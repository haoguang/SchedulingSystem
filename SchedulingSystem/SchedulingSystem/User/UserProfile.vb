Imports System.Data.Linq
Imports System.IO

Public Class UserProfile
    Private Sub UserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get login username
        Dim user As String = LoginSession.username
        'database
        Dim db As New ScheduleDBDataContext
        Dim member As Table(Of Member) = db.GetTable(Of Member)()
        'get user details
        Dim query = From m In member
                    Where m.Username = user
                    Select m
        'if exist
        If query.Count > 0 Then
            For Each m In query
                lblUsername.Text = m.Username
                mskNickname.Text = m.Nickname
                'display image
                Dim img As Image
                Dim imgByte As Byte() = Nothing
                Dim stream As MemoryStream
                imgByte = CType(m.Picture.ToArray, Byte())
                stream = New MemoryStream(imgByte, 0, imgByte.Length)
                img = Image.FromStream(stream)
                picPicture.Image = img
                'select gender
                If m.Gender.Equals("M") Then
                    radMale.Checked = True
                ElseIf m.Gender.Equals("F") Then
                    radFemale.Checked = True
                Else
                    radNotSpecified.Checked = True
                End If

                mskContact.Text = m.ContactNo
                txtEmail.Text = m.Email
                txtHobby.Text = m.Hobby
                txtOccupation.Text = m.Occupation
            Next

        End If

    End Sub
End Class