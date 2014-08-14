Imports WindowsApplication1.ClsTools
Public Class frmInformeRegistroFletes

    Private Sub frmInformeRegistroFletes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Mantenimiento Choferes " + Space(10) + VersionComerci()
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        Me.MaximizeBox = False
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim fechainicial As Date
        Dim fechafinal As Date
        fechainicial = DtpFechaInicial.Value 'Format(DtpFechaInicial.Value, "yyyyMMdd")
        fechafinal = DtpFechaFinal.Value 'Format(DtpFechaFinal.Value, "yyyyMMdd")
        Dim frm As New frmRPTInfRegFletes
        frm.fechaIni = fechainicial
        frm.fechaFin = fechafinal
        frm.Show()
    End Sub

End Class