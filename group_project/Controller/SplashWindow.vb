Option Strict On
Option Explicit On

Imports System.Text

'Author: Jong Seong Lee
'Version: 1.1
'Date: 08/23/13
'Interface: Controller
'This is main windows application that will manipulate other subsystems of controller and two other interfaces, model and view.
Public Class SplashWindow
    'System related attributes
    Dim m_fileContrller As FileController 'Helps saving and loading
    Dim m_panelGraphic As Graphics 'Graphic area for view

    'Model and View Interfaces
    Dim m_view As View 'Graphic interface
    Dim m_budgetManager As budget_manager 'Budget handler
    Dim m_world As world 'Planet status

    'Tracking attributes
    Dim m_isOver As Boolean 'Determines if the game has ended
    Dim m_hasBegun As Boolean 'Determines if the game has ever begun
    Dim m_saved As Boolean 'Determines if the game state is saved, becomes false after budget alloc

    'Graphic related
    Private m_introImg As Bitmap 'Saves intro graphic
    Dim m_color As Color 'Color used to clear graphic space

    Dim m_paintStatus As Integer 'Determines which graphic to be kept on the screen
    '0 = Intro Graphic
    '1 = Environment Graphic
    '2 = Final Graphic
    'Any other number will not display anything on the splash window

    'Consts - Dimension related
    Private Const GRAPHIC_SIZE_X As Integer = 734
    Private Const GRAPHIC_SIZE_Y As Integer = 449
    Private Const GRAPHIC_LOC_X As Integer = 0
    Private Const GRAPHIC_LOC_Y As Integer = 0

    'Const - Graphic Related
    Private Const CELL_SIZE_LENGTH As Integer = 2

    'Does not take any parameters, Initializes member attributes
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        'Setup trackers
        m_isOver = True
        m_hasBegun = False
        m_saved = True

        m_fileContrller = New FileController

        'Model and View interfaces to be nothing, they will be initialized when a new game starts or loading
        m_budgetManager = Nothing
        m_world = Nothing
        m_view = Nothing

        'Setup graphic attributes
        m_color = Color.White 'This color is going to be used to clear graphic area
        m_panelGraphic = d_displayPanel.CreateGraphics() 'Setup graphics variable

        'Intro graphic
        m_introImg = New Bitmap("imgs\graphic_intro.jpg") 'The file is in the debug folder
        bringGraphic() 'Draw intro graphic
    End Sub

    'Handles a click event of load button, runs difficulty setting if loadgame is successful
    Private Sub d_loadGameButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d_loadGameButton.Click
        If loadGame() = True And m_isOver = False Then
            If (difficultySetting() = True) Then
                MsgBox("Your difficulty was changed successfully!")
            Else
                MsgBox("Your difficulty has not changed!")
            End If
        End If
    End Sub

    'Opens up a difficulty setting window and setup difficulty
    Private Function difficultySetting() As Boolean
        Dim ret As Boolean = False

        'Asks a user if he/she wants to change difficulty setting
        Dim result As MsgBoxResult = MsgBox("Would you like to change the difficulty of your game?", MsgBoxStyle.YesNo, "Change Difficulty?")

        'If a user wants to change the difficulty
        If (result = MsgBoxResult.Yes) Then

            Dim difficultyWindow As New DifficultyWindow
            Dim diffcultyResult As DialogResult = difficultyWindow.ShowDialog() 'Runs DifficultyWindow application

            'If a user confirmed the new difficulty, and successfully obtained the result
            If (diffcultyResult = Windows.Forms.DialogResult.OK) And (difficultyWindow.Difficulty > 0) Then

                Dim difficulty As Integer = difficultyWindow.Difficulty 'Get the difficulty result
                m_world.Change_Difficulty(difficulty) 'The world object accepts the new difficulty
                m_view.ChangeDifficulty(difficulty, New Size(GRAPHIC_SIZE_X, GRAPHIC_SIZE_Y), New Point(GRAPHIC_LOC_X, GRAPHIC_LOC_Y)) 'Change difficulty of view

                If (difficultyWindow.Is_Advanced = True) Then 'If a user wanted advanced setting
                    m_world.Change_Multiplier(difficultyWindow.Advanced)
                End If

                updateMultipliers() 'Update multipliers shown on the splash page
                displayDifficulty() 'Update difficulty

                ret = True
            End If
        End If

        Return ret
    End Function

    'Load a file to obtain values in a previous game
    'Return true if loading was successful, false otherwise
    'Handles exception when loading is not successful, if this happens, it will ask again to choose a file
    Private Function loadGame() As Boolean
        'To follow the use case provided, it will be asking the question for saving after a user selects a file to load.
        'New game, save game, and exit game process will be asking for save first before their action.

        Dim ret As Boolean = False
        Dim whileCheck As Boolean = False

        While whileCheck = False
            Dim file As File = m_fileContrller.load()

            If (Not file Is Nothing) Then 'If file is selected from dialog

                If (saveChanges() = True) Then 'Yes or no in the save changes dialog
                    Try 'This will examine if file is corrupted or invalid.

                        'Initialize model objects
                        m_world = New world(file.World)

                        m_budgetManager = New budget_manager(file.BudgetManager)
                        m_view = New View(New Size(GRAPHIC_SIZE_X, GRAPHIC_SIZE_Y), New Point(GRAPHIC_LOC_X, GRAPHIC_LOC_Y), m_world.difficulty, _
                                          CELL_SIZE_LENGTH, file.PointArray)

                        'Setup checker variables
                        loadSetupCheckers()
                        iterUpdate()

                        'Setup view object and prepare for the display
                        m_view.takeResult(m_world) 'Send the result to the view object
                        m_panelGraphic = d_displayPanel.CreateGraphics() 'Get rid of the last graphic and start a new one
                        bringGraphic()

                        'Checkers
                        ret = True
                        whileCheck = True

                        MsgBox("File load was successful!")

                        updateUnallocBudget() 'Update unallocated budget shown on the splash window
                        updateMultipliers() 'Update multipliers shown on the splash window
                        displayDifficulty() 'Display difficulty

                    Catch ex As Exception
                        MsgBox("File must be corrupted or invalid. Please choose another file!")
                    End Try
                Else
                    whileCheck = True 'If a user cancels on the save changes dialog
                End If
            Else
                whileCheck = True 'When file is not delivered or a user does not want to save the current game status
            End If
        End While

        If ret = False Then 'If load was failed, print an error message
            MsgBox("File load has failed!")
        End If

        Return ret
    End Function

    'This will setup some tracking member attributes when loading game is successful
    Private Sub loadSetupCheckers()
        m_saved = True 'Not going to ask for saving right away
        m_hasBegun = True 'User were able to save once the game has begun

        Dim iter As Integer = m_budgetManager.current_turn

        If (iter >= 0) And (iter <= m_budgetManager.NUM_TURNS) Then 'Determines if game is over depends on the iteration value
            m_isOver = False
        Else
            m_isOver = True
        End If
    End Sub

    'Handles the save button click event
    Private Sub d_saveGameButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d_saveGameButton.Click
        saveGame()
    End Sub

    'Saves the current state
    'Returns true if successful, false otherwise
    Private Function saveGame() As Boolean
        Dim ret As Boolean = False

        If (m_hasBegun = False) Then 'If game has not started yet
            MsgBox("Please start a game before you save!")
        Else
            Dim file As File = New File(m_world, m_budgetManager, m_view.mines) 'Create a new file

            If (m_fileContrller.save(file) = True) Then 'Save file here
                m_saved = True
                ret = True
                MsgBox("File Save was successful!")
            Else
                MsgBox("File Save has failed!")
            End If
        End If

        Return ret
    End Function

    'Handles event of the exit game button
    Private Sub d_exitGameButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d_exitGameButton.Click
        If (saveChanges() = True) Then 'Asks if a user wants to save the current state if not saved
            Me.Close()
        End If
    End Sub

    'Asks a user if he/she wants to save current state of the game
    'Returns false if user clicks on the cancel button or cancel file dialog; true otherwise
    Private Function saveChanges() As Boolean
        Dim ret As Boolean = True

        If (m_saved = False) Then 'If this game is not saved
            Dim msgBoxResult As MsgBoxResult = MsgBox("Would you like to save changes?", MsgBoxStyle.YesNoCancel, "Save Changes")
            If (msgBoxResult = msgBoxResult.Yes) Then
                ret = saveGame()
            ElseIf (msgBoxResult = Microsoft.VisualBasic.MsgBoxResult.Cancel) Then
                ret = False
            End If
        End If

        Return ret
    End Function

    'Handles event of the bugdget allocation button
    Private Sub d_budgetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d_budgetButton.Click
        openBudgetWindow()
    End Sub

    'Opens a new budget window and takes care of the result
    Private Function openBudgetWindow() As Boolean
        Dim ret As Boolean = False

        If (m_hasBegun = True) And (m_isOver = False) Then

            Dim budgetWindow As New BudgetWindow(m_budgetManager.Get_Previous_Budget, m_budgetManager.BUDGET_PER_CYCLE)
            budgetWindow.ShowDialog()

            If (budgetWindow.DialogResult = Windows.Forms.DialogResult.OK) Then 'If a user has allocated budgets successfully
                If (budgetResult(budgetWindow.Budget_Result) = True) Then 'Result taken cared here
                    m_saved = False
                    ret = True
                End If
            End If
        Else
            MsgBox("Your game may not be started or already finished! Please start a new game or load a previous game")
        End If

        Return ret
    End Function

    'Takes care of budget result given by a user. Let the buget calculated, send this calculation to the view and draw graphic
    'Returns true if successful, false otherwise
    Private Function budgetResult(ByVal newBudget As budget) As Boolean
        Dim ret As Boolean = False
        Dim result_budget As Integer = m_budgetManager.Submit_Budget(m_world, newBudget)
        m_world.Show_Warnings()

        If (m_world.Show_Failure()) Then
            MsgBox("Game Over! You have not successfully managed the Ampla planet. Please try another game to continue your journey.")
            m_isOver = True
        Else
            If (result_budget = 0 Or result_budget = 2) Then
                m_view.takeResult(m_world) 'Send the result to the view object
                bringGraphic() 'Draw graph
                updateUnallocBudget() 'Update unallocated budget amount
                ret = True
            End If

            If ret = True Then
                MsgBox("Budget allocation was done successfully!")
            Else
                MsgBox("Budget allocation has failed!")
            End If
        End If

        iterUpdate()

        Return ret
    End Function

    'Handles the indicators button click event
    Private Sub d_indicatorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d_indicatorButton.Click
        showIndicatorsWindow("The following is the current status of your planet.")
    End Sub

    'Draws a graphic based on a budget result on the splash page
    Private Sub bringGraphic()
        m_panelGraphic.Clear(m_color)

        If (m_hasBegun = True) Then
            Dim iter As Integer = m_budgetManager.current_turn
            Dim max As Integer = m_budgetManager.NUM_TURNS

            If (iter > 0) And (iter <= max) Then 'Draws normal graphic
                updateGraphicMode(1) 'Environment Graphic

            ElseIf (iter > max) Then 'If the view delivers separate function, can use final graphic with event handler
                updateGraphicMode(2) 'Final Graphic
                m_view.drawChart(m_budgetManager)
            Else
                MsgBox("Unexpected error occured! This game is be terminated. Please try again.")
                m_isOver = True
            End If

        Else 'If haven't started yet, draw intro graphic
            updateGraphicMode(0)
        End If
        
    End Sub

    'Take unallocated budget from the budget manager and display on the splash page
    Private Sub updateUnallocBudget()
        d_totalBudgetValueLabel.Text = (m_budgetManager.Calculate_Remaining_Funds()).ToString
    End Sub

    'Get multipliers used for calculation from world and display on the splash page
    Private Sub updateMultipliers()
        Dim coff As Object() = m_world.Get_Model_Coefficients()
        Dim coff_next As Double()
        Dim coff_size As Integer = coff.Length

        Dim title As String() = {"Food Rates Multiplier:", "Income Rates Multiplier:", "Population Multiplier:", "Environment Multiplier:"}
        Dim sb As StringBuilder = New StringBuilder

        For index = 0 To coff_size - 1
            sb.Append(title(index))
            coff_next = CType(coff(index), Double())

            sb.Append((coff_next(0)).ToString("F")) 'append the first one

            For Each eachCategory As Double In coff_next
                sb.Append(", " & (eachCategory).ToString("F"))
            Next

            sb.Append(vbCrLf)
        Next index

        d_multiplierTextBox.Text = sb.ToString 'Send all the result

    End Sub

    'Create a new indicator window and display it on the screen
    'Note: The automatic final indicator information will be handled in view, this one is just passive popup
    Private Function showIndicatorsWindow(ByVal message As String) As Boolean
        Dim ret As Boolean = False

        If (m_hasBegun = True) Then 'If this game is initialized

            Dim showIndicators As IndicatorWindow
            showIndicators = New IndicatorWindow(m_world, message)
            showIndicators.ShowDialog()
            ret = True
        Else 'If not initialized, let a user start a game first
            MsgBox("Please start a new game or load a previous game to access indicators!")
        End If

        Return ret
    End Function

    'Handles the new game button click event, asks for saving changes if the current game is not saved
    Private Sub d_newGameButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d_newGameButton.Click
        If (saveChanges() = True) Then
            newGame()
        End If
    End Sub

    'If a user selects an appropriate difficulty, setups up new game with the difficulty value given by a user
    Private Sub newGame()
        Dim diffWindow As New DifficultyWindow
        Dim result As DialogResult = diffWindow.ShowDialog()
        If (result = Windows.Forms.DialogResult.OK) Then 'If difficulty setup is successful

            'Initialize other interfaces
            m_world = New world(Nothing, diffWindow.Difficulty)

            If (diffWindow.Is_Advanced = True) Then
                m_world.Change_Multiplier(diffWindow.Advanced)
            End If

            m_view = New View(New Size(GRAPHIC_SIZE_X, GRAPHIC_SIZE_Y), New Point(GRAPHIC_LOC_X, GRAPHIC_LOC_Y), diffWindow.Difficulty, CELL_SIZE_LENGTH)
            m_budgetManager = New budget_manager

            'Checker setup
            m_saved = True
            m_hasBegun = True
            m_isOver = False

            iterUpdate() 'Iteration update
            updateUnallocBudget() 'Updates unallocated budget tracking
            updateMultipliers() 'Update multipliers
            displayDifficulty() 'Display difficulty

            'Graphic and interface Setup
            m_panelGraphic = d_displayPanel.CreateGraphics()
            bringGraphic() 'Draw first graphic

            MsgBox("New game created successfully!")

        Else 'If failed
            MsgBox("Failed to create a new game!")
        End If
    End Sub

    'This method will load a welcome image from a file
    Private Sub welcomeGraphic()
        m_panelGraphic.DrawImage(m_introImg, GRAPHIC_LOC_X, GRAPHIC_LOC_Y, GRAPHIC_SIZE_X, GRAPHIC_SIZE_Y)
    End Sub

    'Updates iteration index in the right corner at the top
    Private Sub iterUpdate()
        Dim iter As Integer = m_budgetManager.current_turn
        Dim displayValue As String

        If iter > m_budgetManager.NUM_TURNS Then
            displayValue = "Finished" 'If it reached the max value, print "finished" instead of number
            m_isOver = True 'Set the game as finished state
        Else
            displayValue = (iter).ToString
        End If

        d_iterLabel.Text = "Next Turn: " + displayValue 'Update the index here
    End Sub

    'Displays the difficulty of this game on the splash page
    Private Sub displayDifficulty()
        Dim difficulty As String = "Not specified"

        Select Case m_world.difficulty
            Case 1
                difficulty = "Easy"
            Case 3
                difficulty = "Normal"
            Case 5
                difficulty = "Difficult"
        End Select

        d_difficultyValueLabel.Text = difficulty
    End Sub

    'This paint event handler will keep the graphic visible
    Private Sub d_displayPanel_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles d_displayPanel.Paint
        Select Case m_paintStatus
            Case 0 'Intro Graphic
                welcomeGraphic()
            Case 1 'Draws environment graphic
                m_view.drawGraphic(m_panelGraphic, CInt(m_world.environment_indicator))
            Case 2 'Final Graphic
                m_view.DrawLastRound(m_panelGraphic, New Point(GRAPHIC_LOC_X, GRAPHIC_LOC_Y), New Size(GRAPHIC_SIZE_X - 1, _
                                GRAPHIC_SIZE_Y - 1))
        End Select
    End Sub

    'Change the graphic to be displayed on the splash page and update the display area
    Private Sub updateGraphicMode(ByVal graphicId As Integer)
        m_paintStatus = graphicId
        d_displayPanel.Invalidate()
    End Sub
End Class