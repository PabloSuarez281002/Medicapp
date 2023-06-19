<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gestionSintomas
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
        Me.nomS = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.codS = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.dgvSintomas = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblGestionSintomas = New System.Windows.Forms.Label()
        CType(Me.dgvSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nomS
        '
        Me.nomS.Location = New System.Drawing.Point(223, 341)
        Me.nomS.Name = "nomS"
        Me.nomS.Size = New System.Drawing.Size(184, 20)
        Me.nomS.TabIndex = 142
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNombre.Location = New System.Drawing.Point(144, 338)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(80, 23)
        Me.lblNombre.TabIndex = 140
        Me.lblNombre.Text = "Nombre:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'codS
        '
        Me.codS.Location = New System.Drawing.Point(223, 285)
        Me.codS.Name = "codS"
        Me.codS.Size = New System.Drawing.Size(184, 20)
        Me.codS.TabIndex = 143
        '
        'lblCodigo
        '
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCodigo.Location = New System.Drawing.Point(151, 282)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(73, 23)
        Me.lblCodigo.TabIndex = 141
        Me.lblCodigo.Text = "Código:"
        Me.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgvSintomas
        '
        Me.dgvSintomas.AllowUserToAddRows = False
        Me.dgvSintomas.AllowUserToDeleteRows = False
        Me.dgvSintomas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSintomas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgvSintomas.Cursor = System.Windows.Forms.Cursors.IBeam
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSintomas.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSintomas.Location = New System.Drawing.Point(500, 213)
        Me.dgvSintomas.Name = "dgvSintomas"
        Me.dgvSintomas.ReadOnly = True
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Desktop
        Me.dgvSintomas.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSintomas.Size = New System.Drawing.Size(416, 262)
        Me.dgvSintomas.TabIndex = 139
        '
        'Column1
        '
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnActualizar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnActualizar.Location = New System.Drawing.Point(500, 508)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(416, 23)
        Me.btnActualizar.TabIndex = 137
        Me.btnActualizar.Text = "&Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnEliminar.Location = New System.Drawing.Point(352, 508)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(83, 23)
        Me.btnEliminar.TabIndex = 136
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnModificar.Location = New System.Drawing.Point(251, 508)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(83, 23)
        Me.btnModificar.TabIndex = 135
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnAgregar.Location = New System.Drawing.Point(150, 508)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(83, 23)
        Me.btnAgregar.TabIndex = 134
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'lblGestionSintomas
        '
        Me.lblGestionSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGestionSintomas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblGestionSintomas.Location = New System.Drawing.Point(297, 72)
        Me.lblGestionSintomas.Name = "lblGestionSintomas"
        Me.lblGestionSintomas.Size = New System.Drawing.Size(472, 38)
        Me.lblGestionSintomas.TabIndex = 133
        Me.lblGestionSintomas.Text = "Gestión de síntomas"
        Me.lblGestionSintomas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gestionSintomas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(1025, 650)
        Me.Controls.Add(Me.nomS)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.codS)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.dgvSintomas)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblGestionSintomas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "gestionSintomas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "gestionSintomas"
        CType(Me.dgvSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nomS As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents codS As TextBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents dgvSintomas As DataGridView
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lblGestionSintomas As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
