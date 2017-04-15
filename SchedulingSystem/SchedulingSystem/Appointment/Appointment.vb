Public Class Appointment
    Public Property Date1 As String
    Public Property StartTime As String
    Public Property EndTime As String
    Public Property Title As String

    Public Sub New(date1 As String, starttime As String, endtime As String, title As String)
        Me.Date1 = date1
        Me.StartTime = starttime
        Me.EndTime = endtime
        Me.Title = title
    End Sub
End Class
