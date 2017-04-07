﻿Public Class MainForm
    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        Dim UserCtrl1 As New DayScheduleViewer
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

    Private Sub ContentPanel_MouseEnter(sender As Object, e As EventArgs) Handles ContentPanel.MouseEnter
        ContentPanel.Focus()
    End Sub

    Private Sub SidePanel_MouseEnter(sender As Object, e As EventArgs) Handles SidePanel.MouseEnter
        SidePanel.Focus()
    End Sub

    Private Sub btnFriends_Click(sender As Object, e As EventArgs) Handles btnFriends.Click
        Dim FriendSidePanel As New FriendSidePanel
        SideContentPanel.Controls.Clear()
        SideContentPanel.Controls.Add(FriendSidePanel)
    End Sub
End Class
