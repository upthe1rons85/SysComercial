Imports WindowsApplication1.ClsBD
Imports System.Data.SqlClient
Imports WindowsApplication1.FrmChoferes
Imports WindowsApplication1.mdVariables
Public Class FrmListRuta
    Friend DatosLista As String
    Private Sub FrmListRuta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenalista()
    End Sub
    Private Sub llenalista()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim consulta As String = "Select * From comRutas(nolock) Order By ruta "
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        'cmd.CommandType = CommandType.Text
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds, "comRutas")
        Dim objListItem As New ListViewItem
        Me.listRutas.Items.Clear()
        For Each drw As DataRow In ds.Tables("comRutas").Rows
            objListItem = listRutas.Items.Add(drw.Item("Ruta").ToString, 0)
            objListItem.SubItems.Add(drw.Item("Descripcion").ToString)
        Next
    End Sub
    Private Sub listChoferes_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles listRutas.MouseDoubleClick
        DatosLista = listRutas.SelectedItems(0).Text
        Me.Close()
    End Sub

    Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
        txtBuscar.Text = ""
        txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F)
        txtBuscar.ForeColor = Color.Gray
    End Sub

    Private Sub txtBuscar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyUp
        Dim clsBD As New ClsBD()
        Dim dr As SqlDataReader
        Dim oclsChoferes = New clsRutas()
        dr = oclsChoferes.SeleccionaRutas2(Me.txtBuscar.Text)
        Dim dt = New DataTable()
        dt.Load(dr)
        If dt.Rows.Count > 0 Then
            listRutas.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("Ruta").ToString)
                lstLista.SubItems.Add(rRow("Descripcion").ToString)
                listRutas.Items.Add(lstLista)
            Next
        End If
    End Sub
End Class