Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButtonToUpper_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonToUpper.CheckedChanged
        Label2.Text = Label2.Text.ToUpper()
    End Sub

    Private Sub ButtonAddWord_Click(sender As Object, e As EventArgs) Handles ButtonAddWord.Click
        Dim words() As String
        Dim space() As Char = {" "c}
        words = TextBoxWord.Text.Split(space, StringSplitOptions.RemoveEmptyEntries)
        For Each word As String In words
            ListBox1.Items.Add(word)


        Next

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Label2.Text = ListBox1.SelectedItem.ToString

    End Sub

    Private Sub RadioButtonToLower_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonToLower.CheckedChanged
        Label2.Text = Label2.Text.ToLower()


    End Sub

    Private Sub RadioButtonPurple_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonPurple.CheckedChanged
        Label2.BackColor = Color.White
        Label2.ForeColor = Color.Purple

    End Sub

    Private Sub RadioButtonBlue_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonBlue.CheckedChanged
        Label2.BackColor = Color.White
        Label2.ForeColor = Color.Blue
    End Sub
End Class
