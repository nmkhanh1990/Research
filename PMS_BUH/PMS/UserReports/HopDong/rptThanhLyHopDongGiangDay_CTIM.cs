using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;


namespace PMS.UserReports
{
    public partial class rptThanhLyHopDongGiangDay_CTIM : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThanhLyHopDongGiangDay_CTIM()
        {
            InitializeComponent();
        }

        public void InitData(DateTime ngayIn, DataTable tb)
        {
            decimal tietQuyDoi, thanhTienGiangDay, thanhTienRaDe, thanhTienChamBai, thanhTienTongCong;
            int soBaiCham;
            foreach (DataColumn column in tb.Columns)
            {
                column.ReadOnly = false;
            }
            //Tính tổng cho các dòng được chọn in:  HIỆN TẠI CHỈ CHẠY ĐÚNG KHI cust_GiangVien_HopDongMoiGiangDay ORDER BY MaGiangVien (MaQuanLy)
            int dongTruocDo = 0;
            string maGvTruocDo = (string)tb.Rows[0]["MaGiangVien"];
            tietQuyDoi = thanhTienGiangDay = thanhTienRaDe = thanhTienChamBai = thanhTienTongCong = soBaiCham = 0;
            // (Report chỉ hiện ra dòng cuối khi dùng [TenThuocTinh] cho nhiều dòng, vì vậy ta cập nhật tất cả các dòng cho chắc)
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                tb.Rows[i]["Ngay"] = ngayIn.Day;
                tb.Rows[i]["Thang"] = ngayIn.Month;
                tb.Rows[i]["Nam"] = ngayIn.Year;
                if (maGvTruocDo == (string)tb.Rows[i]["MaGiangVien"]) //Nếu mã hiện tại bằng mã trước đó
                {
                    tietQuyDoi += (decimal)tb.Rows[i]["SoTietQuyDoi"];
                    thanhTienGiangDay += (decimal)tb.Rows[i]["ThanhTienGiangDay"];
                    thanhTienRaDe += (decimal)tb.Rows[i]["ThanhTienRaDe"];
                    thanhTienChamBai += (decimal)tb.Rows[i]["ThanhTienChamBai"];
                    thanhTienTongCong += (decimal)tb.Rows[i]["ThanhTienTongCong"];
                    soBaiCham += (int)tb.Rows[i]["SoBaiCham"];
                }
                else
                {
                    maGvTruocDo = (string)tb.Rows[i]["MaGiangVien"];
                    for (int j = dongTruocDo; j < i; j++)
                    {
                        tb.Rows[j]["SoTietQuyDoi"] = tietQuyDoi;
                        tb.Rows[j]["ThanhTienGiangDay"] = thanhTienGiangDay;
                        tb.Rows[j]["ThanhTienRaDe"] = thanhTienRaDe;
                        tb.Rows[j]["ThanhTienChamBai"] = thanhTienChamBai;
                        tb.Rows[j]["ThanhTienTongCong"] = thanhTienTongCong;
                        tb.Rows[j]["ThanhTienTongCongBangChu"] = PMS.Common.Globals.DocTien(thanhTienTongCong);
                        tb.Rows[j]["SoBaiCham"] = soBaiCham;
                        tietQuyDoi = thanhTienGiangDay = thanhTienRaDe = thanhTienChamBai = thanhTienTongCong = soBaiCham = 0;  //reset
                    }
                    dongTruocDo = i;
                }
            }
            DataRow row = tb.Rows[tb.Rows.Count - 1];
            row["SoTietQuyDoi"] = tietQuyDoi;
            row["ThanhTienGiangDay"] = thanhTienGiangDay;
            row["ThanhTienRaDe"] = thanhTienRaDe;
            row["ThanhTienChamBai"] = thanhTienChamBai;
            row["ThanhTienTongCong"] = thanhTienTongCong;
            row["ThanhTienTongCongBangChu"] = PMS.Common.Globals.DocTien(thanhTienTongCong);
            row["SoBaiCham"] = soBaiCham;
            //Gán tb vào data source của report:
            bindingSourceThanhLyHopDong.DataSource = tb;
        }

        private void xrRichText3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           
        }
    }
}
