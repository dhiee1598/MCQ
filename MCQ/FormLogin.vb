Public Class FormLogin
    Dim username As String = "admin"
    Dim password As String = "admin123"

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLogin.Click

        If TextBoxUsername.Text = username And TextBoxPassword.Text = password Then
            Me.Hide()
            FormHome.Show()
        Else
            Beep()
            MessageBox.Show("Wrong Username or Password! Try Again")
            TextBoxUsername.Text = String.Empty
            TextBoxPassword.Text = String.Empty
        End If
    End Sub
End Class
