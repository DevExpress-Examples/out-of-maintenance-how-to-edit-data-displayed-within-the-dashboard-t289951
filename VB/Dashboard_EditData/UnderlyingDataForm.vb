Imports System
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Namespace Dashboard_EditData
	Partial Public Class UnderlyingDataForm
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub UnderlyingDataForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			Me.ordersTableAdapter.Fill(Me.nwindDataSet.Orders)
		End Sub

		Private Sub gridView1_RowUpdated(ByVal sender As Object, ByVal e As RowObjectEventArgs) Handles gridView1.RowUpdated
			Try
				Me.ordersTableAdapter.Update(Me.nwindDataSet.Orders)
			Catch
				XtraMessageBox.Show("Update failed")
			End Try
		End Sub

		Public Sub SetFilter(ByVal columnName As String, ByVal filterList As List(Of Object))
			Dim orderIdColumn As GridColumn = CType(Me.gridControl1.DefaultView, GridView).Columns(columnName)
			Dim filterInfo As New ColumnFilterInfo(New InOperator(columnName, filterList))
			orderIdColumn.FilterInfo = filterInfo
		End Sub
	End Class
End Namespace