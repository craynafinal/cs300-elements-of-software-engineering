Option Strict On
Option Explicit On

'Author: Jong Seong Lee
'Version: 1.2
'Date: 08/23/13
'Interface: Controller
'This windows application form will ask a user to set difficulty.
Public Class DifficultyWindow
    Dim m_isAdvanced As Boolean 'Determines if a user is in advanced mode or not
    Dim m_difficulty As Integer 'Final difficulty value
    Dim m_numeric As NumericUpDown 'This is for advanced difficulty setting
    Dim m_advanced As Integer 'Used for advanced setting of world class

    'Some attributes for normal difficulty setting window
    Dim m_arr_labelTxt As String() 'Each Label
    Dim m_arr_result As Integer() 'Difficulty level for each easy, normal, difficult
    Dim m_arr_radio() As RadioButton 'Radio button selections for easy, normal, and difficult
    Dim m_arr_size As Integer 'The size of array

    'This property determines if a user set advanced value
    'True if he/she did, false otherwise
    Public ReadOnly Property Is_Advanced As Boolean
        Get
            Is_Advanced = m_isAdvanced
        End Get
    End Property

    'This is the value that a user selected as an advanced multiplier, default = -1
    Public ReadOnly Property Advanced As Integer
        Get
            Advanced = m_advanced
        End Get
    End Property

    'This is the value of difficulty chosen by a user
    Public ReadOnly Property Difficulty As Integer
        Get
            Difficulty = m_difficulty
        End Get
    End Property

    'Setup member attributes, no parameters
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        'Setup each array elements
        m_arr_labelTxt = {"Easy", "Normal", "Difficult"}
        m_arr_result = {1, 3, 5}
        m_arr_size = m_arr_labelTxt.Length
        ReDim m_arr_radio(m_arr_size)

        'Setup other attributes
        m_difficulty = -1
        m_isAdvanced = False
        m_advanced = 1

        'Displays default difficulty setting interface when it is loaded
        showDefault()
    End Sub

    'Show default difficulty setting user interface
    Private Sub showDefault()

        'Setup attributes
        Dim xRadio As Integer = 100
        Dim xLabel As Integer = 20
        Dim yLoc As Integer = 30
        Dim yIncr As Integer = 25

        'Printing radio buttons and text in for loop
        For index = 0 To m_arr_size - 1
            'Setup each radio button
            m_arr_radio(index) = New RadioButton
            m_arr_radio(index).Location = New Point(xRadio, yLoc)
            m_arr_radio(index).AutoSize = True
            d_displayPanel.Controls.Add(m_arr_radio(index))

            'Setup each label
            Dim labels As New Label
            labels.Text = m_arr_labelTxt(index)
            labels.AutoSize = True
            labels.Location = New Point(xLabel, yLoc)
            d_displayPanel.Controls.Add(labels)

            yLoc += yIncr
        Next index
    End Sub

    'Show advanced difficulty setting user interface
    Private Sub showAdvanced()

        Dim min As Integer = 1 'Minimum multiplier
        Dim max As Integer = 10 'Maximum multiplier

        'Setup difficulty selector
        m_numeric = New NumericUpDown
        m_numeric.Value = min
        m_numeric.Minimum = min
        m_numeric.Maximum = max
        m_numeric.Location = New Point(0, 0)
        d_advancedPanel.Controls.Add(m_numeric)

        Dim messagelabel As Label = New Label
        messagelabel.Text = "This will multiply indicator values of the planet!"
        messagelabel.AutoSize = True
        messagelabel.Location = New Point(0, 40)
        d_advancedPanel.Controls.Add(messagelabel)
    End Sub

    'Gets the final result from user selection and return it
    'Returns -1 if nothing selected in default mode
    Private Function setResult() As Integer
        Dim ret As Integer = -1

        Dim index As Integer = 0
        Dim found As Boolean = False

        While (index < m_arr_size) And (found = False)
            Dim radio As RadioButton = m_arr_radio(index)
            If (radio.Checked = True) Then 'If this is selected, get this value as the final result
                ret = m_arr_result(index)
                found = True
            End If
            index += 1
        End While

        If (m_isAdvanced = True) Then 'If a user chose to have advanced multiplier, set the advanced result value
            m_advanced = CInt(m_numeric.Value)
        Else
            m_advanced = 1
        End If

        Return ret
    End Function

    'Switches text on the button that changes its interface mode
    Private Sub switchButtonTxt()
        If StrComp(d_switchButton.Text, "Advanced") = 0 Then
            d_switchButton.Text = "Hide"
        Else
            d_switchButton.Text = "Advanced"
        End If
    End Sub

    'Checks if user selected a difficulty and gets the final result, and close the windows.
    'Shows an error message otherwise
    Private Sub d_confirmButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d_confirmButton.Click
        m_difficulty = setResult()
        If (m_difficulty >= 0) Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MsgBox("You did not select the difficulty!")
        End If
    End Sub

    'Cancels selecting difficulty
    Private Sub d_cancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d_cancelButton.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    'Switches the difficulty setting user interface mode
    Private Sub d_switchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d_switchButton.Click
        If (m_isAdvanced = False) Then
            switchButtonTxt()
            showAdvanced()
            m_isAdvanced = True 'No longer in default mode
        Else
            d_advancedPanel.Controls.Clear()
            switchButtonTxt()
            m_isAdvanced = False 'No longer in advanced mode
        End If
    End Sub
End Class