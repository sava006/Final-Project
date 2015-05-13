<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpenTickets
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OpenTickets))
        Me.TabControlTickets = New System.Windows.Forms.TabControl()
        Me.TabPageCreateNewTicket = New System.Windows.Forms.TabPage()
        Me.btn_viewreportnamefromid = New System.Windows.Forms.Button()
        Me.ListViewReporterDepAndName = New System.Windows.Forms.ListView()
        Me.BtnGoToReporter = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAddNewticket = New System.Windows.Forms.Button()
        Me.ComboBoxReporters = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDateIssued = New System.Windows.Forms.TextBox()
        Me.NumericUpDownSeverityRating = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtIssueDescrpition = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPageArchivedTickets = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.TabPageAssignTickets = New System.Windows.Forms.TabPage()
        Me.GrouBoxUnassignedTickets = New System.Windows.Forms.GroupBox()
        Me.btn_GotoAddTech = New System.Windows.Forms.Button()
        Me.CboTicketstobeAssigned = New System.Windows.Forms.ComboBox()
        Me.CboTechstobeassigned = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListViewUnassignedTickets = New System.Windows.Forms.ListView()
        Me.ListViewTechnicans = New System.Windows.Forms.ListView()
        Me.btn_ViewAvailableTicksandTechs = New System.Windows.Forms.Button()
        Me.BtnAssign = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPageResolveAssignedTickets = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_ViewSelectedTicket = New System.Windows.Forms.Button()
        Me.cboselectedtick = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ListViewAssignedticswithretecchs = New System.Windows.Forms.ListView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btn_emailTech = New System.Windows.Forms.Button()
        Me.btn_Viewticksbytech = New System.Windows.Forms.Button()
        Me.CboSelectunresolvedticksbyAssignedTech = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtWorkDone = New System.Windows.Forms.TextBox()
        Me.btn_selecttictoresolve = New System.Windows.Forms.Button()
        Me.DataGridViewTicketsunresolvedbutassignedtotech = New System.Windows.Forms.DataGridView()
        Me.BtnLogOut = New System.Windows.Forms.Button()
        Me.TabControlTickets.SuspendLayout()
        Me.TabPageCreateNewTicket.SuspendLayout()
        CType(Me.NumericUpDownSeverityRating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageArchivedTickets.SuspendLayout()
        Me.TabPageAssignTickets.SuspendLayout()
        Me.GrouBoxUnassignedTickets.SuspendLayout()
        Me.TabPageResolveAssignedTickets.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewTicketsunresolvedbutassignedtotech, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControlTickets
        '
        Me.TabControlTickets.Controls.Add(Me.TabPageCreateNewTicket)
        Me.TabControlTickets.Controls.Add(Me.TabPageArchivedTickets)
        Me.TabControlTickets.Controls.Add(Me.TabPageAssignTickets)
        Me.TabControlTickets.Controls.Add(Me.TabPageResolveAssignedTickets)
        Me.TabControlTickets.Location = New System.Drawing.Point(5, 12)
        Me.TabControlTickets.Name = "TabControlTickets"
        Me.TabControlTickets.SelectedIndex = 0
        Me.TabControlTickets.Size = New System.Drawing.Size(777, 478)
        Me.TabControlTickets.TabIndex = 0
        '
        'TabPageCreateNewTicket
        '
        Me.TabPageCreateNewTicket.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPageCreateNewTicket.Controls.Add(Me.btn_viewreportnamefromid)
        Me.TabPageCreateNewTicket.Controls.Add(Me.ListViewReporterDepAndName)
        Me.TabPageCreateNewTicket.Controls.Add(Me.BtnGoToReporter)
        Me.TabPageCreateNewTicket.Controls.Add(Me.Label5)
        Me.TabPageCreateNewTicket.Controls.Add(Me.btnAddNewticket)
        Me.TabPageCreateNewTicket.Controls.Add(Me.ComboBoxReporters)
        Me.TabPageCreateNewTicket.Controls.Add(Me.Label4)
        Me.TabPageCreateNewTicket.Controls.Add(Me.Label3)
        Me.TabPageCreateNewTicket.Controls.Add(Me.TxtDateIssued)
        Me.TabPageCreateNewTicket.Controls.Add(Me.NumericUpDownSeverityRating)
        Me.TabPageCreateNewTicket.Controls.Add(Me.Label2)
        Me.TabPageCreateNewTicket.Controls.Add(Me.TxtIssueDescrpition)
        Me.TabPageCreateNewTicket.Controls.Add(Me.Label1)
        Me.TabPageCreateNewTicket.Location = New System.Drawing.Point(4, 22)
        Me.TabPageCreateNewTicket.Name = "TabPageCreateNewTicket"
        Me.TabPageCreateNewTicket.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCreateNewTicket.Size = New System.Drawing.Size(769, 452)
        Me.TabPageCreateNewTicket.TabIndex = 1
        Me.TabPageCreateNewTicket.Text = "Create New Ticket"
        '
        'btn_viewreportnamefromid
        '
        Me.btn_viewreportnamefromid.Location = New System.Drawing.Point(359, 330)
        Me.btn_viewreportnamefromid.Name = "btn_viewreportnamefromid"
        Me.btn_viewreportnamefromid.Size = New System.Drawing.Size(131, 23)
        Me.btn_viewreportnamefromid.TabIndex = 14
        Me.btn_viewreportnamefromid.Text = "view report name"
        Me.btn_viewreportnamefromid.UseVisualStyleBackColor = True
        '
        'ListViewReporterDepAndName
        '
        Me.ListViewReporterDepAndName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ListViewReporterDepAndName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListViewReporterDepAndName.Location = New System.Drawing.Point(29, 257)
        Me.ListViewReporterDepAndName.Name = "ListViewReporterDepAndName"
        Me.ListViewReporterDepAndName.Size = New System.Drawing.Size(158, 97)
        Me.ListViewReporterDepAndName.TabIndex = 13
        Me.ListViewReporterDepAndName.UseCompatibleStateImageBehavior = False
        '
        'BtnGoToReporter
        '
        Me.BtnGoToReporter.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGoToReporter.Location = New System.Drawing.Point(497, 370)
        Me.BtnGoToReporter.Name = "BtnGoToReporter"
        Me.BtnGoToReporter.Size = New System.Drawing.Size(39, 23)
        Me.BtnGoToReporter.TabIndex = 12
        Me.BtnGoToReporter.Text = "ok"
        Me.BtnGoToReporter.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 370)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(464, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "If reporter is not in system then you need to add a new reporter :"
        '
        'btnAddNewticket
        '
        Me.btnAddNewticket.Location = New System.Drawing.Point(326, 405)
        Me.btnAddNewticket.Name = "btnAddNewticket"
        Me.btnAddNewticket.Size = New System.Drawing.Size(173, 23)
        Me.btnAddNewticket.TabIndex = 10
        Me.btnAddNewticket.Text = "Add New Ticket"
        Me.btnAddNewticket.UseVisualStyleBackColor = True
        '
        'ComboBoxReporters
        '
        Me.ComboBoxReporters.FormattingEnabled = True
        Me.ComboBoxReporters.Location = New System.Drawing.Point(358, 293)
        Me.ComboBoxReporters.Name = "ComboBoxReporters"
        Me.ComboBoxReporters.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxReporters.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(216, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Reporter of Issue"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(246, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Date Issued :"
        '
        'TxtDateIssued
        '
        Me.TxtDateIssued.Location = New System.Drawing.Point(359, 257)
        Me.TxtDateIssued.Name = "TxtDateIssued"
        Me.TxtDateIssued.Size = New System.Drawing.Size(120, 20)
        Me.TxtDateIssued.TabIndex = 6
        '
        'NumericUpDownSeverityRating
        '
        Me.NumericUpDownSeverityRating.Location = New System.Drawing.Point(359, 218)
        Me.NumericUpDownSeverityRating.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDownSeverityRating.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownSeverityRating.Name = "NumericUpDownSeverityRating"
        Me.NumericUpDownSeverityRating.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownSeverityRating.TabIndex = 1
        Me.NumericUpDownSeverityRating.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(362, 34)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "How bad is your problem On a scale of 1 to 5 with" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a 1 being not bad to 5 being v" & _
    "ery urgent:"
        '
        'TxtIssueDescrpition
        '
        Me.TxtIssueDescrpition.Location = New System.Drawing.Point(51, 51)
        Me.TxtIssueDescrpition.Multiline = True
        Me.TxtIssueDescrpition.Name = "TxtIssueDescrpition"
        Me.TxtIssueDescrpition.Size = New System.Drawing.Size(397, 117)
        Me.TxtIssueDescrpition.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Description of Isssue Needing to be fixed :"
        '
        'TabPageArchivedTickets
        '
        Me.TabPageArchivedTickets.BackColor = System.Drawing.Color.Blue
        Me.TabPageArchivedTickets.Controls.Add(Me.Label13)
        Me.TabPageArchivedTickets.Controls.Add(Me.Button1)
        Me.TabPageArchivedTickets.Controls.Add(Me.ListView1)
        Me.TabPageArchivedTickets.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageArchivedTickets.Location = New System.Drawing.Point(4, 22)
        Me.TabPageArchivedTickets.Name = "TabPageArchivedTickets"
        Me.TabPageArchivedTickets.Size = New System.Drawing.Size(769, 452)
        Me.TabPageArchivedTickets.TabIndex = 2
        Me.TabPageArchivedTickets.Text = "Archived Completed Tickets"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(46, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(271, 21)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "View Resolved Archived Tickets "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(63, 290)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(343, 36)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Archived Tickeks list"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ListView1.Location = New System.Drawing.Point(26, 59)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(530, 206)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'TabPageAssignTickets
        '
        Me.TabPageAssignTickets.BackColor = System.Drawing.Color.Lime
        Me.TabPageAssignTickets.Controls.Add(Me.GrouBoxUnassignedTickets)
        Me.TabPageAssignTickets.Location = New System.Drawing.Point(4, 22)
        Me.TabPageAssignTickets.Name = "TabPageAssignTickets"
        Me.TabPageAssignTickets.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageAssignTickets.Size = New System.Drawing.Size(769, 452)
        Me.TabPageAssignTickets.TabIndex = 0
        Me.TabPageAssignTickets.Text = "Assign Tickets"
        '
        'GrouBoxUnassignedTickets
        '
        Me.GrouBoxUnassignedTickets.BackColor = System.Drawing.Color.PaleGreen
        Me.GrouBoxUnassignedTickets.Controls.Add(Me.btn_GotoAddTech)
        Me.GrouBoxUnassignedTickets.Controls.Add(Me.CboTicketstobeAssigned)
        Me.GrouBoxUnassignedTickets.Controls.Add(Me.CboTechstobeassigned)
        Me.GrouBoxUnassignedTickets.Controls.Add(Me.Label9)
        Me.GrouBoxUnassignedTickets.Controls.Add(Me.ListViewUnassignedTickets)
        Me.GrouBoxUnassignedTickets.Controls.Add(Me.ListViewTechnicans)
        Me.GrouBoxUnassignedTickets.Controls.Add(Me.btn_ViewAvailableTicksandTechs)
        Me.GrouBoxUnassignedTickets.Controls.Add(Me.BtnAssign)
        Me.GrouBoxUnassignedTickets.Controls.Add(Me.Label8)
        Me.GrouBoxUnassignedTickets.Controls.Add(Me.Label7)
        Me.GrouBoxUnassignedTickets.Controls.Add(Me.Label6)
        Me.GrouBoxUnassignedTickets.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrouBoxUnassignedTickets.Location = New System.Drawing.Point(6, 28)
        Me.GrouBoxUnassignedTickets.Name = "GrouBoxUnassignedTickets"
        Me.GrouBoxUnassignedTickets.Size = New System.Drawing.Size(603, 344)
        Me.GrouBoxUnassignedTickets.TabIndex = 0
        Me.GrouBoxUnassignedTickets.TabStop = False
        Me.GrouBoxUnassignedTickets.Text = "                           Tickets that need a Technican"
        '
        'btn_GotoAddTech
        '
        Me.btn_GotoAddTech.Location = New System.Drawing.Point(441, 315)
        Me.btn_GotoAddTech.Name = "btn_GotoAddTech"
        Me.btn_GotoAddTech.Size = New System.Drawing.Size(119, 23)
        Me.btn_GotoAddTech.TabIndex = 12
        Me.btn_GotoAddTech.Text = "Add New Technican"
        Me.btn_GotoAddTech.UseVisualStyleBackColor = True
        '
        'CboTicketstobeAssigned
        '
        Me.CboTicketstobeAssigned.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CboTicketstobeAssigned.FormattingEnabled = True
        Me.CboTicketstobeAssigned.Location = New System.Drawing.Point(340, 216)
        Me.CboTicketstobeAssigned.Name = "CboTicketstobeAssigned"
        Me.CboTicketstobeAssigned.Size = New System.Drawing.Size(210, 26)
        Me.CboTicketstobeAssigned.TabIndex = 11
        '
        'CboTechstobeassigned
        '
        Me.CboTechstobeassigned.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CboTechstobeassigned.FormattingEnabled = True
        Me.CboTechstobeassigned.Location = New System.Drawing.Point(23, 216)
        Me.CboTechstobeassigned.Name = "CboTechstobeassigned"
        Me.CboTechstobeassigned.Size = New System.Drawing.Size(211, 26)
        Me.CboTechstobeassigned.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(254, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 18)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = ">>>>>"
        '
        'ListViewUnassignedTickets
        '
        Me.ListViewUnassignedTickets.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListViewUnassignedTickets.Location = New System.Drawing.Point(340, 63)
        Me.ListViewUnassignedTickets.Name = "ListViewUnassignedTickets"
        Me.ListViewUnassignedTickets.Size = New System.Drawing.Size(210, 136)
        Me.ListViewUnassignedTickets.TabIndex = 8
        Me.ListViewUnassignedTickets.UseCompatibleStateImageBehavior = False
        '
        'ListViewTechnicans
        '
        Me.ListViewTechnicans.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListViewTechnicans.Location = New System.Drawing.Point(23, 63)
        Me.ListViewTechnicans.Name = "ListViewTechnicans"
        Me.ListViewTechnicans.Size = New System.Drawing.Size(211, 136)
        Me.ListViewTechnicans.TabIndex = 7
        Me.ListViewTechnicans.UseCompatibleStateImageBehavior = False
        '
        'btn_ViewAvailableTicksandTechs
        '
        Me.btn_ViewAvailableTicksandTechs.Location = New System.Drawing.Point(204, 314)
        Me.btn_ViewAvailableTicksandTechs.Name = "btn_ViewAvailableTicksandTechs"
        Me.btn_ViewAvailableTicksandTechs.Size = New System.Drawing.Size(208, 24)
        Me.btn_ViewAvailableTicksandTechs.TabIndex = 6
        Me.btn_ViewAvailableTicksandTechs.Text = "Technicans and Available Technicans"
        Me.btn_ViewAvailableTicksandTechs.UseVisualStyleBackColor = True
        '
        'BtnAssign
        '
        Me.BtnAssign.Location = New System.Drawing.Point(53, 315)
        Me.BtnAssign.Name = "BtnAssign"
        Me.BtnAssign.Size = New System.Drawing.Size(120, 23)
        Me.BtnAssign.TabIndex = 5
        Me.BtnAssign.Text = "assign tickets"
        Me.BtnAssign.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 18)
        Me.Label8.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Technicans"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(328, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 30)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "tickets unassigned" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " to a tech"
        '
        'TabPageResolveAssignedTickets
        '
        Me.TabPageResolveAssignedTickets.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPageResolveAssignedTickets.Controls.Add(Me.GroupBox1)
        Me.TabPageResolveAssignedTickets.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageResolveAssignedTickets.Location = New System.Drawing.Point(4, 22)
        Me.TabPageResolveAssignedTickets.Name = "TabPageResolveAssignedTickets"
        Me.TabPageResolveAssignedTickets.Size = New System.Drawing.Size(769, 452)
        Me.TabPageResolveAssignedTickets.TabIndex = 3
        Me.TabPageResolveAssignedTickets.Text = "Resolve Assigned Tickets"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Fuchsia
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.btn_ViewSelectedTicket)
        Me.GroupBox1.Controls.Add(Me.cboselectedtick)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.ListViewAssignedticswithretecchs)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.btn_emailTech)
        Me.GroupBox1.Controls.Add(Me.btn_Viewticksbytech)
        Me.GroupBox1.Controls.Add(Me.CboSelectunresolvedticksbyAssignedTech)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtWorkDone)
        Me.GroupBox1.Controls.Add(Me.btn_selecttictoresolve)
        Me.GroupBox1.Controls.Add(Me.DataGridViewTicketsunresolvedbutassignedtotech)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(675, 409)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "                        Resolving tickets"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(161, 291)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 17)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Work Done ----->>"
        '
        'btn_ViewSelectedTicket
        '
        Me.btn_ViewSelectedTicket.Location = New System.Drawing.Point(432, 351)
        Me.btn_ViewSelectedTicket.Name = "btn_ViewSelectedTicket"
        Me.btn_ViewSelectedTicket.Size = New System.Drawing.Size(140, 23)
        Me.btn_ViewSelectedTicket.TabIndex = 11
        Me.btn_ViewSelectedTicket.Text = "view selected ticeket"
        Me.btn_ViewSelectedTicket.UseVisualStyleBackColor = True
        '
        'cboselectedtick
        '
        Me.cboselectedtick.BackColor = System.Drawing.Color.Yellow
        Me.cboselectedtick.FormattingEnabled = True
        Me.cboselectedtick.Location = New System.Drawing.Point(432, 203)
        Me.cboselectedtick.Name = "cboselectedtick"
        Me.cboselectedtick.Size = New System.Drawing.Size(173, 23)
        Me.cboselectedtick.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(438, 185)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(146, 15)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Select Ticket by Id to view"
        '
        'ListViewAssignedticswithretecchs
        '
        Me.ListViewAssignedticswithretecchs.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ListViewAssignedticswithretecchs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ListViewAssignedticswithretecchs.Location = New System.Drawing.Point(38, 28)
        Me.ListViewAssignedticswithretecchs.Name = "ListViewAssignedticswithretecchs"
        Me.ListViewAssignedticswithretecchs.Size = New System.Drawing.Size(434, 150)
        Me.ListViewAssignedticswithretecchs.TabIndex = 8
        Me.ListViewAssignedticswithretecchs.UseCompatibleStateImageBehavior = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(16, 207)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(165, 23)
        Me.ComboBox1.TabIndex = 7
        '
        'btn_emailTech
        '
        Me.btn_emailTech.Location = New System.Drawing.Point(16, 265)
        Me.btn_emailTech.Name = "btn_emailTech"
        Me.btn_emailTech.Size = New System.Drawing.Size(143, 23)
        Me.btn_emailTech.TabIndex = 6
        Me.btn_emailTech.Text = "email Tech list"
        Me.btn_emailTech.UseVisualStyleBackColor = True
        '
        'btn_Viewticksbytech
        '
        Me.btn_Viewticksbytech.Location = New System.Drawing.Point(16, 236)
        Me.btn_Viewticksbytech.Name = "btn_Viewticksbytech"
        Me.btn_Viewticksbytech.Size = New System.Drawing.Size(143, 23)
        Me.btn_Viewticksbytech.TabIndex = 5
        Me.btn_Viewticksbytech.Text = "Tech tickets"
        Me.btn_Viewticksbytech.UseVisualStyleBackColor = True
        '
        'CboSelectunresolvedticksbyAssignedTech
        '
        Me.CboSelectunresolvedticksbyAssignedTech.BackColor = System.Drawing.Color.Aqua
        Me.CboSelectunresolvedticksbyAssignedTech.FormattingEnabled = True
        Me.CboSelectunresolvedticksbyAssignedTech.Location = New System.Drawing.Point(16, 182)
        Me.CboSelectunresolvedticksbyAssignedTech.Name = "CboSelectunresolvedticksbyAssignedTech"
        Me.CboSelectunresolvedticksbyAssignedTech.Size = New System.Drawing.Size(240, 23)
        Me.CboSelectunresolvedticksbyAssignedTech.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 332)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(397, 45)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = resources.GetString("Label10.Text")
        '
        'txtWorkDone
        '
        Me.txtWorkDone.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtWorkDone.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWorkDone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtWorkDone.Location = New System.Drawing.Point(303, 232)
        Me.txtWorkDone.Multiline = True
        Me.txtWorkDone.Name = "txtWorkDone"
        Me.txtWorkDone.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtWorkDone.Size = New System.Drawing.Size(302, 97)
        Me.txtWorkDone.TabIndex = 2
        '
        'btn_selecttictoresolve
        '
        Me.btn_selecttictoresolve.Location = New System.Drawing.Point(432, 380)
        Me.btn_selecttictoresolve.Name = "btn_selecttictoresolve"
        Me.btn_selecttictoresolve.Size = New System.Drawing.Size(140, 23)
        Me.btn_selecttictoresolve.TabIndex = 1
        Me.btn_selecttictoresolve.Text = "Update ticket"
        Me.btn_selecttictoresolve.UseVisualStyleBackColor = True
        '
        'DataGridViewTicketsunresolvedbutassignedtotech
        '
        Me.DataGridViewTicketsunresolvedbutassignedtotech.BackgroundColor = System.Drawing.Color.Red
        Me.DataGridViewTicketsunresolvedbutassignedtotech.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTicketsunresolvedbutassignedtotech.Location = New System.Drawing.Point(92, 28)
        Me.DataGridViewTicketsunresolvedbutassignedtotech.Name = "DataGridViewTicketsunresolvedbutassignedtotech"
        Me.DataGridViewTicketsunresolvedbutassignedtotech.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridViewTicketsunresolvedbutassignedtotech.Size = New System.Drawing.Size(380, 150)
        Me.DataGridViewTicketsunresolvedbutassignedtotech.TabIndex = 0
        '
        'BtnLogOut
        '
        Me.BtnLogOut.BackColor = System.Drawing.Color.Yellow
        Me.BtnLogOut.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogOut.Location = New System.Drawing.Point(475, 514)
        Me.BtnLogOut.Name = "BtnLogOut"
        Me.BtnLogOut.Size = New System.Drawing.Size(143, 23)
        Me.BtnLogOut.TabIndex = 1
        Me.BtnLogOut.Text = "Log Out of Screen"
        Me.BtnLogOut.UseVisualStyleBackColor = False
        '
        'OpenTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(872, 549)
        Me.Controls.Add(Me.BtnLogOut)
        Me.Controls.Add(Me.TabControlTickets)
        Me.Name = "OpenTickets"
        Me.Text = "OpenTickets"
        Me.TabControlTickets.ResumeLayout(False)
        Me.TabPageCreateNewTicket.ResumeLayout(False)
        Me.TabPageCreateNewTicket.PerformLayout()
        CType(Me.NumericUpDownSeverityRating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageArchivedTickets.ResumeLayout(False)
        Me.TabPageArchivedTickets.PerformLayout()
        Me.TabPageAssignTickets.ResumeLayout(False)
        Me.GrouBoxUnassignedTickets.ResumeLayout(False)
        Me.GrouBoxUnassignedTickets.PerformLayout()
        Me.TabPageResolveAssignedTickets.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewTicketsunresolvedbutassignedtotech, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControlTickets As System.Windows.Forms.TabControl
    Friend WithEvents TabPageAssignTickets As System.Windows.Forms.TabPage
    Friend WithEvents TabPageCreateNewTicket As System.Windows.Forms.TabPage
    Friend WithEvents TabPageArchivedTickets As System.Windows.Forms.TabPage
    Friend WithEvents BtnLogOut As System.Windows.Forms.Button
    Friend WithEvents btnAddNewticket As System.Windows.Forms.Button
    Friend WithEvents ComboBoxReporters As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtDateIssued As System.Windows.Forms.TextBox
    Friend WithEvents NumericUpDownSeverityRating As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtIssueDescrpition As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnGoToReporter As System.Windows.Forms.Button
    Friend WithEvents GrouBoxUnassignedTickets As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnAssign As System.Windows.Forms.Button
    Friend WithEvents TabPageResolveAssignedTickets As System.Windows.Forms.TabPage
    Friend WithEvents ListViewReporterDepAndName As System.Windows.Forms.ListView
    Friend WithEvents btn_viewreportnamefromid As System.Windows.Forms.Button
    Friend WithEvents btn_ViewAvailableTicksandTechs As System.Windows.Forms.Button
    Friend WithEvents ListViewTechnicans As System.Windows.Forms.ListView
    Friend WithEvents ListViewUnassignedTickets As System.Windows.Forms.ListView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CboTicketstobeAssigned As System.Windows.Forms.ComboBox
    Friend WithEvents CboTechstobeassigned As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_selecttictoresolve As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTicketsunresolvedbutassignedtotech As System.Windows.Forms.DataGridView
    Friend WithEvents txtWorkDone As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CboSelectunresolvedticksbyAssignedTech As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Viewticksbytech As System.Windows.Forms.Button
    Friend WithEvents btn_emailTech As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ListViewAssignedticswithretecchs As System.Windows.Forms.ListView
    Friend WithEvents btn_ViewSelectedTicket As System.Windows.Forms.Button
    Friend WithEvents cboselectedtick As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btn_GotoAddTech As System.Windows.Forms.Button
End Class
