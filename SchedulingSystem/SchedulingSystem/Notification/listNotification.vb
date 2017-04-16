Imports System.IO

Public Class listNotification
    Public index As Integer = 0
    Dim userId As Integer = LoginSession.memberID

    Private Sub listNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim db As New ScheduleDBDataContext()
        Dim count As Integer = 0

        Dim appointmentQuery = From p In db.Participles, s In db.Schedules, st In db.ScheduleTimes
                               Where p.MemberID = userId And p.Status = "Pending" And p.ScheduleID = s.ScheduleID And s.ScheduleID = st.ScheduleID
                               Select s.ScheduleID, st.ScheduleStart, s.Title, s.Venue, s.Description

        Dim friendQuery = From f In db.Friends, m In db.Members
                          Where f.FriendID = userId And f.Status = "Pending" And f.Inviter = m.MemberID
                          Select m.MemberID, m.Username, m.Hobby, m.Picture


        'if appointment request exist
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
        End If

        'if friend request exist
        If friendQuery.Count > 0 Then
            For Each m In friendQuery
                lstFNotification.Items.Add(String.Format("{0} sent you a friend request.", m.Username))
                apmtDetail.Inviter(count) = New InviterDetail
                apmtDetail.Inviter(count).UserName = m.Username
                apmtDetail.Inviter(count).Hobby = m.Hobby
                apmtDetail.Inviter(count).MemberID = m.MemberID
                'convert to image 
                Dim img As Image
                Dim imgByte As Byte() = Nothing
                Dim stream As MemoryStream
                If m.Picture IsNot Nothing Then
                    imgByte = CType(m.Picture.ToArray, Byte())
                    stream = New MemoryStream(imgByte, 0, imgByte.Length)
                    img = Image.FromStream(stream)
                Else
                    img = My.Resources.user_default
                End If
                apmtDetail.Inviter(count).Picture = img
                count += 1
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
        getAppointmentData()

    End Sub

    Private Sub lstFNotification_MouseDoubleClick(sender As Object, e As EventArgs) Handles lstFNotification.MouseDoubleClick
        index = lstFNotification.SelectedIndex
        FriendNotification.Findex = index
        FriendNotification.ShowDialog()
        getFriendData()
    End Sub

    Public Sub getAppointmentData()
        Dim db As New ScheduleDBDataContext()
        Dim count As Integer = 0

        lstANotification.Items.Clear()

        Dim appointmentQuery = From p In db.Participles, s In db.Schedules, st In db.ScheduleTimes
                               Where p.MemberID = userId And p.Status = "Pending" And p.ScheduleID = s.ScheduleID And s.ScheduleID = st.ScheduleID
                               Select s.ScheduleID, st.ScheduleStart, s.Title, s.Venue, s.Description

        'if appointment request exist
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
        End If
        'get number of notification available
        lblANoticeAvailable.Text = appointmentQuery.Count & " Appointment Notification"

    End Sub

    Public Sub getFriendData()
        Dim db As New ScheduleDBDataContext()
        Dim count As Integer = 0

        lstFNotification.Items.Clear()

        Dim friendQuery = From f In db.Friends, m In db.Members
                          Where f.FriendID = userId And f.Status = "Pending" And f.Inviter = m.MemberID
                          Select m.MemberID, m.Username, m.Hobby, m.Picture

        'if friend request exist
        If friendQuery.Count > 0 Then
            For Each m In friendQuery
                lstFNotification.Items.Add(String.Format("{0} sent you a friend request.", m.Username))
                apmtDetail.Inviter(count) = New InviterDetail
                apmtDetail.Inviter(count).UserName = m.Username
                apmtDetail.Inviter(count).Hobby = m.Hobby
                apmtDetail.Inviter(count).MemberID = m.MemberID
                'convert to image 
                Dim img As Image
                Dim imgByte As Byte() = Nothing
                Dim stream As MemoryStream
                If m.Picture IsNot Nothing Then
                    imgByte = CType(m.Picture.ToArray, Byte())
                    stream = New MemoryStream(imgByte, 0, imgByte.Length)
                    img = Image.FromStream(stream)
                Else
                    img = My.Resources.user_default
                End If
                apmtDetail.Inviter(count).Picture = img
                count += 1
            Next
        End If

        'get number of notification available
        lblFNoticeAvailable.Text = friendQuery.Count & " Friend Notification"
    End Sub

End Class
