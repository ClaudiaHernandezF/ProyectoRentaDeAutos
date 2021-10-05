
'Todo lo que veas en color verde son comentarios

Imports Oracle.DataAccess.Client

Public Class ClaseLogin

    'Private nombre As String

    'Método constructor inicializa variables
    Public Sub New()
        'Si tus variables son de otro tipo (numeric,Integer, etc) tendrías que iniciarlas en 0
        idLogin = "0"
        usuario = ""
        contrasena = ""
    End Sub


    'Metodo constructor con valores proporcionados al instanciar el objeto
    Public Sub New(ByVal elIdLogin As Integer, ByVal elUsuario As String, ByVal laContraseña As String)
        'Aquí recibimos los datos
        idLogin = elIdLogin
        usuario = elUsuario
        contrasena = laContraseña
    End Sub

    'Metodos get y set
    Public Property getSetIdLogin() As Integer
        Get
            Return idLogin
        End Get
        Set(ByVal Value As Integer)
            idLogin = Value
        End Set
    End Property

    Public Property getSetUsuario() As String
        Get
            Return usuario
        End Get
        Set(ByVal Value As String)
            usuario = Value
        End Set
    End Property

    Public Property getSetContrasena() As String
        Get
            Return contrasena
        End Get
        Set(ByVal Value As String)
            contrasena = Value
        End Set
    End Property

    Public Function consultaUsuario() As Boolean

        ' Utilizada para obtener el ID del país seleccionado, ejemplo para cuando
        ' requieran obtener un ID de alguna tabla de un registro ya existente, 
        ' la búsqueda la hace por el nombre del país

        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable


        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT idLogin FROM Login " & "WHERE usuario='" & FrmLogin.TxtUsuario.Text & "'and contrasena ='" & FrmLogin.TxtContraseña.Text & "'"

        consultaUsuario = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("idLogin")) Then
                idLogin = ""
            Else
                idLogin = CStr(xDT.Rows(0)("idLogin"))
                usuario = idLogin
            End If
            consultaUsuario = True
        End If
    End Function


End Class