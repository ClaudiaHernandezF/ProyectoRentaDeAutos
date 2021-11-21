Imports Oracle.DataAccess.Client
Public Class ClaseColonias
    Private nombre As String

    'Método constructor inicializa variables
    Public Sub New()
        id_estado = ""
        id_ciudad = ""
        id_colonia = ""
        nombre = ""
    End Sub

    'Metodo constructor con valores proporcionados al instanciar el objeto
    Public Sub New(ByVal idEdo As String, ByVal idCd As String, ByVal idCol As String, ByVal nuevoNombre As String)
        'Aquí recibimos los datos
        id_estado = idEdo
        id_ciudad = idCd
        id_colonia = idCol
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

    Public Property getSetid_ciudad() As Integer
        Get
            Return id_ciudad
        End Get
        Set(ByVal Value As Integer)
            id_ciudad = Value
        End Set
    End Property

    Public Property getSetid_colonia() As Integer
        Get
            Return id_colonia
        End Get
        Set(ByVal Value As Integer)
            id_colonia = Value
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

    'Inserta nueva colonia en la tabla correspondiente
    'la tabla tiene 4 atributos, por lo tanto se requieren de 4 valores
    Public Sub insertaCol()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido

        If id_estado <> 0 And id_ciudad <> 0 And id_colonia <> 0 And nombre <> "" Then

            'Realiza inserción de datos con un query
            strSql = "INSERT INTO Colonias VALUES(" & id_estado & ", " & id_ciudad & ", " & id_colonia & ", '" & nombre & "')"
            xCnx.objetoCommand(strSql)
        Else
            'Notificamos al usuario final por medio de un mensaje en caso que falten datos
            MsgBox("Faltan datos para la colonia de la ciudad seleccionada, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'Actualiza datos de una colonia específica
    Public Sub actualizaCol()
        Dim strSql As String
        Dim xCnx As New Oracle
        If id_estado <> 0 And id_ciudad And id_colonia <> 0 And nombre <> "" Then

            'query de la actualización
            strSql = "UPDATE Colonias set nombreColonia='" & nombre &
                     "' WHERE idEstado =" & id_estado &
                     " AND idCiudad =" & id_ciudad &
                     " and idColonia=" & id_colonia
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos para la colonia !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'Utilizada para obtener el ID del estado seleccionado, haciendo la búsqueda con el nombre del estado
    Public Function consultaIdEstado() As Boolean

        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'query de la consulta en la tabla Estados
        strSQL = "SELECT idEstado FROM Estados " &
                 "WHERE nombreEstado='" & FrmColonias.CmbEstado.Text & "'"
        consultaIdEstado = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("idEstado")) Then
                id_estado = ""
            Else
                id_estado = CStr(xDT.Rows(0)("idEstado"))
                miEstado = id_estado
            End If
            consultaIdEstado = True
        End If
    End Function

    'Busca el ID de la ciudad del estado que previamente se ha seleccionado. No puedo buscar ciudades sin antes
    'seleccionar el estado.
    Public Function consultaIdCiudad() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT idCiudad FROM Ciudades " &
                 "WHERE idEstado =" & miEstado & " and nombreCiudad ='" & FrmColonias.CmbCiudad.Text & "'"

        consultaIdCiudad = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("idCiudad")) Then
                miCiudad = ""
            Else
                miCiudad = CStr(xDT.Rows(0)("idCiudad"))
            End If
            consultaIdCiudad = True
        End If
    End Function

    'Consulta una colonia específica
    Public Function consultaUnaCol() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'query de consulta de colonias de un estado y ciudad ya seleccionadas previamente.
        strSQL = "SELECT Colonias.idEstado, Colonias.idCiudad, Colonias.idColonia, Colonias.nombreColonia " &
                 " FROM Estados, Ciudades, Colonias " &
                 "WHERE Estados.idEstado =Ciudades.idEstado and " &
                      " Ciudades.idEstado=Colonias.idEstado and " &
                      " Ciudades.idCiudad=Colonias.idCiudad and " &
                      " Colonias.idColonia =" & FrmColonias.TxtIdCol.Text &
                      " and Ciudades.nombreCiudad ='" & FrmColonias.CmbCiudad.Text &
                      "' and Estados.nombreEstado ='" & FrmColonias.CmbEstado.Text & "'"
        consultaUnaCol = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("idColonia")) Then
                id_colonia = 0
            Else
                id_colonia = CStr(xDT.Rows(0)("idColonia"))
                FrmColonias.TxtNomCol.Text = CStr(xDT.Rows(0)("nombreColonia"))
            End If


            consultaUnaCol = True
        End If
    End Function

    'Consulta datos de todas las colonias registradas en la ciudad y estado seleccionado
    'para llenar el DGV correspondiente, así solo se le muestran al usuario final las
    'colonias de la ciudad y estado que se ha seleccionado 
    Public Function consultaTodasColonias() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        strSQL = "SELECT idColonia as ID, Colonias.nombreColonia as Colonias " &
                 " FROM Estados, Ciudades, Colonias " &
                 "WHERE Estados.idEstado =Ciudades.idEstado and " &
                      " Ciudades.idEstado=Colonias.idEstado and " &
                      " Ciudades.idCiudad=Colonias.idCiudad and " &
                       " Estados.nombreEstado = '" & FrmColonias.CmbEstado.Text & "' and " &
                       " Ciudades.nombreCiudad = '" & FrmColonias.CmbCiudad.Text & "'" &
                       " ORDER BY Colonias.nombreColonia asc"
        consultaTodasColonias = xCnx.objetoDataAdapter(strSQL)
    End Function

    'Método que lee todas las colonias del origen de datos y
    'da dimensión a las columnas y cuantas columnas tendrá el DGV
    Public Sub PoblarDataGridCol(ByVal DGVcolonias As DataGridView)

        DGVcolonias.DataSource = consultaTodasColonias()

        'Con el refresh actualiza el contenido del DGV
        DGVcolonias.Refresh()

        'Establecer ancho de cada columna del DataGridView
        DGVcolonias.Columns.Item(0).Width = 200
        DGVcolonias.Columns.Item(1).Width = 900
    End Sub

    'Llenar el comboBox de Estados
    Public Sub poblarComboEstados(ByVal objeto As ComboBox)
        Dim Lista As OracleDataReader
        Dim strSql As String
        Dim xCnx As New Oracle

        strSql = "SELECT nombreEstado FROM Estados Order By nombreEstado asc"
        Lista = xCnx.objetoDataReader(strSql)

        'Limpia el contenido del combo, para ser rellendo
        objeto.Items.Clear()

        'Con el while le coloca los renglones encontrados al combo
        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
    End Sub

    'Llenar el comboBox de Ciudades
    Public Sub poblarComboCiudades(ByVal objeto As ComboBox)
        Dim Lista As OracleDataReader
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con éste query llenamos el combo con los datos de las ciudades del estado que tenemos selecionado
        strSql = "SELECT Ciudades.nombreCiudad " &
                 " FROM Estados, Ciudades " &
                 " WHERE Estados.idEstado = Ciudades.idEstado and " &
                 "      Estados.nombreEstado = '" & FrmColonias.CmbEstado.Text & "' Order By Ciudades.nombreCiudad asc"
        Lista = xCnx.objetoDataReader(strSql)
        objeto.Items.Clear()
        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
    End Sub

    'Eliminar una colonia
    Public Sub eliminaColonia()
        Dim strSql As String
        Dim xCnx As New Oracle

        If id_estado <> 0 And id_ciudad <> 0 And nombre <> "" Then
            strSql = "DELETE FROM Colonias " &
                     " where idEstado = " & miEstado &
                     " AND idCiudad=" & miCiudad &
                     " AND idColonia=" & FrmColonias.TxtIdCol.Text
            xCnx.objetoCommand(strSql)
        Else
            'En caso que falten datos de la colonia, envía un mensaje
            MsgBox("Faltan datos de la colonia !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub
End Class
