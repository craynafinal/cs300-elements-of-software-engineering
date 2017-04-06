<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaveBeforeExit
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
        Me.bSave = New System.Windows.Forms.Button()
        Me.bNoSave = New System.Windows.Forms.Button()
        Me.bCancel = New System.Windows.Forms.Button()
        Me.pDisplayTxt = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'bSave
        '
        Me.bSave.Location = New System.Drawing.Point(35, 207)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(75, 23)
        Me.bSave.TabIndex = 0
        Me.bSave.Text = "Save"
        Me.bSave.UseVisualStyleBackColor = True
        '
        'bNoSave
        '
        Me.bNoSave.Location = New System.Drawing.Point(129, 206)
        Me.bNoSave.Name = "bNoSave"
        Me.bNoSave.Size = New System.Drawing.Size(75, 23)
        Me.bNoSave.TabIndex = 1
        Me.bNoSave.Text = "Don't Save"
        Me.bNoSave.UseVisualStyleBackColor = True
        '
        'bCancel
        '
        Me.bCancel.Location = New System.Drawing.Point(252, 207)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Size = New System.Drawing.Size(79, 23)
        Me.bCancel.TabIndex = 2
        Me.bCancel.Text = "Cancel Exit"
        Me.bCancel.UseVisualStyleBackColor = True
        '
        'pDisplayTxt
        '
        Me.pDisplayTxt.Location = New System.Drawing.Point(35, 30)
        Me.pDisplayTxt.Name = "pDisplayTxt"
        Me.pDisplayTxt.Size = New System.Drawing.Size(296, 148)
        Me.pDisplayTxt.TabIndex = 3
        '
        'frmSaveBeforeExit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 262)
        Me.Controls.Add(Me.pDisplayTxt)
        Me.Controls.Add(Me.bCancel)
        Me.Controls.Add(Me.bNoSave)
        Me.Controls.Add(Me.bSave)
        Me.Name = "frmSaveBeforeExit"
        Me.Text = "Save File Before Exit?"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bSave As System.Windows.Forms.Button
    Friend WithEvents bNoSave As System.Windows.Forms.Button
    Friend WithEvents bCancel As System.Windows.Forms.Button
    Friend WithEvents pDisplayTxt As System.Windows.Forms.Panel
End Class
