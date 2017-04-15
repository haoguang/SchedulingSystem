Imports System.Data.Linq
Imports System.Text

Public Class ChangePassword
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtConfirmPassword.Text = ""
        txtNewPassword.Text = ""
        txtOldPassword.Text = ""
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        'Validation
        If txtOldPassword.Text = "" Then
            err.AppendLine("- Please enter old password.")
            ctr = If(ctr, txtOldPassword)
        End If

        If txtNewPassword.Text = "" Then
            err.AppendLine("- Please enter new password.")
            ctr = If(ctr, txtNewPassword)
        End If

        If txtConfirmPassword.Text = "" Then
            err.AppendLine("- Please enter confirm password.")
            ctr = If(ctr, txtConfirmPassword)
        End If

        If txtConfirmPassword.Text.Equals(txtNewPassword.Text) = False Then
            err.AppendLine("- Confirm password not match.")
            ctr = If(ctr, txtConfirmPassword)
        End If

        'show error message
        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr.Focus()
            Return
        End If

        Dim username As String = LoginSession.username
        'database
        Dim db As New ScheduleDBDataContext()
        Dim member As Table(Of Member) = db.GetTable(Of Member)()

        'check username
        Dim query = From m In member
                    Where m.Username = username
                    Select m
        'if exist
        If query.Count > 0 Then
            For Each m In query
                If m.Password.Equals(txtOldPassword.Text) Then
                    Dim updateMember = (From mem In db.Members
                                        Where mem.Username = username).ToList()(0)
                    updateMember.Password = txtNewPassword.Text
                    Try
                        db.SubmitChanges()
                        MessageBox.Show("Password changed successfully.", "Congratulation")
                        Me.Close()
                    Catch ex As Exception
                        MessageBox.Show("Fail to change password.", "Error")
                    End Try


                Else
                    MessageBox.Show("Incorrect old password.", "Error")
                End If
            Next
        End If

    End Sub

    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtConfirmPassword.Text = ""
        txtNewPassword.Text = ""
        txtOldPassword.Text = ""
    End Sub
End Class