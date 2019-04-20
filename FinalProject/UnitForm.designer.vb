<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnit
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
        Me.lblDayCounter = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblEmployeeOne = New System.Windows.Forms.Label()
        Me.lblEmployeeTwo = New System.Windows.Forms.Label()
        Me.lblEmployeeThree = New System.Windows.Forms.Label()
        Me.txtUnitInput = New System.Windows.Forms.TextBox()
        Me.lblEmployeeOneAverage = New System.Windows.Forms.Label()
        Me.lblEmployeeTwoAverage = New System.Windows.Forms.Label()
        Me.lblEmployeeThreeAverage = New System.Windows.Forms.Label()
        Me.txtEmployeeOneInput = New System.Windows.Forms.TextBox()
        Me.txtEmployeeTwoInput = New System.Windows.Forms.TextBox()
        Me.txtEmployeeThreeInput = New System.Windows.Forms.TextBox()
        Me.lblAverageShippedDaily = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDayCounter
        '
        Me.lblDayCounter.Location = New System.Drawing.Point(13, 18)
        Me.lblDayCounter.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDayCounter.Name = "lblDayCounter"
        Me.lblDayCounter.Size = New System.Drawing.Size(75, 19)
        Me.lblDayCounter.TabIndex = 0
        Me.lblDayCounter.Text = "Day"
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(10, 46)
        Me.lblUnits.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(33, 19)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "&Units:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmployeeOne
        '
        Me.lblEmployeeOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeOne.Location = New System.Drawing.Point(15, 70)
        Me.lblEmployeeOne.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmployeeOne.Name = "lblEmployeeOne"
        Me.lblEmployeeOne.Size = New System.Drawing.Size(101, 19)
        Me.lblEmployeeOne.TabIndex = 2
        Me.lblEmployeeOne.Text = "Employee 1"
        Me.lblEmployeeOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployeeTwo
        '
        Me.lblEmployeeTwo.Location = New System.Drawing.Point(121, 70)
        Me.lblEmployeeTwo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmployeeTwo.Name = "lblEmployeeTwo"
        Me.lblEmployeeTwo.Size = New System.Drawing.Size(104, 19)
        Me.lblEmployeeTwo.TabIndex = 3
        Me.lblEmployeeTwo.Text = "Employee 2"
        Me.lblEmployeeTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployeeThree
        '
        Me.lblEmployeeThree.Location = New System.Drawing.Point(229, 70)
        Me.lblEmployeeThree.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmployeeThree.Name = "lblEmployeeThree"
        Me.lblEmployeeThree.Size = New System.Drawing.Size(104, 19)
        Me.lblEmployeeThree.TabIndex = 4
        Me.lblEmployeeThree.Text = "Employee 3"
        Me.lblEmployeeThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUnitInput
        '
        Me.txtUnitInput.Location = New System.Drawing.Point(48, 46)
        Me.txtUnitInput.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUnitInput.Name = "txtUnitInput"
        Me.txtUnitInput.Size = New System.Drawing.Size(51, 20)
        Me.txtUnitInput.TabIndex = 5
        '
        'lblEmployeeOneAverage
        '
        Me.lblEmployeeOneAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeOneAverage.Location = New System.Drawing.Point(11, 197)
        Me.lblEmployeeOneAverage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmployeeOneAverage.Name = "lblEmployeeOneAverage"
        Me.lblEmployeeOneAverage.Size = New System.Drawing.Size(105, 19)
        Me.lblEmployeeOneAverage.TabIndex = 6
        Me.lblEmployeeOneAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployeeTwoAverage
        '
        Me.lblEmployeeTwoAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeTwoAverage.Location = New System.Drawing.Point(121, 197)
        Me.lblEmployeeTwoAverage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmployeeTwoAverage.Name = "lblEmployeeTwoAverage"
        Me.lblEmployeeTwoAverage.Size = New System.Drawing.Size(104, 19)
        Me.lblEmployeeTwoAverage.TabIndex = 7
        Me.lblEmployeeTwoAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployeeThreeAverage
        '
        Me.lblEmployeeThreeAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeThreeAverage.Location = New System.Drawing.Point(229, 197)
        Me.lblEmployeeThreeAverage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmployeeThreeAverage.Name = "lblEmployeeThreeAverage"
        Me.lblEmployeeThreeAverage.Size = New System.Drawing.Size(104, 19)
        Me.lblEmployeeThreeAverage.TabIndex = 8
        Me.lblEmployeeThreeAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmployeeOneInput
        '
        Me.txtEmployeeOneInput.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmployeeOneInput.Location = New System.Drawing.Point(13, 91)
        Me.txtEmployeeOneInput.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEmployeeOneInput.Multiline = True
        Me.txtEmployeeOneInput.Name = "txtEmployeeOneInput"
        Me.txtEmployeeOneInput.ReadOnly = True
        Me.txtEmployeeOneInput.Size = New System.Drawing.Size(104, 102)
        Me.txtEmployeeOneInput.TabIndex = 9
        '
        'txtEmployeeTwoInput
        '
        Me.txtEmployeeTwoInput.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmployeeTwoInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmployeeTwoInput.Location = New System.Drawing.Point(121, 91)
        Me.txtEmployeeTwoInput.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEmployeeTwoInput.Multiline = True
        Me.txtEmployeeTwoInput.Name = "txtEmployeeTwoInput"
        Me.txtEmployeeTwoInput.ReadOnly = True
        Me.txtEmployeeTwoInput.Size = New System.Drawing.Size(104, 102)
        Me.txtEmployeeTwoInput.TabIndex = 10
        '
        'txtEmployeeThreeInput
        '
        Me.txtEmployeeThreeInput.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmployeeThreeInput.Location = New System.Drawing.Point(229, 91)
        Me.txtEmployeeThreeInput.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEmployeeThreeInput.Multiline = True
        Me.txtEmployeeThreeInput.Name = "txtEmployeeThreeInput"
        Me.txtEmployeeThreeInput.ReadOnly = True
        Me.txtEmployeeThreeInput.Size = New System.Drawing.Size(104, 102)
        Me.txtEmployeeThreeInput.TabIndex = 11
        '
        'lblAverageShippedDaily
        '
        Me.lblAverageShippedDaily.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageShippedDaily.Location = New System.Drawing.Point(11, 225)
        Me.lblAverageShippedDaily.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAverageShippedDaily.Name = "lblAverageShippedDaily"
        Me.lblAverageShippedDaily.Size = New System.Drawing.Size(321, 19)
        Me.lblAverageShippedDaily.TabIndex = 12
        Me.lblAverageShippedDaily.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(11, 246)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(105, 25)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(121, 246)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(104, 25)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(229, 246)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 25)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmUnit
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(343, 278)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblAverageShippedDaily)
        Me.Controls.Add(Me.txtEmployeeThreeInput)
        Me.Controls.Add(Me.txtEmployeeTwoInput)
        Me.Controls.Add(Me.txtEmployeeOneInput)
        Me.Controls.Add(Me.lblEmployeeThreeAverage)
        Me.Controls.Add(Me.lblEmployeeTwoAverage)
        Me.Controls.Add(Me.lblEmployeeOneAverage)
        Me.Controls.Add(Me.txtUnitInput)
        Me.Controls.Add(Me.lblEmployeeThree)
        Me.Controls.Add(Me.lblEmployeeTwo)
        Me.Controls.Add(Me.lblEmployeeOne)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblDayCounter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUnit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDayCounter As Label
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblEmployeeOne As Label
    Friend WithEvents lblEmployeeTwo As Label
    Friend WithEvents lblEmployeeThree As Label
    Friend WithEvents txtUnitInput As TextBox
    Friend WithEvents lblEmployeeOneAverage As Label
    Friend WithEvents lblEmployeeTwoAverage As Label
    Friend WithEvents lblEmployeeThreeAverage As Label
    Friend WithEvents txtEmployeeOneInput As TextBox
    Friend WithEvents txtEmployeeTwoInput As TextBox
    Friend WithEvents txtEmployeeThreeInput As TextBox
    Friend WithEvents lblAverageShippedDaily As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
