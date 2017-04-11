Public Class ViewAppointment



    Private Sub ViewAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbHistory.Checked = True
    End Sub



    Private Sub rbHistory_CheckedChanged(sender As Object, e As EventArgs) Handles rbHistory.CheckedChanged
        dgvRecord.DataSource = Nothing
        Dim db As New ScheduleDBDataContext()
        Dim memberId As Integer = DevelopmentVariables.UserID
        Dim currentDateTime As Date

        currentDateTime = Date.Now

        Dim record = From p In db.Participles, s In db.Schedules, st In db.ScheduleTimes
                     Where p.MemberID = memberId And s.Type = "Appointment" And st.ScheduleStart < currentDateTime And s.ScheduleID = p.ScheduleID And st.ScheduleID = s.ScheduleID
                     Select New With {
                         .Schedule_ID = s.ScheduleID,
                         .Start_DateTime = st.ScheduleStart,
                         .End_DateTime = st.ScheduleEnd,
                         s.Title,
                         s.Venue
                         }
        dgvRecord.DataSource = record
        dgvRecord.ReadOnly = True
    End Sub

    Private Sub rbOngoing_CheckedChanged(sender As Object, e As EventArgs) Handles rbOngoing.CheckedChanged
        dgvRecord.DataSource = Nothing
        Dim db As New ScheduleDBDataContext()
        Dim memberId As Integer = DevelopmentVariables.UserID
        Dim currentDateTime As DateTime

        currentDateTime = DateTime.Now

        Dim record = From p In db.Participles, s In db.Schedules, st In db.ScheduleTimes
                     Where p.MemberID = memberId And s.Type = "Appointment" And st.ScheduleStart > currentDateTime And s.Status = "Active" And s.ScheduleID = p.ScheduleID And st.ScheduleID = s.ScheduleID
                     Select New With {
                         .Schedule_ID = s.ScheduleID,
                         .Start_DateTime = st.ScheduleStart,
                         .End_DateTime = st.ScheduleEnd,
                         s.Title,
                         s.Venue
                         }

        dgvRecord.DataSource = record
        dgvRecord.ReadOnly = True
    End Sub

    Private Sub rbPending_CheckedChanged(sender As Object, e As EventArgs) Handles rbPending.CheckedChanged

        dgvRecord.DataSource = Nothing
        Dim db As New ScheduleDBDataContext()
        Dim memberId As Integer = DevelopmentVariables.UserID
        Dim currentDateTime As DateTime

        currentDateTime = DateTime.Now

        Dim record = From p In db.Participles, s In db.Schedules, st In db.ScheduleTimes
                     Where p.MemberID = memberId And s.Type = "Appointment" And st.ScheduleStart > currentDateTime And s.Status = "Pending" And s.ScheduleID = p.ScheduleID And st.ScheduleID = s.ScheduleID
                     Select New With {
                         .Schedule_ID = s.ScheduleID,
                         .Start_DateTime = st.ScheduleStart,
                         .End_DateTime = st.ScheduleEnd,
                         s.Title,
                         s.Venue
                         }

        dgvRecord.DataSource = record
        dgvRecord.ReadOnly = True


    End Sub

    Private Sub dgvRecord_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecord.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        Dim formRecord As New ViewAppointmentRecord()
        Dim scheduleID As String
        selectedRow = dgvRecord.Rows(index)
        scheduleID = selectedRow.Cells(0).Value.ToString()

        formRecord.StringIDPass = Integer.Parse(scheduleID)
        formRecord.ShowDialog()
    End Sub
End Class
