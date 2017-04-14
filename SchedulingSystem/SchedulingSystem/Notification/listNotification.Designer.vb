<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listNotification
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
        Me.lstNotification = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstNotification
        '
        Me.lstNotification.FormattingEnabled = True
        Me.lstNotification.Location = New System.Drawing.Point(16, 13)
        Me.lstNotification.Name = "lstNotification"
        Me.lstNotification.Size = New System.Drawing.Size(475, 277)
        Me.lstNotification.TabIndex = 0
        '
        'listNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lstNotification)
        Me.Name = "listNotification"
        Me.Size = New System.Drawing.Size(508, 301)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstNotification As ListBox
End Class
