Public Class studiKasus1RegisterDetail

    Private data() As String

    Public Sub dataPass(datapass() As String)
        Me.data = datapass
    End Sub

    Private Sub studiKasus1RegisterDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNama.Text = data(0)
        txtAlamat.Text = data(1)
        txtGender.Text = data(2)
        txtGoldar.Text = data(3)
        txtHobi.Text = data(4)
        txtTTL.Text = data(5)
        txtNoTelp.Text = data(6)
        txtUsername.Text = data(7)
        txtPassword.Text = data(8)
    End Sub

    Private Sub backBtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles backBtn.LinkClicked

        If studiKasus1Register.OriginalForm IsNot Nothing Then
            studiKasus1Register.OriginalForm.Show()
        End If

        Me.Close()
    End Sub
End Class