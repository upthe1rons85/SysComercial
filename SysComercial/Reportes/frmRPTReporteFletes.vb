﻿Public Class frmRPTReporteFletes
    Public fechaInicial As String
    Public fechaFinal As String
    Private Sub frmRPTReporteFletes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSRepFletes.spRegistroFletes' Puede moverla o quitarla según sea necesario.
        Me.spRegistroFletesTableAdapter.Fill(Me.DSRepFletes.spRegistroFletes, fechaInicial, fechaFinal)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class