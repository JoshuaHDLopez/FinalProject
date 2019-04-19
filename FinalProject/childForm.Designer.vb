<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class childForm
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
        Me.tbTextInput = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'tbTextInput
        '
        Me.tbTextInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbTextInput.Location = New System.Drawing.Point(0, 0)
        Me.tbTextInput.Multiline = True
        Me.tbTextInput.Name = "tbTextInput"
        Me.tbTextInput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbTextInput.Size = New System.Drawing.Size(800, 450)
        Me.tbTextInput.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.tbTextInput, "Text Box for input")
        '
        'childForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tbTextInput)
        Me.Name = "childForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbTextInput As TextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
