Imports Oracle.DataAccess.Client

Public Class ClaseCiudades
    Private nombre As String

    'Método constructor inicializa variables
    Public Sub New()
        id_estado = ""
        id_ciudad = ""
        nombre = ""
    End Sub

    'Metodo constructor con valores proporcionados al instanciar el objeto
    Public Sub New(ByVal idEdo As String, ByVal idCd As String, ByVal nuevoNombre As String)
        'Aquí recibimos los datos
        id_estado = idEdo
        id_ciudad = idCd
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

    Public Property getSetnombre() As String
        Get
            Return nombre
        End Get
        Set(ByVal Value As String)
            nombre = Value
        End Set
    End Property

    'Inserta nueva ciudad en la tabla correspondiente
    'la tabla tiene 3 atributos, por lo tanto se requieren de 3 valores
    Public Sub insertaCiudad()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido

        If id_estado <> 0 And id_ciudad <> 0 And nombre <> "" Then

            'Realiza inserción de datos con un query
            strSql = "INSERT INTO Ciudades VALUES(" & id_estado & ", " & id_ciudad & ", '" & nombre & "')"
            xCnx.objetoCommand(strSql)
        Else
            'Notificamos al usuario final por medio de un mensaje en caso que falten datos
            MsgBox("Faltan datos para la ciudad del estado seleccionado, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'Actualiza datos de una ciudad específica
    Public Sub actualizaCiudad()
        Dim strSql As String
        Dim xCnx As New Oracle
        If id_estado <> 0 And id_ciudad And nombre <> "" Then

            'query de la actualización
            strSql = "UPDATE Ciudades set nombreCiudad='" & nombre &
                     "' WHERE idEstado =" & id_estado &
                     " AND idCiudad =" & id_ciudad
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos para la ciudad !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    'Utilizada para obtener el ID del estado seleccionado, haciendo la búsqueda con el nombre del estado
    Public Function consultaIdEstado() As Boolean

        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'query de la consulta en la tabla Estados
        strSQL = "SELECT idEstado FROM Estados " &
                 "WHERE nombreEstado='" & FrmCiudades.CmbEstado.Text & "'"
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

    'Consulta una ciudad específica
    Public Function consultaUnaCiudad() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'query de consulta de ciudades de un estado ya seleccionadas previamente.
        strSQL = "SELECT Ciudades.idEstado, Ciudades.idCiudad, Ciudades.nombreCiudad " &
                 " FROM Estados, Ciudades " &
                 "WHERE Estados.idEstado =Ciudades.idEstado and " &
                      " Ciudades.idCiudad =" & FrmCiudades.TxtIdCiudad.Text &
                      " and Estados.nombreEstado ='" & FrmCiudades.CmbEstado.Text & "'"
        consultaUnaCiudad = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("idCiudad")) Then
                id_ciudad = 0
            Else
                id_ciudad = CStr(xDT.Rows(0)("idCiudad"))
                FrmCiudades.TxtNomCiudad.Text = CStr(xDT.Rows(0)("nombreCiudad"))
            End If


            consultaUnaCiudad = True
        End If
    End Function

    'Consulta datos de todas las ciudades registradas en el estado seleccionado
    'para llenar el DGV correspondiente, así solo se le muestran al usuario final las
    'ciudades del estado que se ha seleccionado 
    Public Function consultaTodasCiudades() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        strSQL = "Select idCiudad As ID, Ciudades.nombreCiudad As Ciudades " &
                 " FROM Estados, Ciudades " &
                 "WHERE Estados.idEstado =Ciudades.idEstado And " &
                       " Estados.nombreEstado = '" & FrmCiudades.CmbEstado.Text & "'" &
                       " ORDER BY Ciudades.nombreCiudad asc"
        consultaTodasCiudades = xCnx.objetoDataAdapter(strSQL)
    End Function

    'Método que lee todas las colonias del origen de datos y
    'da dimensión a las columnas y cuantas columnas tendrá el DGV
    Public Sub PoblarDataGridCiudades(ByVal DGVciudades As DataGridView)

        DGVciudades.DataSource = consultaTodasCiudades()

        'Con el refresh actualiza el contenido del DGV
        DGVciudades.Refresh()

        'Establecer ancho de cada columna del DataGridView
        DGVciudades.Columns.Item(0).Width = 200
        DGVciudades.Columns.Item(1).Width = 900
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

    Public Function validaColonias() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT * FROM Colonias " &
               " WHERE idEstado = " & miEstado &
               " AND idCiudad = " & FrmCiudades.TxtIdCiudad.Text
        validaColonias = False
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count >= 1 Then
            If IsDBNull(xDT.Rows(0)("idEstado")) Then
                id_estado = 0
            Else
                miEstado = CStr(xDT.Rows(0)("idEstado"))
            End If
            validaColonias = True
        End If
    End Function

    'Eliminar una ciudad
    Public Sub eliminaCiudad()
        Dim strSql As String
        Dim xCnx As New Oracle

        If id_estado <> 0 And id_ciudad <> 0 And nombre <> "" Then
            strSql = "DELETE FROM Ciudades " &
                     " where idEstado = " & miEstado &
                     " AND idCiudad=" & FrmCiudades.TxtIdCiudad.Text
            xCnx.objetoCommand(strSql)
        Else
            'En caso que falten datos de la colonia, envía un mensaje
            MsgBox("Faltan datos de la ciudad !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub
End Class
