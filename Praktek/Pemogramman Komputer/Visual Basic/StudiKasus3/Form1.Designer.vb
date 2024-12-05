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
        GroupBox2 = New GroupBox()
        Label8 = New Label()
        AkarHasil = New Label()
        Label5 = New Label()
        AkarBtn = New Button()
        AkarVar1 = New TextBox()
        AkarVar2 = New TextBox()
        GroupBoxPerkalian = New GroupBox()
        PerkalianVarHasil = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PerkalianBtn = New Button()
        PerkalianVar2 = New TextBox()
        PerkalianVar1 = New TextBox()
        GroupBox1 = New GroupBox()
        PerpangkatanHasil = New Label()
        Label4 = New Label()
        PerpangkatanBtn = New Button()
        PerpangkatanVar2 = New TextBox()
        PerpangkatanVar1 = New TextBox()
        Logaritma = New GroupBox()
        adasd = New Label()
        LogHasil = New Label()
        Label7 = New Label()
        LogBtn = New Button()
        LogVar1 = New TextBox()
        LogVar2 = New TextBox()
        Panel1 = New Panel()
        GroupBox4 = New GroupBox()
        Label6 = New Label()
        FactorHasil = New Label()
        Label9 = New Label()
        FactorBtn = New Button()
        FactorVar1 = New TextBox()
        GroupBox2.SuspendLayout()
        GroupBoxPerkalian.SuspendLayout()
        GroupBox1.SuspendLayout()
        Logaritma.SuspendLayout()
        Panel1.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(AkarHasil)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(AkarBtn)
        GroupBox2.Controls.Add(AkarVar1)
        GroupBox2.Controls.Add(AkarVar2)
        GroupBox2.Location = New Point(0, 222)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(771, 117)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        GroupBox2.Text = "Akar"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(46, 36)
        Label8.Name = "Label8"
        Label8.Size = New Size(24, 21)
        Label8.TabIndex = 6
        Label8.Text = "√ "
        ' 
        ' AkarHasil
        ' 
        AkarHasil.AutoSize = True
        AkarHasil.Location = New Point(150, 42)
        AkarHasil.Name = "AkarHasil"
        AkarHasil.Size = New Size(13, 15)
        AkarHasil.TabIndex = 5
        AkarHasil.Text = "0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(129, 42)
        Label5.Name = "Label5"
        Label5.Size = New Size(15, 15)
        Label5.TabIndex = 4
        Label5.Text = "="
        ' 
        ' AkarBtn
        ' 
        AkarBtn.Location = New Point(13, 67)
        AkarBtn.Name = "AkarBtn"
        AkarBtn.Size = New Size(75, 23)
        AkarBtn.TabIndex = 2
        AkarBtn.Text = "hitung"
        AkarBtn.UseVisualStyleBackColor = True
        ' 
        ' AkarVar1
        ' 
        AkarVar1.Font = New Font("Segoe UI", 7.0F)
        AkarVar1.Location = New Point(14, 22)
        AkarVar1.Name = "AkarVar1"
        AkarVar1.Size = New Size(26, 20)
        AkarVar1.TabIndex = 1
        ' 
        ' AkarVar2
        ' 
        AkarVar2.Location = New Point(72, 38)
        AkarVar2.Name = "AkarVar2"
        AkarVar2.Size = New Size(42, 23)
        AkarVar2.TabIndex = 0
        ' 
        ' GroupBoxPerkalian
        ' 
        GroupBoxPerkalian.Controls.Add(PerkalianVarHasil)
        GroupBoxPerkalian.Controls.Add(Label2)
        GroupBoxPerkalian.Controls.Add(Label1)
        GroupBoxPerkalian.Controls.Add(PerkalianBtn)
        GroupBoxPerkalian.Controls.Add(PerkalianVar2)
        GroupBoxPerkalian.Controls.Add(PerkalianVar1)
        GroupBoxPerkalian.Location = New Point(0, 0)
        GroupBoxPerkalian.Name = "GroupBoxPerkalian"
        GroupBoxPerkalian.Size = New Size(774, 105)
        GroupBoxPerkalian.TabIndex = 0
        GroupBoxPerkalian.TabStop = False
        GroupBoxPerkalian.Text = "Perkalian"
        ' 
        ' PerkalianVarHasil
        ' 
        PerkalianVarHasil.AutoSize = True
        PerkalianVarHasil.Location = New Point(339, 29)
        PerkalianVarHasil.Name = "PerkalianVarHasil"
        PerkalianVarHasil.Size = New Size(13, 15)
        PerkalianVarHasil.TabIndex = 5
        PerkalianVarHasil.Text = "0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(303, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(15, 15)
        Label2.TabIndex = 4
        Label2.Text = "="
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(138, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(14, 15)
        Label1.TabIndex = 3
        Label1.Text = "X"
        ' 
        ' PerkalianBtn
        ' 
        PerkalianBtn.Location = New Point(108, 67)
        PerkalianBtn.Name = "PerkalianBtn"
        PerkalianBtn.Size = New Size(75, 23)
        PerkalianBtn.TabIndex = 2
        PerkalianBtn.Text = "hitung"
        PerkalianBtn.UseVisualStyleBackColor = True
        ' 
        ' PerkalianVar2
        ' 
        PerkalianVar2.Location = New Point(178, 26)
        PerkalianVar2.Name = "PerkalianVar2"
        PerkalianVar2.Size = New Size(100, 23)
        PerkalianVar2.TabIndex = 1
        ' 
        ' PerkalianVar1
        ' 
        PerkalianVar1.Location = New Point(14, 26)
        PerkalianVar1.Name = "PerkalianVar1"
        PerkalianVar1.Size = New Size(100, 23)
        PerkalianVar1.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(PerpangkatanHasil)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(PerpangkatanBtn)
        GroupBox1.Controls.Add(PerpangkatanVar2)
        GroupBox1.Controls.Add(PerpangkatanVar1)
        GroupBox1.Location = New Point(0, 111)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(774, 105)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Perpangkatan"
        ' 
        ' PerpangkatanHasil
        ' 
        PerpangkatanHasil.AutoSize = True
        PerpangkatanHasil.Location = New Point(135, 37)
        PerpangkatanHasil.Name = "PerpangkatanHasil"
        PerpangkatanHasil.Size = New Size(13, 15)
        PerpangkatanHasil.TabIndex = 5
        PerpangkatanHasil.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(99, 37)
        Label4.Name = "Label4"
        Label4.Size = New Size(15, 15)
        Label4.TabIndex = 4
        Label4.Text = "="
        ' 
        ' PerpangkatanBtn
        ' 
        PerpangkatanBtn.Location = New Point(13, 67)
        PerpangkatanBtn.Name = "PerpangkatanBtn"
        PerpangkatanBtn.Size = New Size(75, 23)
        PerpangkatanBtn.TabIndex = 2
        PerpangkatanBtn.Text = "hitung"
        PerpangkatanBtn.UseVisualStyleBackColor = True
        ' 
        ' PerpangkatanVar2
        ' 
        PerpangkatanVar2.Font = New Font("Segoe UI", 7.0F)
        PerpangkatanVar2.Location = New Point(62, 22)
        PerpangkatanVar2.Name = "PerpangkatanVar2"
        PerpangkatanVar2.Size = New Size(26, 20)
        PerpangkatanVar2.TabIndex = 1
        ' 
        ' PerpangkatanVar1
        ' 
        PerpangkatanVar1.Location = New Point(14, 29)
        PerpangkatanVar1.Name = "PerpangkatanVar1"
        PerpangkatanVar1.Size = New Size(42, 23)
        PerpangkatanVar1.TabIndex = 0
        ' 
        ' Logaritma
        ' 
        Logaritma.Controls.Add(adasd)
        Logaritma.Controls.Add(LogHasil)
        Logaritma.Controls.Add(Label7)
        Logaritma.Controls.Add(LogBtn)
        Logaritma.Controls.Add(LogVar1)
        Logaritma.Controls.Add(LogVar2)
        Logaritma.Location = New Point(5, 363)
        Logaritma.Name = "Logaritma"
        Logaritma.Size = New Size(774, 105)
        Logaritma.TabIndex = 8
        Logaritma.TabStop = False
        Logaritma.Text = "Logaritama"
        ' 
        ' adasd
        ' 
        adasd.AutoSize = True
        adasd.Location = New Point(38, 37)
        adasd.Name = "adasd"
        adasd.Size = New Size(27, 15)
        adasd.TabIndex = 6
        adasd.Text = "Log"
        ' 
        ' LogHasil
        ' 
        LogHasil.AutoSize = True
        LogHasil.Location = New Point(165, 37)
        LogHasil.Name = "LogHasil"
        LogHasil.Size = New Size(13, 15)
        LogHasil.TabIndex = 5
        LogHasil.Text = "0"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(122, 37)
        Label7.Name = "Label7"
        Label7.Size = New Size(15, 15)
        Label7.TabIndex = 4
        Label7.Text = "="
        ' 
        ' LogBtn
        ' 
        LogBtn.Location = New Point(13, 67)
        LogBtn.Name = "LogBtn"
        LogBtn.Size = New Size(75, 23)
        LogBtn.TabIndex = 2
        LogBtn.Text = "hitung"
        LogBtn.UseVisualStyleBackColor = True
        ' 
        ' LogVar1
        ' 
        LogVar1.Font = New Font("Segoe UI", 7.0F)
        LogVar1.Location = New Point(14, 22)
        LogVar1.Name = "LogVar1"
        LogVar1.Size = New Size(26, 20)
        LogVar1.TabIndex = 1
        ' 
        ' LogVar2
        ' 
        LogVar2.Location = New Point(62, 34)
        LogVar2.Name = "LogVar2"
        LogVar2.Size = New Size(42, 23)
        LogVar2.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Controls.Add(GroupBox4)
        Panel1.Controls.Add(Logaritma)
        Panel1.Controls.Add(GroupBox2)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Controls.Add(GroupBoxPerkalian)
        Panel1.Location = New Point(14, 20)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(774, 418)
        Panel1.TabIndex = 0
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(Label6)
        GroupBox4.Controls.Add(FactorHasil)
        GroupBox4.Controls.Add(Label9)
        GroupBox4.Controls.Add(FactorBtn)
        GroupBox4.Controls.Add(FactorVar1)
        GroupBox4.Location = New Point(5, 492)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(774, 105)
        GroupBox4.TabIndex = 9
        GroupBox4.TabStop = False
        GroupBox4.Text = "Faktorial"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(62, 32)
        Label6.Name = "Label6"
        Label6.Size = New Size(10, 15)
        Label6.TabIndex = 6
        Label6.Text = "!"
        ' 
        ' FactorHasil
        ' 
        FactorHasil.AutoSize = True
        FactorHasil.Location = New Point(122, 32)
        FactorHasil.Name = "FactorHasil"
        FactorHasil.Size = New Size(13, 15)
        FactorHasil.TabIndex = 5
        FactorHasil.Text = "0"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(89, 32)
        Label9.Name = "Label9"
        Label9.Size = New Size(15, 15)
        Label9.TabIndex = 4
        Label9.Text = "="
        ' 
        ' FactorBtn
        ' 
        FactorBtn.Location = New Point(13, 67)
        FactorBtn.Name = "FactorBtn"
        FactorBtn.Size = New Size(75, 23)
        FactorBtn.TabIndex = 2
        FactorBtn.Text = "hitung"
        FactorBtn.UseVisualStyleBackColor = True
        ' 
        ' FactorVar1
        ' 
        FactorVar1.Location = New Point(14, 29)
        FactorVar1.Name = "FactorVar1"
        FactorVar1.Size = New Size(42, 23)
        FactorVar1.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBoxPerkalian.ResumeLayout(False)
        GroupBoxPerkalian.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Logaritma.ResumeLayout(False)
        Logaritma.PerformLayout()
        Panel1.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents AkarHasil As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents AkarBtn As Button
    Friend WithEvents AkarVar1 As TextBox
    Friend WithEvents AkarVar2 As TextBox
    Friend WithEvents GroupBoxPerkalian As GroupBox
    Friend WithEvents PerkalianVarHasil As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PerkalianBtn As Button
    Friend WithEvents PerkalianVar2 As TextBox
    Friend WithEvents PerkalianVar1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PerpangkatanHasil As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PerpangkatanBtn As Button
    Friend WithEvents PerpangkatanVar2 As TextBox
    Friend WithEvents PerpangkatanVar1 As TextBox
    Friend WithEvents Logaritma As GroupBox
    Friend WithEvents LogHasil As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LogBtn As Button
    Friend WithEvents LogVar1 As TextBox
    Friend WithEvents LogVar2 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents FactorHasil As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents FactorBtn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents FactorVar1 As TextBox
    Friend WithEvents adasd As Label
    Friend WithEvents Label6 As Label


End Class
