Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim UserCtrl1 As New TestUserControl1
        Panel1.Controls.Clear()
        Panel1.Controls.Add(UserCtrl1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim UserCtrl2 As New SecondUserControl
        Panel1.Controls.Clear()
        Panel1.Controls.Add(UserCtrl2)
    End Sub
End Class
