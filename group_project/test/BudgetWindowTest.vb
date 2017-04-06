Imports System.Text
Imports CS300_AmplaProject

<TestClass()>
Public Class BudgetWindowTest
    'This test will check if budget will be successfully allocated and delivered
    <TestMethod()>
    Public Sub BudgetAllocationTest_Normal()
        Dim newWorld As world = New world
        Dim newBudgetManager As budget_manager = New budget_manager()
        Dim prevBudget As budget
        prevBudget.ag = 5
        prevBudget.edu = 4
        prevBudget.ind = 3
        prevBudget.pol = 2
        prevBudget.sci = 1

        newBudgetManager.Submit_Budget(newWorld, prevBudget)

        Dim newBudgetWindow As BudgetWindow_Accessor = New BudgetWindow_Accessor(newBudgetManager.Get_Previous_Budget(), newBudgetManager.BUDGET_PER_CYCLE)
        newBudgetWindow.displayBudgetInterface() 'Initialize textboxes

        'Checking if the previous budgets are delivered properly
        Assert.AreEqual(prevBudget.ag, newBudgetWindow.m_prevBudgets(0))
        Assert.AreEqual(prevBudget.edu, newBudgetWindow.m_prevBudgets(1))
        Assert.AreEqual(prevBudget.ind, newBudgetWindow.m_prevBudgets(2))
        Assert.AreEqual(prevBudget.pol, newBudgetWindow.m_prevBudgets(3))
        Assert.AreEqual(prevBudget.sci, newBudgetWindow.m_prevBudgets(4))

        Dim index As Integer
        Dim max As Integer = 5

        'Setup values to be allocated for each project
        For index = 0 To max - 1
            newBudgetWindow.m_textboxes(index).Text = (index + 1).ToString
        Next

        'Finishing budget allocation
        newBudgetWindow.commitBudget()

        'Check for the result budget
        Dim budgetResult As budget = newBudgetWindow.Budget_Result
        Assert.AreEqual(1.0, budgetResult.ag)
        Assert.AreEqual(2.0, budgetResult.edu)
        Assert.AreEqual(3.0, budgetResult.ind)
        Assert.AreEqual(4.0, budgetResult.pol)
        Assert.AreEqual(5.0, budgetResult.sci)

    End Sub

    'Checks if commit function blocks further process if user inputs are too high
    <TestMethod()>
    Public Sub BudgetAllocationTest_TooHigh()
        Assert.IsFalse(SpecialValueTest("2000"))
    End Sub

    'Checks if commit function blocks further process if user inputs are negatives
    <TestMethod()>
    Public Sub BudgetAllocationTest_Negative()
        Assert.IsFalse(SpecialValueTest("-1"))
    End Sub

    'Checks if commit function blocks further process if user inputs are characters
    <TestMethod()>
    Public Sub BudgetAllocationTest_Character()
        Assert.IsFalse(SpecialValueTest("test"))
    End Sub

    'Checks if commit function blocks further process if user inputs are empty string
    <TestMethod()>
    Public Sub BudgetAllocationTest_Empty()
        Assert.IsFalse(SpecialValueTest(""))
    End Sub

    Private Function SpecialValueTest(ByVal testValue As String)
        Dim newWorld As world = New world
        Dim newBudgetManager As budget_manager = New budget_manager

        Dim newBudgetWindow As BudgetWindow_Accessor = New BudgetWindow_Accessor(newBudgetManager.Get_Previous_Budget(), newBudgetManager.BUDGET_PER_CYCLE)
        newBudgetWindow.displayBudgetInterface() 'Initialize textboxes

        Dim index As Integer
        Dim max As Integer = 5

        'Setup values to be allocated for each project
        For index = 0 To max - 1
            newBudgetWindow.m_textboxes(index).Text = testValue
        Next

        'Return the result of commit function
        Return newBudgetWindow.commitBudget()
    End Function

End Class
