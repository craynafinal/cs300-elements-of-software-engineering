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
        Me.bDrawGrid = New System.Windows.Forms.Button()
        Me.bExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bDrawGrid
        '
        Me.bDrawGrid.Location = New System.Drawing.Point(36, 274)
        Me.bDrawGrid.Name = "bDrawGrid"
        Me.bDrawGrid.Size = New System.Drawing.Size(75, 23)
        Me.bDrawGrid.TabIndex = 0
        Me.bDrawGrid.Text = "Draw Grid"
        Me.bDrawGrid.UseVisualStyleBackColor = True
        '
        'bExit
        '
        Me.bExit.Location = New System.Drawing.Point(132, 274)
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
        Me.ClientSize = New System.Drawing.Size(249, 318)
        Me.Controls.Add(Me.bExit)
        Me.Controls.Add(Me.bDrawGrid)
        Me.Name = "frmMain"
        Me.Text = "CS300 Assignment2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bDrawGrid As System.Windows.Forms.Button
    Friend WithEvents bExit As System.Windows.Forms.Button

End Class
