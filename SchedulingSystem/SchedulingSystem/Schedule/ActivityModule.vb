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

End Module
