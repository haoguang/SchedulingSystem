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
        Me.btnFriend.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFriend.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnFriend.Location = New System.Drawing.Point(303, 3)
        Me.btnFriend.Name = "btnFriend"
        Me.btnFriend.Size = New System.Drawing.Size(97, 37)
        Me.btnFriend.TabIndex = 0
        Me.btnFriend.Text = "+"
        Me.btnFriend.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(3, 3)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(297, 34)
        Me.txtsearch.TabIndex = 3
        '
        'DGVF
        '
        Me.DGVF.AllowUserToAddRows = False
        Me.DGVF.AllowUserToDeleteRows = False
        Me.DGVF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVF.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DGVF.Location = New System.Drawing.Point(3, 85)
        Me.DGVF.Name = "DGVF"
        Me.DGVF.ReadOnly = True
        Me.DGVF.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGVF.RowTemplate.Height = 24
        Me.DGVF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVF.Size = New System.Drawing.Size(397, 150)
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
