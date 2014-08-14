Imports System.Drawing.Printing
Public Class frmRPTInfRegFletes
    Public fechaIni As Date
    Public fechaFin As Date
    Private Sub frmRPTInfRegFletes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSRegistroFlet.spRegistroFletes' Puede moverla o quitarla según sea necesario.
        Me.spRegistroFletesTableAdapter.Fill(Me.DSRegistroFlet.spRegistroFletes, fechaIni, fechaFin)
        'TODO: esta línea de código carga datos en la tabla 'DSRegisFletes.spRegistroFletes' Puede moverla o quitarla según sea necesario.
        'Me.spRegistroFletesTableAdapter.Fill(Me.DSRegisFletes.spRegistroFletes, fechaIni, fechaFin)   
        Dim pg As New PageSettings
        'pg.Margins.Top = 0
        'pg.Margins.Bottom = 0
        pg.Margins.Left = 15
        pg.Margins.Right = 0
        pg.Landscape = True
        Dim tam As New PaperSize
        tam.RawKind = CInt(PaperKind.A4)
        pg.PaperSize = tam
        ReportViewer1.SetPageSettings(pg)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class