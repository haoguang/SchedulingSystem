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
        Me.btnConfirm.Location = New System.Drawing.Point(245, 398)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(135, 28)
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
        Me.gbGeneral.Location = New System.Drawing.Point(23, 70)
        Me.gbGeneral.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbGeneral.Name = "gbGeneral"
        Me.gbGeneral.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbGeneral.Size = New System.Drawing.Size(511, 298)
        Me.gbGeneral.TabIndex = 8
        Me.gbGeneral.TabStop = False
        Me.gbGeneral.Text = "General"
        '
        'lblStartTitle
        '
        Me.lblStartTitle.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblStartTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblStartTitle.Location = New System.Drawing.Point(8, 32)
        Me.lblStartTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStartTitle.Name = "lblStartTitle"
        Me.lblStartTitle.Size = New System.Drawing.Size(207, 16)
        Me.lblStartTitle.TabIndex = 0
        Me.lblStartTitle.Text = "Appointment Start:"
        Me.lblStartTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblEndTitle
        '
        Me.lblEndTitle.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblEndTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblEndTitle.Location = New System.Drawing.Point(8, 70)
        Me.lblEndTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndTitle.Name = "lblEndTitle"
        Me.lblEndTitle.Size = New System.Drawing.Size(207, 16)
        Me.lblEndTitle.TabIndex = 2
        Me.lblEndTitle.Text = "Duration :"
        Me.lblEndTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'scheStart
        '
        Me.scheStart.CustomFormat = "dd/MM/yyyy hh:mm tt"
        Me.scheStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.scheStart.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.scheStart.Location = New System.Drawing.Point(223, 25)
        Me.scheStart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.scheStart.Name = "scheStart"
        Me.scheStart.ShowUpDown = True
        Me.scheStart.Size = New System.Drawing.Size(265, 22)
        Me.scheStart.TabIndex = 1
        '
        'txtVenue
        '
        Me.txtVenue.Location = New System.Drawing.Point(223, 226)
        Me.txtVenue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtVenue.Name = "txtVenue"
        Me.txtVenue.Size = New System.Drawing.Size(264, 22)
        Me.txtVenue.TabIndex = 9
        '
        'txtBoxDescription
        '
        Me.txtBoxDescription.Location = New System.Drawing.Point(223, 146)
        Me.txtBoxDescription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBoxDescription.Name = "txtBoxDescription"
        Me.txtBoxDescription.Size = New System.Drawing.Size(264, 68)
        Me.txtBoxDescription.TabIndex = 7
        Me.txtBoxDescription.Text = ""
        '
        'scheEnd
        '
        Me.scheEnd.CustomFormat = "hh:mm tt"
        Me.scheEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.scheEnd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.scheEnd.Location = New System.Drawing.Point(223, 63)
        Me.scheEnd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.scheEnd.Name = "scheEnd"
        Me.scheEnd.ShowUpDown = True
        Me.scheEnd.Size = New System.Drawing.Size(265, 22)
        Me.scheEnd.TabIndex = 3
        '
        'lblVenueTitle
        '
        Me.lblVenueTitle.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblVenueTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblVenueTitle.Location = New System.Drawing.Point(8, 230)
        Me.lblVenueTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVenueTitle.Name = "lblVenueTitle"
        Me.lblVenueTitle.Size = New System.Drawing.Size(207, 16)
        Me.lblVenueTitle.TabIndex = 8
        Me.lblVenueTitle.Text = "Venue :"
        Me.lblVenueTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblTitle.Location = New System.Drawing.Point(8, 108)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(207, 16)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Activity Title :"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(223, 105)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(264, 22)
        Me.txtTitle.TabIndex = 5
        '
        'lblDescriptionTitle
        '
        Me.lblDescriptionTitle.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblDescriptionTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblDescriptionTitle.Location = New System.Drawing.Point(8, 146)
        Me.lblDescriptionTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescriptionTitle.Name = "lblDescriptionTitle"
        Me.lblDescriptionTitle.Size = New System.Drawing.Size(207, 16)
        Me.lblDescriptionTitle.TabIndex = 6
        Me.lblDescriptionTitle.Text = "Description :"
        Me.lblDescriptionTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(87, 398)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(135, 28)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTo.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblTo.Location = New System.Drawing.Point(31, 28)
        Me.lblTo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(48, 17)
        Me.lblTo.TabIndex = 10
        Me.lblTo.Text = "To :"
        '
        'CreateAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 589)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.gbGeneral)
        Me.Controls.Add(Me.btnConfirm)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
