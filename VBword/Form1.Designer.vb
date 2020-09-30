<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxWord = New System.Windows.Forms.TextBox()
        Me.ButtonAddWord = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButtonToUpper = New System.Windows.Forms.RadioButton()
        Me.RadioButtonToLower = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPurple = New System.Windows.Forms.RadioButton()
        Me.RadioButtonBlue = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a word:"
        '
        'TextBoxWord
        '
        Me.TextBoxWord.Location = New System.Drawing.Point(11, 25)
        Me.TextBoxWord.Name = "TextBoxWord"
        Me.TextBoxWord.Size = New System.Drawing.Size(223, 20)
        Me.TextBoxWord.TabIndex = 1
        '
        'ButtonAddWord
        '
        Me.ButtonAddWord.Location = New System.Drawing.Point(40, 61)
        Me.ButtonAddWord.Name = "ButtonAddWord"
        Me.ButtonAddWord.Size = New System.Drawing.Size(143, 23)
        Me.ButtonAddWord.TabIndex = 2
        Me.ButtonAddWord.Text = "Add"
        Me.ButtonAddWord.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(11, 113)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(223, 95)
        Me.ListBox1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'RadioButtonToUpper
        '
        Me.RadioButtonToUpper.AutoSize = True
        Me.RadioButtonToUpper.Location = New System.Drawing.Point(15, 293)
        Me.RadioButtonToUpper.Name = "RadioButtonToUpper"
        Me.RadioButtonToUpper.Size = New System.Drawing.Size(70, 17)
        Me.RadioButtonToUpper.TabIndex = 5
        Me.RadioButtonToUpper.TabStop = True
        Me.RadioButtonToUpper.Text = "To Upper"
        Me.RadioButtonToUpper.UseVisualStyleBackColor = True
        '
        'RadioButtonToLower
        '
        Me.RadioButtonToLower.AutoSize = True
        Me.RadioButtonToLower.Location = New System.Drawing.Point(15, 317)
        Me.RadioButtonToLower.Name = "RadioButtonToLower"
        Me.RadioButtonToLower.Size = New System.Drawing.Size(70, 17)
        Me.RadioButtonToLower.TabIndex = 6
        Me.RadioButtonToLower.TabStop = True
        Me.RadioButtonToLower.Text = "To Lower"
        Me.RadioButtonToLower.UseVisualStyleBackColor = True
        '
        'RadioButtonPurple
        '
        Me.RadioButtonPurple.AutoSize = True
        Me.RadioButtonPurple.Location = New System.Drawing.Point(144, 293)
        Me.RadioButtonPurple.Name = "RadioButtonPurple"
        Me.RadioButtonPurple.Size = New System.Drawing.Size(55, 17)
        Me.RadioButtonPurple.TabIndex = 7
        Me.RadioButtonPurple.TabStop = True
        Me.RadioButtonPurple.Text = "Purple"
        Me.RadioButtonPurple.UseVisualStyleBackColor = True
        '
        'RadioButtonBlue
        '
        Me.RadioButtonBlue.AutoSize = True
        Me.RadioButtonBlue.Location = New System.Drawing.Point(144, 317)
        Me.RadioButtonBlue.Name = "RadioButtonBlue"
        Me.RadioButtonBlue.Size = New System.Drawing.Size(46, 17)
        Me.RadioButtonBlue.TabIndex = 8
        Me.RadioButtonBlue.TabStop = True
        Me.RadioButtonBlue.Text = "Blue"
        Me.RadioButtonBlue.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 450)
        Me.Controls.Add(Me.RadioButtonBlue)
        Me.Controls.Add(Me.RadioButtonPurple)
        Me.Controls.Add(Me.RadioButtonToLower)
        Me.Controls.Add(Me.RadioButtonToUpper)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ButtonAddWord)
        Me.Controls.Add(Me.TextBoxWord)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Words"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxWord As TextBox
    Friend WithEvents ButtonAddWord As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButtonToUpper As RadioButton
    Friend WithEvents RadioButtonToLower As RadioButton
    Friend WithEvents RadioButtonPurple As RadioButton
    Friend WithEvents RadioButtonBlue As RadioButton
End Class
