Public Class ViewAppointment


    Private Sub ViewAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbHistory.Checked = True
    End Sub

    Private Sub rbHistory_CheckedChanged(sender As Object, e As EventArgs) Handles rbHistory.CheckedChanged
        BindHistoryData()
    End Sub

    Private Sub rbOngoing_CheckedChanged(sender As Object, e As EventArgs) Handles rbOngoing.CheckedChanged
        BindOngoingData()
    End Sub

    Private Sub rbPending_CheckedChanged(sender As Object, e As EventArgs) Handles rbPending.CheckedChanged
        BindPendingData()
    End Sub

    Private Sub dgvRecord_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecord.CellClick
        Dim index As Integer
        index = e.RowIndex
        If index >= 0 Then
            Dim selectedRow As DataGridViewRow
            Dim formRecord As New ViewAppointmentRecord()
            Dim scheduleID As String

            selectedRow = dgvRecord.Rows(index)
            scheduleID = selectedRow.Cells(0).Value.ToString()
            formRecord.StringIDPass = Integer.Parse(scheduleID)
            formRecord.ShowDialog()
        End If
    End Sub

    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged
        If rbOngoing.Checked = True Then
            BindOngoingData()
        ElseIf rbPending.Checked = True Then
            BindPendingData()
        Else
            BindHistoryData()
        End If

    End Sub

    Private Sub BindOngoingData()
        dgvRecord.DataSource = Nothing
        Dim db As New ScheduleDBDataContext()
        Dim currentDateTime As DateTime
        Dim userid As Integer = LoginSession.memberID
        currentDateTime = DateTime.Now
        Dim record = From p In db.Participles, s In db.Schedules, st In db.ScheduleTimes
                     Where s.Title.Contains(txtTitle.Text) And p.MemberID = userid And s.Type = "Appointment" And st.ScheduleStart > currentDateTime And s.Status = "Active" And s.ScheduleID = p.ScheduleID And st.ScheduleID = s.ScheduleID
                     Select New With {
                         .Schedule_ID = s.ScheduleID,
                         .Start_DateTime = st.ScheduleStart,
                         .End_DateTime = st.ScheduleEnd,
                         s.Title,
                         s.Venue
                         }
        dgvRecord.DataSource = record
        dgvRecord.ReadOnly = True
        dgvRecord.AutoResizeColumns()
    End Sub

    Private Sub BindPendingData()
        dgvRecord.DataSource = Nothing
        Dim db As New ScheduleDBDataContext()
        Dim userid As Integer = LoginSession.memberID
        Dim currentDateTime As DateTime

        currentDateTime = DateTime.Now

        Dim record = From p In db.Participles, s In db.Schedules, st In db.ScheduleTimes
                     Where s.Title.Contains(txtTitle.Text) And p.MemberID = userid And s.Type = "Appointment" And st.ScheduleStart > currentDateTime And s.Status = "Pending" And s.ScheduleID = p.ScheduleID And st.ScheduleID = s.ScheduleID
                     Select New With {
                         .Schedule_ID = s.ScheduleID,
                         .Start_DateTime = st.ScheduleStart,
                         .End_DateTime = st.ScheduleEnd,
                         s.Title,
                         s.Venue
                         }

        dgvRecord.DataSource = record
        dgvRecord.ReadOnly = True
        dgvRecord.AutoResizeColumns()
    End Sub

    Private Sub BindHistoryData()
        dgvRecord.DataSource = Nothing
        Dim db As New ScheduleDBDataContext()
        Dim userid As Integer = LoginSession.memberID
        Dim currentDateTime As Date

        currentDateTime = Date.Now

        Dim record = From p In db.Participles, s In db.Schedules, st In db.ScheduleTimes
                     Where s.Title.Contains(txtTitle.Text) And p.MemberID = userid And s.Type = "Appointment" And s.Status = "Active" And st.ScheduleStart < currentDateTime And s.ScheduleID = p.ScheduleID And st.ScheduleID = s.ScheduleID
                     Select New With {
                         .Schedule_ID = s.ScheduleID,
                         .Start_DateTime = st.ScheduleStart,
                         .End_DateTime = st.ScheduleEnd,
                         s.Title,
                         s.Venue
                         }
        dgvRecord.DataSource = record
        dgvRecord.ReadOnly = True
        dgvRecord.AutoResizeColumns()

    End Sub

    Private Sub BindCancelData()
        dgvRecord.DataSource = Nothing
        Dim db As New ScheduleDBDataContext()
        Dim userid As Integer = LoginSession.memberID
        Dim currentDateTime As Date

        currentDateTime = Date.Now

        Dim record = From p In db.Participles, s In db.Schedules, st In db.ScheduleTimes
                     Where s.Title.Contains(txtTitle.Text) And p.MemberID = userid And s.Type = "Appointment" And s.Status = "Cancel" And s.ScheduleID = p.ScheduleID And st.ScheduleID = s.ScheduleID
                     Select New With {
                         .Schedule_ID = s.ScheduleID,
                         .Start_DateTime = st.ScheduleStart,
                         .End_DateTime = st.ScheduleEnd,
                         s.Title,
                         s.Venue
                         }
        dgvRecord.DataSource = record
        dgvRecord.ReadOnly = True
        dgvRecord.AutoResizeColumns()
    End Sub

    Private Sub rbCancel_CheckedChanged(sender As Object, e As EventArgs) Handles rbCancel.CheckedChanged
        BindCancelData()

    End Sub
End Class
