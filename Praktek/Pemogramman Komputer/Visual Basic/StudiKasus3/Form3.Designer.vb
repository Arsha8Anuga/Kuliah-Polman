<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        g1box = New ComboBox()
        g2box = New ComboBox()
        g3box = New ComboBox()
        g4box = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        nilaires = New TextBox()
        Hitung = New Button()
        Kembali = New Button()
        Ulang = New Button()
        SuspendLayout()
        ' 
        ' g1box
        ' 
        g1box.FormattingEnabled = True
        g1box.Items.AddRange(New Object() {"HITAM", "COKELAT", "MERAH ", "ORANYE", "KUNING", "HIJAU", "BIRU ", "UNGU", "ABU", "PUTIH"})
        g1box.Location = New Point(65, 68)
        g1box.Name = "g1box"
        g1box.Size = New Size(121, 23)
        g1box.TabIndex = 0
        ' 
        ' g2box
        ' 
        g2box.FormattingEnabled = True
        g2box.Items.AddRange(New Object() {"HITAM", "COKELAT", "MERAH ", "ORANYE", "KUNING", "HIJAU", "BIRU ", "UNGU", "ABU", "PUTIH"})
        g2box.Location = New Point(242, 68)
        g2box.Name = "g2box"
        g2box.Size = New Size(121, 23)
        g2box.TabIndex = 1
        ' 
        ' g3box
        ' 
        g3box.FormattingEnabled = True
        g3box.Items.AddRange(New Object() {"HITAM", "COKELAT", "MERAH ", "ORANYE", "KUNING", "HIJAU", "BIRU ", "UNGU", "ABU", "PUTIH"})
        g3box.Location = New Point(433, 68)
        g3box.Name = "g3box"
        g3box.Size = New Size(121, 23)
        g3box.TabIndex = 2
        ' 
        ' g4box
        ' 
        g4box.FormattingEnabled = True
        g4box.Items.AddRange(New Object() {"EMAS", "PERAK ", "COKELAT", "MERAH"})
        g4box.Location = New Point(615, 68)
        g4box.Name = "g4box"
        g4box.Size = New Size(121, 23)
        g4box.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(65, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 15)
        Label1.TabIndex = 4
        Label1.Text = "Kode Warna 1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(242, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 15)
        Label2.TabIndex = 5
        Label2.Text = "Kode Warna 2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(433, 39)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 15)
        Label3.TabIndex = 6
        Label3.Text = "Kode Warna 3"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(615, 39)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 15)
        Label4.TabIndex = 7
        Label4.Text = "Kode Warna 4"
        ' 
        ' nilaires
        ' 
        nilaires.Location = New Point(185, 227)
        nilaires.Name = "nilaires"
        nilaires.ReadOnly = True
        nilaires.Size = New Size(425, 23)
        nilaires.TabIndex = 8
        ' 
        ' Hitung
        ' 
        Hitung.Location = New Point(185, 296)
        Hitung.Name = "Hitung"
        Hitung.Size = New Size(75, 23)
        Hitung.TabIndex = 9
        Hitung.Text = "Hitung"
        Hitung.UseVisualStyleBackColor = True
        ' 
        ' Kembali
        ' 
        Kembali.Location = New Point(535, 296)
        Kembali.Name = "Kembali"
        Kembali.Size = New Size(75, 23)
        Kembali.TabIndex = 10
        Kembali.Text = "Kembali"
        Kembali.UseVisualStyleBackColor = True
        ' 
        ' Ulang
        ' 
        Ulang.Location = New Point(363, 296)
        Ulang.Name = "Ulang"
        Ulang.Size = New Size(75, 23)
        Ulang.TabIndex = 11
        Ulang.Text = "Ulang"
        Ulang.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Ulang)
        Controls.Add(Kembali)
        Controls.Add(Hitung)
        Controls.Add(nilaires)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(g4box)
        Controls.Add(g3box)
        Controls.Add(g2box)
        Controls.Add(g1box)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents g1box As ComboBox
    Friend WithEvents g2box As ComboBox
    Friend WithEvents g3box As ComboBox
    Friend WithEvents g4box As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nilaires As TextBox
    Friend WithEvents Hitung As Button
    Friend WithEvents Kembali As Button
    Friend WithEvents Ulang As Button
End Class
