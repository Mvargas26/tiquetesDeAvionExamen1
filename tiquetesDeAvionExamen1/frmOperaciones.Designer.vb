<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperaciones
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.btnComprar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpFechaViaje = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.cmbPaisDestino = New System.Windows.Forms.ComboBox()
        Me.cmbPaisOrigen = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paisDestino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidadTiquetes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valorTiquete = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.impuestos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblIVA = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.btnComprar)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.dtpFechaViaje)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtCedula)
        Me.GroupBox1.Controls.Add(Me.cmbPaisDestino)
        Me.GroupBox1.Controls.Add(Me.cmbPaisOrigen)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(605, 407)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tiquetes deViaje:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(160, 346)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(126, 22)
        Me.txtCantidad.TabIndex = 11
        '
        'btnComprar
        '
        Me.btnComprar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprar.Location = New System.Drawing.Point(478, 330)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(113, 50)
        Me.btnComprar.TabIndex = 8
        Me.btnComprar.Text = "Comprar"
        Me.btnComprar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(39, 318)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 17)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Cantidad Tiquetes:"
        '
        'dtpFechaViaje
        '
        Me.dtpFechaViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaViaje.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaViaje.Location = New System.Drawing.Point(184, 170)
        Me.dtpFechaViaje.Name = "dtpFechaViaje"
        Me.dtpFechaViaje.Size = New System.Drawing.Size(195, 34)
        Me.dtpFechaViaje.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fecha salida del Viaje:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(75, 278)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(343, 22)
        Me.txtNombre.TabIndex = 7
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(75, 223)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(343, 22)
        Me.txtCedula.TabIndex = 6
        '
        'cmbPaisDestino
        '
        Me.cmbPaisDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPaisDestino.FormattingEnabled = True
        Me.cmbPaisDestino.Location = New System.Drawing.Point(75, 108)
        Me.cmbPaisDestino.Name = "cmbPaisDestino"
        Me.cmbPaisDestino.Size = New System.Drawing.Size(343, 24)
        Me.cmbPaisDestino.TabIndex = 5
        '
        'cmbPaisOrigen
        '
        Me.cmbPaisOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPaisOrigen.FormattingEnabled = True
        Me.cmbPaisOrigen.Location = New System.Drawing.Point(75, 50)
        Me.cmbPaisOrigen.Name = "cmbPaisOrigen"
        Me.cmbPaisOrigen.Size = New System.Drawing.Size(343, 24)
        Me.cmbPaisOrigen.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombre Completo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cedula o ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "País de Destino:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "País de Origen:"
        '
        'dgvDatos
        '
        Me.dgvDatos.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre, Me.paisDestino, Me.cantidadTiquetes, Me.valorTiquete, Me.impuestos})
        Me.dgvDatos.Location = New System.Drawing.Point(12, 437)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.RowHeadersWidth = 51
        Me.dgvDatos.RowTemplate.Height = 24
        Me.dgvDatos.Size = New System.Drawing.Size(776, 200)
        Me.dgvDatos.TabIndex = 1
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.MinimumWidth = 6
        Me.nombre.Name = "nombre"
        Me.nombre.Width = 125
        '
        'paisDestino
        '
        Me.paisDestino.HeaderText = "Pais de Destino"
        Me.paisDestino.MinimumWidth = 6
        Me.paisDestino.Name = "paisDestino"
        Me.paisDestino.Width = 125
        '
        'cantidadTiquetes
        '
        Me.cantidadTiquetes.HeaderText = "Cantidad de Tiquetes"
        Me.cantidadTiquetes.MinimumWidth = 6
        Me.cantidadTiquetes.Name = "cantidadTiquetes"
        Me.cantidadTiquetes.Width = 125
        '
        'valorTiquete
        '
        Me.valorTiquete.HeaderText = "Valor del Tiquete"
        Me.valorTiquete.MinimumWidth = 6
        Me.valorTiquete.Name = "valorTiquete"
        Me.valorTiquete.Width = 125
        '
        'impuestos
        '
        Me.impuestos.HeaderText = "Impuestos"
        Me.impuestos.MinimumWidth = 6
        Me.impuestos.Name = "impuestos"
        Me.impuestos.Width = 125
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Sub Total:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "I.V.A:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 17)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Total:"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(116, 28)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(160, 23)
        Me.lblSubTotal.TabIndex = 5
        Me.lblSubTotal.Text = "-"
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblIVA
        '
        Me.lblIVA.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIVA.Location = New System.Drawing.Point(116, 58)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(160, 23)
        Me.lblIVA.TabIndex = 6
        Me.lblIVA.Text = "-"
        Me.lblIVA.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(116, 88)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(160, 23)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "-"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblIVA)
        Me.GroupBox2.Controls.Add(Me.lblSubTotal)
        Me.GroupBox2.Location = New System.Drawing.Point(491, 643)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(282, 118)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle Pago en Dolares"
        '
        'frmOperaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 773)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmOperaciones"
        Me.Text = "Operaciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpFechaViaje As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents cmbPaisDestino As ComboBox
    Friend WithEvents cmbPaisOrigen As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblIVA As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents btnComprar As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents paisDestino As DataGridViewTextBoxColumn
    Friend WithEvents cantidadTiquetes As DataGridViewTextBoxColumn
    Friend WithEvents valorTiquete As DataGridViewTextBoxColumn
    Friend WithEvents impuestos As DataGridViewTextBoxColumn
End Class
