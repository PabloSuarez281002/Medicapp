<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DiagnosticoFinal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnIniciarChat = New System.Windows.Forms.Button()
        Me.lblDiagnostico = New System.Windows.Forms.Label()
        Me.resultado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnIniciarChat
        '
        Me.btnIniciarChat.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnIniciarChat.Location = New System.Drawing.Point(271, 388)
        Me.btnIniciarChat.Name = "btnIniciarChat"
        Me.btnIniciarChat.Size = New System.Drawing.Size(404, 23)
        Me.btnIniciarChat.TabIndex = 160
        Me.btnIniciarChat.Text = "&Iniciar chat"
        Me.btnIniciarChat.UseVisualStyleBackColor = False
        '
        'lblDiagnostico
        '
        Me.lblDiagnostico.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiagnostico.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDiagnostico.Location = New System.Drawing.Point(317, 110)
        Me.lblDiagnostico.Name = "lblDiagnostico"
        Me.lblDiagnostico.Size = New System.Drawing.Size(313, 38)
        Me.lblDiagnostico.TabIndex = 159
        Me.lblDiagnostico.Text = "Diagnóstico Primario"
        Me.lblDiagnostico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'resultado
        '
        Me.resultado.Enabled = False
        Me.resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultado.Location = New System.Drawing.Point(271, 311)
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(404, 38)
        Me.resultado.TabIndex = 155
        Me.resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DiagnosticoFinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(1025, 650)
        Me.Controls.Add(Me.btnIniciarChat)
        Me.Controls.Add(Me.lblDiagnostico)
        Me.Controls.Add(Me.resultado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DiagnosticoFinal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Diagnostico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIniciarChat As Button
    Friend WithEvents lblDiagnostico As Label
    Friend WithEvents resultado As TextBox
End Class
