Imports System.Runtime.CompilerServices
Imports System.Data.SqlClient

Public Class frmLogin

    Private Sub ButtbtnAccederon1_Click(sender As Object, e As EventArgs) Handles ButtbtnAccederon1.Click
        If TxtUsuario.Text = "carlos" And TxtContraseña.Text = "1234" Then

            Me.Hide()
            frmNuevoPersonal.Show()

        End If

    End Sub
End Class