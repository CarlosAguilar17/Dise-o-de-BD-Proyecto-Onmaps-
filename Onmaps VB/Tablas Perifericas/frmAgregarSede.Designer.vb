<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarSede
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarSede))
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtIdSede = New System.Windows.Forms.TextBox()
        Me.lblIdSede = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblCiudad = New System.Windows.Forms.Label()
        Me.lblSedeNombre = New System.Windows.Forms.Label()
        Me.lblColonia = New System.Windows.Forms.Label()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.lblNumeroExt = New System.Windows.Forms.Label()
        Me.Calle = New System.Windows.Forms.Label()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.txtNumExt = New System.Windows.Forms.TextBox()
        Me.cboCiudad = New System.Windows.Forms.ComboBox()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtIdSede, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblIdSede, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtNombre, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblCiudad, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblSedeNombre, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblColonia, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtColonia, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblNumeroExt, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Calle, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtCalle, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtNumExt, 5, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cboCiudad, 1, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 58)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(747, 80)
        Me.TableLayoutPanel2.TabIndex = 42
        '
        'txtIdSede
        '
        Me.txtIdSede.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtIdSede.Enabled = False
        Me.txtIdSede.Location = New System.Drawing.Point(3, 43)
        Me.txtIdSede.Name = "txtIdSede"
        Me.txtIdSede.ReadOnly = True
        Me.txtIdSede.Size = New System.Drawing.Size(118, 27)
        Me.txtIdSede.TabIndex = 0
        '
        'lblIdSede
        '
        Me.lblIdSede.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblIdSede.AutoSize = True
        Me.lblIdSede.Location = New System.Drawing.Point(34, 10)
        Me.lblIdSede.Name = "lblIdSede"
        Me.lblIdSede.Size = New System.Drawing.Size(55, 20)
        Me.lblIdSede.TabIndex = 2
        Me.lblIdSede.Text = "idSede"
        '
        'txtNombre
        '
        Me.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(251, 43)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(118, 27)
        Me.txtNombre.TabIndex = 8
        '
        'lblCiudad
        '
        Me.lblCiudad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCiudad.AutoSize = True
        Me.lblCiudad.Location = New System.Drawing.Point(158, 10)
        Me.lblCiudad.Name = "lblCiudad"
        Me.lblCiudad.Size = New System.Drawing.Size(56, 20)
        Me.lblCiudad.TabIndex = 3
        Me.lblCiudad.Text = "Ciudad"
        '
        'lblSedeNombre
        '
        Me.lblSedeNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSedeNombre.AutoSize = True
        Me.lblSedeNombre.Location = New System.Drawing.Point(259, 10)
        Me.lblSedeNombre.Name = "lblSedeNombre"
        Me.lblSedeNombre.Size = New System.Drawing.Size(101, 20)
        Me.lblSedeNombre.TabIndex = 4
        Me.lblSedeNombre.Text = "Nombre Sede"
        '
        'lblColonia
        '
        Me.lblColonia.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Location = New System.Drawing.Point(404, 10)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(60, 20)
        Me.lblColonia.TabIndex = 7
        Me.lblColonia.Text = "Colonia"
        '
        'txtColonia
        '
        Me.txtColonia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtColonia.Enabled = False
        Me.txtColonia.Location = New System.Drawing.Point(375, 43)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(118, 27)
        Me.txtColonia.TabIndex = 9
        '
        'lblNumeroExt
        '
        Me.lblNumeroExt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNumeroExt.AutoSize = True
        Me.lblNumeroExt.Location = New System.Drawing.Point(624, 10)
        Me.lblNumeroExt.Name = "lblNumeroExt"
        Me.lblNumeroExt.Size = New System.Drawing.Size(118, 20)
        Me.lblNumeroExt.TabIndex = 11
        Me.lblNumeroExt.Text = "Numero Exterior"
        '
        'Calle
        '
        Me.Calle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Calle.AutoSize = True
        Me.Calle.Location = New System.Drawing.Point(537, 10)
        Me.Calle.Name = "Calle"
        Me.Calle.Size = New System.Drawing.Size(42, 20)
        Me.Calle.TabIndex = 10
        Me.Calle.Text = "Calle"
        '
        'txtCalle
        '
        Me.txtCalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCalle.Enabled = False
        Me.txtCalle.Location = New System.Drawing.Point(499, 43)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(118, 27)
        Me.txtCalle.TabIndex = 12
        '
        'txtNumExt
        '
        Me.txtNumExt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNumExt.Enabled = False
        Me.txtNumExt.Location = New System.Drawing.Point(623, 43)
        Me.txtNumExt.Name = "txtNumExt"
        Me.txtNumExt.Size = New System.Drawing.Size(121, 27)
        Me.txtNumExt.TabIndex = 13
        '
        'cboCiudad
        '
        Me.cboCiudad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboCiudad.FormattingEnabled = True
        Me.cboCiudad.Location = New System.Drawing.Point(127, 43)
        Me.cboCiudad.Name = "cboCiudad"
        Me.cboCiudad.Size = New System.Drawing.Size(118, 28)
        Me.cboCiudad.TabIndex = 14
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
        Me.dgvDatos.Size = New System.Drawing.Size(747, 294)
        Me.dgvDatos.TabIndex = 41
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(196, 12)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(40, 40)
        Me.btnCancelar.TabIndex = 40
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(150, 12)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(40, 40)
        Me.btnEliminar.TabIndex = 39
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Enabled = False
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(104, 12)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(40, 40)
        Me.btnModificar.TabIndex = 38
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(58, 12)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 40)
        Me.btnGuardar.TabIndex = 37
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(12, 12)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(40, 40)
        Me.btnNuevo.TabIndex = 36
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'frmAgregarSede
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 450)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Name = "frmAgregarSede"
        Me.Text = "Agregar Sede"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents TableLayoutPanel2 As TableLayoutPanel
    Private WithEvents txtIdSede As TextBox
    Private WithEvents lblIdSede As Label
    Private WithEvents txtNombre As TextBox
    Private WithEvents lblCiudad As Label
    Private WithEvents lblSedeNombre As Label
    Private WithEvents lblColonia As Label
    Friend WithEvents txtColonia As TextBox
    Friend WithEvents lblNumeroExt As Label
    Friend WithEvents Calle As Label
    Private WithEvents dgvDatos As DataGridView
    Private WithEvents btnCancelar As Button
    Private WithEvents btnEliminar As Button
    Private WithEvents btnModificar As Button
    Private WithEvents btnGuardar As Button
    Private WithEvents btnNuevo As Button
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents txtNumExt As TextBox
    Friend WithEvents cboCiudad As ComboBox
End Class
