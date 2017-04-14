Public Class UserMenu


    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        ' Log out
        MessageBox.Show("You have been logout.", "Logout")
        UserLogin.Show()
        MainForm.Close()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        ' View Profile
        UserProfile.ShowDialog()
    End Sub


End Class
