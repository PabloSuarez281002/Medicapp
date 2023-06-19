<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChatHistorial
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
        Me.txtMedico = New System.Windows.Forms.TextBox()
        Me.lblMedico = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtChat = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtMedico
        '
        Me.txtMedico.Enabled = False
        Me.txtMedico.Location = New System.Drawing.Point(449, 12)
        Me.txtMedico.Name = "txtMedico"
        Me.txtMedico.Size = New System.Drawing.Size(121, 20)
        Me.txtMedico.TabIndex = 20
        '
        'lblMedico
        '
        Me.lblMedico.AutoSize = True
        Me.lblMedico.BackColor = System.Drawing.SystemColors.Desktop
        Me.lblMedico.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMedico.Location = New System.Drawing.Point(397, 16)
        Me.lblMedico.Name = "lblMedico"
        Me.lblMedico.Size = New System.Drawing.Size(45, 13)
        Me.lblMedico.TabIndex = 19
        Me.lblMedico.Text = "Médico:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(73, 12)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(121, 20)
        Me.txtUsuario.TabIndex = 21
        '
        'txtChat
        '
        Me.txtChat.Location = New System.Drawing.Point(24, 45)
        Me.txtChat.Multiline = True
        Me.txtChat.Name = "txtChat"
        Me.txtChat.ReadOnly = True
        Me.txtChat.Size = New System.Drawing.Size(546, 367)
        Me.txtChat.TabIndex = 18
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.SystemColors.Desktop
        Me.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblUsuario.Location = New System.Drawing.Point(21, 16)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(46, 13)
        Me.lblUsuario.TabIndex = 22
        Me.lblUsuario.Text = "Usuario:"
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVolver.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnVolver.Location = New System.Drawing.Point(177, 419)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(240, 23)
        Me.btnVolver.TabIndex = 271
        Me.btnVolver.Text = "&Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'ChatHistorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(594, 451)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtMedico)
        Me.Controls.Add(Me.lblMedico)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtChat)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "ChatHistorial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChatHistorial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMedico As TextBox
    Friend WithEvents lblMedico As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtChat As TextBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents btnVolver As Button
End Class
