<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashWindow))
        Me.d_budgetButton = New System.Windows.Forms.Button()
        Me.d_indicatorButton = New System.Windows.Forms.Button()
        Me.d_newGameButton = New System.Windows.Forms.Button()
        Me.d_loadGameButton = New System.Windows.Forms.Button()
        Me.d_saveGameButton = New System.Windows.Forms.Button()
        Me.d_exitGameButton = New System.Windows.Forms.Button()
        Me.d_iterLabel = New System.Windows.Forms.Label()
        Me.d_noteLabel = New System.Windows.Forms.Label()
        Me.d_displayPanel = New System.Windows.Forms.Panel()
        Me.d_totalBudgetLabel = New System.Windows.Forms.Label()
        Me.d_totalBudgetValueLabel = New System.Windows.Forms.Label()
        Me.d_multiplierTextBox = New System.Windows.Forms.Label()
        Me.d_difficultyLabel = New System.Windows.Forms.Label()
        Me.d_difficultyValueLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'd_budgetButton
        '
        Me.d_budgetButton.BackColor = System.Drawing.Color.Tomato
        Me.d_budgetButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.d_budgetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d_budgetButton.Location = New System.Drawing.Point(754, 48)
        Me.d_budgetButton.Name = "d_budgetButton"
        Me.d_budgetButton.Size = New System.Drawing.Size(116, 23)
        Me.d_budgetButton.TabIndex = 0
        Me.d_budgetButton.Text = "Budget Allocation"
        Me.d_budgetButton.UseVisualStyleBackColor = False
        '
        'd_indicatorButton
        '
        Me.d_indicatorButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.d_indicatorButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.d_indicatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d_indicatorButton.Location = New System.Drawing.Point(876, 48)
        Me.d_indicatorButton.Name = "d_indicatorButton"
        Me.d_indicatorButton.Size = New System.Drawing.Size(74, 23)
        Me.d_indicatorButton.TabIndex = 1
        Me.d_indicatorButton.Text = "Indicators"
        Me.d_indicatorButton.UseVisualStyleBackColor = False
        '
        'd_newGameButton
        '
        Me.d_newGameButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.d_newGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d_newGameButton.Location = New System.Drawing.Point(756, 416)
        Me.d_newGameButton.Name = "d_newGameButton"
        Me.d_newGameButton.Size = New System.Drawing.Size(112, 23)
        Me.d_newGameButton.TabIndex = 2
        Me.d_newGameButton.Text = "New Game"
        Me.d_newGameButton.UseVisualStyleBackColor = False
        '
        'd_loadGameButton
        '
        Me.d_loadGameButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.d_loadGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d_loadGameButton.Location = New System.Drawing.Point(756, 445)
        Me.d_loadGameButton.Name = "d_loadGameButton"
        Me.d_loadGameButton.Size = New System.Drawing.Size(112, 23)
        Me.d_loadGameButton.TabIndex = 3
        Me.d_loadGameButton.Text = "Load Game"
        Me.d_loadGameButton.UseVisualStyleBackColor = True
        '
        'd_saveGameButton
        '
        Me.d_saveGameButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.d_saveGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d_saveGameButton.Location = New System.Drawing.Point(874, 416)
        Me.d_saveGameButton.Name = "d_saveGameButton"
        Me.d_saveGameButton.Size = New System.Drawing.Size(112, 23)
        Me.d_saveGameButton.TabIndex = 4
        Me.d_saveGameButton.Text = "Save Game"
        Me.d_saveGameButton.UseVisualStyleBackColor = True
        '
        'd_exitGameButton
        '
        Me.d_exitGameButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.d_exitGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d_exitGameButton.Location = New System.Drawing.Point(874, 445)
        Me.d_exitGameButton.Name = "d_exitGameButton"
        Me.d_exitGameButton.Size = New System.Drawing.Size(112, 23)
        Me.d_exitGameButton.TabIndex = 5
        Me.d_exitGameButton.Text = "Exit Game"
        Me.d_exitGameButton.UseVisualStyleBackColor = True
        '
        'd_iterLabel
        '
        Me.d_iterLabel.AutoSize = True
        Me.d_iterLabel.Location = New System.Drawing.Point(752, 18)
        Me.d_iterLabel.Name = "d_iterLabel"
        Me.d_iterLabel.Size = New System.Drawing.Size(166, 12)
        Me.d_iterLabel.TabIndex = 6
        Me.d_iterLabel.Text = "Next Trun: Game not started"
        '
        'd_noteLabel
        '
        Me.d_noteLabel.Location = New System.Drawing.Point(752, 83)
        Me.d_noteLabel.Name = "d_noteLabel"
        Me.d_noteLabel.Size = New System.Drawing.Size(238, 41)
        Me.d_noteLabel.TabIndex = 8
        Me.d_noteLabel.Text = "Note: Graph will show the last result of budget allocation"
        '
        'd_displayPanel
        '
        Me.d_displayPanel.Location = New System.Drawing.Point(12, 12)
        Me.d_displayPanel.Name = "d_displayPanel"
        Me.d_displayPanel.Size = New System.Drawing.Size(734, 455)
        Me.d_displayPanel.TabIndex = 9
        '
        'd_totalBudgetLabel
        '
        Me.d_totalBudgetLabel.AutoSize = True
        Me.d_totalBudgetLabel.Location = New System.Drawing.Point(754, 124)
        Me.d_totalBudgetLabel.Name = "d_totalBudgetLabel"
        Me.d_totalBudgetLabel.Size = New System.Drawing.Size(104, 12)
        Me.d_totalBudgetLabel.TabIndex = 10
        Me.d_totalBudgetLabel.Text = "Total Budget Left:"
        '
        'd_totalBudgetValueLabel
        '
        Me.d_totalBudgetValueLabel.AutoSize = True
        Me.d_totalBudgetValueLabel.Location = New System.Drawing.Point(754, 149)
        Me.d_totalBudgetValueLabel.Name = "d_totalBudgetValueLabel"
        Me.d_totalBudgetValueLabel.Size = New System.Drawing.Size(11, 12)
        Me.d_totalBudgetValueLabel.TabIndex = 11
        Me.d_totalBudgetValueLabel.Text = "0"
        '
        'd_multiplierTextBox
        '
        Me.d_multiplierTextBox.Location = New System.Drawing.Point(754, 187)
        Me.d_multiplierTextBox.Name = "d_multiplierTextBox"
        Me.d_multiplierTextBox.Size = New System.Drawing.Size(236, 214)
        Me.d_multiplierTextBox.TabIndex = 12
        Me.d_multiplierTextBox.Text = "Multiplier:"
        '
        'd_difficultyLabel
        '
        Me.d_difficultyLabel.AutoSize = True
        Me.d_difficultyLabel.Location = New System.Drawing.Point(872, 124)
        Me.d_difficultyLabel.Name = "d_difficultyLabel"
        Me.d_difficultyLabel.Size = New System.Drawing.Size(56, 12)
        Me.d_difficultyLabel.TabIndex = 13
        Me.d_difficultyLabel.Text = "Difficulty:"
        '
        'd_difficultyValueLabel
        '
        Me.d_difficultyValueLabel.AutoSize = True
        Me.d_difficultyValueLabel.Location = New System.Drawing.Point(874, 149)
        Me.d_difficultyValueLabel.Name = "d_difficultyValueLabel"
        Me.d_difficultyValueLabel.Size = New System.Drawing.Size(67, 12)
        Me.d_difficultyValueLabel.TabIndex = 14
        Me.d_difficultyValueLabel.Text = "Not Started"
        '
        'SplashWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1002, 485)
        Me.Controls.Add(Me.d_difficultyValueLabel)
        Me.Controls.Add(Me.d_difficultyLabel)
        Me.Controls.Add(Me.d_multiplierTextBox)
        Me.Controls.Add(Me.d_totalBudgetValueLabel)
        Me.Controls.Add(Me.d_totalBudgetLabel)
        Me.Controls.Add(Me.d_displayPanel)
        Me.Controls.Add(Me.d_noteLabel)
        Me.Controls.Add(Me.d_iterLabel)
        Me.Controls.Add(Me.d_exitGameButton)
        Me.Controls.Add(Me.d_saveGameButton)
        Me.Controls.Add(Me.d_loadGameButton)
        Me.Controls.Add(Me.d_newGameButton)
        Me.Controls.Add(Me.d_indicatorButton)
        Me.Controls.Add(Me.d_budgetButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SplashWindow"
        Me.Text = "CS300 Ampla Project"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents d_budgetButton As System.Windows.Forms.Button
    Friend WithEvents d_indicatorButton As System.Windows.Forms.Button
    Friend WithEvents d_newGameButton As System.Windows.Forms.Button
    Friend WithEvents d_loadGameButton As System.Windows.Forms.Button
    Friend WithEvents d_saveGameButton As System.Windows.Forms.Button
    Friend WithEvents d_exitGameButton As System.Windows.Forms.Button
    Friend WithEvents d_iterLabel As System.Windows.Forms.Label
    Friend WithEvents d_noteLabel As System.Windows.Forms.Label
    Friend WithEvents d_displayPanel As System.Windows.Forms.Panel
    Friend WithEvents d_totalBudgetLabel As System.Windows.Forms.Label
    Friend WithEvents d_totalBudgetValueLabel As System.Windows.Forms.Label
    Friend WithEvents d_multiplierTextBox As System.Windows.Forms.Label
    Friend WithEvents d_difficultyLabel As System.Windows.Forms.Label
    Friend WithEvents d_difficultyValueLabel As System.Windows.Forms.Label

End Class
