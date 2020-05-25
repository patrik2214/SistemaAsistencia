Public Class FrmLogin
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles btnIngresar.Click




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        ''Cerrar el login
        Application.Exit()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        ''Minimizar Login
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class