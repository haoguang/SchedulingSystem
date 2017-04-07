Public Class ScheduleSidePanel
    Private Sub btnAddSchedule_Click(sender As Object, e As EventArgs) Handles btnAddSchedule.Click
        Dim UserCtrl As New ActivityRegister
        My.Forms.MainForm.ContentPanel.Controls.Clear()
        My.Forms.MainForm.ContentPanel.Controls.Add(UserCtrl)
    End Sub

    Private Sub btnMySchedule_Click(sender As Object, e As EventArgs) Handles btnMySchedule.Click
        Dim UserCtrl As New DayScheduleViewer
        My.Forms.MainForm.ContentPanel.Controls.Clear()
        My.Forms.MainForm.ContentPanel.Controls.Add(UserCtrl)
    End Sub
End Class
