Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnhexback.Click
        Close()

    End Sub


    Private Sub btncalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalc.Click
        'get the value from text box - value should be in hex string

        Dim decValue As Integer = 0
        Dim hexString As String = Nothing

        decValue = Int(txthex.Text.Trim)


        'convert into hexadecimal 
        hexString = Hex(decValue)

        MsgBox("Hexadecimal value is: " & hexString)


        'convert into hexadecimal 
        hexString = Hex(decValue)

        MsgBox("Hexadecimal value is: " & hexString)
    End Sub
End Class