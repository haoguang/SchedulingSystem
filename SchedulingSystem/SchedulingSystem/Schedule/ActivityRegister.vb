
Imports System.Data.Linq
Imports System.IO

Public Class ActivityRegister
    Friend schedule As ScheduleClass
    Friend parentCtrl As ScheduleViewPanel
    Private repeat As RepeatationClass


    Private Sub initializeScheduleForDevelopment() '******************************************
        Dim db As New ScheduleDBDataContext

        Dim s As Schedule = db.Schedules.FirstOrDefault(Function(o) o.ScheduleID = 5000005)
        Dim st As ScheduleTime = db.ScheduleTimes.FirstOrDefault(Function(o) o.ScheduleID = 5000005 And o.InitialTime = True)

        Dim thisSchedule As ScheduleClass = New ScheduleClass(s.ScheduleID, CDate(st.ScheduleStart), CDate(st.ScheduleEnd), CDate(s.RepeatDue), CByte(s.RepeatBehavior.ToArray().First()), s.Title, s.Description, s.Venue, s.Type, s.Status)
        schedule = thisSchedule
    End Sub

    Private Sub ActivityRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'initializeScheduleForDevelopment() 'to test adding *******************************

        cboMinBefore.SelectedIndex = -1
        cboActivityType.Items.AddRange(ScheduleClass.getTypeList())
        cboActivityType.SelectedIndex = 0
        cboBehavior.Items.AddRange(RepeatationModule.getRepeatStringArray())
        cboBehavior.SelectedIndex = 0

        If schedule Is Nothing Then

            activityCreateMode()
        Else
            activityEditMode()
        End If

    End Sub

    Private Sub activityEditMode() 'called when control is used to edit schedule

        AddHandler btnDone.MouseClick, AddressOf btnDoneEdit_MouseClick

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
        Else
            'disable the button if not owner of the schedule
            btnAddParti.Enabled = False
            btnAddParti.Visible = False
        End If

        settingdgvColumn() 'resize the column

        populateDataToControls() 'insert data to all control

        populateParticiples() 'insert data to grid view
    End Sub

    Private Sub activityCreateMode() 'called when control is used to create schedule
        ' limit date control min date
        scheStart.MinDate = Date.Today
        scheEnd.MinDate = Date.Today

        AddHandler btnDone.MouseClick, AddressOf btnDoneCreate_MouseClick

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

        settingdgvColumn() 'resize the column
    End Sub

    Private Sub populateDataToControls()
        scheStart.Value = schedule.ScheduleStart
        scheEnd.Value = schedule.ScheduleEnd
        txtTitle.Text = schedule.Title
        txtBoxDescription.Text = schedule.Description
        txtVenue.Text = schedule.Venue
        scheRepeatDue.Value = schedule.RepeatDue


        Dim index As Integer = 0
        Dim i As Integer = 0
        For Each item As String In ScheduleClass.getTypeList()
            If item.Equals(schedule.Type) Then
                index = i
            End If
            i += 1
        Next

        cboActivityType.SelectedIndex = index

        index = 0
        i = 0
        For Each item As String In RepeatationModule.getRepeatStringArray()
            If item.Equals(RepeatationModule.getRepeatString(schedule.RepeatBehavior)) Then
                index = i
            End If
            i += 1
        Next

        cboBehavior.SelectedIndex = index

    End Sub

    Private Sub btnDoneCreate_MouseClick(sender As Object, e As EventArgs) ' Done button handler for create schedule use

        If Me.ValidateChildren() = False Then
            Return
        End If

        Dim startDate As DateTime = scheStart.Value
        Dim endDate As DateTime = scheEnd.Value
        Dim title As String = txtTitle.Text
        Dim description As String = txtBoxDescription.Text
        Dim venue As String = txtVenue.Text
        Dim type As String = cboActivityType.SelectedItem.ToString

        Dim repeatBehave As Byte = RepeatationModule.getRepeatBehavior(cboBehavior.SelectedItem.ToString)
        Dim repeatDue As Date = scheRepeatDue.Value

        Dim db As New ScheduleDBDataContext

        Dim schedule As New Schedule With {.Title = title, .Description = description,
            .Venue = venue, .Type = type, .RepeatBehavior = New Binary(BitConverter.GetBytes(repeatBehave)), .RepeatDue = repeatDue}

        If type.Equals(ScheduleClass.APPOINTMENT_TYPE) Then
            schedule.Status = ScheduleClass.PENDING_STATUS
        Else
            schedule.Status = ScheduleClass.ACTIVE_STATUS
        End If

        db.Schedules.InsertOnSubmit(schedule)
        db.SubmitChanges()

        Dim scheduleid As Integer = schedule.ScheduleID

        Dim scheduleTime As New ScheduleTime With {.ScheduleID = scheduleid, .InitialTime = True, .ScheduleStart = startDate, .ScheduleEnd = endDate}

        Dim participle As New Participle With {.ScheduleID = scheduleid, .ParticiplesRole = ScheduleClass.OWNER, .Status = ScheduleClass.PARTICIPLE_ATTENT,
            .MemberID = DevelopmentVariables.UserID, .GenerateDate = Date.Today}

        db.ScheduleTimes.InsertOnSubmit(scheduleTime)
        db.Participles.InsertOnSubmit(participle)
        db.SubmitChanges()

        If dgvParticiples.RowCount > 0 And gbParticiple.Enabled Then
            insertParticipleToDB(scheduleid)
        End If

        If (repeatBehave <> RepeatationModule.REPEAT_NONE And repeat IsNot Nothing) Then
            repeat.scheduleID = scheduleid
            RepeatationModule.generateScheduleTimeRecord(repeat)
        End If

        MessageBox.Show("Successfully added a schedule", "Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information)
        backToSchedule()
    End Sub

    Private Sub btnDoneEdit_MouseClick(sender As Object, e As EventArgs) ' Done button handler for edit schedule use
        If Me.ValidateChildren() = False Then
            Return
        End If

        Dim repeatBehave As Byte = RepeatationModule.getRepeatBehavior(cboBehavior.SelectedItem.ToString)
        Dim repeatDue As Date = scheRepeatDue.Value

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
            .s.RepeatDue = repeatDue
            .s.RepeatBehavior = New Binary(BitConverter.GetBytes(repeatBehave))
        End With

        db.SubmitChanges()

        RepeatationModule.deleteScheduleTimeRecord(schedule.ScheduleID)

        If (repeatBehave <> RepeatationModule.REPEAT_NONE And repeat IsNot Nothing) Then
            repeat.scheduleID = schedule.ScheduleID
            RepeatationModule.generateScheduleTimeRecord(repeat)
        End If

        MessageBox.Show("Successfully edited a schedule", "Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information)
        backToSchedule()
    End Sub

    Private Sub backToSchedule()
        Dim view As New DayScheduleViewer
        My.Forms.MainForm.ContentPanel.Controls.Clear()
        My.Forms.MainForm.ContentPanel.Controls.Add(view)
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

    Private Sub btnAddParti_Click(sender As Object, e As EventArgs) Handles btnAddParti.Click
        Dim participleAdd As New AddParticiple

        If schedule Is Nothing Then

            participleAdd.ScheduleID = -1
            participleAdd.participleList = dgvParticiples

        Else
            participleAdd.ScheduleID = schedule.ScheduleID
        End If

        participleAdd.ShowDialog()

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
        If schedule Is Nothing Then
            'romove row only
            If columnName = "dgvParticiplesRemove" Then
                dgvParticiples.Rows.RemoveAt(e.RowIndex)
            End If

        Else


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
        End If



    End Sub

    Private Sub dgvParticiples_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvParticiples.CellMouseDown

        dgvParticiples.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(179, 255, 236)

        Dim columnName As String = dgvParticiples.Columns(e.ColumnIndex).Name
        If columnName = "dgvParticiplesRemove" Then
            Dim cellImage As DataGridViewImageCell = CType(dgvParticiples.Rows(e.RowIndex).Cells("dgvParticiplesRemove"), DataGridViewImageCell)
            cellImage.Value = My.Resources.x_mark_3_Pressed
        End If

    End Sub

    Private Sub scheEnd_ValueChanged(sender As Object, e As EventArgs) Handles scheEnd.ValueChanged
        'To make sure that due date is atleast same as end date
        scheRepeatDue.MinDate = scheEnd.Value.Date
        scheStart.MaxDate = scheEnd.Value
        scheRepeatDue.Value = scheEnd.Value


    End Sub

    Private Sub scheStart_ValueChanged(sender As Object, e As EventArgs) Handles scheStart.ValueChanged
        scheEnd.MinDate = scheStart.Value
    End Sub

    Private Sub cboActivityType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboActivityType.SelectedIndexChanged
        If cboActivityType.SelectedItem.ToString.Equals(ScheduleClass.PERSONAL_TYPE) Then
            gbRepeat.Enabled = True
            gbParticiple.Enabled = False
        Else
            gbRepeat.Enabled = False
            gbParticiple.Enabled = True
        End If
    End Sub

    Private Sub generateRepeatDates()


        Dim startDate As DateTime = scheStart.Value
        Dim endDate As DateTime = scheEnd.Value
        Dim repeatDue As Date = scheRepeatDue.Value

        If Not (cboBehavior.SelectedItem.ToString.Equals(RepeatationModule.NONE_STRING)) Then
            repeat = New RepeatationClass(If(schedule Is Nothing, 0, schedule.ScheduleID), startDate, endDate)
            Dim errorMessage = repeat.generateDateArray(RepeatationModule.getRepeatBehavior(cboBehavior.SelectedItem.ToString), repeatDue)

            If Not (errorMessage.Equals("errorless")) Then
                MessageBox.Show(errorMessage, "Repetation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

    End Sub

    Private Sub RepeatationHandler(sender As Object, e As EventArgs) Handles cboBehavior.SelectedIndexChanged, scheRepeatDue.ValueChanged, scheStart.ValueChanged, scheEnd.ValueChanged
        generateRepeatDates()
    End Sub

    Private Sub insertParticipleToDB(scheduleid As Integer)
        Dim db As New ScheduleDBDataContext
        Dim participle As Participle

        For Each row As DataGridViewRow In dgvParticiples.Rows
            participle = New Participle
            With participle
                .ScheduleID = scheduleid
                .MemberID = CInt(row.Cells("dgvParticipleID").Value)
                .ParticiplesRole = ScheduleClass.PARTICIPLE
                .Status = ScheduleClass.PENDING_STATUS
                .GenerateDate = Date.Today
            End With

            db.Participles.InsertOnSubmit(participle)
        Next

        db.SubmitChanges()
    End Sub

    Private Sub txtTitle_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTitle.Validating

        If txtTitle.Text.Equals("") Then
            Err.SetError(txtTitle, "Field must not be empty.")
            e.Cancel = True
        Else
            Err.SetError(txtTitle, Nothing)
        End If

    End Sub

    Private Sub txtBoxDescription_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtBoxDescription.Validating

        If txtBoxDescription.Text.Equals("") Then
            Err.SetError(txtBoxDescription, "Field must not be empty")
            e.Cancel = True
        Else
            Err.SetError(txtBoxDescription, Nothing)
        End If
    End Sub

    Private Sub txtVenue_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtVenue.Validating

        If txtVenue.Text.Equals("") Then
            Err.SetError(txtVenue, "Field must not be empty")
            e.Cancel = True
        Else
            Err.SetError(txtVenue, Nothing)
        End If

    End Sub

    Private Sub cboActivityType_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboActivityType.Validating
        If schedule IsNot Nothing Then
            If schedule.Type = ScheduleClass.PERSONAL_TYPE Then
                If Not (cboActivityType.SelectedItem.ToString.Equals(ScheduleClass.PERSONAL_TYPE)) Then
                    Err.SetError(cboActivityType, "Once activity type is set to personal it can't change to activity type involve multiple person")
                    e.Cancel = True
                Else
                    Err.SetError(cboActivityType, Nothing)
                End If
            Else
                If cboActivityType.SelectedItem.ToString.Equals(ScheduleClass.PERSONAL_TYPE) Then
                    Err.SetError(cboActivityType, "Once activity type is set to multiperson activity type it can't change to activity type involve only one person")
                    e.Cancel = True
                Else
                    Err.SetError(cboActivityType, Nothing)
                End If
            End If
        End If
    End Sub

    Private Sub schedule_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles scheEnd.Validating, scheStart.Validating
        If scheEnd.Value.CompareTo(scheStart.Value) < 1 Then
            Err.SetError(scheStart, "The Start date must be earlier than the end date")
            Err.SetError(scheEnd, "The end date must be later than the start date")
            e.Cancel = True
        ElseIf DateDiff(DateInterval.Minute, scheStart.Value, scheEnd.Value) < 30 Then
            Err.SetError(scheStart, "The duration of the time must more than 30 minutes")
            Err.SetError(scheEnd, "The duration of the time must more than 30 minutes")
            e.Cancel = True
        ElseIf ActivityModule.dateValidator(scheEnd.Value, DevelopmentVariables.UserID, If(schedule Is Nothing, -1, schedule.ScheduleID)) Then
            Err.SetError(scheStart, Nothing)
            Err.SetError(scheEnd, "The end date is having conflict with other schedule")
            e.Cancel = True
        ElseIf ActivityModule.dateValidator(scheStart.Value, DevelopmentVariables.UserID, If(schedule Is Nothing, -1, schedule.ScheduleID)) Then
            Err.SetError(scheEnd, Nothing)
            Err.SetError(scheStart, "The start date is having conflict with other schedule")
            e.Cancel = True
        ElseIf ActivityModule.dateValidator2(scheStart.Value, scheEnd.Value, DevelopmentVariables.UserID, If(schedule Is Nothing, -1, schedule.ScheduleID)) Then
            Err.SetError(scheStart, "There is schedule conflict between both times")
            Err.SetError(scheEnd, "There is schedule conflict between both times")
            e.Cancel = True
        Else
            Err.SetError(scheEnd, Nothing)
            Err.SetError(scheStart, Nothing)
        End If
    End Sub

    Private Sub scheRepeatDue_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles scheRepeatDue.Validating
        If scheRepeatDue.Value.CompareTo(scheEnd.Value) > 1 Then
            Err.SetError(scheRepeatDue, "RepeatDue cannot be earlier than the schedule dates")
            e.Cancel = True
        Else
            Err.SetError(scheRepeatDue, Nothing)
        End If
    End Sub

    Private Sub dgvParticiples_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dgvParticiples.Validating
        If Not (cboActivityType.SelectedItem.ToString.Equals(ScheduleClass.PERSONAL_TYPE)) Then
            If dgvParticiples.RowCount < 1 Then
                Err.SetError(gbParticiple, cboActivityType.SelectedItem.ToString & " need to be atleast invite 1 person")
                e.Cancel = True
            Else
                Err.SetError(gbParticiple, Nothing)
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If schedule Is Nothing Then
            backToSchedule()
        Else
            parentCtrl.btnBack_MouseClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnAddReminder_Click(sender As Object, e As EventArgs) Handles btnAddReminder.Click
        Dim minutes As String



    End Sub
End Class
