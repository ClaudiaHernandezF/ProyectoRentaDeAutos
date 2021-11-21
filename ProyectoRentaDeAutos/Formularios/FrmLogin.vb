' Valores cargados al ejecutar mi aplicación, en el FrmLogin
Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' La contraseña aparece oculta cuando aparece el formulario
        TxtContraseña.UseSystemPasswordChar = True

        ' Definir ToolTip para mostrar mensajes de ayuda en los elementos de mi FrmLogin 
        Me.ToolTip1.SetToolTip(Me.TxtUsuario, "Ingresar nombre de Administrador")
        Me.ToolTip1.SetToolTip(Me.TxtContraseña, "Ingresar contraseña de Administrador")
        Me.ToolTip1.SetToolTip(Me.ChbMostrar, "Mostrar contraseña")
        Me.ToolTip1.SetToolTip(Me.BtnInSesion, "Clic para iniciar sesión")

    End Sub

    ' Acción del botón "Iniciar sesión"
    Private Sub btnInSesion_Click(sender As Object, e As EventArgs) Handles BtnInSesion.Click

        ' Instanciar la clase y pasarle como parámetros los dos datos del login
        Dim login As New ClaseLogin(TxtUsuario.Text, TxtContraseña.Text)

        ' Definir que mis variables van a ser igual a los valores que tengo en mis textBox
        login.getSetUsuario = TxtUsuario.Text
        login.getSetContrasena = TxtContraseña.Text

        ' Si el usuario y contraseñas son válidos me permite seguir
        If (login.consultaUsuario() = True) Then
            ' Muestra siguiente formulario
            FrmCatalogo.Show()
            ' Cerrar ventana
            ' Me.Close()
            ' Si el usuario o contraseña no son válidos, me envía un mensaje
        Else
            MsgBox("Usuario o contraseña no válidas", MsgBoxStyle.Critical, "Datos incorrectos")
        End If

        ' Hacer que mis cajitas se hagan vacías una vez terminado el registro
        TxtUsuario.Text = ""
        TxtContraseña.Text = ""
    End Sub

    ' Configuración del CheckBox "Mostrar" para la contraseña
    Private Sub ChbMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles ChbMostrar.CheckedChanged
        ' Si el checkBox está activo se muestra la contraseña
        If (ChbMostrar.Checked = True) Then
            TxtContraseña.UseSystemPasswordChar = False
        Else
            ' Si es checkBox está desactivado se oculta la contraseña
            TxtContraseña.UseSystemPasswordChar = True
        End If
    End Sub

End Class
