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
                    lstNotice.Items.Add(String.Format("{0, 15}  {1, 20}  {2,30}  {3,30}", "Appointment", appointmentQuery.Count, appointmentQuery2.Count, appointmentQuery1.Count))
                Else
                    lstNotice.Items.Add(String.Format("{0, 15}  {1, 20}  {2,30}  {3,30}", "Appointment", appointmentQuery.Count, "N/A", appointmentQuery1.Count))
                End If
            Else
                lstNotice.Items.Add(String.Format("{0, 15}  {1, 20}  {2,30}  {3,30}", "Appointment", appointmentQuery.Count, appointmentQuery2.Count, "N/A"))
            End If
        Else
            lstNotice.Items.Add(String.Format("{0, 15}  {1, 20}  {2,30}  {3,30}", "Appointment", "N/A", "N/A", "N/A"))
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
                    lstFriend.Items.Add(String.Format("{0, 15}  {1, 25}  {2,25}  {3,25}", "Friend", friendQuery.Count, friendQuery1.Count, friendQuery2.Count))
                Else
                    lstFriend.Items.Add(String.Format("{0, 15}  {1, 25}  {2,25}  {3,25}", "Friend", friendQuery.Count, "N/A", friendQuery2.Count))
                End If
            Else
                lstFriend.Items.Add(String.Format("{0, 15}  {1, 25}  {2,25}  {3,25}", "Friend", friendQuery.Count, friendQuery1.Count, "N/A"))
            End If
        Else
            lstFriend.Items.Add(String.Format("{0, 15}  {1, 25}  {2,25}  {3,25}", "Friend", "N/A", "N/A", "N/A"))
        End If
    End Sub


End Class
