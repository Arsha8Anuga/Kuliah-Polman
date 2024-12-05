<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdmin))
        RiwayatSP = New DataGridView()
        LaporanSPTxtBox = New TextBox()
        KDEtikTxtBox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        InsertBtn = New Button()
        Label4 = New Label()
        JenisPeringatanCmbBox = New ComboBox()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        NIMCmbBox = New ComboBox()
        DeleteBtn = New Button()
        RefreshBtn = New Button()
        Label5 = New Label()
        CType(RiwayatSP, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' RiwayatSP
        ' 
        RiwayatSP.AllowUserToAddRows = False
        RiwayatSP.AllowUserToDeleteRows = False
        RiwayatSP.AllowUserToOrderColumns = True
        RiwayatSP.AllowUserToResizeColumns = False
        RiwayatSP.AllowUserToResizeRows = False
        RiwayatSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        RiwayatSP.Location = New Point(359, 88)
        RiwayatSP.Margin = New Padding(2)
        RiwayatSP.MultiSelect = False
        RiwayatSP.Name = "RiwayatSP"
        RiwayatSP.ReadOnly = True
        RiwayatSP.RowHeadersWidth = 62
        RiwayatSP.ShowCellErrors = False
        RiwayatSP.ShowCellToolTips = False
        RiwayatSP.ShowEditingIcon = False
        RiwayatSP.ShowRowErrors = False
        RiwayatSP.Size = New Size(466, 175)
        RiwayatSP.TabIndex = 0
        RiwayatSP.Visible = False
        ' 
        ' LaporanSPTxtBox
        ' 
        LaporanSPTxtBox.Location = New Point(139, 166)
        LaporanSPTxtBox.Margin = New Padding(2)
        LaporanSPTxtBox.Multiline = True
        LaporanSPTxtBox.Name = "LaporanSPTxtBox"
        LaporanSPTxtBox.Size = New Size(172, 53)
        LaporanSPTxtBox.TabIndex = 3
        LaporanSPTxtBox.Visible = False
        ' 
        ' KDEtikTxtBox
        ' 
        KDEtikTxtBox.Location = New Point(139, 125)
        KDEtikTxtBox.Margin = New Padding(2)
        KDEtikTxtBox.Name = "KDEtikTxtBox"
        KDEtikTxtBox.Size = New Size(172, 23)
        KDEtikTxtBox.TabIndex = 4
        KDEtikTxtBox.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.White
        Label1.Location = New Point(30, 88)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 15)
        Label1.TabIndex = 5
        Label1.Text = "NIM"
        Label1.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.White
        Label2.Location = New Point(30, 168)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 15)
        Label2.TabIndex = 6
        Label2.Text = "Laporan SP"
        Label2.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.White
        Label3.Location = New Point(30, 128)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 7
        Label3.Text = "Kode Etik"
        Label3.Visible = False
        ' 
        ' InsertBtn
        ' 
        InsertBtn.Location = New Point(211, 290)
        InsertBtn.Margin = New Padding(2)
        InsertBtn.Name = "InsertBtn"
        InsertBtn.Size = New Size(100, 35)
        InsertBtn.TabIndex = 8
        InsertBtn.Text = "Insert"
        InsertBtn.UseVisualStyleBackColor = True
        InsertBtn.Visible = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.White
        Label4.Location = New Point(30, 238)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 15)
        Label4.TabIndex = 10
        Label4.Text = "Jenis Peringatan"
        Label4.Visible = False
        ' 
        ' JenisPeringatanCmbBox
        ' 
        JenisPeringatanCmbBox.FormattingEnabled = True
        JenisPeringatanCmbBox.Items.AddRange(New Object() {"lisan", "tulis"})
        JenisPeringatanCmbBox.Location = New Point(139, 238)
        JenisPeringatanCmbBox.Margin = New Padding(2)
        JenisPeringatanCmbBox.Name = "JenisPeringatanCmbBox"
        JenisPeringatanCmbBox.Size = New Size(172, 23)
        JenisPeringatanCmbBox.TabIndex = 11
        JenisPeringatanCmbBox.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(10, 7)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(208, 36)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MidnightBlue
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(-1, 0)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(873, 53)
        Panel1.TabIndex = 13
        ' 
        ' NIMCmbBox
        ' 
        NIMCmbBox.FormattingEnabled = True
        NIMCmbBox.Location = New Point(139, 85)
        NIMCmbBox.Margin = New Padding(2)
        NIMCmbBox.Name = "NIMCmbBox"
        NIMCmbBox.Size = New Size(172, 23)
        NIMCmbBox.TabIndex = 14
        NIMCmbBox.Visible = False
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.Location = New Point(725, 290)
        DeleteBtn.Margin = New Padding(2)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(100, 35)
        DeleteBtn.TabIndex = 15
        DeleteBtn.Text = "Delete"
        DeleteBtn.UseVisualStyleBackColor = True
        DeleteBtn.Visible = False
        ' 
        ' RefreshBtn
        ' 
        RefreshBtn.Location = New Point(621, 290)
        RefreshBtn.Margin = New Padding(2)
        RefreshBtn.Name = "RefreshBtn"
        RefreshBtn.Size = New Size(100, 35)
        RefreshBtn.TabIndex = 16
        RefreshBtn.Text = "Refresh"
        RefreshBtn.UseVisualStyleBackColor = True
        RefreshBtn.Visible = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(329, 188)
        Label5.Name = "Label5"
        Label5.Size = New Size(215, 15)
        Label5.TabIndex = 17
        Label5.Text = "Data sedang dimuat mohon bersabar...."
        ' 
        ' FormAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(853, 353)
        Controls.Add(Label5)
        Controls.Add(RefreshBtn)
        Controls.Add(DeleteBtn)
        Controls.Add(NIMCmbBox)
        Controls.Add(Panel1)
        Controls.Add(JenisPeringatanCmbBox)
        Controls.Add(Label4)
        Controls.Add(InsertBtn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(KDEtikTxtBox)
        Controls.Add(LaporanSPTxtBox)
        Controls.Add(RiwayatSP)
        Margin = New Padding(2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormAdmin"
        Text = "FormAdmin"
        CType(RiwayatSP, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RiwayatSP As DataGridView
    Friend WithEvents Nama_TextBox As TextBox
    Friend WithEvents LaporanSPTxtBox As TextBox
    Friend WithEvents KDEtikTxtBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents InsertBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents JenisPeringatanCmbBox As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents NIMCmbBox As ComboBox
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents RefreshBtn As Button
    Friend WithEvents Label5 As Label
End Class
