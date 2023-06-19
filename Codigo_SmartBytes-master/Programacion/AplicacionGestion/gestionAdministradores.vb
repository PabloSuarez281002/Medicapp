Imports CapaDeLogica
Imports Datos
Public Class gestionAdministradores
    Public Property idioma As String
    Dim logicaGestionUsuarios As LogicaGestionUsuarios = New LogicaGestionUsuarios
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If MessageBox.Show(Traduccion.Traducir("msgSeguroAgregarUsuario", idioma), Traduccion.Traducir("msgAtencion", idioma), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim fecha As Date = fechaNac.Text
                Dim formato As String = "yyyy-MM-dd"
                Dim nuevoAdmin As Administrador = New Administrador(ci.Text, contraseña.Text, nom.Text, primerApe.Text, segundoApe.Text, sexo.Text, tel.Text, calle.Text, esq.Text, numPuerta.Text, fecha.ToString(formato), mail.Text)
                If logicaGestionUsuarios.IngresarAdministrador(nuevoAdmin) Then
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
                Dim admin As Administrador = New Administrador(ci.Text, contraseña.Text, nom.Text, primerApe.Text, segundoApe.Text, sexo.Text, tel.Text, calle.Text, esq.Text, numPuerta.Text, fecha.ToString(formato), mail.Text)
                If logicaGestionUsuarios.ModificarAdministrador(admin) Then
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
                Dim admin As Administrador = New Administrador(ci.Text, contraseña.Text, nom.Text, primerApe.Text, segundoApe.Text, sexo.Text, tel.Text, calle.Text, esq.Text, numPuerta.Text, fecha.ToString(formato), mail.Text)
                If logicaGestionUsuarios.EliminarAdministrador(admin) Then
                    MsgBox(Traduccion.Traducir("msgUsuarioEliminadoExito", idioma))
                End If
                mostrarDatos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub gestionAdministradores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarDatos()
        traductor()
    End Sub
    Public Sub mostrarDatos()
        dgvUsuarios.Rows.Clear()
        Dim administradores As List(Of Administrador) = logicaGestionUsuarios.ObtenerAdministradores()
        Dim i As Integer = 0
        For Each admin As Administrador In administradores
            dgvUsuarios.Rows.Add()
            Dim dgvData As DataGridViewRow = dgvUsuarios.Rows.Item(i)
            dgvData.Cells(0).Value = admin.Ci
            dgvData.Cells(1).Value = admin.Contraseña
            dgvData.Cells(2).Value = admin.PrimerNombre
            dgvData.Cells(3).Value = admin.PrimerApellido
            dgvData.Cells(4).Value = admin.SegundoApellido
            dgvData.Cells(5).Value = admin.Telefono
            dgvData.Cells(6).Value = admin.Mail
            dgvData.Cells(7).Value = admin.Sexo
            dgvData.Cells(8).Value = admin.Calle
            dgvData.Cells(9).Value = admin.Esquina
            dgvData.Cells(10).Value = admin.NumeroPuerta
            dgvData.Cells(11).Value = admin.FechaNacimiento
            i += 1
        Next
    End Sub
    Private Sub btnActualizarU_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        mostrarDatos()
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
    Public Sub traductor()
        lblCalle.Text = Traduccion.Traducir("lblCalle", idioma)
        lblCedula.Text = Traduccion.Traducir("lblCedula", idioma)
        lblContraseña.Text = Traduccion.Traducir("lblContraseña", idioma)
        lblEsquina.Text = Traduccion.Traducir("lblEsquina", idioma)
        lblGestionAdmins.Text = Traduccion.Traducir("lblGestionAdmins", idioma)
        lblNacimiento.Text = Traduccion.Traducir("lblNacimiento", idioma)
        lblNombre.Text = Traduccion.Traducir("lblNombre", idioma)
        lblNum.Text = Traduccion.Traducir("lblNum", idioma)
        lblPrimApe.Text = Traduccion.Traducir("lblPrimApe", idioma)
        lblSexo.Text = Traduccion.Traducir("lblSexo", idioma)
        lblTel.Text = Traduccion.Traducir("lblTel", idioma)
        btnActualizar.Text = Traduccion.Traducir("btnActualizar", idioma)
        btnAgregar.Text = Traduccion.Traducir("btnAgregar", idioma)
        btnEliminar.Text = Traduccion.Traducir("btnEliminar", idioma)
        btnModificar.Text = Traduccion.Traducir("btnModificar", idioma)
    End Sub

End Class