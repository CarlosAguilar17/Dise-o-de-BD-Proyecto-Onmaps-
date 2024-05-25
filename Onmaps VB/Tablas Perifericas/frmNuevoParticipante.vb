Public Class frmNuevoParticipante
    Public Sub inicializarPantalla()
        LlenaGrid(sqlConexion, dgvDatos, "SP_Participante 5,0,'','','','',''")
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        txtIdParticipante.Enabled = False
        txtGrado.Enabled = False
        txtNombre.Enabled = False
        txtPaterno.Enabled = False
        txtMaterno.Enabled = False
        cboSede.Enabled = False
        txtIdParticipante.Clear()
        txtGrado.Clear()
        txtNombre.Clear()
        txtPaterno.Clear()
        txtMaterno.Clear()
        'txtSede.Clear()
        llenaCombo("Select idSede, Nombre from Sede", cboSede, "Nombre", "Sede", sqlConexion)

    End Sub

    Private Sub frmNuevoParticipante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializarPantalla()
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnCancelar.Enabled = True
        txtIdParticipante.Enabled = True
        txtGrado.Enabled = True
        txtNombre.Enabled = True
        txtPaterno.Enabled = True
        txtMaterno.Enabled = True
        cboSede.Enabled = True
        txtGrado.Focus()
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim sqlcmdComando As New SqlClient.SqlCommand
        sqlcmdComando.CommandText = "SP_Participante 1, 0, '" & txtGrado.Text & "','" & txtNombre.Text & "','" & txtPaterno.Text & "','" & txtMaterno.Text & "'," & cboSede.Text
        sqlcmdComando.Connection = sqlConexion
        sqlcmdComando.ExecuteNonQuery()
        MessageBox.Show("Participante dado de alta exitosamente", "Atencion")
        inicializarPantalla()
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If MessageBox.Show("Seguro que deseas modificar el registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim sqlcmdComando As New SqlClient.SqlCommand
            sqlcmdComando.CommandText = "SP_Participante 1, '" & txtIdParticipante.Text & "', '" & txtGrado.Text & "','" & txtNombre.Text & "','" & txtPaterno.Text & "','" & txtMaterno.Text & "'," & cboSede.Text
            sqlcmdComando.Connection = sqlConexion
            sqlcmdComando.ExecuteNonQuery()
            MessageBox.Show("Datos del participante modificados exitosamente", "Atencion")
            inicializarPantalla()

        End If
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        inicializarPantalla()
    End Sub

    Private Sub txtGrado_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtNombre.Focus()
        End If
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
            cboSede.Focus()
        End If
    End Sub

    Private Sub dgvDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellDoubleClick
        txtIdParticipante.Text = dgvDatos.CurrentRow.Cells(0).Value.ToString    'Copia todos los datos de la Fila seleccionada a los txt
        txtGrado.Text = dgvDatos.CurrentRow.Cells(1).Value.ToString
        txtNombre.Text = dgvDatos.CurrentRow.Cells(2).Value.ToString
        txtPaterno.Text = dgvDatos.CurrentRow.Cells(3).Value.ToString
        txtMaterno.Text = dgvDatos.CurrentRow.Cells(4).Value.ToString
        cboSede.Text = dgvDatos.CurrentRow.Cells(5).Value.ToString
        btnNuevo.Enabled = False 'inicializa solo los botones
        btnGuardar.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnCancelar.Enabled = True
        txtIdParticipante.Enabled = False
        txtNombre.Enabled = True
        txtPaterno.Enabled = True
        txtMaterno.Enabled = True
        cboSede.Enabled = True
        txtNombre.SelectAll()   'ubica el cursor en el nombre para su cambio rapido
        txtNombre.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("Seguro que deseas eliminar el registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim sqlcmdComando As New SqlClient.SqlCommand
            sqlcmdComando.CommandText = "SP_Participante 2, " & txtIdParticipante.Text & ", '','','','',''"
            sqlcmdComando.Connection = sqlConexion
            sqlcmdComando.ExecuteNonQuery()
            MessageBox.Show("Registro Eliminado exitosamente", "Atencion")
            inicializarPantalla()

        End If
    End Sub

End Class
