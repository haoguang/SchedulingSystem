<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserButton
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserButton))
        Me.lblUserEmail = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.pcbProfilePic = New System.Windows.Forms.PictureBox()
        CType(Me.pcbProfilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUserEmail
        '
        Me.lblUserEmail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblUserEmail.Location = New System.Drawing.Point(69, 38)
        Me.lblUserEmail.Name = "lblUserEmail"
        Me.lblUserEmail.Size = New System.Drawing.Size(159, 31)
        Me.lblUserEmail.TabIndex = 2
        Me.lblUserEmail.Text = "abc123@bcd.com"
        Me.lblUserEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblName
        '
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(69, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(159, 38)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "My Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnMenu
        '
        Me.btnMenu.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), System.Drawing.Image)
        Me.btnMenu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMenu.Location = New System.Drawing.Point(228, 0)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(26, 69)
        Me.btnMenu.TabIndex = 1
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'pcbProfilePic
        '
        Me.pcbProfilePic.Dock = System.Windows.Forms.DockStyle.Left
        Me.pcbProfilePic.ErrorImage = CType(resources.GetObject("pcbProfilePic.ErrorImage"), System.Drawing.Image)
        Me.pcbProfilePic.Location = New System.Drawing.Point(0, 0)
        Me.pcbProfilePic.Name = "pcbProfilePic"
        Me.pcbProfilePic.Padding = New System.Windows.Forms.Padding(10)
        Me.pcbProfilePic.Size = New System.Drawing.Size(69, 69)
        Me.pcbProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbProfilePic.TabIndex = 0
        Me.pcbProfilePic.TabStop = False
        '
        'UserButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblUserEmail)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.pcbProfilePic)
        Me.Name = "UserButton"
        Me.Size = New System.Drawing.Size(254, 69)
        CType(Me.pcbProfilePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pcbProfilePic As PictureBox
    Friend WithEvents btnMenu As Button
    Friend WithEvents lblUserEmail As Label
    Friend WithEvents lblName As Label
End Class
