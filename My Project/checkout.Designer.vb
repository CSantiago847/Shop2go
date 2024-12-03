<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(checkout))
        Label1 = New Label()
        Label2 = New Label()
        Prodname = New Label()
        ProductName = New Label()
        ProductID = New Label()
        Panel1 = New Panel()
        Id = New Label()
        Back = New Button()
        Exit_Button = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Overseer", 48F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(228, 215)
        Label1.Name = "Label1"
        Label1.Size = New Size(782, 72)
        Label1.TabIndex = 0
        Label1.Text = "Thank you for shopping with  "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Overseer", 36F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(474, 153)
        Label2.Name = "Label2"
        Label2.Size = New Size(294, 54)
        Label2.TabIndex = 1
        Label2.Text = "Item Purchased"
        ' 
        ' Prodname
        ' 
        Prodname.AutoSize = True
        Prodname.Font = New Font("Overseer", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Prodname.ForeColor = Color.White
        Prodname.Location = New Point(66, 84)
        Prodname.Name = "Prodname"
        Prodname.Size = New Size(196, 39)
        Prodname.TabIndex = 4
        Prodname.Text = "Product Name"
        ' 
        ' ProductName
        ' 
        ProductName.AutoSize = True
        ProductName.BorderStyle = BorderStyle.FixedSingle
        ProductName.Font = New Font("Overseer", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        ProductName.ForeColor = Color.White
        ProductName.Location = New Point(289, 84)
        ProductName.Name = "ProductName"
        ProductName.Size = New Size(184, 41)
        ProductName.TabIndex = 12
        ProductName.Text = "ProductName"
        ' 
        ' ProductID
        ' 
        ProductID.AutoSize = True
        ProductID.Font = New Font("Overseer", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        ProductID.ForeColor = Color.White
        ProductID.Location = New Point(66, 18)
        ProductID.Name = "ProductID"
        ProductID.Size = New Size(153, 39)
        ProductID.TabIndex = 13
        ProductID.Text = "Product ID"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Id)
        Panel1.Controls.Add(ProductName)
        Panel1.Controls.Add(ProductID)
        Panel1.Controls.Add(Prodname)
        Panel1.Location = New Point(284, 423)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(607, 139)
        Panel1.TabIndex = 15
        ' 
        ' Id
        ' 
        Id.AutoSize = True
        Id.BorderStyle = BorderStyle.FixedSingle
        Id.Font = New Font("Overseer", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Id.ForeColor = Color.White
        Id.Location = New Point(289, 18)
        Id.Name = "Id"
        Id.Size = New Size(153, 41)
        Id.TabIndex = 14
        Id.Text = "Product Id"
        ' 
        ' Back
        ' 
        Back.BackColor = SystemColors.ScrollBar
        Back.Font = New Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Back.Location = New Point(364, 604)
        Back.Name = "Back"
        Back.Size = New Size(184, 57)
        Back.TabIndex = 16
        Back.Text = "Back"
        Back.UseVisualStyleBackColor = False
        ' 
        ' Exit_Button
        ' 
        Exit_Button.BackColor = SystemColors.ScrollBar
        Exit_Button.Font = New Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Exit_Button.Location = New Point(620, 604)
        Exit_Button.Name = "Exit_Button"
        Exit_Button.Size = New Size(184, 57)
        Exit_Button.TabIndex = 17
        Exit_Button.Text = "Exit"
        Exit_Button.UseVisualStyleBackColor = False
        ' 
        ' checkout
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1184, 704)
        Controls.Add(Exit_Button)
        Controls.Add(Back)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Name = "checkout"
        Text = "checkout"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Prodname As Label
    Friend WithEvents ProductName As Label
    Friend WithEvents ProductID As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Id As Label
    Friend WithEvents Back As Button
    Friend WithEvents Exit_Button As Button
End Class
