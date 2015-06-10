Public Class Form1

    Public Const hotDogPrice As Double = 3.5
    Public Const italianBeefPrice As Double = 4.5
    Public Const Tax As Double = 0.055

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        outputListBox.Text = ""
        answerLabel.Text = ""
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click

        Dim hotDog As Integer
        Dim italianBeef As Integer


        outputListBox.Text = "The price of the hot dog is $" & hotDogPrice & "0."


        dim
    End Sub
End Class
