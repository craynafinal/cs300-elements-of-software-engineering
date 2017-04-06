<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BudgetWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BudgetWindow))
        Me.d_totalBudgetLabel = New System.Windows.Forms.Label()
        Me.d_budgetRemainedLabel = New System.Windows.Forms.Label()
        Me.d_budgetTypeLabel = New System.Windows.Forms.Label()
        Me.d_allocationLabel = New System.Windows.Forms.Label()
        Me.d_prevLabel = New System.Windows.Forms.Label()
        Me.d_cancelButton = New System.Windows.Forms.Button()
        Me.d_resetButton = New System.Windows.Forms.Button()
        Me.d_commitButton = New System.Windows.Forms.Button()
        Me.labelTotal_value = New System.Windows.Forms.Label()
        Me.labelRemained_value = New System.Windows.Forms.Label()
        Me.d_displayPanel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'd_totalBudgetLabel
        '
        Me.d_totalBudgetLabel.AutoSize = True
        Me.d_totalBudgetLabel.Location = New System.Drawing.Point(20, 18)
        Me.d_totalBudgetLabel.Name = "d_totalBudgetLabel"
        Me.d_totalBudgetLabel.Size = New System.Drawing.Size(80, 12)
        Me.d_totalBudgetLabel.TabIndex = 4
        Me.d_totalBudgetLabel.Text = "Total Budget:"
        '
        'd_budgetRemainedLabel
        '
        Me.d_budgetRemainedLabel.AutoSize = True
        Me.d_budgetRemainedLabel.Location = New System.Drawing.Point(184, 18)
        Me.d_budgetRemainedLabel.Name = "d_budgetRemainedLabel"
        Me.d_budgetRemainedLabel.Size = New System.Drawing.Size(109, 12)
        Me.d_budgetRemainedLabel.TabIndex = 5
        Me.d_budgetRemainedLabel.Text = "Budget Remained:"
        '
        'd_budgetTypeLabel
        '
        Me.d_budgetTypeLabel.AutoSize = True
        Me.d_budgetTypeLabel.Location = New System.Drawing.Point(20, 41)
        Me.d_budgetTypeLabel.Name = "d_budgetTypeLabel"
        Me.d_budgetTypeLabel.Size = New System.Drawing.Size(77, 12)
        Me.d_budgetTypeLabel.TabIndex = 6
        Me.d_budgetTypeLabel.Text = "Budget Type"
        '
        'd_allocationLabel
        '
        Me.d_allocationLabel.AutoSize = True
        Me.d_allocationLabel.Location = New System.Drawing.Point(220, 41)
        Me.d_allocationLabel.Name = "d_allocationLabel"
        Me.d_allocationLabel.Size = New System.Drawing.Size(60, 12)
        Me.d_allocationLabel.TabIndex = 7
        Me.d_allocationLabel.Text = "Allocation"
        '
        'd_prevLabel
        '
        Me.d_prevLabel.AutoSize = True
        Me.d_prevLabel.Location = New System.Drawing.Point(306, 41)
        Me.d_prevLabel.Name = "d_prevLabel"
        Me.d_prevLabel.Size = New System.Drawing.Size(30, 12)
        Me.d_prevLabel.TabIndex = 8
        Me.d_prevLabel.Text = "Prev"
        '
        'd_cancelButton
        '
        Me.d_cancelButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.d_cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d_cancelButton.Location = New System.Drawing.Point(314, 371)
        Me.d_cancelButton.Name = "d_cancelButton"
        Me.d_cancelButton.Size = New System.Drawing.Size(75, 23)
        Me.d_cancelButton.TabIndex = 11
        Me.d_cancelButton.Text = "Cancel"
        Me.d_cancelButton.UseVisualStyleBackColor = True
        '
        'd_resetButton
        '
        Me.d_resetButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.d_resetButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.d_resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d_resetButton.Location = New System.Drawing.Point(108, 371)
        Me.d_resetButton.Name = "d_resetButton"
        Me.d_resetButton.Size = New System.Drawing.Size(75, 23)
        Me.d_resetButton.TabIndex = 10
        Me.d_resetButton.Text = "Reset"
        Me.d_resetButton.UseVisualStyleBackColor = False
        '
        'd_commitButton
        '
        Me.d_commitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.d_commitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.d_commitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d_commitButton.Location = New System.Drawing.Point(20, 371)
        Me.d_commitButton.Name = "d_commitButton"
        Me.d_commitButton.Size = New System.Drawing.Size(75, 23)
        Me.d_commitButton.TabIndex = 9
        Me.d_commitButton.Text = "Commit"
        Me.d_commitButton.UseVisualStyleBackColor = False
        '
        'labelTotal_value
        '
        Me.labelTotal_value.AutoSize = True
        Me.labelTotal_value.Location = New System.Drawing.Point(106, 18)
        Me.labelTotal_value.Name = "labelTotal_value"
        Me.labelTotal_value.Size = New System.Drawing.Size(11, 12)
        Me.labelTotal_value.TabIndex = 12
        Me.labelTotal_value.Text = "0"
        '
        'labelRemained_value
        '
        Me.labelRemained_value.AutoSize = True
        Me.labelRemained_value.Location = New System.Drawing.Point(299, 18)
        Me.labelRemained_value.Name = "labelRemained_value"
        Me.labelRemained_value.Size = New System.Drawing.Size(11, 12)
        Me.labelRemained_value.TabIndex = 13
        Me.labelRemained_value.Text = "0"
        '
        'd_displayPanel
        '
        Me.d_displayPanel.Location = New System.Drawing.Point(22, 68)
        Me.d_displayPanel.Name = "d_displayPanel"
        Me.d_displayPanel.Size = New System.Drawing.Size(367, 285)
        Me.d_displayPanel.TabIndex = 14
        '
        'BudgetWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(416, 416)
        Me.Controls.Add(Me.d_displayPanel)
        Me.Controls.Add(Me.labelRemained_value)
        Me.Controls.Add(Me.labelTotal_value)
        Me.Controls.Add(Me.d_cancelButton)
        Me.Controls.Add(Me.d_resetButton)
        Me.Controls.Add(Me.d_commitButton)
        Me.Controls.Add(Me.d_prevLabel)
        Me.Controls.Add(Me.d_allocationLabel)
        Me.Controls.Add(Me.d_budgetTypeLabel)
        Me.Controls.Add(Me.d_budgetRemainedLabel)
        Me.Controls.Add(Me.d_totalBudgetLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BudgetWindow"
        Me.Text = "Budget Allocation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents d_totalBudgetLabel As System.Windows.Forms.Label
    Friend WithEvents d_budgetRemainedLabel As System.Windows.Forms.Label
    Friend WithEvents d_budgetTypeLabel As System.Windows.Forms.Label
    Friend WithEvents d_allocationLabel As System.Windows.Forms.Label
    Friend WithEvents d_prevLabel As System.Windows.Forms.Label
    Friend WithEvents d_cancelButton As System.Windows.Forms.Button
    Friend WithEvents d_resetButton As System.Windows.Forms.Button
    Friend WithEvents d_commitButton As System.Windows.Forms.Button
    Friend WithEvents labelTotal_value As System.Windows.Forms.Label
    Friend WithEvents labelRemained_value As System.Windows.Forms.Label
    Friend WithEvents d_displayPanel As System.Windows.Forms.Panel
End Class
