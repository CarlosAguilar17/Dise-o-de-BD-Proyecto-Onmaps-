Public Class frmOnmapsMenu

    Private Sub frmOnmapsNuevo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
        sqlConexion.Close()
    End Sub
    Dim frmNuevoPersonal As New frmNuevoPersonal
    Private Sub NuevoPersonalMenu_Click(sender As Object, e As EventArgs) Handles MenuNuevoPersonal.Click
        If frmNuevoPersonal Is Nothing Then
            frmNuevoPersonal = New frmNuevoPersonal
            frmNuevoPersonal.MdiParent = Me
            frmNuevoPersonal.Show()
        Else
            If frmNuevoPersonal.Visible = True Then
                frmNuevoPersonal.BringToFront()
            Else
                frmNuevoPersonal = New frmNuevoPersonal
                frmNuevoPersonal.MdiParent = Me
                frmNuevoPersonal.Show()
            End If
        End If
    End Sub
    Dim frmNuevoParticipante As New frmNuevoParticipante
    Private Sub NuevoParticipanteMenu_Click(sender As Object, e As EventArgs) Handles MenuNuevoParticipante.Click
        If frmNuevoParticipante Is Nothing Then
            frmNuevoParticipante = New frmNuevoParticipante
            frmNuevoParticipante.MdiParent = Me
            frmNuevoParticipante.Show()
        Else
            If frmNuevoParticipante.Visible = True Then
                frmNuevoParticipante.BringToFront()
            Else
                frmNuevoParticipante = New frmNuevoParticipante
                frmNuevoParticipante.MdiParent = Me
                frmNuevoParticipante.Show()
            End If
        End If
    End Sub
    Dim frmNuevoExamen As New frmNuevoExamen
    Private Sub MenuNuevoExamen_Click(sender As Object, e As EventArgs) Handles MenuNuevoExamen.Click
        If frmNuevoExamen Is Nothing Then
            frmNuevoExamen = New frmNuevoExamen
            frmNuevoExamen.MdiParent = Me
            frmNuevoExamen.Show()
        Else
            If frmNuevoExamen.Visible = True Then
                frmNuevoExamen.BringToFront()
            Else
                frmNuevoExamen = New frmNuevoExamen
                frmNuevoExamen.MdiParent = Me
                frmNuevoExamen.Show()
            End If
        End If
    End Sub

    Dim frmAgregarCiudad As New frmAgregarEstado
    Private Sub MenuAgregarCiudad_Click(sender As Object, e As EventArgs) Handles MenuAgregarEstado.Click
        If frmAgregarCiudad Is Nothing Then
            frmAgregarCiudad = New frmAgregarEstado
            frmAgregarCiudad.MdiParent = Me
            frmAgregarCiudad.Show()
        Else
            If frmAgregarCiudad.Visible = True Then
                frmAgregarCiudad.BringToFront()
            Else
                frmAgregarCiudad = New frmAgregarEstado
                frmAgregarCiudad.MdiParent = Me
                frmAgregarCiudad.Show()
            End If
        End If
    End Sub
    Dim frmAgregarSede As New frmAgregarSede
    Private Sub MenuAgregarSede_Click(sender As Object, e As EventArgs) Handles MenuAgregarSede.Click
        If frmAgregarSede Is Nothing Then
            frmAgregarSede = New frmAgregarSede
            frmAgregarSede.MdiParent = Me
            frmAgregarSede.Show()
        Else
            If frmAgregarSede.Visible = True Then
                frmAgregarSede.BringToFront()
            Else
                frmAgregarSede = New frmAgregarSede
                frmAgregarSede.MdiParent = Me
                frmAgregarSede.Show()
            End If
        End If
    End Sub
    Dim frmExamenParticipante As New frmExamenParticipante
    Private Sub MenuAsignarExamen_Click(sender As Object, e As EventArgs) Handles MenuAsignarExamen.Click
        If frmExamenParticipante Is Nothing Then
            frmExamenParticipante = New frmExamenParticipante
            frmExamenParticipante.MdiParent = Me
            frmExamenParticipante.Show()
        Else
            If frmExamenParticipante.Visible = True Then
                frmExamenParticipante.BringToFront()
            Else
                frmExamenParticipante = New frmExamenParticipante
                frmExamenParticipante.MdiParent = Me
                frmExamenParticipante.Show()
            End If
        End If
    End Sub
    Dim frmResultados As New frmResultados

    Private Sub MenuResultados_Click(sender As Object, e As EventArgs) Handles MenuResultados.Click
        If frmResultados Is Nothing Then
            frmResultados = New frmResultados
            frmResultados.MdiParent = Me
            frmResultados.Show()
        Else
            If frmResultados.Visible = True Then
                frmResultados.BringToFront()
            Else
                frmResultados = New frmResultados
                frmResultados.MdiParent = Me
                frmResultados.Show()
            End If
        End If
    End Sub
End Class