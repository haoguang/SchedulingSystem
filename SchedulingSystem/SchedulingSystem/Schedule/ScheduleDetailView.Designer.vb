<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleDetailView
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvReminder = New System.Windows.Forms.DataGridView()
        Me.btnAddReminder = New System.Windows.Forms.Button()
        Me.lblMinBefore = New System.Windows.Forms.Label()
        Me.lblRepeatDueTitle = New System.Windows.Forms.Label()
        Me.lblRepeatBehaveTitle = New System.Windows.Forms.Label()
        Me.gbReminder = New System.Windows.Forms.GroupBox()
        Me.cboMinBefore = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAddParti = New System.Windows.Forms.PictureBox()
        Me.lblParticipleTitle = New System.Windows.Forms.Label()
        Me.dgvParticiples = New System.Windows.Forms.DataGridView()
        Me.dgvParticipleID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvParticiplePic = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dgvParticipleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbParticiple = New System.Windows.Forms.GroupBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.gbRepeat = New System.Windows.Forms.GroupBox()
        Me.lblRepeatBehave = New System.Windows.Forms.Label()
        Me.lblRepeatDue = New System.Windows.Forms.Label()
        Me.lblEndTitle = New System.Windows.Forms.Label()
        Me.lblTypeTitle = New System.Windows.Forms.Label()
        Me.lblVenueTitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDescriptionTitle = New System.Windows.Forms.Label()
        Me.gbGeneral = New System.Windows.Forms.GroupBox()
        Me.lblActivityType = New System.Windows.Forms.Label()
        Me.lblVenue = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblAcTitle = New System.Windows.Forms.Label()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblStartTitle = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        CType(Me.dgvReminder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbReminder.SuspendLayout()
        CType(Me.btnAddParti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvParticiples, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbParticiple.SuspendLayout()
        Me.gbRepeat.SuspendLayout()
        Me.gbGeneral.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvReminder
        '
        Me.dgvReminder.AllowUserToAddRows = False
        Me.dgvReminder.AllowUserToDeleteRows = False
        Me.dgvReminder.AllowUserToResizeColumns = False
        Me.dgvReminder.AllowUserToResizeRows = False
        Me.dgvReminder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReminder.Location = New System.Drawing.Point(9, 60)
        Me.dgvReminder.MultiSelect = False
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
        'lblMinBefore
        '
        Me.lblMinBefore.AutoSize = True
        Me.lblMinBefore.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblMinBefore.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblMinBefore.Location = New System.Drawing.Point(6, 25)
        Me.lblMinBefore.Name = "lblMinBefore"
        Me.lblMinBefore.Size = New System.Drawing.Size(135, 13)
        Me.lblMinBefore.TabIndex = 3
        Me.lblMinBefore.Text = "&Minutes Before :"
        '
        'lblRepeatDueTitle
        '
        Me.lblRepeatDueTitle.AutoSize = True
        Me.lblRepeatDueTitle.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblRepeatDueTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblRepeatDueTitle.Location = New System.Drawing.Point(6, 25)
        Me.lblRepeatDueTitle.Name = "lblRepeatDueTitle"
        Me.lblRepeatDueTitle.Size = New System.Drawing.Size(143, 13)
        Me.lblRepeatDueTitle.TabIndex = 0
        Me.lblRepeatDueTitle.Text = "Re&peatation Due :"
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
        'gbReminder
        '
        Me.gbReminder.Controls.Add(Me.dgvReminder)
        Me.gbReminder.Controls.Add(Me.btnAddReminder)
        Me.gbReminder.Controls.Add(Me.cboMinBefore)
        Me.gbReminder.Controls.Add(Me.lblMinBefore)
        Me.gbReminder.Location = New System.Drawing.Point(23, 383)
        Me.gbReminder.Name = "gbReminder"
        Me.gbReminder.Size = New System.Drawing.Size(402, 152)
        Me.gbReminder.TabIndex = 17
        Me.gbReminder.TabStop = False
        Me.gbReminder.Text = "Reminder"
        '
        'cboMinBefore
        '
        Me.cboMinBefore.FormattingEnabled = True
        Me.cboMinBefore.Items.AddRange(New Object() {"10 minutes", "20 minutes", "30 minutes", "40 minutes", "50 minutes", "1 hour"})
        Me.cboMinBefore.Location = New System.Drawing.Point(167, 22)
        Me.cboMinBefore.Name = "cboMinBefore"
        Me.cboMinBefore.Size = New System.Drawing.Size(158, 21)
        Me.cboMinBefore.TabIndex = 4
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnCancel.CausesValidation = False
        Me.btnCancel.FlatAppearance.BorderSize = 3
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(586, 408)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(119, 44)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
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
        'lblParticipleTitle
        '
        Me.lblParticipleTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lblParticipleTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblParticipleTitle.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParticipleTitle.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblParticipleTitle.Location = New System.Drawing.Point(3, 16)
        Me.lblParticipleTitle.Name = "lblParticipleTitle"
        Me.lblParticipleTitle.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblParticipleTitle.Size = New System.Drawing.Size(271, 40)
        Me.lblParticipleTitle.TabIndex = 1
        Me.lblParticipleTitle.Text = "Participle Names"
        Me.lblParticipleTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvParticiples
        '
        Me.dgvParticiples.AllowUserToAddRows = False
        Me.dgvParticiples.AllowUserToDeleteRows = False
        Me.dgvParticiples.AllowUserToResizeColumns = False
        Me.dgvParticiples.AllowUserToResizeRows = False
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.dgvParticiples.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvParticiples.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.dgvParticiples.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvParticiples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvParticiples.ColumnHeadersVisible = False
        Me.dgvParticiples.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvParticipleID, Me.dgvParticiplePic, Me.dgvParticipleName})
        Me.dgvParticiples.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvParticiples.GridColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.dgvParticiples.Location = New System.Drawing.Point(3, 56)
        Me.dgvParticiples.MultiSelect = False
        Me.dgvParticiples.Name = "dgvParticiples"
        Me.dgvParticiples.ReadOnly = True
        Me.dgvParticiples.RowHeadersVisible = False
        Me.dgvParticiples.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvParticiples.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvParticiples.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgvParticiples.RowTemplate.Height = 60
        Me.dgvParticiples.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvParticiples.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvParticiples.Size = New System.Drawing.Size(271, 312)
        Me.dgvParticiples.TabIndex = 0
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
        Me.dgvParticiplePic.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
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
        'gbParticiple
        '
        Me.gbParticiple.Controls.Add(Me.btnAddParti)
        Me.gbParticiple.Controls.Add(Me.lblParticipleTitle)
        Me.gbParticiple.Controls.Add(Me.dgvParticiples)
        Me.gbParticiple.Location = New System.Drawing.Point(434, 17)
        Me.gbParticiple.Name = "gbParticiple"
        Me.gbParticiple.Size = New System.Drawing.Size(277, 371)
        Me.gbParticiple.TabIndex = 16
        Me.gbParticiple.TabStop = False
        Me.gbParticiple.Text = "Participles"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnEdit.FlatAppearance.BorderSize = 3
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Green
        Me.btnEdit.Location = New System.Drawing.Point(434, 408)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(119, 44)
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "E&dit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'gbRepeat
        '
        Me.gbRepeat.Controls.Add(Me.lblRepeatBehave)
        Me.gbRepeat.Controls.Add(Me.lblRepeatDue)
        Me.gbRepeat.Controls.Add(Me.lblRepeatDueTitle)
        Me.gbRepeat.Controls.Add(Me.lblRepeatBehaveTitle)
        Me.gbRepeat.Location = New System.Drawing.Point(23, 282)
        Me.gbRepeat.Name = "gbRepeat"
        Me.gbRepeat.Size = New System.Drawing.Size(402, 95)
        Me.gbRepeat.TabIndex = 13
        Me.gbRepeat.TabStop = False
        Me.gbRepeat.Text = "Repeatation"
        '
        'lblRepeatBehave
        '
        Me.lblRepeatBehave.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepeatBehave.Location = New System.Drawing.Point(154, 52)
        Me.lblRepeatBehave.Name = "lblRepeatBehave"
        Me.lblRepeatBehave.Size = New System.Drawing.Size(220, 23)
        Me.lblRepeatBehave.TabIndex = 11
        Me.lblRepeatBehave.Text = "Behavior type"
        Me.lblRepeatBehave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRepeatDue
        '
        Me.lblRepeatDue.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepeatDue.Location = New System.Drawing.Point(154, 19)
        Me.lblRepeatDue.Name = "lblRepeatDue"
        Me.lblRepeatDue.Size = New System.Drawing.Size(220, 23)
        Me.lblRepeatDue.TabIndex = 11
        Me.lblRepeatDue.Text = "repeatation due"
        Me.lblRepeatDue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEndTitle
        '
        Me.lblEndTitle.AutoSize = True
        Me.lblEndTitle.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblEndTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblEndTitle.Location = New System.Drawing.Point(6, 57)
        Me.lblEndTitle.Name = "lblEndTitle"
        Me.lblEndTitle.Size = New System.Drawing.Size(119, 13)
        Me.lblEndTitle.TabIndex = 2
        Me.lblEndTitle.Text = "Activity &End :"
        '
        'lblTypeTitle
        '
        Me.lblTypeTitle.AutoSize = True
        Me.lblTypeTitle.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTypeTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblTypeTitle.Location = New System.Drawing.Point(6, 223)
        Me.lblTypeTitle.Name = "lblTypeTitle"
        Me.lblTypeTitle.Size = New System.Drawing.Size(127, 13)
        Me.lblTypeTitle.TabIndex = 10
        Me.lblTypeTitle.Text = "&Activity Type :"
        '
        'lblVenueTitle
        '
        Me.lblVenueTitle.AutoSize = True
        Me.lblVenueTitle.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblVenueTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblVenueTitle.Location = New System.Drawing.Point(6, 187)
        Me.lblVenueTitle.Name = "lblVenueTitle"
        Me.lblVenueTitle.Size = New System.Drawing.Size(63, 13)
        Me.lblVenueTitle.TabIndex = 8
        Me.lblVenueTitle.Text = "&Venue :"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblTitle.Location = New System.Drawing.Point(6, 88)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(135, 13)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Activity &Title :"
        '
        'lblDescriptionTitle
        '
        Me.lblDescriptionTitle.AutoSize = True
        Me.lblDescriptionTitle.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblDescriptionTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblDescriptionTitle.Location = New System.Drawing.Point(6, 119)
        Me.lblDescriptionTitle.Name = "lblDescriptionTitle"
        Me.lblDescriptionTitle.Size = New System.Drawing.Size(111, 13)
        Me.lblDescriptionTitle.TabIndex = 6
        Me.lblDescriptionTitle.Text = "Descriptio&n :"
        '
        'gbGeneral
        '
        Me.gbGeneral.Controls.Add(Me.lblActivityType)
        Me.gbGeneral.Controls.Add(Me.lblVenue)
        Me.gbGeneral.Controls.Add(Me.lblDesc)
        Me.gbGeneral.Controls.Add(Me.lblAcTitle)
        Me.gbGeneral.Controls.Add(Me.lblEnd)
        Me.gbGeneral.Controls.Add(Me.lblStart)
        Me.gbGeneral.Controls.Add(Me.lblStartTitle)
        Me.gbGeneral.Controls.Add(Me.lblEndTitle)
        Me.gbGeneral.Controls.Add(Me.lblTypeTitle)
        Me.gbGeneral.Controls.Add(Me.lblVenueTitle)
        Me.gbGeneral.Controls.Add(Me.lblTitle)
        Me.gbGeneral.Controls.Add(Me.lblDescriptionTitle)
        Me.gbGeneral.Location = New System.Drawing.Point(23, 17)
        Me.gbGeneral.Name = "gbGeneral"
        Me.gbGeneral.Size = New System.Drawing.Size(402, 259)
        Me.gbGeneral.TabIndex = 12
        Me.gbGeneral.TabStop = False
        Me.gbGeneral.Text = "General"
        '
        'lblActivityType
        '
        Me.lblActivityType.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivityType.Location = New System.Drawing.Point(146, 217)
        Me.lblActivityType.Name = "lblActivityType"
        Me.lblActivityType.Size = New System.Drawing.Size(220, 23)
        Me.lblActivityType.TabIndex = 11
        Me.lblActivityType.Text = "activity type"
        Me.lblActivityType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVenue
        '
        Me.lblVenue.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenue.Location = New System.Drawing.Point(146, 181)
        Me.lblVenue.Name = "lblVenue"
        Me.lblVenue.Size = New System.Drawing.Size(220, 23)
        Me.lblVenue.TabIndex = 11
        Me.lblVenue.Text = "Venue"
        Me.lblVenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDesc
        '
        Me.lblDesc.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(146, 113)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(220, 68)
        Me.lblDesc.TabIndex = 11
        Me.lblDesc.Text = "Description"
        '
        'lblAcTitle
        '
        Me.lblAcTitle.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcTitle.Location = New System.Drawing.Point(147, 82)
        Me.lblAcTitle.Name = "lblAcTitle"
        Me.lblAcTitle.Size = New System.Drawing.Size(220, 23)
        Me.lblAcTitle.TabIndex = 11
        Me.lblAcTitle.Text = "Title"
        Me.lblAcTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEnd
        '
        Me.lblEnd.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.Location = New System.Drawing.Point(147, 51)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(220, 23)
        Me.lblEnd.TabIndex = 11
        Me.lblEnd.Text = "end Date"
        Me.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStart
        '
        Me.lblStart.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.Location = New System.Drawing.Point(147, 20)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(220, 23)
        Me.lblStart.TabIndex = 11
        Me.lblStart.Text = "start date"
        Me.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStartTitle
        '
        Me.lblStartTitle.AutoSize = True
        Me.lblStartTitle.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblStartTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblStartTitle.Location = New System.Drawing.Point(6, 26)
        Me.lblStartTitle.Name = "lblStartTitle"
        Me.lblStartTitle.Size = New System.Drawing.Size(135, 13)
        Me.lblStartTitle.TabIndex = 0
        Me.lblStartTitle.Text = "Activity &Start :"
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Silver
        Me.btnRemove.CausesValidation = False
        Me.btnRemove.FlatAppearance.BorderSize = 3
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.Black
        Me.btnRemove.Location = New System.Drawing.Point(434, 492)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(271, 37)
        Me.btnRemove.TabIndex = 14
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'ScheduleDetailView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gbReminder)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.gbParticiple)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.gbRepeat)
        Me.Controls.Add(Me.gbGeneral)
        Me.Name = "ScheduleDetailView"
        Me.Size = New System.Drawing.Size(729, 558)
        CType(Me.dgvReminder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbReminder.ResumeLayout(False)
        Me.gbReminder.PerformLayout()
        CType(Me.btnAddParti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvParticiples, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbParticiple.ResumeLayout(False)
        Me.gbRepeat.ResumeLayout(False)
        Me.gbRepeat.PerformLayout()
        Me.gbGeneral.ResumeLayout(False)
        Me.gbGeneral.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvReminder As DataGridView
    Friend WithEvents btnAddReminder As Button
    Friend WithEvents lblMinBefore As Label
    Friend WithEvents lblRepeatDueTitle As Label
    Friend WithEvents lblRepeatBehaveTitle As Label
    Friend WithEvents gbReminder As GroupBox
    Friend WithEvents cboMinBefore As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents gbParticiple As GroupBox
    Friend WithEvents btnAddParti As PictureBox
    Friend WithEvents lblParticipleTitle As Label
    Friend WithEvents dgvParticiples As DataGridView
    Friend WithEvents btnEdit As Button
    Friend WithEvents gbRepeat As GroupBox
    Friend WithEvents gbGeneral As GroupBox
    Friend WithEvents lblStartTitle As Label
    Friend WithEvents lblEndTitle As Label
    Friend WithEvents lblTypeTitle As Label
    Friend WithEvents lblVenueTitle As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDescriptionTitle As Label
    Friend WithEvents lblRepeatBehave As Label
    Friend WithEvents lblRepeatDue As Label
    Friend WithEvents lblActivityType As Label
    Friend WithEvents lblVenue As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblAcTitle As Label
    Friend WithEvents lblEnd As Label
    Friend WithEvents lblStart As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents dgvParticipleID As DataGridViewTextBoxColumn
    Friend WithEvents dgvParticiplePic As DataGridViewImageColumn
    Friend WithEvents dgvParticipleName As DataGridViewTextBoxColumn
End Class
