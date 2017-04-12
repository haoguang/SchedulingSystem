<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserProfile
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
        Me.picPicture = New System.Windows.Forms.PictureBox()
        Me.btnImage = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mskNickname = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radNotSpecified = New System.Windows.Forms.RadioButton()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.picPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picPicture
        '
        Me.picPicture.Location = New System.Drawing.Point(16, 15)
        Me.picPicture.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picPicture.Name = "picPicture"
        Me.picPicture.Size = New System.Drawing.Size(141, 155)
        Me.picPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPicture.TabIndex = 0
        Me.picPicture.TabStop = False
        '
        'btnImage
        '
        Me.btnImage.Location = New System.Drawing.Point(16, 177)
        Me.btnImage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnImage.Name = "btnImage"
        Me.btnImage.Size = New System.Drawing.Size(127, 31)
        Me.btnImage.TabIndex = 1
        Me.btnImage.Text = "Change Picture"
        Me.btnImage.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(208, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(297, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(208, 71)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Nickname :"
        '
        'mskNickname
        '
        Me.mskNickname.Location = New System.Drawing.Point(301, 68)
        Me.mskNickname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mskNickname.Name = "mskNickname"
        Me.mskNickname.Size = New System.Drawing.Size(132, 22)
        Me.mskNickname.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radNotSpecified)
        Me.GroupBox1.Controls.Add(Me.radFemale)
        Me.GroupBox1.Controls.Add(Me.radMale)
        Me.GroupBox1.Location = New System.Drawing.Point(212, 100)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(297, 52)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gender"
        '
        'radNotSpecified
        '
        Me.radNotSpecified.AutoSize = True
        Me.radNotSpecified.Location = New System.Drawing.Point(167, 23)
        Me.radNotSpecified.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radNotSpecified.Name = "radNotSpecified"
        Me.radNotSpecified.Size = New System.Drawing.Size(113, 21)
        Me.radNotSpecified.TabIndex = 3
        Me.radNotSpecified.TabStop = True
        Me.radNotSpecified.Text = "&Not Specified"
        Me.radNotSpecified.UseVisualStyleBackColor = True
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(80, 23)
        Me.radFemale.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(75, 21)
        Me.radFemale.TabIndex = 2
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "&Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(8, 23)
        Me.radMale.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(59, 21)
        Me.radMale.TabIndex = 1
        Me.radMale.TabStop = True
        Me.radMale.Text = "&Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(169, 166)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "&Contact Number :"
        '
        'UserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 484)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mskNickname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnImage)
        Me.Controls.Add(Me.picPicture)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "UserProfile"
        Me.Text = "UserProfile"
        CType(Me.picPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPicture As PictureBox
    Friend WithEvents btnImage As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents mskNickname As MaskedTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radNotSpecified As RadioButton
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents Label4 As Label
End Class
