Imports DevExpress.Mvvm
Imports System.Collections.Generic
Imports System.Collections.ObjectModel

Namespace MultiLevelMasterDetail

    Public Class MainViewModel
        Inherits ViewModelBase

        Private _Items As ObservableCollection(Of MultiLevelMasterDetail.MasterLevelItem)

        Public Sub New()
            Items = New ObservableCollection(Of MasterLevelItem)()
            InitMasterItems()
            CurrentMasterItem = Nothing
        End Sub

        Public Property Items As ObservableCollection(Of MasterLevelItem)
            Get
                Return _Items
            End Get

            Private Set(ByVal value As ObservableCollection(Of MasterLevelItem))
                _Items = value
            End Set
        End Property

        Public Property CurrentMasterItem As MasterLevelItem
            Get
                Return GetValue(Of MasterLevelItem)()
            End Get

            Set(ByVal value As MasterLevelItem)
                SetValue(value)
            End Set
        End Property

        Public Property CurrentDetailItem As DetailLevelItem
            Get
                Return GetValue(Of DetailLevelItem)()
            End Get

            Set(ByVal value As DetailLevelItem)
                SetValue(value)
            End Set
        End Property

        Private Sub InitMasterItems()
            For i As Integer = 0 To 10 - 1
                Items.Add(New MasterLevelItem() With {.MasterId = i, .MasterName = String.Format("master item {0}", i)})
            Next
        End Sub
    End Class

    Public Class MasterLevelItem

        Public Property MasterId As Integer

        Public Property MasterName As String

        Public Property DetailItems As List(Of DetailLevelItem)

        Public Sub New()
            DetailItems = New List(Of DetailLevelItem)()
            InitDetailItems()
        End Sub

        Private Sub InitDetailItems()
            For i As Integer = 0 To 10 - 1
                DetailItems.Add(New DetailLevelItem() With {.DetailId = i, .DetailName = String.Format("detail item {0}", i), .MasterItem = Me})
            Next
        End Sub
    End Class

    Public Class DetailLevelItem

        Public Property DetailId As Integer

        Public Property DetailName As String

        Public Property MasterItem As Object
    End Class
End Namespace
