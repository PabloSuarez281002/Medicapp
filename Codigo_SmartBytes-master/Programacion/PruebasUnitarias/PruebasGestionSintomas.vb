Imports CapaDeLogica
Imports Datos
<TestClass()> Public Class PruebasGestionSintomas
    Dim logicaSintomas As New LogicaGestionSintomas
    <TestMethod()> Public Sub PruebaSintomaSinNombre()
        Dim sintoma As New Sintoma(200, "")
        Dim resultado As Boolean = False
        Try
            logicaSintomas.IngresarSintoma(sintoma)
        Catch ex As Exception
            resultado = True
        End Try
        Assert.AreEqual(True, resultado)
    End Sub
    <TestMethod()> Public Sub PruebaSintomaNombreNothing()
        Dim sintoma As New Sintoma(200, Nothing)
        Dim resultado As Boolean = False
        Try
            logicaSintomas.IngresarSintoma(sintoma)
        Catch ex As Exception
            resultado = True
        End Try
        Assert.AreEqual(True, resultado)
    End Sub
    <TestMethod()> Public Sub SintomaNombreRepetido()
        Dim sintoma As New Sintoma(200, "Tos")
        Dim resultado As Boolean = False
        Try
            logicaSintomas.IngresarSintoma(sintoma)
        Catch ex As Exception
            resultado = True
        End Try
        Assert.AreEqual(True, resultado)
    End Sub
    <TestMethod()> Public Sub IngresarSintoma()
        Dim resultado As Boolean = False
        Dim sintoma As New Sintoma(-1, "Sintoma De Prueba")
        If logicaSintomas.VerificarSintomaExite(sintoma.Nombre) Then
            If logicaSintomas.IngresarSintoma(sintoma) Then
                resultado = True
            End If
            Assert.AreEqual(True, resultado)
            If resultado = True Then
                logicaSintomas.EliminarSintoma(sintoma)
            End If
        End If
    End Sub
    <TestMethod()> Public Sub ModificarSintoma()
        Dim resultado As Boolean = False
        Dim sintoma As New Sintoma(1, "Tos fuerte")
        If logicaSintomas.ModificarSintoma(sintoma) Then
            resultado = True
        End If
        Assert.AreEqual(True, resultado)
        Dim restaurarSintoma As New Sintoma(1, "Tos")
        logicaSintomas.ModificarSintoma(restaurarSintoma)
    End Sub
    <TestMethod()> Public Sub EliminarSintoma()
        Dim resultado As Boolean = False
        Dim sintoma As New Sintoma(-1, "Sintoma De Prueba")
        logicaSintomas.IngresarSintoma(sintoma)
        Dim sintomas As List(Of Sintoma) = logicaSintomas.MostrarDatos
        Dim codigoSintoma = sintomas.Last.Codigo
        Dim sintomaEliminar As New Sintoma(codigoSintoma, sintoma.Nombre)
        If logicaSintomas.EliminarSintoma(sintomaEliminar) Then
            resultado = True
        End If
        Assert.AreEqual(True, resultado)
    End Sub
End Class