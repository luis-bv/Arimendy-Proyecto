Public Class frminfromedeusuario

    Private Sub informe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'inicioDataSet.usuario' Puede moverla o quitarla según sea necesario.
        Me.usuarioTableAdapter.Fill(Me.inicioDataSet.usuario)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class