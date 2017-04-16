Public Class MainForm
    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click

        Dim SideContent As New ScheduleSidePanel
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
        btnUserInfo.pcbProfilePic.Image = LoginSession.picture
        btnUserInfo.lblName.Text = LoginSession.nickname
        btnUserInfo.lblUserEmail.Text = LoginSession.email
    End Sub

    Private Sub btnDown_Click()
        umDropDownMenu.Visible = True
        Refresh()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler btnUserInfo.btnMenuEvent, AddressOf btnDown_Click
    End Sub

    Private Sub umDropDownMenu_MouseLeave() Handles umDropDownMenu.MouseLeave
        umDropDownMenu.Visible = False
    End Sub

    Private Sub umDropDownMenu_MouseLeave(sender As Object, e As EventArgs) Handles umDropDownMenu.MouseLeave

    End Sub

    Private Sub btnNotification_Click(sender As Object, e As EventArgs) Handles btnNotification.Click
        Dim listNotification As New listNotification
        ContentPanel.Controls.Clear()
        ContentPanel.Controls.Add(listNotification)
    End Sub

End Class
