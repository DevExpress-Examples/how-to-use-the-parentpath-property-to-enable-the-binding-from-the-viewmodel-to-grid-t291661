Imports System.Windows

Namespace MultiLevelMasterDetail

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            DataContext = New MultiLevelDataSource()
        End Sub
    End Class
End Namespace
