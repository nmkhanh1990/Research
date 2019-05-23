using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ReportManager.GV
{
    public partial class rptBangTongHopGioGiangCacKhoa_HBU : DevExpress.XtraReports.UI.XtraReport
    {
        DataTable tbl;
        public rptBangTongHopGioGiangCacKhoa_HBU()
        {
            InitializeComponent();
        }

        public void InitData(string tenTruong,  DataTable data) 
        {
            pTruong.Value = tenTruong.ToUpper();
            tbl = data;
            bindingSource1.DataSource = tbl;            
            GroupHeader1.GroupFields.Add(new GroupField("MaDonVi"));
        }      
       
         
    }
}
