Public Class FormHome

    Private Sub ButtonJava_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonJava.Click
        Formjava.Show()
        ButtonMath.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub ButtonMath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMath.Click
        FormMath.Show()
        ButtonJava.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        FormPython.Show()
        ButtonMath.Enabled = False
        ButtonJava.Enabled = False
    End Sub

    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        Environment.Exit(1)
    End Sub

End Class