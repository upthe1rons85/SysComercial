﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroFletes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistroFletes))
        Me.DgvFacturas = New System.Windows.Forms.DataGridView()
        Me.check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Razon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GbxRangoFechas = New System.Windows.Forms.GroupBox()
        Me.BtnCargarFac = New System.Windows.Forms.Button()
        Me.LblFechaFinal = New System.Windows.Forms.Label()
        Me.LblFechaInicial = New System.Windows.Forms.Label()
        Me.DtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.GbxDatos = New System.Windows.Forms.GroupBox()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CbxProveedor = New System.Windows.Forms.ComboBox()
        Me.TxtKmProg = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbxChofer = New System.Windows.Forms.ComboBox()
        Me.CbxMunicipioDestino = New System.Windows.Forms.ComboBox()
        Me.CbxEstadoDestino = New System.Windows.Forms.ComboBox()
        Me.CbxMunicipioOrigen = New System.Windows.Forms.ComboBox()
        Me.CbxEstadoOrigen = New System.Windows.Forms.ComboBox()
        Me.LblDestino = New System.Windows.Forms.Label()
        Me.LblOrigen = New System.Windows.Forms.Label()
        Me.LblChofer = New System.Windows.Forms.Label()
        Me.LblProveedor = New System.Windows.Forms.Label()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.GbxFolio = New System.Windows.Forms.GroupBox()
        Me.TxtFolio = New System.Windows.Forms.TextBox()
        Me.LblFolio = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LblCostoFlete = New System.Windows.Forms.Label()
        Me.TxtCostoFlete = New System.Windows.Forms.TextBox()
        Me.TxtCostoManiobras = New System.Windows.Forms.TextBox()
        Me.LblCostoManiobras = New System.Windows.Forms.Label()
        Me.TxtIva = New System.Windows.Forms.TextBox()
        Me.LblIva = New System.Windows.Forms.Label()
        Me.TxtRetencion = New System.Windows.Forms.TextBox()
        Me.LblRetencion = New System.Windows.Forms.Label()
        Me.GbxCostos = New System.Windows.Forms.GroupBox()
        Me.TxtComenOtros = New System.Windows.Forms.TextBox()
        Me.TxtComenEstancias = New System.Windows.Forms.TextBox()
        Me.TxtComenDevo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtCostoOtros = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LblEstancias = New System.Windows.Forms.Label()
        Me.TxtCostoEstancias = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblDevoluciones = New System.Windows.Forms.Label()
        Me.TxtCostoDevoluciones = New System.Windows.Forms.TextBox()
        Me.TxtComenDemoras = New System.Windows.Forms.TextBox()
        Me.TxtComenManiobras = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCostoDemoras = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.CkbCerrarFlete = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STBlblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.TxtConsultar = New System.Windows.Forms.Button()
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbxRangoFechas.SuspendLayout()
        Me.GbxDatos.SuspendLayout()
        Me.GbxFolio.SuspendLayout()
        Me.GbxCostos.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvFacturas
        '
        Me.DgvFacturas.AllowUserToAddRows = False
        Me.DgvFacturas.AllowUserToDeleteRows = False
        Me.DgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.check, Me.Factura, Me.FechaVta, Me.Cliente, Me.Razon, Me.Total, Me.Vendedor, Me.Marca})
        Me.DgvFacturas.Enabled = False
        Me.DgvFacturas.Location = New System.Drawing.Point(34, 433)
        Me.DgvFacturas.Name = "DgvFacturas"
        Me.DgvFacturas.Size = New System.Drawing.Size(684, 209)
        Me.DgvFacturas.TabIndex = 6
        '
        'check
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.NullValue = False
        Me.check.DefaultCellStyle = DataGridViewCellStyle7
        Me.check.HeaderText = " [  +  ] "
        Me.check.Name = "check"
        Me.check.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.check.Width = 45
        '
        'Factura
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Factura.DefaultCellStyle = DataGridViewCellStyle8
        Me.Factura.HeaderText = "Factura"
        Me.Factura.Name = "Factura"
        Me.Factura.ReadOnly = True
        Me.Factura.Width = 53
        '
        'FechaVta
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.FechaVta.DefaultCellStyle = DataGridViewCellStyle9
        Me.FechaVta.HeaderText = "Fecha"
        Me.FechaVta.Name = "FechaVta"
        Me.FechaVta.ReadOnly = True
        Me.FechaVta.Width = 75
        '
        'Cliente
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Cliente.DefaultCellStyle = DataGridViewCellStyle10
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.Width = 60
        '
        'Razon
        '
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Razon.DefaultCellStyle = DataGridViewCellStyle11
        Me.Razon.HeaderText = "Nombre"
        Me.Razon.Name = "Razon"
        Me.Razon.ReadOnly = True
        Me.Razon.Width = 207
        '
        'Total
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "C2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.Total.DefaultCellStyle = DataGridViewCellStyle12
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 65
        '
        'Vendedor
        '
        Me.Vendedor.HeaderText = "Vendedor"
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.ReadOnly = True
        Me.Vendedor.Width = 140
        '
        'Marca
        '
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        Me.Marca.Visible = False
        '
        'GbxRangoFechas
        '
        Me.GbxRangoFechas.Controls.Add(Me.BtnCargarFac)
        Me.GbxRangoFechas.Controls.Add(Me.LblFechaFinal)
        Me.GbxRangoFechas.Controls.Add(Me.LblFechaInicial)
        Me.GbxRangoFechas.Controls.Add(Me.DtpFechaFinal)
        Me.GbxRangoFechas.Controls.Add(Me.DtpFechaInicial)
        Me.GbxRangoFechas.Enabled = False
        Me.GbxRangoFechas.Location = New System.Drawing.Point(34, 384)
        Me.GbxRangoFechas.Name = "GbxRangoFechas"
        Me.GbxRangoFechas.Size = New System.Drawing.Size(683, 43)
        Me.GbxRangoFechas.TabIndex = 5
        Me.GbxRangoFechas.TabStop = False
        Me.GbxRangoFechas.Text = "Rango Facturas"
        '
        'BtnCargarFac
        '
        Me.BtnCargarFac.Location = New System.Drawing.Point(577, 15)
        Me.BtnCargarFac.Name = "BtnCargarFac"
        Me.BtnCargarFac.Size = New System.Drawing.Size(69, 21)
        Me.BtnCargarFac.TabIndex = 29
        Me.BtnCargarFac.Text = "Cargar"
        Me.BtnCargarFac.UseVisualStyleBackColor = True
        '
        'LblFechaFinal
        '
        Me.LblFechaFinal.AutoSize = True
        Me.LblFechaFinal.Location = New System.Drawing.Point(331, 21)
        Me.LblFechaFinal.Name = "LblFechaFinal"
        Me.LblFechaFinal.Size = New System.Drawing.Size(68, 13)
        Me.LblFechaFinal.TabIndex = 28
        Me.LblFechaFinal.Text = "Fecha Final :"
        '
        'LblFechaInicial
        '
        Me.LblFechaInicial.AutoSize = True
        Me.LblFechaInicial.Location = New System.Drawing.Point(111, 21)
        Me.LblFechaInicial.Name = "LblFechaInicial"
        Me.LblFechaInicial.Size = New System.Drawing.Size(73, 13)
        Me.LblFechaInicial.TabIndex = 21
        Me.LblFechaInicial.Text = "Fecha Inicial :"
        '
        'DtpFechaFinal
        '
        Me.DtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFinal.Location = New System.Drawing.Point(428, 17)
        Me.DtpFechaFinal.Name = "DtpFechaFinal"
        Me.DtpFechaFinal.Size = New System.Drawing.Size(98, 20)
        Me.DtpFechaFinal.TabIndex = 27
        '
        'DtpFechaInicial
        '
        Me.DtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaInicial.Location = New System.Drawing.Point(204, 17)
        Me.DtpFechaInicial.Name = "DtpFechaInicial"
        Me.DtpFechaInicial.Size = New System.Drawing.Size(98, 20)
        Me.DtpFechaInicial.TabIndex = 26
        '
        'GbxDatos
        '
        Me.GbxDatos.Controls.Add(Me.TxtObservaciones)
        Me.GbxDatos.Controls.Add(Me.Label11)
        Me.GbxDatos.Controls.Add(Me.CbxProveedor)
        Me.GbxDatos.Controls.Add(Me.TxtKmProg)
        Me.GbxDatos.Controls.Add(Me.Label2)
        Me.GbxDatos.Controls.Add(Me.CbxChofer)
        Me.GbxDatos.Controls.Add(Me.CbxMunicipioDestino)
        Me.GbxDatos.Controls.Add(Me.CbxEstadoDestino)
        Me.GbxDatos.Controls.Add(Me.CbxMunicipioOrigen)
        Me.GbxDatos.Controls.Add(Me.CbxEstadoOrigen)
        Me.GbxDatos.Controls.Add(Me.LblDestino)
        Me.GbxDatos.Controls.Add(Me.LblOrigen)
        Me.GbxDatos.Controls.Add(Me.LblChofer)
        Me.GbxDatos.Controls.Add(Me.LblProveedor)
        Me.GbxDatos.Controls.Add(Me.DtpFecha)
        Me.GbxDatos.Controls.Add(Me.LblFecha)
        Me.GbxDatos.Enabled = False
        Me.GbxDatos.Location = New System.Drawing.Point(34, 120)
        Me.GbxDatos.Name = "GbxDatos"
        Me.GbxDatos.Size = New System.Drawing.Size(336, 258)
        Me.GbxDatos.TabIndex = 3
        Me.GbxDatos.TabStop = False
        Me.GbxDatos.Text = "Datos"
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Location = New System.Drawing.Point(108, 217)
        Me.TxtObservaciones.MaxLength = 90
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(219, 20)
        Me.TxtObservaciones.TabIndex = 25
        Me.TxtObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 220)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Observaciones :"
        '
        'CbxProveedor
        '
        Me.CbxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxProveedor.FormattingEnabled = True
        Me.CbxProveedor.Location = New System.Drawing.Point(80, 58)
        Me.CbxProveedor.Name = "CbxProveedor"
        Me.CbxProveedor.Size = New System.Drawing.Size(209, 21)
        Me.CbxProveedor.TabIndex = 1
        '
        'TxtKmProg
        '
        Me.TxtKmProg.Location = New System.Drawing.Point(79, 188)
        Me.TxtKmProg.Name = "TxtKmProg"
        Me.TxtKmProg.Size = New System.Drawing.Size(121, 20)
        Me.TxtKmProg.TabIndex = 7
        Me.TxtKmProg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Kms.Progr :"
        '
        'CbxChofer
        '
        Me.CbxChofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxChofer.FormattingEnabled = True
        Me.CbxChofer.Location = New System.Drawing.Point(79, 91)
        Me.CbxChofer.Name = "CbxChofer"
        Me.CbxChofer.Size = New System.Drawing.Size(209, 21)
        Me.CbxChofer.TabIndex = 2
        '
        'CbxMunicipioDestino
        '
        Me.CbxMunicipioDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxMunicipioDestino.FormattingEnabled = True
        Me.CbxMunicipioDestino.Location = New System.Drawing.Point(207, 159)
        Me.CbxMunicipioDestino.Name = "CbxMunicipioDestino"
        Me.CbxMunicipioDestino.Size = New System.Drawing.Size(121, 21)
        Me.CbxMunicipioDestino.TabIndex = 6
        '
        'CbxEstadoDestino
        '
        Me.CbxEstadoDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxEstadoDestino.FormattingEnabled = True
        Me.CbxEstadoDestino.Location = New System.Drawing.Point(80, 159)
        Me.CbxEstadoDestino.Name = "CbxEstadoDestino"
        Me.CbxEstadoDestino.Size = New System.Drawing.Size(121, 21)
        Me.CbxEstadoDestino.TabIndex = 5
        '
        'CbxMunicipioOrigen
        '
        Me.CbxMunicipioOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxMunicipioOrigen.FormattingEnabled = True
        Me.CbxMunicipioOrigen.Location = New System.Drawing.Point(207, 125)
        Me.CbxMunicipioOrigen.Name = "CbxMunicipioOrigen"
        Me.CbxMunicipioOrigen.Size = New System.Drawing.Size(121, 21)
        Me.CbxMunicipioOrigen.TabIndex = 4
        '
        'CbxEstadoOrigen
        '
        Me.CbxEstadoOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxEstadoOrigen.FormattingEnabled = True
        Me.CbxEstadoOrigen.Location = New System.Drawing.Point(80, 125)
        Me.CbxEstadoOrigen.Name = "CbxEstadoOrigen"
        Me.CbxEstadoOrigen.Size = New System.Drawing.Size(121, 21)
        Me.CbxEstadoOrigen.TabIndex = 3
        '
        'LblDestino
        '
        Me.LblDestino.AutoSize = True
        Me.LblDestino.Location = New System.Drawing.Point(19, 162)
        Me.LblDestino.Name = "LblDestino"
        Me.LblDestino.Size = New System.Drawing.Size(49, 13)
        Me.LblDestino.TabIndex = 21
        Me.LblDestino.Text = "Destino :"
        '
        'LblOrigen
        '
        Me.LblOrigen.AutoSize = True
        Me.LblOrigen.Location = New System.Drawing.Point(19, 128)
        Me.LblOrigen.Name = "LblOrigen"
        Me.LblOrigen.Size = New System.Drawing.Size(44, 13)
        Me.LblOrigen.TabIndex = 20
        Me.LblOrigen.Text = "Origen :"
        '
        'LblChofer
        '
        Me.LblChofer.AutoSize = True
        Me.LblChofer.Location = New System.Drawing.Point(18, 94)
        Me.LblChofer.Name = "LblChofer"
        Me.LblChofer.Size = New System.Drawing.Size(44, 13)
        Me.LblChofer.TabIndex = 17
        Me.LblChofer.Text = "Chofer :"
        '
        'LblProveedor
        '
        Me.LblProveedor.AutoSize = True
        Me.LblProveedor.Location = New System.Drawing.Point(19, 61)
        Me.LblProveedor.Name = "LblProveedor"
        Me.LblProveedor.Size = New System.Drawing.Size(62, 13)
        Me.LblProveedor.TabIndex = 16
        Me.LblProveedor.Text = "Proveedor :"
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(80, 27)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(98, 20)
        Me.DtpFecha.TabIndex = 0
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Location = New System.Drawing.Point(19, 30)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(43, 13)
        Me.LblFecha.TabIndex = 14
        Me.LblFecha.Text = "Fecha :"
        '
        'GbxFolio
        '
        Me.GbxFolio.Controls.Add(Me.TxtFolio)
        Me.GbxFolio.Controls.Add(Me.LblFolio)
        Me.GbxFolio.Location = New System.Drawing.Point(587, 71)
        Me.GbxFolio.Name = "GbxFolio"
        Me.GbxFolio.Size = New System.Drawing.Size(136, 43)
        Me.GbxFolio.TabIndex = 2
        Me.GbxFolio.TabStop = False
        '
        'TxtFolio
        '
        Me.TxtFolio.Location = New System.Drawing.Point(64, 14)
        Me.TxtFolio.Name = "TxtFolio"
        Me.TxtFolio.Size = New System.Drawing.Size(59, 20)
        Me.TxtFolio.TabIndex = 4
        Me.TxtFolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblFolio
        '
        Me.LblFolio.AutoSize = True
        Me.LblFolio.Location = New System.Drawing.Point(8, 17)
        Me.LblFolio.Name = "LblFolio"
        Me.LblFolio.Size = New System.Drawing.Size(35, 13)
        Me.LblFolio.TabIndex = 3
        Me.LblFolio.Text = "Folio :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(37, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Registro de Fletes"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(735, 674)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 42
        Me.LineShape2.X2 = 771
        Me.LineShape2.Y1 = 60
        Me.LineShape2.Y2 = 60
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.LightSlateGray
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 45
        Me.LineShape1.X2 = 774
        Me.LineShape1.Y1 = 61
        Me.LineShape1.Y2 = 61
        '
        'LblCostoFlete
        '
        Me.LblCostoFlete.AutoSize = True
        Me.LblCostoFlete.Location = New System.Drawing.Point(12, 30)
        Me.LblCostoFlete.Name = "LblCostoFlete"
        Me.LblCostoFlete.Size = New System.Drawing.Size(66, 13)
        Me.LblCostoFlete.TabIndex = 27
        Me.LblCostoFlete.Text = "Costo Flete :"
        '
        'TxtCostoFlete
        '
        Me.TxtCostoFlete.Location = New System.Drawing.Point(115, 27)
        Me.TxtCostoFlete.Name = "TxtCostoFlete"
        Me.TxtCostoFlete.Size = New System.Drawing.Size(72, 20)
        Me.TxtCostoFlete.TabIndex = 9
        Me.TxtCostoFlete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtCostoManiobras
        '
        Me.TxtCostoManiobras.Location = New System.Drawing.Point(115, 53)
        Me.TxtCostoManiobras.Name = "TxtCostoManiobras"
        Me.TxtCostoManiobras.Size = New System.Drawing.Size(72, 20)
        Me.TxtCostoManiobras.TabIndex = 10
        Me.TxtCostoManiobras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblCostoManiobras
        '
        Me.LblCostoManiobras.AutoSize = True
        Me.LblCostoManiobras.Location = New System.Drawing.Point(12, 57)
        Me.LblCostoManiobras.Name = "LblCostoManiobras"
        Me.LblCostoManiobras.Size = New System.Drawing.Size(92, 13)
        Me.LblCostoManiobras.TabIndex = 40
        Me.LblCostoManiobras.Text = "Costo Maniobras :"
        '
        'TxtIva
        '
        Me.TxtIva.Enabled = False
        Me.TxtIva.Location = New System.Drawing.Point(115, 180)
        Me.TxtIva.Name = "TxtIva"
        Me.TxtIva.Size = New System.Drawing.Size(72, 20)
        Me.TxtIva.TabIndex = 43
        Me.TxtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblIva
        '
        Me.LblIva.AutoSize = True
        Me.LblIva.Location = New System.Drawing.Point(12, 183)
        Me.LblIva.Name = "LblIva"
        Me.LblIva.Size = New System.Drawing.Size(28, 13)
        Me.LblIva.TabIndex = 42
        Me.LblIva.Text = "Iva :"
        '
        'TxtRetencion
        '
        Me.TxtRetencion.Enabled = False
        Me.TxtRetencion.Location = New System.Drawing.Point(115, 206)
        Me.TxtRetencion.Name = "TxtRetencion"
        Me.TxtRetencion.Size = New System.Drawing.Size(72, 20)
        Me.TxtRetencion.TabIndex = 45
        Me.TxtRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblRetencion
        '
        Me.LblRetencion.AutoSize = True
        Me.LblRetencion.Location = New System.Drawing.Point(12, 210)
        Me.LblRetencion.Name = "LblRetencion"
        Me.LblRetencion.Size = New System.Drawing.Size(82, 13)
        Me.LblRetencion.TabIndex = 44
        Me.LblRetencion.Text = "Retencion 4%  :"
        '
        'GbxCostos
        '
        Me.GbxCostos.Controls.Add(Me.TxtComenOtros)
        Me.GbxCostos.Controls.Add(Me.TxtComenEstancias)
        Me.GbxCostos.Controls.Add(Me.TxtComenDevo)
        Me.GbxCostos.Controls.Add(Me.Label14)
        Me.GbxCostos.Controls.Add(Me.Label15)
        Me.GbxCostos.Controls.Add(Me.TxtCostoOtros)
        Me.GbxCostos.Controls.Add(Me.Label12)
        Me.GbxCostos.Controls.Add(Me.LblEstancias)
        Me.GbxCostos.Controls.Add(Me.TxtCostoEstancias)
        Me.GbxCostos.Controls.Add(Me.Label10)
        Me.GbxCostos.Controls.Add(Me.LblDevoluciones)
        Me.GbxCostos.Controls.Add(Me.TxtCostoDevoluciones)
        Me.GbxCostos.Controls.Add(Me.TxtComenDemoras)
        Me.GbxCostos.Controls.Add(Me.TxtComenManiobras)
        Me.GbxCostos.Controls.Add(Me.Label9)
        Me.GbxCostos.Controls.Add(Me.Label8)
        Me.GbxCostos.Controls.Add(Me.TxtCostoDemoras)
        Me.GbxCostos.Controls.Add(Me.Label7)
        Me.GbxCostos.Controls.Add(Me.Label6)
        Me.GbxCostos.Controls.Add(Me.Label5)
        Me.GbxCostos.Controls.Add(Me.Label4)
        Me.GbxCostos.Controls.Add(Me.Label3)
        Me.GbxCostos.Controls.Add(Me.TxtTotal)
        Me.GbxCostos.Controls.Add(Me.LblTotal)
        Me.GbxCostos.Controls.Add(Me.LblCostoManiobras)
        Me.GbxCostos.Controls.Add(Me.TxtRetencion)
        Me.GbxCostos.Controls.Add(Me.LblCostoFlete)
        Me.GbxCostos.Controls.Add(Me.LblRetencion)
        Me.GbxCostos.Controls.Add(Me.TxtCostoFlete)
        Me.GbxCostos.Controls.Add(Me.TxtIva)
        Me.GbxCostos.Controls.Add(Me.TxtCostoManiobras)
        Me.GbxCostos.Controls.Add(Me.LblIva)
        Me.GbxCostos.Enabled = False
        Me.GbxCostos.Location = New System.Drawing.Point(394, 120)
        Me.GbxCostos.Name = "GbxCostos"
        Me.GbxCostos.Size = New System.Drawing.Size(329, 258)
        Me.GbxCostos.TabIndex = 4
        Me.GbxCostos.TabStop = False
        Me.GbxCostos.Text = "Costos"
        '
        'TxtComenOtros
        '
        Me.TxtComenOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtComenOtros.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TxtComenOtros.Location = New System.Drawing.Point(204, 154)
        Me.TxtComenOtros.MaxLength = 50
        Me.TxtComenOtros.Name = "TxtComenOtros"
        Me.TxtComenOtros.Size = New System.Drawing.Size(115, 20)
        Me.TxtComenOtros.TabIndex = 19
        Me.TxtComenOtros.Text = "Comentario"
        '
        'TxtComenEstancias
        '
        Me.TxtComenEstancias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtComenEstancias.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TxtComenEstancias.Location = New System.Drawing.Point(204, 129)
        Me.TxtComenEstancias.MaxLength = 50
        Me.TxtComenEstancias.Name = "TxtComenEstancias"
        Me.TxtComenEstancias.Size = New System.Drawing.Size(115, 20)
        Me.TxtComenEstancias.TabIndex = 17
        Me.TxtComenEstancias.Text = "Comentario"
        '
        'TxtComenDevo
        '
        Me.TxtComenDevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtComenDevo.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TxtComenDevo.Location = New System.Drawing.Point(204, 104)
        Me.TxtComenDevo.MaxLength = 50
        Me.TxtComenDevo.Name = "TxtComenDevo"
        Me.TxtComenDevo.Size = New System.Drawing.Size(115, 20)
        Me.TxtComenDevo.TabIndex = 15
        Me.TxtComenDevo.Text = "Comentario"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(101, 158)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 13)
        Me.Label14.TabIndex = 66
        Me.Label14.Text = "$"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 158)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 64
        Me.Label15.Text = "Otros :"
        '
        'TxtCostoOtros
        '
        Me.TxtCostoOtros.Location = New System.Drawing.Point(115, 155)
        Me.TxtCostoOtros.Name = "TxtCostoOtros"
        Me.TxtCostoOtros.Size = New System.Drawing.Size(72, 20)
        Me.TxtCostoOtros.TabIndex = 18
        Me.TxtCostoOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(101, 132)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 13)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "$"
        '
        'LblEstancias
        '
        Me.LblEstancias.AutoSize = True
        Me.LblEstancias.Location = New System.Drawing.Point(12, 132)
        Me.LblEstancias.Name = "LblEstancias"
        Me.LblEstancias.Size = New System.Drawing.Size(59, 13)
        Me.LblEstancias.TabIndex = 61
        Me.LblEstancias.Text = "Estancias :"
        '
        'TxtCostoEstancias
        '
        Me.TxtCostoEstancias.Location = New System.Drawing.Point(115, 129)
        Me.TxtCostoEstancias.Name = "TxtCostoEstancias"
        Me.TxtCostoEstancias.Size = New System.Drawing.Size(72, 20)
        Me.TxtCostoEstancias.TabIndex = 16
        Me.TxtCostoEstancias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(101, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "$"
        '
        'LblDevoluciones
        '
        Me.LblDevoluciones.AutoSize = True
        Me.LblDevoluciones.Location = New System.Drawing.Point(12, 107)
        Me.LblDevoluciones.Name = "LblDevoluciones"
        Me.LblDevoluciones.Size = New System.Drawing.Size(78, 13)
        Me.LblDevoluciones.TabIndex = 58
        Me.LblDevoluciones.Text = "Devoluciones :"
        '
        'TxtCostoDevoluciones
        '
        Me.TxtCostoDevoluciones.Location = New System.Drawing.Point(115, 104)
        Me.TxtCostoDevoluciones.Name = "TxtCostoDevoluciones"
        Me.TxtCostoDevoluciones.Size = New System.Drawing.Size(72, 20)
        Me.TxtCostoDevoluciones.TabIndex = 14
        Me.TxtCostoDevoluciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtComenDemoras
        '
        Me.TxtComenDemoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtComenDemoras.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TxtComenDemoras.Location = New System.Drawing.Point(204, 79)
        Me.TxtComenDemoras.MaxLength = 50
        Me.TxtComenDemoras.Name = "TxtComenDemoras"
        Me.TxtComenDemoras.Size = New System.Drawing.Size(115, 20)
        Me.TxtComenDemoras.TabIndex = 13
        Me.TxtComenDemoras.Text = "Comentario"
        '
        'TxtComenManiobras
        '
        Me.TxtComenManiobras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtComenManiobras.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TxtComenManiobras.Location = New System.Drawing.Point(204, 53)
        Me.TxtComenManiobras.MaxLength = 50
        Me.TxtComenManiobras.Name = "TxtComenManiobras"
        Me.TxtComenManiobras.Size = New System.Drawing.Size(115, 20)
        Me.TxtComenManiobras.TabIndex = 11
        Me.TxtComenManiobras.Text = "Comentario"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(101, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "$"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Demoras :"
        '
        'TxtCostoDemoras
        '
        Me.TxtCostoDemoras.Location = New System.Drawing.Point(115, 79)
        Me.TxtCostoDemoras.Name = "TxtCostoDemoras"
        Me.TxtCostoDemoras.Size = New System.Drawing.Size(72, 20)
        Me.TxtCostoDemoras.TabIndex = 12
        Me.TxtCostoDemoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(101, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "$"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(101, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "$"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(101, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "$"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(101, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "$"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "$"
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Location = New System.Drawing.Point(115, 232)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(72, 20)
        Me.TxtTotal.TabIndex = 47
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(12, 235)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(40, 13)
        Me.LblTotal.TabIndex = 46
        Me.LblTotal.Text = "Total  :"
        '
        'CkbCerrarFlete
        '
        Me.CkbCerrarFlete.AutoSize = True
        Me.CkbCerrarFlete.Enabled = False
        Me.CkbCerrarFlete.Location = New System.Drawing.Point(471, 87)
        Me.CkbCerrarFlete.Name = "CkbCerrarFlete"
        Me.CkbCerrarFlete.Size = New System.Drawing.Size(80, 17)
        Me.CkbCerrarFlete.TabIndex = 91
        Me.CkbCerrarFlete.Text = "Cerrar Flete"
        Me.CkbCerrarFlete.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.STBlblUsuario})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 652)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(735, 22)
        Me.StatusStrip1.TabIndex = 92
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(256, 17)
        Me.ToolStripStatusLabel1.Text = "Desarrollo de Engordas Estabuladas S.A. de C.V."
        '
        'STBlblUsuario
        '
        Me.STBlblUsuario.Name = "STBlblUsuario"
        Me.STBlblUsuario.Size = New System.Drawing.Size(80, 17)
        Me.STBlblUsuario.Text = "STBlblUsuario"
        '
        'btnImprimir
        '
        Me.btnImprimir.Enabled = False
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(664, 17)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(37, 38)
        Me.btnImprimir.TabIndex = 93
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Enabled = False
        Me.BtnModificar.Image = Global.WindowsApplication1.My.Resources.Resources.refreshx
        Me.BtnModificar.Location = New System.Drawing.Point(576, 17)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(37, 38)
        Me.BtnModificar.TabIndex = 90
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.Location = New System.Drawing.Point(532, 17)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(37, 38)
        Me.BtnNuevo.TabIndex = 8
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Enabled = False
        Me.BtnGrabar.Image = CType(resources.GetObject("BtnGrabar.Image"), System.Drawing.Image)
        Me.BtnGrabar.Location = New System.Drawing.Point(488, 17)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(37, 38)
        Me.BtnGrabar.TabIndex = 7
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'TxtConsultar
        '
        Me.TxtConsultar.Image = Global.WindowsApplication1.My.Resources.Resources.ico_buscar1
        Me.TxtConsultar.Location = New System.Drawing.Point(620, 17)
        Me.TxtConsultar.Name = "TxtConsultar"
        Me.TxtConsultar.Size = New System.Drawing.Size(37, 38)
        Me.TxtConsultar.TabIndex = 94
        Me.TxtConsultar.UseVisualStyleBackColor = True
        '
        'frmRegistroFletes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 674)
        Me.Controls.Add(Me.TxtConsultar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.CkbCerrarFlete)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.GbxCostos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.DgvFacturas)
        Me.Controls.Add(Me.GbxRangoFechas)
        Me.Controls.Add(Me.GbxDatos)
        Me.Controls.Add(Me.GbxFolio)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRegistroFletes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Fletes"
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbxRangoFechas.ResumeLayout(False)
        Me.GbxRangoFechas.PerformLayout()
        Me.GbxDatos.ResumeLayout(False)
        Me.GbxDatos.PerformLayout()
        Me.GbxFolio.ResumeLayout(False)
        Me.GbxFolio.PerformLayout()
        Me.GbxCostos.ResumeLayout(False)
        Me.GbxCostos.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents GbxRangoFechas As System.Windows.Forms.GroupBox
    Friend WithEvents LblFechaFinal As System.Windows.Forms.Label
    Friend WithEvents LblFechaInicial As System.Windows.Forms.Label
    Friend WithEvents DtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents GbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents CbxMunicipioDestino As System.Windows.Forms.ComboBox
    Friend WithEvents CbxEstadoDestino As System.Windows.Forms.ComboBox
    Friend WithEvents CbxMunicipioOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents CbxEstadoOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents LblDestino As System.Windows.Forms.Label
    Friend WithEvents LblOrigen As System.Windows.Forms.Label
    Friend WithEvents LblChofer As System.Windows.Forms.Label
    Friend WithEvents LblProveedor As System.Windows.Forms.Label
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents GbxFolio As System.Windows.Forms.GroupBox
    Friend WithEvents TxtFolio As System.Windows.Forms.TextBox
    Friend WithEvents LblFolio As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents BtnCargarFac As System.Windows.Forms.Button
    Friend WithEvents CbxChofer As System.Windows.Forms.ComboBox
    Friend WithEvents LblCostoFlete As System.Windows.Forms.Label
    Friend WithEvents TxtCostoFlete As System.Windows.Forms.TextBox
    Friend WithEvents TxtCostoManiobras As System.Windows.Forms.TextBox
    Friend WithEvents LblCostoManiobras As System.Windows.Forms.Label
    Friend WithEvents TxtIva As System.Windows.Forms.TextBox
    Friend WithEvents LblIva As System.Windows.Forms.Label
    Friend WithEvents TxtRetencion As System.Windows.Forms.TextBox
    Friend WithEvents LblRetencion As System.Windows.Forms.Label
    Friend WithEvents GbxCostos As System.Windows.Forms.GroupBox
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents TxtKmProg As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents CbxProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CkbCerrarFlete As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtCostoDemoras As System.Windows.Forms.TextBox
    Friend WithEvents TxtComenDemoras As System.Windows.Forms.TextBox
    Friend WithEvents TxtComenManiobras As System.Windows.Forms.TextBox
    Friend WithEvents TxtComenOtros As System.Windows.Forms.TextBox
    Friend WithEvents TxtComenEstancias As System.Windows.Forms.TextBox
    Friend WithEvents TxtComenDevo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtCostoOtros As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LblEstancias As System.Windows.Forms.Label
    Friend WithEvents TxtCostoEstancias As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LblDevoluciones As System.Windows.Forms.Label
    Friend WithEvents TxtCostoDevoluciones As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STBlblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents check As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaVta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Razon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vendedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtConsultar As System.Windows.Forms.Button
End Class
