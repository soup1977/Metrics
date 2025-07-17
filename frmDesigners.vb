Imports System.Globalization
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmDesigners

    Sub New()

        InitializeComponent()


    End Sub


    Private Sub frmDesigners_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSDesigners.EmpTeam' table. You can move, or remove it, as needed.
        Me.EmpTeamTableAdapter.Fill(Me.DSDesigners.EmpTeam)
        'TODO: This line of code loads data into the 'DSDesigners.EmpJobTitles' table. You can move, or remove it, as needed.
        Me.EmpJobTitlesTableAdapter.Fill(Me.DSDesigners.EmpJobTitles)
        'TODO: This line of code loads data into the 'DSDesigners.EmpWorkLocation' table. You can move, or remove it, as needed.
        Me.EmpWorkLocationTableAdapter.Fill(Me.DSDesigners.EmpWorkLocation)

        'TODO: This line of code loads data into the 'DSMonthlyMetrics.MonthlyMetrics' table. You can move, or remove it, as needed.
        Me.MonthlyMetricsTableAdapter.Fill(Me.DSMonthlyMetrics.MonthlyMetrics)
        'TODO: This line of code loads data into the 'DSDesigners.EmployeeType' table. You can move, or remove it, as needed.
        Me.EmployeeTypeTableAdapter.Fill(Me.DSDesigners.EmployeeType)
        'TODO: This line of code loads data into the 'DSDesigners.Warehouse' table. You can move, or remove it, as needed.
        Me.WarehouseTableAdapter.Fill(Me.DSDesigners.Warehouse)
        'TODO: This line of code loads data into the 'DSDesigners.DesignMetrics' table. You can move, or remove it, as needed.
        Me.DesignMetricsTableAdapter.Fill(Me.DSDesigners.DesignMetrics)
        'TODO: This line of code loads data into the 'DSDesigners.EmpRates' table. You can move, or remove it, as needed.
        Me.EmpRatesTableAdapter.Fill(Me.DSDesigners.EmpRates)
        'TODO: This line of code loads data into the 'DSDesigners.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.DSDesigners.Employees)
        Me.EmpTeamTableAdapter.Fill(Me.DSDesigners.EmpTeam)


    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetRowCellValue(e.RowHandle, colEmpID, EmpIDTextBox.Text)
    End Sub

    Private Sub GridView2_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView2.InitNewRow
        GridView2.SetRowCellValue(e.RowHandle, colEMPID1, EmpIDTextBox.Text)
        GridView2.SetRowCellValue(e.RowHandle, colyearsort, DatePart(DateInterval.Year, Today()))

    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.EmployeesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSDesigners)


    End Sub



    Public Shared Function FirstDateOfWeek(ByVal year As Integer, ByVal weekOfYear As Integer) As DateTime
        If year = 0 Then
            Exit Function
        End If
        Dim dfi As DateTimeFormatInfo = DateTimeFormatInfo.CurrentInfo

        Dim jan1 As DateTime = New DateTime(year, 1, 1)
        Dim daysOffset As Integer = DayOfWeek.Thursday - jan1.DayOfWeek
        Dim firstThursday As DateTime = jan1.AddDays(daysOffset)
        Dim cal = CultureInfo.CurrentCulture.Calendar
        Dim firstWeek As Integer = cal.GetWeekOfYear(firstThursday, dfi.CalendarWeekRule, dfi.FirstDayOfWeek)
        Dim firstWeek1 As Integer = DatePart(DateInterval.WeekOfYear, jan1, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)
        Dim weekNum = weekOfYear

        If firstWeek = 1 Then
            weekNum -= 1
        End If

        Dim result = firstThursday.AddDays(weekNum * 7)
        Return result.AddDays(-4)
    End Function
    Public Shared Function LastDateOfWeek(ByVal year As Integer, ByVal weekOfYear As Integer) As DateTime
        If year = 0 Then
            Exit Function
        End If
        Dim dfi As DateTimeFormatInfo = DateTimeFormatInfo.CurrentInfo

        Dim jan1 As DateTime = New DateTime(year, 1, 1)
        Dim daysOffset As Integer = DayOfWeek.Thursday - jan1.DayOfWeek
        Dim firstThursday As DateTime = jan1.AddDays(daysOffset)
        Dim cal = CultureInfo.CurrentCulture.Calendar
        Dim firstWeek As Integer = cal.GetWeekOfYear(firstThursday, dfi.CalendarWeekRule, dfi.FirstDayOfWeek)
        Dim weekNum = weekOfYear

        If firstWeek = 1 Then
            weekNum -= 1
        End If

        Dim result = firstThursday.AddDays(weekNum * 7)
        Return result.AddDays(4)
    End Function




    Private Sub GridView2_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView2.ValidateRow
        If GridView2.GetRowCellValue(e.RowHandle, colweeksort) > 0 Then
            Dim x As String = e.RowHandle
            '  GridView2.SetRowCellValue(e.RowHandle, colHoursWorked, 0.001 + Me.EmployeeTableAdapter.ReturnHours(FirstDateOfWeek(GridView2.GetRowCellValue(e.RowHandle, colyearsort), GridView2.GetRowCellValue(e.RowHandle, colweeksort)), LastDateOfWeek(GridView2.GetRowCellValue(e.RowHandle, colyearsort), GridView2.GetRowCellValue(e.RowHandle, colweeksort)), Me.EmpTimeClockIDTextBox.Text))
            GridView2.SetRowCellValue(e.RowHandle, colWeekYear, GridView2.GetRowCellValue(e.RowHandle, colweeksort) & "-" & GridView2.GetRowCellValue(e.RowHandle, colyearsort))

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btnMonthlySave.Click
        Me.Validate()
        Me.MonthlyMetricsBindingSource.EndEdit()
        Me.TableAdapterManager2.UpdateAll(Me.DSMonthlyMetrics)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles btnDashboards.Click
        frmDashboard.Show()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles btnExportMonthlyExcel.Click
        Dim path As String = "output.xlsx"
        MonthlyMetricsGridControl.ExportToXlsx(path)
        ' Open the created XLSX file with the default application.
        Process.Start(path)
    End Sub


    Private Sub XtraTabControl1_Selecting(sender As Object, e As DevExpress.XtraTab.TabPageCancelEventArgs) Handles tabMetricsPayRate.Selecting
        If e.PageIndex = 1 Then
            If InputBox("Please Enter the password", "Password") <> "Builders2021" Then
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Me.EmployeesBindingSource.AddNew()

    End Sub


    Private Sub GridView2_BeforeLeaveRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowAllowEventArgs) Handles GridView2.BeforeLeaveRow
        If CInt(GridView2.GetRowCellValue(e.RowHandle, colyearsort)) = 0 Then
            Exit Sub
        End If
        'old timeclock hour pull during row exit.  Not used anymore.
        ' GridView2.SetRowCellValue(e.RowHandle, colHoursWorked, 0.001 + Me.EmployeeTableAdapter.ReturnHours(FirstDateOfWeek(GridView2.GetRowCellValue(e.RowHandle, colyearsort), GridView2.GetRowCellValue(e.RowHandle, colweeksort)), LastDateOfWeek(GridView2.GetRowCellValue(e.RowHandle, colyearsort), GridView2.GetRowCellValue(e.RowHandle, colweeksort)), Me.EmpTimeClockIDTextBox.Text))

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.DesignMetricsTableAdapter.Fill(Me.DSDesigners.DesignMetrics)
        'TODO: This line of code loads data into the 'DSDesigners.EmpRates' table. You can move, or remove it, as needed.
        Me.EmpRatesTableAdapter.Fill(Me.DSDesigners.EmpRates)
        'TODO: This line of code loads data into the 'DSDesigners.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.DSDesigners.Employees)

    End Sub

    Private Sub btnteamsave_Click(sender As Object, e As EventArgs) Handles btnteamsave.Click
        Me.Validate()
        Me.EmpTeamBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSDesigners)
    End Sub


    Private Sub tabDesignMetrics_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles tabDesignMetrics.SelectedPageChanged
        If e.Page.Name = "XtraTabPage3" Then
            If PivotGridControl1.Fields("BdftPerManHour") Is Nothing Then
                Dim calculatedfield As New DevExpress.XtraPivotGrid.PivotGridField()
                With calculatedfield
                    .Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                    .AreaIndex = 8
                    .Caption = "BDFTperMH"
                    .FieldName = "BdftPerManHour"
                    .UnboundType = DevExpress.Data.UnboundColumnType.Decimal
                    .UnboundExpression = "[fieldDesignToShopBDFT1] / IIf([fieldDesignHours1] = 0, 1, [fieldDesignHours1])"
                    .CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .CellFormat.FormatString = "N2"
                End With
                PivotGridControl1.Fields.Add(calculatedfield)
                PivotGridControl1.RefreshData()
            End If
            If PivotGridControl1.Fields("TotalBdftPerManHour") Is Nothing Then
                Dim calculatedfield1 As New DevExpress.XtraPivotGrid.PivotGridField()
                With calculatedfield1
                    .Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                    .AreaIndex = 9
                    .Caption = "TotalBDFTperMH"
                    .FieldName = "TotalBdftPerManHour"
                    .UnboundType = DevExpress.Data.UnboundColumnType.Decimal
                    .UnboundExpression = "([fieldDesignToShopBDFT1]+[fieldSubmittedBDFT1]) / IIf([fieldDesignHours1] = 0, 1, [fieldDesignHours1])"
                    .CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .CellFormat.FormatString = "N2"
                End With
                PivotGridControl1.Fields.Add(calculatedfield1)
                PivotGridControl1.RefreshData()
            End If
            If PivotGridControl1.Fields("EstBdftPerManHour") Is Nothing Then
                Dim calculatedfield2 As New DevExpress.XtraPivotGrid.PivotGridField()
                With calculatedfield2
                    .Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                    .AreaIndex = 11
                    .Caption = "EstBDFTperMH"
                    .FieldName = "EstBdftPerManHour"
                    .UnboundType = DevExpress.Data.UnboundColumnType.Decimal
                    .UnboundExpression = "([fieldEstimatedBDFT1]) / IIf([fieldEstimateHours1] = 0, 1, [fieldEstimateHours1])"
                    .CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .CellFormat.FormatString = "N2"
                End With
                PivotGridControl1.Fields.Add(calculatedfield2)
                PivotGridControl1.RefreshData()
            End If

            If PivotGridControl1.Fields("CostperDesign") Is Nothing Then
                Dim calculatedfield3 As New DevExpress.XtraPivotGrid.PivotGridField()
                With calculatedfield3
                    .Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                    .AreaIndex = 11
                    .Caption = "CostperDesign"
                    .FieldName = "CostperDesign"
                    .UnboundType = DevExpress.Data.UnboundColumnType.Decimal
                    .UnboundExpression = "([fieldDesignCost1]) / IIf([fieldDesignToShopBDFT1] = 0, 1, [fieldDesignToShopBDFT1])"
                    .CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .CellFormat.FormatString = "C2"
                End With
                PivotGridControl1.Fields.Add(calculatedfield3)
                PivotGridControl1.RefreshData()
            End If

            If PivotGridControl1.Fields("CostperEst") Is Nothing Then
                Dim calculatedfield3 As New DevExpress.XtraPivotGrid.PivotGridField()
                With calculatedfield3
                    .Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                    .AreaIndex = 11
                    .Caption = "CostperEst"
                    .FieldName = "CostperEst"
                    .UnboundType = DevExpress.Data.UnboundColumnType.Decimal
                    .UnboundExpression = "([fieldEstimateCost1]) / IIf([fieldEstimatedBDFT1] = 0, 1, [fieldEstimatedBDFT1])"
                    .CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .CellFormat.FormatString = "C4"
                End With
                PivotGridControl1.Fields.Add(calculatedfield3)
                PivotGridControl1.RefreshData()
            End If

        End If
    End Sub
End Class