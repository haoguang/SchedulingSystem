Imports System.Text
Public Class CreateAppointment
    Public Property StringUsername As String

    Private Sub CreateAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTo.Text = "To : " & StringUsername

        scheStart.MinDate = DateTime.Now.AddHours(2)
        scheEnd.MinDate = scheStart.Value
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim title As String, description As String, venue As String
        Dim err As New StringBuilder
        Dim ctr As Control = Nothing

        title = txtTitle.Text
        description = txtBoxDescription.Text
        venue = txtVenue.Text

        If title = "" Then
            err.AppendLine("- Please enter title.")
            ctr = If(ctr, txtTitle)
        End If
        If description = "" Then
            err.AppendLine("- Please enter description.")
            ctr = If(ctr, txtBoxDescription)
        End If
        If venue = "" Then
            err.AppendLine("- Please enter venue")
            ctr = If(ctr, txtVenue)
        End If
        If (err.Length > 0) Then
            MessageBox.Show(err.ToString, "Input Error")
            ctr.Focus()
            Return
        End If

        AddSchedule()


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    Private Function GetMemberID(username As String) As Integer
        Dim db As New ScheduleDBDataContext()
        Dim id As Integer
        Dim record = From m In db.Members
                     Where m.Username = StringUsername
                     Select New With {
                         m.MemberID
                         }
        id = record.FirstOrDefault.MemberID
        Return id
    End Function

    Private Sub AddSchedule()
        Dim s As New Schedule()
        s.RepeatDue = Nothing
        s.RepeatBehavior = Nothing
        s.Title = txtTitle.Text
        s.Description = txtBoxDescription.Text
        s.Venue = txtVenue.Text
        s.Type = "Appointment"
        s.Status = "Pending"

        Dim db As New ScheduleDBDataContext()
        db.Schedules.InsertOnSubmit(s)
        db.SubmitChanges()
    End Sub

    Private Sub AddScheduleTime()
        Dim st As New ScheduleTime
        'st.ScheduleID =
        'st.ScheduleStart = scheStart.Value
        st.ScheduleEnd = scheEnd.Value
        st.InitialTime = Nothing
    End Sub
End Class