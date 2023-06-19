Imports CapaDeLogica
Imports Datos
Public Class AsociarSintomasYPatologias
    Public Property idioma As String
    Dim logicaAsociar As LogicaAsociarSintomasYPatologias = New LogicaAsociarSintomasYPatologias
    Private Sub AsociarSintomasYPatologias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboboxs()
        ActualizarTabla()
        traductor()
    End Sub
    Public Sub LlenarComboboxs()
        Try
            Dim listaSintomas As List(Of Sintoma) = New List(Of Sintoma)
            listaSintomas = logicaAsociar.ObtenerSintomas
            cmbSintoma.Items.Clear()
            For Each sintoma As Sintoma In listaSintomas
                cmbSintoma.Items.Add(sintoma.Nombre)
            Next
            cmbSintoma.Sorted = True

            Dim listaPatologias As List(Of Patologia) = New List(Of Patologia)
            listaPatologias = logicaAsociar.ObtenerPatologias
            cmbPatologia.Items.Clear()
            For Each patologia As Patologia In listaPatologias
                cmbPatologia.Items.Add(patologia.Nombre)
            Next
            cmbPatologia.Sorted = True
            If cmbPatologia.SelectedIndex Then
            Else
                Dim patologiaSeleccionada As Patologia = cmbPatologia.SelectedItem
                Dim i = 0
                For Each sintoma As Sintoma In patologiaSeleccionada.Sintomas
                    Dim dgvData As DataGridViewRow = dgvSintomasAsociados.Rows.Item(i)
                    dgvData.Cells(0).Value = sintoma.Codigo
                    dgvData.Cells(1).Value = sintoma.Nombre
                    i += 1
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub ActualizarTabla()
        Try
            If cmbPatologia.SelectedIndex >= 0 Then
                dgvSintomasAsociados.Rows.Clear()
                Dim patologias As List(Of Patologia) = logicaAsociar.ObtenerPatologias
                Dim patologiaSeleccionada As Patologia = Nothing
                For Each patologia As Patologia In patologias
                    If patologia.Nombre = cmbPatologia.Text Then
                        patologiaSeleccionada = patologia
                    End If
                Next
                Dim i = 0
                For Each sintoma As Sintoma In patologiaSeleccionada.Sintomas
                    dgvSintomasAsociados.Rows.Add()
                    Dim dgvData As DataGridViewRow = dgvSintomasAsociados.Rows.Item(i)
                    dgvData.Cells(0).Value = sintoma.Codigo
                    dgvData.Cells(1).Value = sintoma.Nombre
                    i += 1
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub AsociarSintomasYPatologias_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        inicioGestion.Show()
    End Sub
    Private Sub codP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPatologia.SelectedIndexChanged
        ActualizarTabla()
    End Sub
    Public Sub traductor()
        btnActualizar.Text = Traduccion.Traducir("btnActualizar", idioma)
        btnAsociar.Text = Traduccion.Traducir("btnAsociar", idioma)
        btnDesasociar.Text = Traduccion.Traducir("btnDesasociar", idioma)
        lblAsociarSP.Text = Traduccion.Traducir("lblAsociarSP", idioma)
        lblPatologia.Text = Traduccion.Traducir("lblPatologia", idioma)
        lblSintoma.Text = Traduccion.Traducir("lblSintoma", idioma)
    End Sub
    Private Sub btnAsociar_Click(sender As Object, e As EventArgs) Handles btnAsociar.Click
        Try
            If MessageBox.Show(Traduccion.Traducir("msgSeguroAsociar", idioma), Traduccion.Traducir("msgAtencion", idioma), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If cmbSintoma.Text.Length = 0 Then
                    MsgBox(Traduccion.Traducir("msgIngreseSintoma", idioma))
                ElseIf cmbPatologia.Text.Length = 0 Then
                    MsgBox(Traduccion.Traducir("msgIngresePatologia", idioma))
                Else
                    Dim sintoma As Sintoma = Nothing
                    Dim patologia As Patologia = Nothing
                    Dim patologias As List(Of Patologia) = logicaAsociar.ObtenerPatologias
                    For Each pat As Patologia In patologias
                        If pat.Nombre = cmbPatologia.Text Then
                            Dim patologiaSeleccionada As New Patologia(pat.Codigo, pat.Nombre, pat.Especialista, pat.Gravedad)
                            patologia = patologiaSeleccionada
                        End If
                    Next
                    Dim sintomas As List(Of Sintoma) = logicaAsociar.ObtenerSintomas
                    For Each sint As Sintoma In sintomas
                        If sint.Nombre = cmbSintoma.Text Then
                            Dim sintomaSeleccionado As New Sintoma(sint.Codigo, sint.Nombre)
                            sintoma = sintomaSeleccionado
                        End If
                    Next
                    If logicaAsociar.Asociar(patologia, sintoma) Then
                        MsgBox(Traduccion.Traducir("msgAsociadoExito", idioma))
                    End If
                    ActualizarTabla()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnActualizar_Click_1(sender As Object, e As EventArgs) Handles btnActualizar.Click
        ActualizarTabla()
    End Sub
    Private Sub btnDesasociar_Click(sender As Object, e As EventArgs) Handles btnDesasociar.Click
        Try
            If MessageBox.Show(Traduccion.Traducir("msgSeguroDesasociar", idioma), Traduccion.Traducir("msgAtencion", idioma), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If cmbSintoma.Text.Length = 0 Then
                    MsgBox(Traduccion.Traducir("msgIngreseSintoma", idioma))
                ElseIf cmbPatologia.Text.Length = 0 Then
                    MsgBox(Traduccion.Traducir("msgIngresePatologia", idioma))
                Else
                    Dim sintoma As Sintoma = Nothing
                    Dim patologia As Patologia = Nothing
                    Dim patologias As List(Of Patologia) = logicaAsociar.ObtenerPatologias
                    For Each pat As Patologia In patologias
                        If pat.Nombre = cmbPatologia.Text Then
                            Dim patologiaSeleccionada As New Patologia(pat.Codigo, pat.Nombre, pat.Especialista, pat.Gravedad)
                            patologia = patologiaSeleccionada
                        End If
                    Next
                    Dim sintomas As List(Of Sintoma) = logicaAsociar.ObtenerSintomas
                    For Each sint As Sintoma In sintomas
                        If sint.Nombre = cmbSintoma.Text Then
                            Dim sintomaSeleccionado As New Sintoma(sint.Codigo, sint.Nombre)
                            sintoma = sintomaSeleccionado
                        End If
                    Next
                    If logicaAsociar.Desasociar(patologia, sintoma) Then
                        MsgBox(Traduccion.Traducir("msgDesaociadoExito", idioma))
                    End If
                    ActualizarTabla()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgvSintomasAsociados_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSintomasAsociados.CellClick
        Try
            Dim dgvData As DataGridViewRow = dgvSintomasAsociados.Rows(e.RowIndex)
            cmbSintoma.Text = dgvData.Cells(1).Value.ToString
        Catch ex As Exception

        End Try
    End Sub
End Class