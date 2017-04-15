Imports System.Data.Linq
Imports System.Net
Imports System.Net.Mail
Imports System.Text

Public Class ForgotPassword
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        'validation
        If txtUsername.Text = "" Then
            err.AppendLine("- Please enter username.")
            ctr = If(ctr, txtUsername)
        End If

        If cboQuestion.SelectedIndex = -1 Then
            err.AppendLine("- Please select security question.")
            ctr = If(ctr, cboQuestion)
        End If

        If txtAnswer.Text = "" Then
            err.AppendLine("- Please enter security answer.")
            ctr = If(ctr, txtAnswer)
        End If

        'show error message
        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr.Focus()
            Return
        End If

        'database
        Dim db As New ScheduleDBDataContext()
        Dim member As Table(Of Member) = db.GetTable(Of Member)()

        'check username
        Dim query = From m In member
                    Where m.Username = txtUsername.Text
                    Select m
        'if exist
        If query.Count > 0 Then
            For Each m In query
                If m.SecurityQuestion = cboQuestion.SelectedItem.ToString() AndAlso m.SecurityAnswer.ToLower() = txtAnswer.Text.ToLower() Then
                    Try
                        Dim mail = New MailMessage()
                        mail.From = New MailAddress("testingprogram80@gmail.com")
                        Dim smtp = New SmtpClient()

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
                        Me.Close()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                Else
                    MessageBox.Show("Usename, security question and answer mismatch.", "Error")
                End If
            Next
        Else
        MessageBox.Show("Username does not exist.")
        End If

    End Sub

    Private Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = ""
        txtAnswer.Text = ""
        cboQuestion.SelectedIndex = -1
    End Sub
End Class