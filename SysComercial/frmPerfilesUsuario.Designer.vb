﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPerfilesUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPerfilesUsuario))
        Me.lstPerfil = New System.Windows.Forms.ListView()
        Me.xPerfil = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.yDescripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.yUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STBlblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtPerfil = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstPerfil
        '
        Me.lstPerfil.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.xPerfil, Me.yDescripcion, Me.yUsuario})
        Me.lstPerfil.GridLines = True
        Me.lstPerfil.Location = New System.Drawing.Point(10, 100)
        Me.lstPerfil.Name = "lstPerfil"
        Me.lstPerfil.Size = New System.Drawing.Size(253, 161)
        Me.lstPerfil.TabIndex = 5
        Me.lstPerfil.UseCompatibleStateImageBehavior = False
        Me.lstPerfil.View = System.Windows.Forms.View.Details
        '
        'xPerfil
        '
        Me.xPerfil.Text = "Perfil"
        Me.xPerfil.Width = 43
        '
        'yDescripcion
        '
        Me.yDescripcion.Text = "Descripcion"
        Me.yDescripcion.Width = 101
        '
        'yUsuario
        '
        Me.yUsuario.Text = "Usuario"
        Me.yUsuario.Width = 104
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Perfil"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(9, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Perfiles de Usuarios"
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 0
        Me.LineShape2.X2 = 269
        Me.LineShape2.Y1 = 45
        Me.LineShape2.Y2 = 45
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 0
        Me.LineShape1.X2 = 269
        Me.LineShape1.Y1 = 44
        Me.LineShape1.Y2 = 44
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(273, 286)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.STBlblUsuario})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 264)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(273, 22)
        Me.StatusStrip1.TabIndex = 6
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
        Me.STBlblUsuario.Size = New System.Drawing.Size(80, 15)
        Me.STBlblUsuario.Text = "STBlblUsuario"
        '
        'txtPerfil
        '
        Me.txtPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPerfil.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtPerfil.Location = New System.Drawing.Point(55, 65)
        Me.txtPerfil.MaxLength = 2
        Me.txtPerfil.Name = "txtPerfil"
        Me.txtPerfil.Size = New System.Drawing.Size(70, 18)
        Me.txtPerfil.TabIndex = 3
        Me.txtPerfil.Text = "Buscar Perfil"
        '
        'Button1
        '
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources.refresh_0
        Me.Button1.Location = New System.Drawing.Point(226, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 37)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmPerfilesUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 286)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtPerfil)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstPerfil)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPerfilesUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Perfiles Usuarios"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstPerfil As System.Windows.Forms.ListView
    Friend WithEvents xPerfil As System.Windows.Forms.ColumnHeader
    Friend WithEvents yDescripcion As System.Windows.Forms.ColumnHeader
    Friend WithEvents yUsuario As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STBlblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtPerfil As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
