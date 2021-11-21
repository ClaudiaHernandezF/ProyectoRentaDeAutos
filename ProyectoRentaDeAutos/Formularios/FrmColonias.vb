Public Class FrmColonias
    Private Sub FrmDirecciones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim Colonias As New ClaseColonias

        'Poblamos el DGV de los estados, la clase colonias tiene un método llamado poblarComboEstados
        'y para que sepa que combo queremos llenar con datos le pasamos como parámetro el nombre del combo
        Colonias.poblarComboEstados(CmbEstado)

        'Para cerrar la BD, la variable que tiene el nombre de la BD y el usuario con la palabra CLOSE
        cnx.Close()

        'Definimos mensaje de ayuda en los botones con toolTips
        Me.ToolTip1.SetToolTip(Me.BtnLimpia, "Clic para limpiar cajas de texto ...")
        Me.ToolTip1.SetToolTip(Me.BtnGuardar, "Clic para Guardar información en el sistema...")
        Me.ToolTip1.SetToolTip(Me.BtnEliminar, "Clic para Eliminar información en el sistema...")
    End Sub

    'Botón para limpiar el contenido de las cajas de texto
    Private Sub BtnLimpia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpia.Click

        TxtIdCol.Text = vbNullString
        TxtNomCol.Text = ""

        'Para poner o madar el cursor a una caja de textos
        TxtIdCol.Focus()
    End Sub

    Private Sub DGVciudades_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVcolonias.CellContentClick

        'Con éste código podemos seleccionar los datos que están mostrados
        'en un DGV, la variable renglón no sirve para saber en qué renglón se da clic

        Dim renglon As Integer

        renglon = DGVcolonias.CurrentCellAddress.Y

        'Al darle clic al renglón mostramos los datos en las cajas de texto
        'DGVcolonias.Rows(renglon) nos dice cual renglón se ha dado clic
        'Cells(0).Value recupera el DATO de la celda o columna del DGV y lo 
        'dejamos en la caja de texto correspondiente

        TxtIdCol.Text = DGVcolonias.Rows(renglon).Cells(0).Value
        TxtNomCol.Text = DGVcolonias.Rows(renglon).Cells(1).Value

    End Sub

    'Botón de guardar, para agregar un nuevo registro a nuestra base de datos
    Private Sub BtnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles BtnGuardar.Click

        'Cuando se quiere registrar la información, validamos que se haya capturado texto en las cajas de texto

        If TxtIdCol.Text = "" Then
            MessageBox.Show("Capturar clave para la colonia !!")
        ElseIf TxtNomCol.Text = "" Then
            MessageBox.Show("Capturar nombre de la colonia !!")
        Else
            'instanciamos la clase y le pasamos como parámetros los cuatro datos

            Dim Colonias As New ClaseColonias(miEstado, miCiudad, TxtIdCol.Text, TxtNomCol.Text)

            Colonias.getSetid_colonia = TxtIdCol.Text
            Colonias.getSetnombre = TxtNomCol.Text

            'En el siguiente IF, usamos un método para verificar si la colonia está registrada
            ' en esa ciudad de ese estado

            If Colonias.consultaUnaCol() = False Then
                'Si la colonia NO está registrada, la inserta como una nueva
                Colonias.insertaCol() 'INSERTA NUEVA COLONIA

                'Con ésta función mandamos una ventana de notificación al usuario final
                MessageBox.Show("Colonia Registrada ...")
            Else

                'Si la colonia se encuentra registrada, se modifica la información
                Colonias.actualizaCol() 'ACTUALIZA LA COLONIA

                'Con ésta función mandamos una ventana de notificación al usuario final
                MsgBox("Colonia modificada ...")
            End If

            'Una vez realizada la accion del Insert o Update, debemos de presentar
            'la información de nueva cuenta en el DGV correspondiente

            Colonias.PoblarDataGridCol(DGVcolonias)
        End If

    End Sub
    ' //////////////// NOOOOOOOOOOO
    Private Sub BtnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles BtnEliminar.Click
        'Validamos que esa ciudad no tenga colonias dadas de alta, es decir que no tenga hijos.
        'Si tu BD tiene las reglas de integridad referencial, el DBMS hará la validación, pero
        'hay que controlar esa validación y mandar un mensaje apropiado al usuario final

        Dim Colonias As New ClaseColonias(miEstado, miCiudad, TxtIdCol.Text, TxtNomCol.Text)

        'Con el método validaColonias, verificamos que la ciudad que se quiere eliminar NO tenga colonias

        ' If Colonias.validaColonias() = True Then
        ' MsgBox("No se puede dar de baja la colonia seleccionada, tiene calles registradas...")
        ' Else
        'If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

        'Llamamos al método que elimina el registro de la ciudad
        Colonias.eliminaColonia()
            MessageBox.Show("Registro Eliminado")

            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
            Colonias.PoblarDataGridCol(DGVcolonias)
        'End If
        '  End If
    End Sub

    Private Sub TxtIdCol_TextChanged(sender As Object, e As EventArgs) Handles TxtIdCol.TextChanged
        If TxtIdCol.Text <> "" Then
            'Busca  una colonia en particular
            Dim Colonias As New ClaseColonias
            'Llamamos al método que elimina el registro
            Colonias.consultaUnaCol()
        End If
    End Sub

    Private Sub CmbEstado_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CmbEstado.SelectedIndexChanged
        Dim Colonias As New ClaseColonias(CmbEstado.Text, CmbCiudad.Text, TxtIdCol.Text, TxtNomCol.Text)


        If (TxtIdCol.Text) <> "" Then
            Colonias.getSetid_colonia = TxtIdCol.Text
            Colonias.getSetnombre = TxtNomCol.Text
        End If
        'Con éste método obtenemos el ID del estado
        Colonias.consultaIdEstado()

        'Con éste método llenamos el combo de las ciudades del estado seleccionado
        Colonias.poblarComboCiudades(CmbCiudad)
    End Sub

    Private Sub CmbCiudad_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CmbCiudad.SelectedIndexChanged
        Dim Colonias As New ClaseColonias
        Colonias.consultaIdCiudad()
        Colonias.PoblarDataGridCol(DGVcolonias)
    End Sub

    'Botón para salir de ese formulario y cerrarlo
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class