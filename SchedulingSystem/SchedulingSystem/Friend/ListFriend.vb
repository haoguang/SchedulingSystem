Public Class ListFriend
    Friend friend_id As Integer
    Friend user_id As Integer = 100001
    Friend sideCtrl As FriendSidePanel

    Private Sub ListFriend_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New ScheduleDBDataContext

        Dim fl = From m In db.Members, o In db.Friends
                 Where m.MemberID = o.FriendID And o.UserID = user_id And o.FriendID = friend_id
                 Select m.MemberID, m.Nickname, m.Gender, m.Occupation, m.Hobby, o.Status

        lbl_ID.Text = fl.FirstOrDefault.MemberID.ToString()
        lbl_N.Text = fl.FirstOrDefault.Nickname
        lbl_G.Text = fl.FirstOrDefault.Gender
        lbl_Oc.Text = fl.FirstOrDefault.Occupation
        lbl_H.Text = fl.FirstOrDefault.Hobby
        cbo_S.SelectedItem = fl.FirstOrDefault.Status
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim db As New ScheduleDBDataContext()

        Dim a As [Friend] = db.Friends.FirstOrDefault(Function(o) o.UserID = Integer.Parse(lbl_ID.Text))
        a.Status = cbo_S.SelectedItem.ToString()
        db.SubmitChanges()
        sideCtrl.populateDGVF()
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        Dim db As New ScheduleDBDataContext
        Dim UserCtrl3 As New ListFriend
        Dim FriendSidePanel As New FriendSidePanel

        Dim btn_delete As [Friend] = db.Friends.FirstOrDefault(Function(o) o.FriendID = Integer.Parse(sideCtrl.DGVF.CurrentRow.Cells(0).Value.ToString))
        db.Friends.DeleteOnSubmit(btn_delete)
        db.SubmitChanges()
        sideCtrl.populateDGVF()
        My.Forms.MainForm.ContentPanel.Controls.Clear()
    End Sub
End Class
