Imports System.IO

Public Class ListFriend
    Friend friend_id As Integer
    Friend user_id As Integer = LoginSession.memberID
    Friend sideCtrl As FriendSidePanel

    Private Sub ListFriend_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New ScheduleDBDataContext
        Dim img As Image
        Dim imgByte As Byte() = Nothing
        Dim stream As MemoryStream
        Dim fl = From m In db.Members, o In db.Friends
                 Where m.MemberID = o.FriendID And o.UserID = user_id And o.FriendID = friend_id
                 Select m.MemberID, m.Nickname, m.Gender, m.Occupation, m.Hobby, o.Status, m.Picture
        lbl_ID.Text = fl.FirstOrDefault.MemberID.ToString()
        lbl_N.Text = fl.FirstOrDefault.Nickname
        lbl_G.Text = fl.FirstOrDefault.Gender
        lbl_Oc.Text = fl.FirstOrDefault.Occupation
        lbl_H.Text = fl.FirstOrDefault.Hobby
        cbo_S.SelectedItem = fl.FirstOrDefault.Status

        For Each p In fl
            If p.Picture IsNot Nothing Then
                imgByte = CType(p.Picture.ToArray, Byte())
                stream = New MemoryStream(imgByte, 0, imgByte.Length)
                img = Image.FromStream(stream)
                PictureBox1.Image = img
            Else
                img = My.Resources.user_default
                PictureBox1.Image = img

            End If

        Next
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

        Dim btn_delete As [Friend] = db.Friends.FirstOrDefault(Function(o) o.FriendID = user_id)
        db.Friends.DeleteOnSubmit(btn_delete)
        db.SubmitChanges()
        sideCtrl.populateDGVF()
        My.Forms.MainForm.ContentPanel.Controls.Clear()
    End Sub

End Class
