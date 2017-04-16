<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AppointmentSidePanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnMySchedule = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMySchedule
        '
        Me.btnMySchedule.BackColor = System.Drawing.Color.Transparent
        Me.btnMySchedule.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMySchedule.FlatAppearance.BorderSize = 0
        Me.btnMySchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMySchedule.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMySchedule.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnMySchedule.Location = New System.Drawing.Point(0, 0)
        Me.btnMySchedule.Name = "btnMySchedule"
        Me.btnMySchedule.Size = New System.Drawing.Size(300, 62)
        Me.btnMySchedule.TabIndex = 1
        Me.btnMySchedule.Text = "Create Appointment"
        Me.btnMySchedule.UseVisualStyleBackColor = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.Transparent
        Me.btnView.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnView.FlatAppearance.BorderSize = 0
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnView.Location = New System.Drawing.Point(0, 62)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(300, 62)
        Me.btnView.TabIndex = 2
        Me.btnView.Text = "View Appointment"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnUpdate.Location = New System.Drawing.Point(0, 124)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(300, 62)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update Appointment"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'AppointmentSidePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnMySchedule)
        Me.Name = "AppointmentSidePanel"
        Me.Size = New System.Drawing.Size(300, 313)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMySchedule As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnUpdate As Button
End Class
