Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class Reporters
    'this is the form dealing with the connection string 
    Dim ConnectionString As New SqlConnection("server=HARRY-HP\SQLEXPRESS;database=ticketmanager;Trusted_Connection=Yes")

    Dim bindingSource As New BindingSource()
    'adapter for the reporter names
    Dim objReporterDataAdapter As SqlDataAdapter
    'for table for the reporter names
    Dim objReporterDataTable As New DataTable()
    'another table for reporter names
    Dim objReporterNamesTables As New DataTable()
    Dim objDepNameAdapter As SqlDataAdapter
    'this is the department data adapter
    Dim objDepTables As New DataTable()




    Private Sub Reporters_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'updating the reporters table 
        lstReporters.Update()
        cboCategoriesReporters.Update()
        CboReportersreporterform.Update()

        'this load the Reporter on the current reporters page
        objReporterDataAdapter = New SqlDataAdapter("select ReporterFirstName  + '-' + ReporterLastName  as name From Reporters", ConnectionString)
        objReporterDataAdapter.Fill(objReporterNamesTables)
        CboReportersreporterform.DataSource = objReporterNamesTables
        Dim ReporterNameColumn As String = "name"
        CboReportersreporterform.DisplayMember = ReporterNameColumn
        CboReportersreporterform.ValueMember = ReporterNameColumn

        selectordisplayProblem(CboReportersreporterform, "No Reporter were found. YOU need to add a Reporter")

        'this loads the current departcategories from where a probblem was reported 
        objDepNameAdapter = New SqlDataAdapter("Select department From Reporters", ConnectionString)
        objDepNameAdapter.Fill(objDepTables)
        cboCategoriesReporters.DataSource = objDepTables

        Dim DepartementCategory As String = "department"
        cboCategoriesReporters.DisplayMember = DepartementCategory
        cboCategoriesReporters.ValueMember = DepartementCategory
        selectordisplayProblem(cboCategoriesReporters, "No departments were found.")

    End Sub

    Private Sub selectordisplayProblem(comboBox As ComboBox, errorMessage As String)

        If comboBox.Items.Count > 0 Then
            comboBox.SelectedIndex = 0
        Else
            MessageBox.Show(errorMessage)
            comboBox.Enabled = False
            'this to check to make sure that data is actually in the table 
        End If
    End Sub

    'Dim 
    
    Private Sub BtnAddReporter_Click(sender As Object, e As EventArgs) Handles BtnAddReporter.Click
        'this string adds a new reporter to the database 
        Dim NewReporterFirstName As String = txtReporterFNam.Text
        Dim NewReporterLastName As String = txtreporterLname.Text
        Dim NewReporterDepartment As String = ComboDeps.Text
        Dim NewReporterEmail As String = txtreporteremail.Text
        'up load a picture later 
        'this is the new reporter which is calling the ClassReporter 
        Dim NewReporter As New ClassesReporter()
        NewReporter.ReporterfirstName = NewReporterFirstName
        NewReporter.ReporterlastName = NewReporterLastName
        NewReporter.Reporterdepartment = NewReporterDepartment
        NewReporter.Reporteremail = NewReporterEmail

        'again the security asspect of creating parameters is a good level of protection for inserting values
        Dim NewReporterSQLInsert As String = "insert into Reporters values (@ReporterFirstName, @ReporterLastName, @ReporterEmail, @department)"
        Dim NewReporterSQLInsertcommand As New SqlCommand(NewReporterSQLInsert, ConnectionString)

        NewReporterSQLInsertcommand.Parameters.AddWithValue("@ReporterFirstName", NewReporter.ReporterfirstName)
        NewReporterSQLInsertcommand.Parameters.AddWithValue("@ReporterLastName", NewReporter.ReporterlastName)
        NewReporterSQLInsertcommand.Parameters.AddWithValue("@ReporterEmail", NewReporter.Reporteremail)
        NewReporterSQLInsertcommand.Parameters.AddWithValue("@department", NewReporter.Reporterdepartment)

        ConnectionString.Open()
        NewReporterSQLInsertcommand.ExecuteNonQuery()
        ConnectionString.Close()
        MessageBox.Show("Added new Reporter - yyou can confimrm in the listbox")

        'i used this code to add what I have as guidance into a listbox
        'https://www.daniweb.com/software-development/vbnet/threads/314291/populate-a-listbox-using-a-sql-database
        lstReporters.ClearSelected()
        'http://stackoverflow.com/questions/14597595/populating-listbox-with-data-from-sql-server

        'Dim ReportlistrefreshAndAdd As New SqlCommand("SELECT Cast(ReporterID as varchar) + ': ' + ReporterLastName + ', ' + ReporterFirstName as 'ID and reporter Name' From Reporters",
        '                                              ConnectionString)
        ' '' ''Dim cmd As String = "SELECT ReporterID, ReporterFirstName, ReporterLastName From Reporters"
        ' ''Dim adpt As New SqlDataAdapter(cmd, ConnectionString)
        ' ''Dim myDataReportersTable As New DataSet()
        ' ''adpt.Fill(myDataReportersTable, "dbo.Reporters")
        ' ''Dim myDataTable As DataTable = myDataReportersTable.Tables(0)
        ' ''Dim tempRow As DataRow
        ' ''For Each tempRow In myDataTable.Rows
        ' ''    lstReporters.Items.Add((tempRow("ReporterID") + tempRow("ReporterFirstName")))
        ' ''Next
        'Dim reporterReader As SqlDataReader
        'ConnectionString.Open()

        'reporterReader = ReportlistrefreshAndAdd.ExecuteReader(CommandBehavior.CloseConnection)
        ''lstReporters.Items.Add("Reporter ID" + ", " + "Reporter First Name" + ", " + "Reporter Last Name")
        'While reporterReader.Read()
        '    lstReporters.Items.Add(reporterReader.Item("ID and reporter Name"))



        '    'lstReporters.Items.Add(reporterReader.Item("ReporterID") + reporterReader.Item("ReporterFirstName") + reporterReader.Item("ReporterLastName"))

        'End While
        'reporterReader.Close()

        'we need to edit and reset values and refresh the cboboxes etc. 
        ConnectionString.Close()

        txtReporterFNam.Clear()
        txtreporterLname.Clear()
        txtreporteremail.Clear()
        ActiveControl = txtReporterFNam
        cboCategoriesReporters.Refresh()
        CboReportersreporterform.Refresh()

    End Sub


    Private Sub BtnVeiwReporter_Click(sender As Object, e As EventArgs) Handles BtnVeiwReporter.Click

        'Dim ReportlistrefreshAndAdd As New SqlCommand("SELECT Cast(ReporterID as varchar) + ': ' + ReporterLastName + ', ' + ReporterFirstName as 'ID and reporter Name' From Reporters",
        '                                              ConnectionString)
        ' '' ''Dim cmd As String = "SELECT ReporterID, ReporterFirstName, ReporterLastName From Reporters"
        ' ''Dim adpt As New SqlDataAdapter(cmd, ConnectionString)
        ' ''Dim myDataReportersTable As New DataSet()
        ' ''adpt.Fill(myDataReportersTable, "dbo.Reporters")
        ' ''Dim myDataTable As DataTable = myDataReportersTable.Tables(0)
        ' ''Dim tempRow As DataRow
        ' ''For Each tempRow In myDataTable.Rows
        ' ''    lstReporters.Items.Add((tempRow("ReporterID") + tempRow("ReporterFirstName")))
        ' ''Next
        'Dim reporterReader As SqlDataReader
        'ConnectionString.Open()

        'reporterReader = ReportlistrefreshAndAdd.ExecuteReader(CommandBehavior.CloseConnection)
        'lstReporters.Items.Add("Reporter ID and Name")

        'While reporterReader.Read()
        '    lstReporters.Items.Add(reporterReader.Item("ID and reporter Name"))



        '    'lstReporters.Items.Add(reporterReader.Item("ReporterID") + reporterReader.Item("ReporterFirstName") + reporterReader.Item("ReporterLastName"))

        'End While
        'reporterReader.Close()

        'this is the other way to get information into a list

        'this the loading a string concatenation from for viewing our string in the list
        ' the first and only time I used a list. the problem with lists compared to listviews is that they were 
        'no very good choices for seeing the data at handd.

        Dim cmd As String = "SELECT cast(ReporterID as varchar) + ': ' + ReporterLastName + ', ' + ReporterFirstName as 'Id and Name' From Reporters"
        'You need to concatenate the sql statement and cast the reporter ID as varchar else you will only be able to add
        'one elemet at a time.
        Dim adpt As New SqlDataAdapter(cmd, ConnectionString)
        Dim myDataReportersTable As New DataSet()
        adpt.Fill(myDataReportersTable, "dbo.Reporters")
        Dim myDataTable As DataTable = myDataReportersTable.Tables(0)
        Dim tempRow As DataRow
        lstReporters.Items.Add("ID: Reporter Name")
        For Each tempRow In myDataTable.Rows
            lstReporters.Items.Add((tempRow("Id and Name")))
        Next
        ConnectionString.Close()

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'this button is also adding a new reporter is being called from the openticket 
        Dim reporterFirstName As String = txtReporterFNam.Text
        Dim reporterLastName As String = txtreporterLname.Text
        Dim reporterEmail As String = txtreporteremail.Text
        Dim reportDep As String = ComboDeps.Text
        'this is checking to make sure that no part of what we need for the reporter is left un satisfied 
        If reporterFirstName = "" Or reporterEmail = "" Or reporterEmail = "" Or reportDep = "" Then
            MessageBox.Show("Please Enter alll the data")

        End If
        ' this calling the new reporter class 
        Dim newRepor As New ClassesReporter()
        newRepor.ReporterfirstName = reporterFirstName
        newRepor.ReporterlastName = reporterLastName
        newRepor.Reporteremail = reporterEmail
        newRepor.Reporterdepartment = reportDep

        Tag = newRepor
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub btnReporterPicture_Click(sender As Object, e As EventArgs) Handles btnReporterPicture.Click
        ImageForm.ShowDialog()
        'this is opening the reporter picture button 
    End Sub

    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click
        EmailingUpdatetoReporter.ShowDialog()
        'this oping the email reporter form
    End Sub
End Class
' myconnection = New SqlConnection("server=NXT\SQLEXPRESS;uid=;pwd=;database=shop;Integrated security=true")
'04
'    sql = "INSERT INTO stock VALUES('" & TextBox2.Text & "','" & ListBox3.SelectedItem & "','" & TextBox3.Text & "')"
'05
'    myconnection.Open()
'06
'    adapter.InsertCommand = New SqlCommand(sql, myconnection)
'07
'    adapter.InsertCommand.ExecuteNonQuery()
'08
'    MsgBox("Member added successfully...!! ")
'09

'10
'    dr = mycommand.ExecuteReader()
'11

'12
'    While dr.Read()
'13
'        ListBox1.BeginUpdate()
'14
'        ListBox1.Items.Add(dr.Item("base"))
'15
'        ListBox1.EndUpdate()
'16
'    End While
'17
'    dr.Close()
'18

'19

'20
'End Sub
