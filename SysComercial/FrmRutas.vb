Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports WindowsApplication1.ClsTools
Public Class FrmRutas
    Private Sub cargadatos()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim oclsChoferes = New clsRutas()
        Dim dr As SqlDataReader
        dr = oclsChoferes.SeleccionaRutas(Me.txtCodigo.Text)
        If dr.Read() Then
            Me.txtCodigo.Text = dr("Ruta").ToString()
            Me.txtDescripcion.Text = dr("Descripcion").ToString()
            txtCodigo.Enabled = False
            txtDescripcion.Enabled = False
            btnGrabar.Enabled = False
            BtnNuevo.Enabled = True
            BtnModificar.Enabled = True
            BtnEliminar.Enabled = True
            'Else
            '    MsgBox("Crear Registro Nuevo, Se generara Codigo Nuevo", vbInformation, "Sistema Almacen")
            '    txtCodigo.Text = "0000"
            '    txtCodigo.Enabled = False
            '    txtDescripcion.Enabled = True
            '    txtCodigo.Focus()
            '    btnGrabar.Enabled = True
            '    BtnNuevo.Enabled = True
            '    BtnModificar.Enabled = False
            '    BtnEliminar.Enabled = False
            '    txtDescripcion.Focus()
            '    txtDescripcion.Clear()
            '    llenalista2()
        End If
    End Sub
    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Or InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            txtDescripcion.Focus()

            e.KeyChar = ""


            If txtCodigo.Text <> "" Then
                cargadatos()
            Else
                MsgBox("Crear Registro Nuevo, Se generara Codigo Nuevo", vbInformation, "Sistema Almacen")
                txtCodigo.Text = "0000"
                txtCodigo.Enabled = False
                txtDescripcion.Enabled = True
                txtCodigo.Focus()
                btnGrabar.Enabled = True
                BtnNuevo.Enabled = True
                BtnModificar.Enabled = False
                BtnEliminar.Enabled = False
                txtDescripcion.Focus()
                txtDescripcion.Clear()
                llenalista2()
            End If
        End If
    End Sub
    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            btnGrabar.PerformClick()
        End If
    End Sub
    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        txtBuscar.Text = "BUSCAR DESCRIPCION"
        txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0F, FontStyle.Italic)
        Me.txtCodigo.Enabled = False
        Me.txtDescripcion.Enabled = True
        btnGrabar.Enabled = True
        BtnNuevo.Enabled = True
        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False
        llenalista2()
        Me.txtDescripcion.Focus()
    End Sub
    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        If txtCodigo.Text = "" Or txtDescripcion.Text = "" Then
            MsgBox("No deben Quedar Datos Vacios..!!!", vbInformation, "Sistema Comercial")
            txtCodigo.Focus()
            llenalista2()
        Else
            Try
                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New ClsBD()
                cnnConexion = clsDB.CreaConexion()
                Dim commandbus As New SqlCommand("spValidaRutas", cnnConexion)
                commandbus.CommandType = CommandType.StoredProcedure
                commandbus.Parameters.AddWithValue("@Ruta", txtCodigo.Text)
                Dim n As Integer
                n = RTrim(commandbus.ExecuteScalar())
                If n > 0 Then
                    Dim pclsRutas = New clsRutas()
                    pclsRutas.ActualizaRutas(Me.txtCodigo.Text, Me.txtDescripcion.Text)
                    MsgBox("Actualizado Correctamente", vbInformation, "Sistema Comercial")
                    Dim limpiar As New ClsTools
                    limpiar.LimpiarControles(Me)
                Else
                    Dim wQuery As String = ""
                    Dim LocalCommand As SqlCommand
                    Dim wCodigo As String
                    wQuery = "SELECT MAX(FolioRutas)+1 FROM parametros (NOLOCK)"
                    LocalCommand = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
                    LocalCommand.CommandType = Data.CommandType.Text
                    wCodigo = LocalCommand.ExecuteScalar()
                    If wCodigo IsNot Nothing Then
                        'MsgBox("Se Genero Consecutivo de Folio Proveedor Correctamente", vbInformation, "Sistema Contable")
                    Else
                        MsgBox("No Se Genero Consecutivo de Folio ", vbInformation, "Sistema Comercial")
                    End If
                    LocalCommand.Dispose()
                    Dim xfoliador = New clsRutas()
                    xfoliador.AdelantaRutas(wCodigo)
                    ' Existencias = 0
                    Dim sXML = "<xRutas>"
                    sXML += "<Ruta>" + wCodigo + "</Ruta>"
                    sXML += "<Descripcion>" + Me.txtDescripcion.Text + "</Descripcion>"
                    sXML += "</xRutas>"
                    Dim xclsRutas = New clsRutas()
                    xclsRutas.InsertaRutas(sXML)
                    MsgBox("Registrado Correctamente, Codigo de Producto :" + wCodigo, vbInformation, "Sistema Comercial")
                    llenalista2()
                    Dim limpiar As New ClsTools
                    limpiar.LimpiarControles(Me)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Comercial")
            End Try
            txtCodigo.Enabled = True
            txtDescripcion.Enabled = False
            btnGrabar.Enabled = False
            BtnNuevo.Enabled = True
            BtnEliminar.Enabled = False
            BtnModificar.Enabled = False
            txtCodigo.Clear()
            txtDescripcion.Clear()
            llenalista2()
            txtBuscar.Text = "BUSCAR DESCRIPCION"
            txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0F, FontStyle.Italic)
            Me.txtCodigo.Focus()
        End If
    End Sub
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If Me.txtCodigo.Text = "" Then
            MsgBox("Debe capturar un Codigo", vbInformation, "Sistema Comercial")
            txtCodigo.Focus()
        Else
            If MessageBox.Show("¿Desea ELIMINAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim oclsRutas = New clsRutas()
                oclsRutas.EliminaRutas(Me.txtCodigo.Text)
                MsgBox("Registro Eliminado", vbInformation, "Sistema Comercial")
                Dim limpiar As New ClsTools
                limpiar.LimpiarControles(Me)
                btnGrabar.Enabled = False
                BtnNuevo.Enabled = True
                BtnModificar.Enabled = False
                BtnEliminar.Enabled = False
                Me.txtCodigo.Enabled = True
                txtCodigo.Clear()
                txtDescripcion.Clear()
                llenalista2()
                listRutas.Refresh()
                txtBuscar.Text = "BUSCAR DESCRIPCION"
                txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0F, FontStyle.Italic)
                Me.txtCodigo.Focus()
            End If
        End If
    End Sub
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Dim limpiar As New ClsTools
        limpiar.LimpiarControles(Me)
        txtBuscar.Text = "BUSCAR DESCRIPCION"
        txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0F, FontStyle.Italic)
        Me.txtCodigo.Enabled = True
        Me.txtDescripcion.Enabled = True
        Me.btnGrabar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.BtnModificar.Enabled = False
        Me.BtnEliminar.Enabled = False
        txtCodigo.Clear()
        txtDescripcion.Clear()
        llenalista2()
        Me.txtCodigo.Focus()
    End Sub
    Private Sub listRutas_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles listRutas.MouseDoubleClick
        txtCodigo.Text = listRutas.SelectedItems(0).SubItems(0).Text
        txtDescripcion.Text = listRutas.SelectedItems(0).SubItems(1).Text
        txtCodigo.Enabled = False
        txtDescripcion.Enabled = False
        BtnModificar.Enabled = True
        btnGrabar.Enabled = False
        BtnEliminar.Enabled = True
        BtnNuevo.Enabled = True
    End Sub
    Private Sub FrmRutas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Mantenimiento Rutas " + Space(10) + VersionComerci()
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        Me.MaximizeBox = False
        llenalista2()
        txtCodigo.Enabled = True
        txtDescripcion.Enabled = False
        btnGrabar.Enabled = False
        BtnNuevo.Enabled = True
        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub
    Private Sub llenalista2()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim consulta As String = "Select * from Comercial.Dbo.comRutas(nolock) order by Ruta"
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
        clsDB.CierraConexion(cnnConexion)
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