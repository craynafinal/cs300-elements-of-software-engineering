Imports System.Text
Imports CS300_AmplaProject

<TestClass()>
Public Class IndicatorWindowTest

    'This test will examine if indicators are successfully delivered to the IndicatorWindow class, so they can be displayed well
    <TestMethod()>
    Public Sub IndicatorTest()
        Dim newWorld As New world

        'Artificially assigned values for testing
        newWorld.environment_indicator = 1
        newWorld.food_indicator = 2
        newWorld.income_indicator = 3
        newWorld.population_indicator = 4

        Dim indicatorWindow As IndicatorWindow_Accessor = New IndicatorWindow_Accessor(newWorld, "test")

        Assert.AreEqual(indicatorWindow.m_arr_value(0), newWorld.environment_indicator)
        Assert.AreEqual(indicatorWindow.m_arr_value(1), newWorld.food_indicator)
        Assert.AreEqual(indicatorWindow.m_arr_value(2), newWorld.income_indicator)
        Assert.AreEqual(indicatorWindow.m_arr_value(3), newWorld.population_indicator)
    End Sub

End Class
