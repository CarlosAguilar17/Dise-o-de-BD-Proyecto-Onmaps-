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
        dgvDatos = New DataGridView()
        btnCancelar = New Button()
        btnEliminar = New Button()
        btnModificar = New Button()
        btnGuardar = New Button()
        btnNuevo = New Button()
        TableLayoutPanel2 = New TableLayoutPanel()
        txtIdParticipante = New TextBox()
        txtGrado = New TextBox()
        lblIdParticipante = New Label()
        Label1 = New Label()
        Label2 = New Label()
        lblIdSede = New Label()
        txtNombre = New TextBox()
        txtPaterno = New TextBox()
        txtMaterno = New TextBox()
        lblGrado = New Label()
        Label3 = New Label()
        cboSede = New ComboBox()
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
        dgvDatos.Size = New Size(647, 274)
        dgvDatos.TabIndex = 20
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Enabled = False
        btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), Image)
        btnCancelar.Location = New Point(196, 12)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(40, 40)
        btnCancelar.TabIndex = 19
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Enabled = False
        btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), Image)
        btnEliminar.Location = New Point(150, 12)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(40, 40)
        btnEliminar.TabIndex = 18
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnModificar
        ' 
        btnModificar.Enabled = False
        btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), Image)
        btnModificar.Location = New Point(104, 12)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(40, 40)
        btnModificar.TabIndex = 17
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Enabled = False
        btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), Image)
        btnGuardar.Location = New Point(58, 12)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(40, 40)
        btnGuardar.TabIndex = 16
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.BackgroundImageLayout = ImageLayout.Stretch
        btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), Image)
        btnNuevo.Location = New Point(12, 12)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(40, 40)
        btnNuevo.TabIndex = 15
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
        TableLayoutPanel2.Controls.Add(txtIdParticipante, 0, 1)
        TableLayoutPanel2.Controls.Add(txtGrado, 1, 1)
        TableLayoutPanel2.Controls.Add(lblIdParticipante, 0, 0)
        TableLayoutPanel2.Controls.Add(Label1, 3, 0)
        TableLayoutPanel2.Controls.Add(Label2, 4, 0)
        TableLayoutPanel2.Controls.Add(lblIdSede, 5, 0)
        TableLayoutPanel2.Controls.Add(txtNombre, 2, 1)
        TableLayoutPanel2.Controls.Add(txtPaterno, 3, 1)
        TableLayoutPanel2.Controls.Add(txtMaterno, 4, 1)
        TableLayoutPanel2.Controls.Add(lblGrado, 1, 0)
        TableLayoutPanel2.Controls.Add(Label3, 2, 0)
        TableLayoutPanel2.Controls.Add(cboSede, 5, 1)
        TableLayoutPanel2.Location = New Point(12, 58)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(647, 80)
        TableLayoutPanel2.TabIndex = 21
        ' 
        ' txtIdParticipante
        ' 
        txtIdParticipante.Dock = DockStyle.Fill
        txtIdParticipante.Enabled = False
        txtIdParticipante.Location = New Point(3, 43)
        txtIdParticipante.Name = "txtIdParticipante"
        txtIdParticipante.ReadOnly = True
        txtIdParticipante.Size = New Size(101, 27)
        txtIdParticipante.TabIndex = 0
        ' 
        ' txtGrado
        ' 
        txtGrado.Dock = DockStyle.Fill
        txtGrado.Enabled = False
        txtGrado.Location = New Point(110, 43)
        txtGrado.Name = "txtGrado"
        txtGrado.Size = New Size(101, 27)
        txtGrado.TabIndex = 1
        ' 
        ' lblIdParticipante
        ' 
        lblIdParticipante.Anchor = AnchorStyles.None
        lblIdParticipante.AutoSize = True
        lblIdParticipante.Location = New Point(3, 10)
        lblIdParticipante.Name = "lblIdParticipante"
        lblIdParticipante.Size = New Size(100, 20)
        lblIdParticipante.TabIndex = 2
        lblIdParticipante.Text = "IdParticipante"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Location = New Point(339, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 40)
        Label1.TabIndex = 5
        Label1.Text = "Apellido Paterno"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Location = New Point(446, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 40)
        Label2.TabIndex = 6
        Label2.Text = "Apellido Materno"
        ' 
        ' lblIdSede
        ' 
        lblIdSede.Anchor = AnchorStyles.None
        lblIdSede.AutoSize = True
        lblIdSede.Location = New Point(570, 10)
        lblIdSede.Name = "lblIdSede"
        lblIdSede.Size = New Size(42, 20)
        lblIdSede.TabIndex = 7
        lblIdSede.Text = "Sede"
        ' 
        ' txtNombre
        ' 
        txtNombre.Dock = DockStyle.Fill
        txtNombre.Enabled = False
        txtNombre.Location = New Point(217, 43)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(101, 27)
        txtNombre.TabIndex = 8
        ' 
        ' txtPaterno
        ' 
        txtPaterno.Dock = DockStyle.Fill
        txtPaterno.Enabled = False
        txtPaterno.Location = New Point(324, 43)
        txtPaterno.Name = "txtPaterno"
        txtPaterno.Size = New Size(101, 27)
        txtPaterno.TabIndex = 9
        ' 
        ' txtMaterno
        ' 
        txtMaterno.Dock = DockStyle.Fill
        txtMaterno.Enabled = False
        txtMaterno.Location = New Point(431, 43)
        txtMaterno.Name = "txtMaterno"
        txtMaterno.Size = New Size(101, 27)
        txtMaterno.TabIndex = 10
        ' 
        ' lblGrado
        ' 
        lblGrado.Anchor = AnchorStyles.None
        lblGrado.AutoSize = True
        lblGrado.Location = New Point(135, 10)
        lblGrado.Name = "lblGrado"
        lblGrado.Size = New Size(50, 20)
        lblGrado.TabIndex = 3
        lblGrado.Text = "Grado"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Location = New Point(235, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 20)
        Label3.TabIndex = 4
        Label3.Text = "Nombre"
        ' 
        ' cboSede
        ' 
        cboSede.Dock = DockStyle.Fill
        cboSede.FormattingEnabled = True
        cboSede.Location = New Point(538, 43)
        cboSede.Name = "cboSede"
        cboSede.Size = New Size(106, 28)
        cboSede.TabIndex = 11
        ' 
        ' frmNuevoParticipante
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(671, 430)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(dgvDatos)
        Controls.Add(btnCancelar)
        Controls.Add(btnEliminar)
        Controls.Add(btnModificar)
        Controls.Add(btnGuardar)
        Controls.Add(btnNuevo)
        Name = "frmNuevoParticipante"
        Text = "Nuevo Participante"
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
