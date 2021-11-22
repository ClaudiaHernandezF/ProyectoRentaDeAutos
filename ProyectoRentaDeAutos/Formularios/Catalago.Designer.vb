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
        Me.LabelAutoModelo = New System.Windows.Forms.Label()
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
        Me.TextNombreColonia = New System.Windows.Forms.TextBox()
        Me.TextIDColonia = New System.Windows.Forms.TextBox()
        Me.LabelNombreColonia = New System.Windows.Forms.Label()
        Me.LabelIDColonia = New System.Windows.Forms.Label()
        Me.TabSucursales = New System.Windows.Forms.TabPage()
        Me.EliminarSucursal = New System.Windows.Forms.Button()
        Me.GuardarSucursal = New System.Windows.Forms.Button()
        Me.NuevaSucursal = New System.Windows.Forms.Button()
        Me.LabelIDSucursal = New System.Windows.Forms.Label()
        Me.TabClientes = New System.Windows.Forms.TabPage()
        Me.ComboClienteCiudad = New System.Windows.Forms.ComboBox()
        Me.ComboColoniaCLiente = New System.Windows.Forms.ComboBox()
        Me.DGVClientes = New System.Windows.Forms.DataGridView()
        Me.EliminarCliente = New System.Windows.Forms.Button()
        Me.GuardarCliente = New System.Windows.Forms.Button()
        Me.NuevoCliente = New System.Windows.Forms.Button()
        Me.TextCorreoCliente = New System.Windows.Forms.TextBox()
        Me.TextNoCasaCliente = New System.Windows.Forms.TextBox()
        Me.TextApellidoMCliente = New System.Windows.Forms.TextBox()
        Me.TextEstadoCliente = New System.Windows.Forms.TextBox()
        Me.TextCalleCLiente = New System.Windows.Forms.TextBox()
        Me.TextTelCliente = New System.Windows.Forms.TextBox()
        Me.TextApellidoPCliente = New System.Windows.Forms.TextBox()
        Me.LabelCiudadCliente = New System.Windows.Forms.Label()
        Me.TextNombreCliente = New System.Windows.Forms.TextBox()
        Me.LabelColoniaCLiente = New System.Windows.Forms.Label()
        Me.LabelCorreoCliente = New System.Windows.Forms.Label()
        Me.LabelApellidoMCliente = New System.Windows.Forms.Label()
        Me.LabelNoCasaCliente = New System.Windows.Forms.Label()
        Me.LabelEstadoCLiente = New System.Windows.Forms.Label()
        Me.TextnoLicencia = New System.Windows.Forms.TextBox()
        Me.LabelCalleCliente = New System.Windows.Forms.Label()
        Me.LabelTelCLiente = New System.Windows.Forms.Label()
        Me.LabelApellidoPCliente = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelLicencia = New System.Windows.Forms.Label()
        Me.TabEmpleados = New System.Windows.Forms.TabPage()
        Me.TabRentas = New System.Windows.Forms.TabPage()
        Me.TabLogin = New System.Windows.Forms.TabPage()
        Me.EliminarAdmin = New System.Windows.Forms.Button()
        Me.GuardarAdmin = New System.Windows.Forms.Button()
        Me.NuevoAdmin = New System.Windows.Forms.Button()
        Me.DGVAdmins = New System.Windows.Forms.DataGridView()
        Me.TextContraseña = New System.Windows.Forms.TextBox()
        Me.TextIDAdmin = New System.Windows.Forms.TextBox()
        Me.LabelContrasena = New System.Windows.Forms.Label()
        Me.LabelidAdmin = New System.Windows.Forms.Label()
        Me.LabelPrecioDIa = New System.Windows.Forms.Label()
        Me.TextPrecioDia = New System.Windows.Forms.TextBox()
        Me.LabelPrecioGarantia = New System.Windows.Forms.Label()
        Me.TextPrecioGarantia = New System.Windows.Forms.TextBox()
        Me.TextIDSucursal = New System.Windows.Forms.TextBox()
        Me.LabelNombreSucursal = New System.Windows.Forms.Label()
        Me.TextNombreSucursal = New System.Windows.Forms.TextBox()
        Me.LabelSucIDEstado = New System.Windows.Forms.Label()
        Me.ComboEstadoSucursal = New System.Windows.Forms.ComboBox()
        Me.LabelCiudadSucursal = New System.Windows.Forms.Label()
        Me.ComboCiudadSucursal = New System.Windows.Forms.ComboBox()
        Me.LabelColSucursal = New System.Windows.Forms.Label()
        Me.ComboColoniaSucursal = New System.Windows.Forms.ComboBox()
        Me.LabelCalleSucursal = New System.Windows.Forms.Label()
        Me.TextCalleSucursal = New System.Windows.Forms.TextBox()
        Me.DGVSucursal = New System.Windows.Forms.DataGridView()
        Me.ComboIDSucursal = New System.Windows.Forms.ComboBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.EliminarEmpleado = New System.Windows.Forms.Button()
        Me.GuardarEmpleado = New System.Windows.Forms.Button()
        Me.NuevoEmpleado = New System.Windows.Forms.Button()
        Me.TextCorreoEmpleado = New System.Windows.Forms.TextBox()
        Me.TextApellidoMEmpleado = New System.Windows.Forms.TextBox()
        Me.TextTelEmpleado = New System.Windows.Forms.TextBox()
        Me.TextApellidoPEmpleado = New System.Windows.Forms.TextBox()
        Me.TextNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelCorreoEmpleado = New System.Windows.Forms.Label()
        Me.LabelApellidoMEmpleado = New System.Windows.Forms.Label()
        Me.TextUsuarioEmpleado = New System.Windows.Forms.TextBox()
        Me.LabelTelEmpleado = New System.Windows.Forms.Label()
        Me.LabelApellidoPEmpleado = New System.Windows.Forms.Label()
        Me.LabelNombreEmpleado = New System.Windows.Forms.Label()
        Me.LabelUsuario = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.EliminarRenta = New System.Windows.Forms.Button()
        Me.GuardarRenta = New System.Windows.Forms.Button()
        Me.NuevaRenta = New System.Windows.Forms.Button()
        Me.LabelDiasRenta = New System.Windows.Forms.Label()
        Me.LabelFechaDevolucion = New System.Windows.Forms.Label()
        Me.LabelLicenciaRenta = New System.Windows.Forms.Label()
        Me.TextIDRenta = New System.Windows.Forms.TextBox()
        Me.LabelFechaPRenta = New System.Windows.Forms.Label()
        Me.LabelEmpleadoRenta = New System.Windows.Forms.Label()
        Me.LabelPlacaRenta = New System.Windows.Forms.Label()
        Me.LabelIDRenta = New System.Windows.Forms.Label()
        Me.ComboPlacaRenta = New System.Windows.Forms.ComboBox()
        Me.ComboEmpleadoRenta = New System.Windows.Forms.ComboBox()
        Me.ComboLicenciaRenta = New System.Windows.Forms.ComboBox()
        Me.DateFechaPrestamo = New System.Windows.Forms.DateTimePicker()
        Me.DateFechaDevolucion = New System.Windows.Forms.DateTimePicker()
        Me.TextDiasRenta = New System.Windows.Forms.TextBox()
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
        Me.TabEstados.SuspendLayout()
        CType(Me.DataEstados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCiudades.SuspendLayout()
        CType(Me.DataCiudades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabColonias.SuspendLayout()
        CType(Me.DataColonias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSucursales.SuspendLayout()
        Me.TabClientes.SuspendLayout()
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabEmpleados.SuspendLayout()
        Me.TabRentas.SuspendLayout()
        Me.TabLogin.SuspendLayout()
        CType(Me.DGVAdmins, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabAutos.Controls.Add(Me.LabelAutoModelo)
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
        'LabelAutoModelo
        '
        Me.LabelAutoModelo.AutoSize = True
        Me.LabelAutoModelo.Location = New System.Drawing.Point(183, 20)
        Me.LabelAutoModelo.Name = "LabelAutoModelo"
        Me.LabelAutoModelo.Size = New System.Drawing.Size(42, 13)
        Me.LabelAutoModelo.TabIndex = 4
        Me.LabelAutoModelo.Text = "Modelo"
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
        Me.TabModelos.Controls.Add(Me.TextPrecioDia)
        Me.TabModelos.Controls.Add(Me.LabelPrecioDIa)
        Me.TabModelos.Controls.Add(Me.TextNombreModelo)
        Me.TabModelos.Controls.Add(Me.TextPrecioGarantia)
        Me.TabModelos.Controls.Add(Me.LabelNombreModelo)
        Me.TabModelos.Controls.Add(Me.TextIDModelo)
        Me.TabModelos.Controls.Add(Me.LabelPrecioGarantia)
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
        Me.LabelModeloIDMarca.Size = New System.Drawing.Size(37, 13)
        Me.LabelModeloIDMarca.TabIndex = 0
        Me.LabelModeloIDMarca.Text = "Marca"
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
        Me.LabelCiudadesIDEstado.Size = New System.Drawing.Size(40, 13)
        Me.LabelCiudadesIDEstado.TabIndex = 0
        Me.LabelCiudadesIDEstado.Text = "Estado"
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
        Me.TabColonias.Controls.Add(Me.TextNombreColonia)
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
        'TextNombreColonia
        '
        Me.TextNombreColonia.Location = New System.Drawing.Point(33, 84)
        Me.TextNombreColonia.Name = "TextNombreColonia"
        Me.TextNombreColonia.Size = New System.Drawing.Size(100, 20)
        Me.TextNombreColonia.TabIndex = 1
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
        Me.TabSucursales.Controls.Add(Me.DGVSucursal)
        Me.TabSucursales.Controls.Add(Me.ComboCiudadSucursal)
        Me.TabSucursales.Controls.Add(Me.ComboColoniaSucursal)
        Me.TabSucursales.Controls.Add(Me.ComboEstadoSucursal)
        Me.TabSucursales.Controls.Add(Me.LabelColSucursal)
        Me.TabSucursales.Controls.Add(Me.LabelCiudadSucursal)
        Me.TabSucursales.Controls.Add(Me.LabelSucIDEstado)
        Me.TabSucursales.Controls.Add(Me.TextCalleSucursal)
        Me.TabSucursales.Controls.Add(Me.TextNombreSucursal)
        Me.TabSucursales.Controls.Add(Me.TextIDSucursal)
        Me.TabSucursales.Controls.Add(Me.EliminarSucursal)
        Me.TabSucursales.Controls.Add(Me.GuardarSucursal)
        Me.TabSucursales.Controls.Add(Me.LabelCalleSucursal)
        Me.TabSucursales.Controls.Add(Me.NuevaSucursal)
        Me.TabSucursales.Controls.Add(Me.LabelNombreSucursal)
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
        Me.LabelIDSucursal.Location = New System.Drawing.Point(30, 20)
        Me.LabelIDSucursal.Name = "LabelIDSucursal"
        Me.LabelIDSucursal.Size = New System.Drawing.Size(62, 13)
        Me.LabelIDSucursal.TabIndex = 0
        Me.LabelIDSucursal.Text = "ID Sucursal"
        '
        'TabClientes
        '
        Me.TabClientes.Controls.Add(Me.ComboClienteCiudad)
        Me.TabClientes.Controls.Add(Me.ComboColoniaCLiente)
        Me.TabClientes.Controls.Add(Me.DGVClientes)
        Me.TabClientes.Controls.Add(Me.EliminarCliente)
        Me.TabClientes.Controls.Add(Me.GuardarCliente)
        Me.TabClientes.Controls.Add(Me.NuevoCliente)
        Me.TabClientes.Controls.Add(Me.TextCorreoCliente)
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
        'ComboClienteCiudad
        '
        Me.ComboClienteCiudad.FormattingEnabled = True
        Me.ComboClienteCiudad.Location = New System.Drawing.Point(497, 83)
        Me.ComboClienteCiudad.Name = "ComboClienteCiudad"
        Me.ComboClienteCiudad.Size = New System.Drawing.Size(100, 21)
        Me.ComboClienteCiudad.TabIndex = 16
        '
        'ComboColoniaCLiente
        '
        Me.ComboColoniaCLiente.FormattingEnabled = True
        Me.ComboColoniaCLiente.Location = New System.Drawing.Point(382, 84)
        Me.ComboColoniaCLiente.Name = "ComboColoniaCLiente"
        Me.ComboColoniaCLiente.Size = New System.Drawing.Size(100, 21)
        Me.ComboColoniaCLiente.TabIndex = 16
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
        'TextCorreoCliente
        '
        Me.TextCorreoCliente.Location = New System.Drawing.Point(266, 84)
        Me.TextCorreoCliente.Name = "TextCorreoCliente"
        Me.TextCorreoCliente.Size = New System.Drawing.Size(100, 20)
        Me.TextCorreoCliente.TabIndex = 1
        '
        'TextNoCasaCliente
        '
        Me.TextNoCasaCliente.Location = New System.Drawing.Point(616, 37)
        Me.TextNoCasaCliente.Name = "TextNoCasaCliente"
        Me.TextNoCasaCliente.Size = New System.Drawing.Size(35, 20)
        Me.TextNoCasaCliente.TabIndex = 1
        '
        'TextApellidoMCliente
        '
        Me.TextApellidoMCliente.Location = New System.Drawing.Point(151, 84)
        Me.TextApellidoMCliente.Name = "TextApellidoMCliente"
        Me.TextApellidoMCliente.Size = New System.Drawing.Size(100, 20)
        Me.TextApellidoMCliente.TabIndex = 1
        '
        'TextEstadoCliente
        '
        Me.TextEstadoCliente.Location = New System.Drawing.Point(497, 37)
        Me.TextEstadoCliente.Name = "TextEstadoCliente"
        Me.TextEstadoCliente.Size = New System.Drawing.Size(100, 20)
        Me.TextEstadoCliente.TabIndex = 1
        '
        'TextCalleCLiente
        '
        Me.TextCalleCLiente.Location = New System.Drawing.Point(382, 37)
        Me.TextCalleCLiente.Name = "TextCalleCLiente"
        Me.TextCalleCLiente.Size = New System.Drawing.Size(100, 20)
        Me.TextCalleCLiente.TabIndex = 1
        '
        'TextTelCliente
        '
        Me.TextTelCliente.Location = New System.Drawing.Point(266, 37)
        Me.TextTelCliente.Name = "TextTelCliente"
        Me.TextTelCliente.Size = New System.Drawing.Size(100, 20)
        Me.TextTelCliente.TabIndex = 1
        '
        'TextApellidoPCliente
        '
        Me.TextApellidoPCliente.Location = New System.Drawing.Point(151, 37)
        Me.TextApellidoPCliente.Name = "TextApellidoPCliente"
        Me.TextApellidoPCliente.Size = New System.Drawing.Size(100, 20)
        Me.TextApellidoPCliente.TabIndex = 1
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
        'TextNombreCliente
        '
        Me.TextNombreCliente.Location = New System.Drawing.Point(33, 84)
        Me.TextNombreCliente.Name = "TextNombreCliente"
        Me.TextNombreCliente.Size = New System.Drawing.Size(100, 20)
        Me.TextNombreCliente.TabIndex = 1
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
        'LabelCorreoCliente
        '
        Me.LabelCorreoCliente.AutoSize = True
        Me.LabelCorreoCliente.Location = New System.Drawing.Point(263, 68)
        Me.LabelCorreoCliente.Name = "LabelCorreoCliente"
        Me.LabelCorreoCliente.Size = New System.Drawing.Size(93, 13)
        Me.LabelCorreoCliente.TabIndex = 0
        Me.LabelCorreoCliente.Text = "Correo electrónico"
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
        'LabelNoCasaCliente
        '
        Me.LabelNoCasaCliente.AutoSize = True
        Me.LabelNoCasaCliente.Location = New System.Drawing.Point(613, 20)
        Me.LabelNoCasaCliente.Name = "LabelNoCasaCliente"
        Me.LabelNoCasaCliente.Size = New System.Drawing.Size(38, 13)
        Me.LabelNoCasaCliente.TabIndex = 0
        Me.LabelNoCasaCliente.Text = "#Casa"
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
        'TextnoLicencia
        '
        Me.TextnoLicencia.Location = New System.Drawing.Point(33, 37)
        Me.TextnoLicencia.Name = "TextnoLicencia"
        Me.TextnoLicencia.Size = New System.Drawing.Size(100, 20)
        Me.TextnoLicencia.TabIndex = 1
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
        'LabelTelCLiente
        '
        Me.LabelTelCLiente.AutoSize = True
        Me.LabelTelCLiente.Location = New System.Drawing.Point(263, 20)
        Me.LabelTelCLiente.Name = "LabelTelCLiente"
        Me.LabelTelCLiente.Size = New System.Drawing.Size(49, 13)
        Me.LabelTelCLiente.TabIndex = 0
        Me.LabelTelCLiente.Text = "Teléfono"
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
        Me.TabEmpleados.Controls.Add(Me.ComboIDSucursal)
        Me.TabEmpleados.Controls.Add(Me.DataGridView2)
        Me.TabEmpleados.Controls.Add(Me.EliminarEmpleado)
        Me.TabEmpleados.Controls.Add(Me.GuardarEmpleado)
        Me.TabEmpleados.Controls.Add(Me.NuevoEmpleado)
        Me.TabEmpleados.Controls.Add(Me.TextCorreoEmpleado)
        Me.TabEmpleados.Controls.Add(Me.TextApellidoMEmpleado)
        Me.TabEmpleados.Controls.Add(Me.TextTelEmpleado)
        Me.TabEmpleados.Controls.Add(Me.TextApellidoPEmpleado)
        Me.TabEmpleados.Controls.Add(Me.TextNombreEmpleado)
        Me.TabEmpleados.Controls.Add(Me.Label2)
        Me.TabEmpleados.Controls.Add(Me.LabelCorreoEmpleado)
        Me.TabEmpleados.Controls.Add(Me.LabelApellidoMEmpleado)
        Me.TabEmpleados.Controls.Add(Me.TextUsuarioEmpleado)
        Me.TabEmpleados.Controls.Add(Me.LabelTelEmpleado)
        Me.TabEmpleados.Controls.Add(Me.LabelApellidoPEmpleado)
        Me.TabEmpleados.Controls.Add(Me.LabelNombreEmpleado)
        Me.TabEmpleados.Controls.Add(Me.LabelUsuario)
        Me.TabEmpleados.Location = New System.Drawing.Point(4, 22)
        Me.TabEmpleados.Name = "TabEmpleados"
        Me.TabEmpleados.Size = New System.Drawing.Size(670, 386)
        Me.TabEmpleados.TabIndex = 9
        Me.TabEmpleados.Text = "Empleados"
        Me.TabEmpleados.UseVisualStyleBackColor = True
        '
        'TabRentas
        '
        Me.TabRentas.Controls.Add(Me.TextDiasRenta)
        Me.TabRentas.Controls.Add(Me.DateFechaDevolucion)
        Me.TabRentas.Controls.Add(Me.DateFechaPrestamo)
        Me.TabRentas.Controls.Add(Me.ComboLicenciaRenta)
        Me.TabRentas.Controls.Add(Me.ComboEmpleadoRenta)
        Me.TabRentas.Controls.Add(Me.ComboPlacaRenta)
        Me.TabRentas.Controls.Add(Me.DataGridView3)
        Me.TabRentas.Controls.Add(Me.EliminarRenta)
        Me.TabRentas.Controls.Add(Me.GuardarRenta)
        Me.TabRentas.Controls.Add(Me.NuevaRenta)
        Me.TabRentas.Controls.Add(Me.LabelDiasRenta)
        Me.TabRentas.Controls.Add(Me.LabelFechaDevolucion)
        Me.TabRentas.Controls.Add(Me.LabelLicenciaRenta)
        Me.TabRentas.Controls.Add(Me.TextIDRenta)
        Me.TabRentas.Controls.Add(Me.LabelFechaPRenta)
        Me.TabRentas.Controls.Add(Me.LabelEmpleadoRenta)
        Me.TabRentas.Controls.Add(Me.LabelPlacaRenta)
        Me.TabRentas.Controls.Add(Me.LabelIDRenta)
        Me.TabRentas.Location = New System.Drawing.Point(4, 22)
        Me.TabRentas.Name = "TabRentas"
        Me.TabRentas.Size = New System.Drawing.Size(670, 386)
        Me.TabRentas.TabIndex = 10
        Me.TabRentas.Text = "Rentas"
        Me.TabRentas.UseVisualStyleBackColor = True
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
        Me.TabLogin.Text = "Login"
        Me.TabLogin.UseVisualStyleBackColor = True
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
        'DGVAdmins
        '
        Me.DGVAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAdmins.Location = New System.Drawing.Point(6, 110)
        Me.DGVAdmins.Name = "DGVAdmins"
        Me.DGVAdmins.Size = New System.Drawing.Size(661, 244)
        Me.DGVAdmins.TabIndex = 2
        '
        'TextContraseña
        '
        Me.TextContraseña.Location = New System.Drawing.Point(33, 84)
        Me.TextContraseña.Name = "TextContraseña"
        Me.TextContraseña.Size = New System.Drawing.Size(100, 20)
        Me.TextContraseña.TabIndex = 1
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
        'LabelidAdmin
        '
        Me.LabelidAdmin.AutoSize = True
        Me.LabelidAdmin.Location = New System.Drawing.Point(30, 20)
        Me.LabelidAdmin.Name = "LabelidAdmin"
        Me.LabelidAdmin.Size = New System.Drawing.Size(43, 13)
        Me.LabelidAdmin.TabIndex = 0
        Me.LabelidAdmin.Text = "Usuario"
        '
        'LabelPrecioDIa
        '
        Me.LabelPrecioDIa.AutoSize = True
        Me.LabelPrecioDIa.Location = New System.Drawing.Point(183, 68)
        Me.LabelPrecioDIa.Name = "LabelPrecioDIa"
        Me.LabelPrecioDIa.Size = New System.Drawing.Size(74, 13)
        Me.LabelPrecioDIa.TabIndex = 0
        Me.LabelPrecioDIa.Text = "Precio por día"
        '
        'TextPrecioDia
        '
        Me.TextPrecioDia.Location = New System.Drawing.Point(183, 84)
        Me.TextPrecioDia.Name = "TextPrecioDia"
        Me.TextPrecioDia.Size = New System.Drawing.Size(121, 20)
        Me.TextPrecioDia.TabIndex = 1
        '
        'LabelPrecioGarantia
        '
        Me.LabelPrecioGarantia.AutoSize = True
        Me.LabelPrecioGarantia.Location = New System.Drawing.Point(354, 20)
        Me.LabelPrecioGarantia.Name = "LabelPrecioGarantia"
        Me.LabelPrecioGarantia.Size = New System.Drawing.Size(95, 13)
        Me.LabelPrecioGarantia.TabIndex = 0
        Me.LabelPrecioGarantia.Text = "Precio de garantía"
        '
        'TextPrecioGarantia
        '
        Me.TextPrecioGarantia.Location = New System.Drawing.Point(354, 36)
        Me.TextPrecioGarantia.Name = "TextPrecioGarantia"
        Me.TextPrecioGarantia.Size = New System.Drawing.Size(100, 20)
        Me.TextPrecioGarantia.TabIndex = 1
        '
        'TextIDSucursal
        '
        Me.TextIDSucursal.Location = New System.Drawing.Point(33, 36)
        Me.TextIDSucursal.Name = "TextIDSucursal"
        Me.TextIDSucursal.Size = New System.Drawing.Size(100, 20)
        Me.TextIDSucursal.TabIndex = 12
        '
        'LabelNombreSucursal
        '
        Me.LabelNombreSucursal.AutoSize = True
        Me.LabelNombreSucursal.Location = New System.Drawing.Point(30, 68)
        Me.LabelNombreSucursal.Name = "LabelNombreSucursal"
        Me.LabelNombreSucursal.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombreSucursal.TabIndex = 0
        Me.LabelNombreSucursal.Text = "Nombre"
        '
        'TextNombreSucursal
        '
        Me.TextNombreSucursal.Location = New System.Drawing.Point(33, 84)
        Me.TextNombreSucursal.Name = "TextNombreSucursal"
        Me.TextNombreSucursal.Size = New System.Drawing.Size(100, 20)
        Me.TextNombreSucursal.TabIndex = 12
        '
        'LabelSucIDEstado
        '
        Me.LabelSucIDEstado.AutoSize = True
        Me.LabelSucIDEstado.Location = New System.Drawing.Point(197, 20)
        Me.LabelSucIDEstado.Name = "LabelSucIDEstado"
        Me.LabelSucIDEstado.Size = New System.Drawing.Size(40, 13)
        Me.LabelSucIDEstado.TabIndex = 13
        Me.LabelSucIDEstado.Text = "Estado"
        '
        'ComboEstadoSucursal
        '
        Me.ComboEstadoSucursal.FormattingEnabled = True
        Me.ComboEstadoSucursal.Location = New System.Drawing.Point(200, 36)
        Me.ComboEstadoSucursal.Name = "ComboEstadoSucursal"
        Me.ComboEstadoSucursal.Size = New System.Drawing.Size(111, 21)
        Me.ComboEstadoSucursal.TabIndex = 14
        '
        'LabelCiudadSucursal
        '
        Me.LabelCiudadSucursal.AutoSize = True
        Me.LabelCiudadSucursal.Location = New System.Drawing.Point(197, 68)
        Me.LabelCiudadSucursal.Name = "LabelCiudadSucursal"
        Me.LabelCiudadSucursal.Size = New System.Drawing.Size(40, 13)
        Me.LabelCiudadSucursal.TabIndex = 13
        Me.LabelCiudadSucursal.Text = "Ciudad"
        '
        'ComboCiudadSucursal
        '
        Me.ComboCiudadSucursal.FormattingEnabled = True
        Me.ComboCiudadSucursal.Location = New System.Drawing.Point(200, 84)
        Me.ComboCiudadSucursal.Name = "ComboCiudadSucursal"
        Me.ComboCiudadSucursal.Size = New System.Drawing.Size(111, 21)
        Me.ComboCiudadSucursal.TabIndex = 14
        '
        'LabelColSucursal
        '
        Me.LabelColSucursal.AutoSize = True
        Me.LabelColSucursal.Location = New System.Drawing.Point(369, 20)
        Me.LabelColSucursal.Name = "LabelColSucursal"
        Me.LabelColSucursal.Size = New System.Drawing.Size(42, 13)
        Me.LabelColSucursal.TabIndex = 13
        Me.LabelColSucursal.Text = "Colonia"
        '
        'ComboColoniaSucursal
        '
        Me.ComboColoniaSucursal.FormattingEnabled = True
        Me.ComboColoniaSucursal.Location = New System.Drawing.Point(372, 36)
        Me.ComboColoniaSucursal.Name = "ComboColoniaSucursal"
        Me.ComboColoniaSucursal.Size = New System.Drawing.Size(100, 21)
        Me.ComboColoniaSucursal.TabIndex = 14
        '
        'LabelCalleSucursal
        '
        Me.LabelCalleSucursal.AutoSize = True
        Me.LabelCalleSucursal.Location = New System.Drawing.Point(369, 68)
        Me.LabelCalleSucursal.Name = "LabelCalleSucursal"
        Me.LabelCalleSucursal.Size = New System.Drawing.Size(30, 13)
        Me.LabelCalleSucursal.TabIndex = 0
        Me.LabelCalleSucursal.Text = "Calle"
        '
        'TextCalleSucursal
        '
        Me.TextCalleSucursal.Location = New System.Drawing.Point(372, 84)
        Me.TextCalleSucursal.Name = "TextCalleSucursal"
        Me.TextCalleSucursal.Size = New System.Drawing.Size(100, 20)
        Me.TextCalleSucursal.TabIndex = 12
        '
        'DGVSucursal
        '
        Me.DGVSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSucursal.Location = New System.Drawing.Point(3, 110)
        Me.DGVSucursal.Name = "DGVSucursal"
        Me.DGVSucursal.Size = New System.Drawing.Size(664, 244)
        Me.DGVSucursal.TabIndex = 16
        '
        'ComboIDSucursal
        '
        Me.ComboIDSucursal.FormattingEnabled = True
        Me.ComboIDSucursal.Location = New System.Drawing.Point(382, 36)
        Me.ComboIDSucursal.Name = "ComboIDSucursal"
        Me.ComboIDSucursal.Size = New System.Drawing.Size(100, 21)
        Me.ComboIDSucursal.TabIndex = 41
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(3, 110)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(664, 244)
        Me.DataGridView2.TabIndex = 40
        '
        'EliminarEmpleado
        '
        Me.EliminarEmpleado.Location = New System.Drawing.Point(592, 360)
        Me.EliminarEmpleado.Name = "EliminarEmpleado"
        Me.EliminarEmpleado.Size = New System.Drawing.Size(75, 23)
        Me.EliminarEmpleado.TabIndex = 37
        Me.EliminarEmpleado.Text = "Eliminar"
        Me.EliminarEmpleado.UseVisualStyleBackColor = True
        '
        'GuardarEmpleado
        '
        Me.GuardarEmpleado.Location = New System.Drawing.Point(511, 360)
        Me.GuardarEmpleado.Name = "GuardarEmpleado"
        Me.GuardarEmpleado.Size = New System.Drawing.Size(75, 23)
        Me.GuardarEmpleado.TabIndex = 38
        Me.GuardarEmpleado.Text = "Guardar"
        Me.GuardarEmpleado.UseVisualStyleBackColor = True
        '
        'NuevoEmpleado
        '
        Me.NuevoEmpleado.Location = New System.Drawing.Point(430, 360)
        Me.NuevoEmpleado.Name = "NuevoEmpleado"
        Me.NuevoEmpleado.Size = New System.Drawing.Size(75, 23)
        Me.NuevoEmpleado.TabIndex = 39
        Me.NuevoEmpleado.Text = "Nuevo"
        Me.NuevoEmpleado.UseVisualStyleBackColor = True
        '
        'TextCorreoEmpleado
        '
        Me.TextCorreoEmpleado.Location = New System.Drawing.Point(266, 84)
        Me.TextCorreoEmpleado.Name = "TextCorreoEmpleado"
        Me.TextCorreoEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.TextCorreoEmpleado.TabIndex = 35
        '
        'TextApellidoMEmpleado
        '
        Me.TextApellidoMEmpleado.Location = New System.Drawing.Point(151, 84)
        Me.TextApellidoMEmpleado.Name = "TextApellidoMEmpleado"
        Me.TextApellidoMEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.TextApellidoMEmpleado.TabIndex = 33
        '
        'TextTelEmpleado
        '
        Me.TextTelEmpleado.Location = New System.Drawing.Point(266, 37)
        Me.TextTelEmpleado.Name = "TextTelEmpleado"
        Me.TextTelEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.TextTelEmpleado.TabIndex = 36
        '
        'TextApellidoPEmpleado
        '
        Me.TextApellidoPEmpleado.Location = New System.Drawing.Point(151, 37)
        Me.TextApellidoPEmpleado.Name = "TextApellidoPEmpleado"
        Me.TextApellidoPEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.TextApellidoPEmpleado.TabIndex = 30
        '
        'TextNombreEmpleado
        '
        Me.TextNombreEmpleado.Location = New System.Drawing.Point(33, 84)
        Me.TextNombreEmpleado.Name = "TextNombreEmpleado"
        Me.TextNombreEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.TextNombreEmpleado.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(379, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Sucursal"
        '
        'LabelCorreoEmpleado
        '
        Me.LabelCorreoEmpleado.AutoSize = True
        Me.LabelCorreoEmpleado.Location = New System.Drawing.Point(263, 68)
        Me.LabelCorreoEmpleado.Name = "LabelCorreoEmpleado"
        Me.LabelCorreoEmpleado.Size = New System.Drawing.Size(93, 13)
        Me.LabelCorreoEmpleado.TabIndex = 24
        Me.LabelCorreoEmpleado.Text = "Correo electrónico"
        '
        'LabelApellidoMEmpleado
        '
        Me.LabelApellidoMEmpleado.AutoSize = True
        Me.LabelApellidoMEmpleado.Location = New System.Drawing.Point(148, 68)
        Me.LabelApellidoMEmpleado.Name = "LabelApellidoMEmpleado"
        Me.LabelApellidoMEmpleado.Size = New System.Drawing.Size(85, 13)
        Me.LabelApellidoMEmpleado.TabIndex = 23
        Me.LabelApellidoMEmpleado.Text = "Apellido materno"
        '
        'TextUsuarioEmpleado
        '
        Me.TextUsuarioEmpleado.Location = New System.Drawing.Point(33, 37)
        Me.TextUsuarioEmpleado.Name = "TextUsuarioEmpleado"
        Me.TextUsuarioEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.TextUsuarioEmpleado.TabIndex = 28
        '
        'LabelTelEmpleado
        '
        Me.LabelTelEmpleado.AutoSize = True
        Me.LabelTelEmpleado.Location = New System.Drawing.Point(263, 20)
        Me.LabelTelEmpleado.Name = "LabelTelEmpleado"
        Me.LabelTelEmpleado.Size = New System.Drawing.Size(49, 13)
        Me.LabelTelEmpleado.TabIndex = 19
        Me.LabelTelEmpleado.Text = "Teléfono"
        '
        'LabelApellidoPEmpleado
        '
        Me.LabelApellidoPEmpleado.AutoSize = True
        Me.LabelApellidoPEmpleado.Location = New System.Drawing.Point(148, 20)
        Me.LabelApellidoPEmpleado.Name = "LabelApellidoPEmpleado"
        Me.LabelApellidoPEmpleado.Size = New System.Drawing.Size(83, 13)
        Me.LabelApellidoPEmpleado.TabIndex = 18
        Me.LabelApellidoPEmpleado.Text = "Apellido paterno"
        '
        'LabelNombreEmpleado
        '
        Me.LabelNombreEmpleado.AutoSize = True
        Me.LabelNombreEmpleado.Location = New System.Drawing.Point(30, 68)
        Me.LabelNombreEmpleado.Name = "LabelNombreEmpleado"
        Me.LabelNombreEmpleado.Size = New System.Drawing.Size(55, 13)
        Me.LabelNombreEmpleado.TabIndex = 27
        Me.LabelNombreEmpleado.Text = "Nombre(s)"
        '
        'LabelUsuario
        '
        Me.LabelUsuario.AutoSize = True
        Me.LabelUsuario.Location = New System.Drawing.Point(30, 20)
        Me.LabelUsuario.Name = "LabelUsuario"
        Me.LabelUsuario.Size = New System.Drawing.Size(43, 13)
        Me.LabelUsuario.TabIndex = 17
        Me.LabelUsuario.Text = "Usuario"
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(3, 110)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(664, 244)
        Me.DataGridView3.TabIndex = 58
        '
        'EliminarRenta
        '
        Me.EliminarRenta.Location = New System.Drawing.Point(592, 360)
        Me.EliminarRenta.Name = "EliminarRenta"
        Me.EliminarRenta.Size = New System.Drawing.Size(75, 23)
        Me.EliminarRenta.TabIndex = 55
        Me.EliminarRenta.Text = "Eliminar"
        Me.EliminarRenta.UseVisualStyleBackColor = True
        '
        'GuardarRenta
        '
        Me.GuardarRenta.Location = New System.Drawing.Point(511, 360)
        Me.GuardarRenta.Name = "GuardarRenta"
        Me.GuardarRenta.Size = New System.Drawing.Size(75, 23)
        Me.GuardarRenta.TabIndex = 56
        Me.GuardarRenta.Text = "Guardar"
        Me.GuardarRenta.UseVisualStyleBackColor = True
        '
        'NuevaRenta
        '
        Me.NuevaRenta.Location = New System.Drawing.Point(430, 360)
        Me.NuevaRenta.Name = "NuevaRenta"
        Me.NuevaRenta.Size = New System.Drawing.Size(75, 23)
        Me.NuevaRenta.TabIndex = 57
        Me.NuevaRenta.Text = "Nuevo"
        Me.NuevaRenta.UseVisualStyleBackColor = True
        '
        'LabelDiasRenta
        '
        Me.LabelDiasRenta.AutoSize = True
        Me.LabelDiasRenta.Location = New System.Drawing.Point(481, 20)
        Me.LabelDiasRenta.Name = "LabelDiasRenta"
        Me.LabelDiasRenta.Size = New System.Drawing.Size(70, 13)
        Me.LabelDiasRenta.TabIndex = 47
        Me.LabelDiasRenta.Text = "Dias de renta"
        '
        'LabelFechaDevolucion
        '
        Me.LabelFechaDevolucion.AutoSize = True
        Me.LabelFechaDevolucion.Location = New System.Drawing.Point(263, 68)
        Me.LabelFechaDevolucion.Name = "LabelFechaDevolucion"
        Me.LabelFechaDevolucion.Size = New System.Drawing.Size(107, 13)
        Me.LabelFechaDevolucion.TabIndex = 46
        Me.LabelFechaDevolucion.Text = "Fecha de devolución"
        '
        'LabelLicenciaRenta
        '
        Me.LabelLicenciaRenta.AutoSize = True
        Me.LabelLicenciaRenta.Location = New System.Drawing.Point(148, 68)
        Me.LabelLicenciaRenta.Name = "LabelLicenciaRenta"
        Me.LabelLicenciaRenta.Size = New System.Drawing.Size(98, 13)
        Me.LabelLicenciaRenta.TabIndex = 45
        Me.LabelLicenciaRenta.Text = "Licencia del cliente"
        '
        'TextIDRenta
        '
        Me.TextIDRenta.Location = New System.Drawing.Point(33, 37)
        Me.TextIDRenta.Name = "TextIDRenta"
        Me.TextIDRenta.Size = New System.Drawing.Size(100, 20)
        Me.TextIDRenta.TabIndex = 49
        '
        'LabelFechaPRenta
        '
        Me.LabelFechaPRenta.AutoSize = True
        Me.LabelFechaPRenta.Location = New System.Drawing.Point(263, 20)
        Me.LabelFechaPRenta.Name = "LabelFechaPRenta"
        Me.LabelFechaPRenta.Size = New System.Drawing.Size(37, 13)
        Me.LabelFechaPRenta.TabIndex = 44
        Me.LabelFechaPRenta.Text = "Fecha"
        '
        'LabelEmpleadoRenta
        '
        Me.LabelEmpleadoRenta.AutoSize = True
        Me.LabelEmpleadoRenta.Location = New System.Drawing.Point(148, 20)
        Me.LabelEmpleadoRenta.Name = "LabelEmpleadoRenta"
        Me.LabelEmpleadoRenta.Size = New System.Drawing.Size(54, 13)
        Me.LabelEmpleadoRenta.TabIndex = 43
        Me.LabelEmpleadoRenta.Text = "Empleado"
        '
        'LabelPlacaRenta
        '
        Me.LabelPlacaRenta.AutoSize = True
        Me.LabelPlacaRenta.Location = New System.Drawing.Point(30, 68)
        Me.LabelPlacaRenta.Name = "LabelPlacaRenta"
        Me.LabelPlacaRenta.Size = New System.Drawing.Size(34, 13)
        Me.LabelPlacaRenta.TabIndex = 48
        Me.LabelPlacaRenta.Text = "Placa"
        '
        'LabelIDRenta
        '
        Me.LabelIDRenta.AutoSize = True
        Me.LabelIDRenta.Location = New System.Drawing.Point(30, 20)
        Me.LabelIDRenta.Name = "LabelIDRenta"
        Me.LabelIDRenta.Size = New System.Drawing.Size(50, 13)
        Me.LabelIDRenta.TabIndex = 42
        Me.LabelIDRenta.Text = "ID Renta"
        '
        'ComboPlacaRenta
        '
        Me.ComboPlacaRenta.FormattingEnabled = True
        Me.ComboPlacaRenta.Location = New System.Drawing.Point(33, 83)
        Me.ComboPlacaRenta.Name = "ComboPlacaRenta"
        Me.ComboPlacaRenta.Size = New System.Drawing.Size(100, 21)
        Me.ComboPlacaRenta.TabIndex = 60
        '
        'ComboEmpleadoRenta
        '
        Me.ComboEmpleadoRenta.FormattingEnabled = True
        Me.ComboEmpleadoRenta.Location = New System.Drawing.Point(151, 36)
        Me.ComboEmpleadoRenta.Name = "ComboEmpleadoRenta"
        Me.ComboEmpleadoRenta.Size = New System.Drawing.Size(100, 21)
        Me.ComboEmpleadoRenta.TabIndex = 61
        '
        'ComboLicenciaRenta
        '
        Me.ComboLicenciaRenta.FormattingEnabled = True
        Me.ComboLicenciaRenta.Location = New System.Drawing.Point(151, 84)
        Me.ComboLicenciaRenta.Name = "ComboLicenciaRenta"
        Me.ComboLicenciaRenta.Size = New System.Drawing.Size(100, 21)
        Me.ComboLicenciaRenta.TabIndex = 62
        '
        'DateFechaPrestamo
        '
        Me.DateFechaPrestamo.Location = New System.Drawing.Point(266, 37)
        Me.DateFechaPrestamo.Name = "DateFechaPrestamo"
        Me.DateFechaPrestamo.Size = New System.Drawing.Size(200, 20)
        Me.DateFechaPrestamo.TabIndex = 63
        '
        'DateFechaDevolucion
        '
        Me.DateFechaDevolucion.Location = New System.Drawing.Point(266, 84)
        Me.DateFechaDevolucion.Name = "DateFechaDevolucion"
        Me.DateFechaDevolucion.Size = New System.Drawing.Size(200, 20)
        Me.DateFechaDevolucion.TabIndex = 63
        '
        'TextDiasRenta
        '
        Me.TextDiasRenta.Location = New System.Drawing.Point(484, 36)
        Me.TextDiasRenta.Name = "TextDiasRenta"
        Me.TextDiasRenta.Size = New System.Drawing.Size(100, 20)
        Me.TextDiasRenta.TabIndex = 64
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
        Me.TabEmpleados.ResumeLayout(False)
        Me.TabEmpleados.PerformLayout()
        Me.TabRentas.ResumeLayout(False)
        Me.TabRentas.PerformLayout()
        Me.TabLogin.ResumeLayout(False)
        Me.TabLogin.PerformLayout()
        CType(Me.DGVAdmins, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVSucursal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LabelAutoModelo As Label
    Friend WithEvents TextIDColonia As TextBox
    Friend WithEvents LabelIDColonia As Label
    Friend WithEvents ComboColCiudades As ComboBox
    Friend WithEvents ComboColEstados As ComboBox
    Friend WithEvents LabelColCiudad As Label
    Friend WithEvents LabelColEstado As Label
    Friend WithEvents TextNombreColonia As TextBox
    Friend WithEvents LabelNombreColonia As Label
    Friend WithEvents LabelIDSucursal As Label
    Friend WithEvents DataMarcas As DataGridView
    Friend WithEvents DataModelos As DataGridView
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
    Friend WithEvents ComboClienteCiudad As ComboBox
    Friend WithEvents ComboColoniaCLiente As ComboBox
    Friend WithEvents TextCorreoCliente As TextBox
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
    Friend WithEvents TextPrecioDia As TextBox
    Friend WithEvents LabelPrecioDIa As Label
    Friend WithEvents TextPrecioGarantia As TextBox
    Friend WithEvents LabelPrecioGarantia As Label
    Friend WithEvents TextIDSucursal As TextBox
    Friend WithEvents DGVSucursal As DataGridView
    Friend WithEvents ComboCiudadSucursal As ComboBox
    Friend WithEvents ComboColoniaSucursal As ComboBox
    Friend WithEvents ComboEstadoSucursal As ComboBox
    Friend WithEvents LabelColSucursal As Label
    Friend WithEvents LabelCiudadSucursal As Label
    Friend WithEvents LabelSucIDEstado As Label
    Friend WithEvents TextCalleSucursal As TextBox
    Friend WithEvents TextNombreSucursal As TextBox
    Friend WithEvents LabelCalleSucursal As Label
    Friend WithEvents LabelNombreSucursal As Label
    Friend WithEvents ComboIDSucursal As ComboBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents EliminarEmpleado As Button
    Friend WithEvents GuardarEmpleado As Button
    Friend WithEvents NuevoEmpleado As Button
    Friend WithEvents TextCorreoEmpleado As TextBox
    Friend WithEvents TextApellidoMEmpleado As TextBox
    Friend WithEvents TextTelEmpleado As TextBox
    Friend WithEvents TextApellidoPEmpleado As TextBox
    Friend WithEvents TextNombreEmpleado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelCorreoEmpleado As Label
    Friend WithEvents LabelApellidoMEmpleado As Label
    Friend WithEvents TextUsuarioEmpleado As TextBox
    Friend WithEvents LabelTelEmpleado As Label
    Friend WithEvents LabelApellidoPEmpleado As Label
    Friend WithEvents LabelNombreEmpleado As Label
    Friend WithEvents LabelUsuario As Label
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents EliminarRenta As Button
    Friend WithEvents GuardarRenta As Button
    Friend WithEvents NuevaRenta As Button
    Friend WithEvents LabelDiasRenta As Label
    Friend WithEvents LabelFechaDevolucion As Label
    Friend WithEvents LabelLicenciaRenta As Label
    Friend WithEvents TextIDRenta As TextBox
    Friend WithEvents LabelFechaPRenta As Label
    Friend WithEvents LabelEmpleadoRenta As Label
    Friend WithEvents LabelPlacaRenta As Label
    Friend WithEvents LabelIDRenta As Label
    Friend WithEvents ComboPlacaRenta As ComboBox
    Friend WithEvents ComboEmpleadoRenta As ComboBox
    Friend WithEvents ComboLicenciaRenta As ComboBox
    Friend WithEvents DateFechaPrestamo As DateTimePicker
    Friend WithEvents DateFechaDevolucion As DateTimePicker
    Friend WithEvents TextDiasRenta As TextBox
End Class
