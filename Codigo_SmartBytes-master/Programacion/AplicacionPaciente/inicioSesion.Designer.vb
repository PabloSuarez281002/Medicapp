<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inicioSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inicioSesion))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.contraseñaUsuario = New System.Windows.Forms.TextBox()
        Me.cedulaUsuario = New System.Windows.Forms.TextBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.cmbIdioma = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AplicacionPaciente.My.Resources.Resources.Logo_MedicApp_blanco_0_5x
        Me.PictureBox1.Location = New System.Drawing.Point(138, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnSalir.Location = New System.Drawing.Point(86, 380)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 23)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnIniciar
        '
        Me.btnIniciar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnIniciar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnIniciar.Location = New System.Drawing.Point(236, 380)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(94, 23)
        Me.btnIniciar.TabIndex = 13
        Me.btnIniciar.Text = "&Iniciar sesión"
        Me.btnIniciar.UseVisualStyleBackColor = False
        '
        'contraseñaUsuario
        '
        Me.contraseñaUsuario.Location = New System.Drawing.Point(196, 315)
        Me.contraseñaUsuario.Name = "contraseñaUsuario"
        Me.contraseñaUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.contraseñaUsuario.Size = New System.Drawing.Size(158, 20)
        Me.contraseñaUsuario.TabIndex = 12
        Me.contraseñaUsuario.Text = "66758884"
        '
        'cedulaUsuario
        '
        Me.cedulaUsuario.Location = New System.Drawing.Point(196, 253)
        Me.cedulaUsuario.Name = "cedulaUsuario"
        Me.cedulaUsuario.Size = New System.Drawing.Size(158, 20)
        Me.cedulaUsuario.TabIndex = 10
        Me.cedulaUsuario.Text = "66758884"
        '
        'lblContraseña
        '
        Me.lblContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblContraseña.Location = New System.Drawing.Point(82, 312)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(108, 23)
        Me.lblContraseña.TabIndex = 11
        Me.lblContraseña.Text = "Contraseña:"
        Me.lblContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCedula
        '
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCedula.Location = New System.Drawing.Point(15, 250)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(175, 23)
        Me.lblCedula.TabIndex = 9
        Me.lblCedula.Text = "Cédula:"
        Me.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbIdioma
        '
        Me.cmbIdioma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdioma.FormattingEnabled = True
        Me.cmbIdioma.Items.AddRange(New Object() {"ES", "EN"})
        Me.cmbIdioma.Location = New System.Drawing.Point(378, 12)
        Me.cmbIdioma.Name = "cmbIdioma"
        Me.cmbIdioma.Size = New System.Drawing.Size(44, 21)
        Me.cmbIdioma.TabIndex = 17
        '
        'inicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(434, 451)
        Me.Controls.Add(Me.cmbIdioma)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.contraseñaUsuario)
        Me.Controls.Add(Me.cedulaUsuario)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.lblCedula)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "inicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar sesión"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnIniciar As Button
    Friend WithEvents contraseñaUsuario As TextBox
    Friend WithEvents cedulaUsuario As TextBox
    Friend WithEvents lblContraseña As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents cmbIdioma As ComboBox
End Class
