<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informedeentradad
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.inicioDataSet2 = New WindowsApplication2.inicioDataSet2()
        Me.entradaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.entradaTableAdapter = New WindowsApplication2.inicioDataSet2TableAdapters.entradaTableAdapter()
        CType(Me.inicioDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.entradaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.entradaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication2.Reportdenetradad.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(700, 308)
        Me.ReportViewer1.TabIndex = 0
        '
        'inicioDataSet2
        '
        Me.inicioDataSet2.DataSetName = "inicioDataSet2"
        Me.inicioDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'entradaBindingSource
        '
        Me.entradaBindingSource.DataMember = "entrada"
        Me.entradaBindingSource.DataSource = Me.inicioDataSet2
        '
        'entradaTableAdapter
        '
        Me.entradaTableAdapter.ClearBeforeFill = True
        '
        'Informedeentradad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 308)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Informedeentradad"
        Me.Text = "Informedeentradad"
        CType(Me.inicioDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.entradaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents entradaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents inicioDataSet2 As WindowsApplication2.inicioDataSet2
    Friend WithEvents entradaTableAdapter As WindowsApplication2.inicioDataSet2TableAdapters.entradaTableAdapter
End Class
