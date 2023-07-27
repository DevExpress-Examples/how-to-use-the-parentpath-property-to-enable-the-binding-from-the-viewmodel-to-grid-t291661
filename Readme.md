<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T291661)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Data Grid - Use the ParentPath Property to Define the Selected Detail Row in the View Model

This example specifies the selected detail object in the View Model and makes the [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl) define the master object associated with the detail object.

![image](https://github.com/DevExpress-Examples/how-to-use-the-parentpath-property-to-enable-the-binding-from-the-viewmodel-to-grid-t291661/assets/65009440/4898c6af-8aa4-4eb8-8724-5b49d3770550)

Your detail objects should contain information about their master items to define selected and focused detail items in the View Model. Assign the [DataControlDetailDescriptor.ParentPath](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlDetailDescriptor.ParentPath) property to the detail data source field that contains master objects. In this case, the [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl) can define the master object associated with the detail object and select the specified row.

## Implementation Details

In this example, the [DataControlDetailDescriptor.ParentPath](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlDetailDescriptor.ParentPath) property is set to the **MasterItem** property that references the master item. The combo box at the bottom contains detail items of the focused master row. You can choose a detail item in the combo box to focus this item within the grid.

## Files to Review

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainViewModel.cs](./CS/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/MainViewModel.vb))

## Documentation

* [Data Grid in Details](https://docs.devexpress.com/WPF/119851/controls-and-libraries/data-grid/master-detail/data-grid-in-details)
* [DataControlDetailDescriptor.ParentPath](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlDetailDescriptor.ParentPath)
* [DataControlBase.CurrentItem](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlBase.CurrentItem)

## More Examples

* [WPF Data Grid - Bind Master and Detail Focused Rows to View Model Properties](https://github.com/DevExpress-Examples/wpf-data-grid-bind-master-and-detail-focused-rows-to-viewmodel-properties)
* [WPF Data Grid - Create Master-Detail Grid](https://github.com/DevExpress-Examples/wpf-data-grid-create-master-detail-grid)
* [WPF Data Grid - Display Detail Content in Tabs](https://github.com/DevExpress-Examples/wpf-data-grid-display-detail-content-in-tabs)
* [WPF Data Grid - Expand and Collapse Master Rows](https://github.com/DevExpress-Examples/wpf-data-grid-expand-and-collapse-master-rows)
* [WPF Data Grid - Display Different Details Based on Data in the Master Row](https://github.com/DevExpress-Examples/wpf-data-grid-display-different-details-based-on-master-row-data)
