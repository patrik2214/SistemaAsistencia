
Imports CapaDatos
Public Class clsEmpleado

    Private DB As BDAsistenciaUsatEntities = New BDAsistenciaUsatEntities()
    Public Function Login(DNI As String, nombre As String, apellido As String, sexo As Boolean, direccion As String, telefono As String, correo As String, estado As String)

        Try

            Dim Empleado = 


        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Search(DNI As String) As EMPLEADO

        Try
            Dim Empleado = From e In DB.EMPLEADO Where DNI Is e.DNI Select e
            Return Empleado.Single()

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function List() As EMPLEADO

        Try
            Dim Empleado = From e In DB.EMPLEADO Select e
            Return Empleado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Delete(DNI As String)
        Try
            Dim Empleado = From e In DB.EMPLEADO Where DNI Is e.DNI ''Falta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Down(DNI As String)
        Try
            Dim Empleado = From e In DB.EMPLEADO Where DNI Is e.DNI ''Falta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Modifiy(DNI As String)
        Try
            Dim Empleado = From e In DB.EMPLEADO  ''Falta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
