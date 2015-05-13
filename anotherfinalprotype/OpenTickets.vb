Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

'Dim Ticketconnection As New SqlConnection("server=HARRY-HP\SQLEXPRESS;databse=ticketmanager;Trusted_Connection=Yes")



Public Class OpenTickets
    Dim Ticketconnection As New SqlConnection("server=HARRY-HP\SQLEXPRESS;database=ticketmanager;Trusted_Connection=Yes")
    Dim bindingticketSource As New BindingSource()
    'adapter for the reporterName names
    Dim ticketDataAdapter As SqlDataAdapter
    'for table for the ticket names
    Dim objticketDataTable As New DataTable()
    'another table for ticket names
    Dim objTicketIdTables As New DataTable()
    Dim objticketIDAdapter As SqlDataAdapter
    'this is the ticket data adapter
    Dim cmd2 As SqlCommand
    Dim da2 As SqlDataAdapter
    Dim ds2 As DataSet
    Dim itemcoll(100) As String

    Dim bindingSource As New BindingSource()
    'adapter for the reporter names
    Dim objReporter2DataAdapter As SqlDataAdapter
    'for table for the reporter names
    Dim objReporter2DataTable As New DataTable()
    'another table for reporter names
    Dim objReporter2NamesTables As New DataTable()
    Dim objDepName2Adapter As SqlDataAdapter
    'this is the department data adapter
    Dim objDep2Tables As New DataTable()

    Dim objUnresolvedTicsAssignedToTechDataAdapter As SqlDataAdapter
    Dim objUnresolvedTicsAssignedToTechTabe As New DataTable()

    Dim unassignedticketadapter As SqlDataAdapter
    Dim unassignedtickettable As New DataTable()
    Dim assigningtechadapter2 As SqlDataAdapter
    Dim assigningtechtable As New DataTable()

    'assigned listview techs
    Dim cmd3 As SqlCommand
    Dim Da3 As SqlDataAdapter
    Dim Ds3 As DataSet
    Dim itemcoll2(100) As String
    'unassinged tickets to tech commands

    Dim cmd4 As SqlCommand
    Dim Da4 As SqlDataAdapter
    Dim Ds4 As DataSet
    Dim itemColl3(100) As String

    Dim updatetickupresovledcmd As SqlCommand
    Dim udateticketunresolveddataAdapter As SqlDataAdapter
   
    Dim cmd5 As SqlCommand
    Dim Da5 As SqlDataAdapter
    Dim Ds5 As DataSet
    Dim itemColl5(100) As String
    Dim cmd6 As SqlCommand
    Dim Da6 As SqlDataAdapter
    Dim ds6 As DataSet
    Dim itemColl6(100) As String
    Dim updatecompletedticket As SqlCommand

    Private Sub OpenTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim selectedIDtoUpdateAdapter As New SqlDataAdapter("Select TicketID from Tickets where resolved = 'unresolved'", Ticketconnection)
        Dim selectedIdtoUpdatedatatable As New DataTable()
        selectedIDtoUpdateAdapter.Fill(selectedIdtoUpdatedatatable)
        cboselectedtick.DataSource = selectedIdtoUpdatedatatable
        Dim selectiD As String = "TicketID"
        cboselectedtick.DisplayMember = selectiD
        cboselectedtick.ValueMember = selectiD
        selectordisplayticketReporterProblem(cboselectedtick, "there is nothing to load for tickets")
        ' the loads above to select ticketId in order to be used for mining further tickets

        objReporter2DataAdapter = New SqlDataAdapter("select ReporterID From Reporters", Ticketconnection)
        objReporter2DataAdapter.Fill(objReporter2NamesTables)
        ComboBoxReporters.DataSource = objReporter2NamesTables
        Dim ReporterNameColumn2 As String = "ReporterID"
        ComboBoxReporters.DisplayMember = ReporterNameColumn2
        ComboBoxReporters.ValueMember = ReporterNameColumn2
        'this loading a combox reporter box 
        selectordisplayticketReporterProblem(ComboBoxReporters, "No Reporter were found. YOU need to add a Reporter")

        'Dim unassignedticketadapter As SqlDataAdapter
        'Dim unassignedtickettable As New DataTable()
        'Dim assigningtechadapter2 As SqlDataAdapter
        'Dim assigningtechtable As New DataTable()
        'Dim updatetoUnresolved As SqlDataAdapter
        'updatetoUnresolved = New SqlDataAdapter("Update Tickets set resolved = 'Unresolved' where Date_Completed is Null", Ticketconnection)

        'this is selecting from tickets where the Date_Completed is null 
        unassignedticketadapter = New SqlDataAdapter("Select * from tickets where Date_Completed is Null", Ticketconnection)
        unassignedticketadapter.Fill(unassignedtickettable)
        CboTicketstobeAssigned.DataSource = unassignedtickettable
        Dim tickettobeassinged As String = "TicketID"
        CboTicketstobeAssigned.DisplayMember = tickettobeassinged
        CboTicketstobeAssigned.ValueMember = tickettobeassinged
        selectordisplayticketReporterProblem(CboTicketstobeAssigned, "No tickets were to be found")
        'added values to cboTicketedtoAssigned 
        assigningtechadapter2 = New SqlDataAdapter("Select * from Technicans", Ticketconnection)
        assigningtechadapter2.Fill(assigningtechtable)
        CboTechstobeassigned.DataSource = assigningtechtable
        Dim techtobeassinged As String = "techID"
        CboTechstobeassigned.DisplayMember = techtobeassinged
        CboTechstobeassigned.ValueMember = techtobeassinged
        selectordisplayticketReporterProblem(CboTechstobeassigned, "No Techs where to be found")

        'for list of technicans to be assigned to unassigned created tickets
        'Dim bindingSource As New BindingSource()
        'Dim objTechnicanListadapter As SqlDataAdapter
        'Dim objTechnican2DataTable As New DataTable()
        Dim objtickettoselectforissuesdataAdapter As SqlDataAdapter
        Dim objtickettoselectforissuesDataTable As New DataTable()
        'I concatenated a string to fll the select unreosolved techs by name 
        objtickettoselectforissuesdataAdapter = New SqlDataAdapter("Select cast(TechID as varchar) + ' :' + TechFirstName + '-' + TechLastName as Name from Technicans", Ticketconnection)
        objtickettoselectforissuesdataAdapter.Fill(objtickettoselectforissuesDataTable)
        CboSelectunresolvedticksbyAssignedTech.DataSource = objtickettoselectforissuesDataTable
        Dim techName As String = "Name"
        CboSelectunresolvedticksbyAssignedTech.DisplayMember = techName
        CboSelectunresolvedticksbyAssignedTech.ValueMember = techName
        selectordisplayticketReporterProblem(CboSelectunresolvedticksbyAssignedTech, " No names for technicans in combobox ")
        Dim objecttagain As SqlDataAdapter
        Dim objectagaintabel As New DataTable()
        objecttagain = New SqlDataAdapter("Select TechID from Technicans", Ticketconnection)
        objecttagain.Fill(objectagaintabel)
        Dim completemmentComboTableName As String = "TechID"
        ComboBox1.DataSource = objectagaintabel
        ComboBox1.DisplayMember = completemmentComboTableName
        ComboBox1.ValueMember = completemmentComboTableName
        selectordisplayticketReporterProblem(ComboBox1, "TechIDs in the combobox")
        ListViewAssignedticswithretecchs.Clear()
        MessageBox.Show("Clearing the selected tables and then putting the inforamation back on the table by selected tehnican ")

    End Sub
    Private Sub selectordisplayticketReporterProblem(comboBox As ComboBox, errorMessage As String)

        If comboBox.Items.Count > 0 Then
            comboBox.SelectedIndex = 0
        Else
            MessageBox.Show(errorMessage)
            comboBox.Enabled = False
            'this sub is for checking that various information is filled into the various combo boxex

        End If
    End Sub
    Private Sub btnAddNewticket_Click(sender As Object, e As EventArgs) Handles btnAddNewticket.Click

        'calling the new ticket class I have created for creating a new ticket 
        Dim newtic As New NewTicket
        newtic.Ticketdescription = TxtIssueDescrpition.Text
        newtic.Tickurgency = CInt(NumericUpDownSeverityRating.Value)
        newtic.Ticketopendate = CDate(TxtDateIssued.Text)
        newtic.Personreporting = CInt(ComboBoxReporters.Text)
        'newtic.Ticketclosedate = Convert.DBNull(TxtDateResolved.Text)
        'newtic.Resolved = TxtResovledorNot.Text
        'newtic.Whatresolved = txtwhatworkwasdone.Text

        'inserting a new ticket onto the ticket menu utilizing  parameters and using variables
        Dim newticketInsertSql As String = "insert into tickets values(@priorityStatus, @issueDescription,(select ReporterID from Reporters where ReporterID = @ReporterID), @Date_reported, @Date_Completed, @resolved, @DescriptionWorkDone)"
        Dim newticketInsertSqlcommand As New SqlCommand(newticketInsertSql, Ticketconnection)
        newticketInsertSqlcommand.Parameters.AddWithValue("@priorityStatus", newtic.Tickurgency)
        newticketInsertSqlcommand.Parameters.AddWithValue("@issueDescription", newtic.Ticketdescription)
        newticketInsertSqlcommand.Parameters.AddWithValue("@Date_Reported", newtic.Ticketopendate)
        newticketInsertSqlcommand.Parameters.AddWithValue("@ReporterID", newtic.Personreporting)
        newticketInsertSqlcommand.Parameters.AddWithValue("@Date_Completed", Convert.DBNull)
        newticketInsertSqlcommand.Parameters.AddWithValue("@resolved", Convert.DBNull)
        newticketInsertSqlcommand.Parameters.AddWithValue("@DescriptionWorkdone", Convert.DBNull)
        Try
            Ticketconnection.Open()
            newticketInsertSqlcommand.ExecuteNonQuery()
            Ticketconnection.Close()
        Catch se As SqlException
            If se.Number = 2627 Then
                MessageBox.Show("the ticket already exists")

            End If

        End Try


        MessageBox.Show("Added a newticket to the ticket list")
        'Dim updateticket1 As String = "update tickets set resolved = 'not completed' where Date_Completed = Null"
        'Dim updatetickettoUncompleted As New SqlCommand(updateticket1, Ticketconnection)
        'MessageBox.Show("Ticket has been updated to where Date resolved is open to null")
        'unassignedticketadapter.Update(unassignedtickettable)
        'CboTicketstobeAssigned.DataSource = unassignedticketadapter
        'Dim ticketupdate As String = "TicketID"
        'CboTicketstobeAssigned.DisplayMember = ticketupdate
        'CboTicketstobeAssigned.ValueMember = ticketupdate
        TxtDateIssued.Clear()
        TxtIssueDescrpition.Clear()


    End Sub

    
    Private Sub btn_viewreportnamefromid_Click(sender As Object, e As EventArgs) Handles btn_viewreportnamefromid.Click
        ListViewReporterDepAndName.Clear()
        'tihs were I found the code for the lines 59 via 87
        'this is a list view of a name into the listview by columns and witht reporter name 
        'https://www.daniweb.com/software-development/vbnet/threads/357118/populating-listview-using-database
        Me.ListViewReporterDepAndName.View = View.Details
        Me.ListViewReporterDepAndName.GridLines = True
        Dim strQ2 As String = String.Empty
        strQ2 = "Select ReporterFirstName, ReporterLastName from Reporters where ReporterID = " + ComboBoxReporters.Text.ToString()
        cmd2 = New SqlCommand(strQ2, Ticketconnection)
        da2 = New SqlDataAdapter(cmd2)
        ds2 = New DataSet
        da2.Fill(ds2, "Reporters")
        Dim i As Integer = 0
        Dim j As Integer = 0

        For i = 0 To ds2.Tables(0).Columns.Count - 1
            Me.ListViewReporterDepAndName.Columns.Add(ds2.Tables(0).Columns(i).ColumnName.ToString())

        Next

        'addin itmes to technicans name list view
        For i = 0 To ds2.Tables(0).Rows.Count - 1

            For j = 0 To ds2.Tables(0).Columns.Count - 1
                itemcoll(j) = ds2.Tables(0).Rows(i)(j).ToString()

            Next
            Dim lvi As New ListViewItem(itemcoll)
            Me.ListViewReporterDepAndName.Items.Add(lvi)

            Me.ListViewReporterDepAndName.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        Next

    End Sub

    Private Sub btn_ViewAvailableTicksandTechs_Click(sender As Object, e As EventArgs) Handles btn_ViewAvailableTicksandTechs.Click

        'Private Sub TabPageAssignTickets_Click(sender As Object, e As EventArgs) Handles TabPageAssignTickets.Click
        MessageBox.Show("Please use the drop down boxes and select the id which mataches the one you want in the table to the other table and its id to its number")
        ' MessageBox.Show("Please select update all tickets to unreolved")
        ''we are going to want to update all of our code
        'Dim updateticket1 As String = "UPDATE Tickets SET resolved = 'not completed' Where Date_Completed = null"
        'Dim updatetickettoUncompleted As SqlCommand
        'Dim upddateadaptertic As SqlDataAdapter
        'updatetickettoUncompleted = New SqlCommand(updateticket1, Ticketconnection)
        'upddateadaptertic = New SqlDataAdapter(updatetickettoUncompleted)
        'MessageBox.Show("Ticket has been updated to where Date resolved is open to null")
        'unassignedticketadapter.Update(unassignedtickettable)
        'CboTicketstobeAssigned.DataSource = unassignedticketadapter
        'Dim ticketupdate As String = "TicketID"
        'CboTicketstobeAssigned.DisplayMember = ticketupdate
        'CboTicketstobeAssigned.ValueMember = ticketupdate
        'Dim unassignedticketadapter As SqlDataAdapter
        'Dim unassignedtickettable As New DataTable()
        'Dim assigningtechadapter2 As SqlDataAdapter
        'Dim assigningtechtable As New DataTable()

        'unassignedticketadapter = New SqlDataAdapter("Select * from tickets where Date_Completed is null", Ticketconnection)
        'unassignedticketadapter.Fill(unassignedtickettable)
        'CboTicketstobeAssigned.DataSource = unassignedtickettable
        'Dim tickettobeassinged As String = "TicketID"
        'CboTicketstobeAssigned.DisplayMember = tickettobeassinged
        'CboTicketstobeAssigned.ValueMember = tickettobeassinged
        'selectordisplayticketReporterProblem(CboTicketstobeAssigned, "No tickets were to be found")

        'assigningtechadapter2 = New SqlDataAdapter("Select * from Technicans", Ticketconnection)
        'assigningtechadapter2.Fill(assigningtechtable)
        'CboTechstobeassigned.DataSource = assigningtechadapter2
        'Dim techtobeassinged As String = "techID"
        'CboTechstobeassigned.DisplayMember = techtobeassinged
        'CboTechstobeassigned.ValueMember = techtobeassinged
        'selectordisplayticketReporterProblem(CboTechstobeassigned, "No Techs where to be found")

        'this for updateding the two listviews
        ListViewTechnicans.Clear()
        ListViewUnassignedTickets.Clear()

        'for list of technicans to be assigned to unassigned created tickets
        'Dim bindingSource As New BindingSource()
        'Dim objTechnicanListadapter As SqlDataAdapter
        'Dim objTechnican2DataTable As New DataTable()

        'objTechnicanListadapter = New SqlDataAdapter("Select * From Technicans", Ticketconnection)
        'objTechnicanListadapter.Fill(objTechnican2DataTable)
        'for the technican list
        'Dim cmd3 As SqlCommand
        'Dim Da3 As SqlDataAdapter
        'Dim Ds3 As DataSet
        'Dim itemcoll2(100) As String

        'this loads every column from technicans into the listview
        Me.ListViewTechnicans.View = View.Details
        Me.ListViewTechnicans.GridLines = True
        Dim sqrQ3 As String = String.Empty
        sqrQ3 = "Select * from Technicans"
        cmd3 = New SqlCommand(sqrQ3, Ticketconnection)
        Da3 = New SqlDataAdapter(cmd3)
        Ds3 = New DataSet
        Da3.Fill(Ds3, "Technicans")
        Dim z As Integer = 0
        Dim x As Integer = 0

        For z = 0 To Ds3.Tables(0).Columns.Count - 1
            Me.ListViewTechnicans.Columns.Add(Ds3.Tables(0).Columns(z).ColumnName.ToString())

        Next

        'addin itmes to technicans name list view
        For z = 0 To Ds3.Tables(0).Rows.Count - 1

            For x = 0 To Ds3.Tables(0).Columns.Count - 1
                itemcoll2(x) = Ds3.Tables(0).Rows(z)(x).ToString()

            Next
            Dim lvi1 As New ListViewItem(itemcoll2)
            Me.ListViewTechnicans.Items.Add(lvi1)

            Me.ListViewTechnicans.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

        Next
        Ticketconnection.Close()

        'this for the new ticklistview in Sql
        'Dim cmd4 As SqlCommand
        'Dim Da4 As SqlDataAdapter
        'Dim Ds4 As DataSet
        'Dim itemColl3(100) As String
        Me.ListViewUnassignedTickets.View = View.Details
        Me.ListViewUnassignedTickets.GridLines = True
        Dim sqr4 As String = String.Empty
        'this when clicked this runs two quries one to update resolved tickes as null where date completed is null and then
        'the other actually pulls all of the data into the listview 
        sqr4 = "update tickets set resolved = 'unresolved' where Date_Completed is null; Select * From Tickets t join Reporters r on r.ReporterID = t.ReporterID where resolved = 'unresolved'"
        cmd4 = New SqlCommand(sqr4, Ticketconnection)
        Da4 = New SqlDataAdapter(cmd4)
        Ds4 = New DataSet
        Da4.Fill(Ds4, "Tickets")
        Dim a As Integer = 0
        Dim b As Integer = 0
        For a = 0 To Ds4.Tables(0).Columns.Count - 1
            Me.ListViewUnassignedTickets.Columns.Add(Ds4.Tables(0).Columns(a).ColumnName.ToString())

        Next
        For a = 0 To Ds4.Tables(0).Rows.Count - 1
            For b = 0 To Ds4.Tables(0).Columns.Count - 1
                itemColl3(b) = Ds4.Tables(0).Rows(a)(b).ToString()

            Next
            Dim lvi2 As New ListViewItem(itemColl3)
            Me.ListViewUnassignedTickets.Items.Add(lvi2)

            Me.ListViewUnassignedTickets.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        Next
        Ticketconnection.Close()
    End Sub

    Private Sub combobox1sub()

        'a combox sub to help other technicans so as not to continue to pull code for a the
        'tech table over and over again; however I did not quiete implemented into this project. 

        Dim objecttagain As SqlDataAdapter
        Dim objectagaintabel As New DataTable()
        objecttagain = New SqlDataAdapter("Select TechID from Technicans", Ticketconnection)
        objecttagain.Fill(objectagaintabel)
        Dim completemmentComboTableName As String = "TechID"
        ComboBox1.DataSource = objectagaintabel
        ComboBox1.DisplayMember = completemmentComboTableName
        ComboBox1.ValueMember = completemmentComboTableName
        selectordisplayticketReporterProblem(ComboBox1, "TechIDs in the combobox")

    End Sub

    Private Sub BtnAssign_Click(sender As Object, e As EventArgs) Handles BtnAssign.Click
        'assigning a ticket 
        ' and then running for the newticket class for creing a new ticket
        Dim ticketwithtech As New NewTicket
        ticketwithtech.TicketID = CInt(CboTicketstobeAssigned.Text)

        Dim techhasAnothertech As New Techticketassignment
        techhasAnothertech.TechjoinedID = CInt(CboTechstobeassigned.Text)
        'this is job that is inserted into a new technican list 
        ' this good news to know that it dumps into this new table and 
        'so now we can join the ticket table with the tech table 
        Dim AssignedtictoTechInsertSql As String = "insert into TechnicanTicket values (@TicketID, @TechID)"

        Dim sqlAddTechToTicketcommand As New SqlCommand(AssignedtictoTechInsertSql, Ticketconnection)
        sqlAddTechToTicketcommand.Parameters.AddWithValue("@TicketID", ticketwithtech.TicketID)
        sqlAddTechToTicketcommand.Parameters.AddWithValue("@TechID", techhasAnothertech.TechjoinedID)

        Try
            Ticketconnection.Open()
            sqlAddTechToTicketcommand.ExecuteNonQuery()
            Ticketconnection.Close()

        Catch se As SqlException

            'catching the error of trying to assign the same ticket twice
            'a technican can have more than one ticket but not the other way around
            If se.Number = 2601 Then
                MessageBox.Show("this ticket :" + CboTicketstobeAssigned.Text + " has already been assigned")

            End If

        End Try
        ' based on the above iinsetion in the TechnicanTicket table we are loading various combo boxes as seen 
        'below 
        Dim objtickettoselectforissuesdataAdapter As SqlDataAdapter
        Dim objtickettoselectforissuesDataTable As New DataTable()
        objtickettoselectforissuesdataAdapter = New SqlDataAdapter("Select cast(TechID as varchar) + ' :' + TechFirstName + '-' + TechLastName as Name from Technicans", Ticketconnection)
        objtickettoselectforissuesdataAdapter.Fill(objtickettoselectforissuesDataTable)
        CboSelectunresolvedticksbyAssignedTech.DataSource = objtickettoselectforissuesDataTable
        Dim techName As String = "Name"
        CboSelectunresolvedticksbyAssignedTech.DisplayMember = techName
        CboSelectunresolvedticksbyAssignedTech.ValueMember = techName
        selectordisplayticketReporterProblem(CboSelectunresolvedticksbyAssignedTech, " No names for technicans in combobox ")
        Dim objecttagain As SqlDataAdapter
        Dim objectagaintabel As New DataTable()
        objecttagain = New SqlDataAdapter("Select TechID from Technicans", Ticketconnection)
        objecttagain.Fill(objectagaintabel)
        Dim completemmentComboTableName As String = "TechID"
        ComboBox1.DataSource = objectagaintabel
        ComboBox1.DisplayMember = completemmentComboTableName
        ComboBox1.ValueMember = completemmentComboTableName
        selectordisplayticketReporterProblem(ComboBox1, "TechIDs in the combobox")
        'objUnresolvedTicsAssignedToTechDataAdapter = New SqlDataAdapter("select * from Technicans t inner join TechnicanTicket e on e.TechID = t.TechID inner join Tickets c on c.TicketID = e.TicketID where t.TechID = " + ComboBox1.Text + " order by priorityStatus", Ticketconnection)
        'Dim objunersolvedNewtickisDatatable As New DataTable()
        'objUnresolvedTicsAssignedToTechDataAdapter.Fill(objunersolvedNewtickisDatatable)

        'DataGridViewTicketsunresolvedbutassignedtotech.DataSource = objunersolvedNewtickisDatatable

        'this is a listview to see assigned tickets open tickets and their techincians 
        ListViewAssignedticswithretecchs.Clear()
        'tihs were I found the code for the lines 59 via 87
        'https://www.daniweb.com/software-development/vbnet/threads/357118/populating-listview-using-database
        Me.ListViewAssignedticswithretecchs.View = View.Details
        Me.ListViewAssignedticswithretecchs.GridLines = True
        Dim strQ5 As String = String.Empty
        'the string used to run the query
        strQ5 = "select * from Technicans t join TechnicanTicket e on e.TechID = t.TechID join Tickets c on c.TicketID = e.TicketID where t.TechID = " + CboTechstobeassigned.Text + " and c.TicketID = " + CboTicketstobeAssigned.Text + " order by priorityStatus"
        cmd5 = New SqlCommand(strQ5, Ticketconnection)
        Da5 = New SqlDataAdapter(cmd5)
        Ds5 = New DataSet
        Da5.Fill(Ds5)
        Dim p As Integer = 0
        Dim q As Integer = 0

        For p = 0 To Ds5.Tables(0).Columns.Count - 1
            Me.ListViewAssignedticswithretecchs.Columns.Add(Ds5.Tables(0).Columns(p).ColumnName.ToString())

        Next

        'addin itmes to technicans name list view
        For p = 0 To Ds5.Tables(0).Rows.Count - 1

            For q = 0 To Ds5.Tables(0).Columns.Count - 1
                itemColl5(q) = Ds5.Tables(0).Rows(p)(q).ToString()

            Next
            Dim lvi5 As New ListViewItem(itemColl5)
            Me.ListViewAssignedticswithretecchs.Items.Add(lvi5)

            Me.ListViewAssignedticswithretecchs.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        Next

        Ticketconnection.Close()
        Close()
        Dim selectedIDtoUpdateAdapter As New SqlDataAdapter("Select TicketID from Tickets where resolved = 'unresolved'", Ticketconnection)
        Dim selectedIdtoUpdatedatatable As New DataTable()
        selectedIDtoUpdateAdapter.Fill(selectedIdtoUpdatedatatable)
        cboselectedtick.DataSource = selectedIdtoUpdatedatatable
        Dim selectiD As String = "TicketID"
        cboselectedtick.DisplayMember = selectiD
        cboselectedtick.ValueMember = selectiD
        selectordisplayticketReporterProblem(cboselectedtick, "there is nothing to load for tickets")


    End Sub

    Private Sub btn_Viewticksbytech_Click(sender As Object, e As EventArgs) Handles btn_Viewticksbytech.Click
        'this views technican by a given Technican 

        'CboSelectunresolvedticksbyAssignedTech.Refresh()
        'ComboBox1.Refresh()

        'Dim objtickettoselectforissuesdataAdapter As SqlDataAdapter
        'Dim objtickettoselectforissuesDataTable As New DataTable()
        'objtickettoselectforissuesdataAdapter = New SqlDataAdapter("Select cast(TechID as varchar) + ' :' + TechFirstName + '-' + TechLastName as Name from Technicans", Ticketconnection)
        'objtickettoselectforissuesdataAdapter.Fill(objtickettoselectforissuesDataTable)
        'CboSelectunresolvedticksbyAssignedTech.DataSource = objtickettoselectforissuesDataTable
        'Dim techName As String = "Name"
        'CboSelectunresolvedticksbyAssignedTech.DisplayMember = techName
        'CboSelectunresolvedticksbyAssignedTech.ValueMember = techName
        'selectordisplayticketReporterProblem(CboSelectunresolvedticksbyAssignedTech, " No names for technicans in combobox ")
        'Dim objecttagain As SqlDataAdapter
        'Dim objectagaintabel As New DataTable()
        'objecttagain = New SqlDataAdapter("Select TechID from Technicans", Ticketconnection)
        'objecttagain.Fill(objectagaintabel)
        'Dim completemmentComboTableName As String = "TechID"
        'ComboBox1.DataSource = objectagaintabel
        'ComboBox1.DisplayMember = completemmentComboTableName
        'ComboBox1.ValueMember = completemmentComboTableName
        'selectordisplayticketReporterProblem(ComboBox1, "TechIDs in the combobox")
        'ListViewAssignedticswithretecchs.Clear()
        'MessageBox.Show("Clearing the selected tables and then putting the inforamation back on the table by selected tehnican ")

        'objUnresolvedTicsAssignedToTechDataAdapter = New SqlDataAdapter("Select * from Tickets i inner join TechnicanTicket e on e.TicketID = i.TicketID inner join Technicans a on e.TechID = a.TechID where TechID = " + ComboBox1.Text + " and i.resolved = 'unresolved' order by PriorityStatus Desc", Ticketconnection)
        'objUnresolvedTicsAssignedToTechDataAdapter.Fill(objUnresolvedTicsAssignedToTechTabe)
        'DataGridViewTicketsunresolvedbutassignedtotech.DataSource = objUnresolvedTicsAssignedToTechTabe

        'adding valuse iinto the the ListViw of techs assinged with tickets and their values 
        Me.ListViewAssignedticswithretecchs.View = View.Details
        Me.ListViewAssignedticswithretecchs.GridLines = True
        Dim strQ5 As String = String.Empty
        'the string for the query
        strQ5 = "Select * from Tickets i join TechnicanTicket e on e.TicketID = i.TicketID join Technicans a on e.TechID = a.TechID where e.TechID = " + ComboBox1.Text + " and resolved = 'unresolved' order by PriorityStatus Desc"
        cmd5 = New SqlCommand(strQ5, Ticketconnection)
        Da5 = New SqlDataAdapter(cmd5)
        Ds5 = New DataSet
        Da5.Fill(Ds5)
        Dim p As Integer = 0
        Dim q As Integer = 0

        For p = 0 To Ds5.Tables(0).Columns.Count - 1
            Me.ListViewAssignedticswithretecchs.Columns.Add(Ds5.Tables(0).Columns(p).ColumnName.ToString())

        Next

        'addin itmes to technicans name list view
        For p = 0 To Ds5.Tables(0).Rows.Count - 1

            For q = 0 To Ds5.Tables(0).Columns.Count - 1
                itemColl5(q) = Ds5.Tables(0).Rows(p)(q).ToString()

            Next
            Dim lvi5 As New ListViewItem(itemColl5)
            Me.ListViewAssignedticswithretecchs.Items.Add(lvi5)

            Me.ListViewAssignedticswithretecchs.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        Next
    End Sub

    Private Sub btn_emailTech_Click(sender As Object, e As EventArgs) Handles btn_emailTech.Click

        'this is the email for the tech that will open the email tech form
        MessageBox.Show("this will email the technican only tickets that are outstanding which he or she needs to work on")
        EmailTechnicanList.ShowDialog()

    End Sub

    Private Sub BtnGoToReporter_Click(sender As Object, e As EventArgs) Handles BtnGoToReporter.Click
        'go to reporter and Add another Reporter to be part of the ticket list 

        If Reporters.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim reporter As ClassesReporter = CType(Reporters.Tag, ClassesReporter)
            If reporter.Reporterdepartment = "" Or reporter.ReporterlastName = "" Or reporter.Reporteremail = "" _
               Or reporter.ReporterfirstName = "" Then
                MessageBox.Show("show please enter a value for the name")

            End If
            Dim newReporterInsertSQL As String = "insert into Reporters values (@ReporterFirstName, @ReporterLastName, @ReporterEmail, @department)"
            Dim sqlAddReporterViaTickeCommand As New SqlCommand(newReporterInsertSQL, Ticketconnection)
            sqlAddReporterViaTickeCommand.Parameters.AddWithValue("@ReporterFirstName", reporter.ReporterfirstName)
            sqlAddReporterViaTickeCommand.Parameters.AddWithValue("@ReporterLastName", reporter.ReporterlastName)
            sqlAddReporterViaTickeCommand.Parameters.AddWithValue("@ReporterEmail", reporter.Reporteremail)
            sqlAddReporterViaTickeCommand.Parameters.AddWithValue("@department", reporter.Reporterdepartment)
            Try
                Ticketconnection.Open()
                sqlAddReporterViaTickeCommand.ExecuteNonQuery()
                Ticketconnection.Close()

                MessageBox.Show("New Reporter Has been add, reload the reporter of issue to see reporter added to create new tickets")

            Catch se As SqlException

                If se.Number = 2627 Then
                    MessageBox.Show("this user email already exists, try again")
                End If
            End Try
        End If
    End Sub

    Private Sub btn_selecttictoresolve_Click(sender As Object, e As EventArgs) Handles btn_selecttictoresolve.Click
        MessageBox.Show("this ticket will be updated you will need to select a ticket to update", "update", MessageBoxButtons.OKCancel)
        'this will update the ticket from unresolved to completed

        Dim objworkcompletedbytechadapter As String = "Update Tickets set DescriptionWorkDone = '" + txtWorkDone.Text + "', resolved = 'resolved', Date_Completed = GetDate() where TicketID = " + cboselectedtick.Text
        updatecompletedticket = New SqlCommand(objworkcompletedbytechadapter, Ticketconnection)
        Try

            Ticketconnection.Open()
            updatecompletedticket.ExecuteNonQuery()
            Ticketconnection.Close()
        Catch ex As Exception
            If txtWorkDone.Text = "" Then
                MessageBox.Show("please enter a value")
            End If
        End Try
        'Me.ListViewAssignedticswithretecchs.View = View.Details
        'Me.ListViewAssignedticswithretecchs.GridLines = True
        'Dim strQ5 As String = String.Empty
        'strQ5 = "Update Tickets set DescriptionWorkDone = '" + txtWorkDone.Text + "', resolved = 'resolved', Date_Completed = GetDate() where TicketID = " + cboselectedtick.Text

        'cmd5 = New SqlCommand(strQ5, Ticketconnection)
        'Da5 = New SqlDataAdapter(cmd5)

        'Ds5 = New DataSet
        'Da5.Fill(Ds5)
        'Ticketconnection.Open()
        'cmd5.ExecuteNonQuery()

        'Dim p As Integer = 0
        'Dim q As Integer = 0

        'For p = 0 To Ds5.Tables(0).Columns.Count - 1
        '    Me.ListViewAssignedticswithretecchs.Columns.Add(Ds5.Tables(0).Columns(p).ColumnName.ToString())

        'Next

        ''addin itmes to technicans name list view
        'For p = 0 To Ds5.Tables(0).Rows.Count - 1

        '    For q = 0 To Ds5.Tables(0).Columns.Count - 1
        '        itemColl5(q) = Ds5.Tables(0).Rows(p)(q).ToString()

        '    Next
        '    Dim lvi5 As New ListViewItem(itemColl5)
        '    Me.ListViewAssignedticswithretecchs.Items.Add(lvi5)

        '    Me.ListViewAssignedticswithretecchs.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        'Next
        'Ticketconnection.Close()

    End Sub

    Private Sub txtWorkDone_TextChanged(sender As Object, e As EventArgs) Handles txtWorkDone.TextChanged
        'Dim selectedIDtoUpdateAdapter As New SqlDataAdapter("Select TicketID from Tickets where resolved = 'unresolved'", Ticketconnection)
        'Dim selectedIdtoUpdatedatatable As New DataTable()
        'selectedIDtoUpdateAdapter.Fill(selectedIdtoUpdatedatatable)
        'cboselectedtick.DataSource = selectedIdtoUpdatedatatable
        'Dim selectiD As String = "TicketID"
        'cboselectedtick.DisplayMember = selectiD
        'cboselectedtick.ValueMember = selectiD
        'selectordisplayticketReporterProblem(cboselectedtick, "there is nothing to load for tickets")

        'If txtWorkDone.Text = "" Then
        '    MessageBox.Show("Please enter a value for work completed")

        'End If

        'Dim objworkcompletedbytechadapter As String = "update Tickets set DescriptionWorkDone = " + txtWorkDone.Text + ", resolved = 'resolved', Date_Completed = " + Date.Now.ToShortDateString() + " where TicketID = " + cboselectedtick.Text
        'Dim updatecompletedticket As New SqlCommand(objworkcompletedbytechadapter, Ticketconnection)
        'Ticketconnection.Open()
        'updatecompletedticket.ExecuteNonQuery()
        'Ticketconnection.Close()


    End Sub

    Private Sub btn_ViewSelectedTicket_Click(sender As Object, e As EventArgs) Handles btn_ViewSelectedTicket.Click
        'it is good idea to update the select ticket or have it refreshed when we go to view select ticket
        cboselectedtick.Refresh()
        'cboselectedtick.Update()

        'Dim selectedIDtoUpdateAdapter As New SqlDataAdapter("Select TicketID from Tickets where resolved = 'unresolved'", Ticketconnection)
        'Dim selectedIdtoUpdatedatatable As New DataTable()
        'selectedIDtoUpdateAdapter.Fill(selectedIdtoUpdatedatatable)
        'cboselectedtick.DataSource = selectedIdtoUpdatedatatable
        'Dim selectiD As String = "TicketID"
        'cboselectedtick.DisplayMember = selectiD
        'cboselectedtick.ValueMember = selectiD
        'selectordisplayticketReporterProblem(cboselectedtick, "there is nothing to load for tickets")

        'ListViewAssignedticswithretecchs.Clear()

        MessageBox.Show("Clearing the selected tables and then putting the inforamation back on the table by selected tehnican and open tickets")

        'objUnresolvedTicsAssignedToTechDataAdapter = New SqlDataAdapter("Select * from Tickets i inner join TechnicanTicket e on e.TicketID = i.TicketID inner join Technicans a on e.TechID = a.TechID where TechID = " + ComboBox1.Text + " and i.resolved = 'unresolved' order by PriorityStatus Desc", Ticketconnection)
        'objUnresolvedTicsAssignedToTechDataAdapter.Fill(objUnresolvedTicsAssignedToTechTabe)
        'DataGridViewTicketsunresolvedbutassignedtotech.DataSource = objUnresolvedTicsAssignedToTechTabe
        Me.ListViewAssignedticswithretecchs.View = View.Details
        Me.ListViewAssignedticswithretecchs.GridLines = True
        Dim strQ5 As String = String.Empty
        'we are setting tickets as unresolved that we want to see , not updating just seeing 
        'unresolved tickets
        'then we are running through the listview once again.
        strQ5 = "Select * from Tickets where TicketID = " + cboselectedtick.Text + " and resolved = 'unresolved'"
        cmd5 = New SqlCommand(strQ5, Ticketconnection)
        Da5 = New SqlDataAdapter(cmd5)
        Ds5 = New DataSet
        Da5.Fill(Ds5)
        Dim p As Integer = 0
        Dim q As Integer = 0

        For p = 0 To Ds5.Tables(0).Columns.Count - 1
            Me.ListViewAssignedticswithretecchs.Columns.Add(Ds5.Tables(0).Columns(p).ColumnName.ToString())

        Next

        'addin itmes to technicans name list view
        For p = 0 To Ds5.Tables(0).Rows.Count - 1



            For q = 0 To Ds5.Tables(0).Columns.Count - 1
                itemColl5(q) = Ds5.Tables(0).Rows(p)(q).ToString()
            Next

            Dim lvi5 As New ListViewItem(itemColl5)
            Me.ListViewAssignedticswithretecchs.Items.Add(lvi5)

            Me.ListViewAssignedticswithretecchs.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)


        Next

    End Sub

   
    Private Sub btn_GotoAddTech_Click(sender As Object, e As EventArgs) Handles btn_GotoAddTech.Click

        'this goes to add tech form based on the example from the Coffeeshop program 
        If TechnicanGui.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim technican As classesTechnicans = CType(TechnicanGui.Tag, classesTechnicans)
            If technican.Techfirstname = "" Or technican.Techlastname = "" Or technican.Technicanjob = "" _
               Or technican.Techemail = "" Then
                MessageBox.Show("show please enter a value for the name")
                'we do not want null values for new created techncians because we are going to want to email them as well
                '
            End If
            Dim newTechInsertSQL As String = "insert into technicans values (@TechFirstName, @TechLastName, @techemail, @technican_type)"
            Dim sqladdTechViaTickeCommand As New SqlCommand(newTechInsertSQL, Ticketconnection)
            sqladdTechViaTickeCommand.Parameters.AddWithValue("@TechFirstName", technican.Techfirstname)
            sqladdTechViaTickeCommand.Parameters.AddWithValue("@TechLastName", technican.Techlastname)
            sqladdTechViaTickeCommand.Parameters.AddWithValue("@Techemail", technican.Techemail)
            sqladdTechViaTickeCommand.Parameters.AddWithValue("@technican_type", technican.Technicanjob)
            Try
                Ticketconnection.Open()
                sqladdTechViaTickeCommand.ExecuteNonQuery()
                Ticketconnection.Close()

                MessageBox.Show("New Technican Has been added, reload the technincs of issue to see technican added to assign open tickets")

            Catch se As SqlException
                'looking for where the user email already exists 
                If se.Number = 2627 Then
                    MessageBox.Show("this user email already exists, try again")
                End If
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'this is selecting to view the resolved tickets
        Me.ListView1.View = View.Details
        Me.ListView1.GridLines = True
        Dim strQ2 As String = String.Empty
        'Insert into resolvedticketArchivies select * from tickets where resolved = 'resolved'
        strQ2 = "Select * From Tickets where resolved = 'resolved'"
        cmd6 = New SqlCommand(strQ2, Ticketconnection)
        Da6 = New SqlDataAdapter(cmd6)
        ds6 = New DataSet
        Ticketconnection.Open()
        Da6.Fill(ds6, "Tickets")
        Dim i As Integer = 0
        Dim j As Integer = 0

        For i = 0 To ds6.Tables(0).Columns.Count - 1
            Me.ListView1.Columns.Add(ds6.Tables(0).Columns(i).ColumnName.ToString())

        Next

        'addin itmes to technicans list view
        For i = 0 To ds6.Tables(0).Rows.Count - 1

            For j = 0 To ds6.Tables(0).Columns.Count - 1
                itemColl6(j) = ds6.Tables(0).Rows(i)(j).ToString()

            Next
            Dim lvi6 As New ListViewItem(itemColl6)
            Me.ListView1.Items.Add(lvi6)

            Me.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

        Next
        Ticketconnection.Close()

        'attempting to insert into the archives table but Iam having problems 
        'because not all values are delt with and there for not being shown 
        Dim Ba7 As New SqlDataAdapter()
        Dim Bs7 As New DataSet
        Dim innsertcommand As String = "Insert into resolvedticketArchivies select * from tickets where resolved = 'resolved'"
        Dim insertintoarchive As New SqlCommand(innsertcommand, Ticketconnection)
        Ba7 = New SqlDataAdapter(insertintoarchive)
        Ba7.Fill(Bs7, "Tickets")
        Ticketconnection.Open()
        insertintoarchive.ExecuteNonQuery()
        Ticketconnection.Close()
        
   End sub


    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        'time to close this program out
        Close()
    End Sub
End Class


