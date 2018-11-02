Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        lstIntervalAdd.Items.Add("Day")
        lstIntervalAdd.Items.Add("Month")
        lstIntervalAdd.Items.Add("Year")
        lstOp.Items.Add("Add")
        lstOp.Items.Add("Subtract")
    End Sub

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
End Class
