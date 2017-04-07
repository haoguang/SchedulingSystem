Public Class ViewAppointment
    Private Sub ViewAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim db As New ScheduleDBDataContext()
        Dim memberId As String = "100001"


        Dim record = From p In db.Participles, s In db.Schedules, st In db.ScheduleTimes
                     Where p.MemberID = memberId
        'Dim record = From o In db.Participles
        '             Join o1 In db.Schedules On o.ScheduleID Equals o1.ScheduleID
        '             Join o2 In db.ScheduleTimes On o1.ScheduleID Equals o2.ScheduleID
        '             Where o.MemberID = memberId And o2.ScheduleStart = "30/03/2017" And o1.Type = "Appointment"
        '             Select New With {
        '              o1.ScheduleID,
        '              o2.ScheduleStart,
        '              o2.ScheduleEnd,
        '              o1.Title
        '             }

        dgvRecord.DataSource = record




    End Sub
End Class
