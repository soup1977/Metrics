Public Class frmtest 

    Private Sub frmtest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSDesigners.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.DSDesigners.Employees)
        'TODO: This line of code loads data into the 'ViewRoleDataSet1.ViewPermissions' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'ViewRoleDataSet.ViewRoles' table. You can move, or remove it, as needed.
        Me.ViewRolesTableAdapter.Fill(Me.ViewRoleDataSet.ViewRoles)

    End Sub

    Private Sub ListBoxControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxControl1.SelectedIndexChanged
        Me.ViewPermissionsTableAdapter.FillByRole(Me.ViewRoleDataSet1.ViewPermissions, ListBoxControl1.SelectedIndex + 1)
    End Sub
End Class