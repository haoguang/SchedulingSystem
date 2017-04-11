Imports System.Text
Public Class SecondUserControl
    Private Sub btnAppointment_Click(sender As Object, e As EventArgs) Handles btnAppointment.Click
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

        Dim member As Member = db.Members.FirstOrDefault(Function(o) o.Username = name)

        If member Is Nothing Then
            MessageBox.Show("User record not found!", "Error")
        Else
            Dim record = From p In db.Participles, s In db.Schedules, st In db.ScheduleTimes, m In db.Members
                         Where m.Username = name And st.ScheduleStart > beforeDate And st.ScheduleStart < afterDate And m.MemberID = p.MemberID And p.ScheduleID = s.ScheduleID And s.ScheduleID = st.ScheduleID
                         Select New With {
                             .StartTime = Format(st.ScheduleStart, "HH: mm "),
                             .EndTime = Format(st.ScheduleEnd, "HH: mm ")
                        }


            dgvTimetable.DataSource = record
            dgvTimetable.ReadOnly = True
            gbTimetable.Visible = True
            btnAppointment.Enabled = True
            gbSearch.Enabled = False
            gbTimetable.Enabled = True

            If dgvTimetable.RowCount <= 0 Then
                lblInfo.Text = name & "haven't create his schedule in " & dtSelected.Value.Date
            Else
                lblInfo.Text = name & "'s Schedule in " & dtSelected.Value.Date

            End If
            'add new column for status
            'Dim statusColumn As New DataGridViewColumn
            'With statusColumn
            '    .HeaderText = "Status"
            '    .ToolTipText = "N/A"
            'End With
            'dgvTimetable.Columns.Insert(2, statusColumn)
        End If



    End Sub

    Private Sub SecondUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtSelected.MinDate = DateTime.Now
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        gbSearch.Enabled = True
        gbTimetable.Enabled = False
    End Sub


End Class
