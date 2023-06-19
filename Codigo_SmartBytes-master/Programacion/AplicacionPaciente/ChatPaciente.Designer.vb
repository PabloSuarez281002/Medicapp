<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChatPaciente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChatPaciente))
        Me.txtChat = New System.Windows.Forms.TextBox()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.TimerChat = New System.Windows.Forms.Timer(Me.components)
        Me.txtMedico = New System.Windows.Forms.TextBox()
        Me.lblPatologiaFinal = New System.Windows.Forms.Label()
        Me.txtPatFinal = New System.Windows.Forms.TextBox()
        Me.lblMedico = New System.Windows.Forms.Label()
        Me.TimerMedico = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtChat
        '
        Me.txtChat.Location = New System.Drawing.Point(26, 45)
        Me.txtChat.Multiline = True
        Me.txtChat.Name = "txtChat"
        Me.txtChat.ReadOnly = True
        Me.txtChat.Size = New System.Drawing.Size(546, 356)
        Me.txtChat.TabIndex = 13
        '
        'txtMensaje
        '
        Me.txtMensaje.Location = New System.Drawing.Point(26, 417)
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(441, 20)
        Me.txtMensaje.TabIndex = 12
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(488, 415)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(84, 23)
        Me.btnEnviar.TabIndex = 11
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'TimerChat
        '
        Me.TimerChat.Interval = 1000
        '
        'txtMedico
        '
        Me.txtMedico.Enabled = False
        Me.txtMedico.Location = New System.Drawing.Point(451, 12)
        Me.txtMedico.Name = "txtMedico"
        Me.txtMedico.Size = New System.Drawing.Size(121, 20)
        Me.txtMedico.TabIndex = 15
        '
        'lblPatologiaFinal
        '
        Me.lblPatologiaFinal.AutoSize = True
        Me.lblPatologiaFinal.BackColor = System.Drawing.SystemColors.Desktop
        Me.lblPatologiaFinal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPatologiaFinal.Location = New System.Drawing.Point(23, 16)
        Me.lblPatologiaFinal.Name = "lblPatologiaFinal"
        Me.lblPatologiaFinal.Size = New System.Drawing.Size(78, 13)
        Me.lblPatologiaFinal.TabIndex = 14
        Me.lblPatologiaFinal.Text = "Patología final:"
        '
        'txtPatFinal
        '
        Me.txtPatFinal.Enabled = False
        Me.txtPatFinal.Location = New System.Drawing.Point(110, 13)
        Me.txtPatFinal.Name = "txtPatFinal"
        Me.txtPatFinal.Size = New System.Drawing.Size(121, 20)
        Me.txtPatFinal.TabIndex = 15
        '
        'lblMedico
        '
        Me.lblMedico.AutoSize = True
        Me.lblMedico.BackColor = System.Drawing.SystemColors.Desktop
        Me.lblMedico.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMedico.Location = New System.Drawing.Point(399, 16)
        Me.lblMedico.Name = "lblMedico"
        Me.lblMedico.Size = New System.Drawing.Size(45, 13)
        Me.lblMedico.TabIndex = 14
        Me.lblMedico.Text = "Médico:"
        '
        'TimerMedico
        '
        '
        'ChatPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(594, 451)
        Me.Controls.Add(Me.txtMedico)
        Me.Controls.Add(Me.lblMedico)
        Me.Controls.Add(Me.txtPatFinal)
        Me.Controls.Add(Me.lblPatologiaFinal)
        Me.Controls.Add(Me.txtChat)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.btnEnviar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ChatPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChatPaciente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtChat As TextBox
    Friend WithEvents txtMensaje As TextBox
    Friend WithEvents btnEnviar As Button
    Friend WithEvents TimerChat As Timer
    Friend WithEvents txtMedico As TextBox
    Friend WithEvents lblPatologiaFinal As Label
    Friend WithEvents txtPatFinal As TextBox
    Friend WithEvents lblMedico As Label
    Friend WithEvents TimerMedico As Timer
End Class
