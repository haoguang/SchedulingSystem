Public Class DayScheduleViewer
    Dim arrTimeLabel(24) As Label
    Dim activityDisplayer As New ActivityControl


    Private Sub HandleActivityControlClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim activity As ActivityControl = DirectCast(sender, ActivityControl)

        Console.WriteLine(activity.lblScheduleID.Text)

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

    Private Sub DayScheduleViewer_Load(sender As Object, e As EventArgs) Handles Me.Load
        populateTimeToPanel() 'Populate Time to time display panel
        populateSchedule()    'Populate schedule to time line
    End Sub

    Private Sub populateTimeToPanel()
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
    End Sub

    Private Sub populateSchedule()
        Dim db As New ScheduleDBDataContext()
        Dim rs = From s In db.Schedules, st In db.ScheduleTimes
                 Where s.ScheduleID = st.ScheduleID And st.ScheduleStart >= New DateTime(2017, 4, 9) And st.ScheduleStart <= New DateTime(2017, 4, 10)

        Dim activities(rs.Count) As ActivityControl

        Dim ScheduleID As Integer
        Dim ScheduleTitle As String
        Dim ScheduleVenue As String
        Dim ScheduleStart As DateTime
        Dim ScheduleEnd As DateTime
        Dim x As Integer = 0

        For Each item In rs
            ScheduleID = item.s.ScheduleID
            ScheduleTitle = item.s.Title
            ScheduleVenue = item.s.Venue
            ScheduleStart = CDate(item.st.ScheduleStart)
            ScheduleEnd = CDate(item.st.ScheduleEnd)

            activities(x) = New ActivityControl

            With activities(x)
                .Location = New System.Drawing.Point(0, CInt(ActivityModule.calActivityPosition(ScheduleStart)))
                .Height = CInt(ActivityModule.calActivityHeight(ScheduleStart, ScheduleEnd))
                .lblStartTime.Text = ScheduleStart.ToShortTimeString
                .lblTitle.Text = ScheduleTitle
                .lblVenue.Text = ScheduleVenue
                .lblScheduleID.Text = ScheduleID.ToString
                .Anchor = AnchorStyles.Left Or AnchorStyles.Right
                .BackColor = Color.GreenYellow
            End With
            AddHandler activities(x).Click, AddressOf HandleActivityControlClick
            activityDisplayPanel.Controls.Add(activities(x))
            x += 1
        Next



        'for testing purpose only (need to delete)
        Dim startTime As DateTime = New DateTime(DateTime.Parse("2017-4-1 00:00").ToBinary)
        Dim endTime As DateTime = New DateTime(DateTime.Parse("2017-4-1 02:00").ToBinary)


        With activityDisplayer
            .Location = New System.Drawing.Point(0, CInt(ActivityModule.calActivityPosition(startTime)))
            .Height = CInt(ActivityModule.calActivityHeight(startTime, endTime))
            .lblStartTime.Text = startTime.ToShortTimeString
            .lblTitle.Text = "I am a title"
            .lblVenue.Text = "I am a place"
            .Anchor = AnchorStyles.Left Or AnchorStyles.Right
            .BackColor = Color.GreenYellow
        End With

        activityDisplayPanel.Controls.Add(activityDisplayer)
        '(delete till here)
    End Sub
End Class
