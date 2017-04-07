Public Class ListFriend
    Friend user_id As Integer

    Private Sub ListFriend_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New ScheduleDBDataContext

        Dim fl = From m In db.Members
                 Where m.MemberID = user_id
                 Select m.MemberID

        lbl_ID.Text = fl.FirstOrDefault.ToString()























    End Sub
End Class
