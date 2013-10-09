Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click

        Dim x As Integer
        x = 1
        Do While (x <= 10)



            lstResult.Items.Add(x ^ 2)
            x = x + 1
        Loop

    End Sub
End Class