using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using PMS.Entities;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptBangKeThucTeGioGiangDay_VHU : DevExpress.XtraReports.UI.XtraReport
    {
        DataTable tblTongTien;
        public rptBangKeThucTeGioGiangDay_VHU()
        {
            InitializeComponent();
        }

        public void InitData(string truong ,string strnguoilapbang,DateTime _ngayIn, DataTable vList)
        {
            string strNgay = _ngayIn.Day.ToString();
            string strThang = _ngayIn.Month.ToString();
            pTruong.Value = truong;            
            pNguoiLapBang.Value = strnguoilapbang;
            pNgay.Value = strNgay.Length < 2 ? "0" + strNgay : strNgay;
            pThang.Value = strThang.Length<2?"0"+ strThang: strThang;
            pNam.Value = _ngayIn.Year.ToString();
            tblTongTien = vList;
            bindingSourceBangChiTienCoVan.DataSource = vList;
        }

        private void rptBangKeThucTeGioGiangDay_VHU_DataSourceRowChanged(object sender, DataSourceRowEventArgs e)
        {
            foreach (DataRow item in tblTongTien.Rows)
            {
                decimal tien = Convert.ToDecimal(item["TongTien_LT"].ToString());
                string tiengbangchu = PMS.Common.Globals.DocTien(tien);
                pTienBangChu.Value = tiengbangchu;
                break;
            }
        }
    }
}
