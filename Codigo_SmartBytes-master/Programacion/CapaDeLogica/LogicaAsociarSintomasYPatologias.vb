Imports CapaBaseDeDatos
Imports Datos
Public Class LogicaAsociarSintomasYPatologias
    Dim conexion As conexionBD = New conexionBD
    Public Function Asociar(patologia As Patologia, sintoma As Sintoma)
        Dim patologias As List(Of Patologia) = New List(Of Patologia)
        patologias = ObtenerPatologias()
        For Each pat As Patologia In patologias
            If pat.Codigo = patologia.Codigo Then
                patologia = pat
            End If
        Next
        For Each sint As Sintoma In patologia.Sintomas
            If sint.Codigo = sintoma.Codigo Then
                Throw New Exception(Traduccion.Traducir("msgYaAsociado", Traduccion.Idioma))
            End If
        Next
        If conexion.Asociar(patologia, sintoma) Then
            Return True
        Else
            Throw New Exception(Traduccion.Traducir("msgErrorAsociar", Traduccion.Idioma))
        End If
    End Function
    Public Function Desasociar(patologia As Patologia, sintoma As Sintoma)
        Dim patologias As List(Of Patologia) = New List(Of Patologia)
        patologias = ObtenerPatologias()
        For Each pat As Patologia In patologias
            If pat.Codigo = patologia.Codigo Then
                patologia = pat
            End If
        Next
        Dim i = 0
        Dim cantidadSintomas = patologia.Sintomas.Count
        For Each sint As Sintoma In patologia.Sintomas
            If sint.Codigo = sintoma.Codigo Then
                i += 1
            End If
        Next
        If i = 0 Then
            Throw New Exception(Traduccion.Traducir("msgNoAsociado", Traduccion.Idioma))
        Else
            If conexion.Desasociar(patologia, sintoma) Then
                Return True
            Else
                Throw New Exception(Traduccion.Traducir("msgErrorDesasociar", Traduccion.Idioma))
            End If
        End If
    End Function
    Public Function ObtenerPatologias()
        Dim listaPatologias As List(Of Patologia) = New List(Of Patologia)
        listaPatologias = conexion.ObtenerPatologias()
        Return listaPatologias
    End Function
    Public Function ObtenerSintomas()
        Dim listaSintomas As List(Of Sintoma) = New List(Of Sintoma)
        listaSintomas = conexion.ObtenerSintomas()
        Return listaSintomas
    End Function
End Class