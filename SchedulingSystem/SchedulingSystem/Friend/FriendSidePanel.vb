Public Class FriendSidePanel
    Private Sub FriendSidePanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New ScheduleDBDataContext

        Dim fl = From o In db.Friends,
                     m In db.Members
                 Where o.UserID = 100001 And o.FriendID = m.MemberID
                 Select m.Username, m.MemberID, o.Status
        DGVF.DataSource = fl
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Dim db As New ScheduleDBDataContext

        Dim fl = From o In db.Friends,
                     m In db.Members
                 Where o.UserID = 100001 And o.FriendID = m.MemberID And m.Username.Contains(txtsearch.Text)
                 Select m.Username, m.MemberID, o.Status

        DGVF.DataSource = fl


    End Sub

    Private Sub btnFriend_Click(sender As Object, e As EventArgs) Handles btnFriend.Click
        My.Forms.MainForm.ContentPanel.Controls.Clear()
        Dim UserCtrl3 As New SearchnewFriend
        My.Forms.MainForm.ContentPanel.Controls.Add(UserCtrl3)
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DGVF.SelectionChanged
        Static Dim curRow As Integer = -1
        If DGVF.CurrentRow.Index <> curRow Then
            My.Forms.MainForm.ContentPanel.Controls.Clear()

            curRow = DGVF.CurrentRow.Index
        End If


    End Sub


End Class
