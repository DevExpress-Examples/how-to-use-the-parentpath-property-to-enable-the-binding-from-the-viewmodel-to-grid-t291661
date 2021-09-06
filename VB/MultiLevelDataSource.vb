Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel

Namespace MultiLevelMasterDetail
	Public Class MultiLevelDataSource
		Implements INotifyPropertyChanged

'INSTANT VB NOTE: The field currentItem was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private currentItem_Conflict As MasterLevelItem
'INSTANT VB NOTE: The field currentDetailItem was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private currentDetailItem_Conflict As DetailLevelItem
'INSTANT VB NOTE: The field items was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private items_Conflict As ObservableCollection(Of MasterLevelItem)

		Public Property Items() As ObservableCollection(Of MasterLevelItem)
			Get
				Return items_Conflict
			End Get
			Set(ByVal value As ObservableCollection(Of MasterLevelItem))
				If items_Conflict Is value Then
					Return
				End If
				items_Conflict = value
				RaisePropertyChanged("Items")
			End Set
		End Property
		Public Property CurrentItem() As MasterLevelItem
			Get
				Return currentItem_Conflict
			End Get
			Set(ByVal value As MasterLevelItem)
				If currentItem_Conflict Is value Then
					Return
				End If
				currentItem_Conflict = value
				RaisePropertyChanged("CurrentItem")
			End Set
		End Property
		Public Property CurrentDetailItem() As DetailLevelItem
			Get
				Return currentDetailItem_Conflict
			End Get
			Set(ByVal value As DetailLevelItem)
				If currentDetailItem_Conflict Is value Then
					Return
				End If
				currentDetailItem_Conflict = value
				RaisePropertyChanged("CurrentDetailItem")
			End Set
		End Property
		Public Event PropertyChanged As PropertyChangedEventHandler

		Public Sub New()
			Items = New ObservableCollection(Of MasterLevelItem)()
			InitMasterItems()
			CurrentItem = Nothing
		End Sub
		Private Sub InitMasterItems()
			For i As Integer = 0 To 9
				Items.Add(New MasterLevelItem() With {
					.MasterId = i,
					.MasterName = String.Format("master item {0}", i)
				})
			Next i
		End Sub
		Private Sub RaisePropertyChanged(ByVal propertyName As String)
			If PropertyChangedEvent Is Nothing Then
				Return
			End If
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub
	End Class

	Public Class MasterLevelItem
		Public Property MasterId() As Integer
		Public Property MasterName() As String
		Public Property DetailItems() As List(Of DetailLevelItem)
		Public Sub New()
			DetailItems = New List(Of DetailLevelItem)()
			InitDetailItems()
		End Sub
		Private Sub InitDetailItems()
			For i As Integer = 0 To 9
				DetailItems.Add(New DetailLevelItem() With {
					.DetailId = i,
					.DetailName = String.Format("detail item {0}", i),
					.MasterItem = Me
				})
			Next i
		End Sub
	End Class

	Public Class DetailLevelItem
		Public Property DetailId() As Integer
		Public Property DetailName() As String
		Public Property MasterItem() As Object
	End Class
End Namespace
