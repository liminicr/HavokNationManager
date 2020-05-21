<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssignWindow
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
        Dim DOBLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssignWindow))
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.Assign = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Customer_DBTableAdapter = New WindowsApplication1.Customer_DBDataSetTableAdapters.Customer_DBTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Customer_DBDataSetTableAdapters.TableAdapterManager()
        Me.Customer_DBDataGridView = New System.Windows.Forms.DataGridView()
        Me.Customer_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Customer_DBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Customer_DBDataSet = New WindowsApplication1.Customer_DBDataSet()
        Me.Customer_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Customer_NameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DOBTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Customer_IDLabel = New System.Windows.Forms.Label()
        Customer_NameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        CType(Me.Customer_DBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_DBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Customer_IDLabel
        '
        Customer_IDLabel.AutoSize = True
        Customer_IDLabel.Font = New System.Drawing.Font("Malgun Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Customer_IDLabel.Location = New System.Drawing.Point(7, 48)
        Customer_IDLabel.Name = "Customer_IDLabel"
        Customer_IDLabel.Size = New System.Drawing.Size(111, 23)
        Customer_IDLabel.TabIndex = 27
        Customer_IDLabel.Text = "Customer ID:"
        '
        'Customer_NameLabel
        '
        Customer_NameLabel.AutoSize = True
        Customer_NameLabel.Font = New System.Drawing.Font("Malgun Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Customer_NameLabel.Location = New System.Drawing.Point(7, 91)
        Customer_NameLabel.Name = "Customer_NameLabel"
        Customer_NameLabel.Size = New System.Drawing.Size(140, 23)
        Customer_NameLabel.TabIndex = 29
        Customer_NameLabel.Text = "Customer Name:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Malgun Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        GenderLabel.Location = New System.Drawing.Point(7, 133)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(70, 23)
        GenderLabel.TabIndex = 31
        GenderLabel.Text = "Gender:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Font = New System.Drawing.Font("Malgun Gothic", 10.2!)
        DOBLabel.Location = New System.Drawing.Point(7, 174)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(49, 23)
        DOBLabel.TabIndex = 47
        DOBLabel.Text = "DOB:"
        '
        'SearchBox
        '
        Me.SearchBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.SearchBox.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        Me.SearchBox.Location = New System.Drawing.Point(3, 26)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(666, 30)
        Me.SearchBox.TabIndex = 3
        '
        'Assign
        '
        Me.Assign.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Assign.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Assign.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Assign.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Assign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Assign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Assign.Font = New System.Drawing.Font("Malgun Gothic", 9.0!)
        Me.Assign.Location = New System.Drawing.Point(0, 428)
        Me.Assign.Name = "Assign"
        Me.Assign.Size = New System.Drawing.Size(365, 47)
        Me.Assign.TabIndex = 4
        Me.Assign.Text = "Assign"
        Me.Assign.UseVisualStyleBackColor = False
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
        Me.Cancel.Location = New System.Drawing.Point(0, 475)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(365, 47)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
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
        Me.Customer_DBDataGridView.AllowUserToDeleteRows = False
        Me.Customer_DBDataGridView.AllowUserToResizeColumns = False
        Me.Customer_DBDataGridView.AllowUserToResizeRows = False
        Me.Customer_DBDataGridView.AutoGenerateColumns = False
        Me.Customer_DBDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Customer_DBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Customer_DBDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Customer_ID, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6})
        Me.Customer_DBDataGridView.DataSource = Me.Customer_DBBindingSource
        Me.Customer_DBDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Customer_DBDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Customer_DBDataGridView.Location = New System.Drawing.Point(3, 56)
        Me.Customer_DBDataGridView.Name = "Customer_DBDataGridView"
        Me.Customer_DBDataGridView.ReadOnly = True
        Me.Customer_DBDataGridView.RowTemplate.Height = 27
        Me.Customer_DBDataGridView.Size = New System.Drawing.Size(666, 463)
        Me.Customer_DBDataGridView.TabIndex = 27
        '
        'Customer_ID
        '
        Me.Customer_ID.DataPropertyName = "Customer_ID"
        Me.Customer_ID.HeaderText = "Customer_ID"
        Me.Customer_ID.Name = "Customer_ID"
        Me.Customer_ID.ReadOnly = True
        Me.Customer_ID.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDformat"
        Me.DataGridViewTextBoxColumn1.FillWeight = 70.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.Width = 52
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Customer_Name"
        Me.DataGridViewTextBoxColumn2.FillWeight = 170.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.Width = 170
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn3.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'Customer_DBBindingSource
        '
        Me.Customer_DBBindingSource.DataMember = "Customer DB"
        Me.Customer_DBBindingSource.DataSource = Me.Customer_DBDataSet
        '
        'Customer_DBDataSet
        '
        Me.Customer_DBDataSet.DataSetName = "Customer_DBDataSet"
        Me.Customer_DBDataSet.Locale = New System.Globalization.CultureInfo("en")
        Me.Customer_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Customer_IDTextBox
        '
        Me.Customer_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_DBBindingSource, "IDformat", True))
        Me.Customer_IDTextBox.Font = New System.Drawing.Font("Malgun Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Customer_IDTextBox.Location = New System.Drawing.Point(152, 45)
        Me.Customer_IDTextBox.Name = "Customer_IDTextBox"
        Me.Customer_IDTextBox.ReadOnly = True
        Me.Customer_IDTextBox.Size = New System.Drawing.Size(199, 30)
        Me.Customer_IDTextBox.TabIndex = 28
        '
        'Customer_NameTextBox
        '
        Me.Customer_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_DBBindingSource, "Customer_Name", True))
        Me.Customer_NameTextBox.Font = New System.Drawing.Font("Malgun Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Customer_NameTextBox.Location = New System.Drawing.Point(152, 88)
        Me.Customer_NameTextBox.Name = "Customer_NameTextBox"
        Me.Customer_NameTextBox.ReadOnly = True
        Me.Customer_NameTextBox.Size = New System.Drawing.Size(199, 30)
        Me.Customer_NameTextBox.TabIndex = 30
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_DBBindingSource, "Gender", True))
        Me.GenderTextBox.Font = New System.Drawing.Font("Malgun Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GenderTextBox.Location = New System.Drawing.Point(152, 130)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.ReadOnly = True
        Me.GenderTextBox.Size = New System.Drawing.Size(199, 30)
        Me.GenderTextBox.TabIndex = 32
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(DOBLabel)
        Me.Panel1.Controls.Add(Me.DOBTextBox)
        Me.Panel1.Controls.Add(Me.Assign)
        Me.Panel1.Controls.Add(Me.Cancel)
        Me.Panel1.Controls.Add(Customer_IDLabel)
        Me.Panel1.Controls.Add(Me.Customer_IDTextBox)
        Me.Panel1.Controls.Add(Customer_NameLabel)
        Me.Panel1.Controls.Add(Me.Customer_NameTextBox)
        Me.Panel1.Controls.Add(GenderLabel)
        Me.Panel1.Controls.Add(Me.GenderTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(365, 522)
        Me.Panel1.TabIndex = 49
        '
        'DOBTextBox
        '
        Me.DOBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_DBBindingSource, "DOB", True))
        Me.DOBTextBox.Font = New System.Drawing.Font("Malgun Gothic", 10.2!)
        Me.DOBTextBox.Location = New System.Drawing.Point(152, 171)
        Me.DOBTextBox.Name = "DOBTextBox"
        Me.DOBTextBox.ReadOnly = True
        Me.DOBTextBox.Size = New System.Drawing.Size(199, 30)
        Me.DOBTextBox.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Malgun Gothic", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(261, 41)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Customer Assign"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Customer_DBDataGridView)
        Me.GroupBox1.Controls.Add(Me.SearchBox)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(365, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 522)
        Me.GroupBox1.TabIndex = 51
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
        Me.Panel2.Size = New System.Drawing.Size(1037, 522)
        Me.Panel2.TabIndex = 52
        '
        'AssignWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1037, 563)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AssignWindow"
        Me.ShowInTaskbar = False
        Me.Text = "Customer Assign"
        CType(Me.Customer_DBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_DBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Customer_DBDataSet As WindowsApplication1.Customer_DBDataSet
    Friend WithEvents Customer_DBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Customer_DBTableAdapter As WindowsApplication1.Customer_DBDataSetTableAdapters.Customer_DBTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Customer_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SearchBox As System.Windows.Forms.TextBox
    Friend WithEvents Assign As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Customer_DBDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Customer_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Customer_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DOBTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Customer_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
