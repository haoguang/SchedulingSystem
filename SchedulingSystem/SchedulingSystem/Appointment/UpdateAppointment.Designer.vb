<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateAppointment
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.gbOngoing = New System.Windows.Forms.GroupBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvRecord = New System.Windows.Forms.DataGridView()
        Me.rbPending = New System.Windows.Forms.RadioButton()
        Me.rbOngoing = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbOngoing.SuspendLayout()
        CType(Me.dgvRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("NSimSun", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblTitle.Location = New System.Drawing.Point(21, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(446, 43)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Update Appointment Record"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbOngoing
        '
        Me.gbOngoing.Controls.Add(Me.GroupBox1)
        Me.gbOngoing.Controls.Add(Me.txtTitle)
        Me.gbOngoing.Controls.Add(Me.Label1)
        Me.gbOngoing.Controls.Add(Me.dgvRecord)
        Me.gbOngoing.Font = New System.Drawing.Font("NSimSun", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOngoing.ForeColor = System.Drawing.Color.DarkGreen
        Me.gbOngoing.Location = New System.Drawing.Point(38, 86)
        Me.gbOngoing.Name = "gbOngoing"
        Me.gbOngoing.Size = New System.Drawing.Size(830, 419)
        Me.gbOngoing.TabIndex = 4
        Me.gbOngoing.TabStop = False
        Me.gbOngoing.Text = "Appointment"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(204, 127)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(119, 26)
        Me.txtTitle.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search by &Title :"
        '
        'dgvRecord
        '
        Me.dgvRecord.AllowUserToAddRows = False
        Me.dgvRecord.AllowUserToDeleteRows = False
        Me.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecord.Location = New System.Drawing.Point(40, 171)
        Me.dgvRecord.Name = "dgvRecord"
        Me.dgvRecord.ReadOnly = True
        Me.dgvRecord.Size = New System.Drawing.Size(709, 200)
        Me.dgvRecord.TabIndex = 0
        '
        'rbPending
        '
        Me.rbPending.AutoSize = True
        Me.rbPending.Location = New System.Drawing.Point(173, 38)
        Me.rbPending.Name = "rbPending"
        Me.rbPending.Size = New System.Drawing.Size(89, 20)
        Me.rbPending.TabIndex = 5
        Me.rbPending.TabStop = True
        Me.rbPending.Text = "Pending"
        Me.rbPending.UseVisualStyleBackColor = True
        '
        'rbOngoing
        '
        Me.rbOngoing.AutoSize = True
        Me.rbOngoing.Location = New System.Drawing.Point(22, 38)
        Me.rbOngoing.Name = "rbOngoing"
        Me.rbOngoing.Size = New System.Drawing.Size(89, 20)
        Me.rbOngoing.TabIndex = 4
        Me.rbOngoing.TabStop = True
        Me.rbOngoing.Text = "Ongoing"
        Me.rbOngoing.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbPending)
        Me.GroupBox1.Controls.Add(Me.rbOngoing)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 82)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type"
        '
        'UpdateAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gbOngoing)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "UpdateAppointment"
        Me.Size = New System.Drawing.Size(895, 484)
        Me.gbOngoing.ResumeLayout(False)
        Me.gbOngoing.PerformLayout()
        CType(Me.dgvRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents gbOngoing As GroupBox
    Friend WithEvents dgvRecord As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbPending As RadioButton
    Friend WithEvents rbOngoing As RadioButton
End Class
