Public Class MainForm
    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        Dim UserCtrl1 As New ActivityRegister
        Dim SideContent As New ScheduleSidePanel
        ContentPanel.Controls.Clear()
        ContentPanel.Controls.Add(UserCtrl1)
        SideContentPanel.Controls.Clear()
        SideContentPanel.Controls.Add(SideContent)
    End Sub

    Private Sub btnAppointment_Click(sender As Object, e As EventArgs) Handles btnAppointment.Click
        Dim UserCtrl2 As New SecondUserControl
        Dim AppointmentSideContent As New AppointmentSidePanel
        ContentPanel.Controls.Clear()
        ContentPanel.Controls.Add(UserCtrl2)
        SideContentPanel.Controls.Clear()
        SideContentPanel.Controls.Add(AppointmentSideContent)

    End Sub
End Class
