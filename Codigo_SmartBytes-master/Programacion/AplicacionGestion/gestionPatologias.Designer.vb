<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gestionPatologias
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
        Me.gravP = New System.Windows.Forms.ComboBox()
        Me.lblGravedad = New System.Windows.Forms.Label()
        Me.espP = New System.Windows.Forms.TextBox()
        Me.lblEspecialista = New System.Windows.Forms.Label()
        Me.nomP = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.codP = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.dgvPatologia = New System.Windows.Forms.DataGridView()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblGestionPatologias = New System.Windows.Forms.Label()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Especialista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gravedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvPatologia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gravP
        '
        Me.gravP.FormattingEnabled = True
        Me.gravP.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.gravP.Location = New System.Drawing.Point(219, 391)
        Me.gravP.Name = "gravP"
        Me.gravP.Size = New System.Drawing.Size(184, 21)
        Me.gravP.TabIndex = 160
        Me.gravP.Text = "1"
        '
        'lblGravedad
        '
        Me.lblGravedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGravedad.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblGravedad.Location = New System.Drawing.Point(118, 388)
        Me.lblGravedad.Name = "lblGravedad"
        Me.lblGravedad.Size = New System.Drawing.Size(102, 23)
        Me.lblGravedad.TabIndex = 153
        Me.lblGravedad.Text = "Gravedad:"
        Me.lblGravedad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'espP
        '
        Me.espP.Location = New System.Drawing.Point(219, 332)
        Me.espP.Name = "espP"
        Me.espP.Size = New System.Drawing.Size(184, 20)
        Me.espP.TabIndex = 157
        '
        'lblEspecialista
        '
        Me.lblEspecialista.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspecialista.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEspecialista.Location = New System.Drawing.Point(101, 329)
        Me.lblEspecialista.Name = "lblEspecialista"
        Me.lblEspecialista.Size = New System.Drawing.Size(119, 23)
        Me.lblEspecialista.TabIndex = 154
        Me.lblEspecialista.Text = "Especialista:"
        Me.lblEspecialista.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nomP
        '
        Me.nomP.Location = New System.Drawing.Point(219, 273)
        Me.nomP.Name = "nomP"
        Me.nomP.Size = New System.Drawing.Size(184, 20)
        Me.nomP.TabIndex = 158
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNombre.Location = New System.Drawing.Point(140, 270)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(80, 23)
        Me.lblNombre.TabIndex = 155
        Me.lblNombre.Text = "Nombre:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'codP
        '
        Me.codP.Location = New System.Drawing.Point(219, 214)
        Me.codP.Name = "codP"
        Me.codP.Size = New System.Drawing.Size(184, 20)
        Me.codP.TabIndex = 159
        '
        'lblCodigo
        '
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCodigo.Location = New System.Drawing.Point(147, 211)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(73, 23)
        Me.lblCodigo.TabIndex = 156
        Me.lblCodigo.Text = "Código:"
        Me.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgvPatologia
        '
        Me.dgvPatologia.AllowUserToAddRows = False
        Me.dgvPatologia.AllowUserToDeleteRows = False
        Me.dgvPatologia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPatologia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Nombre, Me.Especialista, Me.Gravedad})
        Me.dgvPatologia.Cursor = System.Windows.Forms.Cursors.IBeam
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPatologia.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPatologia.Location = New System.Drawing.Point(490, 214)
        Me.dgvPatologia.Name = "dgvPatologia"
        Me.dgvPatologia.ReadOnly = True
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Desktop
        Me.dgvPatologia.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPatologia.Size = New System.Drawing.Size(467, 262)
        Me.dgvPatologia.TabIndex = 152
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnActualizar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnActualizar.Location = New System.Drawing.Point(490, 509)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(467, 23)
        Me.btnActualizar.TabIndex = 150
        Me.btnActualizar.Text = "&Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnEliminar.Location = New System.Drawing.Point(339, 509)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(83, 23)
        Me.btnEliminar.TabIndex = 149
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnModificar.Location = New System.Drawing.Point(238, 509)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(83, 23)
        Me.btnModificar.TabIndex = 148
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnAgregar.Location = New System.Drawing.Point(137, 509)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(83, 23)
        Me.btnAgregar.TabIndex = 147
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'lblGestionPatologias
        '
        Me.lblGestionPatologias.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGestionPatologias.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblGestionPatologias.Location = New System.Drawing.Point(354, 72)
        Me.lblGestionPatologias.Name = "lblGestionPatologias"
        Me.lblGestionPatologias.Size = New System.Drawing.Size(304, 38)
        Me.lblGestionPatologias.TabIndex = 146
        Me.lblGestionPatologias.Text = "Gestión de patologías"
        Me.lblGestionPatologias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Especialista
        '
        Me.Especialista.HeaderText = "Especialista"
        Me.Especialista.Name = "Especialista"
        Me.Especialista.ReadOnly = True
        '
        'Gravedad
        '
        Me.Gravedad.HeaderText = "Gravedad"
        Me.Gravedad.Name = "Gravedad"
        Me.Gravedad.ReadOnly = True
        '
        'gestionPatologias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(1025, 650)
        Me.Controls.Add(Me.gravP)
        Me.Controls.Add(Me.lblGravedad)
        Me.Controls.Add(Me.espP)
        Me.Controls.Add(Me.lblEspecialista)
        Me.Controls.Add(Me.nomP)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.codP)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.dgvPatologia)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblGestionPatologias)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "gestionPatologias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestionar patologías"
        CType(Me.dgvPatologia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gravP As ComboBox
    Friend WithEvents lblGravedad As Label
    Friend WithEvents espP As TextBox
    Friend WithEvents lblEspecialista As Label
    Friend WithEvents nomP As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents codP As TextBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents dgvPatologia As DataGridView
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lblGestionPatologias As Label
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Especialista As DataGridViewTextBoxColumn
    Friend WithEvents Gravedad As DataGridViewTextBoxColumn
End Class
