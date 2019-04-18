Public Class informedearcticulo

    Private Sub informedearcticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'inicioDataSet1.articulos' Puede moverla o quitarla según sea necesario.
        Me.articulosTableAdapter.Fill(Me.inicioDataSet1.articulos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class