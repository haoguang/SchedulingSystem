<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.btnUserInfo = New SchedulingSystem.UserButton()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnFriends = New System.Windows.Forms.Button()
        Me.btnNotification = New System.Windows.Forms.Button()
        Me.btnAppointment = New System.Windows.Forms.Button()
        Me.btnSchedule = New System.Windows.Forms.Button()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.SideContentPanel = New System.Windows.Forms.Panel()
        Me.TimeSidePanel = New System.Windows.Forms.Panel()
        Me.ContentPanel = New System.Windows.Forms.Panel()
        Me.HeaderPanel.SuspendLayout()
        Me.SidePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.btnUserInfo)
        Me.HeaderPanel.Controls.Add(Me.btnReport)
        Me.HeaderPanel.Controls.Add(Me.btnFriends)
        Me.HeaderPanel.Controls.Add(Me.btnNotification)
        Me.HeaderPanel.Controls.Add(Me.btnAppointment)
        Me.HeaderPanel.Controls.Add(Me.btnSchedule)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(1476, 85)
        Me.HeaderPanel.TabIndex = 0
        '
        'btnUserInfo
        '
        Me.btnUserInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUserInfo.Location = New System.Drawing.Point(1143, 0)
        Me.btnUserInfo.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnUserInfo.Name = "btnUserInfo"
        Me.btnUserInfo.Size = New System.Drawing.Size(333, 85)
        Me.btnUserInfo.TabIndex = 4
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnReport.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.SystemColors.Control
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Image)
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.Location = New System.Drawing.Point(892, 0)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.btnReport.Size = New System.Drawing.Size(223, 85)
        Me.btnReport.TabIndex = 3
        Me.btnReport.Text = "  Report"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnFriends
        '
        Me.btnFriends.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnFriends.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnFriends.FlatAppearance.BorderSize = 0
        Me.btnFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFriends.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFriends.ForeColor = System.Drawing.SystemColors.Control
        Me.btnFriends.Image = CType(resources.GetObject("btnFriends.Image"), System.Drawing.Image)
        Me.btnFriends.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFriends.Location = New System.Drawing.Point(669, 0)
        Me.btnFriends.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFriends.Name = "btnFriends"
        Me.btnFriends.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.btnFriends.Size = New System.Drawing.Size(223, 85)
        Me.btnFriends.TabIndex = 2
        Me.btnFriends.Text = "  Friends"
        Me.btnFriends.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFriends.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFriends.UseVisualStyleBackColor = False
        '
        'btnNotification
        '
        Me.btnNotification.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnNotification.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnNotification.FlatAppearance.BorderSize = 0
        Me.btnNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotification.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotification.ForeColor = System.Drawing.SystemColors.Control
        Me.btnNotification.Image = CType(resources.GetObject("btnNotification.Image"), System.Drawing.Image)
        Me.btnNotification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotification.Location = New System.Drawing.Point(446, 0)
        Me.btnNotification.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNotification.Name = "btnNotification"
        Me.btnNotification.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.btnNotification.Size = New System.Drawing.Size(223, 85)
        Me.btnNotification.TabIndex = 2
        Me.btnNotification.Text = "  Notification"
        Me.btnNotification.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNotification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNotification.UseVisualStyleBackColor = False
        '
        'btnAppointment
        '
        Me.btnAppointment.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnAppointment.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAppointment.FlatAppearance.BorderSize = 0
        Me.btnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppointment.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppointment.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAppointment.Image = CType(resources.GetObject("btnAppointment.Image"), System.Drawing.Image)
        Me.btnAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAppointment.Location = New System.Drawing.Point(223, 0)
        Me.btnAppointment.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAppointment.Name = "btnAppointment"
        Me.btnAppointment.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.btnAppointment.Size = New System.Drawing.Size(223, 85)
        Me.btnAppointment.TabIndex = 2
        Me.btnAppointment.Text = "  Appointment"
        Me.btnAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAppointment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAppointment.UseVisualStyleBackColor = False
        '
        'btnSchedule
        '
        Me.btnSchedule.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnSchedule.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSchedule.FlatAppearance.BorderSize = 0
        Me.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSchedule.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSchedule.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSchedule.Image = CType(resources.GetObject("btnSchedule.Image"), System.Drawing.Image)
        Me.btnSchedule.Location = New System.Drawing.Point(0, 0)
        Me.btnSchedule.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSchedule.Name = "btnSchedule"
        Me.btnSchedule.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.btnSchedule.Size = New System.Drawing.Size(223, 85)
        Me.btnSchedule.TabIndex = 2
        Me.btnSchedule.Text = "  Schedule"
        Me.btnSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSchedule.UseVisualStyleBackColor = False
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.SidePanel.Controls.Add(Me.SideContentPanel)
        Me.SidePanel.Controls.Add(Me.TimeSidePanel)
        Me.SidePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SidePanel.Location = New System.Drawing.Point(0, 85)
        Me.SidePanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(400, 662)
        Me.SidePanel.TabIndex = 1
        '
        'SideContentPanel
        '
        Me.SideContentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideContentPanel.Location = New System.Drawing.Point(0, 79)
        Me.SideContentPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SideContentPanel.Name = "SideContentPanel"
        Me.SideContentPanel.Size = New System.Drawing.Size(400, 583)
        Me.SideContentPanel.TabIndex = 1
        '
        'TimeSidePanel
        '
        Me.TimeSidePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TimeSidePanel.Location = New System.Drawing.Point(0, 0)
        Me.TimeSidePanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TimeSidePanel.Name = "TimeSidePanel"
        Me.TimeSidePanel.Size = New System.Drawing.Size(400, 79)
        Me.TimeSidePanel.TabIndex = 0
        '
        'ContentPanel
        '
        Me.ContentPanel.AutoScroll = True
        Me.ContentPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentPanel.Location = New System.Drawing.Point(400, 85)
        Me.ContentPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ContentPanel.Name = "ContentPanel"
        Me.ContentPanel.Size = New System.Drawing.Size(1076, 662)
        Me.ContentPanel.TabIndex = 2
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1476, 747)
        Me.Controls.Add(Me.ContentPanel)
        Me.Controls.Add(Me.SidePanel)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(1491, 784)
        Me.Name = "MainForm"
        Me.Text = "Personal Scheduling System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.HeaderPanel.ResumeLayout(False)
        Me.SidePanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSchedule As Button
    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents btnFriends As Button
    Friend WithEvents btnNotification As Button
    Friend WithEvents btnAppointment As Button
    Friend WithEvents SidePanel As Panel
    Friend WithEvents SideContentPanel As Panel
    Friend WithEvents TimeSidePanel As Panel
    Friend WithEvents ContentPanel As Panel
    Friend WithEvents btnReport As Button
    Friend WithEvents btnUserInfo As UserButton
End Class
