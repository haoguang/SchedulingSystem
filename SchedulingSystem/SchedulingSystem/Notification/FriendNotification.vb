Imports System.IO
Public Class FriendNotification
    Public Findex As Integer
    Dim userId As Integer = LoginSession.memberID 'MemberID that login now
    Dim friendID As Integer = apmtDetail.Inviter(Findex).MemberID 'MemberID that request to do friend

    Private Sub FriendNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picUser.Image = apmtDetail.Inviter(Findex).Picture
        lblFriendName.Text = apmtDetail.Inviter(Findex).UserName
        lblFriendHobby.Text = apmtDetail.Inviter(Findex).Hobby

        Me.AcceptButton = btnAccept
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Friend_Module.acceptRequest(friendID, userId)
        MessageBox.Show("Friend Added Succcesfully!" & vbNewLine & "")
        Me.Close()
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click

    End Sub
End Class