Imports System.Data.SqlClient


Public Class EmailingUpdatetoReporter

    'thiss is loading all of the
    Dim emailconstring As New SqlConnection("server=HARRY-HP\SQLEXPRESS;database=ticketmanager;Trusted_Connection=Yes")
    'view tickets by ReporterID
    Dim viewticketdataApater As SqlDataAdapter
    Dim viewticketdatatable As New DataTable()
    'view the email of ID
    Dim viewreportemailAdapter As SqlDataAdapter
    Dim viewreporteremailtable As New DataTable()

    'Viewing completed tickets of a reporterID
    Dim viewcompletedReporterticketAdapater As SqlDataAdapter
    Dim viewcompletedReporterTicketDataTable As New DataTable()
    Dim cmd5 As SqlCommand
    Dim da5 As SqlDataAdapter
    Dim ds5 As DataSet
    Dim itemColl5(100) As String
    Private Sub selectordisplayticketReporterProblem(comboBox As ComboBox, errorMessage As String)

        If comboBox.Items.Count > 0 Then
            comboBox.SelectedIndex = 0
        Else
            MessageBox.Show(errorMessage)
            comboBox.Enabled = False
            'this aga reloads the columns 
        End If
    End Sub
    Private Sub EmailingUpdatetoReporter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'viewcompletedReporterticketAdapater = New SqlDataAdapter("Select * Tickets Where resolved = 'resolved' and ReporterID = " + CboboxSelectReporterToEmail.Text, emailconstring)
        'this is selecting the Reporter ids
        viewticketdataApater = New SqlDataAdapter("select ReporterID From Reporters", emailconstring)
        viewticketdataApater.Fill(viewticketdatatable)
        CboboxSelectReporterToEmail.DataSource = viewticketdatatable
        Dim ReportIDanme As String = "ReporterID"
        CboboxSelectReporterToEmail.DisplayMember = ReportIDanme
        CboboxSelectReporterToEmail.ValueMember = ReportIDanme
        selectordisplayticketReporterProblem(CboboxSelectReporterToEmail, "no IDs loaded")

        'Dim [to] As String = "email address"
        'Dim cc As String = "other email address"
        'Dim subject As String = "your subject"
        'Dim body As String = "email body"
        'Process.Start(String.Format("mailto:{0}?cc={1}&subject={2}&body={3}", [to], cc, subject, body))
    End Sub

    Private Sub Btn_ViewSelectedReporterOpentic_Click(sender As Object, e As EventArgs) Handles Btn_ViewSelectedReporterOpentic.Click
        'this views the reporter id that has been selected 
        Me.ListView1.View = View.Details
        Me.ListView1.GridLines = True
        Dim strQ5 As String = String.Empty
        'here is the string for communicating with the dbo.Tickets 
        'this again is loaded into a listview
        strQ5 = "Select * From Tickets Where resolved = 'resolved' and ReporterID = " + CboboxSelectReporterToEmail.Text
        'and ReporterID = " + CboboxSelectReporterToEmail.Text
        cmd5 = New SqlCommand(strQ5, emailconstring)
        da5 = New SqlDataAdapter(cmd5)
        ds5 = New DataSet
        da5.Fill(ds5, "Tickets")

        Dim p As Integer = 0
        Dim q As Integer = 0

        For p = 0 To ds5.Tables(0).Columns.Count - 1
            Me.ListView1.Columns.Add(ds5.Tables(0).Columns(p).ColumnName.ToString())

        Next

        'addin itmes to technicans name list view
        For p = 0 To ds5.Tables(0).Rows.Count - 1

            For q = 0 To ds5.Tables(0).Columns.Count - 1
                itemColl5(q) = ds5.Tables(0).Rows(p)(q).ToString()

            Next
            Dim lvi5 As New ListViewItem(itemColl5)
            Me.ListView1.Items.Add(lvi5)

            Me.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        Next
        'loading the reporterr combo to get not the ide by the email
        viewreportemailAdapter = New SqlDataAdapter("Select ReporterEmail from Reporters  where ReporterID = " + CboboxSelectReporterToEmail.Text, emailconstring)
        viewreportemailAdapter.Fill(viewreporteremailtable)
        ComboBox1.DataSource = viewreporteremailtable
        Dim viewemail As String = "ReporterEmail"
        ComboBox1.DisplayMember = viewemail
        ComboBox1.ValueMember = viewemail
        selectordisplayticketReporterProblem(ComboBox1, "No email loaded")
    End Sub

    Private Sub Btn_EmailReporterThatMissionAcomplished_Click(sender As Object, e As EventArgs) Handles Btn_EmailReporterThatMissionAcomplished.Click
        'this is the button that actually loads outlook to work in a functioning manner. 
        Dim email As String = ComboBox1.Text
        Dim cc As String = ""
        Dim subject As String = "Completed ticket for " + CboboxSelectReporterToEmail.Text
        Dim body As String = "this is the completed work on the ticket " + vbNewLine + "thank you for your service"
        'the process.start is formated this way to load the body with subject that their ticket has been handled 
        Process.Start(String.Format("mailto:{0}?&subject={2}&body={3}", email, cc, subject, body))


    End Sub
End Class