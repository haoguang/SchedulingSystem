<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewAppointment
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
        Me.gbSelection = New System.Windows.Forms.GroupBox()
        Me.btnView = New System.Windows.Forms.Button()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvRecord = New System.Windows.Forms.DataGridView()
        Me.gbSelection.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbSelection
        '
        Me.gbSelection.Controls.Add(Me.btnView)
        Me.gbSelection.Controls.Add(Me.RadioButton3)
        Me.gbSelection.Controls.Add(Me.RadioButton2)
        Me.gbSelection.Controls.Add(Me.RadioButton1)
        Me.gbSelection.Location = New System.Drawing.Point(39, 17)
        Me.gbSelection.Name = "gbSelection"
        Me.gbSelection.Size = New System.Drawing.Size(581, 92)
        Me.gbSelection.TabIndex = 0
        Me.gbSelection.TabStop = False
        Me.gbSelection.Text = "Selection"
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(473, 39)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 23)
        Me.btnView.TabIndex = 2
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(320, 39)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(126, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Pending Appointment"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(169, 39)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(127, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Ongoing Appointment"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(24, 39)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(119, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Appointment History"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvRecord)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(581, 209)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Record"
        '
        'dgvRecord
        '
        Me.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecord.Location = New System.Drawing.Point(24, 31)
        Me.dgvRecord.Name = "dgvRecord"
        Me.dgvRecord.Size = New System.Drawing.Size(524, 150)
        Me.dgvRecord.TabIndex = 0
        '
        'ViewAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbSelection)
        Me.Name = "ViewAppointment"
        Me.Size = New System.Drawing.Size(704, 384)
        Me.gbSelection.ResumeLayout(False)
        Me.gbSelection.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbSelection As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnView As Button
    Friend WithEvents dgvRecord As DataGridView
End Class
