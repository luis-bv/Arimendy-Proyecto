Public Class Informedeproveedores

    Private Sub Informedeproveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'inicioDataSet1.proveedor' Puede moverla o quitarla según sea necesario.
        Me.proveedorTableAdapter.Fill(Me.inicioDataSet1.proveedor)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class