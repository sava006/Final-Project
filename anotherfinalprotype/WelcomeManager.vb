Public Class WelcomeManager

    Private Sub btnContinueLogin_Click(sender As Object, e As EventArgs) Handles btnContinueLogin.Click
        MainMenu.ShowDialog()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Close()
        security.Close()
    End Sub
End Class