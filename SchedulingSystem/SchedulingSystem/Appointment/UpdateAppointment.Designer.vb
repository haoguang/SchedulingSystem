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
        Me.dgvRecord = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.gbOngoing.SuspendLayout()
        CType(Me.dgvRecord, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gbOngoing.Controls.Add(Me.txtTitle)
        Me.gbOngoing.Controls.Add(Me.Label1)
        Me.gbOngoing.Controls.Add(Me.dgvRecord)
        Me.gbOngoing.Font = New System.Drawing.Font("NSimSun", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOngoing.ForeColor = System.Drawing.Color.DarkGreen
        Me.gbOngoing.Location = New System.Drawing.Point(38, 86)
        Me.gbOngoing.Name = "gbOngoing"
        Me.gbOngoing.Size = New System.Drawing.Size(963, 315)
        Me.gbOngoing.TabIndex = 4
        Me.gbOngoing.TabStop = False
        Me.gbOngoing.Text = "Ongoing Appointment"
        '
        'dgvRecord
        '
        Me.dgvRecord.AllowUserToAddRows = False
        Me.dgvRecord.AllowUserToDeleteRows = False
        Me.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecord.Location = New System.Drawing.Point(24, 74)
        Me.dgvRecord.Name = "dgvRecord"
        Me.dgvRecord.ReadOnly = True
        Me.dgvRecord.Size = New System.Drawing.Size(897, 200)
        Me.dgvRecord.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search by &Title :"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(204, 39)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(119, 26)
        Me.txtTitle.TabIndex = 3
        '
        'UpdateAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gbOngoing)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "UpdateAppointment"
        Me.Size = New System.Drawing.Size(1063, 484)
        Me.gbOngoing.ResumeLayout(False)
        Me.gbOngoing.PerformLayout()
        CType(Me.dgvRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents gbOngoing As GroupBox
    Friend WithEvents dgvRecord As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitle As TextBox
End Class
