Imports CapaDeLogica
Imports Datos
Public Class InicioMedico
    Dim logicaInfo As LogicaInformacion = New LogicaInformacion
    Public Property idioma As String
    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub btnInfo_Click(sender As Object, e As EventArgs)
        InfoMedico.Show()
        Me.Hide()
    End Sub
    Private Sub btnChats_Click(sender As Object, e As EventArgs)
        SolicitudesDeChat.Show()
        Me.Hide()
    End Sub
    Private Sub InicioMedico_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        inicioSesion.Close()
    End Sub
    Private Sub InicioMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        traductor()
    End Sub
    Public Sub traductor()
        lblBienvenido.Text = Traduccion.Traducir("lblBienvenido", idioma)
        lblBuenaJornada.Text = Traduccion.Traducir("lblBuenaJornada", idioma)
    End Sub
End Class