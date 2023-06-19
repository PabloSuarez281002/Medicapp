Imports CapaBaseDeDatos
Imports Datos
Public Class LogicaGestionPatologías
    Dim conexion As conexionBD = New conexionBD
    Public Function IngresarPatologia(patologia As Patologia)
        If DatosVacios(patologia.Nombre) Or DatosVacios(patologia.Especialista) Then
            Throw New Exception(Traduccion.Traducir("msgRellenarCampos", Traduccion.Idioma))
        Else
            Dim patologias As List(Of Patologia) = conexion.ObtenerPatologias
            For Each pat As Patologia In patologias
                If patologia.Nombre = pat.Nombre Then
                    Throw New Exception(Traduccion.Traducir("msgPatologiaYaIngresada", Traduccion.Idioma))
                End If
            Next
            If conexion.IngresarPatologia(patologia) Then
                Return True
            Else
                Throw New Exception(Traduccion.Traducir("msgErrorIngresarPatologia", Traduccion.Idioma))
            End If
        End If
    End Function
    Public Function ModificarPatologia(patologia As Patologia)
        If DatosVacios(patologia.Codigo) Or DatosVacios(patologia.Especialista) Or DatosVacios(patologia.Especialista) Then
            Throw New Exception(Traduccion.Traducir("msgRellenarCampos", Traduccion.Idioma))
        ElseIf patologia.Gravedad > 5 Or patologia.Gravedad < 1 Then
            Throw New Exception(Traduccion.Traducir("msgGravedadMenor5", Traduccion.Idioma))
        Else
            Dim patologias As List(Of Patologia) = conexion.ObtenerPatologias
            Dim i = 0
            For Each pat As Patologia In patologias
                If pat.Codigo = patologia.Codigo Then
                    i += 1
                End If
            Next
            If i = 1 Then
                If conexion.ModificarPatologia(patologia) Then
                    Return True
                End If
            Else
                Throw New Exception(Traduccion.Traducir("msgPatologiaNoIngresada", Traduccion.Idioma))
            End If
        End If
        Throw New Exception(Traduccion.Traducir("msgErrorModificarPatologia", Traduccion.Idioma))
    End Function
    Public Function EliminarPatologia(patologia As Patologia)
        If DatosVacios(patologia.Codigo) Then
            Throw New Exception(Traduccion.Traducir("msgRellenarCodigo", Traduccion.Idioma))
        Else
            Dim patologias As List(Of Patologia) = conexion.ObtenerPatologias
            Dim i = 0
            For Each pat As Patologia In patologias
                If pat.Codigo = patologia.Codigo Then
                    i += 1
                End If
            Next
            If i = 1 Then
                If conexion.EliminarPatologia(patologia) Then
                    Return True
                End If
            End If
        End If
        Throw New Exception(Traduccion.Traducir("msgErrorEliminarPatologia", Traduccion.Idioma))
    End Function
    Public Function MostrarDatos() As List(Of Patologia)
        Dim patologias As List(Of Patologia) = conexion.ObtenerPatologias
        Return patologias
    End Function
    Public Function DatosVacios(dato As String)
        If dato = "" Then
            Return True
        Else
            Return False
        End If
    End Function
End Class