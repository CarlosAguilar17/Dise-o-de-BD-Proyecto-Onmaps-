﻿Imports System.Runtime.CompilerServices
Imports System.Data.SqlClient
Imports System.Net

Public Class frmLogin

    Public Sub ButtbtnAccederon1_Click(sender As Object, e As EventArgs) Handles ButtbtnAcceder.Click
        Dim sqlcmdComando As New SqlClient.SqlCommand
        sqlcmdComando.CommandText = "SP_ValidarUsuario '" & TxtUsuario.Text & "','" & TxtContraseña.Text & "'"
        sqlcmdComando.Connection = sqlConexion
        If sqlcmdComando.ExecuteScalar() = 1 Then
            Dim frmOnmapsMenu As New frmOnmapsMenu

            Me.Hide()
            frmOnmapsMenu.Show()
        Else
            MessageBox.Show("Problema con el usuario", "Atencion")
        End If

    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlConexion = New SqlClient.SqlConnection
        'sqlConexion.ConnectionString = "workstation id = " & Dns.GetHostName & "; packet size = 8192; user id = USR_Onmaps; data source = DESKTOP-C8NETJI\TEW_SQLEXPRESS; persist security info = False; initial catalog = USR_Onmaps; password = 1234; pooling = FALSE"
        sqlConexion.ConnectionString = "Persist Security Info=False;User ID=USR_Onmaps;Password=1234;Initial Catalog=onmapsSQL;Server=DESKTOP-C8NETJI\TEW_SQLEXPRESS;Encrypt=False;"
        sqlConexion.Open()
    End Sub

    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        sqlConexion.Close()
        Application.Exit()
    End Sub

    Private Sub TxtUsuario_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            TxtContraseña.Focus()
        End If
    End Sub

    Private Sub TxtContraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtContraseña.KeyDown

        If e.KeyCode = Keys.Enter Then
            Me.ButtbtnAcceder.PerformClick()
        End If
    End Sub
End Class
