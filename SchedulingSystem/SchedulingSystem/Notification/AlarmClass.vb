Public Class AlarmClass

    Friend Shared Property reminders As New Stack(Of Reminder)
    Friend Shared Property nextDate As Date

    Friend Shared Sub updateReminder()
        Dim db As New ScheduleDBDataContext

        Dim rs = From r In db.Reminders
                 Where r.ReminderDateTime.Value.Date.Equals(DateTime.Now.Date) And r.ReminderDateTime > DateTime.Now
                 Order By r.ReminderDateTime Descending

        For Each item As Reminder In rs
            Console.WriteLine(item.ReminderDateTime.ToString)
            reminders.Push(item)
        Next

    End Sub

    Friend Shared Sub triggerAlarm(ByVal scheduleID As Integer, ByVal minutes As Integer)
        Static Dim trigger As Boolean = True
        Dim x As Integer = 0

        If trigger Then
            trigger = False
            My.Computer.Audio.Play(My.Resources.SoftMusic, AudioPlayMode.Background)

            Dim db As New ScheduleDBDataContext

            Dim s As Schedule = db.Schedules.FirstOrDefault(Function(o) o.ScheduleID = scheduleID)

            Dim message As String = "You have the following activity after [" & minutes & "minutes]:" & vbNewLine &
            "Activity Title : " & s.Title & vbNewLine &
            "Venue : " & s.Venue
            x = MessageBox.Show(message, "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If x = MsgBoxResult.Ok Then
            My.Computer.Audio.Stop()
            trigger = True
        End If

    End Sub


End Class
