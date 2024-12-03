<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registration))
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label4 = New Label()
        TextBox3 = New TextBox()
        GroupBox1 = New GroupBox()
        Cancel = New Button()
        RegisterNow = New Button()
        TextBox5 = New TextBox()
        ComboBox1 = New ComboBox()
        Label7 = New Label()
        Label6 = New Label()
        TextBox4 = New TextBox()
        Label5 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(386, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(302, 77)
        Label1.TabIndex = 1
        Label1.Text = "Register"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(193, 46)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(315, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Transparent
        Label2.Location = New Point(21, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 29)
        Label2.TabIndex = 3
        Label2.Text = "First Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Transparent
        Label3.Location = New Point(21, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 25)
        Label3.TabIndex = 4
        Label3.Text = "Last Name"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(193, 97)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(315, 23)
        TextBox2.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Transparent
        Label4.Location = New Point(21, 146)
        Label4.Name = "Label4"
        Label4.Size = New Size(166, 25)
        Label4.TabIndex = 6
        Label4.Text = "Phone Number"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(193, 146)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(315, 23)
        TextBox3.TabIndex = 7
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(Cancel)
        GroupBox1.Controls.Add(RegisterNow)
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Location = New Point(232, 149)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(627, 430)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Cancel
        ' 
        Cancel.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Cancel.Location = New Point(332, 349)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(247, 47)
        Cancel.TabIndex = 14
        Cancel.Text = "Cancel"
        Cancel.UseVisualStyleBackColor = True
        ' 
        ' RegisterNow
        ' 
        RegisterNow.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        RegisterNow.Location = New Point(37, 349)
        RegisterNow.Name = "RegisterNow"
        RegisterNow.Size = New Size(247, 47)
        RegisterNow.TabIndex = 13
        RegisterNow.Text = "Register Now  "
        RegisterNow.UseVisualStyleBackColor = True
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(193, 291)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(315, 23)
        TextBox5.TabIndex = 10
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Male", "Female", "Non binary"})
        ComboBox1.Location = New Point(193, 191)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(315, 23)
        ComboBox1.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.Transparent
        Label7.Location = New Point(21, 287)
        Label7.Name = "Label7"
        Label7.Size = New Size(115, 25)
        Label7.TabIndex = 11
        Label7.Text = "Password"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Transparent
        Label6.Location = New Point(21, 235)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 25)
        Label6.TabIndex = 10
        Label6.Text = "Email"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(193, 235)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(315, 23)
        TextBox4.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Transparent
        Label5.Location = New Point(21, 187)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 25)
        Label5.TabIndex = 8
        Label5.Text = "Gender"
        ' 
        ' Registration
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1104, 621)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "Registration"
        Text = "Registration"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Cancel As Button
    Friend WithEvents RegisterNow As Button
End Class
