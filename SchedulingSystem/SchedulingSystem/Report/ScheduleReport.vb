Imports System.Data.SqlClient
Imports System.Text

Public Class ScheduleReport

    Private Sub generateReport()
        Dim startDay As Integer = dtpStartDate.Value.Day
        Dim endDay As Integer = dtpEndDate.Value.Day
        Dim month As Integer = dtpMonth.Value.Month
        Dim year As Integer = dtpMonth.Value.Year

        If radDaily.Checked Then
            endDay = startDay
        ElseIf radMonthly.Checked Then
            startDay = 1
            endDay = Date.DaysInMonth(year, month)
        End If

        Dim db As New ScheduleDBDataContext

        Dim rs = From st In db.ScheduleTimes Join s In db.Schedules On s.ScheduleID Equals st.ScheduleID
                 Join p In db.Participles On s.ScheduleID Equals p.ScheduleID
                 Where CLng(p.MemberID) = LoginSession.memberID And
                    CLng(st.ScheduleStart.Value.Month) = month And
                    CLng(st.ScheduleStart.Value.Year) = year And
                     CLng(st.ScheduleStart.Value.Day) >= startDay And
                     CLng(st.ScheduleStart.Value.Day) <= endDay
                 Group st By Column1 = CType(st.ScheduleStart.Value.Hour, Integer?)
                    Into g = Group
                 Order By
                      Column1
                 Select
                     TimeInvolve = Column1,
                     BusyRate = CType(g.Count(Function(p) p.ScheduleStart.Value.Hour <> Nothing) / 30 * 100, Int64?)


        If rs.Count > 0 Then
            lblNoRecord.Hide()
        Else
            lblNoRecord.Show()
        End If

        dgvScheduleReport.Rows.Clear()

        For Each item In rs
            dgvScheduleReport.Rows.Add(String.Format("{0}:00", item.TimeInvolve), item.BusyRate)
        Next

        chtBusyTime.DataSource = rs



        chtBusyTime.Series("Series1").YValueMembers = "BusyRate"
        chtBusyTime.Series("Series1").XValueMember = "TimeInvolve"

        chtBusyTime.DataBind()
    End Sub
    Private Sub DateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles dtpMonth.ValueChanged, dtpStartDate.ValueChanged, dtpEndDate.ValueChanged
        generateReport()
    End Sub

    Private Sub dtpMonth_ValueChanged(sender As Object, e As EventArgs) Handles dtpMonth.ValueChanged

        dtpStartDate.MaxDate = dtpMonth.Value.AddYears(7)
        dtpStartDate.MinDate = dtpMonth.Value.AddYears(-7)
        dtpEndDate.MaxDate = dtpMonth.Value.AddYears(7)
        dtpEndDate.MinDate = dtpMonth.Value.AddYears(-7)

        dtpStartDate.MaxDate = New Date(dtpMonth.Value.Year, dtpMonth.Value.Month, Date.DaysInMonth(dtpMonth.Value.Year, dtpMonth.Value.Month))
        dtpStartDate.MinDate = New Date(dtpMonth.Value.Year, dtpMonth.Value.Month, 1)
        dtpEndDate.MaxDate = New Date(dtpMonth.Value.Year, dtpMonth.Value.Month, Date.DaysInMonth(dtpMonth.Value.Year, dtpMonth.Value.Month))
        dtpEndDate.MinDate = New Date(dtpMonth.Value.Year, dtpMonth.Value.Month, 1)

    End Sub

    Private Sub ScheduleReport_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtpMonth_ValueChanged(Nothing, Nothing)
        radMonthly.Checked = True
        generateReport()
    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles radDaily.CheckedChanged, radMonthly.CheckedChanged, radRange.CheckedChanged
        If radDaily.Checked Then
            dtpEndDate.Enabled = False
            dtpStartDate.Enabled = True
        ElseIf radMonthly.Checked Then
            dtpEndDate.Enabled = False
            dtpStartDate.Enabled = False
        Else
            dtpEndDate.Enabled = True
            dtpStartDate.Enabled = True
        End If
        generateReport()
    End Sub

    Private Sub prtDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles prtDoc.PrintPage
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontbody As New Font("Consolas", 10)

        Dim header As String = "Busy Rate Report"
        Dim subHeader As String = String.Format("Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
                                                "Prepared by " & LoginSession.nickname, DateTime.Now)

        Dim body As New StringBuilder()

        body.AppendLine("No   Time (Hour)   Busy Rate (%)")
        body.AppendLine("--   -----------   -------------")

        Dim cnt As Integer = 0
        For Each item As DataGridViewRow In dgvScheduleReport.Rows
            cnt += 1
            body.AppendFormat("{0,2}   {1,11}   {2,13}" & vbNewLine, cnt, item.Cells(0).Value, item.Cells(1).Value)
        Next

        body.AppendLine()
        body.AppendFormat("{0,2} record(s)", cnt)

        With e.Graphics
            .DrawString(header, fontHeader, Brushes.Purple, 100, 0)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 100, 40)
            .DrawString(body.ToString, fontbody, Brushes.Black, 20, 120)
        End With

        Dim myRec As New System.Drawing.Rectangle(350, 120, 450, 450)
        chtBusyTime.Printing.PrintPaint(e.Graphics, myRec)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        prtPreview.Document = prtDoc
        prtPreview.ShowDialog(Me)
    End Sub
End Class
