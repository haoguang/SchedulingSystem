Module RepeatationModule

    Friend Sub deleteScheduleTimeRecord(scheduleID As Integer)
        Dim db As New ScheduleDBDataContext

        Dim rs = db.ScheduleTimes.Where(Function(st) st.ScheduleID = scheduleID And st.InitialTime = False)

        db.ScheduleTimes.DeleteAllOnSubmit(rs)
        db.SubmitChanges()

    End Sub

    Friend Sub generateScheduleTimeRecord(repeatation As RepeatationClass)
        Dim db As New ScheduleDBDataContext
        Dim startTime As DateTime
        Dim endTime As DateTime
        Dim scheduleTime As ScheduleTime


        For Each item In repeatation.startTimeList
            scheduleTime = New ScheduleTime
            startTime = item
            endTime = item.AddMinutes(repeatation.minDuration)
            With scheduleTime
                .ScheduleID = repeatation.scheduleID
                .ScheduleStart = startTime
                .ScheduleEnd = endTime
                .InitialTime = False
            End With

            db.ScheduleTimes.InsertOnSubmit(scheduleTime)
        Next

        db.SubmitChanges()

    End Sub

    Friend Function getNextDate(repeatString As String, tempDate As DateTime) As DateTime
        Select Case repeatString
            Case DAILY_STRING
                Return tempDate.AddDays(1)
            Case MONTHLY_STRING
                Return tempDate.AddMonths(1)
            Case TWICE_WEEK_STRING
                Return tempDate.AddDays(14)
            Case WEEKLY_STRING
                Return tempDate.AddDays(7)
            Case YEARLY_STRING
                Return tempDate.AddYears(1)
            Case Else
                Return tempDate
        End Select
    End Function

    Friend Function getRepeatStringArray() As String()

        Dim stringList As String() = {NONE_STRING, DAILY_STRING, WEEKLY_STRING, TWICE_WEEK_STRING, MONTHLY_STRING, YEARLY_STRING}
        Return stringList
    End Function

    Friend Function getRepeatString(repeatBehavior As Byte) As String
        Select Case repeatBehavior
            Case REPEAT_DAILY
                Return DAILY_STRING
            Case REPEAT_MONTHLY
                Return MONTHLY_STRING
            Case REPEAT_TWICE_WEEK
                Return TWICE_WEEK_STRING
            Case REPEAT_WEEKLY
                Return WEEKLY_STRING
            Case REPEAT_YEARLY
                Return YEARLY_STRING
            Case Else
                Return NONE_STRING
        End Select
    End Function

    Friend Function getRepeatBehavior(repeatString As String) As Byte
        Select Case repeatString
            Case DAILY_STRING
                Return REPEAT_DAILY
            Case MONTHLY_STRING
                Return REPEAT_MONTHLY
            Case TWICE_WEEK_STRING
                Return REPEAT_TWICE_WEEK
            Case WEEKLY_STRING
                Return REPEAT_WEEKLY
            Case YEARLY_STRING
                Return REPEAT_YEARLY
            Case Else
                Return REPEAT_NONE
        End Select
    End Function

    Friend Const REPEAT_NONE As Byte = 0
    Friend Const REPEAT_DAILY As Byte = 1
    Friend Const REPEAT_WEEKLY As Byte = 2
    Friend Const REPEAT_TWICE_WEEK As Byte = 4
    Friend Const REPEAT_MONTHLY As Byte = 8
    Friend Const REPEAT_YEARLY As Byte = 16

    Friend Const NONE_STRING As String = "None"
    Friend Const DAILY_STRING As String = "Daily"
    Friend Const WEEKLY_STRING As String = "Weekly"
    Friend Const TWICE_WEEK_STRING As String = "Twice a Week"
    Friend Const MONTHLY_STRING As String = "Monthly"
    Friend Const YEARLY_STRING As String = "Yearly"
End Module
