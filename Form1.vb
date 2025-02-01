Public Class Form1

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    WebBrowser1.Navigate("https://www.bing.com")
End Sub

Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text = "About" Then
            MsgBox("Nebula Dark V2025.1.02")
        End If
        If TextBox1.Text = "The Answer To Life, The Universe, And Everything" Then
            MsgBox("42")
        End If
        WebBrowser1.Navigate(TextBox1.Text)
End Sub

Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    WebBrowser1.GoBack()

End Sub

Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    WebBrowser1.GoForward()
End Sub

Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    WebBrowser1.Refresh()

End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub
End Class


