<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studikasus1TebakHuruf
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
        Label1 = New Label()
        Tebak = New TextBox()
        Hasil = New TextBox()
        TebakBtn = New Button()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' BackBtn
        ' 
        BackBtn.Location = New Point(12, 12)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(75, 23)
        BackBtn.TabIndex = 0
        BackBtn.Text = "Back"
        BackBtn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(173, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 24)
        Label1.TabIndex = 1
        Label1.Text = "TEBAK HURUF"
        ' 
        ' Tebak
        ' 
        Tebak.Font = New Font("Adobe Fan Heiti Std B", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Tebak.Location = New Point(131, 141)
        Tebak.Name = "Tebak"
        Tebak.Size = New Size(237, 55)
        Tebak.TabIndex = 2
        Tebak.TextAlign = HorizontalAlignment.Center
        ' 
        ' Hasil
        ' 
        Hasil.Enabled = False
        Hasil.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Hasil.Location = New Point(52, 245)
        Hasil.Name = "Hasil"
        Hasil.ReadOnly = True
        Hasil.Size = New Size(377, 45)
        Hasil.TabIndex = 3
        Hasil.TextAlign = HorizontalAlignment.Center
        ' 
        ' TebakBtn
        ' 
        TebakBtn.Location = New Point(211, 202)
        TebakBtn.Name = "TebakBtn"
        TebakBtn.Size = New Size(75, 23)
        TebakBtn.TabIndex = 4
        TebakBtn.Text = "TEBAK"
        TebakBtn.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(131, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(157, 15)
        Label2.TabIndex = 5
        Label2.Text = "Silahkan pilih tebakan anda :"
        ' 
        ' studikasus1TebakHuruf
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(477, 321)
        Controls.Add(Label2)
        Controls.Add(TebakBtn)
        Controls.Add(Hasil)
        Controls.Add(Tebak)
        Controls.Add(Label1)
        Controls.Add(BackBtn)
        Name = "studikasus1TebakHuruf"
        Text = "studikasus1TebakHuruf"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BackBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Tebak As TextBox
    Friend WithEvents Hasil As TextBox
    Friend WithEvents TebakBtn As Button
    Friend WithEvents Label2 As Label
End Class
