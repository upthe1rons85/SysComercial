Imports WindowsApplication1.ClsBD
Imports System.Data.SqlClient
Public Class clsRutas
    Function SeleccionaRutas(ByVal pcodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "spSelRutas"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Ruta", SqlDbType.NChar).Value = pcodigo
        dr = cmd.ExecuteReader()
        SeleccionaRutas = dr
    End Function
    Function SeleccionaRutas2(ByVal pcodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "spSelRutas2"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Descripcion", SqlDbType.NChar).Value = pcodigo
        dr = cmd.ExecuteReader()
        SeleccionaRutas2 = dr
    End Function
    Sub ActualizaRutas(ByVal pRuta As String, ByVal pDescripcion As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spActRutas"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Ruta", SqlDbType.Int).Value = pRuta
        cmd.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 90).Value = pDescripcion
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub InsertaRutas(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spInsRutas"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@XMLDoc", SqlDbType.VarChar).Value = pDatos
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub EliminaRutas(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spEliRutas"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Ruta", SqlDbType.VarChar).Value = pDatos
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub AdelantaRutas(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spAvanzaFolioRutas"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@FolioRutas", SqlDbType.VarChar).Value = pDatos
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
End Class
