Imports System.Globalization
Imports System.Text
Imports System.Threading

Public Class studiKasus1Register

    Dim goldarChoosed As String
    Dim goldarName As String
    Dim genderChoosed As String
    Dim genderName As String
    Public Shared OriginalForm As studiKasus1Register



    Private Sub studiKasus1Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        OriginalForm = Me


        AddHandler lGenderRBtn.Click, AddressOf rGender_Click
        AddHandler pGenderRBtn.Click, AddressOf rGender_Click

        AddHandler aGoldarRBtn.Click, AddressOf rGoldar_Click
        AddHandler bGoldarRBtn.Click, AddressOf rGoldar_Click
        AddHandler abGoldarRBtn.Click, AddressOf rGoldar_Click
        AddHandler oGoldarRBtn.Click, AddressOf rGoldar_Click
    End Sub

    Private Sub rGender_Click(sender As Object, e As EventArgs)

        Dim rGender As RadioButton = CType(sender, RadioButton)

        genderChoosed = rGender.Text
        genderName = rGender.Name.ToString()

    End Sub

    Private Sub rGoldar_Click(sender As Object, e As EventArgs)

        Dim rGoldar As RadioButton = CType(sender, RadioButton)

        goldarChoosed = rGoldar.Text
        goldarName = rGoldar.Name.ToString()

    End Sub

    Private Sub txtListHobi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtListHobi.SelectedIndexChanged

        Dim selectedTxt As ListBox = CType(sender, ListBox)

        If selectedTxt.SelectedIndex <> -1 AndAlso Not txtTempHobi.Text.Contains(selectedTxt.SelectedItem.ToString()) Then
            txtTempHobi.Text &= selectedTxt.SelectedItem.ToString() & " "
        End If

    End Sub

    Private Sub regBtn_Click(sender As Object, e As EventArgs) Handles regBtn.Click

        Dim bundleData() As String = {txtNama.Text, txtAlamat.Text, genderChoosed, goldarChoosed,
                                     txtTempHobi.Text, $"{txtT.Text}, {txtTL.Text}", txtNoTelp.Text,
                                     txtUsername.Text, txtPassword.Text}

        Dim regPageDetail As New studiKasus1RegisterDetail

        regPageDetail.dataPass(bundleData)

        regPageDetail.Show()

        Me.Hide()


    End Sub


    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        ' Reset RadioButtons for gender and goldar
        Dim rGender As RadioButton = CType(gBox1.Controls(genderName), RadioButton)
        Dim rGoldar As RadioButton = CType(gBox2.Controls(goldarName), RadioButton)

        ' Uncheck the selected RadioButtons if they exist
        If rGoldar IsNot Nothing AndAlso rGoldar.Checked Then
            rGoldar.Checked = False
        End If

        If rGender IsNot Nothing AndAlso rGender.Checked Then
            rGender.Checked = False
        End If

        ' Reset variables
        goldarChoosed = ""
        goldarName = ""
        genderChoosed = ""
        genderName = ""

        ' Clear TextBox controls
        txtNama.Text = ""
        txtAlamat.Text = ""
        txtTL.Value = DateTime.Now
        txtT.Text = ""
        txtNoTelp.Text = ""
        txtListHobi.ClearSelected()
        txtTempHobi.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub backBtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles backBtn.LinkClicked

        If studiKasus1Login.loginForm IsNot Nothing Then
            studiKasus1Login.loginForm.Show()
        Else
            Application.Exit()
        End If

        Me.Close()
    End Sub
End Class