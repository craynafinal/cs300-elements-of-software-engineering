Option Strict On
Option Explicit On

'Author: Jong Seong Lee
'Version: 1.3
'Date: 08/23/13
'Interface: Controller
'This class simply shows indicators calculated in world object.
Public Class IndicatorWindow
    Dim m_arr_txt() As String 'This is for labels for each indicator values
    Dim m_arr_value() As Double 'Numeric values of indicator information
    Dim m_arr_size As Integer 'Length of arrays
    Dim m_message As String 'A message that will appear above the indicator information

    'Setup array elements and members
    'Take a world parameter to get indicator information, and a message to be shown above the indicator
    Public Sub New(ByVal world As world, ByVal message As String)
        ' This call is required by the designer.
        InitializeComponent()

        'Array element setup
        m_arr_value = {world.environment_indicator, world.food_indicator, world.income_indicator, world.population_indicator}
        m_arr_size = m_arr_value.Length
        m_arr_txt = {"Environment", "Food", "Income", "Population"}

        'Message as a string object
        m_message = message

        'Print indicators
        showIndicators()
    End Sub

    'Dynamically prints indicators on this window
    Private Sub showIndicators()
        Dim arr_labels(m_arr_size) As Label
        Dim yLoc As Integer = 60
        Dim yspacing As Integer = 25
        Dim xleftSpace As Integer = 50

        Dim textMesssage As Label

        'Prints the message delivered at the top
        textMesssage = New Label
        textMesssage.Text = m_message
        textMesssage.Location = New Point(xleftSpace, yLoc)
        textMesssage.AutoSize = True
        d_displayPanel.Controls.Add(textMesssage)
        yLoc += textMesssage.Height + yspacing

        'Printing indicators in for loop
        For index = 0 To m_arr_size - 1
            'Set up each indicator label
            arr_labels(index) = New Label
            arr_labels(index).Text = m_arr_txt(index) & ": " & m_arr_value(index)
            arr_labels(index).Location = New Point(xleftSpace, yLoc)
            arr_labels(index).AutoSize = True
            d_displayPanel.Controls.Add(arr_labels(index))

            yLoc += yspacing
        Next index
    End Sub

    'Close button event handler, closes this application
    Private Sub d_closeButton_Click(sender As System.Object, e As System.EventArgs) Handles d_closeButton.Click
        Me.Close()
    End Sub
End Class