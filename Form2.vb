Imports System.Data.SqlClient
Imports Microsoft.SqlServer
Public Class Form2

    Dim con As New SqlConnection("Server=LocalHost\sqlexpress;Database=NumberGame;Integrated Security=true")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Getnumber()
        btnNo.Visible = False
        btnYes.Visible = False
        lblVictory.Visible = False
    End Sub
    Dim intAnswer As Integer
    Dim intGuess As Integer
    Dim stDate As String
    Dim stTime As String
    Dim stResult As String

    Private Sub Getnumber()

        intAnswer = Math.Ceiling(Rnd() * 100)

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Select Case (Val(txtGuess.Text))
            Case Is > intAnswer
                MsgBox("Too High")
                stResult = "Too High"
            Case Is < intAnswer
                MsgBox("Too Low")
                stResult = "Too Low"
            Case Is = intAnswer
                MsgBox("Thats correct!")
                stResult = "Correct"
                txtGuess.Visible = False
                btnStart.Visible = False
                btnNo.Visible = True
                btnYes.Visible = True
                lblVictory.Visible = True
        End Select

        intGuess = txtGuess.Text
        stDate = Today
        stTime = TimeOfDay
        lblGuessDate.Text = Today
        lblGuessTime.Text = TimeOfDay
        lblGuess.Text = txtGuess.Text
        txtGuess.Text = ""


        con.Open()

        Dim InsertCmd = "Insert Into UserGuessHistory Values('" & 5 & "' , '" & intGuess & "' , '" & stResult & "' , '" & intAnswer & "' , '" & stDate & "' , '" & stTime & "')"

        Dim cmd As New SqlCommand(InsertCmd, con)

        cmd.ExecuteNonQuery()

        con.Close()

    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        End
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Getnumber()
        txtGuess.Visible = True
        btnStart.Visible = True
        btnNo.Visible = False
        btnYes.Visible = False
        lblVictory.Visible = False
    End Sub

    Private Sub lblGuessDate_Click(sender As Object, e As EventArgs) Handles lblGuessDate.Click

    End Sub
End Class
