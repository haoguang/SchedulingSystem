Imports System.Text
Imports System.Data.Linq

Public Class noticeReport
    Dim userId As Integer = LoginSession.memberID

    Private Sub noticeReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentDateTime As DateTime
        currentDateTime = DateTime.Now
        Dim year As Integer = CDate(currentDateTime).Year

        For index = 0 To 2
            cboYear.Items.Add(year - index)
        Next index
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'clear listbox
        lstNotice.Items.Clear()
        lstFriend.Items.Clear()

        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        'validatw combobox selection
        If cboMonth.SelectedIndex = -1 Then
            err.AppendLine("- Please select month")
            ctr = If(ctr, cboMonth)
        End If

        If cboYear.SelectedIndex = -1 Then
            err.AppendLine("- Please select year")
            ctr = If(ctr, cboYear)
        End If

        'show error message
        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr.Focus()
            Return
        End If

        'get month and year
        Dim month As String = cboMonth.SelectedItem.ToString
        Dim year As String = cboYear.SelectedItem.ToString

        'get month
        Select Case month
            Case "January"
                month = "1"
            Case "February"
                month = "2"
            Case "March"
                month = "3"
            Case "April"
                month = "4"
            Case "May"
                month = "5"
            Case "June"
                month = "6"
            Case "July"
                month = "7"
            Case "August"
                month = "8"
            Case "September"
                month = "9"
            Case "October"
                month = "10"
            Case "November"
                month = "11"
            Case "December"
                month = "12"
        End Select


        Dim mth As Integer = Integer.Parse(month)
        Dim yr As Integer = Integer.Parse(year)

        'database
        Dim db As New ScheduleDBDataContext()

        'get appoinment details
        Dim appointmentQuery = From p In db.Participles
                               Where p.MemberID = userId And CDate(p.GenerateDate).Month = mth And CDate(p.GenerateDate).Year = yr
                               Select p.ParticiplesRole

        Dim appointmentQuery1 = From p In db.Participles
                                Where p.MemberID = userId And p.Status = "Decline" And CDate(p.GenerateDate).Month = mth And CDate(p.GenerateDate).Year = yr
                                Select p.ParticiplesRole

        Dim appointmentQuery2 = From p In db.Participles
                                Where p.MemberID = userId And p.Status = "Attend" And CDate(p.GenerateDate).Month = mth And CDate(p.GenerateDate).Year = yr
                                Select p.ParticiplesRole


        'if exist
        If appointmentQuery.Count > 0 Then
            If appointmentQuery1.Count > 0 Then 'decline 
                If appointmentQuery2.Count > 0 Then 'attend
                    lstNotice.Items.Add(String.Format("{0, 15}  {1, 15}  {2,15}  {3,14}", "Appointment" & vbTab, appointmentQuery.Count & vbTab, appointmentQuery2.Count & vbTab, appointmentQuery1.Count))
                Else
                    lstNotice.Items.Add(String.Format("{0, 15}  {1, 15}  {2,15}  {3,14}", "Appointment" & vbTab, appointmentQuery.Count & vbTab, "0" & vbTab, appointmentQuery1.Count))
                End If
            Else
                lstNotice.Items.Add(String.Format("{0, 15}  {1, 15}  {2,15}  {3,14}", "Appointment" & vbTab, appointmentQuery.Count & vbTab, appointmentQuery2.Count & vbTab, "0"))
            End If
        Else
            lstNotice.Items.Add(String.Format("{0, 15}  {1, 15}  {2,14}  {3,13}", "Appointment" & vbTab, "N/A" & vbTab, "N/A" & vbTab, "N/A"))
        End If


        'get friend details
        Dim friendQuery = From f In db.Friends
                          Where f.FriendID = userId And CDate(f.MeetDate).Month = mth And CDate(f.MeetDate).Year = yr
                          Select f.UserID

        Dim friendQuery1 = From f In db.Friends
                           Where f.FriendID = userId And f.Status = "Friend" And CDate(f.MeetDate).Month = mth And CDate(f.MeetDate).Year = yr
                           Select f.UserID

        Dim friendQuery2 = From f In db.Friends
                           Where f.FriendID = userId And f.Status = "CloseFriend" And CDate(f.MeetDate).Month = mth And CDate(f.MeetDate).Year = yr
                           Select f.UserID


        'if exist
        If friendQuery.Count > 0 Then
            If friendQuery1.Count > 0 Then 'Friend
                If friendQuery2.Count > 0 Then 'CloseFriend
                    lstFriend.Items.Add(String.Format("{0, 15}  {1, 15}  {2,15}  {3,14}", "Friend" & vbTab, friendQuery.Count & vbTab, friendQuery1.Count & vbTab, friendQuery2.Count))
                Else
                    lstFriend.Items.Add(String.Format("{0, 15}  {1, 15}  {2,15}  {3,14}", "Friend" & vbTab, friendQuery.Count & vbTab, "0" & vbTab, friendQuery2.Count))
                End If
            Else
                lstFriend.Items.Add(String.Format("{0, 15}  {1, 15}  {2,15}  {3,14}", "Friend" & vbTab, friendQuery.Count & vbTab, friendQuery1.Count & vbTab, "0"))
            End If
        Else
            lstFriend.Items.Add(String.Format("{0, 15}  {1, 15}  {2,14}  {3,13}", "Friend" & vbTab, "N/A" & vbTab, "N/A" & vbTab, "N/A"))
        End If
    End Sub

    Private Sub docNotice_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles docNotice.PrintPage
        'print report
        'font
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 12)
        'header
        Dim header As String = "Notification Report"
        Dim subHeader As String = String.Format(
            "Printed on {0:yyyy-MMMM-dd hh:mm:ss tt}" & vbNewLine &
            "Printed by {1}", DateTime.Now, LoginSession.nickname
            )
        'body
        Dim body As New StringBuilder()
        Dim bodyInput As New StringBuilder()
        Dim bodyInput2 As New StringBuilder()
        body.AppendLine()
        body.AppendLine()
        body.AppendLine()
        body.AppendLine()
        body.AppendLine("   Type                      Receive           Accepted           Rejected")
        body.AppendLine("   --------------            --------          ---------          ---------")
        body.AppendLine()
        body.AppendLine()

        Dim parts() As String
        Dim count As Integer
        'bodyInput.AppendLine()
        bodyInput.AppendLine()
        For Each item In lstNotice.Items
            count += 1
            parts = CStr(item).Split(CChar(vbTab))
            bodyInput.AppendFormat("{0,-8}  {1,-2}  {2,-2}  {3,-2}" & vbNewLine, parts(0), parts(1), parts(2), parts(3))
        Next
        body.AppendLine()
        body.AppendLine("   Type                      Receive           Friend            CloseFriend")
        body.AppendLine("   --------------            --------          ---------         -----------")
        bodyInput2.AppendLine()
        bodyInput2.AppendLine()
        ' bodyInput2.AppendLine()

        For Each item In lstFriend.Items
            count += 1
            parts = CStr(item).Split(CChar(vbTab))
            bodyInput2.AppendFormat("{0,-17}  {1,-2}  {2,-2}  {3,-2}" & vbNewLine, parts(0), parts(1), parts(2), parts(3))
        Next

        With e.Graphics
            .DrawImage(My.Resources.logo, 80, 50, 150, 130)  'change 1st 2 digit to set image position 
            .DrawString(header, fontHeader, Brushes.Purple, 250, 50) 'change last 2 digit to set text alignment
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 250, 90)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 50, 170)
            .DrawString(bodyInput.ToString(), fontBody, Brushes.Black, 48, 260)
            .DrawString(bodyInput2.ToString(), fontBody, Brushes.Black, 5, 340)
        End With
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        dlgNoticePreview.Document = docNotice
        dlgNoticePreview.ShowDialog(Me)
    End Sub
End Class
