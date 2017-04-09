

Public Class ActivityRegister
    Private schedule As ScheduleClass

    Private Sub initializeScheduleForDevelopment()
        Dim db As New ScheduleDBDataContext

        Dim s As Schedule = db.Schedules.FirstOrDefault(Function(o) o.ScheduleID = 5000002)
        Dim st As ScheduleTime = db.ScheduleTimes.FirstOrDefault(Function(o) o.ScheduleID = 5000002)

        Dim thisSchedule As ScheduleClass = New ScheduleClass(s.ScheduleID, CDate(st.ScheduleStart), CDate(st.ScheduleEnd), CDate(s.RepeatDue), CByte(s.RepeatBehavior.ToArray(8)), s.Title, s.Description, s.Venue, s.Type, s.Status)
        schedule = thisSchedule
    End Sub

    Private Sub ActivityRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initializeScheduleForDevelopment()

        cboActivityType.Items.AddRange(ScheduleClass.getTypeList())

        If schedule Is Nothing Then
            activityCreateMode()
        Else
            activityEditMode()
        End If

    End Sub

    Private Sub activityEditMode() 'called when control is used to edit schedule

        AddHandler btnDone.MouseClick, AddressOf btnDoneEdit_MouseClick

        populateDataToControls()

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
            btnAddParti.Enabled = False
            btnAddParti.Visible = False
        End If


        settingdgvColumn() 'resize the column
        populateParticiples() 'insert data to grid view
    End Sub

    Private Sub activityCreateMode() 'called when control is used to create schedule
        AddHandler btnDone.MouseClick, AddressOf btnDoneCreate_MouseClick
    End Sub

    Private Sub populateDataToControls()
        scheStart.Value = schedule.ScheduleStart
        scheEnd.Value = schedule.ScheduleEnd
        txtTitle.Text = schedule.Title
        txtBoxDescription.Text = schedule.Description
        txtVenue.Text = schedule.Venue

        Dim index As Integer = 0
        Dim i As Integer = 0
        For Each item As String In ScheduleClass.getTypeList()
            If item.Equals(schedule.Type) Then
                index = i
            End If
            i += 1
        Next

        cboActivityType.SelectedIndex = index

        Dim abc As Byte = CByte(30)

        Console.WriteLine(abc.ToString)

    End Sub

    Private Sub btnDoneCreate_MouseClick(sender As Object, e As EventArgs)
        Console.WriteLine("is Create")
    End Sub

    Private Sub btnDoneEdit_MouseClick(sender As Object, e As EventArgs)
        Dim db As New ScheduleDBDataContext

        Dim sche = From s In db.Schedules, st In db.ScheduleTimes
                   Where s.ScheduleID = schedule.ScheduleID And s.ScheduleID = st.ScheduleID And
                       st.InitialTime = True

        With sche.FirstOrDefault
            .st.ScheduleStart = scheStart.Value
            .st.ScheduleEnd = scheEnd.Value
            .s.Title = txtTitle.Text
            .s.Description = txtBoxDescription.Text
            .s.Venue = txtVenue.Text
            .s.Type = cboActivityType.SelectedItem.ToString
        End With

        db.SubmitChanges()
    End Sub


    Private Sub populateParticiples()
        Dim db As New ScheduleDBDataContext()
        Dim rs = From p In db.Participles, m In db.Members
                 Where m.MemberID = p.MemberID And p.ScheduleID = schedule.ScheduleID And p.Status = "Attend"
                 Select New With {p.MemberID, m.Nickname}

        dgvParticipleID.DataPropertyName = "MemberID"
        dgvParticipleName.DataPropertyName = "Nickname"
        dgvParticiples.DataSource = rs
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

        If dgvParticiples.Columns("dgvParticiplesRemove") Is Nothing Then
            dgvParticiples.Columns("dgvParticipleName").Width = CInt(dgvWidth)
        Else
            dgvParticiples.Columns("dgvParticiplesRemove").Width = dgvParticiples.RowTemplate.Height
            dgvParticiples.Columns("dgvParticipleName").Width = CInt(dgvWidth - dgvParticiples.Columns(2).Width)
        End If


    End Sub

    Private Sub btnAddParti_Click(sender As Object, e As EventArgs) Handles btnAddParti.Click
        'use true or false to handle add participle with create and edit condition
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

    Private Sub dgvParticiples_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvParticiples.CellMouseClick, dgvParticiples.CellMouseDown

        dgvParticiples.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(179, 255, 236)
        Dim columnName As String = dgvParticiples.Columns(e.ColumnIndex).Name
        If columnName = "dgvParticiplesRemove" Then
            'change icon
            Dim cellImage As DataGridViewImageCell = CType(dgvParticiples.Rows(e.RowIndex).Cells("dgvParticiplesRemove"), DataGridViewImageCell)
            cellImage.Value = My.Resources.x_mark_3_Pressed

            'preform operation
            If vbYes = MsgBox("Are you sure you want to remove this participle?", vbYesNo, "Warning") Then
                Dim db As New ScheduleDBDataContext()

                Dim p As Participle = db.Participles.FirstOrDefault(Function(o) o.ScheduleID = schedule.ScheduleID And o.MemberID = CInt(dgvParticiples.Rows(e.RowIndex).Cells("dgvParticipleID").Value))

                If p Is Nothing Then
                    MsgBox("The record of the user fail to retrieved", vbOKOnly, "Error")
                ElseIf p.ParticiplesRole.Equals("Owner")
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
