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
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.DGVS = New System.Windows.Forms.DataGridView()
        Me.R_ID = New System.Windows.Forms.RadioButton()
        Me.R_Hobby = New System.Windows.Forms.RadioButton()
        Me.R_Name = New System.Windows.Forms.RadioButton()
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
        Me.txtsearch.Size = New System.Drawing.Size(722, 31)
        Me.txtsearch.TabIndex = 5
        '
        'DGVS
        '
        Me.DGVS.AllowUserToAddRows = False
        Me.DGVS.AllowUserToDeleteRows = False
        Me.DGVS.AllowUserToResizeColumns = False
        Me.DGVS.AllowUserToResizeRows = False
        Me.DGVS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVS.Location = New System.Drawing.Point(42, 165)
        Me.DGVS.Name = "DGVS"
        Me.DGVS.ReadOnly = True
        Me.DGVS.RowTemplate.Height = 24
        Me.DGVS.Size = New System.Drawing.Size(722, 211)
        Me.DGVS.TabIndex = 6
        '
        'R_ID
        '
        Me.R_ID.AutoSize = True
        Me.R_ID.Location = New System.Drawing.Point(524, 62)
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
        Me.R_Hobby.Location = New System.Drawing.Point(672, 62)
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
        Me.R_Name.Location = New System.Drawing.Point(580, 62)
        Me.R_Name.Name = "R_Name"
        Me.R_Name.Size = New System.Drawing.Size(86, 28)
        Me.R_Name.TabIndex = 9
        Me.R_Name.TabStop = True
        Me.R_Name.Text = "&Name"
        Me.R_Name.UseVisualStyleBackColor = True
        '
        'SearchnewFriend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
End Class
