

Public Class Monthly_Friend_Changes_Report
    Dim array_list As New List(Of [Friend])

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDocument1.Print()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim db As New ScheduleDBDataContext


        Dim rs = From o In db.Friends, m In db.Members
                 Where o.UserID = 100001 And o.FriendID = m.MemberID And o.Status = "Colleague"
        Dim tempFriend As New [Friend]
        For Each i In rs
            tempFriend = New [Friend]
            With tempFriend
                .FriendID = i.m.MemberID
                .Status = i.o.Status
            End With
            Console.WriteLine(tempFriend.FriendID & " " & tempFriend.Status)
        Next

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

    End Sub
End Class