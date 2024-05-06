Public Class frmOnmapsMenu

    Private Sub frmOnmapsNuevo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub NuevoPersonalMenu_Click(sender As Object, e As EventArgs) Handles MenuNuevoPersonal.Click
        Dim Pantalla As New frmNuevoPersonal
        Me.Hide()
        Pantalla.Show()
    End Sub

    Private Sub NuevoParticipanteMenu_Click(sender As Object, e As EventArgs) Handles MenuNuevoParticipante.Click
        Dim Pantalla As New frmNuevoParticipante
        Me.Hide()
        Pantalla.Show()
    End Sub

    Private Sub MenuNuevoExamen_Click(sender As Object, e As EventArgs) Handles MenuNuevoExamen.Click
        Dim Pantalla As New frmNuevoExamen
        Me.Hide()
        Pantalla.Show()
    End Sub

    Private Sub MenuAgregarEstado_Click(sender As Object, e As EventArgs) Handles MenuCiudad.Click
        Dim Pantalla As New frmAgregarCiudad
        Me.Hide()
        Pantalla.Show()
    End Sub

    Private Sub MenuAgregarSede_Click(sender As Object, e As EventArgs) Handles MenuAgregarSede.Click
        Dim Pantalla As New frmAgregarSede
        Me.Hide()
        Pantalla.Show()
    End Sub
End Class