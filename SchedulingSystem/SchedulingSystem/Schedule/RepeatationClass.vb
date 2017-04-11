Imports System.Text

Public Class RepeatationClass
    Friend Property scheduleID As Integer
    Friend Property minDuration As Integer
    Friend Property initialStartDate As DateTime
    Friend Property startTimeList As ArrayList

    Sub New(scheduleID As Integer, startDate As DateTime, endDate As DateTime)
        Me.scheduleID = scheduleID
        Me.minDuration = calTimeDiffInMin(startDate, endDate)
        Me.initialStartDate = startDate
    End Sub

    Public Function generateDateArray(repeatBehavior As Byte, repeatDue As Date) As String ' return true when date duplicated in the db

        Dim tempDate As DateTime = initialStartDate
        Dim errorStr As New StringBuilder("Conflict occur on the dates :" & vbNewLine)
        Dim isConflict As Boolean = False

        Do While tempDate.CompareTo(repeatDue) <> 1
            tempDate = RepeatationModule.getNextDate(RepeatationModule.getRepeatString(repeatBehavior), tempDate)
            If ActivityModule.dateValidator(tempDate, DevelopmentVariables.UserID) Then
                errorStr.AppendLine(tempDate.ToString("dd/MM/yyyy HH:mm"))
                isConflict = True
            ElseIf ActivityModule.dateValidator(tempDate.AddMinutes(minDuration), DevelopmentVariables.UserID)
                errorStr.AppendLine(tempDate.ToString("dd/MM/yyyy HH:mm"))
                isConflict = True
            Else
                '****************************



            End If

        Loop


        Return errorStr.ToString
    End Function

    Private Function calTimeDiffInMin(startTime As DateTime, endTime As DateTime) As Integer
        Return CInt(DateDiff(DateInterval.Minute, startTime, endTime))
    End Function
End Class
