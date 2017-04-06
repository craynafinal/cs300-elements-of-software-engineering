Option Strict On
Option Explicit On

'Author: Jong Seong Lee
'Version: 1.2
'Date: 08/23/13
'Interface: Controller
'File class is a simple container of objects that are going to be saved.
<System.Serializable()>
Public Class File
    Dim m_world As world
    Dim m_budget As budget_manager
    Dim m_points() As Point 'This array contains the information of the locations of mines

    'A world object to be saved or loaded
    Public ReadOnly Property World As world
        Get
            World = m_world
        End Get
    End Property

    'A budget manager object to be saved or loaded
    Public ReadOnly Property BudgetManager As budget_manager
        Get
            BudgetManager = m_budget
        End Get
    End Property

    'An array of points to be saved or loaded
    Public ReadOnly Property PointArray As Point()
        Get
            PointArray = m_points
        End Get
    End Property

    'Takes a world, a budget object, and a array of points
    Sub New(ByVal worldState As world, ByVal budgetState As budget_manager, ByVal points() As Point)
        m_world = New world(worldState)
        m_budget = New budget_manager(budgetState)
        m_points = points
    End Sub

End Class