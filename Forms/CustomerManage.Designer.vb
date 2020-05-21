<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerManage
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
        Dim Customer_IDLabel As System.Windows.Forms.Label
        Dim Customer_NameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim E_mailLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerManage))
        Me.Customer_DBTableAdapter = New WindowsApplication1.Customer_DBDataSetTableAdapters.Customer_DBTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Customer_DBDataSetTableAdapters.TableAdapterManager()
        Me.Customer_DBDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Customer_DBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Customer_DBDataSet = New WindowsApplication1.Customer_DBDataSet()
        Me.Customer_IDTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Customer_DBDataSet1 = New WindowsApplication1.Customer_DBDataSet()
        Me.Customer_NameTextBox = New System.Windows.Forms.TextBox()
        Me.E_mailTextBox = New System.Windows.Forms.TextBox()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.ContactTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnMain = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CustomerDBFinancialDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Financial_DBTableAdapter = New WindowsApplication1.Customer_DBDataSetTableAdapters.Financial_DBTableAdapter()
        Me.CustomerDBDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Customer_IDLabel = New System.Windows.Forms.Label()
        Customer_NameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        E_mailLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.Customer_DBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_DBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_DBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.CustomerDBFinancialDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDBDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Customer_IDLabel
        '
        Customer_IDLabel.AutoSize = True
        Customer_IDLabel.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        Customer_IDLabel.Location = New System.Drawing.Point(3, 22)
        Customer_IDLabel.Name = "Customer_IDLabel"
        Customer_IDLabel.Size = New System.Drawing.Size(111, 23)
        Customer_IDLabel.TabIndex = 19
        Customer_IDLabel.Text = "Customer ID:"
        '
        'Customer_NameLabel
        '
        Customer_NameLabel.AutoSize = True
        Customer_NameLabel.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        Customer_NameLabel.Location = New System.Drawing.Point(3, 59)
        Customer_NameLabel.Name = "Customer_NameLabel"
        Customer_NameLabel.Size = New System.Drawing.Size(140, 23)
        Customer_NameLabel.TabIndex = 21
        Customer_NameLabel.Text = "Customer Name:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        GenderLabel.Location = New System.Drawing.Point(3, 96)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(70, 23)
        GenderLabel.TabIndex = 23
        GenderLabel.Text = "Gender:"
        '
        'E_mailLabel
        '
        E_mailLabel.AutoSize = True
        E_mailLabel.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        E_mailLabel.Location = New System.Drawing.Point(3, 168)
        E_mailLabel.Name = "E_mailLabel"
        E_mailLabel.Size = New System.Drawing.Size(62, 23)
        E_mailLabel.TabIndex = 27
        E_mailLabel.Text = "E-mail:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        DOBLabel.Location = New System.Drawing.Point(3, 133)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(49, 23)
        DOBLabel.TabIndex = 29
        DOBLabel.Text = "DOB:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        Label1.Location = New System.Drawing.Point(3, 204)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(74, 23)
        Label1.TabIndex = 48
        Label1.Text = "Contact:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        Label3.Location = New System.Drawing.Point(3, 240)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(74, 23)
        Label3.TabIndex = 50
        Label3.Text = "Address:"
        '
        'Customer_DBTableAdapter
        '
        Me.Customer_DBTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Customer_DBTableAdapter = Me.Customer_DBTableAdapter
        Me.TableAdapterManager.Financial_DBTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Customer_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Customer_DBDataGridView
        '
        Me.Customer_DBDataGridView.AllowUserToAddRows = False
        Me.Customer_DBDataGridView.AllowUserToOrderColumns = True
        Me.Customer_DBDataGridView.AllowUserToResizeRows = False
        Me.Customer_DBDataGridView.AutoGenerateColumns = False
        Me.Customer_DBDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Customer_DBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Customer_DBDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.Email, Me.Contact, Me.Address})
        Me.Customer_DBDataGridView.DataSource = Me.Customer_DBBindingSource
        Me.Customer_DBDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Customer_DBDataGridView.Location = New System.Drawing.Point(3, 56)
        Me.Customer_DBDataGridView.Name = "Customer_DBDataGridView"
        Me.Customer_DBDataGridView.RowTemplate.Height = 27
        Me.Customer_DBDataGridView.Size = New System.Drawing.Size(1008, 570)
        Me.Customer_DBDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDformat"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Customer_Name"
        Me.DataGridViewTextBoxColumn2.FillWeight = 120.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn3.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 60
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn6.FillWeight = 120.0!
        Me.DataGridViewTextBoxColumn6.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 120
        '
        'Email
        '
        Me.Email.DataPropertyName = "Email"
        Me.Email.FillWeight = 150.0!
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.Width = 150
        '
        'Contact
        '
        Me.Contact.DataPropertyName = "Contact"
        Me.Contact.FillWeight = 110.0!
        Me.Contact.HeaderText = "Contact"
        Me.Contact.Name = "Contact"
        Me.Contact.Width = 110
        '
        'Address
        '
        Me.Address.DataPropertyName = "Address"
        Me.Address.FillWeight = 200.0!
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.Width = 200
        '
        'Customer_DBBindingSource
        '
        Me.Customer_DBBindingSource.DataMember = "Customer DB"
        Me.Customer_DBBindingSource.DataSource = Me.Customer_DBDataSet
        '
        'Customer_DBDataSet
        '
        Me.Customer_DBDataSet.DataSetName = "Customer_DBDataSet"
        Me.Customer_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Customer_IDTextBox
        '
        Me.Customer_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDBBindingSource, "IDformat", True))
        Me.Customer_IDTextBox.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        Me.Customer_IDTextBox.Location = New System.Drawing.Point(160, 19)
        Me.Customer_IDTextBox.Name = "Customer_IDTextBox"
        Me.Customer_IDTextBox.ReadOnly = True
        Me.Customer_IDTextBox.Size = New System.Drawing.Size(314, 30)
        Me.Customer_IDTextBox.TabIndex = 20
        '
        'CustomerDBBindingSource
        '
        Me.CustomerDBBindingSource.DataMember = "Customer DB"
        Me.CustomerDBBindingSource.DataSource = Me.Customer_DBDataSet1
        '
        'Customer_DBDataSet1
        '
        Me.Customer_DBDataSet1.DataSetName = "Customer_DBDataSet"
        Me.Customer_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Customer_NameTextBox
        '
        Me.Customer_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_DBBindingSource, "Customer_Name", True))
        Me.Customer_NameTextBox.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        Me.Customer_NameTextBox.Location = New System.Drawing.Point(160, 56)
        Me.Customer_NameTextBox.Name = "Customer_NameTextBox"
        Me.Customer_NameTextBox.Size = New System.Drawing.Size(314, 30)
        Me.Customer_NameTextBox.TabIndex = 22
        '
        'E_mailTextBox
        '
        Me.E_mailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_DBBindingSource, "Email", True))
        Me.E_mailTextBox.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        Me.E_mailTextBox.Location = New System.Drawing.Point(160, 165)
        Me.E_mailTextBox.Name = "E_mailTextBox"
        Me.E_mailTextBox.Size = New System.Drawing.Size(314, 30)
        Me.E_mailTextBox.TabIndex = 28
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Customer_DBBindingSource, "DOB", True))
        Me.DOBDateTimePicker.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(160, 129)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(238, 30)
        Me.DOBDateTimePicker.TabIndex = 30
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Me.AddressTextBox)
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Controls.Add(Me.ContactTextBox)
        Me.Panel1.Controls.Add(Customer_IDLabel)
        Me.Panel1.Controls.Add(GenderLabel)
        Me.Panel1.Controls.Add(E_mailLabel)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(DOBLabel)
        Me.Panel1.Controls.Add(Me.GenderTextBox)
        Me.Panel1.Controls.Add(Me.Customer_IDTextBox)
        Me.Panel1.Controls.Add(Customer_NameLabel)
        Me.Panel1.Controls.Add(Me.DOBDateTimePicker)
        Me.Panel1.Controls.Add(Me.E_mailTextBox)
        Me.Panel1.Controls.Add(Me.Customer_NameTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(492, 629)
        Me.Panel1.TabIndex = 38
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_DBBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        Me.AddressTextBox.Location = New System.Drawing.Point(160, 237)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(314, 30)
        Me.AddressTextBox.TabIndex = 51
        '
        'ContactTextBox
        '
        Me.ContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_DBBindingSource, "Contact", True))
        Me.ContactTextBox.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        Me.ContactTextBox.Location = New System.Drawing.Point(160, 201)
        Me.ContactTextBox.Name = "ContactTextBox"
        Me.ContactTextBox.Size = New System.Drawing.Size(314, 30)
        Me.ContactTextBox.TabIndex = 49
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnMain)
        Me.Panel3.Controls.Add(Me.Cancel)
        Me.Panel3.Controls.Add(Me.BtnRemove)
        Me.Panel3.Controls.Add(Me.BtnUpdate)
        Me.Panel3.Controls.Add(Me.BtnRegister)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 365)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(492, 264)
        Me.Panel3.TabIndex = 47
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
        Me.BtnMain.Location = New System.Drawing.Point(0, 164)
        Me.BtnMain.Name = "BtnMain"
        Me.BtnMain.Size = New System.Drawing.Size(492, 50)
        Me.BtnMain.TabIndex = 47
        Me.BtnMain.Text = "Main"
        Me.BtnMain.UseVisualStyleBackColor = False
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
        Me.Cancel.Location = New System.Drawing.Point(0, 214)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(492, 50)
        Me.Cancel.TabIndex = 46
        Me.Cancel.Text = "Close"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'BtnRemove
        '
        Me.BtnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRemove.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemove.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        Me.BtnRemove.Location = New System.Drawing.Point(0, 100)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(492, 50)
        Me.BtnRemove.TabIndex = 42
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnUpdate.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        Me.BtnUpdate.Location = New System.Drawing.Point(0, 50)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(492, 50)
        Me.BtnUpdate.TabIndex = 41
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnRegister
        '
        Me.BtnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegister.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegister.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        Me.BtnRegister.Location = New System.Drawing.Point(0, 0)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(492, 50)
        Me.BtnRegister.TabIndex = 44
        Me.BtnRegister.Text = "Register"
        Me.BtnRegister.UseVisualStyleBackColor = False
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_DBBindingSource, "Gender", True))
        Me.GenderTextBox.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        Me.GenderTextBox.Location = New System.Drawing.Point(160, 93)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.ReadOnly = True
        Me.GenderTextBox.Size = New System.Drawing.Size(314, 30)
        Me.GenderTextBox.TabIndex = 36
        '
        'SearchBox
        '
        Me.SearchBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.SearchBox.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        Me.SearchBox.Location = New System.Drawing.Point(3, 26)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(1008, 30)
        Me.SearchBox.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Malgun Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(355, 41)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Customer Management"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Customer_DBDataGridView)
        Me.GroupBox1.Controls.Add(Me.SearchBox)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(492, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1014, 629)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search by name"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1506, 629)
        Me.Panel2.TabIndex = 46
        '
        'CustomerDBFinancialDBBindingSource
        '
        Me.CustomerDBFinancialDBBindingSource.DataMember = "Customer DBFinancial DB"
        Me.CustomerDBFinancialDBBindingSource.DataSource = Me.Customer_DBBindingSource
        '
        'Financial_DBTableAdapter
        '
        Me.Financial_DBTableAdapter.ClearBeforeFill = True
        '
        'CustomerManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1506, 670)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CustomerManage"
        Me.Text = "Customer Manage"
        CType(Me.Customer_DBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_DBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_DBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.CustomerDBFinancialDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDBDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Customer_DBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Customer_DBTableAdapter As WindowsApplication1.Customer_DBDataSetTableAdapters.Customer_DBTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Customer_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Customer_DBDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Customer_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Customer_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents E_mailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOBDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SearchBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnRemove As System.Windows.Forms.Button
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnRegister As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BtnMain As System.Windows.Forms.Button
    Friend WithEvents Customer_DBDataSet As WindowsApplication1.Customer_DBDataSet
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CustomerDBFinancialDBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Financial_DBTableAdapter As WindowsApplication1.Customer_DBDataSetTableAdapters.Financial_DBTableAdapter
    Friend WithEvents CustomerDBDataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Customer_DBDataSet1 As WindowsApplication1.Customer_DBDataSet
    Friend WithEvents CustomerDBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactTextBox As System.Windows.Forms.TextBox
End Class
