<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmailingUpdatetoReporter
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
        Me.Btn_ViewSelectedReporterOpentic = New System.Windows.Forms.Button()
        Me.CboboxSelectReporterToEmail = New System.Windows.Forms.ComboBox()
        Me.Btn_EmailReporterThatMissionAcomplished = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_ViewSelectedReporterOpentic
        '
        Me.Btn_ViewSelectedReporterOpentic.Location = New System.Drawing.Point(11, 217)
        Me.Btn_ViewSelectedReporterOpentic.Name = "Btn_ViewSelectedReporterOpentic"
        Me.Btn_ViewSelectedReporterOpentic.Size = New System.Drawing.Size(136, 23)
        Me.Btn_ViewSelectedReporterOpentic.TabIndex = 0
        Me.Btn_ViewSelectedReporterOpentic.Text = "View selected Reporter"
        Me.Btn_ViewSelectedReporterOpentic.UseVisualStyleBackColor = True
        '
        'CboboxSelectReporterToEmail
        '
        Me.CboboxSelectReporterToEmail.BackColor = System.Drawing.Color.Lime
        Me.CboboxSelectReporterToEmail.FormattingEnabled = True
        Me.CboboxSelectReporterToEmail.Location = New System.Drawing.Point(261, 182)
        Me.CboboxSelectReporterToEmail.Name = "CboboxSelectReporterToEmail"
        Me.CboboxSelectReporterToEmail.Size = New System.Drawing.Size(172, 21)
        Me.CboboxSelectReporterToEmail.TabIndex = 1
        '
        'Btn_EmailReporterThatMissionAcomplished
        '
        Me.Btn_EmailReporterThatMissionAcomplished.Location = New System.Drawing.Point(11, 278)
        Me.Btn_EmailReporterThatMissionAcomplished.Name = "Btn_EmailReporterThatMissionAcomplished"
        Me.Btn_EmailReporterThatMissionAcomplished.Size = New System.Drawing.Size(124, 23)
        Me.Btn_EmailReporterThatMissionAcomplished.TabIndex = 2
        Me.Btn_EmailReporterThatMissionAcomplished.Text = "Email Reporter"
        Me.Btn_EmailReporterThatMissionAcomplished.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Lime
        Me.ListView1.Location = New System.Drawing.Point(23, 13)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(569, 153)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 34)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select a Reporter by Id To email" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "where   Their order is completed"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Lime
        Me.TextBox1.Location = New System.Drawing.Point(249, 248)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(195, 93)
        Me.TextBox1.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Lime
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(544, 182)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(175, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(555, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "reporter's email"
        '
        'EmailingUpdatetoReporter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(744, 414)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Btn_EmailReporterThatMissionAcomplished)
        Me.Controls.Add(Me.CboboxSelectReporterToEmail)
        Me.Controls.Add(Me.Btn_ViewSelectedReporterOpentic)
        Me.Name = "EmailingUpdatetoReporter"
        Me.Text = "EmailingUpdatetoReporter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_ViewSelectedReporterOpentic As System.Windows.Forms.Button
    Friend WithEvents CboboxSelectReporterToEmail As System.Windows.Forms.ComboBox
    Friend WithEvents Btn_EmailReporterThatMissionAcomplished As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
