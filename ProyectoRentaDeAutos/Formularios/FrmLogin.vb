Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnInSesion_Click(sender As Object, e As EventArgs) Handles BtnInSesion.Click

        'instanciamos la clase y le pasamos como parámetros los cuatro datos

        Dim login As New ClaseLogin(idLogin, TxtUsuario.Text, TxtContraseña.Text)
        ' Definir que mis variables van a ser igual a los valores que tengo en mis textBox
        login.getSetUsuario = TxtUsuario.Text
        login.getSetContrasena = TxtContraseña.Text

        ' Declarar variables para mis dos datos
        ' Dim usuarioAdmi As String
        ' Dim contraseña As String

        ' Si el usuario y contraseñas son válidos me permite seguir
        If (login.consultaUsuario() = True) Then
            ' Cerrar ventana
            ' Me.Hide()
            ' Muestra siguiente formulario
            Frm1.Show()
            ' Si el usuario o contraseña no son válidos, me envía un mensaje
        Else
            MsgBox("Usuario o contraseña no válidas", MsgBoxStyle.Critical, "Datos incorrectos")
        End If

        ' Hacer que mis cajitas se hagan vacías una vez terminado el registro
        TxtUsuario.Text = ""
        TxtContraseña.Text = ""
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        ' Cerrar formulario con botón Cerrar
        Me.Close()
    End Sub

    Private Sub ChbMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles ChbMostrar.CheckedChanged
        ' Si es checkBox está activo se oculta la contraseña
        If (ChbMostrar.Checked = True) Then
            TxtContraseña.UseSystemPasswordChar = True
        Else
            ' Si es checkBox está desactivado se muestra la contraseña
            TxtContraseña.UseSystemPasswordChar = False
        End If
    End Sub

End Class
