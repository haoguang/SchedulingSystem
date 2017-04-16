Imports System.Text
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Data.Linq

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

                Dim gender As String = m.Gender.First

                If gender.Equals("M") Then
                    radMale.Checked = True
                ElseIf gender.Equals("F") Then
                    radFemale.Checked = True
                Else
                    radNotSpecified.Checked = True
                End If

                mskContact.Text = m.ContactNo
                txtEmail.Text = m.Email
                txtHobby.Text = m.Hobby
                txtOccupation.Text = m.Occupation
                lblDateJoined.Text = m.DateJoin.ToShortDateString
            Next

        End If
    End Sub

    Private Sub btnImage_Click(sender As Object, e As EventArgs) Handles btnImage.Click
        'browse file
        ofdBrowse.InitialDirectory = "c:\"
        ofdBrowse.Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        ofdBrowse.FilterIndex = 2
        ofdBrowse.RestoreDirectory = True
        If ofdBrowse.ShowDialog() = DialogResult.OK Then
            If File.Exists(ofdBrowse.FileName) = False Then
                MessageBox.Show("Sorry, The File You Specified Does Not Exist.")
            Else
                picPicture.ImageLocation = ofdBrowse.FileName
            End If
        End If
    End Sub

    Public Shared Function ImgToByteArray(img As Image, imgFormat As Imaging.ImageFormat) As Byte()
        'convert image
        Dim tmpData As Byte()
        Using ms As New MemoryStream()
            img.Save(ms, imgFormat)

            tmpData = ms.ToArray
        End Using
        Return tmpData
    End Function

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        Dim nickname As String = If(mskNickname.MaskCompleted, mskNickname.Text, "")
        Dim contact As String = If(mskContact.MaskCompleted, mskContact.Text, "")
        Dim gender As String

        'Validation
        If nickname = "" Then
            err.AppendLine("- Please enter nickname.")
            ctr = If(ctr, mskNickname)
        End If

        If radMale.Checked Then
            gender = "M"
        ElseIf radFemale.Checked Then
            gender = "F"
        ElseIf radNotSpecified.Checked Then
            gender = "N"

        End If

        If contact = "" Then
            err.AppendLine("- Please enter contact number.")
            ctr = If(ctr, mskContact)
        End If

        If txtEmail.Text = "" Then
            Err.AppendLine("- Please enter email.")
            ctr = If(ctr, txtEmail)
        End If

        If txtOccupation.Text = "" Then
            Err.AppendLine("- Please enter occupation.")
            ctr = If(ctr, txtOccupation)
        End If

        If txtHobby.Text = "" Then
            Err.AppendLine("- Please enter hobby.")
            ctr = If(ctr, txtHobby)
        End If

        'show error message
        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr.Focus()
            Return
        End If
        'convert image
        Dim imgData As Byte()
        imgData = ImgToByteArray(picPicture.Image, ImageFormat.Jpeg)
        'update
        Dim db As New ScheduleDBDataContext
        Dim updateMember = (From m In db.Members
                            Where m.Username = lblUsername.Text).ToList()(0)
        updateMember.Nickname = nickname
        updateMember.Gender = gender
        updateMember.ContactNo = contact
        updateMember.Email = txtEmail.Text
        updateMember.Occupation = txtOccupation.Text
        updateMember.Hobby = txtHobby.Text
        updateMember.Picture = imgData

        Try
            db.SubmitChanges()
            MessageBox.Show("Profile Updated.", "Congratulation")
            LoginSession.nickname = nickname
            LoginSession.email = txtEmail.Text
            LoginSession.picture = picPicture.Image
            MainForm.btnUserInfo.lblName.Text = nickname
            MainForm.btnUserInfo.lblUserEmail.Text = email
            MainForm.btnUserInfo.pcbProfilePic.Image = picture
            Refresh()

        Catch ex As Exception
            MessageBox.Show("Fail to update.", "Error")
        End Try

    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        ChangePassword.ShowDialog()
    End Sub

End Class