<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Financial
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Financial))
        Me.Financial_DBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Customer_DBDataSet = New WindowsApplication1.Customer_DBDataSet()
        Me.MonthlyQueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YearlyQueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PopDrinksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnMain = New System.Windows.Forms.Button()
        Me.Financial_DBTableAdapter = New WindowsApplication1.Customer_DBDataSetTableAdapters.Financial_DBTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Customer_DBDataSetTableAdapters.TableAdapterManager()
        Me.DailyQueryTableAdapter = New WindowsApplication1.Customer_DBDataSetTableAdapters.DailyQueryTableAdapter()
        Me.MonthlyQueryTableAdapter = New WindowsApplication1.Customer_DBDataSetTableAdapters.MonthlyQueryTableAdapter()
        Me.PopDrinksTableAdapter = New WindowsApplication1.Customer_DBDataSetTableAdapters.PopDrinksTableAdapter()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ReportViewer_Day = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ShowAllday = New System.Windows.Forms.Button()
        Me.Calendar_Day = New System.Windows.Forms.MonthCalendar()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ReportViewer_Month = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ShowAllMonth = New System.Windows.Forms.Button()
        Me.Calendar_Month = New System.Windows.Forms.MonthCalendar()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ReportViewer_Year = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShowAllyear = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Beverage = New System.Windows.Forms.TabPage()
        Me.BeverageReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShowAlldrinks = New System.Windows.Forms.Button()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.DailyQueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.Financial_DBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonthlyQueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YearlyQueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopDrinksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Beverage.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DailyQueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Financial_DBBindingSource
        '
        Me.Financial_DBBindingSource.DataMember = "Financial DB"
        Me.Financial_DBBindingSource.DataSource = Me.Customer_DBDataSet
        '
        'Customer_DBDataSet
        '
        Me.Customer_DBDataSet.DataSetName = "Customer_DBDataSet"
        Me.Customer_DBDataSet.Locale = New System.Globalization.CultureInfo("en")
        Me.Customer_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MonthlyQueryBindingSource
        '
        Me.MonthlyQueryBindingSource.DataMember = "DailyQuery"
        Me.MonthlyQueryBindingSource.DataSource = Me.Customer_DBDataSet
        '
        'YearlyQueryBindingSource
        '
        Me.YearlyQueryBindingSource.DataMember = "MonthlyQuery"
        Me.YearlyQueryBindingSource.DataSource = Me.Customer_DBDataSet
        '
        'PopDrinksBindingSource
        '
        Me.PopDrinksBindingSource.DataMember = "PopDrinks"
        Me.PopDrinksBindingSource.DataSource = Me.Customer_DBDataSet
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClose.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Location = New System.Drawing.Point(0, 810)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(1220, 43)
        Me.BtnClose.TabIndex = 12
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
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
        Me.BtnMain.ForeColor = System.Drawing.Color.White
        Me.BtnMain.Location = New System.Drawing.Point(0, 767)
        Me.BtnMain.Name = "BtnMain"
        Me.BtnMain.Size = New System.Drawing.Size(1220, 43)
        Me.BtnMain.TabIndex = 13
        Me.BtnMain.Text = "Main"
        Me.BtnMain.UseVisualStyleBackColor = False
        '
        'Financial_DBTableAdapter
        '
        Me.Financial_DBTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Customer_DBTableAdapter = Nothing
        Me.TableAdapterManager.Financial_DBTableAdapter = Me.Financial_DBTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Customer_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DailyQueryTableAdapter
        '
        Me.DailyQueryTableAdapter.ClearBeforeFill = True
        '
        'MonthlyQueryTableAdapter
        '
        Me.MonthlyQueryTableAdapter.ClearBeforeFill = True
        '
        'PopDrinksTableAdapter
        '
        Me.PopDrinksTableAdapter.ClearBeforeFill = True
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRefresh.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        Me.BtnRefresh.ForeColor = System.Drawing.Color.White
        Me.BtnRefresh.Location = New System.Drawing.Point(0, 724)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(1220, 43)
        Me.BtnRefresh.TabIndex = 13
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.Beverage)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Malgun Gothic", 10.0!)
        Me.TabControl1.ItemSize = New System.Drawing.Size(174, 34)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(40, 5)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1220, 724)
        Me.TabControl1.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.ReportViewer_Day)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.ForeColor = System.Drawing.Color.White
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1212, 682)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Daily Report"
        '
        'ReportViewer_Day
        '
        Me.ReportViewer_Day.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ReportViewer_Day.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer_Day.ForeColor = System.Drawing.Color.Black
        ReportDataSource1.Name = "DailyReport"
        ReportDataSource1.Value = Me.Financial_DBBindingSource
        Me.ReportViewer_Day.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer_Day.LocalReport.ReportEmbeddedResource = "WindowsApplication1.DailyReport.rdlc"
        Me.ReportViewer_Day.Location = New System.Drawing.Point(291, 3)
        Me.ReportViewer_Day.Name = "ReportViewer_Day"
        Me.ReportViewer_Day.Size = New System.Drawing.Size(918, 676)
        Me.ReportViewer_Day.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ShowAllday)
        Me.Panel1.Controls.Add(Me.Calendar_Day)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(288, 676)
        Me.Panel1.TabIndex = 19
        '
        'ShowAllday
        '
        Me.ShowAllday.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowAllday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowAllday.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowAllday.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowAllday.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowAllday.Location = New System.Drawing.Point(5, 219)
        Me.ShowAllday.Name = "ShowAllday"
        Me.ShowAllday.Size = New System.Drawing.Size(257, 73)
        Me.ShowAllday.TabIndex = 16
        Me.ShowAllday.Text = "Show All"
        Me.ShowAllday.UseVisualStyleBackColor = False
        '
        'Calendar_Day
        '
        Me.Calendar_Day.Location = New System.Drawing.Point(0, 0)
        Me.Calendar_Day.MaxSelectionCount = 1
        Me.Calendar_Day.Name = "Calendar_Day"
        Me.Calendar_Day.TabIndex = 17
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.ReportViewer_Month)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.ForeColor = System.Drawing.Color.White
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1212, 682)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Monthly Report"
        '
        'ReportViewer_Month
        '
        Me.ReportViewer_Month.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ReportViewer_Month.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer_Month.ForeColor = System.Drawing.Color.Black
        ReportDataSource2.Name = "MonthData"
        ReportDataSource2.Value = Me.MonthlyQueryBindingSource
        Me.ReportViewer_Month.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer_Month.LocalReport.ReportEmbeddedResource = "WindowsApplication1.MonthlyReport.rdlc"
        Me.ReportViewer_Month.Location = New System.Drawing.Point(291, 3)
        Me.ReportViewer_Month.Name = "ReportViewer_Month"
        Me.ReportViewer_Month.Size = New System.Drawing.Size(918, 676)
        Me.ReportViewer_Month.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ShowAllMonth)
        Me.Panel2.Controls.Add(Me.Calendar_Month)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(288, 676)
        Me.Panel2.TabIndex = 21
        '
        'ShowAllMonth
        '
        Me.ShowAllMonth.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowAllMonth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowAllMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowAllMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowAllMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowAllMonth.Location = New System.Drawing.Point(5, 219)
        Me.ShowAllMonth.Name = "ShowAllMonth"
        Me.ShowAllMonth.Size = New System.Drawing.Size(257, 73)
        Me.ShowAllMonth.TabIndex = 15
        Me.ShowAllMonth.Text = "Show All"
        Me.ShowAllMonth.UseVisualStyleBackColor = False
        '
        'Calendar_Month
        '
        Me.Calendar_Month.Location = New System.Drawing.Point(0, 0)
        Me.Calendar_Month.MaxSelectionCount = 1
        Me.Calendar_Month.Name = "Calendar_Month"
        Me.Calendar_Month.TabIndex = 13
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TabPage3.Controls.Add(Me.ReportViewer_Year)
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.ForeColor = System.Drawing.Color.White
        Me.TabPage3.Location = New System.Drawing.Point(4, 38)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1212, 682)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Yearly Report"
        '
        'ReportViewer_Year
        '
        Me.ReportViewer_Year.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ReportViewer_Year.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer_Year.ForeColor = System.Drawing.Color.Black
        ReportDataSource3.Name = "YearData"
        ReportDataSource3.Value = Me.YearlyQueryBindingSource
        Me.ReportViewer_Year.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer_Year.LocalReport.ReportEmbeddedResource = "WindowsApplication1.YearlyReport.rdlc"
        Me.ReportViewer_Year.LocalReport.ReportPath = ""
        Me.ReportViewer_Year.Location = New System.Drawing.Point(231, 3)
        Me.ReportViewer_Year.Name = "ReportViewer_Year"
        Me.ReportViewer_Year.Size = New System.Drawing.Size(978, 676)
        Me.ReportViewer_Year.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.ShowAllyear)
        Me.Panel3.Controls.Add(Me.NumericUpDown1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(228, 676)
        Me.Panel3.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(31, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 28)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Select the year"
        '
        'ShowAllyear
        '
        Me.ShowAllyear.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowAllyear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowAllyear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowAllyear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowAllyear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowAllyear.Location = New System.Drawing.Point(31, 122)
        Me.ShowAllyear.Name = "ShowAllyear"
        Me.ShowAllyear.Size = New System.Drawing.Size(157, 73)
        Me.ShowAllyear.TabIndex = 19
        Me.ShowAllyear.Text = "Show All"
        Me.ShowAllyear.UseVisualStyleBackColor = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Malgun Gothic", 20.0!)
        Me.NumericUpDown1.Location = New System.Drawing.Point(31, 64)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(157, 52)
        Me.NumericUpDown1.TabIndex = 17
        Me.NumericUpDown1.Value = New Decimal(New Integer() {2016, 0, 0, 0})
        '
        'Beverage
        '
        Me.Beverage.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Beverage.Controls.Add(Me.BeverageReportViewer)
        Me.Beverage.Controls.Add(Me.Panel4)
        Me.Beverage.ForeColor = System.Drawing.Color.White
        Me.Beverage.Location = New System.Drawing.Point(4, 38)
        Me.Beverage.Name = "Beverage"
        Me.Beverage.Padding = New System.Windows.Forms.Padding(3)
        Me.Beverage.Size = New System.Drawing.Size(1212, 682)
        Me.Beverage.TabIndex = 3
        Me.Beverage.Text = "Beverage"
        '
        'BeverageReportViewer
        '
        Me.BeverageReportViewer.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BeverageReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BeverageReportViewer.ForeColor = System.Drawing.Color.Black
        ReportDataSource4.Name = "DataSet1"
        ReportDataSource4.Value = Me.PopDrinksBindingSource
        Me.BeverageReportViewer.LocalReport.DataSources.Add(ReportDataSource4)
        Me.BeverageReportViewer.LocalReport.ReportEmbeddedResource = "WindowsApplication1.BeverageReport.rdlc"
        Me.BeverageReportViewer.Location = New System.Drawing.Point(231, 3)
        Me.BeverageReportViewer.Name = "BeverageReportViewer"
        Me.BeverageReportViewer.Size = New System.Drawing.Size(978, 676)
        Me.BeverageReportViewer.TabIndex = 23
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.ShowAlldrinks)
        Me.Panel4.Controls.Add(Me.NumericUpDown2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(228, 676)
        Me.Panel4.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Malgun Gothic", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(31, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 28)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Select the year"
        '
        'ShowAlldrinks
        '
        Me.ShowAlldrinks.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowAlldrinks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowAlldrinks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowAlldrinks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowAlldrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowAlldrinks.Location = New System.Drawing.Point(31, 122)
        Me.ShowAlldrinks.Name = "ShowAlldrinks"
        Me.ShowAlldrinks.Size = New System.Drawing.Size(157, 73)
        Me.ShowAlldrinks.TabIndex = 19
        Me.ShowAlldrinks.Text = "Show All"
        Me.ShowAlldrinks.UseVisualStyleBackColor = False
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Font = New System.Drawing.Font("Malgun Gothic", 20.0!)
        Me.NumericUpDown2.Location = New System.Drawing.Point(31, 64)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(157, 52)
        Me.NumericUpDown2.TabIndex = 17
        Me.NumericUpDown2.Value = New Decimal(New Integer() {2016, 0, 0, 0})
        '
        'DailyQueryBindingSource
        '
        Me.DailyQueryBindingSource.DataMember = "Financial DB"
        Me.DailyQueryBindingSource.DataSource = Me.Customer_DBDataSet
        '
        'Financial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1220, 853)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnMain)
        Me.Controls.Add(Me.BtnClose)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Financial"
        Me.Text = "Financial report"
        CType(Me.Financial_DBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonthlyQueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YearlyQueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopDrinksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Beverage.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DailyQueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Financial_DBTableAdapter As WindowsApplication1.Customer_DBDataSetTableAdapters.Financial_DBTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Customer_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    'Friend WithEvents DailyQueryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DailyQueryTableAdapter As WindowsApplication1.Customer_DBDataSetTableAdapters.DailyQueryTableAdapter
    Friend WithEvents MonthlyQueryTableAdapter As WindowsApplication1.Customer_DBDataSetTableAdapters.MonthlyQueryTableAdapter
    Friend WithEvents PopDrinksTableAdapter As WindowsApplication1.Customer_DBDataSetTableAdapters.PopDrinksTableAdapter
    Friend WithEvents DailyQueryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MonthlyQueryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents YearlyQueryBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents YearlyQueryTableAdapter As WindowsApplication1.Customer_DBDataSetTableAdapters.YearlyQueryTableAdapter
    Friend WithEvents Customer_DBDataSet As WindowsApplication1.Customer_DBDataSet
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnMain As System.Windows.Forms.Button
    Friend WithEvents Financial_DBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PopDrinksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer_Day As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ShowAllday As System.Windows.Forms.Button
    Friend WithEvents Calendar_Day As System.Windows.Forms.MonthCalendar
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer_Month As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ShowAllMonth As System.Windows.Forms.Button
    Friend WithEvents Calendar_Month As System.Windows.Forms.MonthCalendar
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer_Year As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShowAllyear As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Beverage As System.Windows.Forms.TabPage
    Friend WithEvents BeverageReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShowAlldrinks As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
End Class
