Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Getnumber()
        btnNo.Visible = False
        btnYes.Visible = False
        lblVictory.Visible = False
    End Sub
    Dim guess As Integer
    Private Sub Getnumber()

        guess = Math.Ceiling(Rnd() * 100)

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Select Case (Val(txtGuess.Text))
            Case Is > guess
                MsgBox("Too High")
            Case Is < guess
                MsgBox("Too Low")
            Case Is = guess
                MsgBox("Thats correct!")
                txtGuess.Visible = False
                btnStart.Visible = False
                btnNo.Visible = True
                btnYes.Visible = True
                lblVictory.Visible = True
        End Select

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
End Class
