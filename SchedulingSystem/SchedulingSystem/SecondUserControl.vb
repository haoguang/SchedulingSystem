Public Class SecondUserControl
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim formDialog As New CreateAppointment()
        formDialog.ShowDialog()

    End Sub
End Class
