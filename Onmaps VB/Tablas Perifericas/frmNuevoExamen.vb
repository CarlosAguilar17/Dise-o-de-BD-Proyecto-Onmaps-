Public Class frmNuevoExamen
    Public Sub inicializarPantalla()
        LlenaGrid(sqlConexion, dgvDatos, "SP_Examen 5,0,'','',''")
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        txtIdExamen.Enabled = False
        txtNombre.Enabled = False
        txtPunMax.Enabled = False
        dtpFecha.Enabled = False
        txtIdExamen.Clear()
        txtNombre.Clear()
        txtPunMax.Clear()
        dtpFecha.Value = New DateTime(2000, 1, 1)
    End Sub

    Private Sub frmNuevoExamen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializarPantalla()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnCancelar.Enabled = True
        txtIdExamen.Enabled = True
        txtNombre.Enabled = True
        txtPunMax.Enabled = True
        dtpFecha.Enabled = True
        txtNombre.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim sqlcmdComando As New SqlClient.SqlCommand
        sqlcmdComando.CommandText = "SP_Examen 1, 0, '" & txtNombre.Text & "'," & txtPunMax.Text & ",'" & dtpFecha.Text & "'"
        sqlcmdComando.Connection = sqlConexion
        sqlcmdComando.ExecuteNonQuery()
        MessageBox.Show("Examen dado de alta exitosamente", "Atencion")
        inicializarPantalla()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If MessageBox.Show("Seguro que deseas modificar el registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim sqlcmdComando As New SqlClient.SqlCommand
            sqlcmdComando.CommandText = "SP_Examen 3, " & txtIdExamen.Text & ", '" & txtNombre.Text & "'," & txtPunMax.Text & ",'" & dtpFecha.Text
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
            txtPunMax.Focus()
        End If
    End Sub
    Private Sub dgvDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellDoubleClick
        txtIdExamen.Text = dgvDatos.CurrentRow.Cells(0).Value.ToString    'Copia todos los datos de la Fila seleccionada a los txt
        txtNombre.Text = dgvDatos.CurrentRow.Cells(1).Value.ToString
        dtpFecha.Text = dgvDatos.CurrentRow.Cells(2).Value.ToString
        txtPunMax.Text = dgvDatos.CurrentRow.Cells(3).Value.ToString
        btnNuevo.Enabled = False 'inicializa solo los botones
        btnGuardar.Enabled = False
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnCancelar.Enabled = True
        txtIdExamen.Enabled = False
        txtNombre.Enabled = True
        txtPunMax.Enabled = True
        dtpFecha.Enabled = True
        txtNombre.SelectAll()   'ubica el cursor en el nombre para su cambio rapido
        txtNombre.Focus()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("Seguro que deseas eliminar el registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim sqlcmdComando As New SqlClient.SqlCommand
            sqlcmdComando.CommandText = "SP_Examen 2, " & txtIdExamen.Text & ", '','','','',''"
            sqlcmdComando.Connection = sqlConexion
            sqlcmdComando.ExecuteNonQuery()
            MessageBox.Show("Registro Eliminado exitosamente", "Atencion")
            inicializarPantalla()

        End If
    End Sub
End Class