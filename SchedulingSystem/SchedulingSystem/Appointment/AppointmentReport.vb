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
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)

        Dim header As String = "Appointment Report"
        Dim subHeader As String = String.Format(
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
            "Monthly Summary Report", DateTime.Now)

        Dim body As New StringBuilder()

        body.AppendLine("No  Date        Start Time End Time  Title")
        body.AppendLine("--  ----------  ---------- --------  ---------")

        Dim cnt As Integer = 0
        Dim parts() As String
        For Each item In lstRecord.Items
            cnt += 1
            parts = CStr(item).Split(CChar(vbTab))
            body.AppendFormat("{0,2}  {1,10}  {2,9} {3,9} {4, 4}" & vbNewLine, cnt, parts(0), parts(1), parts(2), parts(3))
        Next

        body.AppendLine()
        body.AppendFormat("{0,2} record(s)", cnt)

        With e.Graphics
            .DrawImage(My.Resources.Appointment, 0, 0, 80, 100)
            .DrawString(header, fontHeader, Brushes.Purple, 98, 0)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 100, 40)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 0, 120)
        End With
    End Sub
End Class
