Public Class CustomerManage
    Private Sub CustomerManage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Customer_DBDataSet1.Customer_DB' table. You can move, or remove it, as needed.
        Me.Customer_DBTableAdapter.Fill(Me.Customer_DBDataSet1.Customer_DB)
        'TODO: This line of code loads data into the 'Customer_DBDataSet.Financial_DB' table. You can move, or remove it, as needed.
        Me.Financial_DBTableAdapter.Fill(Me.Customer_DBDataSet.Financial_DB)
        DatagridSetting()
    End Sub

    Private Sub DatagridSetting()
        Me.Customer_DBTableAdapter.Fill(Me.Customer_DBDataSet.Customer_DB)


        Me.Customer_DBDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty
        Me.Customer_DBDataGridView.DefaultCellStyle.ForeColor = Color.White
        Me.Customer_DBDataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(166, 89, 0)
        Me.Customer_DBDataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(95, 46, 0)
        Me.Customer_DBDataGridView.DefaultCellStyle.SelectionForeColor = Color.White
        Me.Customer_DBDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        Me.Customer_DBDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
        Me.Customer_DBDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black
        Me.Customer_DBDataGridView.DefaultCellStyle.Font = New Font("Malgun Gothic", 10)


        Customer_DBDataGridView.Sort(Customer_DBDataGridView.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub SearchBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchBox.TextChanged
        Customer_DBBindingSource.Filter = "Customer_Name like '%" & Trim(SearchBox.Text) & "%'"
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click

        Customer_DBBindingSource.EndEdit()
        Customer_DBTableAdapter.Update(Customer_DBDataSet.Customer_DB)
        MsgBox("Data Saved")
    End Sub

    Private Sub Remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemove.Click
        Dim yesno As String
        yesno = MsgBox("Delete Permanently?", vbYesNo)
        If yesno = vbYes Then
            Customer_DBBindingSource.RemoveCurrent()
            Customer_DBBindingSource.EndEdit()
            Customer_DBTableAdapter.Update(Customer_DBDataSet.Customer_DB)
            MsgBox("Successfully deleted")
        End If
    End Sub

    Private Sub BtnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegister.Click
        RegisterWindow.Show()
        If RegisterWindow.WindowState = FormWindowState.Minimized Then
            RegisterWindow.WindowState = FormWindowState.Normal
        End If
        RegisterWindow.Focus()
    End Sub

    Private Sub BtnMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMain.Click
        Dashboard.Focus()
        If Dashboard.WindowState = FormWindowState.Minimized Then
            Dashboard.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub



End Class