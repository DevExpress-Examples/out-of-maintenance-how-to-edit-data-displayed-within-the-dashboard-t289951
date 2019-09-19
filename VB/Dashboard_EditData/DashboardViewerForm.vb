Imports System.Collections.Generic
Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWin
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars

Namespace Dashboard_EditData
    Partial Public Class DashboardViewerForm
        Inherits RibbonForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub dashboardViewer1_DashboardItemClick(ByVal sender As Object, _
                                                        ByVal e As DashboardItemMouseActionEventArgs) _
                                                    Handles dashboardViewer1.DashboardItemClick
            If e.DashboardItemName = "gridDashboardItem1" And e.GetUnderlyingData() IsNot Nothing Then
                ShowUnderlyingData(e.GetUnderlyingData())
            End If
        End Sub

        Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) _
            Handles barButtonItem1.ItemClick
            ShowUnderlyingData(dashboardViewer1.GetUnderlyingData("gridDashboardItem1"))
        End Sub

        Private Sub barButtonItem2_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) _
            Handles barButtonItem2.ItemClick
            dashboardViewer1.ReloadData()
        End Sub

        Private Sub ShowUnderlyingData(ByVal unData As DashboardUnderlyingDataSet)
            Dim form As New UnderlyingDataForm()
            Dim keyColumnName As String = "OrderID"

            Dim filterList As New List(Of Object)()
            For Each row As DashboardUnderlyingDataRow In unData
                filterList.Add(row(keyColumnName))
            Next row
            form.SetFilter(keyColumnName, filterList)

            form.ShowDialog()
            form.Dispose()
        End Sub
    End Class
End Namespace
