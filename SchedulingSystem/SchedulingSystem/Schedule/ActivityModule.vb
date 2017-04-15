Module ActivityModule
    Private schedule As ScheduleClass
    Friend Const MAX_HEIGHT As Integer = 1203
    Friend Const MINS_ONE_DAY As Integer = 1440
    Friend Const TOP_PADDING As Integer = 5

    Friend Function calActivityHeight(startTime As DateTime, endTime As DateTime, requestDate As Date) As Double
        Dim height As Double = (calTimeDiffInMin(startTime, endTime) / MINS_ONE_DAY) * MAX_HEIGHT

        If requestDate.CompareTo(endTime.Date) < 0 Then
            height = MAX_HEIGHT - calActivityPosition(startTime, endTime, requestDate)
        ElseIf requestDate.CompareTo(startTime.Date) > 0
            height = (calTimeDiffInMin(endTime.Date, endTime) / MINS_ONE_DAY) * MAX_HEIGHT
        End If

        Return height
    End Function

    Friend Function calTimeDiffInMin(startTime As DateTime, endTime As DateTime) As Double
        Return endTime.Subtract(startTime).TotalMinutes
    End Function

    Friend Function calActivityPosition(startTime As DateTime, endTime As DateTime, requestDate As Date) As Double
        Dim time As TimeSpan = startTime.TimeOfDay
        Dim position As Double = TOP_PADDING + (time.TotalMinutes / MINS_ONE_DAY * MAX_HEIGHT)

        If requestDate.CompareTo(startTime.Date) > 0 Then
            position = TOP_PADDING
        End If
        Return position

    End Function


    Friend Function IsOwner(ScheduleID As Integer) As Boolean
        Dim db As New ScheduleDBDataContext

        Dim p As Participle = db.Participles.FirstOrDefault(Function(o) o.ScheduleID = ScheduleID And o.MemberID = DevelopmentVariables.UserID)

        Return p.ParticiplesRole.Equals("Owner")
    End Function

    Friend Function dateValidator(tempDate As DateTime, userID As Integer, scheduleID As Integer) As Boolean
        Dim db As New ScheduleDBDataContext

        Dim rs = From s In db.Schedules, st In db.ScheduleTimes, p In db.Participles
                 Where p.MemberID = userID And p.ScheduleID = s.ScheduleID And
                     s.ScheduleID = st.ScheduleID And st.ScheduleStart <= tempDate And
                     s.Status = ScheduleClass.ACTIVE_STATUS And st.ScheduleEnd >= tempDate And
                     st.ScheduleID <> scheduleID

        Return rs.Count > 0
    End Function

    Friend Function dateValidator2(tempDate As DateTime, tempDate2 As DateTime, userID As Integer, scheduleID As Integer) As Boolean
        Dim db As New ScheduleDBDataContext

        Dim rs = From s In db.Schedules, st In db.ScheduleTimes, p In db.Participles
                 Where p.MemberID = userID And p.ScheduleID = s.ScheduleID And
                     s.ScheduleID = st.ScheduleID And st.ScheduleStart >= tempDate And
                     s.Status = ScheduleClass.ACTIVE_STATUS And
                     st.ScheduleEnd <= tempDate2 And st.ScheduleID <> scheduleID

        Return rs.Count > 0
    End Function

    Friend Function acceptAppointment(memberId As Integer, scheId As Integer, startDate As DateTime, endDate As DateTime) As Boolean
        Dim db As New ScheduleDBDataContext
        Dim status As Boolean
        If ActivityModule.dateValidator(startDate, memberId, -1) Then
            status = False
        ElseIf ActivityModule.dateValidator(endDate, memberId, -1) Then
            status = False
        ElseIf ActivityModule.dateValidator2(startDate, endDate, memberId, -1) Then
            status = False
        Else
            'update schedule table
            Dim s As Schedule = db.Schedules.FirstOrDefault(Function(o) o.ScheduleID = scheId)
            s.Status = "Active"
            db.SubmitChanges()

            'update participle table
            Dim p As Participle = db.Participles.FirstOrDefault(Function(o) o.ScheduleID = scheId And o.ParticiplesRole = "Participle")
            p.Status = "Attend"
            db.SubmitChanges()

            'assign true to status
            status = True
        End If
        Return status
    End Function

    Friend Function declineAppoinment(scheId As Integer) As Boolean
        Dim db As New ScheduleDBDataContext

        'update schedule table
        Dim s As Schedule = db.Schedules.FirstOrDefault(Function(o) o.ScheduleID = scheId)
        s.Status = "Cancel"
        db.SubmitChanges()

        'update participle table
        Dim p As Participle = db.Participles.FirstOrDefault(Function(o) o.ScheduleID = scheId And o.ParticiplesRole = "Participle")
        p.Status = "Decline"
        db.SubmitChanges()

        Return True
    End Function
End Module
