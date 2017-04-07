<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListFriend
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblgender = New System.Windows.Forms.Label()
        Me.lblhobby = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.Status = New System.Windows.Forms.Label()
        Me.lbloccupation = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(246, 146)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(53, 17)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(246, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID :"
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Location = New System.Drawing.Point(245, 206)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(64, 17)
        Me.lblgender.TabIndex = 2
        Me.lblgender.Text = "Gender :"
        '
        'lblhobby
        '
        Me.lblhobby.AutoSize = True
        Me.lblhobby.Location = New System.Drawing.Point(246, 266)
        Me.lblhobby.Name = "lblhobby"
        Me.lblhobby.Size = New System.Drawing.Size(57, 17)
        Me.lblhobby.TabIndex = 4
        Me.lblhobby.Text = "Hobby :"
        Me.lblhobby.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(343, 326)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(121, 31)
        Me.btn_update.TabIndex = 11
        Me.btn_update.Text = "&Update Status"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.Location = New System.Drawing.Point(470, 326)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(102, 32)
        Me.btn_del.TabIndex = 12
        Me.btn_del.Text = "&Unfriend"
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Location = New System.Drawing.Point(246, 294)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(56, 17)
        Me.Status.TabIndex = 13
        Me.Status.Text = "Status :"
        '
        'lbloccupation
        '
        Me.lbloccupation.AutoSize = True
        Me.lbloccupation.Location = New System.Drawing.Point(246, 238)
        Me.lbloccupation.Name = "lbloccupation"
        Me.lbloccupation.Size = New System.Drawing.Size(88, 17)
        Me.lbloccupation.TabIndex = 3
        Me.lbloccupation.Text = "Occupation :"
        '
        'ListFriend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.lblhobby)
        Me.Controls.Add(Me.lbloccupation)
        Me.Controls.Add(Me.lblgender)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblName)
        Me.Name = "ListFriend"
        Me.Size = New System.Drawing.Size(1010, 569)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblgender As Label
    Friend WithEvents lblhobby As Label
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_del As Button
    Friend WithEvents Status As Label
    Friend WithEvents lbloccupation As Label
End Class
