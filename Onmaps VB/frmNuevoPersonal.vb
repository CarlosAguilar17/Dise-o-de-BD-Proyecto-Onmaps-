﻿Public Class frmNuevoPersonal
    Private Sub tableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Public Sub iniciarBotones()
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        txtIdParticipante.Enabled = False
        txtNombre.Enabled = False
        txtPaterno.Enabled = False
        txtMaterno.Enabled = False
        txtDireccion.Enabled = False
        dtpFechaNacimiento.Enabled = False
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnCancelar.Enabled = True
        txtIdParticipante.Enabled = True
        txtNombre.Enabled = True
        txtPaterno.Enabled = True
        txtMaterno.Enabled = True
        txtDireccion.Enabled = True
        dtpFechaNacimiento.Enabled = True
        txtNombre.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        iniciarBotones()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        iniciarBotones()
        Dim SqlcmdComando As New SqlClient.SqlCommand




    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtPaterno.Focus()
        End If
    End Sub

    Private Sub txtPaterno_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtMaterno.Focus()
        End If
    End Sub

    Private Sub txtMaterno_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtDireccion.Focus()
        End If
    End Sub

    Private Sub txtDireccion_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            dtpFechaNacimiento.Focus()
        End If
    End Sub

    Private Sub frmNuevoPersonal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class
