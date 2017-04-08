Imports System.Text
Public Class SecondUserControl
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAppointment.Click
        Dim formDialog As New CreateAppointment()
        formDialog.StringUsername = txtName.Text
        formDialog.ShowDialog()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim err As New StringBuilder
        Dim ctr As Control = Nothing

        Dim db As New ScheduleDBDataContext()
        Dim name As String

        Dim beforeDate As DateTime
        Dim afterDate As DateTime


        name = txtName.Text.Trim

        If name = "" Then
            err.AppendLine("- Please enter [Name]")
            ctr = If(ctr, txtName)
        End If
        If (err.Length > 0) Then
            MessageBox.Show(err.ToString, "Input Error")
            ctr.Focus()
            Return
        End If

        beforeDate = dtSelected.Value.Date.AddDays(-1)
        afterDate = dtSelected.Value.Date.AddDays(1)


        Dim record = From p In db.Participles, s In db.Schedules, st In db.ScheduleTimes, m In db.Members
                     Where m.Username = name And st.ScheduleStart >= beforeDate And st.ScheduleStart <= afterDate And m.MemberID = p.MemberID And p.ScheduleID = s.ScheduleID And s.ScheduleID = st.ScheduleID
                     Select New With {
                         .StartTime = Format(st.ScheduleStart, "HH: mm tt"),
                         .EndTime = Format(st.ScheduleEnd, "HH: mm tt")
                    }


        dgvTimetable.DataSource = record


        If dgvTimetable.RowCount <= 0 Then
            MessageBox.Show("Record not found!", "Input Error")
        Else
            lblInfo.Text = name & "'s Schedule in " & dtSelected.Value.Date
            dgvTimetable.ReadOnly = True
            gbTimetable.Visible = True
            btnAppointment.Enabled = True
            gbSearch.Enabled = False
            gbTimetable.Enabled = True
        End If

    End Sub

    Private Sub SecondUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtSelected.MinDate = DateTime.Now
    End Sub

    Private Sub btnSearch2_Click(sender As Object, e As EventArgs) Handles btnSearch2.Click
        gbSearch.Enabled = True
        gbTimetable.Enabled = False
    End Sub
End Class
