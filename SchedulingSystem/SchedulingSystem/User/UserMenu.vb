Imports System.Data.Linq

Public Class UserMenu


    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        ' insert login record
        Dim db As New ScheduleDBDataContext
        Dim l As New LoginRecord()
        l.SignInTime = LoginSession.signInTime
        l.UserId = LoginSession.memberID
        l.SignOutTime = DateTime.Now

        db.LoginRecords.InsertOnSubmit(l)
        Try
            db.SubmitChanges()
            'log out
            MessageBox.Show("You have been logout.", "Logout")
            UserLogin.Show()
            MainForm.Close()
        Catch ex As Exception
            MessageBox.Show("Fail to logout.", "Error")
        End Try

    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        ' View Profile
        UserProfile.ShowDialog()
    End Sub


End Class
