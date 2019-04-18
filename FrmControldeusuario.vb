Imports System.Data.SqlClient
Public Class FrmControldeusuario

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  conectar()
        mostar()
        cargarcmb() ' es para llenar el commbox

    End Sub
    Sub cargarcmb()
        cmbtiposusuario.Items.Add("ADMIN")
        cmbtiposusuario.Items.Add("USER")
    End Sub
    Sub mostar()
        Dim da As New SqlDataAdapter("select * from usuario  where id_usuario like '%" & txtbuscar.Text & "%'", con)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub cmdguardad_Click(sender As Object, e As EventArgs) Handles cmdguardad.Click
        If txtusuario.Text = "" Then 'SE USO ESTA DECICION PARA CORRERIR EL ERROR GUARDA USUARIO VACIO
            MessageBox.Show("POR FAVOR ESCRIBA UNA USUARIO", "ERROR")
            txtusuario.Focus() 'PARA QUE ME ENFOQUE EL USUARIO CUANDO NO SE ALGA ESCRIBIDO
        Else
            If txtclave.Text = "" Then
                MessageBox.Show("POR FAVOR ESCRIBA UNA CLAVE", "ERROR") 'SE USO ESTA DECICION PARA CORRERIR EL ERROR GUARDA CLAVE VACIO
                txtclave.Focus()
            Else
                Try
                    Dim cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandText = "Insert into usuario (id_usuario,clave,tipos)values(@usuario,@clave,@tipos )"
                    cmd.Parameters.AddWithValue("@usuario", txtusuario.Text)
                    cmd.Parameters.AddWithValue("@clave", txtclave.Text)
                    cmd.Parameters.AddWithValue("@tipos", cmbtiposusuario.Text)

                    Dim x As Integer = cmd.ExecuteNonQuery
                    If x > 0 Then
                        MessageBox.Show("Datos guardado correctamente ")
                        mostar()
                        txtusuario.Clear()
                        txtclave.Clear()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    
       
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        mostar() 'mostar para que mueste los datos cuando se escriba en el txtbuscar

    End Sub

    Private Sub cmdmodificar_Click(sender As Object, e As EventArgs) Handles cmdmodificar.Click
        Try 'BUTTON MODIFICAR
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "update usuario set id_usuario=@id_usuario,clave=@clave,tipos=@tipos where codigo=@codigo"
            cmd.Parameters.AddWithValue("@id_usuario", txtusuario.Text)
            cmd.Parameters.AddWithValue("@clave", txtclave.Text)
            cmd.Parameters.AddWithValue("@codigo", txtcodigo.Text)
            cmd.Parameters.AddWithValue("@tipos", cmbtiposusuario.Text)
            Dim x As Integer = cmd.ExecuteNonQuery
            If x > 0 Then
                mostar()
                MessageBox.Show("Datos Modificado Correctamente ")
            Else
                MessageBox.Show("NOSE A MODIFICADO NADA", "ERROR")
                txtcodigo.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Cmdeliminar_Click(sender As Object, e As EventArgs) Handles Cmdeliminar.Click
        Try 'BUTTON ELIMINAR 
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "delete usuario where codigo=@codigo"
            cmd.Parameters.AddWithValue("codigo", txtcodigo.Text)
            Dim x As Integer = cmd.ExecuteNonQuery
            If x > 0 Then
                mostar()
                MessageBox.Show("Datos Borrado Correctamente")
            Else
                MessageBox.Show("NO SE A BORRADO NADA", "ERROR")
                txtcodigo.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frminfromedeusuario.Show()


    End Sub
End Class