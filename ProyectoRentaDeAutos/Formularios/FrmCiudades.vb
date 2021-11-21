Public Class FrmCiudades
    Private Sub FrmCiudades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Ciudades As New ClaseCiudades

        'Poblamos el DGV de los estados, la clase colonias tiene un método llamado poblarComboEstados
        'y para que sepa que combo queremos llenar con datos le pasamos como parámetro el nombre del combo
        Ciudades.poblarComboEstados(CmbEstado)

        'Para cerrar la BD, la variable que tiene el nombre de la BD y el usuario con la palabra CLOSE
        cnx.Close()

        'Definimos mensaje de ayuda en los botones con toolTips
        Me.ToolTip1.SetToolTip(Me.BtnLimpia, "Clic para limpiar cajas de texto ...")
        Me.ToolTip1.SetToolTip(Me.BtnGuardar, "Clic para Guardar información en el sistema...")
        Me.ToolTip1.SetToolTip(Me.BtnEliminar, "Clic para Eliminar información en el sistema...")
    End Sub

    'Botón para limpiar el contenido de las cajas de texto
    Private Sub BtnLimpia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpia.Click

        TxtIdCiudad.Text = vbNullString
        TxtNomCiudad.Text = ""

        'Para poner o madar el cursor a una caja de textos
        TxtIdCiudad.Focus()
    End Sub

    Private Sub DGVestados_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVciudades.CellContentClick

        'Con éste código podemos seleccionar los datos que están mostrados
        'en un DGV, la variable renglón no sirve para saber en qué renglón se da clic

        Dim renglon As Integer

        renglon = DGVciudades.CurrentCellAddress.Y

        'Al darle clic al renglón mostramos los datos en las cajas de texto
        'DGVciudades.Rows(renglon) nos dice cual renglón se ha dado clic
        'Cells(0).Value recupera el DATO de la celda o columna del DGV y lo 
        'dejamos en la caja de texto correspondiente

        TxtIdCiudad.Text = DGVciudades.Rows(renglon).Cells(0).Value
        TxtNomCiudad.Text = DGVciudades.Rows(renglon).Cells(1).Value

    End Sub

    'Botón de guardar, para agregar un nuevo registro a nuestra base de datos
    Private Sub BtnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles BtnGuardar.Click

        'Cuando se quiere registrar la información, validamos que se haya capturado texto en las cajas de texto

        If TxtIdCiudad.Text = "" Then
            MessageBox.Show("Capturar clave para la ciudad !!")
        ElseIf TxtNomCiudad.Text = "" Then
            MessageBox.Show("Capturar nombre de la ciudad !!")
        Else
            'instanciamos la clase y le pasamos como parámetros los tres datos

            Dim Ciudades As New ClaseCiudades(miEstado, TxtIdCiudad.Text, TxtNomCiudad.Text)

            Ciudades.getSetid_ciudad = TxtIdCiudad.Text
            Ciudades.getSetnombre = TxtNomCiudad.Text

            'En el siguiente IF, usamos un método para verificar si la ciudad está registrada
            ' en ese estado

            If Ciudades.consultaUnaCiudad() = False Then
                'Si la ciudad NO está registrada, la inserta como una nueva
                Ciudades.insertaCiudad() 'INSERTA NUEVA CIUDAD

                'Con ésta función mandamos una ventana de notificación al usuario final
                MessageBox.Show("Ciudad Registrada ...")
            Else

                'Si la colonia se encuentra registrada, se modifica la información
                Ciudades.actualizaCiudad() 'ACTUALIZA LA CIUDAD

                'Con ésta función mandamos una ventana de notificación al usuario final
                MsgBox("Ciudad modificada ...")
            End If

            'Una vez realizada la accion del Insert o Update, debemos de presentar
            'la información de nueva cuenta en el DGV correspondiente

            Ciudades.PoblarDataGridCiudades(DGVciudades)
        End If

    End Sub

    Private Sub BtnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles BtnEliminar.Click
        'Validamos que esa ciudad no tenga colonias dadas de alta, es decir que no tenga hijos.

        Dim Ciudades As New ClaseCiudades(miEstado, TxtIdCiudad.Text, TxtNomCiudad.Text)

        'Con el método validaColonias, verificamos que la ciudad que se quiere eliminar NO tenga colonias

        If Ciudades.validaColonias() = True Then
            MsgBox("No se puede dar de baja la ciudad seleccionada, tiene colonias registradas...")
        Else
            'If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            'Llamamos al método que elimina el registro de la ciudad
            Ciudades.eliminaCiudad()
                MessageBox.Show("Registro Eliminado")

                'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                Ciudades.PoblarDataGridCiudades(DGVciudades)
            End If
        ' End If
        ' Si borro algo se quita el texto de las cajas de texto
        TxtIdCiudad.Text = vbNullString
        TxtNomCiudad.Text = ""
    End Sub

    Private Sub TxtIdCiudad_TextChanged(sender As Object, e As EventArgs) Handles TxtIdCiudad.TextChanged
        If TxtIdCiudad.Text <> "" Then
            'Busca  una ciudad en particular
            Dim Ciudades As New ClaseCiudades
            'Llamamos al método que elimina el registro
            Ciudades.consultaUnaCiudad()
        End If
    End Sub

    Private Sub CmbEstado_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CmbEstado.SelectedIndexChanged
        Dim Ciudades As New ClaseCiudades(CmbEstado.Text, TxtIdCiudad.Text, TxtNomCiudad.Text)


        If (TxtIdCiudad.Text) <> "" Then
            Ciudades.getSetid_ciudad = TxtIdCiudad.Text
            Ciudades.getSetnombre = TxtNomCiudad.Text
        End If
        'Con éste método obtenemos el ID del estado
        Ciudades.consultaIdEstado()

        'Con éste método llenamos el combo de las ciudades del estado seleccionado
        Ciudades.PoblarDataGridCiudades(DGVciudades)
    End Sub

    'Botón para salir de ese formulario y cerrarlo
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class