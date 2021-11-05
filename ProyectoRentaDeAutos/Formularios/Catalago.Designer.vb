<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Catalago
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabEstados = New System.Windows.Forms.TabPage()
        Me.TabMarcas = New System.Windows.Forms.TabPage()
        Me.LabelIDEst = New System.Windows.Forms.Label()
        Me.TextIDEst = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabEstAuto = New System.Windows.Forms.TabPage()
        Me.TabModelos = New System.Windows.Forms.TabPage()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TabCiudades = New System.Windows.Forms.TabPage()
        Me.TabDir = New System.Windows.Forms.TabPage()
        Me.LabelCalle = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.LabelIDCiudad = New System.Windows.Forms.Label()
        Me.TextIDCiudad = New System.Windows.Forms.TextBox()
        Me.LabelNombreciudad = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabEstados.SuspendLayout()
        Me.TabMarcas.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabEstAuto.SuspendLayout()
        Me.TabModelos.SuspendLayout()
        Me.TabCiudades.SuspendLayout()
        Me.TabDir.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(171, 368)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(259, 56)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button1.Location = New System.Drawing.Point(9, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Nuevo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button2.Location = New System.Drawing.Point(90, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Guardar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button3.Location = New System.Drawing.Point(171, 17)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 623)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(626, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabEstados)
        Me.TabControl1.Controls.Add(Me.TabMarcas)
        Me.TabControl1.Controls.Add(Me.TabModelos)
        Me.TabControl1.Controls.Add(Me.TabEstAuto)
        Me.TabControl1.Controls.Add(Me.TabCiudades)
        Me.TabControl1.Controls.Add(Me.TabDir)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(418, 169)
        Me.TabControl1.TabIndex = 2
        '
        'TabEstados
        '
        Me.TabEstados.Controls.Add(Me.TextBox1)
        Me.TabEstados.Controls.Add(Me.Label1)
        Me.TabEstados.Controls.Add(Me.TextIDEst)
        Me.TabEstados.Controls.Add(Me.LabelIDEst)
        Me.TabEstados.Location = New System.Drawing.Point(4, 22)
        Me.TabEstados.Name = "TabEstados"
        Me.TabEstados.Padding = New System.Windows.Forms.Padding(3)
        Me.TabEstados.Size = New System.Drawing.Size(410, 143)
        Me.TabEstados.TabIndex = 0
        Me.TabEstados.Text = "Estados"
        Me.TabEstados.UseVisualStyleBackColor = True
        '
        'TabMarcas
        '
        Me.TabMarcas.Controls.Add(Me.TextBox2)
        Me.TabMarcas.Controls.Add(Me.Label2)
        Me.TabMarcas.Controls.Add(Me.TextBox3)
        Me.TabMarcas.Controls.Add(Me.Label3)
        Me.TabMarcas.Location = New System.Drawing.Point(4, 22)
        Me.TabMarcas.Name = "TabMarcas"
        Me.TabMarcas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMarcas.Size = New System.Drawing.Size(410, 143)
        Me.TabMarcas.TabIndex = 1
        Me.TabMarcas.Text = "Marcas"
        Me.TabMarcas.UseVisualStyleBackColor = True
        '
        'LabelIDEst
        '
        Me.LabelIDEst.AutoSize = True
        Me.LabelIDEst.Location = New System.Drawing.Point(30, 20)
        Me.LabelIDEst.Name = "LabelIDEst"
        Me.LabelIDEst.Size = New System.Drawing.Size(18, 13)
        Me.LabelIDEst.TabIndex = 0
        Me.LabelIDEst.Text = "ID"
        '
        'TextIDEst
        '
        Me.TextIDEst.Location = New System.Drawing.Point(30, 36)
        Me.TextIDEst.Name = "TextIDEst"
        Me.TextIDEst.Size = New System.Drawing.Size(100, 20)
        Me.TextIDEst.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(30, 84)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(12, 183)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(414, 179)
        Me.DataGridView2.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(30, 84)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(30, 36)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ID"
        '
        'TabEstAuto
        '
        Me.TabEstAuto.Controls.Add(Me.TextBox4)
        Me.TabEstAuto.Controls.Add(Me.Label4)
        Me.TabEstAuto.Controls.Add(Me.TextBox5)
        Me.TabEstAuto.Controls.Add(Me.Label5)
        Me.TabEstAuto.Location = New System.Drawing.Point(4, 22)
        Me.TabEstAuto.Name = "TabEstAuto"
        Me.TabEstAuto.Size = New System.Drawing.Size(410, 143)
        Me.TabEstAuto.TabIndex = 2
        Me.TabEstAuto.Text = "Estados de auto"
        Me.TabEstAuto.UseVisualStyleBackColor = True
        '
        'TabModelos
        '
        Me.TabModelos.Controls.Add(Me.ComboBox1)
        Me.TabModelos.Controls.Add(Me.TextBox7)
        Me.TabModelos.Controls.Add(Me.Label7)
        Me.TabModelos.Controls.Add(Me.TextBox6)
        Me.TabModelos.Controls.Add(Me.Label8)
        Me.TabModelos.Controls.Add(Me.Label6)
        Me.TabModelos.Location = New System.Drawing.Point(4, 22)
        Me.TabModelos.Name = "TabModelos"
        Me.TabModelos.Size = New System.Drawing.Size(410, 143)
        Me.TabModelos.TabIndex = 3
        Me.TabModelos.Text = "Modelos"
        Me.TabModelos.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(30, 84)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Descripción"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(30, 36)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ID Modelo"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(30, 36)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Nombre"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(30, 84)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(183, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ID Marca"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(183, 36)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'TabCiudades
        '
        Me.TabCiudades.Controls.Add(Me.ComboBox2)
        Me.TabCiudades.Controls.Add(Me.TextBox9)
        Me.TabCiudades.Controls.Add(Me.TextIDCiudad)
        Me.TabCiudades.Controls.Add(Me.LabelNombreciudad)
        Me.TabCiudades.Controls.Add(Me.Label9)
        Me.TabCiudades.Controls.Add(Me.LabelIDCiudad)
        Me.TabCiudades.Location = New System.Drawing.Point(4, 22)
        Me.TabCiudades.Name = "TabCiudades"
        Me.TabCiudades.Size = New System.Drawing.Size(410, 143)
        Me.TabCiudades.TabIndex = 4
        Me.TabCiudades.Text = "Ciudades"
        Me.TabCiudades.UseVisualStyleBackColor = True
        '
        'TabDir
        '
        Me.TabDir.Controls.Add(Me.TextBox8)
        Me.TabDir.Controls.Add(Me.LabelCalle)
        Me.TabDir.Location = New System.Drawing.Point(4, 22)
        Me.TabDir.Name = "TabDir"
        Me.TabDir.Size = New System.Drawing.Size(410, 143)
        Me.TabDir.TabIndex = 5
        Me.TabDir.Text = "Direcciones"
        Me.TabDir.UseVisualStyleBackColor = True
        '
        'LabelCalle
        '
        Me.LabelCalle.AutoSize = True
        Me.LabelCalle.Location = New System.Drawing.Point(30, 20)
        Me.LabelCalle.Name = "LabelCalle"
        Me.LabelCalle.Size = New System.Drawing.Size(30, 13)
        Me.LabelCalle.TabIndex = 0
        Me.LabelCalle.Text = "Calle"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(30, 36)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 1
        '
        'LabelIDCiudad
        '
        Me.LabelIDCiudad.AutoSize = True
        Me.LabelIDCiudad.Location = New System.Drawing.Point(30, 20)
        Me.LabelIDCiudad.Name = "LabelIDCiudad"
        Me.LabelIDCiudad.Size = New System.Drawing.Size(54, 13)
        Me.LabelIDCiudad.TabIndex = 0
        Me.LabelIDCiudad.Text = "ID Ciudad"
        '
        'TextIDCiudad
        '
        Me.TextIDCiudad.Location = New System.Drawing.Point(30, 37)
        Me.TextIDCiudad.Name = "TextIDCiudad"
        Me.TextIDCiudad.Size = New System.Drawing.Size(100, 20)
        Me.TextIDCiudad.TabIndex = 1
        '
        'LabelNombreciudad
        '
        Me.LabelNombreciudad.AutoSize = True
        Me.LabelNombreciudad.Location = New System.Drawing.Point(30, 68)
        Me.LabelNombreciudad.Name = "LabelNombreciudad"
        Me.LabelNombreciudad.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombreciudad.TabIndex = 0
        Me.LabelNombreciudad.Text = "Nombre"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(30, 84)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 20)
        Me.TextBox9.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(183, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "ID Estado"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(183, 35)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 2
        '
        'Frm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 436)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(458, 39)
        Me.Name = "Frm1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálago"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabEstados.ResumeLayout(False)
        Me.TabEstados.PerformLayout()
        Me.TabMarcas.ResumeLayout(False)
        Me.TabMarcas.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabEstAuto.ResumeLayout(False)
        Me.TabEstAuto.PerformLayout()
        Me.TabModelos.ResumeLayout(False)
        Me.TabModelos.PerformLayout()
        Me.TabCiudades.ResumeLayout(False)
        Me.TabCiudades.PerformLayout()
        Me.TabDir.ResumeLayout(False)
        Me.TabDir.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TabEstados As TabPage
    Friend WithEvents LabelIDEst As Label
    Friend WithEvents TabMarcas As TabPage
    Friend WithEvents TextIDEst As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TabEstAuto As TabPage
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TabModelos As TabPage
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TabCiudades As TabPage
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextIDCiudad As TextBox
    Friend WithEvents LabelNombreciudad As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LabelIDCiudad As Label
    Friend WithEvents TabDir As TabPage
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents LabelCalle As Label
End Class
