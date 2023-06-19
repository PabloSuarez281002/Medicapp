<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gestionPacientes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.contraseña = New System.Windows.Forms.TextBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.ci = New System.Windows.Forms.TextBox()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.segundoApe = New System.Windows.Forms.TextBox()
        Me.lblSegApe = New System.Windows.Forms.Label()
        Me.primerApe = New System.Windows.Forms.TextBox()
        Me.lblPrimApe = New System.Windows.Forms.Label()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.numPuerta = New System.Windows.Forms.TextBox()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.esq = New System.Windows.Forms.TextBox()
        Me.lblEsquina = New System.Windows.Forms.Label()
        Me.calle = New System.Windows.Forms.TextBox()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.fechaNac = New System.Windows.Forms.DateTimePicker()
        Me.tel = New System.Windows.Forms.TextBox()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.sexo = New System.Windows.Forms.ComboBox()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblGestionPacientes = New System.Windows.Forms.Label()
        Me.mail = New System.Windows.Forms.TextBox()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'contraseña
        '
        Me.contraseña.Location = New System.Drawing.Point(232, 213)
        Me.contraseña.Name = "contraseña"
        Me.contraseña.Size = New System.Drawing.Size(111, 20)
        Me.contraseña.TabIndex = 161
        '
        'lblContraseña
        '
        Me.lblContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblContraseña.Location = New System.Drawing.Point(228, 187)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(110, 23)
        Me.lblContraseña.TabIndex = 159
        Me.lblContraseña.Text = "Contraseña:"
        Me.lblContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ci
        '
        Me.ci.Location = New System.Drawing.Point(85, 213)
        Me.ci.Name = "ci"
        Me.ci.Size = New System.Drawing.Size(111, 20)
        Me.ci.TabIndex = 162
        '
        'lblCedula
        '
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCedula.Location = New System.Drawing.Point(81, 187)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(72, 23)
        Me.lblCedula.TabIndex = 160
        Me.lblCedula.Text = "Cédula:"
        Me.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column12, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        Me.dgvUsuarios.Cursor = System.Windows.Forms.Cursors.IBeam
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Format = "yyyy-MM-dd"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUsuarios.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUsuarios.Location = New System.Drawing.Point(512, 213)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Desktop
        Me.dgvUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvUsuarios.Size = New System.Drawing.Size(416, 262)
        Me.dgvUsuarios.TabIndex = 158
        '
        'segundoApe
        '
        Me.segundoApe.Location = New System.Drawing.Point(376, 289)
        Me.segundoApe.Name = "segundoApe"
        Me.segundoApe.Size = New System.Drawing.Size(111, 20)
        Me.segundoApe.TabIndex = 155
        '
        'lblSegApe
        '
        Me.lblSegApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegApe.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSegApe.Location = New System.Drawing.Point(374, 266)
        Me.lblSegApe.Name = "lblSegApe"
        Me.lblSegApe.Size = New System.Drawing.Size(132, 23)
        Me.lblSegApe.TabIndex = 152
        Me.lblSegApe.Text = "2do apellido:"
        Me.lblSegApe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'primerApe
        '
        Me.primerApe.Location = New System.Drawing.Point(232, 289)
        Me.primerApe.Name = "primerApe"
        Me.primerApe.Size = New System.Drawing.Size(111, 20)
        Me.primerApe.TabIndex = 156
        '
        'lblPrimApe
        '
        Me.lblPrimApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimApe.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPrimApe.Location = New System.Drawing.Point(228, 266)
        Me.lblPrimApe.Name = "lblPrimApe"
        Me.lblPrimApe.Size = New System.Drawing.Size(115, 23)
        Me.lblPrimApe.TabIndex = 153
        Me.lblPrimApe.Text = "1er apellido:"
        Me.lblPrimApe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nom
        '
        Me.nom.Location = New System.Drawing.Point(85, 289)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(111, 20)
        Me.nom.TabIndex = 157
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNombre.Location = New System.Drawing.Point(81, 266)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(115, 23)
        Me.lblNombre.TabIndex = 154
        Me.lblNombre.Text = "Nombre:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnActualizar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnActualizar.Location = New System.Drawing.Point(512, 508)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(416, 23)
        Me.btnActualizar.TabIndex = 150
        Me.btnActualizar.Text = "&Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnEliminar.Location = New System.Drawing.Point(376, 508)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(111, 23)
        Me.btnEliminar.TabIndex = 149
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnModificar.Location = New System.Drawing.Point(232, 508)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(111, 23)
        Me.btnModificar.TabIndex = 148
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnAgregar.Location = New System.Drawing.Point(85, 508)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(111, 23)
        Me.btnAgregar.TabIndex = 147
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'numPuerta
        '
        Me.numPuerta.Location = New System.Drawing.Point(376, 455)
        Me.numPuerta.Name = "numPuerta"
        Me.numPuerta.Size = New System.Drawing.Size(111, 20)
        Me.numPuerta.TabIndex = 145
        '
        'lblNum
        '
        Me.lblNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNum.Location = New System.Drawing.Point(372, 432)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(115, 23)
        Me.lblNum.TabIndex = 143
        Me.lblNum.Text = "Número:"
        Me.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'esq
        '
        Me.esq.Location = New System.Drawing.Point(232, 455)
        Me.esq.Name = "esq"
        Me.esq.Size = New System.Drawing.Size(111, 20)
        Me.esq.TabIndex = 146
        '
        'lblEsquina
        '
        Me.lblEsquina.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEsquina.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEsquina.Location = New System.Drawing.Point(228, 432)
        Me.lblEsquina.Name = "lblEsquina"
        Me.lblEsquina.Size = New System.Drawing.Size(115, 23)
        Me.lblEsquina.TabIndex = 142
        Me.lblEsquina.Text = "Esquina:"
        Me.lblEsquina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'calle
        '
        Me.calle.Location = New System.Drawing.Point(85, 455)
        Me.calle.Name = "calle"
        Me.calle.Size = New System.Drawing.Size(111, 20)
        Me.calle.TabIndex = 144
        '
        'lblCalle
        '
        Me.lblCalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCalle.Location = New System.Drawing.Point(81, 432)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(115, 23)
        Me.lblCalle.TabIndex = 141
        Me.lblCalle.Text = "Calle:"
        Me.lblCalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fechaNac
        '
        Me.fechaNac.CustomFormat = "yyyy-MM-dd"
        Me.fechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fechaNac.Location = New System.Drawing.Point(232, 375)
        Me.fechaNac.MaxDate = New Date(2020, 6, 5, 0, 0, 0, 0)
        Me.fechaNac.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.fechaNac.Name = "fechaNac"
        Me.fechaNac.Size = New System.Drawing.Size(111, 20)
        Me.fechaNac.TabIndex = 140
        Me.fechaNac.Value = New Date(2002, 7, 24, 0, 0, 0, 0)
        '
        'tel
        '
        Me.tel.Location = New System.Drawing.Point(376, 375)
        Me.tel.Name = "tel"
        Me.tel.Size = New System.Drawing.Size(111, 20)
        Me.tel.TabIndex = 139
        '
        'lblTel
        '
        Me.lblTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTel.Location = New System.Drawing.Point(372, 352)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(115, 23)
        Me.lblTel.TabIndex = 138
        Me.lblTel.Text = "Teléfono:"
        Me.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNacimiento
        '
        Me.lblNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacimiento.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNacimiento.Location = New System.Drawing.Point(228, 352)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(115, 23)
        Me.lblNacimiento.TabIndex = 137
        Me.lblNacimiento.Text = "Nacimiento:"
        Me.lblNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sexo
        '
        Me.sexo.FormattingEnabled = True
        Me.sexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.sexo.Location = New System.Drawing.Point(85, 375)
        Me.sexo.Name = "sexo"
        Me.sexo.Size = New System.Drawing.Size(111, 21)
        Me.sexo.TabIndex = 135
        '
        'lblSexo
        '
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSexo.Location = New System.Drawing.Point(81, 352)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(115, 23)
        Me.lblSexo.TabIndex = 134
        Me.lblSexo.Text = "Sexo:"
        Me.lblSexo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGestionPacientes
        '
        Me.lblGestionPacientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGestionPacientes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblGestionPacientes.Location = New System.Drawing.Point(365, 73)
        Me.lblGestionPacientes.Name = "lblGestionPacientes"
        Me.lblGestionPacientes.Size = New System.Drawing.Size(304, 38)
        Me.lblGestionPacientes.TabIndex = 133
        Me.lblGestionPacientes.Text = "Gestión de pacientes"
        Me.lblGestionPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mail
        '
        Me.mail.Location = New System.Drawing.Point(376, 213)
        Me.mail.Name = "mail"
        Me.mail.Size = New System.Drawing.Size(111, 20)
        Me.mail.TabIndex = 161
        '
        'lblMail
        '
        Me.lblMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMail.Location = New System.Drawing.Point(372, 187)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(110, 23)
        Me.lblMail.TabIndex = 159
        Me.lblMail.Text = "Contraseña:"
        Me.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Column1
        '
        Me.Column1.HeaderText = "Cédula"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Contraseña"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nombre"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Primer apellido"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Segundo apellido"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Teléfono"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "Mail"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Sexo"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Calle"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Esquina"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "Número de puerta"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "Fecha de nacimiento"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'gestionPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(1025, 650)
        Me.Controls.Add(Me.mail)
        Me.Controls.Add(Me.contraseña)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.ci)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.dgvUsuarios)
        Me.Controls.Add(Me.segundoApe)
        Me.Controls.Add(Me.lblSegApe)
        Me.Controls.Add(Me.primerApe)
        Me.Controls.Add(Me.lblPrimApe)
        Me.Controls.Add(Me.nom)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.numPuerta)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.esq)
        Me.Controls.Add(Me.lblEsquina)
        Me.Controls.Add(Me.calle)
        Me.Controls.Add(Me.lblCalle)
        Me.Controls.Add(Me.fechaNac)
        Me.Controls.Add(Me.tel)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.lblNacimiento)
        Me.Controls.Add(Me.sexo)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.lblGestionPacientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "gestionPacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestionar pacientes"
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents contraseña As TextBox
    Friend WithEvents lblContraseña As Label
    Friend WithEvents ci As TextBox
    Friend WithEvents lblCedula As Label
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents segundoApe As TextBox
    Friend WithEvents lblSegApe As Label
    Friend WithEvents primerApe As TextBox
    Friend WithEvents lblPrimApe As Label
    Friend WithEvents nom As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents numPuerta As TextBox
    Friend WithEvents lblNum As Label
    Friend WithEvents esq As TextBox
    Friend WithEvents lblEsquina As Label
    Friend WithEvents calle As TextBox
    Friend WithEvents lblCalle As Label
    Friend WithEvents fechaNac As DateTimePicker
    Friend WithEvents tel As TextBox
    Friend WithEvents lblTel As Label
    Friend WithEvents lblNacimiento As Label
    Friend WithEvents sexo As ComboBox
    Friend WithEvents lblSexo As Label
    Friend WithEvents lblGestionPacientes As Label
    Friend WithEvents mail As TextBox
    Friend WithEvents lblMail As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
End Class
