<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleSidePanel
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
        Me.btnMySchedule = New System.Windows.Forms.Button()
        Me.btnAddSchedule = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMySchedule
        '
        Me.btnMySchedule.BackColor = System.Drawing.Color.Transparent
        Me.btnMySchedule.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMySchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMySchedule.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMySchedule.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnMySchedule.Location = New System.Drawing.Point(0, 0)
        Me.btnMySchedule.Name = "btnMySchedule"
        Me.btnMySchedule.Size = New System.Drawing.Size(300, 62)
        Me.btnMySchedule.TabIndex = 0
        Me.btnMySchedule.Text = "My Schedule"
        Me.btnMySchedule.UseVisualStyleBackColor = False
        '
        'btnAddSchedule
        '
        Me.btnAddSchedule.BackColor = System.Drawing.Color.Transparent
        Me.btnAddSchedule.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAddSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSchedule.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSchedule.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnAddSchedule.Location = New System.Drawing.Point(0, 62)
        Me.btnAddSchedule.Name = "btnAddSchedule"
        Me.btnAddSchedule.Size = New System.Drawing.Size(300, 62)
        Me.btnAddSchedule.TabIndex = 1
        Me.btnAddSchedule.Text = "Add Schedule"
        Me.btnAddSchedule.UseVisualStyleBackColor = False
        '
        'ScheduleSidePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnAddSchedule)
        Me.Controls.Add(Me.btnMySchedule)
        Me.Name = "ScheduleSidePanel"
        Me.Size = New System.Drawing.Size(300, 313)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMySchedule As Button
    Friend WithEvents btnAddSchedule As Button
End Class
