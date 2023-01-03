<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtAgeInYears = New System.Windows.Forms.TextBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblAgeInDays = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAgeInYears
        '
        Me.txtAgeInYears.Location = New System.Drawing.Point(231, 66)
        Me.txtAgeInYears.Name = "txtAgeInYears"
        Me.txtAgeInYears.Size = New System.Drawing.Size(234, 27)
        Me.txtAgeInYears.TabIndex = 0
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblInstructions.Location = New System.Drawing.Point(168, 24)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(427, 29)
        Me.lblInstructions.TabIndex = 1
        Me.lblInstructions.Text = "Please enter your age in years:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCalculate.Location = New System.Drawing.Point(262, 115)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(203, 58)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblAgeInDays
        '
        Me.lblAgeInDays.AutoSize = True
        Me.lblAgeInDays.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblAgeInDays.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAgeInDays.Location = New System.Drawing.Point(216, 209)
        Me.lblAgeInDays.Name = "lblAgeInDays"
        Me.lblAgeInDays.Size = New System.Drawing.Size(301, 37)
        Me.lblAgeInDays.TabIndex = 3
        Me.lblAgeInDays.Text = "Your Age in Days"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblAgeInDays)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.txtAgeInYears)
        Me.Name = "Form1"
        Me.Text = "Age in Days Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAgeInYears As TextBox
    Friend WithEvents lblInstructions As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblAgeInDays As Label
End Class
