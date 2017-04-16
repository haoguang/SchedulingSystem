Imports System.Text

Public Class RepeatationClass
    Friend Property scheduleID As Integer
    Friend Property minDuration As Integer
    Friend Property initialStartDate As DateTime
    Friend Property startTimeList As List(Of DateTime)

    Sub New(scheduleID As Integer, startDate As DateTime, endDate As DateTime)
        Me.scheduleID = scheduleID
        Me.minDuration = calTimeDiffInMin(startDate, endDate)
        Me.initialStartDate = startDate
        Me.startTimeList = New List(Of DateTime)
    End Sub

    Public Function generateDateArray(repeatBehavior As Byte, repeatDue As Date) As String ' return true when date duplicated in the db

        Dim tempDate As DateTime = initialStartDate
        Dim errorStr As New StringBuilder("Conflict occur on the dates :" & vbNewLine)
        Dim isConflict As Boolean = False

        Do While tempDate.Date.CompareTo(repeatDue.Date) < 0
            tempDate = RepeatationModule.getNextDate(RepeatationModule.getRepeatString(repeatBehavior), tempDate)
            If ActivityModule.dateValidator(tempDate, LoginSession.memberID, scheduleID) Then
                errorStr.AppendLine(tempDate.ToString("dd/MM/yyyy HH:mm"))
                isConflict = True
            ElseIf ActivityModule.dateValidator(tempDate.AddMinutes(minDuration), LoginSession.memberID, scheduleID)
                errorStr.AppendLine(tempDate.ToString("dd/MM/yyyy HH:mm"))
                isConflict = True
            Else
                startTimeList.Add(New DateTime(tempDate.Ticks))
            End If

        Loop

        If isConflict Then
            errorStr.AppendLine("Reselect the date or activity will not be create on the following date.")
        Else
            errorStr = New StringBuilder("errorless")
        End If

        Return errorStr.ToString
    End Function

    Private Function calTimeDiffInMin(startTime As DateTime, endTime As DateTime) As Integer
        Return CInt(DateDiff(DateInterval.Minute, startTime, endTime))
    End Function
End Class
