using System;
using DevExpress.XtraReports.UI;
using System.Data;


namespace PMS.UserReports
{
    public partial class rptBienBanThanhLyHopDongThinhGiang_HBU : XtraReport
    {        
        public rptBienBanThanhLyHopDongThinhGiang_HBU()
        {
            InitializeComponent();
            
        }       

        public void InitData(string tenTruong, DataSet data,string strTenTruong,string strNguoiDaiDien)
        {            
            pTruong.Value = tenTruong.ToUpper();
            pNgayThang.Value = "TP.Hồ Chí Minh " + PMS.Common.XuLyChuoi.GetThuNgayThangNam();
            pNgay.Value = DateTime.Now.Day.ToString();
            pThang.Value = DateTime.Now.Month.ToString();
            pNam.Value = DateTime.Now.Year.ToString();
            pTenTruong.Value = strTenTruong;
            pChucVuDaiDienHopDong.Value = strNguoiDaiDien;
            pBangChu.Value = PMS.Common.XuLyDoSoThanhChu.GetSoThanhChu(data.Tables[0].Rows[0]["BangChu"].ToString());
            this.DataSource = data.Tables[0];              
        }     
        
        private string GetThanhTien(DataTable tblThanhTien)
        {
            string strThanhTien = string.Empty;
            for (int i = 0; i < tblThanhTien.Rows.Count; i++)
            {
                
            }
            return strThanhTien;
        }   
       
    }
}
