<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtOccupation = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mskContactNumber = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnPicture = New System.Windows.Forms.Button()
        Me.picPicture = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtHobby = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.ofdBrowse = New System.Windows.Forms.OpenFileDialog()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboQuestion = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.txtNickname = New System.Windows.Forms.TextBox()
        CType(Me.picPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Username :"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(125, 10)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtUsername.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Password :"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(125, 42)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Confirm Password :"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(125, 72)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtConfirmPassword.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "&Email :"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(125, 214)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(156, 20)
        Me.txtEmail.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "&Occupation :"
        '
        'txtOccupation
        '
        Me.txtOccupation.Location = New System.Drawing.Point(125, 245)
        Me.txtOccupation.Name = "txtOccupation"
        Me.txtOccupation.Size = New System.Drawing.Size(100, 20)
        Me.txtOccupation.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Con&tact Number :"
        '
        'mskContactNumber
        '
        Me.mskContactNumber.Location = New System.Drawing.Point(125, 182)
        Me.mskContactNumber.Mask = "0000000000"
        Me.mskContactNumber.Name = "mskContactNumber"
        Me.mskContactNumber.Size = New System.Drawing.Size(100, 20)
        Me.mskContactNumber.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "P&rofile Picture :"
        '
        'btnPicture
        '
        Me.btnPicture.Location = New System.Drawing.Point(125, 282)
        Me.btnPicture.Name = "btnPicture"
        Me.btnPicture.Size = New System.Drawing.Size(100, 23)
        Me.btnPicture.TabIndex = 20
        Me.btnPicture.Text = "Browse &Image"
        Me.btnPicture.UseVisualStyleBackColor = True
        '
        'picPicture
        '
        Me.picPicture.Location = New System.Drawing.Point(125, 311)
        Me.picPicture.Name = "picPicture"
        Me.picPicture.Size = New System.Drawing.Size(100, 90)
        Me.picPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPicture.TabIndex = 14
        Me.picPicture.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(48, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "&Nickname :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radFemale)
        Me.GroupBox1.Controls.Add(Me.radMale)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 45)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(167, 18)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(59, 17)
        Me.radFemale.TabIndex = 11
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "&Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(113, 18)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(48, 17)
        Me.radMale.TabIndex = 10
        Me.radMale.TabStop = True
        Me.radMale.Text = "&Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(49, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "&Gender :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(65, 410)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "&Hobby :"
        '
        'txtHobby
        '
        Me.txtHobby.Location = New System.Drawing.Point(125, 407)
        Me.txtHobby.Name = "txtHobby"
        Me.txtHobby.Size = New System.Drawing.Size(100, 20)
        Me.txtHobby.TabIndex = 22
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(125, 511)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnRegister.TabIndex = 27
        Me.btnRegister.Text = "&Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'ofdBrowse
        '
        Me.ofdBrowse.FileName = "OpenFileDialog1"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(206, 511)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 28
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 443)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Security &Question :"
        '
        'cboQuestion
        '
        Me.cboQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQuestion.FormattingEnabled = True
        Me.cboQuestion.Items.AddRange(New Object() {"Where is your mom's hometown ?", "What is your favorite food ?", "What is the name of your first pet ?", "Who are your best friend ?"})
        Me.cboQuestion.Location = New System.Drawing.Point(125, 440)
        Me.cboQuestion.Name = "cboQuestion"
        Me.cboQuestion.Size = New System.Drawing.Size(196, 21)
        Me.cboQuestion.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 478)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Security &Answer :"
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(125, 475)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(100, 20)
        Me.txtAnswer.TabIndex = 26
        '
        'txtNickname
        '
        Me.txtNickname.Location = New System.Drawing.Point(125, 105)
        Me.txtNickname.Name = "txtNickname"
        Me.txtNickname.Size = New System.Drawing.Size(100, 20)
        Me.txtNickname.TabIndex = 7
        '
        'Registration
        '
        Me.AcceptButton = Me.btnRegister
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 544)
        Me.Controls.Add(Me.txtNickname)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboQuestion)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtHobby)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.picPicture)
        Me.Controls.Add(Me.btnPicture)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.mskContactNumber)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtOccupation)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration"
        CType(Me.picPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtOccupation As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents mskContactNumber As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnPicture As Button
    Friend WithEvents picPicture As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents txtHobby As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents ofdBrowse As OpenFileDialog
    Friend WithEvents btnClear As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cboQuestion As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents txtNickname As TextBox
End Class
