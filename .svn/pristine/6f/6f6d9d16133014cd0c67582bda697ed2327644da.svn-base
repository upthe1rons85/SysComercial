Imports System.Data.SqlClient
Imports System.Data
Imports WindowsApplication1.ClsTools
Imports System.Deployment.Application
Public Class frmPrincipal

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Space(160) + "Desarrollo de Engordas Estabuladas S.A. de C.V." + Space(10) + VersionComerci()
        Me.Hide()
        login.Show()
        Me.WindowState = 2
    End Sub

    Private Sub SalirDeSysComercialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirDeSysComercialToolStripMenuItem.Click
        If MsgBox("Desea Salir de SysComerci ? ", MessageBoxButtons.YesNo, "               SysComerci [V 1.0]") = MsgBoxResult.Yes Then
            Me.Close()
            Application.Exit()
        End If
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        If MsgBox("Desea Cerrar Sesion ? ", MessageBoxButtons.YesNo, "               SysComerci [V 1.0]") = MsgBoxResult.Yes Then
            Me.Hide()
            'login.Show()
        End If
    End Sub

    'Private Sub MttoChoferesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MttoChoferesToolStripMenuItem.Click
    '    Dim isOpen As Boolean = False
    '    For Each f As Form In Application.OpenForms
    '        If f.Name = FrmChoferes.Name Then
    '            isOpen = True
    '        End If
    '    Next
    '    If isOpen = False Then
    '        My.Forms.FrmChoferes.Show()
    '    Else
    '        My.Forms.FrmChoferes.Focus()
    '    End If
    'End Sub

    Private Sub MttoRutasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MttoRutasToolStripMenuItem.Click
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = FrmRutas.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.FrmRutas.Show()
        Else
            My.Forms.FrmRutas.Focus()
        End If
    End Sub

    Private Sub ResetContraseñaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetContraseñaToolStripMenuItem1.Click
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmCambiarContraseña.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmCambiarContraseña.Show()
        Else
            My.Forms.frmCambiarContraseña.Focus()
        End If
    End Sub

    Private Sub PerfilUsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerfilUsuariosToolStripMenuItem.Click
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmPerfilesUsuario.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmPerfilesUsuario.Show()
        Else
            My.Forms.frmPerfilesUsuario.Focus()
        End If
    End Sub

    Private Sub MttoVendedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MttoVendedoresToolStripMenuItem.Click
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmVendedores.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmVendedores.Show()
        Else
            My.Forms.frmVendedores.Focus()
        End If
    End Sub

    Private Sub RegistroFletesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroFletesToolStripMenuItem.Click
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmRegistroFletes.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmRegistroFletes.Show()
        Else
            My.Forms.frmRegistroFletes.Focus()
        End If
    End Sub

    Private Sub RegistroDeFletesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeFletesToolStripMenuItem.Click
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmReporteFletes.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmReporteFletes.Show()
        Else
            My.Forms.frmReporteFletes.Focus()
        End If
    End Sub
    Private Sub MttoChoferesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MttoChoferesToolStripMenuItem.Click
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = FrmChoferes.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.FrmChoferes.Show()
        Else
            My.Forms.FrmChoferes.Focus()
        End If
    End Sub
End Class
