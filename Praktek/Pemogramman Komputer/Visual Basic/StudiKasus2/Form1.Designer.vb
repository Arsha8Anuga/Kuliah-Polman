<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        ForEachTxt = New MaskedTextBox()
        ForEachBtn = New Button()
        Label2 = New Label()
        writeTxt = New MaskedTextBox()
        WriteBtn = New Button()
        ReadBtn = New Button()
        Label3 = New Label()
        SegitigaTxt = New TextBox()
        SegitigaBtn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(36, 108)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 15)
        Label1.TabIndex = 0
        Label1.Text = "foreach loop"
        ' 
        ' ForEachTxt
        ' 
        ForEachTxt.Location = New Point(125, 105)
        ForEachTxt.Name = "ForEachTxt"
        ForEachTxt.Size = New Size(558, 23)
        ForEachTxt.TabIndex = 1
        ' 
        ' ForEachBtn
        ' 
        ForEachBtn.Location = New Point(702, 104)
        ForEachBtn.Name = "ForEachBtn"
        ForEachBtn.Size = New Size(75, 23)
        ForEachBtn.TabIndex = 2
        ForEachBtn.Text = "Submit"
        ForEachBtn.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(36, 174)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 15)
        Label2.TabIndex = 3
        Label2.Text = "write file"
        ' 
        ' writeTxt
        ' 
        writeTxt.Location = New Point(125, 166)
        writeTxt.Name = "writeTxt"
        writeTxt.Size = New Size(460, 23)
        writeTxt.TabIndex = 4
        ' 
        ' WriteBtn
        ' 
        WriteBtn.Location = New Point(608, 166)
        WriteBtn.Name = "WriteBtn"
        WriteBtn.Size = New Size(75, 23)
        WriteBtn.TabIndex = 5
        WriteBtn.Text = "Write"
        WriteBtn.UseVisualStyleBackColor = True
        ' 
        ' ReadBtn
        ' 
        ReadBtn.Location = New Point(702, 165)
        ReadBtn.Name = "ReadBtn"
        ReadBtn.Size = New Size(75, 23)
        ReadBtn.TabIndex = 6
        ReadBtn.Text = "Read"
        ReadBtn.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(36, 57)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 15)
        Label3.TabIndex = 10
        Label3.Text = "Segitiga"
        ' 
        ' SegitigaTxt
        ' 
        SegitigaTxt.Location = New Point(125, 54)
        SegitigaTxt.Name = "SegitigaTxt"
        SegitigaTxt.Size = New Size(558, 23)
        SegitigaTxt.TabIndex = 11
        ' 
        ' SegitigaBtn
        ' 
        SegitigaBtn.Location = New Point(702, 57)
        SegitigaBtn.Name = "SegitigaBtn"
        SegitigaBtn.Size = New Size(75, 23)
        SegitigaBtn.TabIndex = 12
        SegitigaBtn.Text = "Submit"
        SegitigaBtn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 247)
        Controls.Add(SegitigaBtn)
        Controls.Add(SegitigaTxt)
        Controls.Add(Label3)
        Controls.Add(ReadBtn)
        Controls.Add(WriteBtn)
        Controls.Add(writeTxt)
        Controls.Add(Label2)
        Controls.Add(ForEachBtn)
        Controls.Add(ForEachTxt)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ForEachTxt As MaskedTextBox
    Friend WithEvents ForEachBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents writeTxt As MaskedTextBox
    Friend WithEvents WriteBtn As Button
    Friend WithEvents ReadBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents SegitigaTxt As TextBox
    Friend WithEvents SegitigaBtn As Button
End Class
