Public Class AssignWindow

    Private Sub Assign_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Calls DatagridSetting() when loaded
        DatagridSetting()
        Customer_DBDataGridView.Columns(0).Visible = False
    End Sub

    Private Sub DatagridSetting()
        'Fills the gridview
        Me.Customer_DBTableAdapter.Fill(Me.Customer_DBDataSet.Customer_DB)

        'Datagridview Design
        Me.Customer_DBDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty
        Me.Customer_DBDataGridView.DefaultCellStyle.ForeColor = Color.White
        Me.Customer_DBDataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(166, 89, 0)
        Me.Customer_DBDataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(95, 46, 0)
        Me.Customer_DBDataGridView.DefaultCellStyle.SelectionForeColor = Color.White
        Me.Customer_DBDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        Me.Customer_DBDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
        Me.Customer_DBDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black
        Customer_DBDataGridView.DefaultCellStyle.Font = New Font("Malgun Gothic", 10)

        'Sort by ID number in ascending order
        Customer_DBDataGridView.Sort(Customer_DBDataGridView.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, _
                                     ByVal e As System.EventArgs) Handles SearchBox.TextChanged

        Me.Customer_DBBindingSource.Filter = "Customer_Name like '%" & Trim(SearchBox.Text) & "%'"

    End Sub


    Private Sub Assign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Assign.Click
        Assigning(Dashboard.current)
    End Sub

    Private Sub Customer_DBDataGridView_CellContentClick(ByVal sender As System.Object, _
                                                 ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Customer_DBDataGridView.CellDoubleClick
        Assigning(Dashboard.current)
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


    Private Sub Assigning(ByVal current As Integer)
        Dim yesno As String
        Dim assigned As Boolean = False
        Dim i As Integer = 0
        
        yesno = MsgBox("Assign customer?", vbYesNo, "Confirm")

        If yesno = vbYes Then
            For i = 0 To 19
                If Dashboard.id(i) = Customer_DBDataGridView.CurrentRow.Cells(0).Value Then
                    assigned = True
                End If
            Next

            If assigned = True Then
                MsgBox("The customer is already assigned!")
            Else

                My.Settings.names(current - 1) = Customer_NameTextBox.Text
                My.Settings.intimes(current - 1) = DateTime.Now.ToString
                My.Settings.ids(current - 1) = CStr(Customer_DBDataGridView.CurrentRow.Cells(0).Value)
                My.Settings.Save()
                Dashboard.inTime(current - 1) = DateTime.Now
                Dashboard.id(current - 1) = Customer_DBDataGridView.CurrentRow.Cells(0).Value
                Dashboard.namelist(current - 1) = Customer_NameTextBox.Text
                Dashboard.CustomerNumber += 1
                Dashboard.CustNum.Text = Dashboard.CustomerNumber
                If current = 1 Then
                    Dashboard.Name1.Text = Customer_NameTextBox.Text
                    Dashboard.Timer1.Enabled = True
                    Dashboard.PCbtn1.Text = "Manage"
                ElseIf current = 2 Then
                    Dashboard.Name2.Text = Customer_NameTextBox.Text
                    Dashboard.Timer2.Enabled = True
                    Dashboard.PCbtn2.Text = "Manage"
                ElseIf current = 3 Then
                    Dashboard.Name3.Text = Customer_NameTextBox.Text
                    Dashboard.Timer3.Enabled = True
                    Dashboard.PCbtn3.Text = "Manage"
                ElseIf current = 4 Then
                    Dashboard.Name4.Text = Customer_NameTextBox.Text
                    Dashboard.Timer4.Enabled = True
                    Dashboard.PCbtn4.Text = "Manage"
                ElseIf current = 5 Then
                    Dashboard.Name5.Text = Customer_NameTextBox.Text
                    Dashboard.Timer5.Enabled = True
                    Dashboard.PCbtn5.Text = "Manage"
                ElseIf current = 6 Then
                    Dashboard.Name6.Text = Customer_NameTextBox.Text
                    Dashboard.Timer6.Enabled = True
                    Dashboard.PCbtn6.Text = "Manage"
                ElseIf current = 7 Then
                    Dashboard.Name7.Text = Customer_NameTextBox.Text
                    Dashboard.Timer7.Enabled = True
                    Dashboard.PCbtn7.Text = "Manage"
                ElseIf current = 8 Then
                    Dashboard.Name8.Text = Customer_NameTextBox.Text
                    Dashboard.Timer8.Enabled = True
                    Dashboard.PCbtn8.Text = "Manage"
                ElseIf current = 9 Then
                    Dashboard.Name9.Text = Customer_NameTextBox.Text
                    Dashboard.Timer9.Enabled = True
                    Dashboard.PCbtn9.Text = "Manage"
                ElseIf current = 10 Then
                    Dashboard.Name10.Text = Customer_NameTextBox.Text
                    Dashboard.Timer10.Enabled = True
                    Dashboard.PCbtn10.Text = "Manage"
                ElseIf current = 11 Then
                    Dashboard.Name11.Text = Customer_NameTextBox.Text
                    Dashboard.Timer11.Enabled = True
                    Dashboard.PCbtn11.Text = "Manage"
                ElseIf current = 12 Then
                    Dashboard.Name12.Text = Customer_NameTextBox.Text
                    Dashboard.Timer12.Enabled = True
                    Dashboard.PCbtn12.Text = "Manage"
                ElseIf current = 13 Then
                    Dashboard.Name13.Text = Customer_NameTextBox.Text
                    Dashboard.Timer13.Enabled = True
                    Dashboard.PCbtn13.Text = "Manage"
                ElseIf current = 14 Then
                    Dashboard.Name14.Text = Customer_NameTextBox.Text
                    Dashboard.Timer14.Enabled = True
                    Dashboard.PCbtn14.Text = "Manage"
                ElseIf current = 15 Then
                    Dashboard.Name15.Text = Customer_NameTextBox.Text
                    Dashboard.Timer15.Enabled = True
                    Dashboard.PCbtn15.Text = "Manage"
                ElseIf current = 16 Then
                    Dashboard.Name16.Text = Customer_NameTextBox.Text
                    Dashboard.Timer16.Enabled = True
                    Dashboard.PCbtn16.Text = "Manage"
                ElseIf current = 17 Then
                    Dashboard.Name17.Text = Customer_NameTextBox.Text
                    Dashboard.Timer17.Enabled = True
                    Dashboard.PCbtn17.Text = "Manage"
                ElseIf current = 18 Then
                    Dashboard.Name18.Text = Customer_NameTextBox.Text
                    Dashboard.Timer18.Enabled = True
                    Dashboard.PCbtn18.Text = "Manage"
                ElseIf current = 19 Then
                    Dashboard.Name19.Text = Customer_NameTextBox.Text
                    Dashboard.Timer19.Enabled = True
                    Dashboard.PCbtn19.Text = "Manage"
                ElseIf current = 20 Then
                    Dashboard.Name20.Text = Customer_NameTextBox.Text
                    Dashboard.Timer20.Enabled = True
                    Dashboard.PCbtn20.Text = "Manage"
                End If
                Me.Close()
            End If

            End If

    End Sub

End Class