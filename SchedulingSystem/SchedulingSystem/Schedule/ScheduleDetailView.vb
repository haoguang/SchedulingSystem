Public Class ScheduleDetailView
    Friend schedule As ScheduleClass

    Private Sub ScheduleDetailView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If schedule IsNot Nothing Then
            populateDataToControl()

            If ActivityModule.IsOwner(schedule.ScheduleID) Then
                'Add button column
                Dim iconColumn As New DataGridViewImageColumn()

                With iconColumn
                    .Image = My.Resources.transparent
                    .Name = "dgvParticiplesRemove"
                    .HeaderText = "Remove"
                    .ToolTipText = "Remore this participle"
                End With
                dgvParticiples.Columns.Insert(2, iconColumn)
                btnAddParti.Enabled = True
                btnAddParti.Visible = True
            Else
                'disable the button if not owner of the schedule
                btnAddParti.Enabled = False
                btnAddParti.Visible = False
            End If
        End If
    End Sub

    Private Sub populateDataToControl()
        lblStart.Text = schedule.ScheduleStart.ToString("dd/MM/yyyy HH:mm")
        lblEnd.Text = schedule.ScheduleEnd.ToString("dd/MM/yyyy HH:mm")
        lblAcTitle.Text = schedule.Title
        lblDesc.Text = schedule.Description
        lblVenue.Text = schedule.Venue
        lblActivityType.Text = schedule.Type
        lblRepeatDue.Text = schedule.RepeatDue.ToString("dd/MM/yyyy")
        lblRepeatBehave.Text = RepeatationModule.getRepeatString(schedule.RepeatBehavior)


        If schedule.Type = ScheduleClass.PERSONAL_TYPE Then
            dgvParticiples.Enabled = False
        Else
            dgvParticiples.Enabled = True
        End If
    End Sub
End Class
