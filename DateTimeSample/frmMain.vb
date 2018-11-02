Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        lstIntervalAdd.Items.Add("Day")
        lstIntervalAdd.Items.Add("Month")
        lstIntervalAdd.Items.Add("Year")
        lstOp.Items.Add("Add")
        lstOp.Items.Add("Subtract")

        lstIntervalSpan.Items.Add("Days")
        lstIntervalSpan.Items.Add("Hours")
        lstIntervalSpan.Items.Add("Minutes")
        lstIntervalSpan.Items.Add("Seconds")
        dtmStartSpan.Format = DateTimePickerFormat.Custom
        dtmStartSpan.CustomFormat = "hh:mm:ss tt"
        dtmEndSpan.Format = DateTimePickerFormat.Custom
        dtmEndSpan.CustomFormat = "hh:mm:ss tt"
    End Sub

    Private Function ElapsedTime(ByVal dtmEarly As Date, ByVal dtmLate As Date, strInterval As String) As Integer
        Dim tspDifference As TimeSpan = dtmLate.Subtract(dtmEarly)
        Select Case strInterval
            Case "Days"
                Return tspDifference.TotalDays
            Case "Hours"
                Return tspDifference.TotalHours
            Case "Minutes"
                Return tspDifference.TotalMinutes
            Case "Seconds"
                Return tspDifference.TotalSeconds
            Case Else
                'default to days
                Return tspDifference.TotalDays
        End Select
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim dtiIntervalType As DateInterval
        Dim blnErrors As Boolean
        Dim dblAmount As Double
        'validate input
        If Not ValidateListBox(lstIntervalAdd, errP) Then
            blnErrors = True
        End If
        If Not ValidateListBox(lstOp, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxNumeric(txtQty, errP) Then
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If
        dblAmount = CDbl(txtQty.Text)
        If lstOp.SelectedItem = "Subtract" Then
            dblAmount *= -1
        End If
        Select Case lstIntervalAdd.SelectedItem.ToString
            Case "Day"
                dtiIntervalType = DateInterval.Day
            Case "Month"
                dtiIntervalType = DateInterval.Month
            Case "Year"
                dtiIntervalType = DateInterval.Year
            Case Else
                MessageBox.Show("Unexpected date interval in btnAdd_Click", "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
        dtmEndAdd.Value = DateAdd(dtiIntervalType, dblAmount, dtmStartAdd.Value)
        lblResult.Text = CStr(dtmEndAdd.Value)
        lblAlt.Text = Format(dtmEndAdd.Value, "MM-dd-yyyy")
    End Sub

    Private Sub btnSpan_Click(sender As Object, e As EventArgs) Handles btnSpan.Click
        Dim blnErrors As Boolean
        If Not ValidateListBox(lstIntervalSpan, errP) Then
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If
        lblElapsedUnits.Text = CStr(ElapsedTime(dtmStartSpan.Value, dtmEndSpan.Value, lstIntervalSpan.SelectedItem.ToString))
    End Sub

    Private Sub btnUpdateSpan_Click(sender As Object, e As EventArgs) Handles btnUpdateSpan.Click
        Dim dtmTempDate As Date
        Dim timIn As Date
        Dim datIn As Date
        'next line extracts only the time portion of the picker, with no date
        timIn = FormatDateTime(dtmEndSpan.Value, DateFormat.LongTime)
        'next line extracts only the date portion on the picker, with no time
        datIn = FormatDateTime(dtmEndSpan.Value, DateFormat.ShortDate)
        'to build a date value from existing date and time values to put back into the datetime picker,
        'use DatePart function and reassemble in this order with integer values: year, month, day, hour, minutes, seconds
        'DatePart function returns an integer value
        dtmTempDate = New Date(DatePart(DateInterval.Year, datIn), DatePart(DateInterval.Month, datIn), DatePart(DateInterval.Day, datIn),
                               DatePart(DateInterval.Hour, timIn), DatePart(DateInterval.Minute, timIn), DatePart(DateInterval.Second, timIn))
        dtmStartSpan.Value = dtmTempDate
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnClearAdd_Click(sender As Object, e As EventArgs) Handles btnClearAdd.Click
        ClearScreenControls(Me)
        lblResult.Text = ""
        lblAlt.Text = ""
    End Sub

    Private Sub btnClearSpan_Click(sender As Object, e As EventArgs) Handles btnClearSpan.Click
        ClearScreenControls(Me)
        lblElapsedUnits.Text = ""
        'set start and end span to current time when form is cleared
        dtmStartSpan.Value = FormatDateTime(Date.Now)
        dtmEndSpan.Value = FormatDateTime(Date.Now)
    End Sub
End Class
