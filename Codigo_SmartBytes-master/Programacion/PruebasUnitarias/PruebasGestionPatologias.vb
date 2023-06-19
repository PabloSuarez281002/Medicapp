Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeLogica
Imports Datos
<TestClass()> Public Class PruebasGestionPatologias
    Dim logicaPatologias As New LogicaGestionPatologías
    <TestMethod()> Public Sub IngresoNombreExistente()
        Dim resultado As Boolean = False
        Try
            Dim patologia As New Patologia(-1, "Asma", "Neumólogo", 3)
            logicaPatologias.IngresarPatologia(patologia)
        Catch ex As Exception
            resultado = True
        End Try
        Assert.AreEqual(True, resultado)
    End Sub
    <TestMethod()> Public Sub IngresarPatologia()
        Dim resultado As Boolean = False
        Dim patologia As New Patologia(-1, "Patología de prueba", "Especialista", 2)
        If logicaPatologias.IngresarPatologia(patologia) Then
            resultado = True
        End If
        If resultado = True Then
            Dim patologias As List(Of Patologia) = logicaPatologias.MostrarDatos
            Dim eliminarPatologia As New Patologia(patologias.Last.Codigo, "Patología de prueba 2", "Especialista", 2)
            logicaPatologias.EliminarPatologia(eliminarPatologia)
        End If
        Assert.AreEqual(True, resultado)
    End Sub
    <TestMethod()> Public Sub ModificarPatologia()
        Dim resultado As Boolean = False
        Dim patologia As New Patologia(1, "Asma", "Neumólogo", 3)
        If logicaPatologias.ModificarPatologia(patologia) Then
            resultado = True
        End If
        Assert.AreEqual(True, resultado)
    End Sub
    <TestMethod()> Public Sub EliminarPatologia()
        Dim resultado As Boolean = False
        Dim patologia As New Patologia(-1, "Patología de prueba 2", "Especialista", 2)
        logicaPatologias.IngresarPatologia(patologia)
        Dim patologias As List(Of Patologia) = logicaPatologias.MostrarDatos
        Dim eliminarPatologia As New Patologia(patologias.Last.Codigo, "Patología de prueba 2", "Especialista", 2)
        If logicaPatologias.EliminarPatologia(eliminarPatologia) Then
            resultado = True
        End If
        Assert.AreEqual(True, resultado)
    End Sub
End Class