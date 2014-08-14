<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MttoChoferesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MttoRutasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MttoUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerfilUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetContraseñaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MttoVendedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroFletesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INFORMESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeFletesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirDeSysComercialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label1.Location = New System.Drawing.Point(784, 502)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(419, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Desarrollo de Engordas Estabuladas S.A. de C.V"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CataToolStripMenuItem, Me.INFORMESToolStripMenuItem, Me.SALIDAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1276, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CataToolStripMenuItem
        '
        Me.CataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MttoChoferesToolStripMenuItem, Me.MttoRutasToolStripMenuItem, Me.MttoUsuariosToolStripMenuItem, Me.MttoVendedoresToolStripMenuItem, Me.RegistroFletesToolStripMenuItem})
        Me.CataToolStripMenuItem.Name = "CataToolStripMenuItem"
        Me.CataToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.CataToolStripMenuItem.Text = "CATALOGO"
        '
        'MttoChoferesToolStripMenuItem
        '
        Me.MttoChoferesToolStripMenuItem.Name = "MttoChoferesToolStripMenuItem"
        Me.MttoChoferesToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.MttoChoferesToolStripMenuItem.Text = "Mtto.Choferes"
        '
        'MttoRutasToolStripMenuItem
        '
        Me.MttoRutasToolStripMenuItem.Name = "MttoRutasToolStripMenuItem"
        Me.MttoRutasToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.MttoRutasToolStripMenuItem.Text = "Mtto.Rutas"
        '
        'MttoUsuariosToolStripMenuItem
        '
        Me.MttoUsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerfilUsuariosToolStripMenuItem, Me.ResetContraseñaToolStripMenuItem1})
        Me.MttoUsuariosToolStripMenuItem.Name = "MttoUsuariosToolStripMenuItem"
        Me.MttoUsuariosToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.MttoUsuariosToolStripMenuItem.Text = "Mtto.Usuarios"
        '
        'PerfilUsuariosToolStripMenuItem
        '
        Me.PerfilUsuariosToolStripMenuItem.Name = "PerfilUsuariosToolStripMenuItem"
        Me.PerfilUsuariosToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.PerfilUsuariosToolStripMenuItem.Text = "Perfil Usuarios"
        '
        'ResetContraseñaToolStripMenuItem1
        '
        Me.ResetContraseñaToolStripMenuItem1.Name = "ResetContraseñaToolStripMenuItem1"
        Me.ResetContraseñaToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.ResetContraseñaToolStripMenuItem1.Text = "Reset Contraseña"
        '
        'MttoVendedoresToolStripMenuItem
        '
        Me.MttoVendedoresToolStripMenuItem.Name = "MttoVendedoresToolStripMenuItem"
        Me.MttoVendedoresToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.MttoVendedoresToolStripMenuItem.Text = "Mtto. Vendedores"
        '
        'RegistroFletesToolStripMenuItem
        '
        Me.RegistroFletesToolStripMenuItem.Name = "RegistroFletesToolStripMenuItem"
        Me.RegistroFletesToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.RegistroFletesToolStripMenuItem.Text = "Registro Fletes"
        '
        'INFORMESToolStripMenuItem
        '
        Me.INFORMESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroDeFletesToolStripMenuItem})
        Me.INFORMESToolStripMenuItem.Name = "INFORMESToolStripMenuItem"
        Me.INFORMESToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.INFORMESToolStripMenuItem.Text = "INFORMES"
        '
        'RegistroDeFletesToolStripMenuItem
        '
        Me.RegistroDeFletesToolStripMenuItem.Name = "RegistroDeFletesToolStripMenuItem"
        Me.RegistroDeFletesToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RegistroDeFletesToolStripMenuItem.Text = "Reporte de Fletes"
        '
        'SALIDAToolStripMenuItem
        '
        Me.SALIDAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesionToolStripMenuItem, Me.SalirDeSysComercialToolStripMenuItem})
        Me.SALIDAToolStripMenuItem.Name = "SALIDAToolStripMenuItem"
        Me.SALIDAToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.SALIDAToolStripMenuItem.Text = "SALIDA"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesion"
        '
        'SalirDeSysComercialToolStripMenuItem
        '
        Me.SalirDeSysComercialToolStripMenuItem.Name = "SalirDeSysComercialToolStripMenuItem"
        Me.SalirDeSysComercialToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SalirDeSysComercialToolStripMenuItem.Text = "Salir de SysComercial"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(898, 417)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(198, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 538)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MttoChoferesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SALIDAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirDeSysComercialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MttoRutasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MttoUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetContraseñaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerfilUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MttoVendedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroFletesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INFORMESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroDeFletesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
