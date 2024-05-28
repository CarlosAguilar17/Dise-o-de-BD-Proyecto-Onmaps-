Public Class frmResultados
    Public Sub inicializarPantalla()
        LlenaGrid(sqlConexion, dgvExamen, "SP_AsignarExamen 1,0,0,0")
    End Sub

    Private Sub frmResultadosParticipante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializarPantalla()
    End Sub

    Private Sub dgvExamen_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvExamen.CellDoubleClick
        txtIdExamen.Text = dgvExamen.CurrentRow.Cells(0).Value.ToString    'Copia todos los datos de la Fila seleccionada a los txt
        txtNombre.Text = dgvExamen.CurrentRow.Cells(1).Value.ToString
        LlenaGrid(sqlConexion, DgvParticipante, "SP_AsignarExamen 9," & txtIdExamen.Text & ",'',''")
        llenaCombo("Select a.idParticipante, concat(Nombre,' ',Paterno,' ',Materno)as Nombre  from Participante a Inner Join ExamenParticipante b on a.idParticipante=b.idParticipante", cboParticipante, "a.idParticipante", "Nombre", sqlConexion)

    End Sub

    Private Sub dgvParticipante_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvParticipante.CellDoubleClick
        cboParticipante.Text = DgvParticipante.CurrentRow.Cells(0).Value.ToString
    End Sub

    Private Sub DgvSigExamen_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSigExamen.CellDoubleClick
        cboExamen.Text = DgvSigExamen.CurrentRow.Cells(0).Value.ToString

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim sqlcmdComando As New SqlClient.SqlCommand
        sqlcmdComando.CommandText = "SP_AsignarExamen 5," & txtIdExamen.Text & " ," & cboParticipante.SelectedValue & ",0"
        sqlcmdComando.Connection = sqlConexion
        sqlcmdComando.ExecuteNonQuery()
        MessageBox.Show("Participante eliminado exitosamente", "Atencion")
        inicializarPantalla()
        LlenaGrid(sqlConexion, DgvParticipante, "SP_AsignarExamen 2," & txtIdExamen.Text & ",'',''")
        cboParticipante.Focus()
    End Sub

End Class

