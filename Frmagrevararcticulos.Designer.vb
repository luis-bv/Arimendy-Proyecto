<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmagrevararcticulos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbarticulos = New System.Windows.Forms.ComboBox()
        Me.cmbcodigo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnuevacantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbprecio = New System.Windows.Forms.ComboBox()
        Me.label = New System.Windows.Forms.Label()
        Me.cmbmarca = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbDescripcion = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbcantidad = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdguardad = New System.Windows.Forms.Button()
        Me.txtcantidadtotal = New System.Windows.Forms.TextBox()
        Me.txtpreciototal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbproveedor = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdsalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Articulo"
        '
        'cmbarticulos
        '
        Me.cmbarticulos.FormattingEnabled = True
        Me.cmbarticulos.Location = New System.Drawing.Point(141, 48)
        Me.cmbarticulos.Name = "cmbarticulos"
        Me.cmbarticulos.Size = New System.Drawing.Size(145, 21)
        Me.cmbarticulos.TabIndex = 1
        '
        'cmbcodigo
        '
        Me.cmbcodigo.FormattingEnabled = True
        Me.cmbcodigo.Location = New System.Drawing.Point(141, 75)
        Me.cmbcodigo.Name = "cmbcodigo"
        Me.cmbcodigo.Size = New System.Drawing.Size(145, 21)
        Me.cmbcodigo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Codigo"
        '
        'txtnuevacantidad
        '
        Me.txtnuevacantidad.Location = New System.Drawing.Point(141, 283)
        Me.txtnuevacantidad.Name = "txtnuevacantidad"
        Me.txtnuevacantidad.Size = New System.Drawing.Size(145, 20)
        Me.txtnuevacantidad.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nueva Cantidad "
        '
        'cmbprecio
        '
        Me.cmbprecio.FormattingEnabled = True
        Me.cmbprecio.Location = New System.Drawing.Point(129, 117)
        Me.cmbprecio.Name = "cmbprecio"
        Me.cmbprecio.Size = New System.Drawing.Size(145, 21)
        Me.cmbprecio.TabIndex = 7
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(29, 129)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(37, 13)
        Me.label.TabIndex = 6
        Me.label.Text = "Precio"
        '
        'cmbmarca
        '
        Me.cmbmarca.FormattingEnabled = True
        Me.cmbmarca.Location = New System.Drawing.Point(141, 185)
        Me.cmbmarca.Name = "cmbmarca"
        Me.cmbmarca.Size = New System.Drawing.Size(145, 21)
        Me.cmbmarca.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Marca"
        '
        'cmbDescripcion
        '
        Me.cmbDescripcion.FormattingEnabled = True
        Me.cmbDescripcion.Location = New System.Drawing.Point(141, 212)
        Me.cmbDescripcion.Name = "cmbDescripcion"
        Me.cmbDescripcion.Size = New System.Drawing.Size(145, 21)
        Me.cmbDescripcion.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Descripcion"
        '
        'cmbcantidad
        '
        Me.cmbcantidad.FormattingEnabled = True
        Me.cmbcantidad.Location = New System.Drawing.Point(141, 102)
        Me.cmbcantidad.Name = "cmbcantidad"
        Me.cmbcantidad.Size = New System.Drawing.Size(145, 21)
        Me.cmbcantidad.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Cantidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 309)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Cantidad Total"
        '
        'cmdguardad
        '
        Me.cmdguardad.Location = New System.Drawing.Point(141, 364)
        Me.cmdguardad.Name = "cmdguardad"
        Me.cmdguardad.Size = New System.Drawing.Size(75, 23)
        Me.cmdguardad.TabIndex = 18
        Me.cmdguardad.Text = "Guardad"
        Me.cmdguardad.UseVisualStyleBackColor = True
        '
        'txtcantidadtotal
        '
        Me.txtcantidadtotal.Location = New System.Drawing.Point(141, 309)
        Me.txtcantidadtotal.Name = "txtcantidadtotal"
        Me.txtcantidadtotal.Size = New System.Drawing.Size(145, 20)
        Me.txtcantidadtotal.TabIndex = 19
        '
        'txtpreciototal
        '
        Me.txtpreciototal.Location = New System.Drawing.Point(141, 335)
        Me.txtpreciototal.Name = "txtpreciototal"
        Me.txtpreciototal.Size = New System.Drawing.Size(145, 20)
        Me.txtpreciototal.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 335)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Precio Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Proveedor"
        '
        'cmbproveedor
        '
        Me.cmbproveedor.FormattingEnabled = True
        Me.cmbproveedor.Location = New System.Drawing.Point(141, 158)
        Me.cmbproveedor.Name = "cmbproveedor"
        Me.cmbproveedor.Size = New System.Drawing.Size(145, 21)
        Me.cmbproveedor.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbprecio)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 240)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos de Almacen"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(12, 258)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 100)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Aumenta Producto"
        '
        'cmdsalir
        '
        Me.cmdsalir.Location = New System.Drawing.Point(225, 364)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdsalir.TabIndex = 24
        Me.cmdsalir.Text = "Salir"
        Me.cmdsalir.UseVisualStyleBackColor = True
        '
        'Frmagrevararcticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 394)
        Me.Controls.Add(Me.cmdsalir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbproveedor)
        Me.Controls.Add(Me.txtpreciototal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtcantidadtotal)
        Me.Controls.Add(Me.cmdguardad)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbcantidad)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbDescripcion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbmarca)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnuevacantidad)
        Me.Controls.Add(Me.cmbcodigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbarticulos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Frmagrevararcticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frmagrevararcticulos"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbarticulos As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcodigo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnuevacantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbprecio As System.Windows.Forms.ComboBox
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents cmbmarca As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbDescripcion As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbcantidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmdguardad As System.Windows.Forms.Button
    Friend WithEvents txtcantidadtotal As System.Windows.Forms.TextBox
    Friend WithEvents txtpreciototal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbproveedor As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdsalir As System.Windows.Forms.Button
End Class
