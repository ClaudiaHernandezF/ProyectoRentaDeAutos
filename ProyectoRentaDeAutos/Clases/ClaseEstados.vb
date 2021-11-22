
Imports Oracle.DataAccess.Client

    Public Class ClaseEstados
        Private nombre As String

        'Método constructor inicializa variables
        Public Sub New()
            id_estado = ""
            nombre = ""
        End Sub

        'Metodo constructor con valores proporcionados al instanciar el objeto
        Public Sub New(ByVal idEdo As String, ByVal nuevoNombre As String)
            'Aquí recibimos los datos
            id_estado = idEdo
            nombre = nuevoNombre
        End Sub

        'Metodos get y set
        Public Property getSetid_estado() As Integer
            Get
                Return id_estado
            End Get
            Set(ByVal Value As Integer)
                id_estado = Value
            End Set
        End Property

        Public Property getSetnombre() As String
            Get
                Return nombre
            End Get
            Set(ByVal Value As String)
                nombre = Value
            End Set
        End Property

        'Inserta nuevo estado en la tabla correspondiente
        'la tabla tiene 2 atributos, por lo tanto se requieren de 2 valores
        Public Sub insertaEstado()
            Dim strSql As String
            Dim xCnx As New Oracle

            'Con el IF validamos que no falten datos y que sean del tipo de dato requerido

            If id_estado <> 0 And nombre <> "" Then

                'Realiza inserción de datos con un query
                strSql = "INSERT INTO Estados VALUES(" & id_estado & ", '" & nombre & "')"
                xCnx.objetoCommand(strSql)
            Else
                'Notificamos al usuario final por medio de un mensaje en caso que falten datos
                MsgBox("Faltan datos para el estado seleccionado, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
            End If
        End Sub

        'Actualiza datos de un estado específico
        Public Sub actualizaEstado()
            Dim strSql As String
            Dim xCnx As New Oracle
            If id_estado <> 0 And nombre <> "" Then

                'query de la actualización
                strSql = "UPDATE Estados set nombreEstado='" & nombre &
                     "' WHERE idEstado =" & id_estado
                xCnx.objetoCommand(strSql)
            Else
                MsgBox("Faltan datos para el estado !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
            End If
        End Sub

        'Consulta un estado específico
        Public Function consultaUnEstado() As Boolean
            Dim strSQL As String
            Dim xCnx As New Oracle
            Dim xDT As DataTable

        'query de consulta de ciudades de un estado ya seleccionadas previamente.
        strSQL = "SELECT idEstado, nombreEstado FROM Estados WHERE idEstado =" & Catalago.TextIDEst.Text

        consultaUnEstado = False
            xDT = xCnx.objetoDataAdapter(strSQL)
            If xDT.Rows.Count = 1 Then
                If IsDBNull(xDT.Rows(0)("idEstado")) Then
                    id_estado = 0
                Else
                    id_estado = CStr(xDT.Rows(0)("idEstado"))
                Catalago.TextNombreEstado.Text = CStr(xDT.Rows(0)("nombreEstado"))
            End If


                consultaUnEstado = True
            End If
        End Function

        'Consulta datos de todos los estados registrados
        Public Function consultaTodosEstados() As Object
            Dim strSQL As String
            Dim xCnx As New Oracle

            strSQL = "Select idEstado As ID, Estados.nombreEstado As Estados " &
                 " FROM Estados " &
                       " ORDER BY Estados.nombreEstado asc"
            consultaTodosEstados = xCnx.objetoDataAdapter(strSQL)
        End Function

        'Método que lee todas las colonias del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV
        Public Sub PoblarDataGridEStados(ByVal DGVestados As DataGridView)

            DGVestados.DataSource = consultaTodosEstados()

            'Con el refresh actualiza el contenido del DGV
            DGVestados.Refresh()

            'Establecer ancho de cada columna del DataGridView
            DGVestados.Columns.Item(0).Width = 200
            DGVestados.Columns.Item(1).Width = 900
        End Sub

        'Verificamos si los estados tienen ciudades
        Public Function validaCiudades() As Boolean
            Dim strSQL As String
            Dim xCnx As New Oracle
            Dim xDT As DataTable

        strSQL = "Select * FROM Ciudades " &
               " WHERE idEstado = " & Catalago.TextIDEst.Text
        validaCiudades = False
            xDT = xCnx.objetoDataAdapter(strSQL)

            If xDT.Rows.Count >= 1 Then
                If IsDBNull(xDT.Rows(0)("idEstado")) Then
                    id_estado = 0
                Else
                    miEstado = CStr(xDT.Rows(0)("idEstado"))
                End If
                validaCiudades = True
            End If
        End Function

        'Eliminar un estado
        Public Sub eliminaEstado()
            Dim strSql As String
            Dim xCnx As New Oracle

            If id_estado <> 0 And nombre <> "" Then
            strSql = "DELETE FROM Estados " &
                     " where idEstado = " & Catalago.TextIDEst.Text
            xCnx.objetoCommand(strSql)
            Else
                'En caso que falten datos del estado, envía un mensaje
                MsgBox("Faltan datos del estado !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
            End If
        End Sub
    End Class


