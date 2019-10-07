﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Common;
using DevExpress.XtraGrid.Views.Grid;
using PMS.BLL;
using DevExpress.Common.CheckedCombo;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmQuyDoiGioChuan : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnDongbo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnDongbo.ItemShortcut = DevExpress.XtraBars.BarShortcut.Empty;

                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnQuyDoi.ItemShortcut = DevExpress.XtraBars.BarShortcut.Empty;
            }
            else
            {
                btnDongbo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong, _tenTruong;
        bool _thanhToanTheoDot;        
        #endregion

        #region Event Form
        public frmQuyDoiGioChuan()
        {
            InitializeComponent();
            _maTruong =PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Mã trường");
            _tenTruong=PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Tên trường");
            try
            {
                _thanhToanTheoDot = Boolean.Parse(PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Thanh toán giờ giảng theo nhiều đợt trong học kỳ"));
            }
            catch
            {
                _thanhToanTheoDot = false;
            }
        }

        private string GetHocKy()
        {
            return PMS.Common.XuLyGiaoDien.GetHocKy(cboHocKy, cbocheckHocKy, _maTruong);
        }
        private void frmQuyDoiGioChuan_Load(object sender, EventArgs e)
        {
            #region Init GridView            
            switch (_maTruong)
            {
                case "USSH":
                    InitGridUSSH();
                    break;
                case "ACT":
                    InitGridACT();
                    break;
                case "UEL":
                    InitGridUEL();
                    break;
                case "CTIM":
                    InitGridCTIM();
                    break;
                case "IUH":
                    InitGridIUH();
                    break;
                case "BUH":
                    InitGridBUH();
                    break;
                case "VHU":
                    InitGridVHU();
                    break;
                case "CDGTVT":
                    InitGridCDGTVT();
                    break;
                case "HVHQ":
                    InitHVHQ();
                    break;
                case "LAW":
                    InitGridLAW();
                    break;
                case "HBU":
                    InitGridHBU();
                    break;
                case "DLU":
                    InitGridDLU();
                    break;
                default:
                    InitRemaining();
                    break;
            }

            #endregion

            WordWrapHeader(gridViewKhoiLuongQuyDoi, 50);

            VisibleCombobox(_maTruong);

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            cboNamHoc.Properties.NullText = string.Empty;
            #endregion

            LoadHocKy();

            if (_maTruong.Equals("DLU"))
            {
                #region cbo Đợt thanh toán
                AppGridLookupEdit.InitGridLookUp(cboDotThanhToan, true, TextEditStyles.Standard);
                AppGridLookupEdit.ShowField(cboDotThanhToan, new string[] { "MaQuanLy", "TenQuanLy", "TuNgay", "DenNgay" }, new string[] { "Mã đợt", "Tên đợt", "Từ ngày", "Đến ngày" }, new int[] { 80, 100, 100, 100 });
                AppGridLookupEdit.InitPopupFormSize(cboDotThanhToan, 380, 650);
                cboDotThanhToan.Properties.ValueMember = "MaCauHinhChotGio";
                cboDotThanhToan.Properties.DisplayMember = "TenQuanLy";
                cboDotThanhToan.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Đợt thanh toán hiện tại").GiaTri;
                cboDotThanhToan.Properties.NullText = string.Empty;
                #endregion

                #region Bậc đào tạo

                layoutControlItemBacDaoTao.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

                VList<ViewBacDaoTao> vListBacDaoTao = DataServices.ViewBacDaoTao.GetAll();
                vListBacDaoTao.Sort("TenBacDaoTao");
                List<CheckedListBoxItem> listBac = new List<CheckedListBoxItem>();
                foreach (ViewBacDaoTao v in vListBacDaoTao)
                {
                    if (UserInfo.GroupName.Equals("PDT"))
                    {
                        if ("DH;CD".Contains(v.MaBacDaoTao))
                        {
                            listBac.Add(new CheckedListBoxItem(v.MaBacDaoTao, v.TenBacDaoTao, CheckState.Unchecked, true));
                        }
                    }
                    else if (UserInfo.GroupName.Equals("PDTTX"))
                    {
                        if ("DH;CD".Contains(v.MaBacDaoTao))
                        {
                            listBac.Add(new CheckedListBoxItem(v.MaBacDaoTao, v.TenBacDaoTao, CheckState.Unchecked, true));
                        }
                    }
                    else if (UserInfo.GroupName.Equals("SDH"))
                    {
                        if ("CH;NC".Contains(v.MaBacDaoTao))
                        {
                            listBac.Add(new CheckedListBoxItem(v.MaBacDaoTao, v.TenBacDaoTao, CheckState.Unchecked, true));
                        }
                    }
                    else if (UserInfo.GroupName.Equals("Administrator"))
                    {
                        listBac.Add(new CheckedListBoxItem(v.MaBacDaoTao, v.TenBacDaoTao, CheckState.Unchecked, true));
                    }
                }

                AppCheckedComboboxEdit.InitCheckedComboBoxEdit(cboBacDaoTao, listBac);

                #endregion

                #region Hệ đào tạo
                layoutControlItemHeDaoTao.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

                VList<ViewLoaiHinhDaoTao> vListLoaiHinhDaoTao = DataServices.ViewLoaiHinhDaoTao.GetAll();
                vListLoaiHinhDaoTao.Sort("TenLoaiHinh");
                List<CheckedListBoxItem> listLoaiHinh = new List<CheckedListBoxItem>();
                foreach (ViewLoaiHinhDaoTao v in vListLoaiHinhDaoTao)
                {
                    if (UserInfo.GroupName.Equals("PDT"))
                    {
                        if ("CQ;XT".Contains(v.MaLoaiHinh))
                        {
                            listLoaiHinh.Add(new CheckedListBoxItem(v.MaLoaiHinh, v.TenLoaiHinh, CheckState.Unchecked, true));
                        }
                    }
                    else if (UserInfo.GroupName.Equals("PDTTX"))
                    {
                        if ("TC;B2".Contains(v.MaLoaiHinh))
                        {
                            listLoaiHinh.Add(new CheckedListBoxItem(v.MaLoaiHinh, v.TenLoaiHinh, CheckState.Unchecked, true));
                        }
                    }
                    else if (UserInfo.GroupName.Equals("SDH"))
                    {
                        if ("CQ".Contains(v.MaLoaiHinh))
                        {
                            listLoaiHinh.Add(new CheckedListBoxItem(v.MaLoaiHinh, v.TenLoaiHinh, CheckState.Unchecked, true));
                        }
                    }
                    else if (UserInfo.GroupName.Equals("Administrator"))
                    {
                        listLoaiHinh.Add(new CheckedListBoxItem(v.MaLoaiHinh, v.TenLoaiHinh, CheckState.Unchecked, true));
                    }
                }

                AppCheckedComboboxEdit.InitCheckedComboBoxEdit(cboLoaiHinhDaoTao, listLoaiHinh);

                #endregion
            }

            LoadGiangVien();

            KhoaDonVi();

            InitData();
        }
        #endregion

        #region InitGrid
        void InitGridACT()
        {
            AppGridView.InitGridView(gridViewKhoiLuongQuyDoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongQuyDoi, new string[] { "HocKy", "MaGiangVien", "Ho", "Ten", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "LoaiHocPhan", "MaBacDaoTao", "MaLoaiHinhDaoTao", "MaKhoaHoc", "TenCoSo", "SoLuong"
                                                                        , "HeSoLopDong", "HeSoCoSo", "HeSoQuyDoiThucHanhSangLyThuyet", "TietThucDay", "TietQuyDoi"  }
                                                         , new string[] { "Học kỳ", "Mã giảng viên", "Họ", "Tên", "Tên môn học", "Số tín chỉ", "Mã Lớp học phần", "Lớp sinh viên", "Loại học phần", "Bậc đào tạo", "Loại hình", "Mã Khóa học", "Cơ sở", "Số SV ĐK"
                                                                        , "Hệ số lớp đông", "Hệ số cơ sở", "Hệ số quy đổi TH sang LT", "Tiết thực dạy", "Tiết quy đổi"}
                                                         , new int[] { 80, 140, 120, 60, 150, 80, 100, 100, 70, 100, 100, 90, 100, 90, 100, 110, 110, 100, 100 });
            AppGridView.AlignHeader(gridViewKhoiLuongQuyDoi, new string[] { "HocKy", "MaGiangVien", "Ho", "Ten", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "LoaiHocPhan", "MaBacDaoTao", "MaLoaiHinhDaoTao", "MaKhoaHoc", "TenCoSo", "SoLuong"
                                                                        , "HeSoLopDong", "HeSoCoSo", "HeSoQuyDoiThucHanhSangLyThuyet", "TietThucDay", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewKhoiLuongQuyDoi, new string[] { "SoTinChi", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaLoaiHinhDaoTao", "HeSoLopDong", "HeSoCoSo", "HeSoQuyDoiThucHanhSangLyThuyet" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "MaGiangVien", "Tổng: {0:n0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietThucDay", "Tổng: {0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", "Tổng: {0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            //gridViewKhoiLuongQuyDoi.Columns["_hocKy"].GroupIndex = 0;
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongQuyDoi, new string[] { "HocKy", "MaGiangVien", "Ho", "Ten", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "LoaiHocPhan", "MaBacDaoTao", "MaLoaiHinhDaoTao", "MaKhoaHoc", "TenCoSo", "SoLuong"
                                                                        , "HeSoLopDong", "HeSoCoSo", "HeSoQuyDoiThucHanhSangLyThuyet", "TietThucDay", "TietQuyDoi"  });
            AppGridView.HideField(gridViewKhoiLuongQuyDoi, new string[] { "TenCoSo", "HeSoCoSo", "HocKy" });
            AppGridView.FixedField(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            btnDongbo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }

        void InitGridUSSH()
        {
            AppGridView.InitGridView(gridViewKhoiLuongQuyDoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongQuyDoi, new string[] { "HocKy", "MaGiangVien", "Ho", "Ten", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TenCoSo", "SoLuong"
                                                                        , "HeSoLopDong", "HeSoCoSo", "HeSoQuyDoiThucHanhSangLyThuyet","SoTietMonHoc", "TietThucDay", "TietQuyDoi"  }
                                                         , new string[] { "Học kỳ", "Mã giảng viên", "Họ", "Tên", "Tên môn học", "Số tín chỉ", "Mã Lớp học phần", "Lớp sinh viên", "Loại học phần", "Bậc đào tạo", "Mã Khóa học", "Cơ sở", "Số SV ĐK"
                                                                        , "Hệ số lớp đông", "Hệ số cơ sở", "Hệ số quy đổi TH sang LT", "Số tiết môn học","Tiết thực dạy", "Tiết quy đổi"}
                                                         , new int[] { 80, 140, 120, 60, 150, 80, 100, 100, 70, 100, 90, 100, 90, 100, 110, 110, 60, 100, 100 });
            AppGridView.AlignHeader(gridViewKhoiLuongQuyDoi, new string[] { "HocKy", "MaGiangVien", "Ho", "Ten", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TenCoSo", "SoLuong"
                                                                        , "HeSoLopDong", "HeSoCoSo", "HeSoQuyDoiThucHanhSangLyThuyet","SoTietMonHoc" ,"TietThucDay", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewKhoiLuongQuyDoi, new string[] { "SoTinChi", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "HeSoLopDong", "HeSoCoSo", "HeSoQuyDoiThucHanhSangLyThuyet", "SoTietMonHoc" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "MaGiangVien", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietThucDay", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            gridViewKhoiLuongQuyDoi.Columns["HocKy"].GroupIndex = 0;
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongQuyDoi);
            AppGridView.FixedField(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
        }

        void InitGridUEL()
        {
            AppGridView.InitGridView(gridViewKhoiLuongQuyDoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongQuyDoi, new string[] { "HocKy", "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TenCoSo", "SoLuong"
                                                                        , "HeSoLopDong", "HeSoCoSo", "HeSoChucDanhChuyenMon", "HeSoClcCntn", "HeSoThinhGiangMonChuyenNganh", "TietThucDay", "DonGia", "DonGiaQuyDoi", "GhiChu"  }
                                                         , new string[] { "Học kỳ", "Mã giảng viên", "Họ", "Tên", "Học hàm", "Học vị", "Tên môn học", "Số tín chỉ", "Mã Lớp học phần", "Lớp sinh viên", "Loại học phần", "Bậc đào tạo", "Mã Khóa học", "Cơ sở", "Số SV ĐK"
                                                                        , "Hệ số lớp đông", "Hệ số địa điểm và ngoài giờ", "Hệ số chức danh chuyên môn", "Hệ số lớp CLC - CNTN", "Hệ số thỉnh giảng môn chuyên ngành", "Tiết thực dạy", "Đơn giá", "Đơn giá quy đổi", "Ghi chú" }
                                                         , new int[] { 80, 140, 120, 60, 80, 80, 150, 80, 100, 100, 70, 100, 90, 100, 90, 100, 150, 150, 120, 150, 100, 80, 110, 120 });
            AppGridView.AlignHeader(gridViewKhoiLuongQuyDoi, new string[] { "HocKy", "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TenCoSo", "SoLuong"
                                                                        , "HeSoLopDong", "HeSoCoSo", "HeSoChucDanhChuyenMon", "HeSoClcCntn", "HeSoThinhGiangMonChuyenNganh", "TietThucDay", "DonGia", "DonGiaQuyDoi", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewKhoiLuongQuyDoi, new string[] { "SoTinChi", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "HeSoLopDong", "HeSoCoSo", "HeSoChucDanhChuyenMon", "HeSoClcCntn", "HeSoThinhGiangMonChuyenNganh" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "MaGiangVien", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietThucDay", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            //AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "DonGiaQuyDoi", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FixedField(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            gridViewKhoiLuongQuyDoi.Columns["HocKy"].GroupIndex = 0;
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongQuyDoi);
        }

        void InitGridCTIM()
        {
            AppGridView.InitGridView(gridViewKhoiLuongQuyDoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "MaMonHoc", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc"
                                                                        , "HeSoChucDanhChuyenMon", "HeSoThamNien", "HeSoTroCap", "HeSoLopDong" , "HeSoThinhGiangMonChuyenNganh", "HeSoQuyDoiThucHanhSangLyThuyet", "TietThucDay", "TietQuyDoi" }
                                                         , new string[] { "Mã giảng viên", "Họ", "Tên", "Học hàm", "Học vị", "Mã môn học", "Tên môn học", "Số tín chỉ", "Mã Lớp học phần", "Lớp sinh viên", "Học kỳ", "Số SV ĐK", "Loại học phần", "Bậc đào tạo", "Mã Khóa học"
                                                                        , "Hệ số chức danh", "Hệ số thâm niên","Hệ số trợ cấp", "Hệ số lớp đông", "Hệ số thỉnh giảng", "Hệ số thực hành", "Tiết dạy thực tế", "Tiết quy đổi"}
                                                         , new int[] { 110, 120, 80, 100, 100, 100, 200, 80, 110, 80, 99, 80, 100, 100, 100, 110, 100, 110, 110, 120, 120, 100, 100 });
            AppGridView.AlignHeader(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi","HeSoTroCap", "MaMonHoc", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc"
                                                                        , "HeSoChucDanhChuyenMon", "HeSoThamNien", "HeSoLopDong", "HeSoThinhGiangMonChuyenNganh", "HeSoQuyDoiThucHanhSangLyThuyet", "TietThucDay", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewKhoiLuongQuyDoi, new string[] { "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "HeSoChucDanhChuyenMon", "HeSoThamNien", "HeSoLopDong", "HeSoTroCap", "HeSoThinhGiangMonChuyenNganh", "HeSoQuyDoiThucHanhSangLyThuyet" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "MaGiangVien", "{0} GV", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietThucDay", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            gridViewKhoiLuongQuyDoi.Columns["HocKy"].GroupIndex = 0;
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongQuyDoi);
            AppGridView.FixedField(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
        }

        void InitGridIUH()
        {
            AppGridView.InitGridView(gridViewKhoiLuongQuyDoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongQuyDoi, new string[] { "Chon", "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "TenLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc"
                                                                        , "HeSoLopDong", "HeSoNgonNgu", "HeSoQuyDoiThucHanhSangLyThuyet", "TietThucDay", "TietQuyDoi", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaCoSo" }
                                                         , new string[] { "Chọn", "Mã giảng viên", "Họ", "Tên", "Học hàm", "học vị", "Tên môn học", "Số tín chỉ", "Mã Lớp học phần", "Lớp học phần", "Lớp sinh viên", "Học kỳ", "Số SV ĐK", "Loại học phần", "Bậc đào tạo", "Mã Khóa học"
                                                                        , "Hệ số lớp đông", "Hệ số ngôn ngữ", "Hệ số thực hành", "Tiết dạy thực tế", "Tiết quy đổi", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaCoSo"}
                                                         , new int[] { 50, 140, 120, 80, 90, 90, 150, 80, 100, 100, 100, 70, 100, 90, 90, 100, 90, 90, 120, 120, 90, 99, 99, 99, 99 });
            AppGridView.AlignHeader(gridViewKhoiLuongQuyDoi, new string[] { "Chon", "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "TenLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc"
                                                                        , "HeSoLopDong", "HeSoNgonNgu", "HeSoQuyDoiThucHanhSangLyThuyet", "TietThucDay", "TietQuyDoi", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaCoSo" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewKhoiLuongQuyDoi, new string[] { "Chon", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "HeSoLopDong", "HeSoQuyDoiThucHanhSangLyThuyet", "HeSoNgonNgu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "MaGiangVien", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietThucDay", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            gridViewKhoiLuongQuyDoi.Columns["HocKy"].GroupIndex = 0;
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "TenLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc"
                                                                        , "HeSoLopDong", "HeSoNgonNgu", "HeSoQuyDoiThucHanhSangLyThuyet", "TietThucDay", "TietQuyDoi"  });
            AppGridView.HideField(gridViewKhoiLuongQuyDoi, new string[] { "MaLopHocPhan" });
            layoutControlItemChonTatCa.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            AppGridView.FixedField(gridViewKhoiLuongQuyDoi, new string[] { "Chon", "MaGiangVien", "Ho", "Ten" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            AppGridView.HideField(gridViewKhoiLuongQuyDoi, new string[] { "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaCoSo" });
        }

        void InitGridBUH()
        {
            AppGridView.InitGridView(gridViewKhoiLuongQuyDoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongQuyDoi, new string[] { "Chon", "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TietThucDay"
                                                                        , "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "HeSoNgoaiGio", "HeSoLuong", "HeSoMonMoi", "TietQuyDoi"  }
                                                         , new string[] { " ","Mã giảng viên", "Họ", "Tên", "Học hàm", "Học vị", "Tên môn học", "STC", "Mã Lớp học phần", "Lớp sinh viên", "Học kỳ", "Số SV ĐK", "Loại học phần", "Bậc đào tạo", "Mã Khóa học", "Tiết thực dạy"
                                                                        , "Hệ số chức danh", "Hệ số lớp đông", "Hệ số tỉnh (hs cơ sở)", "Hệ số ngoài giờ", "Hệ số lương", "Hệ số môn mới", "Tiết quy đổi"}
                                                         , new int[] { 30, 140, 120, 70, 90, 90, 150, 60, 110, 100, 70, 100, 90, 80, 90, 100, 100, 100, 100, 100, 90, 100, 100 });
            AppGridView.AlignHeader(gridViewKhoiLuongQuyDoi, new string[] {"MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TietThucDay"
                                                                        , "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "HeSoNgoaiGio", "HeSoLuong", "HeSoMonMoi", "TietQuyDoi"   }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewKhoiLuongQuyDoi, new string[] { "SoTinChi", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TietThucDay"
                                                                        , "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "HeSoNgoaiGio", "HeSoLuong", "HeSoMonMoi", "TietQuyDoi"  }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "MaGiangVien", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietThucDay", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            gridViewKhoiLuongQuyDoi.Columns["HocKy"].GroupIndex = 0;
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TietThucDay"
                                                                        , "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "HeSoNgoaiGio", "HeSoLuong", "HeSoMonMoi", "TietQuyDoi" });
            AppGridView.FixedField(gridViewKhoiLuongQuyDoi, new string[] { "Chon", "MaGiangVien", "Ho", "Ten" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);

            layoutControlItemChonTatCa.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }

        void InitGridVHU()
        {
            AppGridView.InitGridView(gridViewKhoiLuongQuyDoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TietThucDay"
                                                                        , "HeSoLopDong", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoNgoaiGio", "HeSoCoSo", "HeSoClcCntn", "HeSoQuyDoiThucHanhSangLyThuyet", "TietQuyDoi"  }
                                                         , new string[] { "Mã giảng viên", "Họ", "Tên", "Học hàm", "Học vị", "Tên môn học", "STC", "Mã Lớp học phần", "Lớp sinh viên", "Số SV ĐK", "Loại học phần", "Bậc đào tạo", "Mã Khóa học", "Tiết thực dạy"
                                                                        , "HS lớp đông", "HS bậc đào tạo", "HS ngôn ngữ giảng dạy", "HS ngoài giờ", "HS cơ sở", "HS lớp CLC", "HS thực hành, TN, BT", "Tiết quy đổi"}
                                                         , new int[] { 140, 120, 70, 90, 90, 150, 60, 110, 70, 100, 90, 80, 90, 100, 100, 100, 100, 100, 100, 100, 100, 100 });
            AppGridView.AlignHeader(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TietThucDay"
                                                                        , "HeSoLopDong", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoNgoaiGio", "HeSoCoSo", "HeSoClcCntn", "HeSoQuyDoiThucHanhSangLyThuyet", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewKhoiLuongQuyDoi, new string[] { "SoTinChi", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TietThucDay"
                                                                        , "HeSoLopDong", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoNgoaiGio", "HeSoCoSo", "HeSoClcCntn", "HeSoQuyDoiThucHanhSangLyThuyet", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "MaGiangVien", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietThucDay", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongQuyDoi);
            AppGridView.FixedField(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);            
            int iichekc = PMS.Common.XuLyGiaoDien.CheckMaTruong(_maTruong, _tenTruong);
            if(iichekc==1)
                AppGridView.HideField(gridViewKhoiLuongQuyDoi,new string[] { "HeSoCoSo", "HeSoClcCntn", "HeSoBacDaoTao" });
        }

        void InitGridCDGTVT()
        {
            //HeSoQuyDoiThucHanhSangLyThuyet: hệ số môn thực tập; HeSoTroCap: hệ số CVHT
            AppGridView.InitGridView(gridViewKhoiLuongQuyDoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc"
                                                                       , "HeSoBacDaoTao", "HeSoLopDong", "HeSoQuyDoiThucHanhSangLyThuyet", "HeSoTroCap", "TietThucDay", "TietQuyDoi"  }
                                                         , new string[] { "Mã giảng viên", "Họ", "Tên", "Tên học phần", "Số tín chỉ", "Mã Lớp học phần", "Lớp sinh viên", "Học kỳ", "Số SV ĐK", "Loại học phần", "Bậc đào tạo", "Mã Khóa học"
                                                                        , "Hệ số bậc đào tạo", "Hệ số lớp đông", "Hệ số môn thực tập", "Hệ số CVHT", "Tiết dạy thực tế", "Tiết quy đổi" }
                                                         , new int[] { 140, 120, 80, 150, 80, 100, 100, 70, 100, 90, 110, 110, 100, 100, 90, 90, 120, 120, 90 });
            AppGridView.AlignHeader(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc"
                                                                       , "HeSoBacDaoTao", "HeSoLopDong", "HeSoQuyDoiThucHanhSangLyThuyet", "HeSoTroCap", "TietThucDay", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewKhoiLuongQuyDoi, new string[] { "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "HeSoBacDaoTao", "HeSoLopDong", "HeSoQuyDoiThucHanhSangLyThuyet", "HeSoTroCap" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "MaGiangVien", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietThucDay", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            gridViewKhoiLuongQuyDoi.Columns["HocKy"].GroupIndex = 0;
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongQuyDoi);
            AppGridView.FixedField(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
        }

        void InitHVHQ()
        {
            AppGridView.InitGridView(gridViewKhoiLuongQuyDoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc"
                                                                        , "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "TietThucDay", "SoTietThucTeQuyDoi", "TietQuyDoi"  }
                                                         , new string[] { "Mã giảng viên", "Họ", "Tên", "Tên môn học", "Số tín chỉ", "Mã Lớp học phần", "Lớp sinh viên", "Học kỳ", "Số SV ĐK", "Loại học phần", "Bậc đào tạo", "Mã Khóa học"
                                                                        , "Hệ số công việc", "Hệ số bậc đào tạo", "Hệ số ngôn ngữ", "Hệ số chức danh", "Hệ số lớp đông", "Hệ số cơ sở", "Tiết dạy thực tế", "Tiết thực tế quy đổi", "Tiết quy đổi"}
                                                         , new int[] { 140, 120, 80, 150, 80, 100, 100, 70, 100, 90, 80, 90, 100, 110, 110, 100, 90, 90, 120, 120, 90 });
            AppGridView.AlignHeader(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc"
                                                                        , "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "TietThucDay", "SoTietThucTeQuyDoi", "TietQuyDoi"  }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewKhoiLuongQuyDoi, new string[] { "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "MaGiangVien", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietThucDay", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "SoTietThucTeQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            gridViewKhoiLuongQuyDoi.Columns["HocKy"].GroupIndex = 0;
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongQuyDoi);
            btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            AppGridView.FixedField(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            AppGridView.HideField(gridViewKhoiLuongQuyDoi, new string[] { "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "SoTietThucTeQuyDoi", "TietQuyDoi" });
        }

        void InitGridLAW()
        {
            AppGridView.InitGridView(gridViewKhoiLuongQuyDoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongQuyDoi, new string[] { "Chon", "MaGiangVien", "Ho", "Ten", "TenNgach", "TenHocHam", "TenHocVi", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TenCoSo"
                                                                        , "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "TietThucDay", "HeSoNienCheTinChi", "HeSoTroCap", "SoTietThucTeQuyDoi", "MucThanhToan", "TietQuyDoi", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaCoSo" }
                                                         , new string[] { "Chọn", "Mã giảng viên", "Họ", "Tên", "Ngạch", "Học hàm", "Học vị", "Tên môn học", "Số tín chỉ", "Mã Lớp học phần", "Lớp sinh viên", "Số SV ĐK", "Loại học phần", "Bậc đào tạo", "Mã Khóa học", "Cơ sở"
                                                                        , "Hệ số công việc", "Hệ số bậc đào tạo", "Hệ số ngôn ngữ", "Hệ số chức danh", "Hệ số lớp đông", "Hệ số cơ sở", "Tiết dạy thực tế", "Hệ số niên chế-tín chỉ", "Hệ số cao học tính thêm", "Tiết thực tế quy đổi", "Mức thanh toán (%)", "Tiết quy đổi", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaCoSo"}
                                                         , new int[] { 60, 140, 120, 80, 100, 100, 100, 150, 80, 100, 100, 100, 90, 80, 90, 100, 100, 110, 110, 100, 90, 90, 120, 120, 90, 120, 90, 90, 99, 99, 99, 99 });
            AppGridView.AlignHeader(gridViewKhoiLuongQuyDoi, new string[] { "Chon", "MaGiangVien", "Ho", "Ten", "TenNgach", "TenHocHam", "TenHocVi", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TenCoSo"
                                                                        , "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "TietThucDay", "HeSoNienCheTinChi", "HeSoTroCap", "SoTietThucTeQuyDoi", "MucThanhToan", "TietQuyDoi", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaCoSo" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewKhoiLuongQuyDoi, new string[] { "Chon", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "HeSoNienCheTinChi", "HeSoTroCap", "MucThanhToan" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "MaGiangVien", "Tổng: {0:n0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietThucDay", "Tổng: {0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "SoTietThucTeQuyDoi", "Tổng: {0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", "Tổng: {0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "SoLuong", "Tổng: {0:n0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "HeSoNienCheTinChi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "SoTietThucTeQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "HeSoTroCap", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenNgach", "TenHocHam", "TenHocVi", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TenCoSo", "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu"
                                                                        , "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "TietThucDay", "HeSoNienCheTinChi", "HeSoTroCap", "SoTietThucTeQuyDoi", "MucThanhToan", "TietQuyDoi", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaCoSo" });
            AppGridView.FixedField(gridViewKhoiLuongQuyDoi, new string[] { "Chon", "MaGiangVien", "Ho", "Ten" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            AppGridView.HideField(gridViewKhoiLuongQuyDoi, new string[] { "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaCoSo" });
            layoutControlItemChonTatCa.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }

        void InitGridHBU()
        {
            AppGridView.InitGridView(gridViewKhoiLuongQuyDoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "SoLuong", "LoaiHocPhan", "MaBacDaoTao"
                                                                          , "MaKhoaHoc", "TietThucDay", "TietQuyDoiTHSangLT", "HeSoQuyDoiThucHanhSangLyThuyet", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoBacDaoTao", "HeSoNgonNgu",
                                                                            "HeSoNgoaiGio", "HeSoKhoiNganh", "TietQuyDoi"  }
                                                         , new string[] { "Mã giảng viên", "Họ", "Tên", "Học hàm", "Học vị", "Tên môn học", "STC", "Mã Lớp học phần", "Lớp sinh viên", "Số SV ĐK", "Loại học phần", "Bậc đào tạo",
                                                                        "Mã Khóa học", "Tiết thực dạy" , "ST TH quy đổi LT","Hệ số thực hành" , "HS Chức danh", "HS lớp đông", "HS bậc đào tạo", "HS ngôn ngữ giảng dạy"
                                                                        , "HS ngoài giờ", "HS khối ngành", "Tiết quy đổi"}
                                                         , new int[] { 140, 120, 70, 90, 90, 150, 60, 110, 70, 100, 100, 90, 80, 90, 100, 100, 100, 100, 100, 100, 100,100, 100 });
            AppGridView.AlignHeader(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TietQuyDoiTHSangLT", "TietThucDay"
                                                                        , "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoNgoaiGio", "HeSoKhoiNganh", "HeSoQuyDoiThucHanhSangLyThuyet", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewKhoiLuongQuyDoi, new string[] { "SoTinChi", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TietThucDay"
                                                                        , "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoNgoaiGio", "HeSoKhoiNganh", "HeSoQuyDoiThucHanhSangLyThuyet", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "MaGiangVien", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietThucDay", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongQuyDoi);
            AppGridView.FixedField(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
        }

        void InitGridDLU()
        {
            //Cho hiển thị cbo đợt
            layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

            //Ẩn nút lọc và ds gv đi
            layoutControlIcboGiangVien.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            //layoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            AppGridView.InitGridView(gridViewKhoiLuongQuyDoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "TenKhoa", "TenMonHoc", "MaKhoaCuaMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaLoaiHinhDaoTao", "MaKhoaHoc", "TietThucDay"
                                                                        , "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoBacDaoTao", "HeSoQuyDoiThucHanhSangLyThuyet", "TietQuyDoi"  }
                                                         , new string[] { "Mã giảng viên", "Họ", "Tên", "Học hàm", "Học vị", "Đơn vị trực thuộc", "Tên môn học", "Mã khoa của môn", "STC", "Mã Lớp học phần", "Lớp sinh viên", "Số SV ĐK", "Loại học phần", "Bậc đào tạo", "Loại hình", "Mã Khóa học", "Tiết thực dạy"
                                                                        , "HS Chức danh", "HS lớp đông", "HS bậc đào tạo", "Hệ số thực hành", "Tiết quy đổi"}
                                                         , new int[] { 140, 120, 70, 90, 90, 120, 150, 80, 60, 110, 70, 100, 100, 90, 100, 80, 90, 100, 100, 100, 100, 100 });
            AppGridView.AlignHeader(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "TenMonHoc", "TenKhoa", "SoTinChi", "MaLopHocPhan", "MaLop", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaLoaiHinhDaoTao", "MaKhoaHoc", "TietThucDay"
                                                                        , "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoBacDaoTao", "HeSoQuyDoiThucHanhSangLyThuyet", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewKhoiLuongQuyDoi, new string[] { "SoTinChi", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaLoaiHinhDaoTao", "MaKhoaHoc", "TietThucDay"
                                                                        , "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoBacDaoTao", "HeSoQuyDoiThucHanhSangLyThuyet", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "MaGiangVien", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietThucDay", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);

            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.HideField(gridViewKhoiLuongQuyDoi, new string[] { "MaKhoaCuaMonHoc" });
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongQuyDoi);
            AppGridView.FixedField(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewKhoiLuongQuyDoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc"
                                                                        , "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "TietThucDay", "SoTietThucTeQuyDoi", "TietQuyDoi"  }
                                                         , new string[] { "Mã giảng viên", "Họ", "Tên", "Tên môn học", "Số tín chỉ", "Mã Lớp học phần", "Lớp sinh viên", "Học kỳ", "Số SV ĐK", "Loại học phần", "Bậc đào tạo", "Mã Khóa học"
                                                                        , "Hệ số công việc", "Hệ số bậc đào tạo", "Hệ số ngôn ngữ", "Hệ số chức danh", "Hệ số lớp đông", "Hệ số cơ sở", "Tiết dạy thực tế", "Tiết thực tế quy đổi", "Tiết quy đổi"}
                                                         , new int[] { 140, 120, 80, 150, 80, 100, 100, 70, 100, 90, 80, 90, 100, 110, 110, 100, 90, 90, 120, 120, 90 });
            AppGridView.AlignHeader(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc"
                                                                        , "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "TietThucDay", "SoTietThucTeQuyDoi", "TietQuyDoi"  }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewKhoiLuongQuyDoi, new string[] { "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "MaGiangVien", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietThucDay", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "SoTietThucTeQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            gridViewKhoiLuongQuyDoi.Columns["HocKy"].GroupIndex = 0;
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongQuyDoi);
            AppGridView.FixedField(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
        }
        #endregion

        #region KhoaDonVi
        private void KhoaDonVi()
        {
            cboDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboDonVi.Properties.Items.Clear();

            VList<ViewKhoaBoMon> vListKhoa = DataServices.ViewKhoaBoMon.GetAll();
            vListKhoa.Sort("MaKhoa");
            List<CheckedListBoxItem> listKhoa = new List<CheckedListBoxItem>();
            for (int i = 0; i < vListKhoa.Count; i++)
            {
                listKhoa.Add(new CheckedListBoxItem(vListKhoa[i].MaKhoa
                    , String.Format("{0} - {1}", vListKhoa[i].MaKhoa, vListKhoa[i].TenKhoa)
                    , CheckState.Unchecked, true));
            }
            cboDonVi.Properties.Items.AddRange(listKhoa.ToArray());
            cboDonVi.Properties.SeparatorChar = ';';
            cboDonVi.CheckAll();
        }
        #endregion

        #region Giang Vien
        private void LoadGiangVien()
        {
            cboGiangVien.Properties.SelectAllItemCaption = "Tất cả";
            cboGiangVien.Properties.TextEditStyle = TextEditStyles.Standard;
            cboGiangVien.Properties.Items.Clear();

            VList<ViewGiangVien> vListGiangVien = DataServices.ViewGiangVien.GetAll();
            vListGiangVien.Sort("MaQuanLy");
            List<CheckedListBoxItem> listGV = new List<CheckedListBoxItem>();
            for (int i = 0; i < vListGiangVien.Count; i++)
            {
                listGV.Add(new CheckedListBoxItem(vListGiangVien[i].MaQuanLy
                    , String.Format("{0} - {1}", vListGiangVien[i].MaQuanLy, vListGiangVien[i].HoTen)
                    , CheckState.Unchecked, true));
            }
            cboGiangVien.Properties.Items.AddRange(listGV.ToArray());
            cboGiangVien.Properties.SeparatorChar = ';';
            cboGiangVien.CheckAll();
        }
        #endregion

        #region Hoc Ky    
        private void LoadHocKy()
        {
            if (_maTruong != "HBU")
            {
                AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
                AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã hoc kỳ", "Tên học kỳ" });
                cboHocKy.Properties.ValueMember = "MaHocKy";
                cboHocKy.Properties.DisplayMember = "TenHocKy";
                cboHocKy.Properties.NullText = string.Empty;
                cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            }
            else
            {
                cbocheckHocKy.Properties.SelectAllItemCaption = "Tất cả";
                cbocheckHocKy.Properties.TextEditStyle = TextEditStyles.Standard;
                cbocheckHocKy.Properties.Items.Clear();
                VList<ViewHocKy> VlistHocKy = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                VlistHocKy.Sort("MaHocKy");
                List<CheckedListBoxItem> listHK = new List<CheckedListBoxItem>();
                for (int i = 0; i < VlistHocKy.Count; i++)
                {
                    listHK.Add(new CheckedListBoxItem(VlistHocKy[i].MaHocKy
                        , String.Format("{0} - {1}", VlistHocKy[i].MaHocKy, VlistHocKy[i].TenHocKy)
                        , CheckState.Unchecked, true));
                }
                cbocheckHocKy.Properties.Items.AddRange(listHK.ToArray());
                cbocheckHocKy.Properties.SeparatorChar = ';';
                cbocheckHocKy.CheckAll();
            }
        }
        #endregion

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
            if (cboNamHoc.EditValue != null && cboHocKy.Text != "")
            {
                bindingSourceDot.DataSource = DataServices.CauHinhChotGio.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

        void WordWrapHeader(GridView grid, int height)
        {
            for (int i = 0; i < grid.Columns.Count; i++)
                grid.Columns[i].AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            AutoHeightHelper a = new AutoHeightHelper(grid, height);
            a.EnableColumnPanelAutoHeight();
        }

        void LoadDataTheoDot()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDotThanhToan.EditValue != null && cboDotThanhToan.EditValue.ToString() != "")
            {
                DataTable dataTable = new DataTable();
                IDataReader reader = DataServices.KhoiLuongQuyDoi.GetByBacLoaiHinhNamHocHocKyDot(cboBacDaoTao.EditValue.ToString(), cboLoaiHinhDaoTao.EditValue.ToString(), cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboDotThanhToan.EditValue.ToString()));
                dataTable.Load(reader);
                //dataTable.Columns.Add(new DataColumn("Chon", typeof(Boolean)));
                bindingSourceKhoiLuongQuyDoi.DataSource = dataTable;
                gridViewKhoiLuongQuyDoi.ExpandAllGroups();
            }
        }

        void LoadDataTheoNamHocHocKy(string strMaTruong)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (strMaTruong != "HBU")
                {
                    if (cboGiangVien.EditValue.ToString() == "")
                    {
                        PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_ChonGiangVien, MessageBoxIcon.Warning, true);
                        cboGiangVien.Focus();
                        return;
                    }
                    if (cboNamHoc.EditValue.ToString() == "" || cboHocKy.EditValue.ToString() == "")
                    {
                        PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_ChekNamHocHocKy, MessageBoxIcon.Warning, true);
                        cboNamHoc.Focus();
                        return;
                    }
                }
                else
                {
                    if (cboNamHoc.EditValue.ToString() == "" || cbocheckHocKy.EditValue.ToString() == "")
                    {
                        PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_ChekNamHocHocKy, MessageBoxIcon.Warning, true);
                        cbocheckHocKy.Focus();
                        return;
                    }
                    if (cboDonVi.EditValue.ToString() == string.Empty)
                    {
                        PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_ChonKhoa, MessageBoxIcon.Warning, true);
                        cboDonVi.Focus();
                        return;
                    }
                }
                string strLst = string.Empty, strHocKy = string.Empty;
                ListCombox(_maTruong, ref strLst, ref strHocKy);
                DataTable dataTable = new DataTable();
                IDataReader reader = DataServices.KhoiLuongQuyDoi.GetByGiangVienNamHocHocKy(strLst, cboNamHoc.EditValue.ToString(), strHocKy);
                dataTable.Load(reader);
                foreach (DataColumn col in dataTable.Columns)
                {
                    col.ReadOnly = false;
                }
                bindingSourceKhoiLuongQuyDoi.DataSource = dataTable;
                gridViewKhoiLuongQuyDoi.ExpandAllGroups();
            }
            catch (Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
            }
        }
        #endregion

        #region Ham Quy Doi
        void QuyDoiTheoGiangVienLopHocPhan_XML()
        {
            DataTable tb = bindingSourceKhoiLuongQuyDoi.DataSource as DataTable;
            string xmlData = "";
            foreach (DataRow r in tb.Rows)
            {
                if (r["Chon"].ToString().ToLower() == "true")
                {
                    xmlData += String.Format("<Input M=\"{0}\" L=\"{1}\" HH=\"{2}\" HV=\"{3}\" LGV=\"{4}\" CS=\"{5}\" />"
                            , r["MaGiangVien"].ToString(), r["MaLopHocPhan"].ToString()
                            , PMS.Common.Globals.IsNull(r["MaHocHam"], "int").ToString()
                            , PMS.Common.Globals.IsNull(r["MaHocVi"], "int").ToString()
                            , PMS.Common.Globals.IsNull(r["MaLoaiGiangVien"], "int").ToString()
                            , r["MaCoSo"].ToString());
                }
            }

            if (xmlData == "")
            {
                XtraMessageBox.Show("Vui lòng chọn những dòng muốn quy đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            xmlData = String.Format("<Root>{0}</Root>", xmlData);

            using (frmXuLyQuyDoiGioiChuan frm = new frmXuLyQuyDoiGioiChuan(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), _maTruong, xmlData, 1))
            {
                frm.ShowDialog();
            }

            LoadDataTheoNamHocHocKy(_maTruong);
        }
        void QuyDoiTheoGiangVienLopHocPhan()
        {
            try
            {
                frmXuLyQuyDoiGioiChuan frm;
                if (gridViewKhoiLuongQuyDoi.RowCount > 0)
                {
                    DataTable dt = (bindingSourceKhoiLuongQuyDoi.DataSource as DataTable).Select("Chon = 'True'").CopyToDataTable();
                    if (dt.Rows.Count > 0)
                    {
                        frm = new frmXuLyQuyDoiGioiChuan(dt, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), _maTruong);
                    }
                    else
                    {
                        frm = new frmXuLyQuyDoiGioiChuan(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), _maTruong);
                    }
                    frm.ShowDialog();
                    LoadDataTheoNamHocHocKy(_maTruong);
                }
                else
                {
                    XtraMessageBox.Show("Chưa lọc dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception ex)
            {
                XuLyGiaoDien.ThongBaoLoi(ex, true);
            }

        }
        void QuyDoiTheoNamHocHocKy()
        {
            using (frmXuLyQuyDoiGioiChuan frm = new frmXuLyQuyDoiGioiChuan(cboNamHoc.EditValue.ToString(), GetHocKy(), _maTruong))
            {
                frm.ShowDialog();
            }
            LoadDataTheoNamHocHocKy(_maTruong);
        }

        void QuyDoiTheoNamHocHocKyDotThanhToan()
        {
            if (cboDotThanhToan.EditValue.ToString() != "")
            {
                using (frmXuLyQuyDoiGioiChuan frm = new frmXuLyQuyDoiGioiChuan(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboDotThanhToan.EditValue.ToString()), cboBacDaoTao.EditValue.ToString(), cboLoaiHinhDaoTao.EditValue.ToString(), _maTruong))
                {
                    frm.ShowDialog();
                }
                LoadDataTheoDot();
            }
            else
            {
                XtraMessageBox.Show("Chưa chọn đợt thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region HamDongBo
        void DongBoTheoDot()    //Đồng bộ theo đơt thanh toán
        {

            Cursor.Current = Cursors.WaitCursor;
            if (cboDotThanhToan.EditValue.ToString() == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn đợt thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamHoc.Focus();
                return;
            }

            int kiemTraDongBo = 0;
            DataServices.KhoiLuongGiangDayChiTiet.KiemTraDongBoTheoDot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboDotThanhToan.EditValue.ToString()), ref kiemTraDongBo);

            if (kiemTraDongBo == 0)
            {

                XtraMessageBox.Show(string.Format("Dữ liệu của năm học {0} - {1} đợt {2} đã được đồng bộ.\nLưu ý: nếu đồng bộ lại toàn bộ dữ liệu cũ của năm học {0} - {1} đợt {2} sẽ bị thay thế.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotThanhToan.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (XtraMessageBox.Show("Bạn có muốn đồng bộ dữ liệu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    using (frmXuLyDongBoDuLieu frm = new frmXuLyDongBoDuLieu(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboDotThanhToan.EditValue.ToString()), _maTruong))
                    {
                        frm.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Đã xãy ra lỗi trong quá trình đồng bộ." + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadDataTheoDot();
            Cursor.Current = Cursors.Default;
        }

        void DongBoCacTruongConLai()
        {
            if (cboNamHoc.EditValue.ToString() == "" || GetHocKy() == "")
            {
                PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_ChekNamHocHocKy, MessageBoxIcon.Warning, true);
                cboNamHoc.Focus();
                return;
            }
            

            int kiemTraDongBo = 0;
            DataServices.KhoiLuongGiangDayChiTiet.KiemTraDongBo(cboNamHoc.EditValue.ToString(), GetHocKy(), ref kiemTraDongBo);
            if (kiemTraDongBo == 0)
                XtraMessageBox.Show(string.Format("Dữ liệu của năm học {0} - {1} đã được đồng bộ.\nLưu ý: nếu đồng bộ lại toàn bộ dữ liệu cũ của năm học {0} - {1} sẽ bị thay thế.", cboNamHoc.EditValue.ToString(), GetHocKy()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (XtraMessageBox.Show("Bạn có muốn đồng bộ dữ liệu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    frmXuLyDongBoDuLieu frm;
                    bindingSourceKhoiLuongQuyDoi.EndEdit(); 
                    frm = new frmXuLyDongBoDuLieu(cboNamHoc.EditValue.ToString(), GetHocKy(), _maTruong);                    
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_LoiDongBo+" "+ex.Message.ToString(), MessageBoxIcon.Error, true);                    
                }
            }

            LoadDataTheoNamHocHocKy(_maTruong);

            if (_maTruong == "IUH")
            {
                DataTable tb = bindingSourceKhoiLuongQuyDoi.DataSource as DataTable;
                foreach (DataRow r in tb.Rows)
                {
                    r["Chon"] = true;
                }
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event Button
        private void btnDongbo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (_thanhToanTheoDot)
                DongBoTheoDot();
            else
                DongBoCacTruongConLai();
            Cursor.Current = Cursors.Default;
        }

        private void btnQuyDoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                gridViewKhoiLuongQuyDoi.FocusedRowHandle = -1;
                if (cboNamHoc.EditValue.ToString() == "" || PMS.Common.XuLyGiaoDien.GetHocKy(  cboHocKy,cbocheckHocKy, _maTruong)=="")
                {
                    PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_ChekNamHocHocKy, MessageBoxIcon.Warning, true);
                    cboNamHoc.Focus();
                    return;
                }

                switch (_maTruong)
                {
                    case "IUH":
                        QuyDoiTheoGiangVienLopHocPhan_XML();
                        break;
                    case "LAW":
                        QuyDoiTheoGiangVienLopHocPhan_XML();
                        break;
                    case "BUH":
                        QuyDoiTheoGiangVienLopHocPhan();
                        break;
                    case "DLU":
                        QuyDoiTheoNamHocHocKyDotThanhToan();
                        break;
                    default:
                        QuyDoiTheoNamHocHocKy();
                        break;
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (_thanhToanTheoDot)
            {
                LoadDataTheoDot();
            }
            else
            {
                LoadDataTheoNamHocHocKy(_maTruong);
            }
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InitData();
            if (_thanhToanTheoDot)
            {
                LoadDataTheoDot();
            }
            else
            {
                LoadDataTheoNamHocHocKy(_maTruong);
            }
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlKhoiLuongQuyDoi.ExportToXls(sf.FileName);
                            PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_XuatFile, MessageBoxIcon.Information, true);
                        }
                }
            }
            catch (Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_LoiXuatFile+" "+ex.Message.ToString(), MessageBoxIcon.Error, true);

            }
        }
        #endregion

        #region Event Grid
        private void gridViewKhoiLuongQuyDoi_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            try
            {
                if (_maTruong == "IUH")
                {
                    if (e.Column.FieldName == "HeSoQuyDoiThucHanhSangLyThuyet")
                    {
                        if (Convert.ToDouble(e.Value) == 0.67)
                            e.DisplayText = "2/3";
                    }
                }

                if (_maTruong == "LAW")
                {
                    if (e.Column.FieldName == "HeSoNienCheTinChi")
                    {
                        if (Convert.ToDouble(e.Value) == 1.111111)
                            e.DisplayText = "50/45";
                    }

                    if (e.Column.FieldName == "HeSoTroCap")
                    {
                        if (Convert.ToDouble(e.Value) == 1.333333)
                            e.DisplayText = "20/15";
                    }
                }
            }
            catch
            { }

        }
        #endregion

        #region Event CheckEdit
        private void checkEditChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            PMS.Common.XuLyGiaoDien.CheckAll(gridViewKhoiLuongQuyDoi, "Chon", checkEditChonTatCa.Checked);
        }
        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboNamHoc.EditValue != null)
                {
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                }

                if (_maTruong == "IUH")
                {
                    if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                    {
                        ThoiGianGiangDay _tg = DataServices.ThoiGianGiangDay.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                        if (_tg != null)
                        {
                            dateEditTuNgay.EditValue = _tg.NgayBatDau;
                            dateEditDenNgay.EditValue = _tg.NgayKetThuc;
                        }
                        else
                        {
                            XtraMessageBox.Show(string.Format("Năm học {0} - {1} chưa được định nghĩa ngày bắt đầu và kết thúc.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dateEditTuNgay.EditValue = null;
                            dateEditDenNgay.EditValue = null;
                        }
                    }
                }
                else
                {
                    if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                    {
                        bindingSourceDot.DataSource = DataServices.CauHinhChotGio.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    }
                }

                if (_thanhToanTheoDot)
                {
                    LoadDataTheoDot();
                }
            }
            catch
            {

            }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (_maTruong == "IUH")
                {
                    if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                    {
                        ThoiGianGiangDay _tg = DataServices.ThoiGianGiangDay.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                        if (_tg != null)
                        {
                            dateEditTuNgay.EditValue = _tg.NgayBatDau;
                            dateEditDenNgay.EditValue = _tg.NgayKetThuc;
                        }
                        else
                        {
                            XtraMessageBox.Show(string.Format("Năm học {0} - {1} chưa được định nghĩa ngày bắt đầu và kết thúc.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dateEditTuNgay.EditValue = null;
                            dateEditDenNgay.EditValue = null;
                        }
                    }
                }
                else
                {
                    if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                    {
                        bindingSourceDot.DataSource = DataServices.CauHinhChotGio.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    }
                }


                if (_thanhToanTheoDot)
                {
                    LoadDataTheoDot();
                }
            }
            catch
            {

            }
        }
        #endregion

        private void cboDotThanhToan_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CauHinhChotGio objCauHinh = cboDotThanhToan.GetSelectedDataRow() as CauHinhChotGio;

                dateEditTuNgay.EditValue = objCauHinh.TuNgay;
                dateEditDenNgay.EditValue = objCauHinh.DenNgay;

                if (_thanhToanTheoDot)
                {
                    LoadDataTheoDot();
                }
            }
            catch
            { }
        }

        private void VisibleCombobox(string strMaTruong)
        {
            if (strMaTruong != "HBU")
            {
                layoutControlcbohocky.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlIcboGiangVien.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlKhoa.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControl_cboHocKy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            else
            {
                layoutControlcbohocky.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControl_cboHocKy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControl_cboHocKy.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
                layoutControlKhoa.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlKhoa.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            }
        }

        private void ListCombox(string strMaTruong,ref string strLst,ref string strHocKy)
        {
            if (strMaTruong != "HBU")
            {
                strLst = cboGiangVien.EditValue.ToString();
                strHocKy = cboHocKy.EditValue.ToString();
            }
            else
            {
                strLst = cboDonVi.EditValue.ToString();
                strHocKy = cbocheckHocKy.EditValue.ToString();
            }
        }
    }
}
