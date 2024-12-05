<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableAndVisualization
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
        PengeluaranBtn = New Button()
        DataGraph = New OxyPlot.WindowsForms.PlotView()
        TableData = New DataGridView()
        PemasukanBtn = New Button()
        Label1 = New Label()
        DateTimePicker = New DateTimePicker()
        CBTime = New ComboBox()
        CType(TableData, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BackBtn
        ' 
        BackBtn.BackColor = Color.FromArgb(CByte(35), CByte(36), CByte(40))
        BackBtn.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BackBtn.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        BackBtn.Location = New Point(29, 43)
        BackBtn.Margin = New Padding(3, 4, 3, 4)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(104, 45)
        BackBtn.TabIndex = 0
        BackBtn.Text = "Back"
        BackBtn.UseVisualStyleBackColor = False
        ' 
        ' PengeluaranBtn
        ' 
        PengeluaranBtn.BackColor = Color.Maroon
        PengeluaranBtn.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PengeluaranBtn.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        PengeluaranBtn.Location = New Point(808, 43)
        PengeluaranBtn.Margin = New Padding(3, 4, 3, 4)
        PengeluaranBtn.Name = "PengeluaranBtn"
        PengeluaranBtn.Size = New Size(166, 45)
        PengeluaranBtn.TabIndex = 1
        PengeluaranBtn.Text = "Pengeluaran"
        PengeluaranBtn.UseVisualStyleBackColor = False
        ' 
        ' DataGraph
        ' 
        DataGraph.BackColor = Color.FromArgb(CByte(35), CByte(36), CByte(40))
        DataGraph.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        DataGraph.Location = New Point(29, 184)
        DataGraph.Margin = New Padding(3, 4, 3, 4)
        DataGraph.Name = "DataGraph"
        DataGraph.PanCursor = Cursors.Hand
        DataGraph.Size = New Size(566, 435)
        DataGraph.TabIndex = 2
        DataGraph.ZoomHorizontalCursor = Cursors.SizeWE
        DataGraph.ZoomRectangleCursor = Cursors.SizeNWSE
        DataGraph.ZoomVerticalCursor = Cursors.SizeNS
        ' 
        ' TableData
        ' 
        TableData.BackgroundColor = Color.FromArgb(CByte(35), CByte(36), CByte(40))
        TableData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TableData.Location = New Point(617, 96)
        TableData.Margin = New Padding(3, 4, 3, 4)
        TableData.Name = "TableData"
        TableData.RowHeadersWidth = 51
        TableData.Size = New Size(357, 587)
        TableData.TabIndex = 3
        ' 
        ' PemasukanBtn
        ' 
        PemasukanBtn.BackColor = Color.Green
        PemasukanBtn.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PemasukanBtn.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        PemasukanBtn.Location = New Point(617, 43)
        PemasukanBtn.Margin = New Padding(3, 4, 3, 4)
        PemasukanBtn.Name = "PemasukanBtn"
        PemasukanBtn.Size = New Size(173, 45)
        PemasukanBtn.TabIndex = 4
        PemasukanBtn.Text = "Pemasukan"
        PemasukanBtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        Label1.Location = New Point(207, 123)
        Label1.Name = "Label1"
        Label1.Size = New Size(262, 29)
        Label1.TabIndex = 5
        Label1.Text = "Visualisasi Keuangan"
        ' 
        ' DateTimePicker
        ' 
        DateTimePicker.CalendarFont = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DateTimePicker.CalendarForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        DateTimePicker.CalendarMonthBackground = Color.FromArgb(CByte(35), CByte(36), CByte(40))
        DateTimePicker.CustomFormat = ""
        DateTimePicker.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        DateTimePicker.Location = New Point(29, 644)
        DateTimePicker.Margin = New Padding(3, 4, 3, 4)
        DateTimePicker.Name = "DateTimePicker"
        DateTimePicker.Size = New Size(170, 23)
        DateTimePicker.TabIndex = 6
        ' 
        ' CBTime
        ' 
        CBTime.BackColor = Color.FromArgb(CByte(35), CByte(36), CByte(40))
        CBTime.DropDownStyle = ComboBoxStyle.DropDownList
        CBTime.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CBTime.ForeColor = Color.FromArgb(CByte(215), CByte(216), CByte(217))
        CBTime.FormattingEnabled = True
        CBTime.Items.AddRange(New Object() {"1 Day", "1 Month"})
        CBTime.Location = New Point(392, 652)
        CBTime.Margin = New Padding(3, 4, 3, 4)
        CBTime.Name = "CBTime"
        CBTime.Size = New Size(202, 26)
        CBTime.TabIndex = 7
        ' 
        ' TableAndVisualization
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(49), CByte(51), CByte(56))
        ClientSize = New Size(1006, 715)
        ControlBox = False
        Controls.Add(CBTime)
        Controls.Add(DateTimePicker)
        Controls.Add(Label1)
        Controls.Add(PemasukanBtn)
        Controls.Add(TableData)
        Controls.Add(DataGraph)
        Controls.Add(PengeluaranBtn)
        Controls.Add(BackBtn)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        Name = "TableAndVisualization"
        CType(TableData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BackBtn As Button
    Friend WithEvents PengeluaranBtn As Button
    Friend WithEvents DataGraph As OxyPlot.WindowsForms.PlotView
    Friend WithEvents TableData As DataGridView
    Friend WithEvents PemasukanBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents CBTime As ComboBox
End Class
