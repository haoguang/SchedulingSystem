Imports System.Text
Public Class AppointmentReport
    Private appClass As Appointment
    Private Sub AppointmentReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i As Integer = 2017 To 2020
            ddlYear.Items.Add(i.ToString())
        Next

        For i As Integer = 1 To 12
            ddlMonth.Items.Add(i.ToString())
        Next
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If Me.ValidateChildren() = False Then
            Return
        End If

        Dim userid As Integer = LoginSession.memberID
        Dim db As New ScheduleDBDataContext()
        Dim month As Integer
        month = Convert.ToInt32(ddlMonth.Text)

        Dim year As Integer
        year = Convert.ToInt32(ddlYear.Text)
        Dim record = From p In db.Participles, s In db.Schedules, st In db.ScheduleTimes
                     Where p.MemberID = userid And s.Type = "Appointment" And s.Status = "Active" And st.ScheduleStart.Value.Month = month And st.ScheduleStart.Value.Year = year And s.ScheduleID = p.ScheduleID And st.ScheduleID = s.ScheduleID
                     Select New With {
                         .Date = Format(st.ScheduleStart, "dd/MM/yyyy"),
                         .StartTime = Format(st.ScheduleStart, "h: mm tt"),
                         .EndTime = Format(st.ScheduleEnd, "h: mm tt"),
                         s.Title
                     }



        For Each item In record
            lstRecord.Items.Add(item.Date & vbTab & item.StartTime & vbTab & item.EndTime & vbTab & item.Title)
        Next


        dlgPreview.Document = doc
        dlgPreview.ShowDialog(Me)
        lstRecord.Items.Clear()

    End Sub

    Private Sub ddlMonth_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ddlMonth.Validating
        If ddlMonth.SelectedIndex = -1 Then
            err.SetError(ddlMonth, "Please select a month.")
            e.Cancel = True
        Else
            err.SetError(ddlMonth, Nothing)
        End If
    End Sub

    Private Sub ddlYear_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ddlYear.Validating
        If ddlYear.SelectedIndex = -1 Then
            err.SetError(ddlYear, "Please select a year.")
            e.Cancel = True
        Else
            err.SetError(ddlYear, Nothing)
        End If
    End Sub

    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
        Dim month1 As String
        If ddlMonth.Text = "1" Then
            month1 = "January"
        ElseIf ddlMonth.Text = "2" Then
            month1 = "February"
        ElseIf ddlMonth.Text = "3" Then
            month1 = "March"
        ElseIf ddlMonth.Text = "4" Then
            month1 = "April"
        ElseIf ddlMonth.Text = "5" Then
            month1 = "May"
        ElseIf ddlMonth.Text = "6" Then
            month1 = "June"
        ElseIf ddlMonth.Text = "7" Then
            month1 = "July"
        ElseIf ddlMonth.Text = "8" Then
            month1 = "August"
        ElseIf ddlMonth.Text = "9" Then
            month1 = "September"
        ElseIf ddlMonth.Text = "10" Then
            month1 = "October"
        ElseIf ddlMonth.Text = "11" Then
            month1 = "November"
        ElseIf ddlMonth.Text = "12" Then
            month1 = "December"
        End If


        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 14)
        Dim fontBody As New Font("Consolas", 10)


        Dim header As String = "  Monthly Appointment Report"
        Dim subHeader As String = String.Format(
            "    Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
            "    " & month1 & " Report", DateTime.Now)

        Dim body As New StringBuilder()

        body.AppendLine("No  Date        Start Time End Time    Title")
        body.AppendLine("--  ----------  ---------- ----------  ----------------")

        Dim cnt As Integer = 0
        Dim parts() As String
        For Each item In lstRecord.Items
            cnt += 1
            parts = CStr(item).Split(CChar(vbTab))
            body.AppendFormat("{0,2}  {1,10}  {2,10} {3,10}  {4, -30}" & vbNewLine, cnt, parts(0), parts(1), parts(2), parts(3))
        Next

        body.AppendLine()
        body.AppendFormat("{0,2} appointment record(s)", cnt)

        With e.Graphics
            .DrawImage(My.Resources.logo, 0, 0, 80, 100)
            .DrawString(header, fontHeader, Brushes.Purple, 98, 0)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 100, 40)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 0, 120)
        End With
    End Sub
End Class
