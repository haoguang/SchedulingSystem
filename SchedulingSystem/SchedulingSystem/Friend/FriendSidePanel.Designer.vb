<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FriendSidePanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnFriend = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.DGVF = New System.Windows.Forms.DataGridView()
        CType(Me.DGVF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFriend
        '
        Me.btnFriend.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnFriend.BackgroundImage = Global.SchedulingSystem.My.Resources.Resources.add_user_32
        Me.btnFriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFriend.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFriend.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnFriend.Location = New System.Drawing.Point(297, 0)
        Me.btnFriend.Name = "btnFriend"
        Me.btnFriend.Size = New System.Drawing.Size(100, 40)
        Me.btnFriend.TabIndex = 0
        Me.btnFriend.UseVisualStyleBackColor = False
        '
        'txtsearch
        '
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(3, 3)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(294, 34)
        Me.txtsearch.TabIndex = 3
        '
        'DGVF
        '
        Me.DGVF.AllowUserToAddRows = False
        Me.DGVF.AllowUserToDeleteRows = False
        Me.DGVF.AllowUserToResizeColumns = False
        Me.DGVF.AllowUserToResizeRows = False
        Me.DGVF.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DGVF.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.DGVF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVF.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVF.ColumnHeadersVisible = False
        Me.DGVF.GridColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.DGVF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DGVF.Location = New System.Drawing.Point(0, 39)
        Me.DGVF.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVF.MultiSelect = False
        Me.DGVF.Name = "DGVF"
        Me.DGVF.ReadOnly = True
        Me.DGVF.RowHeadersVisible = False
        Me.DGVF.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGVF.RowTemplate.Height = 50
        Me.DGVF.RowTemplate.ReadOnly = True
        Me.DGVF.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVF.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGVF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVF.ShowEditingIcon = False
        Me.DGVF.Size = New System.Drawing.Size(396, 426)
        Me.DGVF.TabIndex = 4
        '
        'FriendSidePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DGVF)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.btnFriend)
        Me.Name = "FriendSidePanel"
        Me.Size = New System.Drawing.Size(400, 465)
        CType(Me.DGVF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFriend As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents DGVF As DataGridView
End Class
