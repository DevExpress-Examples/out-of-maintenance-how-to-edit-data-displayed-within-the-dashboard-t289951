using System.Collections.Generic;
using DevExpress.DashboardCommon;
using DevExpress.DashboardWin;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;

namespace Dashboard_EditData {
    public partial class DashboardViewerForm : RibbonForm {
        public DashboardViewerForm() {
            InitializeComponent();
        }

        private void dashboardViewer1_DashboardItemClick(object sender, 
            DashboardItemMouseActionEventArgs e) {
            if (e.DashboardItemName == "gridDashboardItem1" & e.GetUnderlyingData() != null) {
                ShowUnderlyingData(e.GetUnderlyingData());
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e) {
            ShowUnderlyingData(dashboardViewer1.GetUnderlyingData("gridDashboardItem1"));
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e) {
            dashboardViewer1.ReloadData();
        }

        private void ShowUnderlyingData(DashboardUnderlyingDataSet unData) {
            UnderlyingDataForm form = new UnderlyingDataForm();
            string keyColumnName = "OrderID";

            List<object> filterList = new List<object>();
            foreach (DashboardUnderlyingDataRow row in unData) {
                filterList.Add(row[keyColumnName]);
            }
            form.SetFilter(keyColumnName, filterList);

            form.ShowDialog();
            form.Dispose();
        }
    }
}
