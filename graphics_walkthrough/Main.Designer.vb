<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.bDrawIt = New System.Windows.Forms.Button()
        Me.bExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bDrawIt
        '
        Me.bDrawIt.Location = New System.Drawing.Point(42, 405)
        Me.bDrawIt.Name = "bDrawIt"
        Me.bDrawIt.Size = New System.Drawing.Size(75, 23)
        Me.bDrawIt.TabIndex = 0
        Me.bDrawIt.Text = "Draw It!"
        Me.bDrawIt.UseVisualStyleBackColor = True
        '
        'bExit
        '
        Me.bExit.Location = New System.Drawing.Point(146, 405)
        Me.bExit.Name = "bExit"
        Me.bExit.Size = New System.Drawing.Size(75, 23)
        Me.bExit.TabIndex = 1
        Me.bExit.Text = "Exit"
        Me.bExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 457)
        Me.Controls.Add(Me.bExit)
        Me.Controls.Add(Me.bDrawIt)
        Me.Name = "frmMain"
        Me.Text = "CS300 Graphics Walkthrough"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bDrawIt As System.Windows.Forms.Button
    Friend WithEvents bExit As System.Windows.Forms.Button

End Class
