Public Class Form1
    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        Dim UserCtrl1 As New TestUserControl1
        ContentPanel.Controls.Clear()
        ContentPanel.Controls.Add(UserCtrl1)
    End Sub

    Private Sub btnAppointment_Click(sender As Object, e As EventArgs) Handles btnAppointment.Click
        Dim UserCtrl2 As New SecondUserControl
        ContentPanel.Controls.Clear()
        ContentPanel.Controls.Add(UserCtrl2)
    End Sub
End Class
