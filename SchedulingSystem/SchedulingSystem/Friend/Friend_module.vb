Module Friend_Module
    Public Function notification(user_id As Integer, friend_id As Integer) As Boolean
        Dim db As New ScheduleDBDataContext
        Dim a As [Friend] = db.Friends.FirstOrDefault(Function(o) o.UserID = user_id And o.FriendID = friend_id)
        a.Status = "Friend"
        a.MeetDate = Date.Today
        db.SubmitChanges()
        Return True
    End Function
End Module
