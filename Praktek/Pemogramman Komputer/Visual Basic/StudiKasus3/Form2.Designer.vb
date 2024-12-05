<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        ListView1 = New ListView()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nama Peminjam"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 15)
        Label2.TabIndex = 1
        Label2.Text = "Barang Pinjaman"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 100)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 15)
        Label3.TabIndex = 2
        Label3.Text = "Waktu Meminjam"
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(12, 132)
        Label4.Name = "Label4"
        Label4.Size = New Size(355, 23)
        Label4.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(459, 132)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 4
        Button1.Text = "Proses"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(12, 175)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(522, 135)
        ListView1.TabIndex = 5
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(126, 25)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(409, 23)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(126, 63)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(409, 23)
        TextBox2.TabIndex = 7
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(126, 100)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 8
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(547, 322)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(ListView1)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
