<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNuevoPersonal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevoPersonal))
        dgvDatos = New DataGridView()
        btnCancelar = New Button()
        btnEliminar = New Button()
        btnModificar = New Button()
        btnGuardar = New Button()
        btnNuevo = New Button()
        TableLayoutPanel2 = New TableLayoutPanel()
        txtIdPersonal = New TextBox()
        txtNombre = New TextBox()
        lblIdPersonal = New Label()
        Label1 = New Label()
        lblDireccion = New Label()
        lblFechaNac = New Label()
        txtPaterno = New TextBox()
        txtMaterno = New TextBox()
        txtDireccion = New TextBox()
        Label2 = New Label()
        dtpFechaNacimiento = New DateTimePicker()
        Label3 = New Label()
        CType(dgvDatos, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvDatos
        ' 
        dgvDatos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDatos.Location = New Point(12, 144)
        dgvDatos.Name = "dgvDatos"
        dgvDatos.RowHeadersWidth = 51
        dgvDatos.Size = New Size(642, 324)
        dgvDatos.TabIndex = 13
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Enabled = False
        btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), Image)
        btnCancelar.Location = New Point(196, 12)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(40, 40)
        btnCancelar.TabIndex = 12
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Enabled = False
        btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), Image)
        btnEliminar.Location = New Point(150, 12)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(40, 40)
        btnEliminar.TabIndex = 11
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnModificar
        ' 
        btnModificar.Enabled = False
        btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), Image)
        btnModificar.Location = New Point(104, 12)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(40, 40)
        btnModificar.TabIndex = 10
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Enabled = False
        btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), Image)
        btnGuardar.Location = New Point(58, 12)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(40, 40)
        btnGuardar.TabIndex = 9
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.BackgroundImageLayout = ImageLayout.Stretch
        btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), Image)
        btnNuevo.Location = New Point(12, 12)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(40, 40)
        btnNuevo.TabIndex = 8
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.AutoSize = True
        TableLayoutPanel2.ColumnCount = 6
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.66667F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.66667F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.66667F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.66667F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.66667F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.66667F))
        TableLayoutPanel2.Controls.Add(txtIdPersonal, 0, 1)
        TableLayoutPanel2.Controls.Add(txtNombre, 1, 1)
        TableLayoutPanel2.Controls.Add(lblIdPersonal, 0, 0)
        TableLayoutPanel2.Controls.Add(Label1, 3, 0)
        TableLayoutPanel2.Controls.Add(lblDireccion, 4, 0)
        TableLayoutPanel2.Controls.Add(lblFechaNac, 5, 0)
        TableLayoutPanel2.Controls.Add(txtPaterno, 2, 1)
        TableLayoutPanel2.Controls.Add(txtMaterno, 3, 1)
        TableLayoutPanel2.Controls.Add(txtDireccion, 4, 1)
        TableLayoutPanel2.Controls.Add(Label2, 1, 0)
        TableLayoutPanel2.Controls.Add(dtpFechaNacimiento, 5, 1)
        TableLayoutPanel2.Controls.Add(Label3, 2, 0)
        TableLayoutPanel2.Location = New Point(12, 58)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(642, 80)
        TableLayoutPanel2.TabIndex = 15
        ' 
        ' txtIdPersonal
        ' 
        txtIdPersonal.Dock = DockStyle.Fill
        txtIdPersonal.Enabled = False
        txtIdPersonal.Location = New Point(3, 43)
        txtIdPersonal.Name = "txtIdPersonal"
        txtIdPersonal.ReadOnly = True
        txtIdPersonal.Size = New Size(100, 27)
        txtIdPersonal.TabIndex = 0
        ' 
        ' txtNombre
        ' 
        txtNombre.Dock = DockStyle.Fill
        txtNombre.Enabled = False
        txtNombre.Location = New Point(109, 43)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(100, 27)
        txtNombre.TabIndex = 1
        ' 
        ' lblIdPersonal
        ' 
        lblIdPersonal.Anchor = AnchorStyles.None
        lblIdPersonal.AutoSize = True
        lblIdPersonal.Location = New Point(14, 10)
        lblIdPersonal.Name = "lblIdPersonal"
        lblIdPersonal.Size = New Size(77, 20)
        lblIdPersonal.TabIndex = 2
        lblIdPersonal.Text = "IdPersonal"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Location = New Point(338, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 20)
        Label1.TabIndex = 5
        Label1.Text = "Materno"
        ' 
        ' lblDireccion
        ' 
        lblDireccion.Anchor = AnchorStyles.None
        lblDireccion.AutoSize = True
        lblDireccion.Location = New Point(441, 10)
        lblDireccion.Name = "lblDireccion"
        lblDireccion.Size = New Size(72, 20)
        lblDireccion.TabIndex = 6
        lblDireccion.Text = "Direccion"
        ' 
        ' lblFechaNac
        ' 
        lblFechaNac.Anchor = AnchorStyles.None
        lblFechaNac.AutoSize = True
        lblFechaNac.Location = New Point(544, 0)
        lblFechaNac.Name = "lblFechaNac"
        lblFechaNac.Size = New Size(83, 40)
        lblFechaNac.TabIndex = 7
        lblFechaNac.Text = "Fecha de nacimiento"
        ' 
        ' txtPaterno
        ' 
        txtPaterno.Dock = DockStyle.Fill
        txtPaterno.Enabled = False
        txtPaterno.Location = New Point(215, 43)
        txtPaterno.Name = "txtPaterno"
        txtPaterno.Size = New Size(100, 27)
        txtPaterno.TabIndex = 8
        ' 
        ' txtMaterno
        ' 
        txtMaterno.Dock = DockStyle.Fill
        txtMaterno.Enabled = False
        txtMaterno.Location = New Point(321, 43)
        txtMaterno.Name = "txtMaterno"
        txtMaterno.Size = New Size(100, 27)
        txtMaterno.TabIndex = 9
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Dock = DockStyle.Fill
        txtDireccion.Enabled = False
        txtDireccion.Location = New Point(427, 43)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(100, 27)
        txtDireccion.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Location = New Point(127, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 3
        Label2.Text = "Nombre"
        ' 
        ' dtpFechaNacimiento
        ' 
        dtpFechaNacimiento.Dock = DockStyle.Fill
        dtpFechaNacimiento.Enabled = False
        dtpFechaNacimiento.Format = DateTimePickerFormat.Short
        dtpFechaNacimiento.Location = New Point(533, 43)
        dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        dtpFechaNacimiento.Size = New Size(106, 27)
        dtpFechaNacimiento.TabIndex = 11
        dtpFechaNacimiento.Value = New Date(2000, 1, 1, 12, 0, 0, 0)
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Location = New Point(235, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 20)
        Label3.TabIndex = 4
        Label3.Text = "Paterno"
        ' 
        ' frmNuevoPersonal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(689, 480)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(dgvDatos)
        Controls.Add(btnCancelar)
        Controls.Add(btnEliminar)
        Controls.Add(btnModificar)
        Controls.Add(btnGuardar)
        Controls.Add(btnNuevo)
        MinimumSize = New Size(650, 300)
        Name = "frmNuevoPersonal"
        Text = "Nuevo Personal"
        WindowState = FormWindowState.Maximized
        CType(dgvDatos, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Private WithEvents dgvDatos As DataGridView
    Private WithEvents btnCancelar As Button
    Private WithEvents btnEliminar As Button
    Private WithEvents btnModificar As Button
    Private WithEvents btnGuardar As Button
    Private WithEvents btnNuevo As Button
    Private WithEvents TableLayoutPanel2 As TableLayoutPanel
    Private WithEvents txtIdPersonal As TextBox
    Private WithEvents txtNombre As TextBox
    Private WithEvents lblIdPersonal As Label
    Private WithEvents Label1 As Label
    Private WithEvents lblDireccion As Label
    Private WithEvents lblFechaNac As Label
    Private WithEvents txtPaterno As TextBox
    Private WithEvents txtMaterno As TextBox
    Private WithEvents txtDireccion As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents dtpFechaNacimiento As DateTimePicker
    Private WithEvents Label3 As Label
End Class
