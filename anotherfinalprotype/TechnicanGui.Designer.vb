<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TechnicanGui
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
        Me.CboCurrentTechnicans = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTechFirstName = New System.Windows.Forms.TextBox()
        Me.txtTechLastName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTechemail = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.btnAddNewTechnican = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CboTechnicansJob = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnSelectTech = New System.Windows.Forms.Button()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnTicketWindow = New System.Windows.Forms.Button()
        Me.BtnLogOut = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabControlTechnicans = New System.Windows.Forms.TabControl()
        Me.TabPageCurrentTechs = New System.Windows.Forms.TabPage()
        Me.Btn_DeleteTech = New System.Windows.Forms.Button()
        Me.btnDisplayAllTechs = New System.Windows.Forms.Button()
        Me.ListViewTechnicanswithUnresolvedtics = New System.Windows.Forms.ListView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnEmailTech = New System.Windows.Forms.Button()
        Me.TabPageAddTechnicans = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlTechnicans.SuspendLayout()
        Me.TabPageCurrentTechs.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageAddTechnicans.SuspendLayout()
        Me.SuspendLayout()
        '
        'CboCurrentTechnicans
        '
        Me.CboCurrentTechnicans.FormattingEnabled = True
        Me.CboCurrentTechnicans.Location = New System.Drawing.Point(214, 19)
        Me.CboCurrentTechnicans.Name = "CboCurrentTechnicans"
        Me.CboCurrentTechnicans.Size = New System.Drawing.Size(121, 24)
        Me.CboCurrentTechnicans.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Current Technican in system"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 2
        '
        'txtTechFirstName
        '
        Me.txtTechFirstName.Location = New System.Drawing.Point(197, 30)
        Me.txtTechFirstName.Name = "txtTechFirstName"
        Me.txtTechFirstName.Size = New System.Drawing.Size(121, 24)
        Me.txtTechFirstName.TabIndex = 3
        '
        'txtTechLastName
        '
        Me.txtTechLastName.Location = New System.Drawing.Point(197, 70)
        Me.txtTechLastName.Name = "txtTechLastName"
        Me.txtTechLastName.Size = New System.Drawing.Size(121, 24)
        Me.txtTechLastName.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(123, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "First Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(107, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Last Name :"
        '
        'txtTechemail
        '
        Me.txtTechemail.Location = New System.Drawing.Point(197, 127)
        Me.txtTechemail.Name = "txtTechemail"
        Me.txtTechemail.Size = New System.Drawing.Size(121, 24)
        Me.txtTechemail.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.OK_Button)
        Me.GroupBox1.Controls.Add(Me.btnAddNewTechnican)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.CboTechnicansJob)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtTechFirstName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtTechemail)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtTechLastName)
        Me.GroupBox1.Location = New System.Drawing.Point(83, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(481, 219)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "                     New Technican Information"
        '
        'OK_Button
        '
        Me.OK_Button.Location = New System.Drawing.Point(200, 190)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(163, 23)
        Me.OK_Button.TabIndex = 17
        Me.OK_Button.Text = "Go to assing ticket"
        Me.OK_Button.UseVisualStyleBackColor = True
        '
        'btnAddNewTechnican
        '
        Me.btnAddNewTechnican.Location = New System.Drawing.Point(6, 77)
        Me.btnAddNewTechnican.Name = "btnAddNewTechnican"
        Me.btnAddNewTechnican.Size = New System.Drawing.Size(75, 23)
        Me.btnAddNewTechnican.TabIndex = 11
        Me.btnAddNewTechnican.Text = "New Tech"
        Me.btnAddNewTechnican.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(-1, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(257, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Please Up Load a Photo if you have it :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(334, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 133)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(262, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "UpLoad Foto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CboTechnicansJob
        '
        Me.CboTechnicansJob.FormattingEnabled = True
        Me.CboTechnicansJob.Items.AddRange(New Object() {"Technical Support", "Supply Officer", "Maintaince Tech", "Shop Mechnanic", "Cleaner", "Cook", "Building Security"})
        Me.CboTechnicansJob.Location = New System.Drawing.Point(197, 99)
        Me.CboTechnicansJob.Name = "CboTechnicansJob"
        Me.CboTechnicansJob.Size = New System.Drawing.Size(121, 24)
        Me.CboTechnicansJob.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(75, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Technican's Job :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(123, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "email :"
        '
        'BtnSelectTech
        '
        Me.BtnSelectTech.Location = New System.Drawing.Point(181, 49)
        Me.BtnSelectTech.Name = "BtnSelectTech"
        Me.BtnSelectTech.Size = New System.Drawing.Size(182, 23)
        Me.BtnSelectTech.TabIndex = 9
        Me.BtnSelectTech.Text = "Select Technican To view"
        Me.BtnSelectTech.UseVisualStyleBackColor = True
        '
        'btnMain
        '
        Me.btnMain.Location = New System.Drawing.Point(124, 303)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(55, 23)
        Me.btnMain.TabIndex = 10
        Me.btnMain.Text = "Main"
        Me.btnMain.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "return to main menu :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(185, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(247, 18)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "return Return To Open Tickets :"
        '
        'BtnTicketWindow
        '
        Me.BtnTicketWindow.Location = New System.Drawing.Point(433, 304)
        Me.BtnTicketWindow.Name = "BtnTicketWindow"
        Me.BtnTicketWindow.Size = New System.Drawing.Size(55, 23)
        Me.BtnTicketWindow.TabIndex = 14
        Me.BtnTicketWindow.Text = "tickets"
        Me.BtnTicketWindow.UseVisualStyleBackColor = True
        '
        'BtnLogOut
        '
        Me.BtnLogOut.Location = New System.Drawing.Point(528, 304)
        Me.BtnLogOut.Name = "BtnLogOut"
        Me.BtnLogOut.Size = New System.Drawing.Size(75, 23)
        Me.BtnLogOut.TabIndex = 15
        Me.BtnLogOut.Text = "Log Out"
        Me.BtnLogOut.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(73, 339)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(458, 96)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "a Command line promt is better for viewing" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ticket information of one Techncians " & _
    "or all techs" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "I am thinking there are more possibilities in here" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "as well."
        '
        'TabControlTechnicans
        '
        Me.TabControlTechnicans.Controls.Add(Me.TabPageCurrentTechs)
        Me.TabControlTechnicans.Controls.Add(Me.TabPageAddTechnicans)
        Me.TabControlTechnicans.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlTechnicans.Location = New System.Drawing.Point(29, 12)
        Me.TabControlTechnicans.Name = "TabControlTechnicans"
        Me.TabControlTechnicans.SelectedIndex = 0
        Me.TabControlTechnicans.Size = New System.Drawing.Size(578, 274)
        Me.TabControlTechnicans.TabIndex = 17
        '
        'TabPageCurrentTechs
        '
        Me.TabPageCurrentTechs.BackColor = System.Drawing.Color.Lime
        Me.TabPageCurrentTechs.Controls.Add(Me.Button2)
        Me.TabPageCurrentTechs.Controls.Add(Me.Btn_DeleteTech)
        Me.TabPageCurrentTechs.Controls.Add(Me.btnDisplayAllTechs)
        Me.TabPageCurrentTechs.Controls.Add(Me.ListViewTechnicanswithUnresolvedtics)
        Me.TabPageCurrentTechs.Controls.Add(Me.PictureBox2)
        Me.TabPageCurrentTechs.Controls.Add(Me.Label11)
        Me.TabPageCurrentTechs.Controls.Add(Me.btnEmailTech)
        Me.TabPageCurrentTechs.Controls.Add(Me.CboCurrentTechnicans)
        Me.TabPageCurrentTechs.Controls.Add(Me.Label1)
        Me.TabPageCurrentTechs.Controls.Add(Me.BtnSelectTech)
        Me.TabPageCurrentTechs.Location = New System.Drawing.Point(4, 25)
        Me.TabPageCurrentTechs.Name = "TabPageCurrentTechs"
        Me.TabPageCurrentTechs.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCurrentTechs.Size = New System.Drawing.Size(570, 245)
        Me.TabPageCurrentTechs.TabIndex = 0
        Me.TabPageCurrentTechs.Text = "Current Technicans"
        '
        'Btn_DeleteTech
        '
        Me.Btn_DeleteTech.Location = New System.Drawing.Point(362, 143)
        Me.Btn_DeleteTech.Name = "Btn_DeleteTech"
        Me.Btn_DeleteTech.Size = New System.Drawing.Size(155, 23)
        Me.Btn_DeleteTech.TabIndex = 16
        Me.Btn_DeleteTech.Text = "Delete Technican"
        Me.Btn_DeleteTech.UseVisualStyleBackColor = True
        '
        'btnDisplayAllTechs
        '
        Me.btnDisplayAllTechs.Location = New System.Drawing.Point(44, 71)
        Me.btnDisplayAllTechs.Name = "btnDisplayAllTechs"
        Me.btnDisplayAllTechs.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplayAllTechs.TabIndex = 15
        Me.btnDisplayAllTechs.Text = "View all"
        Me.btnDisplayAllTechs.UseVisualStyleBackColor = True
        '
        'ListViewTechnicanswithUnresolvedtics
        '
        Me.ListViewTechnicanswithUnresolvedtics.Location = New System.Drawing.Point(29, 114)
        Me.ListViewTechnicanswithUnresolvedtics.Name = "ListViewTechnicanswithUnresolvedtics"
        Me.ListViewTechnicanswithUnresolvedtics.Size = New System.Drawing.Size(306, 107)
        Me.ListViewTechnicanswithUnresolvedtics.TabIndex = 14
        Me.ListViewTechnicanswithUnresolvedtics.UseCompatibleStateImageBehavior = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(382, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(143, 90)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(394, 124)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 16)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Label11"
        '
        'btnEmailTech
        '
        Me.btnEmailTech.Location = New System.Drawing.Point(362, 202)
        Me.btnEmailTech.Name = "btnEmailTech"
        Me.btnEmailTech.Size = New System.Drawing.Size(136, 23)
        Me.btnEmailTech.TabIndex = 11
        Me.btnEmailTech.Text = "Email Tech a list"
        Me.btnEmailTech.UseVisualStyleBackColor = True
        '
        'TabPageAddTechnicans
        '
        Me.TabPageAddTechnicans.Controls.Add(Me.GroupBox1)
        Me.TabPageAddTechnicans.Location = New System.Drawing.Point(4, 25)
        Me.TabPageAddTechnicans.Name = "TabPageAddTechnicans"
        Me.TabPageAddTechnicans.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageAddTechnicans.Size = New System.Drawing.Size(570, 245)
        Me.TabPageAddTechnicans.TabIndex = 1
        Me.TabPageAddTechnicans.Text = "New Technicans"
        Me.TabPageAddTechnicans.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(172, 78)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "View selected tech photo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TechnicanGui
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(781, 354)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnLogOut)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TabControlTechnicans)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BtnTicketWindow)
        Me.Controls.Add(Me.Label2)
        Me.Name = "TechnicanGui"
        Me.Text = "                           Technicals"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlTechnicans.ResumeLayout(False)
        Me.TabPageCurrentTechs.ResumeLayout(False)
        Me.TabPageCurrentTechs.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageAddTechnicans.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CboCurrentTechnicans As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTechFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtTechLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTechemail As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddNewTechnican As System.Windows.Forms.Button
    Friend WithEvents CboTechnicansJob As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnSelectTech As System.Windows.Forms.Button
    Friend WithEvents btnMain As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnTicketWindow As System.Windows.Forms.Button
    Friend WithEvents BtnLogOut As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TabControlTechnicans As System.Windows.Forms.TabControl
    Friend WithEvents TabPageCurrentTechs As System.Windows.Forms.TabPage
    Friend WithEvents TabPageAddTechnicans As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnEmailTech As System.Windows.Forms.Button
    Friend WithEvents ListViewTechnicanswithUnresolvedtics As System.Windows.Forms.ListView
    Friend WithEvents btnDisplayAllTechs As System.Windows.Forms.Button
    Friend WithEvents Btn_DeleteTech As System.Windows.Forms.Button
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
