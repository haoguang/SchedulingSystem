Public Class listNotification
    Public index As Integer = 0
    Dim userId As Integer = LoginSession.memberID

    Private Sub listNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim db As New ScheduleDBDataContext()
        Dim currentDateTime As DateTime

        currentDateTime = DateTime.Now

        Dim friendQuery = From f In db.Friends, m In db.Members
                          Where f.UserID = userId And f.Status = "pending" And f.Inviter = m.MemberID
                          Select m

        Dim appointmentQuery2 = From p In db.Participles, m In db.Members, s In db.Schedules, st In db.ScheduleTimes
                                Where p.MemberID = userId And p.Status = "pending" And p.ScheduleID = s.ScheduleID And s.ScheduleID = st.ScheduleID
                                Select s.ScheduleID, st.ScheduleStart, s.Title

        'if exist
        If appointmentQuery2.Count > 0 Then
            For Each s In appointmentQuery2
                lstNotification.Items.Add(String.Format("There is a {0} request on {1}.  {2}  {3}", s.Title, s.ScheduleStart, s.ScheduleID, appointmentQuery2.Count))
            Next
        Else
            lstNotification.Items.Add("Appointment N/A")
        End If

        If friendQuery.Count > 0 Then
            For Each m In friendQuery
                lstNotification.Items.Add(String.Format("{0} sent you a friend request. {1}", m.Username, friendQuery.Count))
            Next
        Else
            lstNotification.Items.Add("friend N/A")
        End If


    End Sub

    Private Sub lstNotification_MouseDoubleClick(sender As Object, e As EventArgs) Handles lstNotification.MouseDoubleClick
        index = lstNotification.SelectedIndex
        FriendNotification.ShowDialog()

    End Sub
End Class
