<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class infoGestion
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
        Me.contraseña = New System.Windows.Forms.TextBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.ci = New System.Windows.Forms.TextBox()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.segundoApe = New System.Windows.Forms.TextBox()
        Me.lblSegApe = New System.Windows.Forms.Label()
        Me.primerApe = New System.Windows.Forms.TextBox()
        Me.lblPrimApe = New System.Windows.Forms.Label()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
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
        Me.btnInfo = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.mail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'contraseña
        '
        Me.contraseña.Location = New System.Drawing.Point(376, 178)
        Me.contraseña.Name = "contraseña"
        Me.contraseña.Size = New System.Drawing.Size(111, 20)
        Me.contraseña.TabIndex = 242
        '
        'lblContraseña
        '
        Me.lblContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblContraseña.Location = New System.Drawing.Point(265, 175)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(110, 23)
        Me.lblContraseña.TabIndex = 240
        Me.lblContraseña.Text = "Contraseña:"
        Me.lblContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ci
        '
        Me.ci.Enabled = False
        Me.ci.Location = New System.Drawing.Point(137, 178)
        Me.ci.Name = "ci"
        Me.ci.Size = New System.Drawing.Size(111, 20)
        Me.ci.TabIndex = 243
        '
        'lblCedula
        '
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCedula.Location = New System.Drawing.Point(66, 175)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(72, 23)
        Me.lblCedula.TabIndex = 241
        Me.lblCedula.Text = "Cédula:"
        Me.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'segundoApe
        '
        Me.segundoApe.Enabled = False
        Me.segundoApe.Location = New System.Drawing.Point(376, 319)
        Me.segundoApe.Name = "segundoApe"
        Me.segundoApe.Size = New System.Drawing.Size(111, 20)
        Me.segundoApe.TabIndex = 237
        '
        'lblSegApe
        '
        Me.lblSegApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegApe.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSegApe.Location = New System.Drawing.Point(266, 317)
        Me.lblSegApe.Name = "lblSegApe"
        Me.lblSegApe.Size = New System.Drawing.Size(113, 23)
        Me.lblSegApe.TabIndex = 234
        Me.lblSegApe.Text = "2do apellido:"
        Me.lblSegApe.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'primerApe
        '
        Me.primerApe.Enabled = False
        Me.primerApe.Location = New System.Drawing.Point(137, 319)
        Me.primerApe.Name = "primerApe"
        Me.primerApe.Size = New System.Drawing.Size(111, 20)
        Me.primerApe.TabIndex = 238
        '
        'lblPrimApe
        '
        Me.lblPrimApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimApe.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPrimApe.Location = New System.Drawing.Point(25, 316)
        Me.lblPrimApe.Name = "lblPrimApe"
        Me.lblPrimApe.Size = New System.Drawing.Size(115, 23)
        Me.lblPrimApe.TabIndex = 235
        Me.lblPrimApe.Text = "1er apellido:"
        Me.lblPrimApe.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nom
        '
        Me.nom.Enabled = False
        Me.nom.Location = New System.Drawing.Point(854, 178)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(111, 20)
        Me.nom.TabIndex = 239
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNombre.Location = New System.Drawing.Point(777, 175)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(79, 23)
        Me.lblNombre.TabIndex = 236
        Me.lblNombre.Text = "Nombre:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnModificar.Location = New System.Drawing.Point(376, 591)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(277, 23)
        Me.btnModificar.TabIndex = 232
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'numPuerta
        '
        Me.numPuerta.Location = New System.Drawing.Point(615, 458)
        Me.numPuerta.Name = "numPuerta"
        Me.numPuerta.Size = New System.Drawing.Size(111, 20)
        Me.numPuerta.TabIndex = 230
        '
        'lblNum
        '
        Me.lblNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNum.Location = New System.Drawing.Point(502, 455)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(115, 23)
        Me.lblNum.TabIndex = 228
        Me.lblNum.Text = "Número:"
        Me.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'esq
        '
        Me.esq.Location = New System.Drawing.Point(376, 458)
        Me.esq.Name = "esq"
        Me.esq.Size = New System.Drawing.Size(111, 20)
        Me.esq.TabIndex = 231
        '
        'lblEsquina
        '
        Me.lblEsquina.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEsquina.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEsquina.Location = New System.Drawing.Point(265, 455)
        Me.lblEsquina.Name = "lblEsquina"
        Me.lblEsquina.Size = New System.Drawing.Size(115, 23)
        Me.lblEsquina.TabIndex = 227
        Me.lblEsquina.Text = "Esquina:"
        Me.lblEsquina.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'calle
        '
        Me.calle.Location = New System.Drawing.Point(137, 458)
        Me.calle.Name = "calle"
        Me.calle.Size = New System.Drawing.Size(111, 20)
        Me.calle.TabIndex = 229
        '
        'lblCalle
        '
        Me.lblCalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCalle.Location = New System.Drawing.Point(82, 455)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(56, 23)
        Me.lblCalle.TabIndex = 226
        Me.lblCalle.Text = "Calle:"
        Me.lblCalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fechaNac
        '
        Me.fechaNac.CustomFormat = "yyyy-MM-dd"
        Me.fechaNac.Enabled = False
        Me.fechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fechaNac.Location = New System.Drawing.Point(615, 319)
        Me.fechaNac.MaxDate = New Date(2020, 6, 5, 0, 0, 0, 0)
        Me.fechaNac.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.fechaNac.Name = "fechaNac"
        Me.fechaNac.Size = New System.Drawing.Size(111, 20)
        Me.fechaNac.TabIndex = 225
        Me.fechaNac.Value = New Date(2002, 7, 24, 0, 0, 0, 0)
        '
        'tel
        '
        Me.tel.Location = New System.Drawing.Point(854, 319)
        Me.tel.Name = "tel"
        Me.tel.Size = New System.Drawing.Size(111, 20)
        Me.tel.TabIndex = 224
        '
        'lblTel
        '
        Me.lblTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTel.Location = New System.Drawing.Point(766, 317)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(90, 23)
        Me.lblTel.TabIndex = 223
        Me.lblTel.Text = "Teléfono:"
        Me.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNacimiento
        '
        Me.lblNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacimiento.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNacimiento.Location = New System.Drawing.Point(499, 317)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(115, 23)
        Me.lblNacimiento.TabIndex = 222
        Me.lblNacimiento.Text = "Nacimiento:"
        Me.lblNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'sexo
        '
        Me.sexo.Enabled = False
        Me.sexo.FormattingEnabled = True
        Me.sexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.sexo.Location = New System.Drawing.Point(854, 455)
        Me.sexo.Name = "sexo"
        Me.sexo.Size = New System.Drawing.Size(111, 21)
        Me.sexo.TabIndex = 220
        '
        'lblSexo
        '
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSexo.Location = New System.Drawing.Point(783, 453)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(72, 23)
        Me.lblSexo.TabIndex = 219
        Me.lblSexo.Text = "Sexo:"
        Me.lblSexo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnInfo
        '
        Me.btnInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnInfo.Location = New System.Drawing.Point(430, 62)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(198, 42)
        Me.btnInfo.TabIndex = 241
        Me.btnInfo.Text = "Mi información"
        Me.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMail
        '
        Me.lblMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMail.Location = New System.Drawing.Point(538, 175)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(79, 23)
        Me.lblMail.TabIndex = 236
        Me.lblMail.Text = "Mail:"
        Me.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mail
        '
        Me.mail.Enabled = False
        Me.mail.Location = New System.Drawing.Point(615, 178)
        Me.mail.Name = "mail"
        Me.mail.Size = New System.Drawing.Size(111, 20)
        Me.mail.TabIndex = 239
        '
        'infoGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(1025, 650)
        Me.Controls.Add(Me.contraseña)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.ci)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.segundoApe)
        Me.Controls.Add(Me.lblSegApe)
        Me.Controls.Add(Me.primerApe)
        Me.Controls.Add(Me.lblPrimApe)
        Me.Controls.Add(Me.mail)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.nom)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnModificar)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "infoGestion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mi información"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents contraseña As TextBox
    Friend WithEvents lblContraseña As Label
    Friend WithEvents ci As TextBox
    Friend WithEvents lblCedula As Label
    Friend WithEvents segundoApe As TextBox
    Friend WithEvents lblSegApe As Label
    Friend WithEvents primerApe As TextBox
    Friend WithEvents lblPrimApe As Label
    Friend WithEvents nom As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents btnModificar As Button
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
    Friend WithEvents btnInfo As Label
    Friend WithEvents lblMail As Label
    Friend WithEvents mail As TextBox
End Class
