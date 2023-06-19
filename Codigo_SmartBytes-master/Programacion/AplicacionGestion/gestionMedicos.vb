Imports CapaDeLogica
Imports Datos
Public Class gestionMedicos
    Dim logicaGestionUsuarios As LogicaGestionUsuarios = New LogicaGestionUsuarios
    Public Property idioma As String
    Private Sub btnIU_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If MessageBox.Show(Traduccion.Traducir("msgSeguroAgregarUsuario", idioma), Traduccion.Traducir("msgAtencion", idioma), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim fecha As Date = fechaNac.Text
                Dim formato As String = "yyyy-MM-dd"
                Dim NuevoMedico As Medico = New Medico(ci.Text, contraseña.Text, nom.Text, primerApe.Text, segundoApe.Text, sexo.Text, tel.Text, calle.Text, esq.Text, numPuerta.Text, fecha.ToString(formato), mail.Text, especialidad.Text)
                If logicaGestionUsuarios.IngresarMedico(NuevoMedico) Then
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
                Dim medico As Medico = New Medico(ci.Text, contraseña.Text, nom.Text, primerApe.Text, segundoApe.Text, sexo.Text, tel.Text, calle.Text, esq.Text, numPuerta.Text, fecha.ToString(formato), mail.Text, especialidad.Text)
                If logicaGestionUsuarios.ModificarMedico(medico) Then
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
                Dim medico As Medico = New Medico(ci.Text, contraseña.Text, nom.Text, primerApe.Text, segundoApe.Text, sexo.Text, tel.Text, calle.Text, esq.Text, numPuerta.Text, fecha.ToString(formato), mail.Text, especialidad.Text)
                If logicaGestionUsuarios.EliminarMedico(medico) Then
                    MsgBox(Traduccion.Traducir("msgUsuarioEliminadoExito", idioma))
                End If
                mostrarDatos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnCancelarIU_Click(sender As Object, e As EventArgs) 
        Me.Close()
    End Sub
    Private Sub btnActualizarU_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        mostrarDatos()
    End Sub
    Private Sub gestionMedicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarDatos()
        traductor()
    End Sub
    Public Sub mostrarDatos()
        dgvUsuarios.Rows.Clear()
        Dim medicos As List(Of Medico) = logicaGestionUsuarios.ObtenerMedicos()
        Dim i As Integer = 0
        For Each medico As Medico In medicos
            dgvUsuarios.Rows.Add()
            Dim dgvData As DataGridViewRow = dgvUsuarios.Rows.Item(i)
            dgvData.Cells(0).Value = medico.Ci
            dgvData.Cells(1).Value = medico.Contraseña
            dgvData.Cells(2).Value = medico.PrimerNombre
            dgvData.Cells(3).Value = medico.PrimerApellido
            dgvData.Cells(4).Value = medico.SegundoApellido
            dgvData.Cells(5).Value = medico.Especialidad
            dgvData.Cells(6).Value = medico.Telefono
            dgvData.Cells(7).Value = medico.Mail
            dgvData.Cells(8).Value = medico.Sexo
            dgvData.Cells(9).Value = medico.Calle
            dgvData.Cells(10).Value = medico.Esquina
            dgvData.Cells(11).Value = medico.NumeroPuerta
            dgvData.Cells(12).Value = medico.FechaNacimiento
            i += 1
        Next
    End Sub
    Private Sub dgvUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellClick
        Try
            Dim dgvData As DataGridViewRow = dgvUsuarios.Rows(e.RowIndex)
            ci.Text = dgvData.Cells(0).Value.ToString
            contraseña.Text = dgvData.Cells(1).Value.ToString
            nom.Text = dgvData.Cells(2).Value.ToString
            primerApe.Text = dgvData.Cells(3).Value.ToString
            segundoApe.Text = dgvData.Cells(4).Value.ToString
            especialidad.Text = dgvData.Cells(5).Value.ToString
            tel.Text = dgvData.Cells(6).Value.ToString
            mail.Text = dgvData.Cells(7).Value.ToString
            sexo.Text = dgvData.Cells(8).Value.ToString
            calle.Text = dgvData.Cells(9).Value.ToString
            esq.Text = dgvData.Cells(10).Value.ToString
            numPuerta.Text = dgvData.Cells(11).Value.ToString
            fechaNac.Value = dgvData.Cells(12).Value.ToString
        Catch ex As Exception

        End Try
    End Sub
    Private Sub gestionMedicos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        inicioGestion.Show()
    End Sub
    Public Sub traductor()
        lblCalle.Text = Traduccion.Traducir("lblCalle", idioma)
        lblCedula.Text = Traduccion.Traducir("lblCedula", idioma)
        lblContraseña.Text = Traduccion.Traducir("lblContraseña", idioma)
        lblEsquina.Text = Traduccion.Traducir("lblEsquina", idioma)
        lblGestionMedicos.Text = Traduccion.Traducir("lblGestionMedicos", idioma)
        lblNacimiento.Text = Traduccion.Traducir("lblNacimiento", idioma)
        lblNombre.Text = Traduccion.Traducir("lblNombre", idioma)
        lblNum.Text = Traduccion.Traducir("lblNum", idioma)
        lblPrimApe.Text = Traduccion.Traducir("lblPrimApe", idioma)
        lblSegApe.Text = Traduccion.Traducir("lblSegApe", idioma)
        lblEspecialidad.Text = Traduccion.Traducir("lblEspecialidad", idioma)
        lblSexo.Text = Traduccion.Traducir("lblSexo", idioma)
        lblTel.Text = Traduccion.Traducir("lblTel", idioma)
        btnActualizar.Text = Traduccion.Traducir("btnActualizar", idioma)
        btnAgregar.Text = Traduccion.Traducir("btnAgregar", idioma)
        btnEliminar.Text = Traduccion.Traducir("btnEliminar", idioma)
        btnModificar.Text = Traduccion.Traducir("btnModificar", idioma)
    End Sub
End Class