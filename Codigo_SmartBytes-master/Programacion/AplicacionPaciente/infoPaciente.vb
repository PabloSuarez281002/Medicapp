Imports CapaDeLogica
Imports Datos
Public Class infoPaciente
    Dim logicaInfo As LogicaInformacion = New LogicaInformacion
    Public Property idioma As String
    Private Sub infoPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDatos()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If MessageBox.Show(Traduccion.Traducir("msgSeguroModificarInfo", idioma), Traduccion.Traducir("msgAtencion", idioma), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim fecha As Date = fechaNac.Text
                Dim formato As String = "yyyy-MM-dd"
                Dim paciente As Paciente = New Paciente(ci.Text, contraseña.Text, nom.Text, primerApe.Text, segundoApe.Text, sexo.Text, tel.Text, calle.Text, esq.Text, numPuerta.Text, fecha.ToString(formato), mail.Text)
                If logicaInfo.ModificarPaciente(paciente) Then
                    MsgBox(Traduccion.Traducir("msgDatosActualizados", idioma))

                End If
            End If
            MostrarDatos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDiagnosticos_Click(sender As Object, e As EventArgs) Handles btnDiagnosticos.Click
        Dim listaD As New ListaDiagnosticos
        listaD.idioma = Me.idioma
        FormPrincipalPaciente.AbrirForm(listaD)
    End Sub

    Public Sub traductor()
        lblCedula.Text = Traduccion.Traducir("lblCedula", idioma)
        lblCalle.Text = Traduccion.Traducir("lblCalle", idioma)
        lblContraseña.Text = Traduccion.Traducir("lblContraseña", idioma)
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
        btnDiagnosticos.Text = Traduccion.Traducir("btnDiagnosticos", idioma)
    End Sub

    Public Sub MostrarDatos()
        Try
            Dim paciente As Paciente = logicaInfo.InfoPaciente(inicioSesion.cedula)
            ci.Text = paciente.Ci
            nom.Text = paciente.PrimerNombre
            primerApe.Text = paciente.PrimerApellido
            segundoApe.Text = paciente.SegundoApellido
            contraseña.Text = paciente.Contraseña
            tel.Text = paciente.Telefono
            sexo.Text = paciente.Sexo
            calle.Text = paciente.Calle
            esq.Text = paciente.Esquina
            numPuerta.Text = paciente.NumeroPuerta
            fechaNac.Text = paciente.FechaNacimiento
            mail.Text = paciente.Mail
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class