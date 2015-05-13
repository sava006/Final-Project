<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTechnicans = New System.Windows.Forms.Button()
        Me.btnReporters = New System.Windows.Forms.Button()
        Me.tbnCreateTickets = New System.Windows.Forms.Button()
        Me.btnCurrentOutstandingTicket = New System.Windows.Forms.Button()
        Me.btnArchives = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'btnTechnicans
        '
        Me.btnTechnicans.BackColor = System.Drawing.Color.Yellow
        Me.btnTechnicans.Font = New System.Drawing.Font("Britannic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTechnicans.ForeColor = System.Drawing.Color.Red
        Me.btnTechnicans.Location = New System.Drawing.Point(12, 12)
        Me.btnTechnicans.Name = "btnTechnicans"
        Me.btnTechnicans.Size = New System.Drawing.Size(91, 23)
        Me.btnTechnicans.TabIndex = 1
        Me.btnTechnicans.Text = "TECHNICANS"
        Me.btnTechnicans.UseVisualStyleBackColor = False
        '
        'btnReporters
        '
        Me.btnReporters.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporters.ForeColor = System.Drawing.Color.Blue
        Me.btnReporters.Location = New System.Drawing.Point(12, 51)
        Me.btnReporters.Name = "btnReporters"
        Me.btnReporters.Size = New System.Drawing.Size(253, 23)
        Me.btnReporters.TabIndex = 2
        Me.btnReporters.Text = "Employees With Service Requests"
        Me.btnReporters.UseVisualStyleBackColor = True
        '
        'tbnCreateTickets
        '
        Me.tbnCreateTickets.Location = New System.Drawing.Point(12, 92)
        Me.tbnCreateTickets.Name = "tbnCreateTickets"
        Me.tbnCreateTickets.Size = New System.Drawing.Size(172, 23)
        Me.tbnCreateTickets.TabIndex = 3
        Me.tbnCreateTickets.Text = "Need A New Ticket????"
        Me.tbnCreateTickets.UseVisualStyleBackColor = True
        '
        'btnCurrentOutstandingTicket
        '
        Me.btnCurrentOutstandingTicket.Location = New System.Drawing.Point(12, 131)
        Me.btnCurrentOutstandingTicket.Name = "btnCurrentOutstandingTicket"
        Me.btnCurrentOutstandingTicket.Size = New System.Drawing.Size(180, 23)
        Me.btnCurrentOutstandingTicket.TabIndex = 4
        Me.btnCurrentOutstandingTicket.Text = "Current OutStanding tickets"
        Me.btnCurrentOutstandingTicket.UseVisualStyleBackColor = True
        '
        'btnArchives
        '
        Me.btnArchives.Location = New System.Drawing.Point(8, 172)
        Me.btnArchives.Name = "btnArchives"
        Me.btnArchives.Size = New System.Drawing.Size(123, 23)
        Me.btnArchives.TabIndex = 5
        Me.btnArchives.Text = "Ticket Archives"
        Me.btnArchives.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(583, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "rember to add message boxes and text to guide your boss throught GUI"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 285)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnArchives)
        Me.Controls.Add(Me.btnCurrentOutstandingTicket)
        Me.Controls.Add(Me.tbnCreateTickets)
        Me.Controls.Add(Me.btnReporters)
        Me.Controls.Add(Me.btnTechnicans)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainMenu"
        Me.Text = "                           Main Manager Window"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnTechnicans As System.Windows.Forms.Button
    Friend WithEvents btnReporters As System.Windows.Forms.Button
    Friend WithEvents tbnCreateTickets As System.Windows.Forms.Button
    Friend WithEvents btnCurrentOutstandingTicket As System.Windows.Forms.Button
    Friend WithEvents btnArchives As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
