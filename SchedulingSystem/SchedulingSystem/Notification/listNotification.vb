﻿Public Class listNotification
    Public index As Integer = 0
    Dim userId As Integer = LoginSession.memberID

    Private Sub listNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim db As New ScheduleDBDataContext()
        Dim count As Integer = 0
        Dim currentDateTime As DateTime

        currentDateTime = DateTime.Now

        Dim friendQuery = From f In db.Friends, m In db.Members
                          Where f.UserID = userId And f.Status = "Pending" And f.Inviter = m.MemberID
                          Select m.MemberID, m.Username, m.Hobby, m.Picture

        Dim appointmentQuery = From p In db.Participles, s In db.Schedules, st In db.ScheduleTimes
                               Where p.MemberID = userId And p.Status = "Pending" And p.ScheduleID = s.ScheduleID And s.ScheduleID = st.ScheduleID
                               Select s.ScheduleID, st.ScheduleStart, s.Title, s.Venue, s.Description

        'if exist
        If appointmentQuery.Count > 0 Then
            For Each s In appointmentQuery

                lstANotification.Items.Add(String.Format("There is a {0} request on {1}", s.Title, s.ScheduleStart))
                apmtDetail.Appointment(count) = New ApmtNoticeDetail
                apmtDetail.Appointment(count).ScheduleID = s.ScheduleID
                apmtDetail.Appointment(count).ScheduleTime = s.ScheduleStart.ToString
                apmtDetail.Appointment(count).Title = s.Title
                apmtDetail.Appointment(count).Venue = s.Venue
                apmtDetail.Appointment(count).Description = s.Description
                count += 1
            Next
        ElseIf friendQuery.Count > 0 Then
            For Each m In friendQuery
                lstFNotification.Items.Add(String.Format("{0} sent you a friend request.", m.Username))
            Next
        End If

        'get number of notification available
        lblANoticeAvailable.Text = appointmentQuery.Count & " Appointment Notification"
        lblFNoticeAvailable.Text = friendQuery.Count & " Friend Notification"

    End Sub

    Private Sub lstANotification_MouseDoubleClick(sender As Object, e As EventArgs) Handles lstANotification.MouseDoubleClick
        index = lstANotification.SelectedIndex
        AppointmentNotification.index = index
        AppointmentNotification.ShowDialog()

    End Sub

    Private Sub lstFNotification_MouseDoubleClick(sender As Object, e As EventArgs) Handles lstFNotification.MouseDoubleClick
        index = lstANotification.SelectedIndex
        FriendNotification.ShowDialog()
    End Sub

End Class
