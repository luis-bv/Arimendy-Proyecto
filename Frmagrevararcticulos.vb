Imports System.Data.SqlClient
Public Class Frmagrevararcticulos

    Private Sub Frmagrevararcticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostar()
        txtcantidadtotal.Text = Val(txtnuevacantidad.Text) + Val(cmbcantidad.Text) 'para cuando inici el formulario cargue los datoos de txtpreciototal y txtcantidadtotal
        txtpreciototal.Text = Val(cmbprecio.Text) * Val(txtcantidadtotal.Text)
    End Sub
    Sub mostar()
        Dim da As New SqlDataAdapter("select * from articulos", con) 'para llenar los combobox
        Dim dt As New DataTable
        da.Fill(dt)
        cmbarticulos.DataSource = dt 'todos esto datasoure y displaymember es para mostar los datos en los combobox
        cmbarticulos.DisplayMember = "nombre"
        cmbcodigo.DataSource = dt
        cmbcodigo.DisplayMember = "Codigo"
        cmbmarca.DataSource = dt
        cmbmarca.DisplayMember = "Marca"
        cmbprecio.DataSource = dt
        cmbprecio.DisplayMember = "precio"
        cmbproveedor.DataSource = dt
        cmbproveedor.DisplayMember = "proveedor"
        cmbDescripcion.DataSource = dt
        cmbDescripcion.DisplayMember = "Descripcion"
        cmbcantidad.DataSource = dt
        cmbcantidad.DisplayMember = "Cantidad"
    End Sub

    Private Sub cmdguardad_Click(sender As Object, e As EventArgs) Handles cmdguardad.Click
        'esta desicion es para validad la entrada de nueva cantidad
        If txtnuevacantidad.Text = "" Then
            MessageBox.Show("Por favor ingresar la Nueva Cantidad")
        Else
            Dim cmd As New SqlCommand 'este variable es para guardad los datod de update
            Dim cmd1 As New SqlCommand 'esta varia es para guardad los datos de la tabla entrada 
            cmd.Connection = con
            cmd1.Connection = con
            cmd1.CommandText = "insert into entrada (nombre,precio,cantidad1,proveedor,Marca,descripcion)values(@nombre,@precio,@cantidad1,@proveedor,@Marca,@descripcion)"
            cmd1.Parameters.AddWithValue("@nombre", cmbarticulos.Text)
            cmd1.Parameters.AddWithValue("@cantidad1", txtnuevacantidad.Text)
            cmd1.Parameters.AddWithValue("@precio", cmbprecio.Text)
            cmd1.Parameters.AddWithValue("@proveedor", cmbproveedor.Text)
            cmd1.Parameters.AddWithValue("@marca", cmbmarca.Text)
            cmd1.Parameters.AddWithValue("@descripcion", cmbDescripcion.Text)
            Dim x1 As Integer = cmd1.ExecuteNonQuery
            If x1 > 0 Then
                'este codigo es para actualizar la cantidad y esta aqui adentro para que fuciones insert y update a mismo tiempo
                cmd.CommandText = "update articulos set cantidad=@cantidad where codigo=@codigo"
                cmd.Parameters.AddWithValue("@codigo", cmbcodigo.Text)
                cmd.Parameters.AddWithValue("@cantidad", txtcantidadtotal.Text)
                Dim x As Integer = cmd.ExecuteNonQuery
                If x > 0 Then
                    mostar()
                    MessageBox.Show("Datos guardado correctamete")
                Else
                    MessageBox.Show("NOSE A GUARDADO NADA")
                End If
            End If
        End If
      



    End Sub


    Private Sub cmbarticulos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbarticulos.SelectedIndexChanged

        txtnuevacantidad.Clear() 'para que limpier cuando cambia de articulos
        txtcantidadtotal.Clear()
        txtpreciototal.Clear()

    End Sub

    Private Sub txtnuevacantidad_TextChanged(sender As Object, e As EventArgs) Handles txtnuevacantidad.TextChanged
        txtcantidadtotal.Text = Val(txtnuevacantidad.Text) + Val(cmbcantidad.Text) 'esta suma es para que los valores valla cambiando solo cuando escriba en el txt nueva cantidad
        txtpreciototal.Text = Val(cmbprecio.Text) * Val(txtcantidadtotal.Text)
    End Sub

    Private Sub cmbcantidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcantidad.SelectedIndexChanged
        txtcantidadtotal.Text = Val(txtnuevacantidad.Text) + Val(cmbcantidad.Text) 'esta sunma es para que se actualize txtcantidadtotal y txtpreciototal
        txtpreciototal.Text = Val(cmbprecio.Text) * Val(txtcantidadtotal.Text)
    End Sub

    
    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Me.Close() 'boton salir
    End Sub
End Class