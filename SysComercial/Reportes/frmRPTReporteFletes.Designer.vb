<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTReporteFletes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTReporteFletes))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DSRepFletes = New WindowsApplication1.DSRepFletes()
        Me.spRegistroFletesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.spRegistroFletesTableAdapter = New WindowsApplication1.DSRepFletesTableAdapters.spRegistroFletesTableAdapter()
        CType(Me.DSRepFletes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spRegistroFletesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSRepFletes"
        ReportDataSource1.Value = Me.spRegistroFletesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.RPTReporteFletes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(991, 462)
        Me.ReportViewer1.TabIndex = 0
        '
        'DSRepFletes
        '
        Me.DSRepFletes.DataSetName = "DSRepFletes"
        Me.DSRepFletes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'spRegistroFletesBindingSource
        '
        Me.spRegistroFletesBindingSource.DataMember = "spRegistroFletes"
        Me.spRegistroFletesBindingSource.DataSource = Me.DSRepFletes
        '
        'spRegistroFletesTableAdapter
        '
        Me.spRegistroFletesTableAdapter.ClearBeforeFill = True
        '
        'frmRPTReporteFletes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 462)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRPTReporteFletes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRPTReporteFletes"
        CType(Me.DSRepFletes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spRegistroFletesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spRegistroFletesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSRepFletes As WindowsApplication1.DSRepFletes
    Friend WithEvents spRegistroFletesTableAdapter As WindowsApplication1.DSRepFletesTableAdapters.spRegistroFletesTableAdapter
End Class
