<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmregritodeproveedor
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
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txttel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtrcn = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdguardad = New System.Windows.Forms.Button()
        Me.cmdmodificar = New System.Windows.Forms.Button()
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
        Me.DataGridView1.Location = New System.Drawing.Point(12, 26)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(655, 194)
        Me.DataGridView1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(70, 264)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(126, 20)
        Me.txtnombre.TabIndex = 3
        '
        'txttel
        '
        Me.txttel.Location = New System.Drawing.Point(296, 264)
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(126, 20)
        Me.txttel.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(238, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tel"
        '
        'txtrcn
        '
        Me.txtrcn.Location = New System.Drawing.Point(296, 238)
        Me.txtrcn.Name = "txtrcn"
        Me.txtrcn.Size = New System.Drawing.Size(126, 20)
        Me.txtrcn.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(238, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "RCN"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(541, 264)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(126, 20)
        Me.txtemail.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(483, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Email"
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(541, 235)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(126, 20)
        Me.txtdireccion.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(483, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Direccion"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(70, 235)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(41, 20)
        Me.txtcodigo.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Codigo"
        '
        'cmdguardad
        '
        Me.cmdguardad.Location = New System.Drawing.Point(70, 305)
        Me.cmdguardad.Name = "cmdguardad"
        Me.cmdguardad.Size = New System.Drawing.Size(75, 23)
        Me.cmdguardad.TabIndex = 14
        Me.cmdguardad.Text = "Guardad"
        Me.cmdguardad.UseVisualStyleBackColor = True
        '
        'cmdmodificar
        '
        Me.cmdmodificar.Location = New System.Drawing.Point(193, 305)
        Me.cmdmodificar.Name = "cmdmodificar"
        Me.cmdmodificar.Size = New System.Drawing.Size(75, 23)
        Me.cmdmodificar.TabIndex = 15
        Me.cmdmodificar.Text = "Mordificar"
        Me.cmdmodificar.UseVisualStyleBackColor = True
        '
        'cmdeliminar
        '
        Me.cmdeliminar.Location = New System.Drawing.Point(347, 305)
        Me.cmdeliminar.Name = "cmdeliminar"
        Me.cmdeliminar.Size = New System.Drawing.Size(75, 23)
        Me.cmdeliminar.TabIndex = 16
        Me.cmdeliminar.Text = "Eliminar"
        Me.cmdeliminar.UseVisualStyleBackColor = True
        '
        'cmdlimpiar
        '
        Me.cmdlimpiar.Location = New System.Drawing.Point(460, 305)
        Me.cmdlimpiar.Name = "cmdlimpiar"
        Me.cmdlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmdlimpiar.TabIndex = 17
        Me.cmdlimpiar.Text = "Limpíar"
        Me.cmdlimpiar.UseVisualStyleBackColor = True
        '
        'Cmdimprimir
        '
        Me.Cmdimprimir.Location = New System.Drawing.Point(574, 305)
        Me.Cmdimprimir.Name = "Cmdimprimir"
        Me.Cmdimprimir.Size = New System.Drawing.Size(75, 23)
        Me.Cmdimprimir.TabIndex = 18
        Me.Cmdimprimir.Text = "Imprimir"
        Me.Cmdimprimir.UseVisualStyleBackColor = True
        '
        'frmregritodeproveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 346)
        Me.Controls.Add(Me.Cmdimprimir)
        Me.Controls.Add(Me.cmdlimpiar)
        Me.Controls.Add(Me.cmdeliminar)
        Me.Controls.Add(Me.cmdmodificar)
        Me.Controls.Add(Me.cmdguardad)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtrcn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txttel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmregritodeproveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Regritos de Proveedor"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txttel As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtrcn As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdguardad As System.Windows.Forms.Button
    Friend WithEvents cmdmodificar As System.Windows.Forms.Button
    Friend WithEvents cmdeliminar As System.Windows.Forms.Button
    Friend WithEvents cmdlimpiar As System.Windows.Forms.Button
    Friend WithEvents Cmdimprimir As System.Windows.Forms.Button
End Class
