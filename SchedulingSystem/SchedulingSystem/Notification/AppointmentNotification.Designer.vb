<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AppointmentNotification
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblATitle = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblADesc = New System.Windows.Forms.Label()
        Me.lblVenue = New System.Windows.Forms.Label()
        Me.lblAVenue = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblADateTime = New System.Windows.Forms.Label()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnReject = New System.Windows.Forms.Button()
        Me.lblInviter = New System.Windows.Forms.Label()
        Me.lblAInviter = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(47, 58)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(111, 15)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Title                 : "
        '
        'lblATitle
        '
        Me.lblATitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblATitle.Location = New System.Drawing.Point(155, 58)
        Me.lblATitle.Name = "lblATitle"
        Me.lblATitle.Size = New System.Drawing.Size(165, 15)
        Me.lblATitle.TabIndex = 1
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(47, 89)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(112, 15)
        Me.lblDesc.TabIndex = 2
        Me.lblDesc.Text = "Description      : "
        '
        'lblADesc
        '
        Me.lblADesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblADesc.Location = New System.Drawing.Point(155, 89)
        Me.lblADesc.Name = "lblADesc"
        Me.lblADesc.Size = New System.Drawing.Size(165, 15)
        Me.lblADesc.TabIndex = 3
        '
        'lblVenue
        '
        Me.lblVenue.AutoSize = True
        Me.lblVenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenue.Location = New System.Drawing.Point(47, 124)
        Me.lblVenue.Name = "lblVenue"
        Me.lblVenue.Size = New System.Drawing.Size(111, 15)
        Me.lblVenue.TabIndex = 4
        Me.lblVenue.Text = "Venue              : "
        '
        'lblAVenue
        '
        Me.lblAVenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAVenue.Location = New System.Drawing.Point(155, 124)
        Me.lblAVenue.Name = "lblAVenue"
        Me.lblAVenue.Size = New System.Drawing.Size(165, 15)
        Me.lblAVenue.TabIndex = 5
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.Location = New System.Drawing.Point(47, 156)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(113, 15)
        Me.lblDateTime.TabIndex = 6
        Me.lblDateTime.Text = "Date and Time : "
        '
        'lblADateTime
        '
        Me.lblADateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblADateTime.Location = New System.Drawing.Point(155, 156)
        Me.lblADateTime.Name = "lblADateTime"
        Me.lblADateTime.Size = New System.Drawing.Size(165, 15)
        Me.lblADateTime.TabIndex = 7
        '
        'btnAccept
        '
        Me.btnAccept.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccept.Location = New System.Drawing.Point(83, 210)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(75, 23)
        Me.btnAccept.TabIndex = 8
        Me.btnAccept.Text = "&Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnReject
        '
        Me.btnReject.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReject.Location = New System.Drawing.Point(197, 210)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(75, 23)
        Me.btnReject.TabIndex = 9
        Me.btnReject.Text = "&Reject"
        Me.btnReject.UseVisualStyleBackColor = True
        '
        'lblInviter
        '
        Me.lblInviter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInviter.Location = New System.Drawing.Point(47, 25)
        Me.lblInviter.Name = "lblInviter"
        Me.lblInviter.Size = New System.Drawing.Size(111, 19)
        Me.lblInviter.TabIndex = 10
        Me.lblInviter.Text = "Inviter             :"
        '
        'lblAInviter
        '
        Me.lblAInviter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAInviter.Location = New System.Drawing.Point(158, 25)
        Me.lblAInviter.Name = "lblAInviter"
        Me.lblAInviter.Size = New System.Drawing.Size(162, 19)
        Me.lblAInviter.TabIndex = 11
        '
        'AppointmentNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 245)
        Me.Controls.Add(Me.lblAInviter)
        Me.Controls.Add(Me.lblInviter)
        Me.Controls.Add(Me.btnReject)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.lblADateTime)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.lblAVenue)
        Me.Controls.Add(Me.lblVenue)
        Me.Controls.Add(Me.lblADesc)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblATitle)
        Me.Controls.Add(Me.lblTitle)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(363, 284)
        Me.MinimumSize = New System.Drawing.Size(363, 284)
        Me.Name = "AppointmentNotification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Appointment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblATitle As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblADesc As Label
    Friend WithEvents lblVenue As Label
    Friend WithEvents lblAVenue As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents lblADateTime As Label
    Friend WithEvents btnAccept As Button
    Friend WithEvents btnReject As Button
    Friend WithEvents lblInviter As Label
    Friend WithEvents lblAInviter As Label
End Class
