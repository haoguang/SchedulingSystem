Module ActivityModule
    Friend Const MAX_HEIGHT As Integer = 1203
    Friend Const MINS_ONE_DAY As Integer = 1440
    Friend Const TOP_PADDING As Integer = 5

    Friend Function calActivityHeight(startTime As DateTime, endTime As DateTime) As Double
        Return (calTimeDiffInMin(startTime, endTime) / MINS_ONE_DAY) * MAX_HEIGHT
    End Function

    Friend Function calTimeDiffInMin(startTime As DateTime, endTime As DateTime) As Double
        Return endTime.Subtract(startTime).TotalMinutes
    End Function

    Friend Function calActivityPosition(startTime As DateTime) As Double
        Dim time As TimeSpan = startTime.TimeOfDay
        Return TOP_PADDING + (time.TotalMinutes / MINS_ONE_DAY * MAX_HEIGHT)

    End Function

    Friend Function IsOwner(ScheduleID As Integer) As Boolean
        Dim db As New ScheduleDBDataContext

        Dim p As Participle = db.Participles.FirstOrDefault(Function(o) o.ScheduleID = ScheduleID And o.MemberID = DevelopmentVariables.UserID)

        Return p.ParticiplesRole.Equals("Owner")
    End Function

    Friend Function dateValidator(tempDate As DateTime, userID As Integer) As Boolean
        Dim db As New ScheduleDBDataContext

        Dim rs = From s In db.Schedules, st In db.ScheduleTimes, p In db.Participles
                 Where p.MemberID = userID And p.ScheduleID = s.ScheduleID And
                     s.ScheduleID = st.ScheduleID And st.ScheduleStart <= tempDate And
                     s.Status = ScheduleClass.ACTIVE_STATUS And st.ScheduleEnd >= tempDate

        Return rs.Count > 0
    End Function

    Friend Function dateValidator2(tempDate As DateTime, tempDate2 As DateTime, userID As Integer) As Boolean
        Dim db As New ScheduleDBDataContext

        Dim rs = From s In db.Schedules, st In db.ScheduleTimes, p In db.Participles
                 Where p.MemberID = userID And p.ScheduleID = s.ScheduleID And
                     s.ScheduleID = st.ScheduleID And st.ScheduleStart >= tempDate And
                     s.Status = ScheduleClass.ACTIVE_STATUS And
                        st.ScheduleEnd <= tempDate2

        Return rs.Count > 0
    End Function
End Module
