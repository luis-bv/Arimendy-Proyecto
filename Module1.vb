Imports System.Data.SqlClient
Module Module1
    Public con As New SqlConnection
    Public Sub conectar()
        Try
            con.ConnectionString = "Data Source=adrian-pc;Initial Catalog=inicio;Integrated Security=True"
            con.Open()
            MessageBox.Show(con.State.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
