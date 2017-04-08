Public Class ActivityRegister
    Private scheduleID As Integer = 5000002
    Private Sub ActivityRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ActivityModule.IsOwner(scheduleID) Then
            'Add button column
            Dim iconColumn As New DataGridViewImageColumn()

            With iconColumn
                .Image = My.Resources.transparent
                .Name = "dgvParticiplesRemove"
                .HeaderText = "Remove"
                .ToolTipText = "Remore this participle"
            End With
            dgvParticiples.Columns.Insert(2, iconColumn)
        End If


        settingdgvColumn() 'resize the column
        populateParticiples() 'insert data to grid view



    End Sub


    Private Sub populateParticiples()
        Dim db As New ScheduleDBDataContext()
        Dim rs = From p In db.Participles, m In db.Members
                 Where m.MemberID = p.MemberID And p.ScheduleID = scheduleID And p.Status = "Attend"
                 Select New With {p.MemberID, m.Nickname}

        dgvParticipleID.DataPropertyName = "MemberID"
        dgvParticipleName.DataPropertyName = "Nickname"
        dgvParticiples.DataSource = rs
    End Sub

    Private Sub btnRemoveParti_MouseClick(sender As Object, e As EventArgs)
        MessageBox.Show("This is a mouse click event")
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
        'add friend to row

    End Sub


    Private Sub dgvParticiples_MouseEnterAndMouseUp(sender As Object, e As DataGridViewCellEventArgs) Handles dgvParticiples.CellMouseEnter
        If dgvParticiples.Columns("dgvParticiplesRemove") IsNot Nothing Then
            Dim cellImage As DataGridViewImageCell = CType(dgvParticiples.Rows(e.RowIndex).Cells("dgvParticiplesRemove"), DataGridViewImageCell)
            cellImage.Value = My.Resources.x_mark_3_24
        End If

    End Sub

    Private Sub dgvParticiples_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvParticiples.CellMouseUp
        If dgvParticiples.Columns("dgvParticiplesRemove") IsNot Nothing Then
            Dim cellImage As DataGridViewImageCell = CType(dgvParticiples.Rows(e.RowIndex).Cells("dgvParticiplesRemove"), DataGridViewImageCell)
            cellImage.Value = My.Resources.x_mark_3_24
        End If

    End Sub

    Private Sub dgvParticiples_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvParticiples.CellMouseLeave
        If dgvParticiples.Columns("dgvParticiplesRemove") IsNot Nothing Then
            Dim cellImage As DataGridViewImageCell = CType(dgvParticiples.Rows(e.RowIndex).Cells("dgvParticiplesRemove"), DataGridViewImageCell)
            cellImage.Value = My.Resources.transparent
        End If

    End Sub

    Private Sub dgvParticiples_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvParticiples.CellMouseClick, dgvParticiples.CellMouseDown


        Dim columnName As String = dgvParticiples.Columns(e.ColumnIndex).Name
            If columnName = "dgvParticiplesRemove" Then
                'change icon
                Dim cellImage As DataGridViewImageCell = CType(dgvParticiples.Rows(e.RowIndex).Cells("dgvParticiplesRemove"), DataGridViewImageCell)
                cellImage.Value = My.Resources.x_mark_3_Pressed

                'preform operation
                If vbYes = MsgBox("Are you sure you want to remove this participle?", vbYesNo, "Warning") Then
                    Dim db As New ScheduleDBDataContext()

                    Dim p As Participle = db.Participles.FirstOrDefault(Function(o) o.ScheduleID = scheduleID And o.MemberID = CInt(dgvParticiples.Rows(e.RowIndex).Cells("dgvParticipleID").Value))

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
