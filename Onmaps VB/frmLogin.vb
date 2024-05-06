Imports System.Runtime.CompilerServices
Imports System.Data.SqlClient
Imports System.Net

Public Class frmLogin

    Private Sub ButtbtnAccederon1_Click(sender As Object, e As EventArgs) Handles ButtbtnAccederon1.Click
        Dim sqlcmdComando As New SqlClient.SqlCommand
        sqlcmdComando.CommandText = "SP_VaidarUsusario '" & TxtUsuario.Text & "','" & TxtContraseña.Text & "'"
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
End Class
