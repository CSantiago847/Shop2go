<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        GroupBox1 = New GroupBox()
        Cancel = New Button()
        LoginButton = New Button()
        Label7 = New Label()
        Label6 = New Label()
        passbox = New TextBox()
        Emailbox = New TextBox()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(Cancel)
        GroupBox1.Controls.Add(LoginButton)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(passbox)
        GroupBox1.Controls.Add(Emailbox)
        GroupBox1.Location = New Point(266, 168)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(627, 430)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Cancel
        ' 
        Cancel.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Cancel.Location = New Point(329, 250)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(247, 47)
        Cancel.TabIndex = 14
        Cancel.Text = "Cancel"
        Cancel.UseVisualStyleBackColor = True
        ' 
        ' LoginButton
        ' 
        LoginButton.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        LoginButton.Location = New Point(38, 250)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(247, 47)
        LoginButton.TabIndex = 13
        LoginButton.Text = "Login"
        LoginButton.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.Transparent
        Label7.Location = New Point(23, 164)
        Label7.Name = "Label7"
        Label7.Size = New Size(199, 45)
        Label7.TabIndex = 11
        Label7.Text = "Password"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Transparent
        Label6.Location = New Point(15, 100)
        Label6.Name = "Label6"
        Label6.Size = New Size(207, 45)
        Label6.TabIndex = 10
        Label6.Text = "Username"
        ' 
        ' passbox
        ' 
        passbox.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        passbox.Location = New Point(228, 174)
        passbox.Name = "passbox"
        passbox.Size = New Size(315, 35)
        passbox.TabIndex = 7
        ' 
        ' Emailbox
        ' 
        Emailbox.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Emailbox.Location = New Point(228, 100)
        Emailbox.Name = "Emailbox"
        Emailbox.Size = New Size(315, 35)
        Emailbox.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(477, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(210, 77)
        Label1.TabIndex = 10
        Label1.Text = "Login"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1165, 665)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Name = "Login"
        Text = "Login"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Cancel As Button
    Friend WithEvents LoginButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents passbox As TextBox
    Friend WithEvents Emailbox As TextBox
    Friend WithEvents Label1 As Label
End Class
