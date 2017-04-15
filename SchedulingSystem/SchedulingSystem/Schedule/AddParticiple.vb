Imports System.Drawing.Imaging
Imports System.IO

Public Class AddParticiple
    Friend ScheduleID As Integer = -1
    Friend participleList As DataGridView

    Private Sub refreshFriendGridView(keyword As String)
        dgvAddUsers.Rows.Clear()
        Dim db As New ScheduleDBDataContext()

        Dim friends = From f In db.Friends, m In db.Members
                      Where f.UserID = DevelopmentVariables.UserID And
                          f.FriendID = m.MemberID And
                          f.Status <> "Pending" And
                          (m.Nickname.Contains(keyword) Or
                          m.Username.Contains(keyword))
                      Select m.Picture, m.MemberID, m.Nickname

        For Each i In friends
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

            dgvAddUsers.Rows.Add(i.MemberID, ProPic, i.Nickname, My.Resources.transparent)
        Next
    End Sub

    Private Sub refreshPublicGridView(Keyword As String)

        dgvPublic.Rows.Clear()
        Dim db As New ScheduleDBDataContext()

        Dim friends = From m In db.Members
                      Where (m.Nickname.Contains(Keyword) Or
                          m.Username.Contains(Keyword)) And Not (m.MemberID = DevelopmentVariables.UserID)
                      Select m.Picture, m.MemberID, m.Nickname

        For Each i In friends
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

            dgvPublic.Rows.Add(i.MemberID, ProPic, i.Nickname, My.Resources.transparent)
        Next
    End Sub

    Private Sub AddParticiple_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        settingColumnWidth() 'set the column width of the gridview
        refreshFriendGridView("")  'populate user to gridview
        tbcParticipleAdd.SelectedIndex = 0 'set default tab
        Me.ActiveControl = txtSearchFriend  'focus on textbox
    End Sub

    Private Sub settingColumnWidth()

        dgvAddUsers.Columns("dgvAddUsersButton").Width = dgvAddUsers.RowTemplate.Height
        dgvAddUsers.Columns("dgvAddUsersProPic").Width = dgvAddUsers.RowTemplate.Height
        dgvAddUsers.Columns("dgvAddUsersName").Width = CInt(dgvAddUsers.Width - dgvAddUsers.Columns("dgvAddUsersButton").Width - dgvAddUsers.Columns("dgvAddUsersProPic").Width)


        dgvPublic.Columns("dgvPublicUserPicture").Width = dgvPublic.RowTemplate.Height
        dgvPublic.Columns("dgvPublicAddButton").Width = dgvPublic.RowTemplate.Height
        dgvPublic.Columns("dgvPublicName").Width = CInt(dgvPublic.Width - dgvPublic.Columns("dgvPublicAddButton").Width - dgvPublic.Columns("dgvPublicUserPicture").Width)
    End Sub

    Private Sub tbcParticipleAdd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcParticipleAdd.SelectedIndexChanged
        If tbcParticipleAdd.SelectedIndex = 0 Then
            txtSearchFriend.Focus()
        Else
            txtSearchPublic.Focus()
        End If
    End Sub

    Private Sub txtSearchFriend_TextChanged(sender As Object, e As EventArgs) Handles txtSearchFriend.TextChanged
        refreshFriendGridView(txtSearchFriend.Text)
    End Sub

    Private Sub dgvAddUsers_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAddUsers.CellMouseEnter
        Dim cellImage As DataGridViewImageCell = CType(dgvAddUsers.Rows(e.RowIndex).Cells("dgvAddUsersButton"), DataGridViewImageCell)
        cellImage.Value = My.Resources.add_user_hover
        dgvAddUsers.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(0, 179, 134)
    End Sub

    Private Sub dgvAddUsers_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvAddUsers.CellMouseUp
        Dim cellImage As DataGridViewImageCell = CType(dgvAddUsers.Rows(e.RowIndex).Cells("dgvAddUsersButton"), DataGridViewImageCell)
        cellImage.Value = My.Resources.add_user_hover
        dgvAddUsers.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(0, 179, 134)
    End Sub

    Private Sub dgvAddUsers_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAddUsers.CellMouseLeave
        Dim cellImage As DataGridViewImageCell = CType(dgvAddUsers.Rows(e.RowIndex).Cells("dgvAddUsersButton"), DataGridViewImageCell)
        cellImage.Value = My.Resources.transparent
        dgvAddUsers.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192)
    End Sub

    Private Sub dgvAddUsers_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvAddUsers.CellMouseClick


        Dim columnName As String = dgvAddUsers.Columns(e.ColumnIndex).Name
        If columnName = "dgvAddUsersButton" Then

            If ScheduleID = -1 Then
                'for create mode user list
                EditParticipleWhenCreateSchedule(CType(dgvAddUsers.Rows(e.RowIndex).Cells("dgvAddUsersProPic").Value, Image), CInt(dgvAddUsers.Rows(e.RowIndex).Cells("dgvAddUsersID").Value), dgvAddUsers.Rows(e.RowIndex).Cells("dgvAddUsersName").Value.ToString)
            Else
                'for edit mode user list
                EditParticipleWhenEditSchedule(CInt(dgvAddUsers.Rows(e.RowIndex).Cells("dgvAddUsersID").Value), dgvAddUsers.Rows(e.RowIndex).Cells("dgvAddUsersName").Value.ToString)
            End If
        End If
    End Sub

    Sub EditParticipleWhenCreateSchedule(ProPic As Image, userID As Integer, userName As String)

        For Each item As DataGridViewRow In participleList.Rows
            If item.Cells("dgvParticipleID").Value.Equals(userID) Then
                MessageBox.Show("User " & userName & " already exist in the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Next
        participleList.Rows.Add(userID, ProPic, userName, My.Resources.transparent)
        MessageBox.Show("Successfully added " & userName & " to the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Sub EditParticipleWhenEditSchedule(userID As Integer, userName As String)
        Dim db As New ScheduleDBDataContext
        Dim isDuplicated As Boolean = db.Participles.Any(Function(o) o.MemberID = userID And o.ScheduleID = ScheduleID)

        Dim participle As New Participle()
        With participle
            .ScheduleID = ScheduleID
            .MemberID = userID
            .ParticiplesRole = ScheduleClass.PARTICIPLE
            .Status = ScheduleClass.PARTICIPLE_PENDING
            .GenerateDate = Date.Today
        End With

        If isDuplicated Then
            MessageBox.Show("You had invited " & userName & ".", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            db.Participles.InsertOnSubmit(participle)
            db.SubmitChanges()
            MessageBox.Show("You had send a request to " & userName & ".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtSearchPublic_TextChanged(sender As Object, e As EventArgs) Handles txtSearchPublic.TextChanged
        refreshPublicGridView(txtSearchPublic.Text)
    End Sub

    Private Sub dgvPublic_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPublic.CellMouseEnter
        Dim cellImage As DataGridViewImageCell = CType(dgvPublic.Rows(e.RowIndex).Cells("dgvPublicAddButton"), DataGridViewImageCell)
        cellImage.Value = My.Resources.add_user_hover
        dgvPublic.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(0, 179, 134)
    End Sub

    Private Sub dgvPublic_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvPublic.CellMouseUp
        Dim cellImage As DataGridViewImageCell = CType(dgvPublic.Rows(e.RowIndex).Cells("dgvPublicAddButton"), DataGridViewImageCell)
        cellImage.Value = My.Resources.add_user_hover
        dgvPublic.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(0, 179, 134)
    End Sub

    Private Sub dgvPublic_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPublic.CellMouseLeave
        Dim cellImage As DataGridViewImageCell = CType(dgvPublic.Rows(e.RowIndex).Cells("dgvPublicAddButton"), DataGridViewImageCell)
        cellImage.Value = My.Resources.transparent
        dgvPublic.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192)
    End Sub

    Private Sub dgvPublic_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvPublic.CellMouseClick


        Dim columnName As String = dgvPublic.Columns(e.ColumnIndex).Name
        If columnName = "dgvPublicAddButton" Then

            If ScheduleID = -1 Then
                'for create user list
                EditParticipleWhenCreateSchedule(CType(dgvPublic.Rows(e.RowIndex).Cells("dgvPublicUserPicture").Value, Image), CInt(dgvPublic.Rows(e.RowIndex).Cells("dgvPublicUserID").Value), dgvPublic.Rows(e.RowIndex).Cells("dgvPublicName").Value.ToString)
            Else
                'for edit user list
                EditParticipleWhenEditSchedule(CInt(dgvPublic.Rows(e.RowIndex).Cells("dgvPublicUserID").Value), dgvPublic.Rows(e.RowIndex).Cells("dgvPublicName").Value.ToString)
            End If
        End If
    End Sub

    Private Sub dgvAddUsers_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvAddUsers.CellMouseDown
        Dim cellImage As DataGridViewImageCell = CType(dgvAddUsers.Rows(e.RowIndex).Cells("dgvAddUsersButton"), DataGridViewImageCell)

        Dim columnName As String = dgvAddUsers.Columns(e.ColumnIndex).Name

        If columnName = "dgvAddUsersButton" Then
            'change icon
            cellImage.Value = My.Resources.add_user_pressed
            dgvAddUsers.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(179, 255, 236)
        End If

    End Sub

    Private Sub dgvPublic_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvPublic.CellMouseDown
        Dim cellImage As DataGridViewImageCell = CType(dgvPublic.Rows(e.RowIndex).Cells("dgvPublicAddButton"), DataGridViewImageCell)

        Dim columnName As String = dgvPublic.Columns(e.ColumnIndex).Name

        If columnName = "dgvPublicAddButton" Then
            'change icon
            cellImage.Value = My.Resources.add_user_pressed
            dgvPublic.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(179, 255, 236)
        End If
    End Sub
End Class