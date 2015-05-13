<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporters
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
        Me.BtnAddReporter = New System.Windows.Forms.Button()
        Me.CboReportersreporterform = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOpenTicks = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtreporteremail = New System.Windows.Forms.TextBox()
        Me.txtreporterLname = New System.Windows.Forms.TextBox()
        Me.txtReporterFNam = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnMainmenu = New System.Windows.Forms.Button()
        Me.BtnLogOut = New System.Windows.Forms.Button()
        Me.BtnVeiwReporter = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.ComboDeps = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnReporterPicture = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TabControlReporters = New System.Windows.Forms.TabControl()
        Me.TabPageCurrentReporters = New System.Windows.Forms.TabPage()
        Me.btnViewSelected = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboCategoriesReporters = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnEmail = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lstReporters = New System.Windows.Forms.ListBox()
        Me.TabPageNewReporters = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlReporters.SuspendLayout()
        Me.TabPageCurrentReporters.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageNewReporters.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAddReporter
        '
        Me.BtnAddReporter.Location = New System.Drawing.Point(314, 177)
        Me.BtnAddReporter.Name = "BtnAddReporter"
        Me.BtnAddReporter.Size = New System.Drawing.Size(123, 23)
        Me.BtnAddReporter.TabIndex = 0
        Me.BtnAddReporter.Text = "Add to Reporter List"
        Me.BtnAddReporter.UseVisualStyleBackColor = True
        '
        'CboReportersreporterform
        '
        Me.CboReportersreporterform.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CboReportersreporterform.FormattingEnabled = True
        Me.CboReportersreporterform.Items.AddRange(New Object() {"Select (Reporters)"})
        Me.CboReportersreporterform.Location = New System.Drawing.Point(192, 20)
        Me.CboReportersreporterform.Name = "CboReportersreporterform"
        Me.CboReportersreporterform.Size = New System.Drawing.Size(145, 24)
        Me.CboReportersreporterform.TabIndex = 1
        Me.CboReportersreporterform.Text = "Select Reporters"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "View Current Reporters :"
        '
        'btnOpenTicks
        '
        Me.btnOpenTicks.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenTicks.Location = New System.Drawing.Point(435, 431)
        Me.btnOpenTicks.Name = "btnOpenTicks"
        Me.btnOpenTicks.Size = New System.Drawing.Size(156, 23)
        Me.btnOpenTicks.TabIndex = 3
        Me.btnOpenTicks.Text = "Head for Tickets"
        Me.btnOpenTicks.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "First Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Last Name :"
        '
        'txtreporteremail
        '
        Me.txtreporteremail.Location = New System.Drawing.Point(180, 130)
        Me.txtreporteremail.Name = "txtreporteremail"
        Me.txtreporteremail.Size = New System.Drawing.Size(121, 22)
        Me.txtreporteremail.TabIndex = 6
        '
        'txtreporterLname
        '
        Me.txtreporterLname.Location = New System.Drawing.Point(180, 66)
        Me.txtreporterLname.Name = "txtreporterLname"
        Me.txtreporterLname.Size = New System.Drawing.Size(121, 22)
        Me.txtreporterLname.TabIndex = 7
        '
        'txtReporterFNam
        '
        Me.txtReporterFNam.Location = New System.Drawing.Point(180, 25)
        Me.txtReporterFNam.Name = "txtReporterFNam"
        Me.txtReporterFNam.Size = New System.Drawing.Size(121, 22)
        Me.txtReporterFNam.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(84, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "email :"
        '
        'btnMainmenu
        '
        Me.btnMainmenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainmenu.Location = New System.Drawing.Point(516, 462)
        Me.btnMainmenu.Name = "btnMainmenu"
        Me.btnMainmenu.Size = New System.Drawing.Size(75, 23)
        Me.btnMainmenu.TabIndex = 11
        Me.btnMainmenu.Text = "Main Menu"
        Me.btnMainmenu.UseVisualStyleBackColor = True
        '
        'BtnLogOut
        '
        Me.BtnLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogOut.Location = New System.Drawing.Point(516, 402)
        Me.BtnLogOut.Name = "BtnLogOut"
        Me.BtnLogOut.Size = New System.Drawing.Size(75, 23)
        Me.BtnLogOut.TabIndex = 12
        Me.BtnLogOut.Text = "Log Out"
        Me.BtnLogOut.UseVisualStyleBackColor = True
        '
        'BtnVeiwReporter
        '
        Me.BtnVeiwReporter.Location = New System.Drawing.Point(370, 21)
        Me.BtnVeiwReporter.Name = "BtnVeiwReporter"
        Me.BtnVeiwReporter.Size = New System.Drawing.Size(137, 23)
        Me.BtnVeiwReporter.TabIndex = 13
        Me.BtnVeiwReporter.Text = "View All"
        Me.BtnVeiwReporter.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OK_Button)
        Me.GroupBox1.Controls.Add(Me.ComboDeps)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.btnReporterPicture)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtReporterFNam)
        Me.GroupBox1.Controls.Add(Me.BtnAddReporter)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtreporteremail)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtreporterLname)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(467, 255)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "                                Add a New Reporter Please"
        '
        'OK_Button
        '
        Me.OK_Button.Location = New System.Drawing.Point(122, 226)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(315, 23)
        Me.OK_Button.TabIndex = 18
        Me.OK_Button.Text = "Add Reporter and return to creating ticket"
        Me.OK_Button.UseVisualStyleBackColor = True
        '
        'ComboDeps
        '
        Me.ComboDeps.FormattingEnabled = True
        Me.ComboDeps.Items.AddRange(New Object() {"Accounting", "Marketing", "R & D", "Security", "Administration"})
        Me.ComboDeps.Location = New System.Drawing.Point(148, 99)
        Me.ComboDeps.Name = "ComboDeps"
        Me.ComboDeps.Size = New System.Drawing.Size(153, 24)
        Me.ComboDeps.TabIndex = 17
        Me.ComboDeps.Text = "Select department"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(46, 102)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 16)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Department :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(333, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "employee Picture"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(333, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 95)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'btnReporterPicture
        '
        Me.btnReporterPicture.Location = New System.Drawing.Point(180, 168)
        Me.btnReporterPicture.Name = "btnReporterPicture"
        Me.btnReporterPicture.Size = New System.Drawing.Size(107, 32)
        Me.btnReporterPicture.TabIndex = 12
        Me.btnReporterPicture.Text = "Upload picture"
        Me.btnReporterPicture.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Upload Email :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(384, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 15
        '
        'TabControlReporters
        '
        Me.TabControlReporters.Controls.Add(Me.TabPageCurrentReporters)
        Me.TabControlReporters.Controls.Add(Me.TabPageNewReporters)
        Me.TabControlReporters.Controls.Add(Me.TabPage1)
        Me.TabControlReporters.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlReporters.Location = New System.Drawing.Point(33, 38)
        Me.TabControlReporters.Name = "TabControlReporters"
        Me.TabControlReporters.SelectedIndex = 0
        Me.TabControlReporters.Size = New System.Drawing.Size(558, 358)
        Me.TabControlReporters.TabIndex = 16
        '
        'TabPageCurrentReporters
        '
        Me.TabPageCurrentReporters.BackColor = System.Drawing.Color.Yellow
        Me.TabPageCurrentReporters.Controls.Add(Me.btnViewSelected)
        Me.TabPageCurrentReporters.Controls.Add(Me.Label13)
        Me.TabPageCurrentReporters.Controls.Add(Me.cboCategoriesReporters)
        Me.TabPageCurrentReporters.Controls.Add(Me.Label12)
        Me.TabPageCurrentReporters.Controls.Add(Me.btnEmail)
        Me.TabPageCurrentReporters.Controls.Add(Me.Label11)
        Me.TabPageCurrentReporters.Controls.Add(Me.PictureBox2)
        Me.TabPageCurrentReporters.Controls.Add(Me.lstReporters)
        Me.TabPageCurrentReporters.Controls.Add(Me.Label1)
        Me.TabPageCurrentReporters.Controls.Add(Me.CboReportersreporterform)
        Me.TabPageCurrentReporters.Controls.Add(Me.BtnVeiwReporter)
        Me.TabPageCurrentReporters.ForeColor = System.Drawing.Color.Red
        Me.TabPageCurrentReporters.Location = New System.Drawing.Point(4, 25)
        Me.TabPageCurrentReporters.Name = "TabPageCurrentReporters"
        Me.TabPageCurrentReporters.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCurrentReporters.Size = New System.Drawing.Size(550, 329)
        Me.TabPageCurrentReporters.TabIndex = 0
        Me.TabPageCurrentReporters.Text = "Current Reporters"
        '
        'btnViewSelected
        '
        Me.btnViewSelected.Location = New System.Drawing.Point(370, 54)
        Me.btnViewSelected.Name = "btnViewSelected"
        Me.btnViewSelected.Size = New System.Drawing.Size(137, 23)
        Me.btnViewSelected.TabIndex = 21
        Me.btnViewSelected.Text = "View Selected"
        Me.btnViewSelected.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(112, 290)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(295, 22)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Send Email of completed orders :"
        '
        'cboCategoriesReporters
        '
        Me.cboCategoriesReporters.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cboCategoriesReporters.FormattingEnabled = True
        Me.cboCategoriesReporters.Items.AddRange(New Object() {"Select (Department)"})
        Me.cboCategoriesReporters.Location = New System.Drawing.Point(173, 54)
        Me.cboCategoriesReporters.Name = "cboCategoriesReporters"
        Me.cboCategoriesReporters.Size = New System.Drawing.Size(121, 24)
        Me.cboCategoriesReporters.TabIndex = 19
        Me.cboCategoriesReporters.Text = "Departments"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(52, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 16)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Select Category :"
        '
        'btnEmail
        '
        Me.btnEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmail.Location = New System.Drawing.Point(438, 289)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(75, 23)
        Me.btnEmail.TabIndex = 17
        Me.btnEmail.Text = "send"
        Me.btnEmail.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 16)
        Me.Label11.TabIndex = 16
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(370, 88)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(153, 115)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'lstReporters
        '
        Me.lstReporters.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstReporters.FormattingEnabled = True
        Me.lstReporters.ItemHeight = 16
        Me.lstReporters.Location = New System.Drawing.Point(80, 88)
        Me.lstReporters.Name = "lstReporters"
        Me.lstReporters.Size = New System.Drawing.Size(233, 180)
        Me.lstReporters.TabIndex = 14
        '
        'TabPageNewReporters
        '
        Me.TabPageNewReporters.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPageNewReporters.Controls.Add(Me.GroupBox1)
        Me.TabPageNewReporters.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabPageNewReporters.Location = New System.Drawing.Point(4, 25)
        Me.TabPageNewReporters.Name = "TabPageNewReporters"
        Me.TabPageNewReporters.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageNewReporters.Size = New System.Drawing.Size(550, 329)
        Me.TabPageNewReporters.TabIndex = 1
        Me.TabPageNewReporters.Text = "Add New Reporter"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(550, 329)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "More than Just Reporters"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(307, 435)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 15)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Head for Tickets"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(432, 407)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Had enough"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(353, 466)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Return  To Main Menu "
        '
        'Reporters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(616, 495)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnMainmenu)
        Me.Controls.Add(Me.TabControlReporters)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnOpenTicks)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnLogOut)
        Me.Name = "Reporters"
        Me.Text = "                                              Reporters"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlReporters.ResumeLayout(False)
        Me.TabPageCurrentReporters.ResumeLayout(False)
        Me.TabPageCurrentReporters.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageNewReporters.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAddReporter As System.Windows.Forms.Button
    Friend WithEvents CboReportersreporterform As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOpenTicks As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtreporteremail As System.Windows.Forms.TextBox
    Friend WithEvents txtreporterLname As System.Windows.Forms.TextBox
    Friend WithEvents txtReporterFNam As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnMainmenu As System.Windows.Forms.Button
    Friend WithEvents BtnLogOut As System.Windows.Forms.Button
    Friend WithEvents BtnVeiwReporter As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnReporterPicture As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabControlReporters As System.Windows.Forms.TabControl
    Friend WithEvents TabPageCurrentReporters As System.Windows.Forms.TabPage
    Friend WithEvents TabPageNewReporters As System.Windows.Forms.TabPage
    Friend WithEvents cboCategoriesReporters As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnEmail As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lstReporters As System.Windows.Forms.ListBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnViewSelected As System.Windows.Forms.Button
    Friend WithEvents ComboDeps As System.Windows.Forms.ComboBox
    Friend WithEvents OK_Button As System.Windows.Forms.Button
End Class
