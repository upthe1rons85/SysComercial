Imports WindowsApplication1.ClsBD
Imports System.Data.SqlClient
Public Class ClsRegistroFletes
    Function SeleccionaFacturas(ByVal fechaInicial, ByVal FechaFinal, ByVal folioflete)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spFacturasFletes"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@FolioFlete", SqlDbType.VarChar).Value = folioFlete
        cmd.Parameters.Add("@FechaInicial", SqlDbType.VarChar).Value = fechaInicial
        cmd.Parameters.Add("@FechaFinal", SqlDbType.VarChar).Value = FechaFinal

        dr = cmd.ExecuteReader()
        SeleccionaFacturas = dr
    End Function
    Sub InsertaFletes(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spInsFletes"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@XMLDoc", SqlDbType.VarChar).Value = pDatos

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Function SeleccionaFolio(ByVal pFolio As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spBusFolioFlete"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Folio", SqlDbType.VarChar).Value = pFolio

        dr = cmd.ExecuteReader()
        SeleccionaFolio = dr
    End Function
    Sub AdelantaFolioFletes(ByVal pDato As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spAdeFolioFletes"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@folioFletes", SqlDbType.NChar).Value = pDato

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)

    End Sub
    Function MuestraFacturas(ByVal pFolio)
        'clase para mostrar las facturas asignadas a un folio de flete
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spMuestraFacturasFletes"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Folio", SqlDbType.VarChar).Value = pFolio


        dr = cmd.ExecuteReader()
        MuestraFacturas = dr
    End Function
End Class
