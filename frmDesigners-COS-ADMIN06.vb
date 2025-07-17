Imports System.Globalization
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns

Public Class frmDesigners

    Sub New()

        InitializeComponent()


    End Sub


    Private Sub frmDesigners_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        'TODO: This line of code loads data into the 'DSDesigners.YearlyDesignMetrics' table. You can move, or remove it, as needed.
        Me.YearlyDesignMetricsTableAdapter.Fill(Me.DSDesigners.YearlyDesignMetrics)

    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetRowCellValue(e.RowHandle, colEmpID, EmpIDTextBox.Text)
    End Sub

    Private Sub GridView2_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView2.InitNewRow
        GridView2.SetRowCellValue(e.RowHandle, colEMPID1, EmpIDTextBox.Text)
        GridView2.SetRowCellValue(e.RowHandle, colyearsort, DatePart(DateInterval.Year, Today()))

    End Sub

    Private Sub btnMovePrev_Click(sender As Object, e As EventArgs) Handles btnMovePrev.Click
        Me.EmployeesBindingSource.MovePrevious()
    End Sub

    Private Sub btnMoveNext_Click(sender As Object, e As EventArgs) Handles btnMoveNext.Click
        Me.EmployeesBindingSource.MoveNext()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.EmployeesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSDesigners)
    End Sub



    Public Shared Function FirstDateOfWeek(ByVal year As Integer, ByVal weekOfYear As Integer) As DateTime
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
        Return result.AddDays(-11)
    End Function
    Public Shared Function LastDateOfWeek(ByVal year As Integer, ByVal weekOfYear As Integer) As DateTime
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
        Return result.AddDays(-4)
    End Function




    Private Sub GridView2_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView2.ValidateRow
        If GridView2.GetRowCellValue(e.RowHandle, colweeksort) > 0 Then

            GridView2.SetRowCellValue(e.RowHandle, colHoursWorked, 0.001 + Me.EmployeeTableAdapter.ReturnHours(FirstDateOfWeek(GridView2.GetRowCellValue(e.RowHandle, colyearsort), GridView2.GetRowCellValue(e.RowHandle, colweeksort)), LastDateOfWeek(GridView2.GetRowCellValue(e.RowHandle, colyearsort), GridView2.GetRowCellValue(e.RowHandle, colweeksort)), Me.EmpTimeClockIDTextBox.Text))
            GridView2.SetRowCellValue(e.RowHandle, colWeekYear, GridView2.GetRowCellValue(e.RowHandle, colweeksort) & "-" & GridView2.GetRowCellValue(e.RowHandle, colyearsort))

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Validate()
        Me.MonthlyMetricsBindingSource.EndEdit()
        Me.TableAdapterManager2.UpdateAll(Me.DSMonthlyMetrics)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        frmDashboard.Show()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Dim path As String = "output.xlsx"
        MonthlyMetricsGridControl.ExportToXlsx(path)
        ' Open the created XLSX file with the default application.
        Process.Start(path)
    End Sub


    Private Sub XtraTabControl1_Selecting(sender As Object, e As DevExpress.XtraTab.TabPageCancelEventArgs) Handles XtraTabControl1.Selecting
        If e.PageIndex = 1 Then
            If InputBox("Please Enter the password", "Password") <> "Builders2021" Then
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Me.EmployeesBindingSource.AddNew()

    End Sub

    Private Sub GridView2_ShowingEditor(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GridView2.ShowingEditor
        Dim view As GridView = TryCast(sender, GridView)
        For Each column As GridColumn In view.VisibleColumns
            If column.Visible And column.OptionsColumn.AllowEdit Then
                Dim focusedValue As Object = view.GetFocusedValue()
                If focusedValue IsNot Nothing AndAlso String.IsNullOrEmpty(focusedValue.ToString()) Then
                    Dim defaultValue As Object = GetDefaultValueForColumn(column.FieldName)
                    If defaultValue IsNot Nothing Then
                        view.SetFocusedValue(defaultValue)
                    End If
                End If
            End If
        Next
    End Sub
    Private Function GetDefaultValueForColumn(fieldName As String) As Object
        'Return default value for the given column name'
        Select Case fieldName
            Case "TotalBDFT"
                Return 0
            Case "ToShopBDFT"
                Return 0
            Case "EstBDFT"
                Return 0
            Case "EWPLF"
                Return 0
            Case "LooseSQFT"
                Return 0
            Case "DesignEnoCost"
                Return 0
            Case "DesignEnoNBR"
                Return 0
            Case Else
                Return Nothing
        End Select
    End Function
End Class