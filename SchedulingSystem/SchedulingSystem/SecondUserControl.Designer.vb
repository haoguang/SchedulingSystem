<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SecondUserControl
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
        Me.gbSearch = New System.Windows.Forms.GroupBox()
        Me.dtSelected = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAppointment = New System.Windows.Forms.Button()
        Me.gbTimetable = New System.Windows.Forms.GroupBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.dgvTimetable = New System.Windows.Forms.DataGridView()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.gbSearch.SuspendLayout()
        Me.gbTimetable.SuspendLayout()
        CType(Me.dgvTimetable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbSearch
        '
        Me.gbSearch.Controls.Add(Me.dtSelected)
        Me.gbSearch.Controls.Add(Me.lblDate)
        Me.gbSearch.Controls.Add(Me.lblName)
        Me.gbSearch.Controls.Add(Me.txtName)
        Me.gbSearch.Controls.Add(Me.Button2)
        Me.gbSearch.Controls.Add(Me.btnSearch)
        Me.gbSearch.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSearch.ForeColor = System.Drawing.Color.DarkGreen
        Me.gbSearch.Location = New System.Drawing.Point(86, 97)
        Me.gbSearch.Name = "gbSearch"
        Me.gbSearch.Size = New System.Drawing.Size(407, 142)
        Me.gbSearch.TabIndex = 0
        Me.gbSearch.TabStop = False
        Me.gbSearch.Text = "Search Schedule"
        '
        'dtSelected
        '
        Me.dtSelected.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtSelected.Location = New System.Drawing.Point(115, 52)
        Me.dtSelected.Name = "dtSelected"
        Me.dtSelected.Size = New System.Drawing.Size(200, 22)
        Me.dtSelected.TabIndex = 10
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblDate.Location = New System.Drawing.Point(14, 52)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(95, 13)
        Me.lblDate.TabIndex = 9
        Me.lblDate.Text = "Date :"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblName.Location = New System.Drawing.Point(14, 19)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(95, 13)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "&User Name :"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(112, 16)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 22)
        Me.txtName.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(301, 239)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(8, 8)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(112, 96)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnAppointment
        '
        Me.btnAppointment.Enabled = False
        Me.btnAppointment.Location = New System.Drawing.Point(248, 255)
        Me.btnAppointment.Name = "btnAppointment"
        Me.btnAppointment.Size = New System.Drawing.Size(168, 28)
        Me.btnAppointment.TabIndex = 4
        Me.btnAppointment.Text = "Make Appointment"
        Me.btnAppointment.UseVisualStyleBackColor = True
        '
        'gbTimetable
        '
        Me.gbTimetable.Controls.Add(Me.btnBack)
        Me.gbTimetable.Controls.Add(Me.lblInfo)
        Me.gbTimetable.Controls.Add(Me.dgvTimetable)
        Me.gbTimetable.Controls.Add(Me.btnAppointment)
        Me.gbTimetable.Font = New System.Drawing.Font("NSimSun", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTimetable.ForeColor = System.Drawing.Color.DarkGreen
        Me.gbTimetable.Location = New System.Drawing.Point(86, 277)
        Me.gbTimetable.Name = "gbTimetable"
        Me.gbTimetable.Size = New System.Drawing.Size(605, 364)
        Me.gbTimetable.TabIndex = 5
        Me.gbTimetable.TabStop = False
        Me.gbTimetable.Text = "Timetable"
        Me.gbTimetable.Visible = False
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(79, 255)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 28)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInfo.Location = New System.Drawing.Point(27, 34)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(510, 18)
        Me.lblInfo.TabIndex = 6
        '
        'dgvTimetable
        '
        Me.dgvTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTimetable.Location = New System.Drawing.Point(27, 74)
        Me.dgvTimetable.Name = "dgvTimetable"
        Me.dgvTimetable.Size = New System.Drawing.Size(510, 150)
        Me.dgvTimetable.TabIndex = 5
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("NSimSun", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblTitle.Location = New System.Drawing.Point(33, 27)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(445, 43)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Create Appointment Record"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SecondUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.gbTimetable)
        Me.Controls.Add(Me.gbSearch)
        Me.Name = "SecondUserControl"
        Me.Size = New System.Drawing.Size(817, 726)
        Me.gbSearch.ResumeLayout(False)
        Me.gbSearch.PerformLayout()
        Me.gbTimetable.ResumeLayout(False)
        CType(Me.dgvTimetable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbSearch As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAppointment As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents gbTimetable As GroupBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblName As Label
    Friend WithEvents dgvTimetable As DataGridView
    Friend WithEvents dtSelected As DateTimePicker
    Friend WithEvents lblInfo As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lblTitle As Label
End Class
