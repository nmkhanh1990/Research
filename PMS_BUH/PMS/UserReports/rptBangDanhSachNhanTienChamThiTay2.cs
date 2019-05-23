using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ReportManager.Reports
{
    public partial class rptBangDanhSachNhanTienChamThiTay2 : DevExpress.XtraReports.UI.XtraReport
    {        
       
        DataTable _listGiangVien = new DataTable();       
        public rptBangDanhSachNhanTienChamThiTay2()
        {
            InitializeComponent();
           
        }
        
        public void InitData(DataTable dsDataSource, string strUseLap, DateTime ngayIn)
        {
            pTenNguoiLap.Value = strUseLap;
            this.DataSource = dsDataSource;
        }        
        
    }
}
