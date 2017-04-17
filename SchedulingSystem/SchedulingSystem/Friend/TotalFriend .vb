

Imports System.Text

Public Class TotalFriend

    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)


        Dim header As String = "Friend Listing"
        Dim subHeader As String = String.Format(
        "Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine & "Printed by {1,2}", DateTime.Now, LoginSession.username)

        Dim body As New StringBuilder()

        body.AppendLine("Status                  No of Friend")
        body.AppendLine("-------------           ------------")
        body.AppendLine()
        Dim cnt As Integer
        Dim db As New ScheduleDBDataContext
        Dim fl = From f In db.Friends
                 Where
                 CLng(f.UserID) = LoginSession.memberID
                 Group f By f.Status Into g = Group
                 Select
                    Status,
                    NoOfUser = CType(g.Count(Function(p) p.Status <> Nothing), Int64?)

        For Each i In fl
            body.AppendLine()
            body.AppendFormat("{0,-12} {1,16}" & vbNewLine, i.Status, i.NoOfUser)
            cnt = CInt(cnt + i.NoOfUser)
        Next
        body.AppendLine()
        body.AppendLine()
        body.AppendFormat("Total Number of record(s) = {0,2} ", cnt)
        With e.Graphics
            .DrawString(header, fontHeader, Brushes.Purple, 100, 0)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 100, 40)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 100, 120)
        End With
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        dlgPreview.Document = doc
        dlgPreview.ShowDialog(Me)
    End Sub
End Class
