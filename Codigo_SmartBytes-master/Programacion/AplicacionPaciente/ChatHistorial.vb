Imports CapaDeLogica
Imports Datos
Public Class ChatHistorial
    Public Property idioma As String
    Dim logicaChat As LogicaChat = New LogicaChat
    Public Property Diagnostico As Diagnostico
    Private Sub ChatHistorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtChat.Text = logicaChat.cargarChat(Diagnostico)
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub
    Public Sub traductor()
        btnVolver.Text = Traduccion.Traducir("btnVolver", idioma)
        lblMedico.Text = Traduccion.Traducir("lblMedico", idioma)
        lblUsuario.Text = Traduccion.Traducir("lblUsuario", idioma)
    End Sub
End Class