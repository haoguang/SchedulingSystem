Imports System.IO

Public Class ScheduleDetailView
    Friend schedule As ScheduleClass
    Friend parentCtrl As ScheduleViewPanel

    Private Sub ScheduleDetailView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If schedule IsNot Nothing Then

            If ActivityModule.IsOwner(schedule.ScheduleID) Then
                'Add button column
                Dim iconColumn As New DataGridViewImageColumn()

                With iconColumn
                    .Image = My.Resources.transparent
                    .Name = "dgvParticiplesRemove"
                    .HeaderText = "Remove"
                    .ToolTipText = "Remore this participle"
                End With

                dgvParticiples.Columns.Insert(3, iconColumn)
                btnAddParti.Enabled = True
                btnAddParti.Visible = True
                btnEdit.Enabled = True
            Else
                'disable the button if not owner of the schedule
                btnAddParti.Enabled = False
                btnAddParti.Visible = False
                btnEdit.Enabled = False
                btnEdit.BackColor = Color.LightSlateGray
                btnEdit.ForeColor = Color.Gray
            End If

            populateDataToControl()
            settingdgvColumn()
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
            gbParticiple.Enabled = False
        Else
            gbParticiple.Enabled = True
            populateParticiples()
        End If
    End Sub

    Private Sub populateParticiples()
        dgvParticiples.Rows.Clear()
        Dim db As New ScheduleDBDataContext()
        Dim rs = From p In db.Participles, m In db.Members
                 Where m.MemberID = p.MemberID And p.ScheduleID = schedule.ScheduleID And
                     p.Status = ScheduleClass.PARTICIPLE_ATTENT And p.ParticiplesRole <> ScheduleClass.OWNER
                 Select New With {m.Picture, p.MemberID, m.Nickname}

        For Each i In rs
            Dim ProPic As Image
            Dim imgByte As Byte() = Nothing

            Dim stream As MemoryStream
            If i.Picture IsNot Nothing Then
                imgByte = CType(i.Picture.ToArray, Byte())
                stream = New MemoryStream(imgByte, 0, imgByte.Length)
                ProPic = Image.FromStream(stream)
            Else
                ProPic = My.Resources.user_default
            End If

            dgvParticiples.Rows.Add(i.MemberID, ProPic, i.Nickname)
        Next

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        Dim scheduleEditor As New ActivityRegister

        Dim db As New ScheduleDBDataContext

        Dim rs = From s In db.Schedules, st In db.ScheduleTimes
                 Where s.ScheduleID = st.ScheduleID And st.ScheduleID = schedule.ScheduleID And
                      st.InitialTime = True

        Dim tempSchedule As New ScheduleClass(rs.FirstOrDefault.s.ScheduleID, CDate(rs.FirstOrDefault.st.ScheduleStart), CDate(rs.FirstOrDefault.st.ScheduleEnd),
                                              CDate(rs.FirstOrDefault.s.RepeatDue), rs.FirstOrDefault.s.RepeatBehavior.ToArray.First(), rs.FirstOrDefault.s.Title,
                                              rs.FirstOrDefault.s.Description, rs.FirstOrDefault.s.Venue, rs.FirstOrDefault.s.Type, rs.FirstOrDefault.s.Status)

        scheduleEditor.schedule = tempSchedule
        scheduleEditor.parentCtrl = parentCtrl


        parentCtrl.prevCtrl.Push(Me)
        parentCtrl.DetailViewPanel.Controls.Clear()
        parentCtrl.DetailViewPanel.Controls.Add(scheduleEditor)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        parentCtrl.btnBack_MouseClick(Nothing, Nothing)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If vbYes = MsgBox("Are you sure you want to cancel this activity?", vbYesNo, "Warning") Then

            ' cancel a record
            Dim db As New ScheduleDBDataContext
            If ActivityModule.IsOwner(schedule.ScheduleID) Then
                Dim s As Schedule = db.Schedules.FirstOrDefault(Function(o) o.ScheduleID = schedule.ScheduleID)
                s.Status = ScheduleClass.CANCEL_STATUS

            Else
                Dim p As Participle = db.Participles.FirstOrDefault(Function(o) o.ScheduleID = schedule.ScheduleID)
                p.Status = ScheduleClass.PARTICIPLE_REJECT
            End If

            db.SubmitChanges()
        End If
    End Sub

    Private Sub btnAddParti_Click(sender As Object, e As EventArgs) Handles btnAddParti.Click
        Dim participleAdd As New AddParticiple
        participleAdd.ScheduleID = schedule.ScheduleID
        participleAdd.ShowDialog()
    End Sub

    Private Sub btnAddParti_MouseEnterAndUp(sender As Object, e As EventArgs) Handles btnAddParti.MouseEnter, btnAddParti.MouseUp
        btnAddParti.Image = My.Resources.add_user_hover
    End Sub

    Private Sub btnAddParti_MouseDown(sender As Object, e As MouseEventArgs) Handles btnAddParti.MouseDown
        btnAddParti.Image = My.Resources.add_user_pressed
    End Sub

    Private Sub btnAddParti_MouseLeave(sender As Object, e As EventArgs) Handles btnAddParti.MouseLeave
        btnAddParti.Image = My.Resources.add_user_32
    End Sub

    Private Sub settingdgvColumn()
        Dim dgvWidth As Double = dgvParticiples.Width

        If dgvParticiples.Columns("dgvParticiplesRemove") Is Nothing Then
            dgvParticiples.Columns("dgvParticiplePic").Width = dgvParticiples.RowTemplate.Height
            dgvParticiples.Columns("dgvParticipleName").Width = CInt(dgvWidth - dgvParticiples.Columns("dgvParticiplePic").Width)
        Else

            dgvParticiples.Columns("dgvParticiplePic").Width = dgvParticiples.RowTemplate.Height
            dgvParticiples.Columns("dgvParticiplesRemove").Width = dgvParticiples.RowTemplate.Height
            dgvParticiples.Columns("dgvParticipleName").Width = CInt(dgvWidth - dgvParticiples.Columns("dgvParticiplesRemove").Width - dgvParticiples.Columns("dgvParticiplePic").Width)
        End If


    End Sub
    Private Sub dgvParticiples_MouseEnterAndMouseUp(sender As Object, e As DataGridViewCellEventArgs) Handles dgvParticiples.CellMouseEnter
        If dgvParticiples.Columns("dgvParticiplesRemove") IsNot Nothing Then
            Dim cellImage As DataGridViewImageCell = CType(dgvParticiples.Rows(e.RowIndex).Cells("dgvParticiplesRemove"), DataGridViewImageCell)
            cellImage.Value = My.Resources.x_mark_3_24
        End If

        dgvParticiples.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(0, 179, 134)

    End Sub

    Private Sub dgvParticiples_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvParticiples.CellMouseUp
        If dgvParticiples.Columns("dgvParticiplesRemove") IsNot Nothing Then
            Dim cellImage As DataGridViewImageCell = CType(dgvParticiples.Rows(e.RowIndex).Cells("dgvParticiplesRemove"), DataGridViewImageCell)
            cellImage.Value = My.Resources.x_mark_3_24
        End If
        dgvParticiples.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(0, 179, 134)
    End Sub

    Private Sub dgvParticiples_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvParticiples.CellMouseLeave
        If dgvParticiples.Columns("dgvParticiplesRemove") IsNot Nothing Then
            Dim cellImage As DataGridViewImageCell = CType(dgvParticiples.Rows(e.RowIndex).Cells("dgvParticiplesRemove"), DataGridViewImageCell)
            cellImage.Value = My.Resources.transparent
        End If
        dgvParticiples.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192)

    End Sub
    Private Sub dgvParticiples_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvParticiples.CellMouseClick
        Dim columnName As String = dgvParticiples.Columns(e.ColumnIndex).Name

        If columnName = "dgvParticiplesRemove" Then

            'preform operation
            If vbYes = MsgBox("Are you sure you want to remove this participle?", vbYesNo, "Warning") Then
                Dim db As New ScheduleDBDataContext()

                Dim p As Participle = db.Participles.FirstOrDefault(Function(o) o.ScheduleID = schedule.ScheduleID And o.MemberID = CInt(dgvParticiples.Rows(e.RowIndex).Cells("dgvParticipleID").Value))

                If p Is Nothing Then
                    MsgBox("The record of the user fail to retrieved", vbOKOnly, "Error")
                ElseIf p.ParticiplesRole.Equals("Owner") Then
                    MsgBox("You can't remove yourself as an owner of the activity", vbOKOnly, "Warning")
                Else
                    db.Participles.DeleteOnSubmit(p)
                    db.SubmitChanges()
                    populateParticiples()
                End If
            End If

        End If
    End Sub
End Class
