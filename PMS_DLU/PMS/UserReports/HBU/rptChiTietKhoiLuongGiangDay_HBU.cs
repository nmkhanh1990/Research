using System;
using DevExpress.XtraReports.UI;
using System.Data;


namespace PMS.UserReports
{
    public partial class rptChiTietKhoiLuongGiangDay_HBU : XtraReport
    {
        public rptChiTietKhoiLuongGiangDay_HBU()
        {
            InitializeComponent();
            //_tienChu = 0;
        }

        public void InitData(DateTime ngayIn, string strTenTruong, DataTable db)
        {
            pNgayIn.Value = ngayIn.Day;
            pThangIn.Value = ngayIn.Month;
            pNamIn.Value = ngayIn.Year;
            pTenTruong.Value = strTenTruong;
            this.DataSource = db;
        }

    }
}
