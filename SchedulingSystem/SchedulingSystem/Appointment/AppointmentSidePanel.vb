Public Class AppointmentSidePanel
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim ViewAppointmentCtrl As New ViewAppointment
        Dim mainform As New MainForm

        mainform.ContentPanel.Controls.Clear()
        mainform.ContentPanel.Controls.Add(ViewAppointmentCtrl)
    End Sub

    Private Sub btnMySchedule_Click(sender As Object, e As EventArgs) Handles btnMySchedule.Click
        Dim CreateAppointmentCtrl As New SecondUserControl
        Dim mainform As New MainForm

        mainform.ContentPanel.Controls.Clear()
        mainform.ContentPanel.Controls.Add(CreateAppointmentCtrl)
    End Sub
End Class
