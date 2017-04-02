Module ActivityModule
    Friend Const MAX_HEIGHT As Integer = 1250
    Friend Const MINS_ONE_DAY As Integer = 1440

    Friend Function calActivityHeight(startTime As DateTime, endTime As DateTime) As Double
        Return (calTimeDiffInMin(startTime, endTime) / MINS_ONE_DAY) * MAX_HEIGHT
    End Function

    Friend Function calTimeDiffInMin(startTime As DateTime, endTime As DateTime) As Double
        Return endTime.Subtract(startTime).TotalMinutes
    End Function

    Friend Function calActivityPosition(startTime As DateTime) As Double
        Dim time As TimeSpan = startTime.TimeOfDay
        Return (time).TotalMinutes / MINS_ONE_DAY * MAX_HEIGHT
    End Function

End Module
