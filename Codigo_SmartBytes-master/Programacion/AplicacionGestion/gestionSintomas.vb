Imports CapaDeLogica
Imports Datos
Public Class gestionSintomas
    Dim logicaSintomas As LogicaGestionSintomas = New LogicaGestionSintomas
    Public Property idioma As String
    Private Sub btnIS_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If MessageBox.Show(Traduccion.Traducir("msgSeguroAgregarSintoma", idioma), Traduccion.Traducir("msgAtencion", idioma), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim codigo As Integer
                Dim sintomas As List(Of Sintoma) = logicaSintomas.MostrarDatos()
                codigo = sintomas.Last.Codigo + 1
                Dim sintoma As New Sintoma(codigo, nomS.Text)
                If logicaSintomas.IngresarSintoma(sintoma) Then
                    MsgBox(Traduccion.Traducir("msgSintomaIngresado", idioma))
                End If
                MostrarDatos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnMS_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If MessageBox.Show(Traduccion.Traducir("msgSeguroModificarSintoma", idioma), Traduccion.Traducir("msgAtencion", idioma), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim sintoma As New Sintoma(codS.Text, nomS.Text)
                If logicaSintomas.ModificarSintoma(sintoma) Then
                    MsgBox(Traduccion.Traducir("msgSintomaModificado", idioma))
                End If
                MostrarDatos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnES_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If MessageBox.Show(Traduccion.Traducir("msgSeguroEliminarSintoma", idioma), Traduccion.Traducir("msgAtencion", idioma), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim sintoma As New Sintoma(codS.Text, nomS.Text)
                If logicaSintomas.EliminarSintoma(sintoma) Then
                    MsgBox(Traduccion.Traducir("msgSintomaEliminado", idioma))
                End If
                MostrarDatos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnActualizarU_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        MostrarDatos()
    End Sub
    Private Sub gestionSintomas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDatos()
        traductor()
    End Sub
    Private Sub dgvSintomas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSintomas.CellClick
        Try
            Dim dgvData As DataGridViewRow = dgvSintomas.Rows(e.RowIndex)
            codS.Text = dgvData.Cells(0).Value.ToString
            nomS.Text = dgvData.Cells(1).Value.ToString
        Catch ex As Exception
        End Try
    End Sub
    Public Sub MostrarDatos()
        Try
            dgvSintomas.Rows.Clear()
            Dim sintomas As List(Of Sintoma) = logicaSintomas.MostrarDatos()
            Dim i = 0
            For Each sintoma As Sintoma In sintomas
                dgvSintomas.Rows.Add()
                Dim dgvData As DataGridViewRow = dgvSintomas.Rows.Item(i)
                dgvData.Cells(0).Value = sintoma.Codigo
                dgvData.Cells(1).Value = sintoma.Nombre
                i += 1
            Next
        Catch ex As Exception

        End Try
    End Sub
    Public Sub traductor()
        lblCodigo.Text = Traduccion.Traducir("lblCodigo", idioma)
        lblGestionSintomas.Text = Traduccion.Traducir("lblGestionSintomas", idioma)
        lblNombre.Text = Traduccion.Traducir("lblNombre", idioma)
        btnActualizar.Text = Traduccion.Traducir("btnActualizar", idioma)
        btnAgregar.Text = Traduccion.Traducir("btnAgregar", idioma)
        btnEliminar.Text = Traduccion.Traducir("btnEliminar", idioma)
        btnModificar.Text = Traduccion.Traducir("btnModificar", idioma)
    End Sub
End Class