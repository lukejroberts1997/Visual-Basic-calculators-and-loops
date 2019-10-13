Public Class Form3
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtgrade.TextChanged

    End Sub

    Private Sub btngrade_Click(sender As Object, e As EventArgs) Handles btngrade.Click


        If txtgrade.Text >= 80 And txtgrade.Text < 100 Then

            txtanswer.Text = "A"

        ElseIf txtgrade.Text >= 70 And txtgrade.Text < 79 Then

            txtanswer.Text = "B"

        ElseIf txtgrade.Text >= 60 And txtgrade.Text < 69 Then

            txtanswer.Text = "C"

        ElseIf txtgrade.Text >= 50 And txtgrade.Text < 59 Then

            txtanswer.Text = "D"

        ElseIf txtgrade.Text >= 0 And txtgrade.Text < 49 Then

            txtanswer.Text = "E"
        End If

    End Sub
End Class