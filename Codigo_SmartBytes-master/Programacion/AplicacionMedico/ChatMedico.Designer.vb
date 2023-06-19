<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChatMedico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChatMedico))
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtChat = New System.Windows.Forms.TextBox()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnIngresarPatologiaFinal = New System.Windows.Forms.Button()
        Me.lblPatologiaFinal = New System.Windows.Forms.Label()
        Me.cmbPatologia = New System.Windows.Forms.ComboBox()
        Me.timerColor = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(75, 12)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(121, 20)
        Me.txtUsuario.TabIndex = 22
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.SystemColors.Desktop
        Me.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblUsuario.Location = New System.Drawing.Point(23, 16)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(46, 13)
        Me.lblUsuario.TabIndex = 20
        Me.lblUsuario.Text = "Usuario:"
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtChat
        '
        Me.txtChat.Location = New System.Drawing.Point(26, 45)
        Me.txtChat.Multiline = True
        Me.txtChat.Name = "txtChat"
        Me.txtChat.ReadOnly = True
        Me.txtChat.Size = New System.Drawing.Size(546, 356)
        Me.txtChat.TabIndex = 18
        '
        'txtMensaje
        '
        Me.txtMensaje.Location = New System.Drawing.Point(26, 417)
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(441, 20)
        Me.txtMensaje.TabIndex = 17
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(488, 414)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(84, 23)
        Me.btnEnviar.TabIndex = 16
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'btnIngresarPatologiaFinal
        '
        Me.btnIngresarPatologiaFinal.Location = New System.Drawing.Point(518, 10)
        Me.btnIngresarPatologiaFinal.Name = "btnIngresarPatologiaFinal"
        Me.btnIngresarPatologiaFinal.Size = New System.Drawing.Size(54, 23)
        Me.btnIngresarPatologiaFinal.TabIndex = 16
        Me.btnIngresarPatologiaFinal.Text = "Enviar"
        Me.btnIngresarPatologiaFinal.UseVisualStyleBackColor = True
        '
        'lblPatologiaFinal
        '
        Me.lblPatologiaFinal.AutoSize = True
        Me.lblPatologiaFinal.BackColor = System.Drawing.SystemColors.Desktop
        Me.lblPatologiaFinal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPatologiaFinal.Location = New System.Drawing.Point(292, 15)
        Me.lblPatologiaFinal.Name = "lblPatologiaFinal"
        Me.lblPatologiaFinal.Size = New System.Drawing.Size(78, 13)
        Me.lblPatologiaFinal.TabIndex = 20
        Me.lblPatologiaFinal.Text = "Patología final:"
        Me.lblPatologiaFinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbPatologia
        '
        Me.cmbPatologia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPatologia.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbPatologia.FormattingEnabled = True
        Me.cmbPatologia.Location = New System.Drawing.Point(376, 11)
        Me.cmbPatologia.Name = "cmbPatologia"
        Me.cmbPatologia.Size = New System.Drawing.Size(136, 21)
        Me.cmbPatologia.TabIndex = 156
        '
        'timerColor
        '
        Me.timerColor.Interval = 500
        '
        'ChatMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(594, 451)
        Me.Controls.Add(Me.cmbPatologia)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblPatologiaFinal)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtChat)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.btnIngresarPatologiaFinal)
        Me.Controls.Add(Me.btnEnviar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ChatMedico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChatMedico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtChat As TextBox
    Friend WithEvents txtMensaje As TextBox
    Friend WithEvents btnEnviar As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnIngresarPatologiaFinal As Button
    Friend WithEvents lblPatologiaFinal As Label
    Friend WithEvents cmbPatologia As ComboBox
    Friend WithEvents timerColor As Timer
End Class
