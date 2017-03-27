Public Class MainForm
    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        Dim UserCtrl1 As New TestUserControl1
        SidePanel.Controls.Clear()
        SidePanel.Controls.Add(UserCtrl1)
    End Sub

    Private Sub btnAppointment_Click(sender As Object, e As EventArgs) Handles btnAppointment.Click
        Dim UserCtrl2 As New SecondUserControl
        SidePanel.Controls.Clear()
        SidePanel.Controls.Add(UserCtrl2)
    End Sub
End Class
