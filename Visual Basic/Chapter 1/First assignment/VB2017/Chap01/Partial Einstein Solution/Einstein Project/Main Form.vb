' Name: Einstein Project
' Purpose: Show/Hide and equation
' Programmer: Brandon Bardwell on 1-23-2020
Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        ' Show Einsteins's Equation.

        picEquation.Visible = True

    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        ' Hide Einstein's Equation.

        picEquation.Visible = False

    End Sub
End Class
