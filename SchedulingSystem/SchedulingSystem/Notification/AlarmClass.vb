Public Class AlarmClass

    Friend Shared Property reminders As New Stack(Of Reminder)
    Friend Shared Property nextDate As Date

    Friend Shared Sub updateReminder()
        Dim db As New ScheduleDBDataContext

        Dim rs = From r In db.Reminders
                 Where r.ReminderDateTime.Value.Date.Equals(DateTime.Now.Date) And r.ReminderDateTime < DateTime.Now.AddMinutes(3)
                 Order By r.ReminderDateTime Descending

        For Each item As Reminder In rs
            reminders.Push(item)
        Next

    End Sub

    Friend Shared Sub triggerAlarm(ByVal scheduleID As Integer)

    End Sub


End Class
