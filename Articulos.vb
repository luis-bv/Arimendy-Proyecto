Imports System.Data.SqlClient
Public Class Articulos

    Private Sub Articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostar() ' para mostar los datos de la tabla
        mostarcmb() 'para mostar los datos de el commbox de proveedor
        cmbproveedor.Text = "" 'para que el commbox esta vacios cuando se inicia el programa por primera ver
    End Sub
    Sub mostar() 'para mostar los datos de la tabla articulos
        Dim da As New SqlDataAdapter("select * from articulos", con)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Sub mostarcmb() 'mustar los datos de commbox de el nombre de proveeedor
        Dim da As New SqlDataAdapter("select * from proveedor", con)
        Dim dt As New DataTable
        da.Fill(dt)
        cmbproveedor.DisplayMember = "Nombre"
        cmbproveedor.DataSource = dt

    End Sub

    Private Sub cmdguardad_Click(sender As Object, e As EventArgs) Handles cmdguardad.Click
        'esta desicion es para correrir el error de guardad daros vacios
        If cmbproveedor.Text = "" Or txtnombre.Text = "" Or txtprecio.Text = "" Or Txtmarca.Text = "" Then
            MessageBox.Show("NOSE A GUARDADO NADA ")
        Else


            Try
                Dim cmd As New SqlCommand 'para registrar datos de la tabla articulos
                cmd.Connection = con
                cmd.CommandText = "insert into articulos (nombre,cantidad,precio,proveedor,descripcion,marca)values(@nombre,@cantidad,@precio,@proveedor,@descripcion,@marca)"
                cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)
                cmd.Parameters.AddWithValue("@cantidad", txtcantidad.Text)
                cmd.Parameters.AddWithValue("@precio", txtprecio.Text)
                cmd.Parameters.AddWithValue("@proveedor", cmbproveedor.Text)
                cmd.Parameters.AddWithValue("@descripcion", txtdescripcion.Text)
                cmd.Parameters.AddWithValue("@marca", Txtmarca.Text)
                Dim x As Integer = cmd.ExecuteNonQuery
                If x > 0 Then
                    mostar()
                    MessageBox.Show("Datos guardado correctamente")
                Else
                    MessageBox.Show("NOSE A GUARDADO NADA ")
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub cmbproveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbproveedor.SelectedIndexChanged

    End Sub

    Private Sub cmdmordificar_Click(sender As Object, e As EventArgs) Handles cmdmordificar.Click
        ' hay que valida la entrada
        Try
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "update articulos set nombre=@nombre,cantidad=@cantidad,precio=@precio,proveedor=@proveedor,descripcion=@descripcion,marca=@marca where codigo=@codigo"
            cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)
            cmd.Parameters.AddWithValue("@cantidad", txtcantidad.Text)
            cmd.Parameters.AddWithValue("@precio", txtprecio.Text)
            cmd.Parameters.AddWithValue("@proveedor", cmbproveedor.Text)
            cmd.Parameters.AddWithValue("@descripcion", txtdescripcion.Text)
            cmd.Parameters.AddWithValue("@marca", Txtmarca.Text)
            cmd.Parameters.AddWithValue("@codigo", txtcodigo.Text)
            Dim x As Integer = cmd.ExecuteNonQuery
            If x > 0 Then
                mostar()
                MessageBox.Show("Datos Actualizado correctamente")
            Else
                MessageBox.Show("NOSE A Actualizado NADA ")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdeliminar_Click(sender As Object, e As EventArgs) Handles cmdeliminar.Click
        ' para eliminar los datos de la tabla de articulos 
        Try
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "delete articulos where codigo=@codigo"

            cmd.Parameters.AddWithValue("@codigo", txtcodigo.Text)
            Dim x As Integer = cmd.ExecuteNonQuery
            If x > 0 Then
                mostar()
                MessageBox.Show("Datos ELiminado correctamente")
            Else
                MessageBox.Show("NOSE A Eliminado NADA ")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdlimpiar_Click(sender As Object, e As EventArgs) Handles cmdlimpiar.Click
        'para limpiar los datos
        cmbproveedor.Text = ""
        txtcantidad.Clear()
        txtcodigo.Clear()
        txtdescripcion.Clear()
        Txtmarca.Clear()
        txtnombre.Clear()
        txtprecio.Clear()


    End Sub

    Private Sub Cmdimprimir_Click(sender As Object, e As EventArgs) Handles Cmdimprimir.Click
        informedearcticulo.Show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class