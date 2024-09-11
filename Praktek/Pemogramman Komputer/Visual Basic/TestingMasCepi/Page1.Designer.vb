<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Test
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
        Button1 = New Button()
        passInput = New TextBox()
        passwordLabel = New Label()
        nameLabel = New Label()
        nameInput = New TextBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        LinkLabel1 = New LinkLabel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(246, 449)
        Button1.Name = "Button1"
        Button1.Size = New Size(113, 34)
        Button1.TabIndex = 6
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' passInput
        ' 
        passInput.BorderStyle = BorderStyle.FixedSingle
        passInput.Cursor = Cursors.IBeam
        passInput.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        passInput.Location = New Point(176, 377)
        passInput.Name = "passInput"
        passInput.PasswordChar = "*"c
        passInput.Size = New Size(613, 37)
        passInput.TabIndex = 4
        ' 
        ' passwordLabel
        ' 
        passwordLabel.AutoSize = True
        passwordLabel.Font = New Font("Adobe Fangsong Std R", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passwordLabel.Location = New Point(56, 375)
        passwordLabel.Name = "passwordLabel"
        passwordLabel.Size = New Size(104, 24)
        passwordLabel.TabIndex = 2
        passwordLabel.Text = "Password : "
        ' 
        ' nameLabel
        ' 
        nameLabel.AutoSize = True
        nameLabel.Font = New Font("Adobe Fangsong Std R", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nameLabel.Location = New Point(56, 298)
        nameLabel.Name = "nameLabel"
        nameLabel.Size = New Size(67, 24)
        nameLabel.TabIndex = 1
        nameLabel.Text = "Name :"
        ' 
        ' nameInput
        ' 
        nameInput.BorderStyle = BorderStyle.FixedSingle
        nameInput.Cursor = Cursors.IBeam
        nameInput.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nameInput.Location = New Point(176, 298)
        nameInput.Margin = New Padding(3, 4, 7, 7)
        nameInput.Name = "nameInput"
        nameInput.Size = New Size(613, 37)
        nameInput.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(266, 242)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(1)
        Label1.Size = New Size(293, 21)
        Label1.TabIndex = 7
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.WhatsApp_Image_2024_09_10_at_10_28_08_1b759e07
        PictureBox1.Location = New Point(336, 44)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(154, 164)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel1.Location = New Point(520, 458)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(65, 19)
        LinkLabel1.TabIndex = 9
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Register"
        ' 
        ' Test
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(848, 531)
        Controls.Add(LinkLabel1)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(passInput)
        Controls.Add(nameInput)
        Controls.Add(passwordLabel)
        Controls.Add(nameLabel)
        Name = "Test"
        Text = "Test Sector"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents passInput As TextBox
    Friend WithEvents passwordLabel As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents nameInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel

End Class
