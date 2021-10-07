<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChbMostrar = New System.Windows.Forms.CheckBox()
        Me.BtnInSesion = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(77, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(137, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(123, 163)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(163, 20)
        Me.TxtUsuario.TabIndex = 1
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Location = New System.Drawing.Point(123, 210)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Size = New System.Drawing.Size(163, 20)
        Me.TxtContraseña.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(39, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contraseña:"
        '
        'ChbMostrar
        '
        Me.ChbMostrar.AutoSize = True
        Me.ChbMostrar.BackColor = System.Drawing.Color.Transparent
        Me.ChbMostrar.ForeColor = System.Drawing.Color.White
        Me.ChbMostrar.Location = New System.Drawing.Point(123, 246)
        Me.ChbMostrar.Name = "ChbMostrar"
        Me.ChbMostrar.Size = New System.Drawing.Size(61, 17)
        Me.ChbMostrar.TabIndex = 6
        Me.ChbMostrar.Text = "Mostrar"
        Me.ChbMostrar.UseVisualStyleBackColor = False
        '
        'BtnInSesion
        '
        Me.BtnInSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnInSesion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInSesion.ForeColor = System.Drawing.Color.White
        Me.BtnInSesion.Location = New System.Drawing.Point(68, 300)
        Me.BtnInSesion.Name = "BtnInSesion"
        Me.BtnInSesion.Size = New System.Drawing.Size(159, 40)
        Me.BtnInSesion.TabIndex = 7
        Me.BtnInSesion.Text = "Iniciar sesión"
        Me.BtnInSesion.UseVisualStyleBackColor = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(308, 369)
        Me.Controls.Add(Me.BtnInSesion)
        Me.Controls.Add(Me.ChbMostrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtContraseña)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Administradores"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ChbMostrar As CheckBox
    Friend WithEvents BtnInSesion As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
