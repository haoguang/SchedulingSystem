<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActivityControl
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
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblVenue = New System.Windows.Forms.Label()
        Me.lblScheduleID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblStartTime
        '
        Me.lblStartTime.Enabled = False
        Me.lblStartTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblStartTime.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblStartTime.ForeColor = System.Drawing.Color.Black
        Me.lblStartTime.Location = New System.Drawing.Point(-3, 1)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lblStartTime.Size = New System.Drawing.Size(97, 23)
        Me.lblStartTime.TabIndex = 0
        Me.lblStartTime.Text = "Start Time"
        Me.lblStartTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.Enabled = False
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(100, 1)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.lblTitle.Size = New System.Drawing.Size(136, 23)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Title"
        '
        'lblVenue
        '
        Me.lblVenue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVenue.Enabled = False
        Me.lblVenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblVenue.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblVenue.ForeColor = System.Drawing.Color.Black
        Me.lblVenue.Location = New System.Drawing.Point(301, 1)
        Me.lblVenue.Name = "lblVenue"
        Me.lblVenue.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lblVenue.Size = New System.Drawing.Size(97, 23)
        Me.lblVenue.TabIndex = 0
        Me.lblVenue.Text = "Venue"
        Me.lblVenue.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblScheduleID
        '
        Me.lblScheduleID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblScheduleID.AutoSize = True
        Me.lblScheduleID.Location = New System.Drawing.Point(242, 13)
        Me.lblScheduleID.Name = "lblScheduleID"
        Me.lblScheduleID.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lblScheduleID.Size = New System.Drawing.Size(18, 18)
        Me.lblScheduleID.TabIndex = 0
        Me.lblScheduleID.Text = "ID"
        Me.lblScheduleID.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblScheduleID.Visible = False
        '
        'ActivityControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lblScheduleID)
        Me.Controls.Add(Me.lblVenue)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblStartTime)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "ActivityControl"
        Me.Size = New System.Drawing.Size(398, 48)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStartTime As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblVenue As Label
    Friend WithEvents lblScheduleID As Label
End Class
