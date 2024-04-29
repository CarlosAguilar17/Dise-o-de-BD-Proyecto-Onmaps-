<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtIdPersonal = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblIdPersonal = New System.Windows.Forms.Label()
        Me.lblMaterno = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.txtPaterno = New System.Windows.Forms.TextBox()
        Me.txtMaterno = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblPaterno = New System.Windows.Forms.Label()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDatos
        '
        Me.dgvDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Location = New System.Drawing.Point(12, 144)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.RowHeadersWidth = 51
        Me.dgvDatos.RowTemplate.Height = 29
        Me.dgvDatos.Size = New System.Drawing.Size(655, 324)
        Me.dgvDatos.TabIndex = 13
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(196, 12)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(40, 40)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(150, 12)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(40, 40)
        Me.btnEliminar.TabIndex = 11
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Enabled = False
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(104, 12)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(40, 40)
        Me.btnModificar.TabIndex = 10
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(58, 12)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 40)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(12, 12)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(40, 40)
        Me.btnNuevo.TabIndex = 8
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableLayoutPanel1.AutoSize = True
        Me.tableLayoutPanel1.ColumnCount = 6
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tableLayoutPanel1.Controls.Add(Me.txtIdPersonal, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.txtNombre, 1, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.lblIdPersonal, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.lblMaterno, 3, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.lblDireccion, 4, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.lblFechaNac, 5, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.txtPaterno, 2, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.txtMaterno, 3, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.txtDireccion, 4, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.lblNombre, 1, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.dtpFechaNacimiento, 5, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.lblPaterno, 2, 0)
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(12, 58)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 2
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(652, 80)
        Me.tableLayoutPanel1.TabIndex = 7
        '
        'txtIdPersonal
        '
        Me.txtIdPersonal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtIdPersonal.Enabled = False
        Me.txtIdPersonal.Location = New System.Drawing.Point(3, 43)
        Me.txtIdPersonal.Name = "txtIdPersonal"
        Me.txtIdPersonal.ReadOnly = True
        Me.txtIdPersonal.Size = New System.Drawing.Size(102, 27)
        Me.txtIdPersonal.TabIndex = 0
        '
        'txtNombre
        '
        Me.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(111, 43)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(102, 27)
        Me.txtNombre.TabIndex = 1
        '
        'lblIdPersonal
        '
        Me.lblIdPersonal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblIdPersonal.AutoSize = True
        Me.lblIdPersonal.Location = New System.Drawing.Point(15, 10)
        Me.lblIdPersonal.Name = "lblIdPersonal"
        Me.lblIdPersonal.Size = New System.Drawing.Size(77, 20)
        Me.lblIdPersonal.TabIndex = 2
        Me.lblIdPersonal.Text = "IdPersonal"
        '
        'lblMaterno
        '
        Me.lblMaterno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMaterno.AutoSize = True
        Me.lblMaterno.Location = New System.Drawing.Point(345, 10)
        Me.lblMaterno.Name = "lblMaterno"
        Me.lblMaterno.Size = New System.Drawing.Size(65, 20)
        Me.lblMaterno.TabIndex = 5
        Me.lblMaterno.Text = "Materno"
        '
        'lblDireccion
        '
        Me.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(450, 10)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(72, 20)
        Me.lblDireccion.TabIndex = 6
        Me.lblDireccion.Text = "Direccion"
        '
        'lblFechaNac
        '
        Me.lblFechaNac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.Location = New System.Drawing.Point(554, 0)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(83, 40)
        Me.lblFechaNac.TabIndex = 7
        Me.lblFechaNac.Text = "Fecha de nacimiento"
        '
        'txtPaterno
        '
        Me.txtPaterno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPaterno.Enabled = False
        Me.txtPaterno.Location = New System.Drawing.Point(219, 43)
        Me.txtPaterno.Name = "txtPaterno"
        Me.txtPaterno.Size = New System.Drawing.Size(102, 27)
        Me.txtPaterno.TabIndex = 8
        '
        'txtMaterno
        '
        Me.txtMaterno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMaterno.Enabled = False
        Me.txtMaterno.Location = New System.Drawing.Point(327, 43)
        Me.txtMaterno.Name = "txtMaterno"
        Me.txtMaterno.Size = New System.Drawing.Size(102, 27)
        Me.txtMaterno.TabIndex = 9
        '
        'txtDireccion
        '
        Me.txtDireccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(435, 43)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(102, 27)
        Me.txtDireccion.TabIndex = 10
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(130, 10)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(64, 20)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre"
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpFechaNacimiento.Enabled = False
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(543, 43)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(106, 27)
        Me.dtpFechaNacimiento.TabIndex = 11
        Me.dtpFechaNacimiento.Value = New Date(2000, 1, 1, 12, 0, 0, 0)
        '
        'lblPaterno
        '
        Me.lblPaterno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPaterno.AutoSize = True
        Me.lblPaterno.Location = New System.Drawing.Point(240, 10)
        Me.lblPaterno.Name = "lblPaterno"
        Me.lblPaterno.Size = New System.Drawing.Size(59, 20)
        Me.lblPaterno.TabIndex = 4
        Me.lblPaterno.Text = "Paterno"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 480)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(650, 300)
        Me.Name = "Form1"
        Me.Text = "Onmaps Nuevo Personal"
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents dgvDatos As DataGridView
    Private WithEvents btnCancelar As Button
    Private WithEvents btnEliminar As Button
    Private WithEvents btnModificar As Button
    Private WithEvents btnGuardar As Button
    Private WithEvents btnNuevo As Button
    Private WithEvents tableLayoutPanel1 As TableLayoutPanel
    Private WithEvents txtIdPersonal As TextBox
    Private WithEvents txtNombre As TextBox
    Private WithEvents lblIdPersonal As Label
    Private WithEvents lblMaterno As Label
    Private WithEvents lblDireccion As Label
    Private WithEvents lblFechaNac As Label
    Private WithEvents txtPaterno As TextBox
    Private WithEvents txtMaterno As TextBox
    Private WithEvents txtDireccion As TextBox
    Private WithEvents lblNombre As Label
    Private WithEvents dtpFechaNacimiento As DateTimePicker
    Private WithEvents lblPaterno As Label
End Class
