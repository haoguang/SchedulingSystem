Imports System.Text
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Data.Linq

Public Class Registration

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        Dim nickname As String = txtNickname.Text
        Dim contact As String = If(mskContactNumber.MaskCompleted, mskContactNumber.Text, "")
        Dim gender As String
        Dim question As String

        'Validation
        If txtUsername.Text = "" Then
            err.AppendLine("- Please enter username.")
            ctr = If(ctr, txtUsername)
        End If

        If txtPassword.Text = "" Then
            err.AppendLine("- Please enter password.")
            ctr = If(ctr, txtPassword)
        End If

        If txtConfirmPassword.Text = "" Then
            err.AppendLine("- Please enter confirm password.")
            ctr = If(ctr, txtConfirmPassword)
        End If

        If txtConfirmPassword.Text.Equals(txtPassword.Text) = False Then
            err.AppendLine("- Confirm password not match.")
            ctr = If(ctr, txtConfirmPassword)
        End If

        If nickname = "" Then
            err.AppendLine("- Please enter nickname.")
            ctr = If(ctr, txtNickname)
        End If

        If radMale.Checked = True Then
            gender = "M"
        ElseIf radFemale.Checked = True Then
            gender = "F"
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

        If cboQuestion.SelectedIndex = -1 Then
            err.AppendLine("- Please select security question.")
            ctr = If(ctr, cboQuestion)
        End If

        If txtAnswer.Text = "" Then
            err.AppendLine("- Please enter security answer.")
            ctr = If(ctr, txtAnswer)
        End If

        'show error message
        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr.Focus()
            Return
        End If

        'save image
        Dim imgData As Byte()
        imgData = ImgToByteArray(picPicture.Image, ImageFormat.Jpeg)

        'store all info
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
        m.SecurityQuestion = cboQuestion.SelectedItem.ToString()
        m.SecurityAnswer = txtAnswer.Text

        'database
        Dim db As New ScheduleDBDataContext()
        Dim user As Table(Of Member) = db.GetTable(Of Member)()

        'check duplicate
        Dim query = From mem In user
                    Where mem.Username = m.Username
                    Select mem
        'if exist
        If query.Count > 0 Then
            MessageBox.Show("Username exist. Please user other username.")
        Else
            'insert record in database
            db.Members.InsertOnSubmit(m)
            db.SubmitChanges()

            MessageBox.Show("Register Successful :D", "Congratulation")
            UserLogin.Show()
            Me.Close()
        End If

    End Sub

    Private Sub btnPicture_Click(sender As Object, e As EventArgs) Handles btnPicture.Click
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


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear all text
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtConfirmPassword.Text = ""
        txtEmail.Text = ""
        txtHobby.Text = ""
        txtOccupation.Text = ""
        mskContactNumber.Text = ""
        txtNickname.Text = ""
        radMale.Checked = False
        radFemale.Checked = False
        picPicture.Image = Nothing
    End Sub
End Class