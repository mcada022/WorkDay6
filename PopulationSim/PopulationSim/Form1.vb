Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click
        Dim pop As Double
        Dim year As Integer


        year = 2012
        pop = 7000000000.0

        Do While (pop > 6000000)
            pop = pop / 2
            year = year - 50



        Loop


        MessageBox.Show("The year is " & year)

    End Sub
End Class
