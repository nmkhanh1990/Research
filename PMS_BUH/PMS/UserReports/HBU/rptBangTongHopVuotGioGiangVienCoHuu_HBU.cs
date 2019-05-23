using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;


namespace PMS.UserReports
{
    public partial class rptBangTongHopVuotGioGiangVienCoHuu_HBU : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBangTongHopVuotGioGiangVienCoHuu_HBU()
        {
            InitializeComponent();
            //_tienChu = 0;
        }

        public void InitData(string strTenTruong, DataTable db)
        {
            pTenTruong.Value = strTenTruong;
            this.DataSource = db;
        }
    }
}
