<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarCiudad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarCiudad))
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtIdCiudad = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblidCiudad = New System.Windows.Forms.Label()
        Me.txtDelegado = New System.Windows.Forms.TextBox()
        Me.lblCiudad = New System.Windows.Forms.Label()
        Me.idDelegado = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
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
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtIdCiudad, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtNombre, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblidCiudad, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtDelegado, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblCiudad, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.idDelegado, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblCorreo, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtCorreo, 3, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 58)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(525, 80)
        Me.TableLayoutPanel2.TabIndex = 35
        '
        'txtIdCiudad
        '
        Me.txtIdCiudad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtIdCiudad.Enabled = False
        Me.txtIdCiudad.Location = New System.Drawing.Point(3, 43)
        Me.txtIdCiudad.Name = "txtIdCiudad"
        Me.txtIdCiudad.ReadOnly = True
        Me.txtIdCiudad.Size = New System.Drawing.Size(125, 27)
        Me.txtIdCiudad.TabIndex = 0
        '
        'txtNombre
        '
        Me.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(134, 43)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(125, 27)
        Me.txtNombre.TabIndex = 1
        '
        'lblidCiudad
        '
        Me.lblidCiudad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblidCiudad.AutoSize = True
        Me.lblidCiudad.Location = New System.Drawing.Point(31, 10)
        Me.lblidCiudad.Name = "lblidCiudad"
        Me.lblidCiudad.Size = New System.Drawing.Size(69, 20)
        Me.lblidCiudad.TabIndex = 2
        Me.lblidCiudad.Text = "idCiudad"
        '
        'txtDelegado
        '
        Me.txtDelegado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDelegado.Enabled = False
        Me.txtDelegado.Location = New System.Drawing.Point(265, 43)
        Me.txtDelegado.Name = "txtDelegado"
        Me.txtDelegado.Size = New System.Drawing.Size(125, 27)
        Me.txtDelegado.TabIndex = 8
        '
        'lblCiudad
        '
        Me.lblCiudad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCiudad.AutoSize = True
        Me.lblCiudad.Location = New System.Drawing.Point(139, 10)
        Me.lblCiudad.Name = "lblCiudad"
        Me.lblCiudad.Size = New System.Drawing.Size(115, 20)
        Me.lblCiudad.TabIndex = 3
        Me.lblCiudad.Text = "Nombre Ciudad"
        '
        'idDelegado
        '
        Me.idDelegado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.idDelegado.AutoSize = True
        Me.idDelegado.Location = New System.Drawing.Point(281, 10)
        Me.idDelegado.Name = "idDelegado"
        Me.idDelegado.Size = New System.Drawing.Size(92, 20)
        Me.idDelegado.TabIndex = 4
        Me.idDelegado.Text = "Id Delegado"
        '
        'lblCorreo
        '
        Me.lblCorreo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(397, 10)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(124, 20)
        Me.lblCorreo.TabIndex = 7
        Me.lblCorreo.Text = "Correo Delegado"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(396, 43)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(125, 27)
        Me.txtCorreo.TabIndex = 9
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
        Me.dgvDatos.Size = New System.Drawing.Size(525, 294)
        Me.dgvDatos.TabIndex = 34
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(196, 12)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(40, 40)
        Me.btnCancelar.TabIndex = 33
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(150, 12)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(40, 40)
        Me.btnEliminar.TabIndex = 32
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Enabled = False
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(104, 12)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(40, 40)
        Me.btnModificar.TabIndex = 31
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(58, 12)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 40)
        Me.btnGuardar.TabIndex = 30
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(12, 12)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(40, 40)
        Me.btnNuevo.TabIndex = 29
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'frmAgregarCiudad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 450)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Name = "frmAgregarCiudad"
        Me.Text = "Agregar Ciudad"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents TableLayoutPanel2 As TableLayoutPanel
    Private WithEvents txtIdCiudad As TextBox
    Private WithEvents txtNombre As TextBox
    Private WithEvents lblidCiudad As Label
    Private WithEvents txtDelegado As TextBox
    Private WithEvents lblCiudad As Label
    Private WithEvents idDelegado As Label
    Private WithEvents lblCorreo As Label
    Friend WithEvents txtCorreo As TextBox
    Private WithEvents dgvDatos As DataGridView
    Private WithEvents btnCancelar As Button
    Private WithEvents btnEliminar As Button
    Private WithEvents btnModificar As Button
    Private WithEvents btnGuardar As Button
    Private WithEvents btnNuevo As Button
End Class
