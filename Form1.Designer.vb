<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtGuess = New System.Windows.Forms.TextBox()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.lblVictory = New System.Windows.Forms.Label()
        Me.lblGuessDate = New System.Windows.Forms.Label()
        Me.lblGuessTime = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblGuess = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(293, 237)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(199, 91)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtGuess
        '
        Me.txtGuess.Location = New System.Drawing.Point(296, 173)
        Me.txtGuess.Name = "txtGuess"
        Me.txtGuess.Size = New System.Drawing.Size(196, 23)
        Me.txtGuess.TabIndex = 2
        '
        'btnNo
        '
        Me.btnNo.Location = New System.Drawing.Point(223, 244)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(145, 78)
        Me.btnNo.TabIndex = 3
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'btnYes
        '
        Me.btnYes.Location = New System.Drawing.Point(412, 242)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(164, 80)
        Me.btnYes.TabIndex = 4
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'lblVictory
        '
        Me.lblVictory.AutoSize = True
        Me.lblVictory.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblVictory.Location = New System.Drawing.Point(223, 187)
        Me.lblVictory.Name = "lblVictory"
        Me.lblVictory.Size = New System.Drawing.Size(330, 32)
        Me.lblVictory.TabIndex = 5
        Me.lblVictory.Text = "Would you like to play again?"
        '
        'lblGuessDate
        '
        Me.lblGuessDate.AutoSize = True
        Me.lblGuessDate.Location = New System.Drawing.Point(31, 90)
        Me.lblGuessDate.Name = "lblGuessDate"
        Me.lblGuessDate.Size = New System.Drawing.Size(0, 15)
        Me.lblGuessDate.TabIndex = 6
        '
        'lblGuessTime
        '
        Me.lblGuessTime.AutoSize = True
        Me.lblGuessTime.Location = New System.Drawing.Point(96, 90)
        Me.lblGuessTime.Name = "lblGuessTime"
        Me.lblGuessTime.Size = New System.Drawing.Size(0, 15)
        Me.lblGuessTime.TabIndex = 7
        Me.lblGuessTime.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(31, 30)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(106, 15)
        Me.lbl1.TabIndex = 8
        Me.lbl1.Text = "Most recent guess:"
        '
        'lblGuess
        '
        Me.lblGuess.AutoSize = True
        Me.lblGuess.Location = New System.Drawing.Point(62, 55)
        Me.lblGuess.Name = "lblGuess"
        Me.lblGuess.Size = New System.Drawing.Size(0, 15)
        Me.lblGuess.TabIndex = 9
        Me.lblGuess.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 481)
        Me.Controls.Add(Me.lblGuess)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lblGuessTime)
        Me.Controls.Add(Me.lblGuessDate)
        Me.Controls.Add(Me.lblVictory)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.txtGuess)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As Button
    Friend WithEvents txtGuess As TextBox
    Friend WithEvents btnNo As Button
    Friend WithEvents btnYes As Button
    Friend WithEvents lblVictory As Label
    Friend WithEvents lblGuessDate As Label
    Friend WithEvents lblGuessTime As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lblGuess As Label
End Class
