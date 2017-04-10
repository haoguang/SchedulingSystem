Module RepeatationModule

    Friend Sub generateScheduleTimeRecord(ScheduleID As Integer, RepeatString As String)
        Dim db As New ScheduleDBDataContext

        Dim scheduleTime = From st In db.ScheduleTimes, s In db.Schedules
                           Where st.ScheduleID = ScheduleID And st.InitialTime = True And st.ScheduleID = s.ScheduleID
                           Select st.ScheduleStart, st.ScheduleEnd, s.RepeatDue, s.RepeatBehavior

        Dim startTime As DateTime = CDate(scheduleTime.FirstOrDefault.ScheduleStart)
        Dim endTime As DateTime = CDate(scheduleTime.FirstOrDefault.ScheduleEnd)
        Dim dueDate As DateTime = CDate(scheduleTime.FirstOrDefault.RepeatDue)
        Dim repeatB As Byte = scheduleTime.FirstOrDefault.RepeatBehavior.ToArray(8)
        ' Not done yet
        '*
        '*
        '*
        '*
        '*
        '*
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

        Dim stringList As String() = {DAILY_STRING, WEEKLY_STRING, TWICE_WEEK_STRING, MONTHLY_STRING, YEARLY_STRING}
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
                Return "Invalid Repeat Behavior"
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
                Return 0
        End Select
    End Function

    Friend Const REPEAT_DAILY As Byte = 1
    Friend Const REPEAT_WEEKLY As Byte = 2
    Friend Const REPEAT_TWICE_WEEK As Byte = 4
    Friend Const REPEAT_MONTHLY As Byte = 8
    Friend Const REPEAT_YEARLY As Byte = 16

    Friend Const DAILY_STRING As String = "Daily"
    Friend Const WEEKLY_STRING As String = "Weekly"
    Friend Const TWICE_WEEK_STRING As String = "Twice a Week"
    Friend Const MONTHLY_STRING As String = "Monthly"
    Friend Const YEARLY_STRING As String = "Yearly"
End Module
