'CS300 - Jong Seong Lee
'Assignment 2
'This program will draw a graphic of hexagon grid. Each hexagon side length is 10, and the size of graphic area is 100 x 100.

Public Class frmMain

    Private Sub bExit_Click(sender As System.Object, e As System.EventArgs) Handles bExit.Click
        Me.Close()
    End Sub

    Private Sub bDrawGrid_Click(sender As System.Object, e As System.EventArgs) Handles bDrawGrid.Click
        Dim LineColr As Color = Color.Black
        Dim SideLength As Integer = 10
        Dim Graphic = Me.CreateGraphics()

        Dim HexGrid As New Cell(SideLength, LineColr, Graphic)
        HexGrid.DrawGrid(200, 200)
    End Sub

End Class