<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDesigners
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim EmpIDLabel As System.Windows.Forms.Label
        Dim EmpFirstLabel As System.Windows.Forms.Label
        Dim EmpLastLabel As System.Windows.Forms.Label
        Dim EmpLoginLabel As System.Windows.Forms.Label
        Dim EmpWareIDLabel As System.Windows.Forms.Label
        Dim EmpTypeIDLabel As System.Windows.Forms.Label
        Dim EmpTimeClockIDLabel As System.Windows.Forms.Label
        Dim EmpworklocationidLabel As System.Windows.Forms.Label
        Dim EmpJobTitleLabel As System.Windows.Forms.Label
        Dim EmpHomeAddressLabel As System.Windows.Forms.Label
        Dim EmpStartDateLabel As System.Windows.Forms.Label
        Dim EmpTeamNameLabel As System.Windows.Forms.Label
        Me.tabMetricsPayRate = New DevExpress.XtraTab.XtraTabControl()
        Me.TabMetrics = New DevExpress.XtraTab.XtraTabPage()
        Me.DesignMetricsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.DesignMetricsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSDesigners = New DesignMetrics.DSDesigners()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEMPID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHoursWorked = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colToShopBDFT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalBDFT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstBDFT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEWPLF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLooseSQFT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesignEnoNBR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesignEnoCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colweeksort = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colyearsort = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWeekYear = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabPayRates = New DevExpress.XtraTab.XtraTabPage()
        Me.EmpRatesGridControl = New DevExpress.XtraGrid.GridControl()
        Me.EmpRatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEmpID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmpPayRate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEffectivedate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEffectiveEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EmployeesTableAdapter = New DesignMetrics.DSDesignersTableAdapters.EmployeesTableAdapter()
        Me.TableAdapterManager = New DesignMetrics.DSDesignersTableAdapters.TableAdapterManager()
        Me.DesignMetricsTableAdapter = New DesignMetrics.DSDesignersTableAdapters.DesignMetricsTableAdapter()
        Me.EmployeeTypeTableAdapter = New DesignMetrics.DSDesignersTableAdapters.EmployeeTypeTableAdapter()
        Me.EmpRatesTableAdapter = New DesignMetrics.DSDesignersTableAdapters.EmpRatesTableAdapter()
        Me.EmpTeamTableAdapter = New DesignMetrics.DSDesignersTableAdapters.EmpTeamTableAdapter()
        Me.WarehouseTableAdapter = New DesignMetrics.DSDesignersTableAdapters.WarehouseTableAdapter()
        Me.EmpIDTextBox = New System.Windows.Forms.TextBox()
        Me.EmpFirstTextBox = New System.Windows.Forms.TextBox()
        Me.EmpLastTextBox = New System.Windows.Forms.TextBox()
        Me.EmpLoginTextBox = New System.Windows.Forms.TextBox()
        Me.EmpWareIDLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.WarehouseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpTypeIDLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.EmployeeTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpTimeClockIDTextBox = New System.Windows.Forms.TextBox()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.DSTimeclock = New DesignMetrics.DSTimeclock()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New DesignMetrics.DSTimeclockTableAdapters.EmployeeTableAdapter()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.tabDesignMetrics = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.EmpTeamNameLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.EmpTeamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpStartDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.EmpHomeAddressTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EmpJobTitleLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.EmpJobTitlesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpworklocationidLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.EmpWorkLocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.lstDesigners = New DevExpress.XtraEditors.ListBoxControl()
        Me.btnDashboards = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.btnExportMonthlyExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnMonthlySave = New DevExpress.XtraEditors.SimpleButton()
        Me.MonthlyMetricsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.MonthlyMetricsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSMonthlyMetrics = New DesignMetrics.DSMonthlyMetrics()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMonth = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYear = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFiscalMonth = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFiscalYear = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkingDays = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedBDFT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderedBDFT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubmittedBDFT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesignToShopBDFT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuiltBDFT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesignCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimateCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesignHours = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimateHours = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesignEnOs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesignEnOCost1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHubStaffCount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.fieldMonthlyMetricsID1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMonth1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldYear1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFiscalMonth1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFiscalYear1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldEstimatedBDFT1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldOrderedBDFT1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSubmittedBDFT1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDesignToShopBDFT1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBuiltBDFT1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDesignCost1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldEstimateCost1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDesignHours1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldEstimateHours1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDesignEnOs1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDesignEnOCost1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHubStaffCount1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldWorkingDays1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.tabTeam = New DevExpress.XtraTab.XtraTabPage()
        Me.btnteamsave = New DevExpress.XtraEditors.SimpleButton()
        Me.EmpTeamGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEmpTeam = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmpTeamName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmpTeamLeader = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MonthlyMetricsTableAdapter = New DesignMetrics.DSMonthlyMetricsTableAdapters.MonthlyMetricsTableAdapter()
        Me.TableAdapterManager2 = New DesignMetrics.DSMonthlyMetricsTableAdapters.TableAdapterManager()
        Me.FKDesignMetricsEmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpWorkLocationTableAdapter = New DesignMetrics.DSDesignersTableAdapters.EmpWorkLocationTableAdapter()
        Me.EmpJobTitlesTableAdapter = New DesignMetrics.DSDesignersTableAdapters.EmpJobTitlesTableAdapter()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FKEmpTeamEmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        EmpIDLabel = New System.Windows.Forms.Label()
        EmpFirstLabel = New System.Windows.Forms.Label()
        EmpLastLabel = New System.Windows.Forms.Label()
        EmpLoginLabel = New System.Windows.Forms.Label()
        EmpWareIDLabel = New System.Windows.Forms.Label()
        EmpTypeIDLabel = New System.Windows.Forms.Label()
        EmpTimeClockIDLabel = New System.Windows.Forms.Label()
        EmpworklocationidLabel = New System.Windows.Forms.Label()
        EmpJobTitleLabel = New System.Windows.Forms.Label()
        EmpHomeAddressLabel = New System.Windows.Forms.Label()
        EmpStartDateLabel = New System.Windows.Forms.Label()
        EmpTeamNameLabel = New System.Windows.Forms.Label()
        CType(Me.tabMetricsPayRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMetricsPayRate.SuspendLayout()
        Me.TabMetrics.SuspendLayout()
        CType(Me.DesignMetricsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DesignMetricsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSDesigners, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPayRates.SuspendLayout()
        CType(Me.EmpRatesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpRatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpWareIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarehouseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpTypeIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSTimeclock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabDesignMetrics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDesignMetrics.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.EmpTeamNameLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpTeamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpStartDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpStartDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpHomeAddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpJobTitleLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpJobTitlesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpworklocationidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpWorkLocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstDesigners, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.MonthlyMetricsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonthlyMetricsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSMonthlyMetrics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTeam.SuspendLayout()
        CType(Me.EmpTeamGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKDesignMetricsEmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKEmpTeamEmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmpIDLabel
        '
        EmpIDLabel.AutoSize = True
        EmpIDLabel.Location = New System.Drawing.Point(189, 15)
        EmpIDLabel.Name = "EmpIDLabel"
        EmpIDLabel.Size = New System.Drawing.Size(22, 13)
        EmpIDLabel.TabIndex = 2
        EmpIDLabel.Text = "ID:"
        '
        'EmpFirstLabel
        '
        EmpFirstLabel.AutoSize = True
        EmpFirstLabel.Location = New System.Drawing.Point(179, 43)
        EmpFirstLabel.Name = "EmpFirstLabel"
        EmpFirstLabel.Size = New System.Drawing.Size(32, 13)
        EmpFirstLabel.TabIndex = 4
        EmpFirstLabel.Text = "First:"
        '
        'EmpLastLabel
        '
        EmpLastLabel.AutoSize = True
        EmpLastLabel.Location = New System.Drawing.Point(180, 68)
        EmpLastLabel.Name = "EmpLastLabel"
        EmpLastLabel.Size = New System.Drawing.Size(31, 13)
        EmpLastLabel.TabIndex = 6
        EmpLastLabel.Text = "Last:"
        '
        'EmpLoginLabel
        '
        EmpLoginLabel.AutoSize = True
        EmpLoginLabel.Location = New System.Drawing.Point(416, 15)
        EmpLoginLabel.Name = "EmpLoginLabel"
        EmpLoginLabel.Size = New System.Drawing.Size(36, 13)
        EmpLoginLabel.TabIndex = 10
        EmpLoginLabel.Text = "Login:"
        '
        'EmpWareIDLabel
        '
        EmpWareIDLabel.AutoSize = True
        EmpWareIDLabel.Location = New System.Drawing.Point(401, 42)
        EmpWareIDLabel.Name = "EmpWareIDLabel"
        EmpWareIDLabel.Size = New System.Drawing.Size(51, 13)
        EmpWareIDLabel.TabIndex = 12
        EmpWareIDLabel.Text = "Ware ID:"
        '
        'EmpTypeIDLabel
        '
        EmpTypeIDLabel.AutoSize = True
        EmpTypeIDLabel.Location = New System.Drawing.Point(403, 68)
        EmpTypeIDLabel.Name = "EmpTypeIDLabel"
        EmpTypeIDLabel.Size = New System.Drawing.Size(49, 13)
        EmpTypeIDLabel.TabIndex = 14
        EmpTypeIDLabel.Text = "Type ID:"
        '
        'EmpTimeClockIDLabel
        '
        EmpTimeClockIDLabel.AutoSize = True
        EmpTimeClockIDLabel.Location = New System.Drawing.Point(136, 95)
        EmpTimeClockIDLabel.Name = "EmpTimeClockIDLabel"
        EmpTimeClockIDLabel.Size = New System.Drawing.Size(75, 13)
        EmpTimeClockIDLabel.TabIndex = 16
        EmpTimeClockIDLabel.Text = "Time Clock ID:"
        '
        'EmpworklocationidLabel
        '
        EmpworklocationidLabel.AutoSize = True
        EmpworklocationidLabel.Location = New System.Drawing.Point(644, 16)
        EmpworklocationidLabel.Name = "EmpworklocationidLabel"
        EmpworklocationidLabel.Size = New System.Drawing.Size(79, 13)
        EmpworklocationidLabel.TabIndex = 26
        EmpworklocationidLabel.Text = "Work Location:"
        '
        'EmpJobTitleLabel
        '
        EmpJobTitleLabel.AutoSize = True
        EmpJobTitleLabel.Location = New System.Drawing.Point(672, 44)
        EmpJobTitleLabel.Name = "EmpJobTitleLabel"
        EmpJobTitleLabel.Size = New System.Drawing.Size(51, 13)
        EmpJobTitleLabel.TabIndex = 27
        EmpJobTitleLabel.Text = "Job Title:"
        '
        'EmpHomeAddressLabel
        '
        EmpHomeAddressLabel.AutoSize = True
        EmpHomeAddressLabel.Location = New System.Drawing.Point(643, 74)
        EmpHomeAddressLabel.Name = "EmpHomeAddressLabel"
        EmpHomeAddressLabel.Size = New System.Drawing.Size(80, 13)
        EmpHomeAddressLabel.TabIndex = 28
        EmpHomeAddressLabel.Text = "Home Address:"
        '
        'EmpStartDateLabel
        '
        EmpStartDateLabel.AutoSize = True
        EmpStartDateLabel.Location = New System.Drawing.Point(391, 95)
        EmpStartDateLabel.Name = "EmpStartDateLabel"
        EmpStartDateLabel.Size = New System.Drawing.Size(61, 13)
        EmpStartDateLabel.TabIndex = 29
        EmpStartDateLabel.Text = "Start Date:"
        '
        'EmpTeamNameLabel
        '
        EmpTeamNameLabel.AutoSize = True
        EmpTeamNameLabel.Location = New System.Drawing.Point(633, 100)
        EmpTeamNameLabel.Name = "EmpTeamNameLabel"
        EmpTeamNameLabel.Size = New System.Drawing.Size(90, 13)
        EmpTeamNameLabel.TabIndex = 30
        EmpTeamNameLabel.Text = "Emp Team Name:"
        '
        'tabMetricsPayRate
        '
        Me.tabMetricsPayRate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMetricsPayRate.Location = New System.Drawing.Point(133, 119)
        Me.tabMetricsPayRate.Name = "tabMetricsPayRate"
        Me.tabMetricsPayRate.SelectedTabPage = Me.TabMetrics
        Me.tabMetricsPayRate.Size = New System.Drawing.Size(1036, 375)
        Me.tabMetricsPayRate.TabIndex = 1
        Me.tabMetricsPayRate.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabMetrics, Me.tabPayRates})
        '
        'TabMetrics
        '
        Me.TabMetrics.AutoScroll = True
        Me.TabMetrics.Controls.Add(Me.DesignMetricsGridControl)
        Me.TabMetrics.Name = "TabMetrics"
        Me.TabMetrics.Size = New System.Drawing.Size(1030, 347)
        Me.TabMetrics.Text = "Metrics"
        '
        'DesignMetricsGridControl
        '
        Me.DesignMetricsGridControl.DataSource = Me.DesignMetricsBindingSource
        Me.DesignMetricsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DesignMetricsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.DesignMetricsGridControl.MainView = Me.GridView2
        Me.DesignMetricsGridControl.Name = "DesignMetricsGridControl"
        Me.DesignMetricsGridControl.Size = New System.Drawing.Size(1030, 347)
        Me.DesignMetricsGridControl.TabIndex = 0
        Me.DesignMetricsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'DesignMetricsBindingSource
        '
        Me.DesignMetricsBindingSource.DataMember = "FK_DesignMetrics_Employees"
        Me.DesignMetricsBindingSource.DataSource = Me.EmployeesBindingSource
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "Employees"
        Me.EmployeesBindingSource.DataSource = Me.DSDesigners
        '
        'DSDesigners
        '
        Me.DSDesigners.DataSetName = "DSDesigners"
        Me.DSDesigners.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEMPID1, Me.colHoursWorked, Me.colToShopBDFT, Me.colTotalBDFT, Me.colEstBDFT, Me.colEWPLF, Me.colLooseSQFT, Me.colDesignEnoNBR, Me.colDesignEnoCost, Me.colweeksort, Me.colyearsort, Me.colWeekYear})
        Me.GridView2.GridControl = Me.DesignMetricsGridControl
        Me.GridView2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ToShopBDFT", Nothing, "(To Shop BDFT: {0:0.##})"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalBDFT", Nothing, "(Total BDFT: {0:0.##})"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EstBDFT", Nothing, "(Est BDFT: {0:0.##})"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HoursWorked", Nothing, "(Hours Worked: {0:0.##})"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DesignEnoCost", Nothing, "(Eno Cost: {0:0.##})")})
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView2.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridView2.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colyearsort, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colweeksort, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colEMPID1
        '
        Me.colEMPID1.FieldName = "EMPID"
        Me.colEMPID1.Name = "colEMPID1"
        Me.colEMPID1.Visible = True
        Me.colEMPID1.VisibleIndex = 11
        Me.colEMPID1.Width = 259
        '
        'colHoursWorked
        '
        Me.colHoursWorked.FieldName = "HoursWorked"
        Me.colHoursWorked.Name = "colHoursWorked"
        Me.colHoursWorked.Visible = True
        Me.colHoursWorked.VisibleIndex = 10
        Me.colHoursWorked.Width = 202
        '
        'colToShopBDFT
        '
        Me.colToShopBDFT.FieldName = "ToShopBDFT"
        Me.colToShopBDFT.Name = "colToShopBDFT"
        Me.colToShopBDFT.Visible = True
        Me.colToShopBDFT.VisibleIndex = 5
        Me.colToShopBDFT.Width = 112
        '
        'colTotalBDFT
        '
        Me.colTotalBDFT.FieldName = "TotalBDFT"
        Me.colTotalBDFT.Name = "colTotalBDFT"
        Me.colTotalBDFT.Visible = True
        Me.colTotalBDFT.VisibleIndex = 6
        Me.colTotalBDFT.Width = 108
        '
        'colEstBDFT
        '
        Me.colEstBDFT.FieldName = "EstBDFT"
        Me.colEstBDFT.Name = "colEstBDFT"
        Me.colEstBDFT.Visible = True
        Me.colEstBDFT.VisibleIndex = 2
        Me.colEstBDFT.Width = 103
        '
        'colEWPLF
        '
        Me.colEWPLF.FieldName = "EWPLF"
        Me.colEWPLF.Name = "colEWPLF"
        Me.colEWPLF.Visible = True
        Me.colEWPLF.VisibleIndex = 4
        Me.colEWPLF.Width = 102
        '
        'colLooseSQFT
        '
        Me.colLooseSQFT.FieldName = "LooseSQFT"
        Me.colLooseSQFT.Name = "colLooseSQFT"
        Me.colLooseSQFT.Visible = True
        Me.colLooseSQFT.VisibleIndex = 3
        Me.colLooseSQFT.Width = 113
        '
        'colDesignEnoNBR
        '
        Me.colDesignEnoNBR.FieldName = "DesignEnoNBR"
        Me.colDesignEnoNBR.Name = "colDesignEnoNBR"
        Me.colDesignEnoNBR.Visible = True
        Me.colDesignEnoNBR.VisibleIndex = 7
        Me.colDesignEnoNBR.Width = 121
        '
        'colDesignEnoCost
        '
        Me.colDesignEnoCost.FieldName = "DesignEnoCost"
        Me.colDesignEnoCost.Name = "colDesignEnoCost"
        Me.colDesignEnoCost.Visible = True
        Me.colDesignEnoCost.VisibleIndex = 8
        Me.colDesignEnoCost.Width = 137
        '
        'colweeksort
        '
        Me.colweeksort.FieldName = "weeksort"
        Me.colweeksort.Name = "colweeksort"
        Me.colweeksort.Visible = True
        Me.colweeksort.VisibleIndex = 0
        Me.colweeksort.Width = 83
        '
        'colyearsort
        '
        Me.colyearsort.FieldName = "yearsort"
        Me.colyearsort.Name = "colyearsort"
        Me.colyearsort.Visible = True
        Me.colyearsort.VisibleIndex = 1
        Me.colyearsort.Width = 90
        '
        'colWeekYear
        '
        Me.colWeekYear.FieldName = "WeekYear"
        Me.colWeekYear.Name = "colWeekYear"
        Me.colWeekYear.Visible = True
        Me.colWeekYear.VisibleIndex = 9
        Me.colWeekYear.Width = 202
        '
        'tabPayRates
        '
        Me.tabPayRates.AutoScroll = True
        Me.tabPayRates.Controls.Add(Me.EmpRatesGridControl)
        Me.tabPayRates.Name = "tabPayRates"
        Me.tabPayRates.Size = New System.Drawing.Size(1030, 347)
        Me.tabPayRates.Text = "Pay Rates"
        '
        'EmpRatesGridControl
        '
        Me.EmpRatesGridControl.DataSource = Me.EmpRatesBindingSource
        Me.EmpRatesGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmpRatesGridControl.Location = New System.Drawing.Point(0, 0)
        Me.EmpRatesGridControl.MainView = Me.GridView1
        Me.EmpRatesGridControl.Name = "EmpRatesGridControl"
        Me.EmpRatesGridControl.Size = New System.Drawing.Size(1030, 347)
        Me.EmpRatesGridControl.TabIndex = 0
        Me.EmpRatesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'EmpRatesBindingSource
        '
        Me.EmpRatesBindingSource.DataMember = "FK_EmpRates_Employees"
        Me.EmpRatesBindingSource.DataSource = Me.EmployeesBindingSource
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEmpID, Me.colEmpPayRate, Me.colEffectivedate, Me.colEffectiveEndDate})
        Me.GridView1.GridControl = Me.EmpRatesGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        '
        'colEmpID
        '
        Me.colEmpID.FieldName = "EmpID"
        Me.colEmpID.Name = "colEmpID"
        Me.colEmpID.Visible = True
        Me.colEmpID.VisibleIndex = 0
        '
        'colEmpPayRate
        '
        Me.colEmpPayRate.FieldName = "EmpPayRate"
        Me.colEmpPayRate.Name = "colEmpPayRate"
        Me.colEmpPayRate.Visible = True
        Me.colEmpPayRate.VisibleIndex = 1
        '
        'colEffectivedate
        '
        Me.colEffectivedate.FieldName = "Effectivedate"
        Me.colEffectivedate.Name = "colEffectivedate"
        Me.colEffectivedate.Visible = True
        Me.colEffectivedate.VisibleIndex = 2
        '
        'colEffectiveEndDate
        '
        Me.colEffectiveEndDate.FieldName = "EffectiveEndDate"
        Me.colEffectiveEndDate.Name = "colEffectiveEndDate"
        Me.colEffectiveEndDate.Visible = True
        Me.colEffectiveEndDate.VisibleIndex = 3
        '
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DesignMetricsTableAdapter = Me.DesignMetricsTableAdapter
        Me.TableAdapterManager.EmpJobTitlesTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Me.EmployeesTableAdapter
        Me.TableAdapterManager.EmployeeTypeTableAdapter = Me.EmployeeTypeTableAdapter
        Me.TableAdapterManager.EmpRatesTableAdapter = Me.EmpRatesTableAdapter
        Me.TableAdapterManager.EmpTeamTableAdapter = Me.EmpTeamTableAdapter
        Me.TableAdapterManager.EmpWorkLocationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DesignMetrics.DSDesignersTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WarehouseTableAdapter = Me.WarehouseTableAdapter
        '
        'DesignMetricsTableAdapter
        '
        Me.DesignMetricsTableAdapter.ClearBeforeFill = True
        '
        'EmployeeTypeTableAdapter
        '
        Me.EmployeeTypeTableAdapter.ClearBeforeFill = True
        '
        'EmpRatesTableAdapter
        '
        Me.EmpRatesTableAdapter.ClearBeforeFill = True
        '
        'EmpTeamTableAdapter
        '
        Me.EmpTeamTableAdapter.ClearBeforeFill = True
        '
        'WarehouseTableAdapter
        '
        Me.WarehouseTableAdapter.ClearBeforeFill = True
        '
        'EmpIDTextBox
        '
        Me.EmpIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "EmpID", True))
        Me.EmpIDTextBox.Location = New System.Drawing.Point(217, 11)
        Me.EmpIDTextBox.Name = "EmpIDTextBox"
        Me.EmpIDTextBox.Size = New System.Drawing.Size(72, 21)
        Me.EmpIDTextBox.TabIndex = 3
        '
        'EmpFirstTextBox
        '
        Me.EmpFirstTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "EmpFirst", True))
        Me.EmpFirstTextBox.Location = New System.Drawing.Point(217, 38)
        Me.EmpFirstTextBox.Name = "EmpFirstTextBox"
        Me.EmpFirstTextBox.Size = New System.Drawing.Size(133, 21)
        Me.EmpFirstTextBox.TabIndex = 5
        '
        'EmpLastTextBox
        '
        Me.EmpLastTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "EmpLast", True))
        Me.EmpLastTextBox.Location = New System.Drawing.Point(217, 65)
        Me.EmpLastTextBox.Name = "EmpLastTextBox"
        Me.EmpLastTextBox.Size = New System.Drawing.Size(133, 21)
        Me.EmpLastTextBox.TabIndex = 7
        '
        'EmpLoginTextBox
        '
        Me.EmpLoginTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "EmpLogin", True))
        Me.EmpLoginTextBox.Location = New System.Drawing.Point(458, 12)
        Me.EmpLoginTextBox.Name = "EmpLoginTextBox"
        Me.EmpLoginTextBox.Size = New System.Drawing.Size(133, 21)
        Me.EmpLoginTextBox.TabIndex = 11
        '
        'EmpWareIDLookUpEdit
        '
        Me.EmpWareIDLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmployeesBindingSource, "EmpWareID", True))
        Me.EmpWareIDLookUpEdit.Location = New System.Drawing.Point(458, 39)
        Me.EmpWareIDLookUpEdit.Name = "EmpWareIDLookUpEdit"
        Me.EmpWareIDLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EmpWareIDLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("WarehouseID", "Warehouse ID", 92, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("WarehouseName", "Warehouse Name", 95, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.EmpWareIDLookUpEdit.Properties.DataSource = Me.WarehouseBindingSource
        Me.EmpWareIDLookUpEdit.Properties.DisplayMember = "WarehouseName"
        Me.EmpWareIDLookUpEdit.Properties.NullText = "..."
        Me.EmpWareIDLookUpEdit.Properties.ValueMember = "WarehouseID"
        Me.EmpWareIDLookUpEdit.Size = New System.Drawing.Size(133, 20)
        Me.EmpWareIDLookUpEdit.TabIndex = 13
        '
        'WarehouseBindingSource
        '
        Me.WarehouseBindingSource.DataMember = "Warehouse"
        Me.WarehouseBindingSource.DataSource = Me.DSDesigners
        '
        'EmpTypeIDLookUpEdit
        '
        Me.EmpTypeIDLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmployeesBindingSource, "EmpTypeID", True))
        Me.EmpTypeIDLookUpEdit.Location = New System.Drawing.Point(458, 65)
        Me.EmpTypeIDLookUpEdit.Name = "EmpTypeIDLookUpEdit"
        Me.EmpTypeIDLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EmpTypeIDLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpTypeID", "Emp Type ID", 84, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpTypeName", "Emp Type Name", 87, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.EmpTypeIDLookUpEdit.Properties.DataSource = Me.EmployeeTypeBindingSource
        Me.EmpTypeIDLookUpEdit.Properties.DisplayMember = "EmpTypeName"
        Me.EmpTypeIDLookUpEdit.Properties.NullText = "..."
        Me.EmpTypeIDLookUpEdit.Properties.ValueMember = "EmpTypeID"
        Me.EmpTypeIDLookUpEdit.Size = New System.Drawing.Size(133, 20)
        Me.EmpTypeIDLookUpEdit.TabIndex = 15
        '
        'EmployeeTypeBindingSource
        '
        Me.EmployeeTypeBindingSource.DataMember = "EmployeeType"
        Me.EmployeeTypeBindingSource.DataSource = Me.DSDesigners
        '
        'EmpTimeClockIDTextBox
        '
        Me.EmpTimeClockIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "EmpTimeClockID", True))
        Me.EmpTimeClockIDTextBox.Location = New System.Drawing.Point(217, 92)
        Me.EmpTimeClockIDTextBox.Name = "EmpTimeClockIDTextBox"
        Me.EmpTimeClockIDTextBox.Size = New System.Drawing.Size(133, 21)
        Me.EmpTimeClockIDTextBox.TabIndex = 8
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(924, 72)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Save Data"
        '
        'DSTimeclock
        '
        Me.DSTimeclock.DataSetName = "DSTimeclock"
        Me.DSTimeclock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.DSTimeclock
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(1086, 43)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "Exit"
        '
        'tabDesignMetrics
        '
        Me.tabDesignMetrics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabDesignMetrics.Location = New System.Drawing.Point(0, 0)
        Me.tabDesignMetrics.Name = "tabDesignMetrics"
        Me.tabDesignMetrics.SelectedTabPage = Me.XtraTabPage1
        Me.tabDesignMetrics.Size = New System.Drawing.Size(1186, 570)
        Me.tabDesignMetrics.TabIndex = 22
        Me.tabDesignMetrics.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.tabTeam})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.AutoScroll = True
        Me.XtraTabPage1.Controls.Add(EmpTeamNameLabel)
        Me.XtraTabPage1.Controls.Add(Me.EmpTeamNameLookUpEdit)
        Me.XtraTabPage1.Controls.Add(EmpStartDateLabel)
        Me.XtraTabPage1.Controls.Add(Me.EmpStartDateDateEdit)
        Me.XtraTabPage1.Controls.Add(EmpHomeAddressLabel)
        Me.XtraTabPage1.Controls.Add(Me.EmpHomeAddressTextEdit)
        Me.XtraTabPage1.Controls.Add(EmpJobTitleLabel)
        Me.XtraTabPage1.Controls.Add(Me.EmpJobTitleLookUpEdit)
        Me.XtraTabPage1.Controls.Add(EmpworklocationidLabel)
        Me.XtraTabPage1.Controls.Add(Me.EmpworklocationidLookUpEdit)
        Me.XtraTabPage1.Controls.Add(Me.btnRefresh)
        Me.XtraTabPage1.Controls.Add(Me.btnNew)
        Me.XtraTabPage1.Controls.Add(Me.lstDesigners)
        Me.XtraTabPage1.Controls.Add(Me.btnDashboards)
        Me.XtraTabPage1.Controls.Add(Me.btnExit)
        Me.XtraTabPage1.Controls.Add(EmpLastLabel)
        Me.XtraTabPage1.Controls.Add(Me.btnSave)
        Me.XtraTabPage1.Controls.Add(EmpFirstLabel)
        Me.XtraTabPage1.Controls.Add(EmpIDLabel)
        Me.XtraTabPage1.Controls.Add(Me.EmpTimeClockIDTextBox)
        Me.XtraTabPage1.Controls.Add(EmpTimeClockIDLabel)
        Me.XtraTabPage1.Controls.Add(Me.EmpTypeIDLookUpEdit)
        Me.XtraTabPage1.Controls.Add(EmpTypeIDLabel)
        Me.XtraTabPage1.Controls.Add(Me.EmpWareIDLookUpEdit)
        Me.XtraTabPage1.Controls.Add(EmpLoginLabel)
        Me.XtraTabPage1.Controls.Add(Me.EmpLoginTextBox)
        Me.XtraTabPage1.Controls.Add(EmpWareIDLabel)
        Me.XtraTabPage1.Controls.Add(Me.tabMetricsPayRate)
        Me.XtraTabPage1.Controls.Add(Me.EmpLastTextBox)
        Me.XtraTabPage1.Controls.Add(Me.EmpIDTextBox)
        Me.XtraTabPage1.Controls.Add(Me.EmpFirstTextBox)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1180, 542)
        Me.XtraTabPage1.Text = "Individual Design Metrics"
        '
        'EmpTeamNameLookUpEdit
        '
        Me.EmpTeamNameLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmployeesBindingSource, "EmpTeamID", True))
        Me.EmpTeamNameLookUpEdit.Location = New System.Drawing.Point(729, 97)
        Me.EmpTeamNameLookUpEdit.Name = "EmpTeamNameLookUpEdit"
        Me.EmpTeamNameLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EmpTeamNameLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpTeam", "Emp Team", 72, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpTeamName", "Emp Team Name", 89, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpTeamLeader", "Emp Team Leader", 95, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.EmpTeamNameLookUpEdit.Properties.DataSource = Me.EmpTeamBindingSource
        Me.EmpTeamNameLookUpEdit.Properties.DisplayMember = "EmpTeamName"
        Me.EmpTeamNameLookUpEdit.Properties.NullText = "..."
        Me.EmpTeamNameLookUpEdit.Properties.ValueMember = "EmpTeam"
        Me.EmpTeamNameLookUpEdit.Size = New System.Drawing.Size(172, 20)
        Me.EmpTeamNameLookUpEdit.TabIndex = 31
        '
        'EmpTeamBindingSource
        '
        Me.EmpTeamBindingSource.DataMember = "EmpTeam"
        Me.EmpTeamBindingSource.DataSource = Me.DSDesigners
        '
        'EmpStartDateDateEdit
        '
        Me.EmpStartDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmployeesBindingSource, "EmpStartDate", True))
        Me.EmpStartDateDateEdit.EditValue = Nothing
        Me.EmpStartDateDateEdit.Location = New System.Drawing.Point(458, 93)
        Me.EmpStartDateDateEdit.Name = "EmpStartDateDateEdit"
        Me.EmpStartDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EmpStartDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EmpStartDateDateEdit.Size = New System.Drawing.Size(133, 20)
        Me.EmpStartDateDateEdit.TabIndex = 30
        '
        'EmpHomeAddressTextEdit
        '
        Me.EmpHomeAddressTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmployeesBindingSource, "EmpHomeAddress", True))
        Me.EmpHomeAddressTextEdit.Location = New System.Drawing.Point(729, 71)
        Me.EmpHomeAddressTextEdit.Name = "EmpHomeAddressTextEdit"
        Me.EmpHomeAddressTextEdit.Size = New System.Drawing.Size(172, 20)
        Me.EmpHomeAddressTextEdit.TabIndex = 29
        '
        'EmpJobTitleLookUpEdit
        '
        Me.EmpJobTitleLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmployeesBindingSource, "EmpJobTitle", True))
        Me.EmpJobTitleLookUpEdit.Location = New System.Drawing.Point(729, 41)
        Me.EmpJobTitleLookUpEdit.Name = "EmpJobTitleLookUpEdit"
        Me.EmpJobTitleLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EmpJobTitleLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("empjobtitleid", "empjobtitleid", 84, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpJobTitle", "Emp Job Title", 73, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.EmpJobTitleLookUpEdit.Properties.DataSource = Me.EmpJobTitlesBindingSource
        Me.EmpJobTitleLookUpEdit.Properties.DisplayMember = "EmpJobTitle"
        Me.EmpJobTitleLookUpEdit.Properties.NullText = "..."
        Me.EmpJobTitleLookUpEdit.Properties.ValueMember = "empjobtitleid"
        Me.EmpJobTitleLookUpEdit.Size = New System.Drawing.Size(172, 20)
        Me.EmpJobTitleLookUpEdit.TabIndex = 28
        '
        'EmpJobTitlesBindingSource
        '
        Me.EmpJobTitlesBindingSource.DataMember = "EmpJobTitles"
        Me.EmpJobTitlesBindingSource.DataSource = Me.DSDesigners
        '
        'EmpworklocationidLookUpEdit
        '
        Me.EmpworklocationidLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmployeesBindingSource, "EmpWorkLocation", True))
        Me.EmpworklocationidLookUpEdit.Location = New System.Drawing.Point(729, 13)
        Me.EmpworklocationidLookUpEdit.Name = "EmpworklocationidLookUpEdit"
        Me.EmpworklocationidLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EmpworklocationidLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("empworklocationid", "empworklocationid", 111, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Empworklocation", "Empworklocation", 90, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.EmpworklocationidLookUpEdit.Properties.DataSource = Me.EmpWorkLocationBindingSource
        Me.EmpworklocationidLookUpEdit.Properties.DisplayMember = "Empworklocation"
        Me.EmpworklocationidLookUpEdit.Properties.NullText = "..."
        Me.EmpworklocationidLookUpEdit.Properties.ValueMember = "empworklocationid"
        Me.EmpworklocationidLookUpEdit.Size = New System.Drawing.Size(172, 20)
        Me.EmpworklocationidLookUpEdit.TabIndex = 27
        '
        'EmpWorkLocationBindingSource
        '
        Me.EmpWorkLocationBindingSource.DataMember = "EmpWorkLocation"
        Me.EmpWorkLocationBindingSource.DataSource = Me.DSDesigners
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(924, 43)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 26
        Me.btnRefresh.Text = "Refresh"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(1005, 43)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 25
        Me.btnNew.Text = "Add New"
        '
        'lstDesigners
        '
        Me.lstDesigners.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstDesigners.DataSource = Me.EmployeesBindingSource
        Me.lstDesigners.DisplayMember = "EmpFullName"
        Me.lstDesigners.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstDesigners.Location = New System.Drawing.Point(0, 0)
        Me.lstDesigners.Name = "lstDesigners"
        Me.lstDesigners.Size = New System.Drawing.Size(128, 542)
        Me.lstDesigners.TabIndex = 24
        Me.lstDesigners.ValueMember = "EmpID"
        '
        'btnDashboards
        '
        Me.btnDashboards.Location = New System.Drawing.Point(1005, 72)
        Me.btnDashboards.Name = "btnDashboards"
        Me.btnDashboards.Size = New System.Drawing.Size(75, 23)
        Me.btnDashboards.TabIndex = 22
        Me.btnDashboards.Text = "Dashboards"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.btnExportMonthlyExcel)
        Me.XtraTabPage2.Controls.Add(Me.btnMonthlySave)
        Me.XtraTabPage2.Controls.Add(Me.MonthlyMetricsGridControl)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1180, 542)
        Me.XtraTabPage2.Text = "Monthly Metrics"
        '
        'btnExportMonthlyExcel
        '
        Me.btnExportMonthlyExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportMonthlyExcel.Location = New System.Drawing.Point(1004, 34)
        Me.btnExportMonthlyExcel.Name = "btnExportMonthlyExcel"
        Me.btnExportMonthlyExcel.Size = New System.Drawing.Size(88, 23)
        Me.btnExportMonthlyExcel.TabIndex = 2
        Me.btnExportMonthlyExcel.Text = "Export to Excel"
        '
        'btnMonthlySave
        '
        Me.btnMonthlySave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMonthlySave.Location = New System.Drawing.Point(1098, 34)
        Me.btnMonthlySave.Name = "btnMonthlySave"
        Me.btnMonthlySave.Size = New System.Drawing.Size(75, 23)
        Me.btnMonthlySave.TabIndex = 1
        Me.btnMonthlySave.Text = "Save"
        '
        'MonthlyMetricsGridControl
        '
        Me.MonthlyMetricsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MonthlyMetricsGridControl.DataSource = Me.MonthlyMetricsBindingSource
        Me.MonthlyMetricsGridControl.Location = New System.Drawing.Point(7, 63)
        Me.MonthlyMetricsGridControl.MainView = Me.GridView3
        Me.MonthlyMetricsGridControl.Name = "MonthlyMetricsGridControl"
        Me.MonthlyMetricsGridControl.Size = New System.Drawing.Size(1166, 476)
        Me.MonthlyMetricsGridControl.TabIndex = 0
        Me.MonthlyMetricsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'MonthlyMetricsBindingSource
        '
        Me.MonthlyMetricsBindingSource.DataMember = "MonthlyMetrics"
        Me.MonthlyMetricsBindingSource.DataSource = Me.DSMonthlyMetrics
        '
        'DSMonthlyMetrics
        '
        Me.DSMonthlyMetrics.DataSetName = "DSMonthlyMetrics"
        Me.DSMonthlyMetrics.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMonth, Me.colYear, Me.colFiscalMonth, Me.colFiscalYear, Me.colWorkingDays, Me.colEstimatedBDFT, Me.colOrderedBDFT, Me.colSubmittedBDFT, Me.colDesignToShopBDFT, Me.colBuiltBDFT, Me.colDesignCost, Me.colEstimateCost, Me.colDesignHours, Me.colEstimateHours, Me.colDesignEnOs, Me.colDesignEnOCost1, Me.colHubStaffCount})
        Me.GridView3.GridControl = Me.MonthlyMetricsGridControl
        Me.GridView3.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EstimatedBDFT", Nothing, "(Estimated BDFT: {0:n0})")})
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsMenu.ShowConditionalFormattingItem = True
        Me.GridView3.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridView3.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GridView3.OptionsView.ShowChildrenInGroupPanel = True
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupedColumns = True
        '
        'colMonth
        '
        Me.colMonth.FieldName = "Month"
        Me.colMonth.Name = "colMonth"
        Me.colMonth.Visible = True
        Me.colMonth.VisibleIndex = 1
        '
        'colYear
        '
        Me.colYear.FieldName = "Year"
        Me.colYear.Name = "colYear"
        Me.colYear.Visible = True
        Me.colYear.VisibleIndex = 2
        '
        'colFiscalMonth
        '
        Me.colFiscalMonth.FieldName = "FiscalMonth"
        Me.colFiscalMonth.Name = "colFiscalMonth"
        Me.colFiscalMonth.Visible = True
        Me.colFiscalMonth.VisibleIndex = 3
        '
        'colFiscalYear
        '
        Me.colFiscalYear.FieldName = "FiscalYear"
        Me.colFiscalYear.Name = "colFiscalYear"
        Me.colFiscalYear.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FiscalYear", "SUM={0:0.##}")})
        Me.colFiscalYear.Visible = True
        Me.colFiscalYear.VisibleIndex = 4
        '
        'colWorkingDays
        '
        Me.colWorkingDays.FieldName = "WorkingDays"
        Me.colWorkingDays.Name = "colWorkingDays"
        Me.colWorkingDays.Visible = True
        Me.colWorkingDays.VisibleIndex = 0
        '
        'colEstimatedBDFT
        '
        Me.colEstimatedBDFT.DisplayFormat.FormatString = "n0"
        Me.colEstimatedBDFT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEstimatedBDFT.FieldName = "EstimatedBDFT"
        Me.colEstimatedBDFT.Name = "colEstimatedBDFT"
        Me.colEstimatedBDFT.Visible = True
        Me.colEstimatedBDFT.VisibleIndex = 5
        '
        'colOrderedBDFT
        '
        Me.colOrderedBDFT.DisplayFormat.FormatString = "n0"
        Me.colOrderedBDFT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOrderedBDFT.FieldName = "OrderedBDFT"
        Me.colOrderedBDFT.Name = "colOrderedBDFT"
        Me.colOrderedBDFT.Visible = True
        Me.colOrderedBDFT.VisibleIndex = 6
        '
        'colSubmittedBDFT
        '
        Me.colSubmittedBDFT.DisplayFormat.FormatString = "n0"
        Me.colSubmittedBDFT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubmittedBDFT.FieldName = "SubmittedBDFT"
        Me.colSubmittedBDFT.Name = "colSubmittedBDFT"
        Me.colSubmittedBDFT.Visible = True
        Me.colSubmittedBDFT.VisibleIndex = 7
        '
        'colDesignToShopBDFT
        '
        Me.colDesignToShopBDFT.DisplayFormat.FormatString = "n0"
        Me.colDesignToShopBDFT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDesignToShopBDFT.FieldName = "DesignToShopBDFT"
        Me.colDesignToShopBDFT.Name = "colDesignToShopBDFT"
        Me.colDesignToShopBDFT.Visible = True
        Me.colDesignToShopBDFT.VisibleIndex = 8
        '
        'colBuiltBDFT
        '
        Me.colBuiltBDFT.DisplayFormat.FormatString = "n0"
        Me.colBuiltBDFT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBuiltBDFT.FieldName = "BuiltBDFT"
        Me.colBuiltBDFT.Name = "colBuiltBDFT"
        Me.colBuiltBDFT.Visible = True
        Me.colBuiltBDFT.VisibleIndex = 9
        '
        'colDesignCost
        '
        Me.colDesignCost.DisplayFormat.FormatString = "c2"
        Me.colDesignCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDesignCost.FieldName = "DesignCost"
        Me.colDesignCost.Name = "colDesignCost"
        Me.colDesignCost.Visible = True
        Me.colDesignCost.VisibleIndex = 10
        '
        'colEstimateCost
        '
        Me.colEstimateCost.DisplayFormat.FormatString = "c2"
        Me.colEstimateCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEstimateCost.FieldName = "EstimateCost"
        Me.colEstimateCost.Name = "colEstimateCost"
        Me.colEstimateCost.Visible = True
        Me.colEstimateCost.VisibleIndex = 11
        '
        'colDesignHours
        '
        Me.colDesignHours.DisplayFormat.FormatString = "n2"
        Me.colDesignHours.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDesignHours.FieldName = "DesignHours"
        Me.colDesignHours.Name = "colDesignHours"
        Me.colDesignHours.Visible = True
        Me.colDesignHours.VisibleIndex = 12
        '
        'colEstimateHours
        '
        Me.colEstimateHours.DisplayFormat.FormatString = "n2"
        Me.colEstimateHours.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEstimateHours.FieldName = "EstimateHours"
        Me.colEstimateHours.Name = "colEstimateHours"
        Me.colEstimateHours.Visible = True
        Me.colEstimateHours.VisibleIndex = 13
        '
        'colDesignEnOs
        '
        Me.colDesignEnOs.FieldName = "DesignEnOs"
        Me.colDesignEnOs.Name = "colDesignEnOs"
        Me.colDesignEnOs.Visible = True
        Me.colDesignEnOs.VisibleIndex = 14
        '
        'colDesignEnOCost1
        '
        Me.colDesignEnOCost1.DisplayFormat.FormatString = "c2"
        Me.colDesignEnOCost1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDesignEnOCost1.FieldName = "DesignEnOCost"
        Me.colDesignEnOCost1.Name = "colDesignEnOCost1"
        Me.colDesignEnOCost1.Visible = True
        Me.colDesignEnOCost1.VisibleIndex = 15
        '
        'colHubStaffCount
        '
        Me.colHubStaffCount.FieldName = "HubStaffCount"
        Me.colHubStaffCount.Name = "colHubStaffCount"
        Me.colHubStaffCount.Visible = True
        Me.colHubStaffCount.VisibleIndex = 16
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.PivotGridControl1)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1180, 542)
        Me.XtraTabPage3.Text = "Monthly Pivot Grid"
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataSource = Me.MonthlyMetricsBindingSource
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldMonthlyMetricsID1, Me.fieldMonth1, Me.fieldYear1, Me.fieldFiscalMonth1, Me.fieldFiscalYear1, Me.fieldEstimatedBDFT1, Me.fieldOrderedBDFT1, Me.fieldSubmittedBDFT1, Me.fieldDesignToShopBDFT1, Me.fieldBuiltBDFT1, Me.fieldDesignCost1, Me.fieldEstimateCost1, Me.fieldDesignHours1, Me.fieldEstimateHours1, Me.fieldDesignEnOs1, Me.fieldDesignEnOCost1, Me.fieldHubStaffCount1, Me.fieldWorkingDays1})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsData.DataFieldUnboundExpressionMode = DevExpress.XtraPivotGrid.DataFieldUnboundExpressionMode.UseSummaryValues
        Me.PivotGridControl1.OptionsMenu.EnableFormatRulesMenu = True
        Me.PivotGridControl1.Size = New System.Drawing.Size(1180, 542)
        Me.PivotGridControl1.TabIndex = 0
        '
        'fieldMonthlyMetricsID1
        '
        Me.fieldMonthlyMetricsID1.AreaIndex = 0
        Me.fieldMonthlyMetricsID1.FieldName = "MonthlyMetricsID"
        Me.fieldMonthlyMetricsID1.Name = "fieldMonthlyMetricsID1"
        '
        'fieldMonth1
        '
        Me.fieldMonth1.AreaIndex = 1
        Me.fieldMonth1.FieldName = "Month"
        Me.fieldMonth1.Name = "fieldMonth1"
        '
        'fieldYear1
        '
        Me.fieldYear1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldYear1.AreaIndex = 0
        Me.fieldYear1.FieldName = "Year"
        Me.fieldYear1.Name = "fieldYear1"
        '
        'fieldFiscalMonth1
        '
        Me.fieldFiscalMonth1.AreaIndex = 2
        Me.fieldFiscalMonth1.FieldName = "FiscalMonth"
        Me.fieldFiscalMonth1.Name = "fieldFiscalMonth1"
        '
        'fieldFiscalYear1
        '
        Me.fieldFiscalYear1.AreaIndex = 3
        Me.fieldFiscalYear1.FieldName = "FiscalYear"
        Me.fieldFiscalYear1.Name = "fieldFiscalYear1"
        '
        'fieldEstimatedBDFT1
        '
        Me.fieldEstimatedBDFT1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldEstimatedBDFT1.AreaIndex = 0
        Me.fieldEstimatedBDFT1.CellFormat.FormatString = "n2"
        Me.fieldEstimatedBDFT1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldEstimatedBDFT1.FieldName = "EstimatedBDFT"
        Me.fieldEstimatedBDFT1.Name = "fieldEstimatedBDFT1"
        Me.fieldEstimatedBDFT1.ValueFormat.FormatString = "n2"
        Me.fieldEstimatedBDFT1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldOrderedBDFT1
        '
        Me.fieldOrderedBDFT1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldOrderedBDFT1.AreaIndex = 1
        Me.fieldOrderedBDFT1.CellFormat.FormatString = "n2"
        Me.fieldOrderedBDFT1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldOrderedBDFT1.FieldName = "OrderedBDFT"
        Me.fieldOrderedBDFT1.Name = "fieldOrderedBDFT1"
        Me.fieldOrderedBDFT1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldSubmittedBDFT1
        '
        Me.fieldSubmittedBDFT1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldSubmittedBDFT1.AreaIndex = 2
        Me.fieldSubmittedBDFT1.CellFormat.FormatString = "n2"
        Me.fieldSubmittedBDFT1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldSubmittedBDFT1.FieldName = "SubmittedBDFT"
        Me.fieldSubmittedBDFT1.Name = "fieldSubmittedBDFT1"
        Me.fieldSubmittedBDFT1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldDesignToShopBDFT1
        '
        Me.fieldDesignToShopBDFT1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldDesignToShopBDFT1.AreaIndex = 3
        Me.fieldDesignToShopBDFT1.CellFormat.FormatString = "n2"
        Me.fieldDesignToShopBDFT1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldDesignToShopBDFT1.FieldName = "DesignToShopBDFT"
        Me.fieldDesignToShopBDFT1.Name = "fieldDesignToShopBDFT1"
        Me.fieldDesignToShopBDFT1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldBuiltBDFT1
        '
        Me.fieldBuiltBDFT1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldBuiltBDFT1.AreaIndex = 4
        Me.fieldBuiltBDFT1.CellFormat.FormatString = "n2"
        Me.fieldBuiltBDFT1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldBuiltBDFT1.FieldName = "BuiltBDFT"
        Me.fieldBuiltBDFT1.Name = "fieldBuiltBDFT1"
        Me.fieldBuiltBDFT1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldDesignCost1
        '
        Me.fieldDesignCost1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldDesignCost1.AreaIndex = 5
        Me.fieldDesignCost1.CellFormat.FormatString = "c2"
        Me.fieldDesignCost1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldDesignCost1.FieldName = "DesignCost"
        Me.fieldDesignCost1.Name = "fieldDesignCost1"
        '
        'fieldEstimateCost1
        '
        Me.fieldEstimateCost1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldEstimateCost1.AreaIndex = 6
        Me.fieldEstimateCost1.CellFormat.FormatString = "c2"
        Me.fieldEstimateCost1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldEstimateCost1.FieldName = "EstimateCost"
        Me.fieldEstimateCost1.Name = "fieldEstimateCost1"
        '
        'fieldDesignHours1
        '
        Me.fieldDesignHours1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldDesignHours1.AreaIndex = 7
        Me.fieldDesignHours1.CellFormat.FormatString = "n2"
        Me.fieldDesignHours1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldDesignHours1.FieldName = "DesignHours"
        Me.fieldDesignHours1.Name = "fieldDesignHours1"
        Me.fieldDesignHours1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldEstimateHours1
        '
        Me.fieldEstimateHours1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldEstimateHours1.AreaIndex = 8
        Me.fieldEstimateHours1.CellFormat.FormatString = "n2"
        Me.fieldEstimateHours1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldEstimateHours1.FieldName = "EstimateHours"
        Me.fieldEstimateHours1.Name = "fieldEstimateHours1"
        Me.fieldEstimateHours1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldDesignEnOs1
        '
        Me.fieldDesignEnOs1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldDesignEnOs1.AreaIndex = 9
        Me.fieldDesignEnOs1.CellFormat.FormatString = "n2"
        Me.fieldDesignEnOs1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldDesignEnOs1.FieldName = "DesignEnOs"
        Me.fieldDesignEnOs1.Name = "fieldDesignEnOs1"
        Me.fieldDesignEnOs1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldDesignEnOCost1
        '
        Me.fieldDesignEnOCost1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldDesignEnOCost1.AreaIndex = 10
        Me.fieldDesignEnOCost1.CellFormat.FormatString = "c2"
        Me.fieldDesignEnOCost1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldDesignEnOCost1.FieldName = "DesignEnOCost"
        Me.fieldDesignEnOCost1.Name = "fieldDesignEnOCost1"
        '
        'fieldHubStaffCount1
        '
        Me.fieldHubStaffCount1.AreaIndex = 4
        Me.fieldHubStaffCount1.FieldName = "HubStaffCount"
        Me.fieldHubStaffCount1.Name = "fieldHubStaffCount1"
        '
        'fieldWorkingDays1
        '
        Me.fieldWorkingDays1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldWorkingDays1.AreaIndex = 11
        Me.fieldWorkingDays1.CellFormat.FormatString = "n2"
        Me.fieldWorkingDays1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldWorkingDays1.FieldName = "WorkingDays"
        Me.fieldWorkingDays1.Name = "fieldWorkingDays1"
        '
        'tabTeam
        '
        Me.tabTeam.Controls.Add(Me.btnteamsave)
        Me.tabTeam.Controls.Add(Me.EmpTeamGridControl)
        Me.tabTeam.Name = "tabTeam"
        Me.tabTeam.Size = New System.Drawing.Size(1180, 542)
        Me.tabTeam.Text = "XtraTabPage4"
        '
        'btnteamsave
        '
        Me.btnteamsave.Location = New System.Drawing.Point(11, 44)
        Me.btnteamsave.Name = "btnteamsave"
        Me.btnteamsave.Size = New System.Drawing.Size(75, 23)
        Me.btnteamsave.TabIndex = 1
        Me.btnteamsave.Text = "Save"
        '
        'EmpTeamGridControl
        '
        Me.EmpTeamGridControl.DataSource = Me.EmpTeamBindingSource
        Me.EmpTeamGridControl.Location = New System.Drawing.Point(11, 73)
        Me.EmpTeamGridControl.MainView = Me.GridView4
        Me.EmpTeamGridControl.Name = "EmpTeamGridControl"
        Me.EmpTeamGridControl.Size = New System.Drawing.Size(1162, 462)
        Me.EmpTeamGridControl.TabIndex = 0
        Me.EmpTeamGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEmpTeam, Me.colEmpTeamName, Me.colEmpTeamLeader})
        Me.GridView4.GridControl = Me.EmpTeamGridControl
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        '
        'colEmpTeam
        '
        Me.colEmpTeam.FieldName = "EmpTeam"
        Me.colEmpTeam.Name = "colEmpTeam"
        Me.colEmpTeam.Visible = True
        Me.colEmpTeam.VisibleIndex = 0
        '
        'colEmpTeamName
        '
        Me.colEmpTeamName.FieldName = "EmpTeamName"
        Me.colEmpTeamName.Name = "colEmpTeamName"
        Me.colEmpTeamName.Visible = True
        Me.colEmpTeamName.VisibleIndex = 1
        '
        'colEmpTeamLeader
        '
        Me.colEmpTeamLeader.FieldName = "EmpTeamLeader"
        Me.colEmpTeamLeader.Name = "colEmpTeamLeader"
        Me.colEmpTeamLeader.Visible = True
        Me.colEmpTeamLeader.VisibleIndex = 2
        '
        'MonthlyMetricsTableAdapter
        '
        Me.MonthlyMetricsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.MonthlyMetricsTableAdapter = Me.MonthlyMetricsTableAdapter
        Me.TableAdapterManager2.UpdateOrder = DesignMetrics.DSMonthlyMetricsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FKDesignMetricsEmployeesBindingSource
        '
        Me.FKDesignMetricsEmployeesBindingSource.DataMember = "FK_DesignMetrics_Employees"
        Me.FKDesignMetricsEmployeesBindingSource.DataSource = Me.EmployeesBindingSource
        '
        'EmpWorkLocationTableAdapter
        '
        Me.EmpWorkLocationTableAdapter.ClearBeforeFill = True
        '
        'EmpJobTitlesTableAdapter
        '
        Me.EmpJobTitlesTableAdapter.ClearBeforeFill = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'FKEmpTeamEmployeesBindingSource
        '
        Me.FKEmpTeamEmployeesBindingSource.DataMember = "FK_EmpTeam_Employees"
        Me.FKEmpTeamEmployeesBindingSource.DataSource = Me.EmployeesBindingSource
        '
        'frmDesigners
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1186, 570)
        Me.Controls.Add(Me.tabDesignMetrics)
        Me.Name = "frmDesigners"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Designer Metrics"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.tabMetricsPayRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMetricsPayRate.ResumeLayout(False)
        Me.TabMetrics.ResumeLayout(False)
        CType(Me.DesignMetricsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DesignMetricsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSDesigners, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPayRates.ResumeLayout(False)
        CType(Me.EmpRatesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpRatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpWareIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarehouseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpTypeIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSTimeclock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabDesignMetrics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDesignMetrics.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.EmpTeamNameLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpTeamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpStartDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpStartDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpHomeAddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpJobTitleLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpJobTitlesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpworklocationidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpWorkLocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstDesigners, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.MonthlyMetricsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonthlyMetricsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSMonthlyMetrics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTeam.ResumeLayout(False)
        CType(Me.EmpTeamGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKDesignMetricsEmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKEmpTeamEmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMetricsPayRate As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabPayRates As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TabMetrics As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents DSDesigners As DesignMetrics.DSDesigners
    Friend WithEvents EmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeesTableAdapter As DesignMetrics.DSDesignersTableAdapters.EmployeesTableAdapter
    Friend WithEvents TableAdapterManager As DesignMetrics.DSDesignersTableAdapters.TableAdapterManager
    Friend WithEvents EmpRatesTableAdapter As DesignMetrics.DSDesignersTableAdapters.EmpRatesTableAdapter
    Friend WithEvents EmpIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmpFirstTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmpRatesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpRatesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colEmpID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmpPayRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEffectivedate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DesignMetricsTableAdapter As DesignMetrics.DSDesignersTableAdapters.DesignMetricsTableAdapter
    Friend WithEvents DesignMetricsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DesignMetricsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colEMPID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHoursWorked As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colToShopBDFT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalBDFT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstBDFT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEWPLF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLooseSQFT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesignEnoCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesignEnoNBR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colyearsort As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colweeksort As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWeekYear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmpLastTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmpLoginTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmpWareIDLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents EmpTypeIDLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents EmpTimeClockIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WarehouseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WarehouseTableAdapter As DesignMetrics.DSDesignersTableAdapters.WarehouseTableAdapter
    Friend WithEvents EmployeeTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTypeTableAdapter As DesignMetrics.DSDesignersTableAdapters.EmployeeTypeTableAdapter
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DSTimeclock As DesignMetrics.DSTimeclock
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTableAdapter As DesignMetrics.DSTimeclockTableAdapters.EmployeeTableAdapter
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabDesignMetrics As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents DSMonthlyMetrics As DesignMetrics.DSMonthlyMetrics
    Friend WithEvents MonthlyMetricsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MonthlyMetricsTableAdapter As DesignMetrics.DSMonthlyMetricsTableAdapters.MonthlyMetricsTableAdapter
    Friend WithEvents TableAdapterManager2 As DesignMetrics.DSMonthlyMetricsTableAdapters.TableAdapterManager
    Friend WithEvents btnMonthlySave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MonthlyMetricsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMonth As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkingDays As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedBDFT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderedBDFT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubmittedBDFT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesignToShopBDFT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuiltBDFT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesignCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimateCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesignHours As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimateHours As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesignEnOs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesignEnOCost1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHubStaffCount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFiscalMonth As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFiscalYear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnDashboards As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExportMonthlyExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colEffectiveEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldMonthlyMetricsID1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMonth1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldYear1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFiscalMonth1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFiscalYear1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEstimatedBDFT1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOrderedBDFT1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSubmittedBDFT1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDesignToShopBDFT1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBuiltBDFT1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDesignCost1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEstimateCost1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDesignHours1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEstimateHours1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDesignEnOs1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDesignEnOCost1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHubStaffCount1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldWorkingDays1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents lstDesigners As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents FKDesignMetricsEmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EmpWorkLocationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpWorkLocationTableAdapter As DesignMetrics.DSDesignersTableAdapters.EmpWorkLocationTableAdapter
    Friend WithEvents EmpworklocationidLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents EmpJobTitleLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents EmpJobTitlesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpJobTitlesTableAdapter As DesignMetrics.DSDesignersTableAdapters.EmpJobTitlesTableAdapter
    Friend WithEvents EmpStartDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents EmpHomeAddressTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EmpTeamBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpTeamTableAdapter As DesignMetrics.DSDesignersTableAdapters.EmpTeamTableAdapter
    Friend WithEvents EmpTeamNameLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents FKEmpTeamEmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tabTeam As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents EmpTeamGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colEmpTeam As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmpTeamName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmpTeamLeader As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnteamsave As DevExpress.XtraEditors.SimpleButton
End Class
