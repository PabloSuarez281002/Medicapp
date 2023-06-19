<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsociarSintomasYPatologias
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnDesasociar = New System.Windows.Forms.Button()
        Me.btnAsociar = New System.Windows.Forms.Button()
        Me.lblSintoma = New System.Windows.Forms.Label()
        Me.lblPatologia = New System.Windows.Forms.Label()
        Me.dgvSintomasAsociados = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbSintoma = New System.Windows.Forms.ComboBox()
        Me.cmbPatologia = New System.Windows.Forms.ComboBox()
        Me.lblAsociarSP = New System.Windows.Forms.Label()
        CType(Me.dgvSintomasAsociados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnActualizar.Location = New System.Drawing.Point(530, 451)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(244, 23)
        Me.btnActualizar.TabIndex = 159
        Me.btnActualizar.Text = "&Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnDesasociar
        '
        Me.btnDesasociar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDesasociar.Location = New System.Drawing.Point(403, 451)
        Me.btnDesasociar.Name = "btnDesasociar"
        Me.btnDesasociar.Size = New System.Drawing.Size(95, 23)
        Me.btnDesasociar.TabIndex = 161
        Me.btnDesasociar.Text = "&Desasociar"
        Me.btnDesasociar.UseVisualStyleBackColor = False
        '
        'btnAsociar
        '
        Me.btnAsociar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAsociar.Location = New System.Drawing.Point(281, 451)
        Me.btnAsociar.Name = "btnAsociar"
        Me.btnAsociar.Size = New System.Drawing.Size(95, 23)
        Me.btnAsociar.TabIndex = 162
        Me.btnAsociar.Text = "&Asociar"
        Me.btnAsociar.UseVisualStyleBackColor = False
        '
        'lblSintoma
        '
        Me.lblSintoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSintoma.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSintoma.Location = New System.Drawing.Point(139, 368)
        Me.lblSintoma.Name = "lblSintoma"
        Me.lblSintoma.Size = New System.Drawing.Size(219, 23)
        Me.lblSintoma.TabIndex = 157
        Me.lblSintoma.Text = "Síntoma:"
        Me.lblSintoma.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPatologia
        '
        Me.lblPatologia.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatologia.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPatologia.Location = New System.Drawing.Point(171, 280)
        Me.lblPatologia.Name = "lblPatologia"
        Me.lblPatologia.Size = New System.Drawing.Size(187, 23)
        Me.lblPatologia.TabIndex = 158
        Me.lblPatologia.Text = "Patología:"
        Me.lblPatologia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgvSintomasAsociados
        '
        Me.dgvSintomasAsociados.AllowUserToAddRows = False
        Me.dgvSintomasAsociados.AllowUserToDeleteRows = False
        Me.dgvSintomasAsociados.AllowUserToOrderColumns = True
        Me.dgvSintomasAsociados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSintomasAsociados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.Nombre})
        Me.dgvSintomasAsociados.Cursor = System.Windows.Forms.Cursors.IBeam
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSintomasAsociados.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSintomasAsociados.Location = New System.Drawing.Point(530, 246)
        Me.dgvSintomasAsociados.Name = "dgvSintomasAsociados"
        Me.dgvSintomasAsociados.ReadOnly = True
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Desktop
        Me.dgvSintomasAsociados.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSintomasAsociados.Size = New System.Drawing.Size(244, 196)
        Me.dgvSintomasAsociados.TabIndex = 156
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'cmbSintoma
        '
        Me.cmbSintoma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSintoma.FormattingEnabled = True
        Me.cmbSintoma.Location = New System.Drawing.Point(362, 371)
        Me.cmbSintoma.Name = "cmbSintoma"
        Me.cmbSintoma.Size = New System.Drawing.Size(136, 21)
        Me.cmbSintoma.TabIndex = 154
        '
        'cmbPatologia
        '
        Me.cmbPatologia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPatologia.FormattingEnabled = True
        Me.cmbPatologia.Location = New System.Drawing.Point(362, 283)
        Me.cmbPatologia.Name = "cmbPatologia"
        Me.cmbPatologia.Size = New System.Drawing.Size(136, 21)
        Me.cmbPatologia.TabIndex = 155
        '
        'lblAsociarSP
        '
        Me.lblAsociarSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsociarSP.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAsociarSP.Location = New System.Drawing.Point(209, 64)
        Me.lblAsociarSP.Name = "lblAsociarSP"
        Me.lblAsociarSP.Size = New System.Drawing.Size(597, 38)
        Me.lblAsociarSP.TabIndex = 153
        Me.lblAsociarSP.Text = "Asociar síntomas y patologías"
        Me.lblAsociarSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AsociarSintomasYPatologias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(1025, 650)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnDesasociar)
        Me.Controls.Add(Me.btnAsociar)
        Me.Controls.Add(Me.lblSintoma)
        Me.Controls.Add(Me.lblPatologia)
        Me.Controls.Add(Me.dgvSintomasAsociados)
        Me.Controls.Add(Me.cmbSintoma)
        Me.Controls.Add(Me.cmbPatologia)
        Me.Controls.Add(Me.lblAsociarSP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AsociarSintomasYPatologias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AsociarSintomasYPatologias"
        CType(Me.dgvSintomasAsociados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnDesasociar As Button
    Friend WithEvents btnAsociar As Button
    Friend WithEvents lblSintoma As Label
    Friend WithEvents lblPatologia As Label
    Friend WithEvents dgvSintomasAsociados As DataGridView
    Friend WithEvents cmbSintoma As ComboBox
    Friend WithEvents cmbPatologia As ComboBox
    Friend WithEvents lblAsociarSP As Label
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
End Class
