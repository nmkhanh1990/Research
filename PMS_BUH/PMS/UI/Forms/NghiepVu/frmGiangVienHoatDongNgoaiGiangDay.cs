﻿using System;
using System.Linq;
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
using DevExpress.XtraEditors.Repository;
using PMS.BLL;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using PMS.UI.Forms.BaoCao;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.Comon;
using System.IO;
using ExcelLibrary;
using DevExpress.XtraEditors.Controls;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmGiangVienHoatDongNgoaiGiangDay : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ItemShortcut = DevExpress.XtraBars.BarShortcut.Empty;

                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnXoa.ItemShortcut = DevExpress.XtraBars.BarShortcut.Empty;

                btnLayDuLieu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLayDuLieu.ItemShortcut = DevExpress.XtraBars.BarShortcut.Empty;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnLayDuLieu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        VList<ViewGiangVien> _ViewGiangVien = new VList<ViewGiangVien>();
        TList<GiangVienHoatDongNgoaiGiangDay> LStGiangVien = new TList<GiangVienHoatDongNgoaiGiangDay>();
        string _maTruong;
        RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditLop, repositoryItemGridLookUpEditTenMonHoc;
        string _groupName = UserInfo.GroupName;
        string iMaHoatDong = UserInfo.MaHoatDong;//phân quyền cho hoạt động    
        string[] LstColumns = new string[] { "MaGiangVien", "MaHoatDong", "MaLop", "TenMonHoc", "SiSo", "SoTiet", "SoLuong", "GhiChu", "MaQuanLy", "Chon" };
        string strMaGiangVien = string.Empty, strMaHoatDong = string.Empty;
        List<string> strListXoaMaQuanLy = new List<string>();
        DataTable _listGiangVienHDNGD = new DataTable();
        DateTime _ngayIn;
        bool bUser = false;
        bool bUserHoatDong = false;
        #endregion

        #region Event Form
        public frmGiangVienHoatDongNgoaiGiangDay()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Where(i => i.TenCauHinh == "Mã trường").First().GiaTri;
        }

        #region Khac
        private void BUHENABLE(bool b)
        {
            gridViewGiangVienHDNGD.Columns["MaLop"].Visible = b;
            gridViewGiangVienHDNGD.Columns["TenMonHoc"].Visible = b;
        }

        private void LoadLop()
        {
            DataTable dtLop = new DataTable();
            IDataReader readerLop = DataServices.ViewLopHocPhan.GetByNamHocHocKyKhoaDonViBuh(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
            dtLop.Load(readerLop);
            repositoryItemGridLookUpEditLop.DataSource = dtLop;
            repositoryItemGridLookUpEditTenMonHoc.DataSource = dtLop;
        }

        #endregion


        private void HideButton()
        {
            btnLayDuLieu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }
        private void frmGiangVienHoatDongNgoaiGiangDay_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewGiangVienHDNGD, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewGiangVienHDNGD, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewGiangVienHDNGD, LstColumns
                        , new string[] { "Họ và tên", "Hoạt động ngoài giảng dạy", "Lớp", "Tên môn học", "Sĩ số", "Số tiết", "Số lượng", "Ghi chú", "Mã HD", "Chọn" }
                        , new int[] { 180, 350, 150, 250, 90, 90, 90, 180, 99, 100 });
            AppGridView.AlignHeader(gridViewGiangVienHDNGD, new string[] { "MaGiangVien", "MaHoatDong", "MaLop", "TenMonHoc", "SiSo", "SoTiet", "SoLuong", "GhiChu", "Chon" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewGiangVienHDNGD, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewGiangVienHDNGD, "MaHoatDong", repositoryItemGridLookUpEditHoatDong);
            AppGridView.FormatDataField(gridViewGiangVienHDNGD, "SoLuong", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewGiangVienHDNGD, "SiSo", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewGiangVienHDNGD, "SoTiet", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.SummaryField(gridViewGiangVienHDNGD, "MaGiangVien", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);

            BUHENABLE(true);
            AppGridView.ReadOnlyColumn(gridViewGiangVienHDNGD, new string[] { "SiSo", "SoTiet" });
            AppGridView.HideField(gridViewGiangVienHDNGD, new string[] { "Chon" });
            #endregion

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "TenHocKy" }, new string[] { "Học kỳ" });
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region Khoa bộ môn
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaBoMon", "TenBoMon" }, new string[] { "Mã bộ môn", "Tên bộ môn" });
            cboKhoaDonVi.Properties.DisplayMember = "TenBoMon";
            cboKhoaDonVi.Properties.ValueMember = "MaBoMon";
            cboKhoaDonVi.Properties.NullText = string.Empty;

            #endregion

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenDonVi" }, new string[] { "Mã giảng viên", "Họ tên", "Khoa - Đơn vị" }
                        , new int[] { 100, 180, 120 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 400, 500);
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "HoTen";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            #region HoatDongNgoaiGiangDay
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHoatDong, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHoatDong, new string[] { "TenHoatDong", "MucQuyDoi", "GhiChu" }, new string[] { "Tên hoạt động", "Mức quy đổi", "Ghi chú" }, new int[] { 300, 100, 100 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditHoatDong, 500, 450);
            repositoryItemGridLookUpEditHoatDong.DisplayMember = "TenHoatDong";
            repositoryItemGridLookUpEditHoatDong.ValueMember = "MaHoatDong";
            repositoryItemGridLookUpEditHoatDong.NullText = string.Empty;
            #endregion

            #region _LoaiHoatDongNgoaiGiangDay
            //AppGridLookupEdit.InitGridLookUp(cbo_LoaiHoatDong, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            //AppGridLookupEdit.ShowField(cbo_LoaiHoatDong, new string[] { "TenHoatDong" }, new string[] { "Tên hoạt động" });
            //cbo_LoaiHoatDong.Properties.DisplayMember = "TenHoatDong";
            //cbo_LoaiHoatDong.Properties.ValueMember = "MaHoatDong";
            #endregion

            #region Lớp
            repositoryItemGridLookUpEditLop = new RepositoryItemGridLookUpEdit();
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLop
                , DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLop
                , new string[] { "MaLop", "TenLop" }
                , new string[] { "Mã lớp", "Tên môn" }
                , new int[] { 50, 100 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditLop, 500, 450);
            repositoryItemGridLookUpEditLop.DisplayMember = "MaLop";
            repositoryItemGridLookUpEditLop.ValueMember = "MaLop";
            repositoryItemGridLookUpEditLop.NullText = string.Empty;
            AppGridView.RegisterControlField(gridViewGiangVienHDNGD, "MaLop", repositoryItemGridLookUpEditLop);

            repositoryItemGridLookUpEditTenMonHoc = new RepositoryItemGridLookUpEdit();
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditTenMonHoc
                , DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditTenMonHoc
                , new string[] { "MaLop", "TenLop" }
                , new string[] { "Mã lớp", "Tên môn" }
                , new int[] { 50, 100 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditTenMonHoc, 300, 550);
            repositoryItemGridLookUpEditTenMonHoc.DisplayMember = "TenLop";
            repositoryItemGridLookUpEditTenMonHoc.ValueMember = "MaLop";
            repositoryItemGridLookUpEditTenMonHoc.NullText = string.Empty;
            AppGridView.RegisterControlField(gridViewGiangVienHDNGD, "TenMonHoc", repositoryItemGridLookUpEditTenMonHoc);

            #endregion

            InitData();
        }
        #endregion

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            cboKhoaDonVi.DataBindings.Clear();
            VList<ViewKhoaBoMon> _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                if (_groupName == v.MaBoMon)
                {
                    bUser = true;
                    break;
                }

            }
            if (bUser)
                _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetByMaBoMon(_groupName);
            else
                _vListKhoaBoMon.Add(new ViewKhoaBoMon() { ThuTu = 0, MaBoMon = "-1", TenBoMon = "[Tất cả]" });
            bindingSourceKhoaDonVi.DataSource = _vListKhoaBoMon;
            bindingSourceKhoaDonVi.Sort = "ThuTu";
            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaBoMon", true, DataSourceUpdateMode.Never);



            //Giảng viên của khoa khác cũng có thể dc phân công cho khoa _groupname 
            cbo_LoaiHoatDong.Properties.SelectAllItemCaption = "Tất cả";       
            cbo_LoaiHoatDong.DataBindings.Clear();
            List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();
            VList<ViewGiangVienHoatDongNgoaiGiangDay> _VListHoatDongNgoaiGiangDay = DataServices.ViewGiangVienHoatDongNgoaiGiangDay.GetAll();
            foreach (ViewGiangVienHoatDongNgoaiGiangDay item in _VListHoatDongNgoaiGiangDay)
            {
                foreach (var itemHD in iMaHoatDong.Split(';'))
                {
                    if (item.MaHoatDong == int.Parse(itemHD.ToString()))
                    {
                        bUserHoatDong = true;
                        break;
                    }
                }
            }
            if (bUserHoatDong)
                _VListHoatDongNgoaiGiangDay = DataServices.ViewGiangVienHoatDongNgoaiGiangDay.GetByMaHoatDong(iMaHoatDong.ToString());
            else
                _VListHoatDongNgoaiGiangDay.Add(new ViewGiangVienHoatDongNgoaiGiangDay() { MaHoatDong = -1, TenHoatDong = "[Tất cả]" });
            foreach (ViewGiangVienHoatDongNgoaiGiangDay obj in _VListHoatDongNgoaiGiangDay)
            {
                list.Add(new CheckedListBoxItem(obj.MaHoatDong.ToString(), obj.TenHoatDong.ToString(), CheckState.Unchecked, true));
            }
            cbo_LoaiHoatDong.Properties.Items.AddRange(list.ToArray());
            cbo_LoaiHoatDong.Properties.SeparatorChar = ';';
            //bindingSourceMaHoatDong.DataSource = _VListHoatDongNgoaiGiangDay;
            //bindingSourceMaHoatDong.Sort = "MaHoatDong";
            //cbo_LoaiHoatDong.DataBindings.Add("EditValue", bindingSourceMaHoatDong, "MaHoatDong", true, DataSourceUpdateMode.Never);
            //cbo_LoaiHoatDong.Properties.DataSource = bindingSourceMaHoatDong;

            bindingSourceHoatDong.DataSource = DataServices.ViewGiangVienHoatDongNgoaiGiangDay.GetAll();// DataServices.HoatDongNgoaiGiangDay.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null && cbo_LoaiHoatDong.EditValue != null)
            {
                LoadLop();
                LoadDataBy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), cbo_LoaiHoatDong.EditValue.ToString());
            }

        }

        private void LoadDataGiangVienByKhoa(string strKhoa, string strNamHoc, string strHocKy)
        {
            _ViewGiangVien = DataServices.ViewGiangVien.GetByMaDonViTrucThuoc(strKhoa, strNamHoc, strHocKy);
            bindingSourceGiangVien.DataSource = _ViewGiangVien;

        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            strListXoaMaQuanLy.Clear();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] LstIndex = gridViewGiangVienHDNGD.GetSelectedRows();
            for (int i = 0; i < LstIndex.Length; i++)
            {
                GiangVienHoatDongNgoaiGiangDay itemGiangVien = new GiangVienHoatDongNgoaiGiangDay();
                itemGiangVien.MaQuanLy = int.Parse(gridViewGiangVienHDNGD.GetRowCellValue(LstIndex[i], "MaQuanLy").ToString());
                itemGiangVien.MaGiangVien = int.Parse(gridViewGiangVienHDNGD.GetRowCellValue(LstIndex[i], "MaGiangVien").ToString());
                itemGiangVien.MaHoatDong = int.Parse(gridViewGiangVienHDNGD.GetRowCellValue(LstIndex[i], "MaHoatDong").ToString());
                itemGiangVien.SoLuong = int.Parse(gridViewGiangVienHDNGD.GetRowCellValue(LstIndex[i], "SoLuong").ToString());

                itemGiangVien.MaLop = gridViewGiangVienHDNGD.GetRowCellValue(LstIndex[i], "MaLop").ToString();
                itemGiangVien.GhiChu = gridViewGiangVienHDNGD.GetRowCellValue(LstIndex[i], "GhiChu").ToString();

                LStGiangVien.Add(itemGiangVien);
            }
            AppGridView.DeleteSelectedRows(gridViewGiangVienHDNGD);
        }

        private string GetXML(string strAction)
        {
            strAction = strListXoaMaQuanLy.Count > 0 ? "Xóa" : "Luu";
            string strKhoa = string.Empty;
            bool bChon = true; ;
            string xmlData = "";
            if (strAction == "Luu")
            {
                DataTable list = bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource as DataTable;
                foreach (DataRow row in list.Rows)
                {
                    if (row.RowState != DataRowState.Deleted)
                    {
                        if (row["MaGiangVien"].ToString() == string.Empty || row["MaHoatDong"].ToString() == string.Empty || row["SoLuong"].ToString() == string.Empty)
                        {
                            xmlData = string.Empty;
                            break;
                        }
                        strKhoa = string.Empty;
                        bChon = false;
                        strKhoa = row["MaLop"].ToString();
                        xmlData += GetDataRow(row, strKhoa, bChon);
                    }

                }
            }
            else
            {
                foreach (string item in strListXoaMaQuanLy)
                {
                    foreach (DataRow row in _listGiangVienHDNGD.Rows)
                    {
                        if (item.ToString() == row["MaQuanLy"].ToString())
                        {
                            xmlData += GetDataRow(row, strKhoa, bChon);
                            break;
                        }
                    }

                }
            }
            if (xmlData != string.Empty)
            {
                xmlData = String.Format("<Root>{0}</Root>", xmlData);
            }
            return xmlData;
        }

        string GetDataRow(DataRow row, string strKhoa, bool bChon)
        {
            string strGetRow = string.Empty;
            strGetRow = "<Input Q=\"" + row["MaQuanLy"].ToString()
                        + "\" M=\"" + row["MaGiangVien"].ToString()
                        + "\" H=\"" + row["MaHoatDong"].ToString()
                        + "\" S=\"" + PMS.Common.Globals.IsNull(row["SoLuong"], "decimal")
                        + "\" L=\"" + strKhoa
                        + "\" G=\"" + row["GhiChu"]
                        + "\" B=\"" + bChon
                        + "\" />";
            return strGetRow;
        }

        private bool checkXoaMaGiangVien(string strMaGiangVien, string strMaLopHocPhan, string strMaHoatDong)
        {
            foreach (GiangVienHoatDongNgoaiGiangDay item in LStGiangVien)
            {
                if (item.MaGiangVien.ToString() == strMaGiangVien && item.MaLop == strMaLopHocPhan && item.MaHoatDong.ToString() == strMaHoatDong)
                    return true;
            }
            return false;
        }
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //Cập nhật mã lớp
            gridViewGiangVienHDNGD.FocusedRowHandle = -1;
            try
            {
                if (XtraMessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    //string xmlData = GetXML("Luu");
                    string xmlData = string.Empty;
                    string strKhoa = string.Empty;
                    bool bChon = true; ;
                    DataTable list = bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource as DataTable;
                    if (list.Rows.Count > 0)
                    {
                        foreach (DataRow row in list.Rows)
                        {
                            if (row.RowState != DataRowState.Deleted)
                            {
                                if ((row["MaGiangVien"].ToString() == string.Empty || row["MaHoatDong"].ToString() == string.Empty || row["SoLuong"].ToString() == string.Empty) && LStGiangVien.Count == 0)
                                {
                                    xmlData = string.Empty;
                                    break;
                                }
                                strKhoa = string.Empty;
                                bChon = checkXoaMaGiangVien(row["MaGiangVien"].ToString(), row["MaLop"].ToString(), row["MaHoatDong"].ToString());//(bool)PMS.Common.Globals.IsNull(row["LayDuLieu"],"bool") != false ? true : false;
                                strKhoa = row["MaLop"].ToString();
                                xmlData += GetDataRow(row, strKhoa, bChon);
                            }             

                        }
                    }
                    if (LStGiangVien.Count > 0)
                    {
                        foreach (GiangVienHoatDongNgoaiGiangDay item in LStGiangVien)
                        {
                            xmlData += "<Input Q=\"" + item.MaQuanLy.ToString()
                                  + "\" M=\"" + item.MaGiangVien.ToString()
                                  + "\" H=\"" + item.MaHoatDong.ToString()
                                  + "\" S=\"" + item.SoLuong.ToString()
                                  + "\" L=\"" + item.MaLop.ToString()
                                  + "\" G=\"" + item.GhiChu.ToString()
                                  + "\" B=\"" + true
                                  + "\" />";
                        }
                    }
                    if (xmlData == string.Empty && LStGiangVien.Count == 0)
                    {
                        XtraMessageBox.Show("Vui lòng nhập đủ thông tin tối thiểu: Giảng viên, hoạt động, số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (xmlData != string.Empty)
                    {
                        xmlData = String.Format("<Root>{0}</Root>", xmlData);
                    }
                    int kq = -1;
                    DataServices.GiangVienHoatDongNgoaiGiangDay.Luu(xmlData, cboKhoaDonVi.EditValue.ToString(), cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                    if (kq == 0)
                        PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_LuuThayDoiThanhCong, MessageBoxIcon.Information, true);
                    else
                        PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_LuuLoiXayRa, MessageBoxIcon.Error, true);
                    ShowDataGridView();
                    LStGiangVien.Clear();
                }
            }
            catch (Exception ex)
            { XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi." + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            Cursor.Current = Cursors.Default;
        }

        private void ShowDataGridView()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null && cbo_LoaiHoatDong.EditValue != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                LoadLop();
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.GiangVienHoatDongNgoaiGiangDay.GetByNamHocHocKyKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), cbo_LoaiHoatDong.EditValue.ToString());
                dt.Load(reader);
                dt.Columns["SoLuong"].ReadOnly = false;
                bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource = dt;// ShowInnitData(dt);
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnLayDuLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null && cbo_LoaiHoatDong.EditValue != null)
            {
                int kq = 0;
                DataServices.GiangVienHoatDongNgoaiGiangDay.KiemTraDuLieu(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), ref kq);
                if (kq == 0)
                {
                    if (XtraMessageBox.Show("Bạn muốn lấy dữ liệu tự động?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            LayDuLieu(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                            XtraMessageBox.Show("Lấy dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lấy dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                if (kq == 1)
                {
                    if (XtraMessageBox.Show(string.Format("Dữ liệu hoạt động ngoài giảng dạy của năm học {0} - {1} đã có, tiếp tục lấy dữ liệu sẽ ghi đè dữ liệu cũ.\n Bạn có muốn tiếp tục?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            LayDuLieu(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                            XtraMessageBox.Show("Lấy dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lấy dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                LoadDataBy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), cbo_LoaiHoatDong.EditValue.ToString());
            }
        }
        #endregion

        private void LayDuLieu(string StrNamHoc, string strHocKy, string strKhoa)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataServices.GiangVienHoatDongNgoaiGiangDay.LayDuLieu(StrNamHoc, strHocKy, strKhoa);
            Cursor.Current = Cursors.Default;
        }

        #region Evnet Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null && cbo_LoaiHoatDong.EditValue != null)
            {
                LoadLop();
                LoadDataBy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), cbo_LoaiHoatDong.EditValue.ToString());

            }
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null && cbo_LoaiHoatDong.EditValue != null)
            {
                LoadLop();
                LoadDataBy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), cbo_LoaiHoatDong.EditValue.ToString());

            }
            Cursor.Current = Cursors.Default;
        }

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null && cbo_LoaiHoatDong.EditValue != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                LoadLop();
                LoadDataBy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), cbo_LoaiHoatDong.EditValue.ToString());
                Cursor.Current = Cursors.Default;
            }
        }

        private void LoadDataBy(string strNamHoc, string strHocKy, string strKhoa, string strMaHoatDong)
        {
            try
            {
                LoadDataGiangVienByKhoa(strKhoa, strNamHoc, strHocKy);
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.GiangVienHoatDongNgoaiGiangDay.GetByNamHocHocKyKhoa(strNamHoc, strHocKy, strKhoa, strMaHoatDong);

                dt.Load(reader);
                dt.Columns["SoLuong"].ReadOnly = false;
                _listGiangVienHDNGD = dt;
                bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource = dt;
            }
            catch (Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
            }

        }

        #endregion

        #region Event Grid
        private void gridViewGiangVienHDNGD_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaGiangVien")
            {
                string strMaGiangVien = gridViewGiangVienHDNGD.GetRowCellValue(e.RowHandle, "MaGiangVien").ToString();
                string strHoTen = _ViewGiangVien.Find(p => p.MaGiangVien == int.Parse(strMaGiangVien)).HoTen;
                gridViewGiangVienHDNGD.SetRowCellValue(e.RowHandle, "HoTen", strHoTen);
            }
            if (col.FieldName == "MaLop" || col.FieldName == "MaHoatDong")
            {
                try
                {
                    int _siSo = 0, _soTiet = 0;
                    DataTable dtLop = repositoryItemGridLookUpEditLop.DataSource as DataTable;
                    DataRowView r = gridViewGiangVienHDNGD.GetRow(e.RowHandle) as DataRowView;
                    DataRow rowLHP = dtLop.Select(String.Format("MaLop = '{0}'", r["MaLop"]))[0];
                    _siSo = int.Parse(rowLHP["SiSo"].ToString());
                    _soTiet = int.Parse(rowLHP["SoTiet"].ToString());
                    gridViewGiangVienHDNGD.SetRowCellValue(e.RowHandle, "TenMonHoc", rowLHP["MaLop"].ToString());
                    gridViewGiangVienHDNGD.SetRowCellValue(e.RowHandle, "SiSo", _siSo);
                    gridViewGiangVienHDNGD.SetRowCellValue(e.RowHandle, "SoTiet", _soTiet);
                    if (r["MaHoatDong"].ToString() == "2")
                    {
                        gridViewGiangVienHDNGD.SetRowCellValue(e.RowHandle, "SoLuong", _siSo * (_soTiet / 15));
                    }
                    if (r["MaHoatDong"].ToString() == "1" || r["MaHoatDong"].ToString() == "9")
                    {
                        gridViewGiangVienHDNGD.SetRowCellValue(e.RowHandle, "SoLuong", _soTiet);
                    }
                    if (r["MaHoatDong"].ToString() == "6" || r["MaHoatDong"].ToString() == "7" || r["MaHoatDong"].ToString() == "8" || r["MaHoatDong"].ToString() == "12" || r["MaHoatDong"].ToString() == "16")
                    {
                        gridViewGiangVienHDNGD.SetRowCellValue(e.RowHandle, "SoLuong", _siSo);
                    }
                }
                catch
                { }
            }

        }


        private void gridViewGiangVienHDNGD_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewGiangVienHDNGD, e);
        }

        private void gridViewGiangVienHDNGD_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {

            if (gridViewGiangVienHDNGD.FocusedColumn.FieldName == "MaGiangVien")
            {
                strMaGiangVien = e.Value.ToString();
                if (strMaGiangVien == string.Empty)
                {
                    e.Valid = false;
                    e.ErrorText = "Vui lòng chọn giảng viên";
                }
            }
            else if (gridViewGiangVienHDNGD.FocusedColumn.FieldName == "MaHoatDong")
            {
                strMaHoatDong = e.Value.ToString();
                if (strMaHoatDong == string.Empty)
                {
                    e.Valid = false;
                    e.ErrorText = "Vui lòng chọn loại hoạt động";
                }
                else
                {
                    if (checkExistsMaGV(strMaGiangVien, strMaHoatDong, string.Empty) != false)
                    {
                        e.Valid = false;
                        e.ErrorText = "Hoạt động hiện tại đang chọn đã tồn tại.";
                    }
                }
            }
            else if (gridViewGiangVienHDNGD.FocusedColumn.FieldName == "SoLuong")
            {
                string strSoLuong = e.Value.ToString();
                if (!PMS.Common.XuLySo.KiemTraChuoiToanSo(strSoLuong))
                {
                    e.Valid = false;
                    e.ErrorText = "Vui lòng nhập số lượng";
                }
            }
            if (_maTruong == "BUH")
            {
                if (gridViewGiangVienHDNGD.FocusedColumn.FieldName == "MaLop")
                {
                    if (e.Value != null)
                    {
                        if (gridViewGiangVienHDNGD.GetRowCellValue(gridViewGiangVienHDNGD.FocusedRowHandle, "MaGiangVien") == null)
                            strMaGiangVien = string.Empty;
                        string strMaLop = e.Value.ToString();
                        if (checkExistsMaGV(strMaGiangVien, strMaHoatDong, strMaLop) != false)
                        {
                            e.Valid = false;
                            e.ErrorText = "Hoạt động hiện tại đang chọn đã tồn tại.";
                        }
                    }
                }
            }
        }

        private void cbo_LoaiHoatDong_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null && cbo_LoaiHoatDong.EditValue != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                LoadLop();
                LoadDataBy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), cbo_LoaiHoatDong.EditValue.ToString());
                Cursor.Current = Cursors.Default;
            }
        }

        private void btn_In_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
            gridViewGiangVienHDNGD.FocusedRowHandle = -1;
            bindingSourceGiangVienHoatDongNgoaiGiangDay.EndEdit();
            DataTable data = bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = new DataTable();
            IDataReader id = DataServices.GiangVienHoatDongNgoaiGiangDay.GetByNamHocHocKyKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), cbo_LoaiHoatDong.EditValue.ToString());
            vListBaoCao.Load(id);
            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewGiangVienHDNGD.SortedColumns)
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
                    frm.InThongKeTongHopPhanCong(vListBaoCao, UserInfo.UserName, _ngayIn);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void gridControlGiangVienHDNGD_Click(object sender, EventArgs e)
        {
            //int datarowcount = gridControlGiangVienHDNGD.FocusedView.DataRowCount;

            //int detaillevel = gridControlGiangVienHDNGD.FocusedView.DetailLevel;

            //DataRowView rowRowView = (DataRowView)gridControlGiangVienHDNGD.FocusedView.GetRow(0);

            //string column03 = Convert.ToString(rowRowView.Row.ItemArray[3]);
            //MessageBox.Show(column03.ToString());
        }

        private void btn_Nhapfileexcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int iOutput = -1;
            using (FrmIm_Ex_port_GiangVienHoatDongNgoaiGiangDay frmImExport = new NghiepVu.FrmIm_Ex_port_GiangVienHoatDongNgoaiGiangDay(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), 0))
            {
                frmImExport.MaHoatDong = cbo_LoaiHoatDong.EditValue.ToString();
                iOutput = frmImExport.OutPut;
                frmImExport.ShowDialog();
            }
            if (iOutput == 0)
            {
                LoadDataBy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), cbo_LoaiHoatDong.EditValue.ToString());
            }
        }

        private void btn_Xuatfileexcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable dbTable = new DataTable();
            dbTable.Load(DataServices.GiangVienHoatDongNgoaiGiangDay.GetByNamHocHocKyKhoaExportExcel(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), cbo_LoaiHoatDong.EditValue.ToString()));
            ExcelImport.exportDataToExcel(2, dbTable);
        }

        private void btn_XuatFileDuLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //DataTable dbTable = bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource as DataTable;
            //DataSet dsHoatDong = new DataSet("DSHoatDong");
            //dsHoatDong.Tables.Add(dbTable);
            //SaveFileDialog f = new SaveFileDialog();
            //f.Filter = "Excel file (*.xls)|*.xls";
            //if (f.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {
            //        iloveit1208Library k = new iloveit1208Library();//Lib ExcelLibrary
            //        k.ExportToExcel(dsHoatDong, f.FileName);
            //        XtraMessageBox.Show("Đã xuất danh sách thành công.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    catch
            //    {
            //        XtraMessageBox.Show("Lỗi xuất dữ liệu.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private bool checkExistsMaGV(string strMaGV, string strMaHD, string strMaLop)
        {
            bool bResult = false;
            DataTable tbl = bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource as DataTable;
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                if (tbl.Rows[i]["MaGiangVien"].ToString() == strMaGV && tbl.Rows[i]["MaHoatDong"].ToString() == strMaHD)
                {
                    if (tbl.Rows[i]["MaLop"].ToString() == strMaLop)
                    {
                        bResult = true;
                        break;
                    }
                }
            }
            return bResult;
        }


        public DataTable ShowInnitData(DataTable tbl)
        {
            DataTable tblShow = PMS.Common.XuLyGiaoDien.CreateTable(LstColumns);
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                DataRow dr = tblShow.NewRow();
                dr["MaGiangVien"] = tbl.Rows[i]["MaGiangVien"].ToString();
                dr["HoTen"] = tbl.Rows[i]["HoTen"].ToString();
                dr["MaHoatDong"] = tbl.Rows[i]["MaHoatDong"].ToString();
                dr["MaLop"] = tbl.Rows[i]["MaLop"].ToString();
                dr["TenMonHoc"] = tbl.Rows[i]["TenMonHoc"].ToString();
                dr["SiSo"] = tbl.Rows[i]["SiSo"].ToString();
                dr["SoTiet"] = tbl.Rows[i]["SoTiet"].ToString();
                dr["SoLuong"] = tbl.Rows[i]["SoLuong"].ToString();
                dr["GhiChu"] = tbl.Rows[i]["GhiChu"].ToString();
                dr["MaQuanLy"] = tbl.Rows[i]["MaQuanLy"].ToString();
                dr["Chon"] = false;
                tblShow.Rows.Add(dr);
            }
            return tblShow;
        }

        #endregion

    }
}