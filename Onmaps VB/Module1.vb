Module Module1
    Public sqlConexion As SqlClient.SqlConnection

    Sub LlenaGrid(ByVal sqlcConexion As SqlClient.SqlConnection, ByVal dgvDatos As DataGridView, ByVal strConsulta As String)
        Dim sqldaAdaptador As New SqlClient.SqlDataAdapter
        Dim sqlcmdComando As New SqlClient.SqlCommand(strConsulta)
        Dim sqldsConjunto As New DataSet
        sqlcmdComando.CommandTimeout = 0
        sqldaAdaptador.SelectCommand = sqlcmdComando
        sqldaAdaptador.SelectCommand.Connection = sqlcConexion
        sqldaAdaptador.Fill(sqldsConjunto, "Tabla")
        dgvDatos.DataSource = sqldsConjunto.Tables("Tabla")

    End Sub
End Module
