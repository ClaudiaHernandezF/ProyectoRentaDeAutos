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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TablasPestanas = New System.Windows.Forms.TabControl()
        Me.TabAutos = New System.Windows.Forms.TabPage()
        Me.ButtonEliminarAuto = New System.Windows.Forms.Button()
        Me.ButtonGuardarAuto = New System.Windows.Forms.Button()
        Me.ButtonNuevoAuto = New System.Windows.Forms.Button()
        Me.CheckDisponible = New System.Windows.Forms.CheckBox()
        Me.ComboEstAuto = New System.Windows.Forms.ComboBox()
        Me.ComboMarca = New System.Windows.Forms.ComboBox()
        Me.TextCapacidad = New System.Windows.Forms.TextBox()
        Me.LabelCapacidad = New System.Windows.Forms.Label()
        Me.TextPlaca = New System.Windows.Forms.TextBox()
        Me.LabelAutoEstAuto = New System.Windows.Forms.Label()
        Me.LabelAutoMarca = New System.Windows.Forms.Label()
        Me.LabelPlaca = New System.Windows.Forms.Label()
        Me.DataAutos = New System.Windows.Forms.DataGridView()
        Me.TabEstAuto = New System.Windows.Forms.TabPage()
        Me.EliminarEstAuto = New System.Windows.Forms.Button()
        Me.GuardarEstAuto = New System.Windows.Forms.Button()
        Me.NuevoEstAuto = New System.Windows.Forms.Button()
        Me.DataEstadosAuto = New System.Windows.Forms.DataGridView()
        Me.TextDescEstAuto = New System.Windows.Forms.TextBox()
        Me.LabelDescEstAuto = New System.Windows.Forms.Label()
        Me.TextIDEstAuto = New System.Windows.Forms.TextBox()
        Me.LabelIDEstAuto = New System.Windows.Forms.Label()
        Me.TabMarcas = New System.Windows.Forms.TabPage()
        Me.EliminarMarca = New System.Windows.Forms.Button()
        Me.GuardarMarca = New System.Windows.Forms.Button()
        Me.NuevaMarca = New System.Windows.Forms.Button()
        Me.DataMarcas = New System.Windows.Forms.DataGridView()
        Me.TextNombreMarca = New System.Windows.Forms.TextBox()
        Me.LabelNombreMarca = New System.Windows.Forms.Label()
        Me.TextIDMarca = New System.Windows.Forms.TextBox()
        Me.LabelIDMarca = New System.Windows.Forms.Label()
        Me.TabModelos = New System.Windows.Forms.TabPage()
        Me.EliminarModelo = New System.Windows.Forms.Button()
        Me.GuardarModelo = New System.Windows.Forms.Button()
        Me.NuevoModelo = New System.Windows.Forms.Button()
        Me.DataModelos = New System.Windows.Forms.DataGridView()
        Me.ComboIDMarca = New System.Windows.Forms.ComboBox()
        Me.TextNombreModelo = New System.Windows.Forms.TextBox()
        Me.LabelNombreModelo = New System.Windows.Forms.Label()
        Me.TextIDModelo = New System.Windows.Forms.TextBox()
        Me.LabelModeloIDMarca = New System.Windows.Forms.Label()
        Me.LabelIDModelo = New System.Windows.Forms.Label()
        Me.TabPrecios = New System.Windows.Forms.TabPage()
        Me.EliminarPrecio = New System.Windows.Forms.Button()
        Me.GuardarPrecio = New System.Windows.Forms.Button()
        Me.NuevoPrecio = New System.Windows.Forms.Button()
        Me.DataPrecios = New System.Windows.Forms.DataGridView()
        Me.TextMontoGarantia = New System.Windows.Forms.TextBox()
        Me.TextMontoDia = New System.Windows.Forms.TextBox()
        Me.LabelPrecioModelo = New System.Windows.Forms.Label()
        Me.ComboPreciosIDModelo = New System.Windows.Forms.ComboBox()
        Me.LabelMontoGarantia = New System.Windows.Forms.Label()
        Me.LabelMontoDia = New System.Windows.Forms.Label()
        Me.TextIDPrecio = New System.Windows.Forms.TextBox()
        Me.LabelIDPrecio = New System.Windows.Forms.Label()
        Me.TabEstados = New System.Windows.Forms.TabPage()
        Me.EliminarEstado = New System.Windows.Forms.Button()
        Me.GuardarEstado = New System.Windows.Forms.Button()
        Me.NuevoEstado = New System.Windows.Forms.Button()
        Me.DataEstados = New System.Windows.Forms.DataGridView()
        Me.TextNombreEstado = New System.Windows.Forms.TextBox()
        Me.LabelNombreEstado = New System.Windows.Forms.Label()
        Me.TextIDEst = New System.Windows.Forms.TextBox()
        Me.LabelIDEst = New System.Windows.Forms.Label()
        Me.TabCiudades = New System.Windows.Forms.TabPage()
        Me.EliminarCiudad = New System.Windows.Forms.Button()
        Me.GuardarCiudad = New System.Windows.Forms.Button()
        Me.NuevaCiudad = New System.Windows.Forms.Button()
        Me.DataCiudades = New System.Windows.Forms.DataGridView()
        Me.ComboCiudadIDEstado = New System.Windows.Forms.ComboBox()
        Me.TextNombreCiudad = New System.Windows.Forms.TextBox()
        Me.TextIDCiudad = New System.Windows.Forms.TextBox()
        Me.LabelNombreciudad = New System.Windows.Forms.Label()
        Me.LabelCiudadesIDEstado = New System.Windows.Forms.Label()
        Me.LabelIDCiudad = New System.Windows.Forms.Label()
        Me.TabColonias = New System.Windows.Forms.TabPage()
        Me.EliminarColonia = New System.Windows.Forms.Button()
        Me.GuardarColonia = New System.Windows.Forms.Button()
        Me.NuevaColonia = New System.Windows.Forms.Button()
        Me.DataColonias = New System.Windows.Forms.DataGridView()
        Me.ComboColCiudades = New System.Windows.Forms.ComboBox()
        Me.ComboColEstados = New System.Windows.Forms.ComboBox()
        Me.LabelColCiudad = New System.Windows.Forms.Label()
        Me.LabelColEstado = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextIDColonia = New System.Windows.Forms.TextBox()
        Me.LabelNombreColonia = New System.Windows.Forms.Label()
        Me.LabelIDColonia = New System.Windows.Forms.Label()
        Me.TabSucursales = New System.Windows.Forms.TabPage()
        Me.EliminarSucursal = New System.Windows.Forms.Button()
        Me.GuardarSucursal = New System.Windows.Forms.Button()
        Me.NuevaSucursal = New System.Windows.Forms.Button()
        Me.LabelIDSucursal = New System.Windows.Forms.Label()
        Me.TabClientes = New System.Windows.Forms.TabPage()
        Me.DGVClientes = New System.Windows.Forms.DataGridView()
        Me.EliminarCliente = New System.Windows.Forms.Button()
        Me.GuardarCliente = New System.Windows.Forms.Button()
        Me.NuevoCliente = New System.Windows.Forms.Button()
        Me.TextApellidoMCliente = New System.Windows.Forms.TextBox()
        Me.TextApellidoPCliente = New System.Windows.Forms.TextBox()
        Me.TextNombreCliente = New System.Windows.Forms.TextBox()
        Me.LabelApellidoMCliente = New System.Windows.Forms.Label()
        Me.TextnoLicencia = New System.Windows.Forms.TextBox()
        Me.LabelApellidoPCliente = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelLicencia = New System.Windows.Forms.Label()
        Me.TabEmpleados = New System.Windows.Forms.TabPage()
        Me.TabRentas = New System.Windows.Forms.TabPage()
        Me.LabelTelCLiente = New System.Windows.Forms.Label()
        Me.LabelCorreoCliente = New System.Windows.Forms.Label()
        Me.TextTelCliente = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.LabelCalleCliente = New System.Windows.Forms.Label()
        Me.LabelColoniaCLiente = New System.Windows.Forms.Label()
        Me.TextCalleCLiente = New System.Windows.Forms.TextBox()
        Me.ComboColoniaCLiente = New System.Windows.Forms.ComboBox()
        Me.LabelNoCasaCliente = New System.Windows.Forms.Label()
        Me.LabelCiudadCliente = New System.Windows.Forms.Label()
        Me.TextNoCasaCliente = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LabelEstadoCLiente = New System.Windows.Forms.Label()
        Me.TextEstadoCliente = New System.Windows.Forms.TextBox()
        Me.TabLogin = New System.Windows.Forms.TabPage()
        Me.LabelidAdmin = New System.Windows.Forms.Label()
        Me.TextIDAdmin = New System.Windows.Forms.TextBox()
        Me.LabelContrasena = New System.Windows.Forms.Label()
        Me.TextContraseña = New System.Windows.Forms.TextBox()
        Me.DGVAdmins = New System.Windows.Forms.DataGridView()
        Me.EliminarAdmin = New System.Windows.Forms.Button()
        Me.GuardarAdmin = New System.Windows.Forms.Button()
        Me.NuevoAdmin = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TablasPestanas.SuspendLayout()
        Me.TabAutos.SuspendLayout()
        CType(Me.DataAutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabEstAuto.SuspendLayout()
        CType(Me.DataEstadosAuto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMarcas.SuspendLayout()
        CType(Me.DataMarcas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabModelos.SuspendLayout()
        CType(Me.DataModelos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPrecios.SuspendLayout()
        CType(Me.DataPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabEstados.SuspendLayout()
        CType(Me.DataEstados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCiudades.SuspendLayout()
        CType(Me.DataCiudades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabColonias.SuspendLayout()
        CType(Me.DataColonias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSucursales.SuspendLayout()
        Me.TabClientes.SuspendLayout()
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabLogin.SuspendLayout()
        CType(Me.DGVAdmins, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 623)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(886, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'TablasPestanas
        '
        Me.TablasPestanas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TablasPestanas.Controls.Add(Me.TabAutos)
        Me.TablasPestanas.Controls.Add(Me.TabEstAuto)
        Me.TablasPestanas.Controls.Add(Me.TabMarcas)
        Me.TablasPestanas.Controls.Add(Me.TabModelos)
        Me.TablasPestanas.Controls.Add(Me.TabPrecios)
        Me.TablasPestanas.Controls.Add(Me.TabEstados)
        Me.TablasPestanas.Controls.Add(Me.TabCiudades)
        Me.TablasPestanas.Controls.Add(Me.TabColonias)
        Me.TablasPestanas.Controls.Add(Me.TabSucursales)
        Me.TablasPestanas.Controls.Add(Me.TabClientes)
        Me.TablasPestanas.Controls.Add(Me.TabEmpleados)
        Me.TablasPestanas.Controls.Add(Me.TabRentas)
        Me.TablasPestanas.Controls.Add(Me.TabLogin)
        Me.TablasPestanas.Location = New System.Drawing.Point(12, 12)
        Me.TablasPestanas.Name = "TablasPestanas"
        Me.TablasPestanas.SelectedIndex = 0
        Me.TablasPestanas.Size = New System.Drawing.Size(678, 412)
        Me.TablasPestanas.TabIndex = 2
        '
        'TabAutos
        '
        Me.TabAutos.Controls.Add(Me.ButtonEliminarAuto)
        Me.TabAutos.Controls.Add(Me.ButtonGuardarAuto)
        Me.TabAutos.Controls.Add(Me.ButtonNuevoAuto)
        Me.TabAutos.Controls.Add(Me.CheckDisponible)
        Me.TabAutos.Controls.Add(Me.ComboEstAuto)
        Me.TabAutos.Controls.Add(Me.ComboMarca)
        Me.TabAutos.Controls.Add(Me.TextCapacidad)
        Me.TabAutos.Controls.Add(Me.LabelCapacidad)
        Me.TabAutos.Controls.Add(Me.TextPlaca)
        Me.TabAutos.Controls.Add(Me.LabelAutoEstAuto)
        Me.TabAutos.Controls.Add(Me.LabelAutoMarca)
        Me.TabAutos.Controls.Add(Me.LabelPlaca)
        Me.TabAutos.Controls.Add(Me.DataAutos)
        Me.TabAutos.Location = New System.Drawing.Point(4, 22)
        Me.TabAutos.Name = "TabAutos"
        Me.TabAutos.Size = New System.Drawing.Size(670, 386)
        Me.TabAutos.TabIndex = 11
        Me.TabAutos.Text = "Autos"
        Me.TabAutos.UseVisualStyleBackColor = True
        '
        'ButtonEliminarAuto
        '
        Me.ButtonEliminarAuto.Location = New System.Drawing.Point(592, 360)
        Me.ButtonEliminarAuto.Name = "ButtonEliminarAuto"
        Me.ButtonEliminarAuto.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEliminarAuto.TabIndex = 8
        Me.ButtonEliminarAuto.Text = "Eliminar"
        Me.ButtonEliminarAuto.UseVisualStyleBackColor = True
        '
        'ButtonGuardarAuto
        '
        Me.ButtonGuardarAuto.Location = New System.Drawing.Point(511, 360)
        Me.ButtonGuardarAuto.Name = "ButtonGuardarAuto"
        Me.ButtonGuardarAuto.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGuardarAuto.TabIndex = 8
        Me.ButtonGuardarAuto.Text = "Guardar"
        Me.ButtonGuardarAuto.UseVisualStyleBackColor = True
        '
        'ButtonNuevoAuto
        '
        Me.ButtonNuevoAuto.Location = New System.Drawing.Point(430, 360)
        Me.ButtonNuevoAuto.Name = "ButtonNuevoAuto"
        Me.ButtonNuevoAuto.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNuevoAuto.TabIndex = 8
        Me.ButtonNuevoAuto.Text = "Nuevo"
        Me.ButtonNuevoAuto.UseVisualStyleBackColor = True
        '
        'CheckDisponible
        '
        Me.CheckDisponible.AutoSize = True
        Me.CheckDisponible.Location = New System.Drawing.Point(378, 36)
        Me.CheckDisponible.Name = "CheckDisponible"
        Me.CheckDisponible.Size = New System.Drawing.Size(75, 17)
        Me.CheckDisponible.TabIndex = 7
        Me.CheckDisponible.Text = "Disponible"
        Me.CheckDisponible.UseVisualStyleBackColor = True
        '
        'ComboEstAuto
        '
        Me.ComboEstAuto.FormattingEnabled = True
        Me.ComboEstAuto.Location = New System.Drawing.Point(186, 84)
        Me.ComboEstAuto.Name = "ComboEstAuto"
        Me.ComboEstAuto.Size = New System.Drawing.Size(121, 21)
        Me.ComboEstAuto.TabIndex = 6
        '
        'ComboMarca
        '
        Me.ComboMarca.FormattingEnabled = True
        Me.ComboMarca.Location = New System.Drawing.Point(186, 36)
        Me.ComboMarca.Name = "ComboMarca"
        Me.ComboMarca.Size = New System.Drawing.Size(121, 21)
        Me.ComboMarca.TabIndex = 6
        '
        'TextCapacidad
        '
        Me.TextCapacidad.Location = New System.Drawing.Point(33, 84)
        Me.TextCapacidad.Name = "TextCapacidad"
        Me.TextCapacidad.Size = New System.Drawing.Size(100, 20)
        Me.TextCapacidad.TabIndex = 5
        '
        'LabelCapacidad
        '
        Me.LabelCapacidad.AutoSize = True
        Me.LabelCapacidad.Location = New System.Drawing.Point(30, 68)
        Me.LabelCapacidad.Name = "LabelCapacidad"
        Me.LabelCapacidad.Size = New System.Drawing.Size(58, 13)
        Me.LabelCapacidad.TabIndex = 4
        Me.LabelCapacidad.Text = "Capacidad"
        '
        'TextPlaca
        '
        Me.TextPlaca.Location = New System.Drawing.Point(33, 36)
        Me.TextPlaca.Name = "TextPlaca"
        Me.TextPlaca.Size = New System.Drawing.Size(100, 20)
        Me.TextPlaca.TabIndex = 5
        '
        'LabelAutoEstAuto
        '
        Me.LabelAutoEstAuto.AutoSize = True
        Me.LabelAutoEstAuto.Location = New System.Drawing.Point(180, 68)
        Me.LabelAutoEstAuto.Name = "LabelAutoEstAuto"
        Me.LabelAutoEstAuto.Size = New System.Drawing.Size(40, 13)
        Me.LabelAutoEstAuto.TabIndex = 4
        Me.LabelAutoEstAuto.Text = "Estado"
        '
        'LabelAutoMarca
        '
        Me.LabelAutoMarca.AutoSize = True
        Me.LabelAutoMarca.Location = New System.Drawing.Point(183, 20)
        Me.LabelAutoMarca.Name = "LabelAutoMarca"
        Me.LabelAutoMarca.Size = New System.Drawing.Size(37, 13)
        Me.LabelAutoMarca.TabIndex = 4
        Me.LabelAutoMarca.Text = "Marca"
        '
        'LabelPlaca
        '
        Me.LabelPlaca.AutoSize = True
        Me.LabelPlaca.Location = New System.Drawing.Point(30, 20)
        Me.LabelPlaca.Name = "LabelPlaca"
        Me.LabelPlaca.Size = New System.Drawing.Size(34, 13)
        Me.LabelPlaca.TabIndex = 4
        Me.LabelPlaca.Text = "Placa"
        '
        'DataAutos
        '
        Me.DataAutos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataAutos.Location = New System.Drawing.Point(3, 111)
        Me.DataAutos.Name = "DataAutos"
        Me.DataAutos.Size = New System.Drawing.Size(664, 243)
        Me.DataAutos.TabIndex = 3
        '
        'TabEstAuto
        '
        Me.TabEstAuto.Controls.Add(Me.EliminarEstAuto)
        Me.TabEstAuto.Controls.Add(Me.GuardarEstAuto)
        Me.TabEstAuto.Controls.Add(Me.NuevoEstAuto)
        Me.TabEstAuto.Controls.Add(Me.DataEstadosAuto)
        Me.TabEstAuto.Controls.Add(Me.TextDescEstAuto)
        Me.TabEstAuto.Controls.Add(Me.LabelDescEstAuto)
        Me.TabEstAuto.Controls.Add(Me.TextIDEstAuto)
        Me.TabEstAuto.Controls.Add(Me.LabelIDEstAuto)
        Me.TabEstAuto.Location = New System.Drawing.Point(4, 22)
        Me.TabEstAuto.Name = "TabEstAuto"
        Me.TabEstAuto.Size = New System.Drawing.Size(670, 386)
        Me.TabEstAuto.TabIndex = 2
        Me.TabEstAuto.Text = "Estados de auto"
        Me.TabEstAuto.UseVisualStyleBackColor = True
        '
        'EliminarEstAuto
        '
        Me.EliminarEstAuto.Location = New System.Drawing.Point(592, 360)
        Me.EliminarEstAuto.Name = "EliminarEstAuto"
        Me.EliminarEstAuto.Size = New System.Drawing.Size(75, 23)
        Me.EliminarEstAuto.TabIndex = 11
        Me.EliminarEstAuto.Text = "Eliminar"
        Me.EliminarEstAuto.UseVisualStyleBackColor = True
        '
        'GuardarEstAuto
        '
        Me.GuardarEstAuto.Location = New System.Drawing.Point(511, 360)
        Me.GuardarEstAuto.Name = "GuardarEstAuto"
        Me.GuardarEstAuto.Size = New System.Drawing.Size(75, 23)
        Me.GuardarEstAuto.TabIndex = 12
        Me.GuardarEstAuto.Text = "Guardar"
        Me.GuardarEstAuto.UseVisualStyleBackColor = True
        '
        'NuevoEstAuto
        '
        Me.NuevoEstAuto.Location = New System.Drawing.Point(430, 360)
        Me.NuevoEstAuto.Name = "NuevoEstAuto"
        Me.NuevoEstAuto.Size = New System.Drawing.Size(75, 23)
        Me.NuevoEstAuto.TabIndex = 13
        Me.NuevoEstAuto.Text = "Nuevo"
        Me.NuevoEstAuto.UseVisualStyleBackColor = True
        '
        'DataEstadosAuto
        '
        Me.DataEstadosAuto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataEstadosAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataEstadosAuto.Location = New System.Drawing.Point(3, 110)
        Me.DataEstadosAuto.Name = "DataEstadosAuto"
        Me.DataEstadosAuto.Size = New System.Drawing.Size(664, 244)
        Me.DataEstadosAuto.TabIndex = 10
        '
        'TextDescEstAuto
        '
        Me.TextDescEstAuto.Location = New System.Drawing.Point(30, 84)
        Me.TextDescEstAuto.Name = "TextDescEstAuto"
        Me.TextDescEstAuto.Size = New System.Drawing.Size(100, 20)
        Me.TextDescEstAuto.TabIndex = 8
        '
        'LabelDescEstAuto
        '
        Me.LabelDescEstAuto.AutoSize = True
        Me.LabelDescEstAuto.Location = New System.Drawing.Point(30, 68)
        Me.LabelDescEstAuto.Name = "LabelDescEstAuto"
        Me.LabelDescEstAuto.Size = New System.Drawing.Size(63, 13)
        Me.LabelDescEstAuto.TabIndex = 6
        Me.LabelDescEstAuto.Text = "Descripción"
        '
        'TextIDEstAuto
        '
        Me.TextIDEstAuto.Location = New System.Drawing.Point(30, 36)
        Me.TextIDEstAuto.Name = "TextIDEstAuto"
        Me.TextIDEstAuto.Size = New System.Drawing.Size(100, 20)
        Me.TextIDEstAuto.TabIndex = 9
        '
        'LabelIDEstAuto
        '
        Me.LabelIDEstAuto.AutoSize = True
        Me.LabelIDEstAuto.Location = New System.Drawing.Point(30, 20)
        Me.LabelIDEstAuto.Name = "LabelIDEstAuto"
        Me.LabelIDEstAuto.Size = New System.Drawing.Size(54, 13)
        Me.LabelIDEstAuto.TabIndex = 7
        Me.LabelIDEstAuto.Text = "ID Estado"
        '
        'TabMarcas
        '
        Me.TabMarcas.Controls.Add(Me.EliminarMarca)
        Me.TabMarcas.Controls.Add(Me.GuardarMarca)
        Me.TabMarcas.Controls.Add(Me.NuevaMarca)
        Me.TabMarcas.Controls.Add(Me.DataMarcas)
        Me.TabMarcas.Controls.Add(Me.TextNombreMarca)
        Me.TabMarcas.Controls.Add(Me.LabelNombreMarca)
        Me.TabMarcas.Controls.Add(Me.TextIDMarca)
        Me.TabMarcas.Controls.Add(Me.LabelIDMarca)
        Me.TabMarcas.Location = New System.Drawing.Point(4, 22)
        Me.TabMarcas.Name = "TabMarcas"
        Me.TabMarcas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMarcas.Size = New System.Drawing.Size(670, 386)
        Me.TabMarcas.TabIndex = 1
        Me.TabMarcas.Text = "Marcas"
        Me.TabMarcas.UseVisualStyleBackColor = True
        '
        'EliminarMarca
        '
        Me.EliminarMarca.Location = New System.Drawing.Point(592, 360)
        Me.EliminarMarca.Name = "EliminarMarca"
        Me.EliminarMarca.Size = New System.Drawing.Size(75, 23)
        Me.EliminarMarca.TabIndex = 9
        Me.EliminarMarca.Text = "Eliminar"
        Me.EliminarMarca.UseVisualStyleBackColor = True
        '
        'GuardarMarca
        '
        Me.GuardarMarca.Location = New System.Drawing.Point(511, 360)
        Me.GuardarMarca.Name = "GuardarMarca"
        Me.GuardarMarca.Size = New System.Drawing.Size(75, 23)
        Me.GuardarMarca.TabIndex = 10
        Me.GuardarMarca.Text = "Guardar"
        Me.GuardarMarca.UseVisualStyleBackColor = True
        '
        'NuevaMarca
        '
        Me.NuevaMarca.Location = New System.Drawing.Point(430, 360)
        Me.NuevaMarca.Name = "NuevaMarca"
        Me.NuevaMarca.Size = New System.Drawing.Size(75, 23)
        Me.NuevaMarca.TabIndex = 11
        Me.NuevaMarca.Text = "Nuevo"
        Me.NuevaMarca.UseVisualStyleBackColor = True
        '
        'DataMarcas
        '
        Me.DataMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataMarcas.Location = New System.Drawing.Point(3, 110)
        Me.DataMarcas.Name = "DataMarcas"
        Me.DataMarcas.Size = New System.Drawing.Size(664, 244)
        Me.DataMarcas.TabIndex = 6
        '
        'TextNombreMarca
        '
        Me.TextNombreMarca.Location = New System.Drawing.Point(30, 84)
        Me.TextNombreMarca.Name = "TextNombreMarca"
        Me.TextNombreMarca.Size = New System.Drawing.Size(100, 20)
        Me.TextNombreMarca.TabIndex = 4
        '
        'LabelNombreMarca
        '
        Me.LabelNombreMarca.AutoSize = True
        Me.LabelNombreMarca.Location = New System.Drawing.Point(30, 68)
        Me.LabelNombreMarca.Name = "LabelNombreMarca"
        Me.LabelNombreMarca.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombreMarca.TabIndex = 2
        Me.LabelNombreMarca.Text = "Nombre"
        '
        'TextIDMarca
        '
        Me.TextIDMarca.Location = New System.Drawing.Point(30, 36)
        Me.TextIDMarca.Name = "TextIDMarca"
        Me.TextIDMarca.Size = New System.Drawing.Size(100, 20)
        Me.TextIDMarca.TabIndex = 5
        '
        'LabelIDMarca
        '
        Me.LabelIDMarca.AutoSize = True
        Me.LabelIDMarca.Location = New System.Drawing.Point(30, 20)
        Me.LabelIDMarca.Name = "LabelIDMarca"
        Me.LabelIDMarca.Size = New System.Drawing.Size(51, 13)
        Me.LabelIDMarca.TabIndex = 3
        Me.LabelIDMarca.Text = "ID Marca"
        '
        'TabModelos
        '
        Me.TabModelos.Controls.Add(Me.EliminarModelo)
        Me.TabModelos.Controls.Add(Me.GuardarModelo)
        Me.TabModelos.Controls.Add(Me.NuevoModelo)
        Me.TabModelos.Controls.Add(Me.DataModelos)
        Me.TabModelos.Controls.Add(Me.ComboIDMarca)
        Me.TabModelos.Controls.Add(Me.TextNombreModelo)
        Me.TabModelos.Controls.Add(Me.LabelNombreModelo)
        Me.TabModelos.Controls.Add(Me.TextIDModelo)
        Me.TabModelos.Controls.Add(Me.LabelModeloIDMarca)
        Me.TabModelos.Controls.Add(Me.LabelIDModelo)
        Me.TabModelos.Location = New System.Drawing.Point(4, 22)
        Me.TabModelos.Name = "TabModelos"
        Me.TabModelos.Size = New System.Drawing.Size(670, 386)
        Me.TabModelos.TabIndex = 3
        Me.TabModelos.Text = "Modelos"
        Me.TabModelos.UseVisualStyleBackColor = True
        '
        'EliminarModelo
        '
        Me.EliminarModelo.Location = New System.Drawing.Point(592, 360)
        Me.EliminarModelo.Name = "EliminarModelo"
        Me.EliminarModelo.Size = New System.Drawing.Size(75, 23)
        Me.EliminarModelo.TabIndex = 9
        Me.EliminarModelo.Text = "Eliminar"
        Me.EliminarModelo.UseVisualStyleBackColor = True
        '
        'GuardarModelo
        '
        Me.GuardarModelo.Location = New System.Drawing.Point(511, 360)
        Me.GuardarModelo.Name = "GuardarModelo"
        Me.GuardarModelo.Size = New System.Drawing.Size(75, 23)
        Me.GuardarModelo.TabIndex = 10
        Me.GuardarModelo.Text = "Guardar"
        Me.GuardarModelo.UseVisualStyleBackColor = True
        '
        'NuevoModelo
        '
        Me.NuevoModelo.Location = New System.Drawing.Point(430, 360)
        Me.NuevoModelo.Name = "NuevoModelo"
        Me.NuevoModelo.Size = New System.Drawing.Size(75, 23)
        Me.NuevoModelo.TabIndex = 11
        Me.NuevoModelo.Text = "Nuevo"
        Me.NuevoModelo.UseVisualStyleBackColor = True
        '
        'DataModelos
        '
        Me.DataModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataModelos.Location = New System.Drawing.Point(3, 110)
        Me.DataModelos.Name = "DataModelos"
        Me.DataModelos.Size = New System.Drawing.Size(664, 244)
        Me.DataModelos.TabIndex = 3
        '
        'ComboIDMarca
        '
        Me.ComboIDMarca.FormattingEnabled = True
        Me.ComboIDMarca.Location = New System.Drawing.Point(183, 36)
        Me.ComboIDMarca.Name = "ComboIDMarca"
        Me.ComboIDMarca.Size = New System.Drawing.Size(121, 21)
        Me.ComboIDMarca.TabIndex = 2
        '
        'TextNombreModelo
        '
        Me.TextNombreModelo.Location = New System.Drawing.Point(30, 84)
        Me.TextNombreModelo.Name = "TextNombreModelo"
        Me.TextNombreModelo.Size = New System.Drawing.Size(100, 20)
        Me.TextNombreModelo.TabIndex = 1
        '
        'LabelNombreModelo
        '
        Me.LabelNombreModelo.AutoSize = True
        Me.LabelNombreModelo.Location = New System.Drawing.Point(30, 68)
        Me.LabelNombreModelo.Name = "LabelNombreModelo"
        Me.LabelNombreModelo.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombreModelo.TabIndex = 0
        Me.LabelNombreModelo.Text = "Nombre"
        '
        'TextIDModelo
        '
        Me.TextIDModelo.Location = New System.Drawing.Point(30, 36)
        Me.TextIDModelo.Name = "TextIDModelo"
        Me.TextIDModelo.Size = New System.Drawing.Size(100, 20)
        Me.TextIDModelo.TabIndex = 1
        '
        'LabelModeloIDMarca
        '
        Me.LabelModeloIDMarca.AutoSize = True
        Me.LabelModeloIDMarca.Location = New System.Drawing.Point(183, 20)
        Me.LabelModeloIDMarca.Name = "LabelModeloIDMarca"
        Me.LabelModeloIDMarca.Size = New System.Drawing.Size(51, 13)
        Me.LabelModeloIDMarca.TabIndex = 0
        Me.LabelModeloIDMarca.Text = "ID Marca"
        '
        'LabelIDModelo
        '
        Me.LabelIDModelo.AutoSize = True
        Me.LabelIDModelo.Location = New System.Drawing.Point(30, 20)
        Me.LabelIDModelo.Name = "LabelIDModelo"
        Me.LabelIDModelo.Size = New System.Drawing.Size(56, 13)
        Me.LabelIDModelo.TabIndex = 0
        Me.LabelIDModelo.Text = "ID Modelo"
        '
        'TabPrecios
        '
        Me.TabPrecios.Controls.Add(Me.EliminarPrecio)
        Me.TabPrecios.Controls.Add(Me.GuardarPrecio)
        Me.TabPrecios.Controls.Add(Me.NuevoPrecio)
        Me.TabPrecios.Controls.Add(Me.DataPrecios)
        Me.TabPrecios.Controls.Add(Me.TextMontoGarantia)
        Me.TabPrecios.Controls.Add(Me.TextMontoDia)
        Me.TabPrecios.Controls.Add(Me.LabelPrecioModelo)
        Me.TabPrecios.Controls.Add(Me.ComboPreciosIDModelo)
        Me.TabPrecios.Controls.Add(Me.LabelMontoGarantia)
        Me.TabPrecios.Controls.Add(Me.LabelMontoDia)
        Me.TabPrecios.Controls.Add(Me.TextIDPrecio)
        Me.TabPrecios.Controls.Add(Me.LabelIDPrecio)
        Me.TabPrecios.Location = New System.Drawing.Point(4, 22)
        Me.TabPrecios.Name = "TabPrecios"
        Me.TabPrecios.Size = New System.Drawing.Size(670, 386)
        Me.TabPrecios.TabIndex = 5
        Me.TabPrecios.Text = "Precios"
        Me.TabPrecios.UseVisualStyleBackColor = True
        '
        'EliminarPrecio
        '
        Me.EliminarPrecio.Location = New System.Drawing.Point(592, 360)
        Me.EliminarPrecio.Name = "EliminarPrecio"
        Me.EliminarPrecio.Size = New System.Drawing.Size(75, 23)
        Me.EliminarPrecio.TabIndex = 9
        Me.EliminarPrecio.Text = "Eliminar"
        Me.EliminarPrecio.UseVisualStyleBackColor = True
        '
        'GuardarPrecio
        '
        Me.GuardarPrecio.Location = New System.Drawing.Point(511, 360)
        Me.GuardarPrecio.Name = "GuardarPrecio"
        Me.GuardarPrecio.Size = New System.Drawing.Size(75, 23)
        Me.GuardarPrecio.TabIndex = 10
        Me.GuardarPrecio.Text = "Guardar"
        Me.GuardarPrecio.UseVisualStyleBackColor = True
        '
        'NuevoPrecio
        '
        Me.NuevoPrecio.Location = New System.Drawing.Point(430, 360)
        Me.NuevoPrecio.Name = "NuevoPrecio"
        Me.NuevoPrecio.Size = New System.Drawing.Size(75, 23)
        Me.NuevoPrecio.TabIndex = 11
        Me.NuevoPrecio.Text = "Nuevo"
        Me.NuevoPrecio.UseVisualStyleBackColor = True
        '
        'DataPrecios
        '
        Me.DataPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataPrecios.Location = New System.Drawing.Point(3, 111)
        Me.DataPrecios.Name = "DataPrecios"
        Me.DataPrecios.Size = New System.Drawing.Size(664, 243)
        Me.DataPrecios.TabIndex = 6
        '
        'TextMontoGarantia
        '
        Me.TextMontoGarantia.Location = New System.Drawing.Point(165, 85)
        Me.TextMontoGarantia.Name = "TextMontoGarantia"
        Me.TextMontoGarantia.Size = New System.Drawing.Size(124, 20)
        Me.TextMontoGarantia.TabIndex = 5
        '
        'TextMontoDia
        '
        Me.TextMontoDia.Location = New System.Drawing.Point(30, 85)
        Me.TextMontoDia.Name = "TextMontoDia"
        Me.TextMontoDia.Size = New System.Drawing.Size(100, 20)
        Me.TextMontoDia.TabIndex = 5
        '
        'LabelPrecioModelo
        '
        Me.LabelPrecioModelo.AutoSize = True
        Me.LabelPrecioModelo.Location = New System.Drawing.Point(165, 20)
        Me.LabelPrecioModelo.Name = "LabelPrecioModelo"
        Me.LabelPrecioModelo.Size = New System.Drawing.Size(42, 13)
        Me.LabelPrecioModelo.TabIndex = 4
        Me.LabelPrecioModelo.Text = "Modelo"
        '
        'ComboPreciosIDModelo
        '
        Me.ComboPreciosIDModelo.FormattingEnabled = True
        Me.ComboPreciosIDModelo.Location = New System.Drawing.Point(168, 36)
        Me.ComboPreciosIDModelo.Name = "ComboPreciosIDModelo"
        Me.ComboPreciosIDModelo.Size = New System.Drawing.Size(121, 21)
        Me.ComboPreciosIDModelo.TabIndex = 3
        '
        'LabelMontoGarantia
        '
        Me.LabelMontoGarantia.AutoSize = True
        Me.LabelMontoGarantia.Location = New System.Drawing.Point(165, 68)
        Me.LabelMontoGarantia.Name = "LabelMontoGarantia"
        Me.LabelMontoGarantia.Size = New System.Drawing.Size(95, 13)
        Me.LabelMontoGarantia.TabIndex = 2
        Me.LabelMontoGarantia.Text = "Monto de garantía"
        '
        'LabelMontoDia
        '
        Me.LabelMontoDia.AutoSize = True
        Me.LabelMontoDia.Location = New System.Drawing.Point(30, 68)
        Me.LabelMontoDia.Name = "LabelMontoDia"
        Me.LabelMontoDia.Size = New System.Drawing.Size(71, 13)
        Me.LabelMontoDia.TabIndex = 2
        Me.LabelMontoDia.Text = "Monto de día"
        '
        'TextIDPrecio
        '
        Me.TextIDPrecio.Location = New System.Drawing.Point(30, 36)
        Me.TextIDPrecio.Name = "TextIDPrecio"
        Me.TextIDPrecio.Size = New System.Drawing.Size(100, 20)
        Me.TextIDPrecio.TabIndex = 1
        '
        'LabelIDPrecio
        '
        Me.LabelIDPrecio.AutoSize = True
        Me.LabelIDPrecio.Location = New System.Drawing.Point(30, 20)
        Me.LabelIDPrecio.Name = "LabelIDPrecio"
        Me.LabelIDPrecio.Size = New System.Drawing.Size(79, 13)
        Me.LabelIDPrecio.TabIndex = 0
        Me.LabelIDPrecio.Text = "ID Precio diario"
        '
        'TabEstados
        '
        Me.TabEstados.Controls.Add(Me.EliminarEstado)
        Me.TabEstados.Controls.Add(Me.GuardarEstado)
        Me.TabEstados.Controls.Add(Me.NuevoEstado)
        Me.TabEstados.Controls.Add(Me.DataEstados)
        Me.TabEstados.Controls.Add(Me.TextNombreEstado)
        Me.TabEstados.Controls.Add(Me.LabelNombreEstado)
        Me.TabEstados.Controls.Add(Me.TextIDEst)
        Me.TabEstados.Controls.Add(Me.LabelIDEst)
        Me.TabEstados.Location = New System.Drawing.Point(4, 22)
        Me.TabEstados.Name = "TabEstados"
        Me.TabEstados.Padding = New System.Windows.Forms.Padding(3)
        Me.TabEstados.Size = New System.Drawing.Size(670, 386)
        Me.TabEstados.TabIndex = 0
        Me.TabEstados.Text = "Estados"
        Me.TabEstados.UseVisualStyleBackColor = True
        '
        'EliminarEstado
        '
        Me.EliminarEstado.Location = New System.Drawing.Point(592, 360)
        Me.EliminarEstado.Name = "EliminarEstado"
        Me.EliminarEstado.Size = New System.Drawing.Size(75, 23)
        Me.EliminarEstado.TabIndex = 9
        Me.EliminarEstado.Text = "Eliminar"
        Me.EliminarEstado.UseVisualStyleBackColor = True
        '
        'GuardarEstado
        '
        Me.GuardarEstado.Location = New System.Drawing.Point(511, 360)
        Me.GuardarEstado.Name = "GuardarEstado"
        Me.GuardarEstado.Size = New System.Drawing.Size(75, 23)
        Me.GuardarEstado.TabIndex = 10
        Me.GuardarEstado.Text = "Guardar"
        Me.GuardarEstado.UseVisualStyleBackColor = True
        '
        'NuevoEstado
        '
        Me.NuevoEstado.Location = New System.Drawing.Point(430, 360)
        Me.NuevoEstado.Name = "NuevoEstado"
        Me.NuevoEstado.Size = New System.Drawing.Size(75, 23)
        Me.NuevoEstado.TabIndex = 11
        Me.NuevoEstado.Text = "Nuevo"
        Me.NuevoEstado.UseVisualStyleBackColor = True
        '
        'DataEstados
        '
        Me.DataEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataEstados.Location = New System.Drawing.Point(3, 110)
        Me.DataEstados.Name = "DataEstados"
        Me.DataEstados.Size = New System.Drawing.Size(664, 244)
        Me.DataEstados.TabIndex = 2
        '
        'TextNombreEstado
        '
        Me.TextNombreEstado.Location = New System.Drawing.Point(30, 84)
        Me.TextNombreEstado.Name = "TextNombreEstado"
        Me.TextNombreEstado.Size = New System.Drawing.Size(100, 20)
        Me.TextNombreEstado.TabIndex = 1
        '
        'LabelNombreEstado
        '
        Me.LabelNombreEstado.AutoSize = True
        Me.LabelNombreEstado.Location = New System.Drawing.Point(30, 68)
        Me.LabelNombreEstado.Name = "LabelNombreEstado"
        Me.LabelNombreEstado.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombreEstado.TabIndex = 0
        Me.LabelNombreEstado.Text = "Nombre"
        '
        'TextIDEst
        '
        Me.TextIDEst.Location = New System.Drawing.Point(30, 36)
        Me.TextIDEst.Name = "TextIDEst"
        Me.TextIDEst.Size = New System.Drawing.Size(100, 20)
        Me.TextIDEst.TabIndex = 1
        '
        'LabelIDEst
        '
        Me.LabelIDEst.AutoSize = True
        Me.LabelIDEst.Location = New System.Drawing.Point(30, 20)
        Me.LabelIDEst.Name = "LabelIDEst"
        Me.LabelIDEst.Size = New System.Drawing.Size(54, 13)
        Me.LabelIDEst.TabIndex = 0
        Me.LabelIDEst.Text = "ID Estado"
        '
        'TabCiudades
        '
        Me.TabCiudades.Controls.Add(Me.EliminarCiudad)
        Me.TabCiudades.Controls.Add(Me.GuardarCiudad)
        Me.TabCiudades.Controls.Add(Me.NuevaCiudad)
        Me.TabCiudades.Controls.Add(Me.DataCiudades)
        Me.TabCiudades.Controls.Add(Me.ComboCiudadIDEstado)
        Me.TabCiudades.Controls.Add(Me.TextNombreCiudad)
        Me.TabCiudades.Controls.Add(Me.TextIDCiudad)
        Me.TabCiudades.Controls.Add(Me.LabelNombreciudad)
        Me.TabCiudades.Controls.Add(Me.LabelCiudadesIDEstado)
        Me.TabCiudades.Controls.Add(Me.LabelIDCiudad)
        Me.TabCiudades.Location = New System.Drawing.Point(4, 22)
        Me.TabCiudades.Name = "TabCiudades"
        Me.TabCiudades.Size = New System.Drawing.Size(670, 386)
        Me.TabCiudades.TabIndex = 4
        Me.TabCiudades.Text = "Ciudades"
        Me.TabCiudades.UseVisualStyleBackColor = True
        '
        'EliminarCiudad
        '
        Me.EliminarCiudad.Location = New System.Drawing.Point(592, 360)
        Me.EliminarCiudad.Name = "EliminarCiudad"
        Me.EliminarCiudad.Size = New System.Drawing.Size(75, 23)
        Me.EliminarCiudad.TabIndex = 9
        Me.EliminarCiudad.Text = "Eliminar"
        Me.EliminarCiudad.UseVisualStyleBackColor = True
        '
        'GuardarCiudad
        '
        Me.GuardarCiudad.Location = New System.Drawing.Point(511, 360)
        Me.GuardarCiudad.Name = "GuardarCiudad"
        Me.GuardarCiudad.Size = New System.Drawing.Size(75, 23)
        Me.GuardarCiudad.TabIndex = 10
        Me.GuardarCiudad.Text = "Guardar"
        Me.GuardarCiudad.UseVisualStyleBackColor = True
        '
        'NuevaCiudad
        '
        Me.NuevaCiudad.Location = New System.Drawing.Point(430, 360)
        Me.NuevaCiudad.Name = "NuevaCiudad"
        Me.NuevaCiudad.Size = New System.Drawing.Size(75, 23)
        Me.NuevaCiudad.TabIndex = 11
        Me.NuevaCiudad.Text = "Nuevo"
        Me.NuevaCiudad.UseVisualStyleBackColor = True
        '
        'DataCiudades
        '
        Me.DataCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataCiudades.Location = New System.Drawing.Point(3, 110)
        Me.DataCiudades.Name = "DataCiudades"
        Me.DataCiudades.Size = New System.Drawing.Size(664, 244)
        Me.DataCiudades.TabIndex = 3
        '
        'ComboCiudadIDEstado
        '
        Me.ComboCiudadIDEstado.FormattingEnabled = True
        Me.ComboCiudadIDEstado.Location = New System.Drawing.Point(183, 35)
        Me.ComboCiudadIDEstado.Name = "ComboCiudadIDEstado"
        Me.ComboCiudadIDEstado.Size = New System.Drawing.Size(121, 21)
        Me.ComboCiudadIDEstado.TabIndex = 2
        '
        'TextNombreCiudad
        '
        Me.TextNombreCiudad.Location = New System.Drawing.Point(30, 84)
        Me.TextNombreCiudad.Name = "TextNombreCiudad"
        Me.TextNombreCiudad.Size = New System.Drawing.Size(100, 20)
        Me.TextNombreCiudad.TabIndex = 1
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
        'LabelCiudadesIDEstado
        '
        Me.LabelCiudadesIDEstado.AutoSize = True
        Me.LabelCiudadesIDEstado.Location = New System.Drawing.Point(183, 20)
        Me.LabelCiudadesIDEstado.Name = "LabelCiudadesIDEstado"
        Me.LabelCiudadesIDEstado.Size = New System.Drawing.Size(54, 13)
        Me.LabelCiudadesIDEstado.TabIndex = 0
        Me.LabelCiudadesIDEstado.Text = "ID Estado"
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
        'TabColonias
        '
        Me.TabColonias.Controls.Add(Me.EliminarColonia)
        Me.TabColonias.Controls.Add(Me.GuardarColonia)
        Me.TabColonias.Controls.Add(Me.NuevaColonia)
        Me.TabColonias.Controls.Add(Me.DataColonias)
        Me.TabColonias.Controls.Add(Me.ComboColCiudades)
        Me.TabColonias.Controls.Add(Me.ComboColEstados)
        Me.TabColonias.Controls.Add(Me.LabelColCiudad)
        Me.TabColonias.Controls.Add(Me.LabelColEstado)
        Me.TabColonias.Controls.Add(Me.TextBox1)
        Me.TabColonias.Controls.Add(Me.TextIDColonia)
        Me.TabColonias.Controls.Add(Me.LabelNombreColonia)
        Me.TabColonias.Controls.Add(Me.LabelIDColonia)
        Me.TabColonias.Location = New System.Drawing.Point(4, 22)
        Me.TabColonias.Name = "TabColonias"
        Me.TabColonias.Size = New System.Drawing.Size(670, 386)
        Me.TabColonias.TabIndex = 6
        Me.TabColonias.Text = "Colonias"
        Me.TabColonias.UseVisualStyleBackColor = True
        '
        'EliminarColonia
        '
        Me.EliminarColonia.Location = New System.Drawing.Point(592, 360)
        Me.EliminarColonia.Name = "EliminarColonia"
        Me.EliminarColonia.Size = New System.Drawing.Size(75, 23)
        Me.EliminarColonia.TabIndex = 9
        Me.EliminarColonia.Text = "Eliminar"
        Me.EliminarColonia.UseVisualStyleBackColor = True
        '
        'GuardarColonia
        '
        Me.GuardarColonia.Location = New System.Drawing.Point(511, 360)
        Me.GuardarColonia.Name = "GuardarColonia"
        Me.GuardarColonia.Size = New System.Drawing.Size(75, 23)
        Me.GuardarColonia.TabIndex = 10
        Me.GuardarColonia.Text = "Guardar"
        Me.GuardarColonia.UseVisualStyleBackColor = True
        '
        'NuevaColonia
        '
        Me.NuevaColonia.Location = New System.Drawing.Point(430, 360)
        Me.NuevaColonia.Name = "NuevaColonia"
        Me.NuevaColonia.Size = New System.Drawing.Size(75, 23)
        Me.NuevaColonia.TabIndex = 11
        Me.NuevaColonia.Text = "Nuevo"
        Me.NuevaColonia.UseVisualStyleBackColor = True
        '
        'DataColonias
        '
        Me.DataColonias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataColonias.Location = New System.Drawing.Point(3, 110)
        Me.DataColonias.Name = "DataColonias"
        Me.DataColonias.Size = New System.Drawing.Size(664, 244)
        Me.DataColonias.TabIndex = 4
        '
        'ComboColCiudades
        '
        Me.ComboColCiudades.FormattingEnabled = True
        Me.ComboColCiudades.Location = New System.Drawing.Point(175, 83)
        Me.ComboColCiudades.Name = "ComboColCiudades"
        Me.ComboColCiudades.Size = New System.Drawing.Size(121, 21)
        Me.ComboColCiudades.TabIndex = 3
        '
        'ComboColEstados
        '
        Me.ComboColEstados.FormattingEnabled = True
        Me.ComboColEstados.Location = New System.Drawing.Point(175, 35)
        Me.ComboColEstados.Name = "ComboColEstados"
        Me.ComboColEstados.Size = New System.Drawing.Size(121, 21)
        Me.ComboColEstados.TabIndex = 3
        '
        'LabelColCiudad
        '
        Me.LabelColCiudad.AutoSize = True
        Me.LabelColCiudad.Location = New System.Drawing.Point(172, 68)
        Me.LabelColCiudad.Name = "LabelColCiudad"
        Me.LabelColCiudad.Size = New System.Drawing.Size(40, 13)
        Me.LabelColCiudad.TabIndex = 2
        Me.LabelColCiudad.Text = "Ciudad"
        '
        'LabelColEstado
        '
        Me.LabelColEstado.AutoSize = True
        Me.LabelColEstado.Location = New System.Drawing.Point(172, 20)
        Me.LabelColEstado.Name = "LabelColEstado"
        Me.LabelColEstado.Size = New System.Drawing.Size(40, 13)
        Me.LabelColEstado.TabIndex = 2
        Me.LabelColEstado.Text = "Estado"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(33, 84)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextIDColonia
        '
        Me.TextIDColonia.Location = New System.Drawing.Point(33, 37)
        Me.TextIDColonia.Name = "TextIDColonia"
        Me.TextIDColonia.Size = New System.Drawing.Size(100, 20)
        Me.TextIDColonia.TabIndex = 1
        '
        'LabelNombreColonia
        '
        Me.LabelNombreColonia.AutoSize = True
        Me.LabelNombreColonia.Location = New System.Drawing.Point(30, 68)
        Me.LabelNombreColonia.Name = "LabelNombreColonia"
        Me.LabelNombreColonia.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombreColonia.TabIndex = 0
        Me.LabelNombreColonia.Text = "Nombre"
        '
        'LabelIDColonia
        '
        Me.LabelIDColonia.AutoSize = True
        Me.LabelIDColonia.Location = New System.Drawing.Point(30, 20)
        Me.LabelIDColonia.Name = "LabelIDColonia"
        Me.LabelIDColonia.Size = New System.Drawing.Size(56, 13)
        Me.LabelIDColonia.TabIndex = 0
        Me.LabelIDColonia.Text = "ID Colonia"
        '
        'TabSucursales
        '
        Me.TabSucursales.Controls.Add(Me.EliminarSucursal)
        Me.TabSucursales.Controls.Add(Me.GuardarSucursal)
        Me.TabSucursales.Controls.Add(Me.NuevaSucursal)
        Me.TabSucursales.Controls.Add(Me.LabelIDSucursal)
        Me.TabSucursales.Location = New System.Drawing.Point(4, 22)
        Me.TabSucursales.Name = "TabSucursales"
        Me.TabSucursales.Size = New System.Drawing.Size(670, 386)
        Me.TabSucursales.TabIndex = 7
        Me.TabSucursales.Text = "Sucursales"
        Me.TabSucursales.UseVisualStyleBackColor = True
        '
        'EliminarSucursal
        '
        Me.EliminarSucursal.Location = New System.Drawing.Point(592, 360)
        Me.EliminarSucursal.Name = "EliminarSucursal"
        Me.EliminarSucursal.Size = New System.Drawing.Size(75, 23)
        Me.EliminarSucursal.TabIndex = 9
        Me.EliminarSucursal.Text = "Eliminar"
        Me.EliminarSucursal.UseVisualStyleBackColor = True
        '
        'GuardarSucursal
        '
        Me.GuardarSucursal.Location = New System.Drawing.Point(511, 360)
        Me.GuardarSucursal.Name = "GuardarSucursal"
        Me.GuardarSucursal.Size = New System.Drawing.Size(75, 23)
        Me.GuardarSucursal.TabIndex = 10
        Me.GuardarSucursal.Text = "Guardar"
        Me.GuardarSucursal.UseVisualStyleBackColor = True
        '
        'NuevaSucursal
        '
        Me.NuevaSucursal.Location = New System.Drawing.Point(430, 360)
        Me.NuevaSucursal.Name = "NuevaSucursal"
        Me.NuevaSucursal.Size = New System.Drawing.Size(75, 23)
        Me.NuevaSucursal.TabIndex = 11
        Me.NuevaSucursal.Text = "Nuevo"
        Me.NuevaSucursal.UseVisualStyleBackColor = True
        '
        'LabelIDSucursal
        '
        Me.LabelIDSucursal.AutoSize = True
        Me.LabelIDSucursal.Location = New System.Drawing.Point(33, 27)
        Me.LabelIDSucursal.Name = "LabelIDSucursal"
        Me.LabelIDSucursal.Size = New System.Drawing.Size(62, 13)
        Me.LabelIDSucursal.TabIndex = 0
        Me.LabelIDSucursal.Text = "ID Sucursal"
        '
        'TabClientes
        '
        Me.TabClientes.Controls.Add(Me.ComboBox1)
        Me.TabClientes.Controls.Add(Me.ComboColoniaCLiente)
        Me.TabClientes.Controls.Add(Me.DGVClientes)
        Me.TabClientes.Controls.Add(Me.EliminarCliente)
        Me.TabClientes.Controls.Add(Me.GuardarCliente)
        Me.TabClientes.Controls.Add(Me.NuevoCliente)
        Me.TabClientes.Controls.Add(Me.TextBox3)
        Me.TabClientes.Controls.Add(Me.TextNoCasaCliente)
        Me.TabClientes.Controls.Add(Me.TextApellidoMCliente)
        Me.TabClientes.Controls.Add(Me.TextEstadoCliente)
        Me.TabClientes.Controls.Add(Me.TextCalleCLiente)
        Me.TabClientes.Controls.Add(Me.TextTelCliente)
        Me.TabClientes.Controls.Add(Me.TextApellidoPCliente)
        Me.TabClientes.Controls.Add(Me.LabelCiudadCliente)
        Me.TabClientes.Controls.Add(Me.TextNombreCliente)
        Me.TabClientes.Controls.Add(Me.LabelColoniaCLiente)
        Me.TabClientes.Controls.Add(Me.LabelCorreoCliente)
        Me.TabClientes.Controls.Add(Me.LabelApellidoMCliente)
        Me.TabClientes.Controls.Add(Me.LabelNoCasaCliente)
        Me.TabClientes.Controls.Add(Me.LabelEstadoCLiente)
        Me.TabClientes.Controls.Add(Me.TextnoLicencia)
        Me.TabClientes.Controls.Add(Me.LabelCalleCliente)
        Me.TabClientes.Controls.Add(Me.LabelTelCLiente)
        Me.TabClientes.Controls.Add(Me.LabelApellidoPCliente)
        Me.TabClientes.Controls.Add(Me.LabelNombre)
        Me.TabClientes.Controls.Add(Me.LabelLicencia)
        Me.TabClientes.Location = New System.Drawing.Point(4, 22)
        Me.TabClientes.Name = "TabClientes"
        Me.TabClientes.Size = New System.Drawing.Size(670, 386)
        Me.TabClientes.TabIndex = 8
        Me.TabClientes.Text = "Clientes"
        Me.TabClientes.UseVisualStyleBackColor = True
        '
        'DGVClientes
        '
        Me.DGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVClientes.Location = New System.Drawing.Point(3, 110)
        Me.DGVClientes.Name = "DGVClientes"
        Me.DGVClientes.Size = New System.Drawing.Size(664, 244)
        Me.DGVClientes.TabIndex = 15
        '
        'EliminarCliente
        '
        Me.EliminarCliente.Location = New System.Drawing.Point(592, 360)
        Me.EliminarCliente.Name = "EliminarCliente"
        Me.EliminarCliente.Size = New System.Drawing.Size(75, 23)
        Me.EliminarCliente.TabIndex = 12
        Me.EliminarCliente.Text = "Eliminar"
        Me.EliminarCliente.UseVisualStyleBackColor = True
        '
        'GuardarCliente
        '
        Me.GuardarCliente.Location = New System.Drawing.Point(511, 360)
        Me.GuardarCliente.Name = "GuardarCliente"
        Me.GuardarCliente.Size = New System.Drawing.Size(75, 23)
        Me.GuardarCliente.TabIndex = 13
        Me.GuardarCliente.Text = "Guardar"
        Me.GuardarCliente.UseVisualStyleBackColor = True
        '
        'NuevoCliente
        '
        Me.NuevoCliente.Location = New System.Drawing.Point(430, 360)
        Me.NuevoCliente.Name = "NuevoCliente"
        Me.NuevoCliente.Size = New System.Drawing.Size(75, 23)
        Me.NuevoCliente.TabIndex = 14
        Me.NuevoCliente.Text = "Nuevo"
        Me.NuevoCliente.UseVisualStyleBackColor = True
        '
        'TextApellidoMCliente
        '
        Me.TextApellidoMCliente.Location = New System.Drawing.Point(151, 84)
        Me.TextApellidoMCliente.Name = "TextApellidoMCliente"
        Me.TextApellidoMCliente.Size = New System.Drawing.Size(100, 20)
        Me.TextApellidoMCliente.TabIndex = 1
        '
        'TextApellidoPCliente
        '
        Me.TextApellidoPCliente.Location = New System.Drawing.Point(151, 37)
        Me.TextApellidoPCliente.Name = "TextApellidoPCliente"
        Me.TextApellidoPCliente.Size = New System.Drawing.Size(100, 20)
        Me.TextApellidoPCliente.TabIndex = 1
        '
        'TextNombreCliente
        '
        Me.TextNombreCliente.Location = New System.Drawing.Point(33, 84)
        Me.TextNombreCliente.Name = "TextNombreCliente"
        Me.TextNombreCliente.Size = New System.Drawing.Size(100, 20)
        Me.TextNombreCliente.TabIndex = 1
        '
        'LabelApellidoMCliente
        '
        Me.LabelApellidoMCliente.AutoSize = True
        Me.LabelApellidoMCliente.Location = New System.Drawing.Point(148, 68)
        Me.LabelApellidoMCliente.Name = "LabelApellidoMCliente"
        Me.LabelApellidoMCliente.Size = New System.Drawing.Size(85, 13)
        Me.LabelApellidoMCliente.TabIndex = 0
        Me.LabelApellidoMCliente.Text = "Apellido materno"
        '
        'TextnoLicencia
        '
        Me.TextnoLicencia.Location = New System.Drawing.Point(33, 37)
        Me.TextnoLicencia.Name = "TextnoLicencia"
        Me.TextnoLicencia.Size = New System.Drawing.Size(100, 20)
        Me.TextnoLicencia.TabIndex = 1
        '
        'LabelApellidoPCliente
        '
        Me.LabelApellidoPCliente.AutoSize = True
        Me.LabelApellidoPCliente.Location = New System.Drawing.Point(148, 20)
        Me.LabelApellidoPCliente.Name = "LabelApellidoPCliente"
        Me.LabelApellidoPCliente.Size = New System.Drawing.Size(83, 13)
        Me.LabelApellidoPCliente.TabIndex = 0
        Me.LabelApellidoPCliente.Text = "Apellido paterno"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Location = New System.Drawing.Point(30, 68)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(55, 13)
        Me.LabelNombre.TabIndex = 0
        Me.LabelNombre.Text = "Nombre(s)"
        '
        'LabelLicencia
        '
        Me.LabelLicencia.AutoSize = True
        Me.LabelLicencia.Location = New System.Drawing.Point(30, 20)
        Me.LabelLicencia.Name = "LabelLicencia"
        Me.LabelLicencia.Size = New System.Drawing.Size(98, 13)
        Me.LabelLicencia.TabIndex = 0
        Me.LabelLicencia.Text = "Número de licencia"
        '
        'TabEmpleados
        '
        Me.TabEmpleados.Location = New System.Drawing.Point(4, 22)
        Me.TabEmpleados.Name = "TabEmpleados"
        Me.TabEmpleados.Size = New System.Drawing.Size(670, 386)
        Me.TabEmpleados.TabIndex = 9
        Me.TabEmpleados.Text = "Empleados"
        Me.TabEmpleados.UseVisualStyleBackColor = True
        '
        'TabRentas
        '
        Me.TabRentas.Location = New System.Drawing.Point(4, 22)
        Me.TabRentas.Name = "TabRentas"
        Me.TabRentas.Size = New System.Drawing.Size(670, 386)
        Me.TabRentas.TabIndex = 10
        Me.TabRentas.Text = "Rentas"
        Me.TabRentas.UseVisualStyleBackColor = True
        '
        'LabelTelCLiente
        '
        Me.LabelTelCLiente.AutoSize = True
        Me.LabelTelCLiente.Location = New System.Drawing.Point(263, 20)
        Me.LabelTelCLiente.Name = "LabelTelCLiente"
        Me.LabelTelCLiente.Size = New System.Drawing.Size(49, 13)
        Me.LabelTelCLiente.TabIndex = 0
        Me.LabelTelCLiente.Text = "Teléfono"
        '
        'LabelCorreoCliente
        '
        Me.LabelCorreoCliente.AutoSize = True
        Me.LabelCorreoCliente.Location = New System.Drawing.Point(263, 68)
        Me.LabelCorreoCliente.Name = "LabelCorreoCliente"
        Me.LabelCorreoCliente.Size = New System.Drawing.Size(93, 13)
        Me.LabelCorreoCliente.TabIndex = 0
        Me.LabelCorreoCliente.Text = "Correo electrónico"
        '
        'TextTelCliente
        '
        Me.TextTelCliente.Location = New System.Drawing.Point(266, 37)
        Me.TextTelCliente.Name = "TextTelCliente"
        Me.TextTelCliente.Size = New System.Drawing.Size(100, 20)
        Me.TextTelCliente.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(266, 84)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 1
        '
        'LabelCalleCliente
        '
        Me.LabelCalleCliente.AutoSize = True
        Me.LabelCalleCliente.Location = New System.Drawing.Point(379, 20)
        Me.LabelCalleCliente.Name = "LabelCalleCliente"
        Me.LabelCalleCliente.Size = New System.Drawing.Size(30, 13)
        Me.LabelCalleCliente.TabIndex = 0
        Me.LabelCalleCliente.Text = "Calle"
        '
        'LabelColoniaCLiente
        '
        Me.LabelColoniaCLiente.AutoSize = True
        Me.LabelColoniaCLiente.Location = New System.Drawing.Point(379, 68)
        Me.LabelColoniaCLiente.Name = "LabelColoniaCLiente"
        Me.LabelColoniaCLiente.Size = New System.Drawing.Size(42, 13)
        Me.LabelColoniaCLiente.TabIndex = 0
        Me.LabelColoniaCLiente.Text = "Colonia"
        '
        'TextCalleCLiente
        '
        Me.TextCalleCLiente.Location = New System.Drawing.Point(382, 37)
        Me.TextCalleCLiente.Name = "TextCalleCLiente"
        Me.TextCalleCLiente.Size = New System.Drawing.Size(100, 20)
        Me.TextCalleCLiente.TabIndex = 1
        '
        'ComboColoniaCLiente
        '
        Me.ComboColoniaCLiente.FormattingEnabled = True
        Me.ComboColoniaCLiente.Location = New System.Drawing.Point(382, 84)
        Me.ComboColoniaCLiente.Name = "ComboColoniaCLiente"
        Me.ComboColoniaCLiente.Size = New System.Drawing.Size(100, 21)
        Me.ComboColoniaCLiente.TabIndex = 16
        '
        'LabelNoCasaCliente
        '
        Me.LabelNoCasaCliente.AutoSize = True
        Me.LabelNoCasaCliente.Location = New System.Drawing.Point(613, 20)
        Me.LabelNoCasaCliente.Name = "LabelNoCasaCliente"
        Me.LabelNoCasaCliente.Size = New System.Drawing.Size(38, 13)
        Me.LabelNoCasaCliente.TabIndex = 0
        Me.LabelNoCasaCliente.Text = "#Casa"
        '
        'LabelCiudadCliente
        '
        Me.LabelCiudadCliente.AutoSize = True
        Me.LabelCiudadCliente.Location = New System.Drawing.Point(494, 67)
        Me.LabelCiudadCliente.Name = "LabelCiudadCliente"
        Me.LabelCiudadCliente.Size = New System.Drawing.Size(40, 13)
        Me.LabelCiudadCliente.TabIndex = 0
        Me.LabelCiudadCliente.Text = "Ciudad"
        '
        'TextNoCasaCliente
        '
        Me.TextNoCasaCliente.Location = New System.Drawing.Point(616, 37)
        Me.TextNoCasaCliente.Name = "TextNoCasaCliente"
        Me.TextNoCasaCliente.Size = New System.Drawing.Size(35, 20)
        Me.TextNoCasaCliente.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(497, 83)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 16
        '
        'LabelEstadoCLiente
        '
        Me.LabelEstadoCLiente.AutoSize = True
        Me.LabelEstadoCLiente.Location = New System.Drawing.Point(494, 20)
        Me.LabelEstadoCLiente.Name = "LabelEstadoCLiente"
        Me.LabelEstadoCLiente.Size = New System.Drawing.Size(40, 13)
        Me.LabelEstadoCLiente.TabIndex = 0
        Me.LabelEstadoCLiente.Text = "Estado"
        '
        'TextEstadoCliente
        '
        Me.TextEstadoCliente.Location = New System.Drawing.Point(497, 37)
        Me.TextEstadoCliente.Name = "TextEstadoCliente"
        Me.TextEstadoCliente.Size = New System.Drawing.Size(100, 20)
        Me.TextEstadoCliente.TabIndex = 1
        '
        'TabLogin
        '
        Me.TabLogin.Controls.Add(Me.EliminarAdmin)
        Me.TabLogin.Controls.Add(Me.GuardarAdmin)
        Me.TabLogin.Controls.Add(Me.NuevoAdmin)
        Me.TabLogin.Controls.Add(Me.DGVAdmins)
        Me.TabLogin.Controls.Add(Me.TextContraseña)
        Me.TabLogin.Controls.Add(Me.TextIDAdmin)
        Me.TabLogin.Controls.Add(Me.LabelContrasena)
        Me.TabLogin.Controls.Add(Me.LabelidAdmin)
        Me.TabLogin.Location = New System.Drawing.Point(4, 22)
        Me.TabLogin.Name = "TabLogin"
        Me.TabLogin.Padding = New System.Windows.Forms.Padding(3)
        Me.TabLogin.Size = New System.Drawing.Size(670, 386)
        Me.TabLogin.TabIndex = 12
        Me.TabLogin.Text = "Aministradores"
        Me.TabLogin.UseVisualStyleBackColor = True
        '
        'LabelidAdmin
        '
        Me.LabelidAdmin.AutoSize = True
        Me.LabelidAdmin.Location = New System.Drawing.Point(30, 20)
        Me.LabelidAdmin.Name = "LabelidAdmin"
        Me.LabelidAdmin.Size = New System.Drawing.Size(43, 13)
        Me.LabelidAdmin.TabIndex = 0
        Me.LabelidAdmin.Text = "Usuario"
        '
        'TextIDAdmin
        '
        Me.TextIDAdmin.Location = New System.Drawing.Point(33, 37)
        Me.TextIDAdmin.Name = "TextIDAdmin"
        Me.TextIDAdmin.Size = New System.Drawing.Size(100, 20)
        Me.TextIDAdmin.TabIndex = 1
        '
        'LabelContrasena
        '
        Me.LabelContrasena.AutoSize = True
        Me.LabelContrasena.Location = New System.Drawing.Point(30, 68)
        Me.LabelContrasena.Name = "LabelContrasena"
        Me.LabelContrasena.Size = New System.Drawing.Size(61, 13)
        Me.LabelContrasena.TabIndex = 0
        Me.LabelContrasena.Text = "Contraseña"
        '
        'TextContraseña
        '
        Me.TextContraseña.Location = New System.Drawing.Point(33, 84)
        Me.TextContraseña.Name = "TextContraseña"
        Me.TextContraseña.Size = New System.Drawing.Size(100, 20)
        Me.TextContraseña.TabIndex = 1
        '
        'DGVAdmins
        '
        Me.DGVAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAdmins.Location = New System.Drawing.Point(6, 110)
        Me.DGVAdmins.Name = "DGVAdmins"
        Me.DGVAdmins.Size = New System.Drawing.Size(661, 244)
        Me.DGVAdmins.TabIndex = 2
        '
        'EliminarAdmin
        '
        Me.EliminarAdmin.Location = New System.Drawing.Point(592, 360)
        Me.EliminarAdmin.Name = "EliminarAdmin"
        Me.EliminarAdmin.Size = New System.Drawing.Size(75, 23)
        Me.EliminarAdmin.TabIndex = 15
        Me.EliminarAdmin.Text = "Eliminar"
        Me.EliminarAdmin.UseVisualStyleBackColor = True
        '
        'GuardarAdmin
        '
        Me.GuardarAdmin.Location = New System.Drawing.Point(511, 360)
        Me.GuardarAdmin.Name = "GuardarAdmin"
        Me.GuardarAdmin.Size = New System.Drawing.Size(75, 23)
        Me.GuardarAdmin.TabIndex = 16
        Me.GuardarAdmin.Text = "Guardar"
        Me.GuardarAdmin.UseVisualStyleBackColor = True
        '
        'NuevoAdmin
        '
        Me.NuevoAdmin.Location = New System.Drawing.Point(430, 360)
        Me.NuevoAdmin.Name = "NuevoAdmin"
        Me.NuevoAdmin.Size = New System.Drawing.Size(75, 23)
        Me.NuevoAdmin.TabIndex = 17
        Me.NuevoAdmin.Text = "Nuevo"
        Me.NuevoAdmin.UseVisualStyleBackColor = True
        '
        'Catalago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 436)
        Me.Controls.Add(Me.TablasPestanas)
        Me.Controls.Add(Me.DataGridView1)
        Me.MinimumSize = New System.Drawing.Size(458, 39)
        Me.Name = "Catalago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálago"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TablasPestanas.ResumeLayout(False)
        Me.TabAutos.ResumeLayout(False)
        Me.TabAutos.PerformLayout()
        CType(Me.DataAutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabEstAuto.ResumeLayout(False)
        Me.TabEstAuto.PerformLayout()
        CType(Me.DataEstadosAuto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMarcas.ResumeLayout(False)
        Me.TabMarcas.PerformLayout()
        CType(Me.DataMarcas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabModelos.ResumeLayout(False)
        Me.TabModelos.PerformLayout()
        CType(Me.DataModelos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPrecios.ResumeLayout(False)
        Me.TabPrecios.PerformLayout()
        CType(Me.DataPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabEstados.ResumeLayout(False)
        Me.TabEstados.PerformLayout()
        CType(Me.DataEstados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCiudades.ResumeLayout(False)
        Me.TabCiudades.PerformLayout()
        CType(Me.DataCiudades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabColonias.ResumeLayout(False)
        Me.TabColonias.PerformLayout()
        CType(Me.DataColonias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSucursales.ResumeLayout(False)
        Me.TabSucursales.PerformLayout()
        Me.TabClientes.ResumeLayout(False)
        Me.TabClientes.PerformLayout()
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabLogin.ResumeLayout(False)
        Me.TabLogin.PerformLayout()
        CType(Me.DGVAdmins, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TabEstados As TabPage
    Friend WithEvents LabelIDEst As Label
    Friend WithEvents TabMarcas As TabPage
    Friend WithEvents TextIDEst As TextBox
    Friend WithEvents TablasPestanas As TabControl
    Friend WithEvents TextNombreEstado As TextBox
    Friend WithEvents LabelNombreEstado As Label
    Friend WithEvents TextNombreMarca As TextBox
    Friend WithEvents LabelNombreMarca As Label
    Friend WithEvents TextIDMarca As TextBox
    Friend WithEvents LabelIDMarca As Label
    Friend WithEvents DataAutos As DataGridView
    Friend WithEvents TabEstAuto As TabPage
    Friend WithEvents TextDescEstAuto As TextBox
    Friend WithEvents LabelDescEstAuto As Label
    Friend WithEvents TextIDEstAuto As TextBox
    Friend WithEvents LabelIDEstAuto As Label
    Friend WithEvents TabModelos As TabPage
    Friend WithEvents ComboIDMarca As ComboBox
    Friend WithEvents TextNombreModelo As TextBox
    Friend WithEvents LabelNombreModelo As Label
    Friend WithEvents TextIDModelo As TextBox
    Friend WithEvents LabelModeloIDMarca As Label
    Friend WithEvents LabelIDModelo As Label
    Friend WithEvents TabCiudades As TabPage
    Friend WithEvents ComboCiudadIDEstado As ComboBox
    Friend WithEvents TextNombreCiudad As TextBox
    Friend WithEvents TextIDCiudad As TextBox
    Friend WithEvents LabelNombreciudad As Label
    Friend WithEvents LabelCiudadesIDEstado As Label
    Friend WithEvents LabelIDCiudad As Label
    Friend WithEvents TabPrecios As TabPage
    Friend WithEvents TextIDPrecio As TextBox
    Friend WithEvents LabelIDPrecio As Label
    Friend WithEvents TabAutos As TabPage
    Friend WithEvents TextCapacidad As TextBox
    Friend WithEvents LabelCapacidad As Label
    Friend WithEvents TextPlaca As TextBox
    Friend WithEvents LabelPlaca As Label
    Friend WithEvents DataEstadosAuto As DataGridView
    Friend WithEvents TabColonias As TabPage
    Friend WithEvents TabSucursales As TabPage
    Friend WithEvents TabClientes As TabPage
    Friend WithEvents TabEmpleados As TabPage
    Friend WithEvents TabRentas As TabPage
    Friend WithEvents CheckDisponible As CheckBox
    Friend WithEvents ComboEstAuto As ComboBox
    Friend WithEvents ComboMarca As ComboBox
    Friend WithEvents LabelAutoEstAuto As Label
    Friend WithEvents LabelAutoMarca As Label
    Friend WithEvents TextMontoDia As TextBox
    Friend WithEvents LabelPrecioModelo As Label
    Friend WithEvents ComboPreciosIDModelo As ComboBox
    Friend WithEvents LabelMontoDia As Label
    Friend WithEvents TextMontoGarantia As TextBox
    Friend WithEvents LabelMontoGarantia As Label
    Friend WithEvents TextIDColonia As TextBox
    Friend WithEvents LabelIDColonia As Label
    Friend WithEvents ComboColCiudades As ComboBox
    Friend WithEvents ComboColEstados As ComboBox
    Friend WithEvents LabelColCiudad As Label
    Friend WithEvents LabelColEstado As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LabelNombreColonia As Label
    Friend WithEvents LabelIDSucursal As Label
    Friend WithEvents DataMarcas As DataGridView
    Friend WithEvents DataModelos As DataGridView
    Friend WithEvents DataPrecios As DataGridView
    Friend WithEvents DataEstados As DataGridView
    Friend WithEvents DataCiudades As DataGridView
    Friend WithEvents DataColonias As DataGridView
    Friend WithEvents ButtonEliminarAuto As Button
    Friend WithEvents ButtonGuardarAuto As Button
    Friend WithEvents ButtonNuevoAuto As Button
    Friend WithEvents EliminarEstAuto As Button
    Friend WithEvents GuardarEstAuto As Button
    Friend WithEvents NuevoEstAuto As Button
    Friend WithEvents EliminarMarca As Button
    Friend WithEvents GuardarMarca As Button
    Friend WithEvents NuevaMarca As Button
    Friend WithEvents EliminarModelo As Button
    Friend WithEvents GuardarModelo As Button
    Friend WithEvents NuevoModelo As Button
    Friend WithEvents EliminarPrecio As Button
    Friend WithEvents GuardarPrecio As Button
    Friend WithEvents NuevoPrecio As Button
    Friend WithEvents EliminarEstado As Button
    Friend WithEvents GuardarEstado As Button
    Friend WithEvents NuevoEstado As Button
    Friend WithEvents EliminarCiudad As Button
    Friend WithEvents GuardarCiudad As Button
    Friend WithEvents NuevaCiudad As Button
    Friend WithEvents EliminarColonia As Button
    Friend WithEvents GuardarColonia As Button
    Friend WithEvents NuevaColonia As Button
    Friend WithEvents EliminarSucursal As Button
    Friend WithEvents GuardarSucursal As Button
    Friend WithEvents NuevaSucursal As Button
    Friend WithEvents TextNombreCliente As TextBox
    Friend WithEvents TextnoLicencia As TextBox
    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelLicencia As Label
    Friend WithEvents DGVClientes As DataGridView
    Friend WithEvents EliminarCliente As Button
    Friend WithEvents GuardarCliente As Button
    Friend WithEvents NuevoCliente As Button
    Friend WithEvents TextApellidoMCliente As TextBox
    Friend WithEvents TextApellidoPCliente As TextBox
    Friend WithEvents LabelApellidoMCliente As Label
    Friend WithEvents LabelApellidoPCliente As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboColoniaCLiente As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextNoCasaCliente As TextBox
    Friend WithEvents TextEstadoCliente As TextBox
    Friend WithEvents TextCalleCLiente As TextBox
    Friend WithEvents TextTelCliente As TextBox
    Friend WithEvents LabelCiudadCliente As Label
    Friend WithEvents LabelColoniaCLiente As Label
    Friend WithEvents LabelCorreoCliente As Label
    Friend WithEvents LabelNoCasaCliente As Label
    Friend WithEvents LabelEstadoCLiente As Label
    Friend WithEvents LabelCalleCliente As Label
    Friend WithEvents LabelTelCLiente As Label
    Friend WithEvents TabLogin As TabPage
    Friend WithEvents EliminarAdmin As Button
    Friend WithEvents GuardarAdmin As Button
    Friend WithEvents NuevoAdmin As Button
    Friend WithEvents DGVAdmins As DataGridView
    Friend WithEvents TextContraseña As TextBox
    Friend WithEvents TextIDAdmin As TextBox
    Friend WithEvents LabelContrasena As Label
    Friend WithEvents LabelidAdmin As Label
End Class
