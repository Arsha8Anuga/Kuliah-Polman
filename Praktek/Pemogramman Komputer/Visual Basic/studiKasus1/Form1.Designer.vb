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
        congrats = New Label()
        backOpt = New LinkLabel()
        SuspendLayout()
        ' 
        ' congrats
        ' 
        congrats.Font = New Font("Adobe Fan Heiti Std B", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        congrats.Location = New Point(34, 134)
        congrats.Name = "congrats"
        congrats.Size = New Size(556, 55)
        congrats.TabIndex = 0
        congrats.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' backOpt
        ' 
        backOpt.AutoSize = True
        backOpt.Font = New Font("Adobe Fan Heiti Std B", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        backOpt.Location = New Point(12, 9)
        backOpt.Name = "backOpt"
        backOpt.Size = New Size(57, 26)
        backOpt.TabIndex = 1
        backOpt.TabStop = True
        backOpt.Text = "Back"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(626, 351)
        ControlBox = False
        Controls.Add(backOpt)
        Controls.Add(congrats)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents congrats As Label
    Friend WithEvents backOpt As LinkLabel
End Class
