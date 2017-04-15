

Imports System.Text

Public Class Monthly_Friend_Changes_Report

    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)


        Dim header As String = "Friend Listing"
        Dim subHeader As String = String.Format(
        "Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine & "Printed by ", DateTime.Now, LoginSession.username)

        Dim body As New StringBuilder()

        body.AppendLine("Username   ID     Status")
        body.AppendLine("--------   ---    ------")
        body.AppendLine()
        Dim cnt As Integer
        Dim db As New ScheduleDBDataContext

        Dim fl = From f In db.Friends
                 Where
                 CLng(f.UserID) = 100006
                 Group f By f.Status Into g = Group
                 Select
                    Status,
                    NoOfUser = CType(g.Count(Function(p) p.Status <> Nothing), Int64?)
        cnt += 1
        For Each i In fl
            body.AppendLine()
            body.AppendLine()
            body.AppendFormat("{0,0} {1,2}" & vbNewLine, i.Status, i.NoOfUser)
        Next
        body.AppendLine()
        body.AppendFormat("{0,2} record(s)", cnt)
        With e.Graphics
            .DrawString(header, fontHeader, Brushes.Purple, 100, 0)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 100, 40)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 0, 120)
        End With
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        dlgPreview.Document = doc
        dlgPreview.ShowDialog(Me)
    End Sub
End Class