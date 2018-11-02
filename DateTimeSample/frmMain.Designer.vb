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
        Me.components = New System.ComponentModel.Container()
        Me.grpAddSubtract = New System.Windows.Forms.GroupBox()
        Me.btnClearAdd = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblAlt = New System.Windows.Forms.Label()
        Me.dtmEndAdd = New System.Windows.Forms.DateTimePicker()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lstOp = New System.Windows.Forms.ListBox()
        Me.lstIntervalAdd = New System.Windows.Forms.ListBox()
        Me.dtmStartAdd = New System.Windows.Forms.DateTimePicker()
        Me.lblAltFormat = New System.Windows.Forms.Label()
        Me.lblDTMResult = New System.Windows.Forms.Label()
        Me.lblAddSubResult = New System.Windows.Forms.Label()
        Me.lblHowMuch = New System.Windows.Forms.Label()
        Me.lblAddSubtract = New System.Windows.Forms.Label()
        Me.lblInterval = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpSpan = New System.Windows.Forms.GroupBox()
        Me.btnClearSpan = New System.Windows.Forms.Button()
        Me.btnUpdateSpan = New System.Windows.Forms.Button()
        Me.btnSpan = New System.Windows.Forms.Button()
        Me.lblElapsedUnits = New System.Windows.Forms.Label()
        Me.lstIntervalSpan = New System.Windows.Forms.ListBox()
        Me.dtmEndSpan = New System.Windows.Forms.DateTimePicker()
        Me.dtmStartSpan = New System.Windows.Forms.DateTimePicker()
        Me.lblElapsedLabel = New System.Windows.Forms.Label()
        Me.lblResultInterval = New System.Windows.Forms.Label()
        Me.lblEndTime = New System.Windows.Forms.Label()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpAddSubtract.SuspendLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSpan.SuspendLayout()
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
        Me.grpAddSubtract.Location = New System.Drawing.Point(27, 21)
        Me.grpAddSubtract.Name = "grpAddSubtract"
        Me.grpAddSubtract.Size = New System.Drawing.Size(513, 401)
        Me.grpAddSubtract.TabIndex = 0
        Me.grpAddSubtract.TabStop = False
        Me.grpAddSubtract.Text = "Adding and Subtracting Date"
        '
        'btnClearAdd
        '
        Me.btnClearAdd.Location = New System.Drawing.Point(363, 342)
        Me.btnClearAdd.Name = "btnClearAdd"
        Me.btnClearAdd.Size = New System.Drawing.Size(126, 35)
        Me.btnClearAdd.TabIndex = 15
        Me.btnClearAdd.Text = "Clear"
        Me.btnClearAdd.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(363, 296)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(126, 35)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Process"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblAlt
        '
        Me.lblAlt.BackColor = System.Drawing.Color.White
        Me.lblAlt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAlt.Location = New System.Drawing.Point(170, 350)
        Me.lblAlt.Name = "lblAlt"
        Me.lblAlt.Size = New System.Drawing.Size(155, 25)
        Me.lblAlt.TabIndex = 13
        '
        'dtmEndAdd
        '
        Me.dtmEndAdd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmEndAdd.Location = New System.Drawing.Point(170, 304)
        Me.dtmEndAdd.Name = "dtmEndAdd"
        Me.dtmEndAdd.Size = New System.Drawing.Size(155, 25)
        Me.dtmEndAdd.TabIndex = 12
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.White
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(170, 258)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(155, 25)
        Me.lblResult.TabIndex = 11
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(170, 212)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(155, 25)
        Me.txtQty.TabIndex = 10
        '
        'lstOp
        '
        Me.lstOp.FormattingEnabled = True
        Me.lstOp.ItemHeight = 17
        Me.lstOp.Location = New System.Drawing.Point(170, 153)
        Me.lstOp.Name = "lstOp"
        Me.lstOp.Size = New System.Drawing.Size(155, 38)
        Me.lstOp.TabIndex = 9
        '
        'lstIntervalAdd
        '
        Me.lstIntervalAdd.FormattingEnabled = True
        Me.lstIntervalAdd.ItemHeight = 17
        Me.lstIntervalAdd.Location = New System.Drawing.Point(170, 77)
        Me.lstIntervalAdd.Name = "lstIntervalAdd"
        Me.lstIntervalAdd.Size = New System.Drawing.Size(155, 55)
        Me.lstIntervalAdd.TabIndex = 8
        '
        'dtmStartAdd
        '
        Me.dtmStartAdd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmStartAdd.Location = New System.Drawing.Point(170, 31)
        Me.dtmStartAdd.Name = "dtmStartAdd"
        Me.dtmStartAdd.Size = New System.Drawing.Size(155, 25)
        Me.dtmStartAdd.TabIndex = 7
        '
        'lblAltFormat
        '
        Me.lblAltFormat.AutoSize = True
        Me.lblAltFormat.Location = New System.Drawing.Point(19, 354)
        Me.lblAltFormat.Name = "lblAltFormat"
        Me.lblAltFormat.Size = New System.Drawing.Size(105, 17)
        Me.lblAltFormat.TabIndex = 6
        Me.lblAltFormat.Text = "Alternate Format"
        '
        'lblDTMResult
        '
        Me.lblDTMResult.AutoSize = True
        Me.lblDTMResult.Location = New System.Drawing.Point(18, 308)
        Me.lblDTMResult.Name = "lblDTMResult"
        Me.lblDTMResult.Size = New System.Drawing.Size(71, 17)
        Me.lblDTMResult.TabIndex = 5
        Me.lblDTMResult.Text = "DTM result"
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
        'lblHowMuch
        '
        Me.lblHowMuch.AutoSize = True
        Me.lblHowMuch.Location = New System.Drawing.Point(19, 215)
        Me.lblHowMuch.Name = "lblHowMuch"
        Me.lblHowMuch.Size = New System.Drawing.Size(75, 17)
        Me.lblHowMuch.TabIndex = 3
        Me.lblHowMuch.Text = "How much?"
        '
        'lblAddSubtract
        '
        Me.lblAddSubtract.AutoSize = True
        Me.lblAddSubtract.Location = New System.Drawing.Point(18, 163)
        Me.lblAddSubtract.Name = "lblAddSubtract"
        Me.lblAddSubtract.Size = New System.Drawing.Size(106, 17)
        Me.lblAddSubtract.TabIndex = 2
        Me.lblAddSubtract.Text = "Add or subtract?"
        '
        'lblInterval
        '
        Me.lblInterval.AutoSize = True
        Me.lblInterval.Location = New System.Drawing.Point(19, 92)
        Me.lblInterval.Name = "lblInterval"
        Me.lblInterval.Size = New System.Drawing.Size(90, 17)
        Me.lblInterval.TabIndex = 1
        Me.lblInterval.Text = "What Interval?"
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
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'grpSpan
        '
        Me.grpSpan.Controls.Add(Me.btnClearSpan)
        Me.grpSpan.Controls.Add(Me.btnUpdateSpan)
        Me.grpSpan.Controls.Add(Me.btnSpan)
        Me.grpSpan.Controls.Add(Me.lblElapsedUnits)
        Me.grpSpan.Controls.Add(Me.lstIntervalSpan)
        Me.grpSpan.Controls.Add(Me.dtmEndSpan)
        Me.grpSpan.Controls.Add(Me.dtmStartSpan)
        Me.grpSpan.Controls.Add(Me.lblElapsedLabel)
        Me.grpSpan.Controls.Add(Me.lblResultInterval)
        Me.grpSpan.Controls.Add(Me.lblEndTime)
        Me.grpSpan.Controls.Add(Me.lblStartTime)
        Me.grpSpan.Location = New System.Drawing.Point(559, 21)
        Me.grpSpan.Name = "grpSpan"
        Me.grpSpan.Size = New System.Drawing.Size(475, 401)
        Me.grpSpan.TabIndex = 1
        Me.grpSpan.TabStop = False
        Me.grpSpan.Text = "Determining the Interval"
        '
        'btnClearSpan
        '
        Me.btnClearSpan.Location = New System.Drawing.Point(329, 308)
        Me.btnClearSpan.Name = "btnClearSpan"
        Me.btnClearSpan.Size = New System.Drawing.Size(125, 40)
        Me.btnClearSpan.TabIndex = 17
        Me.btnClearSpan.Text = "Clear"
        Me.btnClearSpan.UseVisualStyleBackColor = True
        '
        'btnUpdateSpan
        '
        Me.btnUpdateSpan.Location = New System.Drawing.Point(175, 308)
        Me.btnUpdateSpan.Name = "btnUpdateSpan"
        Me.btnUpdateSpan.Size = New System.Drawing.Size(125, 40)
        Me.btnUpdateSpan.TabIndex = 16
        Me.btnUpdateSpan.Text = "Update Start From"
        Me.btnUpdateSpan.UseVisualStyleBackColor = True
        '
        'btnSpan
        '
        Me.btnSpan.Location = New System.Drawing.Point(21, 308)
        Me.btnSpan.Name = "btnSpan"
        Me.btnSpan.Size = New System.Drawing.Size(125, 40)
        Me.btnSpan.TabIndex = 15
        Me.btnSpan.Text = "Calculate Span"
        Me.btnSpan.UseVisualStyleBackColor = True
        '
        'lblElapsedUnits
        '
        Me.lblElapsedUnits.BackColor = System.Drawing.Color.White
        Me.lblElapsedUnits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblElapsedUnits.Location = New System.Drawing.Point(121, 240)
        Me.lblElapsedUnits.Name = "lblElapsedUnits"
        Me.lblElapsedUnits.Size = New System.Drawing.Size(155, 25)
        Me.lblElapsedUnits.TabIndex = 14
        '
        'lstIntervalSpan
        '
        Me.lstIntervalSpan.FormattingEnabled = True
        Me.lstIntervalSpan.ItemHeight = 17
        Me.lstIntervalSpan.Location = New System.Drawing.Point(121, 151)
        Me.lstIntervalSpan.Name = "lstIntervalSpan"
        Me.lstIntervalSpan.Size = New System.Drawing.Size(155, 55)
        Me.lstIntervalSpan.TabIndex = 10
        '
        'dtmEndSpan
        '
        Me.dtmEndSpan.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtmEndSpan.Location = New System.Drawing.Point(121, 92)
        Me.dtmEndSpan.Name = "dtmEndSpan"
        Me.dtmEndSpan.Size = New System.Drawing.Size(155, 25)
        Me.dtmEndSpan.TabIndex = 9
        '
        'dtmStartSpan
        '
        Me.dtmStartSpan.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtmStartSpan.Location = New System.Drawing.Point(121, 33)
        Me.dtmStartSpan.Name = "dtmStartSpan"
        Me.dtmStartSpan.Size = New System.Drawing.Size(155, 25)
        Me.dtmStartSpan.TabIndex = 8
        '
        'lblElapsedLabel
        '
        Me.lblElapsedLabel.AutoSize = True
        Me.lblElapsedLabel.Location = New System.Drawing.Point(20, 241)
        Me.lblElapsedLabel.Name = "lblElapsedLabel"
        Me.lblElapsedLabel.Size = New System.Drawing.Size(87, 17)
        Me.lblElapsedLabel.TabIndex = 7
        Me.lblElapsedLabel.Text = "Elapsed Units"
        '
        'lblResultInterval
        '
        Me.lblResultInterval.AutoSize = True
        Me.lblResultInterval.Location = New System.Drawing.Point(20, 167)
        Me.lblResultInterval.Name = "lblResultInterval"
        Me.lblResultInterval.Size = New System.Drawing.Size(50, 17)
        Me.lblResultInterval.TabIndex = 6
        Me.lblResultInterval.Text = "Interval"
        '
        'lblEndTime
        '
        Me.lblEndTime.AutoSize = True
        Me.lblEndTime.Location = New System.Drawing.Point(20, 98)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(62, 17)
        Me.lblEndTime.TabIndex = 5
        Me.lblEndTime.Text = "End Time"
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Location = New System.Drawing.Point(20, 39)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(67, 17)
        Me.lblStartTime.TabIndex = 4
        Me.lblStartTime.Text = "Start Time"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(908, 436)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(126, 35)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 487)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpSpan)
        Me.Controls.Add(Me.grpAddSubtract)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.Text = "Date and Time Handling Samples"
        Me.grpAddSubtract.ResumeLayout(False)
        Me.grpAddSubtract.PerformLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSpan.ResumeLayout(False)
        Me.grpSpan.PerformLayout()
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
    Friend WithEvents errP As ErrorProvider
    Friend WithEvents btnExit As Button
    Friend WithEvents grpSpan As GroupBox
    Friend WithEvents btnClearSpan As Button
    Friend WithEvents btnUpdateSpan As Button
    Friend WithEvents btnSpan As Button
    Friend WithEvents lblElapsedUnits As Label
    Friend WithEvents lstIntervalSpan As ListBox
    Friend WithEvents dtmEndSpan As DateTimePicker
    Friend WithEvents dtmStartSpan As DateTimePicker
    Friend WithEvents lblElapsedLabel As Label
    Friend WithEvents lblResultInterval As Label
    Friend WithEvents lblEndTime As Label
    Friend WithEvents lblStartTime As Label
End Class
