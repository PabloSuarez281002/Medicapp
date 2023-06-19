Imports Datos
Public Class FormPrincipalGestion
    Public Property idioma As String
    Dim inicio As New inicioGestion
    Dim gMedicos As New gestionMedicos
    Dim gPacientes As New gestionPacientes
    Dim gAdmins As New gestionAdministradores
    Dim gSintomas As New gestionSintomas
    Dim gPatologias As New gestionPatologias
    Dim asociar As New AsociarSintomasYPatologias
    Dim info As New infoGestion
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
    Private Sub btnAdministradores_Click(sender As Object, e As EventArgs) Handles btnAdministradores.Click
        gAdmins.idioma = idioma
        AbrirForm(gAdmins)
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
    Private Sub btnMédicos_Click(sender As Object, e As EventArgs) Handles btnMedicos.Click
        gMedicos.idioma = idioma
        AbrirForm(gMedicos)
    End Sub
    Private Sub btnPacientes_Click(sender As Object, e As EventArgs) Handles btnPacientes.Click
        gPacientes.idioma = idioma
        AbrirForm(gPacientes)
    End Sub
    Private Sub btnSintomas_Click(sender As Object, e As EventArgs) Handles btnSintomas.Click
        gSintomas.idioma = idioma
        AbrirForm(gSintomas)
    End Sub
    Private Sub btnPatologias_Click(sender As Object, e As EventArgs) Handles btnPatologias.Click
        gPatologias.idioma = idioma
        AbrirForm(gPatologias)
    End Sub
    Private Sub btnAsociarSP_Click(sender As Object, e As EventArgs) Handles btnAsociarSP.Click
        asociar.idioma = idioma
        AbrirForm(asociar)
    End Sub
    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        info.idioma = idioma
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
        btnAdministradores.Text = Traduccion.Traducir("btnAdministradores", idioma)
        btnMedicos.Text = Traduccion.Traducir("btnMedicos", idioma)
        btnPacientes.Text = Traduccion.Traducir("btnPacientes", idioma)
        btnSintomas.Text = Traduccion.Traducir("btnSintomas", idioma)
        btnPatologias.Text = Traduccion.Traducir("btnPatologias", idioma)
        btnAsociarSP.Text = Traduccion.Traducir("btnAsociar", idioma)
        btnInfo.Text = Traduccion.Traducir("btnInfo", idioma)
        btnSalir.Text = Traduccion.Traducir("btnSalir", idioma)

        inicio.idioma = Me.idioma
        inicio.traductor()

        gAdmins.idioma = Me.idioma
        gAdmins.traductor()

        gMedicos.idioma = Me.idioma
        gMedicos.traductor()

        gPacientes.idioma = Me.idioma
        gPacientes.traductor()

        gPatologias.idioma = Me.idioma
        gPatologias.traductor()

        asociar.idioma = Me.idioma
        asociar.traductor()

        info.idioma = Me.idioma
        info.traductor()

    End Sub
    Private Sub cmbIdioma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIdioma.SelectedIndexChanged
        idioma = cmbIdioma.Text
        traductor()
    End Sub
End Class