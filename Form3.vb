Imports System.Data.SqlClient
Imports System.Security.Principal
Imports System.Windows.Forms.AxHost
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock
Imports Microsoft.SqlServer
Public Class Form3
    Dim con As New SqlConnection("Server=LocalHost\sqlexpress;Database=NumberGame;Integrated Security=true")
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblInputpassword.Click

    End Sub

    Private Sub lblInputUsername_Click(sender As Object, e As EventArgs) Handles lblInputUsername.Click

    End Sub

    Private Sub txtInputpassword_TextChanged(sender As Object, e As EventArgs) Handles txtInputpassword.TextChanged

    End Sub

    Private Sub btnCreateaccount_Click(sender As Object, e As EventArgs) Handles btnCreateaccount.Click
        If txtConfirmPassword.Text = "" Or txtConfirmPassword.Text = "" Or txtInputUsername.Text = "" Then
            lblfields.Visible = True
            lblIncorrect.Visible = False
        Else
            If txtInputpassword.Text = txtConfirmPassword.Text Then
                Dim stUsername As String
                Dim stPassword As String

                stUsername = txtInputUsername.Text
                stPassword = txtInputpassword.Text

                con.Open()
                Dim InsertCmd = "Insert Into Users (Username, Password, Created) Values('" & stUsername & "' , '" & stPassword & "' , '" & Now & "')"
                Dim cmd As New SqlCommand(InsertCmd, con)
                cmd.ExecuteNonQuery()

                con.Close()

                MsgBox("Account has been created, please log in")

                Me.Hide()
                Form1.Show()

            Else
                lblIncorrect.Visible = True
                lblfields.Visible = False
            End If
        End If
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblfields.Visible = False
        lblIncorrect.Visible = False
    End Sub
End Class