Public Class CreateAppointment
    Public Property StringUsername As String
    Private schedule As ScheduleClass
    Private Sub CreateAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTo.Text = "To : " & StringUsername

        scheStart.MinDate = DateTime.Now.AddHours(2)
        scheEnd.MinDate = scheStart.Value
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If Me.ValidateChildren() = False Then
            MessageBox.Show("Please correct the invalid input.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        s.RepeatDue = scheEnd.Value
        's.RepeatBehavior = New Binary(BitConverter.GetBytes(RepeatationModule.REPEAT_NONE))
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
        st.InitialTime = True
        db.ScheduleTimes.InsertOnSubmit(st)
        db.SubmitChanges()
    End Sub

    Private Sub addOwner()
        Dim userid As Integer = LoginSession.memberID
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
        p.MemberID = userid
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

    Private Sub txtTitle_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTitle.Validating
        If txtTitle.Text.Equals("") Then
            err.SetError(txtTitle, "Field must not be empty.")
            e.Cancel = True
        Else
            err.SetError(txtTitle, Nothing)
        End If
    End Sub

    Private Sub txtBoxDescription_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtBoxDescription.Validating
        If txtBoxDescription.Text.Equals("") Then
            err.SetError(txtBoxDescription, "Field must not be empty")
            e.Cancel = True
        Else
            err.SetError(txtBoxDescription, Nothing)
        End If
    End Sub

    Private Sub txtVenue_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtVenue.Validating
        If txtVenue.Text.Equals("") Then
            err.SetError(txtVenue, "Field must not be empty")
            e.Cancel = True
        Else
            err.SetError(txtVenue, Nothing)
        End If
    End Sub

    Private Sub scheStart_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles scheStart.Validating, scheEnd.Validating
        Dim db As New ScheduleDBDataContext
        Dim participle = StringUsername
        Dim memberId As Integer
        Dim memId = From m In db.Members
                    Where m.Username = participle

        memberId = memId.FirstOrDefault.MemberID

        If scheEnd.Value.CompareTo(scheStart.Value) < 1 Then
            err.SetError(scheStart, "The Start date must be earlier than the end date")
            err.SetError(scheEnd, "The end date must be later than the start date")
            e.Cancel = True
        ElseIf DateDiff(DateInterval.Minute, scheStart.Value, scheEnd.Value) < 30 Then
            err.SetError(scheStart, "The duration of the time must more than 30 minutes")
            err.SetError(scheEnd, "The duration of the time must more than 30 minutes")
            e.Cancel = True
        ElseIf ActivityModule.dateValidator(scheEnd.Value, memberId, -1) Then
            err.SetError(scheStart, Nothing)
            err.SetError(scheEnd, "The end date is having conflict with other schedule")
            e.Cancel = True
        ElseIf ActivityModule.dateValidator(scheStart.Value, memberId, -1) Then
            err.SetError(scheEnd, Nothing)
            err.SetError(scheStart, "The start date is having conflict with other schedule")
            e.Cancel = True
        ElseIf ActivityModule.dateValidator2(scheStart.Value, scheEnd.Value, memberId, -1) Then
            err.SetError(scheStart, "There is schedule conflict between both times")
            err.SetError(scheEnd, "There is schedule conflict between both times")
            e.Cancel = True
        Else
            err.SetError(scheEnd, Nothing)
            err.SetError(scheStart, Nothing)
        End If
    End Sub
End Class