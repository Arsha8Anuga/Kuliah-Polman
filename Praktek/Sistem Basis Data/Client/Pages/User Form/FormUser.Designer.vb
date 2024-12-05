<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUser))
        NamaLbl = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SPLisanLbl = New Label()
        SPTulisLbl = New Label()
        RiwayatPeringatan = New DataGridView()
        KelasLbl = New Label()
        JurusanLbl = New Label()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        NimLbl = New Label()
        Label1 = New Label()
        RefreshBtn = New Button()
        CType(RiwayatPeringatan, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' NamaLbl
        ' 
        NamaLbl.AutoSize = True
        NamaLbl.Location = New Point(40, 53)
        NamaLbl.Margin = New Padding(2, 0, 2, 0)
        NamaLbl.Name = "NamaLbl"
        NamaLbl.Size = New Size(39, 15)
        NamaLbl.TabIndex = 0
        NamaLbl.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(41, 206)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 15)
        Label2.TabIndex = 1
        Label2.Text = "Jumlah SP Lisan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(41, 251)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 15)
        Label3.TabIndex = 2
        Label3.Text = "Jumlah SP Tulis"
        ' 
        ' SPLisanLbl
        ' 
        SPLisanLbl.AutoSize = True
        SPLisanLbl.Location = New Point(162, 206)
        SPLisanLbl.Margin = New Padding(2, 0, 2, 0)
        SPLisanLbl.Name = "SPLisanLbl"
        SPLisanLbl.Size = New Size(13, 15)
        SPLisanLbl.TabIndex = 3
        SPLisanLbl.Text = "0"
        ' 
        ' SPTulisLbl
        ' 
        SPTulisLbl.AutoSize = True
        SPTulisLbl.Location = New Point(162, 251)
        SPTulisLbl.Margin = New Padding(2, 0, 2, 0)
        SPTulisLbl.Name = "SPTulisLbl"
        SPTulisLbl.Size = New Size(13, 15)
        SPTulisLbl.TabIndex = 4
        SPTulisLbl.Text = "0"
        ' 
        ' RiwayatPeringatan
        ' 
        RiwayatPeringatan.AllowUserToAddRows = False
        RiwayatPeringatan.AllowUserToDeleteRows = False
        RiwayatPeringatan.AllowUserToOrderColumns = True
        RiwayatPeringatan.AllowUserToResizeColumns = False
        RiwayatPeringatan.AllowUserToResizeRows = False
        RiwayatPeringatan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        RiwayatPeringatan.Location = New Point(276, 53)
        RiwayatPeringatan.Margin = New Padding(2)
        RiwayatPeringatan.MultiSelect = False
        RiwayatPeringatan.Name = "RiwayatPeringatan"
        RiwayatPeringatan.ReadOnly = True
        RiwayatPeringatan.RowHeadersWidth = 62
        RiwayatPeringatan.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        RiwayatPeringatan.ShowCellErrors = False
        RiwayatPeringatan.ShowCellToolTips = False
        RiwayatPeringatan.ShowEditingIcon = False
        RiwayatPeringatan.ShowRowErrors = False
        RiwayatPeringatan.Size = New Size(382, 192)
        RiwayatPeringatan.TabIndex = 5
        RiwayatPeringatan.Visible = False
        ' 
        ' KelasLbl
        ' 
        KelasLbl.AutoSize = True
        KelasLbl.Location = New Point(41, 107)
        KelasLbl.Margin = New Padding(2, 0, 2, 0)
        KelasLbl.Name = "KelasLbl"
        KelasLbl.Size = New Size(34, 15)
        KelasLbl.TabIndex = 6
        KelasLbl.Text = "Kelas"
        ' 
        ' JurusanLbl
        ' 
        JurusanLbl.AutoSize = True
        JurusanLbl.Location = New Point(41, 133)
        JurusanLbl.Margin = New Padding(2, 0, 2, 0)
        JurusanLbl.Name = "JurusanLbl"
        JurusanLbl.Size = New Size(47, 15)
        JurusanLbl.TabIndex = 7
        JurusanLbl.Text = "Jurusan"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(2, 4)
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
        Panel1.Location = New Point(-2, -1)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(674, 40)
        Panel1.TabIndex = 14
        ' 
        ' NimLbl
        ' 
        NimLbl.AutoSize = True
        NimLbl.Location = New Point(41, 81)
        NimLbl.Margin = New Padding(2, 0, 2, 0)
        NimLbl.Name = "NimLbl"
        NimLbl.Size = New Size(30, 15)
        NimLbl.TabIndex = 15
        NimLbl.Text = "Nim"
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(392, 121)
        Label1.Name = "Label1"
        Label1.Size = New Size(172, 39)
        Label1.TabIndex = 16
        Label1.Text = "Tabel sedang dimuat, mohon bersabar..."
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RefreshBtn
        ' 
        RefreshBtn.Location = New Point(548, 251)
        RefreshBtn.Name = "RefreshBtn"
        RefreshBtn.Size = New Size(109, 35)
        RefreshBtn.TabIndex = 17
        RefreshBtn.Text = "Refresh"
        RefreshBtn.UseVisualStyleBackColor = True
        RefreshBtn.Visible = False
        ' 
        ' FormUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(669, 298)
        Controls.Add(RefreshBtn)
        Controls.Add(Label1)
        Controls.Add(NimLbl)
        Controls.Add(Panel1)
        Controls.Add(JurusanLbl)
        Controls.Add(KelasLbl)
        Controls.Add(RiwayatPeringatan)
        Controls.Add(SPTulisLbl)
        Controls.Add(SPLisanLbl)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(NamaLbl)
        Margin = New Padding(2)
        Name = "FormUser"
        Text = "FormUser - Gustian - Anugrah"
        CType(RiwayatPeringatan, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NamaLbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SPLisanLbl As Label
    Friend WithEvents SPTulisLbl As Label
    Friend WithEvents RiwayatPeringatan As DataGridView
    Friend WithEvents KelasLbl As Label
    Friend WithEvents JurusanLbl As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents NimLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RefreshBtn As Button
End Class
