'Name: Chapter 3 Dropbox   
'Purpose: Calculating Tax
'Programmer: Brandon Bardwell


Option Explicit On
Option Strict On
Option Infer Off




Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Calculate property tax based on tax of 1.35% and display the answer in lblTax

        'Constant
        Const dblTAX_RATE As Double = 0.0135

        'Variable
        Dim dblAssessedValue As Double
        Dim dblPropertyTax As Double

        'pull property assessed value from txtAssessed and store in dblAssessedValue
        Double.TryParse(txtAssessed.Text, dblAssessedValue)

        'Calculate property tax based on tax rate

        dblPropertyTax = dblTAX_RATE * dblAssessedValue

        'Display the answer in lblTax

        TextBox2.Text = dblPropertyTax.ToString("C2")


    End Sub



    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ' clear the area box.

        txtAssessed.Text = String.Empty
    End Sub

End Class
