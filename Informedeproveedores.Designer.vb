﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informedeproveedores
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
        Me.proveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.inicioDataSet1 = New WindowsApplication2.inicioDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.proveedorTableAdapter = New WindowsApplication2.inicioDataSet1TableAdapters.proveedorTableAdapter()
        CType(Me.proveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inicioDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'proveedorBindingSource
        '
        Me.proveedorBindingSource.DataMember = "proveedor"
        Me.proveedorBindingSource.DataSource = Me.inicioDataSet1
        '
        'inicioDataSet1
        '
        Me.inicioDataSet1.DataSetName = "inicioDataSet1"
        Me.inicioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.proveedorBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication2.Reportdeproveedor.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(767, 333)
        Me.ReportViewer1.TabIndex = 0
        '
        'proveedorTableAdapter
        '
        Me.proveedorTableAdapter.ClearBeforeFill = True
        '
        'Informedeproveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 333)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Informedeproveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informedeproveedores"
        CType(Me.proveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inicioDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents proveedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents inicioDataSet1 As WindowsApplication2.inicioDataSet1
    Friend WithEvents proveedorTableAdapter As WindowsApplication2.inicioDataSet1TableAdapters.proveedorTableAdapter
End Class
