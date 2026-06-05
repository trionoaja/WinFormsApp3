<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btnsimpan = New Button()
        btnedit = New Button()
        btnhapus = New Button()
        btnreset = New Button()
        txtjudul = New TextBox()
        txtpengarang = New TextBox()
        txtpenerbit = New TextBox()
        txttahun = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        DataGridView1 = New DataGridView()
        Label5 = New Label()
        txtstock = New TextBox()
        btnExportPDF = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnsimpan
        ' 
        btnsimpan.Location = New Point(-3, 253)
        btnsimpan.Name = "btnsimpan"
        btnsimpan.Size = New Size(94, 29)
        btnsimpan.TabIndex = 0
        btnsimpan.Text = "Simpan"
        btnsimpan.UseVisualStyleBackColor = True
        ' 
        ' btnedit
        ' 
        btnedit.Location = New Point(97, 253)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(94, 29)
        btnedit.TabIndex = 1
        btnedit.Text = "Edit"
        btnedit.UseVisualStyleBackColor = True
        ' 
        ' btnhapus
        ' 
        btnhapus.Location = New Point(197, 253)
        btnhapus.Name = "btnhapus"
        btnhapus.Size = New Size(94, 29)
        btnhapus.TabIndex = 2
        btnhapus.Text = "Hapus"
        btnhapus.UseVisualStyleBackColor = True
        ' 
        ' btnreset
        ' 
        btnreset.Location = New Point(297, 253)
        btnreset.Name = "btnreset"
        btnreset.Size = New Size(94, 29)
        btnreset.TabIndex = 3
        btnreset.Text = "Reset"
        btnreset.UseVisualStyleBackColor = True
        ' 
        ' txtjudul
        ' 
        txtjudul.Location = New Point(185, 12)
        txtjudul.Name = "txtjudul"
        txtjudul.Size = New Size(125, 27)
        txtjudul.TabIndex = 4
        ' 
        ' txtpengarang
        ' 
        txtpengarang.Location = New Point(185, 61)
        txtpengarang.Name = "txtpengarang"
        txtpengarang.Size = New Size(125, 27)
        txtpengarang.TabIndex = 5
        ' 
        ' txtpenerbit
        ' 
        txtpenerbit.Location = New Point(185, 111)
        txtpenerbit.Name = "txtpenerbit"
        txtpenerbit.Size = New Size(125, 27)
        txtpenerbit.TabIndex = 6
        ' 
        ' txttahun
        ' 
        txttahun.Location = New Point(185, 155)
        txttahun.Name = "txttahun"
        txttahun.Size = New Size(125, 27)
        txttahun.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(42, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 20)
        Label1.TabIndex = 8
        Label1.Text = "judul"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(42, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 20)
        Label2.TabIndex = 9
        Label2.Text = "Pengarang"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(42, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 20)
        Label3.TabIndex = 10
        Label3.Text = "Penerbit"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(42, 162)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 20)
        Label4.TabIndex = 11
        Label4.Text = "Tahun"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(364, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(424, 202)
        DataGridView1.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(42, 208)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 20)
        Label5.TabIndex = 13
        Label5.Text = "Stock"
        ' 
        ' txtstock
        ' 
        txtstock.Location = New Point(185, 205)
        txtstock.Name = "txtstock"
        txtstock.Size = New Size(125, 27)
        txtstock.TabIndex = 14
        ' 
        ' btnExportPDF
        ' 
        btnExportPDF.Location = New Point(397, 253)
        btnExportPDF.Name = "btnExportPDF"
        btnExportPDF.Size = New Size(94, 29)
        btnExportPDF.TabIndex = 15
        btnExportPDF.Text = "cetak pdf"
        btnExportPDF.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnExportPDF)
        Controls.Add(txtstock)
        Controls.Add(Label5)
        Controls.Add(DataGridView1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txttahun)
        Controls.Add(txtpenerbit)
        Controls.Add(txtpengarang)
        Controls.Add(txtjudul)
        Controls.Add(btnreset)
        Controls.Add(btnhapus)
        Controls.Add(btnedit)
        Controls.Add(btnsimpan)
        MdiChildrenMinimizedAnchorBottom = False
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnsimpan As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnreset As Button
    Friend WithEvents txtjudul As TextBox
    Friend WithEvents txtpengarang As TextBox
    Friend WithEvents txtpenerbit As TextBox
    Friend WithEvents txttahun As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents txtstock As TextBox
    Friend WithEvents btnExportPDF As Button

End Class
