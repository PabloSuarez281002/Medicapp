Imports CapaBaseDeDatos
Imports Datos
Public Class LogicaGestionSintomas
    Dim conexion As conexionBD = New conexionBD
    Public Function IngresarSintoma(sintoma As Sintoma)
        If sintoma.Nombre = "" Then
            Throw New Exception(Traduccion.Traducir("msgNombreSintoma", Traduccion.Idioma))
        Else
            If VerificarSintomaExite(sintoma.Nombre) Then
                Throw New Exception(Traduccion.Traducir("msgSintomaYaIngresado", Traduccion.Idioma))
            Else
                If conexion.IngresarSintoma(sintoma) Then
                    Return True
                End If
            End If
        End If
        Throw New Exception(Traduccion.Traducir("msgErrorIngresarSintoma", Traduccion.Idioma))
    End Function
    Public Function ModificarSintoma(sintoma As Sintoma)
        If sintoma.Nombre = "" Then
            Throw New Exception(Traduccion.Traducir("msgNombreSintoma", Traduccion.Idioma))
        ElseIf sintoma.Codigo = Nothing Then
            Throw New Exception(Traduccion.Traducir("msgRellenarCodigo", Traduccion.Idioma))
        Else
            Dim sintomas As List(Of Sintoma) = conexion.ObtenerSintomas
            Dim i = 0
            For Each sint As Sintoma In sintomas
                If sint.Codigo = sintoma.Codigo Then
                    i += 1
                End If
            Next
            If i = 1 Then
                If conexion.ModificarSintoma(sintoma) Then
                    Return True
                End If
            Else
                Throw New Exception(Traduccion.Traducir("msgSintomaNoIngresado", Traduccion.Idioma))
            End If
        End If
        Throw New Exception(Traduccion.Traducir("msgErrorModificarSintoma", Traduccion.Idioma))
    End Function
    Public Function EliminarSintoma(sintoma As Sintoma)
        If sintoma.Codigo = Nothing Then
            Throw New Exception(Traduccion.Traducir("msgRellenarCodigo", Traduccion.Idioma))
        Else
            If Not VerificarSintomaExite(sintoma.Nombre) Then
                Throw New Exception(Traduccion.Traducir("msgSintomaNoIngresado", Traduccion.Idioma))
            End If
            If conexion.EliminarSintoma(sintoma) Then
                    Return True
                End If
            End If
        Throw New Exception(Traduccion.Traducir("msgErrorEliminarSintoma", Traduccion.Idioma))
    End Function
    Public Function MostrarDatos()
        Dim sintomas As List(Of Sintoma) = conexion.ObtenerSintomas()
        Return sintomas
    End Function
    Public Function VerificarSintomaExite(nombre As String)
        Dim sintomas As List(Of Sintoma) = conexion.ObtenerSintomas
        For Each sint As Sintoma In sintomas
            If sint.Nombre = nombre Then
                Return True
            End If
        Next
        Return False
    End Function
End Class