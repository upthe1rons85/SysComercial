Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports WindowsApplication1.ClsTools
Public Class FrmChoferes
    Dim wcodigo As String
    Dim Chofer As String
    Dim clave As Integer
    Dim Actualizar As Boolean = False
    Private Sub FrmChoferes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Mantenimiento Choferes " + Space(10) + VersionComerci()
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        Me.MaximizeBox = False
        CargaEmpresas()
        txtNombre.Enabled = True
        cbxEmpresa.Enabled = True
        btnGrabar.Enabled = True
        BtnNuevo.Enabled = True
        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub
    Private Sub CargaEmpresas()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "Select codigo,Proveedor,idGiroComercial from Almacen.dbo.catProveedores(nolock) where idgirocomercial in (38,39)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cbxEmpresa.ValueMember = "Codigo"
        cbxEmpresa.DisplayMember = "Proveedor"
        cbxEmpresa.DataSource = dt
    End Sub
    Private Sub cbxEmpresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxEmpresa.SelectedIndexChanged
        llenalista()
    End Sub
    Private Sub llenalista()
        clave = Me.cbxEmpresa.SelectedValue
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        Dim consulta As String = "Select * from catChoferes where clave= '" & clave & "'"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        da = New SqlDataAdapter
        da.SelectCommand = cmd

        da.Fill(ds, "catChoferes")

        Dim objListItem As New ListViewItem
        Me.listChoferes.Items.Clear()

        For Each drw As DataRow In ds.Tables("catChoferes").Rows
            objListItem = listChoferes.Items.Add(drw.Item("CodigoChofer").ToString, 0)
            objListItem.SubItems.Add(drw.Item("Nombre").ToString)
            objListItem.SubItems.Add(drw.Item("Empresa").ToString)
        Next
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Me.btnGrabar.Focus()
        End If
    End Sub
    Private Sub cbxEmpresa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbxEmpresa.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Me.txtNombre.Focus()
        End If
    End Sub
    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        Actualizar = True
        Me.txtNombre.Enabled = True
        Me.cbxEmpresa.Enabled = False
        Me.btnGrabar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.BtnModificar.Enabled = False
        Me.BtnEliminar.Enabled = True
        Me.txtNombre.Focus()
    End Sub
    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        If txtNombre.Text = "" Then
            MsgBox("Debe Capturar el Nombre del Chofer..!!!", vbInformation, "Sistema Comercial")
            Me.txtNombre.Focus()
        Else
            Try
                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New ClsBD()
                cnnConexion = clsDB.CreaConexion()

                If Actualizar = True Then
                    Dim commandbus As New SqlCommand("spValidaChoferes", cnnConexion)
                    commandbus.CommandType = CommandType.StoredProcedure
                    commandbus.Parameters.AddWithValue("@CodigoChofer", wcodigo)
                    commandbus.Parameters.AddWithValue("@Clave", clave)
                    Dim n As Integer
                    n = RTrim(commandbus.ExecuteScalar())
                    If n > "0" Then
                        Dim pclsChoferes = New clsChoferes()
                        pclsChoferes.ActualizaChoferes(wcodigo, Me.cbxEmpresa.Text, clave, Me.txtNombre.Text)
                        MsgBox("Actualizado Correctamente  ", vbInformation, "Sistema Comercial")
                    End If


                Else
                    Dim wQuery As String = ""
                    Dim LocalCommand As SqlCommand
                    Dim wCodigo As String
                    wQuery = " if (SELECT MAX(CodigoChofer)+1 FROM catChoferes (NOLOCK) Where Clave= '" & clave & "')>0 SELECT MAX(CodigoChofer)+1 FROM catChoferes (NOLOCK) Where Clave= '" & clave & "' Else Select 1"
                    LocalCommand = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
                    LocalCommand.CommandType = Data.CommandType.Text
                    wCodigo = LocalCommand.ExecuteScalar()
                    If wCodigo IsNot Nothing Then
                        'MsgBox("Se Genero Consecutivo de Folio Proveedor Correctamente", vbInformation, "Sistema Contable")
                    Else
                        MsgBox("No Se Genero Consecutivo de Folio ", vbInformation, "Sistema Comercial")
                    End If
                    LocalCommand.Dispose()

                    Dim sXML = "<xChoferes>"
                    sXML += "<CodigoChofer>" + wCodigo + "</CodigoChofer>"
                    sXML += "<Empresa>" + Me.cbxEmpresa.Text + "</Empresa>"
                    sXML += "<Nombre>" + Me.txtNombre.Text + "</Nombre>"
                    sXML += "<Clave>" + clave.ToString + "</Clave>"
                    sXML += "</xChoferes>"
                    Dim xclsChoferes = New clsChoferes()
                    xclsChoferes.InsertaChoferes(sXML)
                    MsgBox("Registrado Correctamente, Codigo de Chofer : " + wCodigo, vbInformation, "Sistema Comercial")
                    CargaEmpresas()
                    Me.cbxEmpresa.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Comercial")
            End Try
            Me.txtNombre.Enabled = False
            Me.cbxEmpresa.Enabled = False
            Me.btnGrabar.Enabled = False
            Me.BtnNuevo.Enabled = True
            Me.BtnEliminar.Enabled = False
            Me.BtnModificar.Enabled = False
            Me.txtNombre.Clear()
            CargaEmpresas()
            Me.cbxEmpresa.Focus()
            wcodigo = 0
            Actualizar = False
        End If
    End Sub
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If Me.txtnombre.text = "" Then
            MsgBox("Debe capturar un Codigo", vbInformation, "Sistema Comercial")
            Me.cbxEmpresa.Focus()
        Else
            If MessageBox.Show("¿Desea ELIMINAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim oclsChoferes = New clsChoferes()
                oclsChoferes.EliminaChoferes(wcodigo, Me.cbxEmpresa.SelectedValue)
                MsgBox("Registro Eliminado", vbInformation, "Sistema Comercial")
                Dim limpiar As New ClsTools
                limpiar.LimpiarControles(Me)
                btnGrabar.Enabled = False
                BtnNuevo.Enabled = True
                BtnModificar.Enabled = False
                BtnEliminar.Enabled = False
                txtNombre.Clear()
                listChoferes.Refresh()
                CargaEmpresas()
                Me.cbxEmpresa.Focus()
            End If
        End If
    End Sub
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        CargaEmpresas()
        Me.cbxEmpresa.Enabled = True
        Me.txtNombre.Enabled = True
        Me.btnGrabar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.BtnModificar.Enabled = False
        Me.BtnEliminar.Enabled = False
        Me.txtNombre.Clear()
        Me.cbxEmpresa.Focus()
    End Sub
    Private Sub listChoferes_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles listChoferes.MouseDoubleClick
        wcodigo = listChoferes.SelectedItems(0).SubItems(0).Text
        Me.txtNombre.Text = listChoferes.SelectedItems(0).SubItems(1).Text
        Me.txtNombre.Enabled = False
        Me.cbxEmpresa.Enabled = False
        Me.BtnModificar.Enabled = True
        Me.btnGrabar.Enabled = False
        Me.BtnEliminar.Enabled = True
        Me.BtnNuevo.Enabled = True
    End Sub
    Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
        txtBuscar.Text = ""
        txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F)
        txtBuscar.ForeColor = Color.Gray
    End Sub
    'Private Sub txtBuscar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyUp
    '    Dim clsBD As New ClsBD()
    '    Dim dr As SqlDataReader
    '    Dim oclsChoferes = New clsChoferes()
    '    dr = oclsChoferes.SeleccionaLisChoferes(Me.txtBuscar.Text)
    '    Dim dt = New DataTable()
    '    dt.Load(dr)
    '    If dt.Rows.Count > 0 Then
    '        listChoferes.Items.Clear()
    '        For Each rRow As DataRow In dt.Rows
    '            Dim lstLista As New ListViewItem(rRow("CodigoChofer").ToString)
    '            lstLista.SubItems.Add(rRow("Nombre").ToString)
    '            listChoferes.Items.Add(lstLista)
    '        Next
    '    End If
    'End Sub
End Class