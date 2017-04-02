<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DayScheduleViewer
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
        Me.DateDisplayPanel = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.TimelineDisplayPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.timeDisplayPanel = New System.Windows.Forms.Panel()
        Me.activityDisplayPanel = New System.Windows.Forms.Panel()
        Me.DateDisplayPanel.SuspendLayout()
        Me.TimelineDisplayPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateDisplayPanel
        '
        Me.DateDisplayPanel.Controls.Add(Me.lblDate)
        Me.DateDisplayPanel.Controls.Add(Me.btnNext)
        Me.DateDisplayPanel.Controls.Add(Me.btnPrev)
        Me.DateDisplayPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DateDisplayPanel.Location = New System.Drawing.Point(0, 0)
        Me.DateDisplayPanel.Name = "DateDisplayPanel"
        Me.DateDisplayPanel.Size = New System.Drawing.Size(500, 50)
        Me.DateDisplayPanel.TabIndex = 0
        '
        'lblDate
        '
        Me.lblDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDate.Location = New System.Drawing.Point(75, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(350, 50)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Image = Global.SchedulingSystem.My.Resources.Resources.arrow_4_24
        Me.btnNext.Location = New System.Drawing.Point(425, 0)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 50)
        Me.btnNext.TabIndex = 2
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.Transparent
        Me.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrev.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrev.FlatAppearance.BorderSize = 0
        Me.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrev.Image = Global.SchedulingSystem.My.Resources.Resources.arrow_105_24
        Me.btnPrev.Location = New System.Drawing.Point(0, 0)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(75, 50)
        Me.btnPrev.TabIndex = 1
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'TimelineDisplayPanel
        '
        Me.TimelineDisplayPanel.ColumnCount = 2
        Me.TimelineDisplayPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.4!))
        Me.TimelineDisplayPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.6!))
        Me.TimelineDisplayPanel.Controls.Add(Me.timeDisplayPanel, 0, 0)
        Me.TimelineDisplayPanel.Controls.Add(Me.activityDisplayPanel, 1, 0)
        Me.TimelineDisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TimelineDisplayPanel.Location = New System.Drawing.Point(0, 50)
        Me.TimelineDisplayPanel.Name = "TimelineDisplayPanel"
        Me.TimelineDisplayPanel.RowCount = 1
        Me.TimelineDisplayPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TimelineDisplayPanel.Size = New System.Drawing.Size(500, 1250)
        Me.TimelineDisplayPanel.TabIndex = 1
        '
        'timeDisplayPanel
        '
        Me.timeDisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.timeDisplayPanel.Location = New System.Drawing.Point(3, 3)
        Me.timeDisplayPanel.Name = "timeDisplayPanel"
        Me.timeDisplayPanel.Size = New System.Drawing.Size(70, 1244)
        Me.timeDisplayPanel.TabIndex = 0
        '
        'activityDisplayPanel
        '
        Me.activityDisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.activityDisplayPanel.Location = New System.Drawing.Point(79, 3)
        Me.activityDisplayPanel.Name = "activityDisplayPanel"
        Me.activityDisplayPanel.Size = New System.Drawing.Size(418, 1244)
        Me.activityDisplayPanel.TabIndex = 1
        '
        'DayScheduleViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TimelineDisplayPanel)
        Me.Controls.Add(Me.DateDisplayPanel)
        Me.Name = "DayScheduleViewer"
        Me.Size = New System.Drawing.Size(500, 1300)
        Me.DateDisplayPanel.ResumeLayout(False)
        Me.TimelineDisplayPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DateDisplayPanel As Panel
    Friend WithEvents TimelineDisplayPanel As TableLayoutPanel
    Friend WithEvents timeDisplayPanel As Panel
    Friend WithEvents lblDate As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents activityDisplayPanel As Panel
End Class
