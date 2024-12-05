Public Class Form2
    ' Constructor to initialize the form

    Public Sub New()
        ' Initialize the components (you always need this in a form)

        InitializeComponent()

        ' Dynamically add a label control
        Dim lblDynamic As New Label()
        lblDynamic.Text = "This is a dynamically added label!"
        lblDynamic.Location = New Point(10, 10) ' Set the position on the form
        Me.Controls.Add(lblDynamic)

        ' Dynamically add a button control
        Dim btnDynamic As New Button()
        btnDynamic.Text = "Click Me"
        btnDynamic.Location = New Point(10, 40) ' Set the position on the form
        AddHandler btnDynamic.Click, AddressOf BtnDynamic_Click ' Attach the event handler
        Me.Controls.Add(btnDynamic)
    End Sub

    ' Event handler for the dynamically created button click
    Private Sub BtnDynamic_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Button clicked!")

    End Sub


    Private Sub Form2_Leave(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
