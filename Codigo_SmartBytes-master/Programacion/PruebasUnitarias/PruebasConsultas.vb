Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeLogica
Imports Datos
<TestClass()> Public Class PruebasConsultas
    Dim logicaConsulta As New LogicaRealizarConsulta
    <TestMethod()> Public Sub PruebRealizarConsultaCoronavirus()
        Dim resultado As Boolean = False
        Dim pacientes As List(Of Paciente) = logicaConsulta.ObtenerPacientes
        Dim sintomas As New List(Of Sintoma)
        Dim fatiga As New Sintoma(3, "Fatiga")
        sintomas.Add(fatiga)
        Dim fiebre As New Sintoma(21, "Fiebre")
        sintomas.Add(fiebre)
        Dim tos_seca As New Sintoma(159, "Tos seca")
        sintomas.Add(tos_seca)
        Dim diagnostico As Diagnostico = logicaConsulta.Consultar(sintomas, pacientes.Last)
        MsgBox(diagnostico.CodigoPatologiaPrimaria)
        If diagnostico.CodigoPatologiaPrimaria = 52 Then
            resultado = True
        End If
        Assert.AreEqual(True, resultado)
    End Sub
End Class