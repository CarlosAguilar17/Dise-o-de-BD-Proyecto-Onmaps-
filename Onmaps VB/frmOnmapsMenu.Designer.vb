<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOnmapsMenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.NuevoPersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuNuevoPersonal = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuNuevoParticipante = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuNuevoExamen = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAgregarCiudad = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAgregarSede = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 28)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoPersonalToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'NuevoPersonalToolStripMenuItem
        '
        Me.NuevoPersonalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuNuevoPersonal, Me.MenuNuevoParticipante, Me.MenuNuevoExamen, Me.MenuAgregarCiudad, Me.MenuAgregarSede})
        Me.NuevoPersonalToolStripMenuItem.Name = "NuevoPersonalToolStripMenuItem"
        Me.NuevoPersonalToolStripMenuItem.Size = New System.Drawing.Size(177, 24)
        Me.NuevoPersonalToolStripMenuItem.Text = "Opciones de Agregado"
        '
        'MenuNuevoPersonal
        '
        Me.MenuNuevoPersonal.Name = "MenuNuevoPersonal"
        Me.MenuNuevoPersonal.Size = New System.Drawing.Size(224, 26)
        Me.MenuNuevoPersonal.Text = "Nuevo Personal"
        '
        'MenuNuevoParticipante
        '
        Me.MenuNuevoParticipante.Name = "MenuNuevoParticipante"
        Me.MenuNuevoParticipante.Size = New System.Drawing.Size(224, 26)
        Me.MenuNuevoParticipante.Text = "Nuevo Participante"
        '
        'MenuNuevoExamen
        '
        Me.MenuNuevoExamen.Name = "MenuNuevoExamen"
        Me.MenuNuevoExamen.Size = New System.Drawing.Size(224, 26)
        Me.MenuNuevoExamen.Text = "Nuevo Examen"
        '
        'MenuAgregarCiudad
        '
        Me.MenuAgregarCiudad.Name = "MenuAgregarCiudad"
        Me.MenuAgregarCiudad.Size = New System.Drawing.Size(224, 26)
        Me.MenuAgregarCiudad.Text = "Agregar Ciudad"
        '
        'MenuAgregarSede
        '
        Me.MenuAgregarSede.Name = "MenuAgregarSede"
        Me.MenuAgregarSede.Size = New System.Drawing.Size(224, 26)
        Me.MenuAgregarSede.Text = "Agregar Sede"
        '
        'frmOnmapsMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmOnmapsMenu"
        Me.Text = "OnmapsMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents NuevoPersonalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuNuevoPersonal As ToolStripMenuItem
    Friend WithEvents MenuNuevoParticipante As ToolStripMenuItem
    Friend WithEvents MenuNuevoExamen As ToolStripMenuItem
    Friend WithEvents MenuCiudad As ToolStripMenuItem
    Friend WithEvents MenuAgregarSede As ToolStripMenuItem
    Friend WithEvents MenuAgregarCiudad As ToolStripMenuItem
End Class
