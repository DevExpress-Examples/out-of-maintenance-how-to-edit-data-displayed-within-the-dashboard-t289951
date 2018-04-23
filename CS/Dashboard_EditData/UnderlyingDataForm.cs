using System;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;

namespace Dashboard_EditData {
    public partial class UnderlyingDataForm : DevExpress.XtraEditors.XtraForm {
        public UnderlyingDataForm() {
            InitializeComponent();
        }

        private void UnderlyingDataForm_Load(object sender, EventArgs e) {
            this.ordersTableAdapter.Fill(this.nwindDataSet.Orders);
        }

        private void gridView1_RowUpdated(object sender, RowObjectEventArgs e) {
            try {
                this.ordersTableAdapter.Update(this.nwindDataSet.Orders);
            }
            catch {
                XtraMessageBox.Show("Update failed");
            }
        }

        public void SetFilter(string columnName, List<object> filterList) {
            GridColumn orderIdColumn = ((GridView)this.gridControl1.DefaultView).Columns[columnName];
            ColumnFilterInfo filterInfo = new ColumnFilterInfo(new InOperator(columnName, filterList));
            orderIdColumn.FilterInfo = filterInfo;
        }
    }
}