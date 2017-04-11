Public Class MainForm
    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        Dim UserCtrl1 As New DayScheduleViewer
        Dim SideContent As New ScheduleSidePanel
        ContentPanel.Controls.Clear()
        ContentPanel.Controls.Add(UserCtrl1)
        SideContentPanel.Controls.Clear()
        SideContentPanel.Controls.Add(SideContent)
    End Sub

    Private Sub btnAppointment_Click(sender As Object, e As EventArgs) Handles btnAppointment.Click

        Dim AppointmentSideContent As New AppointmentSidePanel
        ContentPanel.Controls.Clear()
        SideContentPanel.Controls.Clear()
        SideContentPanel.Controls.Add(AppointmentSideContent)

    End Sub

    Private Sub ContentPanel_MouseEnter(sender As Object, e As EventArgs) Handles ContentPanel.MouseEnter
        ContentPanel.Focus()
    End Sub

    Private Sub SidePanel_MouseEnter(sender As Object, e As EventArgs) Handles SidePanel.MouseEnter
        SidePanel.Focus()
    End Sub

    Private Sub btnFriends_Click(sender As Object, e As EventArgs) Handles btnFriends.Click
        Dim FriendSidePanel As New FriendSidePanel
        FriendSidePanel.Dock = DockStyle.Fill
        SideContentPanel.Controls.Clear()
        SideContentPanel.Controls.Add(FriendSidePanel)
    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        btnUserInfo.pcbProfilePic.Image = My.Resources.user_default
        btnUserInfo.lblName.Text = "My Sample name"
        btnUserInfo.lblUserEmail.Text = "hg@sample.com"
    End Sub
End Class
