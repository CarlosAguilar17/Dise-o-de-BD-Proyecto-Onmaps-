<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNuevoParticipante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevoParticipante))
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtIdParticipante = New System.Windows.Forms.TextBox()
        Me.txtGrado = New System.Windows.Forms.TextBox()
        Me.lblIdParticipante = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblIdSede = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPaterno = New System.Windows.Forms.TextBox()
        Me.txtMaterno = New System.Windows.Forms.TextBox()
        Me.lblGrado = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboSede = New System.Windows.Forms.ComboBox()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
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
        Me.dgvDatos.Size = New System.Drawing.Size(647, 274)
        Me.dgvDatos.TabIndex = 20
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(196, 12)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(40, 40)
        Me.btnCancelar.TabIndex = 19
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(150, 12)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(40, 40)
        Me.btnEliminar.TabIndex = 18
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Enabled = False
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(104, 12)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(40, 40)
        Me.btnModificar.TabIndex = 17
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(58, 12)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 40)
        Me.btnGuardar.TabIndex = 16
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(12, 12)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(40, 40)
        Me.btnNuevo.TabIndex = 15
        Me.btnNuevo.UseVisualStyleBackColor = True
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
        Me.TableLayoutPanel2.Controls.Add(Me.txtIdParticipante, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtGrado, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblIdParticipante, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblIdSede, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtNombre, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtPaterno, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtMaterno, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblGrado, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cboSede, 5, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 58)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(647, 80)
        Me.TableLayoutPanel2.TabIndex = 21
        '
        'txtIdParticipante
        '
        Me.txtIdParticipante.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtIdParticipante.Enabled = False
        Me.txtIdParticipante.Location = New System.Drawing.Point(3, 43)
        Me.txtIdParticipante.Name = "txtIdParticipante"
        Me.txtIdParticipante.ReadOnly = True
        Me.txtIdParticipante.Size = New System.Drawing.Size(101, 27)
        Me.txtIdParticipante.TabIndex = 0
        '
        'txtGrado
        '
        Me.txtGrado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtGrado.Enabled = False
        Me.txtGrado.Location = New System.Drawing.Point(110, 43)
        Me.txtGrado.Name = "txtGrado"
        Me.txtGrado.Size = New System.Drawing.Size(101, 27)
        Me.txtGrado.TabIndex = 1
        '
        'lblIdParticipante
        '
        Me.lblIdParticipante.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblIdParticipante.AutoSize = True
        Me.lblIdParticipante.Location = New System.Drawing.Point(3, 10)
        Me.lblIdParticipante.Name = "lblIdParticipante"
        Me.lblIdParticipante.Size = New System.Drawing.Size(100, 20)
        Me.lblIdParticipante.TabIndex = 2
        Me.lblIdParticipante.Text = "IdParticipante"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(339, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 40)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Apellido Paterno"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(446, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 40)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Apellido Materno"
        '
        'lblIdSede
        '
        Me.lblIdSede.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblIdSede.AutoSize = True
        Me.lblIdSede.Location = New System.Drawing.Point(570, 10)
        Me.lblIdSede.Name = "lblIdSede"
        Me.lblIdSede.Size = New System.Drawing.Size(42, 20)
        Me.lblIdSede.TabIndex = 7
        Me.lblIdSede.Text = "Sede"
        '
        'txtNombre
        '
        Me.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(217, 43)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(101, 27)
        Me.txtNombre.TabIndex = 8
        '
        'txtPaterno
        '
        Me.txtPaterno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPaterno.Enabled = False
        Me.txtPaterno.Location = New System.Drawing.Point(324, 43)
        Me.txtPaterno.Name = "txtPaterno"
        Me.txtPaterno.Size = New System.Drawing.Size(101, 27)
        Me.txtPaterno.TabIndex = 9
        '
        'txtMaterno
        '
        Me.txtMaterno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMaterno.Enabled = False
        Me.txtMaterno.Location = New System.Drawing.Point(431, 43)
        Me.txtMaterno.Name = "txtMaterno"
        Me.txtMaterno.Size = New System.Drawing.Size(101, 27)
        Me.txtMaterno.TabIndex = 10
        '
        'lblGrado
        '
        Me.lblGrado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGrado.AutoSize = True
        Me.lblGrado.Location = New System.Drawing.Point(135, 10)
        Me.lblGrado.Name = "lblGrado"
        Me.lblGrado.Size = New System.Drawing.Size(50, 20)
        Me.lblGrado.TabIndex = 3
        Me.lblGrado.Text = "Grado"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(235, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre"
        '
        'cboSede
        '
        Me.cboSede.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboSede.FormattingEnabled = True
        Me.cboSede.Location = New System.Drawing.Point(538, 43)
        Me.cboSede.Name = "cboSede"
        Me.cboSede.Size = New System.Drawing.Size(106, 28)
        Me.cboSede.TabIndex = 11
        '
        'frmNuevoParticipante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 430)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Name = "frmNuevoParticipante"
        Me.Text = "Nuevo Participante"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents dgvDatos As DataGridView
    Private WithEvents btnCancelar As Button
    Private WithEvents btnEliminar As Button
    Private WithEvents btnModificar As Button
    Private WithEvents btnGuardar As Button
    Private WithEvents btnNuevo As Button
    Private WithEvents TableLayoutPanel2 As TableLayoutPanel
    Private WithEvents txtIdParticipante As TextBox
    Private WithEvents txtGrado As TextBox
    Private WithEvents lblIdParticipante As Label
    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Private WithEvents lblIdSede As Label
    Private WithEvents txtNombre As TextBox
    Private WithEvents txtPaterno As TextBox
    Private WithEvents txtMaterno As TextBox
    Private WithEvents lblGrado As Label
    Private WithEvents Label3 As Label
    Friend WithEvents cboSede As ComboBox
End Class
