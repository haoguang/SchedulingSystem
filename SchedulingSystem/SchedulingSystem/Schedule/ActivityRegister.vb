Public Class ActivityRegister
    Private Sub ActivityRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        settingdgvColumn()
    End Sub

    Private Sub btnAddParti_MouseEnterAndUp(sender As Object, e As EventArgs) Handles btnAddParti.MouseEnter, btnAddParti.MouseUp
        btnAddParti.Image = My.Resources.add_user_hover
    End Sub

    Private Sub btnNext_MouseDown(sender As Object, e As MouseEventArgs) Handles btnAddParti.MouseDown
        btnAddParti.Image = My.Resources.add_user_pressed
    End Sub

    Private Sub btnAddParti_MouseLeave(sender As Object, e As EventArgs) Handles btnAddParti.MouseLeave
        btnAddParti.Image = My.Resources.add_user_32
    End Sub

    Private Sub settingdgvColumn()
        Dim dgvWidth As Double = dgvParticiples.Width

        dgvParticiples.Columns(1).Width = CInt(Math.Floor(dgvWidth * 0.89))
        dgvParticiples.Columns(2).Width = CInt(Math.Ceiling(dgvWidth * 0.1))
    End Sub

    Private Sub btnAddParti_Click(sender As Object, e As EventArgs) Handles btnAddParti.Click
        'add friend to row
    End Sub
End Class
