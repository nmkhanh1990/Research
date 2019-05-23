using PMS.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace PMS.Common
{
    public static class KiemTraDuLieuDoiTuong
    {
        public static TList<TrangThaiGiangVien> GetAllTTGV(string strNameFrom,string strNamHoc,string strHocKy)
        {
            return Services.DataServices.TrangThaiGiangVien.GetGiangVienNamHocHocKy(strNameFrom, strNamHoc, strHocKy,string.Empty);
        }
        public static string KiemTraDuLieuGiangVien(GiangVien gv, bool chua_co_trong_he_thong, string ma_truong)
        {
            gv.Cmnd = (gv.Cmnd == null ? "" : gv.Cmnd.Replace("#", "")).Trim();

            if (chua_co_trong_he_thong)
            {
                if (Services.DataServices.GiangVien.Find("MaQuanLy = '" + gv.MaQuanLy.Trim() + "'").Count > 0) return ThongBao.MA_QUAN_LY_TRUNG_LAP;

                int kiemTraTrungTenCmnd = 0;
                Services.DataServices.GiangVien.KiemTraTrungTenCmnd(gv.HoTen, gv.Cmnd, ref kiemTraTrungTenCmnd);
                if (kiemTraTrungTenCmnd == 1 && gv.Cmnd != "") return ThongBao.CMND_TRUNG_LAP;
                if (kiemTraTrungTenCmnd == 2) return ThongBao.HO_TEN_TRUNG_LAP;
            }

            if (gv.MaQuanLy == null && gv.MaQuanLy == "") return ThongBao.MA_QUAN_LY_TRONG;

            if ((gv.Cmnd == "" || gv.Cmnd == null) && "VHU".Contains(ma_truong)) return ThongBao.CMND_TRONG;

            if (!XuLySo.KiemTraChuoiToanSo(gv.Cmnd)) return ThongBao.CMND_KHONG_HOP_LE;

            if (gv.HoTen.Trim() == "" || gv.HoTen == null) return ThongBao.HO_TEN_TRONG;

            if (gv.MaDonVi == null) return ThongBao.DON_VI_TRUC_THUOC_TRONG;

            if (gv.MaHocHam == null) return ThongBao.HOC_HAM_TRONG;

            if (gv.MaHocVi == null) return ThongBao.HOC_VI_TRONG;

            if (gv.MaLoaiGiangVien == null) return ThongBao.LOAI_GIANG_VIEN_TRONG;

            if ((gv.NgayKyHopDong == null || gv.NgayKetThucHopDong == null) && "VHU".Contains(ma_truong)) return ThongBao.NGAY_HOP_DONG_TRONG;

            if (gv.NgayKyHopDong >= gv.NgayKetThucHopDong) return ThongBao.NGAY_HOP_DONG_KHONG_HOP_LE;

            if ((gv.MaTinhTrang == null) && "VHU".Contains(ma_truong)) return ThongBao.TINH_TRANG_TRONG;

            if ((gv.BacLuong == null) && "VHU".Contains(ma_truong)) return ThongBao.BAC_LUONG_TRONG;

            //if (gv.MaHeSoThuLao == null) return ThongBao.HE_SO_LUONG_TRONG;

            return ThongBao.DU_LIEU_HOP_LE;
        }

        private static bool GetTrangThaiKhoa(string strMaGiangVien,string strNamHoc,string strHocKy)
        {
            bool ichk = false;
            TList<TrangThaiGiangVien> LstTTGV = GetAllTTGV(string.Empty,strNamHoc, strHocKy);
            for (int i = 0; i < LstTTGV.Count; i++)
            {
                if (LstTTGV[i].MaGiangVien == strMaGiangVien)
                {
                    ichk = (Boolean)LstTTGV[i].TrangThai;
                    break;
                }
            }
            return ichk;
        }

        public static List<string> LstTrangThaiKhoa(DataTable tbl,string strNamHoc,string strHocKy)
        {            
            List<string> lst = new List<string>();
            foreach (DataRow r in tbl.Rows)
            {
                if (r.RowState == DataRowState.Modified)
                {
                    if (GetTrangThaiKhoa(r["MaQuanLy"].ToString(),strNamHoc,strHocKy))
                    {
                        if (lst.Count == 0)
                            lst.Add(r["MaQuanLy"].ToString());
                        else
                        {
                            for (int i = 0; i < lst.Count; i++)
                            {
                                if (r["MaQuanLy"].ToString() != lst[i].ToString())
                                {
                                    lst.Add(r["MaQuanLy"].ToString());
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            return lst;
        }

        public static string getLstKhoa(List<string> lst)
        {
            string strGet = string.Empty;
            for (int i = 0; i < lst.Count; i++)
            {
                strGet += lst[i].ToString() + ",";
            }
            if (strGet != string.Empty)
                return strGet.Substring(0, strGet.Length - 1);
            return strGet;
        }      
        

    }
}
