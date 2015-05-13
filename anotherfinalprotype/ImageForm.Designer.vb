<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageForm
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Btn_browseImages = New System.Windows.Forms.Button()
        Me.PicImage = New System.Windows.Forms.PictureBox()
        Me.btn__AddtoReporters = New System.Windows.Forms.Button()
        Me.btn_AddtoTechimagestable = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataSet1 = New System.Data.DataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_ReturntoReporters = New System.Windows.Forms.Button()
        Me.Btn_ReturnTOTechs = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnViewTech = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_reporters = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboTechID = New System.Windows.Forms.ComboBox()
        Me.ComboReportID = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.PicImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(129, 190)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(227, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Btn_browseImages
        '
        Me.Btn_browseImages.BackColor = System.Drawing.Color.Red
        Me.Btn_browseImages.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_browseImages.Location = New System.Drawing.Point(98, 19)
        Me.Btn_browseImages.Name = "Btn_browseImages"
        Me.Btn_browseImages.Size = New System.Drawing.Size(135, 24)
        Me.Btn_browseImages.TabIndex = 1
        Me.Btn_browseImages.Text = "Browse Images"
        Me.Btn_browseImages.UseVisualStyleBackColor = False
        '
        'PicImage
        '
        Me.PicImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicImage.Location = New System.Drawing.Point(57, 49)
        Me.PicImage.Name = "PicImage"
        Me.PicImage.Size = New System.Drawing.Size(299, 108)
        Me.PicImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicImage.TabIndex = 3
        Me.PicImage.TabStop = False
        '
        'btn__AddtoReporters
        '
        Me.btn__AddtoReporters.Location = New System.Drawing.Point(224, 238)
        Me.btn__AddtoReporters.Name = "btn__AddtoReporters"
        Me.btn__AddtoReporters.Size = New System.Drawing.Size(149, 23)
        Me.btn__AddtoReporters.TabIndex = 4
        Me.btn__AddtoReporters.Text = "Reporters"
        Me.btn__AddtoReporters.UseVisualStyleBackColor = True
        '
        'btn_AddtoTechimagestable
        '
        Me.btn_AddtoTechimagestable.Location = New System.Drawing.Point(9, 238)
        Me.btn_AddtoTechimagestable.Name = "btn_AddtoTechimagestable"
        Me.btn_AddtoTechimagestable.Size = New System.Drawing.Size(149, 23)
        Me.btn_AddtoTechimagestable.TabIndex = 5
        Me.btn_AddtoTechimagestable.Text = "Technicans table"
        Me.btn_AddtoTechimagestable.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Add to Reporters image table"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(221, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Add to Technicans image table"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 8
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_ReturntoReporters)
        Me.GroupBox1.Controls.Add(Me.Btn_ReturnTOTechs)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.BtnViewTech)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btn_reporters)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CboTechID)
        Me.GroupBox1.Controls.Add(Me.ComboReportID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btn_AddtoTechimagestable)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Btn_browseImages)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.PicImage)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn__AddtoReporters)
        Me.GroupBox1.Location = New System.Drawing.Point(54, 190)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(622, 398)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = "Name"
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Btn_ReturntoReporters
        '
        Me.Btn_ReturntoReporters.Location = New System.Drawing.Point(460, 318)
        Me.Btn_ReturntoReporters.Name = "Btn_ReturntoReporters"
        Me.Btn_ReturntoReporters.Size = New System.Drawing.Size(137, 23)
        Me.Btn_ReturntoReporters.TabIndex = 21
        Me.Btn_ReturntoReporters.Text = "Return To Reporters"
        Me.Btn_ReturntoReporters.UseVisualStyleBackColor = True
        '
        'Btn_ReturnTOTechs
        '
        Me.Btn_ReturnTOTechs.Location = New System.Drawing.Point(460, 284)
        Me.Btn_ReturnTOTechs.Name = "Btn_ReturnTOTechs"
        Me.Btn_ReturnTOTechs.Size = New System.Drawing.Size(137, 23)
        Me.Btn_ReturnTOTechs.TabIndex = 20
        Me.Btn_ReturnTOTechs.Text = "Return to Techs"
        Me.Btn_ReturnTOTechs.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(232, 319)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "View Reporters"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BtnViewTech
        '
        Me.BtnViewTech.Location = New System.Drawing.Point(9, 319)
        Me.BtnViewTech.Name = "BtnViewTech"
        Me.BtnViewTech.Size = New System.Drawing.Size(75, 23)
        Me.BtnViewTech.TabIndex = 18
        Me.BtnViewTech.Text = "View Tech"
        Me.BtnViewTech.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(401, 49)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(140, 108)
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(235, 268)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Retrieve techs"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Retrieve Reporters"
        '
        'btn_reporters
        '
        Me.btn_reporters.Location = New System.Drawing.Point(232, 284)
        Me.btn_reporters.Name = "btn_reporters"
        Me.btn_reporters.Size = New System.Drawing.Size(124, 23)
        Me.btn_reporters.TabIndex = 14
        Me.btn_reporters.Text = "Retrieve Reporters pic" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_reporters.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Retrieve Technican pic"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(245, 351)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "select Reporter ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 345)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Selected TechID"
        '
        'CboTechID
        '
        Me.CboTechID.FormattingEnabled = True
        Me.CboTechID.Location = New System.Drawing.Point(18, 361)
        Me.CboTechID.Name = "CboTechID"
        Me.CboTechID.Size = New System.Drawing.Size(121, 21)
        Me.CboTechID.TabIndex = 10
        '
        'ComboReportID
        '
        Me.ComboReportID.FormattingEnabled = True
        Me.ComboReportID.Location = New System.Drawing.Point(235, 371)
        Me.ComboReportID.Name = "ComboReportID"
        Me.ComboReportID.Size = New System.Drawing.Size(121, 21)
        Me.ComboReportID.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(437, 147)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(48, 10)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(357, 121)
        Me.DataGridView1.TabIndex = 0
        '
        'ImageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 625)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Name = "ImageForm"
        Me.Text = "ImageForm"
        CType(Me.PicImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Btn_browseImages As System.Windows.Forms.Button
    Friend WithEvents PicImage As System.Windows.Forms.PictureBox
    Friend WithEvents btn__AddtoReporters As System.Windows.Forms.Button
    Friend WithEvents btn_AddtoTechimagestable As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CboTechID As System.Windows.Forms.ComboBox
    Friend WithEvents ComboReportID As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_reporters As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents BtnViewTech As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_ReturntoReporters As System.Windows.Forms.Button
    Friend WithEvents Btn_ReturnTOTechs As System.Windows.Forms.Button
End Class
