using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ReportManager.GV
{
    public partial class BangDanhSachGiangVienChamKetThucHocPhamTay2 : DevExpress.XtraReports.UI.XtraReport
    {
        public BangDanhSachGiangVienChamKetThucHocPhamTay2()
        {
            InitializeComponent();
        }

        public void InitData( string namHoc, string hocKy, string nguoiKeKhai, DateTime _ngayIn, DataTable tb)
        {
            pBGDT.Value = "BỘ GIÁO DỤC VÀ ĐÀO TẠO";            
            pNamHoc.Value = namHoc.ToUpper();
            pHocKy.Value = hocKy.ToUpper();            
            pNguoiKeKhai.Value = nguoiKeKhai;
            pNgayIn.Value = string.Format("Tp. Hồ Chí Minh, ngày {0:dd} tháng {0:MM} năm {0:yyyy}", _ngayIn);
            DataSource = tb;
        }

        private void xrLabel27_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
           
        }
    }
}
