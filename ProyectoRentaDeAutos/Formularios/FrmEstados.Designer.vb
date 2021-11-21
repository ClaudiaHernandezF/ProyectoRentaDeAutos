<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEstados
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtIdEstados = New System.Windows.Forms.TextBox()
        Me.TxtNomEstados = New System.Windows.Forms.TextBox()
        Me.DGVestadoss = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnLimpia = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DGVestadoss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "No. Estado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(280, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Nombre Estado:"
        '
        'TxtIdEstados
        '
        Me.TxtIdEstados.Location = New System.Drawing.Point(81, 23)
        Me.TxtIdEstados.Name = "TxtIdEstados"
        Me.TxtIdEstados.Size = New System.Drawing.Size(180, 20)
        Me.TxtIdEstados.TabIndex = 14
        '
        'TxtNomEstados
        '
        Me.TxtNomEstados.Location = New System.Drawing.Point(369, 23)
        Me.TxtNomEstados.Name = "TxtNomEstados"
        Me.TxtNomEstados.Size = New System.Drawing.Size(180, 20)
        Me.TxtNomEstados.TabIndex = 15
        '
        'DGVestadoss
        '
        Me.DGVestadoss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVestadoss.Location = New System.Drawing.Point(28, 94)
        Me.DGVestadoss.Name = "DGVestadoss"
        Me.DGVestadoss.Size = New System.Drawing.Size(504, 153)
        Me.DGVestadoss.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(228, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Estados Registrados"
        '
        'BtnLimpia
        '
        Me.BtnLimpia.Location = New System.Drawing.Point(186, 274)
        Me.BtnLimpia.Name = "BtnLimpia"
        Me.BtnLimpia.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpia.TabIndex = 18
        Me.BtnLimpia.Text = "Nuevo"
        Me.BtnLimpia.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(283, 274)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 19
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(378, 274)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 20
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(474, 274)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 21
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'FrmEstados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 309)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnLimpia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DGVestadoss)
        Me.Controls.Add(Me.TxtNomEstados)
        Me.Controls.Add(Me.TxtIdEstados)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FrmEstados"
        Me.Text = "Estados"
        CType(Me.DGVestadoss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtIdEstados As TextBox
    Friend WithEvents TxtNomEstados As TextBox
    Friend WithEvents DGVestadoss As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnLimpia As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
