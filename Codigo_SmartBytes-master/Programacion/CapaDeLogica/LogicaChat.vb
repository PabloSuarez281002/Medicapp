Imports CapaBaseDeDatos
Imports Datos
Public Class LogicaChat
    Dim conexion As conexionBD = New conexionBD
    Public Function insertarMensaje(mensaje As Mensaje)
        If conexion.IngresarMensaje(mensaje) Then
            Return True
        End If
        Throw New Exception(Traduccion.Traducir("msgErrorEnviarMensaje", Traduccion.Idioma))
    End Function
    Public Function cargarChat(diagnostico As Diagnostico)
        Dim mensajes As List(Of Mensaje) = conexion.ObtenerMensajes(diagnostico)
        Dim usuarios As List(Of Usuario) = conexion.ObtenerNombreUsuarios
        Dim chat As String = ""
        For Each mensaje As Mensaje In mensajes
            Dim nomUsuario = ""
            For Each user As Usuario In usuarios
                If mensaje.Emisor = user.Ci Then
                    nomUsuario = user.PrimerNombre
                End If
            Next
            chat = chat & nomUsuario & ": " & mensaje.Contenido & Environment.NewLine
        Next
        Return chat
    End Function
    Public Sub Desactivar(diagnostico As Diagnostico)
        conexion.DesactivarEstadoDiagnostico(diagnostico)

    End Sub
    Public Function ObtenerMedico(ci As String)
        Dim medicos As List(Of Medico) = conexion.ObtenerMedicos
        For Each medico As Medico In medicos
            If medico.Ci = ci Then
                Return medico
            End If
        Next
        Return Nothing
    End Function
    Public Function MostrarDatos(medico As Medico)
        Dim solicitudes As List(Of Solicitud) = conexion.ObtenerSolicitudes(medico)
        Return solicitudes
    End Function
    Public Sub ModificarMedico(ByVal codDiagnostico As String, ByVal ci As String)
        conexion.ModificarMedicoQueAtiende(codDiagnostico, ci)
    End Sub
    Public Function ObtenerMedicoQueAtiende(codDiagnostico As Integer)
        Dim medico As String = conexion.ObtenerMedicoQueAtiende(codDiagnostico)
        Return medico
    End Function
    Public Function ObtenerPatologiaFinal(diagnostico As Diagnostico)
        Dim diagnosticos As List(Of Diagnostico) = conexion.ObtenerDiagnosticos
        Dim patFinal As Integer
        For Each diag As Diagnostico In diagnosticos
            If diag.Codigo = diagnostico.Codigo Then
                patFinal = diag.CodigoPatologiaFinal
            End If
        Next
        If patFinal > 0 Then
            Dim patologias As List(Of Patologia) = conexion.ObtenerPatologias
            For Each patologia As Patologia In patologias
                If patologia.Codigo = patFinal Then
                    Return patologia.Nombre
                End If
            Next
        End If
        Return "No asignada"
    End Function
    Public Function IngresarPatologiaFinal(solicitud As Solicitud, nomPatologia As String)
        Dim diagnosticos As List(Of Diagnostico) = conexion.ObtenerDiagnosticos()
        Dim patologias As List(Of Patologia) = conexion.ObtenerPatologias

        Dim codPatologia = -1
        For Each patologia As Patologia In patologias
            If patologia.Nombre = nomPatologia Then
                codPatologia = patologia.Codigo
            End If
        Next

        For Each diagnostico As Diagnostico In diagnosticos
            If diagnostico.Codigo = solicitud.CodigoDiagnostico Then
                diagnostico.CodigoPatologiaFinal = codPatologia
                If conexion.ModificarPatologiaFinal(diagnostico) Then
                    Return True
                End If
            End If
        Next
        Return True
    End Function
    Public Function ObtenerPatologias() As List(Of Patologia)
        Return conexion.ObtenerPatologias
    End Function
End Class