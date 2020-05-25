Imports CapaDatos.BDAsistenciaUsatDataSet
Imports CapaDatos.BDAsistenciaUsatDataSetTableAdapters


Public Class clsUsuario
    Inherits USUARIOTableAdapter

    Public Function Login(nombre As String, contraseña As String) As USUARIORow
        Try
            Dim Usuario = MyBase.Login(nombre, contraseña)
            Return Usuario.Single()

        Catch ex As Exception
            Throw ex
        End Try

    End Function





End Class
