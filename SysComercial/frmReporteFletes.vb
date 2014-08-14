
Public Class frmReporteFletes
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If Me.DtpFechaFinal.Value < Me.DtpFechaInicial.Value Then
            MsgBox("La Fecha Final no debe ser Menor a la Fecha Inicial..!!!", MessageBoxIcon.Error)
        Else
            Dim frm As New frmRPTReporteFletes
            frm.fechaInicial = DtpFechaInicial.Value
            frm.fechaFinal = DtpFechaFinal.Value
            frm.ShowDialog()
        End If
    End Sub
End Class