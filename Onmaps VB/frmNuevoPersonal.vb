Public Class frmNuevoPersonal


    Public Sub inicializarPantalla()
        LlenaGrid(sqlConexion, dgvDatos, "SP_Personal 5,0,'','','','',''")
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        txtIdPersonal.Enabled = False
        txtNombre.Enabled = False
        txtPaterno.Enabled = False
        txtMaterno.Enabled = False
        txtDireccion.Enabled = False
        dtpFechaNacimiento.Enabled = False
        txtIdPersonal.Clear()
        txtNombre.Clear()
        txtPaterno.Clear()
        txtMaterno.Clear()
        txtDireccion.Clear()
        dtpFechaNacimiento.Value = New DateTime(2000, 1, 1)

    End Sub
    Private Sub frmNuevoPersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializarPantalla()
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnCancelar.Enabled = True
        txtIdPersonal.Enabled = True
        txtNombre.Enabled = True
        txtPaterno.Enabled = True
        txtMaterno.Enabled = True
        txtDireccion.Enabled = True
        dtpFechaNacimiento.Enabled = True
        txtNombre.Focus()
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim sqlcmdComando As New SqlClient.SqlCommand
        sqlcmdComando.CommandText = "SP_Personal 1, 0, '" & txtNombre.Text & "','" & txtPaterno.Text & "','" & txtMaterno.Text & "','" & txtDireccion.Text & "','" & dtpFechaNacimiento.Text & "'"
        sqlcmdComando.Connection = sqlConexion
        sqlcmdComando.ExecuteNonQuery()
        MessageBox.Show("Personal dado de alta exitosamente", "Atencion")
        inicializarPantalla()
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If MessageBox.Show("Seguro que deseas modificar el registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim sqlcmdComando As New SqlClient.SqlCommand
            sqlcmdComando.CommandText = "SP_Personal 3,'" & txtIdPersonal.Text & "','" & txtNombre.Text & "','" & txtPaterno.Text & "','" & txtMaterno.Text & "','" & txtDireccion.Text & "','" & dtpFechaNacimiento.Text & "'"
            sqlcmdComando.Connection = sqlConexion
            sqlcmdComando.ExecuteNonQuery()
            'sqlcmdComando.ExecuteReader() 'Cuando regresa una matriz
            'sqlcmdComando.ExecuteScalar() 'Cuando regresa solo una valor
            MessageBox.Show("Datos del personal modificados exitosamente", "Atencion")
            inicializarPantalla()

        End If
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        inicializarPantalla()

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
    Private Sub dgvDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellDoubleClick
        txtIdPersonal.Text = dgvDatos.CurrentRow.Cells(0).Value.ToString    'Copia todos los datos de la Fila seleccionada a los txt
        txtNombre.Text = dgvDatos.CurrentRow.Cells(1).Value.ToString
        txtPaterno.Text = dgvDatos.CurrentRow.Cells(2).Value.ToString
        txtMaterno.Text = dgvDatos.CurrentRow.Cells(3).Value.ToString
        txtDireccion.Text = dgvDatos.CurrentRow.Cells(4).Value.ToString
        dtpFechaNacimiento.Text = dgvDatos.CurrentRow.Cells(5).Value.ToString
        btnNuevo.Enabled = False 'inicializa solo los botones
        btnGuardar.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnCancelar.Enabled = True
        txtIdPersonal.Enabled = False
        txtNombre.Enabled = True
        txtPaterno.Enabled = True
        txtMaterno.Enabled = True
        txtDireccion.Enabled = True
        dtpFechaNacimiento.Enabled = True
        txtNombre.SelectAll()   'ubica el cursor en el nombre para su cambio rapido
        txtNombre.Focus()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("Seguro que deseas eliminar el registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim sqlcmdComando As New SqlClient.SqlCommand
            sqlcmdComando.CommandText = "SP_Personal 2, " & txtIdPersonal.Text & ", '','','','',''"
            sqlcmdComando.Connection = sqlConexion
            sqlcmdComando.ExecuteNonQuery()
            MessageBox.Show("Registro Eliminado exitosamente", "Atencion")
            inicializarPantalla()

        End If
    End Sub
End Class
