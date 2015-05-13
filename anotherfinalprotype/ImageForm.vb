Imports System.Data.SqlClient
Imports System.IO

Public Class ImageForm
    'this ithe pathe that I used for adding an image to vb..net
    Dim path As String = (Microsoft.VisualBasic.Left(Application.StartupPath, Len(Application.StartupPath) - 9))
    Dim con As New SqlConnection("server=HARRY-HP\SQLEXPRESS;database=ticketmanager;Trusted_Connection=Yes")
    Dim cmd As New SqlCommand(path, con)
    'these are some of the adapters that I used for the image
    Dim informationTableAdapter As New SqlDataAdapter


    Dim reporterIDadapter As New SqlDataAdapter
    Dim reporterIDDtable As New DataTable()
    Dim TechIdadpater As New SqlDataAdapter
    Dim tecIDtabel As New DataTable()
    Private Sub Btn_browseImages_Click(sender As Object, e As EventArgs) Handles Btn_browseImages.Click
        'i needed an openFile dialog to load an image into table 
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PicImage.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            Label3.Visible = True
            TextBox1.Visible = True
            Label3.Text = "Name"
            TextBox1.Clear()

        End If

    End Sub

    Private Sub ImageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'this loading the image 
        reporterIDadapter = New SqlDataAdapter("select ReporterID from Reporters", con)
        reporterIDadapter.Fill(reporterIDDtable)
        ComboReportID.DataSource = reporterIDDtable
        Dim reproID As String = "reporterID"
        ComboReportID.DisplayMember = reproID
        ComboReportID.ValueMember = reproID

        TechIdadpater = New SqlDataAdapter("select TechID from Technicans", con)
        TechIdadpater.Fill(tecIDtabel)
        CboTechID.DataSource = tecIDtabel
        Dim tecid As String = "TechID"
        CboTechID.DisplayMember = tecid
        CboTechID.ValueMember = tecid


        Me.informationTableAdapter.Fill(DataSet1)

        con.Open()
        con.Close()


    End Sub


    Private Sub btn__AddtoReporters_Click(sender As Object, e As EventArgs) Handles btn__AddtoReporters.Click
        'this is adding reporters menu 
        Dim newtic As New ClassesReporter()
        newtic.ReporterID = CInt(ComboReportID.Text)

        If TextBox1.Text = "" Then
            MessageBox.Show("fill the Name Field")
        Else
            'this tthe es that sql will run 
            Dim sql As String = "Insert Into reporterimage values (@reportercaption, @reporterpicture" &
                "(select ReporterID from Reporters where ReporterID = @ReporterID))"
            Dim cmd As New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@reportercaption", TextBox1.Text)
            Dim ms As New MemoryStream()
            'I had issues right about here on in pulling data into the picture 
            PicImage.BackgroundImage.Save(ms, PicImage.BackgroundImage.RawFormat)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@reporterpicture", SqlDbType.Image)
            p.Value = data
            cmd.Parameters.Add(p)
            con.Open()

            MessageBox.Show("Name & Image has been saved", "Save", MessageBoxButtons.OK)
            Label3.Visible = False
            TextBox1.Visible = False

            cmd.Parameters.AddWithValue("@ReporterID", newtic.ReporterID)
            cmd.ExecuteNonQuery()

        End If
        con.Close()

    End Sub

    Private Sub btn_AddtoTechimagestable_Click(sender As Object, e As EventArgs) Handles btn_AddtoTechimagestable.Click
        Dim newtic As New classesTechnicans()
        newtic.IdTechs = CInt(CboTechID.Text)
        ' I had the same problem the technican image as well 

        If TextBox1.Text = "" Then
            MessageBox.Show("fill the Name Field")
        Else
            Dim sql As String = "Insert Into technicanimage values (@techcaption, @techpic, (select TechID from Technicans where TechID = @TechID))"
            Dim cmd As New SqlCommand(sql, con)

            cmd.Parameters.AddWithValue("@techcaption", TextBox1.Text)
            Dim ms As New MemoryStream()

            PicImage.BackgroundImage.Save(ms, PicImage.BackgroundImage.RawFormat)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@techpic", SqlDbType.Image)
            p.Value = data

            Try



                cmd.Parameters.Add(p)
                con.Open()



                MessageBox.Show("Name & Image has been saved", "saved")
                Label3.Visible = False
                TextBox1.Visible = False

                cmd.Parameters.AddWithValue("@TechID", newtic.IdTechs)
                cmd.ExecuteNonQuery()
            Catch se As SqlException
                MsgBox(se.Message)

            End Try
        End If

        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox2.BringToFront()
        GroupBox2.Visible = True
        Label3.Visible = False
        TextBox1.Visible = False

    End Sub

    Private Sub btn_reporters_Click(sender As Object, e As EventArgs) Handles btn_reporters.Click
        GroupBox2.BringToFront()
        GroupBox2.Visible = True
        Label3.Visible = False
        TextBox1.Visible = False

    End Sub


    'Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    '    cmd = New SqlCommand("select Techpic name='" & _
    '              DataGridView1.CurrentRow.Cells(2).Value() & "'", con)
    '    Dim imageData As Byte() = DirectCast(cmd.ExecuteScalar(), Byte())
    '    If Not imageData Is Nothing Then
    '        Using ms As New MemoryStream(imageData, 0, imageData.Length)
    '            ms.Write(imageData, 0, imageData.Length)
    '            PicImage.BackgroundImage = Image.FromStream(ms, True)
    '        End Using
    '    End If
    '    GroupBox2.SendToBack()
    '    GroupBox2.Visible = False
    '    Label1.Visible = True
    '    Label1.Text = CStr(DataGridView1.CurrentRow.Cells(0).Value())
    'End Sub

    Private Sub BtnViewTech_Click(sender As Object, e As EventArgs) Handles BtnViewTech.Click
        'this is the viewing tech pic of which I had issues with as weel 
        Dim command As String
        command = "Select Techpic from TechnicanImage where TechID = " + CboTechID.Text
        Dim commandview As SqlCommand
        commandview = New SqlCommand(command, con)

        con.Open()
        commandview.ExecuteNonQuery()

        Dim imageData As Byte() = DirectCast(commandview.ExecuteScalar(), Byte())
        If Not imageData Is Nothing Then
            Using ms As New MemoryStream(imageData, 0, imageData.Length)
                ms.Write(imageData, 0, imageData.Length)
                PicImage.BackgroundImage = Image.FromStream(ms, True)


            End Using
            GroupBox2.SendToBack()
            GroupBox2.Visible = False
            Label3.Visible = True
            'Label3.Text = CStr()

        End If
        con.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'and this tthe reporter view which i had problems with again as well 
        Dim command2 As String
        command2 = "Select reporterpicture from reporterimage where ReporterID = " + ComboReportID.Text
        Dim commandview2 As New SqlCommand
        commandview2 = New SqlCommand(command2, con)


        Dim imageData As Byte() = DirectCast(commandview2.ExecuteScalar(), Byte())
        If Not imageData Is Nothing Then
            Using ms As New MemoryStream(imageData, 0, imageData.Length)
                ms.Write(imageData, 0, imageData.Length)
                PicImage.BackgroundImage = Image.FromStream(ms, True)


            End Using
            GroupBox2.SendToBack()
            GroupBox2.Visible = False
            Label3.Visible = True
            'Label3.Text = CStr()

        End If
        con.Close()
    End Sub

    Private Sub Btn_ReturntoReporters_Click(sender As Object, e As EventArgs) Handles Btn_ReturntoReporters.Click
        'this is the return to t reporters 
        Reporters.ShowDialog()
        Close()
    End Sub

    Private Sub Btn_ReturnTOTechs_Click(sender As Object, e As EventArgs) Handles Btn_ReturnTOTechs.Click
        'this is the return th techs 
        TechnicanGui.ShowDialog()
        Close()

    End Sub
End Class