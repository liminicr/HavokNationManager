<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatusWindow
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StatusWindow))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Payment = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Time_Status = New System.Windows.Forms.Label()
        Me.Name_Status = New System.Windows.Forms.Label()
        Me.Financial_DBTableAdapter = New WindowsApplication1.Customer_DBDataSetTableAdapters.Financial_DBTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.time_out = New System.Windows.Forms.Label()
        Me.time_in = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PC = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Qty_Redbull = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Qty_MtDew = New System.Windows.Forms.NumericUpDown()
        Me.Qty_Fanta = New System.Windows.Forms.NumericUpDown()
        Me.Qty_Coke = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Qty_Water = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Bill = New System.Windows.Forms.TextBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Discard = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Qty_Redbull, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Qty_MtDew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Qty_Fanta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Qty_Coke, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Qty_Water, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 35)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(251, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 35)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Time:"
        '
        'Payment
        '
        Me.Payment.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Payment.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Payment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Payment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Payment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Payment.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Payment.Location = New System.Drawing.Point(0, 410)
        Me.Payment.Name = "Payment"
        Me.Payment.Size = New System.Drawing.Size(576, 44)
        Me.Payment.TabIndex = 7
        Me.Payment.Text = "Payment"
        Me.Payment.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Time_Status
        '
        Me.Time_Status.AutoSize = True
        Me.Time_Status.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time_Status.Location = New System.Drawing.Point(251, 32)
        Me.Time_Status.Name = "Time_Status"
        Me.Time_Status.Size = New System.Drawing.Size(24, 35)
        Me.Time_Status.TabIndex = 9
        Me.Time_Status.Text = "-"
        '
        'Name_Status
        '
        Me.Name_Status.AutoSize = True
        Me.Name_Status.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_Status.Location = New System.Drawing.Point(9, 30)
        Me.Name_Status.Name = "Name_Status"
        Me.Name_Status.Size = New System.Drawing.Size(24, 35)
        Me.Name_Status.TabIndex = 10
        Me.Name_Status.Text = "-"
        '
        'Financial_DBTableAdapter
        '
        Me.Financial_DBTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Name_Status)
        Me.Panel1.Controls.Add(Me.time_out)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.time_in)
        Me.Panel1.Controls.Add(Me.Time_Status)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(576, 100)
        Me.Panel1.TabIndex = 20
        '
        'time_out
        '
        Me.time_out.AutoSize = True
        Me.time_out.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_out.Location = New System.Drawing.Point(245, 72)
        Me.time_out.Name = "time_out"
        Me.time_out.Size = New System.Drawing.Size(15, 21)
        Me.time_out.TabIndex = 26
        Me.time_out.Text = "-"
        Me.time_out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'time_in
        '
        Me.time_in.AutoSize = True
        Me.time_in.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_in.Location = New System.Drawing.Point(76, 72)
        Me.time_in.Name = "time_in"
        Me.time_in.Size = New System.Drawing.Size(15, 21)
        Me.time_in.TabIndex = 25
        Me.time_in.Text = "-"
        Me.time_in.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(160, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 21)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Time-Out :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 21)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Time-In :"
        '
        'PC
        '
        Me.PC.AutoSize = True
        Me.PC.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.PC.Location = New System.Drawing.Point(3, 0)
        Me.PC.Name = "PC"
        Me.PC.Size = New System.Drawing.Size(23, 33)
        Me.PC.TabIndex = 21
        Me.PC.Text = "-"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Qty_Redbull)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Qty_MtDew)
        Me.Panel2.Controls.Add(Me.Qty_Fanta)
        Me.Panel2.Controls.Add(Me.Qty_Coke)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Qty_Water)
        Me.Panel2.Location = New System.Drawing.Point(3, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(179, 244)
        Me.Panel2.TabIndex = 22
        '
        'Qty_Redbull
        '
        Me.Qty_Redbull.BackColor = System.Drawing.SystemColors.Control
        Me.Qty_Redbull.Font = New System.Drawing.Font("Calibri", 13.8!)
        Me.Qty_Redbull.Location = New System.Drawing.Point(100, 186)
        Me.Qty_Redbull.Name = "Qty_Redbull"
        Me.Qty_Redbull.Size = New System.Drawing.Size(55, 36)
        Me.Qty_Redbull.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 13.8!)
        Me.Label15.Location = New System.Drawing.Point(7, 189)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 29)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Redbull"
        '
        'Qty_MtDew
        '
        Me.Qty_MtDew.BackColor = System.Drawing.SystemColors.Control
        Me.Qty_MtDew.Font = New System.Drawing.Font("Calibri", 13.8!)
        Me.Qty_MtDew.Location = New System.Drawing.Point(100, 144)
        Me.Qty_MtDew.Name = "Qty_MtDew"
        Me.Qty_MtDew.Size = New System.Drawing.Size(55, 36)
        Me.Qty_MtDew.TabIndex = 8
        '
        'Qty_Fanta
        '
        Me.Qty_Fanta.BackColor = System.Drawing.SystemColors.Control
        Me.Qty_Fanta.Font = New System.Drawing.Font("Calibri", 13.8!)
        Me.Qty_Fanta.Location = New System.Drawing.Point(100, 102)
        Me.Qty_Fanta.Name = "Qty_Fanta"
        Me.Qty_Fanta.Size = New System.Drawing.Size(55, 36)
        Me.Qty_Fanta.TabIndex = 7
        '
        'Qty_Coke
        '
        Me.Qty_Coke.BackColor = System.Drawing.SystemColors.Control
        Me.Qty_Coke.Font = New System.Drawing.Font("Calibri", 13.8!)
        Me.Qty_Coke.Location = New System.Drawing.Point(100, 60)
        Me.Qty_Coke.Name = "Qty_Coke"
        Me.Qty_Coke.Size = New System.Drawing.Size(55, 36)
        Me.Qty_Coke.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 13.8!)
        Me.Label14.Location = New System.Drawing.Point(7, 147)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 29)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "MtDew"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 13.8!)
        Me.Label13.Location = New System.Drawing.Point(7, 105)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 29)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Fanta"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 13.8!)
        Me.Label12.Location = New System.Drawing.Point(7, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 29)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Coke"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 13.8!)
        Me.Label11.Location = New System.Drawing.Point(7, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 29)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Water"
        '
        'Qty_Water
        '
        Me.Qty_Water.BackColor = System.Drawing.SystemColors.Control
        Me.Qty_Water.Font = New System.Drawing.Font("Calibri", 13.8!)
        Me.Qty_Water.Location = New System.Drawing.Point(100, 18)
        Me.Qty_Water.Name = "Qty_Water"
        Me.Qty_Water.Size = New System.Drawing.Size(55, 36)
        Me.Qty_Water.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.Bill)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(265, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 381)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bill"
        '
        'Bill
        '
        Me.Bill.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Bill.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Bill.Location = New System.Drawing.Point(3, 28)
        Me.Bill.Multiline = True
        Me.Bill.Name = "Bill"
        Me.Bill.ReadOnly = True
        Me.Bill.Size = New System.Drawing.Size(293, 350)
        Me.Bill.TabIndex = 0
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cancel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Cancel.Location = New System.Drawing.Point(0, 498)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(576, 44)
        Me.Cancel.TabIndex = 28
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Payment)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.Discard)
        Me.Panel3.Controls.Add(Me.Cancel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 142)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(576, 542)
        Me.Panel3.TabIndex = 29
        '
        'Discard
        '
        Me.Discard.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Discard.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Discard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Discard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Discard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Discard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Discard.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Discard.Location = New System.Drawing.Point(0, 454)
        Me.Discard.Name = "Discard"
        Me.Discard.Size = New System.Drawing.Size(576, 44)
        Me.Discard.TabIndex = 29
        Me.Discard.Text = "Discard"
        Me.Discard.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PC)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(576, 42)
        Me.Panel4.TabIndex = 27
        '
        'StatusWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(576, 684)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StatusWindow"
        Me.Text = "Management Window"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Qty_Redbull, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Qty_MtDew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Qty_Fanta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Qty_Coke, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Qty_Water, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Payment As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Time_Status As System.Windows.Forms.Label
    Friend WithEvents Name_Status As System.Windows.Forms.Label
    Friend WithEvents Financial_DBTableAdapter As WindowsApplication1.Customer_DBDataSetTableAdapters.Financial_DBTableAdapter
    Friend WithEvents PC As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents time_in As System.Windows.Forms.Label
    Friend WithEvents Qty_Water As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Qty_Redbull As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Qty_MtDew As System.Windows.Forms.NumericUpDown
    Friend WithEvents Qty_Fanta As System.Windows.Forms.NumericUpDown
    Friend WithEvents Qty_Coke As System.Windows.Forms.NumericUpDown
    Friend WithEvents time_out As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Bill As System.Windows.Forms.TextBox
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Discard As System.Windows.Forms.Button
End Class
