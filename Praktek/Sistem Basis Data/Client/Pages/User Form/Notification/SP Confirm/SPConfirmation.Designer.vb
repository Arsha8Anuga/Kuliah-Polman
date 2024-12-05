Imports System.Reflection.Emit

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SPConfirmation
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
        ImageHolder = New PictureBox()
        CancelBtn = New Button()
        ConfirmBtn = New Button()
        WaitLbl = New System.Windows.Forms.Label()
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
        ' CancelBtn
        ' 
        CancelBtn.Enabled = False
        CancelBtn.Location = New Point(379, 376)
        CancelBtn.Name = "CancelBtn"
        CancelBtn.Size = New Size(75, 23)
        CancelBtn.TabIndex = 2
        CancelBtn.Text = "Batal"
        CancelBtn.UseVisualStyleBackColor = True
        CancelBtn.Visible = False
        ' 
        ' ConfirmBtn
        ' 
        ConfirmBtn.Enabled = False
        ConfirmBtn.Location = New Point(298, 376)
        ConfirmBtn.Name = "ConfirmBtn"
        ConfirmBtn.Size = New Size(75, 23)
        ConfirmBtn.TabIndex = 3
        ConfirmBtn.Text = "Terima"
        ConfirmBtn.UseVisualStyleBackColor = True
        ConfirmBtn.Visible = False
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
        ' SPConfirmation
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(497, 450)
        Controls.Add(WaitLbl)
        Controls.Add(ConfirmBtn)
        Controls.Add(CancelBtn)
        Controls.Add(ImageHolder)
        MaximizeBox = False
        MinimizeBox = False
        Name = "SPConfirmation"
        Text = "SPConfirm - Fatan"
        CType(ImageHolder, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ImageHolder As PictureBox
    Friend WithEvents CancelBtn As Button
    Friend WithEvents ConfirmBtn As Button
    Friend WithEvents WaitLbl As System.Windows.Forms.Label

End Class
