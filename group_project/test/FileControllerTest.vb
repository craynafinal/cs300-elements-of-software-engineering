Imports System.Text
Imports CS300_AmplaProject
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

<TestClass()>
Public Class FileControllerTest

    'This tests if save and load was successful
    <TestMethod()>
    Public Sub SaveAndLoadTest()
        Dim target As FileController_Accessor = New FileController_Accessor
        Dim newWorld As world = New world()

        'Artificially changes values in budget
        Dim newBudget As budget
        newBudget.ag = 1
        newBudget.edu = 2
        newBudget.ind = 3
        newBudget.pol = 4
        newBudget.sci = 5

        Dim newBudgetManager As budget_manager = New budget_manager
        newBudgetManager.Submit_Budget(newWorld, newBudget)

        'Artificially change attributes in the world object
        newWorld.environment_indicator = 1
        newWorld.food_indicator = 2
        newWorld.income_indicator = 3
        newWorld.population_indicator = 4

        Dim newArray(1, 1) As Integer
        newArray(0, 0) = 1

        Dim file As CS300_AmplaProject.File = New CS300_AmplaProject.File(newWorld, newBudgetManager, newArray)
        Dim filePath As String = "c:\test.sav"

        Dim result As Boolean = target.serialize(file, filePath)
        Assert.AreEqual(result, True) 'Fails if serialization fails

        Dim fileResult As CS300_AmplaProject.File = target.deserialize(filePath)
        Assert.AreNotEqual(fileResult, Nothing) 'Fails if deserialization fails

        Dim budgetResult As budget = fileResult.BudgetManager.Get_Previous_Budget
        Assert.AreEqual(budgetResult.ag, newBudget.ag)
        Assert.AreEqual(budgetResult.edu, newBudget.edu)
        Assert.AreEqual(budgetResult.ind, newBudget.ind)
        Assert.AreEqual(budgetResult.pol, newBudget.pol)
        Assert.AreEqual(budgetResult.sci, newBudget.sci)

        Dim worldResult As world = fileResult.World
        Assert.AreEqual(worldResult.environment_indicator, newWorld.environment_indicator)
        Assert.AreEqual(worldResult.food_indicator, newWorld.food_indicator)
        Assert.AreEqual(worldResult.income_indicator, newWorld.income_indicator)
        Assert.AreEqual(worldResult.population_indicator, newWorld.population_indicator)

        Dim arrayCopy(,) As Integer = fileResult.PointArray
        Assert.AreEqual(newArray(0, 0), arrayCopy(0, 0))
    End Sub

    'This will test if save fails with empty file path
    <TestMethod()>
    Public Sub SaveTest_Empty()
        Dim target As FileController_Accessor = New FileController_Accessor

        Dim newArray(1, 1) As Integer
        newArray(0, 0) = 1

        Dim file As CS300_AmplaProject.File = New CS300_AmplaProject.File(New world, New budget_manager, newArray)
        Dim filePath As String = ""

        Dim result As Boolean = target.serialize(file, filePath)
        Assert.AreEqual(result, False) 'Fails if serialization fails
    End Sub

    'This will test if save fails with null data
    <TestMethod()>
    Public Sub SaveTest_Nothing()
        Dim target As FileController_Accessor = New FileController_Accessor

        Dim newArray(0, 0) As Integer

        Dim file As CS300_AmplaProject.File = New CS300_AmplaProject.File(Nothing, Nothing, newArray)
        Dim filePath As String = ""

        Dim result As Boolean = target.serialize(file, filePath)
        Assert.AreEqual(result, False) 'Fails if serialization fails
    End Sub


    'This will test if load fails with empty file path
    <TestMethod()>
    Public Sub LoadTest_Empty()
        Dim target As FileController_Accessor = New FileController_Accessor
        Dim filePath As String = ""
        Dim result As Boolean = True

        Try
            Dim fileResult As CS300_AmplaProject.File = target.deserialize(filePath)
        Catch ex As Exception
            result = False
        End Try

        Assert.AreEqual(False, result) 'Fails if deserialization fails
    End Sub

    'This class is used to be tested as a corrupted file object
    <System.Serializable()>
    Public Class CorruptedFile
        Dim value As Integer = 1
    End Class

    'This test will check if the process fails when loading corrupted file
    <TestMethod()>
    Public Sub LoadTest_Corruption()
        Dim target As FileController_Accessor = New FileController_Accessor
        Dim filePath As String = "c:\test.sav"
        Dim result As Boolean = True
        Dim m_binaryFormatter As New BinaryFormatter()
        Dim fs As FileStream = New FileStream(filePath, FileMode.OpenOrCreate)
        Dim file As CorruptedFile = New CorruptedFile

        m_binaryFormatter.Serialize(fs, file)
        fs.Close()

        Dim fileResult As CS300_AmplaProject.File = target.deserialize(filePath)
        
        Assert.IsNull(fileResult) 'Fails if deserialization fails
    End Sub
End Class
