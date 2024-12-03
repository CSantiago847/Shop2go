<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Loginbutton = New Button()
        Register = New Button()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Loginbutton
        ' 
        Loginbutton.BackColor = SystemColors.ActiveBorder
        Loginbutton.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Loginbutton.Location = New Point(288, 403)
        Loginbutton.Name = "Loginbutton"
        Loginbutton.Size = New Size(284, 66)
        Loginbutton.TabIndex = 0
        Loginbutton.Text = "Login"
        Loginbutton.UseVisualStyleBackColor = False
        ' 
        ' Register
        ' 
        Register.BackColor = SystemColors.ActiveBorder
        Register.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Register.Location = New Point(589, 403)
        Register.Name = "Register"
        Register.Size = New Size(284, 66)
        Register.TabIndex = 1
        Register.Text = "Register"
        Register.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Tahoma", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(314, 507)
        Label1.Name = "Label1"
        Label1.Size = New Size(528, 99)
        Label1.TabIndex = 2
        Label1.Text = "Welcome to shop2go " & vbCrLf & vbCrLf & "Rated #3 as best online shop in utah  "
        Label1.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Register)
        Panel1.Controls.Add(Loginbutton)
        Panel1.Location = New Point(27, 24)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1140, 681)
        Panel1.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1193, 736)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Loginbutton As Button
    Friend WithEvents Register As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel

End Class
