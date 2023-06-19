Imports CapaDeLogica
Imports Datos
Public Class SolicitudesDeChat
    Dim logicaChat As LogicaChat = New LogicaChat
    Public Property idioma As String
    Dim medico As Medico = logicaChat.ObtenerMedico(inicioSesion.cedula)
    Private Sub SolicitudesDeChat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        traductor()
    End Sub
    Public Sub mostrarDatos()
        Try
            Dim solicitudes As List(Of Solicitud) = logicaChat.MostrarDatos(Medico)
            dgvChatsDisponibles.Rows.Clear()
            Dim i As Integer = 0
            For Each solicitud As Solicitud In solicitudes
                dgvChatsDisponibles.Rows.Add()
                Dim dgvData As DataGridViewRow = dgvChatsDisponibles.Rows.Item(i)
                dgvData.Cells(0).Value = solicitud.CodigoDiagnostico
                dgvData.Cells(1).Value = solicitud.CiPaciente
                dgvData.Cells(2).Value = solicitud.NombrePatologia
                dgvData.Cells(3).Value = solicitud.Gravedad
                i += 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnCancelarP_Click(sender As Object, e As EventArgs)
        InicioMedico.Show()
        Me.Close()
    End Sub
    Private Sub SolicitudesDeChat_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        InicioMedico.Show()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        mostrarDatos()
    End Sub
    Public Sub traductor()
        lblDobleClick.Text = Traduccion.Traducir("lblDobleClick", idioma)
        lblSolicitudes.Text = Traduccion.Traducir("lblSolicitudes", idioma)
    End Sub
    Private Sub dgvChatsDisponibles_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvChatsDisponibles.CellDoubleClick
        Dim dgvData As DataGridViewRow = dgvChatsDisponibles.Rows(e.RowIndex)
        Dim cod = dgvData.Cells(0).Value.ToString
        Dim solicitud As New Solicitud(dgvData.Cells(0).Value.ToString, dgvData.Cells(1).Value.ToString, dgvData.Cells(2).Value.ToString, dgvData.Cells(3).Value.ToString)
        Dim chatMedico As New ChatMedico
        chatMedico.solicitud = solicitud
        chatMedico.idioma = idioma
        chatMedico.Show()
    End Sub
End Class