using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using PMS.UI.Forms.NghiepVu;
using PMS.BLL;
using DevExpress.XtraGrid.Views.Base;

namespace PMS.UI.Modules.DanhMucTheoNam
{
    public partial class ucTietNghiaVuTheoNamHoc : DevExpress.XtraEditors.XtraUserControl
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ItemShortcut = DevExpress.XtraBars.BarShortcut.Empty;


                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnSaoChep.ItemShortcut = DevExpress.XtraBars.BarShortcut.Empty;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        TList<GiamTruDinhMuc> _listGiamTruKhac = new TList<GiamTruDinhMuc>();
        TList<TrangThaiGiangVien> lstTTGV;
        string _maTruong = string.Empty;
        string strTenTruong = string.Empty;
        string icboHocKyindex = string.Empty;
        List<string> ToMauIndex = new List<string>();
        List<string> LstIdMaGV = new List<string>();
        List<int> LstIndexReadOnly;
        #endregion

        public ucTietNghiaVuTheoNamHoc()
        {
            InitializeComponent();
            _maTruong = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Mã trường");
            strTenTruong = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Tên trường");
            lstTTGV = new TList<TrangThaiGiangVien>();
            LstIndexReadOnly = new List<int>();

        }

        private void GetAllTrangThaiGiangVien()
        {
            lstTTGV = PMS.Common.KiemTraDuLieuDoiTuong.GetAllTTGV(string.Empty, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }
        void EnableCheckEdit()
        {
            layoutControlI_XemTheoHockKy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }

        private void ucTietNghiaVuTheoNamHoc_Load(object sender, EventArgs e)
        {
            try
            {
                #region Init GirdView           
                switch (_maTruong)
                {
                    case "VHU":
                        InitGridVHU();
                        layoutControlI_hocky.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        break;
                    case "DLU":
                        InitGridDLU();
                        break;
                    case "HBU":
                        InitGridHBU();
                       // EnableCheckEdit();
                        break;
                    case "BUH":
                        InitGridDLU();
                        break;
                    default:
                        InitGridVHU();
                        break;
                }
                #endregion

                #region Nam hoc
                AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
                AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
                cboNamHoc.Properties.ValueMember = "NamHoc";
                cboNamHoc.Properties.DisplayMember = "NamHoc";
                cboNamHoc.Properties.NullText = string.Empty;
                cboNamHoc.EditValue = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Năm học hiện tại");
                #endregion

                #region Hoc ky
                AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
                AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
                cboHocKy.Properties.ValueMember = "MaHocKy";
                cboHocKy.Properties.DisplayMember = "TenHocKy";
                cboHocKy.Properties.NullText = string.Empty;
                cboHocKy.EditValue = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Học kỳ hiện tại");
                #endregion

                InitGiamTruKhac();

                InitData();
            }
            catch (Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
            }
        }

        #region InitGridView { }
        void InitGiamTruKhac()
        {
            switch (_maTruong)
            {
                case "DLU":
                case "BUH":
                    #region GiamTruKhac
                    AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiamTruKhac, TextEditStyles.Standard);
                    AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiamTruKhac, new string[] { "NoiDungGiamTru", "MucGiam", "MucGiamNckh", "DonVi" }, new string[] { "Nội dung giảm trừ", "Mức giảm giảng dạy", "Mức giảm NCKH", "Đơn vị" }, new int[] { 200, 100, 100, 100 });
                    AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiamTruKhac, 500, 500);
                    repositoryItemGridLookUpEditGiamTruKhac.DisplayMember = "NoiDungGiamTru";
                    repositoryItemGridLookUpEditGiamTruKhac.ValueMember = "MaQuanLy";
                    repositoryItemGridLookUpEditGiamTruKhac.NullText = String.Empty;
                    #endregion
                    break;
                default:
                    #region GiamTruKhac
                    AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiamTruKhac, TextEditStyles.Standard);
                    AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiamTruKhac, new string[] { "NoiDungGiamTru", "MucGiam", "DonVi" }, new string[] { "Nội dung giảm trừ", "Mức giảm", "Đơn vị" }, new int[] { 200, 100, 100 });
                    AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiamTruKhac, 400, 500);
                    repositoryItemGridLookUpEditGiamTruKhac.DisplayMember = "NoiDungGiamTru";
                    repositoryItemGridLookUpEditGiamTruKhac.ValueMember = "MaQuanLy";
                    repositoryItemGridLookUpEditGiamTruKhac.NullText = String.Empty;
                    #endregion
                    break;
            }
        }

        void InitGridVHU()
        {
            AppGridView.InitGridView(gridViewTietNghiaVu, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewTietNghiaVu, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu"
                    , "TietNghiaVuGiangDay", "TietNghiaVuNckh", "TietNghiaVuQuanLy", "DinhMucToiThieuCuaChucVu", "TietGiangDayGiamDoChucVu"
                    , "TietNghiaVuQuanLyKiemNhiem", "MaGiamTruKhac", "SoTietGiamTruKhac", "TongTietGiamDoTamNghi", "TietNo_BaoLuuGiangDay", "TietNo_BaoLuuNckh", "TietBaoLuuNckh", "TietNo_BaoLuuQuanLy"
                    , "GioChuanGiangDayChuyenSangNckh", "TietGiangDayDuocGiam", "TietNckhDuocGiam", "TietQuanLyDuocGiam", "GhiChu", "MaGiangVien" }
                , new string[] { "Khoa - Đơn vị", "Mã giảng viên", "Họ và tên", "Học hàm", "Học vị", "Chức vụ", "Định mức GC giảng dạy", "Định mức GC NCKH"
                    , "Định mức GC TGQL", "Định mức tối thiểu chức vụ", "GC giảm do chức vụ", "Định mức TGQL kiêm nhiệm", "Giảm trừ khác", "Số GC giảm khác"
                    , "Tiết giảm theo thời gian", "GC nợ giảng dạy", "GC nợ/bảo lưu NCKH", "GC NCKH bảo lưu", "GC nợ TGQL", "GC giảng dạy chuyển sang NCKH"
                    , "Tổng GC giảng dạy", "Tổng GC NCKH", "Tổng GC TGQL", "Ghi chú", "MaGiangVien" }
                , new int[] { 90, 90, 140, 100, 100, 100, 90, 90, 90, 90, 90, 100, 100, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 120, 99 });
            AppGridView.AlignHeader(gridViewTietNghiaVu, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "TietNghiaVuGiangDay", "TietNghiaVuNckh", "TietNghiaVuQuanLy"
                , "DinhMucToiThieuCuaChucVu", "TietGiangDayGiamDoChucVu", "TietNghiaVuQuanLyKiemNhiem", "MaGiamTruKhac", "SoTietGiamTruKhac", "TongTietGiamDoTamNghi"
                , "TietNo_BaoLuuGiangDay", "TietNo_BaoLuuNckh", "TietBaoLuuNckh", "TietNo_BaoLuuQuanLy", "GioChuanGiangDayChuyenSangNckh", "TietGiangDayDuocGiam", "TietNckhDuocGiam", "TietQuanLyDuocGiam", "GhiChu", "MaGiangVien" }
                , DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewTietNghiaVu, new string[] { "TenDonVi", "TenHocHam", "TenHocVi", "TenChucVu", "TietNghiaVuGiangDay", "TietNghiaVuNckh", "TietNghiaVuQuanLy", "DinhMucToiThieuCuaChucVu"
                , "TietGiangDayGiamDoChucVu", "TietNghiaVuQuanLyKiemNhiem", "SoTietGiamTruKhac", "TongTietGiamDoTamNghi", "TietNo_BaoLuuGiangDay", "TietNo_BaoLuuNckh", "TietBaoLuuNckh", "TietNo_BaoLuuQuanLy"
                , "TietGiangDayDuocGiam", "TietNckhDuocGiam", "TietQuanLyDuocGiam", "MaGiangVien" });
            AppGridView.HideField(gridViewTietNghiaVu, new string[] { "MaGiangVien", "MaGiamTruKhac", "TietBaoLuuNckh", "GioChuanGiangDayChuyenSangNckh" });           
            AppGridView.RegisterControlField(gridViewTietNghiaVu, "MaGiamTruKhac", repositoryItemGridLookUpEditGiamTruKhac);
            AppGridView.FixedField(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen" }, FixedStyle.Left);
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TietNo_BaoLuuGiangDay", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TietNo_BaoLuuNckh", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TietBaoLuuNckh", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TietNo_BaoLuuQuanLy", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "SoTietGiamTruKhac", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TongTietGiamDoTamNghi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TietGiangDayDuocGiam", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TietNckhDuocGiam", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TietQuanLyDuocGiam", DevExpress.Utils.FormatType.Custom, "n2");
            //gridViewTietNghiaVu.Columns["TenDonVi"].GroupIndex = 0;
            AppGridView.SummaryField(gridViewTietNghiaVu, "MaQuanLy", "{0} GV", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewTietNghiaVu, "TietGiangDayDuocGiam", "{0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewTietNghiaVu, "TietNckhDuocGiam", "{0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewTietNghiaVu, "TietQuanLyDuocGiam", "{0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.BackColorFieldAppearance(gridViewTietNghiaVu, new string[] { "TietNghiaVuGiangDay", "TietGiangDayGiamDoChucVu", "TietNo_BaoLuuGiangDay", "TietGiangDayDuocGiam" }, Color.FromArgb(235, 220, 255));
            AppGridView.BackColorFieldAppearance(gridViewTietNghiaVu, new string[] { "TietNghiaVuNckh", "TietNo_BaoLuuNckh", "TietBaoLuuNckh", "TietNckhDuocGiam" }, Color.FromArgb(230, 255, 245));
            AppGridView.BackColorFieldAppearance(gridViewTietNghiaVu, new string[] { "TietNghiaVuQuanLy", "TietNo_BaoLuuQuanLy", "TietQuanLyDuocGiam" }, Color.FromArgb(255, 250, 240));
            PMS.Common.Globals.WordWrapHeader(gridViewTietNghiaVu, 40);
        }

        void InitGridHBU()
        {
            AppGridView.InitGridView(gridViewTietNghiaVu, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewTietNghiaVu, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu"
                    , "TietNghiaVuGiangDay", "TietNghiaVuNckh", "TietNghiaVuQuanLy", "DinhMucToiThieuCuaChucVu", "TietGiangDayGiamDoChucVu"
                    , "TietNghiaVuQuanLyKiemNhiem", "MaGiamTruKhac", "SoTietGiamTruKhac", "TongTietGiamDoTamNghi", "TietNo_BaoLuuGiangDay", "TietNo_BaoLuuNckh", "TietBaoLuuNckh", "TietNo_BaoLuuQuanLy"
                    , "GioChuanGiangDayChuyenSangNckh", "TietGiangDayDuocGiam", "TietNckhDuocGiam", "TietQuanLyDuocGiam", "GhiChu", "MaGiangVien" }
                , new string[] { "Khoa - Đơn vị", "Mã giảng viên", "Họ và tên", "Học hàm", "Học vị", "Chức vụ", "Định mức GC giảng dạy", "Định mức GC NCKH"
                    , "Định mức GC TGQL", "Định mức tối thiểu chức vụ", "GC giảm do chức vụ", "Định mức TGQL kiêm nhiệm", "Giảm trừ khác", "Số GC giảm khác"
                    , "Tiết giảm theo thời gian", "GC nợ giảng dạy", "GC nợ/bảo lưu NCKH", "GC NCKH bảo lưu", "GC nợ TGQL", "GC giảng dạy chuyển sang NCKH"
                    , "Tổng GC giảng dạy", "Tổng GC NCKH", "Tổng GC TGQL", "Ghi chú", "MaGiangVien" }
                , new int[] { 90, 90, 140, 100, 100, 100, 90, 90, 90, 90, 90, 100, 100, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 120, 99 });
            AppGridView.AlignHeader(gridViewTietNghiaVu, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "TietNghiaVuGiangDay", "TietNghiaVuNckh", "TietNghiaVuQuanLy"
                , "DinhMucToiThieuCuaChucVu", "TietGiangDayGiamDoChucVu", "TietNghiaVuQuanLyKiemNhiem", "MaGiamTruKhac", "SoTietGiamTruKhac", "TongTietGiamDoTamNghi"
                , "TietNo_BaoLuuGiangDay", "TietNo_BaoLuuNckh", "TietBaoLuuNckh", "TietNo_BaoLuuQuanLy", "GioChuanGiangDayChuyenSangNckh", "TietGiangDayDuocGiam", "TietNckhDuocGiam", "TietQuanLyDuocGiam", "GhiChu", "MaGiangVien" }
                , DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewTietNghiaVu, new string[] { "TenDonVi", "TenHocHam", "TenHocVi", "TenChucVu", "TietNghiaVuGiangDay", "TietNghiaVuNckh", "TietNghiaVuQuanLy", "DinhMucToiThieuCuaChucVu"
                , "TietGiangDayGiamDoChucVu", "TietNghiaVuQuanLyKiemNhiem", "SoTietGiamTruKhac", "TongTietGiamDoTamNghi", "TietNo_BaoLuuGiangDay", "TietNo_BaoLuuNckh", "TietBaoLuuNckh", "TietNo_BaoLuuQuanLy"
                , "TietGiangDayDuocGiam", "TietNckhDuocGiam", "TietQuanLyDuocGiam", "MaGiangVien" });
            AppGridView.HideField(gridViewTietNghiaVu, new string[] { "MaGiangVien", "MaGiamTruKhac", "TietBaoLuuNckh", "GioChuanGiangDayChuyenSangNckh" });
            AppGridView.RegisterControlField(gridViewTietNghiaVu, "MaGiamTruKhac", repositoryItemGridLookUpEditGiamTruKhac);
            AppGridView.FixedField(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen" }, FixedStyle.Left);
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TietNo_BaoLuuGiangDay", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TietNo_BaoLuuNckh", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TietBaoLuuNckh", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TietNo_BaoLuuQuanLy", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "SoTietGiamTruKhac", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TongTietGiamDoTamNghi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TietGiangDayDuocGiam", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TietNckhDuocGiam", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TietQuanLyDuocGiam", DevExpress.Utils.FormatType.Custom, "n2");
            //gridViewTietNghiaVu.Columns["TenDonVi"].GroupIndex = 0;
            AppGridView.SummaryField(gridViewTietNghiaVu, "MaQuanLy", "{0} GV", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewTietNghiaVu, "TietGiangDayDuocGiam", "{0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewTietNghiaVu, "TietNckhDuocGiam", "{0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewTietNghiaVu, "TietQuanLyDuocGiam", "{0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.BackColorFieldAppearance(gridViewTietNghiaVu, new string[] { "TietNghiaVuGiangDay", "TietGiangDayGiamDoChucVu", "TietNo_BaoLuuGiangDay", "TietGiangDayDuocGiam" }, Color.FromArgb(235, 220, 255));
            AppGridView.BackColorFieldAppearance(gridViewTietNghiaVu, new string[] { "TietNghiaVuNckh", "TietNo_BaoLuuNckh", "TietBaoLuuNckh", "TietNckhDuocGiam" }, Color.FromArgb(230, 255, 245));
            AppGridView.BackColorFieldAppearance(gridViewTietNghiaVu, new string[] { "TietNghiaVuQuanLy", "TietNo_BaoLuuQuanLy", "TietQuanLyDuocGiam" }, Color.FromArgb(255, 250, 240));
            PMS.Common.Globals.WordWrapHeader(gridViewTietNghiaVu, 40);
        }

        void InitGridDLU()
        {
            AppGridView.InitGridView(gridViewTietNghiaVu, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewTietNghiaVu, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "TietNghiaVuGiangDayBanDau", "TietNghiaVuNckhBanDau", "DinhMucToiThieuCuaChucVu", "TietGiangDayDuocGiam", "TietNckhDuocGiam", "MaGiamTruKhac", "SoTietGiamTruKhac", "TietNo_BaoLuuGiangDay", "TietNo_BaoLuuNcKh", "SumTietnghiaVuGiangDay", "TietNghiaVuGiangDay", "SumTietNghiaVuNckh", "TietNghiaVuNckh", "MaGiangVien", "GhiChu" }
                , new string[] { "Khoa - Đơn vị", "Mã giảng viên", "Họ và tên", "Học hàm", "Học vị", "Chức vụ", "Định mức GC giảng dạy", "Định mức GC NCKH", "Định mức do chức vụ (%)", "Tiết giảng dạy được giảm", "Tiết NCKH được giảm", "Giảm trừ khác", "Số tiết giảm khác", "Giờ chuẩn giảng dạy nợ/bảo lưu", "Giờ chuẩn NCKH nợ/bảo lưu", "Tổng giờ chuẩn giảng dạy", "Tổng giờ chuẩn giảng dạy đã lưu", "Tổng giờ chuẩn NCKH", "Tổng giờ chuẩn NCKH đã lưu", "MaGiangVien", "Ghi chú" }
                , new int[] { 100, 110, 130, 90, 80, 100, 90, 90, 90, 100, 90, 90, 90, 110, 100, 90, 90, 90, 90, 50, 500 });
            AppGridView.AlignHeader(gridViewTietNghiaVu, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "TietNghiaVuGiangDayBanDau", "TietNghiaVuNckhBanDau", "DinhMucToiThieuCuaChucVu", "TietGiangDayDuocGiam", "TietNckhDuocGiam", "MaGiamTruKhac", "SoTietGiamTruKhac", "TietNo_BaoLuuGiangDay", "TietNo_BaoLuuNcKh", "SumTietnghiaVuGiangDay", "SumTietNghiaVuNckh", "MaGiangVien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTietNghiaVu, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            string[] strchuoi;
            if (_maTruong == "BUH")
            {
                strchuoi = new string[] { "TenDonVi", "TenHocHam", "TenHocVi", "TenChucVu", "TietNghiaVuGiangDayBanDau", "TietNghiaVuNckhBanDau", "DinhMucToiThieuCuaChucVu", "SoTietGiamTruKhac", "TietNo_BaoLuuGiangDay", "TietNo_BaoLuuNcKh", "MaGiangVien", "TietNghiaVuGiangDay", "TietNghiaVuNckh" };
            }
            else
            {
                strchuoi = new string[] { "TenDonVi", "TenHocHam", "TenHocVi", "TenChucVu", "TietNghiaVuGiangDayBanDau", "TietNghiaVuNckhBanDau", "DinhMucToiThieuCuaChucVu", "TietGiangDayDuocGiam", "TietNckhDuocGiam", "SoTietGiamTruKhac", "TietNo_BaoLuuGiangDay", "TietNo_BaoLuuNcKh", "MaGiangVien", "TietNghiaVuGiangDay", "TietNghiaVuNckh" };
            }
            AppGridView.ReadOnlyColumn(gridViewTietNghiaVu, strchuoi);

            AppGridView.HideField(gridViewTietNghiaVu, new string[] { "MaGiangVien", "MaGiamTruKhac", "SoTietGiamTruKhac" });
            AppGridView.RegisterControlField(gridViewTietNghiaVu, "MaGiamTruKhac", repositoryItemGridLookUpEditGiamTruKhac);
            AppGridView.FixedField(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen" }, FixedStyle.Left);
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TietNghiaVuGiangDayBanDau", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TietNghiaVuNckhBanDau", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "SumTietnghiaVuGiangDay", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "SumTietNghiaVuNckh", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "SoTietGiamTruKhac", DevExpress.Utils.FormatType.Custom, "n2");
            gridViewTietNghiaVu.Columns["TenDonVi"].GroupIndex = 0;
            PMS.Common.Globals.WordWrapHeader(gridViewTietNghiaVu, 35);
        }
        #endregion

        #region InitData
        void InitData()
        {
            _listGiamTruKhac = DataServices.GiamTruDinhMuc.GetAll();
            bindingSourceGiamTruKhac.DataSource = _listGiamTruKhac;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            LoadDataSource(cboNamHoc.EditValue.ToString());
        }

        void LoadDataSource(string strHocKy)
        {
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

                DataTable tb = new DataTable();
                IDataReader reader;

                switch (_maTruong)
                {
                    case "BUH":
                        if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                        {
                            reader = DataServices.TietNghiaVu.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                        }
                        else return;
                        break;
                    default:
                        reader = DataServices.TietNghiaVu.GetByNamHoc(strHocKy);
                        break;
                }

                tb.Load(reader);

                foreach (DataColumn col in tb.Columns)
                    col.ReadOnly = false;
                bindingSourceTietNghiaVu.DataSource = tb;
                if (_maTruong == "BUH")
                {
                    GetAllTrangThaiGiangVien();
                    ToMau(tb);

                }
                gridViewTietNghiaVu.ExpandAllGroups();
            }
        }
        #endregion

        #region Thêm
        private void ToMau(DataTable tbl)
        {
            ToMauIndex.Clear();
            LstIdMaGV.Clear();
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                decimal dSumTietnghiaVuGiangDay = decimal.Parse(tbl.Rows[i]["SumTietnghiaVuGiangDay"].ToString());
                decimal dSumTietNghiaVuNckh = decimal.Parse(tbl.Rows[i]["SumTietNghiaVuNckh"].ToString());
                if (dSumTietnghiaVuGiangDay.ToString() != tbl.Rows[i]["TietnghiaVuGiangDay"].ToString()
                     || dSumTietNghiaVuNckh.ToString() != tbl.Rows[i]["TietNghiaVuNckh"].ToString()
                     )
                {

                    ToMauIndex.Add(tbl.Rows[i]["MaQuanLy"].ToString());
                }
                string strMaQuanLy = tbl.Rows[i]["MaQuanLy"].ToString();
                bool bchk = AppGridControl.chkKhoa(lstTTGV, strMaQuanLy);
                if (bchk)
                {
                    if (LstIdMaGV.Count == 0)
                        LstIdMaGV.Add(strMaQuanLy);
                    else
                    {
                        for (int j = 0; j < LstIdMaGV.Count; j++)
                        {
                            if (LstIdMaGV[j].ToString() != strMaQuanLy)
                                LstIdMaGV.Add(strMaQuanLy);
                        }
                    }
                }

            }
        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewTietNghiaVu.FocusedRowHandle = -1;
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataTable list = bindingSourceTietNghiaVu.DataSource as DataTable;
                if (list != null)
                {
                    try
                    {
                        string xmlData = "";
                        foreach (DataRow kl in list.Rows)
                        {
                            //if (kl.RowState == DataRowState.Modified)
                            //{
                            string[] MangKiTu = { "<=", ">=", "<", ">" };
                            string[] MangMoTa = { "nhỏ hơn bằng", "lớn hơn bằng", "nhỏ hơn_", "lớn hơn_" };
                            string strGhiChu = kl["GhiChu"].ToString();
                            for (int i = 0; i < MangKiTu.Length; i++)
                            {
                                strGhiChu = strGhiChu.Replace(MangKiTu[i], MangMoTa[i]);
                            }
                            xmlData += String.Format("<Input M=\"{0}\" G=\"{1}\" TG=\"{2}\" GD=\"{3}\" NC=\"{4}\" QL=\"{5}\" C=\"{6}\"  GK=\"{7}\" NK=\"{8}\" GC=\"{9}\" TDG=\"{10}\" TNG=\"{11}\" />"
                                    , kl["MaGiangVien"]
                                    , PMS.Common.Globals.IsNull(kl["MaGiamTruKhac"], "int").ToString()
                                    , PMS.Common.Globals.IsNull(kl["SoTietGiamTruKhac"], "decimal")
                                    , PMS.Common.Globals.IsNull(kl["SumTietNghiaVuGiangDay"], "decimal")
                                    , PMS.Common.Globals.IsNull(kl["SumTietNghiaVuNckh"], "decimal")
                                    , PMS.Common.Globals.IsNull(kl["SumTietNghiaVuQuanly"], "decimal")
                                    , PMS.Common.Globals.IsNull(kl["GioChuanGiangDayChuyenSangNckh"], "decimal")
                                    , PMS.Common.Globals.IsNull(kl["TietGiamKhacGiangDay"], "decimal")
                                    , PMS.Common.Globals.IsNull(kl["TietGiamKhacNckh"], "decimal")
                                    , strGhiChu
                                    , PMS.Common.Globals.IsNull(kl["TietGiangDayDuocGiam"], "decimal")
                                    , PMS.Common.Globals.IsNull(kl["TietNckhDuocGiam"], "decimal"));
                            //}
                        }
                        //xmlData = string.Format("<Root>{0}</Root>", xmlData);
                        xmlData = "<Root>" + xmlData + "</Root>";
                        bindingSourceTietNghiaVu.EndEdit();
                        int kq = 0;
                        DataServices.TietNghiaVu.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepTietNghiaVu"))
            {
                frm.ShowDialog();
            }
            InitData();
        }
        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            icboHocKyindex = cboNamHoc.EditValue.ToString();
            LoadDataSource(icboHocKyindex);
        }

        #endregion

        private void gridViewTietNghiaVu_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                GridColumn col = e.Column;
                int pos = e.RowHandle;
                if (_maTruong == "DLU")
                {
                    if (col.FieldName == "MaGiamTruKhac" || col.FieldName == "GioChuanGiangDayChuyenSangNckh")
                    {
                        DataRowView row = gridViewTietNghiaVu.GetRow(e.RowHandle) as DataRowView;
                        GiamTruDinhMuc g;

                        decimal? _tietNghiaVuGiangDay = 0, _tietGiangDayGiamDoChucVu, _tietGiangDayGiamKhac = 0, _tietKyTruoc, _reSult, _gioChuanGiangDayChuyenSangNckh, _tietNCKH
                                , _dinhMucNcKh, _noNckh, _tietNCKHGiamDoChucVu, _tietNCKHGiamKhac = 0, _tietGiangDayGiamDoTamNghi, _tietNckhGiamDoTamNghi;

                        _tietNghiaVuGiangDay = decimal.Parse(PMS.Common.Globals.IsNull(row["TietNghiaVuGiangDay"], "decimal").ToString());
                        _tietGiangDayGiamDoChucVu = decimal.Parse(PMS.Common.Globals.IsNull(row["SubTietGiangDayGiamDoChucVu"], "decimal").ToString());
                        _tietNCKHGiamDoChucVu = decimal.Parse(PMS.Common.Globals.IsNull(row["TietNckhGiamDoChucVu"], "decimal").ToString());
                        _tietKyTruoc = decimal.Parse(PMS.Common.Globals.IsNull(row["TietNo_BaoLuuGiangDay"], "decimal").ToString());
                        _gioChuanGiangDayChuyenSangNckh = decimal.Parse(PMS.Common.Globals.IsNull(row["GioChuanGiangDayChuyenSangNckh"], "decimal").ToString());
                        _dinhMucNcKh = decimal.Parse(PMS.Common.Globals.IsNull(row["TietNghiaVuNckh"], "decimal").ToString());
                        _noNckh = decimal.Parse(PMS.Common.Globals.IsNull(row["TietNo_BaoLuuNcKh"], "decimal").ToString());
                        _tietGiangDayGiamDoTamNghi = decimal.Parse(PMS.Common.Globals.IsNull(row["SoTietGiangDayDuocGiamDoTamNghi"], "decimal").ToString());
                        _tietNckhGiamDoTamNghi = decimal.Parse(PMS.Common.Globals.IsNull(row["SoTietNckhDuocGiamDoTamNghi"], "decimal").ToString());

                        try
                        {
                            g = _listGiamTruKhac.Find(p => p.MaQuanLy == int.Parse(row["MaGiamTruKhac"].ToString()));

                            if (g.DonVi.ToLower() == "phantram")
                            {
                                _tietGiangDayGiamKhac = (_tietNghiaVuGiangDay * (g.MucGiam)) / 100;
                                _tietNCKHGiamKhac = (_dinhMucNcKh * g.MucGiamNckh) / 100;
                            }
                            else
                            {
                                _tietGiangDayGiamKhac = g.MucGiam;
                                _tietNCKHGiamKhac = g.MucGiamNckh;
                            }
                        }
                        catch
                        { }

                        _reSult = _tietNghiaVuGiangDay - _tietGiangDayGiamDoChucVu - _tietGiangDayGiamKhac - _tietKyTruoc - _gioChuanGiangDayChuyenSangNckh - _tietGiangDayGiamDoTamNghi;
                        _tietNCKH = _dinhMucNcKh - _tietNCKHGiamDoChucVu - _tietNCKHGiamKhac - _noNckh + _gioChuanGiangDayChuyenSangNckh - _tietNckhGiamDoTamNghi;
                        gridViewTietNghiaVu.SetRowCellValue(e.RowHandle, "SoTietGiamTruKhac", _tietGiangDayGiamKhac + _tietNCKHGiamKhac);
                        gridViewTietNghiaVu.SetRowCellValue(e.RowHandle, "SumTietnghiaVuGiangDay", _reSult);
                        gridViewTietNghiaVu.SetRowCellValue(e.RowHandle, "SumTietNghiaVuNckh", _tietNCKH);
                        gridViewTietNghiaVu.SetRowCellValue(e.RowHandle, "TietGiamKhacGiangDay", _tietGiangDayGiamKhac);
                        gridViewTietNghiaVu.SetRowCellValue(e.RowHandle, "TietGiamKhacNckh", _tietNCKHGiamKhac);
                    }
                }
                else
                {
                    if (col.FieldName == "MaGiamTruKhac" || col.FieldName == "GioChuanGiangDayChuyenSangNckh")
                    {
                        DataRowView row = gridViewTietNghiaVu.GetRow(e.RowHandle) as DataRowView;
                        GiamTruDinhMuc g;

                        decimal? _tietNghiaVuGiangDay = 0, _tietGiamDoChucVu, _tietGiamKhac = 0, _tietKyTruoc, _reSult, _gioChuanGiangDayChuyenSangNckh, _tietNCKH
                                , _dinhMucNcKh, _noNckh;

                        _tietNghiaVuGiangDay = decimal.Parse(PMS.Common.Globals.IsNull(row["TietNghiaVuGiangDay"], "decimal").ToString());
                        _tietGiamDoChucVu = decimal.Parse(PMS.Common.Globals.IsNull(row["TietGiangDayGiamDoChucVu"], "decimal").ToString());
                        _tietKyTruoc = decimal.Parse(PMS.Common.Globals.IsNull(row["TietNo_BaoLuuGiangDay"], "decimal").ToString());
                        _gioChuanGiangDayChuyenSangNckh = decimal.Parse(PMS.Common.Globals.IsNull(row["GioChuanGiangDayChuyenSangNckh"], "decimal").ToString());
                        _dinhMucNcKh = decimal.Parse(PMS.Common.Globals.IsNull(row["TietNghiaVuNckh"], "decimal").ToString());
                        _noNckh = decimal.Parse(PMS.Common.Globals.IsNull(row["TietNo_BaoLuuNcKh"], "decimal").ToString());

                        try
                        {
                            g = _listGiamTruKhac.Find(p => p.MaQuanLy == int.Parse(row["MaGiamTruKhac"].ToString()));

                            if (g.DonVi.ToLower() == "phantram")
                            {
                                _tietGiamKhac = (_tietNghiaVuGiangDay * (g.MucGiam)) / 100;
                            }
                            else
                            {
                                _tietGiamKhac = g.MucGiam;
                            }
                        }
                        catch
                        { }

                        _reSult = _tietNghiaVuGiangDay - _tietGiamDoChucVu - _tietGiamKhac - _tietKyTruoc - _gioChuanGiangDayChuyenSangNckh;
                        _tietNCKH = _dinhMucNcKh + _noNckh + _gioChuanGiangDayChuyenSangNckh;
                        gridViewTietNghiaVu.SetRowCellValue(e.RowHandle, "SoTietGiamTruKhac", _tietGiamKhac);
                        gridViewTietNghiaVu.SetRowCellValue(e.RowHandle, "SumTietnghiaVuGiangDay", _reSult);
                        gridViewTietNghiaVu.SetRowCellValue(e.RowHandle, "SumTietNghiaVuNckh", _tietNCKH);
                    }
                }
            }
            catch
            { }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlTietNghiaVu.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            icboHocKyindex = cboHocKy.EditValue.ToString();
            LoadDataSource(icboHocKyindex);
        }

        private void gridViewTietNghiaVu_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (_maTruong == "BUH")
            {
                LstIndexReadOnly.Clear();
                GridView View = sender as GridView;
                if (e.RowHandle >= 0)
                {
                    string MaQuanLy = View.GetRowCellDisplayText(e.RowHandle, View.Columns["MaQuanLy"]);
                    for (int i = 0; i < ToMauIndex.Count; i++)
                    {
                        if (ToMauIndex[i].ToString() == MaQuanLy)
                        {
                            e.Appearance.BackColor = Color.Orange;
                        }
                    }

                    for (int i = 0; i < LstIdMaGV.Count; i++)
                    {
                        if (LstIdMaGV[i].ToString() == MaQuanLy)
                        {
                            LstIndexReadOnly.Add(e.RowHandle);
                            e.Appearance.BackColor = Color.GreenYellow;

                        }
                    }

                }
            }

        }

        private void chk_Xemtheohocky_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataSource(chk_Xemtheohocky.Checked == true ? cboNamHoc.EditValue.ToString() + "_" + icboHocKyindex : cboNamHoc.EditValue.ToString());
        }

        private void gridViewTietNghiaVu_ShownEditor(object sender, EventArgs e)
        {
            //ColumnView view = (ColumnView)sender;
            //for (int i = 0; i < LstIndexReadOnly.Count; i++)
            //{
            //    view.ActiveEditor.Properties.ReadOnly = view.FocusedRowHandle == LstIndexReadOnly[i];
            //}

        }

        private void gridViewTietNghiaVu_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            for (int i = 0; i < LstIndexReadOnly.Count; i++)
            {
                e.Cancel = view.FocusedRowHandle == LstIndexReadOnly[i];
            }

        }
    }
}
