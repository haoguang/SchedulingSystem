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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblFriendName = New System.Windows.Forms.Label()
        Me.lblHobby = New System.Windows.Forms.Label()
        Me.lblFriendHobby = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(79, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 121)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        'FriendNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblFriendHobby)
        Me.Controls.Add(Me.lblHobby)
        Me.Controls.Add(Me.lblFriendName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "FriendNotification"
        Me.Text = "FriendNotification"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblFriendName As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents lblFriendHobby As Label
End Class
