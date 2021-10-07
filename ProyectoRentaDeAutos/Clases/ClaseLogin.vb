Imports Oracle.DataAccess.Client

' En esta clase defino mis contructores y querys necesarios para mi FrmLogin
' En la tabla LogAdministradores cuento con dos atributos --> usuario y contrasena
Public Class ClaseLogin

    'Método constructor que inicializa variables
    Public Sub New()
        ' Son variables de tipo String, por lo que inicializan como ""
        usuario = ""
        contrasena = ""
    End Sub

    'Metodo constructor con valores proporcionados al instanciar el objeto
    Public Sub New(ByVal elUsuario As String, ByVal laContraseña As String)
        'Aquí recibimos los datos
        usuario = elUsuario
        contrasena = laContraseña
    End Sub

    'Metodos get y set
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
        ' Utilizada para comprobar si mi usuario y contraseña existen en la tabla de LogAdministradores

        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        ' Verifico con una sentencia de SELECT mis datos en la tabla LogAdministradores, para ver si los valores de mis variables 
        ' son iguales a los valores que me den en login (usuario y contraseña) en mis textBox
        strSQL = "SELECT * FROM LogAdministradores " & "WHERE usuario='" & FrmLogin.TxtUsuario.Text & "'and contrasena ='" & FrmLogin.TxtContraseña.Text & "'"

        consultaUsuario = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("usuario")) Then
                usuario = ""
            Else
                usuario = CStr(xDT.Rows(0)("usuario"))
            End If
            consultaUsuario = True
        End If
    End Function

End Class