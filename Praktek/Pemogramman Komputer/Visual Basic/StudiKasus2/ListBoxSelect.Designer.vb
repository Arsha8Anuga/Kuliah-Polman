<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListBoxSelect
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
        ListAsal = New ListBox()
        ListTujuan = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        TotalTxt = New TextBox()
        Label3 = New Label()
        BonusTxt = New TextBox()
        SuspendLayout()
        ' 
        ' ListAsal
        ' 
        ListAsal.FormattingEnabled = True
        ListAsal.ItemHeight = 15
        ListAsal.Items.AddRange(New Object() {"Jersey Xl  = 120000", "Minyak = 14000", "Snack Mini = 2000", "Beras 15KG = 150000", "Bunga Eucalyptus = 300000"})
        ListAsal.Location = New Point(151, 72)
        ListAsal.Name = "ListAsal"
        ListAsal.Size = New Size(208, 184)
        ListAsal.TabIndex = 0
        ' 
        ' ListTujuan
        ' 
        ListTujuan.FormattingEnabled = True
        ListTujuan.ItemHeight = 15
        ListTujuan.Location = New Point(484, 72)
        ListTujuan.Name = "ListTujuan"
        ListTujuan.Size = New Size(208, 184)
        ListTujuan.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(403, 155)
        Label1.Name = "Label1"
        Label1.Size = New Size(31, 15)
        Label1.TabIndex = 2
        Label1.Text = ">>>"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(488, 279)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 3
        Label2.Text = "Total : "
        ' 
        ' TotalTxt
        ' 
        TotalTxt.Location = New Point(538, 280)
        TotalTxt.Name = "TotalTxt"
        TotalTxt.ReadOnly = True
        TotalTxt.Size = New Size(154, 23)
        TotalTxt.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(151, 280)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 15)
        Label3.TabIndex = 5
        Label3.Text = "Bonus : "
        ' 
        ' BonusTxt
        ' 
        BonusTxt.Location = New Point(201, 276)
        BonusTxt.Name = "BonusTxt"
        BonusTxt.ReadOnly = True
        BonusTxt.Size = New Size(158, 23)
        BonusTxt.TabIndex = 6
        ' 
        ' ListBoxSelect
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BonusTxt)
        Controls.Add(Label3)
        Controls.Add(TotalTxt)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ListTujuan)
        Controls.Add(ListAsal)
        Name = "ListBoxSelect"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListAsal As ListBox
    Friend WithEvents ListTujuan As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TotalTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BonusTxt As TextBox

End Class
