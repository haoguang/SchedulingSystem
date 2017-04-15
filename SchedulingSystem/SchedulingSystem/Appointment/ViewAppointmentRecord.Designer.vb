<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewAppointmentRecord
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
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblStartTitle = New System.Windows.Forms.Label()
        Me.gbAppointment = New System.Windows.Forms.GroupBox()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblPaticipant = New System.Windows.Forms.Label()
        Me.lblVenue = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblEndTime = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBoxDescription = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOwner = New System.Windows.Forms.Label()
        Me.gbAppointment.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDate
        '
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDate.Location = New System.Drawing.Point(186, 44)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(199, 23)
        Me.lblDate.TabIndex = 0
        '
        'lblStartTitle
        '
        Me.lblStartTitle.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblStartTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblStartTitle.Location = New System.Drawing.Point(6, 82)
        Me.lblStartTitle.Name = "lblStartTitle"
        Me.lblStartTitle.Size = New System.Drawing.Size(159, 22)
        Me.lblStartTitle.TabIndex = 1
        Me.lblStartTitle.Text = "Start Time :"
        Me.lblStartTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gbAppointment
        '
        Me.gbAppointment.Controls.Add(Me.lblOwner)
        Me.gbAppointment.Controls.Add(Me.Label1)
        Me.gbAppointment.Controls.Add(Me.lblStartTime)
        Me.gbAppointment.Controls.Add(Me.Label11)
        Me.gbAppointment.Controls.Add(Me.btnClose)
        Me.gbAppointment.Controls.Add(Me.lblPaticipant)
        Me.gbAppointment.Controls.Add(Me.lblVenue)
        Me.gbAppointment.Controls.Add(Me.lblTitle)
        Me.gbAppointment.Controls.Add(Me.lblEndTime)
        Me.gbAppointment.Controls.Add(Me.Label6)
        Me.gbAppointment.Controls.Add(Me.Label5)
        Me.gbAppointment.Controls.Add(Me.Label4)
        Me.gbAppointment.Controls.Add(Me.txtBoxDescription)
        Me.gbAppointment.Controls.Add(Me.Label3)
        Me.gbAppointment.Controls.Add(Me.Label2)
        Me.gbAppointment.Controls.Add(Me.lblStartTitle)
        Me.gbAppointment.Controls.Add(Me.lblDate)
        Me.gbAppointment.Font = New System.Drawing.Font("NSimSun", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAppointment.ForeColor = System.Drawing.Color.DarkGreen
        Me.gbAppointment.Location = New System.Drawing.Point(31, 27)
        Me.gbAppointment.Name = "gbAppointment"
        Me.gbAppointment.Size = New System.Drawing.Size(430, 461)
        Me.gbAppointment.TabIndex = 2
        Me.gbAppointment.TabStop = False
        Me.gbAppointment.Text = "Appointment Details"
        '
        'lblStartTime
        '
        Me.lblStartTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStartTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblStartTime.Location = New System.Drawing.Point(186, 82)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(199, 23)
        Me.lblStartTime.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label11.Location = New System.Drawing.Point(6, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(159, 22)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Date :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(113, 413)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(164, 29)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblPaticipant
        '
        Me.lblPaticipant.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPaticipant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPaticipant.Location = New System.Drawing.Point(186, 373)
        Me.lblPaticipant.Name = "lblPaticipant"
        Me.lblPaticipant.Size = New System.Drawing.Size(199, 23)
        Me.lblPaticipant.TabIndex = 15
        '
        'lblVenue
        '
        Me.lblVenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVenue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblVenue.Location = New System.Drawing.Point(186, 274)
        Me.lblVenue.Name = "lblVenue"
        Me.lblVenue.Size = New System.Drawing.Size(199, 23)
        Me.lblVenue.TabIndex = 14
        '
        'lblTitle
        '
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTitle.Location = New System.Drawing.Point(186, 161)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(199, 23)
        Me.lblTitle.TabIndex = 13
        '
        'lblEndTime
        '
        Me.lblEndTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEndTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEndTime.Location = New System.Drawing.Point(186, 121)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(199, 23)
        Me.lblEndTime.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label6.Location = New System.Drawing.Point(6, 377)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 22)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Participant :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label5.Location = New System.Drawing.Point(6, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 22)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Venue :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label4.Location = New System.Drawing.Point(6, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 22)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Description :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtBoxDescription
        '
        Me.txtBoxDescription.Enabled = False
        Me.txtBoxDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtBoxDescription.Location = New System.Drawing.Point(186, 199)
        Me.txtBoxDescription.Name = "txtBoxDescription"
        Me.txtBoxDescription.ReadOnly = True
        Me.txtBoxDescription.Size = New System.Drawing.Size(199, 56)
        Me.txtBoxDescription.TabIndex = 8
        Me.txtBoxDescription.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(6, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Title :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(6, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "End Time :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(6, 336)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 22)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Owner :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblOwner
        '
        Me.lblOwner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOwner.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblOwner.Location = New System.Drawing.Point(186, 332)
        Me.lblOwner.Name = "lblOwner"
        Me.lblOwner.Size = New System.Drawing.Size(199, 23)
        Me.lblOwner.TabIndex = 20
        '
        'ViewAppointmentRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 513)
        Me.Controls.Add(Me.gbAppointment)
        Me.MaximizeBox = False
        Me.Name = "ViewAppointmentRecord"
        Me.Text = "View Appointment Record"
        Me.gbAppointment.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblDate As Label
    Friend WithEvents lblStartTitle As Label
    Friend WithEvents gbAppointment As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPaticipant As Label
    Friend WithEvents lblVenue As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblEndTime As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBoxDescription As RichTextBox
    Friend WithEvents lblStartTime As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents lblOwner As Label
    Friend WithEvents Label1 As Label
End Class
