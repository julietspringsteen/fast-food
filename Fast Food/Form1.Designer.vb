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
        Me.hotDogRadioBtn = New System.Windows.Forms.RadioButton()
        Me.italianBeefBtn = New System.Windows.Forms.RadioButton()
        Me.answerLabel = New System.Windows.Forms.Label()
        Me.outputListBox = New System.Windows.Forms.ListBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'hotDogRadioBtn
        '
        Me.hotDogRadioBtn.AutoSize = True
        Me.hotDogRadioBtn.Checked = True
        Me.hotDogRadioBtn.Location = New System.Drawing.Point(28, 79)
        Me.hotDogRadioBtn.Name = "hotDogRadioBtn"
        Me.hotDogRadioBtn.Size = New System.Drawing.Size(65, 17)
        Me.hotDogRadioBtn.TabIndex = 0
        Me.hotDogRadioBtn.TabStop = True
        Me.hotDogRadioBtn.Text = "Hot Dog"
        Me.hotDogRadioBtn.UseVisualStyleBackColor = True
        '
        'italianBeefBtn
        '
        Me.italianBeefBtn.AutoSize = True
        Me.italianBeefBtn.Location = New System.Drawing.Point(28, 102)
        Me.italianBeefBtn.Name = "italianBeefBtn"
        Me.italianBeefBtn.Size = New System.Drawing.Size(78, 17)
        Me.italianBeefBtn.TabIndex = 1
        Me.italianBeefBtn.TabStop = True
        Me.italianBeefBtn.Text = "Italian Beef"
        Me.italianBeefBtn.UseVisualStyleBackColor = True
        '
        'answerLabel
        '
        Me.answerLabel.AutoSize = True
        Me.answerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answerLabel.Location = New System.Drawing.Point(246, 173)
        Me.answerLabel.Name = "answerLabel"
        Me.answerLabel.Size = New System.Drawing.Size(68, 20)
        Me.answerLabel.TabIndex = 2
        Me.answerLabel.Text = "Answer"
        '
        'outputListBox
        '
        Me.outputListBox.FormattingEnabled = True
        Me.outputListBox.Location = New System.Drawing.Point(185, 59)
        Me.outputListBox.Name = "outputListBox"
        Me.outputListBox.Size = New System.Drawing.Size(204, 95)
        Me.outputListBox.TabIndex = 3
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(52, 215)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(75, 23)
        Me.calcButton.TabIndex = 4
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(152, 215)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 5
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(250, 215)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 283)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.outputListBox)
        Me.Controls.Add(Me.answerLabel)
        Me.Controls.Add(Me.italianBeefBtn)
        Me.Controls.Add(Me.hotDogRadioBtn)
        Me.Name = "Form1"
        Me.Text = "Fast Food"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents hotDogRadioBtn As System.Windows.Forms.RadioButton
    Friend WithEvents italianBeefBtn As System.Windows.Forms.RadioButton
    Friend WithEvents answerLabel As System.Windows.Forms.Label
    Friend WithEvents outputListBox As System.Windows.Forms.ListBox
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
