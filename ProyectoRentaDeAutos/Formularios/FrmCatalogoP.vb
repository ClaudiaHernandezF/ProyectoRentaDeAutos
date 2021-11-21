Public Class FrmCatalogoP
    Private Sub Frm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnDir_Click(sender As Object, e As EventArgs) Handles BtnDir.Click
        FrmColonias.Show()
    End Sub

    Private Sub ColoniasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColoniasToolStripMenuItem.Click
        FrmColonias.Show()
    End Sub

    Private Sub CiudadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CiudadesToolStripMenuItem.Click
        FrmCiudades.Show()
    End Sub

    Private Sub EstadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadosToolStripMenuItem.Click
        FrmEstados.Show()
    End Sub
End Class