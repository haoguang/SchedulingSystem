Imports System.Text
Public Class CreateAppointment
    Public Property StringUsername As String

    Private Sub CreateAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTo.Text = "To : " & StringUsername

        scheStart.MinDate = DateTime.Now.AddHours(2)
        scheEnd.MinDate = scheStart.Value
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim title As String, description As String, venue As String
        Dim err As New StringBuilder
        Dim ctr As Control = Nothing
        Dim db As New ScheduleDBDataContext
        title = txtTitle.Text
        description = txtBoxDescription.Text
        venue = txtVenue.Text

        'validate date and time
        Dim participle = StringUsername
        Dim memberId As Integer
        Dim memId = From m In db.Members
                    Where m.Username = participle

        memberId = memId.FirstOrDefault.MemberID

        If dateValidator(scheStart.Value, memberId) = True Then
            err.AppendLine("- Start time is not available")
            ctr = If(ctr, scheStart)
        End If
        If dateValidator(scheEnd.Value, memberId) = True Then
            err.AppendLine("- End time is not available")
            ctr = If(ctr, scheEnd)
        End If
        If dateValidator2(scheStart.Value, scheEnd.Value, memberId) = True Then
            err.AppendLine("- Start time and End time are not available")
            ctr = If(ctr, scheStart)
            ctr = If(ctr, scheEnd)
        End If

        If title = "" Then
            err.AppendLine("- Please enter title.")
            ctr = If(ctr, txtTitle)
        End If
        If description = "" Then
            err.AppendLine("- Please enter description.")
            ctr = If(ctr, txtBoxDescription)
        End If
        If venue = "" Then
            err.AppendLine("- Please enter venue")
            ctr = If(ctr, txtVenue)
        End If
        If (err.Length > 0) Then
            MessageBox.Show(err.ToString, "Input Error")
            ctr.Focus()
            Return
        End If

        AddSchedule()
        AddScheduleTime()
        addOwner()
        addParticiple()
        MessageBox.Show("Appointment request sent.", "Request")
        Me.Close()


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    Private Function GetMemberID(username As String) As Integer
        Dim db As New ScheduleDBDataContext()
        Dim id As Integer
        Dim record = From m In db.Members
                     Where m.Username = StringUsername
                     Select New With {
                         m.MemberID
                         }
        id = record.FirstOrDefault.MemberID
        Return id
    End Function

    Private Sub AddSchedule()
        Dim s As New Schedule()
        s.RepeatDue = Nothing
        s.RepeatBehavior = Nothing
        s.Title = txtTitle.Text
        s.Description = txtBoxDescription.Text
        s.Venue = txtVenue.Text
        s.Type = "Appointment"
        s.Status = "Pending"

        Dim db As New ScheduleDBDataContext()
        db.Schedules.InsertOnSubmit(s)
        db.SubmitChanges()
    End Sub

    Private Sub AddScheduleTime()
        Dim db As New ScheduleDBDataContext()
        Dim record = From s In db.Schedules
                     Order By s.ScheduleID
                     Descending
                     Select New With {
                          s.ScheduleID
                         }
        Dim scheduleID As Integer
        With record.First
            scheduleID = .ScheduleID
        End With

        Dim st As New ScheduleTime
        st.ScheduleID = scheduleID
        st.ScheduleStart = scheStart.Value
        st.ScheduleEnd = scheEnd.Value
        st.InitialTime = Nothing
        db.ScheduleTimes.InsertOnSubmit(st)
        db.SubmitChanges()
    End Sub

    Private Sub addOwner()
        Dim db As New ScheduleDBDataContext()
        Dim record = From s In db.Schedules
                     Order By s.ScheduleID
                     Descending
                     Select New With {
                          s.ScheduleID
                         }
        Dim scheduleID As Integer
        With record.First
            scheduleID = .ScheduleID
        End With

        Dim p As New Participle
        p.ScheduleID = scheduleID
        p.MemberID = DevelopmentVariables.UserID
        p.ParticiplesRole = "Owner"
        p.Status = "Attend"
        p.GenerateDate = DateTime.Now
        db.Participles.InsertOnSubmit(p)
        db.SubmitChanges()
    End Sub

    Private Sub addParticiple()
        Dim db As New ScheduleDBDataContext()
        Dim record = From s In db.Schedules
                     Order By s.ScheduleID
                     Descending
                     Select New With {
                          s.ScheduleID
                         }
        Dim scheduleID As Integer
        With record.First
            scheduleID = .ScheduleID
        End With

        Dim memberRecord = From m In db.Members
                           Where m.Username = StringUsername
                           Select New With {
                           m.MemberID
                           }
        Dim memId As Integer = memberRecord.FirstOrDefault.MemberID

        Dim p As New Participle
        p.ScheduleID = scheduleID
        p.MemberID = memId
        p.ParticiplesRole = ScheduleClass.PARTICIPLE
        p.Status = "Pending"
        p.GenerateDate = DateTime.Now
        db.Participles.InsertOnSubmit(p)
        db.SubmitChanges()
    End Sub
End Class