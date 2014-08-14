<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTImprimeFacturasFlete
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTImprimeFacturasFlete))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.spFacturasFletesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSImprimeFacturasFletes = New WindowsApplication1.DSImprimeFacturasFletes()
        Me.spFacturasFletesDetalleTableAdapter = New WindowsApplication1.DSImprimeFacturasFletesTableAdapters.spFacturasFletesDetalleTableAdapter()
        CType(Me.spFacturasFletesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSImprimeFacturasFletes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSImprimeFacturasFletes"
        ReportDataSource1.Value = Me.spFacturasFletesDetalleBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTImprimeFacturasFlete.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(818, 499)
        Me.ReportViewer1.TabIndex = 0
        '
        'spFacturasFletesDetalleBindingSource
        '
        Me.spFacturasFletesDetalleBindingSource.DataMember = "spFacturasFletesDetalle"
        Me.spFacturasFletesDetalleBindingSource.DataSource = Me.DSImprimeFacturasFletes
        '
        'DSImprimeFacturasFletes
        '
        Me.DSImprimeFacturasFletes.DataSetName = "DSImprimeFacturasFletes"
        Me.DSImprimeFacturasFletes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'spFacturasFletesDetalleTableAdapter
        '
        Me.spFacturasFletesDetalleTableAdapter.ClearBeforeFill = True
        '
        'frmRPTImprimeFacturasFlete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 499)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRPTImprimeFacturasFlete"
        Me.Text = "Imprime Facturas Flete"
        CType(Me.spFacturasFletesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSImprimeFacturasFletes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spFacturasFletesDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSImprimeFacturasFletes As WindowsApplication1.DSImprimeFacturasFletes
    Friend WithEvents spFacturasFletesDetalleTableAdapter As WindowsApplication1.DSImprimeFacturasFletesTableAdapters.spFacturasFletesDetalleTableAdapter
End Class
