using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Printing;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;

namespace MultiLevelMasterDetail {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = new MultiLevelDataSource();
        }
    }
}
