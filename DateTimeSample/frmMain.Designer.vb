<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpAddSubtract = New System.Windows.Forms.GroupBox()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.lblInterval = New System.Windows.Forms.Label()
        Me.lblAddSubtract = New System.Windows.Forms.Label()
        Me.lblHowMuch = New System.Windows.Forms.Label()
        Me.lblAddSubResult = New System.Windows.Forms.Label()
        Me.lblDTMResult = New System.Windows.Forms.Label()
        Me.lblAltFormat = New System.Windows.Forms.Label()
        Me.dtmStartAdd = New System.Windows.Forms.DateTimePicker()
        Me.lstIntervalAdd = New System.Windows.Forms.ListBox()
        Me.lstOp = New System.Windows.Forms.ListBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.dtmEndAdd = New System.Windows.Forms.DateTimePicker()
        Me.lblAlt = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClearAdd = New System.Windows.Forms.Button()
        Me.grpAddSubtract.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAddSubtract
        '
        Me.grpAddSubtract.Controls.Add(Me.btnClearAdd)
        Me.grpAddSubtract.Controls.Add(Me.btnAdd)
        Me.grpAddSubtract.Controls.Add(Me.lblAlt)
        Me.grpAddSubtract.Controls.Add(Me.dtmEndAdd)
        Me.grpAddSubtract.Controls.Add(Me.lblResult)
        Me.grpAddSubtract.Controls.Add(Me.txtQty)
        Me.grpAddSubtract.Controls.Add(Me.lstOp)
        Me.grpAddSubtract.Controls.Add(Me.lstIntervalAdd)
        Me.grpAddSubtract.Controls.Add(Me.dtmStartAdd)
        Me.grpAddSubtract.Controls.Add(Me.lblAltFormat)
        Me.grpAddSubtract.Controls.Add(Me.lblDTMResult)
        Me.grpAddSubtract.Controls.Add(Me.lblAddSubResult)
        Me.grpAddSubtract.Controls.Add(Me.lblHowMuch)
        Me.grpAddSubtract.Controls.Add(Me.lblAddSubtract)
        Me.grpAddSubtract.Controls.Add(Me.lblInterval)
        Me.grpAddSubtract.Controls.Add(Me.lblStartDate)
        Me.grpAddSubtract.Location = New System.Drawing.Point(44, 41)
        Me.grpAddSubtract.Name = "grpAddSubtract"
        Me.grpAddSubtract.Size = New System.Drawing.Size(582, 417)
        Me.grpAddSubtract.TabIndex = 0
        Me.grpAddSubtract.TabStop = False
        Me.grpAddSubtract.Text = "Adding and Subtracting Date"
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Location = New System.Drawing.Point(19, 39)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(65, 17)
        Me.lblStartDate.TabIndex = 0
        Me.lblStartDate.Text = "Start date"
        '
        'lblInterval
        '
        Me.lblInterval.AutoSize = True
        Me.lblInterval.Location = New System.Drawing.Point(19, 77)
        Me.lblInterval.Name = "lblInterval"
        Me.lblInterval.Size = New System.Drawing.Size(90, 17)
        Me.lblInterval.TabIndex = 1
        Me.lblInterval.Text = "What Interval?"
        '
        'lblAddSubtract
        '
        Me.lblAddSubtract.AutoSize = True
        Me.lblAddSubtract.Location = New System.Drawing.Point(18, 153)
        Me.lblAddSubtract.Name = "lblAddSubtract"
        Me.lblAddSubtract.Size = New System.Drawing.Size(106, 17)
        Me.lblAddSubtract.TabIndex = 2
        Me.lblAddSubtract.Text = "Add or subtract?"
        '
        'lblHowMuch
        '
        Me.lblHowMuch.AutoSize = True
        Me.lblHowMuch.Location = New System.Drawing.Point(18, 215)
        Me.lblHowMuch.Name = "lblHowMuch"
        Me.lblHowMuch.Size = New System.Drawing.Size(75, 17)
        Me.lblHowMuch.TabIndex = 3
        Me.lblHowMuch.Text = "How much?"
        '
        'lblAddSubResult
        '
        Me.lblAddSubResult.AutoSize = True
        Me.lblAddSubResult.Location = New System.Drawing.Point(19, 259)
        Me.lblAddSubResult.Name = "lblAddSubResult"
        Me.lblAddSubResult.Size = New System.Drawing.Size(78, 17)
        Me.lblAddSubResult.TabIndex = 4
        Me.lblAddSubResult.Text = "String result"
        '
        'lblDTMResult
        '
        Me.lblDTMResult.AutoSize = True
        Me.lblDTMResult.Location = New System.Drawing.Point(19, 310)
        Me.lblDTMResult.Name = "lblDTMResult"
        Me.lblDTMResult.Size = New System.Drawing.Size(71, 17)
        Me.lblDTMResult.TabIndex = 5
        Me.lblDTMResult.Text = "DTM result"
        '
        'lblAltFormat
        '
        Me.lblAltFormat.AutoSize = True
        Me.lblAltFormat.Location = New System.Drawing.Point(18, 351)
        Me.lblAltFormat.Name = "lblAltFormat"
        Me.lblAltFormat.Size = New System.Drawing.Size(105, 17)
        Me.lblAltFormat.TabIndex = 6
        Me.lblAltFormat.Text = "Alternate Format"
        '
        'dtmStartAdd
        '
        Me.dtmStartAdd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmStartAdd.Location = New System.Drawing.Point(205, 31)
        Me.dtmStartAdd.Name = "dtmStartAdd"
        Me.dtmStartAdd.Size = New System.Drawing.Size(184, 25)
        Me.dtmStartAdd.TabIndex = 7
        '
        'lstIntervalAdd
        '
        Me.lstIntervalAdd.FormattingEnabled = True
        Me.lstIntervalAdd.ItemHeight = 17
        Me.lstIntervalAdd.Location = New System.Drawing.Point(205, 77)
        Me.lstIntervalAdd.Name = "lstIntervalAdd"
        Me.lstIntervalAdd.Size = New System.Drawing.Size(184, 55)
        Me.lstIntervalAdd.TabIndex = 8
        '
        'lstOp
        '
        Me.lstOp.FormattingEnabled = True
        Me.lstOp.ItemHeight = 17
        Me.lstOp.Location = New System.Drawing.Point(205, 153)
        Me.lstOp.Name = "lstOp"
        Me.lstOp.Size = New System.Drawing.Size(184, 38)
        Me.lstOp.TabIndex = 9
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(205, 212)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(184, 25)
        Me.txtQty.TabIndex = 10
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.White
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(205, 258)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(184, 25)
        Me.lblResult.TabIndex = 11
        '
        'dtmEndAdd
        '
        Me.dtmEndAdd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmEndAdd.Location = New System.Drawing.Point(205, 304)
        Me.dtmEndAdd.Name = "dtmEndAdd"
        Me.dtmEndAdd.Size = New System.Drawing.Size(184, 25)
        Me.dtmEndAdd.TabIndex = 12
        '
        'lblAlt
        '
        Me.lblAlt.BackColor = System.Drawing.Color.White
        Me.lblAlt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAlt.Location = New System.Drawing.Point(205, 350)
        Me.lblAlt.Name = "lblAlt"
        Me.lblAlt.Size = New System.Drawing.Size(184, 25)
        Me.lblAlt.TabIndex = 13
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(426, 304)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(126, 25)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Process"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClearAdd
        '
        Me.btnClearAdd.Location = New System.Drawing.Point(426, 350)
        Me.btnClearAdd.Name = "btnClearAdd"
        Me.btnClearAdd.Size = New System.Drawing.Size(126, 25)
        Me.btnClearAdd.TabIndex = 15
        Me.btnClearAdd.Text = "Clear"
        Me.btnClearAdd.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 555)
        Me.Controls.Add(Me.grpAddSubtract)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.Text = "Date and Time Handling Samples"
        Me.grpAddSubtract.ResumeLayout(False)
        Me.grpAddSubtract.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpAddSubtract As GroupBox
    Friend WithEvents lblResult As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents lstOp As ListBox
    Friend WithEvents lstIntervalAdd As ListBox
    Friend WithEvents dtmStartAdd As DateTimePicker
    Friend WithEvents lblAltFormat As Label
    Friend WithEvents lblDTMResult As Label
    Friend WithEvents lblAddSubResult As Label
    Friend WithEvents lblHowMuch As Label
    Friend WithEvents lblAddSubtract As Label
    Friend WithEvents lblInterval As Label
    Friend WithEvents lblStartDate As Label
    Friend WithEvents btnClearAdd As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblAlt As Label
    Friend WithEvents dtmEndAdd As DateTimePicker
End Class
