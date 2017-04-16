Public Class MainForm
    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click

        Dim SideContent As New ScheduleSidePanel
        SideContent.Dock = DockStyle.Fill
        SideContentPanel.Controls.Clear()
        SideContentPanel.Controls.Add(SideContent)
    End Sub

    Private Sub btnAppointment_Click(sender As Object, e As EventArgs) Handles btnAppointment.Click

        Dim AppointmentSideContent As New AppointmentSidePanel
        ContentPanel.Controls.Clear()
        SideContentPanel.Controls.Clear()
        SideContentPanel.Controls.Add(AppointmentSideContent)

        Dim CreateAppointmentCtrl As New SecondUserControl


        My.Forms.MainForm.ContentPanel.Controls.Clear()
        My.Forms.MainForm.ContentPanel.Controls.Add(CreateAppointmentCtrl)

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
        ContentPanel.Controls.Clear()
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
        AlarmClass.updateReminder() ' get reminder
        AlarmClass.nextDate = Date.Now.Date
        tmrClock.Start()

        'Dim trd As Threading.Thread = New Threading.Thread(AddressOf getReminder)
        'trd.IsBackground = True
        'trd.Start()

        Dim SideContent As New ScheduleSidePanel
        SideContent.Dock = DockStyle.Fill
        SideContentPanel.Controls.Clear()
        SideContentPanel.Controls.Add(SideContent)

    End Sub

    Private Sub umDropDownMenu_MouseLeave() Handles umDropDownMenu.MouseLeave
        umDropDownMenu.Visible = False
    End Sub

    Private Sub umDropDownMenu_MouseLeave(sender As Object, e As EventArgs) Handles umDropDownMenu.MouseLeave

    End Sub

    Private Sub btnNotification_Click(sender As Object, e As EventArgs) Handles btnNotification.Click
        Dim listNotification As New listNotification
        SideContentPanel.Controls.Clear()
        ContentPanel.Controls.Clear()
        ContentPanel.Controls.Add(listNotification)
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim reportSidePanel As New ReportSidePanel
        SideContentPanel.Controls.Clear()
        SideContentPanel.Controls.Add(reportSidePanel)

        Dim firstPage As New ReportPage
        ContentPanel.Controls.Clear()
        firstPage.Dock = DockStyle.Fill
        ContentPanel.Controls.Add(firstPage)

    End Sub

    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        lblClock.Text = DateTime.Now.ToLongTimeString

        If AlarmClass.reminders.Count > 0 Then
            If lblClock.Text.Equals(CDate(AlarmClass.reminders.Peek.ReminderDateTime).ToLongTimeString()) Then
                Dim reminder As Reminder = AlarmClass.reminders.Pop()
                AlarmClass.triggerAlarm(CInt(reminder.ScheduleID), CInt(reminder.MinutesBefore))
            End If
        End If


        If Date.Now.Date.Equals(AlarmClass.nextDate) Then
            AlarmClass.nextDate = Date.Now.Date
            AlarmClass.updateReminder()
        End If

    End Sub

    Private Sub btnUserInfo_Load(sender As Object, e As EventArgs) Handles btnUserInfo.Load

    End Sub

    'Private Sub getReminder()
    '    Dim db As New ScheduleDBDataContext
    '    Dim time As String
    '    Dim currentDateTime As DateTime
    '    currentDateTime = DateTime.Now

    '    Dim ReminderDate = From rm In db.Reminders, s In db.Schedules
    '                       Where CDate(rm.ReminderDateTime).Date = CDate(currentDateTime).Date And rm.ScheduleID = s.ScheduleID
    '                       Select rm.ReminderDateTime, s.Title, rm.MinutesBefore

    '    For Each r In ReminderDate
    '        time = CDate(r.ReminderDateTime).ToLongTimeString
    '        Dim msg As String = r.MinutesBefore & " minutes before " & r.Title & " start"
    '        If (tmrClock.ToString = time) Then
    '            MsgBox(msg)
    '        End If
    '    Next

    '    Threading.Thread.Sleep(1000)
    'End Sub
End Class
