Imports System.Net.Mime.MediaTypeNames

Imports System.Data.SqlClient
Imports System.Data

Imports System.Windows.Forms

Imports System.Runtime

Imports System.Linq
Imports System.Collections.Generic
Public Class EmailTechnicanList
    'this is our connection string again 
    Dim emailconstring As New SqlConnection("server=HARRY-HP\SQLEXPRESS;database=ticketmanager;Trusted_Connection=Yes")
    'view tickets by ReporterID
    Dim viewticketdataApater As SqlDataAdapter
    Dim viewticketdatatable As New DataTable()
    'view the email of ID
    Dim viewtechemailAdapter As SqlDataAdapter
    Dim viewtechemailtable As New DataTable()

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

        End If
        'this is for correcting the input of the rows 
    End Sub
    Private Sub EmailingUpdatetoReporter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'viewcompletedReporterticketAdapater = New SqlDataAdapter("Select * Tickets Where resolved = 'resolved' and ReporterID = " + CboboxSelectReporterToEmail.Text, emailconstring)
        viewticketdataApater = New SqlDataAdapter("select TechID From Technicans", emailconstring)
        viewticketdataApater.Fill(viewticketdatatable)
        ComboSelectTechtoEmail.DataSource = viewticketdatatable
        Dim TechIDanme As String = "TechID"
        ComboSelectTechtoEmail.DisplayMember = TechIDanme
        ComboSelectTechtoEmail.ValueMember = TechIDanme
        selectordisplayticketReporterProblem(ComboSelectTechtoEmail, "no IDs loaded")

        'Dim [to] As String = "email address"
        'Dim cc As String = "other email address"
        'Dim subject As String = "your subject"
        'Dim body As String = "email body"
        'Process.Start(String.Format("mailto:{0}?cc={1}&subject={2}&body={3}", [to], cc, subject, body))
    End Sub

    Private Sub btn_selectTechToEmail_Click(sender As Object, e As EventArgs) Handles btn_selectTechToEmail.Click
        Me.ListView1.View = View.Details
        Me.ListView1.GridLines = True
        'select the tech to email and show their outstanding tickets which are do 
        Dim cmd As String = _
            "SELECT * From Tickets t join TechnicanTicket e on e.TicketID = t.TicketID  where TechID = " + ComboSelectTechtoEmail.Text + " and resolved = 'unresolved' order by priorityStatus DESC"

        cmd5 = New SqlCommand(cmd, emailconstring)
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

        'You need to concatenate the sql statement and cast the reporter ID as varchar else you will only be able to add
        'one elemet at a time.
        'Try
        '    Dim adpt As New SqlDataAdapter(cmd, emailconstring)

        '    Dim myDataReportersTable As New DataSet()
        '    adpt.Fill(myDataReportersTable, "Tickets")
        '    Dim myDataTable As DataTable = myDataReportersTable.Tables(0)
        '    Dim tempRow As DataRow
        '    ListBox1.Items.Add("Technicans list")
        '    For Each tempRow In myDataTable.Rows
        '        ListBox1.Items.Add((tempRow("Technicans list")))
        '    Next
        '    emailconstring.Close()
        'Catch ex As Exception
        '    If ComboSelectTechtoEmail.Text = "" Then
        '        MessageBox.Show("You need to select a tech to email")

        '    End If
        'End Try
        ' Next we are going to want to load and select the tech email by their tech ide which is located in the combobox
        viewtechemailAdapter = New SqlDataAdapter("Select techemail from Technicans where TechID = " + ComboSelectTechtoEmail.Text, emailconstring)
        viewtechemailAdapter.Fill(viewtechemailtable)
        CboEmailofTech.DataSource = viewtechemailtable
        Dim viewemail As String = "techemail"
        CboEmailofTech.DisplayMember = viewemail
        CboEmailofTech.ValueMember = viewemail
        selectordisplayticketReporterProblem(CboEmailofTech, "No email loaded")
    End Sub

    Private Sub Btn_Emailtechlist_Click(sender As Object, e As EventArgs) Handles Btn_Emailtechlist.Click

        'this sends the tech and email of work to do 
        Dim email As String = CboEmailofTech.Text
        Dim cc As String = ""
        Dim subject As String = "Completed ticket for " + ComboSelectTechtoEmail.Text
        Dim body As New ArrayList()
        body = New ArrayList(ListView1.Items)
        'Dim StronglyTypedList = body.Cast(Of Type)().ToList()
        'If Me.ListView1.Items.Count <> 1 Then Exit Sub
        'Dim row As ListViewItem = Me.ListView1.Items(0)
        'Dim values(0 To row.SubItems.Count - 1) As String
        'Dim i As Integer = 0
        'For Each item As ListViewItem.ListViewSubItem In row.SubItems
        '    values(i) = item.Text
        '    i = i + 1
        'Next
        'Dim values As New List(Of String)
        '' Dim values As New String
        'If ListView1.SelectedItems.Count > 0 Then
        '    For Each item As ListViewItem.ListViewSubItem In ListView1.SelectedItems(0).SubItems()
        '        values.Add(item.Text)

        '    Next
        'End If
        'Dim listviewitem As String = listviewitem1 + vbNewLine

        'this ads the first two rows for tech to view what their given tickets are in abstentia. 
        Dim listviewitems1 As String
        listviewitems1 = "ticketNumbers: " + ListView1.Items(0).Text + ", " + " Priority status " + ListView1.Items(0).SubItems(1).Text + ", issue discription " + ListView1.Items(0).SubItems(2).Text + ", " + ListView1.Items(0).SubItems(2).Text + ", Date issued " + ListView1.Items(0).SubItems(4).Text

        Dim listviewitems2 As String
        listviewitems2 = "ticketNumbers: " + ListView1.Items(1).Text + ", " + " Priority status " + ListView1.Items(1).SubItems(1).Text + ", issue discription " + ListView1.Items(1).SubItems(2).Text + ", " + ListView1.Items(1).SubItems(2).Text + ", date issued " + ListView1.Items(1).SubItems(4).Text

        Dim listviewitem As String
        listviewitem = listviewitems1 + vbNewLine + listviewitems2



        ' + ListView1.Items(1).Text + ListView1.Items(2).Text + ListView1.Items(3)





        ''Dim valueArray(ListView1.Items.Count - 1) As String
        ' ''ReDim valueArray(ListView1.SelectedItems.Count - 1)
        ''Dim i As Integer

        ''For Each Item As ListViewItem In ListView1.SelectedItems
        ''    valueArray(i) = Item.Text
        ''    i += 1
        ''Next
        ' ''Dim Top As String
        ''Dim top As String



        Process.Start(String.Format("mailto:{0}?&subject={2}&body={3}", email, cc, subject, listviewitem))
        'this is the process for sending the email off 

    End Sub
End Class
