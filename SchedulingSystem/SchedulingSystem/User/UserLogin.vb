﻿Imports System.Data.Linq
Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports System.Text

Public Class UserLogin
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'show registration form
        Registration.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'database
        Dim db As New ScheduleDBDataContext
        Dim member As Table(Of Member) = db.GetTable(Of Member)()
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        'validation
        If txtUsername.Text = "" Then
            err.AppendLine("- Please enter username.")
            ctr = If(ctr, txtUsername)
        End If

        If txtPassword.Text = "" Then
            err.AppendLine("- Please enter password.")
            ctr = If(ctr, txtPassword)
        End If
        'display error message
        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr.Focus()
            Return
        End If
        'check if exist
        Dim query = From m In member
                    Where m.Username = txtUsername.Text
                    Select m
        'if exist
        If query.Count > 0 Then
            For Each m In query
                'correct password
                If m.Password = txtPassword.Text Then
                    LoginSession.memberID = m.MemberID
                    LoginSession.username = m.Username
                    LoginSession.email = m.Email
                    LoginSession.signInTime = DateTime.Now

                    'convert to image 
                    Dim img As Image
                    Dim imgByte As Byte() = Nothing
                    Dim stream As MemoryStream
                    If m.Picture IsNot Nothing Then
                        imgByte = CType(m.Picture.ToArray, Byte())
                        stream = New MemoryStream(imgByte, 0, imgByte.Length)
                        img = Image.FromStream(stream)
                    Else
                        img = My.Resources.user_default
                    End If
                    LoginSession.picture = img
                    LoginSession.nickname = m.Nickname
                    LoginSession.email = m.Email

                    MessageBox.Show("Login Success.", "Congratulation")
                    MainForm.Show()
                    Me.Close()
                Else
                    'incorrect password
                    MessageBox.Show("Incorrect username or password.", "Sorry")
                End If
            Next
        Else
            'username not exist
            MessageBox.Show("Username not exist.", "Sorry")
        End If
    End Sub

    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        ForgotPassword.ShowDialog()
    End Sub

End Class