<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentalChargesForm
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
        Me.RentalInfoBox = New System.Windows.Forms.GroupBox()
        Me.NumberDaysTextBox = New System.Windows.Forms.TextBox()
        Me.EndOdometerTextBox = New System.Windows.Forms.TextBox()
        Me.BeginOdometerTextBox = New System.Windows.Forms.TextBox()
        Me.NumberDaysLabel = New System.Windows.Forms.Label()
        Me.EndOdometerLabel = New System.Windows.Forms.Label()
        Me.BeginOdometerLabel = New System.Windows.Forms.Label()
        Me.TotalsBox = New System.Windows.Forms.GroupBox()
        Me.TotalChargeTextBox = New System.Windows.Forms.TextBox()
        Me.MilesDrivenTextBox = New System.Windows.Forms.TextBox()
        Me.TotalChargeLabel = New System.Windows.Forms.Label()
        Me.MilesDrivenLabel = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.RentalInfoBox.SuspendLayout()
        Me.TotalsBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'RentalInfoBox
        '
        Me.RentalInfoBox.Controls.Add(Me.NumberDaysTextBox)
        Me.RentalInfoBox.Controls.Add(Me.EndOdometerTextBox)
        Me.RentalInfoBox.Controls.Add(Me.BeginOdometerTextBox)
        Me.RentalInfoBox.Controls.Add(Me.NumberDaysLabel)
        Me.RentalInfoBox.Controls.Add(Me.EndOdometerLabel)
        Me.RentalInfoBox.Controls.Add(Me.BeginOdometerLabel)
        Me.RentalInfoBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RentalInfoBox.Location = New System.Drawing.Point(12, 12)
        Me.RentalInfoBox.Name = "RentalInfoBox"
        Me.RentalInfoBox.Size = New System.Drawing.Size(393, 192)
        Me.RentalInfoBox.TabIndex = 0
        Me.RentalInfoBox.TabStop = False
        Me.RentalInfoBox.Text = "Enter Rental Information"
        '
        'NumberDaysTextBox
        '
        Me.NumberDaysTextBox.Location = New System.Drawing.Point(173, 100)
        Me.NumberDaysTextBox.Name = "NumberDaysTextBox"
        Me.NumberDaysTextBox.Size = New System.Drawing.Size(43, 26)
        Me.NumberDaysTextBox.TabIndex = 5
        '
        'EndOdometerTextBox
        '
        Me.EndOdometerTextBox.Location = New System.Drawing.Point(173, 64)
        Me.EndOdometerTextBox.Name = "EndOdometerTextBox"
        Me.EndOdometerTextBox.Size = New System.Drawing.Size(100, 26)
        Me.EndOdometerTextBox.TabIndex = 4
        '
        'BeginOdometerTextBox
        '
        Me.BeginOdometerTextBox.Location = New System.Drawing.Point(173, 26)
        Me.BeginOdometerTextBox.Name = "BeginOdometerTextBox"
        Me.BeginOdometerTextBox.Size = New System.Drawing.Size(100, 26)
        Me.BeginOdometerTextBox.TabIndex = 3
        '
        'NumberDaysLabel
        '
        Me.NumberDaysLabel.AutoSize = True
        Me.NumberDaysLabel.Location = New System.Drawing.Point(11, 100)
        Me.NumberDaysLabel.Name = "NumberDaysLabel"
        Me.NumberDaysLabel.Size = New System.Drawing.Size(127, 20)
        Me.NumberDaysLabel.TabIndex = 2
        Me.NumberDaysLabel.Text = "Number of Days:"
        '
        'EndOdometerLabel
        '
        Me.EndOdometerLabel.AutoSize = True
        Me.EndOdometerLabel.Location = New System.Drawing.Point(7, 64)
        Me.EndOdometerLabel.Name = "EndOdometerLabel"
        Me.EndOdometerLabel.Size = New System.Drawing.Size(138, 20)
        Me.EndOdometerLabel.TabIndex = 1
        Me.EndOdometerLabel.Text = "Ending Odometer:"
        '
        'BeginOdometerLabel
        '
        Me.BeginOdometerLabel.AutoSize = True
        Me.BeginOdometerLabel.Location = New System.Drawing.Point(7, 26)
        Me.BeginOdometerLabel.Name = "BeginOdometerLabel"
        Me.BeginOdometerLabel.Size = New System.Drawing.Size(159, 20)
        Me.BeginOdometerLabel.TabIndex = 0
        Me.BeginOdometerLabel.Text = "Beginning Odometer:"
        '
        'TotalsBox
        '
        Me.TotalsBox.Controls.Add(Me.TotalChargeTextBox)
        Me.TotalsBox.Controls.Add(Me.MilesDrivenTextBox)
        Me.TotalsBox.Controls.Add(Me.TotalChargeLabel)
        Me.TotalsBox.Controls.Add(Me.MilesDrivenLabel)
        Me.TotalsBox.Location = New System.Drawing.Point(481, 12)
        Me.TotalsBox.Name = "TotalsBox"
        Me.TotalsBox.Size = New System.Drawing.Size(298, 192)
        Me.TotalsBox.TabIndex = 1
        Me.TotalsBox.TabStop = False
        Me.TotalsBox.Text = "Totals"
        '
        'TotalChargeTextBox
        '
        Me.TotalChargeTextBox.Location = New System.Drawing.Point(37, 109)
        Me.TotalChargeTextBox.Name = "TotalChargeTextBox"
        Me.TotalChargeTextBox.Size = New System.Drawing.Size(100, 26)
        Me.TotalChargeTextBox.TabIndex = 3
        '
        'MilesDrivenTextBox
        '
        Me.MilesDrivenTextBox.Location = New System.Drawing.Point(37, 54)
        Me.MilesDrivenTextBox.Name = "MilesDrivenTextBox"
        Me.MilesDrivenTextBox.Size = New System.Drawing.Size(100, 26)
        Me.MilesDrivenTextBox.TabIndex = 2
        '
        'TotalChargeLabel
        '
        Me.TotalChargeLabel.AutoSize = True
        Me.TotalChargeLabel.Location = New System.Drawing.Point(37, 85)
        Me.TotalChargeLabel.Name = "TotalChargeLabel"
        Me.TotalChargeLabel.Size = New System.Drawing.Size(104, 20)
        Me.TotalChargeLabel.TabIndex = 1
        Me.TotalChargeLabel.Text = "Total Charge:"
        '
        'MilesDrivenLabel
        '
        Me.MilesDrivenLabel.AutoSize = True
        Me.MilesDrivenLabel.Location = New System.Drawing.Point(33, 31)
        Me.MilesDrivenLabel.Name = "MilesDrivenLabel"
        Me.MilesDrivenLabel.Size = New System.Drawing.Size(98, 20)
        Me.MilesDrivenLabel.TabIndex = 0
        Me.MilesDrivenLabel.Text = "Miles Driven:"
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(400, 220)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(87, 37)
        Me.CalculateButton.TabIndex = 2
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(507, 220)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(88, 37)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(626, 220)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(77, 37)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'RentalChargesForm
        '
        Me.AcceptButton = Me.CalculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 288)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.TotalsBox)
        Me.Controls.Add(Me.RentalInfoBox)
        Me.Name = "RentalChargesForm"
        Me.Text = "Rental Charges"
        Me.RentalInfoBox.ResumeLayout(False)
        Me.RentalInfoBox.PerformLayout()
        Me.TotalsBox.ResumeLayout(False)
        Me.TotalsBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RentalInfoBox As GroupBox
    Friend WithEvents NumberDaysTextBox As TextBox
    Friend WithEvents EndOdometerTextBox As TextBox
    Friend WithEvents BeginOdometerTextBox As TextBox
    Friend WithEvents NumberDaysLabel As Label
    Friend WithEvents EndOdometerLabel As Label
    Friend WithEvents BeginOdometerLabel As Label
    Friend WithEvents TotalsBox As GroupBox
    Friend WithEvents TotalChargeTextBox As TextBox
    Friend WithEvents MilesDrivenTextBox As TextBox
    Friend WithEvents TotalChargeLabel As Label
    Friend WithEvents MilesDrivenLabel As Label
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
End Class
