Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Printing
Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Documents

Namespace MultiLevelMasterDetail
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            DataContext = New MultiLevelDataSource()
        End Sub
    End Class
End Namespace
