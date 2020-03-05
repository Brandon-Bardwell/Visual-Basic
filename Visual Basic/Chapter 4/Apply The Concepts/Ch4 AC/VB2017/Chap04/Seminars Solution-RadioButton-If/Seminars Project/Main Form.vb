﻿' Name:         Seminars Project
' Purpose:      Display the amount due.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Display the amount due.

        Dim intAmountDue As Integer

        ' Determine which radio button is selected  
        ' and assign the associated fee.


        lblAmountDue.Text = intAmountDue.ToString("C0")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
