Public Class Informedeentradad

    Private Sub Informedeentradad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'inicioDataSet2.entrada' Puede moverla o quitarla según sea necesario.
        Me.entradaTableAdapter.Fill(Me.inicioDataSet2.entrada)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class