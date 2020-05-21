Imports Microsoft.Reporting.WinForms

Public Class Financial

    Private Sub Financial_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        NumericUpDown1.Value = CInt(Now.Year)
        NumericUpDown1.Maximum = CInt(Now.Year)
        NumericUpDown2.Value = CInt(Now.Year)
        NumericUpDown2.Maximum = CInt(Now.Year)
        Calendar_Day.MaxDate = DateTime.Now
        Calendar_Month.MaxDate = DateTime.Now
    End Sub

    Private Sub Financial_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown


        filterDay(Calendar_Day.SelectionStart.Day.ToString + "-" +
                  Calendar_Day.SelectionStart.Month.ToString + "-" + Calendar_Day.SelectionStart.Year.ToString)

        filterMonth(Calendar_Month.SelectionStart.Month.ToString + "-" + Calendar_Month.SelectionStart.Year.ToString)

        filterYear(NumericUpDown1.Value)

        fillPopDrinks(NumericUpDown2.Value)

    End Sub

    Private Sub Day_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendar_Day.DateSelected,
                                                                                                                 Calendar_Day.DateChanged
        filterDay(Calendar_Day.SelectionStart.Day.ToString + "-" +
                  Calendar_Day.SelectionStart.Month.ToString + "-" + Calendar_Day.SelectionStart.Year.ToString)

    End Sub
    Private Sub filterDay(ByVal selectedDate As String)
        Try
            Financial_DBTableAdapter.FillByDay(Me.Customer_DBDataSet.Financial_DB, selectedDate)
            ReportViewer_Day.RefreshReport()
        Catch ex As Exception
            MsgBox("Error, database was not found")
            Stop
        End Try
    End Sub

    Private Sub Month_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendar_Month.DateSelected,
                                                                                                                   Calendar_Month.DateChanged
        filterMonth(Calendar_Month.SelectionStart.Month.ToString + "-" + Calendar_Month.SelectionStart.Year.ToString)
    End Sub
    Private Sub filterMonth(ByVal selectedMonth As String)
        Try
            DailyQueryTableAdapter.FillByMonth(Me.Customer_DBDataSet.DailyQuery, selectedMonth)


            Dim Para As New ReportParameter("MonthParam", Calendar_Month.SelectionStart.Year.ToString + " " +
                                            MonthName(Calendar_Month.SelectionStart.Month, False).ToString)

            ReportViewer_Month.LocalReport.SetParameters(Para)

            ReportViewer_Month.RefreshReport()
        Catch ex As Exception
            MsgBox("Error, database was not found")
            Stop
        End Try
    End Sub

    Private Sub Numeric_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        filterYear(NumericUpDown1.Value)
    End Sub
    Private Sub filterYear(ByVal selectedYear As String)
        Try
            MonthlyQueryTableAdapter.FillByYear(Me.Customer_DBDataSet.MonthlyQuery, selectedYear)
            Dim Para As New ReportParameter("YearParam", NumericUpDown1.Value)
            ReportViewer_Year.LocalReport.SetParameters(Para)
            ReportViewer_Year.RefreshReport()
        Catch ex As Exception
            MsgBox("Error, database was not found")
            Stop
        End Try
    End Sub

    Private Sub Numeric2_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown2.ValueChanged
        fillPopDrinks(NumericUpDown2.Value)
    End Sub
    Private Sub fillPopDrinks(ByVal selectedDrinks As String)
        Try
            PopDrinksTableAdapter.FillByDrinks(Me.Customer_DBDataSet.PopDrinks, selectedDrinks)
            Dim Para As New ReportParameter("DrinksParam", NumericUpDown2.Value)
            BeverageReportViewer.LocalReport.SetParameters(Para)
            BeverageReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox("Error, database was not found")
            Stop
        End Try

    End Sub


    Private Sub ShowAllday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowAllday.Click
        Financial_DBTableAdapter.Fill(Me.Customer_DBDataSet.Financial_DB)
        ReportViewer_Day.RefreshReport()
    End Sub
    Private Sub ShowAllMonth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowAllMonth.Click
        DailyQueryTableAdapter.Fill(Me.Customer_DBDataSet.DailyQuery)
        ReportViewer_Month.RefreshReport()
    End Sub
    Private Sub ShowAllYear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowAllyear.Click
        MonthlyQueryTableAdapter.Fill(Me.Customer_DBDataSet.MonthlyQuery)
        ReportViewer_Year.RefreshReport()
    End Sub


    Private Sub refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        ReportViewer_Month.RefreshReport()
        ReportViewer_Day.RefreshReport()
        ReportViewer_Year.RefreshReport()
        BeverageReportViewer.RefreshReport()
    End Sub

    Private Sub BtnMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMain.Click
        Dashboard.Focus()
        If Dashboard.WindowState = FormWindowState.Minimized Then
            Dashboard.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub


End Class