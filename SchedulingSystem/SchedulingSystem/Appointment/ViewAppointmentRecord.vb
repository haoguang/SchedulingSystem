Public Class ViewAppointmentRecord
    Public Property StringIDPass As Integer


    Private Sub ViewAppointmentRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New ScheduleDBDataContext()
        Dim ownerName = From p In db.Participles, m In db.Members
                        Where p.ScheduleID = StringIDPass And p.ParticiplesRole = "Owner" And p.MemberID = m.MemberID

        Dim record = From p In db.Participles, s In db.Schedules, st In db.ScheduleTimes, m In db.Members
                     Where s.ScheduleID = StringIDPass And p.ParticiplesRole = "Participle" And s.ScheduleID = p.ScheduleID And st.ScheduleID = s.ScheduleID And p.MemberID = m.MemberID
                     Select New With {
                         st.ScheduleStart,
                         st.ScheduleEnd,
                         s.Title,
                         s.Venue,
                         s.Description,
                         m.Username
                         }
        lblDate.Text = Format(record.FirstOrDefault.ScheduleStart, "d")
        lblStartTime.Text = Format(record.FirstOrDefault.ScheduleStart, "HH:mm tt")
        lblEndTime.Text = Format(record.FirstOrDefault.ScheduleEnd, "HH:mm tt")
        lblTitle.Text = record.FirstOrDefault.Title
        txtBoxDescription.Text = record.FirstOrDefault.Description
        lblVenue.Text = record.FirstOrDefault.Venue
        lblOwner.Text = ownerName.FirstOrDefault.m.Username
        lblPaticipant.Text = record.FirstOrDefault.Username
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class