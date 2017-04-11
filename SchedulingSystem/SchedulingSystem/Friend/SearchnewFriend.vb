Public Class SearchnewFriend
    Dim db As New ScheduleDBDataContext



    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged

        Dim choosenType = 0
        If R_ID.Checked = False And R_Name.Checked = False And R_Hobby.Checked = True Then
            choosenType = 3
        ElseIf R_ID.Checked = False And R_Hobby.Checked = False And R_Name.Checked = True Then
            choosenType = 2



        ElseIf R_Hobby.Checked = False And R_Name.Checked = False And R_ID.Checked = True Then
            choosenType = 1

        Else
            MessageBox.Show("Please select an Option")
        End If
        Dim sf As IQueryable
        Select Case choosenType
            Case 1

                sf = From m In db.Members
                     Where m.MemberID.ToString.StartsWith((txtsearch.Text))
                     Select m.MemberID, m.Username, m.Hobby

            Case 2

                sf = From m In db.Members
                     Where m.Username.ToString.StartsWith((txtsearch.Text))
                     Select m.MemberID, m.Username, m.Hobby

            Case 3
                sf = From m In db.Members
                     Where m.Hobby.ToString.StartsWith((txtsearch.Text))
                     Select m.MemberID, m.Username, m.Hobby

            Case Else
                MessageBox.Show("Please choose a Radio Button")
        End Select
        If txtsearch.Text.Equals("") Then
            DGVS.DataSource = Nothing
        Else
            DGVS.DataSource = sf
        End If

    End Sub

    Public Function CheckUserRelation(userid As Integer) As Boolean
        Dim db As New ScheduleDBDataContext
        Return db.Friends.Any(Function(o) o.FriendID = userid And o.UserID = 100001)
    End Function

    Public Function CheckUserIsPending(userid As Integer) As Boolean
        Dim db As New ScheduleDBDataContext
        Return db.Friends.Any(Function(o) o.FriendID = userid And o.UserID = 100001 And o.Status = "Pending")
    End Function

    Public Function isMe(userid As Integer) As Boolean
        Return userid = 100001 'need to edit
    End Function

    Private Sub R_ID_CheckedChanged(sender As Object, e As EventArgs) Handles R_ID.CheckedChanged, R_Name.CheckedChanged, R_Hobby.CheckedChanged
        DGVS.DataSource = Nothing
        If txtsearch.Text <> "" Then
            txtsearch_TextChanged(Nothing, Nothing)
        Else
            DGVS.DataSource = Nothing
        End If
    End Sub

    Private Sub btn_addfriend_Click(sender As Object, e As EventArgs) Handles btn_addfriend.Click
        Dim UserCtrl3 As New ListFriend
        Dim friend_id As Integer = Integer.Parse(DGVS.CurrentRow.Cells(0).Value.ToString)
        Console.Write(DGVS.CurrentRow.Cells(1).Value.ToString)

        If CheckUserIsPending(friend_id) Then
            MessageBox.Show("You Already Sent Friend Request")

        ElseIf CheckUserRelation(friend_id) Then
            MessageBox.Show("You Both Are Already Friend")
        ElseIf isMe(friend_id) Then
            MessageBox.Show("You Are Not Allowed To Add Yourself")
        Else
            Dim add_friend As New [Friend]
            add_friend.UserID = DevelopmentVariables.UserID
            add_friend.FriendID = friend_id
            add_friend.Status = "Pending"

            db.Friends.InsertOnSubmit(add_friend)
            db.SubmitChanges()

            MessageBox.Show("Sucessfully Send Friend Request!")

        End If

    End Sub

End Class
