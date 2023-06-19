Imports CapaDeLogica
Imports Datos
Public Class ListaDiagnosticos
    Dim info As LogicaInformacion = New LogicaInformacion
    Public Property idioma As String
    Private Sub ListaDiagnosticos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim diagnosticos As List(Of Diagnostico) = info.ObtenerHistorialDiagnosticos(inicioSesion.cedula)
            dgvHistorial.Rows.Clear()
            Dim formato As String = "yyyy-MM-dd"
            Dim i As Integer = 0
            Dim diagnosticosHistorial As New List(Of Diagnostico)
            Dim patologias As List(Of Patologia) = info.ObtenerPatologias
            For Each diag As Diagnostico In diagnosticos
                If diag.CedulaPaciente = inicioSesion.cedula Then
                    diagnosticosHistorial.Add(diag)
                End If
            Next
            For Each diag As Diagnostico In diagnosticosHistorial
                Dim nombrePatologiaPrimaria As String = ""
                Dim nombrePatologiaFinal As String = ""
                For Each pat As Patologia In patologias
                    If pat.Codigo = diag.CodigoPatologiaPrimaria Then
                        nombrePatologiaPrimaria = pat.Nombre
                    End If
                    If pat.Codigo = diag.CodigoPatologiaFinal Then
                        nombrePatologiaFinal = pat.Nombre
                    End If
                Next
                dgvHistorial.Rows.Add()
                Dim dgvData As DataGridViewRow = dgvHistorial.Rows.Item(i)
                dgvData.Cells(0).Value = diag.Codigo
                dgvData.Cells(1).Value = nombrePatologiaPrimaria
                dgvData.Cells(2).Value = nombrePatologiaFinal
                dgvData.Cells(3).Value = diag.FechaDiagnostico.ToString(formato)
                i += 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgvHistorial_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHistorial.CellDoubleClick
        Dim dgvData As DataGridViewRow = dgvHistorial.Rows(e.RowIndex)
        Dim chatHistorial As New ChatHistorial
        Dim diagnostico As New Diagnostico(dgvData.Cells(0).Value)
        chatHistorial.Diagnostico = diagnostico
        chatHistorial.Show()
    End Sub
End Class