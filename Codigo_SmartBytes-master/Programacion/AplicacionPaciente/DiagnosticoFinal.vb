Imports CapaDeLogica
Imports Datos
Public Class DiagnosticoFinal
    Dim logicaConsulta As LogicaRealizarConsulta = New LogicaRealizarConsulta
    Public Property Diagnostico As Diagnostico
    Public Property idioma As String
    Private Sub DiagnosticoFinal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim patologia As Patologia = logicaConsulta.MostrarPatologia(Diagnostico)
        resultado.Text = patologia.Nombre
        traductor()
    End Sub
    Private Sub btnIniciarChat_Click(sender As Object, e As EventArgs) Handles btnIniciarChat.Click
        Try
            logicaConsulta.Activar(Diagnostico)
            Dim formChat As New ChatPaciente()
            formChat.diagnostico = Diagnostico
            formChat.idioma = Me.idioma
            FormPrincipalPaciente.AbrirForm(FormPrincipalPaciente.inicio)
            formChat.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub traductor()
        btnIniciarChat.Text = Traduccion.Traducir("btnIniciarChat", idioma)
        lblDiagnostico.Text = Traduccion.Traducir("lblDiagnostico", idioma)
    End Sub
End Class