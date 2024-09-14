<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studiKasus1Login
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
        PictureBox1 = New PictureBox()
        lblChecker = New Label()
        Label1 = New Label()
        Label2 = New Label()
        txtBoxUser = New TextBox()
        txtBoxPass = New TextBox()
        submitBtn = New Button()
        regLink = New LinkLabel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.WhatsApp_Image_2024_09_10_at_10_28_08_1b759e07
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(225, 26)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(149, 145)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblChecker
        ' 
        lblChecker.Font = New Font("Adobe Fan Heiti Std B", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblChecker.Location = New Point(111, 189)
        lblChecker.Name = "lblChecker"
        lblChecker.Size = New Size(380, 23)
        lblChecker.TabIndex = 1
        lblChecker.Text = "Silahkan Masukan Username dan Password Anda"
        lblChecker.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(43, 253)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 19)
        Label1.TabIndex = 2
        Label1.Text = "Username : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(43, 322)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 19)
        Label2.TabIndex = 3
        Label2.Text = "Password : "
        ' 
        ' txtBoxUser
        ' 
        txtBoxUser.BorderStyle = BorderStyle.None
        txtBoxUser.Font = New Font("Adobe Fan Heiti Std B", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtBoxUser.Location = New Point(137, 253)
        txtBoxUser.Name = "txtBoxUser"
        txtBoxUser.Size = New Size(398, 32)
        txtBoxUser.TabIndex = 4
        ' 
        ' txtBoxPass
        ' 
        txtBoxPass.BorderStyle = BorderStyle.None
        txtBoxPass.Font = New Font("Adobe Fan Heiti Std B", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtBoxPass.Location = New Point(133, 322)
        txtBoxPass.Name = "txtBoxPass"
        txtBoxPass.PasswordChar = "*"c
        txtBoxPass.Size = New Size(398, 32)
        txtBoxPass.TabIndex = 5
        ' 
        ' submitBtn
        ' 
        submitBtn.Font = New Font("Adobe Fan Heiti Std B", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        submitBtn.Location = New Point(133, 384)
        submitBtn.Name = "submitBtn"
        submitBtn.Size = New Size(118, 39)
        submitBtn.TabIndex = 6
        submitBtn.Text = "Submit"
        submitBtn.UseVisualStyleBackColor = True
        ' 
        ' regLink
        ' 
        regLink.AutoSize = True
        regLink.Font = New Font("Adobe Fan Heiti Std B", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        regLink.Location = New Point(286, 393)
        regLink.Name = "regLink"
        regLink.Size = New Size(70, 20)
        regLink.TabIndex = 7
        regLink.TabStop = True
        regLink.Text = "Register"
        ' 
        ' studiKasus1Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(599, 450)
        Controls.Add(regLink)
        Controls.Add(submitBtn)
        Controls.Add(txtBoxPass)
        Controls.Add(txtBoxUser)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblChecker)
        Controls.Add(PictureBox1)
        Name = "studiKasus1Login"
        Text = "studiKasus1Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblChecker As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBoxUser As TextBox
    Friend WithEvents txtBoxPass As TextBox
    Friend WithEvents submitBtn As Button
    Friend WithEvents regLink As LinkLabel
End Class
