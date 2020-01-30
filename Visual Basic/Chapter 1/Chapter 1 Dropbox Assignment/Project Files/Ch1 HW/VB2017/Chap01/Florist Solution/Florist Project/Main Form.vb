
' Name: Florist Project
' Purpose: Display Store Information
' Programmer: Brandon Bardwell on 1/28/2020





Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        picHours.Visible = False
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        picHours.Visible = True
    End Sub
End Class
