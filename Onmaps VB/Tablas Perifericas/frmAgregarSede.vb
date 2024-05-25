Public Class frmAgregarSede
    Public Sub inicializarPantalla()
        LlenaGrid(sqlConexion, dgvDatos, "SP_Sede 5,0,'','','','',''")
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        txtIdSede.Enabled = False
        cboCiudad.Enabled = False
        txtNombre.Enabled = False
        txtColonia.Enabled = False
        txtCalle.Enabled = False
        txtNumExt.Enabled = False
        txtIdSede.Clear()
        'txtCiudad.Clear()
        txtNombre.Clear()
        txtColonia.Clear()
        txtCalle.Clear()
        txtNumExt.Clear()
        llenaCombo("Select idCiudad, Nombre from Ciudad", cboCiudad, "Nombre", "Ciudad", sqlConexion)

    End Sub

    Private Sub frmAgregarSede_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializarPantalla()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnCancelar.Enabled = True
        txtIdSede.Enabled = True
        cboCiudad.Enabled = True
        txtNombre.Enabled = True
        txtCalle.Enabled = True
        txtColonia.Enabled = True
        txtNumExt.Enabled = True
        cboCiudad.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim sqlcmdComando As New SqlClient.SqlCommand
        sqlcmdComando.CommandText = "SP_Sede 1," & cboCiudad.Text & ",'" & txtNombre.Text & "','" & txtCalle.Text & "','" & txtColonia.Text & "','" & txtNumExt.Text & "'"
        sqlcmdComando.Connection = sqlConexion
        sqlcmdComando.ExecuteNonQuery()
        MessageBox.Show("Sede dada de alta exitosamente", "Atencion")
        inicializarPantalla()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If MessageBox.Show("Seguro que deseas modificar el registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim sqlcmdComando As New SqlClient.SqlCommand
            sqlcmdComando.CommandText = "SP_Sede 3,'" & cboCiudad.Text & ",'" & txtNombre.Text & "','" & txtCalle.Text & "','" & txtColonia.Text & "','" & txtNumExt.Text & "'"
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

    Private Sub txtCiudad_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtNombre.Focus()
        End If
    End Sub
    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtCalle.Focus()
        End If
    End Sub
    Private Sub txtCalle_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtColonia.Focus()
        End If
    End Sub
    Private Sub txtColonia_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtNumExt.Focus()
        End If
    End Sub

    Private Sub dgvDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellDoubleClick
        txtIdSede.Text = dgvDatos.CurrentRow.Cells(0).Value.ToString    'Copia todos los datos de la Fila seleccionada a los txt
        cboCiudad.Text = dgvDatos.CurrentRow.Cells(1).Value.ToString
        txtNombre.Text = dgvDatos.CurrentRow.Cells(2).Value.ToString
        txtCalle.Text = dgvDatos.CurrentRow.Cells(3).Value.ToString
        txtColonia.Text = dgvDatos.CurrentRow.Cells(4).Value.ToString
        txtNumExt.Text = dgvDatos.CurrentRow.Cells(5).Value.ToString
        btnNuevo.Enabled = False 'inicializa solo los botones
        btnGuardar.Enabled = False
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnCancelar.Enabled = True
        txtIdSede.Enabled = False
        cboCiudad.Enabled = True
        txtNombre.Enabled = True
        txtCalle.Enabled = True
        txtColonia.Enabled = True
        txtNumExt.Enabled = True
        cboCiudad.SelectAll()   'ubica el cursor en el nombre para su cambio rapido
        txtNombre.Focus()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("Seguro que deseas eliminar el registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim sqlcmdComando As New SqlClient.SqlCommand
            sqlcmdComando.CommandText = "SP_Sede 2, " & txtIdSede.Text & ", '','','','',''"
            sqlcmdComando.Connection = sqlConexion
            sqlcmdComando.ExecuteNonQuery()
            MessageBox.Show("Registro Eliminado exitosamente", "Atencion")
            inicializarPantalla()

        End If
    End Sub
End Class