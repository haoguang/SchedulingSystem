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
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radNotSpecified = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.picPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picPicture
        '
        Me.picPicture.Location = New System.Drawing.Point(12, 12)
        Me.picPicture.Name = "picPicture"
        Me.picPicture.Size = New System.Drawing.Size(106, 126)
        Me.picPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPicture.TabIndex = 0
        Me.picPicture.TabStop = False
        '
        'btnImage
        '
        Me.btnImage.Location = New System.Drawing.Point(12, 144)
        Me.btnImage.Name = "btnImage"
        Me.btnImage.Size = New System.Drawing.Size(95, 25)
        Me.btnImage.TabIndex = 1
        Me.btnImage.Text = "Change Picture"
        Me.btnImage.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(156, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(223, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(156, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Nickname :"
        '
        'mskNickname
        '
        Me.mskNickname.Location = New System.Drawing.Point(226, 55)
        Me.mskNickname.Name = "mskNickname"
        Me.mskNickname.Size = New System.Drawing.Size(100, 20)
        Me.mskNickname.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radNotSpecified)
        Me.GroupBox1.Controls.Add(Me.radFemale)
        Me.GroupBox1.Controls.Add(Me.radMale)
        Me.GroupBox1.Location = New System.Drawing.Point(159, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 42)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gender"
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(6, 19)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(48, 17)
        Me.radMale.TabIndex = 1
        Me.radMale.TabStop = True
        Me.radMale.Text = "&Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(60, 19)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(59, 17)
        Me.radFemale.TabIndex = 2
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "&Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radNotSpecified
        '
        Me.radNotSpecified.AutoSize = True
        Me.radNotSpecified.Location = New System.Drawing.Point(125, 19)
        Me.radNotSpecified.Name = "radNotSpecified"
        Me.radNotSpecified.Size = New System.Drawing.Size(89, 17)
        Me.radNotSpecified.TabIndex = 3
        Me.radNotSpecified.TabStop = True
        Me.radNotSpecified.Text = "&Not Specified"
        Me.radNotSpecified.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(127, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "&Contact Number :"
        '
        'UserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 393)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mskNickname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnImage)
        Me.Controls.Add(Me.picPicture)
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
