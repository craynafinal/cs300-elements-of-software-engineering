Imports System.Text
Imports CS300_AmplaProject

<TestClass()>
Public Class DifficultyWindowTest

    'This will test normal process of difficulty window, which the result members will have the same value as user inputs
    <TestMethod()>
    Public Sub SelectDifficultyTest_Normal()
        Assert.IsTrue(DifficultyTest(True))
    End Sub

    'This will handle the case if a user did not choose the difficulty and tried to process to the next step. Should fail to process.
    <TestMethod()>
    Public Sub SelectDifficultyTest_Error()
        Assert.IsFalse(DifficultyTest(False))
    End Sub

    Private Function DifficultyTest(ByVal checked As Boolean) As Boolean
        'Setup difficulty window attributes
        Dim newDiffWindow As DifficultyWindow_Accessor = New DifficultyWindow_Accessor
        newDiffWindow.showDefault()
        newDiffWindow.showAdvanced()
        newDiffWindow.m_arr_radio(0).Checked = checked
        newDiffWindow.m_numeric.Value = 2

        'Check if they are correct
        newDiffWindow.m_difficulty = newDiffWindow.setResult()
        Dim diff As Integer = newDiffWindow.Difficulty
        Dim adv As Integer = newDiffWindow.Advanced

        Return (diff = 1) And (adv = 2)
    End Function

End Class
