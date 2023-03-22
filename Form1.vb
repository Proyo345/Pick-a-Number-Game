Imports System.Data.SqlClient
Imports Microsoft.SqlServer
Public Class Form1

    Dim con As New SqlConnection("Server=LocalHost\sqlexpress;Database=NumberGame;Integrated Security=true")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click




        con.Open()

        Dim SelectCmd = "Select Password from Users where Username = '" + txtUsername.Text + "'"

        Dim cmd As New SqlCommand(SelectCmd, con)

        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        reader.Read()

        txtSQLPass.Text = reader("Password")

        reader.Close()

        cmd.ExecuteNonQuery()

        con.Close()

        If txtPassword.Text = txtSQLPass.Text Then
            Form2.Show()
            Me.Hide()
            lblIncorrect.Visible = False
        Else
            lblIncorrect.Visible = True
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblIncorrect.Visible = False
        txtSQLPass.Visible = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSQLPass.TextChanged

    End Sub

    Private Sub btnNewAccout_Click(sender As Object, e As EventArgs) Handles btnNewAccout.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class
