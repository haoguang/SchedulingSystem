Public Class AppointmentNotification
    Public index As Integer

    Private Sub AppointmentNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New ScheduleDBDataContext()
        Dim id As Integer = apmtDetail.Appointment(index).ScheduleID

        Dim inviter = From p In db.Participles, s In db.Schedules, m In db.Members
                      Where s.ScheduleID = id And p.ScheduleID = s.ScheduleID And p.ParticiplesRole = "Owner" And m.MemberID = p.MemberID
                      Select m.Username

        If inviter.Count > 0 Then
            For Each m In inviter
                Label1.Text = String.Format("{0}", m)
            Next
        End If
        lblATitle.Text = apmtDetail.Appointment(index).Title
        lblADesc.Text = apmtDetail.Appointment(index).Description
        lblAVenue.Text = apmtDetail.Appointment(index).Venue
        lblADateTime.Text = apmtDetail.Appointment(index).ScheduleTime
    End Sub
End Class