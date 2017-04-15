Public Class ScheduleViewPanel
    Friend scheduleTimeId As Integer

    Private Sub ScheduleViewPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Function getSchedule() As ScheduleClass

        Dim db As New ScheduleDBDataContext

        Dim rs = From s In db.Schedules, st In db.ScheduleTimes
                 Where st.ScheduleTimeId = scheduleTimeId And
                     s.ScheduleID = st.ScheduleID
        Dim tempSchedule As New ScheduleClass(rs.FirstOrDefault.s.ScheduleID, CDate(rs.FirstOrDefault.st.ScheduleStart), CDate(rs.FirstOrDefault.st.ScheduleEnd),
                                              CDate(rs.FirstOrDefault.s.RepeatDue), rs.FirstOrDefault.s.RepeatBehavior.ToArray.First(), rs.FirstOrDefault.s.Title,
                                              rs.FirstOrDefault.s.Description, rs.FirstOrDefault.s.Venue, rs.FirstOrDefault.s.Type, rs.FirstOrDefault.s.Status)
        Return tempSchedule

    End Function
End Class
