<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditor
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
        Me.bOpen = New System.Windows.Forms.Button()
        Me.bSave = New System.Windows.Forms.Button()
        Me.bExit = New System.Windows.Forms.Button()
        Me.rtbEditor = New System.Windows.Forms.RichTextBox()
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSaveFile = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'bOpen
        '
        Me.bOpen.Location = New System.Drawing.Point(53, 461)
        Me.bOpen.Name = "bOpen"
        Me.bOpen.Size = New System.Drawing.Size(75, 23)
        Me.bOpen.TabIndex = 0
        Me.bOpen.Text = "Open File"
        Me.bOpen.UseVisualStyleBackColor = True
        '
        'bSave
        '
        Me.bSave.Location = New System.Drawing.Point(153, 461)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(75, 23)
        Me.bSave.TabIndex = 1
        Me.bSave.Text = "Save File"
        Me.bSave.UseVisualStyleBackColor = True
        '
        'bExit
        '
        Me.bExit.Location = New System.Drawing.Point(499, 461)
        Me.bExit.Name = "bExit"
        Me.bExit.Size = New System.Drawing.Size(75, 23)
        Me.bExit.TabIndex = 2
        Me.bExit.Text = "Exit"
        Me.bExit.UseVisualStyleBackColor = True
        '
        'rtbEditor
        '
        Me.rtbEditor.Location = New System.Drawing.Point(53, 31)
        Me.rtbEditor.Name = "rtbEditor"
        Me.rtbEditor.Size = New System.Drawing.Size(521, 398)
        Me.rtbEditor.TabIndex = 3
        Me.rtbEditor.Text = ""
        '
        'ofdOpenFile
        '
        Me.ofdOpenFile.Title = "Open File"
        '
        'sfdSaveFile
        '
        Me.sfdSaveFile.Title = "Save File"
        '
        'frmEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 508)
        Me.Controls.Add(Me.rtbEditor)
        Me.Controls.Add(Me.bExit)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(Me.bOpen)
        Me.Name = "frmEditor"
        Me.Text = "CS300 Simple Editor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bOpen As System.Windows.Forms.Button
    Friend WithEvents bSave As System.Windows.Forms.Button
    Friend WithEvents bExit As System.Windows.Forms.Button
    Friend WithEvents rtbEditor As System.Windows.Forms.RichTextBox
    Friend WithEvents ofdOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdSaveFile As System.Windows.Forms.SaveFileDialog

End Class
