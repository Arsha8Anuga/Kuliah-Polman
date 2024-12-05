<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectCase
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
        TextBox1 = New TextBox()
        nilaiLbl = New Label()
        NilaiBtn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(157, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 15)
        Label1.TabIndex = 0
        Label1.Text = "Input Nilai"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(66, 62)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(256, 23)
        TextBox1.TabIndex = 1
        ' 
        ' nilaiLbl
        ' 
        nilaiLbl.Location = New Point(66, 101)
        nilaiLbl.Name = "nilaiLbl"
        nilaiLbl.Size = New Size(256, 23)
        nilaiLbl.TabIndex = 2
        nilaiLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NilaiBtn
        ' 
        NilaiBtn.Location = New Point(117, 144)
        NilaiBtn.Name = "NilaiBtn"
        NilaiBtn.Size = New Size(139, 23)
        NilaiBtn.TabIndex = 3
        NilaiBtn.Text = "Submit Nilai"
        NilaiBtn.UseVisualStyleBackColor = True
        ' 
        ' SelectCase
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(390, 179)
        Controls.Add(NilaiBtn)
        Controls.Add(nilaiLbl)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "SelectCase"
        Text = "SelectCase"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents nilaiLbl As Label
    Friend WithEvents NilaiBtn As Button
End Class
