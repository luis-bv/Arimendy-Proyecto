Imports System.Data.SqlClient
Public Class frmentradad

    Private Sub frmentradad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostar() 'para llenar la tabla de entrada 
    End Sub
    Sub mostar()
        Dim da As New SqlDataAdapter("select * from entrada", con)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt


    End Sub

    Private Sub cmdimprimir_Click(sender As Object, e As EventArgs) Handles cmdimprimir.Click
        Informedeentradad.Show()
    End Sub
End Class