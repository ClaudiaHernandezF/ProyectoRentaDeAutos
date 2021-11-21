<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCatalogoP
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
        Me.BtnDir = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DireccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CiudadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColoniasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SucursalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnDir
        '
        Me.BtnDir.Location = New System.Drawing.Point(12, 94)
        Me.BtnDir.Name = "BtnDir"
        Me.BtnDir.Size = New System.Drawing.Size(75, 23)
        Me.BtnDir.TabIndex = 0
        Me.BtnDir.Text = "Direcciones"
        Me.BtnDir.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DireccionesToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.SucursalesToolStripMenuItem, Me.EmpleadosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(511, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DireccionesToolStripMenuItem
        '
        Me.DireccionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstadosToolStripMenuItem, Me.CiudadesToolStripMenuItem, Me.ColoniasToolStripMenuItem})
        Me.DireccionesToolStripMenuItem.Name = "DireccionesToolStripMenuItem"
        Me.DireccionesToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.DireccionesToolStripMenuItem.Text = "Direcciones"
        '
        'EstadosToolStripMenuItem
        '
        Me.EstadosToolStripMenuItem.Name = "EstadosToolStripMenuItem"
        Me.EstadosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EstadosToolStripMenuItem.Text = "Estados"
        '
        'CiudadesToolStripMenuItem
        '
        Me.CiudadesToolStripMenuItem.Name = "CiudadesToolStripMenuItem"
        Me.CiudadesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CiudadesToolStripMenuItem.Text = "Ciudades"
        '
        'ColoniasToolStripMenuItem
        '
        Me.ColoniasToolStripMenuItem.Name = "ColoniasToolStripMenuItem"
        Me.ColoniasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ColoniasToolStripMenuItem.Text = "Colonias"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'SucursalesToolStripMenuItem
        '
        Me.SucursalesToolStripMenuItem.Name = "SucursalesToolStripMenuItem"
        Me.SucursalesToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.SucursalesToolStripMenuItem.Text = "Sucursales"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(491, 9)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(20, 275)
        Me.VScrollBar1.TabIndex = 2
        '
        'FrmCatalogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 282)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.BtnDir)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmCatalogo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnDir As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DireccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CiudadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColoniasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SucursalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VScrollBar1 As VScrollBar
End Class
