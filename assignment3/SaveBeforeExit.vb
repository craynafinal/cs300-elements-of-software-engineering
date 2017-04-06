'This form asks if a user wants to save file before exit.

Public Class frmSaveBeforeExit

    'cancel button
    Private Sub bCancel_Click(sender As System.Object, e As System.EventArgs) Handles bCancel.Click
        Me.Close()
    End Sub

    'no save button, terminates this program
    Private Sub bNoSave_Click(sender As System.Object, e As System.EventArgs) Handles bNoSave.Click
        frmEditor.Close()
        Me.Close()
    End Sub

    'save button, after save, this popup will be closed
    Private Sub bSave_Click(sender As System.Object, e As System.EventArgs) Handles bSave.Click
        frmEditor.saveFile()
        If (frmEditor.rtbEditor.Modified = False) Then
            Me.Close()
        End If
    End Sub

    Private Sub pDisplayTxt_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pDisplayTxt.Paint
        Dim fileName As String = frmEditor.fileName

        If fileName = "" Then
            fileName = "No name"
        End If

        Dim txtStringTop As String = "There are unsaved changes in file: "
        Dim txtStringBottom = "Save file before exiting?"
        Dim graphic As Graphics = pDisplayTxt.CreateGraphics
        Dim fontRegular As New Font(frmSaveBeforeExit.DefaultFont, Drawing.FontStyle.Regular)
        Dim fontBold As New Font(frmSaveBeforeExit.DefaultFont, Drawing.FontStyle.Bold)

        graphic.DrawString(txtStringTop, fontRegular, Brushes.Black, New Point(0, 0))
        graphic.DrawString(fileName, fontBold, Brushes.Red, New Point(24, 36))
        graphic.DrawString(txtStringBottom, fontRegular, Brushes.Black, New Point(0, 72))
    End Sub

End Class