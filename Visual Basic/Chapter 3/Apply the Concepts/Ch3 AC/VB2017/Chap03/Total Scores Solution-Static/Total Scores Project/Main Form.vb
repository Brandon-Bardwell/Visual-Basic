' Name:         Total Scores Project
' Purpose:      Accumulates and displays the scores.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Accumulates and displays the scores.
        'Static variabl;e for accumulating scores.
        Static dblTotal As Double
        ' Procedure-level variable for storing a score.
        Dim dblScore As Double

        ' Accumulate the scores and display the results.
        Double.TryParse(txtScore.Text, dblScore)
        dblTotal = dblTotal + dblScore
        lblTotal.Text = dblTotal.ToString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
