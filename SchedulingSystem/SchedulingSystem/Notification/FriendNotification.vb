Imports System.IO
Public Class FriendNotification
    Public Findex As Integer
    Private Sub FriendNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        picUser.Image = apmtDetail.Inviter(Findex).Picture
        lblFriendName.Text = apmtDetail.Inviter(Findex).UserName
        lblFriendHobby.Text = apmtDetail.Inviter(Findex).Hobby

        Me.AcceptButton = btnAccept
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click

    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click

    End Sub
End Class