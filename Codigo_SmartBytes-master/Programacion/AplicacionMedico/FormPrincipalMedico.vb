Imports Datos
Public Class FormPrincipalMedico
    Public Property idioma As String
    Dim inicio As New InicioMedico
    Dim info As New InfoMedico
    Dim solicitudes As New SolicitudesDeChat
    Private Sub AbrirForm(FormHijo As Object)
        If panelContenedor.Controls.Count > 0 Then
            panelContenedor.Controls.RemoveAt(0)
        End If
        Dim fh As Form = FormHijo
        fh.TopLevel = False
        fh.Dock = DockStyle.Fill
        panelContenedor.Controls.Add(fh)
        panelContenedor.Tag = fh
        fh.Show()
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub FormPrincipalGestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbIdioma.Text = idioma
        inicio.idioma = Me.idioma
        AbrirForm(inicio)
        traductor()
    End Sub
    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        info.idioma = Me.idioma
        AbrirForm(info)
    End Sub
    Private Sub Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show(Traduccion.Traducir("msgSalirApp", idioma), Traduccion.Traducir("msgAtencion", idioma), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            inicioSesion.Close()
            End
        Else
            e.Cancel = True
        End If
    End Sub
    Public Sub traductor()
        btnSolicitudes.Text = Traduccion.Traducir("btnSolicitudes", idioma)
        btnInfo.Text = Traduccion.Traducir("btnInfo", idioma)
        btnSalir.Text = Traduccion.Traducir("btnSalir", idioma)

        inicio.idioma = Me.idioma
        inicio.traductor()

        info.idioma = Me.idioma
        info.traductor()

        solicitudes.idioma = Me.idioma
        solicitudes.traductor()
    End Sub
    Private Sub cmbIdioma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIdioma.SelectedIndexChanged
        idioma = cmbIdioma.Text
        traductor()
    End Sub
    Private Sub btnSolicitudes_Click(sender As Object, e As EventArgs) Handles btnSolicitudes.Click
        solicitudes.idioma = Me.idioma
        AbrirForm(solicitudes)
    End Sub
End Class