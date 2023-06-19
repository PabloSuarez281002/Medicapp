Imports CapaDeLogica
Imports Datos
Public Class gestionPacientes
    Dim logicaGestionUsuarios As LogicaGestionUsuarios = New LogicaGestionUsuarios
    Public Property idioma As String
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If MessageBox.Show(Traduccion.Traducir("msgSeguroAgregarUsuario", idioma), Traduccion.Traducir("msgAtencion", idioma), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim fecha As Date = fechaNac.Text
                Dim formato As String = "yyyy-MM-dd"
                Dim nuevoPaciente As Paciente = New Paciente(ci.Text, contraseña.Text, nom.Text, primerApe.Text, segundoApe.Text, sexo.Text, tel.Text, calle.Text, esq.Text, numPuerta.Text, fecha.ToString(formato), mail.Text)
                If logicaGestionUsuarios.IngresarPaciente(nuevoPaciente) Then
                    MsgBox(Traduccion.Traducir("msgUsuarioIngresado", idioma))
                    mostrarDatos()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If MessageBox.Show(Traduccion.Traducir("msgSeguroModificarUsuario", idioma), Traduccion.Traducir("msgAtencion", idioma), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim fecha As Date = fechaNac.Text
                Dim formato As String = "yyyy-MM-dd"
                Dim pac As Paciente = New Paciente(ci.Text, contraseña.Text, nom.Text, primerApe.Text, segundoApe.Text, sexo.Text, tel.Text, calle.Text, esq.Text, numPuerta.Text, fecha.ToString(formato), mail.Text)
                If logicaGestionUsuarios.ModificarPaciente(pac) Then
                    MsgBox(Traduccion.Traducir("msgUsuarioModificado", idioma))
                End If
                mostrarDatos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If MessageBox.Show(Traduccion.Traducir("msgSeguroEliminarUsuario", idioma), Traduccion.Traducir("msgAtencion", idioma), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim fecha As Date = fechaNac.Text
                Dim formato As String = "yyyy-MM-dd"
                Dim pac As Paciente = New Paciente(ci.Text, contraseña.Text, nom.Text, primerApe.Text, segundoApe.Text, sexo.Text, tel.Text, calle.Text, esq.Text, numPuerta.Text, fecha.ToString(formato), mail.Text)
                If logicaGestionUsuarios.EliminarPaciente(pac) Then
                    MsgBox(Traduccion.Traducir("msgUsuarioEliminadoExito", idioma))
                End If
                mostrarDatos()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub btnActualizarU_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        mostrarDatos()
    End Sub
    Private Sub gestionPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarDatos()
        traductor()
    End Sub
    Public Sub mostrarDatos()
        Try
            dgvUsuarios.Rows.Clear()
            Dim pacientes As List(Of Paciente) = logicaGestionUsuarios.ObtenerPacientes()
            Dim i As Integer = 0
            For Each pac As Paciente In pacientes
                dgvUsuarios.Rows.Add()
                Dim dgvData As DataGridViewRow = dgvUsuarios.Rows.Item(i)
                dgvData.Cells(0).Value = pac.Ci
                dgvData.Cells(1).Value = pac.Contraseña
                dgvData.Cells(2).Value = pac.PrimerNombre
                dgvData.Cells(3).Value = pac.PrimerApellido
                dgvData.Cells(4).Value = pac.SegundoApellido
                dgvData.Cells(5).Value = pac.Telefono
                dgvData.Cells(6).Value = pac.Mail
                dgvData.Cells(7).Value = pac.Sexo
                dgvData.Cells(8).Value = pac.Calle
                dgvData.Cells(9).Value = pac.Esquina
                dgvData.Cells(10).Value = pac.NumeroPuerta
                dgvData.Cells(11).Value = pac.FechaNacimiento
                i += 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgvUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellClick
        Try
            Dim dgvData As DataGridViewRow = dgvUsuarios.Rows(e.RowIndex)
            ci.Text = dgvData.Cells(0).Value.ToString
            contraseña.Text = dgvData.Cells(1).Value.ToString
            nom.Text = dgvData.Cells(2).Value.ToString
            primerApe.Text = dgvData.Cells(3).Value.ToString
            segundoApe.Text = dgvData.Cells(4).Value.ToString
            tel.Text = dgvData.Cells(5).Value.ToString
            mail.Text = dgvData.Cells(6).Value.ToString
            sexo.Text = dgvData.Cells(7).Value.ToString
            calle.Text = dgvData.Cells(8).Value.ToString
            esq.Text = dgvData.Cells(9).Value.ToString
            numPuerta.Text = dgvData.Cells(10).Value.ToString
            fechaNac.Value = dgvData.Cells(11).Value.ToString
        Catch ex As Exception
        End Try
    End Sub
    Private Sub gestionAPacientes_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        inicioGestion.Show()
    End Sub
    Public Sub traductor()
        lblCalle.Text = Traduccion.Traducir("lblCalle", idioma)
        lblCedula.Text = Traduccion.Traducir("lblCedula", idioma)
        lblContraseña.Text = Traduccion.Traducir("lblContraseña", idioma)
        lblEsquina.Text = Traduccion.Traducir("lblEsquina", idioma)
        lblGestionPacientes.Text = Traduccion.Traducir("lblGestionPacientes", idioma)
        lblNacimiento.Text = Traduccion.Traducir("lblNacimiento", idioma)
        lblNombre.Text = Traduccion.Traducir("lblNombre", idioma)
        lblNum.Text = Traduccion.Traducir("lblNum", idioma)
        lblPrimApe.Text = Traduccion.Traducir("lblPrimApe", idioma)
        lblSegApe.Text = Traduccion.Traducir("lblSegApe", idioma)
        lblSexo.Text = Traduccion.Traducir("lblSexo", idioma)
        lblTel.Text = Traduccion.Traducir("lblTel", idioma)
        btnActualizar.Text = Traduccion.Traducir("btnActualizar", idioma)
        btnAgregar.Text = Traduccion.Traducir("btnAgregar", idioma)
        btnEliminar.Text = Traduccion.Traducir("btnEliminar", idioma)
        btnModificar.Text = Traduccion.Traducir("btnModificar", idioma)
    End Sub
End Class