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
            Refresh()

        Catch ex As Exception
            MessageBox.Show("Fail to update.", "Error")
        End Try

    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        ChangePassword.ShowDialog()
    End Sub

    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
        'Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        'Dim fontSubHeader As New Font("Calibri", 12)
        'Dim fontBody As New Font("Consolas", 10)

        'Dim header As String = "Login Report"
        'Dim subHeader As String = String.Format(
        '    "Printed on {0:yyyy-MMMM-dd hh:mm:ss tt}" & vbNewLine &
        '    "Prepared by Lee", DateTime.Now
        '    )

        'Dim body As New StringBuilder()
        'body.AppendLine("No   Sign In Date     Sign Out Date")
        'body.AppendLine("--  ---------------  ----------------")

        'Dim cnt As Integer = 0
        'Dim parts() As String
        'For Each item In lstStudent.Items
        '    cnt += 1
        '    parts = CStr(item).Split(CChar(vbTab))
        '    body.AppendFormat("{0,2}  {1,10}  {2,-30}" & vbNewLine, cnt, parts(0), parts(1))
        'Next
        'body.AppendLine()
        'body.AppendFormat("{0,2} record(s)", cnt)

        'With e.Graphics
        '    .DrawImage(My.Resources.Erika, 0, 0, 80, 100)
        '    .DrawString(header, fontHeader, Brushes.Purple, 100, 0)
        '    .DrawString(subHeader, fontSubHeader, Brushes.Black, 100, 40)
        '    .DrawString(body.ToString(), fontBody, Brushes.Black, 0, 120)
        'End With
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        dlgPreview.Document = doc
        dlgPreview.ShowDialog(Me)
    End Sub
End Class