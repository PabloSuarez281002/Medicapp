Imports CapaBaseDeDatos
Imports Datos
Public Class LogicaRealizarConsulta
    Dim conexion As conexionBD = New conexionBD
    Public Function Consultar(listaSintomas As List(Of Sintoma), paciente As Paciente)
        Dim listaPatologias As List(Of Patologia) = conexion.ObtenerPatologias
        Dim patologiaFinal As Patologia = Nothing
        Dim comparador As Double = 0
        For Each patologia As Patologia In listaPatologias
            Dim cantidadCoincidencias = 0
            For Each sintomaPaciente As Sintoma In listaSintomas
                For Each sintomaPatologia As Sintoma In patologia.Sintomas
                    If sintomaPaciente.Codigo = sintomaPatologia.Codigo Then
                        cantidadCoincidencias += 1
                    End If
                Next
            Next
            Dim resultado = cantidadCoincidencias / patologia.Sintomas.Count
            If resultado > comparador Then
                comparador = resultado
                patologiaFinal = patologia
            End If
        Next
        Dim diagnostico As Diagnostico = conexion.RealizarConsulta(patologiaFinal, paciente)
        Return diagnostico
    End Function
    Public Sub Activar(diagnostico As Diagnostico)
        conexion.ActivarEstadoDiagnostico(diagnostico)
    End Sub
    Public Function MostrarPatologia(diagnostico As Diagnostico)
        Dim patologias As List(Of Patologia) = New List(Of Patologia)
        patologias = ObtenerPatologias()
        For Each patologia As Patologia In patologias
            If patologia.Codigo = diagnostico.CodigoPatologiaPrimaria Then
                Return patologia
            End If
        Next
        Return Nothing
    End Function
    Public Function ObtenerPacientes()
        Dim pacientes As List(Of Paciente) = conexion.ObtenerPacientes
        Return pacientes
    End Function
    Public Function ObtenerSintomas()
        Dim sintomas As List(Of Sintoma) = conexion.ObtenerSintomasAsociadosAAlgunaPatologia
        Return sintomas
    End Function
    Public Function ObtenerPatologias()
        Dim patologias As List(Of Patologia) = conexion.ObtenerPatologias
        Return patologias
    End Function
End Class
