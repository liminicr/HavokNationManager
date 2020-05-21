Public Class StatusWindow
    Public PriceRate As Double, Waterprice As Integer, Cokeprice As Integer, Fantaprice As Integer, Mtdewprice As Integer, Bullprice As Integer

    Public TimePrice As Integer, BeveragePrice As Integer, TotalPrice As Integer

    Public QtyWater(19) As Integer, QtyCoke(19) As Integer, QtyFanta(19) As Integer, QtyMtDew(19) As Integer, QtyRedbull(19) As Integer

    Public diff As TimeSpan

    Public current As Integer


    Private Sub StatusWindow_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        current = Dashboard.current
        Payment.Show()
        Discard.Show()
        Cancel.Text = "Cancel"
        time_out.Text = "-"
        Bill.Text = String.Empty
        Timer1.Enabled = True

        PC.Text = My.Settings.PCnames(current - 1)
        time_in.Text = Dashboard.inTime(current - 1).ToString("HH:mm:ss")
        Name_Status.Text = Dashboard.namelist(current - 1)

        PriceRate = My.Settings.rate_time
        Waterprice = My.Settings.rate_Water
        Cokeprice = My.Settings.rate_Coke
        Fantaprice = My.Settings.rate_Fanta
        Mtdewprice = My.Settings.rate_Mtdew
        Bullprice = My.Settings.rate_Redbull

        Dim i As Integer = 0
        For i = 0 To 19
            QtyWater(i) = CInt(My.Settings.Waters(i))
            QtyCoke(i) = CInt(My.Settings.Cokes(i))
            QtyFanta(i) = CInt(My.Settings.Fantas(i))
            QtyMtDew(i) = CInt(My.Settings.Mtdews(i))
            QtyRedbull(i) = CInt(My.Settings.Redbulls(i))
        Next

        Qty_Water.Value = QtyWater(current - 1)
        Qty_Coke.Value = QtyCoke(current - 1)
        Qty_Fanta.Value = QtyFanta(current - 1)
        Qty_MtDew.Value = QtyMtDew(current - 1)
        Qty_Redbull.Value = QtyRedbull(current - 1)

        Qty_Water.Enabled = True
        Qty_Coke.Enabled = True
        Qty_Fanta.Enabled = True
        Qty_MtDew.Enabled = True
        Qty_Redbull.Enabled = True

    End Sub

    Private Sub Calculation()
        'Calculating the cost of time usage of the customer by hours
        TimePrice = CInt(diff.TotalHours * PriceRate)

        'Adds total price of customer's order
        BeveragePrice = Waterprice * Qty_Water.Value +
                        Cokeprice * Qty_Coke.Value +
                        Fantaprice * Qty_Fanta.Value +
                        Mtdewprice * Qty_MtDew.Value +
                        Bullprice * Qty_Redbull.Value

        'Total price calculated
        TotalPrice = BeveragePrice + TimePrice

        Try
            'Inserts a new financial record
            Financial_DBTableAdapter.Insert(Dashboard.id(current - 1), DateTime.Now, QtyWater(current - 1), QtyCoke(current - 1),
                                            QtyFanta(current - 1), QtyMtDew(current - 1), QtyRedbull(current - 1), TimePrice,
                                            BeveragePrice, TotalPrice)
        Catch ex As Exception
            MsgBox("Error! Failed in saving the record. Data was not saved")
        End Try

    End Sub

    Private Sub Billing()

        'Showing the time the customer stops using the PC
        time_out.Text = DateTime.Now.ToString("HH:mm:ss")

        'Bill starts
        Bill.AppendText("" + vbNewLine)
        Bill.AppendText("Thank you for Visiting Havok Experience" + vbNewLine)
        Bill.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = =" + vbNewLine)
        Bill.AppendText("" + vbNewLine)
        Bill.AppendText("Product" + vbTab + "Unit" + vbTab + "Qty" + vbTab + "Total Price" + vbNewLine + " " + vbNewLine)
        Bill.AppendText("Playtime" + vbTab + vbTab + vbTab + CStr(TimePrice) + vbNewLine)

        'Conditionally prints according to customer's purchases
        If Qty_Water.Value > 0 Then
            Bill.AppendText("Water" + vbTab + CStr(Waterprice) + vbTab + CStr(Qty_Water.Value) + vbTab + CStr(Waterprice * Qty_Water.Value) + vbNewLine)
        End If
        If Qty_Coke.Value > 0 Then
            Bill.AppendText("Coke" + vbTab + CStr(Cokeprice) + vbTab + CStr(Qty_Coke.Value) + vbTab + CStr(Cokeprice * Qty_Coke.Value) + vbNewLine)
        End If
        If Qty_Fanta.Value > 0 Then
            Bill.AppendText("Fanta" + vbTab + CStr(Fantaprice) + vbTab + CStr(Qty_Fanta.Value) + vbTab + CStr(Fantaprice * Qty_Fanta.Value) + vbNewLine)
        End If
        If Qty_MtDew.Value > 0 Then
            Bill.AppendText("MtDew" + vbTab + CStr(Mtdewprice) + vbTab + CStr(Qty_MtDew.Value) + vbTab + CStr(Mtdewprice * Qty_MtDew.Value) + vbNewLine)
        End If
        If Qty_Redbull.Value > 0 Then
            Bill.AppendText("Redbull" + vbTab + CStr(Bullprice) + vbTab + CStr(Qty_Redbull.Value) + vbTab + CStr(Bullprice * Qty_Redbull.Value) + vbNewLine)
        End If

        'Bill ends
        Bill.AppendText(" " + vbNewLine + " " + vbNewLine)
        Bill.AppendText("Total" + vbTab + vbTab + vbTab + CStr(TotalPrice) + " Rupees" + vbNewLine + vbNewLine)
        Bill.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = =" + vbNewLine + vbNewLine)
        Bill.AppendText("Transaction Date " + Now.ToString)

    End Sub

    Private Sub Reset()

        'Hiding, showing of buttons and disabling of timer in the form
        Payment.Hide()
        Discard.Hide()
        Cancel.Text = "ok"
        Timer1.Enabled = False
        Dashboard.CustomerNumber -= 1
        Dashboard.CustNum.Text = Dashboard.CustomerNumber
        Dashboard.id(current - 1) = -1
        My.Settings.intimes(current - 1) = "-"
        My.Settings.ids(current - 1) = "-"
        My.Settings.names(current - 1) = "-"
        My.Settings.Waters(current - 1) = 0
        My.Settings.Cokes(current - 1) = 0
        My.Settings.Fantas(current - 1) = 0
        My.Settings.Mtdews(current - 1) = 0
        My.Settings.Redbulls(current - 1) = 0
        My.Settings.Save()

        'Clears the array of the customer at the PC
        QtyWater(current - 1) = 0
        QtyCoke(current - 1) = 0
        QtyFanta(current - 1) = 0
        QtyMtDew(current - 1) = 0
        QtyRedbull(current - 1) = 0

        'Prevents further changing
        Qty_Water.Enabled = False
        Qty_Coke.Enabled = False
        Qty_Fanta.Enabled = False
        Qty_MtDew.Enabled = False
        Qty_Redbull.Enabled = False

        'Reset of the texts and timers in Dashboard
        If current = 1 Then
            Dashboard.Timer1.Enabled = False
            Dashboard.PCbtn1.Text = "Assign"
            Dashboard.Name1.Text = "-"
            Dashboard.Time1.Text = "-"
        ElseIf current = 2 Then
            Dashboard.Timer2.Enabled = False
            Dashboard.PCbtn2.Text = "Assign"
            Dashboard.Name2.Text = "-"
            Dashboard.Time2.Text = "-"
        ElseIf current = 3 Then
            Dashboard.Timer3.Enabled = False
            Dashboard.PCbtn3.Text = "Assign"
            Dashboard.Name3.Text = "-"
            Dashboard.Time3.Text = "-"
        ElseIf current = 4 Then
            Dashboard.Timer4.Enabled = False
            Dashboard.PCbtn4.Text = "Assign"
            Dashboard.Name4.Text = "-"
            Dashboard.Time4.Text = "-"
        ElseIf current = 5 Then
            Dashboard.Timer5.Enabled = False
            Dashboard.PCbtn5.Text = "Assign"
            Dashboard.Name5.Text = "-"
            Dashboard.Time5.Text = "-"
        ElseIf current = 6 Then
            Dashboard.Timer6.Enabled = False
            Dashboard.PCbtn6.Text = "Assign"
            Dashboard.Name6.Text = "-"
            Dashboard.Time6.Text = "-"
        ElseIf current = 7 Then
            Dashboard.Timer7.Enabled = False
            Dashboard.PCbtn7.Text = "Assign"
            Dashboard.Name7.Text = "-"
            Dashboard.Time7.Text = "-"
        ElseIf current = 8 Then
            Dashboard.Timer8.Enabled = False
            Dashboard.PCbtn8.Text = "Assign"
            Dashboard.Name8.Text = "-"
            Dashboard.Time8.Text = "-"
        ElseIf current = 9 Then
            Dashboard.Timer9.Enabled = False
            Dashboard.PCbtn9.Text = "Assign"
            Dashboard.Name9.Text = "-"
            Dashboard.Time9.Text = "-"
        ElseIf current = 10 Then
            Dashboard.Timer10.Enabled = False
            Dashboard.PCbtn10.Text = "Assign"
            Dashboard.Name10.Text = "-"
            Dashboard.Time10.Text = "-"
        ElseIf current = 11 Then
            Dashboard.Timer11.Enabled = False
            Dashboard.PCbtn11.Text = "Assign"
            Dashboard.Name11.Text = "-"
            Dashboard.Time11.Text = "-"
        ElseIf current = 12 Then
            Dashboard.Timer12.Enabled = False
            Dashboard.PCbtn12.Text = "Assign"
            Dashboard.Name12.Text = "-"
            Dashboard.Time12.Text = "-"
        ElseIf current = 13 Then
            Dashboard.Timer13.Enabled = False
            Dashboard.PCbtn13.Text = "Assign"
            Dashboard.Name13.Text = "-"
            Dashboard.Time13.Text = "-"
        ElseIf current = 14 Then
            Dashboard.Timer14.Enabled = False
            Dashboard.PCbtn14.Text = "Assign"
            Dashboard.Name14.Text = "-"
            Dashboard.Time14.Text = "-"
        ElseIf current = 15 Then
            Dashboard.Timer15.Enabled = False
            Dashboard.PCbtn15.Text = "Assign"
            Dashboard.Name15.Text = "-"
            Dashboard.Time15.Text = "-"
        ElseIf current = 16 Then
            Dashboard.Timer16.Enabled = False
            Dashboard.PCbtn16.Text = "Assign"
            Dashboard.Name16.Text = "-"
            Dashboard.Time16.Text = "-"
        ElseIf current = 17 Then
            Dashboard.Timer17.Enabled = False
            Dashboard.PCbtn17.Text = "Assign"
            Dashboard.Name17.Text = "-"
            Dashboard.Time17.Text = "-"
        ElseIf current = 18 Then
            Dashboard.Timer18.Enabled = False
            Dashboard.PCbtn18.Text = "Assign"
            Dashboard.Name18.Text = "-"
            Dashboard.Time18.Text = "-"
        ElseIf current = 19 Then
            Dashboard.Timer19.Enabled = False
            Dashboard.PCbtn19.Text = "Assign"
            Dashboard.Name19.Text = "-"
            Dashboard.Time19.Text = "-"
        ElseIf current = 20 Then
            Dashboard.Timer20.Enabled = False
            Dashboard.PCbtn20.Text = "Assign"
            Dashboard.Name20.Text = "-"
            Dashboard.Time20.Text = "-"
        End If
    End Sub

    Private Sub Payment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Payment.Click
        Dim yesno As String
        yesno = MsgBox("Generate Bill?", vbYesNo)

        If yesno = vbYes Then

            'Calls method for calculation
            Calculation()

            'Calls method to prind bill
            Billing()

            'Calls method to reset the values
            Reset()
            MsgBox("Bill generated")
        End If
    End Sub

    Private Sub Discard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Discard.Click
        Dim yesno As String
        yesno = MsgBox("Do you really want to discard?" + vbLf + "(Caution, Transaction will be canceled)", vbYesNo + vbDefaultButton2, "Warning")

        If yesno = vbYes Then

            'Calls Method Reset()
            Reset()

            'Empties values
            time_in.Text = "-"
            Name_Status.Text = "-"
            Time_Status.Text = "-"
            Qty_Water.Value = 0
            Qty_Coke.Value = 0
            Qty_Fanta.Value = 0
            Qty_MtDew.Value = 0
            Qty_Redbull.Value = 0

            'Informs transaction was discarded
            MsgBox("Transaction discarded")
        End If
    End Sub

    Private Sub Qty_Water_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Qty_Water.ValueChanged
        QtyWater(current - 1) = Qty_Water.Value
        My.Settings.Waters(current - 1) = Qty_Water.Value.ToString
        My.Settings.Save()
    End Sub
    Private Sub Qty_Coke_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Qty_Coke.ValueChanged
        QtyCoke(current - 1) = Qty_Coke.Value
        My.Settings.Cokes(current - 1) = Qty_Coke.Value.ToString
        My.Settings.Save()
    End Sub
    Private Sub Qty_Fanta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Qty_Fanta.ValueChanged
        QtyFanta(current - 1) = Qty_Fanta.Value
        My.Settings.Fantas(current - 1) = Qty_Fanta.Value.ToString
        My.Settings.Save()
    End Sub
    Private Sub Qty_MtDew_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Qty_MtDew.ValueChanged
        QtyMtDew(current - 1) = Qty_MtDew.Value
        My.Settings.Mtdews(current - 1) = Qty_MtDew.Value.ToString
        My.Settings.Save()
    End Sub
    Private Sub Qty_Redbull_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Qty_Redbull.ValueChanged
        QtyRedbull(current - 1) = Qty_Redbull.Value
        My.Settings.Redbulls(current - 1) = Qty_Redbull.Value.ToString
        My.Settings.Save()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        diff = DateTime.Now.Subtract(Dashboard.inTime(current - 1))
        Time_Status.Text = diff.Hours.ToString("00") & ":" & diff.Minutes.ToString("00") & ":" & diff.Seconds.ToString("00")
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class

