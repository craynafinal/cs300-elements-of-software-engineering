Imports System.Text
Imports CS300_AmplaProject

<TestClass()>
Public Class FileTest
    'This test will check if budget will be successfully allocated and delivered
    <TestMethod()>
    Public Sub FileTest()
        Dim worldState As world = New world
        Dim budgetState As budget_manager = New budget_manager

        worldState.environment_indicator = 1.1
        worldState.food_indicator = 2.2
        worldState.income_indicator = 3.3
        worldState.population_indicator = 4.4

        Dim budget As budget
        budget.ag = 1
        budget.edu = 2
        budget.ind = 3
        budget.pol = 4
        budget.sci = 5

        budgetState.Submit_Budget(worldState, budget)

        Dim newArray(1, 1) As Integer
        newArray(0, 0) = 1

        Dim file As File = New File(worldState, budgetState, newArray)

        Dim budgetCopy = file.BudgetManager.Get_Previous_Budget()
        Assert.AreEqual(budget.ag, budgetCopy.ag)
        Assert.AreEqual(budget.edu, budgetCopy.edu)
        Assert.AreEqual(budget.ind, budgetCopy.ind)
        Assert.AreEqual(budget.pol, budgetCopy.pol)
        Assert.AreEqual(budget.sci, budgetCopy.sci)

        Dim worldCopy = file.World
        Assert.AreEqual(worldState.environment_indicator, worldCopy.environment_indicator)
        Assert.AreEqual(worldState.food_indicator, worldCopy.food_indicator)
        Assert.AreEqual(worldState.income_indicator, worldCopy.income_indicator)
        Assert.AreEqual(worldState.population_indicator, worldCopy.population_indicator)

        Dim arrayCopy(,) As Integer = file.PointArray
        Assert.AreEqual(newArray(0, 0), arrayCopy(0, 0))
    End Sub
End Class
