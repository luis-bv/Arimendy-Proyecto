<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frminfromedeusuario
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.usuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.inicioDataSet = New WindowsApplication2.inicioDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.usuarioTableAdapter = New WindowsApplication2.inicioDataSetTableAdapters.usuarioTableAdapter()
        CType(Me.usuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inicioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'usuarioBindingSource
        '
        Me.usuarioBindingSource.DataMember = "usuario"
        Me.usuarioBindingSource.DataSource = Me.inicioDataSet
        '
        'inicioDataSet
        '
        Me.inicioDataSet.DataSetName = "inicioDataSet"
        Me.inicioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dataset_de_controldeusuario"
        ReportDataSource1.Value = Me.usuarioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication2.reportedeusuario.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(367, 366)
        Me.ReportViewer1.TabIndex = 0
        '
        'usuarioTableAdapter
        '
        Me.usuarioTableAdapter.ClearBeforeFill = True
        '
        'frminfromedeusuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 366)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frminfromedeusuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "informe"
        CType(Me.usuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inicioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents usuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents inicioDataSet As WindowsApplication2.inicioDataSet
    Friend WithEvents usuarioTableAdapter As WindowsApplication2.inicioDataSetTableAdapters.usuarioTableAdapter
End Class
