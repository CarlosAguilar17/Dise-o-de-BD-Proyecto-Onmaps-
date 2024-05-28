Public Class frmExamenParticipante
    Public Sub inicializarPantalla()
        LlenaGrid(sqlConexion, dgvExamen, "SP_AsignarExamen 1,0,0,0")
    End Sub

    Private Sub frmExamenParticipante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializarPantalla()
    End Sub

    Private Sub dgvExamen_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvExamen.CellDoubleClick
        txtIdExamen.Text = dgvExamen.CurrentRow.Cells(0).Value.ToString    'Copia todos los datos de la Fila seleccionada a los txt
        txtNombre.Text = dgvExamen.CurrentRow.Cells(1).Value.ToString
        LlenaGrid(sqlConexion, DgvParticipante, "SP_AsignarExamen 2," & txtIdExamen.Text & ",'',''")
        LlenaGrid(sqlConexion, DgvSigExamen, "SP_AsignarExamen 3," & txtIdExamen.Text & ",'',''")
        llenaCombo("Select idParticipante, concat(Nombre,' ',Paterno,' ',Materno)as Nombre from Participante", cboParticipante, "idParticipante", "Nombre", sqlConexion)
        llenaCombo("Select idExamen, Nombre from Examen", cboExamen, "idExamen", "Nombre", sqlConexion)

    End Sub
    Private Sub dgvParticipante_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvParticipante.CellDoubleClick
        cboParticipante.Text = DgvParticipante.CurrentRow.Cells(0).Value.ToString
    End Sub
    Private Sub DgvSigExamen_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSigExamen.CellDoubleClick
        cboExamen.Text = DgvSigExamen.CurrentRow.Cells(0).Value.ToString

    End Sub

    Private Sub btnEliminarParticipante_Click(sender As Object, e As EventArgs) Handles btnEliminarParticipante.Click
        Dim sqlcmdComando As New SqlClient.SqlCommand
        sqlcmdComando.CommandText = "SP_AsignarExamen 5," & txtIdExamen.Text & " ,'" & cboParticipante.SelectedValue & "',''"
        sqlcmdComando.Connection = sqlConexion
        sqlcmdComando.ExecuteNonQuery()
        MessageBox.Show("Participante eliminado exitosamente", "Atencion")
        inicializarPantalla()
        LlenaGrid(sqlConexion, DgvParticipante, "SP_AsignarExamen 2," & txtIdExamen.Text & ",'',''")
    End Sub

    Private Sub btnAgregarParticipante_Click(sender As Object, e As EventArgs) Handles btnAgregarParticipante.Click

        Dim sqlcmdComando As New SqlClient.SqlCommand
        sqlcmdComando.CommandText = "SP_AsignarExamen 6," & txtIdExamen.Text & " ,'" & cboParticipante.SelectedValue & "',''"
        sqlcmdComando.Connection = sqlConexion
        sqlcmdComando.ExecuteNonQuery()
        MessageBox.Show("Participante dado de alta exitosamente", "Atencion")
        inicializarPantalla()
        LlenaGrid(sqlConexion, DgvParticipante, "SP_AsignarExamen 2," & txtIdExamen.Text & ",'',''")


    End Sub

    Private Sub btnEliminarExamen_Click(sender As Object, e As EventArgs) Handles btnEliminarExamen.Click
        Dim sqlcmdComando As New SqlClient.SqlCommand
        sqlcmdComando.CommandText = "SP_AsignarExamen 7," & txtIdExamen.Text & ",0," & cboExamen.SelectedValue & ""
        sqlcmdComando.Connection = sqlConexion
        sqlcmdComando.ExecuteNonQuery()
        MessageBox.Show("Examen eliminado exitosamente", "Atencion")
        inicializarPantalla()
        LlenaGrid(sqlConexion, DgvSigExamen, "SP_AsignarExamen 3," & txtIdExamen.Text & ",'',''")
    End Sub

    Private Sub btnAgregarExamen_Click(sender As Object, e As EventArgs) Handles btnAgregarExamen.Click
        Dim sqlcmdComando As New SqlClient.SqlCommand
        sqlcmdComando.CommandText = "SP_AsignarExamen 8," & txtIdExamen.Text & ",0," & cboExamen.SelectedValue & ""
        sqlcmdComando.Connection = sqlConexion
        sqlcmdComando.ExecuteNonQuery()
        MessageBox.Show("Examen dado de alta exitosamente", "Atencion")
        inicializarPantalla()
        LlenaGrid(sqlConexion, DgvSigExamen, "SP_AsignarExamen 3," & txtIdExamen.Text & ",'',''")
    End Sub
End Class