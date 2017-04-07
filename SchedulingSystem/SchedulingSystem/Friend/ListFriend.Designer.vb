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
        Me.lbl_N = New System.Windows.Forms.Label()
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.lbl_G = New System.Windows.Forms.Label()
        Me.lbl_Oc = New System.Windows.Forms.Label()
        Me.lbl_H = New System.Windows.Forms.Label()
        Me.cbo_S = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(321, 147)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(63, 20)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(321, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID :"
        '
        'lblgender
        '
        Me.lblgender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgender.Location = New System.Drawing.Point(320, 207)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(64, 17)
        Me.lblgender.TabIndex = 2
        Me.lblgender.Text = "Gender :"
        '
        'lblhobby
        '
        Me.lblhobby.AutoSize = True
        Me.lblhobby.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhobby.Location = New System.Drawing.Point(321, 267)
        Me.lblhobby.Name = "lblhobby"
        Me.lblhobby.Size = New System.Drawing.Size(67, 20)
        Me.lblhobby.TabIndex = 4
        Me.lblhobby.Text = "Hobby :"
        Me.lblhobby.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(450, 352)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(121, 31)
        Me.btn_update.TabIndex = 11
        Me.btn_update.Text = "&Update Status"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_del.Location = New System.Drawing.Point(599, 351)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(102, 32)
        Me.btn_del.TabIndex = 12
        Me.btn_del.Text = "&Unfriend"
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.Location = New System.Drawing.Point(321, 295)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(111, 20)
        Me.Status.TabIndex = 13
        Me.Status.Text = "Relationship :"
        '
        'lbloccupation
        '
        Me.lbloccupation.AutoSize = True
        Me.lbloccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloccupation.Location = New System.Drawing.Point(321, 238)
        Me.lbloccupation.Name = "lbloccupation"
        Me.lbloccupation.Size = New System.Drawing.Size(104, 20)
        Me.lbloccupation.TabIndex = 3
        Me.lbloccupation.Text = "Occupation :"
        '
        'lbl_N
        '
        Me.lbl_N.AutoSize = True
        Me.lbl_N.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_N.Location = New System.Drawing.Point(451, 144)
        Me.lbl_N.Name = "lbl_N"
        Me.lbl_N.Size = New System.Drawing.Size(0, 20)
        Me.lbl_N.TabIndex = 14
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ID.Location = New System.Drawing.Point(450, 177)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(0, 20)
        Me.lbl_ID.TabIndex = 15
        '
        'lbl_G
        '
        Me.lbl_G.AutoSize = True
        Me.lbl_G.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_G.Location = New System.Drawing.Point(451, 206)
        Me.lbl_G.Name = "lbl_G"
        Me.lbl_G.Size = New System.Drawing.Size(0, 20)
        Me.lbl_G.TabIndex = 16
        '
        'lbl_Oc
        '
        Me.lbl_Oc.AutoSize = True
        Me.lbl_Oc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Oc.Location = New System.Drawing.Point(451, 238)
        Me.lbl_Oc.Name = "lbl_Oc"
        Me.lbl_Oc.Size = New System.Drawing.Size(0, 20)
        Me.lbl_Oc.TabIndex = 17
        '
        'lbl_H
        '
        Me.lbl_H.AutoSize = True
        Me.lbl_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_H.Location = New System.Drawing.Point(451, 267)
        Me.lbl_H.Name = "lbl_H"
        Me.lbl_H.Size = New System.Drawing.Size(0, 20)
        Me.lbl_H.TabIndex = 18
        '
        'cbo_S
        '
        Me.cbo_S.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_S.FormattingEnabled = True
        Me.cbo_S.Items.AddRange(New Object() {"Friend", "Closer Friend", "Family", "Collegue", "Pending"})
        Me.cbo_S.Location = New System.Drawing.Point(450, 295)
        Me.cbo_S.Name = "cbo_S"
        Me.cbo_S.Size = New System.Drawing.Size(151, 28)
        Me.cbo_S.TabIndex = 19
        '
        'ListFriend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cbo_S)
        Me.Controls.Add(Me.lbl_H)
        Me.Controls.Add(Me.lbl_Oc)
        Me.Controls.Add(Me.lbl_G)
        Me.Controls.Add(Me.lbl_ID)
        Me.Controls.Add(Me.lbl_N)
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
    Friend WithEvents lbl_N As Label
    Friend WithEvents lbl_ID As Label
    Friend WithEvents lbl_G As Label
    Friend WithEvents lbl_Oc As Label
    Friend WithEvents lbl_H As Label
    Friend WithEvents cbo_S As ComboBox
End Class
