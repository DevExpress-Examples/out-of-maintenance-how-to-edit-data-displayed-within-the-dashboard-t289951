<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581128/18.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T289951)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Dashboard for WinForms - How to Edit Data Displayed in the Dashboard

This example demonstrates how to edit the data visualized in the dashboard.

The dashboard gets data from the Northwind database. The [Data Grid](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl) control on the _Underlying Data_ form is bound to the Orders table with the [TableAdapter](https://docs.microsoft.com/en-us/visualstudio/data-tools/fill-datasets-by-using-tableadapters) component capable to perform adds, updates, and deletes on the database. The grid data is filtered by the **OrderID** field with values obtained from the dashboard item's underlying data. 

 The [TableAdapter.Update](https://docs.microsoft.com/en-us/visualstudio/data-tools/update-data-by-using-a-tableadapter) method saves changes to the database.
 
 To update data displayed in the dashboard, call the [DashboardViewer.ReloadData](https://docs.devexpress.com/Dashboard/devexpress.dashboardwin.dashboardviewer.reloaddata.overloads) method.

![screenshot](/images/screenshot.png)

<!-- default file list -->
## Files to look at

* [DashboardViewerForm.cs](./CS/Dashboard_EditData/DashboardViewerForm.cs) (VB: [DashboardViewerForm.vb](./VB/Dashboard_EditData/DashboardViewerForm.vb))
* [UnderlyingDataForm.cs](./CS/Dashboard_EditData/UnderlyingDataForm.cs) (VB: [UnderlyingDataForm.vb](./VB/Dashboard_EditData/UnderlyingDataForm.vb))
<!-- default file list end -->

## Documentation

- [Obtaining Underlying and Displayed Data](https://docs.devexpress.com/Dashboard/17269/winforms-dashboard/winforms-viewer/obtaining-underlying-and-displayed-data)
