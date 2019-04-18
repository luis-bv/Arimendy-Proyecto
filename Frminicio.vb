Imports System.Data.SqlClient
Public Class Frminicio

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conectar()
        mostar() 'para llenar los commbox de usuario y tipos de usuario
      
    End Sub

    Sub mostaR() 'es para tener un control de usuario ADMiN y USER
        Dim da As New SqlDataAdapter("Select * from usuario where id_usuario like '%" & txtusuario.Text & "%'", con)
        Dim dt As New DataTable   'esta busqueda se realiza para que busque el tipos de usuario y asi tener un control 
        da.Fill(dt)                    'y asi le pase ese valor a pr que es una variable public para dertmina si es Admin o user
        cmbtipos.DisplayMember = "tipos"
        cmbtipos.DataSource = dt
        pr = cmbtipos.Text

    End Sub
    Private Sub cmdinicio_Click(sender As Object, e As EventArgs) Handles cmdinicio.Click
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()

            End If
            'esta es la parte donde se compara el nombre de usuario con el de la tabla y la clave
            Dim da As New SqlDataAdapter("select * from usuario where id_usuario='" & txtusuario.Text & "' and clave='" & txtclave.Text & "' ", con)
            Dim dt As New DataTable
            da.Fill(dt)
            



            If dt.Rows.Count <> 0 Then
                ' los valores introducido en la txtusuario y txtclave

                FrmPrincipal.Show()
                Me.Close()


            Else
                'este codigo es para cuando el usuario esta incorrepto para que limpie y enfoque el txtusuario
                MessageBox.Show("USUARIO O CLAVE INCORRECTA", "ERROR")
                txtclave.Clear()
                txtusuario.Clear()
                txtusuario.Focus()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtusuario_TextChanged(sender As Object, e As EventArgs) Handles txtusuario.TextChanged

        ' esto es para que se valla mostado el tipos de usuario mientra se escriber en txt usuario 
        mostaR()

    End Sub

    Private Sub Cmdsalir_Click(sender As Object, e As EventArgs) Handles Cmdsalir.Click
        Me.Close()
    End Sub

    Private Sub cmbtipos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtipos.SelectedIndexChanged
        txttipos.Text = cmbtipos.Text
    End Sub

    Private Sub txttipos_TextChanged(sender As Object, e As EventArgs) Handles txttipos.TextChanged

    End Sub
End Class