<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InfoMedico
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
        Me.contraseña = New System.Windows.Forms.TextBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.ci = New System.Windows.Forms.TextBox()
        Me.btnInfo = New System.Windows.Forms.Label()
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
        Me.lblEspecialidad = New System.Windows.Forms.Label()
        Me.especialidad = New System.Windows.Forms.TextBox()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.mail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'contraseña
        '
        Me.contraseña.Location = New System.Drawing.Point(375, 144)
        Me.contraseña.Name = "contraseña"
        Me.contraseña.Size = New System.Drawing.Size(111, 20)
        Me.contraseña.TabIndex = 266
        '
        'lblContraseña
        '
        Me.lblContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblContraseña.Location = New System.Drawing.Point(264, 141)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(110, 23)
        Me.lblContraseña.TabIndex = 263
        Me.lblContraseña.Text = "Contraseña:"
        Me.lblContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ci
        '
        Me.ci.Enabled = False
        Me.ci.Location = New System.Drawing.Point(136, 144)
        Me.ci.Name = "ci"
        Me.ci.Size = New System.Drawing.Size(111, 20)
        Me.ci.TabIndex = 267
        '
        'btnInfo
        '
        Me.btnInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnInfo.Location = New System.Drawing.Point(427, 49)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(198, 42)
        Me.btnInfo.TabIndex = 265
        Me.btnInfo.Text = "Mi información"
        Me.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCedula
        '
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCedula.Location = New System.Drawing.Point(65, 141)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(72, 23)
        Me.lblCedula.TabIndex = 264
        Me.lblCedula.Text = "Cédula:"
        Me.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'segundoApe
        '
        Me.segundoApe.Enabled = False
        Me.segundoApe.Location = New System.Drawing.Point(375, 287)
        Me.segundoApe.Name = "segundoApe"
        Me.segundoApe.Size = New System.Drawing.Size(111, 20)
        Me.segundoApe.TabIndex = 260
        '
        'lblSegApe
        '
        Me.lblSegApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegApe.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSegApe.Location = New System.Drawing.Point(245, 285)
        Me.lblSegApe.Name = "lblSegApe"
        Me.lblSegApe.Size = New System.Drawing.Size(133, 23)
        Me.lblSegApe.TabIndex = 257
        Me.lblSegApe.Text = "2do apellido:"
        Me.lblSegApe.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'primerApe
        '
        Me.primerApe.Enabled = False
        Me.primerApe.Location = New System.Drawing.Point(136, 287)
        Me.primerApe.Name = "primerApe"
        Me.primerApe.Size = New System.Drawing.Size(111, 20)
        Me.primerApe.TabIndex = 261
        '
        'lblPrimApe
        '
        Me.lblPrimApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimApe.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPrimApe.Location = New System.Drawing.Point(24, 284)
        Me.lblPrimApe.Name = "lblPrimApe"
        Me.lblPrimApe.Size = New System.Drawing.Size(115, 23)
        Me.lblPrimApe.TabIndex = 258
        Me.lblPrimApe.Text = "1er apellido:"
        Me.lblPrimApe.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nom
        '
        Me.nom.Enabled = False
        Me.nom.Location = New System.Drawing.Point(853, 144)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(111, 20)
        Me.nom.TabIndex = 262
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNombre.Location = New System.Drawing.Point(776, 141)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(79, 23)
        Me.lblNombre.TabIndex = 259
        Me.lblNombre.Text = "Nombre:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnModificar.Location = New System.Drawing.Point(373, 578)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(277, 23)
        Me.btnModificar.TabIndex = 256
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'numPuerta
        '
        Me.numPuerta.Location = New System.Drawing.Point(614, 424)
        Me.numPuerta.Name = "numPuerta"
        Me.numPuerta.Size = New System.Drawing.Size(111, 20)
        Me.numPuerta.TabIndex = 254
        '
        'lblNum
        '
        Me.lblNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNum.Location = New System.Drawing.Point(501, 421)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(115, 23)
        Me.lblNum.TabIndex = 252
        Me.lblNum.Text = "Número:"
        Me.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'esq
        '
        Me.esq.Location = New System.Drawing.Point(375, 424)
        Me.esq.Name = "esq"
        Me.esq.Size = New System.Drawing.Size(111, 20)
        Me.esq.TabIndex = 255
        '
        'lblEsquina
        '
        Me.lblEsquina.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEsquina.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEsquina.Location = New System.Drawing.Point(264, 421)
        Me.lblEsquina.Name = "lblEsquina"
        Me.lblEsquina.Size = New System.Drawing.Size(115, 23)
        Me.lblEsquina.TabIndex = 251
        Me.lblEsquina.Text = "Esquina:"
        Me.lblEsquina.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'calle
        '
        Me.calle.Location = New System.Drawing.Point(136, 424)
        Me.calle.Name = "calle"
        Me.calle.Size = New System.Drawing.Size(111, 20)
        Me.calle.TabIndex = 253
        '
        'lblCalle
        '
        Me.lblCalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCalle.Location = New System.Drawing.Point(14, 421)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(123, 23)
        Me.lblCalle.TabIndex = 250
        Me.lblCalle.Text = "Calle:"
        Me.lblCalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fechaNac
        '
        Me.fechaNac.CustomFormat = "yyyy-MM-dd"
        Me.fechaNac.Enabled = False
        Me.fechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fechaNac.Location = New System.Drawing.Point(614, 284)
        Me.fechaNac.MaxDate = New Date(2020, 6, 5, 0, 0, 0, 0)
        Me.fechaNac.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.fechaNac.Name = "fechaNac"
        Me.fechaNac.Size = New System.Drawing.Size(111, 20)
        Me.fechaNac.TabIndex = 249
        Me.fechaNac.Value = New Date(2002, 7, 24, 0, 0, 0, 0)
        '
        'tel
        '
        Me.tel.Location = New System.Drawing.Point(853, 284)
        Me.tel.Name = "tel"
        Me.tel.Size = New System.Drawing.Size(111, 20)
        Me.tel.TabIndex = 248
        '
        'lblTel
        '
        Me.lblTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTel.Location = New System.Drawing.Point(744, 282)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(111, 23)
        Me.lblTel.TabIndex = 247
        Me.lblTel.Text = "Teléfono:"
        Me.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNacimiento
        '
        Me.lblNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacimiento.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNacimiento.Location = New System.Drawing.Point(498, 282)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(115, 23)
        Me.lblNacimiento.TabIndex = 246
        Me.lblNacimiento.Text = "Nacimiento:"
        Me.lblNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'sexo
        '
        Me.sexo.Enabled = False
        Me.sexo.FormattingEnabled = True
        Me.sexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.sexo.Location = New System.Drawing.Point(853, 424)
        Me.sexo.Name = "sexo"
        Me.sexo.Size = New System.Drawing.Size(111, 21)
        Me.sexo.TabIndex = 245
        '
        'lblSexo
        '
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSexo.Location = New System.Drawing.Point(782, 422)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(72, 23)
        Me.lblSexo.TabIndex = 244
        Me.lblSexo.Text = "Sexo:"
        Me.lblSexo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEspecialidad
        '
        Me.lblEspecialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspecialidad.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEspecialidad.Location = New System.Drawing.Point(380, 491)
        Me.lblEspecialidad.Name = "lblEspecialidad"
        Me.lblEspecialidad.Size = New System.Drawing.Size(124, 23)
        Me.lblEspecialidad.TabIndex = 259
        Me.lblEspecialidad.Text = "Especialidad:"
        Me.lblEspecialidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'especialidad
        '
        Me.especialidad.Enabled = False
        Me.especialidad.Location = New System.Drawing.Point(502, 494)
        Me.especialidad.Name = "especialidad"
        Me.especialidad.Size = New System.Drawing.Size(111, 20)
        Me.especialidad.TabIndex = 262
        '
        'lblMail
        '
        Me.lblMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMail.Location = New System.Drawing.Point(537, 141)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(79, 23)
        Me.lblMail.TabIndex = 259
        Me.lblMail.Text = "Mail:"
        Me.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mail
        '
        Me.mail.Enabled = False
        Me.mail.Location = New System.Drawing.Point(614, 144)
        Me.mail.Name = "mail"
        Me.mail.Size = New System.Drawing.Size(111, 20)
        Me.mail.TabIndex = 262
        '
        'InfoMedico
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
        Me.Controls.Add(Me.especialidad)
        Me.Controls.Add(Me.lblEspecialidad)
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
        Me.Name = "InfoMedico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mi información"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents contraseña As TextBox
    Friend WithEvents lblContraseña As Label
    Friend WithEvents ci As TextBox
    Friend WithEvents btnInfo As Label
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
    Friend WithEvents lblEspecialidad As Label
    Friend WithEvents especialidad As TextBox
    Friend WithEvents lblMail As Label
    Friend WithEvents mail As TextBox
End Class
