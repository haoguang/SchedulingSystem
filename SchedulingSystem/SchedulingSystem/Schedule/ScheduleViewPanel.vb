Public Class ScheduleViewPanel
    Friend scheduleTimeId As Integer
    Friend prevCtrl As New Stack(Of UserControl)
    Private schedule As ScheduleClass

    Private Sub ScheduleViewPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Text = "Schedule Detail"

        schedule = getSchedule()

        Dim viewContent As New ScheduleDetailView
        viewContent.schedule = schedule
        viewContent.parentCtrl = Me
        Me.DetailViewPanel.Controls.Clear()
        Me.DetailViewPanel.Controls.Add(viewContent)

    End Sub

    Private Function getSchedule() As ScheduleClass

        Dim db As New ScheduleDBDataContext

        Dim rs = From s In db.Schedules, st In db.ScheduleTimes
                 Where st.ScheduleTimeId = scheduleTimeId And
                     s.ScheduleID = st.ScheduleID
        Dim tempSchedule As New ScheduleClass(rs.FirstOrDefault.s.ScheduleID, CDate(rs.FirstOrDefault.st.ScheduleStart), CDate(rs.FirstOrDefault.st.ScheduleEnd),
                                              CDate(rs.FirstOrDefault.s.RepeatDue), rs.FirstOrDefault.s.RepeatBehavior.ToArray.First(), rs.FirstOrDefault.s.Title,
                                              rs.FirstOrDefault.s.Description, rs.FirstOrDefault.s.Venue, rs.FirstOrDefault.s.Type, rs.FirstOrDefault.s.Status)
        Return tempSchedule

    End Function

    Private Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBack.MouseEnter, btnBack.MouseUp
        btnBack.Image = My.Resources.arrow_105_hover
    End Sub

    Private Sub btnBack_MouseDown(sender As Object, e As MouseEventArgs) Handles btnBack.MouseDown
        btnBack.Image = My.Resources.arrow_105_pressed
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        btnBack.Image = My.Resources.arrow_105_24
    End Sub

    Friend Sub btnBack_MouseClick(sender As Object, e As MouseEventArgs) Handles btnBack.MouseClick

        If prevCtrl.Peek.GetType.ToString.Equals("SchedulingSystem.DayScheduleViewer") Then
            My.Forms.MainForm.ContentPanel.Controls.Clear()
            prevCtrl.Pop()
            Dim dayviewer As New DayScheduleViewer
            dayviewer.displayDate = schedule.ScheduleStart.Date
            My.Forms.MainForm.ContentPanel.Controls.Add(dayviewer)
        Else
            Me.DetailViewPanel.Controls.Clear()
            Me.DetailViewPanel.Controls.Add(prevCtrl.Pop)
        End If

    End Sub
End Class
