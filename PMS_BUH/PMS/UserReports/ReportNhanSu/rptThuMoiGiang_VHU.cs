using DevExpress.XtraReports.UI;
using System.Data;

namespace ReportManager.GV
{
    public partial class rptThuMoiGiang_VHU : XtraReport
    {
        public rptThuMoiGiang_VHU()
        {
            InitializeComponent();
            this.Landscape = false;
        }

        public void InitData(DataTable tb)
        {
            bindingSourceThongKe.DataSource = tb;
            //this.subDanhSachGiangDay1.InitData(tbSub);
        }
    }
}
