﻿using System.Data;

namespace PMS.UserReports
{
    public partial class rptThongKeThanhTraSoSanhTienDo : DevExpress.XtraReports.UI.XtraReport
    {
        string _ngay;
        public rptThongKeThanhTraSoSanhTienDo()
        {
            InitializeComponent();
        }
        public void InitData(string truong, string tungay, string denngay, string nguoilapbieu, DataTable data)
        {
            pTruong.Value = truong.ToUpper();
            if (tungay == denngay)
                _ngay = "ngày " + tungay;
            else
                _ngay = "từ ngày " + tungay + " đến ngày " + denngay;
            pNgay.Value = _ngay.ToUpper();
            pNguoiLapBieu.Value = nguoilapbieu;
            bindingSourceThongKe.DataSource = data;
        }
    }
}