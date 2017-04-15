Public Class ApmtNoticeDetail
    Public Property ScheduleID As Integer
    Public Property Title As String
    Public Property Description As String
    Public Property Venue As String
    Public Property ScheduleTime As String
    Public Property Inviter As String

    Public Sub tempNotice(scheduleID As Integer, title As String, description As String, venue As String, scheduleTime As String, inviter As String)
        Me.ScheduleID = scheduleID
        Me.Title = title
        Me.Description = description
        Me.Venue = venue
        Me.ScheduleTime = scheduleTime
        Me.Inviter = inviter
    End Sub

    Public Sub New()
        Me.ScheduleID = Nothing
        Me.Title = Nothing
        Me.Description = Nothing
        Me.Venue = Nothing
        Me.ScheduleTime = Nothing
        Me.Inviter = Nothing
    End Sub
End Class
