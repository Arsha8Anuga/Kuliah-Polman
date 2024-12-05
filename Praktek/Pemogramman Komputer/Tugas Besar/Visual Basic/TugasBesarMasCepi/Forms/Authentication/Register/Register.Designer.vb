<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Label3 = New Label()
        Label4 = New Label()
        UernameTxt = New TextBox()
        EmailTxt = New TextBox()
        PasswordTxt = New TextBox()
        SubmitBtn = New Button()
        BackBtn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        Label1.Location = New Point(235, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 29)
        Label1.TabIndex = 0
        Label1.Text = "Register"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12.25F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        Label2.Location = New Point(14, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 25)
        Label2.TabIndex = 1
        Label2.Text = "Username :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12.25F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        Label3.Location = New Point(14, 141)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 25)
        Label3.TabIndex = 2
        Label3.Text = "Email :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12.25F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        Label4.Location = New Point(14, 193)
        Label4.Name = "Label4"
        Label4.Size = New Size(128, 25)
        Label4.TabIndex = 3
        Label4.Text = "Password :"
        ' 
        ' UernameTxt
        ' 
        UernameTxt.BackColor = Color.FromArgb(CByte(35), CByte(36), CByte(40))
        UernameTxt.BorderStyle = BorderStyle.FixedSingle
        UernameTxt.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UernameTxt.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        UernameTxt.Location = New Point(152, 91)
        UernameTxt.Margin = New Padding(3, 4, 3, 4)
        UernameTxt.Multiline = True
        UernameTxt.Name = "UernameTxt"
        UernameTxt.Size = New Size(375, 29)
        UernameTxt.TabIndex = 4
        ' 
        ' EmailTxt
        ' 
        EmailTxt.BackColor = Color.FromArgb(CByte(35), CByte(36), CByte(40))
        EmailTxt.BorderStyle = BorderStyle.FixedSingle
        EmailTxt.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EmailTxt.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        EmailTxt.Location = New Point(152, 137)
        EmailTxt.Margin = New Padding(3, 4, 3, 4)
        EmailTxt.Multiline = True
        EmailTxt.Name = "EmailTxt"
        EmailTxt.Size = New Size(375, 29)
        EmailTxt.TabIndex = 5
        ' 
        ' PasswordTxt
        ' 
        PasswordTxt.BackColor = Color.FromArgb(CByte(35), CByte(36), CByte(40))
        PasswordTxt.BorderStyle = BorderStyle.FixedSingle
        PasswordTxt.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PasswordTxt.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        PasswordTxt.Location = New Point(152, 189)
        PasswordTxt.Margin = New Padding(3, 4, 3, 4)
        PasswordTxt.Multiline = True
        PasswordTxt.Name = "PasswordTxt"
        PasswordTxt.Size = New Size(375, 29)
        PasswordTxt.TabIndex = 6
        ' 
        ' SubmitBtn
        ' 
        SubmitBtn.BackColor = Color.FromArgb(CByte(35), CByte(36), CByte(40))
        SubmitBtn.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SubmitBtn.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        SubmitBtn.Location = New Point(218, 271)
        SubmitBtn.Margin = New Padding(3, 4, 3, 4)
        SubmitBtn.Name = "SubmitBtn"
        SubmitBtn.Size = New Size(107, 39)
        SubmitBtn.TabIndex = 7
        SubmitBtn.Text = "Submit"
        SubmitBtn.UseVisualStyleBackColor = False
        ' 
        ' BackBtn
        ' 
        BackBtn.BackColor = Color.FromArgb(CByte(35), CByte(36), CByte(40))
        BackBtn.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BackBtn.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        BackBtn.Location = New Point(14, 16)
        BackBtn.Margin = New Padding(3, 4, 3, 4)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(109, 44)
        BackBtn.TabIndex = 8
        BackBtn.Text = "Back"
        BackBtn.UseVisualStyleBackColor = False
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(49), CByte(51), CByte(56))
        ClientSize = New Size(558, 340)
        ControlBox = False
        Controls.Add(BackBtn)
        Controls.Add(SubmitBtn)
        Controls.Add(PasswordTxt)
        Controls.Add(EmailTxt)
        Controls.Add(UernameTxt)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents UernameTxt As TextBox
    Friend WithEvents EmailTxt As TextBox
    Friend WithEvents PasswordTxt As TextBox
    Friend WithEvents SubmitBtn As Button
    Friend WithEvents BackBtn As Button
End Class
