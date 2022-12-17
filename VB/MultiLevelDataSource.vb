Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel

Namespace MultiLevelMasterDetail

    Public Class MultiLevelDataSource
        Implements INotifyPropertyChanged

        Private currentItemField As MasterLevelItem

        Private currentDetailItemField As DetailLevelItem

        Private itemsField As ObservableCollection(Of MasterLevelItem)

        Public Property Items As ObservableCollection(Of MasterLevelItem)
            Get
                Return itemsField
            End Get

            Set(ByVal value As ObservableCollection(Of MasterLevelItem))
                If itemsField Is value Then Return
                itemsField = value
                RaisePropertyChanged("Items")
            End Set
        End Property

        Public Property CurrentItem As MasterLevelItem
            Get
                Return currentItemField
            End Get

            Set(ByVal value As MasterLevelItem)
                If currentItemField Is value Then Return
                currentItemField = value
                RaisePropertyChanged("CurrentItem")
            End Set
        End Property

        Public Property CurrentDetailItem As DetailLevelItem
            Get
                Return currentDetailItemField
            End Get

            Set(ByVal value As DetailLevelItem)
                If currentDetailItemField Is value Then Return
                currentDetailItemField = value
                RaisePropertyChanged("CurrentDetailItem")
            End Set
        End Property

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Public Sub New()
            Items = New ObservableCollection(Of MasterLevelItem)()
            InitMasterItems()
            CurrentItem = Nothing
        End Sub

        Private Sub InitMasterItems()
            For i As Integer = 0 To 10 - 1
                Items.Add(New MasterLevelItem() With {.MasterId = i, .MasterName = String.Format("master item {0}", i)})
            Next
        End Sub

        Private Sub RaisePropertyChanged(ByVal propertyName As String)
            If PropertyChangedEvent Is Nothing Then Return
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
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
