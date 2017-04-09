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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAddParti = New System.Windows.Forms.PictureBox()
        Me.lblParticipleTitle = New System.Windows.Forms.Label()
        Me.dgvParticiples = New System.Windows.Forms.DataGridView()
        Me.dgvParticipleID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvParticipleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.gbGeneral.SuspendLayout()
        Me.gbRepeat.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btnAddParti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvParticiples, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.lblStartTitle.Text = "Activity Start :"
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
        Me.lblEndTitle.Size = New System.Drawing.Size(119, 13)
        Me.lblEndTitle.TabIndex = 2
        Me.lblEndTitle.Text = "Activity End :"
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
        Me.lblRepeatDueTitle.Text = "Repeatation Due :"
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
        Me.lblRepeatBehaveTitle.Text = "Repeat Behaviour :"
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
        Me.lblTitle.Text = "Activity Title :"
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
        Me.lblDescriptionTitle.Text = "Description :"
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
        Me.lblVenueTitle.Text = "Venue :"
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
        Me.lblTypeTitle.Text = "Activity Type :"
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
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(199, 20)
        Me.txtTitle.TabIndex = 5
        '
        'txtBoxDescription
        '
        Me.txtBoxDescription.Location = New System.Drawing.Point(167, 119)
        Me.txtBoxDescription.Name = "txtBoxDescription"
        Me.txtBoxDescription.Size = New System.Drawing.Size(199, 56)
        Me.txtBoxDescription.TabIndex = 7
        Me.txtBoxDescription.Text = ""
        '
        'txtVenue
        '
        Me.txtVenue.Location = New System.Drawing.Point(167, 184)
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
        Me.gbGeneral.Size = New System.Drawing.Size(383, 259)
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
        Me.gbRepeat.Size = New System.Drawing.Size(383, 95)
        Me.gbRepeat.TabIndex = 8
        Me.gbRepeat.TabStop = False
        Me.gbRepeat.Text = "Repeatation"
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDone.FlatAppearance.BorderSize = 3
        Me.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDone.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnDone.Location = New System.Drawing.Point(210, 450)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(119, 44)
        Me.btnDone.TabIndex = 9
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAddParti)
        Me.GroupBox1.Controls.Add(Me.lblParticipleTitle)
        Me.GroupBox1.Controls.Add(Me.dgvParticiples)
        Me.GroupBox1.Location = New System.Drawing.Point(423, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(277, 371)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Participles"
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
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.dgvParticiples.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvParticiples.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.dgvParticiples.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvParticiples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvParticiples.ColumnHeadersVisible = False
        Me.dgvParticiples.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvParticipleID, Me.dgvParticipleName})
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
        Me.btnCancel.FlatAppearance.BorderSize = 3
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(404, 450)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(119, 44)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'ActivityRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.gbRepeat)
        Me.Controls.Add(Me.gbGeneral)
        Me.Name = "ActivityRegister"
        Me.Size = New System.Drawing.Size(729, 540)
        Me.gbGeneral.ResumeLayout(False)
        Me.gbGeneral.PerformLayout()
        Me.gbRepeat.ResumeLayout(False)
        Me.gbRepeat.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.btnAddParti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvParticiples, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvParticiples As DataGridView
    Friend WithEvents btnAddParti As PictureBox
    Friend WithEvents lblParticipleTitle As Label
    Friend WithEvents dgvParticipleID As DataGridViewTextBoxColumn
    Friend WithEvents dgvParticipleName As DataGridViewTextBoxColumn
    Friend WithEvents btnCancel As Button
End Class
