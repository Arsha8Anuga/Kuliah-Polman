
Imports OxyPlot.WindowsForms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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

    Private plotView As PlotView

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PlotView1 = New PlotView()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PlotView1
        ' 
        PlotView1.BackColor = SystemColors.AppWorkspace
        PlotView1.Location = New Point(14, 79)
        PlotView1.Margin = New Padding(3, 4, 3, 4)
        PlotView1.Name = "PlotView1"
        PlotView1.PanCursor = Cursors.Hand
        PlotView1.Size = New Size(455, 505)
        PlotView1.TabIndex = 1
        PlotView1.Text = "PlotView1"
        PlotView1.ZoomHorizontalCursor = Cursors.SizeWE
        PlotView1.ZoomRectangleCursor = Cursors.SizeNWSE
        PlotView1.ZoomVerticalCursor = Cursors.SizeNS
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(496, 79)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(381, 505)
        DataGridView1.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(890, 600)
        Controls.Add(DataGridView1)
        Controls.Add(PlotView1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PlotView1 As PlotView
    Friend WithEvents DataGridView1 As DataGridView

End Class
