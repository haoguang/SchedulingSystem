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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"abc"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.InactiveCaption, Nothing)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Cab")
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.gbGeneral.SuspendLayout()
        Me.gbRepeat.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.scheStart.CustomFormat = "dd/MM/yyyy hh:mm"
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
        Me.scheEnd.CustomFormat = "dd/MM/yyyy hh:mm"
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
        Me.btnDone.Location = New System.Drawing.Point(149, 429)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 9
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Location = New System.Drawing.Point(423, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(277, 371)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Participles"
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
        Me.ListView1.Location = New System.Drawing.Point(3, 16)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(271, 352)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Tile
        '
        'ActivityRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
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
    Friend WithEvents ListView1 As ListView
End Class
