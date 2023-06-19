Imports CapaDeLogica
Imports Datos
Public Class RealizarConsulta
    Dim logicaConsulta As LogicaRealizarConsulta = New LogicaRealizarConsulta
    Dim sintomas As List(Of Sintoma) = logicaConsulta.ObtenerSintomas
    Dim sintomasSeleccionados As New List(Of Sintoma)
    Public Property idioma As String
    Private Sub RealizarConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCheckedListBox(sintomas)
        traductor()
    End Sub
    Private Sub btnRC_Click(sender As Object, e As EventArgs) Handles btnRC.Click
        Try
            If sintomasSeleccionados.Count < 2 Then
                MsgBox(Traduccion.Traducir("msgDosSintomas", idioma))
            Else
                Dim pacientes As List(Of Paciente) = logicaConsulta.ObtenerPacientes
                Dim paciente As Paciente = Nothing
                For Each pac As Paciente In pacientes
                    If pac.Ci = inicioSesion.cedula Then
                        paciente = pac
                    End If
                Next
                Dim diagnostico As Diagnostico = logicaConsulta.Consultar(sintomasSeleccionados, paciente)
                Dim formDiagnostico As New DiagnosticoFinal()
                formDiagnostico.Diagnostico = diagnostico
                formDiagnostico.idioma = Me.idioma
                FormPrincipalPaciente.AbrirForm(formDiagnostico)
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub RealizarConsulta_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        InicioPaciente.Show()
    End Sub
    Public Sub LlenarCheckedListBox(listaDeSintomas As List(Of Sintoma))
        listaSintomas.DataSource = listaDeSintomas.ToList()
        listaSintomas.DisplayMember = "Nombre"
        listaSintomas.ValueMember = "Codigo"
    End Sub
    Public Sub traductor()
        lblRC.Text = Traduccion.Traducir("btnRC", idioma)
        btnRC.Text = Traduccion.Traducir("btnRC", idioma)
    End Sub

    Private Sub listaSintomas_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles listaSintomas.ItemCheck
        If e.CurrentValue = 0 And listaSintomas.CheckedItems.Count + 1 = 9 Then
            Throw New Exception(Traduccion.Traducir("msgMaximo8Sintomas", idioma))
            e.NewValue = 0
        Else
            If e.CurrentValue = 0 Then
                For Each sintoma As Sintoma In sintomas
                    If sintoma.Nombre = listaSintomas.SelectedItem.Nombre Then
                        sintomasSeleccionados.Add(sintoma)
                    End If
                Next
            End If
            If e.CurrentValue = 1 Then
                For Each sintoma As Sintoma In sintomas
                    If sintoma.Nombre = listaSintomas.SelectedItem.Nombre Then
                        sintomasSeleccionados.Remove(sintoma)
                    End If
                Next
            End If
        End If
    End Sub
End Class