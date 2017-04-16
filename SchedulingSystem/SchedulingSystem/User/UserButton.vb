Public Class UserButton

    Friend Event btnMenuEvent() 'for event handling

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        RaiseEvent btnMenuEvent() ' used for handle event from parent class
    End Sub

    Private Sub btnMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles btnMenu.MouseDown
        btnMenu.Image = My.Resources.arrow_213_pressed
    End Sub

    Private Sub btnMenu_MouseEnterAndMouseUp(sender As Object, e As EventArgs) Handles btnMenu.MouseEnter, btnMenu.MouseUp
        btnMenu.Image = My.Resources.arrow_213_hover
    End Sub

    Private Sub btnMenu_MouseLeave(sender As Object, e As EventArgs) Handles btnMenu.MouseLeave
        btnMenu.Image = My.Resources.arrow_213_16
    End Sub

End Class
