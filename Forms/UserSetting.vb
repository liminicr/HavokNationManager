Public Class UserSetting

    Private Sub toPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toPrice.Click
        Me.Opacity = 0
        PriceSetting.ShowDialog()
    End Sub

    Private Sub toPCname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toPCname.Click
        Me.Opacity = 0
        ChangeName.ShowDialog()
    End Sub


    Private Sub UserSetting_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.Left = Dashboard.Left + 250
        Me.Top = Dashboard.Top + 220
    End Sub
End Class