Imports System.Data.SqlClient

Public Class ScheduleReport
    Private Sub dtpMonth_ValueChanged(sender As Object, e As EventArgs) Handles dtpMonth.ValueChanged

        Dim month As Integer = dtpMonth.Value.Month
        Dim year As Integer = dtpMonth.Value.Year

        Dim db As New ScheduleDBDataContext

        Dim rs = From st In db.ScheduleTimes Join s In db.Schedules On s.ScheduleID Equals st.ScheduleID
                 Join p In db.Participles On s.ScheduleID Equals p.ScheduleID
                 Where CLng(p.MemberID) = LoginSession.memberID And
                    CLng(st.ScheduleStart.Value.Month) = month And
                    CLng(st.ScheduleStart.Value.Year) = year
                 Group st By Column1 = CType(st.ScheduleStart.Value.Hour, Integer?)
                    Into g = Group
                 Order By
                      Column1
                 Select
                     TimeInvolve = Column1,
                     BusyRate = CType(g.Count(Function(p) p.ScheduleStart.Value.Hour <> Nothing) / 30 * 100, Int64?)

        dgvScheduleReport.DataSource = rs
        chtBusyTime.DataSource = rs



        chtBusyTime.Series("Series1").YValueMembers = "BusyRate"
        chtBusyTime.Series("Series1").XValueMember = "TimeInvolve"

        chtBusyTime.DataBind()
    End Sub


End Class
