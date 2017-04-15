Imports System.Data.Linq
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
        Try
            Dim mail = New MailMessage()
            mail.From = New MailAddress("testingprogram80@gmail.com")
            Dim smtp = New SmtpClient()

            Dim db As New ScheduleDBDataContext
            Dim member As Table(Of Member) = db.GetTable(Of Member)()

            Dim query = From m In member
                        Where m.Username = txtUsername.Text
                        Select m


            If query.Count > 0 Then
                For Each m In query
                    '25 if use phone data
                    '587 if use wifi
                    smtp.Port = 587
                    smtp.EnableSsl = True
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network
                    smtp.UseDefaultCredentials = False
                    smtp.Credentials = New NetworkCredential(mail.From.Address, "123456789abc")
                    smtp.Host = "smtp.gmail.com"

                    mail.To.Add(m.Email)
                    mail.IsBodyHtml = True
                    Dim st As New StringBuilder
                    st.AppendLine("Your password is: " + m.Password)

                    mail.Body = st.ToString()
                    smtp.Send(mail)
                    MsgBox("Your password has been sent to your email.")
                Next
            Else
                MessageBox.Show("Username not exist", "Error")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class