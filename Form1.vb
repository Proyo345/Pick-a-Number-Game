Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Getnumber()
        btnNo.Visible = False
        btnYes.Visible = False
        lblVictory.Visible = False
    End Sub
    Dim intGuess As Integer
    Dim strDate As String
    Dim strTime As String
    Private Sub Getnumber()

        intGuess = Math.Ceiling(Rnd() * 100)

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Select Case (Val(txtGuess.Text))
            Case Is > intGuess
                MsgBox("Too High")
            Case Is < intGuess
                MsgBox("Too Low")
            Case Is = intGuess
                MsgBox("Thats correct!")
                txtGuess.Visible = False
                btnStart.Visible = False
                btnNo.Visible = True
                btnYes.Visible = True
                lblVictory.Visible = True
        End Select

        strDate = Today
        strTime = TimeOfDay
        lblGuessDate.Text = Today
        lblGuessTime.Text = TimeOfDay
        lblGuess.Text = txtGuess.Text
        txtGuess.Text = ""

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
