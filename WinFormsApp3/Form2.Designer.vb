<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        Label2 = New Label()
        txtusername = New TextBox()
        txtpassword = New TextBox()
        btnlogin = New Button()
        btnexit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(45, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 20)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(45, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' txtusername
        ' 
        txtusername.Location = New Point(158, 54)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(125, 27)
        txtusername.TabIndex = 2
        ' 
        ' txtpassword
        ' 
        txtpassword.Location = New Point(158, 107)
        txtpassword.Name = "txtpassword"
        txtpassword.PasswordChar = "*"c
        txtpassword.Size = New Size(125, 27)
        txtpassword.TabIndex = 3
        ' 
        ' btnlogin
        ' 
        btnlogin.Location = New Point(45, 165)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(94, 29)
        btnlogin.TabIndex = 4
        btnlogin.Text = "Login"
        btnlogin.UseVisualStyleBackColor = True
        ' 
        ' btnexit
        ' 
        btnexit.Location = New Point(158, 165)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(94, 29)
        btnexit.TabIndex = 5
        btnexit.Text = "Exit"
        btnexit.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnexit)
        Controls.Add(btnlogin)
        Controls.Add(txtpassword)
        Controls.Add(txtusername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents btnexit As Button
End Class
