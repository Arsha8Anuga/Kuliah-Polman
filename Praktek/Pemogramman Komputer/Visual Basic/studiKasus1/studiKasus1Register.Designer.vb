<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studiKasus1Register
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
        backBtn = New LinkLabel()
        LinkLabel2 = New LinkLabel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtNama = New TextBox()
        txtAlamat = New TextBox()
        gBox1 = New GroupBox()
        pGenderRBtn = New RadioButton()
        lGenderRBtn = New RadioButton()
        Label4 = New Label()
        gBox2 = New GroupBox()
        oGoldarRBtn = New RadioButton()
        abGoldarRBtn = New RadioButton()
        bGoldarRBtn = New RadioButton()
        aGoldarRBtn = New RadioButton()
        Label5 = New Label()
        txtListHobi = New ListBox()
        txtTempHobi = New TextBox()
        Label6 = New Label()
        txtTL = New DateTimePicker()
        txtT = New TextBox()
        txtNoTelp = New TextBox()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        regBtn = New Button()
        resetBtn = New Button()
        gBox1.SuspendLayout()
        gBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' backBtn
        ' 
        backBtn.AutoSize = True
        backBtn.BorderStyle = BorderStyle.FixedSingle
        backBtn.Font = New Font("Adobe Fan Heiti Std B", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        backBtn.Location = New Point(12, 9)
        backBtn.Name = "backBtn"
        backBtn.Size = New Size(46, 22)
        backBtn.TabIndex = 0
        backBtn.TabStop = True
        backBtn.Text = "Back"
        backBtn.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.Font = New Font("Adobe Fan Heiti Std B", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel2.LinkColor = Color.Black
        LinkLabel2.Location = New Point(252, 38)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(105, 26)
        LinkLabel2.TabIndex = 1
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Registrasi"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(17, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 17)
        Label1.TabIndex = 2
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(17, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 17)
        Label2.TabIndex = 3
        Label2.Text = "Alamat"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(17, 181)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 17)
        Label3.TabIndex = 4
        Label3.Text = "Gender"
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNama.Location = New Point(123, 85)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(468, 25)
        txtNama.TabIndex = 5
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAlamat.Location = New Point(123, 131)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(468, 25)
        txtAlamat.TabIndex = 6
        ' 
        ' gBox1
        ' 
        gBox1.Controls.Add(pGenderRBtn)
        gBox1.Controls.Add(lGenderRBtn)
        gBox1.Location = New Point(123, 181)
        gBox1.Name = "gBox1"
        gBox1.Size = New Size(468, 63)
        gBox1.TabIndex = 7
        gBox1.TabStop = False
        gBox1.Text = "Gender"
        ' 
        ' pGenderRBtn
        ' 
        pGenderRBtn.AutoSize = True
        pGenderRBtn.Location = New Point(84, 22)
        pGenderRBtn.Name = "pGenderRBtn"
        pGenderRBtn.Size = New Size(86, 19)
        pGenderRBtn.TabIndex = 1
        pGenderRBtn.TabStop = True
        pGenderRBtn.Text = "Perempuan"
        pGenderRBtn.UseVisualStyleBackColor = True
        ' 
        ' lGenderRBtn
        ' 
        lGenderRBtn.AutoSize = True
        lGenderRBtn.Location = New Point(6, 22)
        lGenderRBtn.Name = "lGenderRBtn"
        lGenderRBtn.Size = New Size(72, 19)
        lGenderRBtn.TabIndex = 0
        lGenderRBtn.TabStop = True
        lGenderRBtn.Text = "Laki-Laki"
        lGenderRBtn.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(17, 271)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 19)
        Label4.TabIndex = 8
        Label4.Text = "Goldar"
        ' 
        ' gBox2
        ' 
        gBox2.Controls.Add(oGoldarRBtn)
        gBox2.Controls.Add(abGoldarRBtn)
        gBox2.Controls.Add(bGoldarRBtn)
        gBox2.Controls.Add(aGoldarRBtn)
        gBox2.Location = New Point(123, 271)
        gBox2.Name = "gBox2"
        gBox2.Size = New Size(468, 63)
        gBox2.TabIndex = 8
        gBox2.TabStop = False
        gBox2.Text = "Golongan Darah"
        ' 
        ' oGoldarRBtn
        ' 
        oGoldarRBtn.AutoSize = True
        oGoldarRBtn.Location = New Point(234, 22)
        oGoldarRBtn.Name = "oGoldarRBtn"
        oGoldarRBtn.Size = New Size(34, 19)
        oGoldarRBtn.TabIndex = 3
        oGoldarRBtn.TabStop = True
        oGoldarRBtn.Text = "O"
        oGoldarRBtn.UseVisualStyleBackColor = True
        ' 
        ' abGoldarRBtn
        ' 
        abGoldarRBtn.AutoSize = True
        abGoldarRBtn.Location = New Point(160, 22)
        abGoldarRBtn.Name = "abGoldarRBtn"
        abGoldarRBtn.Size = New Size(40, 19)
        abGoldarRBtn.TabIndex = 2
        abGoldarRBtn.TabStop = True
        abGoldarRBtn.Text = "AB"
        abGoldarRBtn.UseVisualStyleBackColor = True
        ' 
        ' bGoldarRBtn
        ' 
        bGoldarRBtn.AutoSize = True
        bGoldarRBtn.Location = New Point(84, 22)
        bGoldarRBtn.Name = "bGoldarRBtn"
        bGoldarRBtn.Size = New Size(32, 19)
        bGoldarRBtn.TabIndex = 1
        bGoldarRBtn.TabStop = True
        bGoldarRBtn.Text = "B"
        bGoldarRBtn.UseVisualStyleBackColor = True
        ' 
        ' aGoldarRBtn
        ' 
        aGoldarRBtn.AutoSize = True
        aGoldarRBtn.Location = New Point(6, 22)
        aGoldarRBtn.Name = "aGoldarRBtn"
        aGoldarRBtn.Size = New Size(33, 19)
        aGoldarRBtn.TabIndex = 0
        aGoldarRBtn.TabStop = True
        aGoldarRBtn.Text = "A"
        aGoldarRBtn.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BorderStyle = BorderStyle.FixedSingle
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(17, 355)
        Label5.Name = "Label5"
        Label5.Size = New Size(38, 19)
        Label5.TabIndex = 9
        Label5.Text = "Hobi"
        ' 
        ' txtListHobi
        ' 
        txtListHobi.FormattingEnabled = True
        txtListHobi.ItemHeight = 15
        txtListHobi.Items.AddRange(New Object() {"Main Piano", "Main Gitar", "Ngotak Ngatik ", "Coding", "Memasak", "Roasting", "Skateboard", "Backroom??"})
        txtListHobi.Location = New Point(123, 355)
        txtListHobi.Name = "txtListHobi"
        txtListHobi.Size = New Size(140, 94)
        txtListHobi.TabIndex = 10
        ' 
        ' txtTempHobi
        ' 
        txtTempHobi.Location = New Point(283, 355)
        txtTempHobi.Multiline = True
        txtTempHobi.Name = "txtTempHobi"
        txtTempHobi.ReadOnly = True
        txtTempHobi.Size = New Size(308, 94)
        txtTempHobi.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BorderStyle = BorderStyle.FixedSingle
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(17, 467)
        Label6.Name = "Label6"
        Label6.Size = New Size(30, 19)
        Label6.TabIndex = 12
        Label6.Text = "TTL"
        ' 
        ' txtTL
        ' 
        txtTL.CustomFormat = "dddd dd-MMM-yyyy"
        txtTL.Format = DateTimePickerFormat.Custom
        txtTL.ImeMode = ImeMode.NoControl
        txtTL.Location = New Point(391, 467)
        txtTL.Name = "txtTL"
        txtTL.Size = New Size(200, 23)
        txtTL.TabIndex = 13
        ' 
        ' txtT
        ' 
        txtT.Location = New Point(123, 466)
        txtT.Name = "txtT"
        txtT.Size = New Size(266, 23)
        txtT.TabIndex = 14
        ' 
        ' txtNoTelp
        ' 
        txtNoTelp.Location = New Point(123, 510)
        txtNoTelp.Name = "txtNoTelp"
        txtNoTelp.Size = New Size(466, 23)
        txtNoTelp.TabIndex = 15
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(123, 555)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(466, 23)
        txtUsername.TabIndex = 16
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(123, 596)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(466, 23)
        txtPassword.TabIndex = 17
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BorderStyle = BorderStyle.FixedSingle
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(17, 511)
        Label7.Name = "Label7"
        Label7.Size = New Size(56, 19)
        Label7.TabIndex = 18
        Label7.Text = "No Telp"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BorderStyle = BorderStyle.FixedSingle
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(17, 555)
        Label8.Name = "Label8"
        Label8.Size = New Size(69, 19)
        Label8.TabIndex = 19
        Label8.Text = "Username"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BorderStyle = BorderStyle.FixedSingle
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(17, 596)
        Label9.Name = "Label9"
        Label9.Size = New Size(66, 19)
        Label9.TabIndex = 20
        Label9.Text = "Password"
        ' 
        ' regBtn
        ' 
        regBtn.BackColor = Color.Lime
        regBtn.BackgroundImageLayout = ImageLayout.None
        regBtn.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        regBtn.Location = New Point(123, 635)
        regBtn.Name = "regBtn"
        regBtn.Size = New Size(116, 38)
        regBtn.TabIndex = 21
        regBtn.Text = "Register"
        regBtn.UseVisualStyleBackColor = False
        ' 
        ' resetBtn
        ' 
        resetBtn.BackColor = Color.Tomato
        resetBtn.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        resetBtn.Location = New Point(264, 635)
        resetBtn.Name = "resetBtn"
        resetBtn.RightToLeft = RightToLeft.No
        resetBtn.Size = New Size(116, 38)
        resetBtn.TabIndex = 22
        resetBtn.Text = "Reset"
        resetBtn.UseVisualStyleBackColor = False
        ' 
        ' studiKasus1Register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(614, 695)
        ControlBox = False
        Controls.Add(resetBtn)
        Controls.Add(regBtn)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(txtNoTelp)
        Controls.Add(txtT)
        Controls.Add(txtTL)
        Controls.Add(Label6)
        Controls.Add(txtTempHobi)
        Controls.Add(txtListHobi)
        Controls.Add(Label5)
        Controls.Add(gBox2)
        Controls.Add(Label4)
        Controls.Add(gBox1)
        Controls.Add(txtAlamat)
        Controls.Add(txtNama)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LinkLabel2)
        Controls.Add(backBtn)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "studiKasus1Register"
        Text = "studiKasus1Register"
        gBox1.ResumeLayout(False)
        gBox1.PerformLayout()
        gBox2.ResumeLayout(False)
        gBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents backBtn As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents gBox1 As GroupBox
    Friend WithEvents pGenderRBtn As RadioButton
    Friend WithEvents lGenderRBtn As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents gBox2 As GroupBox
    Friend WithEvents bGoldarRBtn As RadioButton
    Friend WithEvents aGoldarRBtn As RadioButton
    Friend WithEvents oGoldarRBtn As RadioButton
    Friend WithEvents abGoldarRBtn As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents txtListHobi As ListBox
    Friend WithEvents txtTempHobi As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTL As DateTimePicker
    Friend WithEvents txtT As TextBox
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents regBtn As Button
    Friend WithEvents resetBtn As Button
End Class
