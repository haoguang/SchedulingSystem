Imports System.Text
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Data.Linq

Public Class Registration

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        Dim nickname As String = If(mskNickname.MaskCompleted, mskNickname.Text, "")
        Dim contact As String = If(mskContactNumber.MaskCompleted, mskContactNumber.Text, "")
        Dim gender As String

        If txtUsername.Text = "" Then
            err.AppendLine("- Please enter username.")
            ctr = If(ctr, txtUsername)
        End If

        If txtPassword.Text = "" Then
            err.AppendLine("- Please enter password.")
            ctr = If(ctr, txtPassword)
        End If

        If txtConfirmPassword.Text.Equals(txtPassword) = True Then
            err.AppendLine("- Confirm password not match.")
            ctr = If(ctr, txtConfirmPassword)
        End If

        If nickname = "" Then
            err.AppendLine("- Please enter nickname.")
            ctr = If(ctr, mskNickname)
        End If

        If radMale.Checked Then
            gender = "Male"
        ElseIf radFemale.Checked Then
            gender = "Female"
        ElseIf radNotSpecified.Checked Then
            gender = "Not Specified"
        Else
            err.AppendLine("- Please select gender.")
            ctr = If(ctr, radMale)
        End If

        If contact = "" Then
            err.AppendLine("- Please enter contact number.")
            ctr = If(ctr, mskContactNumber)
        End If

        If txtEmail.Text = "" Then
            err.AppendLine("- Please enter email.")
            ctr = If(ctr, txtEmail)
        End If

        If txtOccupation.Text = "" Then
            err.AppendLine("- Please enter occupation.")
            ctr = If(ctr, txtOccupation)
        End If

        If picPicture.ImageLocation = "" Then
            err.AppendLine("- Please insert profile picture.")
            ctr = If(ctr, picPicture)
        End If

        If txtHobby.Text = "" Then
            err.AppendLine("- Please enter hobby.")
            ctr = If(ctr, txtHobby)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr.Focus()
            Return
        End If

        Dim imgData As Byte()
        imgData = ImgToByteArray(picPicture.Image, ImageFormat.Jpeg)

        Dim m As New Member()
        m.Username = txtUsername.Text
        m.Password = txtPassword.Text
        m.Occupation = txtOccupation.Text
        m.Hobby = txtHobby.Text
        m.Role = "User"
        m.Picture = imgData
        m.DateJoin = Date.Now()
        m.ContactNo = contact
        m.Nickname = nickname
        m.Gender = gender
        m.Email = txtEmail.Text

        Dim db As New ScheduleDBDataContext()
        db.Members.InsertOnSubmit(m)
        db.SubmitChanges()


    End Sub

    Private Sub btnPicture_Click(sender As Object, e As EventArgs) Handles btnPicture.Click
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
        Dim tmpData As Byte()
        Using ms As New MemoryStream()
            img.Save(ms, imgFormat)

            tmpData = ms.ToArray
        End Using
        Return tmpData
    End Function


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtConfirmPassword.Text = ""
        txtEmail.Text = ""
        txtHobby.Text = ""
        txtOccupation.Text = ""
        mskContactNumber.Text = ""
        mskNickname.Text = ""
        radMale.Checked = False
        radFemale.Checked = False
        radNotSpecified.Checked = False
        picPicture.Image = Nothing
    End Sub

    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New ScheduleDBDataContext
        Dim member As Table(Of Member) = db.GetTable(Of Member)()

        Dim query = From m In member
                    Where m.Username = "haha"
                    Select m

        For Each m In query
            Dim img As Image
            Dim imgByte As Byte() = Nothing

            Dim stream As MemoryStream
            imgByte = CType(m.Picture.ToArray, Byte())
            stream = New MemoryStream(imgByte, 0, imgByte.Length)

            img = Image.FromStream(stream)
            PictureBox1.Image = img

        Next
    End Sub


End Class