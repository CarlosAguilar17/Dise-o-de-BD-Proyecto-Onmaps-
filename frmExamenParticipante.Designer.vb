<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExamenParticipante
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
        TableLayoutPanel2 = New TableLayoutPanel()
        txtIdEstado = New TextBox()
        txtEstado = New TextBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TableLayoutPanel3 = New TableLayoutPanel()
        lblIdExamen = New Label()
        txtIdExamen = New TextBox()
        cboExamen = New ComboBox()
        txtNombre = New TextBox()
        lblnombre = New Label()
        lblParticipante = New Label()
        cboParticipante = New ComboBox()
        btnAgregarParticipante = New Button()
        lblSigExamen = New Label()
        btnAgregarExamen = New Button()
        btnEliminarParticipante = New Button()
        btnEliminarExamen = New Button()
        dgvExamen = New DataGridView()
        DgvParticipante = New DataGridView()
        DgvSigExamen = New DataGridView()
        TableLayoutPanel4 = New TableLayoutPanel()
        ComboBox1 = New ComboBox()
        TextBox4 = New TextBox()
        TableLayoutPanel5 = New TableLayoutPanel()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        CType(dgvExamen, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgvParticipante, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgvSigExamen, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.AutoSize = True
        TableLayoutPanel2.ColumnCount = 4
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.66667F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.66667F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.66667F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.66667F))
        TableLayoutPanel2.Controls.Add(txtIdEstado, 0, 1)
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(200, 100)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' txtIdEstado
        ' 
        txtIdEstado.Dock = DockStyle.Fill
        txtIdEstado.Enabled = False
        txtIdEstado.Location = New Point(3, 23)
        txtIdEstado.Name = "txtIdEstado"
        txtIdEstado.ReadOnly = True
        txtIdEstado.Size = New Size(44, 27)
        txtIdEstado.TabIndex = 0
        ' 
        ' txtEstado
        ' 
        txtEstado.Dock = DockStyle.Fill
        txtEstado.Enabled = False
        txtEstado.Location = New Point(53, 3)
        txtEstado.Name = "txtEstado"
        txtEstado.Size = New Size(44, 27)
        txtEstado.TabIndex = 1
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.AutoSize = True
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.66667F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.66667F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.66667F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.66667F))
        TableLayoutPanel1.Controls.Add(TextBox1, 0, 1)
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(200, 100)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.Dock = DockStyle.Fill
        TextBox1.Enabled = False
        TextBox1.Location = New Point(3, 23)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(44, 27)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Dock = DockStyle.Fill
        TextBox2.Enabled = False
        TextBox2.Location = New Point(53, 3)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(44, 27)
        TextBox2.TabIndex = 1
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.AutoSize = True
        TableLayoutPanel3.ColumnCount = 6
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.66682F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.66682F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.66659F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.66659F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.66659F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.66659F))
        TableLayoutPanel3.Controls.Add(lblIdExamen, 0, 0)
        TableLayoutPanel3.Controls.Add(txtIdExamen, 0, 1)
        TableLayoutPanel3.Controls.Add(cboExamen, 4, 1)
        TableLayoutPanel3.Controls.Add(txtNombre, 1, 1)
        TableLayoutPanel3.Controls.Add(lblnombre, 1, 0)
        TableLayoutPanel3.Controls.Add(lblParticipante, 2, 0)
        TableLayoutPanel3.Controls.Add(cboParticipante, 2, 1)
        TableLayoutPanel3.Controls.Add(btnAgregarParticipante, 3, 1)
        TableLayoutPanel3.Controls.Add(lblSigExamen, 4, 0)
        TableLayoutPanel3.Controls.Add(btnAgregarExamen, 5, 1)
        TableLayoutPanel3.Controls.Add(btnEliminarParticipante, 3, 0)
        TableLayoutPanel3.Controls.Add(btnEliminarExamen, 5, 0)
        TableLayoutPanel3.Location = New Point(14, 12)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Size = New Size(719, 82)
        TableLayoutPanel3.TabIndex = 42
        ' 
        ' lblIdExamen
        ' 
        lblIdExamen.Anchor = AnchorStyles.None
        lblIdExamen.AutoSize = True
        lblIdExamen.Location = New Point(22, 10)
        lblIdExamen.Name = "lblIdExamen"
        lblIdExamen.Size = New Size(74, 20)
        lblIdExamen.TabIndex = 54
        lblIdExamen.Text = "idExamen"
        ' 
        ' txtIdExamen
        ' 
        txtIdExamen.Dock = DockStyle.Fill
        txtIdExamen.Enabled = False
        txtIdExamen.Location = New Point(3, 44)
        txtIdExamen.Name = "txtIdExamen"
        txtIdExamen.ReadOnly = True
        txtIdExamen.Size = New Size(113, 27)
        txtIdExamen.TabIndex = 53
        ' 
        ' cboExamen
        ' 
        cboExamen.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cboExamen.FormattingEnabled = True
        cboExamen.Location = New Point(479, 47)
        cboExamen.Name = "cboExamen"
        cboExamen.Size = New Size(113, 28)
        cboExamen.TabIndex = 46
        ' 
        ' txtNombre
        ' 
        txtNombre.Dock = DockStyle.Fill
        txtNombre.Enabled = False
        txtNombre.Location = New Point(122, 44)
        txtNombre.Name = "txtNombre"
        txtNombre.ReadOnly = True
        txtNombre.Size = New Size(113, 27)
        txtNombre.TabIndex = 0
        ' 
        ' lblnombre
        ' 
        lblnombre.Anchor = AnchorStyles.None
        lblnombre.AutoSize = True
        lblnombre.Location = New Point(146, 10)
        lblnombre.Name = "lblnombre"
        lblnombre.Size = New Size(64, 20)
        lblnombre.TabIndex = 2
        lblnombre.Text = "Nombre"
        ' 
        ' lblParticipante
        ' 
        lblParticipante.Anchor = AnchorStyles.None
        lblParticipante.AutoSize = True
        lblParticipante.Location = New Point(254, 10)
        lblParticipante.Name = "lblParticipante"
        lblParticipante.Size = New Size(87, 20)
        lblParticipante.TabIndex = 4
        lblParticipante.Text = "Participante"
        ' 
        ' cboParticipante
        ' 
        cboParticipante.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cboParticipante.FormattingEnabled = True
        cboParticipante.Location = New Point(241, 47)
        cboParticipante.Name = "cboParticipante"
        cboParticipante.Size = New Size(113, 28)
        cboParticipante.TabIndex = 10
        ' 
        ' btnAgregarParticipante
        ' 
        btnAgregarParticipante.Dock = DockStyle.Fill
        btnAgregarParticipante.Location = New Point(360, 44)
        btnAgregarParticipante.Name = "btnAgregarParticipante"
        btnAgregarParticipante.Size = New Size(113, 35)
        btnAgregarParticipante.TabIndex = 11
        btnAgregarParticipante.Text = "Agregar"
        btnAgregarParticipante.UseVisualStyleBackColor = True
        ' 
        ' lblSigExamen
        ' 
        lblSigExamen.Anchor = AnchorStyles.None
        lblSigExamen.AutoSize = True
        lblSigExamen.Location = New Point(491, 10)
        lblSigExamen.Name = "lblSigExamen"
        lblSigExamen.Size = New Size(89, 20)
        lblSigExamen.TabIndex = 12
        lblSigExamen.Text = "Sig. Examen"
        ' 
        ' btnAgregarExamen
        ' 
        btnAgregarExamen.Dock = DockStyle.Fill
        btnAgregarExamen.Location = New Point(598, 44)
        btnAgregarExamen.Name = "btnAgregarExamen"
        btnAgregarExamen.Size = New Size(118, 35)
        btnAgregarExamen.TabIndex = 47
        btnAgregarExamen.Text = "Agregar"
        btnAgregarExamen.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarParticipante
        ' 
        btnEliminarParticipante.Dock = DockStyle.Fill
        btnEliminarParticipante.Location = New Point(360, 3)
        btnEliminarParticipante.Name = "btnEliminarParticipante"
        btnEliminarParticipante.Size = New Size(113, 35)
        btnEliminarParticipante.TabIndex = 48
        btnEliminarParticipante.Text = "Eliminar"
        btnEliminarParticipante.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarExamen
        ' 
        btnEliminarExamen.Dock = DockStyle.Fill
        btnEliminarExamen.Location = New Point(598, 3)
        btnEliminarExamen.Name = "btnEliminarExamen"
        btnEliminarExamen.Size = New Size(118, 35)
        btnEliminarExamen.TabIndex = 49
        btnEliminarExamen.Text = "Eliminar"
        btnEliminarExamen.UseVisualStyleBackColor = True
        ' 
        ' dgvExamen
        ' 
        dgvExamen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvExamen.Dock = DockStyle.Fill
        dgvExamen.Location = New Point(3, 3)
        dgvExamen.Name = "dgvExamen"
        dgvExamen.RowHeadersWidth = 51
        dgvExamen.Size = New Size(233, 462)
        dgvExamen.TabIndex = 41
        ' 
        ' DgvParticipante
        ' 
        DgvParticipante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvParticipante.Dock = DockStyle.Fill
        DgvParticipante.Location = New Point(242, 3)
        DgvParticipante.Name = "DgvParticipante"
        DgvParticipante.RowHeadersWidth = 51
        DgvParticipante.Size = New Size(233, 462)
        DgvParticipante.TabIndex = 43
        ' 
        ' DgvSigExamen
        ' 
        DgvSigExamen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvSigExamen.Dock = DockStyle.Fill
        DgvSigExamen.Location = New Point(481, 3)
        DgvSigExamen.Name = "DgvSigExamen"
        DgvSigExamen.RowHeadersWidth = 51
        DgvSigExamen.Size = New Size(235, 462)
        DgvSigExamen.TabIndex = 44
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel4.AutoSize = True
        TableLayoutPanel4.ColumnCount = 5
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 13.04121F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 21.7397F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 21.7397F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 21.7397F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 21.7397F))
        TableLayoutPanel4.Controls.Add(ComboBox1, 3, 1)
        TableLayoutPanel4.Location = New Point(0, 0)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel4.Size = New Size(200, 100)
        TableLayoutPanel4.TabIndex = 0
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(115, 46)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(37, 28)
        ComboBox1.TabIndex = 46
        ' 
        ' TextBox4
        ' 
        TextBox4.Dock = DockStyle.Fill
        TextBox4.Enabled = False
        TextBox4.Location = New Point(3, 3)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(20, 27)
        TextBox4.TabIndex = 0
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel5.AutoSize = True
        TableLayoutPanel5.ColumnCount = 3
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel5.Controls.Add(dgvExamen, 0, 0)
        TableLayoutPanel5.Controls.Add(DgvSigExamen, 2, 0)
        TableLayoutPanel5.Controls.Add(DgvParticipante, 1, 0)
        TableLayoutPanel5.Location = New Point(14, 100)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel5.Size = New Size(719, 468)
        TableLayoutPanel5.TabIndex = 45
        ' 
        ' frmExamenParticipante
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(745, 580)
        Controls.Add(TableLayoutPanel5)
        Controls.Add(TableLayoutPanel3)
        Name = "frmExamenParticipante"
        Text = "Asignar Participantes"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        CType(dgvExamen, ComponentModel.ISupportInitialize).EndInit()
        CType(DgvParticipante, ComponentModel.ISupportInitialize).EndInit()
        CType(DgvSigExamen, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel5.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Private WithEvents txtIdEstado As TextBox
    Private WithEvents txtEstado As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Private WithEvents TextBox1 As TextBox
    Private WithEvents TextBox2 As TextBox
    Private WithEvents TableLayoutPanel3 As TableLayoutPanel
    Private WithEvents txtNombre As TextBox
    Private WithEvents lblnombre As Label
    Private WithEvents lblParticipante As Label
    Friend WithEvents cboParticipante As ComboBox
    Private WithEvents dgvExamen As DataGridView
    Private WithEvents DgvParticipante As DataGridView
    Private WithEvents DgvSigExamen As DataGridView
    Friend WithEvents btnAgregarParticipante As Button
    Private WithEvents lblSigExamen As Label
    Friend WithEvents cboExamen As ComboBox
    Friend WithEvents btnAgregarExamen As Button
    Friend WithEvents btnEliminarParticipante As Button
    Friend WithEvents btnEliminarExamen As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents ComboBox1 As ComboBox
    Private WithEvents TextBox4 As TextBox
    Private WithEvents TableLayoutPanel5 As TableLayoutPanel
    Private WithEvents lblIdExamen As Label
    Private WithEvents txtIdExamen As TextBox
End Class
