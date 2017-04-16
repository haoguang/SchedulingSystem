Public Class AppointmentNotification
    Public index As Integer
    Dim userId As Integer = LoginSession.memberID
    Dim id As Integer = apmtDetail.Appointment(index).ScheduleID
    Dim startDate, endDate As String

    Private Sub AppointmentNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New ScheduleDBDataContext()

        'get Schedule startDateTime, endDateTime
        Dim scheduleTimes = From p In db.Participles, s In db.Schedules, st In db.ScheduleTimes
                            Where p.MemberID = userId And p.Status = "Pending" And p.ScheduleID = s.ScheduleID And s.ScheduleID = st.ScheduleID
                            Select st.ScheduleStart, st.ScheduleEnd

        'if exist
        If scheduleTimes.Count > 0 Then
            For Each s In scheduleTimes
                startDate = s.ScheduleStart.ToString
                endDate = s.ScheduleEnd.ToString
            Next
        End If

        'get info of Inviter of the appointment
        Dim inviter = From p In db.Participles, s In db.Schedules, m In db.Members
                      Where s.ScheduleID = id And p.ScheduleID = s.ScheduleID And p.ParticiplesRole = "Owner" And m.MemberID = p.MemberID
                      Select m.Username

        'if exist
        If inviter.Count > 0 Then
            For Each m In inviter
                lblAInviter.Text = String.Format("{0}", m)
            Next
        End If

        'display appointment detail
        lblATitle.Text = apmtDetail.Appointment(index).Title
        lblADesc.Text = apmtDetail.Appointment(index).Description
        lblAVenue.Text = apmtDetail.Appointment(index).Venue
        lblADateTime.Text = apmtDetail.Appointment(index).ScheduleTime

        Me.AcceptButton = btnAccept
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Dim status As Boolean
        status = ActivityModule.acceptAppointment(userId, id, Date.Parse(startDate), Date.Parse(endDate))
        If (status = True) Then
            MessageBox.Show("Appointment Accepted Succcesfully!")

            Me.Close()
        ElseIf (status = False) Then
            MessageBox.Show("Sorry, Appoinment Due Date is Over!")
            Me.Close()
        End If
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        ActivityModule.declineAppoinment(id)
        MessageBox.Show("Appointment Rejected Succcesfully!")
        Me.Close()
    End Sub
End Class