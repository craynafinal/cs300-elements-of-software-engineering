'Portland State University: CS300 Assignment 1
'Student: Jong Seong Lee
'This is an assignment to gain familiarity with Visual Basic. Very simple hellow world project.

Public Class Assignment1

    'Say 'Hello'! Button
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("Hello, World!", "Hi There!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    'Exit Button
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class
