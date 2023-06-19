Imports Datos
Public Class FormPrincipalPaciente
    Public Property idioma As String
    Public inicio As New InicioPaciente
    Dim info As New infoPaciente
    Dim realizarConsulta As New RealizarConsulta
    Public Sub AbrirForm(FormHijo As Object)
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
        btnInfo.Text = Traduccion.Traducir("btnInfo", idioma)
        btnRC.Text = Traduccion.Traducir("btnRC", idioma)
        btnSalir.Text = Traduccion.Traducir("btnSalir", idioma)

        inicio.idioma = Me.idioma
        inicio.traductor()

        info.idioma = Me.idioma
        info.traductor()

        realizarConsulta.idioma = Me.idioma
        realizarConsulta.traductor()
    End Sub
    Private Sub cmbIdioma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIdioma.SelectedIndexChanged
        idioma = cmbIdioma.Text
        traductor()
    End Sub
    Private Sub btnRC_Click(sender As Object, e As EventArgs) Handles btnRC.Click
        realizarConsulta.idioma = Me.idioma
        AbrirForm(realizarConsulta)
    End Sub
End Class