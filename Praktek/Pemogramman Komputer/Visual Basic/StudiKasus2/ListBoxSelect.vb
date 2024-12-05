Public Class ListBoxSelect

    Dim countTotal As Integer = 0
    Dim listCounter As New Dictionary(Of String, Integer())
    Private isHandlingSelectionChange As Boolean = False

    Private Sub ListAsal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListAsal.SelectedIndexChanged
        If ListAsal.SelectedItem Is Nothing Then Return

        Dim dataSlice As String() = ListAsal.SelectedItem().ToString().Trim().Split("=")

        If dataSlice.Length < 2 Then Return
        Dim dataName As String = dataSlice(0).Trim()

        listCounter(dataName)(0) += 1

        If Not SearchListBox(dataName) Then
            ListTujuan.Items.Add(dataName & " " & listCounter(dataName)(0) & "X")
        Else

            For i As Integer = 0 To ListTujuan.Items.Count - 1
                If ListTujuan.Items(i).ToString().Contains(dataName) Then
                    ListTujuan.Items(i) = dataName & " " & listCounter(dataName)(0) & "X"
                End If
            Next
        End If

        countTotal += listCounter(dataName)(1)
        TotalTxt.Text = countTotal.ToString

        BonusTxt.Text = Bonus(TotalTxt.Text)
    End Sub

    Private Function SearchListBox(searchText As String) As Boolean
        For Each item As String In ListTujuan.Items
            If item.ToLower().Contains(searchText.ToLower()) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub ListBoxSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each value As String In ListAsal.Items
            Dim dataSlice As String() = value.ToString().Trim().Split("=")

            If dataSlice.Length < 2 Then Continue For

            Dim itemName As String = dataSlice(0).Trim()
            Dim itemValue As Integer

            If Integer.TryParse(dataSlice(1), itemValue) Then
                If Not listCounter.ContainsKey(itemName) Then
                    listCounter.Add(itemName, New Integer() {0, itemValue})
                End If
            End If
        Next
    End Sub


    Private Sub ListTujuan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListTujuan.SelectedIndexChanged
        If isHandlingSelectionChange Then Return
        If ListTujuan.SelectedItem Is Nothing Then Return


        Dim selectedItem As String = ListTujuan.SelectedItem().ToString().Trim()
        Dim itemName As String = selectedItem.Substring(0, selectedItem.Length - 2).Trim()


        listCounter(itemName)(0) -= 1

        isHandlingSelectionChange = True

        If listCounter(itemName)(0) <= 0 Then
            ListTujuan.Items.RemoveAt(ListTujuan.SelectedIndex)
        Else
            ListTujuan.Items(ListTujuan.SelectedIndex) = itemName & " " & listCounter(itemName)(0) & "X"
        End If

        countTotal -= listCounter(itemName)(1)
        TotalTxt.Text = countTotal.ToString

        BonusTxt.Text = Bonus(TotalTxt.Text)


        isHandlingSelectionChange = False
    End Sub

    Private Function Bonus(total As Integer) As String

        If total < 500000 Then
            Return "Tas Ransel"

        ElseIf total < 1000000 Then

            Return "Voucher Belanja"

        ElseIf total >= 1000000 Then

            Return "Helikopter Remot"

        Else

            Return ""

        End If

    End Function
End Class