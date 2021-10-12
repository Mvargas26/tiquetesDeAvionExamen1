<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OPERACIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONFIGURACIÓNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACERCADEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPERACIONESToolStripMenuItem, Me.CONFIGURACIÓNToolStripMenuItem, Me.ACERCADEToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1182, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OPERACIONESToolStripMenuItem
        '
        Me.OPERACIONESToolStripMenuItem.Name = "OPERACIONESToolStripMenuItem"
        Me.OPERACIONESToolStripMenuItem.Size = New System.Drawing.Size(120, 24)
        Me.OPERACIONESToolStripMenuItem.Text = "OPERACIONES"
        '
        'CONFIGURACIÓNToolStripMenuItem
        '
        Me.CONFIGURACIÓNToolStripMenuItem.Name = "CONFIGURACIÓNToolStripMenuItem"
        Me.CONFIGURACIÓNToolStripMenuItem.Size = New System.Drawing.Size(139, 24)
        Me.CONFIGURACIÓNToolStripMenuItem.Text = "CONFIGURACIÓN"
        '
        'ACERCADEToolStripMenuItem
        '
        Me.ACERCADEToolStripMenuItem.Name = "ACERCADEToolStripMenuItem"
        Me.ACERCADEToolStripMenuItem.Size = New System.Drawing.Size(101, 24)
        Me.ACERCADEToolStripMenuItem.Text = "ACERCA DE"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(61, 24)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 753)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "frmPrincipal"
        Me.Text = "ventana Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OPERACIONESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONFIGURACIÓNToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ACERCADEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
End Class
