<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmColonias
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
        Me.components = New System.ComponentModel.Container()
        Me.CmbEstado = New System.Windows.Forms.ComboBox()
        Me.CmbCiudad = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGVcolonias = New System.Windows.Forms.DataGridView()
        Me.TxtIdCol = New System.Windows.Forms.TextBox()
        Me.TxtNomCol = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnLimpia = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DGVcolonias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbEstado
        '
        Me.CmbEstado.FormattingEnabled = True
        Me.CmbEstado.Location = New System.Drawing.Point(105, 24)
        Me.CmbEstado.Name = "CmbEstado"
        Me.CmbEstado.Size = New System.Drawing.Size(180, 21)
        Me.CmbEstado.TabIndex = 0
        '
        'CmbCiudad
        '
        Me.CmbCiudad.FormattingEnabled = True
        Me.CmbCiudad.Location = New System.Drawing.Point(380, 24)
        Me.CmbCiudad.Name = "CmbCiudad"
        Me.CmbCiudad.Size = New System.Drawing.Size(180, 21)
        Me.CmbCiudad.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Estado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(331, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ciudad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "No. Colonia:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(291, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nombre Colonia:"
        '
        'DGVcolonias
        '
        Me.DGVcolonias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVcolonias.Location = New System.Drawing.Point(33, 159)
        Me.DGVcolonias.Name = "DGVcolonias"
        Me.DGVcolonias.Size = New System.Drawing.Size(504, 153)
        Me.DGVcolonias.TabIndex = 6
        '
        'TxtIdCol
        '
        Me.TxtIdCol.Location = New System.Drawing.Point(105, 74)
        Me.TxtIdCol.Name = "TxtIdCol"
        Me.TxtIdCol.Size = New System.Drawing.Size(180, 20)
        Me.TxtIdCol.TabIndex = 7
        '
        'TxtNomCol
        '
        Me.TxtNomCol.Location = New System.Drawing.Point(380, 81)
        Me.TxtNomCol.Name = "TxtNomCol"
        Me.TxtNomCol.Size = New System.Drawing.Size(180, 20)
        Me.TxtNomCol.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(225, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Colonias Registradas"
        '
        'BtnLimpia
        '
        Me.BtnLimpia.Location = New System.Drawing.Point(210, 335)
        Me.BtnLimpia.Name = "BtnLimpia"
        Me.BtnLimpia.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpia.TabIndex = 10
        Me.BtnLimpia.Text = "Nuevo"
        Me.BtnLimpia.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(301, 335)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 11
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(394, 335)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 12
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(485, 335)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 13
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'FrmColonias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 370)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnLimpia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtNomCol)
        Me.Controls.Add(Me.TxtIdCol)
        Me.Controls.Add(Me.DGVcolonias)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbCiudad)
        Me.Controls.Add(Me.CmbEstado)
        Me.Name = "FrmColonias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Colonias"
        CType(Me.DGVcolonias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbEstado As ComboBox
    Friend WithEvents CmbCiudad As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DGVcolonias As DataGridView
    Friend WithEvents TxtIdCol As TextBox
    Friend WithEvents TxtNomCol As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnLimpia As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
