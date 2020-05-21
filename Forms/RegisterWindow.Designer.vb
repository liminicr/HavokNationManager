<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterWindow
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
        Dim DOBLabel As System.Windows.Forms.Label
        Dim Customer_NameLabel As System.Windows.Forms.Label
        Dim E_mailLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterWindow))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Male = New System.Windows.Forms.RadioButton()
        Me.Female = New System.Windows.Forms.RadioButton()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.DOBPicker = New System.Windows.Forms.DateTimePicker()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Customer_DBTableAdapter = New WindowsApplication1.Customer_DBDataSetTableAdapters.Customer_DBTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.BtnMain = New System.Windows.Forms.Button()
        DOBLabel = New System.Windows.Forms.Label()
        Customer_NameLabel = New System.Windows.Forms.Label()
        E_mailLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Font = New System.Drawing.Font("Malgun Gothic", 11.0!)
        DOBLabel.Location = New System.Drawing.Point(12, 138)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(56, 25)
        DOBLabel.TabIndex = 35
        DOBLabel.Text = "DOB:"
        '
        'Customer_NameLabel
        '
        Customer_NameLabel.AutoSize = True
        Customer_NameLabel.Font = New System.Drawing.Font("Malgun Gothic", 11.0!)
        Customer_NameLabel.Location = New System.Drawing.Point(4, 22)
        Customer_NameLabel.Name = "Customer_NameLabel"
        Customer_NameLabel.Size = New System.Drawing.Size(166, 25)
        Customer_NameLabel.TabIndex = 31
        Customer_NameLabel.Text = "*Customer Name:"
        '
        'E_mailLabel
        '
        E_mailLabel.AutoSize = True
        E_mailLabel.Font = New System.Drawing.Font("Malgun Gothic", 11.0!)
        E_mailLabel.Location = New System.Drawing.Point(12, 97)
        E_mailLabel.Name = "E_mailLabel"
        E_mailLabel.Size = New System.Drawing.Size(71, 25)
        E_mailLabel.TabIndex = 34
        E_mailLabel.Text = "E-mail:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Malgun Gothic", 11.0!)
        GenderLabel.Location = New System.Drawing.Point(12, 58)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(78, 25)
        GenderLabel.TabIndex = 32
        GenderLabel.Text = "Gender:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Malgun Gothic", 11.0!)
        Label2.Location = New System.Drawing.Point(12, 181)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(84, 25)
        Label2.TabIndex = 46
        Label2.Text = "Address:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Malgun Gothic", 11.0!)
        Label3.Location = New System.Drawing.Point(12, 223)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(161, 25)
        Label3.TabIndex = 48
        Label3.Text = "Contact Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 41)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Customer registration"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Malgun Gothic", 11.0!)
        Me.txtName.Location = New System.Drawing.Point(205, 18)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(337, 32)
        Me.txtName.TabIndex = 37
        '
        'Male
        '
        Me.Male.AutoSize = True
        Me.Male.Checked = True
        Me.Male.Font = New System.Drawing.Font("Malgun Gothic", 11.0!)
        Me.Male.Location = New System.Drawing.Point(209, 56)
        Me.Male.Name = "Male"
        Me.Male.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Male.Size = New System.Drawing.Size(75, 29)
        Me.Male.TabIndex = 38
        Me.Male.TabStop = True
        Me.Male.Text = "Male"
        Me.Male.UseVisualStyleBackColor = True
        '
        'Female
        '
        Me.Female.AutoSize = True
        Me.Female.Font = New System.Drawing.Font("Malgun Gothic", 11.0!)
        Me.Female.Location = New System.Drawing.Point(330, 56)
        Me.Female.Name = "Female"
        Me.Female.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Female.Size = New System.Drawing.Size(94, 29)
        Me.Female.TabIndex = 39
        Me.Female.Text = "Female"
        Me.Female.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Malgun Gothic", 11.0!)
        Me.txtEmail.Location = New System.Drawing.Point(205, 93)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(337, 32)
        Me.txtEmail.TabIndex = 41
        '
        'DOBPicker
        '
        Me.DOBPicker.Font = New System.Drawing.Font("Malgun Gothic", 11.0!)
        Me.DOBPicker.Location = New System.Drawing.Point(205, 135)
        Me.DOBPicker.Name = "DOBPicker"
        Me.DOBPicker.Size = New System.Drawing.Size(237, 32)
        Me.DOBPicker.TabIndex = 42
        Me.DOBPicker.Value = New Date(1990, 1, 1, 0, 0, 0, 0)
        '
        'BtnNew
        '
        Me.BtnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnNew.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNew.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        Me.BtnNew.Location = New System.Drawing.Point(0, 293)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.BtnNew.Size = New System.Drawing.Size(558, 45)
        Me.BtnNew.TabIndex = 49
        Me.BtnNew.Text = "Register"
        Me.BtnNew.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnNew.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cancel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        Me.Cancel.Location = New System.Drawing.Point(0, 383)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Cancel.Size = New System.Drawing.Size(558, 45)
        Me.Cancel.TabIndex = 51
        Me.Cancel.Text = "Cancel"
        Me.Cancel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'Customer_DBTableAdapter
        '
        Me.Customer_DBTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtContact)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.BtnNew)
        Me.Panel1.Controls.Add(Me.BtnMain)
        Me.Panel1.Controls.Add(Me.Cancel)
        Me.Panel1.Controls.Add(Me.DOBPicker)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.Female)
        Me.Panel1.Controls.Add(Me.Male)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(DOBLabel)
        Me.Panel1.Controls.Add(Customer_NameLabel)
        Me.Panel1.Controls.Add(E_mailLabel)
        Me.Panel1.Controls.Add(GenderLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(558, 428)
        Me.Panel1.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(435, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 23)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "* Mandatory"
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Malgun Gothic", 11.0!)
        Me.txtContact.Location = New System.Drawing.Point(205, 219)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(337, 32)
        Me.txtContact.TabIndex = 44
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Malgun Gothic", 11.0!)
        Me.txtAddress.Location = New System.Drawing.Point(205, 177)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(337, 32)
        Me.txtAddress.TabIndex = 43
        '
        'BtnMain
        '
        Me.BtnMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnMain.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMain.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        Me.BtnMain.Location = New System.Drawing.Point(0, 338)
        Me.BtnMain.Name = "BtnMain"
        Me.BtnMain.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.BtnMain.Size = New System.Drawing.Size(558, 45)
        Me.BtnMain.TabIndex = 50
        Me.BtnMain.Text = "Main"
        Me.BtnMain.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnMain.UseVisualStyleBackColor = False
        '
        'RegisterWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(558, 469)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegisterWindow"
        Me.Text = "Registration"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Male As System.Windows.Forms.RadioButton
    Friend WithEvents Female As System.Windows.Forms.RadioButton
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents DOBPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Customer_DBTableAdapter As WindowsApplication1.Customer_DBDataSetTableAdapters.Customer_DBTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnMain As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
End Class
