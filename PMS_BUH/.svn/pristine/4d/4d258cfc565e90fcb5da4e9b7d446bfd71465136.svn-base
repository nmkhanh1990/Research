using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using PMS.Entities;
using System.Data;


namespace PMS.UserReports
{
    public partial class rptBangChiTraThuLaoGiangDay_VHU : DevExpress.XtraReports.UI.XtraReport
    {

        DataTable tbl;
        public rptBangChiTraThuLaoGiangDay_VHU()
        {
            InitializeComponent();
        }

        public void InitData(string truong, string nguoilapbang,DateTime _ngayIn, DataTable vList)
        {
            string strNgay = _ngayIn.Day.ToString();
            string strThang = _ngayIn.Month.ToString();
            pTruong.Value = truong;            
            pNguoiLapBang.Value = nguoilapbang;
            pNgay.Value = strNgay.Length < 2 ? "0" + strNgay : strNgay;
            pThang.Value = strThang.Length < 2 ? "0" + strThang : strThang;
            pNam.Value = _ngayIn.Year.ToString();
            tbl = vList;
            bindingSourceBangChiTienCoVan.DataSource = vList;
        }

        private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal dThue = 0, dThueTNC = 0;
            GetThue(ref dThue, ref dThueTNC);
            lbl_Thue.Text = dThue.ToString("#,#0");
            lbl_ThucNhan.Text = dThueTNC.ToString("#,#0");
            decimal tien = Convert.ToDecimal(lbl_ThucNhan.Text);
            string tiengbangchu = PMS.Common.Globals.DocTien(tien);
            lbl_TieuDe.Text = lbl_TieuDe.Text + dThueTNC.ToString("#,#0").ToString()+" đ " + tiengbangchu;
            //pTienBangChu.Value = lbl_ThucNhan.Text + " đ" + tiengbangchu;
        }

        private void GetThue(ref decimal dThue,ref decimal dThueTNCN)
        {
            foreach (DataRow item in tbl.Rows)
            {
                dThue = dThue + Convert.ToDecimal(item["Thue"].ToString());
                dThueTNCN = dThueTNCN + Convert.ToDecimal(item["ThucNhan"].ToString());
            }
        }     
       
    }
}
