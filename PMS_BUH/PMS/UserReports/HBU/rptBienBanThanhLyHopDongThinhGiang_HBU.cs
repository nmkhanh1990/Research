using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;


namespace PMS.UserReports
{
    public partial class rptBienBanThanhLyHopDongThinhGiang_HBU : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBienBanThanhLyHopDongThinhGiang_HBU()
        {
            InitializeComponent();

        }
        DataSet ds = new DataSet();

        public void InitData(string strTenTruong, DataSet data, string strNguoiDaiDien)
        {             
            pNgayThang.Value = "TP.Hồ Chí Minh " + PMS.Common.XuLyChuoi.GetThuNgayThangNam();
            pNgay.Value = DateTime.Now.Day.ToString();
            pThang.Value = DateTime.Now.Month.ToString();
            pNam.Value = DateTime.Now.Year.ToString();
            pTenTruong.Value = strTenTruong;
            pChucVuDaiDienHopDong.Value = strNguoiDaiDien;
            ds = data;
            this.DataSource = data.Tables[0];
        }


        private void rptBienBanThanhLyHopDongThinhGiang_HBU_DataSourceRowChanged(object sender, DataSourceRowEventArgs e)
        {
            pBangChu.Value = PMS.Common.Globals.DocTien(decimal.Parse(ds.Tables[0].Rows[e.CurrentRow]["BangChu"].ToString())) + ".";
        }
    }
}
