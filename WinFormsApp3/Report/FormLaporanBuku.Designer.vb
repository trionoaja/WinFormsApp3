<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanBuku
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
        btncetak = New Button()
        SuspendLayout()
        ' 
        ' btncetak
        ' 
        btncetak.Location = New Point(165, 203)
        btncetak.Name = "btncetak"
        btncetak.Size = New Size(94, 29)
        btncetak.TabIndex = 0
        btncetak.Text = "cetak"
        btncetak.UseVisualStyleBackColor = True
        ' 
        ' FormLaporanBuku
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btncetak)
        Name = "FormLaporanBuku"
        Text = "FormLaporanBuku"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btncetak As Button
End Class
