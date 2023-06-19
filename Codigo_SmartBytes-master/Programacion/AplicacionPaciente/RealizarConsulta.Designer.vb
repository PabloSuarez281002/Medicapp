<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RealizarConsulta
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
        Me.lblRC = New System.Windows.Forms.Label()
        Me.btnRC = New System.Windows.Forms.Button()
        Me.listaSintomas = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'lblRC
        '
        Me.lblRC.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRC.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRC.Location = New System.Drawing.Point(350, 61)
        Me.lblRC.Name = "lblRC"
        Me.lblRC.Size = New System.Drawing.Size(313, 38)
        Me.lblRC.TabIndex = 152
        Me.lblRC.Text = "Realizar una consulta"
        Me.lblRC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRC
        '
        Me.btnRC.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRC.Location = New System.Drawing.Point(304, 559)
        Me.btnRC.Name = "btnRC"
        Me.btnRC.Size = New System.Drawing.Size(404, 23)
        Me.btnRC.TabIndex = 150
        Me.btnRC.Text = "&Realizar consulta"
        Me.btnRC.UseVisualStyleBackColor = False
        '
        'listaSintomas
        '
        Me.listaSintomas.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.listaSintomas.CausesValidation = False
        Me.listaSintomas.CheckOnClick = True
        Me.listaSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listaSintomas.ForeColor = System.Drawing.SystemColors.Window
        Me.listaSintomas.FormattingEnabled = True
        Me.listaSintomas.Location = New System.Drawing.Point(242, 139)
        Me.listaSintomas.Name = "listaSintomas"
        Me.listaSintomas.Size = New System.Drawing.Size(529, 382)
        Me.listaSintomas.Sorted = True
        Me.listaSintomas.TabIndex = 147
        '
        'RealizarConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(1025, 650)
        Me.Controls.Add(Me.lblRC)
        Me.Controls.Add(Me.btnRC)
        Me.Controls.Add(Me.listaSintomas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RealizarConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Realizar Consulta"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblRC As Label
    Friend WithEvents btnRC As Button
    Friend WithEvents listaSintomas As CheckedListBox
End Class
