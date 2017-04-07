
Public Class SecondUserControl
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAppointment.Click
        Dim formDialog As New CreateAppointment()
        formDialog.ShowDialog()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        gbTimetable.Visible = True
        btnAppointment.Enabled = True
        Dim db As New ScheduleDBDataContext()
        Dim name As String
        Dim dateSelected As DateTime

        name = txtName.Text
        dateSelected = dtSelected.Value.Date

        Dim record = From p In db.Participles, s In db.Schedules, st In db.ScheduleTimes, m In db.Members
                     Where m.Username = name And st.ScheduleStart = dateSelected And m.MemberID = p.MemberID And p.ScheduleID = s.ScheduleID And s.ScheduleID = st.ScheduleID
                     Select New With {
                         st.ScheduleStart,
                         st.ScheduleEnd
                         }


        dgvTimetable.DataSource = record
        dgvTimetable.ReadOnly = True
    End Sub

    Private Sub SecondUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtSelected.MinDate = DateTime.Now

    End Sub
End Class
