Public Class listNotification
    Public index As Integer = 0
    Dim userId As Integer = LoginSession.memberID

    Private Sub listNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim db As New ScheduleDBDataContext()

        Dim friendNotification = From f In db.Friends, m In db.Members
                                 Where f.UserID = userId And f.Status = "pending" And f.Inviter = m.MemberID
                                 Select New With {
                                     m.Username
                                   }

        Dim appointmentNotification = From p In db.Participles, m In db.Members, s In db.Schedules
                                      Where p.MemberID = userId And p.Status = "pending" And p.ScheduleID = s.ScheduleID
                                      Select New With {
                                           s.Title,
                                           s.ScheduleTimes
                                   }

        If (friendNotification IsNot Nothing) Then
            lstNotification.Items.Add(friendNotification)
        ElseIf (appointmentNotification IsNot Nothing) Then
            lstNotification.Items.Add(appointmentNotification)
        ElseIf (friendNotification Is Nothing And appointmentNotification Is Nothing) Then
            lstNotification.Items.Add("N/A")
        ElseIf (friendNotification IsNot Nothing And appointmentNotification IsNot Nothing) Then
            lstNotification.Items.Add("Hello")
        End If
    End Sub

    Private Sub lstNotification_MouseDoubleClick(sender As Object, e As EventArgs) Handles lstNotification.MouseDoubleClick
        index = lstNotification.SelectedIndex
        'showNotification.ShowDialog()
    End Sub
End Class
