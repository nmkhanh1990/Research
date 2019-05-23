using DevExpress.Common.Grid;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using ExcelLibrary;
using PMS.BLL;
using PMS.Comon;
using PMS.Entities;
using PMS.Services;
using PMS.UI.Forms.BaoCao;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmChamTay2 : Form
    {
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        VList<ViewKhoa> _listKhoaDonVi;
        string _groupName = UserInfo.GroupName;
        bool _status;
        string iMaHoatDong = UserInfo.MaHoatDong;//phân quyền cho hoạt động 
        string MaQuanLyHoatDong = UserInfo.MaQuanLyHoatDong;
        string ThanhPhanChucNang = UserInfo.ThanhPhanChucNang;
        bool bUserHoatDong = false;
        TList<HoatDongNgoaiGiangDay> LstHDNGD;
        VList<ViewGiangVien> _ViewGiangVien = new VList<ViewGiangVien>();
        TList<ChamTayHai> LstChamTayHai = new TList<ChamTayHai>();
        string strMaHoatDong = string.Empty;
        string strNgayThi = string.Empty;
        DateTime _ngayIn;
        public frmChamTay2()
        {
            InitializeComponent();
        }

        private void frmChamTay2_Load(object sender, EventArgs e)
        {
            LoadTitle();
            InitData();
            LoaiHoatDong(2);
            LoadDataGiangVienByKhoa(cbo_Khoa.EditValue.ToString(), cbo_NamHoc.EditValue.ToString(), cbo_HocKy.EditValue.ToString());
            LoadTenLophocPhan(cbo_NamHoc.EditValue.ToString(), cbo_HocKy.EditValue.ToString(), cbo_LoaiHoatDong.EditValue.ToString(), cbo_Khoa.EditValue.ToString());
            LoadDataBy(cbo_NamHoc.EditValue.ToString(), cbo_HocKy.EditValue.ToString(), cbo_Khoa.EditValue.ToString(), cbo_LoaiHoatDong.EditValue.ToString());
            if (MaQuanLyHoatDong == "CLC") //neu la clc or la admin thi hien
            {
                chk_Clc.Checked = true;
                layoutControlI_chkClc.Enabled = false;
            }
            else if (MaQuanLyHoatDong == string.Empty)
            { layoutControlI_chkClc.Enabled = true; }
            PMS.Common.Globals.GridRowColor(gdv_ChamTay2, new Font("Tahoma", 8), Color.Aqua, "XacNhanChiTra", "True");
        }

        private bool LoadThanhPhanChucNang()
        {
            TList<ThanhPhanChucNang> LstThanhPhan = DataServices.ThanhPhanChucNang.GetAll();
            foreach (string item in ThanhPhanChucNang.Split(';'))
            {
                foreach (ThanhPhanChucNang itemTP in LstThanhPhan)
                {
                    if (itemTP.Id.ToString().Trim() == item.Trim())
                    {
                        if (Common.Globals.BoDau(itemTP.TenThanhPhan.ToString().Trim().ToUpper()) == Common.Globals.BoDau("Khóa".ToUpper()))
                            return false;
                    }
                }
            }
            return true;
        }

        private void LoadTitle()
        {
            string[] LstColumns = new string[] { "ChonIn", "TenLopHocPhan", "TenMonHoc", "SoTinChi"
                    , "NgayThi", "CaThi", "PhongThi", "LanThi", "SiSo", "MaHoatDong", "HeSoQuyDoi"
                    , "GiangVienCham1", "DonVi1", "GiangVienCham2", "DonVi2", "Khoa", "KhoaXacNhan"
                    , "XacNhanChiTra", "GhiChu" };
            string[] LstColumnsTitle = new string[] { "Chọn in", "Lớp học phần", "Tên môn học", "Tín chỉ"
                    , "Ngày thi", "Ca thi", "Phòng thi", "Lần thi", "Sĩ số", "Hoạt động", "Hệ số quy đổi"
                    , "Giảng viên chấm 1", "Đơn vị", "Giảng viên chấm 2", "Đơn vị", "Khóa", "Xác nhận"
                    , "Thanh toán", "Ghi chú" };
            int[] LstIndex = new int[] { 60, 160, 120, 70, 90, 80, 80, 60, 70, 90, 70, 120, 150, 120, 150, 60, 60, 60, 200 };
            
            #region Init GridView
            if (LoadThanhPhanChucNang())
            {
                AppGridView.InitGridView(gdv_ChamTay2, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
                AppGridView.ShowEditor(gdv_ChamTay2, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            }
            else
            {
                AppGridView.InitGridView(gdv_ChamTay2, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            }

            AppGridView.ShowField(gdv_ChamTay2, LstColumns, LstColumnsTitle, LstIndex);
            AppGridView.AlignHeader(gdv_ChamTay2, LstColumns, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gdv_ChamTay2);
            AppGridView.RegisterControlField(gdv_ChamTay2, "GiangVienCham2", repositoryItem_G_GiangVien);
            AppGridView.RegisterControlField(gdv_ChamTay2, "GiangVienCham1", repositoryItem_G_GiangVienCham1);
            AppGridView.RegisterControlField(gdv_ChamTay2, "TenLopHocPhan", repositoryItem_gLopHocPhan);
            AppGridView.RegisterControlField(gdv_ChamTay2, "MaHoatDong", repositoryItem_G_LoaiHoatDong);
            AppGridView.FormatDataField(gdv_ChamTay2, "HeSoQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FixedField(gdv_ChamTay2, new string[] { "ChonIn", "TenLopHocPhan", "TenMonHoc", "SoTinChi", "NgayThi", "CaThi", "PhongThi", "LanThi", "SiSo" }, FixedStyle.Left);
            AppGridView.HideField(gdv_ChamTay2, new string[] { "XacNhanChiTra" });
            if (LoadThanhPhanChucNang())
            {
                AppGridView.AllowEditColumn(gdv_ChamTay2, new string[] { "SiSo", "MaHoatDong", "TenLopHocPhan", "GiangVienCham2", "Khoa", "KhoaXacNhan", "GhiChu", "ChonIn" });
                AppGridView.HideField(gdv_ChamTay2, new string[] { "Khoa" });
                layoutControl_Khoatatca.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;


            }
            else
            {
                AppGridView.AllowEditColumn(gdv_ChamTay2, new string[] { "SiSo", "MaHoatDong", "GiangVienCham2", "Khoa", "KhoaXacNhan", "GhiChu", "ChonIn" });
                AppGridView.HideField(gdv_ChamTay2, new string[] { "KhoaXacNhan" });
                layoutControl_XacNhanTatCa.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                EnanbleChucnang(true);
            }


            //AppGridView.FormatDataField(gdv_ChamTay2, "SiSo", DevExpress.Utils.FormatType.Custom, "n0");
            //AppGridView.FormatDataField(gdv_ChamTay2, "SoTiet", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.SummaryField(gdv_ChamTay2, "GiangVienCham2", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            #endregion

            #region HoatDongNgoaiGiangDay
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItem_gLopHocPhan, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItem_gLopHocPhan, new string[] { "TenLopHocPhan", "TenMonHoc", "LanThi", "SiSo" }, new string[] { "Tên lớp học phần", "Tên môn học", "Lần thi", "Sỉ số" }, new int[] { 300, 100, 80, 80 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItem_gLopHocPhan, 500, 450);
            repositoryItem_gLopHocPhan.DisplayMember = "TenLopHocPhan";
            repositoryItem_gLopHocPhan.ValueMember = "TenLopHocPhan";
            repositoryItem_gLopHocPhan.NullText = string.Empty;
            #endregion

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItem_G_GiangVien, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItem_G_GiangVien
                , new string[] { "MaQuanLy", "HoTen", "TenDonVi" }
                , new string[] { "Mã giảng viên", "Họ tên", "Khoa - Đơn vị" }
                , new int[] { 100, 180, 120 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItem_G_GiangVien, 400, 500);
            repositoryItem_G_GiangVien.DisplayMember = "HoTen";
            repositoryItem_G_GiangVien.ValueMember = "MaQuanLy";
            repositoryItem_G_GiangVien.NullText = string.Empty;
            #endregion

            #region Giảng viên chấm 1
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItem_G_GiangVienCham1, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItem_G_GiangVienCham1, new string[] { "MaQuanLy", "HoTen", "TenDonVi" }, new string[] { "Mã giảng viên", "Họ tên", "Khoa - Đơn vị" }
                        , new int[] { 100, 180, 120 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItem_G_GiangVienCham1, 400, 500);
            repositoryItem_G_GiangVienCham1.DisplayMember = "HoTen";
            repositoryItem_G_GiangVienCham1.ValueMember = "MaGiangVien";
            repositoryItem_G_GiangVienCham1.NullText = string.Empty;
            #endregion

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cbo_NamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cbo_NamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cbo_NamHoc.Properties.DisplayMember = "NamHoc";
            cbo_NamHoc.Properties.ValueMember = "NamHoc";
            cbo_NamHoc.Properties.NullText = string.Empty;
            cbo_NamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cbo_NamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cbo_NamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cbo_NamHoc.Properties.DisplayMember = "NamHoc";
            cbo_NamHoc.Properties.ValueMember = "NamHoc";
            cbo_NamHoc.Properties.NullText = "[EditValue is null]";
            cbo_NamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cbo_HocKy, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cbo_HocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cbo_HocKy.Properties.DisplayMember = "TenHocKy";
            cbo_HocKy.Properties.ValueMember = "MaHocKy";
            cbo_HocKy.Properties.NullText = "[EditValue is null]";
            #endregion

            #region Khoa bộ môn
            AppGridLookupEdit.InitGridLookUp(cbo_Khoa, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cbo_Khoa, new string[] { "MaBoMon", "TenBoMon" }, new string[] { "Mã bộ môn", "Tên bộ môn" });
            cbo_Khoa.Properties.DisplayMember = "TenBoMon";
            cbo_Khoa.Properties.ValueMember = "MaBoMon";
            cbo_Khoa.Properties.NullText = string.Empty;
            #endregion

            #region _LoaiHoatDongNgoaiGiangDay
            AppGridLookupEdit.InitGridLookUp(cbo_LoaiHoatDong, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cbo_LoaiHoatDong, new string[] { "TenHoatDong" }, new string[] { "Tên hoạt động" });
            cbo_LoaiHoatDong.Properties.DisplayMember = "TenHoatDong";
            cbo_LoaiHoatDong.Properties.ValueMember = "MaHoatDong";
            #endregion

            #region Danh Sách_LoaiHoatDongNgoaiGiangDay
            //AppGridLookupEdit.InitGridLookUp(repositoryItem_G_LoaiHoatDong, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            //AppGridLookupEdit.ShowField(repositoryItem_G_LoaiHoatDong, new string[] { "TenHoatDong" }, new string[] { "Tên hoạt động" });
            //cbo_LoaiHoatDong.Properties.DisplayMember = "TenHoatDong";
            //cbo_LoaiHoatDong.Properties.ValueMember = "MaHoatDong";



            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItem_G_LoaiHoatDong, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItem_G_LoaiHoatDong, new string[] { "MaHoatDong", "TenHoatDong" }, new string[] { "Mã hoạt động", "Tên hoạt động" }
                        , new int[] { 100, 180, 120 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItem_G_LoaiHoatDong, 200, 300);
            repositoryItem_G_LoaiHoatDong.DisplayMember = "TenHoatDong";
            repositoryItem_G_LoaiHoatDong.ValueMember = "MaHoatDong";
            repositoryItem_G_LoaiHoatDong.NullText = string.Empty;
            #endregion
        }

        void EnanbleChucnang(bool bvalue)
        {
            if (bvalue == true)
            {
                btn_Xoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            else
            {
                btn_Xoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }

        private void InitData()
        {
            bds_NamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cbo_NamHoc.EditValue != null)
            {
                bds_HocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cbo_NamHoc.EditValue.ToString());
                cbo_HocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            }

            #region _khoaDonVi
            AppGridLookupEdit.InitGridLookUp(cbo_Khoa, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cbo_Khoa, new string[] { "MaKhoa", "TenKhoa" }, new string[] { "Mã khoa", "Tên khoa" }, new int[] { 60, 200 });
            cbo_Khoa.Properties.ValueMember = "MaKhoa";
            cbo_Khoa.Properties.DisplayMember = "TenKhoa";
            cbo_Khoa.Properties.NullText = string.Empty;
            _listKhoaDonVi = DataServices.ViewKhoa.GetAll();
            cbo_Khoa.DataBindings.Clear();
            foreach (ViewKhoa v in _listKhoaDonVi)
            {
                if (v.MaKhoa == _groupName)
                {
                    _status = true;
                    break;
                }
            }
            if (_status)
                _listKhoaDonVi = _listKhoaDonVi.FindAll(p => p.MaKhoa == _groupName) as VList<ViewKhoa>;
            else
                _listKhoaDonVi.Insert(0, new ViewKhoa() { ThuTu = -1, MaKhoa = "-1", TenKhoa = "[Tất cả]" });
            bds_Khoa.DataSource = _listKhoaDonVi;
            cbo_Khoa.DataBindings.Add("EditValue", bds_Khoa, "MaKhoa", true, DataSourceUpdateMode.Never);
            #endregion

            LstHDNGD = DataServices.HoatDongNgoaiGiangDay.GetAll();
        }

        private void LoadDataGiangVienByKhoa(string strKhoa, string strNamHoc, string strHocKy)
        {
            try
            {
                bds_GiangVien.Clear();
                bds_GiangVienC1.Clear();
                _ViewGiangVien = DataServices.ViewGiangVien.GetByMaDonViTrucThuoc(strKhoa, strNamHoc, strHocKy);
                bds_GiangVien.DataSource = _ViewGiangVien;
                bds_GiangVienC1.DataSource = _ViewGiangVien;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        private void LoadTenLophocPhan(string strNamhoc, string strHocKy, string strMaHoatDong, string strKhoa)
        {
            DataTable tbl = new DataTable();
            //tbl.Load(DataServices.ChamTayHai.GetAllChamTay2(strNamhoc, strHocKy, strMaHoatDong, strKhoa));
            //tbl.Load(DataServices.ViewLopHocPhan.GetByNamHocHocKyKhoaDonVi(strNamhoc, strHocKy, strKhoa));
            //VList<ViewLopHocPhan> LstHocPhan = DataServices.ViewLopHocPhan.GetByNamHocHocKyKhoaDonVi(strNamhoc, strHocKy, strKhoa);
            bds_LopHocPhan.DataSource = DataServices.ViewLopHocPhan.GetByNamHocHocKy(strNamhoc, strHocKy);
        }

        private void btn_Excel_XuatFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable dbTable = new DataTable();
            dbTable.Load(DataServices.GiangVienHoatDongNgoaiGiangDay.GetByNamHocHocKyKhoaExportExcel(cbo_NamHoc.EditValue.ToString(), cbo_HocKy.EditValue.ToString(), cbo_Khoa.EditValue.ToString(), cbo_LoaiHoatDong.EditValue.ToString()));
            ExcelImport.exportDataToExcel(2, dbTable);
        }

        private void btn_Excel_Nhapfile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int iOutput = -1;
            using (FrmIm_Ex_port_GiangVienHoatDongNgoaiGiangDay frmImExport = new NghiepVu.FrmIm_Ex_port_GiangVienHoatDongNgoaiGiangDay(cbo_NamHoc.EditValue.ToString(), cbo_HocKy.EditValue.ToString(), 0))
            {
                frmImExport.MaHoatDong = cbo_LoaiHoatDong.EditValue.ToString();
                iOutput = frmImExport.OutPut;
                frmImExport.ShowDialog();
            }
            if (iOutput == 0)
            {
                LoadDataBy(cbo_NamHoc.EditValue.ToString(), cbo_HocKy.EditValue.ToString(), cbo_LoaiHoatDong.EditValue.ToString(), cbo_Khoa.EditValue.ToString());
            }
        }

        private void LoadDataBy(string v1, string v2, string v3, string v4)
        {
            try
            {
                DataTable dbTable = new DataTable();
                dbTable.Load(DataServices.ChamTayHai.GetBangChamTay2ByNamHocHocKyKhoaLoaiHoatDong(v1, v2, v3, v4));
                dbTable.Columns.Add("ChonIn", typeof(bool));
                dbTable.Columns["Khoa"].ReadOnly = false;
                dbTable.Columns["XacNhanChiTra"].ReadOnly = false;
                dbTable.Columns["HeSoQuyDoi"].ReadOnly = false;
                dbTable.Columns["SiSo"].ReadOnly = false;
                dbTable.Columns["GhiChu"].ReadOnly = false;
                dbTable.Columns["MaHoatDong"].ReadOnly = false;
                dbTable.Columns["DonVi1"].ReadOnly = false;
                dbTable.Columns["NgayThi"].ReadOnly = false;
                dbTable.Columns["LanThi"].ReadOnly = false;
                dbTable.Columns["PhongThi"].ReadOnly = false;
                dbTable.Columns["GiangVienCham1"].ReadOnly = false;
                dbTable.Columns["KhoaXacNhan"].ReadOnly = false;
                dbTable.Columns["ChonIn"].ReadOnly = false;
                foreach (DataRow item in dbTable.Rows)
                {
                    item["ChonIn"] = false;
                }

                if (!LoadThanhPhanChucNang())
                {
                    //gdv_ChamTay2.ActiveFilterString = "[KhoaXacNhan] = True";
                    bds_ChamTay2.DataSource = dbTable.Select("KhoaXacNhan = True").CopyToDataTable();
                }
                else
                    bds_ChamTay2.DataSource = dbTable;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }

        }

        private void chk_Clc_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                LoaiHoatDong(chk_Clc.Checked == true ? 0 : 1);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        private void LoaiHoatDong(int b)
        {
            int iGetMaHoatDong = 0;

            #region Loại hoạt động
            cbo_LoaiHoatDong.DataBindings.Clear();
            VList<ViewGiangVienHoatDongNgoaiGiangDay> _VListHoatDongNgoaiGiangDay = new VList<ViewGiangVienHoatDongNgoaiGiangDay>();
            string strChuoi = string.Empty;
            foreach (HoatDongNgoaiGiangDay item in LstHDNGD)
            {
                if (item.ThanhToanBinhThuong != null)
                {
                    if ((bool)item.ThanhToanBinhThuong == true)
                    {
                        ViewGiangVienHoatDongNgoaiGiangDay itemsview = new ViewGiangVienHoatDongNgoaiGiangDay();
                        itemsview.MaHoatDong = item.MaQuanLy;
                        strMaHoatDong = item.MaQuanLy.ToString();
                        itemsview.TenHoatDong = item.TenHoatDong;
                        itemsview.MucQuyDoi = item.MucQuyDoi;
                        itemsview.GhiChu = item.GhiChu;
                        strChuoi = item.TenHoatDong.Substring(item.TenHoatDong.Length - 3, 3);
                        if (b == 0)
                        {
                            if (strChuoi.ToUpper() == "CLC")
                            {
                                _VListHoatDongNgoaiGiangDay.Add(itemsview);
                            }
                        }
                        else if (b == 1)
                        {
                            if (strChuoi != "CLC")
                            {
                                _VListHoatDongNgoaiGiangDay.Add(itemsview);
                            }
                        }
                        else
                        {
                            if (MaQuanLyHoatDong == string.Empty)
                                _VListHoatDongNgoaiGiangDay.Add(itemsview);
                            else if (MaQuanLyHoatDong == "BINHTHUONG")
                            {
                                if (strChuoi != "CLC")
                                {
                                    _VListHoatDongNgoaiGiangDay.Add(itemsview);
                                }
                            }
                            else if (MaQuanLyHoatDong == "CLC")
                            {
                                if (strChuoi == "CLC")
                                {
                                    _VListHoatDongNgoaiGiangDay.Add(itemsview);
                                }
                            }
                        }
                    }
                }
            }
            foreach (ViewGiangVienHoatDongNgoaiGiangDay item in _VListHoatDongNgoaiGiangDay)
            {
                foreach (var itemHD in iMaHoatDong.Split(';'))
                {
                    if (item.MaHoatDong == int.Parse(itemHD.ToString()) && item.TenHoatDong.LastIndexOf("tay 2") > -1)
                    {
                        bUserHoatDong = true;
                        iGetMaHoatDong = item.MaHoatDong;
                        break;
                    }
                }
            }
            if (bUserHoatDong)
            {
                _VListHoatDongNgoaiGiangDay = DataServices.ViewGiangVienHoatDongNgoaiGiangDay.GetByMaHoatDong(iGetMaHoatDong.ToString());
            }
            else
            {
                if (MaQuanLyHoatDong == string.Empty)
                    _VListHoatDongNgoaiGiangDay.Add(new ViewGiangVienHoatDongNgoaiGiangDay() { MaHoatDong = -1, TenHoatDong = "[Tất cả]" });
            }
            bds_LoaiHoatDong.DataSource = _VListHoatDongNgoaiGiangDay;
            bds_LoaiHoatDong.Sort = "MaHoatDong";
            cbo_LoaiHoatDong.DataBindings.Add("EditValue", bds_LoaiHoatDong, "MaHoatDong", true, DataSourceUpdateMode.Never);
            cbo_LoaiHoatDong.Properties.DataSource = bds_LoaiHoatDong;
            bds_DSLoaiHoatDong.DataSource = _VListHoatDongNgoaiGiangDay;
            #endregion
        }

        private int GetMaHoatDong(VList<ViewGiangVienHoatDongNgoaiGiangDay> _VListHoatDongNgoaiGiangDay)
        {
            int iResult = 0;
            return iResult;
        }

        private void btn_LamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InitData();
            LoaiHoatDong(2);
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] LstIndex = gdv_ChamTay2.GetSelectedRows();
            string[] LstColumn = { "TenLopHocPhan", "GiangVienCham2", "MaHoatDong", "LanThi" };
            int output = -1;
            if (XtraMessageBox.Show(String.Format("Bạn có muốn xóa {0} dòng đã chọn không ?", gdv_ChamTay2.GetSelectedRows().Length), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string strXML = PMS.Common.Globals.XoaXMLFromGridView(gdv_ChamTay2, LstColumn, LstIndex, cbo_NamHoc.EditValue.ToString(), cbo_HocKy.EditValue.ToString());
                DataServices.ChamTayHai.LuuXoa(strXML, ref output);
                if (output == 0)
                    PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_Luuxoathanhcong, MessageBoxIcon.None, true);
                else
                    PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_Luuxoathatbai, MessageBoxIcon.Warning, true);
            }
            btn_Loc_Click(sender, e);
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            LoadDataBy(cbo_NamHoc.EditValue.ToString(), cbo_HocKy.EditValue.ToString(), cbo_LoaiHoatDong.EditValue.ToString(), cbo_Khoa.EditValue.ToString());
        }

        private void gdv_ChamTay2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn gdv = e.Column;
            GridView gdvCheck = sender as GridView;
            DataTable tbl;
            if (gdv.FieldName == "TenLopHocPhan")
            {
                //repositoryItem_gLopHocPhan.GetDisplayValue()
                string strLopHocPhan = gdv_ChamTay2.GetRowCellValue(e.RowHandle, "TenLopHocPhan").ToString();
                tbl = bds_LopHocPhan.DataSource as DataTable;
                DataRow[] dr = tbl.Select("TenLopHocPhan='" + strLopHocPhan + "' And NgayThi='" + strNgayThi + "'");
                string strHeSoQuyDoi = string.Empty;
                foreach (DataRow item in dr)
                {
                    gdv_ChamTay2.SetRowCellValue(e.RowHandle, "TenMonHoc", item["TenMonHoc"].ToString());
                    gdv_ChamTay2.SetRowCellValue(e.RowHandle, "SoTinChi", item["SoTinChi"].ToString());
                    gdv_ChamTay2.SetRowCellValue(e.RowHandle, "NgayThi", strNgayThi);
                    gdv_ChamTay2.SetRowCellValue(e.RowHandle, "CaThi", item["CaThi"].ToString());
                    gdv_ChamTay2.SetRowCellValue(e.RowHandle, "PhongThi", item["PhongThi"].ToString());

                    gdv_ChamTay2.SetRowCellValue(e.RowHandle, "LanThi", item["LanThi"].ToString());
                    gdv_ChamTay2.SetRowCellValue(e.RowHandle, "SiSo", item["SiSo"].ToString());
                    gdv_ChamTay2.SetRowCellValue(e.RowHandle, "MaHoatDong", cbo_LoaiHoatDong.EditValue.ToString() == "-1" ? "21" : cbo_LoaiHoatDong.EditValue.ToString());

                    gdv_ChamTay2.SetRowCellValue(e.RowHandle, "GiangVienCham1", item["GiangVienCham1"].ToString());
                    gdv_ChamTay2.SetRowCellValue(e.RowHandle, "DonVi1", item["DonVi1"].ToString());
                    string strGiangVienCham2 = item["GiangVienCham2"].ToString();
                    gdv_ChamTay2.SetRowCellValue(e.RowHandle, "GiangVienCham2", strGiangVienCham2);
                    gdv_ChamTay2.SetRowCellValue(e.RowHandle, "Khoa", item["Khoa"].ToString());
                    bool bXacNhan = Convert.ToBoolean(item["XacNhanChiTra"].ToString());
                    gdv_ChamTay2.SetRowCellValue(e.RowHandle, "XacNhanChiTra", bXacNhan);
                    gdv_ChamTay2.SetRowCellValue(e.RowHandle, "ChonIn", false);
                    gdv_ChamTay2.SetRowCellValue(e.RowHandle, "KhoaXacNhan", false);
                }
            }
            else if (gdv.FieldName == "MaHoatDong")
            {
                string strSiSo = gdv_ChamTay2.GetRowCellValue(e.RowHandle, "SiSo").ToString();
                string IntMaHoatDong = gdv_ChamTay2.GetRowCellValue(e.RowHandle, "MaHoatDong").ToString();
                HoatDongNgoaiGiangDay HdItem = LstHDNGD.Find(p => p.MaQuanLy == int.Parse(IntMaHoatDong));
                decimal dSoLuong = decimal.Parse(HdItem.SoLuong.ToString());
                decimal dMucQuyDoi = HdItem.MucQuyDoi != null ? decimal.Parse(HdItem.MucQuyDoi.ToString()) : 1;
                decimal dKetQua = decimal.Parse(strSiSo) / dSoLuong * dMucQuyDoi;
                gdv_ChamTay2.SetRowCellValue(e.RowHandle, "HeSoQuyDoi", dKetQua);
            }
            else if (gdv.FieldName == "GiangVienCham2")
            {
                string strGiangVien = gdv_ChamTay2.GetRowCellValue(e.RowHandle, "GiangVienCham2").ToString();
                if (strGiangVien.Length > 0 || strGiangVien != string.Empty)
                {
                    VList<ViewGiangVien> LstGiangvien = bds_GiangVien.DataSource as VList<ViewGiangVien>;
                    ViewGiangVien itemGiangVien = LstGiangvien.Find(p => p.MaQuanLy == strGiangVien);
                    gdv_ChamTay2.SetRowCellValue(e.RowHandle, "DonVi2", itemGiangVien.TenDonVi.ToString());
                }
            }
            else if (gdv.FieldName == "SiSo")
            {
                string strSiSo = gdv_ChamTay2.GetRowCellValue(e.RowHandle, "SiSo").ToString();
                string IntMaHoatDong = gdv_ChamTay2.GetRowCellValue(e.RowHandle, "MaHoatDong").ToString();
                if (IntMaHoatDong != string.Empty)
                {
                    HoatDongNgoaiGiangDay HdItem = LstHDNGD.Find(p => p.MaQuanLy == int.Parse(IntMaHoatDong));
                    decimal dSoLuong = decimal.Parse(HdItem.SoLuong.ToString());
                    decimal dMucQuyDoi = HdItem.MucQuyDoi != null ? decimal.Parse(HdItem.MucQuyDoi.ToString()) : 1;
                    decimal dKetQua = decimal.Parse(strSiSo) / dSoLuong * dMucQuyDoi;
                    gdv_ChamTay2.SetRowCellValue(e.RowHandle, "HeSoQuyDoi", dKetQua);
                }
            }
        }

        private void btn_Luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gdv_ChamTay2.FocusedRowHandle = -1;
                if (cbo_LoaiHoatDong.EditValue.ToString() == "-1")
                {
                    PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_ChonLoaiHoatDong, MessageBoxIcon.Warning, true);
                    return;
                }
                else
                {
                    string[] LstColumn = { "GiangVienCham2", "TenLopHocPhan", "SiSo", "Khoa", "HeSoQuyDoi", "GhiChu", "LanThi", "KhoaXacNhan" };
                    int output = -1;
                    Cursor.Current = Cursors.WaitCursor;
                    DataTable dbChamTay2 = bds_ChamTay2.DataSource as DataTable;
                    string strXML = "<Root></Root>";
                    strXML = PMS.Common.Globals.GetXMLFromLISTMaHoatDong(LstColumn, dbChamTay2, cbo_NamHoc.EditValue.ToString(), cbo_HocKy.EditValue.ToString(), DateTime.Now.ToString("yyyy-MM-dd"), UserInfo.UserName, cbo_LoaiHoatDong.EditValue.ToString());
                    if (strXML == "<Root></Root>")
                    {
                        PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_KiemTraFileExcel, MessageBoxIcon.Warning, true);
                        return;
                    }
                    else
                    {
                        DataServices.ChamTayHai.Luu(strXML, ref output);
                        if (output == 0)
                            PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_LuuImportThanhCong, MessageBoxIcon.None, true);
                        else
                            PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_LuuImportThatBai, MessageBoxIcon.Warning, true);
                    }
                    Cursor.Current = Cursors.Default;
                }
                btn_Loc_Click(sender, e);
            }
            catch
            {
                PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_LuuImportThatBai + ".......!", MessageBoxIcon.Error, true);
            }
        }

        private void gdv_ChamTay2_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            try
            {
                if (gdv_ChamTay2.FocusedColumn.FieldName == "GiangVienCham2")
                {
                    string strLoaiMaLopHocPhan = gdv_ChamTay2.GetRowCellValue(gdv_ChamTay2.FocusedRowHandle, "TenLopHocPhan").ToString();
                    string strLoaiMaHoatDong = gdv_ChamTay2.GetRowCellValue(gdv_ChamTay2.FocusedRowHandle, "MaHoatDong").ToString();
                    string strLanThi = gdv_ChamTay2.GetRowCellValue(gdv_ChamTay2.FocusedRowHandle, "LanThi").ToString();

                    string strLoaiMaGiangVien = e.Value.ToString();

                    if (strLoaiMaGiangVien == string.Empty)
                    {
                        e.Valid = false;
                        e.ErrorText = "Vui lòng chọn giảng viên";
                    }
                    else
                    {
                        if (KiemTraLopHocPhan(strLoaiMaLopHocPhan, strLoaiMaHoatDong, strLoaiMaGiangVien, strLanThi))
                        {
                            e.Valid = false;
                            e.ErrorText = "Lớp học phần này " + strLoaiMaLopHocPhan + " đã tồn tại.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }

        }


        public bool KiemTraLopHocPhan(string strMaLopHocPhan, string strLoaiHoatDong, string strMaGiangVien, string strLanThi)
        {
            bool bResult = false;
            DataTable dbTable = bds_ChamTay2.DataSource as DataTable;
            DataRow[] ItemRows = dbTable.Select("TenLopHocPhan='" + strMaLopHocPhan + "' And MaHoatDong='" + strLoaiHoatDong + "'And GiangVienCham2='" + strMaGiangVien + "' And LanThi='" + strLanThi + "'");
            if (ItemRows.Count() > 0) bResult = true;
            return bResult;
        }


        private void gdv_ChamTay2_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = gdv_ChamTay2 as GridView;
            if (view.FocusedRowHandle > -1)
            {
                bool bXacNhanChiTra = PMS.Common.XuLyGiaoDien.DisableCellRows(view, "XacNhanChiTra", view.FocusedRowHandle, "True");
                bool bKhoa = PMS.Common.XuLyGiaoDien.DisableCellRows(view, "Khoa", view.FocusedRowHandle, "True");
                if (view.FocusedColumn.FieldName == "Khoa" && bXacNhanChiTra)
                {
                    e.Cancel = true;

                }
                if (view.FocusedColumn.FieldName == "SiSo" && bKhoa)
                {
                    e.Cancel = true;
                }
                if (view.FocusedColumn.FieldName == "KhoaXacnhan" && bKhoa)
                {
                    e.Cancel = true;
                }
            }

        }

        private void gdv_ChamTay2_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gdv_ChamTay2_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView obj = sender as GridView;
            if (obj != null)
            {
                if (obj.FocusedColumn.FieldName == "GhiChu")
                {
                    string strLoaiMaHoatDong = obj.GetRowCellValue(obj.FocusedRowHandle, "MaHoatDong").ToString();
                    string strLoaiGiangVienCham2 = obj.GetRowCellValue(obj.FocusedRowHandle, "GiangVienCham2").ToString();
                    if (strLoaiMaHoatDong == string.Empty)
                    {
                        PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, "Vui lòng chọn loại hoạt động", MessageBoxIcon.Warning, true);
                        e.Valid = false;
                    }
                    else if (strLoaiMaHoatDong != string.Empty && strLoaiGiangVienCham2 == string.Empty)
                    {
                        PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, "Vui lòng chọn giảng viên", MessageBoxIcon.Warning, true);
                        e.Valid = false;
                    }
                }
            }
        }

        private void repositoryItem_gLopHocPhan_CloseUp(object sender, CloseUpEventArgs e)
        {
            try
            {
                GridLookUpEdit edit = sender as GridLookUpEdit;
                if (e.AcceptValue)
                {
                    var selectedDataRow = edit.Properties.View.GetDataRow(edit.Properties.View.FocusedRowHandle);
                    strNgayThi = selectedDataRow[4].ToString();
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        private void gdv_ChamTay2_RowClick(object sender, RowClickEventArgs e)
        {
            GridView gdv = sender as GridView;
            bool bKhoa = PMS.Common.XuLyGiaoDien.DisableCellRows(gdv, "Khoa", gdv.FocusedRowHandle, "True");
            EnanbleChucnang(bKhoa);

        }

        private void chk_XacNhanTatCa_CheckedChanged(object sender, EventArgs e)
        {
            PMS.Common.XuLyGiaoDien.CheckAll(gdv_ChamTay2, "KhoaXacNhan", chk_XacNhanTatCa.Checked);
        }

        private void chk_ChecKhoaTatCa_CheckedChanged(object sender, EventArgs e)
        {
            PMS.Common.XuLyGiaoDien.CheckAll(gdv_ChamTay2, "Khoa", chk_ChecKhoaTatCa.Checked);
        }

        private void btn_In_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gdv_ChamTay2.FocusedRowHandle = -1;
                string[] LstColumn = { "TenLopHocPhan", "TenMonHoc", "SoTinChi", "NgayThi", "CaThi", "PhongThi", "LanThi", "SiSo", "MaHoatDong", "HeSoQuyDoi", "GiangVienCham1", "DonVi1", "GiangVienCham2", "DonVi2" };
                DataTable dataTable = bds_ChamTay2.DataSource as DataTable;
                int icheck = PMS.Common.XuLyGiaoDien.CheckedIn(gdv_ChamTay2, "ChonIn");
                if (icheck == 0)
                {
                    PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_ChonIn, MessageBoxIcon.Warning, true);
                    return;
                }
                DataTable vListBaoCao = LoadThanhPhanChucNang() == true ? dataTable.Select("ChonIn = True").CopyToDataTable() : dataTable.Select("ChonIn = True And KhoaXacNhan = True ").CopyToDataTable();
                DataTable table = PMS.Common.XuLyGiaoDien.CreateTable(LstColumn);
                DataTable tblKetQua = GetAllTable(table, vListBaoCao);
                DataSet dsGiangVien = new DataSet("DsGiangVien");
                dsGiangVien.Tables.Add(tblKetQua);
                SaveFileDialog f = new SaveFileDialog();
                f.Filter = "Excel file (*.xls)|*.xls";
                if (f.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        iloveit1208Library k = new iloveit1208Library();//Lib ExcelLibrary
                        k.ExportToExcel(dsGiangVien, f.FileName);
                        XtraMessageBox.Show("Đã xuất danh sách thành công.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Lỗi xuất dữ liệu.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        private DataTable GetAllTable(DataTable dbColumn, DataTable dbRows)
        {
            DataTable dbTable = dbColumn;
            foreach (DataRow drItems in dbRows.Rows)
            {
                DataRow dr = dbTable.NewRow();
                foreach (DataColumn item in dbColumn.Columns)
                {
                    if (item.ColumnName == "GiangVienCham1" || item.ColumnName == "GiangVienCham2")
                    {
                        string strGiangVien = GetHoTen(drItems[item.ColumnName.ToString()].ToString(), item.ColumnName.ToString());
                        dr[item.ColumnName.ToString()] = strGiangVien;
                    }
                    else
                    {
                        dr[item.ColumnName.ToString()] = drItems[item.ColumnName.ToString()];
                    }
                }
                dbTable.Rows.Add(dr);
            }
            return dbTable;
        }

        string GetHoTen(string strMaGiangVien, string colName)
        {
            foreach (ViewGiangVien item in _ViewGiangVien)
            {
                if (colName == "GiangVienCham1")
                {
                    if (item.MaGiangVien.ToString() == strMaGiangVien)
                        return item.HoTen.ToString();
                }
                else
                {
                    if (item.MaQuanLy.ToString() == strMaGiangVien)
                        return item.HoTen.ToString();
                }
            }
            return string.Empty;
        }

        private void chk_ChonIn_CheckedChanged(object sender, EventArgs e)
        {
            PMS.Common.XuLyGiaoDien.CheckAll(gdv_ChamTay2, "ChonIn", chk_ChonIn.Checked);
        }

        private void btnInReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (frmChonNgay frmChon = new frmChonNgay())
            {
                frmChon.ShowDialog();
                DateTime dt = frmChon.NgayIn;
                if (dt.ToString("dd/MM/yyyy") == "01/01/0001")
                    return;
                _ngayIn = frmChon.NgayIn;
            }
            gdv_ChamTay2.FocusedRowHandle = -1;
            bds_ChamTay2.EndEdit();
            DataTable data = bds_ChamTay2.DataSource as DataTable;
           
            if (data == null)
                return;
            DataTable vListBaoCao;
            try
            {
                vListBaoCao = data.Select("ChonIn = True").CopyToDataTable();
                vListBaoCao.Columns.Add("HoTenGiangVien1", typeof(string));
                vListBaoCao.Columns.Add("HoTenGiangVien2", typeof(string));
                for (int i = 0; i < vListBaoCao.Rows.Count; i++)
                {
                    string strHoTenGV1 = _ViewGiangVien.Find(p => p.MaGiangVien == int.Parse(vListBaoCao.Rows[i]["GiangVienCham1"].ToString())).HoTen;
                    string strHoTenGV2 = string.Empty;
                    if (vListBaoCao.Rows[i]["GiangVienCham2"].ToString().Length > 0)
                    {
                        strHoTenGV2 = _ViewGiangVien.Find(p => p.MaQuanLy == vListBaoCao.Rows[i]["GiangVienCham2"].ToString()).HoTen;
                    }
                    vListBaoCao.Rows[i]["HoTenGiangVien1"] = strHoTenGV1;
                    vListBaoCao.Rows[i]["HoTenGiangVien2"] = strHoTenGV2;
                }
            }
            catch
            {
                XtraMessageBox.Show("Vui lòng chọn môn muốn in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn c in gdv_ChamTay2.SortedColumns)
                    {
                        switch (c.SortOrder)
                        {
                            case DevExpress.Data.ColumnSortOrder.Ascending:
                                sort += string.Format("{0} ASC, ", c.FieldName);
                                break;
                            case DevExpress.Data.ColumnSortOrder.Descending:
                                sort += string.Format("{0} DESC, ", c.FieldName);
                                break;
                        }
                    }
                }
                if (sort != "")
                    sort = sort.Substring(0, sort.Length - 2);
            }
            vListBaoCao.AcceptChanges();
            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InBangKeDanhSachGiangVienChamTay2(cbo_NamHoc.EditValue.ToString(), cbo_HocKy.EditValue.ToString(), UserInfo.FullName, _ngayIn, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void cbo_NamHoc_EditValueChanged(object sender, EventArgs e)
        {
            bds_HocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cbo_NamHoc.EditValue.ToString());
        }

        private void cbo_HocKy_EditValueChanged(object sender, EventArgs e)
        {
            bds_LopHocPhan.DataSource = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cbo_NamHoc.EditValue.ToString(), cbo_HocKy.EditValue.ToString());
        }

        private void cbo_Khoa_EditValueChanged(object sender, EventArgs e)
        {
            _ViewGiangVien = DataServices.ViewGiangVien.GetByMaDonViTrucThuoc(
                cbo_Khoa.EditValue.ToString(), cbo_NamHoc.EditValue.ToString(), cbo_HocKy.EditValue.ToString()
            );
            bds_GiangVien.DataSource = _ViewGiangVien;
            bds_GiangVienC1.DataSource = _ViewGiangVien;
        }
    }
}
