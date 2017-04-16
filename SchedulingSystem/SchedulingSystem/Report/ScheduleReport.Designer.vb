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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpMonth = New System.Windows.Forms.DateTimePicker()
        Me.chtBusyTime = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dgvScheduleReport = New System.Windows.Forms.DataGridView()
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
        Me.lblTitle.Size = New System.Drawing.Size(391, 18)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Schedule Report : The busiest times in for a month"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Report Month : "
        '
        'dtpMonth
        '
        Me.dtpMonth.CustomFormat = "MMMM yyyy"
        Me.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonth.Location = New System.Drawing.Point(114, 55)
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
        Me.chtBusyTime.Location = New System.Drawing.Point(30, 100)
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
        Me.dgvScheduleReport.Location = New System.Drawing.Point(395, 100)
        Me.dgvScheduleReport.Name = "dgvScheduleReport"
        Me.dgvScheduleReport.ReadOnly = True
        Me.dgvScheduleReport.Size = New System.Drawing.Size(294, 263)
        Me.dgvScheduleReport.TabIndex = 4
        '
        'ScheduleReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvScheduleReport)
        Me.Controls.Add(Me.chtBusyTime)
        Me.Controls.Add(Me.dtpMonth)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "ScheduleReport"
        Me.Size = New System.Drawing.Size(707, 366)
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
End Class
