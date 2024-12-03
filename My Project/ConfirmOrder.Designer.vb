<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfirmOrder))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        Back = New Button()
        SellingPrice = New Label()
        OriginalPrice = New Label()
        ProductName = New Label()
        OrderButton = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(26, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(491, 77)
        Label1.TabIndex = 0
        Label1.Text = "Confirm Order"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(6, 27)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(579, 359)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(36, 89)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(160, 19)
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Back)
        Panel1.Controls.Add(SellingPrice)
        Panel1.Controls.Add(OriginalPrice)
        Panel1.Controls.Add(ProductName)
        Panel1.Controls.Add(OrderButton)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(20, 119)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1171, 461)
        Panel1.TabIndex = 3
        ' 
        ' Back
        ' 
        Back.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Back.Location = New Point(591, 358)
        Back.Name = "Back"
        Back.Size = New Size(277, 68)
        Back.TabIndex = 4
        Back.Text = "Back"
        Back.UseVisualStyleBackColor = True
        ' 
        ' SellingPrice
        ' 
        SellingPrice.AutoSize = True
        SellingPrice.Font = New Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        SellingPrice.ForeColor = Color.Green
        SellingPrice.Location = New Point(851, 280)
        SellingPrice.Name = "SellingPrice"
        SellingPrice.Size = New Size(174, 33)
        SellingPrice.TabIndex = 13
        SellingPrice.Text = "SellingPrice"
        ' 
        ' OriginalPrice
        ' 
        OriginalPrice.AutoSize = True
        OriginalPrice.Font = New Font("Tahoma", 20.25F, FontStyle.Bold Or FontStyle.Strikeout, GraphicsUnit.Point)
        OriginalPrice.ForeColor = Color.Red
        OriginalPrice.Location = New Point(851, 211)
        OriginalPrice.Name = "OriginalPrice"
        OriginalPrice.Size = New Size(190, 33)
        OriginalPrice.TabIndex = 12
        OriginalPrice.Text = "OriginalPrice"
        ' 
        ' ProductName
        ' 
        ProductName.AutoSize = True
        ProductName.Font = New Font("Tahoma", 18.75F, FontStyle.Regular, GraphicsUnit.Point)
        ProductName.Location = New Point(851, 144)
        ProductName.Name = "ProductName"
        ProductName.Size = New Size(162, 30)
        ProductName.TabIndex = 11
        ProductName.Text = "ProductName"
        ' 
        ' OrderButton
        ' 
        OrderButton.BackColor = Color.Green
        OrderButton.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        OrderButton.ForeColor = Color.White
        OrderButton.Location = New Point(874, 358)
        OrderButton.Name = "OrderButton"
        OrderButton.Size = New Size(277, 68)
        OrderButton.TabIndex = 10
        OrderButton.Text = "Buy now"
        OrderButton.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 26.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(610, 271)
        Label5.Name = "Label5"
        Label5.Size = New Size(204, 42)
        Label5.TabIndex = 5
        Label5.Text = "Selling Price"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 26.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(610, 211)
        Label4.Name = "Label4"
        Label4.Size = New Size(222, 42)
        Label4.TabIndex = 4
        Label4.Text = "Original Price"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 26.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(610, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(235, 42)
        Label3.TabIndex = 3
        Label3.Text = "Product Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(690, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(389, 58)
        Label2.TabIndex = 2
        Label2.Text = "Product details"
        ' 
        ' ConfirmOrder
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1230, 689)
        Controls.Add(Panel1)
        Controls.Add(PictureBox2)
        Controls.Add(Label1)
        Name = "ConfirmOrder"
        Text = "ConfirmOrder"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SellingPrice As Label
    Friend WithEvents OriginalPrice As Label
    Friend WithEvents ProductName As Label
    Friend WithEvents OrderButton As Button
    Friend WithEvents Back As Button
End Class
