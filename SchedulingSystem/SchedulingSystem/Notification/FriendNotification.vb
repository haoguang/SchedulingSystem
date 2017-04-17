Imports System.IO
Public Class FriendNotification
    Public Findex As Integer
    Dim userId As Integer = LoginSession.memberID 'MemberID that login now

    Private Sub FriendNotification_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub FriendNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim friendID As Integer = apmtDetail.Inviter(Findex).MemberID   'MemberID that request to do friend

        picUser.Image = apmtDetail.Inviter(Findex).Picture
        lblFriendName.Text = apmtDetail.Inviter(Findex).UserName
        lblFriendHobby.Text = apmtDetail.Inviter(Findex).Hobby

        Me.AcceptButton = btnAccept
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Dim friendID As Integer = apmtDetail.Inviter(Findex).MemberID 'MemberID that request to do friend

        Friend_Module.acceptRequest(friendID, userId)
        MessageBox.Show("Friend Added Succcesfully!" & vbNewLine & "Happy Be Friend!")
        Me.Close()
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        Dim friendID As Integer = apmtDetail.Inviter(Findex).MemberID 'MemberID that request to do friend

        Friend_Module.rejectRequest(friendID, userId)
        MessageBox.Show("Friend Request Rejected!" & vbNewLine & "Sad to See That...")
        Me.Close()
    End Sub
End Class