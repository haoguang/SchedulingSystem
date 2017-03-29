<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FriendSidePanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnFriend = New System.Windows.Forms.Button()
        Me.cbostatus = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.lstfriend = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnFriend
        '
        Me.btnFriend.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFriend.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnFriend.Location = New System.Drawing.Point(-10, 0)
        Me.btnFriend.Name = "btnFriend"
        Me.btnFriend.Size = New System.Drawing.Size(410, 76)
        Me.btnFriend.TabIndex = 0
        Me.btnFriend.Text = "Friend"
        Me.btnFriend.UseVisualStyleBackColor = True
        '
        'cbostatus
        '
        Me.cbostatus.FormattingEnabled = True
        Me.cbostatus.Location = New System.Drawing.Point(0, 260)
        Me.cbostatus.Name = "cbostatus"
        Me.cbostatus.Size = New System.Drawing.Size(401, 24)
        Me.cbostatus.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnSearch.Location = New System.Drawing.Point(302, 82)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(98, 76)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtsearch.Location = New System.Drawing.Point(0, 82)
        Me.txtsearch.Multiline = True
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(297, 76)
        Me.txtsearch.TabIndex = 3
        '
        'lstfriend
        '
        Me.lstfriend.FormattingEnabled = True
        Me.lstfriend.ItemHeight = 16
        Me.lstfriend.Location = New System.Drawing.Point(0, 170)
        Me.lstfriend.Name = "lstfriend"
        Me.lstfriend.Size = New System.Drawing.Size(400, 68)
        Me.lstfriend.TabIndex = 4
        '
        'SidePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lstfriend)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.cbostatus)
        Me.Controls.Add(Me.btnFriend)
        Me.Name = "SidePanel"
        Me.Size = New System.Drawing.Size(402, 449)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFriend As Button
    Friend WithEvents cbostatus As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents lstfriend As ListBox
End Class
