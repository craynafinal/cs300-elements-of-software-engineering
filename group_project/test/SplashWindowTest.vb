Imports System.Text
Imports CS300_AmplaProject

<TestClass()>
Public Class SplashWindowTest

    'This test will test if new game button assigns members correctly
    <TestMethod()>
    Public Sub NewGameTest()
        Dim newSplashWindow As SplashWindow_Accessor = New SplashWindow_Accessor
        newSplashWindow.newGame()

        'Check attributes when started a new game
        Assert.IsTrue(newSplashWindow.m_saved) 'This will not trigger save dialog when starting another new game or loading
        Assert.IsTrue(newSplashWindow.m_hasBegun) 'This will indicate this game has been started
        Assert.IsFalse(newSplashWindow.m_isOver) 'This will say this game is not over yet

        'Check if model classes are initialized
        Assert.IsNotNull(newSplashWindow.m_world)
        Assert.IsNotNull(newSplashWindow.m_budgetManager)
    End Sub

    'Assuming the load was successful, check if member attributes are assigned correctly
    'If load is not successful, SplashWindow does not change any attributes in its class
    <TestMethod()>
    Public Sub LoadGameTest()
        Dim newSplashWindow As SplashWindow_Accessor = New SplashWindow_Accessor
        newSplashWindow.m_budgetManager = New budget_manager
        newSplashWindow.loadSetupCheckers()

        'Check the attributes, m_isOver is not checked because it varies
        Assert.IsTrue(newSplashWindow.m_saved) 'Game just have loaded a previous game
        Assert.IsTrue(newSplashWindow.m_hasBegun) 'Game only can be saved when the game has started, so this attribute must be true
    End Sub

    'Check if saveGame method throws false when a user try to save game before starting a new game or loading a game
    <TestMethod()>
    Public Sub SaveGameTest()
        Dim newSplashWindow As SplashWindow_Accessor = New SplashWindow_Accessor
        Assert.IsFalse(newSplashWindow.saveGame())
    End Sub

    'Check if saveGame method throws false when a user try to save game before starting a new game or loading a game
    <TestMethod()>
    Public Sub ExitGameTest()
        Dim newSplashWindow As SplashWindow_Accessor = New SplashWindow_Accessor
        newSplashWindow.exitGame()

        'Is the form closed?
        Assert.IsTrue(newSplashWindow.m_isClosed)
    End Sub

    'Check the situations when the budget window is not gonig to be displayed for the conditions
    <TestMethod()>
    Public Sub BudgetButtonTest()
        Dim newSplashWindow As SplashWindow_Accessor = New SplashWindow_Accessor

        'When game is not initialized
        newSplashWindow.m_hasBegun = False 'When not started
        newSplashWindow.m_isOver = True 'When it is started
        Assert.IsFalse(newSplashWindow.openBudgetWindow())

        'This is not a normal case, but when game is not initialized and game is not over yet
        newSplashWindow.m_hasBegun = False 'When not started
        newSplashWindow.m_isOver = False 'When it is started
        Assert.IsFalse(newSplashWindow.openBudgetWindow())

        'Game is initialized and at the same time the game is over
        newSplashWindow.m_hasBegun = True 'When not started
        newSplashWindow.m_isOver = True 'When it is started
        Assert.IsFalse(newSplashWindow.openBudgetWindow())

    End Sub

    'Checks the indicator window will not be displayed if the game is not started yet
    <TestMethod()>
    Public Sub IndicatorButtonTest()
        Dim newSplashWindow As SplashWindow_Accessor = New SplashWindow_Accessor
        Assert.IsFalse(newSplashWindow.showIndicatorsWindow("test"))
    End Sub

End Class
