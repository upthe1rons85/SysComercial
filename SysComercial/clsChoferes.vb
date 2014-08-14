Imports WindowsApplication1.ClsBD
Imports System.Data.SqlClient
Public Class clsChoferes
    Function SeleccionaChoferes(ByVal pcodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "spSelChoferes"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodigoChofer", SqlDbType.VarChar).Value = pcodigo
        dr = cmd.ExecuteReader()
        SeleccionaChoferes = dr
    End Function
    Function SeleccionaCodigoProveedor(ByVal pcodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelCodigoProveedor"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = pcodigo

        dr = cmd.ExecuteReader()
        SeleccionaCodigoProveedor = dr
    End Function
    Function SeleccionaLisChoferes(ByVal pchofer As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "spBusChoferes"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@NombreChofer", SqlDbType.VarChar).Value = pchofer
        dr = cmd.ExecuteReader()
        SeleccionaLisChoferes = dr
    End Function
    Sub ActualizaChoferes(ByVal pChofer As String, ByVal pEmpresa As String, ByVal pClave As String, ByVal pNombre As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spActChoferes"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodigoChofer", SqlDbType.Int).Value = pChofer
        cmd.Parameters.Add("@Empresa", SqlDbType.NVarChar, 90).Value = pEmpresa
        cmd.Parameters.Add("@Clave", SqlDbType.Int).Value = pClave
        cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar, 90).Value = pNombre

        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub InsertaChoferes(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spInsChoferesPruba"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@XMLDoc", SqlDbType.VarChar).Value = pDatos
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub EliminaChoferes(ByVal pCodigo As String, ByVal pClave As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spEliChoferes"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodigoChofer", SqlDbType.VarChar).Value = pCodigo
        cmd.Parameters.Add("@Clave", SqlDbType.VarChar).Value = pClave
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub AdelantaChoferes(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spAdeFolioChoferes"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CodigoChofer", SqlDbType.VarChar).Value = pDatos
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
End Class
