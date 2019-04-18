Imports System.Data.SqlClient
Public Class frmregritodeproveedor


    Private Sub frmregritodeproveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostar() ' para mostar datos en la tabla de el proveedor 

    End Sub
    Sub mostar() 'para llenar la tabla de el proveedor
        Dim da As New SqlDataAdapter("select * from proveedor ", con)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub cmdguardad_Click(sender As Object, e As EventArgs) Handles cmdguardad.Click
        'hay que arregla el error de que se guarde en vacico la base de datos
        'hay que validad la entrada 
        Try
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "insert into proveedor (nombre,tel,RCN,direccion,email)values(@nombre,@tel,@RCN,@direccion,@email)"
            cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)
            cmd.Parameters.AddWithValue("@RCN", txtrcn.Text)
            cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text)
            cmd.Parameters.AddWithValue("@email", txtemail.Text)
            cmd.Parameters.AddWithValue("@tel", txttel.Text)
            Dim x As Integer = cmd.ExecuteNonQuery
            If x > 0 Then
                mostar()
                MessageBox.Show("Datos guardado correctamente", "GUARDADO")
            Else
                MessageBox.Show("NOSE A GUARDADO NADA")

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdmodificar_Click(sender As Object, e As EventArgs) Handles cmdmodificar.Click
        'hay que validad la entrada
        Try
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "update proveedor set nombre=@nombre,RCN=@RCN,direccion=@direccion,email=@email,tel=@tel where codigo=@codigo"
            cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)
            cmd.Parameters.AddWithValue("@RCN", txtrcn.Text)
            cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text)
            cmd.Parameters.AddWithValue("@email", txtemail.Text)
            cmd.Parameters.AddWithValue("@tel", txttel.Text)
            cmd.Parameters.AddWithValue("@codigo", txtcodigo.Text)
            Dim x As Integer = cmd.ExecuteNonQuery
            If x > 0 Then
                mostar()
                MessageBox.Show("Datos Acualizado correctamente", "GUARDADO")
            Else
                MessageBox.Show("NOSE A ACTUALIZADO  NADA")

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdeliminar_Click(sender As Object, e As EventArgs) Handles cmdeliminar.Click
        'hay que valida entrada
        Try
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "delete proveedor where codigo=@codigo"

            cmd.Parameters.AddWithValue("@codigo", txtcodigo.Text)
            Dim x As Integer = cmd.ExecuteNonQuery
            If x > 0 Then
                mostar()
                MessageBox.Show("Datos Borrado correctamente", "GUARDADO")
            Else
                MessageBox.Show("NOSE A Borrado  NADA")

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdlimpiar_Click(sender As Object, e As EventArgs) Handles cmdlimpiar.Click
        'button para limpiar
        txtcodigo.Clear()
        txtdireccion.Clear()
        txtemail.Clear()
        txtnombre.Clear()
        txtrcn.Clear()
        txttel.Clear()
    End Sub

    Private Sub Cmdimprimir_Click(sender As Object, e As EventArgs) Handles Cmdimprimir.Click
        Informedeproveedores.Show()
    End Sub
End Class