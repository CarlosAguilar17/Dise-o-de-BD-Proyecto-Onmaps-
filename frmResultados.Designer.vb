<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResultados
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
        TableLayoutPanel5 = New TableLayoutPanel()
        dgvExamen = New DataGridView()
        DgvSigExamen = New DataGridView()
        DgvParticipante = New DataGridView()
        TableLayoutPanel3 = New TableLayoutPanel()
        lblIdExamen = New Label()
        txtIdExamen = New TextBox()
        txtNombre = New TextBox()
        lblnombre = New Label()
        lblParticipante = New Label()
        btnActualizarEvaluacion = New Button()
        lblSigExamen = New Label()
        btnAgregarExamen = New Button()
        cboParticipante = New ComboBox()
        TextBox1 = New TextBox()
        TableLayoutPanel5.SuspendLayout()
        CType(dgvExamen, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgvSigExamen, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgvParticipante, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
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
        TableLayoutPanel5.Location = New Point(28, 98)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel5.Size = New Size(676, 308)
        TableLayoutPanel5.TabIndex = 47
        ' 
        ' dgvExamen
        ' 
        dgvExamen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvExamen.Dock = DockStyle.Fill
        dgvExamen.Location = New Point(3, 3)
        dgvExamen.Name = "dgvExamen"
        dgvExamen.RowHeadersWidth = 51
        dgvExamen.Size = New Size(219, 302)
        dgvExamen.TabIndex = 41
        ' 
        ' DgvSigExamen
        ' 
        DgvSigExamen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvSigExamen.Dock = DockStyle.Fill
        DgvSigExamen.Location = New Point(453, 3)
        DgvSigExamen.Name = "DgvSigExamen"
        DgvSigExamen.RowHeadersWidth = 51
        DgvSigExamen.Size = New Size(220, 302)
        DgvSigExamen.TabIndex = 44
        ' 
        ' DgvParticipante
        ' 
        DgvParticipante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvParticipante.Dock = DockStyle.Fill
        DgvParticipante.Location = New Point(228, 3)
        DgvParticipante.Name = "DgvParticipante"
        DgvParticipante.RowHeadersWidth = 51
        DgvParticipante.Size = New Size(219, 302)
        DgvParticipante.TabIndex = 43
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
        TableLayoutPanel3.Controls.Add(txtNombre, 1, 1)
        TableLayoutPanel3.Controls.Add(lblnombre, 1, 0)
        TableLayoutPanel3.Controls.Add(lblParticipante, 2, 0)
        TableLayoutPanel3.Controls.Add(btnActualizarEvaluacion, 3, 1)
        TableLayoutPanel3.Controls.Add(lblSigExamen, 4, 0)
        TableLayoutPanel3.Controls.Add(btnAgregarExamen, 5, 1)
        TableLayoutPanel3.Controls.Add(cboParticipante, 3, 0)
        TableLayoutPanel3.Controls.Add(TextBox1, 2, 1)
        TableLayoutPanel3.Location = New Point(28, 10)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Size = New Size(676, 82)
        TableLayoutPanel3.TabIndex = 46
        ' 
        ' lblIdExamen
        ' 
        lblIdExamen.Anchor = AnchorStyles.None
        lblIdExamen.AutoSize = True
        lblIdExamen.Location = New Point(19, 10)
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
        txtIdExamen.Size = New Size(106, 27)
        txtIdExamen.TabIndex = 53
        ' 
        ' txtNombre
        ' 
        txtNombre.Dock = DockStyle.Fill
        txtNombre.Enabled = False
        txtNombre.Location = New Point(115, 44)
        txtNombre.Name = "txtNombre"
        txtNombre.ReadOnly = True
        txtNombre.Size = New Size(106, 27)
        txtNombre.TabIndex = 0
        ' 
        ' lblnombre
        ' 
        lblnombre.Anchor = AnchorStyles.None
        lblnombre.AutoSize = True
        lblnombre.Location = New Point(136, 10)
        lblnombre.Name = "lblnombre"
        lblnombre.Size = New Size(64, 20)
        lblnombre.TabIndex = 2
        lblnombre.Text = "Nombre"
        ' 
        ' lblParticipante
        ' 
        lblParticipante.Anchor = AnchorStyles.None
        lblParticipante.AutoSize = True
        lblParticipante.Location = New Point(236, 10)
        lblParticipante.Name = "lblParticipante"
        lblParticipante.Size = New Size(87, 20)
        lblParticipante.TabIndex = 4
        lblParticipante.Text = "Participante"
        ' 
        ' btnActualizarEvaluacion
        ' 
        btnActualizarEvaluacion.Dock = DockStyle.Fill
        btnActualizarEvaluacion.Location = New Point(339, 44)
        btnActualizarEvaluacion.Name = "btnActualizarEvaluacion"
        btnActualizarEvaluacion.Size = New Size(106, 35)
        btnActualizarEvaluacion.TabIndex = 11
        btnActualizarEvaluacion.Text = "Agregar"
        btnActualizarEvaluacion.UseVisualStyleBackColor = True
        ' 
        ' lblSigExamen
        ' 
        lblSigExamen.Anchor = AnchorStyles.None
        lblSigExamen.AutoSize = True
        lblSigExamen.Location = New Point(459, 10)
        lblSigExamen.Name = "lblSigExamen"
        lblSigExamen.Size = New Size(89, 20)
        lblSigExamen.TabIndex = 12
        lblSigExamen.Text = "Sig. Examen"
        ' 
        ' btnAgregarExamen
        ' 
        btnAgregarExamen.Dock = DockStyle.Fill
        btnAgregarExamen.Location = New Point(563, 44)
        btnAgregarExamen.Name = "btnAgregarExamen"
        btnAgregarExamen.Size = New Size(110, 35)
        btnAgregarExamen.TabIndex = 47
        btnAgregarExamen.Text = "Agregar"
        btnAgregarExamen.UseVisualStyleBackColor = True
        ' 
        ' cboParticipante
        ' 
        cboParticipante.Dock = DockStyle.Fill
        cboParticipante.FormattingEnabled = True
        cboParticipante.Location = New Point(339, 3)
        cboParticipante.Name = "cboParticipante"
        cboParticipante.Size = New Size(106, 28)
        cboParticipante.TabIndex = 55
        ' 
        ' TextBox1
        ' 
        TextBox1.Dock = DockStyle.Fill
        TextBox1.Location = New Point(227, 44)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(106, 27)
        TextBox1.TabIndex = 56
        ' 
        ' frmResultados
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(732, 416)
        Controls.Add(TableLayoutPanel5)
        Controls.Add(TableLayoutPanel3)
        Name = "frmResultados"
        Text = "Resultados"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel5.ResumeLayout(False)
        CType(dgvExamen, ComponentModel.ISupportInitialize).EndInit()
        CType(DgvSigExamen, ComponentModel.ISupportInitialize).EndInit()
        CType(DgvParticipante, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Private WithEvents TableLayoutPanel5 As TableLayoutPanel
    Private WithEvents dgvExamen As DataGridView
    Private WithEvents DgvSigExamen As DataGridView
    Private WithEvents DgvParticipante As DataGridView
    Private WithEvents TableLayoutPanel3 As TableLayoutPanel
    Private WithEvents lblIdExamen As Label
    Private WithEvents txtIdExamen As TextBox
    Private WithEvents txtNombre As TextBox
    Private WithEvents lblnombre As Label
    Private WithEvents lblParticipante As Label
    Friend WithEvents btnActualizarEvaluacion As Button
    Private WithEvents lblSigExamen As Label
    Friend WithEvents btnAgregarExamen As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnImprimir As Button
    Friend WithEvents cboParticipante As ComboBox
    Friend WithEvents TextBox1 As TextBox

End Class
