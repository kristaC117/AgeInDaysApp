Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'declare vars
        Dim intAgeInYears, intAgeInDays As Integer

        'input - get input from text box as intAgeInYears
        intAgeInYears = txtAgeInYears.Text

        'Calculate the Age in Days now
        intAgeInDays = intAgeInYears * 365 'not counting leap years

        'output 
        lblAgeInDays.Text = intAgeInDays


    End Sub
End Class
