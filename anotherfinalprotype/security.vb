Public Class security
    'not much time for this form but this the form that is set to show up first 
    'because if they cannot get the password right we do not want them to view all the tables 
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'this goes to the welcome page
        WelcomeManager.ShowDialog()

    End Sub
End Class
