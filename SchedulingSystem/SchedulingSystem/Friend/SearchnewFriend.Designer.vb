<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearchnewFriend
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.DGVS = New System.Windows.Forms.DataGridView()
        Me.R_ID = New System.Windows.Forms.RadioButton()
        Me.R_Hobby = New System.Windows.Forms.RadioButton()
        Me.R_Name = New System.Windows.Forms.RadioButton()
        Me.btn_addfriend = New System.Windows.Forms.Button()
        CType(Me.DGVS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtsearch
        '
        Me.txtsearch.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.ForeColor = System.Drawing.Color.DarkCyan
        Me.txtsearch.Location = New System.Drawing.Point(42, 24)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsearch.Multiline = True
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(829, 31)
        Me.txtsearch.TabIndex = 5
        '
        'DGVS
        '
        Me.DGVS.AllowUserToAddRows = False
        Me.DGVS.AllowUserToDeleteRows = False
        Me.DGVS.AllowUserToResizeColumns = False
        Me.DGVS.AllowUserToResizeRows = False
        Me.DGVS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVS.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGVS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DGVS.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DGVS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVS.ColumnHeadersVisible = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVS.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGVS.Location = New System.Drawing.Point(42, 96)
        Me.DGVS.MultiSelect = False
        Me.DGVS.Name = "DGVS"
        Me.DGVS.ReadOnly = True
        Me.DGVS.RowHeadersVisible = False
        Me.DGVS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Lime
        Me.DGVS.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVS.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGVS.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVS.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVS.RowTemplate.Height = 100
        Me.DGVS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVS.Size = New System.Drawing.Size(829, 437)
        Me.DGVS.TabIndex = 6
        '
        'R_ID
        '
        Me.R_ID.AutoSize = True
        Me.R_ID.Location = New System.Drawing.Point(631, 62)
        Me.R_ID.Name = "R_ID"
        Me.R_ID.Size = New System.Drawing.Size(50, 28)
        Me.R_ID.TabIndex = 7
        Me.R_ID.TabStop = True
        Me.R_ID.Text = "&ID"
        Me.R_ID.UseVisualStyleBackColor = True
        '
        'R_Hobby
        '
        Me.R_Hobby.AutoSize = True
        Me.R_Hobby.Location = New System.Drawing.Point(779, 62)
        Me.R_Hobby.Name = "R_Hobby"
        Me.R_Hobby.Size = New System.Drawing.Size(92, 28)
        Me.R_Hobby.TabIndex = 8
        Me.R_Hobby.TabStop = True
        Me.R_Hobby.Text = "&Hobby"
        Me.R_Hobby.UseVisualStyleBackColor = True
        '
        'R_Name
        '
        Me.R_Name.AutoSize = True
        Me.R_Name.Location = New System.Drawing.Point(687, 62)
        Me.R_Name.Name = "R_Name"
        Me.R_Name.Size = New System.Drawing.Size(86, 28)
        Me.R_Name.TabIndex = 9
        Me.R_Name.TabStop = True
        Me.R_Name.Text = "&Name"
        Me.R_Name.UseVisualStyleBackColor = True
        '
        'btn_addfriend
        '
        Me.btn_addfriend.Location = New System.Drawing.Point(758, 554)
        Me.btn_addfriend.Name = "btn_addfriend"
        Me.btn_addfriend.Size = New System.Drawing.Size(113, 39)
        Me.btn_addfriend.TabIndex = 10
        Me.btn_addfriend.Text = "Add Friend"
        Me.btn_addfriend.UseVisualStyleBackColor = True
        '
        'SearchnewFriend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_addfriend)
        Me.Controls.Add(Me.R_Name)
        Me.Controls.Add(Me.R_Hobby)
        Me.Controls.Add(Me.R_ID)
        Me.Controls.Add(Me.DGVS)
        Me.Controls.Add(Me.txtsearch)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkCyan
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SearchnewFriend"
        Me.Size = New System.Drawing.Size(920, 666)
        CType(Me.DGVS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtsearch As TextBox
    Friend WithEvents DGVS As DataGridView
    Friend WithEvents R_ID As RadioButton
    Friend WithEvents R_Hobby As RadioButton
    Friend WithEvents R_Name As RadioButton
    Friend WithEvents btn_addfriend As Button
End Class
