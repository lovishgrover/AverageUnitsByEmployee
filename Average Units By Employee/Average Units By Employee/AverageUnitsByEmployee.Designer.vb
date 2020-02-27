<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AverageUnitsByEmployee
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
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtUnitsShipped1 = New System.Windows.Forms.TextBox()
        Me.txtUnitsShipped2 = New System.Windows.Forms.TextBox()
        Me.txtUnitsShipped3 = New System.Windows.Forms.TextBox()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.lblAverageUnits1 = New System.Windows.Forms.Label()
        Me.lblAverageUnits2 = New System.Windows.Forms.Label()
        Me.lblAverageUnits3 = New System.Windows.Forms.Label()
        Me.lblOverallAverage = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtUnitsShipped = New System.Windows.Forms.TextBox()
        Me.ttpUnits = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(39, 389)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(79, 36)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.ttpUnits.SetToolTip(Me.btnEnter, "Calculates the overall average and average of each employee")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(193, 389)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(79, 36)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.ttpUnits.SetToolTip(Me.btnReset, "Resets the form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(356, 389)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 36)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.ttpUnits.SetToolTip(Me.btnExit, "Exits the form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtUnitsShipped1
        '
        Me.txtUnitsShipped1.Location = New System.Drawing.Point(28, 115)
        Me.txtUnitsShipped1.Multiline = True
        Me.txtUnitsShipped1.Name = "txtUnitsShipped1"
        Me.txtUnitsShipped1.Size = New System.Drawing.Size(111, 190)
        Me.txtUnitsShipped1.TabIndex = 4
        Me.ttpUnits.SetToolTip(Me.txtUnitsShipped1, "Enter the shipped values for Employee1")
        '
        'txtUnitsShipped2
        '
        Me.txtUnitsShipped2.Location = New System.Drawing.Point(219, 116)
        Me.txtUnitsShipped2.Multiline = True
        Me.txtUnitsShipped2.Name = "txtUnitsShipped2"
        Me.txtUnitsShipped2.Size = New System.Drawing.Size(110, 189)
        Me.txtUnitsShipped2.TabIndex = 7
        Me.ttpUnits.SetToolTip(Me.txtUnitsShipped2, "Enter the shipped values for Employee 2")
        '
        'txtUnitsShipped3
        '
        Me.txtUnitsShipped3.Location = New System.Drawing.Point(388, 111)
        Me.txtUnitsShipped3.Multiline = True
        Me.txtUnitsShipped3.Name = "txtUnitsShipped3"
        Me.txtUnitsShipped3.Size = New System.Drawing.Size(115, 189)
        Me.txtUnitsShipped3.TabIndex = 10
        Me.ttpUnits.SetToolTip(Me.txtUnitsShipped3, "Enter the shipped values for Employee 3")
        '
        'lblEmployee1
        '
        Me.lblEmployee1.Location = New System.Drawing.Point(45, 91)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(94, 21)
        Me.lblEmployee1.TabIndex = 3
        Me.lblEmployee1.Text = "Employee 1"
        '
        'lblEmployee2
        '
        Me.lblEmployee2.AutoSize = True
        Me.lblEmployee2.Location = New System.Drawing.Point(232, 91)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(82, 17)
        Me.lblEmployee2.TabIndex = 6
        Me.lblEmployee2.Text = "Employee 2"
        '
        'lblEmployee3
        '
        Me.lblEmployee3.AutoSize = True
        Me.lblEmployee3.Location = New System.Drawing.Point(399, 91)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(82, 17)
        Me.lblEmployee3.TabIndex = 9
        Me.lblEmployee3.Text = "Employee 3"
        '
        'lblAverageUnits1
        '
        Me.lblAverageUnits1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblAverageUnits1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageUnits1.Location = New System.Drawing.Point(-2, 313)
        Me.lblAverageUnits1.Name = "lblAverageUnits1"
        Me.lblAverageUnits1.Size = New System.Drawing.Size(177, 31)
        Me.lblAverageUnits1.TabIndex = 5
        Me.lblAverageUnits1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpUnits.SetToolTip(Me.lblAverageUnits1, "Average units by Employee 1")
        '
        'lblAverageUnits2
        '
        Me.lblAverageUnits2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblAverageUnits2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageUnits2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAverageUnits2.Location = New System.Drawing.Point(181, 313)
        Me.lblAverageUnits2.Name = "lblAverageUnits2"
        Me.lblAverageUnits2.Size = New System.Drawing.Size(174, 31)
        Me.lblAverageUnits2.TabIndex = 8
        Me.lblAverageUnits2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpUnits.SetToolTip(Me.lblAverageUnits2, "Average units by Employee 2")
        '
        'lblAverageUnits3
        '
        Me.lblAverageUnits3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblAverageUnits3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageUnits3.Location = New System.Drawing.Point(361, 313)
        Me.lblAverageUnits3.Name = "lblAverageUnits3"
        Me.lblAverageUnits3.Size = New System.Drawing.Size(181, 31)
        Me.lblAverageUnits3.TabIndex = 11
        Me.lblAverageUnits3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpUnits.SetToolTip(Me.lblAverageUnits3, "Average units by Employee 3")
        '
        'lblOverallAverage
        '
        Me.lblOverallAverage.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblOverallAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOverallAverage.Location = New System.Drawing.Point(73, 350)
        Me.lblOverallAverage.Name = "lblOverallAverage"
        Me.lblOverallAverage.Size = New System.Drawing.Size(341, 36)
        Me.lblOverallAverage.TabIndex = 12
        Me.lblOverallAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpUnits.SetToolTip(Me.lblOverallAverage, "Average units by all Employees")
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(70, 18)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(45, 17)
        Me.lblDay.TabIndex = 0
        Me.lblDay.Text = "Day 1"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUnits
        '
        Me.lblUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnits.Location = New System.Drawing.Point(48, 50)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(100, 23)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "&Units :"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpUnits.SetToolTip(Me.lblUnits, "Enter the units")
        '
        'txtUnitsShipped
        '
        Me.txtUnitsShipped.Location = New System.Drawing.Point(140, 51)
        Me.txtUnitsShipped.Name = "txtUnitsShipped"
        Me.txtUnitsShipped.Size = New System.Drawing.Size(100, 22)
        Me.txtUnitsShipped.TabIndex = 2
        Me.ttpUnits.SetToolTip(Me.txtUnitsShipped, "Enter the units")
        '
        'AverageUnitsByEmployee
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(547, 450)
        Me.Controls.Add(Me.txtUnitsShipped)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblOverallAverage)
        Me.Controls.Add(Me.lblAverageUnits3)
        Me.Controls.Add(Me.lblAverageUnits2)
        Me.Controls.Add(Me.lblAverageUnits1)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.txtUnitsShipped3)
        Me.Controls.Add(Me.txtUnitsShipped2)
        Me.Controls.Add(Me.txtUnitsShipped1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AverageUnitsByEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtUnitsShipped1 As TextBox
    Friend WithEvents txtUnitsShipped2 As TextBox
    Friend WithEvents txtUnitsShipped3 As TextBox
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee3 As Label
    Friend WithEvents lblAverageUnits1 As Label
    Friend WithEvents lblAverageUnits2 As Label
    Friend WithEvents lblAverageUnits3 As Label
    Friend WithEvents lblOverallAverage As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents lblUnits As Label
    Friend WithEvents txtUnitsShipped As TextBox
    Friend WithEvents ttpUnits As ToolTip
End Class
