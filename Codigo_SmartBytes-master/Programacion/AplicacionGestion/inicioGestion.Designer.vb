<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inicioGestion
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
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.lblBuenaJornada = New System.Windows.Forms.Label()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblBienvenido
        '
        Me.lblBienvenido.AutoSize = True
        Me.lblBienvenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenido.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblBienvenido.Location = New System.Drawing.Point(352, 247)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(399, 73)
        Me.lblBienvenido.TabIndex = 1
        Me.lblBienvenido.Text = "¡Bienvenido!"
        Me.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBuenaJornada
        '
        Me.lblBuenaJornada.AutoSize = True
        Me.lblBuenaJornada.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuenaJornada.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblBuenaJornada.Location = New System.Drawing.Point(420, 332)
        Me.lblBuenaJornada.Name = "lblBuenaJornada"
        Me.lblBuenaJornada.Size = New System.Drawing.Size(263, 26)
        Me.lblBuenaJornada.TabIndex = 1
        Me.lblBuenaJornada.Text = "Que tenga buena jornada."
        Me.lblBuenaJornada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelFecha
        '
        Me.labelFecha.AutoSize = True
        Me.labelFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labelFecha.Location = New System.Drawing.Point(893, 615)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.labelFecha.Size = New System.Drawing.Size(0, 26)
        Me.labelFecha.TabIndex = 1
        Me.labelFecha.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'inicioGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(1025, 650)
        Me.Controls.Add(Me.labelFecha)
        Me.Controls.Add(Me.lblBuenaJornada)
        Me.Controls.Add(Me.lblBienvenido)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "inicioGestion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBienvenido As Label
    Friend WithEvents lblBuenaJornada As Label
    Friend WithEvents labelFecha As Label
End Class
