Imports System.Drawing

Public Class Cell
    Dim LLC As Point
    Dim LineColor As Color
    Dim Gr As Graphics
    Dim SideLength As Integer

    Sub New(Lower_Left_Corner As Point, Side_Length As Integer, Line_Color As Color, FG As Form)
        LLC = New Point(Lower_Left_Corner.X, Lower_Left_Corner.Y)
        LineColor = Line_Color
        SideLength = Side_Length
        Gr = FG.CreateGraphics()
    End Sub

    Sub DrawCell()
        Dim P As New Pen(LineColor)

        Dim ULC As New Point(LLC.X, LLC.Y + SideLength)
        Dim URC As New Point(LLC.X + SideLength, LLC.Y + SideLength)
        Dim LRC As New Point(LLC.X + SideLength, LLC.Y)

        With Gr
            .DrawLine(P, LLC, ULC)
            .DrawLine(P, ULC, URC)
            .DrawLine(P, URC, LRC)
            .DrawLine(P, LRC, LLC)
        End With

    End Sub

End Class
