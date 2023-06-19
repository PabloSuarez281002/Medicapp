Imports Datos
Public Class InicioPaciente
    Public Property idioma As String
    Private Sub btnConsulta_Click(sender As Object, e As EventArgs)
        Me.Hide()
        RealizarConsulta.Show()
    End Sub
    Private Sub btnInfo_Click(sender As Object, e As EventArgs)
        infoPaciente.Show()
        Me.Hide()
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        inicioSesion.Close()
    End Sub
    Private Sub InicioPaciente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        inicioSesion.Close()
    End Sub
    Private Sub InicioPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        traductor()
    End Sub
    Public Sub traductor()
        lblBienvenido.Text = Traduccion.Traducir("lblBienvenido", idioma)
    End Sub
End Class