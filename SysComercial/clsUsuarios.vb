Imports WindowsApplication1.ClsBD
Imports System.Data.SqlClient
Public Class clsUsuarios
    Sub CambiaContraseñaUsuario(ByVal pDatos As String, ByVal pContraseña As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spCambiaContraseña"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = pDatos
        cmd.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = pContraseña
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Function BuscaPerfil(ByVal pperfil As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "dbo.spBusPerfil"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Perfil", SqlDbType.VarChar).Value = pperfil

        dr = cmd.ExecuteReader()
        BuscaPerfil = dr

    End Function
End Class
