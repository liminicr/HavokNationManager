Public Class ChangeName

    Private Sub ChangeName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.PCnames(0)
        TextBox2.Text = My.Settings.PCnames(1)
        TextBox3.Text = My.Settings.PCnames(2)
        TextBox4.Text = My.Settings.PCnames(3)
        TextBox5.Text = My.Settings.PCnames(4)
        TextBox6.Text = My.Settings.PCnames(5)
        TextBox7.Text = My.Settings.PCnames(6)
        TextBox8.Text = My.Settings.PCnames(7)
        TextBox9.Text = My.Settings.PCnames(8)
        TextBox10.Text = My.Settings.PCnames(9)
        TextBox11.Text = My.Settings.PCnames(10)
        TextBox12.Text = My.Settings.PCnames(11)
        TextBox13.Text = My.Settings.PCnames(12)
        TextBox14.Text = My.Settings.PCnames(13)
        TextBox15.Text = My.Settings.PCnames(14)
        TextBox16.Text = My.Settings.PCnames(15)
        TextBox17.Text = My.Settings.PCnames(16)
        TextBox18.Text = My.Settings.PCnames(17)
        TextBox19.Text = My.Settings.PCnames(18)
        TextBox20.Text = My.Settings.PCnames(19)
        Apply.Enabled = False
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object,
                                     ByVal e As System.EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged, TextBox4.TextChanged, TextBox5.TextChanged,
                                 TextBox6.TextChanged, TextBox7.TextChanged, TextBox8.TextChanged, TextBox9.TextChanged, TextBox10.TextChanged,
                                 TextBox11.TextChanged, TextBox12.TextChanged, TextBox13.TextChanged, TextBox14.TextChanged, TextBox15.TextChanged,
                                 TextBox16.TextChanged, TextBox17.TextChanged, TextBox18.TextChanged, TextBox19.TextChanged, TextBox20.TextChanged

        Apply.Enabled = True
    End Sub

    Private Sub Apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Apply.Click
        My.Settings.PCnames(0) = TextBox1.Text
        My.Settings.PCnames(1) = TextBox2.Text
        My.Settings.PCnames(2) = TextBox3.Text
        My.Settings.PCnames(3) = TextBox4.Text
        My.Settings.PCnames(4) = TextBox5.Text
        My.Settings.PCnames(5) = TextBox6.Text
        My.Settings.PCnames(6) = TextBox7.Text
        My.Settings.PCnames(7) = TextBox8.Text
        My.Settings.PCnames(8) = TextBox9.Text
        My.Settings.PCnames(9) = TextBox10.Text
        My.Settings.PCnames(10) = TextBox11.Text
        My.Settings.PCnames(11) = TextBox12.Text
        My.Settings.PCnames(12) = TextBox13.Text
        My.Settings.PCnames(13) = TextBox14.Text
        My.Settings.PCnames(14) = TextBox15.Text
        My.Settings.PCnames(15) = TextBox16.Text
        My.Settings.PCnames(16) = TextBox17.Text
        My.Settings.PCnames(17) = TextBox18.Text
        My.Settings.PCnames(18) = TextBox19.Text
        My.Settings.PCnames(19) = TextBox20.Text
        My.Settings.Save()
        Apply.Enabled = False
        Dashboard.PCname()
        MsgBox("PC name(s) has been changed")
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
    Private Sub ChangeName_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        UserSetting.Opacity = 100
    End Sub
End Class