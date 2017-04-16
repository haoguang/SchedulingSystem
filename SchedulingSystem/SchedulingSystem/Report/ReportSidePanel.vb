Public Class ReportSidePanel
    Private Sub btnAppointmentReport_Click(sender As Object, e As EventArgs) Handles btnAppointmentReport.Click
        ' summon appointment report ui
    End Sub

    Private Sub btnFriendReport_Click(sender As Object, e As EventArgs) Handles btnFriendReport.Click
        ' summon friend report ui
    End Sub

    Private Sub btnMemberReport_Click(sender As Object, e As EventArgs) Handles btnMemberReport.Click
        ' summon member report ui
        Dim UserReportCtrl As New UserRpt
        My.Forms.MainForm.ContentPanel.Controls.Clear()
        My.Forms.MainForm.ContentPanel.Controls.Add(UserReportCtrl)
    End Sub

    Private Sub btnNotificationReport_Click(sender As Object, e As EventArgs) Handles btnNotificationReport.Click
        ' summon notification report ui
    End Sub

    Private Sub btnScheduleReport_Click(sender As Object, e As EventArgs) Handles btnScheduleReport.Click
        ' summon schedule report ui
        Dim scheduleReport As New ScheduleReport
        My.Forms.MainForm.ContentPanel.Controls.Clear()
        My.Forms.MainForm.ContentPanel.Controls.Add(scheduleReport)
    End Sub
End Class
