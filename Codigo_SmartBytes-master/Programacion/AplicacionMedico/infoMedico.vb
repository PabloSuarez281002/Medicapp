Imports CapaDeLogica
Imports Datos
Public Class InfoMedico
    Dim logicaInfo As LogicaInformacion = New LogicaInformacion
    Public Property idioma As String
    Private Sub InfoMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDatos()
        traductor()
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub btnModificar_Click_1(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If MessageBox.Show(Traduccion.Traducir("msgSeguroModificarInfo", idioma), Traduccion.Traducir("msgAtencion", idioma), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim fecha As Date = fechaNac.Text
                Dim formato As String = "yyyy-MM-dd"
                Dim medico As Medico = New Medico(ci.Text, contraseña.Text, nom.Text, primerApe.Text, segundoApe.Text, sexo.Text, tel.Text, calle.Text, esq.Text, numPuerta.Text, fecha.ToString(formato), mail.Text, especialidad.Text)
                If logicaInfo.ModificarMedico(medico) Then
                    Throw New Exception(Traduccion.Traducir("msgUsuarioModificado", idioma))
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Public Sub traductor()
        lblCedula.Text = Traduccion.Traducir("lblCedula", idioma)
        lblCalle.Text = Traduccion.Traducir("lblCalle", idioma)
        lblContraseña.Text = Traduccion.Traducir("lblContraseña", idioma)
        lblEspecialidad.Text = Traduccion.Traducir("lblEspecialidad", idioma)
        lblEsquina.Text = Traduccion.Traducir("lblEsquina", idioma)
        lblNacimiento.Text = Traduccion.Traducir("lblNacimiento", idioma)
        lblNombre.Text = Traduccion.Traducir("lblNombre", idioma)
        lblNum.Text = Traduccion.Traducir("lblNum", idioma)
        lblPrimApe.Text = Traduccion.Traducir("lblPrimApe", idioma)
        lblSegApe.Text = Traduccion.Traducir("lblSegApe", idioma)
        lblSexo.Text = Traduccion.Traducir("lblSexo", idioma)
        lblTel.Text = Traduccion.Traducir("lblTel", idioma)
        btnModificar.Text = Traduccion.Traducir("btnModificar", idioma)
        btnInfo.Text = Traduccion.Traducir("btnInfo", idioma)
    End Sub
    Public Sub MostrarDatos()
        Try
            Dim medico As Medico
            medico = logicaInfo.InfoMedico(inicioSesion.cedula)
            ci.Text = medico.Ci
            nom.Text = medico.PrimerNombre
            primerApe.Text = medico.PrimerApellido
            segundoApe.Text = medico.SegundoApellido
            contraseña.Text = medico.Contraseña
            tel.Text = medico.Telefono
            sexo.Text = medico.Sexo
            calle.Text = medico.Calle
            esq.Text = medico.Esquina
            numPuerta.Text = medico.NumeroPuerta
            fechaNac.Text = medico.FechaNacimiento
            especialidad.Text = medico.Especialidad
            mail.Text = medico.Mail
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class