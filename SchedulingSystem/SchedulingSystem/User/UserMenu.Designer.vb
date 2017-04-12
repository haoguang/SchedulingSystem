<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserMenu))
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnProfile
        '
        Me.btnProfile.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnProfile.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProfile.FlatAppearance.BorderSize = 0
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfile.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.Image = CType(resources.GetObject("btnProfile.Image"), System.Drawing.Image)
        Me.btnProfile.Location = New System.Drawing.Point(4, 0)
        Me.btnProfile.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(217, 73)
        Me.btnProfile.TabIndex = 0
        Me.btnProfile.Text = "  Profile"
        Me.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProfile.UseVisualStyleBackColor = False
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Image = CType(resources.GetObject("btnLogOut.Image"), System.Drawing.Image)
        Me.btnLogOut.Location = New System.Drawing.Point(4, 73)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(217, 73)
        Me.btnLogOut.TabIndex = 1
        Me.btnLogOut.Text = "  Logout"
        Me.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'UserMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnProfile)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "UserMenu"
        Me.Padding = New System.Windows.Forms.Padding(4, 0, 4, 4)
        Me.Size = New System.Drawing.Size(225, 148)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnProfile As Button
    Friend WithEvents btnLogOut As Button
End Class
