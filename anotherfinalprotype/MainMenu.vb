Public Class MainMenu
    'this page just opens displays other forms that we are going to want to go to and explore on our own 
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTechnicans_Click(sender As Object, e As EventArgs) Handles btnTechnicans.Click
        TechnicanGui.ShowDialog()
    End Sub

    Private Sub btnReporters_Click(sender As Object, e As EventArgs) Handles btnReporters.Click
        Reporters.ShowDialog()
    End Sub

   
    Private Sub btnCurrentOutstandingTicket_Click(sender As Object, e As EventArgs) Handles btnCurrentOutstandingTicket.Click
        OpenTickets.ShowDialog()
    End Sub


    Private Sub tbnCreateTickets_Click(sender As Object, e As EventArgs) Handles tbnCreateTickets.Click
        OpenTickets.ShowDialog()

    End Sub
End Class