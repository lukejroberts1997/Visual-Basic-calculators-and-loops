Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnhex.Click
        My.Forms.Form2.Text = Now.ToString
        My.Forms.Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btngrade.Click
        My.Forms.Form3.Text = Now.ToString
        My.Forms.Form3.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnquit.Click
        End

    End Sub

    Private Sub btnloops_Click(sender As Object, e As EventArgs) Handles btnloops.Click
        My.Forms.Form4.Text = Now.ToString
        My.Forms.Form4.Show()
    End Sub
End Class
