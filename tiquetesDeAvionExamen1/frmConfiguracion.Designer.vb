<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracion
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
        Me.cmbColores = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCambiarColor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbColores
        '
        Me.cmbColores.FormattingEnabled = True
        Me.cmbColores.Location = New System.Drawing.Point(222, 90)
        Me.cmbColores.Name = "cmbColores"
        Me.cmbColores.Size = New System.Drawing.Size(380, 24)
        Me.cmbColores.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(315, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Elija el color de letra que desea"
        '
        'btnCambiarColor
        '
        Me.btnCambiarColor.Location = New System.Drawing.Point(294, 273)
        Me.btnCambiarColor.Name = "btnCambiarColor"
        Me.btnCambiarColor.Size = New System.Drawing.Size(236, 23)
        Me.btnCambiarColor.TabIndex = 3
        Me.btnCambiarColor.Text = "Cambiar Color"
        Me.btnCambiarColor.UseVisualStyleBackColor = True
        '
        'frmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCambiarColor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbColores)
        Me.Name = "frmConfiguracion"
        Me.Text = "Configuracion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbColores As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCambiarColor As Button
End Class
