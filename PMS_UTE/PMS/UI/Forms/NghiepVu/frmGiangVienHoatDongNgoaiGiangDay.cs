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
//using Libraries.BLL;
using PMS.BLL;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;

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
        DataTable _listGiangVienHDNGD = new DataTable();
        //bool _status;
        string _maTruong;
        RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditLop, repositoryItemGridLookUpEditTenMonHoc;
        string _groupName = UserInfo.GroupName;
        string[] LstColumns = new string[] { "MaGiangVien", "HoTen", "MaHoatDong", "MaLop", "TenMonHoc", "SiSo", "SoTiet", "SoLuong", "GhiChu", "MaQuanLy", "Chon" };
        string strXoaMaGV = "0";
        string strMaGiangVien = string.Empty, strMaHoatDong = string.Empty;
        List<string> strListXoaMaQuanLy = new List<string>();
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
                        , new string[] { "Mã Giảng Viên", "Họ và tên", "Hoạt động ngoài giảng dạy", "Lớp", "Tên môn học", "Sĩ số", "Số tiết", "Số lượng", "Ghi chú", "Mã HD", "Chọn" }
                        , new int[] { 100, 180, 350, 150, 250, 90, 90, 90, 180, 99, 100 });
            AppGridView.AlignHeader(gridViewGiangVienHDNGD, new string[] { "MaGiangVien", "HoTen", "MaHoatDong", "MaLop", "TenMonHoc", "SiSo", "SoTiet", "SoLuong", "GhiChu", "Chon" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewGiangVienHDNGD, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewGiangVienHDNGD, "MaHoatDong", repositoryItemGridLookUpEditHoatDong);
            AppGridView.FormatDataField(gridViewGiangVienHDNGD, "SoLuong", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewGiangVienHDNGD, "SiSo", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewGiangVienHDNGD, "SoTiet", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.SummaryField(gridViewGiangVienHDNGD, "MaGiangVien", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);

            if (_maTruong == "BUH" || _maTruong == "HBU")
            {
                BUHENABLE(true);
                if (_maTruong == "HBU")
                {
                    AppGridView.HideField(gridViewGiangVienHDNGD, new string[] { "MaQuanLy", "MaLop", "TenMonHoc", "SiSo", "SoTiet","Chon" });
                    HideButton();
                }
                else
                {
                    AppGridView.ReadOnlyColumn(gridViewGiangVienHDNGD, new string[] { "SiSo", "SoTiet" });
                    AppGridView.HideField(gridViewGiangVienHDNGD, new string[] {  "MaQuanLy", "Chon" });
                }
            }
            else
            {
                BUHENABLE(false);
                HideButton();
            }
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
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            #region HoatDongNgoaiGiangDay
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHoatDong, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHoatDong, new string[] { "TenHoatDong", "MucQuyDoi", "GhiChu" }, new string[] { "Tên hoạt động", "Mức quy đổi", "Ghi chú" }, new int[] { 300, 100, 100 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditHoatDong, 500, 450);
            repositoryItemGridLookUpEditHoatDong.DisplayMember = "TenHoatDong";
            repositoryItemGridLookUpEditHoatDong.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEditHoatDong.NullText = string.Empty;

            #endregion

            #region Lớp
            if (_maTruong == "BUH" || _maTruong == "HBU")
            {
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
            }
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
                    _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetByMaBoMon(_groupName);
                    break;
                }
            }
            bindingSourceKhoaDonVi.DataSource = _vListKhoaBoMon;
            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaBoMon", true, DataSourceUpdateMode.Never);

            //Giảng viên của khoa khác cũng có thể dc phân công cho khoa _groupname        
            
            bindingSourceHoatDong.DataSource = DataServices.HoatDongNgoaiGiangDay.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                LoadLop();
                LoadDataBy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
            }

        }

        private void LoadDataGiangVienByKhoa(string strKhoa)
        {
            _ViewGiangVien = DataServices.ViewGiangVien.GetByMaDonVi(strKhoa);
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
            if (_maTruong == "HBU")
            {
                //string xmlData = GetXML("Xóa");
                //int kq = -1;
                //DataServices.GiangVienHoatDongNgoaiGiangDay.Luu(xmlData, cboKhoaDonVi.EditValue.ToString(), cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                //ShowDataGridView();
                string strMaQuanLy = gridViewGiangVienHDNGD.GetRowCellValue(gridViewGiangVienHDNGD.FocusedRowHandle, "MaQuanLy").ToString();
                strListXoaMaQuanLy.Add(strMaQuanLy);               

            }
            AppGridView.DeleteSelectedRows(gridViewGiangVienHDNGD);

        }

        private string GetXML(string strAction)
        {
            strAction = strListXoaMaQuanLy.Count > 0 ? "Xoa" : "Luu";
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
                        if (_maTruong == "HBU")
                        {
                            strKhoa = cboKhoaDonVi.EditValue.ToString();
                            bChon = strAction == "Luu" ? false : true;
                        }
                        else
                        {
                            strKhoa = row["MaLop"].ToString();
                            bChon = false;
                        }
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

        string GetDataRow(DataRow row,string strKhoa,bool bChon)
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

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //Cập nhật mã lớp
            if (_maTruong == "BUH" || _maTruong == "HBU")
            {
                gridViewGiangVienHDNGD.FocusedRowHandle = -1;
                try
                {
                    if (XtraMessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {              
                                 
                        string xmlData = GetXML("Luu");
                        if(xmlData==string.Empty)
                        {
                            XtraMessageBox.Show("Vui lòng nhập đủ thông tin tối thiểu: Giảng viên, hoạt động, số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        int kq = -1;
                        DataServices.GiangVienHoatDongNgoaiGiangDay.Luu(xmlData, cboKhoaDonVi.EditValue.ToString(), cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                        if (kq == 0)
                            PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_LuuThayDoiThanhCong, MessageBoxIcon.Information, true);
                        else
                            PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_LuuLoiXayRa, MessageBoxIcon.Error, true);
                        ShowDataGridView();
                        strListXoaMaQuanLy.Clear();
                    }
                }
                catch
                { XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                gridViewGiangVienHDNGD.FocusedRowHandle = -1;
                TList<GiangVienHoatDongNgoaiGiangDay> list = bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource as TList<GiangVienHoatDongNgoaiGiangDay>;
                if (list != null)
                {
                    foreach (GiangVienHoatDongNgoaiGiangDay g in list)
                    {
                        g.NamHoc = cboNamHoc.EditValue.ToString();
                        g.HocKy = cboHocKy.EditValue.ToString();
                    }
                    if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (list.IsValid)
                        {
                            try
                            {
                                bindingSourceGiangVienHoatDongNgoaiGiangDay.EndEdit();
                                DataServices.GiangVienHoatDongNgoaiGiangDay.Save(list);
                                XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch
                            {
                                XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void ShowDataGridView()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                LoadLop();

                DataTable dt = new DataTable();
                IDataReader reader = DataServices.GiangVienHoatDongNgoaiGiangDay.GetByNamHocHocKyKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                dt.Load(reader);
                bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource = ShowInnitData(dt);
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnLayDuLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                int kq = 0;
                DataServices.GiangVienHoatDongNgoaiGiangDay.KiemTraDuLieu(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), ref kq);
                DataTable dt = new DataTable();
                IDataReader reader;
                if (kq == 0)
                {
                    if (XtraMessageBox.Show("Bạn muốn lấy dữ liệu tự động?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            reader = DataServices.GiangVienHoatDongNgoaiGiangDay.LayDuLieu(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                            dt.Load(reader);
                            bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource = dt;
                            Cursor.Current = Cursors.Default;

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
                            Cursor.Current = Cursors.WaitCursor;
                            reader = DataServices.GiangVienHoatDongNgoaiGiangDay.LayDuLieu(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                            dt.Load(reader);
                            bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource = dt;
                            Cursor.Current = Cursors.Default;
                            XtraMessageBox.Show("Lấy dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lấy dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        #endregion

        #region Evnet Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                LoadLop();
                LoadDataBy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());

            }
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                LoadLop();
                LoadDataBy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());

            }
            Cursor.Current = Cursors.Default;
        }

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                LoadLop();
                LoadDataBy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                Cursor.Current = Cursors.Default;
            }
        }

        private void LoadDataBy(string strNamHoc, string strHocKy, string strKhoa)
        {
            try
            {
                LoadDataGiangVienByKhoa(strKhoa);
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.GiangVienHoatDongNgoaiGiangDay.GetByNamHocHocKyKhoa(strNamHoc, strHocKy, strKhoa);
                dt.Load(reader);
                _listGiangVienHDNGD = dt;
                bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource = ShowInnitData(dt);
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
            strXoaMaGV = gridViewGiangVienHDNGD.GetRowCellValue(e.RowHandle, "MaGiangVien").ToString();
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
                    if (checkExistsMaGV(strMaGiangVien, strMaHoatDong,string.Empty) != false)
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
            if(_maTruong=="BUH")
            {
                if(gridViewGiangVienHDNGD.FocusedColumn.FieldName == "MaLop")
                {
                    string strMaLop = e.Value.ToString();
                    if (checkExistsMaGV(strMaGiangVien, strMaHoatDong, strMaLop) != false)
                    {
                        e.Valid = false;
                        e.ErrorText = "Hoạt động hiện tại đang chọn đã tồn tại.";
                    }
                }
            }
        }

        private bool checkExistsMaGV(string strMaGV, string strMaHD,string strMaLop)
        {
            bool bResult = false;
            DataTable tbl = bindingSourceGiangVienHoatDongNgoaiGiangDay.DataSource as DataTable;
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                if (tbl.Rows[i]["MaGiangVien"].ToString() == strMaGV && tbl.Rows[i]["MaHoatDong"].ToString() == strMaHD)
                {
                    if (_maTruong == "HBU")
                    {
                        bResult = true;
                        break;
                    }
                    else
                    {
                        if(tbl.Rows[i]["MaLop"].ToString() == strMaLop)
                        {
                            bResult = true;
                            break;
                        }
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