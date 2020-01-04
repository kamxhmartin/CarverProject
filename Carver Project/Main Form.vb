' Name:         Carver Project
' Purpose:      Displays a grade based on the number of points the user enters
' Programmer:   Kal Martin on 22 Nov 2010

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtPoints_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPoints.Enter
        txtPoints.SelectAll()
    End Sub

    Private Sub txtPoints_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPoints.KeyPress
        ' accepts only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPoints_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPoints.TextChanged
        lblGrade.Text = String.Empty
    End Sub

    Private Sub btnDisplay_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        ' assign point values to grades
        Dim strGrades() As String = {"A", "B", "C", "D", "F"}
        Dim intPoints() As Integer = {450, 400, 350, 300, 0}

        Dim strSearchForGrades As String
        Dim intSubscript As Integer

        ' assign display place to variable
        strSearchForGrades = txtPoints.Text

        'search the intPoints array for the grade
        Do Until intSubscript = intPoints.Length _
            OrElse CDbl(strSearchForGrades) = intPoints(intSubscript)
            intSubscript = intSubscript + 1
        Loop

        ' determine the grade
        If intSubscript < intPoints.Length Then
            lblGrade.Text = strGrades(intSubscript).ToString()
        End If

    End Sub
End Class
