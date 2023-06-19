<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipalGestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipalGestion))
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.cmbIdioma = New System.Windows.Forms.ComboBox()
        Me.logoMedicApp = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnAsociarSP = New System.Windows.Forms.Button()
        Me.btnPatologias = New System.Windows.Forms.Button()
        Me.btnSintomas = New System.Windows.Forms.Button()
        Me.btnPacientes = New System.Windows.Forms.Button()
        Me.btnMedicos = New System.Windows.Forms.Button()
        Me.btnAdministradores = New System.Windows.Forms.Button()
        Me.panelMenu.SuspendLayout()
        Me.panelLogo.SuspendLayout()
        CType(Me.logoMedicApp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelContenedor
        '
        Me.panelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Location = New System.Drawing.Point(175, 0)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(1025, 650)
        Me.panelContenedor.TabIndex = 4
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.panelLogo)
        Me.panelMenu.Controls.Add(Me.btnSalir)
        Me.panelMenu.Controls.Add(Me.btnInfo)
        Me.panelMenu.Controls.Add(Me.btnAsociarSP)
        Me.panelMenu.Controls.Add(Me.btnPatologias)
        Me.panelMenu.Controls.Add(Me.btnSintomas)
        Me.panelMenu.Controls.Add(Me.btnPacientes)
        Me.panelMenu.Controls.Add(Me.btnMedicos)
        Me.panelMenu.Controls.Add(Me.btnAdministradores)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(175, 650)
        Me.panelMenu.TabIndex = 3
        '
        'panelLogo
        '
        Me.panelLogo.Controls.Add(Me.cmbIdioma)
        Me.panelLogo.Controls.Add(Me.logoMedicApp)
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(175, 175)
        Me.panelLogo.TabIndex = 1
        '
        'cmbIdioma
        '
        Me.cmbIdioma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdioma.FormattingEnabled = True
        Me.cmbIdioma.Items.AddRange(New Object() {"ES", "EN"})
        Me.cmbIdioma.Location = New System.Drawing.Point(3, 3)
        Me.cmbIdioma.Name = "cmbIdioma"
        Me.cmbIdioma.Size = New System.Drawing.Size(44, 21)
        Me.cmbIdioma.TabIndex = 17
        '
        'logoMedicApp
        '
        Me.logoMedicApp.Image = CType(resources.GetObject("logoMedicApp.Image"), System.Drawing.Image)
        Me.logoMedicApp.Location = New System.Drawing.Point(37, 37)
        Me.logoMedicApp.Name = "logoMedicApp"
        Me.logoMedicApp.Size = New System.Drawing.Size(100, 100)
        Me.logoMedicApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoMedicApp.TabIndex = 0
        Me.logoMedicApp.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(0, 612)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(175, 38)
        Me.btnSalir.TabIndex = 0
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnInfo.FlatAppearance.BorderSize = 0
        Me.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfo.ForeColor = System.Drawing.Color.White
        Me.btnInfo.Location = New System.Drawing.Point(0, 445)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(175, 38)
        Me.btnInfo.TabIndex = 0
        Me.btnInfo.Text = "Mi información"
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'btnAsociarSP
        '
        Me.btnAsociarSP.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAsociarSP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAsociarSP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAsociarSP.FlatAppearance.BorderSize = 0
        Me.btnAsociarSP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnAsociarSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsociarSP.ForeColor = System.Drawing.Color.White
        Me.btnAsociarSP.Location = New System.Drawing.Point(0, 401)
        Me.btnAsociarSP.Name = "btnAsociarSP"
        Me.btnAsociarSP.Size = New System.Drawing.Size(175, 38)
        Me.btnAsociarSP.TabIndex = 0
        Me.btnAsociarSP.Text = "Asociar"
        Me.btnAsociarSP.UseVisualStyleBackColor = False
        '
        'btnPatologias
        '
        Me.btnPatologias.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnPatologias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPatologias.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnPatologias.FlatAppearance.BorderSize = 0
        Me.btnPatologias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnPatologias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPatologias.ForeColor = System.Drawing.Color.White
        Me.btnPatologias.Location = New System.Drawing.Point(0, 357)
        Me.btnPatologias.Name = "btnPatologias"
        Me.btnPatologias.Size = New System.Drawing.Size(175, 38)
        Me.btnPatologias.TabIndex = 0
        Me.btnPatologias.Text = "Patologías"
        Me.btnPatologias.UseVisualStyleBackColor = False
        '
        'btnSintomas
        '
        Me.btnSintomas.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSintomas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSintomas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSintomas.FlatAppearance.BorderSize = 0
        Me.btnSintomas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnSintomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSintomas.ForeColor = System.Drawing.Color.White
        Me.btnSintomas.Location = New System.Drawing.Point(0, 313)
        Me.btnSintomas.Name = "btnSintomas"
        Me.btnSintomas.Size = New System.Drawing.Size(175, 38)
        Me.btnSintomas.TabIndex = 0
        Me.btnSintomas.Text = "Síntomas"
        Me.btnSintomas.UseVisualStyleBackColor = False
        '
        'btnPacientes
        '
        Me.btnPacientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPacientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnPacientes.FlatAppearance.BorderSize = 0
        Me.btnPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPacientes.ForeColor = System.Drawing.Color.White
        Me.btnPacientes.Location = New System.Drawing.Point(0, 269)
        Me.btnPacientes.Name = "btnPacientes"
        Me.btnPacientes.Size = New System.Drawing.Size(175, 38)
        Me.btnPacientes.TabIndex = 0
        Me.btnPacientes.Text = "Pacientes"
        Me.btnPacientes.UseVisualStyleBackColor = False
        '
        'btnMedicos
        '
        Me.btnMedicos.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnMedicos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMedicos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnMedicos.FlatAppearance.BorderSize = 0
        Me.btnMedicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMedicos.ForeColor = System.Drawing.Color.White
        Me.btnMedicos.Location = New System.Drawing.Point(0, 225)
        Me.btnMedicos.Name = "btnMedicos"
        Me.btnMedicos.Size = New System.Drawing.Size(175, 38)
        Me.btnMedicos.TabIndex = 0
        Me.btnMedicos.Text = "Médicos"
        Me.btnMedicos.UseVisualStyleBackColor = False
        '
        'btnAdministradores
        '
        Me.btnAdministradores.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAdministradores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdministradores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAdministradores.FlatAppearance.BorderSize = 0
        Me.btnAdministradores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnAdministradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdministradores.ForeColor = System.Drawing.Color.White
        Me.btnAdministradores.Location = New System.Drawing.Point(0, 181)
        Me.btnAdministradores.Name = "btnAdministradores"
        Me.btnAdministradores.Size = New System.Drawing.Size(175, 38)
        Me.btnAdministradores.TabIndex = 0
        Me.btnAdministradores.Text = "Administradores"
        Me.btnAdministradores.UseVisualStyleBackColor = False
        '
        'FormPrincipalGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 650)
        Me.Controls.Add(Me.panelContenedor)
        Me.Controls.Add(Me.panelMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPrincipalGestion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MedicApp"
        Me.panelMenu.ResumeLayout(False)
        Me.panelLogo.ResumeLayout(False)
        CType(Me.logoMedicApp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelContenedor As Panel
    Friend WithEvents panelMenu As Panel
    Friend WithEvents panelLogo As Panel
    Friend WithEvents logoMedicApp As PictureBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnInfo As Button
    Friend WithEvents btnAsociarSP As Button
    Friend WithEvents btnPatologias As Button
    Friend WithEvents btnSintomas As Button
    Friend WithEvents btnPacientes As Button
    Friend WithEvents btnMedicos As Button
    Friend WithEvents btnAdministradores As Button
    Friend WithEvents cmbIdioma As ComboBox
End Class
