Public Class Form1
    Private Sub tableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles tableLayoutPanel1.Paint

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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
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
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
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
    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPaterno.Focus()
        End If
    End Sub

    Private Sub txtPaterno_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPaterno.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtMaterno.Focus()
        End If
    End Sub

    Private Sub txtMaterno_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMaterno.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDireccion.Focus()
        End If
    End Sub

    Private Sub txtDireccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDireccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtpFechaNacimiento.Focus()
        End If
    End Sub
End Class
