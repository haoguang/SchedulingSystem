Public Class AppointmentSidePanel
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim ViewAppointmentCtrl As New ViewAppointment


        My.Forms.MainForm.ContentPanel.Controls.Clear()
        My.Forms.MainForm.ContentPanel.Controls.Add(ViewAppointmentCtrl)
    End Sub

    Private Sub btnMySchedule_Click(sender As Object, e As EventArgs) Handles btnMySchedule.Click
        Dim CreateAppointmentCtrl As New SecondUserControl


        My.Forms.MainForm.ContentPanel.Controls.Clear()
        My.Forms.MainForm.ContentPanel.Controls.Add(CreateAppointmentCtrl)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim UpdateAppointmentCtrl As New UpdateAppointment

        My.Forms.MainForm.ContentPanel.Controls.Clear()
        My.Forms.MainForm.ContentPanel.Controls.Add(UpdateAppointmentCtrl)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim AppointmentReportCtrl As New AppointmentReport

        My.Forms.MainForm.ContentPanel.Controls.Clear()
        My.Forms.MainForm.ContentPanel.Controls.Add(AppointmentReportCtrl)
    End Sub
End Class
