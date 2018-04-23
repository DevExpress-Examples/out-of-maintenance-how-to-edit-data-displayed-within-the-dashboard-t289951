# How to edit data displayed within the dashboard


The following example shows how to edit underlying data visualized within the dashboard.<br />In this example, the dashboard visualizes data from the Northwind database. The <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument3455">Data Grid</a> used to display dashboard's underlying data is connected to the Orders table within this database using the <a href="https://msdn.microsoft.com/en-us/library/bz9tthwx.aspx?f=255&MSPPError=-2147217396">TableAdapter</a>, which provides the capability to perform CRUD operations. The OrderID primary key column is used to filter the grid according to underlying values obtained using the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardViewer_GetUnderlyingDatatopic">GetUnderlyingData</a> method. The <a href="https://msdn.microsoft.com/en-us/library/ms171933.aspx">TableAdapter.Update</a> method updates underlying data and posts changes to the database.<br />The <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardViewer_ReloadDatatopic">DashboardViewer.ReloadData</a> method is called to reload data in the data source and display changed data.

<br/>


