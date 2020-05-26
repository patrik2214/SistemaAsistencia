Imports CapaNegocio

Public Class FrmEmpleado


    Private Sub FrmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub limpiar()
        For Each miControl In Me.Panel1.Controls
            If TypeOf miControl Is TextBox Then
                miControl.clear()
            ElseIf TypeOf miControl Is CheckBox Then
                miControl.Is(False)
            End If
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        ''Buscar Empleado

        Dim Empleado = New clsEmpleado().Search(txtDni.Text)
        txtNombre.Text = Empleado.NOMBRE
        txtApellido.Text = Empleado.APELLIDO
        txtCorreo.Text = Empleado.CORREO
        txtTelefono.Text = Empleado.TELEFONO

        If Empleado.SEXO = 1 Then
            cboSexo.SelectedItem().Equals("Masculino")
        ElseIf Empleado.SEXO = 0 Then
            cboSexo.SelectedItem().Equals("Femenino")

        End If

        If Empleado.ESTADO = 1 Then
            chkEstado.Checked = True
        ElseIf Empleado.ESTADO = 0 Then
            chkEstado.Checked = False

        End If



    End Sub
End Class