'This class allows a user to draw a graphic of hexagon grid.

Public Class Cell

    Dim SideLength As Integer

    Dim OppLength As Integer 'A side (opposite) length
    Dim AdjLength As Integer 'B side (adjacent) length
    Dim HypLength As Integer 'C side (hypotenuse) length

    Dim LineColor As Color
    Dim Gr As Graphics

    Sub New(ByVal Side_Length As Integer, ByVal Line_Color As Color, ByVal FG As Graphics)
        SideLength = Side_Length
        LineColor = Line_Color
        Gr = FG
        CalculateAttributes(SideLength) 'Calculate Sin Formulas
    End Sub

    Private Sub CalculateAttributes(ByVal Side_Length As Integer)
        HypLength = Side_Length
        OppLength = HypLength * Math.Sin(Math.PI / 6)
        AdjLength = HypLength * Math.Sin(Math.PI / 3)
    End Sub

    Private Sub DrawCell(ByVal Origin As Point)
        Dim P As New Pen(LineColor)
        Dim OriginX = Origin.X
        Dim OriginY = Origin.Y

        Dim TM As New Point(OriginX + AdjLength, OriginY) 'Top Middle
        Dim UL As New Point(OriginX, OriginY + OppLength) 'Upper Left
        Dim LL As New Point(OriginX, OriginY + OppLength + HypLength) 'Lower Left
        Dim BM As New Point(OriginX + AdjLength, OriginY + (2 * OppLength) + HypLength) 'Bottom Middle
        Dim LR As New Point(OriginX + (2 * AdjLength), OriginY + OppLength + HypLength) 'Lower Right
        Dim UR As New Point(OriginX + (2 * AdjLength), OriginY + OppLength) 'Upper Right

        With Gr
            .DrawLine(P, TM, UL)
            .DrawLine(P, UL, LL)
            .DrawLine(P, LL, BM)
            .DrawLine(P, BM, LR)
            .DrawLine(P, LR, UR)
            .DrawLine(P, UR, TM)
        End With
    End Sub

    Sub DrawGrid(ByVal Rectangle_Width As Integer, ByVal Rectangle_Height As Integer)

        'Clip Properties
        Dim Rect As Rectangle
        Rect.X = SideLength / 2
        Rect.Y = SideLength / 2
        Rect.Width = Rectangle_Width
        Rect.Height = Rectangle_Height
        Gr.SetClip(Rect)

        'Index
        Dim X, Y, Index As Integer
        Dim YGoNext = SideLength + (2 * HypLength)
        Dim YStart As Integer
        Dim OddCase As Integer = HypLength + OppLength

        Index = 0

        For X = 0 To (Rect.X + Rect.Width) Step AdjLength
            'If statement sets start value of Y coordinate
            If (Index Mod 2) = 0 Then
                YStart = 0
            Else
                YStart = OddCase
            End If

            For Y = YStart To (Rect.Y + Rect.Height) Step YGoNext
                DrawCell(New Point(X, Y))
            Next Y

            Index += 1
        Next X
    End Sub

End Class
