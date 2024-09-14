<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class studiKasusMenu
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
        loginPageForm = New Button()
        kalkulator = New Button()
        bangunDatar1 = New Button()
        bangunDatar2 = New Button()
        games = New Button()
        SuspendLayout()
        ' 
        ' loginPageForm
        ' 
        loginPageForm.Location = New Point(225, 90)
        loginPageForm.Name = "loginPageForm"
        loginPageForm.Size = New Size(198, 48)
        loginPageForm.TabIndex = 1
        loginPageForm.Text = "Login Page"
        loginPageForm.UseVisualStyleBackColor = True
        ' 
        ' kalkulator
        ' 
        kalkulator.Location = New Point(225, 174)
        kalkulator.Name = "kalkulator"
        kalkulator.Size = New Size(198, 48)
        kalkulator.TabIndex = 2
        kalkulator.Text = "Kalkulator"
        kalkulator.UseVisualStyleBackColor = True
        ' 
        ' bangunDatar1
        ' 
        bangunDatar1.Location = New Point(225, 262)
        bangunDatar1.Name = "bangunDatar1"
        bangunDatar1.Size = New Size(198, 48)
        bangunDatar1.TabIndex = 3
        bangunDatar1.Text = "Hitung Bangun Datar 1"
        bangunDatar1.UseVisualStyleBackColor = True
        ' 
        ' bangunDatar2
        ' 
        bangunDatar2.Location = New Point(225, 350)
        bangunDatar2.Name = "bangunDatar2"
        bangunDatar2.Size = New Size(198, 48)
        bangunDatar2.TabIndex = 4
        bangunDatar2.Text = "Hitung Bangun Datar 2"
        bangunDatar2.UseVisualStyleBackColor = True
        ' 
        ' games
        ' 
        games.Location = New Point(225, 434)
        games.Name = "games"
        games.Size = New Size(198, 48)
        games.TabIndex = 6
        games.Text = "Games Tebak"
        games.UseVisualStyleBackColor = True
        ' 
        ' studiKasusMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(666, 536)
        Controls.Add(games)
        Controls.Add(bangunDatar2)
        Controls.Add(bangunDatar1)
        Controls.Add(kalkulator)
        Controls.Add(loginPageForm)
        Name = "studiKasusMenu"
        Text = "Form1"
        ResumeLayout(False)
    End Sub
    Friend WithEvents loginPageForm As Button
    Friend WithEvents kalkulator As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents bangunDatar2 As Button
    Public WithEvents bangunDatar1 As Button
    Friend WithEvents games As Button

End Class
