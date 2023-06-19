Imports CapaDeLogica
Imports Datos
Public Class ChatPaciente
    Dim logicaChat As LogicaChat = New LogicaChat
    Public Property diagnostico As Diagnostico
    Public Property idioma As String
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            If txtMedico.Text.Length > 0 And txtMensaje.Text.Length > 0 Then
                Dim formato As String = "yyyy-MM-dd"
                Dim mensaje As New Mensaje(-1, txtMensaje.Text, inicioSesion.cedula, DateTime.Now.ToString(formato), diagnostico.Codigo)
                If logicaChat.insertarMensaje(mensaje) Then
                    actualizarChat()
                    txtMensaje.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ChatPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerChat.Start()
        TimerMedico.Start()
        traductor()
    End Sub
    Private Sub TimerChat_Tick(sender As Object, e As EventArgs) Handles TimerChat.Tick
        actualizarChat()
    End Sub
    Public Sub actualizarChat()
        Try
            txtPatFinal.Text = logicaChat.ObtenerPatologiaFinal(diagnostico)
            txtChat.Text = logicaChat.cargarChat(diagnostico)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ChatPaciente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show(Traduccion.Traducir("msgSalirChat", idioma), Traduccion.Traducir("msgAtencion", idioma), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            logicaChat.Desactivar(diagnostico)
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub TimerMedico_Tick(sender As Object, e As EventArgs) Handles TimerMedico.Tick
        Dim medico As String = logicaChat.ObtenerMedicoQueAtiende(diagnostico.Codigo)
        If medico <> "" Then
            TimerMedico.Stop()
            txtMedico.Text = medico
        End If
    End Sub
    Public Sub traductor()
        btnEnviar.Text = Traduccion.Traducir("btnEnviar", idioma)
        lblMedico.Text = Traduccion.Traducir("lblMedico", idioma)
    End Sub
End Class