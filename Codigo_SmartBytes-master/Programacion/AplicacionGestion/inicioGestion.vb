Imports Datos
Public Class inicioGestion
    Public Property idioma As String
    Private Sub inicioGestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim formato As String = "dd/MM/yyyy"
        labelFecha.Text = DateTime.Now.ToString(formato)
        traductor()
    End Sub
    Public Sub traductor()
        lblBienvenido.Text = Traduccion.Traducir("lblBienvenido", idioma)
        lblBuenaJornada.Text = Traduccion.Traducir("lblBuenaJornada", idioma)
    End Sub
End Class