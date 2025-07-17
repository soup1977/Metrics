<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtest
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
        Me.ListBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
        Me.ViewRolesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewRoleDataSet = New DesignMetrics.ViewRoleDataSet()
        Me.ViewRolesTableAdapter = New DesignMetrics.ViewRoleDataSetTableAdapters.ViewRolesTableAdapter()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ViewPermissionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewRoleDataSet1 = New DesignMetrics.ViewRoleDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colVPermID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVPermName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVPermFuncAreaName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVPermFuncAreafrm = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAssigned = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ViewPermissionsTableAdapter = New DesignMetrics.ViewRoleDataSetTableAdapters.ViewPermissionsTableAdapter()
        Me.DSDesigners = New DesignMetrics.DSDesigners()
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeesTableAdapter = New DesignMetrics.DSDesignersTableAdapters.EmployeesTableAdapter()
        Me.TableAdapterManager = New DesignMetrics.DSDesignersTableAdapters.TableAdapterManager()
        CType(Me.ListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewRolesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewRoleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewPermissionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewRoleDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSDesigners, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBoxControl1
        '
        Me.ListBoxControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ListBoxControl1.DataSource = Me.ViewRolesBindingSource
        Me.ListBoxControl1.DisplayMember = "ViewRoleName"
        Me.ListBoxControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListBoxControl1.Location = New System.Drawing.Point(0, 0)
        Me.ListBoxControl1.Name = "ListBoxControl1"
        Me.ListBoxControl1.Size = New System.Drawing.Size(187, 530)
        Me.ListBoxControl1.TabIndex = 0
        Me.ListBoxControl1.ValueMember = "VRID"
        '
        'ViewRolesBindingSource
        '
        Me.ViewRolesBindingSource.DataMember = "ViewRoles"
        Me.ViewRolesBindingSource.DataSource = Me.ViewRoleDataSet
        '
        'ViewRoleDataSet
        '
        Me.ViewRoleDataSet.DataSetName = "ViewRoleDataSet"
        Me.ViewRoleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ViewRolesTableAdapter
        '
        Me.ViewRolesTableAdapter.ClearBeforeFill = True
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.ViewPermissionsBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridControl1.Location = New System.Drawing.Point(187, 129)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(600, 401)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ViewPermissionsBindingSource
        '
        Me.ViewPermissionsBindingSource.DataMember = "ViewPermissions"
        Me.ViewPermissionsBindingSource.DataSource = Me.ViewRoleDataSet1
        '
        'ViewRoleDataSet1
        '
        Me.ViewRoleDataSet1.DataSetName = "ViewRoleDataSet"
        Me.ViewRoleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colVPermID, Me.colVPermName, Me.colVPermFuncAreaName, Me.colVPermFuncAreafrm, Me.colAssigned})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colVPermID
        '
        Me.colVPermID.FieldName = "VPermID"
        Me.colVPermID.Name = "colVPermID"
        Me.colVPermID.Visible = True
        Me.colVPermID.VisibleIndex = 0
        '
        'colVPermName
        '
        Me.colVPermName.FieldName = "VPermName"
        Me.colVPermName.Name = "colVPermName"
        Me.colVPermName.Visible = True
        Me.colVPermName.VisibleIndex = 1
        '
        'colVPermFuncAreaName
        '
        Me.colVPermFuncAreaName.FieldName = "VPermFuncAreaName"
        Me.colVPermFuncAreaName.Name = "colVPermFuncAreaName"
        Me.colVPermFuncAreaName.Visible = True
        Me.colVPermFuncAreaName.VisibleIndex = 2
        '
        'colVPermFuncAreafrm
        '
        Me.colVPermFuncAreafrm.FieldName = "VPermFuncAreafrm"
        Me.colVPermFuncAreafrm.Name = "colVPermFuncAreafrm"
        Me.colVPermFuncAreafrm.Visible = True
        Me.colVPermFuncAreafrm.VisibleIndex = 3
        '
        'colAssigned
        '
        Me.colAssigned.FieldName = "Assigned"
        Me.colAssigned.Name = "colAssigned"
        Me.colAssigned.Visible = True
        Me.colAssigned.VisibleIndex = 4
        '
        'ViewPermissionsTableAdapter
        '
        Me.ViewPermissionsTableAdapter.ClearBeforeFill = True
        '
        'DSDesigners
        '
        Me.DSDesigners.DataSetName = "DSDesigners"
        Me.DSDesigners.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "Employees"
        Me.EmployeesBindingSource.DataSource = Me.DSDesigners
        '
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DesignMetricsTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Me.EmployeesTableAdapter
        Me.TableAdapterManager.EmployeeTypeTableAdapter = Nothing
        Me.TableAdapterManager.EmpRatesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DesignMetrics.DSDesignersTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WarehouseTableAdapter = Nothing
        '
        'frmtest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 530)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.ListBoxControl1)
        Me.Name = "frmtest"
        Me.Text = "frmtest"
        CType(Me.ListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewRolesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewRoleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewPermissionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewRoleDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSDesigners, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBoxControl1 As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents ViewRoleDataSet As DesignMetrics.ViewRoleDataSet
    Friend WithEvents ViewRolesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViewRolesTableAdapter As DesignMetrics.ViewRoleDataSetTableAdapters.ViewRolesTableAdapter
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ViewRoleDataSet1 As DesignMetrics.ViewRoleDataSet
    Friend WithEvents ViewPermissionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViewPermissionsTableAdapter As DesignMetrics.ViewRoleDataSetTableAdapters.ViewPermissionsTableAdapter
    Friend WithEvents colVPermID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVPermName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVPermFuncAreaName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVPermFuncAreafrm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssigned As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DSDesigners As DesignMetrics.DSDesigners
    Friend WithEvents EmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeesTableAdapter As DesignMetrics.DSDesignersTableAdapters.EmployeesTableAdapter
    Friend WithEvents TableAdapterManager As DesignMetrics.DSDesignersTableAdapters.TableAdapterManager
End Class
