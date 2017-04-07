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
        Me.rbPending = New System.Windows.Forms.RadioButton()
        Me.rbOngoing = New System.Windows.Forms.RadioButton()
        Me.rbHistory = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvRecord = New System.Windows.Forms.DataGridView()
        Me.gbSelection.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbSelection
        '
        Me.gbSelection.Controls.Add(Me.rbPending)
        Me.gbSelection.Controls.Add(Me.rbOngoing)
        Me.gbSelection.Controls.Add(Me.rbHistory)
        Me.gbSelection.Location = New System.Drawing.Point(39, 17)
        Me.gbSelection.Name = "gbSelection"
        Me.gbSelection.Size = New System.Drawing.Size(645, 92)
        Me.gbSelection.TabIndex = 0
        Me.gbSelection.TabStop = False
        Me.gbSelection.Text = "Selection"
        '
        'rbPending
        '
        Me.rbPending.AutoSize = True
        Me.rbPending.Location = New System.Drawing.Point(486, 39)
        Me.rbPending.Name = "rbPending"
        Me.rbPending.Size = New System.Drawing.Size(126, 17)
        Me.rbPending.TabIndex = 2
        Me.rbPending.TabStop = True
        Me.rbPending.Text = "Pending Appointment"
        Me.rbPending.UseVisualStyleBackColor = True
        '
        'rbOngoing
        '
        Me.rbOngoing.AutoSize = True
        Me.rbOngoing.Location = New System.Drawing.Point(241, 39)
        Me.rbOngoing.Name = "rbOngoing"
        Me.rbOngoing.Size = New System.Drawing.Size(127, 17)
        Me.rbOngoing.TabIndex = 1
        Me.rbOngoing.TabStop = True
        Me.rbOngoing.Text = "Ongoing Appointment"
        Me.rbOngoing.UseVisualStyleBackColor = True
        '
        'rbHistory
        '
        Me.rbHistory.AutoSize = True
        Me.rbHistory.Location = New System.Drawing.Point(24, 39)
        Me.rbHistory.Name = "rbHistory"
        Me.rbHistory.Size = New System.Drawing.Size(119, 17)
        Me.rbHistory.TabIndex = 0
        Me.rbHistory.TabStop = True
        Me.rbHistory.Text = "Appointment History"
        Me.rbHistory.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvRecord)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(645, 209)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Record"
        '
        'dgvRecord
        '
        Me.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecord.Location = New System.Drawing.Point(24, 31)
        Me.dgvRecord.Name = "dgvRecord"
        Me.dgvRecord.Size = New System.Drawing.Size(600, 150)
        Me.dgvRecord.TabIndex = 0
        '
        'ViewAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbSelection)
        Me.Name = "ViewAppointment"
        Me.Size = New System.Drawing.Size(704, 384)
        Me.gbSelection.ResumeLayout(False)
        Me.gbSelection.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbSelection As GroupBox
    Friend WithEvents rbPending As RadioButton
    Friend WithEvents rbOngoing As RadioButton
    Friend WithEvents rbHistory As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvRecord As DataGridView
End Class
