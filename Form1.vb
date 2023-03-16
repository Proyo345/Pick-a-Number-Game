
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtUsername.Text = "Eli" And txtPassword.Text = "Smith" Then
            Form2.Show()
            Me.Hide()
            lblIncorrect.Visible = False
        Else
            lblIncorrect.Visible = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblIncorrect.Visible = False
    End Sub
End Class
