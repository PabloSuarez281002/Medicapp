Imports CapaDeLogica
Imports Datos
Public Class gestionPatologias
    Public Property idioma As String
    Dim logicaPatologias As LogicaGestionPatologías = New LogicaGestionPatologías
    Private Sub btnIP_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If MessageBox.Show(Traduccion.Traducir("msgSeguroAgregarPatologia", idioma), Traduccion.Traducir("msgAtencion", idioma), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim codigo As Integer
                Dim patologias As List(Of Patologia) = logicaPatologias.MostrarDatos()
                codigo = patologias.Last.Codigo + 1
                Dim pat As New Patologia(codigo, nomP.Text, espP.Text, gravP.Text)
                If logicaPatologias.IngresarPatologia(pat) Then
                    MsgBox(Traduccion.Traducir("msgPatologiaIngresada", idioma))
                End If
                MostrarDatos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnMP_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If MessageBox.Show(Traduccion.Traducir("msgSeguroModificarPatologia", idioma), Traduccion.Traducir("msgAtencion", idioma), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim pat As New Patologia(codP.Text, nomP.Text, espP.Text, gravP.Text)
                If logicaPatologias.ModificarPatologia(pat) Then
                    MsgBox(Traduccion.Traducir("msgPatologiaModificada", idioma))
                End If
                MostrarDatos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnEP_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If MessageBox.Show(Traduccion.Traducir("msgSeguroEliminarPatologia", idioma), Traduccion.Traducir("msgAtencion", idioma), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim pat As New Patologia(codP.Text, nomP.Text, espP.Text, gravP.Text)
                If logicaPatologias.EliminarPatologia(pat) Then
                    MsgBox(Traduccion.Traducir("msgPatologiaEliminada", idioma))
                End If
                MostrarDatos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnCancelarP_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub btnActualizarP_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        MostrarDatos()
    End Sub
    Private Sub gestionPatologias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDatos()
    End Sub
    Public Sub MostrarDatos()
        Try
            dgvPatologia.Rows.Clear()
            Dim patologias As List(Of Patologia) = logicaPatologias.MostrarDatos()
            Dim i As Integer = 0
            For Each patologia As Patologia In patologias
                dgvPatologia.Rows.Add()
                Dim dgvData As DataGridViewRow = dgvPatologia.Rows.Item(i)
                dgvData.Cells(0).Value = patologia.Codigo
                dgvData.Cells(1).Value = patologia.Nombre
                dgvData.Cells(2).Value = patologia.Especialista
                dgvData.Cells(3).Value = patologia.Gravedad
                i += 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgvPatologia_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPatologia.CellClick
        Try
            Dim dgvData As DataGridViewRow = dgvPatologia.Rows(e.RowIndex)
            codP.Text = dgvData.Cells(0).Value.ToString
            nomP.Text = dgvData.Cells(1).Value.ToString
            espP.Text = dgvData.Cells(2).Value.ToString
            gravP.Text = dgvData.Cells(3).Value.ToString
        Catch ex As Exception

        End Try
    End Sub
    Private Sub gestionPatologias_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        inicioGestion.Show()
    End Sub
    Public Sub traductor()
        btnActualizar.Text = Traduccion.Traducir("btnActualizar", idioma)
        btnAgregar.Text = Traduccion.Traducir("btnAgregar", idioma)
        btnEliminar.Text = Traduccion.Traducir("btnEliminar", idioma)
        btnModificar.Text = Traduccion.Traducir("btnModificar", idioma)
        lblCodigo.Text = Traduccion.Traducir("lblCodigo", idioma)
        lblEspecialista.Text = Traduccion.Traducir("lblEspecialista", idioma)
        lblGestionPatologias.Text = Traduccion.Traducir("lblGestionPatologias", idioma)
        lblGravedad.Text = Traduccion.Traducir("lblGravedad", idioma)
        lblNombre.Text = Traduccion.Traducir("lblNombre", idioma)
    End Sub
End Class