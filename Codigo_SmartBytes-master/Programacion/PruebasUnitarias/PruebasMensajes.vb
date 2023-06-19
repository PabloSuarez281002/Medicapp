Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeLogica
Imports Datos
<TestClass()> Public Class PruebasMensajes
    Dim logicaChat As New LogicaChat
    <TestMethod()> Public Sub PruebaEnviarMensaje()
        Dim resultado As Boolean = False
        Dim mensaje As New Mensaje(-1, "Mensaje de prueba", "57200277", DateTime.Now, "1")
        If logicaChat.insertarMensaje(mensaje) Then
            resultado = True
        End If
        Assert.AreEqual(True, resultado)
    End Sub
End Class