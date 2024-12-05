<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateData
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
        BackBtn = New Button()
        PemasukanBtn = New Button()
        PengeluaranBtn = New Button()
        SubmitBtn = New Button()
        FormGroupBox = New GroupBox()
        FormPanel = New Panel()
        PerincianText = New TextBox()
        NominalText = New TextBox()
        MetodeCB = New ComboBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        FormGroupBox.SuspendLayout()
        FormPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' BackBtn
        ' 
        BackBtn.BackColor = Color.FromArgb(CByte(35), CByte(36), CByte(40))
        BackBtn.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BackBtn.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        BackBtn.Location = New Point(14, 16)
        BackBtn.Margin = New Padding(3, 4, 3, 4)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(127, 40)
        BackBtn.TabIndex = 0
        BackBtn.Text = "Back"
        BackBtn.UseVisualStyleBackColor = False
        ' 
        ' PemasukanBtn
        ' 
        PemasukanBtn.BackColor = Color.Green
        PemasukanBtn.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PemasukanBtn.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        PemasukanBtn.Location = New Point(14, 85)
        PemasukanBtn.Margin = New Padding(3, 4, 3, 4)
        PemasukanBtn.Name = "PemasukanBtn"
        PemasukanBtn.Size = New Size(306, 40)
        PemasukanBtn.TabIndex = 1
        PemasukanBtn.Text = "Pemasukan"
        PemasukanBtn.UseVisualStyleBackColor = False
        ' 
        ' PengeluaranBtn
        ' 
        PengeluaranBtn.BackColor = Color.Maroon
        PengeluaranBtn.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PengeluaranBtn.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        PengeluaranBtn.Location = New Point(327, 85)
        PengeluaranBtn.Margin = New Padding(3, 4, 3, 4)
        PengeluaranBtn.Name = "PengeluaranBtn"
        PengeluaranBtn.Size = New Size(289, 40)
        PengeluaranBtn.TabIndex = 2
        PengeluaranBtn.Text = "Pengeluaran"
        PengeluaranBtn.UseVisualStyleBackColor = False
        ' 
        ' SubmitBtn
        ' 
        SubmitBtn.BackColor = Color.FromArgb(CByte(35), CByte(36), CByte(40))
        SubmitBtn.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SubmitBtn.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        SubmitBtn.Location = New Point(489, 523)
        SubmitBtn.Margin = New Padding(3, 4, 3, 4)
        SubmitBtn.Name = "SubmitBtn"
        SubmitBtn.Size = New Size(127, 40)
        SubmitBtn.TabIndex = 4
        SubmitBtn.Text = "Submit"
        SubmitBtn.UseVisualStyleBackColor = False
        ' 
        ' FormGroupBox
        ' 
        FormGroupBox.Controls.Add(FormPanel)
        FormGroupBox.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        FormGroupBox.Location = New Point(19, 149)
        FormGroupBox.Margin = New Padding(3, 4, 3, 4)
        FormGroupBox.Name = "FormGroupBox"
        FormGroupBox.Padding = New Padding(3, 4, 3, 4)
        FormGroupBox.Size = New Size(597, 352)
        FormGroupBox.TabIndex = 5
        FormGroupBox.TabStop = False
        FormGroupBox.Text = "GroupBox1"
        ' 
        ' FormPanel
        ' 
        FormPanel.AutoScroll = True
        FormPanel.Controls.Add(PerincianText)
        FormPanel.Controls.Add(NominalText)
        FormPanel.Controls.Add(MetodeCB)
        FormPanel.Controls.Add(Label3)
        FormPanel.Controls.Add(Label2)
        FormPanel.Controls.Add(Label1)
        FormPanel.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        FormPanel.Location = New Point(0, 29)
        FormPanel.Margin = New Padding(3, 4, 3, 4)
        FormPanel.Name = "FormPanel"
        FormPanel.Size = New Size(597, 323)
        FormPanel.TabIndex = 0
        ' 
        ' PerincianText
        ' 
        PerincianText.BackColor = Color.FromArgb(CByte(35), CByte(36), CByte(40))
        PerincianText.BorderStyle = BorderStyle.FixedSingle
        PerincianText.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        PerincianText.Location = New Point(129, 149)
        PerincianText.Margin = New Padding(3, 4, 3, 4)
        PerincianText.Multiline = True
        PerincianText.Name = "PerincianText"
        PerincianText.Size = New Size(436, 143)
        PerincianText.TabIndex = 5
        ' 
        ' NominalText
        ' 
        NominalText.BackColor = Color.FromArgb(CByte(35), CByte(36), CByte(40))
        NominalText.BorderStyle = BorderStyle.FixedSingle
        NominalText.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        NominalText.Location = New Point(129, 24)
        NominalText.Margin = New Padding(3, 4, 3, 4)
        NominalText.Name = "NominalText"
        NominalText.Size = New Size(436, 27)
        NominalText.TabIndex = 4
        ' 
        ' MetodeCB
        ' 
        MetodeCB.BackColor = Color.FromArgb(CByte(35), CByte(36), CByte(40))
        MetodeCB.DropDownStyle = ComboBoxStyle.DropDownList
        MetodeCB.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        MetodeCB.FormattingEnabled = True
        MetodeCB.Items.AddRange(New Object() {"Cash", "Non-Cash"})
        MetodeCB.Location = New Point(129, 80)
        MetodeCB.Margin = New Padding(3, 4, 3, 4)
        MetodeCB.Name = "MetodeCB"
        MetodeCB.Size = New Size(138, 28)
        MetodeCB.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        Label3.Location = New Point(17, 155)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 24)
        Label3.TabIndex = 2
        Label3.Text = "Perincian"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        Label2.Location = New Point(17, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 24)
        Label2.TabIndex = 1
        Label2.Text = "Metode"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        Label1.Location = New Point(17, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 24)
        Label1.TabIndex = 0
        Label1.Text = "Nominal"
        ' 
        ' CreateData
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(49), CByte(51), CByte(56))
        ClientSize = New Size(642, 592)
        ControlBox = False
        Controls.Add(SubmitBtn)
        Controls.Add(FormGroupBox)
        Controls.Add(PengeluaranBtn)
        Controls.Add(PemasukanBtn)
        Controls.Add(BackBtn)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "CreateData"
        ShowIcon = False
        FormGroupBox.ResumeLayout(False)
        FormPanel.ResumeLayout(False)
        FormPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BackBtn As Button
    Friend WithEvents PemasukanBtn As Button
    Friend WithEvents PengeluaranBtn As Button
    Friend WithEvents SubmitBtn As Button
    Friend WithEvents FormGroupBox As GroupBox
    Friend WithEvents FormPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PerincianText As TextBox
    Friend WithEvents NominalText As TextBox
    Friend WithEvents MetodeCB As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
