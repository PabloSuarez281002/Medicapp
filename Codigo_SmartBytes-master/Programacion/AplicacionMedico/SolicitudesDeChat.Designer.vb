<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SolicitudesDeChat
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvChatsDisponibles = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSolicitudes = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDobleClick = New System.Windows.Forms.Label()
        CType(Me.dgvChatsDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvChatsDisponibles
        '
        Me.dgvChatsDisponibles.AllowUserToAddRows = False
        Me.dgvChatsDisponibles.AllowUserToDeleteRows = False
        Me.dgvChatsDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvChatsDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChatsDisponibles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvChatsDisponibles.Cursor = System.Windows.Forms.Cursors.IBeam
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvChatsDisponibles.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvChatsDisponibles.Location = New System.Drawing.Point(169, 183)
        Me.dgvChatsDisponibles.Name = "dgvChatsDisponibles"
        Me.dgvChatsDisponibles.ReadOnly = True
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Desktop
        Me.dgvChatsDisponibles.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvChatsDisponibles.Size = New System.Drawing.Size(696, 399)
        Me.dgvChatsDisponibles.TabIndex = 130
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo Diagnóstico"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Ci del paciente"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Patología"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Gravedad"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'lblSolicitudes
        '
        Me.lblSolicitudes.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSolicitudes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSolicitudes.Location = New System.Drawing.Point(337, 61)
        Me.lblSolicitudes.Name = "lblSolicitudes"
        Me.lblSolicitudes.Size = New System.Drawing.Size(320, 38)
        Me.lblSolicitudes.TabIndex = 152
        Me.lblSolicitudes.Text = "Solicitudes de chat"
        Me.lblSolicitudes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblDobleClick
        '
        Me.lblDobleClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDobleClick.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDobleClick.Location = New System.Drawing.Point(644, 165)
        Me.lblDobleClick.Name = "lblDobleClick"
        Me.lblDobleClick.Size = New System.Drawing.Size(221, 15)
        Me.lblDobleClick.TabIndex = 152
        Me.lblDobleClick.Text = "(Debes hacer doble click para entrar al chat)"
        Me.lblDobleClick.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'SolicitudesDeChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(1025, 650)
        Me.Controls.Add(Me.lblDobleClick)
        Me.Controls.Add(Me.lblSolicitudes)
        Me.Controls.Add(Me.dgvChatsDisponibles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SolicitudesDeChat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitudes de chat"
        CType(Me.dgvChatsDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvChatsDisponibles As DataGridView
    Friend WithEvents lblSolicitudes As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblDobleClick As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
