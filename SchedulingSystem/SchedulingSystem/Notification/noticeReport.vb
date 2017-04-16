Imports System.Text
Imports System.Data.Linq

Public Class noticeReport
    Dim userId As Integer = LoginSession.memberID

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
                    lstNotice.Items.Add("Appointment" & vbTab & appointmentQuery.Count & vbTab & appointmentQuery2.Count & vbTab & appointmentQuery1.Count)
                Else
                    lstNotice.Items.Add("Appointment" & vbTab & appointmentQuery.Count & vbTab & "N/A" & vbTab & appointmentQuery1.Count)
                End If
            Else
                lstNotice.Items.Add("Appointment" & vbTab & appointmentQuery.Count & vbTab & appointmentQuery2.Count & vbTab & "N/A")
            End If
        Else
            lstNotice.Items.Add("Appointment" & vbTab & "N/A" & vbTab & "N/A" & vbTab & "N/A")
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
                    lstNotice.Items.Add("Appointment" & vbTab & friendQuery.Count & vbTab & friendQuery1.Count & vbTab & friendQuery2.Count)
                Else
                    lstNotice.Items.Add("Appointment" & vbTab & friendQuery.Count & vbTab & "N/A" & vbTab & friendQuery2.Count)
                End If
            Else
                lstNotice.Items.Add("Appointment" & vbTab & friendQuery.Count & vbTab & friendQuery1.Count & vbTab & "N/A")
            End If
        Else
            lstNotice.Items.Add("Appointment" & vbTab & "N/A" & vbTab & "N/A" & vbTab & "N/A")
        End If
    End Sub
End Class
