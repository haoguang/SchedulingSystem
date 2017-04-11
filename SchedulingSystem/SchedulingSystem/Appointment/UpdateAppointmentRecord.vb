Public Class UpdateAppointmentRecord
    Public Property StringIDPass As Integer

    Private Sub UpdateAppointmentRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'scheStart.MinDate = DateTime.Now
        'scheEnd.MinDate = DateTime.Now
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
        scheEnd.Text = Format(record.FirstOrDefault.ScheduleEnd, "HH:mm tt")
        txtTitle.Text = record.FirstOrDefault.Title
        txtBoxDescription.Text = record.FirstOrDefault.Description
        txtVenue.Text = record.FirstOrDefault.Venue
        lblPaticipant.Text = record.FirstOrDefault.Nickname
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim db As New ScheduleDBDataContext
        Dim s As Schedule = db.Schedules.FirstOrDefault(Function(o) o.ScheduleID = StringIDPass)
        s.Title = txtTitle.Text
        s.Description = txtBoxDescription.Text
        s.Venue = txtVenue.Text
        s.Status = "Pending"
        db.SubmitChanges()

        Dim st As ScheduleTime = db.ScheduleTimes.FirstOrDefault(Function(o) o.ScheduleID = StringIDPass)
        st.ScheduleStart = scheStart.Value
        st.ScheduleEnd = scheEnd.Value
        db.SubmitChanges()

        Dim p As Participle = db.Participles.FirstOrDefault(Function(o) o.ScheduleID = StringIDPass And o.ParticiplesRole = "Participle")
        p.Status = "Pending"
        db.SubmitChanges()

        MessageBox.Show("The appointment record is updated", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.None)
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