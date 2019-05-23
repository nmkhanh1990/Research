using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;


namespace PMS.UserReports
{
    public partial class rptBangKeKhaiGioGiangCuaGiangVien_HBU : DevExpress.XtraReports.UI.XtraReport
    {
        DataTable tbl;
        public rptBangKeKhaiGioGiangCuaGiangVien_HBU()
        {
            InitializeComponent();
        }

        public void InitData(string tenTruong, DataTable data)
        {           
            pTenTruong.Value = tenTruong;
            tbl = data;
            this.DataSource = tbl;
        }

        private void rptBangKeKhaiGioGiangCuaGiangVien_HBU_DataSourceRowChanged(object sender, DataSourceRowEventArgs e)
        {
          
            foreach (DataRow item in tbl.Rows)
            {
                if (item["MaChucVu"].ToString() == "7267")
                {
                    chk_TKhoa.Checked = true;
                }
                else if (item["MaChucVu"].ToString() == "7115")
                {
                    chk_PKhoa.Checked = true;
                }
                else if (item["MaChucVu"].ToString() == "7102")
                {
                    chk_TBoMon.Checked = true;
                }
                else if (item["MaChucVu"].ToString().Length>0
                        && item["MaChucVu"].ToString()!= "7267"
                        && item["MaChucVu"].ToString() != "7115"
                        && item["MaChucVu"].ToString() != "7102")
                {
                    chk_PBoMonKhac.Checked = true;
                }
            }
        }
    }
}
