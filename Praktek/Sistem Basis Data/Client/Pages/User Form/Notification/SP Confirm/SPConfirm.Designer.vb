<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SPConfirm
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
        ImageHolder = New PictureBox()
        BrowseBtn = New Button()
        EditBtn = New Button()
        InsertBtn = New Button()
        WaitLbl = New Label()
        Label1 = New Label()
        CType(ImageHolder, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ImageHolder
        ' 
        ImageHolder.Location = New Point(37, 42)
        ImageHolder.Name = "ImageHolder"
        ImageHolder.Size = New Size(417, 300)
        ImageHolder.SizeMode = PictureBoxSizeMode.StretchImage
        ImageHolder.TabIndex = 0
        ImageHolder.TabStop = False
        ImageHolder.Visible = False
        ' 
        ' BrowseBtn
        ' 
        BrowseBtn.Location = New Point(37, 376)
        BrowseBtn.Name = "BrowseBtn"
        BrowseBtn.Size = New Size(75, 23)
        BrowseBtn.TabIndex = 1
        BrowseBtn.Text = "Browse"
        BrowseBtn.UseVisualStyleBackColor = True
        BrowseBtn.Visible = False
        ' 
        ' EditBtn
        ' 
        EditBtn.Location = New Point(379, 376)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(75, 23)
        EditBtn.TabIndex = 2
        EditBtn.Text = "Update"
        EditBtn.UseVisualStyleBackColor = True
        EditBtn.Visible = False
        ' 
        ' InsertBtn
        ' 
        InsertBtn.Location = New Point(298, 376)
        InsertBtn.Name = "InsertBtn"
        InsertBtn.Size = New Size(75, 23)
        InsertBtn.TabIndex = 3
        InsertBtn.Text = "Submit"
        InsertBtn.UseVisualStyleBackColor = True
        InsertBtn.Visible = False
        ' 
        ' WaitLbl
        ' 
        WaitLbl.AutoSize = True
        WaitLbl.Location = New Point(140, 183)
        WaitLbl.Name = "WaitLbl"
        WaitLbl.Size = New Size(216, 15)
        WaitLbl.TabIndex = 4
        WaitLbl.Text = "Mohon Bersabar sedang inisialisasi data"
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(120, 380)
        Label1.Name = "Label1"
        Label1.Size = New Size(139, 19)
        Label1.TabIndex = 5
        Label1.Visible = False
        ' 
        ' SPConfirm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(497, 450)
        Controls.Add(Label1)
        Controls.Add(WaitLbl)
        Controls.Add(InsertBtn)
        Controls.Add(EditBtn)
        Controls.Add(BrowseBtn)
        Controls.Add(ImageHolder)
        MaximizeBox = False
        MinimizeBox = False
        Name = "SPConfirm"
        Text = "SPConfirm - Fatan"
        CType(ImageHolder, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ImageHolder As PictureBox
    Friend WithEvents BrowseBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents InsertBtn As Button
    Friend WithEvents WaitLbl As Label
    Friend WithEvents Label1 As Label
End Class
