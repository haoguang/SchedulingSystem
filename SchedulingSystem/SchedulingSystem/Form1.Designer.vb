<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.btnFriends = New System.Windows.Forms.Button()
        Me.btnNotification = New System.Windows.Forms.Button()
        Me.btnAppointment = New System.Windows.Forms.Button()
        Me.btnSchedule = New System.Windows.Forms.Button()
        Me.ContentPanel = New System.Windows.Forms.Panel()
        Me.HeaderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.btnFriends)
        Me.HeaderPanel.Controls.Add(Me.btnNotification)
        Me.HeaderPanel.Controls.Add(Me.btnAppointment)
        Me.HeaderPanel.Controls.Add(Me.btnSchedule)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(760, 69)
        Me.HeaderPanel.TabIndex = 0
        '
        'btnFriends
        '
        Me.btnFriends.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnFriends.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFriends.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFriends.ForeColor = System.Drawing.SystemColors.Control
        Me.btnFriends.Image = Global.SchedulingSystem.My.Resources.Resources.user
        Me.btnFriends.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFriends.Location = New System.Drawing.Point(501, 0)
        Me.btnFriends.Name = "btnFriends"
        Me.btnFriends.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnFriends.Size = New System.Drawing.Size(167, 69)
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
        Me.btnNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotification.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotification.ForeColor = System.Drawing.SystemColors.Control
        Me.btnNotification.Image = Global.SchedulingSystem.My.Resources.Resources.warning
        Me.btnNotification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotification.Location = New System.Drawing.Point(334, 0)
        Me.btnNotification.Name = "btnNotification"
        Me.btnNotification.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnNotification.Size = New System.Drawing.Size(167, 69)
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
        Me.btnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppointment.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppointment.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAppointment.Image = CType(resources.GetObject("btnAppointment.Image"), System.Drawing.Image)
        Me.btnAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAppointment.Location = New System.Drawing.Point(167, 0)
        Me.btnAppointment.Name = "btnAppointment"
        Me.btnAppointment.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnAppointment.Size = New System.Drawing.Size(167, 69)
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
        Me.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSchedule.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSchedule.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSchedule.Image = CType(resources.GetObject("btnSchedule.Image"), System.Drawing.Image)
        Me.btnSchedule.Location = New System.Drawing.Point(0, 0)
        Me.btnSchedule.Name = "btnSchedule"
        Me.btnSchedule.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnSchedule.Size = New System.Drawing.Size(167, 69)
        Me.btnSchedule.TabIndex = 2
        Me.btnSchedule.Text = "  Schedule"
        Me.btnSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSchedule.UseVisualStyleBackColor = False
        '
        'ContentPanel
        '
        Me.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentPanel.Location = New System.Drawing.Point(0, 69)
        Me.ContentPanel.Name = "ContentPanel"
        Me.ContentPanel.Size = New System.Drawing.Size(760, 395)
        Me.ContentPanel.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 464)
        Me.Controls.Add(Me.ContentPanel)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Name = "Form1"
        Me.Text = "Personal Scheduling System"
        Me.HeaderPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSchedule As Button
    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents btnFriends As Button
    Friend WithEvents btnNotification As Button
    Friend WithEvents btnAppointment As Button
    Friend WithEvents ContentPanel As Panel
End Class
