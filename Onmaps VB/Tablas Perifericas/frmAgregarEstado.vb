Public Class frmAgregarEstado
    Public Sub inicializarPantalla()
        LlenaGrid(sqlConexion, dgvDatos, "SP_Estado 5,0,'','',''")
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        txtEstado.Enabled = False
        txtIdEstado.Enabled = False
        txtCorreo.Enabled = False
        txtDelegado.Enabled = False
        txtEstado.Clear()
        txtCorreo.Clear()
        txtIdEstado.Clear()
        txtDelegado.Clear()
    End Sub

    Private Sub frmAgregarEstado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializarPantalla()
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnCancelar.Enabled = True
        txtIdEstado.Enabled = True
        txtEstado.Enabled = True
        txtCorreo.Enabled = True
        txtDelegado.Enabled = True
        txtEstado.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim sqlcmdComando As New SqlClient.SqlCommand
        sqlcmdComando.CommandText = "SP_Estado 1, 0, " & txtDelegado.Text & ",'" & txtCorreo.Text & "','" & txtEstado.Text & "'"
        sqlcmdComando.Connection = sqlConexion
        sqlcmdComando.ExecuteNonQuery()
        MessageBox.Show("Extado dado de alta exitosamente", "Atencion")
        inicializarPantalla()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If MessageBox.Show("Seguro que deseas modificar el registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim sqlcmdComando As New SqlClient.SqlCommand
            sqlcmdComando.CommandText = "SP_Estado 1, " & txtIdEstado.Text & ", " & txtDelegado.Text & ",'" & txtCorreo.Text & "','" & txtEstado.Text & "'"
            sqlcmdComando.Connection = sqlConexion
            sqlcmdComando.ExecuteNonQuery()
            MessageBox.Show("Datos del Examen modificados exitosamente", "Atencion")
            inicializarPantalla()

        End If
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        inicializarPantalla()
    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtDelegado.Focus()
        End If
    End Sub
    Private Sub txtDelegado_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtCorreo.Focus()
        End If
    End Sub
    Private Sub dgvDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellDoubleClick
        txtIdEstado.Text = dgvDatos.CurrentRow.Cells(0).Value.ToString    'Copia todos los datos de la Fila seleccionada a los txt
        txtDelegado.Text = dgvDatos.CurrentRow.Cells(1).Value.ToString
        txtCorreo.Text = dgvDatos.CurrentRow.Cells(2).Value.ToString
        txtEstado.Text = dgvDatos.CurrentRow.Cells(3).Value.ToString
        btnNuevo.Enabled = False 'inicializa solo los botones
        btnGuardar.Enabled = False
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnCancelar.Enabled = True
        txtIdEstado.Enabled = False
        txtDelegado.Enabled = True
        txtCorreo.Enabled = True
        txtEstado.Enabled = True
        txtEstado.SelectAll()   'ubica el cursor en el nombre para su cambio rapido
        txtEstado.Focus()
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("Seguro que deseas eliminar el registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim sqlcmdComando As New SqlClient.SqlCommand
            sqlcmdComando.CommandText = "SP_Estado 2, " & txtIdEstado.Text & ", '','',''"
            sqlcmdComando.Connection = sqlConexion
            sqlcmdComando.ExecuteNonQuery()
            MessageBox.Show("Registro Eliminado exitosamente", "Atencion")
            inicializarPantalla()

        End If
    End Sub
End Class