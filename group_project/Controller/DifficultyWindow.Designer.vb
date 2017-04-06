<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DifficultyWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DifficultyWindow))
        Me.d_confirmButton = New System.Windows.Forms.Button()
        Me.d_cancelButton = New System.Windows.Forms.Button()
        Me.d_switchButton = New System.Windows.Forms.Button()
        Me.d_displayPanel = New System.Windows.Forms.Panel()
        Me.d_advancedPanel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'd_confirmButton
        '
        Me.d_confirmButton.BackColor = System.Drawing.SystemColors.Control
        Me.d_confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d_confirmButton.Location = New System.Drawing.Point(220, 238)
        Me.d_confirmButton.Name = "d_confirmButton"
        Me.d_confirmButton.Size = New System.Drawing.Size(75, 23)
        Me.d_confirmButton.TabIndex = 0
        Me.d_confirmButton.Text = "Confirm"
        Me.d_confirmButton.UseVisualStyleBackColor = False
        '
        'd_cancelButton
        '
        Me.d_cancelButton.BackColor = System.Drawing.SystemColors.Control
        Me.d_cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d_cancelButton.Location = New System.Drawing.Point(311, 238)
        Me.d_cancelButton.Name = "d_cancelButton"
        Me.d_cancelButton.Size = New System.Drawing.Size(75, 23)
        Me.d_cancelButton.TabIndex = 1
        Me.d_cancelButton.Text = "Cancel"
        Me.d_cancelButton.UseVisualStyleBackColor = False
        '
        'd_switchButton
        '
        Me.d_switchButton.BackColor = System.Drawing.Color.Tomato
        Me.d_switchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d_switchButton.Location = New System.Drawing.Point(24, 238)
        Me.d_switchButton.Name = "d_switchButton"
        Me.d_switchButton.Size = New System.Drawing.Size(75, 23)
        Me.d_switchButton.TabIndex = 3
        Me.d_switchButton.Text = "Advanced"
        Me.d_switchButton.UseVisualStyleBackColor = False
        '
        'd_displayPanel
        '
        Me.d_displayPanel.Location = New System.Drawing.Point(24, 13)
        Me.d_displayPanel.Name = "d_displayPanel"
        Me.d_displayPanel.Size = New System.Drawing.Size(360, 115)
        Me.d_displayPanel.TabIndex = 4
        '
        'd_advancedPanel
        '
        Me.d_advancedPanel.Location = New System.Drawing.Point(26, 145)
        Me.d_advancedPanel.Name = "d_advancedPanel"
        Me.d_advancedPanel.Size = New System.Drawing.Size(360, 77)
        Me.d_advancedPanel.TabIndex = 5
        '
        'DifficultyWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(411, 283)
        Me.Controls.Add(Me.d_advancedPanel)
        Me.Controls.Add(Me.d_displayPanel)
        Me.Controls.Add(Me.d_switchButton)
        Me.Controls.Add(Me.d_cancelButton)
        Me.Controls.Add(Me.d_confirmButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DifficultyWindow"
        Me.Text = "Select Difficulty"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents d_confirmButton As System.Windows.Forms.Button
    Friend WithEvents d_cancelButton As System.Windows.Forms.Button
    Friend WithEvents d_switchButton As System.Windows.Forms.Button
    Friend WithEvents d_displayPanel As System.Windows.Forms.Panel
    Friend WithEvents d_advancedPanel As System.Windows.Forms.Panel
End Class
