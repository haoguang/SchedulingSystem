Public Class UpdateAppointment
    Private Sub dgvRecord_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecord.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        Dim formRecord As New UpdateAppointmentRecord()
        Dim scheduleID As String
        selectedRow = dgvRecord.Rows(index)
        scheduleID = selectedRow.Cells(0).Value.ToString()

        formRecord.StringIDPass = Integer.Parse(scheduleID)
        formRecord.ShowDialog()
    End Sub

    Private Sub UpdateAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvRecord.DataSource = Nothing
        BindData()

    End Sub

    Private Sub BindData()
        Dim db As New ScheduleDBDataContext()
        Dim memberId As Integer = DevelopmentVariables.UserID
        Dim currentDateTime As DateTime

        currentDateTime = DateTime.Now

        Dim record = From p In db.Participles, s In db.Schedules, st In db.ScheduleTimes
                     Where s.Title.Contains(txtTitle.Text) And p.MemberID = memberId And s.Type = "Appointment" And st.ScheduleStart > currentDateTime And s.Status = "Active" And s.ScheduleID = p.ScheduleID And st.ScheduleID = s.ScheduleID
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

    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged
        BindData()
    End Sub
End Class
