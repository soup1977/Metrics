Imports DevExpress.DashboardCommon
Imports DevExpress.DataAccess.ConnectionParameters

Public Class frmDashboard


    Private Sub frmDashboard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Dim dir As String = My.Settings.SettingsPath & "Settings\Dashboard\"
        'If My.Computer.FileSystem.DirectoryExists(dir) Then

        '    ComboBoxEdit1.Properties.Items.Clear()
        '    For Each foundfile As String In My.Computer.FileSystem.GetFiles(dir)
        '        ComboBoxEdit1.Properties.Items.Add(System.IO.Path.GetFileNameWithoutExtension(foundfile))
        '    Next

        'End If
        'Dim pr As New MsSqlConnectionParameters("cosql01\sqldenver", "Pata", "test", "test", MsSqlAuthorizationType.Windows)
        'Dim conn As New DataConnection("Conn1", pr)
        'Dim provide As New SqlDataProvider(conn, "select * from v_OrderDashboard")
        'Dim ds As New DataSource("Orders", provide)

        Dim mssqlparams As New MsSqlConnectionParameters
        mssqlparams.AuthorizationType = MsSqlAuthorizationType.Windows
        mssqlparams.ServerName = "bwcosql01\cosprod"
        mssqlparams.DatabaseName = "pata"
        Dim sqldatasource As New DashboardSqlDataSource("Metrics", mssqlparams)
        Dim query As New DevExpress.DataAccess.Sql.CustomSqlQuery
        query.Name = "Metricsquery"
        query.Sql = "select * from MonthlyMetrics"

        sqldatasource.Queries.Add(query)
        Dim designquery As New DevExpress.DataAccess.Sql.CustomSqlQuery
        designquery.Name = "DesignWeeklyMetrics"
        designquery.Sql = "SELECT v_empfullname.[Full name], DesignMetrics.* FROM DesignMetrics INNER JOIN v_empfullname ON DesignMetrics.EMPID = v_empfullname.EmpID"

        sqldatasource.Queries.Add(designquery)

        Dim dashboard As New Dashboard
        dashboard.DataSources.Add(sqldatasource)
        DashboardDesigner1.Dashboard = dashboard

    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click

        OpenFileDialog1.InitialDirectory = "C:\Users\Craig\OneDrive - Builders Warehouse\Documents"
        OpenFileDialog1.Filter = "Dashboard Files|*.XML"

        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Me.DashboardViewer1.LoadDashboard(OpenFileDialog1.FileName)
            DashboardViewer1.ReloadData()
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        DashboardViewer1.Dashboard = DashboardDesigner1.Dashboard
    End Sub
End Class