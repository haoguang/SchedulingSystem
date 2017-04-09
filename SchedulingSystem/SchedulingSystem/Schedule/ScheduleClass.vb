Public Class ScheduleClass
    Friend Property ScheduleStart As DateTime
    Friend Property ScheduleEnd As DateTime
    Friend Property RepeatDue As Date
    Friend Property RepeatBehavior As Byte
    Friend Property Title As String
    Friend Property ScheduleID As Integer
    Friend Property Description As String
    Friend Property Venue As String
    Friend Property Type As String
    Friend Property Status As String

    Sub New(ScheduleID As Integer, ScheduleStart As DateTime, ScheduleEnd As DateTime, RepeatDue As Date, RepeatBehavior As Byte, Title As String, Description As String, Venue As String, Type As String, Status As String)
        Me.ScheduleStart = ScheduleStart
        Me.ScheduleEnd = ScheduleEnd
        Me.RepeatDue = RepeatDue
        Me.RepeatBehavior = RepeatBehavior
        Me.Title = Title
        Me.ScheduleID = ScheduleID
        Me.Description = Description
        Me.Venue = Venue
        Me.Type = Type
        Me.Status = Status
    End Sub

    Friend Shared Function getTypeList() As String() 'Return all kind of type 
        Dim stringList As String() = {PERSONAL_TYPE, APPOINTMENT_TYPE, MEETING_TYPE, EVENT_TYPE, FAMILY_TYPE}
        Return stringList
    End Function

    'List of type for schedule
    Friend Shared ReadOnly PERSONAL_TYPE As String = "Personal"
    Friend Shared ReadOnly APPOINTMENT_TYPE As String = "Appointment"
    Friend Shared ReadOnly MEETING_TYPE As String = "Meeting"
    Friend Shared ReadOnly EVENT_TYPE As String = "Event"
    Friend Shared ReadOnly FAMILY_TYPE As String = "Family"

    'List of status for schedule
    Friend Shared ReadOnly CANCEL_STATUS As String = "Cancel"
    Friend Shared ReadOnly ENDED_STATUS As String = "Ended"
    Friend Shared ReadOnly ACTIVE_STATUS As String = "Active"
    Friend Shared ReadOnly PENDING_STATUS As String = "Pending"

    'List of participle type
    Friend Shared ReadOnly OWNER As String = "Owner"
    Friend Shared ReadOnly PARTICIPLE As String = "Participle"

    'List of participle status
    Friend Shared ReadOnly PARTICIPLE_PENDING As String = "Pending"
    Friend Shared ReadOnly PARTICIPLE_ATTENT As String = "Attend"




End Class
