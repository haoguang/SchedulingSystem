Public Class DayScheduleViewer
    Dim arrTimeLabel(24) As Label
    Dim activityDisplayer As New ActivityControl

    Private Sub timeDisplayPanel_Paint(sender As Object, e As PaintEventArgs) Handles timeDisplayPanel.Paint

        'assign label to all array
        For i As Integer = 0 To 24
            arrTimeLabel(i) = New Label()
        Next i

        'assign all label with their specific property
        Dim timeValue As Integer = 0
        Dim heightValue As Integer = 0
        For Each lblTime As Label In arrTimeLabel
            With lblTime
                .Text = String.Format("{0:00:00}", timeValue Mod 2400)
                .AutoSize = True
                .Location = New System.Drawing.Point(20, heightValue)
            End With
            timeDisplayPanel.Controls.Add(lblTime)
            timeValue += 100
            heightValue += 50
        Next

        Dim startTime As DateTime = New DateTime(DateTime.Parse("2017-4-1 3:00").ToBinary)
        Dim endTime As DateTime = New DateTime(DateTime.Parse("2017-4-1 5:30").ToBinary)


        With activityDisplayer
            .Location = New System.Drawing.Point(0, ActivityModule.calActivityPosition(startTime))
            .Height = ActivityModule.calActivityHeight(startTime, endTime)
            .lblStartTime.Text = startTime.ToShortTimeString
            .lblTitle.Text = "I am a title"
            .lblVenue.Text = "I am a place"
            .Anchor = AnchorStyles.Left Or AnchorStyles.Right
            .BackColor = Color.GreenYellow
        End With

        activityDisplayPanel.Controls.Add(activityDisplayer)


    End Sub



    Private Sub btnPrev_MouseEnterAndUp(sender As Object, e As EventArgs) Handles btnPrev.MouseEnter, btnPrev.MouseUp
        btnPrev.Image = My.Resources.arrow_105_hover
    End Sub

    Private Sub btnPrev_MouseLeave(sender As Object, e As EventArgs) Handles btnPrev.MouseLeave
        btnPrev.Image = My.Resources.arrow_105_24
    End Sub

    Private Sub btnPrev_MouseDown(sender As Object, e As MouseEventArgs) Handles btnPrev.MouseDown
        btnPrev.Image = My.Resources.arrow_105_pressed
    End Sub

    Private Sub btnNext_MouseEnterAndUp(sender As Object, e As EventArgs) Handles btnNext.MouseEnter, btnNext.MouseUp
        btnNext.Image = My.Resources.arrow_4_hover
    End Sub

    Private Sub btnNext_MouseDown(sender As Object, e As MouseEventArgs) Handles btnNext.MouseDown
        btnNext.Image = My.Resources.arrow_4_pressed
    End Sub

    Private Sub btnNext_MouseLeave(sender As Object, e As EventArgs) Handles btnNext.MouseLeave
        btnNext.Image = My.Resources.arrow_4_24
    End Sub
End Class
