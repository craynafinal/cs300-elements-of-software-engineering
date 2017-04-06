'CS300 Assignment3: Jong Seong Lee
'This is designed run as a simple notepad program.

Imports System.IO

Public Class frmEditor

    Public fileName As String 'file name

    'exit button
    Private Sub bExit_Click(sender As System.Object, e As System.EventArgs) Handles bExit.Click
        closeForm()
    End Sub

    'open button
    Private Sub bOpen_Click(sender As System.Object, e As System.EventArgs) Handles bOpen.Click
        'check if changes made before opening another file
        If (rtbEditor.Modified = True) Then
            Select Case MsgBox("Save before loading another file?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Save Changes")
                Case MsgBoxResult.Yes
                    saveFile()
            End Select
        End If
        loadFile()
    End Sub

    'save button
    Private Sub bSave_Click(sender As System.Object, e As System.EventArgs) Handles bSave.Click
        saveFile()
    End Sub

    'handles close button at the top
    Private Sub closeButton(sender As System.Object, e As System.EventArgs) Handles Me.FormClosing
        'closeForm()
    End Sub

    'loads file
    Private Sub loadFile()
        Dim ofd As New OpenFileDialog()
        Dim filePath As String

        ofd.DefaultExt = "*.txt"
        ofd.Filter = "txt files (*.txt)|*.txt" 'file extension filter setup

        If (ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK) And (ofd.FileName.Length > 0) Then 'if a user did not hit the cancel button on the file dialog
            filePath = ofd.FileName
            fileName = Path.GetFileName(filePath)
            rtbEditor.LoadFile(filePath, RichTextBoxStreamType.PlainText)
            notModified()
        End If
    End Sub

    'saves file
    Public Sub saveFile()
        Dim sfd As New SaveFileDialog()

        sfd.DefaultExt = "*.txt"
        sfd.Filter = "txt files (*.txt)|*.txt" 'file extension filter setup
        sfd.FileName = fileName

        If Not (IsNothing(fileName)) Then
            sfdSaveFile.FileName = fileName 'get loaded file name if it exists
        End If

        If (sfd.ShowDialog() = System.Windows.Forms.DialogResult.OK) And (sfd.FileName.Length > 0) Then
            rtbEditor.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText)
            notModified()
        End If
    End Sub

    'sets up initial state when loaded or saved
    Private Sub notModified()
        rtbEditor.Modified = False
    End Sub

    'show popup window to ask saving file
    Private Sub saveNotifier()
        'open another form
        Dim frmExit As Form
        frmExit = New frmSaveBeforeExit()
        frmExit.Show()
        frmExit = Nothing
    End Sub

    'closes form or display a popup
    Private Sub closeForm()
        If (rtbEditor.Modified = True) Then
            saveNotifier()
        Else
            Me.Close()
        End If
    End Sub

End Class
