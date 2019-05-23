using System;
using DevExpress.XtraReports.UI;
using System.Data;


namespace PMS.UserReports
{
    public partial class rptHopDongThinhGiang_HBU : XtraReport
    {
        DataTable tblKetQua;
        public rptHopDongThinhGiang_HBU()
        {
            InitializeComponent();
        }

        public void InitData(string tenTruong, DataSet data, string strTenTruong, string strNguoiDaiDien)
        {
            pTruong.Value = tenTruong.ToUpper();
            pTenTruong.Value = strTenTruong;
            pNgayThang.Value = "TP.Hồ Chí Minh " + PMS.Common.XuLyChuoi.GetThuNgayThangNam();
            pNgayThangNam.Value = DateTime.Now.ToShortDateString();
            pNgay.Value = DateTime.Now.Day.ToString();
            pThang.Value = DateTime.Now.Month.ToString();
            pNam.Value = DateTime.Now.Year.ToString();
            pDaidienhopdong.Value = strNguoiDaiDien;
            this.DataSource = data.Tables[0];
            tblKetQua = data.Tables[0];
        }
    }
}
