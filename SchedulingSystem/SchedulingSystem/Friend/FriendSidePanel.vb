Imports System.IO
Public Class FriendSidePanel
    Private Sub FriendSidePanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New ScheduleDBDataContext
        populateDGVF()
    End Sub

    Friend Sub populateDGVF()
        DGVF.Rows.Clear()
        Dim db As New ScheduleDBDataContext
        Dim img As Image
        Dim imgByte As Byte() = Nothing
        Dim stream As MemoryStream
        Dim fl = From o In db.Friends, m In db.Members
                 Where o.UserID = LoginSession.memberID And o.FriendID = m.MemberID And o.Status <> "Pending"
                 Select m.Picture, m.Username, m.MemberID, o.Status
        For Each p In fl
            If p.Picture IsNot Nothing Then
                imgByte = CType(p.Picture.ToArray, Byte())
                stream = New MemoryStream(imgByte, 0, imgByte.Length)
                img = Image.FromStream(stream)
            Else
                img = My.Resources.user_default
            End If
            DGVF.Rows.Add(img, p.Username, p.MemberID, p.Status)
        Next
        If DGVF.RowCount = 0 Then
            MessageBox.Show("You currently have no friends" & vbNewLine &
                            "Please proceed to add friends by clicking OK button", "")
            My.Forms.MainForm.ContentPanel.Controls.Clear()
            Dim UserCtrl3 As New SearchnewFriend
            My.Forms.MainForm.ContentPanel.Controls.Add(UserCtrl3)
        End If
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        DGVF.Rows.Clear()
        Dim db As New ScheduleDBDataContext
        Dim img As Image
        Dim imgByte As Byte() = Nothing
        Dim stream As MemoryStream
        Dim fl = From o In db.Friends,
                     m In db.Members
                 Where o.UserID = LoginSession.memberID And o.FriendID = m.MemberID And m.Username.StartsWith(txtsearch.Text) And Not o.Status = "Pending"
                 Select m.Picture, m.Username, m.MemberID, o.Status
        For Each p In fl
            If p.Picture IsNot Nothing Then
                imgByte = CType(p.Picture.ToArray, Byte())
                Stream = New MemoryStream(imgByte, 0, imgByte.Length)
                img = Image.FromStream(Stream)
            Else
                img = My.Resources.user_default
            End If

            DGVF.Rows.Add(img, p.Username, p.MemberID, p.Status)
        Next

    End Sub

    Private Sub btnFriend_Click(sender As Object, e As EventArgs) Handles btnFriend.Click
        My.Forms.MainForm.ContentPanel.Controls.Clear()
        Dim UserCtrl3 As New SearchnewFriend
        My.Forms.MainForm.ContentPanel.Controls.Add(UserCtrl3)
    End Sub

    Private Sub DGVF_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVF.CellClick
        My.Forms.MainForm.ContentPanel.Controls.Clear()
        Dim UserCtrl4 As New ListFriend
        UserCtrl4.friend_id = Integer.Parse(DGVF.CurrentRow.Cells(2).Value.ToString)
        UserCtrl4.sideCtrl = Me
        My.Forms.MainForm.ContentPanel.Controls.Add(UserCtrl4)
    End Sub

    Private Sub btnFriend_MouseDown(sender As Object, e As MouseEventArgs) Handles btnFriend.MouseDown
        btnFriend.BackgroundImage = My.Resources.add_user_pressed
    End Sub

    Private Sub btnFriend_MouseEnterAndMouseUp(sender As Object, e As EventArgs) Handles btnFriend.MouseEnter, btnFriend.MouseUp
        btnFriend.BackgroundImage = My.Resources.add_user_hover
    End Sub

    Private Sub btnFriend_MouseLeave(sender As Object, e As EventArgs) Handles btnFriend.MouseLeave
        btnFriend.BackgroundImage = My.Resources.add_user_32

    End Sub

    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If Not (Asc(e.KeyChar) = 20) AndAlso e.KeyChar <> ControlChars.Back Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
End Class
