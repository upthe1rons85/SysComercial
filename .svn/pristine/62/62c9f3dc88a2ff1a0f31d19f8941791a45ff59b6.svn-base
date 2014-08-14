Imports System.Data.SqlClient
Imports System.Data
Imports WindowsApplication1.ClsTools

Public Class frmVendedores

    Private Sub frmVendedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargalst()
        Me.Text = "Mantenimiento Rutas " + Space(10) + VersionComerci()
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        MaximizeBox = False
        txtVendedor.Enabled = True
        txtNombre.Enabled = False
        BtnGrabar.Enabled = False
        BtnNuevo.Enabled = True
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub

    Private Sub Cargalst()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim consulta As String = "select * from [Comercial].[DBO].[comVendedores](nolock)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds, "comVendedores")
        Dim objListItem As New ListViewItem
        Me.lstVendedores.Items.Clear()
        For Each drw As DataRow In ds.Tables("comVendedores").Rows
            objListItem = lstVendedores.Items.Add(drw.Item("Vendedor").ToString, 0)
            objListItem.SubItems.Add(drw.Item("Nombre").ToString)
        Next
    End Sub

    Sub limpiar()
        txtVendedor.Clear()
        txtNombre.Clear()
    End Sub

    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        If txtVendedor.Text = "" Or txtNombre.Text = "" Then
            MsgBox("No deben Quedar Datos Vacios..!!!", vbInformation, "Sistema Comercial")
            txtVendedor.Focus()
            Cargalst()
        Else
            Try
                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New ClsBD()
                cnnConexion = clsDB.CreaConexion()
                Dim commandbus As New SqlCommand("spValidaVendedor", cnnConexion)
                commandbus.CommandType = CommandType.StoredProcedure
                commandbus.Parameters.AddWithValue("@Vendedor", txtVendedor.Text)
                Dim n As Integer
                n = RTrim(commandbus.ExecuteScalar())
                If n > 0 Then
                    Dim pclsVend = New clsVendedores()
                    pclsVend.ActualizaVendedor(txtVendedor.Text, txtNombre.Text)
                    MsgBox("Actualizado Correctamente", vbInformation, "Sistema Comercial")
                    limpiar()
                Else
                    Dim sXML = "<xVendedor>"
                    sXML += "<Vendedor>" + txtVendedor.Text + "</Vendedor>"
                    sXML += "<Nombre>" + txtNombre.Text + "</Nombre>"
                    sXML += "</xVendedor>"
                    Dim oclstipodoc = New clsVendedores()
                    oclstipodoc.InsertaVendedor(sXML)
                    MsgBox("Registrado Correctamente", vbInformation, "Sistema Comercial")
                    limpiar()
                    Cargalst()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Comercial")
            End Try
            txtVendedor.Enabled = True
            txtNombre.Enabled = False
            BtnGrabar.Enabled = False
            BtnNuevo.Enabled = True
            BtnEliminar.Enabled = False
            btnModificar.Enabled = False
            Cargalst()
            limpiar()
            txtVendedor.Focus()
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        txtVendedor.Enabled = True
        txtNombre.Enabled = True
        BtnGrabar.Enabled = True
        BtnNuevo.Enabled = False
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False
        txtNombre.Focus()
        Cargalst()
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If txtVendedor.Text = "" Then
            MsgBox("Debe capturar un Codigo", vbInformation, "Sistema Comercial")
            txtVendedor.Focus()
        Else
            If MessageBox.Show("¿Desea ELIMINAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim oclsVen = New clsVendedores()
                'oclsVen.EliminaVendedor(lstVendedores.SelectedItems(0).Text)
                oclsVen.EliminaVendedor(txtVendedor.Text)
                MsgBox("Registro Eliminado", vbInformation, "Sistema Comercial")
            End If
        End If
        BtnGrabar.Enabled = False
        BtnNuevo.Enabled = True
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False
        txtVendedor.Enabled = True
        limpiar()
        Cargalst()
        txtVendedor.Focus()
    End Sub

    Private Sub TxtBuscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBuscar.KeyPress
        Dim clsBD As New ClsBD()
        Dim dr As SqlDataReader
        Dim oclsVen = New clsVendedores()
        dr = oclsVen.BuscaNombreVendedor(Me.TxtBuscar.Text)
        Dim dt = New DataTable()
        dt.Load(dr)
        lstVendedores.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("Vendedor").ToString)
            lstLista.SubItems.Add(rRow("Nombre").ToString)
            lstVendedores.Items.Add(lstLista)
        Next
    End Sub

    Private Sub TxtBuscar_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TxtBuscar.MouseClick
        TxtBuscar.Clear()
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        TxtBuscar.Text = "Buscar Vendedor"
        TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
        txtVendedor.Enabled = True
        txtNombre.Enabled = True
        BtnGrabar.Enabled = True
        BtnNuevo.Enabled = True
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False
        Cargalst()
        limpiar()
        txtVendedor.Focus()
    End Sub

    Private Sub lstVendedores_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstVendedores.MouseDoubleClick
        txtVendedor.Text = lstVendedores.SelectedItems(0).SubItems(0).Text
        txtNombre.Text = lstVendedores.SelectedItems(0).SubItems(1).Text
        txtVendedor.Enabled = False
        txtNombre.Enabled = False
        btnModificar.Enabled = True
        BtnGrabar.Enabled = False
        BtnEliminar.Enabled = True
        BtnNuevo.Enabled = True
    End Sub
End Class