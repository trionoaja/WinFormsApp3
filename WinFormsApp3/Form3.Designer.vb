<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        FormBukuToolStripMenuItem = New ToolStripMenuItem()
        FormAnggotaToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolStripStatusLabel2 = New ToolStripStatusLabel()
        Timer1 = New Timer(components)
        LaporanToolStripMenuItem = New ToolStripMenuItem()
        FormLaporanBukuToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, LaporanToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FormBukuToolStripMenuItem, FormAnggotaToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' FormBukuToolStripMenuItem
        ' 
        FormBukuToolStripMenuItem.Name = "FormBukuToolStripMenuItem"
        FormBukuToolStripMenuItem.Size = New Size(224, 26)
        FormBukuToolStripMenuItem.Text = "Form Buku"
        ' 
        ' FormAnggotaToolStripMenuItem
        ' 
        FormAnggotaToolStripMenuItem.Name = "FormAnggotaToolStripMenuItem"
        FormAnggotaToolStripMenuItem.Size = New Size(224, 26)
        FormAnggotaToolStripMenuItem.Text = "Form Anggota"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(224, 26)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, ToolStripStatusLabel2})
        StatusStrip1.Location = New Point(0, 424)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 26)
        StatusStrip1.TabIndex = 3
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(153, 20)
        ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        ' 
        ' ToolStripStatusLabel2
        ' 
        ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        ToolStripStatusLabel2.Size = New Size(153, 20)
        ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' LaporanToolStripMenuItem
        ' 
        LaporanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FormLaporanBukuToolStripMenuItem})
        LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        LaporanToolStripMenuItem.Size = New Size(77, 24)
        LaporanToolStripMenuItem.Text = "Laporan"
        ' 
        ' FormLaporanBukuToolStripMenuItem
        ' 
        FormLaporanBukuToolStripMenuItem.Name = "FormLaporanBukuToolStripMenuItem"
        FormLaporanBukuToolStripMenuItem.Size = New Size(224, 26)
        FormLaporanBukuToolStripMenuItem.Text = "Form Laporan Buku"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "Form3"
        Text = "Form3"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents FormAnggotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormLaporanBukuToolStripMenuItem As ToolStripMenuItem
End Class
