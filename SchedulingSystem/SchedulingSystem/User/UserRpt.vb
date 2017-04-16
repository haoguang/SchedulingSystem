Imports System.Data.Linq
Imports System.Text

Public Class UserRpt
    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)

        Dim header As String = "Login Report"
        Dim subHeader As String = String.Format(
            "Printed on {0:yyyy-MMMM-dd hh:mm:ss tt}" & vbNewLine, DateTime.Now
            )

        Dim body As New StringBuilder()
        body.AppendLine("No        Sign In Date            Sign Out Date")
        body.AppendLine("--    ---------------------  ---------------------")

        Dim parts() As String
        Dim count As Integer
        For Each item In lstLoginRecord.Items
            count += 1
            parts = CStr(item).Split(CChar(vbTab))
            body.AppendFormat("{0,2}  {1,23}  {2,-25}" & vbNewLine, parts(0), parts(1), parts(2))
        Next
        body.AppendLine()
        body.AppendFormat("{0,2} record(s)", count)

        With e.Graphics
            .DrawImage(LoginSession.picture, 0, 0, 80, 100)
            .DrawString(header, fontHeader, Brushes.Purple, 100, 0)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 100, 40)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 0, 120)
        End With
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        dlgPreview.Document = doc
        dlgPreview.ShowDialog(Me)
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        lstLoginRecord.Items.Clear()
        lblRecord.Text = ""

        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        'validation
        If cboMonth.SelectedIndex = -1 Then
            err.AppendLine("- Please select month.")
            ctr = If(ctr, cboMonth)
        End If

        If cboYear.SelectedIndex = -1 Then
            err.AppendLine("- Please select year.")
            ctr = If(ctr, cboYear)
        End If

        'show error message
        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr.Focus()
            Return
        End If

        Dim month As String = cboMonth.SelectedItem.ToString
        Dim year As String = cboYear.SelectedItem.ToString

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

        Dim db As New ScheduleDBDataContext()
        Dim login As Table(Of LoginRecord) = db.GetTable(Of LoginRecord)()
        'get login details
        Dim query = From l In login
                    Where l.UserId = LoginSession.memberID And CDate(l.SignInTime).Month = mth And CDate(l.SignInTime).Year = yr
                    Select l

        Dim cnt As Integer = 0
        'if exist
        If query.Count > 0 Then
            For Each l In query
                cnt += 1
                lstLoginRecord.Items.Add(cnt & vbTab & l.SignInTime & vbTab & l.SignOutTime)
            Next
        End If
        lblRecord.Text = cnt & " record(s)."
    End Sub

End Class
