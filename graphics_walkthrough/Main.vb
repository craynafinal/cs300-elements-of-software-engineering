Imports System.Drawing

Public Class frmMain

    Private Sub bDrawIt_Click(sender As System.Object, e As System.EventArgs) Handles bDrawIt.Click
        Dim Pt As New Point(20, 20)
        Dim Cir As Color = Color.AliceBlue

        Dim Gr As Graphics = Me.CreateGraphics()

        Dim BndBox As Integer = 300

        Dim LLC As New Point(0, 0)
        Dim ULC As New Point(0, BndBox)
        Dim URC As New Point(BndBox, BndBox)
        Dim LRC As New Point(BndBox, 0)

        'Gr.DrawLines(
        Dim P As New Pen(Brushes.Red) 'pen

        With Gr
            .DrawLine(P, LLC, ULC)
            .DrawLine(P, ULC, URC)
            .DrawLine(P, URC, LRC)
            .DrawLine(P, LRC, LLC)
        End With

        Dim Square As New Cell(New Point(105, 15), 20, Color.Black, Me)

        Square.DrawCell()

        Dim SL, X, Y As Integer

        SL = 10
        P = New Pen(Color.Blue)
        For X = 0 To (BndBox - SL) Step SL
            For Y = 0 To (BndBox - SL) Step SL
                Square = New Cell(New Point(X, Y), SL, Color.Blue, Me)
                Square.DrawCell()
            Next
        Next

    End Sub
    Private Sub bExit_Click(sender As System.Object, e As System.EventArgs) Handles bExit.Click
        Me.Close()
    End Sub
End Class
