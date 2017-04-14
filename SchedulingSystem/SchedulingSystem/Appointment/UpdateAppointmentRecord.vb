Imports System.Text
Public Class UpdateAppointmentRecord
    Public Property StringIDPass As Integer

    Private Sub UpdateAppointmentRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        scheStart.MinDate = DateTime.Now
        scheEnd.MinDate = scheStart.Value
        Dim db As New ScheduleDBDataContext()

        Dim record = From p In db.Participles, s In db.Schedules, st In db.ScheduleTimes, m In db.Members
                     Where s.ScheduleID = StringIDPass And p.ParticiplesRole = "Participle" And s.ScheduleID = p.ScheduleID And st.ScheduleID = s.ScheduleID And p.MemberID = m.MemberID
                     Select New With {
                         st.ScheduleStart,
                         st.ScheduleEnd,
                         s.Title,
                         s.Venue,
                         s.Description,
                         m.Nickname
                         }

        scheStart.Text = record.FirstOrDefault.ScheduleStart.ToString
        scheEnd.Text = record.FirstOrDefault.ScheduleEnd.ToString
        txtTitle.Text = record.FirstOrDefault.Title
        txtBoxDescription.Text = record.FirstOrDefault.Description
        txtVenue.Text = record.FirstOrDefault.Venue
        lblPaticipant.Text = record.FirstOrDefault.Nickname
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim title As String, description As String, venue As String
        Dim err As New StringBuilder
        Dim ctr As Control = Nothing

        title = txtTitle.Text
        description = txtBoxDescription.Text
        venue = txtVenue.Text

        Dim db As New ScheduleDBDataContext
        'validate time
        Dim participle = lblPaticipant.Text
        Dim memberId As Integer
        Dim memId = From m In db.Members
                    Where m.Nickname = participle

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
            err.AppendLine("- The range of Start time and End time are not available")
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
        If scheEnd.Value < scheStart.Value Then
            err.AppendLine("- End time cannot earlier than start time.")
            ctr = If(ctr, scheEnd)
        End If
        If (err.Length > 0) Then
            MessageBox.Show(err.ToString, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ctr.Focus()
            Return
        End If




        'update schedule table
        Dim s As Schedule = db.Schedules.FirstOrDefault(Function(o) o.ScheduleID = StringIDPass)
        s.Title = title
        s.Description = description
        s.Venue = venue
        s.Status = "Pending"
        db.SubmitChanges()

        'update scheduletime table
        Dim st As ScheduleTime = db.ScheduleTimes.FirstOrDefault(Function(o) o.ScheduleID = StringIDPass)
        st.ScheduleStart = scheStart.Value
        st.ScheduleEnd = scheEnd.Value
        db.SubmitChanges()

        'update participle table
        Dim p As Participle = db.Participles.FirstOrDefault(Function(o) o.ScheduleID = StringIDPass And o.ParticiplesRole = "Participle")
        p.Status = "Pending"
        db.SubmitChanges()

        MessageBox.Show("The appointment record is updated", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.None)
        Me.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim db As New ScheduleDBDataContext

        Dim result As Integer = MessageBox.Show("Do you want to cancel the appointment?", "Cancel Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim s As Schedule = db.Schedules.FirstOrDefault(Function(o) o.ScheduleID = StringIDPass)
            s.Status = "Cancel"
            db.SubmitChanges()
            MessageBox.Show("The appointment is cancelled", "Cancel Successful", MessageBoxButtons.OK, MessageBoxIcon.None)
            Me.Close()

        End If
    End Sub
End Class