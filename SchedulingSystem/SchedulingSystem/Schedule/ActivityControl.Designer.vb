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
        Me.lblStartTime.Location = New System.Drawing.Point(-3, 13)
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
        Me.lblTitle.Location = New System.Drawing.Point(100, 13)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.lblTitle.Size = New System.Drawing.Size(138, 23)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Title"
        '
        'lblVenue
        '
        Me.lblVenue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVenue.Location = New System.Drawing.Point(303, 13)
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
        Me.lblScheduleID.Location = New System.Drawing.Point(244, 13)
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
        Me.Controls.Add(Me.lblScheduleID)
        Me.Controls.Add(Me.lblVenue)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblStartTime)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "ActivityControl"
        Me.Size = New System.Drawing.Size(400, 50)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStartTime As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblVenue As Label
    Friend WithEvents lblScheduleID As Label
End Class
