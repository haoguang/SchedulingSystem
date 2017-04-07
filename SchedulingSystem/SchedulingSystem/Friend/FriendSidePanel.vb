Public Class FriendSidePanel
    Private Sub FriendSidePanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateDGVF()

    End Sub

    Friend Sub populateDGVF()
        Dim db As New ScheduleDBDataContext

        Dim fl = From o In db.Friends, m In db.Members
                 Where o.UserID = 100001 And o.FriendID = m.MemberID And o.Status <> "Pending"
                 Select m.Username, m.MemberID, o.Status
        DGVF.DataSource = fl
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Dim db As New ScheduleDBDataContext

        Dim fl = From o In db.Friends,
                     m In db.Members
                 Where o.UserID = 100001 And o.FriendID = m.MemberID And m.Username.StartsWith(txtsearch.Text)
                 Select m.Username, m.MemberID, o.Status

        DGVF.DataSource = fl


    End Sub

    Private Sub btnFriend_Click(sender As Object, e As EventArgs) Handles btnFriend.Click
        My.Forms.MainForm.ContentPanel.Controls.Clear()
        Dim UserCtrl3 As New SearchnewFriend
        My.Forms.MainForm.ContentPanel.Controls.Add(UserCtrl3)
    End Sub

    Private Sub DGVF_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVF.CellClick
        My.Forms.MainForm.ContentPanel.Controls.Clear()
        Dim UserCtrl4 As New ListFriend
        UserCtrl4.friend_id = Integer.Parse(DGVF.CurrentRow.Cells(1).Value.ToString)
        UserCtrl4.sideCtrl = Me
        My.Forms.MainForm.ContentPanel.Controls.Add(UserCtrl4)

    End Sub
End Class
