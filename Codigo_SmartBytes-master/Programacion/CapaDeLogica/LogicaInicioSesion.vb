Imports CapaBaseDeDatos
Imports Datos
Public Class LogicaInicioSesion
    Dim conexion As conexionBD = New conexionBD
    Public Function iniciar(datos As inicio, tipo As String)
        If datos.Ci.Length = 0 Then
            Throw New Exception(Traduccion.Traducir("msgIngresarCedula", Traduccion.Idioma))
        ElseIf datos.Contraseña.Length = 0 Then
            Throw New Exception(Traduccion.Traducir("msgIngresarContraseña", Traduccion.Idioma))
        Else
            If conexion.Inicio(datos, tipo) Then
                Return True
            Else
                Throw New Exception(Traduccion.Traducir("msgErrorIniciar", Traduccion.Idioma))
            End If
        End If
    End Function
End Class