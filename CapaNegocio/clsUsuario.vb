Imports CapaDatos


Public Class clsUsuario

    Private DB As BDAsistenciaUsatEntities = New BDAsistenciaUsatEntities()


    Public Function Login(nombre As String, contraseña As String) As USUARIO

        Try

            Dim Usuario = From u In DB.USUARIO Where u.Nombre Is nombre And u.contraseña Is contraseña Select u
            Return Usuario.Single()

        Catch ex As Exception
            Throw ex
        End Try

    End Function





End Class
