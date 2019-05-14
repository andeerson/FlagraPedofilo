<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btAssistir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btgravar = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AbrirProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesligarFecharToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CONFIGURAÇÃOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QUEMSOMOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SOBREToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btAssistir
        '
        Me.btAssistir.Enabled = False
        Me.btAssistir.ForeColor = System.Drawing.Color.Black
        Me.btAssistir.Location = New System.Drawing.Point(179, 19)
        Me.btAssistir.Name = "btAssistir"
        Me.btAssistir.Size = New System.Drawing.Size(144, 42)
        Me.btAssistir.TabIndex = 2
        Me.btAssistir.Text = "Assistir"
        Me.btAssistir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btgravar)
        Me.GroupBox1.Controls.Add(Me.btAssistir)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(10, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 77)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'btgravar
        '
        Me.btgravar.ForeColor = System.Drawing.Color.Black
        Me.btgravar.Location = New System.Drawing.Point(12, 19)
        Me.btgravar.Name = "btgravar"
        Me.btgravar.Size = New System.Drawing.Size(145, 42)
        Me.btgravar.TabIndex = 1
        Me.btgravar.Text = "Gravar"
        Me.btgravar.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Ant-Spyware"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirProgramaToolStripMenuItem, Me.DesligarFecharToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(190, 48)
        '
        'AbrirProgramaToolStripMenuItem
        '
        Me.AbrirProgramaToolStripMenuItem.Name = "AbrirProgramaToolStripMenuItem"
        Me.AbrirProgramaToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.AbrirProgramaToolStripMenuItem.Text = "Abrir Controle de Pais"
        '
        'DesligarFecharToolStripMenuItem
        '
        Me.DesligarFecharToolStripMenuItem.Name = "DesligarFecharToolStripMenuItem"
        Me.DesligarFecharToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.DesligarFecharToolStripMenuItem.Text = "Desligar/Fechar"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CONFIGURAÇÃOToolStripMenuItem, Me.QUEMSOMOSToolStripMenuItem, Me.SOBREToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(361, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CONFIGURAÇÃOToolStripMenuItem
        '
        Me.CONFIGURAÇÃOToolStripMenuItem.Name = "CONFIGURAÇÃOToolStripMenuItem"
        Me.CONFIGURAÇÃOToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.CONFIGURAÇÃOToolStripMenuItem.Text = "CONFIGURAÇÃO"
        '
        'QUEMSOMOSToolStripMenuItem
        '
        Me.QUEMSOMOSToolStripMenuItem.Name = "QUEMSOMOSToolStripMenuItem"
        Me.QUEMSOMOSToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.QUEMSOMOSToolStripMenuItem.Text = "QUEM SOMOS"
        '
        'SOBREToolStripMenuItem
        '
        Me.SOBREToolStripMenuItem.Name = "SOBREToolStripMenuItem"
        Me.SOBREToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.SOBREToolStripMenuItem.Text = "SOBRE"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Fuchsia
        Me.ClientSize = New System.Drawing.Size(361, 116)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MAIS SEGURANÇA PARA SUA FAMILIA"
        Me.GroupBox1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btgravar As System.Windows.Forms.Button
    Friend WithEvents btAssistir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AbrirProgramaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesligarFecharToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents QUEMSOMOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CONFIGURAÇÃOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SOBREToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
