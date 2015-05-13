Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.OleDb
Imports System.IO

Public Class TechnicanGui

    Dim Connectiontechnicanstring As New SqlConnection("server=HARRY-HP\SQLEXPRESS;database=ticketmanager;Trusted_Connection=Yes")

    'these are some of our guidelines that we are going to want to load for running of this program 
    Dim bindingSource As New BindingSource()
    Dim objTechnicanDataAdapter As SqlDataAdapter
    Dim objTechnicanDataTable As New DataTable()
    'Dim objTechnicanDepartDataAdapter As SqlDataAdapter
    'Dim objTechnicanDepartTable As New DataTable()

    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim itemcoll(100) As String

    Private Sub TechnicanGui_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'these are the  comboboxes and listboxes that I am going to want to load update or refresh when 
        'the technicanGui is loaded up
        objTechnicanDataAdapter = New SqlDataAdapter("select TechID from Technicans", Connectiontechnicanstring)
        objTechnicanDataAdapter.Fill(objTechnicanDataTable)
        CboCurrentTechnicans.DataSource = objTechnicanDataTable
        Dim TechnicanIndividual As String = "TechID"
        CboCurrentTechnicans.DisplayMember = TechnicanIndividual
        CboCurrentTechnicans.ValueMember = TechnicanIndividual
        selectordisplayProblem(CboCurrentTechnicans, "no technicans were found")

        ListViewTechnicanswithUnresolvedtics.Update()
        CboCurrentTechnicans.Update()

        'objTechnicanDepartDataAdapter = New SqlDataAdapter("select Technican_type From Technicans", Connectiontechnicanstring)
        'objTechnicanDataAdapter.Fill(objTechnicanDepartTable)

    End Sub
    Private Sub selectordisplayProblem(comboBox As ComboBox, errorMessage As String)

        If comboBox.Items.Count > 0 Then
            comboBox.SelectedIndex = 0
        Else
            MessageBox.Show(errorMessage)
            comboBox.Enabled = False
            'checking to make sure our comboboxes are loaded and ready to go 
        End If
    End Sub
    'Sub FillListview()
    '    ListViewTechnicanswithUnresolvedtics.Items.Clear()
    '    'myqry = "SELECT AccResult.StudNo,AccResult.CNumber,AccResult.FirstName,AccResult.LastName,AccResult.YrandSec,Exercises.Exer1,Exercises.Exer2,Exercises.Exer3,Exercises.Exer4,Exercises.Exer5 from AccResult INNER JOIN Exercises ON AccResult.StudNo = Exercises.StudNo ORDER BY AccResult.FirstName,AccResult.YrandSec Asc;"
    '    Dim displayalltech As String = "Select cast(TechID as varchar) + ': ' + TechLastName + '-' + TechFirstName + ' email:' + Technemail + ' Job: ' + Technican_type as techs from Technicans order by technican_type"
    '    Dim mycmd As New SqlCommand(displayalltech, Connectiontechnicanstring)
    '    Dim mydr As New SqlDataReader
    '    Connectiontechnicanstring.Open()
    '    mydr.ExecuteReader()
    '    While mydr.Read
    '        With LV
    '            .Items.Add(mydr("StudNo"))
    '            With .Items(.Items.Count - 1).SubItems
    '                .Add(mydr("CNumber"))
    '                .Add(mydr("FirstName"))
    '                .Add(mydr("LastName"))
    '                .Add(mydr("YrandSec"))
    '                .Add(mydr("Exer1"))
    '                .Add(mydr("Exer2"))
    '                .Add(mydr("Exer3"))
    '                .Add(mydr("Exer4"))
    '                .Add(mydr("Exer5"))
    '            End With
    '        End With
    '    End While
    '    con.Close()
    'End Sub
    Private Sub btnDisplayAllTechs_Click(sender As Object, e As EventArgs) Handles btnDisplayAllTechs.Click

        'this is the buttton for displaying all of the techs and we going to want to clear the listview and then 
        'reload the page again.
        ListViewTechnicanswithUnresolvedtics.Clear()

        'https://www.daniweb.com/software-development/vbnet/threads/357118/populating-listview-using-database
        'the code is adapted form the above web site for lines 75 via 101
        Me.ListViewTechnicanswithUnresolvedtics.View = View.Details
        Me.ListViewTechnicanswithUnresolvedtics.GridLines = True
        Dim strQ As String = String.Empty
        'I this a concatenatiion of the string with the sqlcomand 
        strQ = "Select cast(TechID as varchar) + ': ' + TechLastName + '-' + TechFirstName + ' email:' + Techemail + ' Job: ' + Technican_type as 'technican Infomation' from Technicans order by technican_type"
        'strQ = "Select TechLastName + '-' + TechFirstName as 'Complete Tech' From Technicans"
        cmd = New SqlCommand(strQ, Connectiontechnicanstring)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "Technicans")
        Dim i As Integer = 0
        Dim j As Integer = 0

        For i = 0 To ds.Tables(0).Columns.Count - 1
            Me.ListViewTechnicanswithUnresolvedtics.Columns.Add(ds.Tables(0).Columns(i).ColumnName.ToString())

        Next

        'addin itmes to technicans list view
        For i = 0 To ds.Tables(0).Rows.Count - 1

            For j = 0 To ds.Tables(0).Columns.Count - 1
                itemcoll(j) = ds.Tables(0).Rows(i)(j).ToString()

            Next
            Dim lvi As New ListViewItem(itemcoll)
            Me.ListViewTechnicanswithUnresolvedtics.Items.Add(lvi)

            Me.ListViewTechnicanswithUnresolvedtics.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

        Next
        Connectiontechnicanstring.Close()
    End Sub

    Private Sub btnAddNewTechnican_Click(sender As Object, e As EventArgs) Handles btnAddNewTechnican.Click
        'we are directly adding a technican from the Techncian gui
        Dim TechnicianFirstName As String = txtTechFirstName.Text
        Dim TechnicanLastName As String = txtTechLastName.Text
        Dim TechnicanDepartment As String = CboTechnicansJob.Text
        Dim TechnicanEmail As String = txtTechemail.Text
        'we are utiliziing the the class of technincas 
        Dim newTechnican As New classesTechnicans()
        newTechnican.Techfirstname = TechnicianFirstName
        newTechnican.Techlastname = TechnicanLastName
        newTechnican.Technicanjob = TechnicanDepartment
        newTechnican.Techemail = TechnicanEmail

        'again these the ways to enter vaules along the way of Sqlsever 
        Dim NewTechSQLinsert As String = "Insert into technicans values (@TechFirstName, @TechLastName, @Techemail, @Technican_type)"
        Dim NewTechinsertSqlCommand As New SqlCommand(NewTechSQLinsert, Connectiontechnicanstring)

        NewTechinsertSqlCommand.Parameters.AddWithValue("@TechFirstName", newTechnican.Techfirstname)
        NewTechinsertSqlCommand.Parameters.AddWithValue("@TechLastName", newTechnican.Techlastname)
        NewTechinsertSqlCommand.Parameters.AddWithValue("@Techemail", newTechnican.Techemail)
        NewTechinsertSqlCommand.Parameters.AddWithValue("@Technican_type", newTechnican.Technicanjob)

        Connectiontechnicanstring.Open()
        NewTechinsertSqlCommand.ExecuteNonQuery()
        Connectiontechnicanstring.Close()
        MessageBox.Show("Added new Technican into the Table. you can see by clicking View")
        'we want to update the form 
        ListViewTechnicanswithUnresolvedtics.Update()

        CboCurrentTechnicans.Update()
        txtTechFirstName.Clear()
        txtTechLastName.Clear()
        txtTechemail.Clear()
        CboCurrentTechnicans.Refresh()
        ActiveControl = txtTechFirstName
    End Sub

    Private Sub BtnSelectTech_Click(sender As Object, e As EventArgs) Handles BtnSelectTech.Click

        'this is form viewing the selected tech id 
        ListViewTechnicanswithUnresolvedtics.Clear()
        'https://www.daniweb.com/software-development/vbnet/threads/357118/populating-listview-using-database
        'i used this site again for the following code for a listView 
        'my reason for the list view was so that one cant monkey with list like one can with a list box

        Me.ListViewTechnicanswithUnresolvedtics.View = View.Details
        Me.ListViewTechnicanswithUnresolvedtics.GridLines = True
        Dim strQ2 As String = String.Empty
        strQ2 = "Select TechID, TechLastName + '-' + TechFirstName as 'Technican', technican_type from Technicans where TechID = " + CboCurrentTechnicans.Text.ToString()
        cmd = New SqlCommand(strQ2, Connectiontechnicanstring)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "Technicans")
        Dim i As Integer = 0
        Dim j As Integer = 0

        For i = 0 To ds.Tables(0).Columns.Count - 1
            Me.ListViewTechnicanswithUnresolvedtics.Columns.Add(ds.Tables(0).Columns(i).ColumnName.ToString())

        Next

        'addin itmes to technicans list view
        For i = 0 To ds.Tables(0).Rows.Count - 1

            For j = 0 To ds.Tables(0).Columns.Count - 1
                itemcoll(j) = ds.Tables(0).Rows(i)(j).ToString()

            Next
            Dim lvi As New ListViewItem(itemcoll)
            Me.ListViewTechnicanswithUnresolvedtics.Items.Add(lvi)

            Me.ListViewTechnicanswithUnresolvedtics.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

        Next
        'Viewing the Tech Image of the CurrentTechnican who will work on the project

        'cmd = New SqlCommand("Select Techpic from TechnicanImage where TechID = " + CboCurrentTechnicans.Text)

        'Dim imageData As Byte() = DirectCast(cmd.ExecuteScalar(), Byte())
        'If Not imageData Is Nothing Then

        '    Using ms As New MemoryStream(imageData, 0, imageData.Length)
        '        ms.Write(imageData, 0, imageData.Length)
        '        PictureBox1.BackgroundImage = Image.FromStream(ms, True)


        '    End Using
        'End If

        Connectiontechnicanstring.Close()
    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        'this returns to the main
        MainMenu.ShowDialog()
        Close()
    End Sub

    Private Sub btnEmailTech_Click(sender As Object, e As EventArgs) Handles btnEmailTech.Click
        'this is the code for emailing attaching a list to a client
        'https://support.microsoft.com/en-us/kb/313803

        ' Create an Outlook application.
        'Dim oApp As Outlook._Application
        'oApp = New Outlook.Application()

        '' Create a new MailItem.
        'Dim oMsg As Outlook._MailItem
        'oMsg = oApp.CreateItem(Outlook.OlItemType.olMailItem)
        'oMsg.Subject = "Send Attachment Using OOM in Visual Basic .NET"
        'oMsg.Body = "Hello World" & vbCr & vbCr

        '' TODO: Replace with a valid e-mail address.
        'oMsg.To = "user@example.com"

        '' Add an attachment
        '' TODO: Replace with a valid attachment path.
        'Dim sSource As String = "C:\Temp\Hello.txt"
        '' TODO: Replace with attachment name
        'Dim sDisplayName As String = "Hello.txt"

        'Dim sBodyLen As String = oMsg.Body.Length
        'Dim oAttachs As Outlook.Attachments = oMsg.Attachments
        'Dim oAttach As Outlook.Attachment
        'oAttach = oAttachs.Add(sSource, , sBodyLen + 1, sDisplayName)

        '' Send
        'oMsg.Send()

        '' Clean up
        'oApp = Nothing
        'oMsg = Nothing
        'oAttach = Nothing
        'oAttachs = Nothing

        'this ended up not being used I emailed techlink from the open form window
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'head to the image form to pull an image.
        ImageForm.ShowDialog()
        Close()

    End Sub

    Private Sub Btn_DeleteTech_Click(sender As Object, e As EventArgs) Handles Btn_DeleteTech.Click
        'this deletes the technican from the list
        If CboCurrentTechnicans.Text = "" Then
            MessageBox.Show("You need to select a technican of whom to delete")
        End If
        'this is the set uup for delecting a Tech for what ever reason
        Dim cmdDelete As New SqlCommand("Delete Technicans Where TechID = " + CboCurrentTechnicans.Text, Connectiontechnicanstring)
        Connectiontechnicanstring.Open()
        cmdDelete.ExecuteNonQuery()
        Connectiontechnicanstring.Close()

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'this is the form that is accessed and updated from the openticket whne then when clicked is closed and then
        'the tech form is reopened 
        Dim techFirstName As String = txtTechFirstName.Text
        Dim techLastName As String = txtTechLastName.Text
        Dim techEmail As String = txtTechemail.Text
        Dim techjob As String = CboTechnicansJob.Text


        If techFirstName = "" Or techLastName = "" Or techEmail = "" Or techjob = "" Then
            MessageBox.Show("Please Enter alll the data")

        End If

        Dim newTech As New classesTechnicans()
        newTech.Techfirstname = techFirstName
        newTech.Techlastname = techLastName
        newTech.Techemail = techEmail
        newTech.Technicanjob = techjob

        Tag = newTech
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'this where addiing the image would go but I ran into problems on that front
        Dim ds As New DataSet
        Dim adp As New SqlDataAdapter
        Dim con As New SqlClient.SqlConnection
        'Private Sub Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        adp = New SqlDataAdapter("select Emp_Image from Employees where Emp_UserId=106", con)
        Connectiontechnicanstring.Open()
        adp.Fill(ds)
        'PictureBox1.Image = ds.Tables(0).Rows(0)
    End Sub
    ' End Sub
End Class