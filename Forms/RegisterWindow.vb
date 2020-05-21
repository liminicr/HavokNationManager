Public Class RegisterWindow
    Private Sub Registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtName.Text = ""
        Male.Checked = True
        DOBPicker.Value = "1990-01-01"
        txtEmail.Text = ""
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click

        Dim newGender As Char
        If Male.Checked = True Then
            newGender = "M"
        Else
            newGender = "F"
        End If


        If Trim(txtName.Text) = "" Then
            MsgBox("Please Enter name")
            txtName.Text = ""
        Else
            Try
                Customer_DBTableAdapter.Insert(Trim(txtName.Text), newGender, txtEmail.Text, DOBPicker.Value.Date, Trim(txtAddress.Text), Trim(txtContact.Text))
                CustomerManage.Customer_DBTableAdapter.Fill(CustomerManage.Customer_DBDataSet.Customer_DB)
                MsgBox("Customer Registered!")
                Me.Close()
            Catch ex As Exception
                MsgBox("Error! Failed to register. Database cannot be found.")
                Me.Close()
            End Try
        End If
      
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub BtnMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMain.Click
        Dashboard.Focus()
        If Dashboard.WindowState = FormWindowState.Minimized Then
            Dashboard.WindowState = FormWindowState.Normal
        End If
    End Sub

End Class