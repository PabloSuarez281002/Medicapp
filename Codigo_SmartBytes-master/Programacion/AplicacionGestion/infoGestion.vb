Imports CapaDeLogica
Imports Datos
Public Class infoGestion
    Public Property idioma As String
    Dim logicaInfo As LogicaInformacion = New LogicaInformacion
    Private Sub infoGestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDatos()
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If MessageBox.Show(Traduccion.Traducir("msgSeguroModificarInfo", idioma), Traduccion.Traducir("msgAtencion", idioma), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim fecha As Date = fechaNac.Text
                Dim formato As String = "yyyy-MM-dd"
                Dim admin As Administrador = New Administrador(ci.Text, contraseña.Text, nom.Text, primerApe.Text, segundoApe.Text, sexo.Text, tel.Text, calle.Text, esq.Text, numPuerta.Text, fecha.ToString(formato), mail.Text)
                If logicaInfo.ModificarAdministrador(admin) Then
                    MsgBox(Traduccion.Traducir("msgDatosActualizados", idioma))
                    MostrarDatos()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub traductor()
        lblCalle.Text = Traduccion.Traducir("lblCalle", idioma)
        lblCedula.Text = Traduccion.Traducir("lblCedula", idioma)
        lblContraseña.Text = Traduccion.Traducir("lblContraseña", idioma)
        lblEsquina.Text = Traduccion.Traducir("lblEsquina", idioma)
        btnInfo.Text = Traduccion.Traducir("btnInfo", idioma)
        lblNacimiento.Text = Traduccion.Traducir("lblNacimiento", idioma)
        lblNombre.Text = Traduccion.Traducir("lblNombre", idioma)
        lblNum.Text = Traduccion.Traducir("lblNum", idioma)
        lblPrimApe.Text = Traduccion.Traducir("lblPrimApe", idioma)
        lblSegApe.Text = Traduccion.Traducir("lblSegApe", idioma)
        lblSexo.Text = Traduccion.Traducir("lblSexo", idioma)
        lblTel.Text = Traduccion.Traducir("lblTel", idioma)
        btnModificar.Text = Traduccion.Traducir("btnModificar", idioma)
    End Sub
    Public Sub MostrarDatos()
        Try
            Dim admin As Administrador = logicaInfo.InfoAdmin(inicioSesion.cedula)
            ci.Text = admin.Ci
            nom.Text = admin.PrimerNombre
            primerApe.Text = admin.PrimerApellido
            segundoApe.Text = admin.SegundoApellido
            contraseña.Text = admin.Contraseña
            tel.Text = admin.Telefono
            sexo.Text = admin.Sexo
            calle.Text = admin.Calle
            esq.Text = admin.Esquina
            numPuerta.Text = admin.NumeroPuerta
            fechaNac.Text = admin.FechaNacimiento
            mail.Text = admin.Mail
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class