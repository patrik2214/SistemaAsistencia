Imports CapaNegocio

Public Class FrmLogin

    Public nombre As String
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Try
            If txtUsuario.Equals("") Or txtContraseña.Equals("") Then
                MessageBox.Show("Se requiere ingresar el nombre del Usuario y la contraseña")
            Else
                Dim USUARIO = New clsUsuario().Login(txtUsuario.Text, txtContraseña.Text)
                nombre = USUARIO.EMPLEADO.NOMBRE + " " + USUARIO.EMPLEADO.APELLIDO
                MessageBox.Show("Ingresaste " + nombre)

                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error:" + ex.Message)
        End Try

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