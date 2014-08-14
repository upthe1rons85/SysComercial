﻿Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports WindowsApplication1.ClsRegistroFletes
Imports WindowsApplication1.ClsTools
Public Class frmRegistroFletes
    Dim Fechainicial As String
    Dim FechaFinal As String
    Dim BanderaModificarFlete As Boolean = False
    Dim fletecerrado As Boolean
    Private Sub frmRegistroFletes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Mantenimiento Catálogo de Proveedores" + Space(10) + CStr(VersionComerci())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        Dim toolTipGrabar As New ToolTip()
        toolTipGrabar.SetToolTip(Me.BtnGrabar, "Grabar")
        Dim toolTipNuevo As New ToolTip()
        toolTipNuevo.SetToolTip(Me.BtnNuevo, "Nuevo")
        Dim toolTipModificar As New ToolTip()
        toolTipModificar.SetToolTip(Me.BtnModificar, "Modificar")
        CargaEstadoOrigen()
        CargaEstadoDestino()
        CargaChoferes()
        CargaProveedores()
        Inicializacargos()
        Me.TxtFolio.Focus()
        Me.DgvFacturas.AutoGenerateColumns = False
    End Sub
    Private Sub CargaProveedores()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "Select * from Almacen.dbo.catProveedores(nolock) where idGiroComercial in (38,39) Order by Proveedor"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        'carga el combo Estado del Origen 
        Me.CbxProveedor.ValueMember = "Codigo"
        Me.CbxProveedor.DisplayMember = "Proveedor"
        Me.CbxProveedor.Text = "Seleccione Proveedor"
        Me.CbxProveedor.DataSource = dt
    End Sub
    Private Sub CargaEstadoOrigen()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "Select * from Contabilidad.dbo.catEstados(nolock) order by CodigoEdo"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        'carga el combo Estado del Origen 
        Me.CbxEstadoOrigen.ValueMember = "Estado"
        Me.CbxEstadoOrigen.DisplayMember = "Estado"
        Me.CbxEstadoOrigen.DataSource = dt
    End Sub
    Private Sub CargaEstadoDestino()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "Select * from Contabilidad.dbo.catEstados(nolock) order by CodigoEdo"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        'carga el combo Estado del Destino 
        Me.CbxEstadoDestino.ValueMember = "Estado"
        Me.CbxEstadoDestino.DisplayMember = "Estado"
        Me.CbxEstadoDestino.DataSource = dt
    End Sub
    Private Sub CbxEstadoOrigen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxEstadoOrigen.SelectedIndexChanged
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim consulta2 As String = "Select municipio from contabilidad.dbo.catmunicipios where codestado = '" & Me.CbxEstadoOrigen.Text & "'"
        Dim cmd As New SqlCommand(consulta2, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da2 As New SqlDataAdapter(cmd)
        Dim dt2 As New DataTable

        da2.Fill(dt2)

        Me.CbxMunicipioOrigen.ValueMember = "Municipio"
        Me.CbxMunicipioOrigen.DisplayMember = "Municipio"
        Me.CbxMunicipioOrigen.DataSource = dt2
    End Sub
    Private Sub CbxEstadoDestino_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxEstadoDestino.SelectedIndexChanged
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim consulta2 As String = "Select municipio from contabilidad.dbo.catmunicipios where codestado = '" & Me.CbxEstadoDestino.Text & "'"
        Dim cmd As New SqlCommand(consulta2, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da2 As New SqlDataAdapter(cmd)
        Dim dt2 As New DataTable

        da2.Fill(dt2)

        Me.CbxMunicipioDestino.ValueMember = "Municipio"
        Me.CbxMunicipioDestino.DisplayMember = "Municipio"
        Me.CbxMunicipioDestino.DataSource = dt2
    End Sub
    Private Sub CargaChoferes()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "Select codigochofer,Nombre from Comercial.dbo.catchoferes(nolock) Where Clave='" & Me.CbxProveedor.SelectedValue & "' Order by Nombre"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        'carga el combo Estado del Destino 
        Me.CbxChofer.ValueMember = "CodigoChofer"
        Me.CbxChofer.DisplayMember = "Nombre"
        Me.CbxChofer.DataSource = dt
    End Sub
    Private Sub Inicializacargos()
        Me.TxtKmProg.Text = "0.00"
        Me.TxtCostoFlete.Text = "0.00"
        Me.TxtCostoManiobras.Text = "0.00"
        Me.TxtCostoDemoras.Text = "0.00"
        Me.TxtCostoDevoluciones.Text = "0.00"
        Me.TxtCostoEstancias.Text = "0.00"
        Me.TxtCostoOtros.Text = "0.00"
        Me.TxtIva.Text = 0.0
        Me.TxtRetencion.Text = 0.0
        Me.TxtTotal.Text = 0.0
    End Sub
    Private Sub RegresaMovimientos()
        Dim bclsFletes = New ClsRegistroFletes()
        Dim dr As SqlDataReader

        dr = bclsFletes.SeleccionaFolio(Me.TxtFolio.Text)

        If dr.Read() Then
            Me.DtpFecha.Text = dr("Fecha").ToString()
            Me.CbxProveedor.Text = dr("Proveedor").ToString()
            Me.CbxChofer.Text = dr("Chofer").ToString()
            Me.TxtCostoFlete.Text = dr("CostoFlete").ToString()
            Me.TxtCostoManiobras.Text = dr("CostoManiobras").ToString()
            Me.TxtCostoDemoras.Text = dr("CostoDemoras").ToString()
            Me.TxtCostoDevoluciones.Text = dr("CostoDevoluciones").ToString()
            Me.TxtCostoEstancias.Text = dr("CostoEstancias").ToString()
            Me.TxtCostoOtros.Text = dr("CostoOtros").ToString()
            Me.TxtIva.Text = dr("Iva").ToString()
            Me.TxtRetencion.Text = dr("Retencion").ToString()
            Me.CbxEstadoOrigen.Text = dr("EstadoOrigen").ToString()
            Me.CbxMunicipioOrigen.Text = dr("CiudadOrigen").ToString()
            Me.CbxEstadoDestino.Text = dr("EstadoDestino").ToString()
            Me.CbxMunicipioDestino.Text = dr("CiudadDestino").ToString()
            Me.TxtKmProg.Text = dr("Km_Programados").ToString()
            Me.TxtComenManiobras.Text = dr("ComentariosManiobras").ToString()
            Me.TxtComenDemoras.Text = dr("ComentariosDemoras").ToString()
            Me.TxtComenDevo.Text = dr("ComentariosDevoluciones").ToString()
            Me.TxtComenEstancias.Text = dr("ComentariosEstancias").ToString()
            Me.TxtComenOtros.Text = dr("ComentariosOtros").ToString()
            Me.TxtObservaciones.Text = dr("Observaciones").ToString()
            fletecerrado = dr("Estatus").ToString()
            Me.TxtTotal.Text = (Val(Me.TxtCostoFlete.Text) + Val(Me.TxtCostoManiobras.Text) + Val(Me.TxtCostoDevoluciones.Text) + Val(Me.TxtCostoDemoras.Text) + Val(Me.TxtCostoEstancias.Text) + Val(Me.TxtCostoOtros.Text) + Val(Me.TxtIva.Text) + Val(Me.TxtRetencion.Text))

            If fletecerrado = True Then
                Me.CkbCerrarFlete.Checked = True
            Else
                Me.CkbCerrarFlete.Checked = False
            End If

            Dim dr2 As SqlDataReader
            Dim aclsFacturas = New ClsRegistroFletes()

            dr2 = aclsFacturas.MuestraFacturas(Me.TxtFolio.Text)
            Dim dt = New DataTable()
            dt.Load(dr2)

            If dt.Rows.Count > 0 Then
                '' llenar DATAGRID ------------------
                DgvFacturas.AutoGenerateColumns = False 'Aqui digo que las columnas no se generen automaticamente, sino que yo las lleno manualmente
                DgvFacturas.Columns(0).DataPropertyName = Trim("")
                DgvFacturas.Columns(1).DataPropertyName = Trim("Factura")
                DgvFacturas.Columns(2).DataPropertyName = Trim("FechaVta")
                DgvFacturas.Columns(3).DataPropertyName = Trim("Cliente")
                DgvFacturas.Columns(4).DataPropertyName = Trim("Razon")
                DgvFacturas.Columns(5).DataPropertyName = Trim("Total")
                DgvFacturas.Columns(6).DataPropertyName = Trim("Vendedor")
                DgvFacturas.DataSource = dt
            End If
            For Each row As DataGridViewRow In DgvFacturas.Rows
                row.Cells("check").Value = True
            Next
            '-----se valida que el folio del flete no se encuentre cerrado, de ser asi, no podra modificarlo-----
            If fletecerrado = True Then
                MsgBox("Folio de Flete Cerrado, No Puede Realizar Modificaciones..!!!", vbInformation)
                Me.GbxDatos.Enabled = False
                Me.GbxCostos.Enabled = False
                Me.GbxRangoFechas.Enabled = False
                Me.TxtFolio.Enabled = False
                Me.BtnModificar.Enabled = False
                Me.BtnNuevo.Enabled = True
                Me.BtnGrabar.Enabled = False
                Me.DgvFacturas.Enabled = False
                Me.btnImprimir.Enabled = True
            Else
                Me.btnImprimir.Enabled = True
                Me.GbxDatos.Enabled = False
                Me.GbxCostos.Enabled = False
                Me.GbxRangoFechas.Enabled = True
                Me.TxtFolio.Enabled = False
                Me.BtnModificar.Enabled = True
                Me.DgvFacturas.Enabled = False
            End If
        Else
            MsgBox("Folio de Flete no Existe, Favor de Revisar.", MessageBoxIcon.Error)
            Me.GbxDatos.Enabled = False
            Me.GbxCostos.Enabled = False
            Me.GbxRangoFechas.Enabled = False
            Me.DgvFacturas.Enabled = False
            Me.TxtFolio.SelectAll()
        End If
    End Sub
    Private Sub BtnCargarFac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCargarFac.Click
        Fechainicial = Format(CDate(Me.DtpFechaInicial.Value.ToShortDateString), "yyyyMMdd")
        FechaFinal = Format(CDate(Me.DtpFechaFinal.Value.ToShortDateString), "yyyyMMdd")
        If FechaFinal < Fechainicial Then
            MsgBox("Fecha Final no debe ser menor a la fecha Inicial, Favor de revisar.", vbInformation, "Sistema Comercial")
            Me.DtpFechaFinal.Focus()
        Else
            Dim dr As SqlDataReader
            Dim aclsFacturas = New ClsRegistroFletes()

            Dim FolioFlete As Integer = Me.TxtFolio.Text

            dr = aclsFacturas.SeleccionaFacturas(Fechainicial, FechaFinal, FolioFlete)
            Dim dt = New DataTable()
            dt.Load(dr)

            If dt.Rows.Count > 0 Then
                '' llenar DATAGRID ------------------

                DgvFacturas.AutoGenerateColumns = False 'Aqui digo que las columnas no se generen automaticamente, sino que yo las lleno manualmente
                DgvFacturas.Columns(0).DataPropertyName = Trim("")
                DgvFacturas.Columns(1).DataPropertyName = Trim("Factura")
                DgvFacturas.Columns(2).DataPropertyName = Trim("FechaVta")
                DgvFacturas.Columns(3).DataPropertyName = Trim("Cliente")
                DgvFacturas.Columns(4).DataPropertyName = Trim("Razon")
                DgvFacturas.Columns(5).DataPropertyName = Trim("Total")
                DgvFacturas.Columns(6).DataPropertyName = Trim("Vendedor")
                DgvFacturas.Columns(7).DataPropertyName = Trim("Marca")
                DgvFacturas.DataSource = dt

                For Each row As DataGridViewRow In DgvFacturas.Rows

                    If row.Cells("Marca").Value = 1 Then
                        row.Cells("check").Value = True
                    End If
                Next

                Me.DgvFacturas.Enabled = True
                Me.BtnGrabar.Enabled = True
                Me.BtnModificar.Enabled = False
            Else
                MsgBox("No Existen Facturas para las Fechas Seleccionadas", vbInformation, "Sistema Comercial")
            End If
        End If
    End Sub
    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click

        Dim Fecha As String = Format(CDate(Me.DtpFecha.Value.ToShortDateString), "yyyyMMdd")
        Dim EstadoOrigen As String = Me.CbxEstadoOrigen.SelectedValue
        Dim CiudadOrigen As String = Me.CbxMunicipioOrigen.SelectedValue
        Dim EstadoDestino As String = Me.CbxEstadoDestino.SelectedValue
        Dim CiudadDestino As String = Me.CbxMunicipioDestino.SelectedValue
        Dim Proveedor As String = Me.CbxProveedor.SelectedValue
        Dim chofer As String = Me.CbxChofer.SelectedValue

        If Val(Me.TxtKmProg.Text) <= 0 Then
            MsgBox("Los Kms Programados no Pueden ser 0, Favor de Revisar.", vbInformation, "Sistema Comercial")
            Me.TxtKmProg.SelectAll()
        Else

            Dim clsDB = New ClsBD()
            Dim cnnConexion = New SqlConnection()
            cnnConexion = clsDB.CreaConexion()

            Dim transaction As SqlTransaction
            transaction = cnnConexion.BeginTransaction

            'si el txtfolio.text esta con **** significa que capturara un flete nuevo
            If Me.TxtFolio.Text = "*****" Then
                Try
                    Dim wQuery As String = ""
                    Dim LocalCommand As SqlCommand

                    Dim wFolio As String
                    wQuery = "Select max(Folio_sol)+1 from compras.dbo.parametros(nolock) Where Clave='compras_001'"

                    LocalCommand = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
                    LocalCommand.CommandType = Data.CommandType.Text
                    LocalCommand.Connection = cnnConexion
                    LocalCommand.Transaction = transaction
                    wFolio = LocalCommand.ExecuteScalar()

                    If wFolio IsNot Nothing Then
                        'MsgBox("Se Genero Consecutivo de Folio Proveedor Correctamente", vbInformation, "Sistema Contable")
                    Else
                        MsgBox("No Se Genero Consecutivo de Folio Proveedor", vbInformation, "Sistema Contable")
                    End If
                    'LocalCommand.Dispose()

                    Dim sXML = "<xFletes>"
                    sXML += "<Folio>" + wFolio + "</Folio>"
                    sXML += "<Fecha>" + Fecha + "</Fecha>"
                    sXML += "<CodProveedor>" + Proveedor + "</CodProveedor>"
                    sXML += "<CodChofer>" + chofer + "</CodChofer>"
                    sXML += "<CostoFlete>" + Me.TxtCostoFlete.Text + "</CostoFlete>"
                    sXML += "<CostoManiobras>" + Me.TxtCostoManiobras.Text + "</CostoManiobras>"
                    sXML += "<CostoDemoras>" + Me.TxtCostoDemoras.Text + "</CostoDemoras>"
                    sXML += "<CostoDevoluciones>" + Me.TxtCostoDevoluciones.Text + "</CostoDevoluciones>"
                    sXML += "<CostoEstancias>" + Me.TxtCostoEstancias.Text + "</CostoEstancias>"
                    sXML += "<CostoOtros>" + Me.TxtCostoOtros.Text + "</CostoOtros>"
                    sXML += "<Iva>" + Me.TxtIva.Text + "</Iva >"
                    sXML += "<Retencion>" + Me.TxtRetencion.Text + "</Retencion>"
                    sXML += "<EstadoOrigen>" + EstadoOrigen + "</EstadoOrigen>"
                    sXML += "<CiudadOrigen>" + CiudadOrigen + "</CiudadOrigen>"
                    sXML += "<EstadoDestino>" + EstadoDestino + "</EstadoDestino>"
                    sXML += "<CiudadDestino>" + CiudadDestino + "</CiudadDestino>"
                    sXML += "<Km_Programados>" + Me.TxtKmProg.Text + "</Km_Programados>"
                    sXML += "<Usuario>" + LoginUsuario + "</Usuario>"
                    sXML += "<ComentariosManiobras>" + Me.TxtComenManiobras.Text + "</ComentariosManiobras>"
                    sXML += "<ComentariosDemoras>" + Me.TxtComenDemoras.Text + "</ComentariosDemoras>"
                    sXML += "<ComentariosDevoluciones>" + Me.TxtComenDevo.Text + "</ComentariosDevoluciones>"
                    sXML += "<ComentariosEstancias>" + Me.TxtComenEstancias.Text + "</ComentariosEstancias>"
                    sXML += "<ComentariosOtros>" + Me.TxtComenOtros.Text + "</ComentariosOtros>"
                    sXML += "<Observaciones>" + Me.TxtObservaciones.Text + "</Observaciones>"
                    sXML += "</xFletes>"

                    Dim aclsInsertaFletes = New ClsRegistroFletes()
                    aclsInsertaFletes.InsertaFletes(sXML)

                    MsgBox("Registrado Correctamente con el Folio: " + wFolio, vbInformation, "Sistema Contable")

                    Dim xfoliador = New ClsRegistroFletes()
                    xfoliador.AdelantaFolioFletes(wFolio)

                    transaction.Commit()
                    CargaEstadoOrigen()
                    CargaEstadoDestino()
                    CargaChoferes()
                    CargaProveedores()
                    Inicializacargos()
                    Me.GbxDatos.Enabled = False
                    Me.GbxCostos.Enabled = False
                    Me.BtnGrabar.Enabled = False
                    Me.TxtFolio.Enabled = True
                    Me.TxtComenManiobras.Clear()
                    Me.TxtComenDemoras.Clear()
                    Me.TxtComenDevo.Clear()
                    Me.TxtComenEstancias.Clear()
                    Me.TxtComenOtros.Clear()
                    Me.TxtObservaciones.Clear()
                    Me.TxtFolio.Clear()
                    Me.DtpFecha.Value = Today
                    Me.TxtFolio.Focus()
                Catch
                    MsgBox("Ocurrio un Error al Grabar ", MsgBoxStyle.Critical)
                    transaction.Rollback()
                Finally
                    cnnConexion.Dispose()
                    cnnConexion.Close()
                End Try
                '-----------inicia la grabada para la modificacion de un flete ya capturado----------------
            ElseIf BanderaModificarFlete = True Then
                Dim cmd As New SqlCommand

                cmd.Connection = cnnConexion
                cmd.Transaction = transaction

                '--------------se revisa si el flete ah sido cerrado, para al final de la actualizacion----------------------------
                '--------------del flete se realice la orden de compra-----------------------------------------------------------
                If Me.CkbCerrarFlete.Checked = True Then
                    fletecerrado = True
                Else
                    fletecerrado = False
                End If

                Try
                    cmd.Parameters.Clear()
                    cmd.CommandText = "spActFletes"
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = cnnConexion
                    cmd.Transaction = transaction

                    cmd.Parameters.Add("@Folio", SqlDbType.NVarChar).Value = Trim(Me.TxtFolio.Text)
                    cmd.Parameters.Add("@Proveedor", SqlDbType.NVarChar).Value = Proveedor
                    cmd.Parameters.Add("@Chofer", SqlDbType.NVarChar).Value = chofer
                    cmd.Parameters.Add("@EstadoOrigen", SqlDbType.NVarChar).Value = EstadoOrigen
                    cmd.Parameters.Add("@CiudadOrigen", SqlDbType.NVarChar).Value = CiudadOrigen
                    cmd.Parameters.Add("@EstadoDestino", SqlDbType.NVarChar).Value = EstadoDestino
                    cmd.Parameters.Add("@CiudadDestino", SqlDbType.NVarChar).Value = CiudadDestino
                    cmd.Parameters.Add("@kmsprogramados", SqlDbType.NVarChar).Value = Trim(Me.TxtKmProg.Text)
                    cmd.Parameters.Add("@CostoFlete", SqlDbType.NVarChar).Value = Trim(Me.TxtCostoFlete.Text)
                    cmd.Parameters.Add("@CostoManiobras", SqlDbType.NVarChar).Value = Trim(Me.TxtCostoManiobras.Text)
                    cmd.Parameters.Add("@CostoDevoluciones", SqlDbType.NVarChar).Value = Trim(Me.TxtCostoDevoluciones.Text)
                    cmd.Parameters.Add("@CostoDemoras", SqlDbType.NVarChar).Value = Trim(Me.TxtCostoDemoras.Text)
                    cmd.Parameters.Add("@CostoEstancias", SqlDbType.NVarChar).Value = Trim(Me.TxtCostoEstancias.Text)
                    cmd.Parameters.Add("@CostoOtros", SqlDbType.NVarChar).Value = Trim(Me.TxtCostoOtros.Text)
                    cmd.Parameters.Add("@iva", SqlDbType.NVarChar).Value = Trim(Me.TxtIva.Text)
                    cmd.Parameters.Add("@Retencion", SqlDbType.NVarChar).Value = Trim(Me.TxtRetencion.Text)
                    cmd.Parameters.Add("@ComenManiobras", SqlDbType.NVarChar).Value = Trim(Me.TxtComenManiobras.Text)
                    cmd.Parameters.Add("@ComenDemoras", SqlDbType.NVarChar).Value = Trim(Me.TxtComenDemoras.Text)
                    cmd.Parameters.Add("@ComenDevoluciones", SqlDbType.NVarChar).Value = Trim(Me.TxtComenDevo.Text)
                    cmd.Parameters.Add("@ComenEstancias", SqlDbType.NVarChar).Value = Trim(Me.TxtComenEstancias.Text)
                    cmd.Parameters.Add("@ComenOtros", SqlDbType.NVarChar).Value = Trim(Me.TxtComenOtros.Text)
                    cmd.Parameters.Add("@observaciones", SqlDbType.NVarChar).Value = Trim(Me.TxtObservaciones.Text)
                    cmd.Parameters.Add("@Estatus", SqlDbType.Bit).Value = fletecerrado

                    cmd.ExecuteNonQuery()
                    '--------se valida si esta el flete cerrado para generar la orden de compra--------------
                    If fletecerrado = True Then
                        cmd.Parameters.Clear()
                        cmd.CommandText = "spGeneraSolicitudCompra"
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Connection = cnnConexion
                        cmd.Transaction = transaction

                        cmd.Parameters.Add("@Folio", SqlDbType.Int).Value = Trim(Me.TxtFolio.Text)
                        cmd.Parameters.Add("@Fecha", SqlDbType.VarChar).Value = Trim(Me.DtpFecha.Value)
                        cmd.Parameters.Add("@CodProveedor", SqlDbType.Int).Value = Trim(Me.CbxProveedor.SelectedValue)
                        cmd.ExecuteNonQuery()
                    End If


                    transaction.Commit()

                    MsgBox("Se Actualizaron los Datos del Flete Correctamente.", MsgBoxStyle.Information, "Sistema Contable")
                    Me.BtnGrabar.Enabled = False
                    Me.btnImprimir.Enabled = False
                    Me.GbxRangoFechas.Enabled = False
                    CargaEstadoOrigen()
                    CargaEstadoDestino()
                    CargaChoferes()
                    CargaProveedores()
                    Inicializacargos()
                    Me.GbxDatos.Enabled = False
                    Me.GbxCostos.Enabled = False
                    Me.TxtFolio.Enabled = True
                    Me.TxtFolio.Clear()
                    Me.TxtFolio.Focus()
                    Me.TxtComenManiobras.Clear()
                    Me.TxtComenDemoras.Clear()
                    Me.TxtComenDevo.Clear()
                    Me.TxtComenEstancias.Clear()
                    Me.TxtComenOtros.Clear()
                    Me.TxtObservaciones.Clear()
                    BanderaModificarFlete = False
                    Me.CkbCerrarFlete.Enabled = False
                    Me.CkbCerrarFlete.Checked = False
                Catch
                    MsgBox("Ocurrio un Error al Grabar ", MsgBoxStyle.Critical)
                    transaction.Rollback()
                Finally
                    cnnConexion.Dispose()
                    cnnConexion.Close()
                    DgvFacturas.DataSource = Nothing
                    DgvFacturas.Refresh()
                End Try
            Else
                '-----------inicia la grabada para las facturas----------------
                Dim cmd As New SqlCommand

                cmd.Connection = cnnConexion
                cmd.Transaction = transaction

                Try
                    'se eliminaran las facturas asignadas al folio de flete de la tabla comdetregistroflete, ya que se asignaran
                    'nuevamente en la proxima grabada
                    cmd.Parameters.Clear()
                    cmd.CommandText = "spEliFolioFletes"
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = cnnConexion
                    cmd.Transaction = transaction

                    cmd.Parameters.Add("@Folio", SqlDbType.Int).Value = Trim(Me.TxtFolio.Text)
                    cmd.ExecuteNonQuery()

                    For Each row As DataGridViewRow In DgvFacturas.Rows
                        If row.Cells("check").Value = True Then
                            cmd.Parameters.Clear()
                            cmd.CommandText = "spInsFacFletes"
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Connection = cnnConexion
                            cmd.Transaction = transaction

                            cmd.Parameters.Add("@Folio", SqlDbType.Int).Value = Trim(Me.TxtFolio.Text)
                            cmd.Parameters.Add("@Factura", SqlDbType.VarChar).Value = RTrim(row.Cells("Factura").Value)

                            cmd.ExecuteNonQuery()
                        End If
                    Next
                    transaction.Commit()
                    MsgBox("Se Agregaron Correctamente Las Facturas", MsgBoxStyle.Information, "Sistema Contable")
                    Me.BtnGrabar.Enabled = False
                    Me.btnImprimir.Enabled = False
                    Me.GbxRangoFechas.Enabled = False
                    CargaEstadoOrigen()
                    CargaEstadoDestino()
                    CargaChoferes()
                    CargaProveedores()
                    Inicializacargos()
                    Me.TxtFolio.Enabled = True
                    Me.TxtFolio.Clear()
                    Me.TxtFolio.Focus()
                    Me.TxtComenManiobras.Clear()
                    Me.TxtComenDemoras.Clear()
                    Me.TxtComenDevo.Clear()
                    Me.TxtComenEstancias.Clear()
                    Me.TxtComenOtros.Clear()
                    Me.TxtObservaciones.Clear()
                Catch
                    MsgBox("Ocurrio un Error al Grabar ", MsgBoxStyle.Critical)
                    transaction.Rollback()
                Finally
                    cnnConexion.Dispose()
                    cnnConexion.Close()
                    DgvFacturas.DataSource = Nothing
                    DgvFacturas.Refresh()
                End Try
            End If
        End If
    End Sub
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        CargaEstadoOrigen()
        CargaEstadoDestino()
        CargaChoferes()
        CargaProveedores()
        Inicializacargos()
        Me.TxtComenManiobras.Clear()
        Me.TxtComenDemoras.Clear()
        Me.TxtComenDevo.Clear()
        Me.TxtComenEstancias.Clear()
        Me.TxtComenOtros.Clear()
        Me.TxtObservaciones.Clear()
        Me.GbxDatos.Enabled = True
        Me.GbxCostos.Enabled = True
        Me.BtnGrabar.Enabled = True
        Me.TxtFolio.Text = "*****"
        Me.TxtFolio.Enabled = False
        Me.BtnModificar.Enabled = False
        Me.TxtCostoFlete.Enabled = True
        Me.GbxRangoFechas.Enabled = False
        Me.CkbCerrarFlete.Enabled = False
        Me.DgvFacturas.DataSource = Nothing
        Me.DgvFacturas.Refresh()
    End Sub
    '--------Inicia Keyup de costos
    'Private Sub TxtCostoFlete_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCostoFlete.KeyUp
    '    If Me.TxtCostoFlete.Text = "" Then
    '        Me.TxtCostoFlete.Text = 0.0
    '    Else
    '        Me.TxtCostoFlete.Text = Format(CDec(Me.TxtCostoFlete.Text), "###,###,##0.#0")
    '    End If
    'End Sub
    'Private Sub TxtCostoManiobras_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCostoManiobras.KeyUp
    '    If Me.TxtCostoManiobras.Text = "" Then
    '        Me.TxtCostoManiobras.Text = 0.0
    '    Else
    '        Me.TxtCostoManiobras.Text = Format(CDec(Me.TxtCostoManiobras.Text), "###,###,##0.#0")
    '    End If
    'End Sub
    'Private Sub TxtCostoDemoras_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCostoDemoras.KeyUp
    '    If Me.TxtCostoDemoras.Text = "" Then
    '        Me.TxtCostoDemoras.Text = 0.0
    '    Else
    '        Me.TxtCostoDemoras.Text = Format(CDec(Me.TxtCostoDemoras.Text), "###,###,##0.#0")
    '    End If
    'End Sub
    'Private Sub TxtCostoDevoluciones_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCostoDevoluciones.KeyUp
    '    If Me.TxtCostoDevoluciones.Text = "" Then
    '        Me.TxtCostoDevoluciones.Text = 0.0
    '    Else
    '        Me.TxtCostoDevoluciones.Text = Format(CDec(Me.TxtCostoDevoluciones.Text), "###,###,##0.#0")
    '    End If
    'End Sub
    'Private Sub TxtCostoEstancias_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCostoEstancias.KeyUp
    '    If Me.TxtCostoEstancias.Text = "" Then
    '        Me.TxtCostoEstancias.Text = 0.0
    '    Else
    '        Me.TxtCostoEstancias.Text = Format(CDec(Me.TxtCostoEstancias.Text), "###,###,##0.#0")
    '    End If
    'End Sub
    'Private Sub TxtCostoOtros_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCostoOtros.KeyUp
    '    If Me.TxtCostoOtros.Text = "" Then
    '        Me.TxtCostoOtros.Text = 0.0
    '    Else
    '        Me.TxtCostoOtros.Text = Format(CDec(Me.TxtCostoOtros.Text), "###,###,##0.#0")
    '    End If
    'End Sub
    Private Sub TxtKmProg_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtKmProg.LostFocus
        If Me.TxtKmProg.Text = "" Or 0 Then
            Me.TxtKmProg.Text = "0.00"
        End If
    End Sub
    Private Sub TxtCostoFlete_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCostoFlete.LostFocus
        Me.TxtIva.Text = ((Val(Me.TxtCostoFlete.Text) + Val(Me.TxtCostoManiobras.Text) + Val(Me.TxtCostoDemoras.Text) + Val(Me.TxtCostoDevoluciones.Text) + Val(Me.TxtCostoEstancias.Text) + Val(Me.TxtCostoOtros.Text)) * 0.16)
        Me.TxtRetencion.Text = (Val(Me.TxtCostoFlete.Text) * 0.04) * -1
        Me.TxtTotal.Text = (Val(Me.TxtCostoFlete.Text) + Val(Me.TxtCostoManiobras.Text) + Val(Me.TxtCostoDemoras.Text) + Val(Me.TxtCostoDevoluciones.Text) + Val(Me.TxtCostoEstancias.Text) + Val(Me.TxtCostoOtros.Text) + Val(Me.TxtIva.Text) + Val(Me.TxtRetencion.Text))
        If Me.TxtCostoFlete.Text = "" Or 0 Then
            Me.TxtCostoFlete.Text = "0.00"
        End If
    End Sub
    Private Sub TxtCostoManiobras_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCostoManiobras.LostFocus
        Me.TxtIva.Text = ((Val(Me.TxtCostoFlete.Text) + Val(Me.TxtCostoManiobras.Text) + Val(Me.TxtCostoDemoras.Text) + Val(Me.TxtCostoDevoluciones.Text) + Val(Me.TxtCostoEstancias.Text) + Val(Me.TxtCostoOtros.Text)) * 0.16)
        Me.TxtRetencion.Text = (Val(Me.TxtCostoFlete.Text) * 0.04) * -1
        Me.TxtTotal.Text = (Val(Me.TxtCostoFlete.Text) + Val(Me.TxtCostoManiobras.Text) + Val(Me.TxtCostoDemoras.Text) + Val(Me.TxtCostoDevoluciones.Text) + Val(Me.TxtCostoEstancias.Text) + Val(Me.TxtCostoOtros.Text) + Val(Me.TxtIva.Text) + Val(Me.TxtRetencion.Text))
        If Me.TxtCostoManiobras.Text = "" Or 0 Then
            Me.TxtCostoManiobras.Text = "0.00"
        End If
    End Sub
    Private Sub TxtcostoDemoras_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCostoDemoras.LostFocus
        Me.TxtIva.Text = ((Val(Me.TxtCostoFlete.Text) + Val(Me.TxtCostoManiobras.Text) + Val(Me.TxtCostoDemoras.Text) + Val(Me.TxtCostoDevoluciones.Text) + Val(Me.TxtCostoEstancias.Text) + Val(Me.TxtCostoOtros.Text)) * 0.16)
        Me.TxtRetencion.Text = (Val(Me.TxtCostoFlete.Text) * 0.04) * -1
        Me.TxtTotal.Text = (Val(Me.TxtCostoFlete.Text) + Val(Me.TxtCostoManiobras.Text) + Val(Me.TxtCostoDemoras.Text) + Val(Me.TxtCostoDevoluciones.Text) + Val(Me.TxtCostoEstancias.Text) + Val(Me.TxtCostoOtros.Text) + Val(Me.TxtIva.Text) + Val(Me.TxtRetencion.Text))
        If Me.TxtCostoDemoras.Text = "" Or 0 Then
            Me.TxtCostoDemoras.Text = "0.00"
        End If
    End Sub
    Private Sub TxtCostoDevoluciones_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCostoDevoluciones.LostFocus
        Me.TxtIva.Text = ((Val(Me.TxtCostoFlete.Text) + Val(Me.TxtCostoManiobras.Text) + Val(Me.TxtCostoDemoras.Text) + Val(Me.TxtCostoDevoluciones.Text) + Val(Me.TxtCostoEstancias.Text) + Val(Me.TxtCostoOtros.Text)) * 0.16)
        Me.TxtRetencion.Text = (Val(Me.TxtCostoFlete.Text) * 0.04) * -1
        Me.TxtTotal.Text = (Val(Me.TxtCostoFlete.Text) + Val(Me.TxtCostoManiobras.Text) + Val(Me.TxtCostoDemoras.Text) + Val(Me.TxtCostoDevoluciones.Text) + Val(Me.TxtCostoEstancias.Text) + Val(Me.TxtCostoOtros.Text) + Val(Me.TxtIva.Text) + Val(Me.TxtRetencion.Text))
        If Me.TxtCostoDevoluciones.Text = "" Or 0 Then
            Me.TxtCostoDevoluciones.Text = "0.00"
        End If
    End Sub

    Private Sub TxtCostoEstancias_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCostoEstancias.LostFocus
        Me.TxtIva.Text = ((Val(Me.TxtCostoFlete.Text) + Val(Me.TxtCostoManiobras.Text) + Val(Me.TxtCostoDemoras.Text) + Val(Me.TxtCostoDevoluciones.Text) + Val(Me.TxtCostoEstancias.Text) + Val(Me.TxtCostoOtros.Text)) * 0.16)
        Me.TxtRetencion.Text = (Val(Me.TxtCostoFlete.Text) * 0.04) * -1
        Me.TxtTotal.Text = (Val(Me.TxtCostoFlete.Text) + Val(Me.TxtCostoManiobras.Text) + Val(Me.TxtCostoDemoras.Text) + Val(Me.TxtCostoDevoluciones.Text) + Val(Me.TxtCostoEstancias.Text) + Val(Me.TxtCostoOtros.Text) + Val(Me.TxtIva.Text) + Val(Me.TxtRetencion.Text))
        If Me.TxtCostoEstancias.Text = "" Or 0 Then
            Me.TxtCostoEstancias.Text = "0.00"
        End If
    End Sub
    Private Sub TxtCostoOtros_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCostoOtros.LostFocus
        Me.TxtIva.Text = ((Val(Me.TxtCostoFlete.Text) + Val(Me.TxtCostoManiobras.Text) + Val(Me.TxtCostoDemoras.Text) + Val(Me.TxtCostoDevoluciones.Text) + Val(Me.TxtCostoEstancias.Text) + Val(Me.TxtCostoOtros.Text)) * 0.16)
        Me.TxtRetencion.Text = (Val(Me.TxtCostoFlete.Text) * 0.04) * -1
        Me.TxtTotal.Text = (Val(Me.TxtCostoFlete.Text) + Val(Me.TxtCostoManiobras.Text) + Val(Me.TxtCostoDemoras.Text) + Val(Me.TxtCostoDevoluciones.Text) + Val(Me.TxtCostoEstancias.Text) + Val(Me.TxtCostoOtros.Text) + Val(Me.TxtIva.Text) + Val(Me.TxtRetencion.Text))
        If Me.TxtCostoOtros.Text = "" Or 0 Then
            Me.TxtCostoOtros.Text = "0.00"
        End If
    End Sub
    Private Sub TxtFolio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFolio.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            If Me.TxtFolio.Text = "" Then
                Me.BtnNuevo.PerformClick()
            Else
                RegresaMovimientos()
            End If
        End If

        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtKmProg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKmProg.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtObservaciones.Focus()
        End If
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtObservaciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtObservaciones.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtCostoFlete.Focus()
        End If
    End Sub
    Private Sub TxtCostoFlete_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCostoFlete.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtCostoManiobras.Focus()
        End If
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtCostoManiobras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCostoManiobras.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtComenManiobras.Focus()
            Me.TxtComenManiobras.SelectAll()
        End If
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtComenManiobras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtComenManiobras.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtCostoDemoras.Focus()
            Me.TxtCostoDemoras.SelectAll()
        End If
    End Sub
    Private Sub TxtCostoDemoras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCostoDemoras.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtComenDemoras.Focus()
            Me.TxtComenDemoras.SelectAll()
        End If
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtComenDemoras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtComenDemoras.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtCostoDevoluciones.Focus()
            Me.TxtCostoDevoluciones.SelectAll()
        End If
    End Sub
    Private Sub TxtCostoDevoluciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCostoDevoluciones.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtComenDevo.Focus()
            Me.TxtComenDevo.SelectAll()
        End If
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtComenDevo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtComenDevo.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtCostoEstancias.Focus()
            Me.TxtCostoEstancias.SelectAll()
        End If
    End Sub
    Private Sub TxtCostoEstancias_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCostoEstancias.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtComenEstancias.Focus()
            Me.TxtComenEstancias.SelectAll()
        End If
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtComenEstancias_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtComenEstancias.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtCostoOtros.Focus()
            Me.TxtCostoOtros.SelectAll()
        End If
    End Sub
    Private Sub TxtCostoOtros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCostoOtros.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtComenOtros.Focus()
            Me.TxtComenOtros.SelectAll()
        End If
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtComenOtros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtComenOtros.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.BtnGrabar.Focus()
        End If
    End Sub
    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        Me.GbxDatos.Enabled = True
        Me.GbxCostos.Enabled = True
        'Me.TxtCostoFlete.Enabled = False
        'Me.TxtComenDemoras.Enabled = True
        'Me.TxtComenDevo.Enabled = True
        'Me.TxtComenEstancias.Enabled = True
        'Me.TxtComenOtros.Enabled = True
        'Me.CkbCerrarFlete.Enabled = True
        Me.DtpFecha.Enabled = False
        Me.BtnGrabar.Enabled = True
        Me.TxtFolio.Enabled = False
        Me.GbxRangoFechas.Enabled = False
        BanderaModificarFlete = True
        Me.CkbCerrarFlete.Enabled = True
    End Sub
    Private Sub TxtKmProg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtKmProg.Click
        Me.TxtKmProg.SelectAll()
    End Sub
    Private Sub TxtCostoFlete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCostoFlete.Click
        Me.TxtCostoFlete.SelectAll()
    End Sub
    Private Sub TxtCostoManiobras_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCostoManiobras.Click
        Me.TxtCostoManiobras.SelectAll()
    End Sub
    Private Sub TxtDemoras_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCostoDemoras.Click
        Me.TxtCostoDemoras.SelectAll()
    End Sub
    Private Sub TxtCostoDevoluciones_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCostoDevoluciones.Click
        Me.TxtCostoDevoluciones.SelectAll()
    End Sub
    Private Sub TxtCostoEstancias_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCostoEstancias.Click
        Me.TxtCostoEstancias.SelectAll()
    End Sub
    Private Sub TxtCostoOtros_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCostoOtros.Click
        Me.TxtCostoOtros.SelectAll()
    End Sub
    Private Sub TxtIva_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtIva.TextChanged
        'Me.TxtIva.Text = Format(CDec(TxtIva.Text), "###,###,##0.#0")
    End Sub
    Private Sub TxtRetencion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRetencion.TextChanged
        Me.TxtRetencion.Text = Format(CDec(TxtRetencion.Text), "###,###,##0.#0")
    End Sub
    Private Sub TxtTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTotal.TextChanged
        Me.TxtTotal.Text = Format(CDec(TxtTotal.Text), "###,###,##0.#0")
    End Sub
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim Flete As Integer = Me.TxtFolio.Text
        Dim frm As New frmRPTImprimeFacturasFlete
        frm.flete = Flete
        frm.ShowDialog()
    End Sub
    Private Sub TxtConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtConsultar.Click
        Me.TxtFolio.Enabled = True
        CargaEstadoOrigen()
        CargaEstadoDestino()
        CargaChoferes()
        CargaProveedores()
        Inicializacargos()
        Me.GbxDatos.Enabled = False
        Me.GbxCostos.Enabled = False
        Me.BtnGrabar.Enabled = False
        Me.TxtFolio.Enabled = True
        Me.TxtComenManiobras.Clear()
        Me.TxtComenDemoras.Clear()
        Me.TxtComenDevo.Clear()
        Me.TxtComenEstancias.Clear()
        Me.TxtComenOtros.Clear()
        Me.TxtObservaciones.Clear()
        Me.TxtFolio.Clear()
        Me.TxtFolio.Focus()
        Me.DtpFecha.Value = Today
        Me.TxtFolio.Focus()
        DgvFacturas.DataSource = Nothing
        DgvFacturas.Refresh()
    End Sub
    Private Sub CbxProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxProveedor.SelectedIndexChanged
        CargaChoferes()
    End Sub
End Class