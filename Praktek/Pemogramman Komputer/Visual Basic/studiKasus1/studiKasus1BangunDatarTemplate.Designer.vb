<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class studiKasus1BangunDatarTemplate
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
        CloseBtn = New Label()
        titleName = New Label()
        SuspendLayout()
        ' 
        ' CloseBtn
        ' 
        CloseBtn.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CloseBtn.Location = New Point(12, 9)
        CloseBtn.Name = "CloseBtn"
        CloseBtn.Size = New Size(77, 39)
        CloseBtn.TabIndex = 0
        CloseBtn.Text = "Close"
        CloseBtn.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' titleName
        ' 
        titleName.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        titleName.Location = New Point(189, 50)
        titleName.Name = "titleName"
        titleName.Size = New Size(277, 54)
        titleName.TabIndex = 1
        titleName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' studiKasus1BangunDatarTemplate
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(677, 506)
        Controls.Add(titleName)
        Controls.Add(CloseBtn)
        Name = "studiKasus1BangunDatarTemplate"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents CloseBtn As Label
    Friend WithEvents titleName As Label
End Class
