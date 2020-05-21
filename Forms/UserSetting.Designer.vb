<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserSetting
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.toPrice = New System.Windows.Forms.Button()
        Me.toPCname = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'toPrice
        '
        Me.toPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.toPrice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.toPrice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.toPrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.toPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.toPrice.Font = New System.Drawing.Font("Malgun Gothic", 14.0!)
        Me.toPrice.Location = New System.Drawing.Point(24, 30)
        Me.toPrice.Name = "toPrice"
        Me.toPrice.Size = New System.Drawing.Size(257, 73)
        Me.toPrice.TabIndex = 17
        Me.toPrice.Text = "Price Setting"
        Me.toPrice.UseVisualStyleBackColor = False
        '
        'toPCname
        '
        Me.toPCname.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.toPCname.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.toPCname.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.toPCname.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.toPCname.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.toPCname.Font = New System.Drawing.Font("Malgun Gothic", 14.0!)
        Me.toPCname.Location = New System.Drawing.Point(316, 30)
        Me.toPCname.Name = "toPCname"
        Me.toPCname.Size = New System.Drawing.Size(257, 73)
        Me.toPCname.TabIndex = 18
        Me.toPCname.Text = "Change PC name"
        Me.toPCname.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 41)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Please select"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.toPCname)
        Me.Panel1.Controls.Add(Me.toPrice)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(608, 142)
        Me.Panel1.TabIndex = 20
        '
        'UserSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(608, 195)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(600, 370)
        Me.MaximizeBox = False
        Me.Name = "UserSetting"
        Me.Text = "Settings"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toPrice As System.Windows.Forms.Button
    Friend WithEvents toPCname As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
