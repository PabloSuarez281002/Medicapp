Imports CapaDeLogica
Imports Datos
Public Class inicioSesion
    Dim inicio As LogicaInicioSesion = New LogicaInicioSesion
    Public Shared cedula As String
    Public Property idioma As String
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Try
            If inicio.iniciar(New Inicio(cedulaUsuario.Text, contraseñaUsuario.Text), "Administrador") Then
                cedula = cedulaUsuario.Text
                Dim formPrincipal As New FormPrincipalGestion
                formPrincipal.idioma = idioma
                formPrincipal.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub inicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbIdioma.Text = "ES"
        idioma = "ES"
        traductor()
    End Sub
    Public Sub traductor()
        lblCedula.Text = Traduccion.Traducir("lblCedula", idioma)
        btnIniciar.Text = Traduccion.Traducir("btnIniciar", idioma)
        btnSalir.Text = Traduccion.Traducir("btnSalir", idioma)
        lblContraseña.Text = Traduccion.Traducir("lblContraseña", idioma)
    End Sub
    Private Sub cmbIdioma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIdioma.SelectedIndexChanged
        idioma = cmbIdioma.Text
        traductor()
    End Sub
End Class