<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFutureDate = New System.Windows.Forms.TextBox()
        Me.txtBirthDate = New System.Windows.Forms.TextBox()
        Me.btnCalculateDueDays = New System.Windows.Forms.Button()
        Me.btnCalculateAge = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a future date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter a  birthdate:"
        '
        'txtFutureDate
        '
        Me.txtFutureDate.Location = New System.Drawing.Point(183, 25)
        Me.txtFutureDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFutureDate.Name = "txtFutureDate"
        Me.txtFutureDate.Size = New System.Drawing.Size(132, 22)
        Me.txtFutureDate.TabIndex = 2
        '
        'txtBirthDate
        '
        Me.txtBirthDate.Location = New System.Drawing.Point(183, 64)
        Me.txtBirthDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBirthDate.Name = "txtBirthDate"
        Me.txtBirthDate.Size = New System.Drawing.Size(132, 22)
        Me.txtBirthDate.TabIndex = 3
        '
        'btnCalculateDueDays
        '
        Me.btnCalculateDueDays.Location = New System.Drawing.Point(347, 21)
        Me.btnCalculateDueDays.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalculateDueDays.Name = "btnCalculateDueDays"
        Me.btnCalculateDueDays.Size = New System.Drawing.Size(167, 28)
        Me.btnCalculateDueDays.TabIndex = 4
        Me.btnCalculateDueDays.Text = "Calculate Due Days"
        Me.btnCalculateDueDays.UseVisualStyleBackColor = True
        '
        'btnCalculateAge
        '
        Me.btnCalculateAge.Location = New System.Drawing.Point(347, 60)
        Me.btnCalculateAge.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalculateAge.Name = "btnCalculateAge"
        Me.btnCalculateAge.Size = New System.Drawing.Size(167, 28)
        Me.btnCalculateAge.TabIndex = 5
        Me.btnCalculateAge.Text = "Calculate Age"
        Me.btnCalculateAge.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(347, 135)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(167, 28)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(568, 193)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculateAge)
        Me.Controls.Add(Me.btnCalculateDueDays)
        Me.Controls.Add(Me.txtBirthDate)
        Me.Controls.Add(Me.txtFutureDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Date Handling"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFutureDate As System.Windows.Forms.TextBox
    Friend WithEvents txtBirthDate As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculateDueDays As System.Windows.Forms.Button
    Friend WithEvents btnCalculateAge As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
