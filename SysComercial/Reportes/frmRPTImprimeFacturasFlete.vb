Public Class frmRPTImprimeFacturasFlete
    Public flete As Integer
    Private Sub frmRPTImprimeFacturasFlete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSImprimeFacturasFletes.spFacturasFletesDetalle' Puede moverla o quitarla según sea necesario.
        Me.spFacturasFletesDetalleTableAdapter.Fill(Me.DSImprimeFacturasFletes.spFacturasFletesDetalle, flete)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class