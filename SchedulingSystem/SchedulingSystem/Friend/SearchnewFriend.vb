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
        Return db.Friends.Any(Function(o) o.FriendID = userid And o.UserID = LoginSession.memberID)
    End Function

    Public Function CheckUserIsPending(userid As Integer) As Boolean
        Dim db As New ScheduleDBDataContext
        Return db.Friends.Any(Function(o) o.FriendID = userid And o.UserID = LoginSession.memberID And o.Status = "Pending")
    End Function
    Public Function isMe(userid As Integer) As Boolean
        Return userid = LoginSession.memberID 'need to edit
    End Function

    Private Sub btn_addfriend_Click(sender As Object, e As EventArgs) Handles btn_addfriend.Click
        If R_ID.Checked = True And txtsearch.Text = "" Then
            MessageBox.Show("Please Enter ID to search Friend")
        ElseIf R_ID.Checked = False And R_Name.Checked = True And R_Hobby.Checked = False And txtsearch.Text = "" Then
            MessageBox.Show("Please Enter Name to search Friend")
        ElseIf R_ID.Checked = False And R_Name.Checked = False And R_Hobby.Checked = True And txtsearch.Text = "" Then
            MessageBox.Show("Please Enter Hobby to search Friend")
        ElseIf R_ID.Checked = False And R_Name.Checked = False And R_Hobby.Checked = False Or txtsearch.Text = "" Then
            MessageBox.Show("Please Select an RadioButtoon and Enter something to search friend")
        Else
            Dim UserCtrl3 As New ListFriend
            Dim friend_id As Integer = Integer.Parse(DGVS.CurrentRow.Cells(0).Value.ToString)

            If CheckUserIsPending(friend_id) Then
                MessageBox.Show("You Already Sent Friend Request")
            ElseIf CheckUserRelation(friend_id) Then
                MessageBox.Show("You Both Are Already Friend")
            ElseIf isMe(friend_id) Then
                MessageBox.Show("You Are Not Allowed To Add Yourself")
            Else
                Dim add_friend As New [Friend]
                add_friend.UserID = LoginSession.memberID
                add_friend.FriendID = friend_id
                add_friend.RequestDate = Today.Date
                add_friend.Status = "Pending"
                add_friend.Inviter = LoginSession.memberID

                db.Friends.InsertOnSubmit(add_friend)
                db.SubmitChanges()

                MessageBox.Show("Sucessfully Send Friend Request!")
            End If

        End If
    End Sub

    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress

        If R_ID.Checked = True Then
            Dim allowedChars As String = "0123456789"
            If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If

        ElseIf R_Name.Checked = True Then
            If Not (Asc(e.KeyChar) = 20) AndAlso e.KeyChar <> ControlChars.Back Then
                Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
                If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        Else
            If Not (Asc(e.KeyChar) = 20) AndAlso e.KeyChar <> ControlChars.Back Then
                Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
                If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        End If
    End Sub
End Class
