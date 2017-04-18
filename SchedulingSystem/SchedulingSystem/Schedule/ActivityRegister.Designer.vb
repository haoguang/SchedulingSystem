<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActivityRegister
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblStartTitle = New System.Windows.Forms.Label()
        Me.scheStart = New System.Windows.Forms.DateTimePicker()
        Me.lblEndTitle = New System.Windows.Forms.Label()
        Me.lblRepeatDueTitle = New System.Windows.Forms.Label()
        Me.lblRepeatBehaveTitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDescriptionTitle = New System.Windows.Forms.Label()
        Me.lblVenueTitle = New System.Windows.Forms.Label()
        Me.lblTypeTitle = New System.Windows.Forms.Label()
        Me.scheEnd = New System.Windows.Forms.DateTimePicker()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtBoxDescription = New System.Windows.Forms.RichTextBox()
        Me.txtVenue = New System.Windows.Forms.TextBox()
        Me.cboActivityType = New System.Windows.Forms.ComboBox()
        Me.scheRepeatDue = New System.Windows.Forms.DateTimePicker()
        Me.cboBehavior = New System.Windows.Forms.ComboBox()
        Me.gbGeneral = New System.Windows.Forms.GroupBox()
        Me.gbRepeat = New System.Windows.Forms.GroupBox()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.gbParticipant = New System.Windows.Forms.GroupBox()
        Me.btnAddParti = New System.Windows.Forms.PictureBox()
        Me.lblParticipantTitle = New System.Windows.Forms.Label()
        Me.dgvParticipants = New System.Windows.Forms.DataGridView()
        Me.dgvParticipleID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvParticiplePic = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dgvParticipleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.gbReminder = New System.Windows.Forms.GroupBox()
        Me.dgvReminder = New System.Windows.Forms.DataGridView()
        Me.btnAddReminder = New System.Windows.Forms.Button()
        Me.cboMinBefore = New System.Windows.Forms.ComboBox()
        Me.lblMinBefore = New System.Windows.Forms.Label()
        Me.gbGeneral.SuspendLayout()
        Me.gbRepeat.SuspendLayout()
        Me.gbParticipant.SuspendLayout()
        CType(Me.btnAddParti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvParticipants, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbReminder.SuspendLayout()
        CType(Me.dgvReminder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStartTitle
        '
        Me.lblStartTitle.AutoSize = True
        Me.lblStartTitle.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblStartTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblStartTitle.Location = New System.Drawing.Point(6, 26)
        Me.lblStartTitle.Name = "lblStartTitle"
        Me.lblStartTitle.Size = New System.Drawing.Size(151, 13)
        Me.lblStartTitle.TabIndex = 0
        Me.lblStartTitle.Text = "Activity &Start   :"
        '
        'scheStart
        '
        Me.scheStart.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.scheStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.scheStart.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.scheStart.Location = New System.Drawing.Point(167, 20)
        Me.scheStart.Name = "scheStart"
        Me.scheStart.ShowUpDown = True
        Me.scheStart.Size = New System.Drawing.Size(200, 20)
        Me.scheStart.TabIndex = 1
        '
        'lblEndTitle
        '
        Me.lblEndTitle.AutoSize = True
        Me.lblEndTitle.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblEndTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblEndTitle.Location = New System.Drawing.Point(6, 57)
        Me.lblEndTitle.Name = "lblEndTitle"
        Me.lblEndTitle.Size = New System.Drawing.Size(151, 13)
        Me.lblEndTitle.TabIndex = 2
        Me.lblEndTitle.Text = "Activity &End     :"
        '
        'lblRepeatDueTitle
        '
        Me.lblRepeatDueTitle.AutoSize = True
        Me.lblRepeatDueTitle.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblRepeatDueTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblRepeatDueTitle.Location = New System.Drawing.Point(6, 25)
        Me.lblRepeatDueTitle.Name = "lblRepeatDueTitle"
        Me.lblRepeatDueTitle.Size = New System.Drawing.Size(151, 13)
        Me.lblRepeatDueTitle.TabIndex = 0
        Me.lblRepeatDueTitle.Text = "Re&petition Due   :"
        '
        'lblRepeatBehaveTitle
        '
        Me.lblRepeatBehaveTitle.AutoSize = True
        Me.lblRepeatBehaveTitle.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblRepeatBehaveTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblRepeatBehaveTitle.Location = New System.Drawing.Point(6, 58)
        Me.lblRepeatBehaveTitle.Name = "lblRepeatBehaveTitle"
        Me.lblRepeatBehaveTitle.Size = New System.Drawing.Size(151, 13)
        Me.lblRepeatBehaveTitle.TabIndex = 2
        Me.lblRepeatBehaveTitle.Text = "Repeat &Behaviour :"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblTitle.Location = New System.Drawing.Point(6, 88)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(151, 13)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Activity &Title   :"
        '
        'lblDescriptionTitle
        '
        Me.lblDescriptionTitle.AutoSize = True
        Me.lblDescriptionTitle.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblDescriptionTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblDescriptionTitle.Location = New System.Drawing.Point(6, 119)
        Me.lblDescriptionTitle.Name = "lblDescriptionTitle"
        Me.lblDescriptionTitle.Size = New System.Drawing.Size(151, 13)
        Me.lblDescriptionTitle.TabIndex = 6
        Me.lblDescriptionTitle.Text = "Descriptio&n      :"
        '
        'lblVenueTitle
        '
        Me.lblVenueTitle.AutoSize = True
        Me.lblVenueTitle.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblVenueTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblVenueTitle.Location = New System.Drawing.Point(6, 187)
        Me.lblVenueTitle.Name = "lblVenueTitle"
        Me.lblVenueTitle.Size = New System.Drawing.Size(151, 13)
        Me.lblVenueTitle.TabIndex = 8
        Me.lblVenueTitle.Text = "&Venue            :"
        '
        'lblTypeTitle
        '
        Me.lblTypeTitle.AutoSize = True
        Me.lblTypeTitle.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTypeTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblTypeTitle.Location = New System.Drawing.Point(6, 223)
        Me.lblTypeTitle.Name = "lblTypeTitle"
        Me.lblTypeTitle.Size = New System.Drawing.Size(151, 13)
        Me.lblTypeTitle.TabIndex = 10
        Me.lblTypeTitle.Text = "&Activity Type    :"
        '
        'scheEnd
        '
        Me.scheEnd.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.scheEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.scheEnd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.scheEnd.Location = New System.Drawing.Point(167, 51)
        Me.scheEnd.Name = "scheEnd"
        Me.scheEnd.ShowUpDown = True
        Me.scheEnd.Size = New System.Drawing.Size(200, 20)
        Me.scheEnd.TabIndex = 3
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(167, 85)
        Me.txtTitle.MaxLength = 30
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(199, 20)
        Me.txtTitle.TabIndex = 5
        '
        'txtBoxDescription
        '
        Me.txtBoxDescription.Location = New System.Drawing.Point(167, 119)
        Me.txtBoxDescription.MaxLength = 100
        Me.txtBoxDescription.Name = "txtBoxDescription"
        Me.txtBoxDescription.Size = New System.Drawing.Size(199, 56)
        Me.txtBoxDescription.TabIndex = 7
        Me.txtBoxDescription.Text = ""
        '
        'txtVenue
        '
        Me.txtVenue.Location = New System.Drawing.Point(167, 184)
        Me.txtVenue.MaxLength = 30
        Me.txtVenue.Name = "txtVenue"
        Me.txtVenue.Size = New System.Drawing.Size(199, 20)
        Me.txtVenue.TabIndex = 9
        '
        'cboActivityType
        '
        Me.cboActivityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboActivityType.FormattingEnabled = True
        Me.cboActivityType.Location = New System.Drawing.Point(167, 220)
        Me.cboActivityType.Name = "cboActivityType"
        Me.cboActivityType.Size = New System.Drawing.Size(199, 21)
        Me.cboActivityType.TabIndex = 11
        '
        'scheRepeatDue
        '
        Me.scheRepeatDue.Location = New System.Drawing.Point(167, 19)
        Me.scheRepeatDue.Name = "scheRepeatDue"
        Me.scheRepeatDue.Size = New System.Drawing.Size(200, 20)
        Me.scheRepeatDue.TabIndex = 1
        '
        'cboBehavior
        '
        Me.cboBehavior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBehavior.FormattingEnabled = True
        Me.cboBehavior.Location = New System.Drawing.Point(167, 55)
        Me.cboBehavior.Name = "cboBehavior"
        Me.cboBehavior.Size = New System.Drawing.Size(199, 21)
        Me.cboBehavior.TabIndex = 3
        '
        'gbGeneral
        '
        Me.gbGeneral.Controls.Add(Me.lblStartTitle)
        Me.gbGeneral.Controls.Add(Me.lblEndTitle)
        Me.gbGeneral.Controls.Add(Me.cboActivityType)
        Me.gbGeneral.Controls.Add(Me.scheStart)
        Me.gbGeneral.Controls.Add(Me.txtVenue)
        Me.gbGeneral.Controls.Add(Me.txtBoxDescription)
        Me.gbGeneral.Controls.Add(Me.lblTypeTitle)
        Me.gbGeneral.Controls.Add(Me.scheEnd)
        Me.gbGeneral.Controls.Add(Me.lblVenueTitle)
        Me.gbGeneral.Controls.Add(Me.lblTitle)
        Me.gbGeneral.Controls.Add(Me.txtTitle)
        Me.gbGeneral.Controls.Add(Me.lblDescriptionTitle)
        Me.gbGeneral.Location = New System.Drawing.Point(19, 13)
        Me.gbGeneral.Name = "gbGeneral"
        Me.gbGeneral.Size = New System.Drawing.Size(402, 259)
        Me.gbGeneral.TabIndex = 7
        Me.gbGeneral.TabStop = False
        Me.gbGeneral.Text = "General"
        '
        'gbRepeat
        '
        Me.gbRepeat.Controls.Add(Me.lblRepeatDueTitle)
        Me.gbRepeat.Controls.Add(Me.lblRepeatBehaveTitle)
        Me.gbRepeat.Controls.Add(Me.cboBehavior)
        Me.gbRepeat.Controls.Add(Me.scheRepeatDue)
        Me.gbRepeat.Location = New System.Drawing.Point(19, 289)
        Me.gbRepeat.Name = "gbRepeat"
        Me.gbRepeat.Size = New System.Drawing.Size(402, 95)
        Me.gbRepeat.TabIndex = 8
        Me.gbRepeat.TabStop = False
        Me.gbRepeat.Text = "Repetition"
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDone.FlatAppearance.BorderSize = 3
        Me.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDone.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnDone.Location = New System.Drawing.Point(440, 397)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(119, 44)
        Me.btnDone.TabIndex = 9
        Me.btnDone.Text = "&Done"
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'gbParticipant
        '
        Me.gbParticipant.Controls.Add(Me.btnAddParti)
        Me.gbParticipant.Controls.Add(Me.lblParticipantTitle)
        Me.gbParticipant.Controls.Add(Me.dgvParticipants)
        Me.gbParticipant.Location = New System.Drawing.Point(437, 13)
        Me.gbParticipant.Name = "gbParticipant"
        Me.gbParticipant.Size = New System.Drawing.Size(277, 371)
        Me.gbParticipant.TabIndex = 10
        Me.gbParticipant.TabStop = False
        Me.gbParticipant.Text = "Participants"
        '
        'btnAddParti
        '
        Me.btnAddParti.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnAddParti.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddParti.Image = Global.SchedulingSystem.My.Resources.Resources.add_user_32
        Me.btnAddParti.InitialImage = Global.SchedulingSystem.My.Resources.Resources.add_user_32
        Me.btnAddParti.Location = New System.Drawing.Point(234, 16)
        Me.btnAddParti.Name = "btnAddParti"
        Me.btnAddParti.Size = New System.Drawing.Size(40, 40)
        Me.btnAddParti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnAddParti.TabIndex = 2
        Me.btnAddParti.TabStop = False
        '
        'lblParticipantTitle
        '
        Me.lblParticipantTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lblParticipantTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblParticipantTitle.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParticipantTitle.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblParticipantTitle.Location = New System.Drawing.Point(3, 16)
        Me.lblParticipantTitle.Name = "lblParticipantTitle"
        Me.lblParticipantTitle.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblParticipantTitle.Size = New System.Drawing.Size(271, 40)
        Me.lblParticipantTitle.TabIndex = 1
        Me.lblParticipantTitle.Text = "Participant Names"
        Me.lblParticipantTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvParticipants
        '
        Me.dgvParticipants.AllowUserToAddRows = False
        Me.dgvParticipants.AllowUserToDeleteRows = False
        Me.dgvParticipants.AllowUserToResizeColumns = False
        Me.dgvParticipants.AllowUserToResizeRows = False
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.dgvParticipants.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvParticipants.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.dgvParticipants.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvParticipants.ColumnHeadersVisible = False
        Me.dgvParticipants.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvParticipleID, Me.dgvParticiplePic, Me.dgvParticipleName})
        Me.dgvParticipants.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvParticipants.GridColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.dgvParticipants.Location = New System.Drawing.Point(3, 56)
        Me.dgvParticipants.MultiSelect = False
        Me.dgvParticipants.Name = "dgvParticipants"
        Me.dgvParticipants.ReadOnly = True
        Me.dgvParticipants.RowHeadersVisible = False
        Me.dgvParticipants.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvParticipants.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvParticipants.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgvParticipants.RowTemplate.Height = 60
        Me.dgvParticipants.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvParticipants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvParticipants.Size = New System.Drawing.Size(271, 312)
        Me.dgvParticipants.TabIndex = 0
        '
        'dgvParticipleID
        '
        Me.dgvParticipleID.HeaderText = "Participle ID"
        Me.dgvParticipleID.Name = "dgvParticipleID"
        Me.dgvParticipleID.ReadOnly = True
        Me.dgvParticipleID.Visible = False
        '
        'dgvParticiplePic
        '
        Me.dgvParticiplePic.HeaderText = "Profile Picture"
        Me.dgvParticiplePic.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.dgvParticiplePic.Name = "dgvParticiplePic"
        Me.dgvParticiplePic.ReadOnly = True
        '
        'dgvParticipleName
        '
        Me.dgvParticipleName.FillWeight = 50.0!
        Me.dgvParticipleName.HeaderText = "Participle Name"
        Me.dgvParticipleName.Name = "dgvParticipleName"
        Me.dgvParticipleName.ReadOnly = True
        Me.dgvParticipleName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvParticipleName.Width = 221
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnCancel.CausesValidation = False
        Me.btnCancel.FlatAppearance.BorderSize = 3
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(592, 397)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(119, 44)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Err
        '
        Me.Err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.Err.ContainerControl = Me
        '
        'gbReminder
        '
        Me.gbReminder.Controls.Add(Me.dgvReminder)
        Me.gbReminder.Controls.Add(Me.btnAddReminder)
        Me.gbReminder.Controls.Add(Me.cboMinBefore)
        Me.gbReminder.Controls.Add(Me.lblMinBefore)
        Me.gbReminder.Location = New System.Drawing.Point(19, 390)
        Me.gbReminder.Name = "gbReminder"
        Me.gbReminder.Size = New System.Drawing.Size(402, 152)
        Me.gbReminder.TabIndex = 11
        Me.gbReminder.TabStop = False
        Me.gbReminder.Text = "Reminder"
        '
        'dgvReminder
        '
        Me.dgvReminder.AllowUserToAddRows = False
        Me.dgvReminder.AllowUserToDeleteRows = False
        Me.dgvReminder.AllowUserToResizeColumns = False
        Me.dgvReminder.AllowUserToResizeRows = False
        Me.dgvReminder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReminder.Location = New System.Drawing.Point(9, 60)
        Me.dgvReminder.Name = "dgvReminder"
        Me.dgvReminder.ReadOnly = True
        Me.dgvReminder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReminder.Size = New System.Drawing.Size(365, 86)
        Me.dgvReminder.TabIndex = 6
        '
        'btnAddReminder
        '
        Me.btnAddReminder.Location = New System.Drawing.Point(331, 20)
        Me.btnAddReminder.Name = "btnAddReminder"
        Me.btnAddReminder.Size = New System.Drawing.Size(43, 23)
        Me.btnAddReminder.TabIndex = 5
        Me.btnAddReminder.Text = "&Add"
        Me.btnAddReminder.UseVisualStyleBackColor = True
        '
        'cboMinBefore
        '
        Me.cboMinBefore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMinBefore.FormattingEnabled = True
        Me.cboMinBefore.Items.AddRange(New Object() {"10 minutes", "20 minutes", "30 minutes", "40 minutes", "50 minutes", "1 hour"})
        Me.cboMinBefore.Location = New System.Drawing.Point(167, 22)
        Me.cboMinBefore.Name = "cboMinBefore"
        Me.cboMinBefore.Size = New System.Drawing.Size(158, 21)
        Me.cboMinBefore.TabIndex = 4
        '
        'lblMinBefore
        '
        Me.lblMinBefore.AutoSize = True
        Me.lblMinBefore.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblMinBefore.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblMinBefore.Location = New System.Drawing.Point(6, 25)
        Me.lblMinBefore.Name = "lblMinBefore"
        Me.lblMinBefore.Size = New System.Drawing.Size(151, 13)
        Me.lblMinBefore.TabIndex = 3
        Me.lblMinBefore.Text = "&Minutes Before   :"
        '
        'ActivityRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.Controls.Add(Me.gbReminder)
        Me.Controls.Add(Me.gbParticipant)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.gbRepeat)
        Me.Controls.Add(Me.gbGeneral)
        Me.Name = "ActivityRegister"
        Me.Size = New System.Drawing.Size(729, 558)
        Me.gbGeneral.ResumeLayout(False)
        Me.gbGeneral.PerformLayout()
        Me.gbRepeat.ResumeLayout(False)
        Me.gbRepeat.PerformLayout()
        Me.gbParticipant.ResumeLayout(False)
        CType(Me.btnAddParti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvParticipants, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbReminder.ResumeLayout(False)
        Me.gbReminder.PerformLayout()
        CType(Me.dgvReminder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblStartTitle As Label
    Friend WithEvents scheStart As DateTimePicker
    Friend WithEvents lblEndTitle As Label
    Friend WithEvents lblRepeatDueTitle As Label
    Friend WithEvents lblRepeatBehaveTitle As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDescriptionTitle As Label
    Friend WithEvents lblVenueTitle As Label
    Friend WithEvents lblTypeTitle As Label
    Friend WithEvents scheEnd As DateTimePicker
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtBoxDescription As RichTextBox
    Friend WithEvents txtVenue As TextBox
    Friend WithEvents cboActivityType As ComboBox
    Friend WithEvents scheRepeatDue As DateTimePicker
    Friend WithEvents cboBehavior As ComboBox
    Friend WithEvents gbGeneral As GroupBox
    Friend WithEvents gbRepeat As GroupBox
    Friend WithEvents btnDone As Button
    Friend WithEvents gbParticipant As GroupBox
    Friend WithEvents dgvParticipants As DataGridView
    Friend WithEvents btnAddParti As PictureBox
    Friend WithEvents lblParticipantTitle As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents Err As ErrorProvider
    Friend WithEvents gbReminder As GroupBox
    Friend WithEvents dgvReminder As DataGridView
    Friend WithEvents btnAddReminder As Button
    Friend WithEvents cboMinBefore As ComboBox
    Friend WithEvents lblMinBefore As Label
    Friend WithEvents dgvParticipleID As DataGridViewTextBoxColumn
    Friend WithEvents dgvParticiplePic As DataGridViewImageColumn
    Friend WithEvents dgvParticipleName As DataGridViewTextBoxColumn
End Class
