<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblGuess = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblGuessTime = New System.Windows.Forms.Label()
        Me.lblGuessDate = New System.Windows.Forms.Label()
        Me.lblVictory = New System.Windows.Forms.Label()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.txtGuess = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGuess
        '
        Me.lblGuess.AutoSize = True
        Me.lblGuess.Location = New System.Drawing.Point(52, 42)
        Me.lblGuess.Name = "lblGuess"
        Me.lblGuess.Size = New System.Drawing.Size(0, 15)
        Me.lblGuess.TabIndex = 18
        Me.lblGuess.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(21, 17)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(106, 15)
        Me.lbl1.TabIndex = 17
        Me.lbl1.Text = "Most recent guess:"
        '
        'lblGuessTime
        '
        Me.lblGuessTime.AutoSize = True
        Me.lblGuessTime.Location = New System.Drawing.Point(86, 77)
        Me.lblGuessTime.Name = "lblGuessTime"
        Me.lblGuessTime.Size = New System.Drawing.Size(0, 15)
        Me.lblGuessTime.TabIndex = 16
        Me.lblGuessTime.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblGuessDate
        '
        Me.lblGuessDate.AutoSize = True
        Me.lblGuessDate.Location = New System.Drawing.Point(21, 77)
        Me.lblGuessDate.Name = "lblGuessDate"
        Me.lblGuessDate.Size = New System.Drawing.Size(0, 15)
        Me.lblGuessDate.TabIndex = 15
        '
        'lblVictory
        '
        Me.lblVictory.AutoSize = True
        Me.lblVictory.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblVictory.Location = New System.Drawing.Point(213, 174)
        Me.lblVictory.Name = "lblVictory"
        Me.lblVictory.Size = New System.Drawing.Size(330, 32)
        Me.lblVictory.TabIndex = 14
        Me.lblVictory.Text = "Would you like to play again?"
        '
        'btnYes
        '
        Me.btnYes.Location = New System.Drawing.Point(402, 229)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(164, 80)
        Me.btnYes.TabIndex = 13
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'btnNo
        '
        Me.btnNo.Location = New System.Drawing.Point(213, 231)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(145, 78)
        Me.btnNo.TabIndex = 12
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'txtGuess
        '
        Me.txtGuess.Location = New System.Drawing.Point(286, 160)
        Me.txtGuess.Name = "txtGuess"
        Me.txtGuess.Size = New System.Drawing.Size(196, 23)
        Me.txtGuess.TabIndex = 11
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(283, 224)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(199, 91)
        Me.btnStart.TabIndex = 10
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblGuess)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lblGuessTime)
        Me.Controls.Add(Me.lblGuessDate)
        Me.Controls.Add(Me.lblVictory)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.txtGuess)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGuess As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lblGuessTime As Label
    Friend WithEvents lblGuessDate As Label
    Friend WithEvents lblVictory As Label
    Friend WithEvents btnYes As Button
    Friend WithEvents btnNo As Button
    Friend WithEvents txtGuess As TextBox
    Friend WithEvents btnStart As Button
End Class
