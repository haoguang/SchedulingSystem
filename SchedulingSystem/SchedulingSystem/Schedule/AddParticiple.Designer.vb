<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddParticiple
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddParticiple))
        Me.tbcParticipleAdd = New System.Windows.Forms.TabControl()
        Me.tbpFriend = New System.Windows.Forms.TabPage()
        Me.dgvAddUsers = New System.Windows.Forms.DataGridView()
        Me.txtSearchFriend = New System.Windows.Forms.TextBox()
        Me.tbpPublic = New System.Windows.Forms.TabPage()
        Me.dgvPublic = New System.Windows.Forms.DataGridView()
        Me.dgvPublicUserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPublicUserPicture = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dgvPublicName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPublicAddButton = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txtSearchPublic = New System.Windows.Forms.TextBox()
        Me.dgvAddUsersID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvAddUsersProPic = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dgvAddUsersName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvAddUsersButton = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tbcParticipleAdd.SuspendLayout()
        Me.tbpFriend.SuspendLayout()
        CType(Me.dgvAddUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpPublic.SuspendLayout()
        CType(Me.dgvPublic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcParticipleAdd
        '
        Me.tbcParticipleAdd.Controls.Add(Me.tbpFriend)
        Me.tbcParticipleAdd.Controls.Add(Me.tbpPublic)
        Me.tbcParticipleAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcParticipleAdd.ItemSize = New System.Drawing.Size(100, 25)
        Me.tbcParticipleAdd.Location = New System.Drawing.Point(0, 0)
        Me.tbcParticipleAdd.Name = "tbcParticipleAdd"
        Me.tbcParticipleAdd.SelectedIndex = 0
        Me.tbcParticipleAdd.Size = New System.Drawing.Size(298, 326)
        Me.tbcParticipleAdd.TabIndex = 0
        '
        'tbpFriend
        '
        Me.tbpFriend.Controls.Add(Me.dgvAddUsers)
        Me.tbpFriend.Controls.Add(Me.txtSearchFriend)
        Me.tbpFriend.Location = New System.Drawing.Point(4, 29)
        Me.tbpFriend.Name = "tbpFriend"
        Me.tbpFriend.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpFriend.Size = New System.Drawing.Size(290, 293)
        Me.tbpFriend.TabIndex = 0
        Me.tbpFriend.Text = "Friend"
        Me.tbpFriend.UseVisualStyleBackColor = True
        '
        'dgvAddUsers
        '
        Me.dgvAddUsers.AllowUserToAddRows = False
        Me.dgvAddUsers.AllowUserToDeleteRows = False
        Me.dgvAddUsers.AllowUserToResizeColumns = False
        Me.dgvAddUsers.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.dgvAddUsers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAddUsers.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.dgvAddUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvAddUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAddUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAddUsers.ColumnHeadersVisible = False
        Me.dgvAddUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvAddUsersID, Me.dgvAddUsersProPic, Me.dgvAddUsersName, Me.dgvAddUsersButton})
        Me.dgvAddUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAddUsers.GridColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.dgvAddUsers.Location = New System.Drawing.Point(3, 23)
        Me.dgvAddUsers.MultiSelect = False
        Me.dgvAddUsers.Name = "dgvAddUsers"
        Me.dgvAddUsers.ReadOnly = True
        Me.dgvAddUsers.RowHeadersVisible = False
        Me.dgvAddUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvAddUsers.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvAddUsers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgvAddUsers.RowTemplate.Height = 60
        Me.dgvAddUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvAddUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAddUsers.Size = New System.Drawing.Size(284, 267)
        Me.dgvAddUsers.TabIndex = 1
        '
        'txtSearchFriend
        '
        Me.txtSearchFriend.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtSearchFriend.Location = New System.Drawing.Point(3, 3)
        Me.txtSearchFriend.Name = "txtSearchFriend"
        Me.txtSearchFriend.Size = New System.Drawing.Size(284, 20)
        Me.txtSearchFriend.TabIndex = 0
        '
        'tbpPublic
        '
        Me.tbpPublic.Controls.Add(Me.dgvPublic)
        Me.tbpPublic.Controls.Add(Me.txtSearchPublic)
        Me.tbpPublic.Location = New System.Drawing.Point(4, 29)
        Me.tbpPublic.Name = "tbpPublic"
        Me.tbpPublic.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpPublic.Size = New System.Drawing.Size(290, 293)
        Me.tbpPublic.TabIndex = 1
        Me.tbpPublic.Text = "Public"
        Me.tbpPublic.UseVisualStyleBackColor = True
        '
        'dgvPublic
        '
        Me.dgvPublic.AllowUserToAddRows = False
        Me.dgvPublic.AllowUserToDeleteRows = False
        Me.dgvPublic.AllowUserToResizeColumns = False
        Me.dgvPublic.AllowUserToResizeRows = False
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.dgvPublic.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPublic.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.dgvPublic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvPublic.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPublic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPublic.ColumnHeadersVisible = False
        Me.dgvPublic.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvPublicUserID, Me.dgvPublicUserPicture, Me.dgvPublicName, Me.dgvPublicAddButton})
        Me.dgvPublic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPublic.GridColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.dgvPublic.Location = New System.Drawing.Point(3, 23)
        Me.dgvPublic.MultiSelect = False
        Me.dgvPublic.Name = "dgvPublic"
        Me.dgvPublic.ReadOnly = True
        Me.dgvPublic.RowHeadersVisible = False
        Me.dgvPublic.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvPublic.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvPublic.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgvPublic.RowTemplate.Height = 60
        Me.dgvPublic.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvPublic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPublic.Size = New System.Drawing.Size(284, 267)
        Me.dgvPublic.TabIndex = 2
        '
        'dgvPublicUserID
        '
        Me.dgvPublicUserID.HeaderText = "User ID"
        Me.dgvPublicUserID.Name = "dgvPublicUserID"
        Me.dgvPublicUserID.ReadOnly = True
        Me.dgvPublicUserID.Visible = False
        '
        'dgvPublicUserPicture
        '
        Me.dgvPublicUserPicture.HeaderText = "Profile Picture"
        Me.dgvPublicUserPicture.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.dgvPublicUserPicture.Name = "dgvPublicUserPicture"
        Me.dgvPublicUserPicture.ReadOnly = True
        '
        'dgvPublicName
        '
        Me.dgvPublicName.HeaderText = "Name"
        Me.dgvPublicName.Name = "dgvPublicName"
        Me.dgvPublicName.ReadOnly = True
        '
        'dgvPublicAddButton
        '
        Me.dgvPublicAddButton.HeaderText = "Add User"
        Me.dgvPublicAddButton.Name = "dgvPublicAddButton"
        Me.dgvPublicAddButton.ReadOnly = True
        '
        'txtSearchPublic
        '
        Me.txtSearchPublic.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtSearchPublic.Location = New System.Drawing.Point(3, 3)
        Me.txtSearchPublic.Name = "txtSearchPublic"
        Me.txtSearchPublic.Size = New System.Drawing.Size(284, 20)
        Me.txtSearchPublic.TabIndex = 0
        '
        'dgvAddUsersID
        '
        Me.dgvAddUsersID.HeaderText = "User ID"
        Me.dgvAddUsersID.Name = "dgvAddUsersID"
        Me.dgvAddUsersID.ReadOnly = True
        Me.dgvAddUsersID.Visible = False
        '
        'dgvAddUsersProPic
        '
        Me.dgvAddUsersProPic.HeaderText = "Profile Picture"
        Me.dgvAddUsersProPic.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.dgvAddUsersProPic.Name = "dgvAddUsersProPic"
        Me.dgvAddUsersProPic.ReadOnly = True
        Me.dgvAddUsersProPic.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'dgvAddUsersName
        '
        Me.dgvAddUsersName.HeaderText = "Name"
        Me.dgvAddUsersName.Name = "dgvAddUsersName"
        Me.dgvAddUsersName.ReadOnly = True
        '
        'dgvAddUsersButton
        '
        Me.dgvAddUsersButton.HeaderText = "Add User"
        Me.dgvAddUsersButton.Name = "dgvAddUsersButton"
        Me.dgvAddUsersButton.ReadOnly = True
        '
        'AddParticiple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 326)
        Me.Controls.Add(Me.tbcParticipleAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddParticiple"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Participant"
        Me.tbcParticipleAdd.ResumeLayout(False)
        Me.tbpFriend.ResumeLayout(False)
        Me.tbpFriend.PerformLayout()
        CType(Me.dgvAddUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpPublic.ResumeLayout(False)
        Me.tbpPublic.PerformLayout()
        CType(Me.dgvPublic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcParticipleAdd As TabControl
    Friend WithEvents tbpFriend As TabPage
    Friend WithEvents txtSearchFriend As TextBox
    Friend WithEvents tbpPublic As TabPage
    Friend WithEvents dgvAddUsers As DataGridView
    Friend WithEvents txtSearchPublic As TextBox
    Friend WithEvents dgvPublic As DataGridView
    Friend WithEvents dgvPublicUserID As DataGridViewTextBoxColumn
    Friend WithEvents dgvPublicUserPicture As DataGridViewImageColumn
    Friend WithEvents dgvPublicName As DataGridViewTextBoxColumn
    Friend WithEvents dgvPublicAddButton As DataGridViewImageColumn
    Friend WithEvents dgvAddUsersID As DataGridViewTextBoxColumn
    Friend WithEvents dgvAddUsersProPic As DataGridViewImageColumn
    Friend WithEvents dgvAddUsersName As DataGridViewTextBoxColumn
    Friend WithEvents dgvAddUsersButton As DataGridViewImageColumn
End Class
