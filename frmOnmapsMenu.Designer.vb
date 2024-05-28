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
        MenuStrip1 = New MenuStrip()
        MenuStrip2 = New MenuStrip()
        NuevoPersonalToolStripMenuItem = New ToolStripMenuItem()
        MenuNuevoPersonal = New ToolStripMenuItem()
        MenuNuevoParticipante = New ToolStripMenuItem()
        MenuNuevoExamen = New ToolStripMenuItem()
        MenuAgregarEstado = New ToolStripMenuItem()
        MenuAgregarSede = New ToolStripMenuItem()
        ResultadosToolStripMenuItem = New ToolStripMenuItem()
        MenuAsignarExamen = New ToolStripMenuItem()
        MenuResultados = New ToolStripMenuItem()
        MenuStrip2.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Location = New Point(0, 28)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.ImageScalingSize = New Size(20, 20)
        MenuStrip2.Items.AddRange(New ToolStripItem() {NuevoPersonalToolStripMenuItem, ResultadosToolStripMenuItem})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Size = New Size(800, 28)
        MenuStrip2.TabIndex = 1
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' NuevoPersonalToolStripMenuItem
        ' 
        NuevoPersonalToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MenuNuevoPersonal, MenuNuevoParticipante, MenuNuevoExamen, MenuAgregarEstado, MenuAgregarSede})
        NuevoPersonalToolStripMenuItem.Name = "NuevoPersonalToolStripMenuItem"
        NuevoPersonalToolStripMenuItem.Size = New Size(177, 24)
        NuevoPersonalToolStripMenuItem.Text = "Opciones de Agregado"
        ' 
        ' MenuNuevoPersonal
        ' 
        MenuNuevoPersonal.Name = "MenuNuevoPersonal"
        MenuNuevoPersonal.Size = New Size(217, 26)
        MenuNuevoPersonal.Text = "Nuevo Personal"
        ' 
        ' MenuNuevoParticipante
        ' 
        MenuNuevoParticipante.Name = "MenuNuevoParticipante"
        MenuNuevoParticipante.Size = New Size(217, 26)
        MenuNuevoParticipante.Text = "Nuevo Participante"
        ' 
        ' MenuNuevoExamen
        ' 
        MenuNuevoExamen.Name = "MenuNuevoExamen"
        MenuNuevoExamen.Size = New Size(217, 26)
        MenuNuevoExamen.Text = "Nuevo Examen"
        ' 
        ' MenuAgregarEstado
        ' 
        MenuAgregarEstado.Name = "MenuAgregarEstado"
        MenuAgregarEstado.Size = New Size(217, 26)
        MenuAgregarEstado.Text = "Agregar Estado"
        ' 
        ' MenuAgregarSede
        ' 
        MenuAgregarSede.Name = "MenuAgregarSede"
        MenuAgregarSede.Size = New Size(217, 26)
        MenuAgregarSede.Text = "Agregar Sede"
        ' 
        ' ResultadosToolStripMenuItem
        ' 
        ResultadosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MenuAsignarExamen, MenuResultados})
        ResultadosToolStripMenuItem.Name = "ResultadosToolStripMenuItem"
        ResultadosToolStripMenuItem.Size = New Size(95, 24)
        ResultadosToolStripMenuItem.Text = "Resultados"
        ' 
        ' MenuAsignarExamen
        ' 
        MenuAsignarExamen.Name = "MenuAsignarExamen"
        MenuAsignarExamen.Size = New Size(230, 26)
        MenuAsignarExamen.Text = "Asignar Participantes"
        ' 
        ' MenuResultados
        ' 
        MenuResultados.Name = "MenuResultados"
        MenuResultados.Size = New Size(230, 26)
        MenuResultados.Text = "Evaluar Resultados"
        ' 
        ' frmOnmapsMenu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        Controls.Add(MenuStrip2)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "frmOnmapsMenu"
        Text = "OnmapsMenu"
        WindowState = FormWindowState.Maximized
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents NuevoPersonalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuNuevoPersonal As ToolStripMenuItem
    Friend WithEvents MenuNuevoParticipante As ToolStripMenuItem
    Friend WithEvents MenuNuevoExamen As ToolStripMenuItem
    Friend WithEvents MenuCiudad As ToolStripMenuItem
    Friend WithEvents MenuAgregarSede As ToolStripMenuItem
    Friend WithEvents MenuAgregarEstado As ToolStripMenuItem
    Friend WithEvents ResultadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuAsignarExamen As ToolStripMenuItem
    Friend WithEvents MenuResultados As ToolStripMenuItem
End Class
