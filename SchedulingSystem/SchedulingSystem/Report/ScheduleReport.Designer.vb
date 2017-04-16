<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleReport
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScheduleReport))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpMonth = New System.Windows.Forms.DateTimePicker()
        Me.chtBusyTime = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dgvScheduleReport = New System.Windows.Forms.DataGridView()
        Me.dgvTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTaskRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.radDaily = New System.Windows.Forms.RadioButton()
        Me.radRange = New System.Windows.Forms.RadioButton()
        Me.radMonthly = New System.Windows.Forms.RadioButton()
        Me.lblNoRecord = New System.Windows.Forms.Label()
        Me.prtDoc = New System.Drawing.Printing.PrintDocument()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.prtPreview = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.chtBusyTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvScheduleReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(27, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(358, 18)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Schedule Report : The busiest hour in a month"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Report Month : "
        '
        'dtpMonth
        '
        Me.dtpMonth.CustomFormat = "MMMM yyyy"
        Me.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonth.Location = New System.Drawing.Point(128, 89)
        Me.dtpMonth.Name = "dtpMonth"
        Me.dtpMonth.ShowUpDown = True
        Me.dtpMonth.Size = New System.Drawing.Size(200, 20)
        Me.dtpMonth.TabIndex = 2
        '
        'chtBusyTime
        '
        Me.chtBusyTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.chtBusyTime.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chtBusyTime.Legends.Add(Legend1)
        Me.chtBusyTime.Location = New System.Drawing.Point(15, 215)
        Me.chtBusyTime.Name = "chtBusyTime"
        Me.chtBusyTime.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chtBusyTime.Series.Add(Series1)
        Me.chtBusyTime.Size = New System.Drawing.Size(325, 280)
        Me.chtBusyTime.TabIndex = 3
        Me.chtBusyTime.Text = "Chart1"
        '
        'dgvScheduleReport
        '
        Me.dgvScheduleReport.AllowUserToAddRows = False
        Me.dgvScheduleReport.AllowUserToDeleteRows = False
        Me.dgvScheduleReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvScheduleReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvScheduleReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvTime, Me.dgvTaskRate})
        Me.dgvScheduleReport.Location = New System.Drawing.Point(438, 215)
        Me.dgvScheduleReport.Name = "dgvScheduleReport"
        Me.dgvScheduleReport.ReadOnly = True
        Me.dgvScheduleReport.Size = New System.Drawing.Size(294, 263)
        Me.dgvScheduleReport.TabIndex = 4
        '
        'dgvTime
        '
        Me.dgvTime.HeaderText = "Time (Hour)"
        Me.dgvTime.Name = "dgvTime"
        Me.dgvTime.ReadOnly = True
        '
        'dgvTaskRate
        '
        Me.dgvTaskRate.HeaderText = "Task Rate (%)"
        Me.dgvTaskRate.Name = "dgvTaskRate"
        Me.dgvTaskRate.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "To"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "dd"
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(128, 52)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(60, 20)
        Me.dtpStartDate.TabIndex = 5
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CustomFormat = "dd"
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(223, 52)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(60, 20)
        Me.dtpEndDate.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Date :"
        '
        'radDaily
        '
        Me.radDaily.AutoSize = True
        Me.radDaily.Location = New System.Drawing.Point(361, 56)
        Me.radDaily.Name = "radDaily"
        Me.radDaily.Size = New System.Drawing.Size(48, 17)
        Me.radDaily.TabIndex = 7
        Me.radDaily.TabStop = True
        Me.radDaily.Text = "&Daily"
        Me.radDaily.UseVisualStyleBackColor = True
        '
        'radRange
        '
        Me.radRange.AutoSize = True
        Me.radRange.Location = New System.Drawing.Point(467, 56)
        Me.radRange.Name = "radRange"
        Me.radRange.Size = New System.Drawing.Size(57, 17)
        Me.radRange.TabIndex = 8
        Me.radRange.TabStop = True
        Me.radRange.Text = "&Range"
        Me.radRange.UseVisualStyleBackColor = True
        '
        'radMonthly
        '
        Me.radMonthly.AutoSize = True
        Me.radMonthly.Location = New System.Drawing.Point(361, 89)
        Me.radMonthly.Name = "radMonthly"
        Me.radMonthly.Size = New System.Drawing.Size(62, 17)
        Me.radMonthly.TabIndex = 9
        Me.radMonthly.TabStop = True
        Me.radMonthly.Text = "&Monthly"
        Me.radMonthly.UseVisualStyleBackColor = True
        '
        'lblNoRecord
        '
        Me.lblNoRecord.AutoSize = True
        Me.lblNoRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoRecord.ForeColor = System.Drawing.Color.DarkRed
        Me.lblNoRecord.Location = New System.Drawing.Point(12, 183)
        Me.lblNoRecord.Name = "lblNoRecord"
        Me.lblNoRecord.Size = New System.Drawing.Size(206, 16)
        Me.lblNoRecord.TabIndex = 1
        Me.lblNoRecord.Text = "**No record for the particular time."
        '
        'prtDoc
        '
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(30, 134)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 10
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'prtPreview
        '
        Me.prtPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.prtPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.prtPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.prtPreview.Enabled = True
        Me.prtPreview.Icon = CType(resources.GetObject("prtPreview.Icon"), System.Drawing.Icon)
        Me.prtPreview.Name = "prtPreview"
        Me.prtPreview.Visible = False
        '
        'ScheduleReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.radMonthly)
        Me.Controls.Add(Me.radRange)
        Me.Controls.Add(Me.radDaily)
        Me.Controls.Add(Me.dtpEndDate)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.dgvScheduleReport)
        Me.Controls.Add(Me.chtBusyTime)
        Me.Controls.Add(Me.dtpMonth)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblNoRecord)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "ScheduleReport"
        Me.Size = New System.Drawing.Size(752, 507)
        CType(Me.chtBusyTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvScheduleReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpMonth As DateTimePicker
    Friend WithEvents chtBusyTime As DataVisualization.Charting.Chart
    Friend WithEvents dgvScheduleReport As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents radDaily As RadioButton
    Friend WithEvents radRange As RadioButton
    Friend WithEvents radMonthly As RadioButton
    Friend WithEvents dgvTime As DataGridViewTextBoxColumn
    Friend WithEvents dgvTaskRate As DataGridViewTextBoxColumn
    Friend WithEvents lblNoRecord As Label
    Friend WithEvents prtDoc As Printing.PrintDocument
    Friend WithEvents btnPrint As Button
    Friend WithEvents prtPreview As PrintPreviewDialog
End Class
