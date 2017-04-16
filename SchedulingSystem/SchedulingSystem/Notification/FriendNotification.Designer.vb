<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FriendNotification
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
        Me.picUser = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblFriendName = New System.Windows.Forms.Label()
        Me.lblHobby = New System.Windows.Forms.Label()
        Me.lblFriendHobby = New System.Windows.Forms.Label()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnReject = New System.Windows.Forms.Button()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picUser
        '
        Me.picUser.Location = New System.Drawing.Point(79, 12)
        Me.picUser.Name = "picUser"
        Me.picUser.Size = New System.Drawing.Size(127, 121)
        Me.picUser.TabIndex = 0
        Me.picUser.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(65, 152)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(57, 15)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name : "
        '
        'lblFriendName
        '
        Me.lblFriendName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFriendName.Location = New System.Drawing.Point(128, 145)
        Me.lblFriendName.Name = "lblFriendName"
        Me.lblFriendName.Size = New System.Drawing.Size(131, 22)
        Me.lblFriendName.TabIndex = 2
        '
        'lblHobby
        '
        Me.lblHobby.AutoSize = True
        Me.lblHobby.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHobby.Location = New System.Drawing.Point(65, 193)
        Me.lblHobby.Name = "lblHobby"
        Me.lblHobby.Size = New System.Drawing.Size(59, 15)
        Me.lblHobby.TabIndex = 3
        Me.lblHobby.Text = "Hobby : "
        '
        'lblFriendHobby
        '
        Me.lblFriendHobby.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFriendHobby.Location = New System.Drawing.Point(128, 184)
        Me.lblFriendHobby.Name = "lblFriendHobby"
        Me.lblFriendHobby.Size = New System.Drawing.Size(131, 24)
        Me.lblFriendHobby.TabIndex = 4
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(47, 239)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(75, 23)
        Me.btnAccept.TabIndex = 5
        Me.btnAccept.Text = "&Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnReject
        '
        Me.btnReject.Location = New System.Drawing.Point(148, 239)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(75, 23)
        Me.btnReject.TabIndex = 6
        Me.btnReject.Text = "&Reject"
        Me.btnReject.UseVisualStyleBackColor = True
        '
        'FriendNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 274)
        Me.Controls.Add(Me.btnReject)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.lblFriendHobby)
        Me.Controls.Add(Me.lblHobby)
        Me.Controls.Add(Me.lblFriendName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.picUser)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 313)
        Me.MinimumSize = New System.Drawing.Size(300, 313)
        Me.Name = "FriendNotification"
        Me.Text = "Friend Notification"
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picUser As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblFriendName As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents lblFriendHobby As Label
    Friend WithEvents btnAccept As Button
    Friend WithEvents btnReject As Button
End Class
