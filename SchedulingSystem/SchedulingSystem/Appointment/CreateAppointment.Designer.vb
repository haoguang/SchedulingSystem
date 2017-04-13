<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAppointment
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
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.gbGeneral = New System.Windows.Forms.GroupBox()
        Me.lblStartTitle = New System.Windows.Forms.Label()
        Me.lblEndTitle = New System.Windows.Forms.Label()
        Me.scheStart = New System.Windows.Forms.DateTimePicker()
        Me.txtVenue = New System.Windows.Forms.TextBox()
        Me.txtBoxDescription = New System.Windows.Forms.RichTextBox()
        Me.scheEnd = New System.Windows.Forms.DateTimePicker()
        Me.lblVenueTitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblDescriptionTitle = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.gbGeneral.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(184, 323)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(101, 31)
        Me.btnConfirm.TabIndex = 1
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'gbGeneral
        '
        Me.gbGeneral.Controls.Add(Me.lblStartTitle)
        Me.gbGeneral.Controls.Add(Me.lblEndTitle)
        Me.gbGeneral.Controls.Add(Me.scheStart)
        Me.gbGeneral.Controls.Add(Me.txtVenue)
        Me.gbGeneral.Controls.Add(Me.txtBoxDescription)
        Me.gbGeneral.Controls.Add(Me.scheEnd)
        Me.gbGeneral.Controls.Add(Me.lblVenueTitle)
        Me.gbGeneral.Controls.Add(Me.lblTitle)
        Me.gbGeneral.Controls.Add(Me.txtTitle)
        Me.gbGeneral.Controls.Add(Me.lblDescriptionTitle)
        Me.gbGeneral.Location = New System.Drawing.Point(17, 57)
        Me.gbGeneral.Name = "gbGeneral"
        Me.gbGeneral.Size = New System.Drawing.Size(383, 242)
        Me.gbGeneral.TabIndex = 8
        Me.gbGeneral.TabStop = False
        Me.gbGeneral.Text = "General"
        '
        'lblStartTitle
        '
        Me.lblStartTitle.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblStartTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblStartTitle.Location = New System.Drawing.Point(6, 26)
        Me.lblStartTitle.Name = "lblStartTitle"
        Me.lblStartTitle.Size = New System.Drawing.Size(155, 13)
        Me.lblStartTitle.TabIndex = 0
        Me.lblStartTitle.Text = "Appointment Start:"
        Me.lblStartTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblEndTitle
        '
        Me.lblEndTitle.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblEndTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblEndTitle.Location = New System.Drawing.Point(6, 57)
        Me.lblEndTitle.Name = "lblEndTitle"
        Me.lblEndTitle.Size = New System.Drawing.Size(155, 13)
        Me.lblEndTitle.TabIndex = 2
        Me.lblEndTitle.Text = "Appointment End :"
        Me.lblEndTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'scheStart
        '
        Me.scheStart.CustomFormat = "dd/MM/yyyy hh:mm tt"
        Me.scheStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.scheStart.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.scheStart.Location = New System.Drawing.Point(167, 20)
        Me.scheStart.Name = "scheStart"
        Me.scheStart.ShowUpDown = True
        Me.scheStart.Size = New System.Drawing.Size(200, 20)
        Me.scheStart.TabIndex = 1
        '
        'txtVenue
        '
        Me.txtVenue.Location = New System.Drawing.Point(167, 184)
        Me.txtVenue.Name = "txtVenue"
        Me.txtVenue.Size = New System.Drawing.Size(199, 20)
        Me.txtVenue.TabIndex = 9
        '
        'txtBoxDescription
        '
        Me.txtBoxDescription.Location = New System.Drawing.Point(167, 119)
        Me.txtBoxDescription.Name = "txtBoxDescription"
        Me.txtBoxDescription.Size = New System.Drawing.Size(199, 56)
        Me.txtBoxDescription.TabIndex = 7
        Me.txtBoxDescription.Text = ""
        '
        'scheEnd
        '
        Me.scheEnd.CustomFormat = "dd/MM/yyyy hh:mm tt"
        Me.scheEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.scheEnd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.scheEnd.Location = New System.Drawing.Point(167, 51)
        Me.scheEnd.Name = "scheEnd"
        Me.scheEnd.ShowUpDown = True
        Me.scheEnd.Size = New System.Drawing.Size(200, 20)
        Me.scheEnd.TabIndex = 3
        '
        'lblVenueTitle
        '
        Me.lblVenueTitle.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblVenueTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblVenueTitle.Location = New System.Drawing.Point(6, 187)
        Me.lblVenueTitle.Name = "lblVenueTitle"
        Me.lblVenueTitle.Size = New System.Drawing.Size(155, 13)
        Me.lblVenueTitle.TabIndex = 8
        Me.lblVenueTitle.Text = "Venue :"
        Me.lblVenueTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblTitle.Location = New System.Drawing.Point(6, 88)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(155, 13)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Activity Title :"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(167, 85)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(199, 20)
        Me.txtTitle.TabIndex = 5
        '
        'lblDescriptionTitle
        '
        Me.lblDescriptionTitle.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblDescriptionTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblDescriptionTitle.Location = New System.Drawing.Point(6, 119)
        Me.lblDescriptionTitle.Name = "lblDescriptionTitle"
        Me.lblDescriptionTitle.Size = New System.Drawing.Size(155, 13)
        Me.lblDescriptionTitle.TabIndex = 6
        Me.lblDescriptionTitle.Text = "Description :"
        Me.lblDescriptionTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(65, 323)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(101, 31)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTo.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblTo.Location = New System.Drawing.Point(23, 23)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(39, 13)
        Me.lblTo.TabIndex = 10
        Me.lblTo.Text = "To :"
        '
        'CreateAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 390)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.gbGeneral)
        Me.Controls.Add(Me.btnConfirm)
        Me.MaximizeBox = False
        Me.Name = "CreateAppointment"
        Me.Text = "Appointment Form"
        Me.gbGeneral.ResumeLayout(False)
        Me.gbGeneral.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConfirm As Button
    Friend WithEvents gbGeneral As GroupBox
    Friend WithEvents lblStartTitle As Label
    Friend WithEvents lblEndTitle As Label
    Friend WithEvents scheStart As DateTimePicker
    Friend WithEvents txtVenue As TextBox
    Friend WithEvents txtBoxDescription As RichTextBox
    Friend WithEvents scheEnd As DateTimePicker
    Friend WithEvents lblVenueTitle As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents lblDescriptionTitle As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblTo As Label
End Class
