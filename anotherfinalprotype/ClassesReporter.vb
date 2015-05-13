'these are the various classed which I used to store and use information from the tickets, reporters Technicans
Public Class ClassesReporter
    Private _reporterID As Integer
    Public Property ReporterID() As Integer
        Get
            Return _reporterID

        End Get
        Set(value As Integer)
            _reporterID = value

        End Set
    End Property
    Private _reporterfirstName As String
    Public Property ReporterfirstName() As String
        Get
            Return _reporterfirstName
        End Get
        Set(value As String)
            _reporterfirstName = value
        End Set
    End Property
    Private _reporterlastName As String
    Public Property ReporterlastName() As String
        Get
            Return _reporterlastName
        End Get
        Set(value As String)
            _reporterlastName = value
        End Set
    End Property
    Private _reporterdepartment As String
    Public Property Reporterdepartment() As String
        Get
            Return _reporterdepartment

        End Get
        Set(value As String)
            _reporterdepartment = value
        End Set
    End Property
    Private _reporteremail As String
    Public Property Reporteremail() As String
        Get
            Return _reporteremail
        End Get
        Set(value As String)
            _reporteremail = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return ReporterfirstName + ", " + ReporterlastName + ", " + Reporterdepartment + ", " + Reporteremail
    End Function
End Class
'the next is the class for Technicans
Public Class classesTechnicans
    Private _idTechs As Integer
    Public Property IdTechs() As Integer
        Get
            Return _idTechs
        End Get
        Set(value As Integer)
            _idTechs = value
        End Set
    End Property
    Private _techfirstname As String
    Public Property Techfirstname() As String
        Get
            Return _techfirstname
        End Get
        Set(value As String)
            _techfirstname = value
        End Set
    End Property
    Private _techlastname As String
    Public Property Techlastname() As String
        Get
            Return _techlastname
        End Get
        Set(value As String)
            _techlastname = value
        End Set
    End Property
    Private _technicanjob As String
    Public Property Technicanjob() As String
        Get
            Return _technicanjob
        End Get
        Set(value As String)
            _technicanjob = value
        End Set
    End Property
    Private _techemail As String
    Public Property Techemail() As String
        Get
            Return _techemail
        End Get
        Set(value As String)
            _techemail = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return Techfirstname + ", " + Techlastname + ", " + Technicanjob + ", " + Techemail
    End Function

End Class
'full ticket but has not yet ispo defacto been assigned to another technican
Public Class NewTicket
    Private _ticketID As Integer
    Private _ticketdescription As String
    Private _tickurgency As Integer
    Private _ticketopendate As Date
    Private _ticketclosedate As Date
    Private _whatresovled As String
    Public Property TicketID() As Integer
        Get
            Return _ticketID

        End Get
        Set(value As Integer)
            _ticketID = value

        End Set
    End Property
    Public Property Tickurgency() As Integer
        Get
            Return _tickurgency
        End Get
        Set(value As Integer)
            _tickurgency = value
        End Set
    End Property
    Public Property Ticketdescription() As String
        Get
            Return _ticketdescription

        End Get
        Set(value As String)
            _ticketdescription = value
        End Set
    End Property
    Private _personreporting As Integer
    Public Property Personreporting() As Integer
        Get
            Return _personreporting

        End Get
        Set(value As Integer)
            _personreporting = value

        End Set
    End Property
    Public Property Ticketclosedate() As Date
        Get
            Return _ticketclosedate

        End Get
        Set(value As Date)
            _ticketclosedate = value
        End Set
    End Property
    Public Property Ticketopendate() As Date
        Get
            Return _ticketopendate
        End Get
        Set(value As Date)
            _ticketopendate = value

        End Set
    End Property
    Private _resolved As String
    Public Property Resolved() As String
        Get
            Return _resolved
        End Get
        Set(value As String)
            _resolved = value
        End Set
    End Property
    Private _reporterperson As ClassesReporter
    Public Property TheReporter() As ClassesReporter
        Get
            Return _reporterperson
        End Get
        Set(value As ClassesReporter)
            _reporterperson = value
        End Set
    End Property
    Public Property Whatresolved As String
        Get
            Return _whatresovled
        End Get
        Set(value As String)
            _whatresovled = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Ticketdescription + ", " + Ticketopendate.ToShortDateString + ", " + Ticketclosedate.ToShortDateString + ", " + Resolved + ", " + Whatresolved


        ' Return String.Format("{0} stars - {1}, {2}, {3}, {4}, {5}, {6} ", TicketID + ", " + Ticketdescription + ", " + Tickurgency + ", " + Ticketclosedate.ToShortDateString + ", " + Ticketopendate.ToShortDateString + ", " + Whatresolved + ", " + Personreporting + ", " + Resolved)
        'Return String.Format("{0} stars - {1}
        'Return Ticketclosedate.ToShortDateString + ", " + Ticketopendate.ToShortDateString + ", " + Whatresolved + ", " + Personreporting + ", " + Resolved
    End Function
End Class

'a class for Assigned ticket to Technican for work to be done
Public Class Techticketassignment
    Private _techjoinedID As Integer
    Private _ticketjoinedID As Integer
    Public Property TechjoinedID() As Integer
        Get
            Return _techjoinedID

        End Get
        Set(value As Integer)
            _techjoinedID = value
        End Set
    End Property
    Public Property TicketjoinedID() As Integer
        Get
            Return _ticketjoinedID
        End Get
        Set(value As Integer)
            _ticketjoinedID = value

        End Set
    End Property
End Class
'Public Class listviewtechnican
'    Dim i As Integer = 0
'    Dim j As Integer = 0

'        For i = 0 To ds.Tables(0).Columns.Count - 1
'            Me.ListViewTechnicanswithUnresolvedtics.Columns.Add(ds.Tables(0).Columns(i).ColumnName.ToString())

'        Next

'    'addin itmes to technicans list view
'        For i = 0 To ds.Tables(0).Rows.Count - 1

'            For j = 0 To ds.Tables(0).Columns.Count - 1
'                itemcoll(j) = ds.Tables(0).Rows(i)(j).ToString()

'            Next
'    Dim lvi As New ListViewItem(itemcoll)
'            Me.ListViewTechnicanswithUnresolvedtics.Items.Add(lvi)

'            Me.ListViewTechnicanswithUnresolvedtics.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

'        Next

'End Class