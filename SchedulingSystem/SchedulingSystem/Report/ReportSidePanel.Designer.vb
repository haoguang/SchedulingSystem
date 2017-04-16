<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportSidePanel
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
        Me.btnMemberReport = New System.Windows.Forms.Button()
        Me.btnScheduleReport = New System.Windows.Forms.Button()
        Me.btnAppointmentReport = New System.Windows.Forms.Button()
        Me.btnNotificationReport = New System.Windows.Forms.Button()
        Me.btnFriendReport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMemberReport
        '
        Me.btnMemberReport.BackColor = System.Drawing.Color.Transparent
        Me.btnMemberReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMemberReport.FlatAppearance.BorderSize = 0
        Me.btnMemberReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMemberReport.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemberReport.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnMemberReport.Location = New System.Drawing.Point(0, 0)
        Me.btnMemberReport.Name = "btnMemberReport"
        Me.btnMemberReport.Size = New System.Drawing.Size(300, 62)
        Me.btnMemberReport.TabIndex = 1
        Me.btnMemberReport.Text = "Member Report"
        Me.btnMemberReport.UseVisualStyleBackColor = False
        '
        'btnScheduleReport
        '
        Me.btnScheduleReport.BackColor = System.Drawing.Color.Transparent
        Me.btnScheduleReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnScheduleReport.FlatAppearance.BorderSize = 0
        Me.btnScheduleReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScheduleReport.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScheduleReport.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnScheduleReport.Location = New System.Drawing.Point(0, 62)
        Me.btnScheduleReport.Name = "btnScheduleReport"
        Me.btnScheduleReport.Size = New System.Drawing.Size(300, 62)
        Me.btnScheduleReport.TabIndex = 2
        Me.btnScheduleReport.Text = "Schedule Report"
        Me.btnScheduleReport.UseVisualStyleBackColor = False
        '
        'btnAppointmentReport
        '
        Me.btnAppointmentReport.BackColor = System.Drawing.Color.Transparent
        Me.btnAppointmentReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAppointmentReport.FlatAppearance.BorderSize = 0
        Me.btnAppointmentReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppointmentReport.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppointmentReport.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnAppointmentReport.Location = New System.Drawing.Point(0, 124)
        Me.btnAppointmentReport.Name = "btnAppointmentReport"
        Me.btnAppointmentReport.Size = New System.Drawing.Size(300, 62)
        Me.btnAppointmentReport.TabIndex = 3
        Me.btnAppointmentReport.Text = "Appointment Report"
        Me.btnAppointmentReport.UseVisualStyleBackColor = False
        '
        'btnNotificationReport
        '
        Me.btnNotificationReport.BackColor = System.Drawing.Color.Transparent
        Me.btnNotificationReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNotificationReport.FlatAppearance.BorderSize = 0
        Me.btnNotificationReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotificationReport.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotificationReport.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnNotificationReport.Location = New System.Drawing.Point(0, 186)
        Me.btnNotificationReport.Name = "btnNotificationReport"
        Me.btnNotificationReport.Size = New System.Drawing.Size(300, 62)
        Me.btnNotificationReport.TabIndex = 4
        Me.btnNotificationReport.Text = "Notification Report"
        Me.btnNotificationReport.UseVisualStyleBackColor = False
        '
        'btnFriendReport
        '
        Me.btnFriendReport.BackColor = System.Drawing.Color.Transparent
        Me.btnFriendReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFriendReport.FlatAppearance.BorderSize = 0
        Me.btnFriendReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFriendReport.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFriendReport.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnFriendReport.Location = New System.Drawing.Point(0, 248)
        Me.btnFriendReport.Name = "btnFriendReport"
        Me.btnFriendReport.Size = New System.Drawing.Size(300, 62)
        Me.btnFriendReport.TabIndex = 5
        Me.btnFriendReport.Text = "Friend Report"
        Me.btnFriendReport.UseVisualStyleBackColor = False
        '
        'ReportSidePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnFriendReport)
        Me.Controls.Add(Me.btnNotificationReport)
        Me.Controls.Add(Me.btnAppointmentReport)
        Me.Controls.Add(Me.btnScheduleReport)
        Me.Controls.Add(Me.btnMemberReport)
        Me.Name = "ReportSidePanel"
        Me.Size = New System.Drawing.Size(300, 372)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMemberReport As Button
    Friend WithEvents btnScheduleReport As Button
    Friend WithEvents btnAppointmentReport As Button
    Friend WithEvents btnNotificationReport As Button
    Friend WithEvents btnFriendReport As Button
End Class
