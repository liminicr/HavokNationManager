Option Explicit On
Public Class Dashboard
    Public current As Integer = 1
    Public inTime(19) As DateTime
    Public id(19) As Integer
    Public CustomerNumber As Integer = 0
    Public namelist As List(Of String) = New List(Of String)
    Public rate As Double
    Public Waterprice As Integer, Cokeprice As Integer, Fantaprice As Integer, Mtdewprice As Integer, Bullprice As Integer

    Private Sub Dashboard_FormClosing(ByVal sender As Object,
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim yesno As String
        yesno = MsgBox("Do you want to close the program?", vbYesNo, "Warning")
        If yesno = vbYes Then
            If CustomerNumber > 0 Then
                yesno = MsgBox("Are you sure you want to exit the program? " & vbNewLine &
                               "One or more customers have not been payed yet", vbYesNo, "Confirm")
                If yesno = vbYes Then
                    e.Cancel = False
                Else
                    e.Cancel = True
                End If
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer = 1
        For i = 1 To 20
            namelist.Add(".")
        Next
        NameLoading()
        PCname()
        CustNum.Text = CustomerNumber.ToString
    End Sub
    Public Sub PCname()
        PC1.Text = My.Settings.PCnames(0)
        PC2.Text = My.Settings.PCnames(1)
        PC3.Text = My.Settings.PCnames(2)
        PC4.Text = My.Settings.PCnames(3)
        PC5.Text = My.Settings.PCnames(4)
        PC6.Text = My.Settings.PCnames(5)
        PC7.Text = My.Settings.PCnames(6)
        PC8.Text = My.Settings.PCnames(7)
        PC9.Text = My.Settings.PCnames(8)
        PC10.Text = My.Settings.PCnames(9)
        PC11.Text = My.Settings.PCnames(10)
        PC12.Text = My.Settings.PCnames(11)
        PC13.Text = My.Settings.PCnames(12)
        PC14.Text = My.Settings.PCnames(13)
        PC15.Text = My.Settings.PCnames(14)
        PC16.Text = My.Settings.PCnames(15)
        PC17.Text = My.Settings.PCnames(16)
        PC18.Text = My.Settings.PCnames(17)
        PC19.Text = My.Settings.PCnames(18)
        PC20.Text = My.Settings.PCnames(19)
    End Sub
    Private Sub NameLoading()
        For i = 0 To 19
            namelist(i) = My.Settings.names(i)
        Next
        If My.Settings.names(0) <> "-" Then
            Name1.Text = My.Settings.names(0)
            inTime(0) = My.Settings.intimes(0)
            id(0) = CInt(My.Settings.ids(0))
            Timer1.Enabled = True
            PCbtn1.Text = "Manage"
            CustomerNumber += 1
        End If
        If My.Settings.names(1) <> "-" Then
            Name2.Text = My.Settings.names(1)
            inTime(1) = My.Settings.intimes(1)
            id(1) = CInt(My.Settings.ids(1))
            Timer2.Enabled = True
            PCbtn2.Text = "Manage"
            CustomerNumber += 1
        End If
        If My.Settings.names(2) <> "-" Then
            Name3.Text = My.Settings.names(2)
            inTime(2) = My.Settings.intimes(2)
            id(2) = CInt(My.Settings.ids(2))
            Timer3.Enabled = True
            PCbtn3.Text = "Manage"
            CustomerNumber += 1
        End If
        If My.Settings.names(3) <> "-" Then
            Name4.Text = My.Settings.names(3)
            inTime(3) = My.Settings.intimes(3)
            id(3) = CInt(My.Settings.ids(3))
            Timer4.Enabled = True
            PCbtn4.Text = "Manage"
            CustomerNumber += 1
        End If
        If My.Settings.names(4) <> "-" Then
            Name5.Text = My.Settings.names(4)
            inTime(4) = My.Settings.intimes(4)
            id(4) = CInt(My.Settings.ids(4))
            Timer5.Enabled = True
            PCbtn5.Text = "Manage"
            CustomerNumber += 1
        End If
        If My.Settings.names(5) <> "-" Then
            Name6.Text = My.Settings.names(5)
            inTime(5) = My.Settings.intimes(5)
            id(5) = CInt(My.Settings.ids(5))
            Timer6.Enabled = True
            PCbtn6.Text = "Manage"
        End If
        If My.Settings.names(6) <> "-" Then
            Name7.Text = My.Settings.names(6)
            inTime(6) = My.Settings.intimes(6)
            id(6) = CInt(My.Settings.ids(6))
            Timer7.Enabled = True
            PCbtn7.Text = "Manage"
            CustomerNumber += 1
        End If
        If My.Settings.names(7) <> "-" Then
            Name8.Text = My.Settings.names(7)
            inTime(7) = My.Settings.intimes(7)
            id(7) = CInt(My.Settings.ids(7))
            Timer8.Enabled = True
            PCbtn8.Text = "Manage"
            CustomerNumber += 1
        End If
        If My.Settings.names(8) <> "-" Then
            Name9.Text = My.Settings.names(8)
            inTime(8) = My.Settings.intimes(8)
            id(8) = CInt(My.Settings.ids(8))
            Timer9.Enabled = True
            PCbtn9.Text = "Manage"
            CustomerNumber += 1
        End If
        If My.Settings.names(9) <> "-" Then
            Name10.Text = My.Settings.names(9)
            inTime(9) = My.Settings.intimes(9)
            id(9) = CInt(My.Settings.ids(9))
            Timer10.Enabled = True
            PCbtn10.Text = "Manage"
            CustomerNumber += 1
        End If
        If My.Settings.names(10) <> "-" Then
            Name11.Text = My.Settings.names(10)
            inTime(10) = My.Settings.intimes(10)
            id(10) = CInt(My.Settings.ids(10))
            Timer11.Enabled = True
            PCbtn11.Text = "Manage"
            CustomerNumber += 1
        End If
        If My.Settings.names(11) <> "-" Then
            Name12.Text = My.Settings.names(11)
            inTime(11) = My.Settings.intimes(11)
            id(11) = CInt(My.Settings.ids(11))
            Timer12.Enabled = True
            PCbtn12.Text = "Manage"
            CustomerNumber += 1
        End If
        If My.Settings.names(12) <> "-" Then
            Name13.Text = My.Settings.names(12)
            inTime(12) = My.Settings.intimes(12)
            id(12) = CInt(My.Settings.ids(12))
            Timer13.Enabled = True
            PCbtn13.Text = "Manage"
            CustomerNumber += 1
        End If
        If My.Settings.names(13) <> "-" Then
            Name14.Text = My.Settings.names(13)
            inTime(13) = My.Settings.intimes(13)
            id(13) = CInt(My.Settings.ids(13))
            Timer14.Enabled = True
            PCbtn14.Text = "Manage"
            CustomerNumber += 1
        End If
        If My.Settings.names(14) <> "-" Then
            Name15.Text = My.Settings.names(14)
            inTime(14) = My.Settings.intimes(14)
            id(14) = CInt(My.Settings.ids(14))
            Timer15.Enabled = True
            PCbtn15.Text = "Manage"
            CustomerNumber += 1
        End If
        If My.Settings.names(15) <> "-" Then
            Name16.Text = My.Settings.names(15)
            inTime(15) = My.Settings.intimes(15)
            id(15) = CInt(My.Settings.ids(15))
            Timer16.Enabled = True
            PCbtn16.Text = "Manage"
            CustomerNumber += 1
        End If
        If My.Settings.names(16) <> "-" Then
            Name17.Text = My.Settings.names(16)
            inTime(16) = My.Settings.intimes(16)
            id(16) = CInt(My.Settings.ids(16))
            Timer17.Enabled = True
            PCbtn17.Text = "Manage"
            CustomerNumber += 1
        End If
        If My.Settings.names(17) <> "-" Then
            Name18.Text = My.Settings.names(17)
            inTime(17) = My.Settings.intimes(17)
            id(17) = CInt(My.Settings.ids(17))
            Timer18.Enabled = True
            PCbtn18.Text = "Manage"
            CustomerNumber += 1
        End If
        If My.Settings.names(18) <> "-" Then
            Name19.Text = My.Settings.names(18)
            inTime(18) = My.Settings.intimes(18)
            id(18) = CInt(My.Settings.ids(18))
            Timer19.Enabled = True
            PCbtn19.Text = "Manage"
            CustomerNumber += 1
        End If
        If My.Settings.names(19) <> "-" Then
            Name20.Text = My.Settings.names(19)
            inTime(19) = My.Settings.intimes(19)
            id(19) = CInt(My.Settings.ids(19))
            Timer20.Enabled = True
            PCbtn20.Text = "Manage"
            CustomerNumber += 1
        End If
    End Sub

    Private Sub AdminSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminSet.Click
        UserSetting.ShowDialog()
    End Sub

    Private Sub CustManage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustManage.Click
        CustomerManage.Show()
        If CustomerManage.WindowState = FormWindowState.Minimized Then
            CustomerManage.WindowState = FormWindowState.Normal
        End If
        CustomerManage.Focus()
    End Sub

    Private Sub CustRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustRegister.Click
        RegisterWindow.Show()
        If RegisterWindow.WindowState = FormWindowState.Minimized Then
            RegisterWindow.WindowState = FormWindowState.Normal
        End If
        RegisterWindow.Focus()
    End Sub

    Private Sub Finance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Finance.Click
        Financial.Show()

        If Financial.WindowState = FormWindowState.Minimized Then
            Financial.WindowState = FormWindowState.Normal
        End If
        Financial.Focus()
    End Sub

    Private Sub turnoff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles turnoff.Click
            Application.Exit()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim diff1 As TimeSpan = DateTime.Now.Subtract(inTime(0))
        Time1.Text = diff1.Hours.ToString("00") & ":" & diff1.Minutes.ToString("00") & ":" & diff1.Seconds.ToString("00")
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim diff2 As TimeSpan = DateTime.Now.Subtract(inTime(1))
        Time2.Text = diff2.Hours.ToString("00") & ":" & diff2.Minutes.ToString("00") & ":" & diff2.Seconds.ToString("00")
    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Dim diff3 As TimeSpan = DateTime.Now.Subtract(inTime(2))
        Time3.Text = diff3.Hours.ToString("00") & ":" & diff3.Minutes.ToString("00") & ":" & diff3.Seconds.ToString("00")
    End Sub
    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Dim diff4 As TimeSpan = DateTime.Now.Subtract(inTime(3))
        Time4.Text = diff4.Hours.ToString("00") & ":" & diff4.Minutes.ToString("00") & ":" & diff4.Seconds.ToString("00")
    End Sub
    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        Dim diff5 As TimeSpan = DateTime.Now.Subtract(inTime(4))
        Time5.Text = diff5.Hours.ToString("00") & ":" & diff5.Minutes.ToString("00") & ":" & diff5.Seconds.ToString("00")
    End Sub
    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        Dim diff6 As TimeSpan = DateTime.Now.Subtract(inTime(5))
        Time6.Text = diff6.Hours.ToString("00") & ":" & diff6.Minutes.ToString("00") & ":" & diff6.Seconds.ToString("00")
    End Sub
    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer7.Tick
        Dim diff7 As TimeSpan = DateTime.Now.Subtract(inTime(6))
        Time7.Text = diff7.Hours.ToString("00") & ":" & diff7.Minutes.ToString("00") & ":" & diff7.Seconds.ToString("00")
    End Sub
    Private Sub Timer8_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer8.Tick
        Dim diff8 As TimeSpan = DateTime.Now.Subtract(inTime(7))
        Time8.Text = diff8.Hours.ToString("00") & ":" & diff8.Minutes.ToString("00") & ":" & diff8.Seconds.ToString("00")
    End Sub
    Private Sub Timer9_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer9.Tick
        Dim diff9 As TimeSpan = DateTime.Now.Subtract(inTime(8))
        Time9.Text = diff9.Hours.ToString("00") & ":" & diff9.Minutes.ToString("00") & ":" & diff9.Seconds.ToString("00")
    End Sub
    Private Sub Timer10_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer10.Tick
        Dim diff10 As TimeSpan = DateTime.Now.Subtract(inTime(9))
        Time10.Text = diff10.Hours.ToString("00") & ":" & diff10.Minutes.ToString("00") & ":" & diff10.Seconds.ToString("00")
    End Sub
    Private Sub Timer11_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer11.Tick
        Dim diff11 As TimeSpan = DateTime.Now.Subtract(inTime(10))
        Time11.Text = diff11.Hours.ToString("00") & ":" & diff11.Minutes.ToString("00") & ":" & diff11.Seconds.ToString("00")
    End Sub
    Private Sub Timer12_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer12.Tick
        Dim diff12 As TimeSpan = DateTime.Now.Subtract(inTime(11))
        Time12.Text = diff12.Hours.ToString("00") & ":" & diff12.Minutes.ToString("00") & ":" & diff12.Seconds.ToString("00")
    End Sub
    Private Sub Timer13_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer13.Tick
        Dim diff13 As TimeSpan = DateTime.Now.Subtract(inTime(12))
        Time13.Text = diff13.Hours.ToString("00") & ":" & diff13.Minutes.ToString("00") & ":" & diff13.Seconds.ToString("00")
    End Sub
    Private Sub Timer14_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer14.Tick
        Dim diff14 As TimeSpan = DateTime.Now.Subtract(inTime(13))
        Time14.Text = diff14.Hours.ToString("00") & ":" & diff14.Minutes.ToString("00") & ":" & diff14.Seconds.ToString("00")
    End Sub
    Private Sub Timer15_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer15.Tick
        Dim diff15 As TimeSpan = DateTime.Now.Subtract(inTime(14))
        Time15.Text = diff15.Hours.ToString("00") & ":" & diff15.Minutes.ToString("00") & ":" & diff15.Seconds.ToString("00")
    End Sub
    Private Sub Timer16_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer16.Tick
        Dim diff16 As TimeSpan = DateTime.Now.Subtract(inTime(15))
        Time16.Text = diff16.Hours.ToString("00") & ":" & diff16.Minutes.ToString("00") & ":" & diff16.Seconds.ToString("00")
    End Sub
    Private Sub Timer17_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer17.Tick
        Dim diff17 As TimeSpan = DateTime.Now.Subtract(inTime(16))
        Time17.Text = diff17.Hours.ToString("00") & ":" & diff17.Minutes.ToString("00") & ":" & diff17.Seconds.ToString("00")
    End Sub
    Private Sub Timer18_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer18.Tick
        Dim diff18 As TimeSpan = DateTime.Now.Subtract(inTime(17))
        Time18.Text = diff18.Hours.ToString("00") & ":" & diff18.Minutes.ToString("00") & ":" & diff18.Seconds.ToString("00")
    End Sub
    Private Sub Timer19_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer19.Tick
        Dim diff19 As TimeSpan = DateTime.Now.Subtract(inTime(18))
        Time19.Text = diff19.Hours.ToString("00") & ":" & diff19.Minutes.ToString("00") & ":" & diff19.Seconds.ToString("00")
    End Sub
    Private Sub Timer20_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer20.Tick
        Dim diff20 As TimeSpan = DateTime.Now.Subtract(inTime(19))
        Time20.Text = diff20.Hours.ToString("00") & ":" & diff20.Minutes.ToString("00") & ":" & diff20.Seconds.ToString("00")
    End Sub

    Private Sub PCbtn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCbtn1.Click
        current = 1
        If PCbtn1.Text = "Assign" Then
            AssignWindow.ShowDialog()
        ElseIf PCbtn1.Text = "Manage" Then
            StatusWindow.ShowDialog()
        End If
    End Sub
    Private Sub PCbtn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCbtn2.Click
        current = 2
        If PCbtn2.Text = "Assign" Then
            AssignWindow.ShowDialog()
        ElseIf PCbtn2.Text = "Manage" Then
            StatusWindow.ShowDialog()
        End If
    End Sub
    Private Sub PCbtn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCbtn3.Click
        current = 3
        If PCbtn3.Text = "Assign" Then
            AssignWindow.ShowDialog()
        ElseIf PCbtn3.Text = "Manage" Then
            StatusWindow.ShowDialog()
        End If
    End Sub
    Private Sub PCbtn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCbtn4.Click
        current = 4
        If PCbtn4.Text = "Assign" Then
            AssignWindow.ShowDialog()
        ElseIf PCbtn4.Text = "Manage" Then
            StatusWindow.ShowDialog()
        End If
    End Sub
    Private Sub PCbtn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCbtn5.Click
        current = 5
        If PCbtn5.Text = "Assign" Then
            AssignWindow.ShowDialog()
        ElseIf PCbtn5.Text = "Manage" Then
            StatusWindow.ShowDialog()
        End If
    End Sub
    Private Sub PCbtn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCbtn6.Click
        current = 6
        If PCbtn6.Text = "Assign" Then
            AssignWindow.ShowDialog()
        ElseIf PCbtn6.Text = "Manage" Then
            StatusWindow.ShowDialog()
        End If
    End Sub
    Private Sub PCbtn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCbtn7.Click
        current = 7
        If PCbtn7.Text = "Assign" Then
            AssignWindow.ShowDialog()
        ElseIf PCbtn7.Text = "Manage" Then
            StatusWindow.ShowDialog()
        End If
    End Sub
    Private Sub PCbtn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCbtn8.Click
        current = 8
        If PCbtn8.Text = "Assign" Then
            AssignWindow.ShowDialog()
        ElseIf PCbtn8.Text = "Manage" Then
            StatusWindow.ShowDialog()
        End If
    End Sub
    Private Sub PCbtn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCbtn9.Click
        current = 9
        If PCbtn9.Text = "Assign" Then
            AssignWindow.ShowDialog()
        ElseIf PCbtn9.Text = "Manage" Then
            StatusWindow.ShowDialog()
        End If
    End Sub
    Private Sub PCbtn10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCbtn10.Click
        current = 10
        If PCbtn10.Text = "Assign" Then
            AssignWindow.ShowDialog()
        ElseIf PCbtn10.Text = "Manage" Then
            StatusWindow.ShowDialog()
        End If
    End Sub
    Private Sub PCbtn11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCbtn11.Click
        current = 11
        If PCbtn11.Text = "Assign" Then
            AssignWindow.ShowDialog()
        ElseIf PCbtn11.Text = "Manage" Then
            StatusWindow.ShowDialog()
        End If
    End Sub
    Private Sub PCbtn12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCbtn12.Click
        current = 12
        If PCbtn12.Text = "Assign" Then
            AssignWindow.ShowDialog()
        ElseIf PCbtn12.Text = "Manage" Then
            StatusWindow.ShowDialog()
        End If
    End Sub
    Private Sub PCbtn13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCbtn13.Click
        current = 13
        If PCbtn13.Text = "Assign" Then
            AssignWindow.ShowDialog()
        ElseIf PCbtn13.Text = "Manage" Then
            StatusWindow.ShowDialog()
        End If
    End Sub
    Private Sub PCbtn14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCbtn14.Click
        current = 14
        If PCbtn14.Text = "Assign" Then
            AssignWindow.ShowDialog()
        ElseIf PCbtn14.Text = "Manage" Then
            StatusWindow.ShowDialog()
        End If
    End Sub
    Private Sub PCbtn15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCbtn15.Click
        current = 15
        If PCbtn15.Text = "Assign" Then
            AssignWindow.ShowDialog()
        ElseIf PCbtn15.Text = "Manage" Then
            StatusWindow.ShowDialog()
        End If
    End Sub
    Private Sub PCbtn16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCbtn16.Click
        current = 16
        If PCbtn16.Text = "Assign" Then
            AssignWindow.ShowDialog()
        ElseIf PCbtn16.Text = "Manage" Then
            StatusWindow.ShowDialog()
        End If
    End Sub
    Private Sub PCbtn17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCbtn17.Click
        current = 17
        If PCbtn17.Text = "Assign" Then
            AssignWindow.ShowDialog()
        ElseIf PCbtn17.Text = "Manage" Then
            StatusWindow.ShowDialog()
        End If
    End Sub
    Private Sub PCbtn18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCbtn18.Click
        current = 18
        If PCbtn18.Text = "Assign" Then
            AssignWindow.ShowDialog()
        ElseIf PCbtn18.Text = "Manage" Then
            StatusWindow.ShowDialog()
        End If
    End Sub
    Private Sub PCbtn19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCbtn19.Click
        current = 19
        If PCbtn19.Text = "Assign" Then
            AssignWindow.ShowDialog()
        ElseIf PCbtn19.Text = "Manage" Then
            StatusWindow.ShowDialog()
        End If
    End Sub
    Private Sub PCbtn20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCbtn20.Click
        current = 20
        If PCbtn20.Text = "Assign" Then
            AssignWindow.ShowDialog()
        ElseIf PCbtn20.Text = "Manage" Then
            StatusWindow.ShowDialog()
        End If
    End Sub

End Class
