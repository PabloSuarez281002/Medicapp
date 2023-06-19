Imports CapaDeLogica
Imports Datos
Public Class ChatMedico
    Dim logicaChat As LogicaChat = New LogicaChat
    Public Property solicitud As Solicitud
    Public Property idioma As String
    Dim a = 0
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            If txtUsuario.Text = "" Then
            ElseIf txtMensaje.Text = "" Then
            Else
                Dim formato As String = "yyyy-MM-dd"
                Dim mensaje As New Mensaje(2, txtMensaje.Text, inicioSesion.cedula, DateTime.Now.ToString(formato), solicitud.CodigoDiagnostico)
                If logicaChat.insertarMensaje(mensaje) Then
                    actualizarChat()
                    txtMensaje.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ChatMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmbPatologia.BackColor = Color.White
            Dim listaPatologias As List(Of Patologia) = New List(Of Patologia)
            listaPatologias = logicaChat.ObtenerPatologias
            cmbPatologia.Items.Clear()
            For Each patologia As Patologia In listaPatologias
                cmbPatologia.Items.Add(patologia.Nombre)
            Next
            cmbPatologia.Sorted = True
            cmbPatologia.Text = solicitud.NombrePatologia

            logicaChat.ModificarMedico(solicitud.CodigoDiagnostico, inicioSesion.cedula)
            txtUsuario.Text = solicitud.CiPaciente
            Timer1.Start()
            traductor()
        Catch ex As Exception
            Timer1.Stop()
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        actualizarChat()
    End Sub
    Public Sub actualizarChat()
        Dim diagnostico As New Diagnostico(Solicitud.CodigoDiagnostico)
        txtChat.Text = logicaChat.cargarChat(diagnostico)
    End Sub
    Public Sub traductor()
        lblUsuario.Text = Traduccion.Traducir("lblUsuario", idioma)
        lblPatologiaFinal.Text = Traduccion.Traducir("lblPatologiaFinal", idioma)
        btnEnviar.Text = Traduccion.Traducir("btnEnviar", idioma)
    End Sub
    Private Sub btnIngresarPatologiaFinal_Click(sender As Object, e As EventArgs) Handles btnIngresarPatologiaFinal.Click
        Try
            If cmbPatologia.Text <> "" Then
                If logicaChat.IngresarPatologiaFinal(solicitud, cmbPatologia.Text) Then
                    cmbPatologia.BackColor = Color.LightGreen
                    a = 0
                    timerColor.Start()
                Else
                    cmbPatologia.BackColor = Color.IndianRed
                    a = 0
                    timerColor.Start()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub timerColor_Tick(sender As Object, e As EventArgs) Handles timerColor.Tick
        cmbPatologia.BackColor = Color.White
        timerColor.Stop()
    End Sub
End Class