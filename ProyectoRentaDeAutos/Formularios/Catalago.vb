Public Class Catalago

    ' Aquí empieza César
    Private Sub TabAutos_Click(sender As Object, e As EventArgs) Handles TabAutos.Click
        ' Instanciar tabla

        ' Set DGV

        cnx.Close()

        ' Mensajes de ayuda
    End Sub

    Private Sub ButtonNuevoAuto_Click(sender As Object, e As EventArgs) Handles ButtonNuevoAuto.Click

    End Sub
    ' Aquí termina César


    ' Aquí empieza Claudia
    Private Sub TabEstados_Click(sender As Object, e As EventArgs) Handles TabEstados.Click
        'Private Sub FrmEstados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Estados As New ClaseEstados

        'Con éste método llenamos el combo de las ciudades del estado seleccionado
        Estados.PoblarDataGridEStados(DGVestados)

        'Para cerrar la BD, la variable que tiene el nombre de la BD y el usuario con la palabra CLOSE
        cnx.Close()



    End Sub

    'Botón para limpiar el contenido de las cajas de texto
    Private Sub NuevoEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoEstado.Click

        TextIDEst.Text = vbNullString
        TextNombreEstado.Text = ""

        'Para poner o madar el cursor a una caja de textos
        TextIDEst.Focus()
    End Sub

    Private Sub DGVestados_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVestados.CellContentClick

        'Con éste código podemos seleccionar los datos que están mostrados
        'en un DGV, la variable renglón no sirve para saber en qué renglón se da clic

        Dim renglon As Integer

        renglon = DGVestados.CurrentCellAddress.Y

        'Al darle clic al renglón mostramos los datos en las cajas de texto
        'DGVcolonias.Rows(renglon) nos dice cual renglón se ha dado clic
        'Cells(0).Value recupera el DATO de la celda o columna del DGV y lo 
        'dejamos en la caja de texto correspondiente

        TextIDEst.Text = DGVestados.Rows(renglon).Cells(0).Value
        TextNombreEstado.Text = DGVestados.Rows(renglon).Cells(1).Value

    End Sub

    'Botón de guardar, para agregar un nuevo registro a nuestra base de datos
    Private Sub GuardarEstado_Click(sender As Object, e As EventArgs) Handles GuardarEstado.Click

        'Cuando se quiere registrar la información, validamos que se haya capturado texto en las cajas de texto

        If TextIDEst.Text = "" Then
            MessageBox.Show("Capturar clave para el estado !!")
        ElseIf TextNombreEstado.Text = "" Then
            MessageBox.Show("Capturar nombre del estado !!")
        Else
            'instanciamos la clase y le pasamos como parámetros los tres datos

            Dim Estados As New ClaseEstados(TextIDEst.Text, TextNombreEstado.Text)

            Estados.getSetid_estado = TextIDEst.Text
            Estados.getSetnombre = TextNombreEstado.Text

            'En el siguiente IF, usamos un método para verificar si el estado está registrado

            If Estados.consultaUnEstado() = False Then
                'Si la ciudad NO está registrada, la inserta como una nueva
                Estados.insertaEstado() 'INSERTA NUEVO ESTADO

                'Con ésta función mandamos una ventana de notificación al usuario final
                MessageBox.Show("Estado Registrado ...")
            Else

                'Si el estado se encuentra registrado, se modifica la información
                Estados.actualizaEstado() 'ACTUALIZA EL ESTADO

                'Con ésta función mandamos una ventana de notificación al usuario final
                MsgBox("Estado modificado ...")
            End If

            'Una vez realizada la accion del Insert o Update, debemos de presentar
            'la información de nueva cuenta en el DGV correspondiente

            Estados.PoblarDataGridEStados(DGVestados)
        End If

    End Sub

    Private Sub EliminarEstado_Click(sender As Object, e As EventArgs) Handles EliminarEstado.Click
        'Validamos que esa ciudad no tenga colonias dadas de alta, es decir que no tenga hijos.

        Dim Estados As New ClaseEstados(TextIDEst.Text, TextNombreEstado.Text)

        'Con el método validaCiudadess, verificamos que el estado que se quiere eliminar NO tenga ciudades

        If Estados.validaCiudades() = True Then
            MsgBox("No se puede dar de baja el estado seleccionado, tiene ciudades registradas...")
        Else
            'If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            'Llamamos al método que elimina el registro del estado
            Estados.eliminaEstado()
            MessageBox.Show("Registro Eliminado")

            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
            Estados.PoblarDataGridEStados(DGVestados)
        End If
        ' End If
        ' Si borro algo se quita el texto de las cajas de texto
        TextIDEst.Text = vbNullString
        TextNombreEstado.Text = ""
    End Sub

    Private Sub TxtIdEstado_TextChanged(sender As Object, e As EventArgs) Handles TextIDEst.TextChanged
        If TextIDEst.Text <> "" Then
            'Busca  un estado en particular
            Dim Estados As New ClaseEstados
            'Llamamos al método que elimina el registro
            Estados.consultaUnEstado()
        End If
    End Sub


    ' Aquí termina Claudia


    ' Aquí empieza Brayan

    ' Aquí termina Brayian


    ' Aquí empieza Horacio

    ' Aquí termina Horacio
End Class