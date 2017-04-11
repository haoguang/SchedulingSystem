<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateAppointmentRecord
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
        Me.gbAppointment = New System.Windows.Forms.GroupBox()
        Me.txtVenue = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.scheEnd = New System.Windows.Forms.DateTimePicker()
        Me.scheStart = New System.Windows.Forms.DateTimePicker()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblPaticipant = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBoxDescription = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblStartTitle = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.gbAppointment.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbAppointment
        '
        Me.gbAppointment.Controls.Add(Me.txtVenue)
        Me.gbAppointment.Controls.Add(Me.txtTitle)
        Me.gbAppointment.Controls.Add(Me.scheEnd)
        Me.gbAppointment.Controls.Add(Me.scheStart)
        Me.gbAppointment.Controls.Add(Me.btnCancel)
        Me.gbAppointment.Controls.Add(Me.btnUpdate)
        Me.gbAppointment.Controls.Add(Me.lblPaticipant)
        Me.gbAppointment.Controls.Add(Me.Label6)
        Me.gbAppointment.Controls.Add(Me.Label5)
        Me.gbAppointment.Controls.Add(Me.Label4)
        Me.gbAppointment.Controls.Add(Me.txtBoxDescription)
        Me.gbAppointment.Controls.Add(Me.Label3)
        Me.gbAppointment.Controls.Add(Me.Label2)
        Me.gbAppointment.Controls.Add(Me.lblStartTitle)
        Me.gbAppointment.Font = New System.Drawing.Font("NSimSun", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAppointment.ForeColor = System.Drawing.Color.DarkGreen
        Me.gbAppointment.Location = New System.Drawing.Point(12, 27)
        Me.gbAppointment.Name = "gbAppointment"
        Me.gbAppointment.Size = New System.Drawing.Size(430, 408)
        Me.gbAppointment.TabIndex = 3
        Me.gbAppointment.TabStop = False
        Me.gbAppointment.Text = "Appointment Details"
        '
        'txtVenue
        '
        Me.txtVenue.Location = New System.Drawing.Point(187, 233)
        Me.txtVenue.Name = "txtVenue"
        Me.txtVenue.Size = New System.Drawing.Size(199, 26)
        Me.txtVenue.TabIndex = 24
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(186, 121)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(199, 26)
        Me.txtTitle.TabIndex = 23
        '
        'scheEnd
        '
        Me.scheEnd.CustomFormat = "hh:mm tt"
        Me.scheEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.scheEnd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.scheEnd.Location = New System.Drawing.Point(185, 82)
        Me.scheEnd.Name = "scheEnd"
        Me.scheEnd.ShowUpDown = True
        Me.scheEnd.Size = New System.Drawing.Size(200, 26)
        Me.scheEnd.TabIndex = 22
        '
        'scheStart
        '
        Me.scheStart.Checked = False
        Me.scheStart.CustomFormat = "dd/MM/yyyy hh:mm tt"
        Me.scheStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.scheStart.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.scheStart.Location = New System.Drawing.Point(186, 40)
        Me.scheStart.Name = "scheStart"
        Me.scheStart.ShowUpDown = True
        Me.scheStart.Size = New System.Drawing.Size(200, 26)
        Me.scheStart.TabIndex = 21
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(51, 340)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(127, 47)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "Cancel Appointment"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(223, 340)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(117, 47)
        Me.btnUpdate.TabIndex = 19
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblPaticipant
        '
        Me.lblPaticipant.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPaticipant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPaticipant.Location = New System.Drawing.Point(187, 272)
        Me.lblPaticipant.Name = "lblPaticipant"
        Me.lblPaticipant.Size = New System.Drawing.Size(199, 23)
        Me.lblPaticipant.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label6.Location = New System.Drawing.Point(6, 272)
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
        Me.Label5.Location = New System.Drawing.Point(6, 233)
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
        Me.Label4.Location = New System.Drawing.Point(6, 157)
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
        Me.txtBoxDescription.Location = New System.Drawing.Point(187, 157)
        Me.txtBoxDescription.Name = "txtBoxDescription"
        Me.txtBoxDescription.Size = New System.Drawing.Size(199, 64)
        Me.txtBoxDescription.TabIndex = 8
        Me.txtBoxDescription.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(6, 125)
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
        Me.Label2.Location = New System.Drawing.Point(6, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "End Time :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblStartTitle
        '
        Me.lblStartTitle.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblStartTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblStartTitle.Location = New System.Drawing.Point(6, 40)
        Me.lblStartTitle.Name = "lblStartTitle"
        Me.lblStartTitle.Size = New System.Drawing.Size(159, 22)
        Me.lblStartTitle.TabIndex = 1
        Me.lblStartTitle.Text = "Start Date Time :"
        Me.lblStartTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(130, 451)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(164, 29)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'UpdateAppointmentRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 501)
        Me.Controls.Add(Me.gbAppointment)
        Me.Controls.Add(Me.btnClose)
        Me.MaximizeBox = False
        Me.Name = "UpdateAppointmentRecord"
        Me.Text = "UpdateAppointmentRecord"
        Me.gbAppointment.ResumeLayout(False)
        Me.gbAppointment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbAppointment As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblPaticipant As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBoxDescription As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblStartTitle As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents scheStart As DateTimePicker
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents scheEnd As DateTimePicker
    Friend WithEvents txtVenue As TextBox
End Class
