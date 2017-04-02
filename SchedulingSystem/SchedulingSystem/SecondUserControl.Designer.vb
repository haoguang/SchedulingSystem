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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.mcDate = New System.Windows.Forms.MonthCalendar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnAppointment = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.gbTimetable = New System.Windows.Forms.GroupBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gbTimetable.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDate)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.mcDate)
        Me.GroupBox1.Location = New System.Drawing.Point(86, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 266)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Schedule"
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
        Me.btnSearch.Location = New System.Drawing.Point(112, 226)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'mcDate
        '
        Me.mcDate.Location = New System.Drawing.Point(112, 52)
        Me.mcDate.Name = "mcDate"
        Me.mcDate.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(57, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Time"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(159, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Status"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(57, 58)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(232, 56)
        Me.ListBox1.TabIndex = 3
        '
        'btnAppointment
        '
        Me.btnAppointment.Enabled = False
        Me.btnAppointment.Location = New System.Drawing.Point(96, 153)
        Me.btnAppointment.Name = "btnAppointment"
        Me.btnAppointment.Size = New System.Drawing.Size(116, 23)
        Me.btnAppointment.TabIndex = 4
        Me.btnAppointment.Text = "Make Appointment"
        Me.btnAppointment.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(112, 16)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 7
        '
        'gbTimetable
        '
        Me.gbTimetable.Controls.Add(Me.ListBox1)
        Me.gbTimetable.Controls.Add(Me.btnAppointment)
        Me.gbTimetable.Controls.Add(Me.Label3)
        Me.gbTimetable.Controls.Add(Me.Label4)
        Me.gbTimetable.Location = New System.Drawing.Point(86, 302)
        Me.gbTimetable.Name = "gbTimetable"
        Me.gbTimetable.Size = New System.Drawing.Size(371, 196)
        Me.gbTimetable.TabIndex = 5
        Me.gbTimetable.TabStop = False
        Me.gbTimetable.Text = "Timetable"
        Me.gbTimetable.Visible = False
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
        'SecondUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gbTimetable)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SecondUserControl"
        Me.Size = New System.Drawing.Size(572, 609)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbTimetable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mcDate As MonthCalendar
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAppointment As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents gbTimetable As GroupBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblName As Label
End Class
