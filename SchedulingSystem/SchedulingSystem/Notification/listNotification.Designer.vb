<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class listNotification
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
        Me.lstANotification = New System.Windows.Forms.ListBox()
        Me.lblANoticeAvailable = New System.Windows.Forms.Label()
        Me.lblFNoticeAvailable = New System.Windows.Forms.Label()
        Me.lstFNotification = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstANotification
        '
        Me.lstANotification.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstANotification.FormattingEnabled = True
        Me.lstANotification.ItemHeight = 18
        Me.lstANotification.Location = New System.Drawing.Point(16, 13)
        Me.lstANotification.Name = "lstANotification"
        Me.lstANotification.Size = New System.Drawing.Size(476, 364)
        Me.lstANotification.TabIndex = 0
        '
        'lblANoticeAvailable
        '
        Me.lblANoticeAvailable.Location = New System.Drawing.Point(13, 392)
        Me.lblANoticeAvailable.Name = "lblANoticeAvailable"
        Me.lblANoticeAvailable.Size = New System.Drawing.Size(315, 23)
        Me.lblANoticeAvailable.TabIndex = 1
        '
        'lblFNoticeAvailable
        '
        Me.lblFNoticeAvailable.Location = New System.Drawing.Point(518, 392)
        Me.lblFNoticeAvailable.Name = "lblFNoticeAvailable"
        Me.lblFNoticeAvailable.Size = New System.Drawing.Size(290, 23)
        Me.lblFNoticeAvailable.TabIndex = 2
        '
        'lstFNotification
        '
        Me.lstFNotification.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFNotification.FormattingEnabled = True
        Me.lstFNotification.ItemHeight = 18
        Me.lstFNotification.Location = New System.Drawing.Point(521, 13)
        Me.lstFNotification.Name = "lstFNotification"
        Me.lstFNotification.Size = New System.Drawing.Size(476, 364)
        Me.lstFNotification.TabIndex = 3
        '
        'listNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lstFNotification)
        Me.Controls.Add(Me.lblFNoticeAvailable)
        Me.Controls.Add(Me.lblANoticeAvailable)
        Me.Controls.Add(Me.lstANotification)
        Me.Name = "listNotification"
        Me.Size = New System.Drawing.Size(1013, 433)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstANotification As ListBox
    Friend WithEvents lblANoticeAvailable As Label
    Friend WithEvents lblFNoticeAvailable As Label
    Friend WithEvents lstFNotification As ListBox
End Class
