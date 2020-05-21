<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PriceSetting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PriceSetting))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.time = New System.Windows.Forms.NumericUpDown()
        Me.Apply = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.redbull = New System.Windows.Forms.NumericUpDown()
        Me.mtdew = New System.Windows.Forms.NumericUpDown()
        Me.fanta = New System.Windows.Forms.NumericUpDown()
        Me.coke = New System.Windows.Forms.NumericUpDown()
        Me.water = New System.Windows.Forms.NumericUpDown()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.time, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.redbull, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mtdew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fanta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coke, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.water, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 13.0!)
        Me.Label1.Location = New System.Drawing.Point(9, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Time Rate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Malgun Gothic", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(253, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "₹ / hour"
        '
        'time
        '
        Me.time.Font = New System.Drawing.Font("Malgun Gothic", 10.2!)
        Me.time.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.time.Location = New System.Drawing.Point(127, 21)
        Me.time.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(120, 30)
        Me.time.TabIndex = 5
        '
        'Apply
        '
        Me.Apply.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Apply.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Apply.Enabled = False
        Me.Apply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Apply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Apply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Apply.Font = New System.Drawing.Font("Malgun Gothic", 9.0!)
        Me.Apply.Location = New System.Drawing.Point(0, 340)
        Me.Apply.Name = "Apply"
        Me.Apply.Size = New System.Drawing.Size(413, 45)
        Me.Apply.TabIndex = 9
        Me.Apply.Text = "Apply"
        Me.Apply.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cancel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("Malgun Gothic", 9.0!)
        Me.Cancel.Location = New System.Drawing.Point(0, 385)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(413, 45)
        Me.Cancel.TabIndex = 10
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Malgun Gothic", 13.0!)
        Me.Label15.Location = New System.Drawing.Point(9, 230)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 30)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Redbull"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Malgun Gothic", 13.0!)
        Me.Label14.Location = New System.Drawing.Point(9, 188)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 30)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "MtDew"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Malgun Gothic", 13.0!)
        Me.Label13.Location = New System.Drawing.Point(9, 146)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 30)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Fanta"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Malgun Gothic", 13.0!)
        Me.Label12.Location = New System.Drawing.Point(9, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 30)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Coke"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Malgun Gothic", 13.0!)
        Me.Label11.Location = New System.Drawing.Point(9, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 30)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Water"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Malgun Gothic", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 41)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Price Setting"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.redbull)
        Me.Panel1.Controls.Add(Me.mtdew)
        Me.Panel1.Controls.Add(Me.fanta)
        Me.Panel1.Controls.Add(Me.coke)
        Me.Panel1.Controls.Add(Me.water)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.time)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(375, 280)
        Me.Panel1.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Malgun Gothic", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(253, 235)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 20)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "₹ / can"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Malgun Gothic", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(253, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 20)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "₹ / can"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Malgun Gothic", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(253, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 20)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "₹ / can"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Malgun Gothic", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(253, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "₹ / can"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Malgun Gothic", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(253, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "₹ / bottle"
        '
        'redbull
        '
        Me.redbull.Font = New System.Drawing.Font("Malgun Gothic", 10.2!)
        Me.redbull.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.redbull.Location = New System.Drawing.Point(127, 230)
        Me.redbull.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.redbull.Name = "redbull"
        Me.redbull.Size = New System.Drawing.Size(120, 30)
        Me.redbull.TabIndex = 20
        '
        'mtdew
        '
        Me.mtdew.Font = New System.Drawing.Font("Malgun Gothic", 10.2!)
        Me.mtdew.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.mtdew.Location = New System.Drawing.Point(127, 188)
        Me.mtdew.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.mtdew.Name = "mtdew"
        Me.mtdew.Size = New System.Drawing.Size(120, 30)
        Me.mtdew.TabIndex = 19
        '
        'fanta
        '
        Me.fanta.Font = New System.Drawing.Font("Malgun Gothic", 10.2!)
        Me.fanta.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.fanta.Location = New System.Drawing.Point(127, 146)
        Me.fanta.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.fanta.Name = "fanta"
        Me.fanta.Size = New System.Drawing.Size(120, 30)
        Me.fanta.TabIndex = 18
        '
        'coke
        '
        Me.coke.Font = New System.Drawing.Font("Malgun Gothic", 10.2!)
        Me.coke.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.coke.Location = New System.Drawing.Point(127, 104)
        Me.coke.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.coke.Name = "coke"
        Me.coke.Size = New System.Drawing.Size(120, 30)
        Me.coke.TabIndex = 17
        '
        'water
        '
        Me.water.Font = New System.Drawing.Font("Malgun Gothic", 10.2!)
        Me.water.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.water.Location = New System.Drawing.Point(127, 62)
        Me.water.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.water.Name = "water"
        Me.water.Size = New System.Drawing.Size(120, 30)
        Me.water.TabIndex = 16
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Apply)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Cancel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(413, 430)
        Me.Panel2.TabIndex = 18
        '
        'PriceSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(413, 471)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PriceSetting"
        Me.Text = "Price Setting"
        CType(Me.time, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.redbull, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mtdew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fanta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coke, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.water, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents time As System.Windows.Forms.NumericUpDown
    Friend WithEvents Apply As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents redbull As System.Windows.Forms.NumericUpDown
    Friend WithEvents mtdew As System.Windows.Forms.NumericUpDown
    Friend WithEvents fanta As System.Windows.Forms.NumericUpDown
    Friend WithEvents coke As System.Windows.Forms.NumericUpDown
    Friend WithEvents water As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
