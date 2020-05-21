Public Class PriceSetting

    Private Sub PriceSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        time.Value = My.Settings.rate_time
        water.Value = My.Settings.rate_Water
        coke.Value = My.Settings.rate_Coke
        fanta.Value = My.Settings.rate_Fanta
        mtdew.Value = My.Settings.rate_Mtdew
        redbull.Value = My.Settings.rate_Redbull
        Apply.Enabled = False
    End Sub

    Private Sub Any_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles time.TextChanged, water.TextChanged,
                                                     coke.TextChanged, fanta.TextChanged, mtdew.TextChanged, redbull.TextChanged
        Apply.Enabled = True
    End Sub

    Private Sub Apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Apply.Click
        Dim yesno As String
        yesno = MsgBox("Apply the setting?", vbYesNo, "Confirm")
        If yesno = vbYes Then
            If Dashboard.CustomerNumber > 0 Then
                MsgBox("Please make sure that there are no customers assigned")
            Else
                Apply.Enabled = False
                My.Settings.rate_time = time.Value
                My.Settings.rate_Water = water.Value
                My.Settings.rate_Coke = coke.Value
                My.Settings.rate_Fanta = fanta.Value
                My.Settings.rate_Mtdew = mtdew.Value
                My.Settings.rate_Redbull = redbull.Value
                My.Settings.Save()
            End If
        End If
    End Sub

    Private Sub PriceSetting_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        UserSetting.Opacity = 100
    End Sub
    Private Sub Cancel_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class