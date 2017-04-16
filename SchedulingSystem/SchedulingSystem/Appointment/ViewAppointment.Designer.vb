<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewAppointment
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
        Me.gbSelection = New System.Windows.Forms.GroupBox()
        Me.rbCancel = New System.Windows.Forms.RadioButton()
        Me.rbPending = New System.Windows.Forms.RadioButton()
        Me.rbOngoing = New System.Windows.Forms.RadioButton()
        Me.rbHistory = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvRecord = New System.Windows.Forms.DataGridView()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.gbSelection.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbSelection
        '
        Me.gbSelection.Controls.Add(Me.rbCancel)
        Me.gbSelection.Controls.Add(Me.rbPending)
        Me.gbSelection.Controls.Add(Me.rbOngoing)
        Me.gbSelection.Controls.Add(Me.rbHistory)
        Me.gbSelection.Font = New System.Drawing.Font("NSimSun", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSelection.ForeColor = System.Drawing.Color.DarkGreen
        Me.gbSelection.Location = New System.Drawing.Point(39, 100)
        Me.gbSelection.Name = "gbSelection"
        Me.gbSelection.Size = New System.Drawing.Size(788, 92)
        Me.gbSelection.TabIndex = 0
        Me.gbSelection.TabStop = False
        Me.gbSelection.Text = "Selection"
        '
        'rbCancel
        '
        Me.rbCancel.AutoSize = True
        Me.rbCancel.Location = New System.Drawing.Point(575, 39)
        Me.rbCancel.Name = "rbCancel"
        Me.rbCancel.Size = New System.Drawing.Size(80, 20)
        Me.rbCancel.TabIndex = 3
        Me.rbCancel.TabStop = True
        Me.rbCancel.Text = "Cancel"
        Me.rbCancel.UseVisualStyleBackColor = True
        '
        'rbPending
        '
        Me.rbPending.AutoSize = True
        Me.rbPending.Location = New System.Drawing.Point(406, 39)
        Me.rbPending.Name = "rbPending"
        Me.rbPending.Size = New System.Drawing.Size(89, 20)
        Me.rbPending.TabIndex = 2
        Me.rbPending.TabStop = True
        Me.rbPending.Text = "Pending"
        Me.rbPending.UseVisualStyleBackColor = True
        '
        'rbOngoing
        '
        Me.rbOngoing.AutoSize = True
        Me.rbOngoing.Location = New System.Drawing.Point(209, 39)
        Me.rbOngoing.Name = "rbOngoing"
        Me.rbOngoing.Size = New System.Drawing.Size(89, 20)
        Me.rbOngoing.TabIndex = 1
        Me.rbOngoing.TabStop = True
        Me.rbOngoing.Text = "Ongoing"
        Me.rbOngoing.UseVisualStyleBackColor = True
        '
        'rbHistory
        '
        Me.rbHistory.AutoSize = True
        Me.rbHistory.Location = New System.Drawing.Point(24, 39)
        Me.rbHistory.Name = "rbHistory"
        Me.rbHistory.Size = New System.Drawing.Size(89, 20)
        Me.rbHistory.TabIndex = 0
        Me.rbHistory.TabStop = True
        Me.rbHistory.Text = "History"
        Me.rbHistory.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dgvRecord)
        Me.GroupBox1.Font = New System.Drawing.Font("NSimSun", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox1.Location = New System.Drawing.Point(39, 218)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(833, 282)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Record"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(191, 42)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(119, 26)
        Me.txtTitle.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search by &Title :"
        '
        'dgvRecord
        '
        Me.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecord.Location = New System.Drawing.Point(24, 83)
        Me.dgvRecord.Name = "dgvRecord"
        Me.dgvRecord.Size = New System.Drawing.Size(729, 150)
        Me.dgvRecord.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("NSimSun", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblTitle.Location = New System.Drawing.Point(39, 41)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(329, 43)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "View Appointment Record"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ViewAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbSelection)
        Me.Name = "ViewAppointment"
        Me.Size = New System.Drawing.Size(900, 572)
        Me.gbSelection.ResumeLayout(False)
        Me.gbSelection.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbSelection As GroupBox
    Friend WithEvents rbPending As RadioButton
    Friend WithEvents rbOngoing As RadioButton
    Friend WithEvents rbHistory As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvRecord As DataGridView
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rbCancel As RadioButton
End Class
