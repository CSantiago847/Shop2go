<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        PictureBox1 = New PictureBox()
        Panel4 = New Panel()
        Label21 = New Label()
        Label10 = New Label()
        PillowButton = New Button()
        Label19 = New Label()
        Label20 = New Label()
        Label23 = New Label()
        Label24 = New Label()
        PictureBox4 = New PictureBox()
        Panel3 = New Panel()
        Napqueenbutton = New Button()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        PictureBox3 = New PictureBox()
        Panel2 = New Panel()
        Label9 = New Label()
        Label4 = New Label()
        LampButton = New Button()
        Label7 = New Label()
        Label8 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        Sheetsbutton = New Button()
        Label6 = New Label()
        Label5 = New Label()
        Original_Price1 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Back = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(19, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(264, 233)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Label21)
        Panel4.Controls.Add(Label10)
        Panel4.Controls.Add(PillowButton)
        Panel4.Controls.Add(Label19)
        Panel4.Controls.Add(Label20)
        Panel4.Controls.Add(Label23)
        Panel4.Controls.Add(Label24)
        Panel4.Controls.Add(PictureBox4)
        Panel4.Location = New Point(742, 356)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(728, 346)
        Panel4.TabIndex = 18
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Strikeout, GraphicsUnit.Point)
        Label21.ForeColor = Color.Red
        Label21.Location = New Point(574, 194)
        Label21.Name = "Label21"
        Label21.Size = New Size(92, 45)
        Label21.TabIndex = 12
        Label21.Text = "$197"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(319, 190)
        Label10.Name = "Label10"
        Label10.Size = New Size(254, 47)
        Label10.TabIndex = 11
        Label10.Text = "Original Price:"
        ' 
        ' PillowButton
        ' 
        PillowButton.BackColor = Color.Green
        PillowButton.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        PillowButton.ForeColor = Color.White
        PillowButton.Location = New Point(263, 287)
        PillowButton.Name = "PillowButton"
        PillowButton.Size = New Size(179, 46)
        PillowButton.TabIndex = 10
        PillowButton.Text = "Buy now"
        PillowButton.UseVisualStyleBackColor = False
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label19.ForeColor = Color.Green
        Label19.Location = New Point(574, 239)
        Label19.Name = "Label19"
        Label19.Size = New Size(119, 45)
        Label19.TabIndex = 6
        Label19.Text = "$44.99"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label20.Location = New Point(340, 237)
        Label20.Name = "Label20"
        Label20.Size = New Size(233, 47)
        Label20.TabIndex = 5
        Label20.Text = "Selling Price:"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.BorderStyle = BorderStyle.FixedSingle
        Label23.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label23.Location = New Point(367, 88)
        Label23.Name = "Label23"
        Label23.Size = New Size(256, 102)
        Label23.TabIndex = 2
        Label23.Text = "GET YOURSELF A PILLOW THAT WILL " & vbCrLf & "COOL YOU EVERY TIME!" & vbCrLf & vbCrLf & "Our cooling pillow is gel-infused " & vbCrLf & "as well as shredded memory foam. "
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label24.Location = New Point(340, 8)
        Label24.Name = "Label24"
        Label24.Size = New Size(375, 60)
        Label24.TabIndex = 1
        Label24.Text = "Hearth & Harbor Temperature " & vbCrLf & "Regulating Reversible Cooling Pillow"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(49, 30)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(259, 251)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 0
        PictureBox4.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Napqueenbutton)
        Panel3.Controls.Add(Label13)
        Panel3.Controls.Add(Label14)
        Panel3.Controls.Add(Label15)
        Panel3.Controls.Add(Label16)
        Panel3.Controls.Add(Label17)
        Panel3.Controls.Add(Label18)
        Panel3.Controls.Add(PictureBox3)
        Panel3.Location = New Point(742, 16)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(728, 334)
        Panel3.TabIndex = 17
        ' 
        ' Napqueenbutton
        ' 
        Napqueenbutton.BackColor = Color.Green
        Napqueenbutton.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Napqueenbutton.ForeColor = Color.White
        Napqueenbutton.Location = New Point(263, 268)
        Napqueenbutton.Name = "Napqueenbutton"
        Napqueenbutton.Size = New Size(179, 46)
        Napqueenbutton.TabIndex = 9
        Napqueenbutton.Text = "Buy now"
        Napqueenbutton.UseVisualStyleBackColor = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.ForeColor = Color.Green
        Label13.Location = New Point(587, 219)
        Label13.Name = "Label13"
        Label13.Size = New Size(92, 45)
        Label13.TabIndex = 6
        Label13.Text = "$188"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(335, 217)
        Label14.Name = "Label14"
        Label14.Size = New Size(233, 47)
        Label14.TabIndex = 5
        Label14.Text = "Selling Price:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Strikeout, GraphicsUnit.Point)
        Label15.ForeColor = Color.Red
        Label15.Location = New Point(587, 159)
        Label15.Name = "Label15"
        Label15.Size = New Size(92, 45)
        Label15.TabIndex = 4
        Label15.Text = "$200"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(335, 157)
        Label16.Name = "Label16"
        Label16.Size = New Size(254, 47)
        Label16.TabIndex = 3
        Label16.Text = "Original Price:"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BorderStyle = BorderStyle.FixedSingle
        Label17.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.Location = New Point(340, 80)
        Label17.Name = "Label17"
        Label17.Size = New Size(221, 62)
        Label17.TabIndex = 2
        Label17.Text = "NapQueen Victoria Cool Gel" & vbCrLf & " Full size Hybrid Mattress " & vbCrLf & "ideal for side and back sleeper. "
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 15F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label18.Location = New Point(302, 19)
        Label18.Name = "Label18"
        Label18.Size = New Size(391, 28)
        Label18.TabIndex = 1
        Label18.Text = "NapQueen Victoria 10"" Hybrid Mattress"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(49, 28)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(234, 233)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(LampButton)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Location = New Point(-12, 356)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(728, 346)
        Panel2.TabIndex = 16
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Strikeout, GraphicsUnit.Point)
        Label9.ForeColor = Color.Red
        Label9.Location = New Point(538, 186)
        Label9.Name = "Label9"
        Label9.Size = New Size(119, 45)
        Label9.TabIndex = 12
        Label9.Text = "$39.99"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(278, 174)
        Label4.Name = "Label4"
        Label4.Size = New Size(254, 47)
        Label4.TabIndex = 11
        Label4.Text = "Original Price:"
        ' 
        ' LampButton
        ' 
        LampButton.BackColor = Color.Green
        LampButton.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        LampButton.ForeColor = Color.White
        LampButton.Location = New Point(251, 278)
        LampButton.Name = "LampButton"
        LampButton.Size = New Size(179, 46)
        LampButton.TabIndex = 10
        LampButton.Text = "Buy now"
        LampButton.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.Green
        Label7.Location = New Point(538, 231)
        Label7.Name = "Label7"
        Label7.Size = New Size(119, 45)
        Label7.TabIndex = 6
        Label7.Text = "$19.00"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(299, 218)
        Label8.Name = "Label8"
        Label8.Size = New Size(233, 47)
        Label8.TabIndex = 5
        Label8.Text = "Selling Price:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BorderStyle = BorderStyle.FixedSingle
        Label11.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(278, 52)
        Label11.Name = "Label11"
        Label11.Size = New Size(441, 122)
        Label11.TabIndex = 2
        Label11.Text = resources.GetString("Label11.Text")
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label12.Location = New Point(413, 12)
        Label12.Name = "Label12"
        Label12.Size = New Size(130, 30)
        Label12.TabIndex = 1
        Label12.Text = "Table Lamp "
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(36, 38)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(224, 225)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Sheetsbutton)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Original_Price1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(-12, 16)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(728, 334)
        Panel1.TabIndex = 15
        ' 
        ' Sheetsbutton
        ' 
        Sheetsbutton.BackColor = Color.Green
        Sheetsbutton.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Sheetsbutton.ForeColor = Color.White
        Sheetsbutton.Location = New Point(251, 267)
        Sheetsbutton.Name = "Sheetsbutton"
        Sheetsbutton.Size = New Size(179, 47)
        Sheetsbutton.TabIndex = 7
        Sheetsbutton.Text = "Buy now"
        Sheetsbutton.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Green
        Label6.Location = New Point(568, 219)
        Label6.Name = "Label6"
        Label6.Size = New Size(119, 45)
        Label6.TabIndex = 6
        Label6.Text = "$39.96"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(335, 217)
        Label5.Name = "Label5"
        Label5.Size = New Size(233, 47)
        Label5.TabIndex = 5
        Label5.Text = "Selling Price:"
        ' 
        ' Original_Price1
        ' 
        Original_Price1.AutoSize = True
        Original_Price1.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Strikeout, GraphicsUnit.Point)
        Original_Price1.ForeColor = Color.Red
        Original_Price1.Location = New Point(574, 172)
        Original_Price1.Name = "Original_Price1"
        Original_Price1.Size = New Size(119, 45)
        Original_Price1.TabIndex = 4
        Original_Price1.Text = "$50.00"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(314, 172)
        Label3.Name = "Label3"
        Label3.Size = New Size(254, 47)
        Label3.TabIndex = 3
        Label3.Text = "Original Price:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(335, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(301, 42)
        Label2.TabIndex = 2
        Label2.Text = "Give your space an update with " & vbCrLf & "the Mainstays 7-Piece Quilt Set with Sheets. "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.Location = New Point(351, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(336, 30)
        Label1.TabIndex = 1
        Label1.Text = "Mainstays Black 7 Piece Quilt Set"
        ' 
        ' Back
        ' 
        Back.Font = New Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Back.Location = New Point(528, 708)
        Back.Name = "Back"
        Back.Size = New Size(393, 52)
        Back.TabIndex = 19
        Back.Text = "Back"
        Back.UseVisualStyleBackColor = True
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1486, 776)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Back)
        Name = "Home"
        Text = "Home"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PillowButton As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Napqueenbutton As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LampButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Sheetsbutton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Original_Price1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Back As Button
End Class
