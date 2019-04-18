<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Articulos
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtmarca = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbproveedor = New System.Windows.Forms.ComboBox()
        Me.cmdguardad = New System.Windows.Forms.Button()
        Me.cmdmordificar = New System.Windows.Forms.Button()
        Me.cmdeliminar = New System.Windows.Forms.Button()
        Me.cmdlimpiar = New System.Windows.Forms.Button()
        Me.Cmdimprimir = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(16, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(743, 204)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(68, 252)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(24, 20)
        Me.txtcodigo.TabIndex = 2
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(68, 278)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(155, 20)
        Me.txtnombre.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(68, 306)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(155, 20)
        Me.txtcantidad.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 306)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cantidad"
        '
        'Txtmarca
        '
        Me.Txtmarca.Location = New System.Drawing.Point(306, 278)
        Me.Txtmarca.Name = "Txtmarca"
        Me.Txtmarca.Size = New System.Drawing.Size(155, 20)
        Me.Txtmarca.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(251, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Marca"
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(306, 305)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(155, 20)
        Me.txtprecio.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(251, 305)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Precio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(482, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Proveedor"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(555, 305)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(155, 20)
        Me.txtdescripcion.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(482, 302)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Descripcion"
        '
        'cmbproveedor
        '
        Me.cmbproveedor.FormattingEnabled = True
        Me.cmbproveedor.Location = New System.Drawing.Point(555, 278)
        Me.cmbproveedor.Name = "cmbproveedor"
        Me.cmbproveedor.Size = New System.Drawing.Size(155, 21)
        Me.cmbproveedor.TabIndex = 15
        '
        'cmdguardad
        '
        Me.cmdguardad.Location = New System.Drawing.Point(68, 344)
        Me.cmdguardad.Name = "cmdguardad"
        Me.cmdguardad.Size = New System.Drawing.Size(75, 23)
        Me.cmdguardad.TabIndex = 16
        Me.cmdguardad.Text = "Guardad"
        Me.cmdguardad.UseVisualStyleBackColor = True
        '
        'cmdmordificar
        '
        Me.cmdmordificar.Location = New System.Drawing.Point(213, 344)
        Me.cmdmordificar.Name = "cmdmordificar"
        Me.cmdmordificar.Size = New System.Drawing.Size(75, 23)
        Me.cmdmordificar.TabIndex = 17
        Me.cmdmordificar.Text = "Mordificar"
        Me.cmdmordificar.UseVisualStyleBackColor = True
        '
        'cmdeliminar
        '
        Me.cmdeliminar.Location = New System.Drawing.Point(341, 344)
        Me.cmdeliminar.Name = "cmdeliminar"
        Me.cmdeliminar.Size = New System.Drawing.Size(75, 23)
        Me.cmdeliminar.TabIndex = 18
        Me.cmdeliminar.Text = "Eliminar"
        Me.cmdeliminar.UseVisualStyleBackColor = True
        '
        'cmdlimpiar
        '
        Me.cmdlimpiar.Location = New System.Drawing.Point(470, 344)
        Me.cmdlimpiar.Name = "cmdlimpiar"
        Me.cmdlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmdlimpiar.TabIndex = 19
        Me.cmdlimpiar.Text = "Limpiar"
        Me.cmdlimpiar.UseVisualStyleBackColor = True
        '
        'Cmdimprimir
        '
        Me.Cmdimprimir.Location = New System.Drawing.Point(600, 344)
        Me.Cmdimprimir.Name = "Cmdimprimir"
        Me.Cmdimprimir.Size = New System.Drawing.Size(75, 23)
        Me.Cmdimprimir.TabIndex = 20
        Me.Cmdimprimir.Text = "Imprimir"
        Me.Cmdimprimir.UseVisualStyleBackColor = True
        '
        'Articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 392)
        Me.Controls.Add(Me.Cmdimprimir)
        Me.Controls.Add(Me.cmdlimpiar)
        Me.Controls.Add(Me.cmdeliminar)
        Me.Controls.Add(Me.cmdmordificar)
        Me.Controls.Add(Me.cmdguardad)
        Me.Controls.Add(Me.cmbproveedor)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txtmarca)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Articulos"
        Me.Text = "Articulos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txtmarca As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbproveedor As System.Windows.Forms.ComboBox
    Friend WithEvents cmdguardad As System.Windows.Forms.Button
    Friend WithEvents cmdmordificar As System.Windows.Forms.Button
    Friend WithEvents cmdeliminar As System.Windows.Forms.Button
    Friend WithEvents cmdlimpiar As System.Windows.Forms.Button
    Friend WithEvents Cmdimprimir As System.Windows.Forms.Button
End Class
