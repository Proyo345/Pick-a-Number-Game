<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblInputUsername = New System.Windows.Forms.Label()
        Me.lblInputpassword = New System.Windows.Forms.Label()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.txtInputUsername = New System.Windows.Forms.TextBox()
        Me.txtInputpassword = New System.Windows.Forms.TextBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.btnCreateaccount = New System.Windows.Forms.Button()
        Me.lblIncorrect = New System.Windows.Forms.Label()
        Me.lblfields = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInputUsername
        '
        Me.lblInputUsername.AutoSize = True
        Me.lblInputUsername.Location = New System.Drawing.Point(100, 71)
        Me.lblInputUsername.Name = "lblInputUsername"
        Me.lblInputUsername.Size = New System.Drawing.Size(117, 15)
        Me.lblInputUsername.TabIndex = 0
        Me.lblInputUsername.Text = "Enter your Username"
        '
        'lblInputpassword
        '
        Me.lblInputpassword.AutoSize = True
        Me.lblInputpassword.Location = New System.Drawing.Point(100, 124)
        Me.lblInputpassword.Name = "lblInputpassword"
        Me.lblInputpassword.Size = New System.Drawing.Size(114, 15)
        Me.lblInputpassword.TabIndex = 1
        Me.lblInputpassword.Text = "Enter your Password"
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Location = New System.Drawing.Point(100, 181)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(131, 15)
        Me.lblConfirmPassword.TabIndex = 2
        Me.lblConfirmPassword.Text = "Confirm your Password"
        '
        'txtInputUsername
        '
        Me.txtInputUsername.Location = New System.Drawing.Point(299, 71)
        Me.txtInputUsername.Name = "txtInputUsername"
        Me.txtInputUsername.Size = New System.Drawing.Size(164, 23)
        Me.txtInputUsername.TabIndex = 3
        '
        'txtInputpassword
        '
        Me.txtInputpassword.Location = New System.Drawing.Point(299, 124)
        Me.txtInputpassword.Name = "txtInputpassword"
        Me.txtInputpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtInputpassword.Size = New System.Drawing.Size(164, 23)
        Me.txtInputpassword.TabIndex = 4
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(299, 178)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(164, 23)
        Me.txtConfirmPassword.TabIndex = 5
        '
        'btnCreateaccount
        '
        Me.btnCreateaccount.Location = New System.Drawing.Point(299, 231)
        Me.btnCreateaccount.Name = "btnCreateaccount"
        Me.btnCreateaccount.Size = New System.Drawing.Size(164, 44)
        Me.btnCreateaccount.TabIndex = 6
        Me.btnCreateaccount.Text = "Submit"
        Me.btnCreateaccount.UseVisualStyleBackColor = True
        '
        'lblIncorrect
        '
        Me.lblIncorrect.AutoSize = True
        Me.lblIncorrect.ForeColor = System.Drawing.Color.Red
        Me.lblIncorrect.Location = New System.Drawing.Point(317, 310)
        Me.lblIncorrect.Name = "lblIncorrect"
        Me.lblIncorrect.Size = New System.Drawing.Size(137, 15)
        Me.lblIncorrect.TabIndex = 7
        Me.lblIncorrect.Text = "Passwords do not match"
        '
        'lblfields
        '
        Me.lblfields.AutoSize = True
        Me.lblfields.ForeColor = System.Drawing.Color.Red
        Me.lblfields.Location = New System.Drawing.Point(317, 278)
        Me.lblfields.Name = "lblfields"
        Me.lblfields.Size = New System.Drawing.Size(131, 15)
        Me.lblfields.TabIndex = 8
        Me.lblfields.Text = "Please Fill Out All Fields"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblfields)
        Me.Controls.Add(Me.lblIncorrect)
        Me.Controls.Add(Me.btnCreateaccount)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtInputpassword)
        Me.Controls.Add(Me.txtInputUsername)
        Me.Controls.Add(Me.lblConfirmPassword)
        Me.Controls.Add(Me.lblInputpassword)
        Me.Controls.Add(Me.lblInputUsername)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInputUsername As Label
    Friend WithEvents lblInputpassword As Label
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents txtInputUsername As TextBox
    Friend WithEvents txtInputpassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents btnCreateaccount As Button
    Friend WithEvents lblIncorrect As Label
    Friend WithEvents lblfields As Label
End Class
