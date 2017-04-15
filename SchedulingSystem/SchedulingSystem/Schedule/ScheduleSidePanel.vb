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

    Private Sub mcrPicker_DateChanged(sender As Object, e As DateRangeEventArgs) Handles mcrPicker.DateChanged
        Dim dayViewer As New DayScheduleViewer
        dayViewer.displayDate = mcrPicker.SelectionRange.Start().Date
        My.Forms.MainForm.ContentPanel.Controls.Clear()
        My.Forms.MainForm.ContentPanel.Controls.Add(dayViewer)
    End Sub

    Private Sub ScheduleSidePanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dayViewer As New DayScheduleViewer
        dayViewer.displayDate = mcrPicker.SelectionRange.Start().Date
        My.Forms.MainForm.ContentPanel.Controls.Clear()
        My.Forms.MainForm.ContentPanel.Controls.Add(dayViewer)
    End Sub
End Class
