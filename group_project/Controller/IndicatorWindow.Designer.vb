<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IndicatorWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IndicatorWindow))
        Me.d_displayPanel = New System.Windows.Forms.Panel()
        Me.d_closeButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'd_displayPanel
        '
        Me.d_displayPanel.Location = New System.Drawing.Point(13, 13)
        Me.d_displayPanel.Name = "d_displayPanel"
        Me.d_displayPanel.Size = New System.Drawing.Size(393, 231)
        Me.d_displayPanel.TabIndex = 0
        '
        'd_closeButton
        '
        Me.d_closeButton.BackColor = System.Drawing.SystemColors.Control
        Me.d_closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.d_closeButton.ForeColor = System.Drawing.Color.Black
        Me.d_closeButton.Location = New System.Drawing.Point(170, 267)
        Me.d_closeButton.Name = "d_closeButton"
        Me.d_closeButton.Size = New System.Drawing.Size(75, 23)
        Me.d_closeButton.TabIndex = 1
        Me.d_closeButton.Text = "Close"
        Me.d_closeButton.UseVisualStyleBackColor = False
        '
        'IndicatorWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(418, 316)
        Me.Controls.Add(Me.d_closeButton)
        Me.Controls.Add(Me.d_displayPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IndicatorWindow"
        Me.Text = "Current Planet Status"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents d_displayPanel As System.Windows.Forms.Panel
    Friend WithEvents d_closeButton As System.Windows.Forms.Button
End Class
