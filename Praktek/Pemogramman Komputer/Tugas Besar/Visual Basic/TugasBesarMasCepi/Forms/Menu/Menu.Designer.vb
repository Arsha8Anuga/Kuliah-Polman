<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        LogoutBtn = New Button()
        UserLabel = New Label()
        CreateDataBtn = New Button()
        LogActivityBtn = New Button()
        TableAndVisualizationBtn = New Button()
        ExitBtn = New Button()
        SuspendLayout()
        ' 
        ' LogoutBtn
        ' 
        LogoutBtn.BackColor = Color.FromArgb(CByte(35), CByte(36), CByte(40))
        LogoutBtn.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogoutBtn.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        LogoutBtn.Location = New Point(14, 16)
        LogoutBtn.Margin = New Padding(3, 4, 3, 4)
        LogoutBtn.Name = "LogoutBtn"
        LogoutBtn.Size = New Size(130, 48)
        LogoutBtn.TabIndex = 0
        LogoutBtn.Text = "Logout"
        LogoutBtn.UseVisualStyleBackColor = False
        ' 
        ' UserLabel
        ' 
        UserLabel.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UserLabel.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        UserLabel.Location = New Point(166, 27)
        UserLabel.Name = "UserLabel"
        UserLabel.Size = New Size(413, 31)
        UserLabel.TabIndex = 1
        UserLabel.Text = "Label1"
        UserLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CreateDataBtn
        ' 
        CreateDataBtn.BackColor = Color.FromArgb(CByte(35), CByte(36), CByte(40))
        CreateDataBtn.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CreateDataBtn.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        CreateDataBtn.Location = New Point(144, 211)
        CreateDataBtn.Margin = New Padding(3, 4, 3, 4)
        CreateDataBtn.Name = "CreateDataBtn"
        CreateDataBtn.Size = New Size(309, 48)
        CreateDataBtn.TabIndex = 2
        CreateDataBtn.Text = "Create Data"
        CreateDataBtn.UseVisualStyleBackColor = False
        ' 
        ' LogActivityBtn
        ' 
        LogActivityBtn.BackColor = Color.FromArgb(CByte(35), CByte(36), CByte(40))
        LogActivityBtn.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogActivityBtn.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        LogActivityBtn.Location = New Point(144, 281)
        LogActivityBtn.Margin = New Padding(3, 4, 3, 4)
        LogActivityBtn.Name = "LogActivityBtn"
        LogActivityBtn.Size = New Size(309, 48)
        LogActivityBtn.TabIndex = 3
        LogActivityBtn.Text = "Log Activity"
        LogActivityBtn.UseVisualStyleBackColor = False
        ' 
        ' TableAndVisualizationBtn
        ' 
        TableAndVisualizationBtn.BackColor = Color.FromArgb(CByte(35), CByte(36), CByte(40))
        TableAndVisualizationBtn.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TableAndVisualizationBtn.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        TableAndVisualizationBtn.Location = New Point(144, 352)
        TableAndVisualizationBtn.Margin = New Padding(3, 4, 3, 4)
        TableAndVisualizationBtn.Name = "TableAndVisualizationBtn"
        TableAndVisualizationBtn.Size = New Size(309, 48)
        TableAndVisualizationBtn.TabIndex = 4
        TableAndVisualizationBtn.Text = "Table And Visualization"
        TableAndVisualizationBtn.UseVisualStyleBackColor = False
        ' 
        ' ExitBtn
        ' 
        ExitBtn.BackColor = Color.FromArgb(CByte(35), CByte(36), CByte(40))
        ExitBtn.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ExitBtn.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        ExitBtn.Location = New Point(144, 425)
        ExitBtn.Margin = New Padding(3, 4, 3, 4)
        ExitBtn.Name = "ExitBtn"
        ExitBtn.Size = New Size(309, 48)
        ExitBtn.TabIndex = 5
        ExitBtn.Text = "Exit"
        ExitBtn.UseVisualStyleBackColor = False
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(49), CByte(51), CByte(56))
        ClientSize = New Size(606, 555)
        ControlBox = False
        Controls.Add(ExitBtn)
        Controls.Add(TableAndVisualizationBtn)
        Controls.Add(LogActivityBtn)
        Controls.Add(CreateDataBtn)
        Controls.Add(UserLabel)
        Controls.Add(LogoutBtn)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        Name = "Menu"
        ResumeLayout(False)
    End Sub

    Friend WithEvents LogoutBtn As Button
    Friend WithEvents UserLabel As Label
    Friend WithEvents CreateDataBtn As Button
    Friend WithEvents LogActivityBtn As Button
    Friend WithEvents TableAndVisualizationBtn As Button
    Friend WithEvents ExitBtn As Button
End Class
