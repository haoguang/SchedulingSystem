Public Class SearchnewFriend
    Dim db As New ScheduleDBDataContext

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged

        Dim choosenType = 0
        If R_ID.Checked = False And R_Name.Checked = False And R_Hobby.Checked = True Then
            choosenType = 3
        ElseIf R_ID.Checked = False And R_Hobby.Checked = False And R_Name.Checked = True Then
            choosenType = 2
        ElseIf R_Hobby.Checked = False And R_Name.Checked = False And R_ID.Checked = True Then
            choosenType = 1
        Else
            MessageBox.Show("Please select an option")
        End If
        Dim sf As IQueryable
        Select Case choosenType
            Case 1
                sf = From m In db.Members
                     Where m.MemberID.ToString.Contains((txtsearch.Text))
                     Select m.MemberID, m.Username, m.Email, m.Occupation, m.ContactNo, m.Gender, m.Hobby

            Case 2
                sf = From m In db.Members
                     Where m.Username.ToString.Contains((txtsearch.Text))
                     Select m.Username, m.MemberID, m.Email, m.Occupation, m.ContactNo, m.Gender, m.Hobby

            Case 3
                sf = From m In db.Members
                     Where m.Hobby.ToString.Contains((txtsearch.Text))
                     Select m.Hobby, m.Username, m.MemberID, m.Email, m.Occupation, m.ContactNo, m.Gender
            Case Else
                MessageBox.Show("Please choose a radio button 1st")
        End Select
        If txtsearch.Text.Equals("") Then
            DGVS.DataSource = Nothing
        Else
            DGVS.DataSource = sf
        End If


    End Sub

    Private Sub DGVS_SelectionChanged(sender As Object, e As EventArgs) Handles DGVS.SelectionChanged

    End Sub

    Private Sub SearchnewFriend_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub R_ID_CheckedChanged(sender As Object, e As EventArgs) Handles R_ID.CheckedChanged, R_Name.CheckedChanged, R_Hobby.CheckedChanged
        DGVS.DataSource = Nothing
        If txtsearch.Text <> "" Then
            txtsearch_TextChanged(Nothing, Nothing)
        Else
            DGVS.DataSource = Nothing
        End If


    End Sub
End Class
