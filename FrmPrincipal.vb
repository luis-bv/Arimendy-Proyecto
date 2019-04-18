Imports System.Data.SqlClient
Public Class FrmPrincipal



    Private Sub ControlDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmControldeusuario.Show()
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If pr = "USER" Then    'esta decision es para desactiva el mune de admin para el user comun  
            AdminToolStripMenuItem.Enabled = False
            ReporteDeUsuarioToolStripMenuItem.Enabled = False

        End If
        



    End Sub

    Private Sub RegritosDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmregritodeproveedor.Show()
    End Sub

    Private Sub RegritosDeArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Articulos.Show()
    End Sub

   
    Private Sub ControlDeUsuarioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ControlDeUsuarioToolStripMenuItem1.Click
        FrmControldeusuario.Show()
    End Sub

    Private Sub RegritosDeProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegritosDeProveedorToolStripMenuItem.Click
        frmregritodeproveedor.Show()
    End Sub

    Private Sub RegritosDeArticulosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RegritosDeArticulosToolStripMenuItem1.Click
        Articulos.Show()
    End Sub

    Private Sub RegrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegrToolStripMenuItem.Click
        Frmagrevararcticulos.Show()
    End Sub

    
    Private Sub ReiniciarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReiniciarToolStripMenuItem.Click

        Frminicio.Show()
        Me.Close()
    End Sub

    Private Sub INGRobertRguezToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INGRobertRguezToolStripMenuItem.Click
        Process.Start("www.facebook.com/profile.php?id=100000912980910")
        Process.Start("www.instagram.com/robert.rl/")
    End Sub

    Private Sub INGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INGToolStripMenuItem.Click
        Process.Start("www.facebook.com/yoldin?fref=ts")
        Process.Start("www.instagram.com/yoldalyreyes")
    End Sub

    Private Sub INGYanRoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INGYanRoToolStripMenuItem.Click
        Process.Start("www.facebook.com/yanmanuel.rodriguezrodriguez?fref=ts")
    End Sub

    Private Sub ReporteDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeUsuarioToolStripMenuItem.Click
        frminfromedeusuario.Show()
    End Sub

    Private Sub ReporteDeProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeProveedorToolStripMenuItem.Click
        Informedeproveedores.Show()
    End Sub

    Private Sub ReporteDeArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeArticulosToolStripMenuItem.Click
        informedearcticulo.Show()
    End Sub

    Private Sub ReporteDeEntradadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeEntradadToolStripMenuItem.Click
        Informedeentradad.Show()
    End Sub

    Private Sub TablaDeRegritoDeEntradadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TablaDeRegritoDeEntradadToolStripMenuItem.Click
        frmentradad.Show()
    End Sub
End Class