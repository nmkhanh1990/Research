﻿using DevExpress.Common.Grid;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using PMS.BLL;
using PMS.Comon;
using PMS.Entities;
using PMS.Services;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmHoatDongNgoaiGiangDayCLC : XtraForm
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
        string _groupName = UserInfo.GroupName;
        string iMaHoatDong = UserInfo.MaHoatDong;//phân quyền cho hoạt động    
        bool bUserHoatDong = false;
        bool _userRole;
        VList<ViewGiangVien> _listGiangVien;
        VList<ViewHoatDongNgoaiGiangDayNhomClc> _listHoatDong;
        TList<HoatDongNgoaiGiangDayClc> LstHDCLC = new TList<HoatDongNgoaiGiangDayClc>();
        int iSoLuong = 0;
        #endregion

        #region Event Form
        public frmHoatDongNgoaiGiangDayCLC()
        {
            InitializeComponent();
        }

        private void frmHoatDongNgoaiGiangDayCLC_Load(object sender, EventArgs e)
        {
            try
            {
                #region InitGridView
                AppGridView.InitGridView(gridViewHoatDongNgoaiGiangDayCLC, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
                AppGridView.ShowEditor(gridViewHoatDongNgoaiGiangDayCLC, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
                AppGridView.ShowField(gridViewHoatDongNgoaiGiangDayCLC, new string[] { "MaGiangVien", "HoTen", "MaHoatDong", "MaLopHocPhan", "SoLuong", "SoTien", "GhiChu" }
                            , new string[] { "Mã giảng viên", "Họ Tên", "Tên hoạt động", "Mã lớp", "Số lượng", "Số tiền", "Ghi chú" }
                            , new int[] { 90, 150, 350, 110, 90, 100, 120 });
                AppGridView.AlignHeader(gridViewHoatDongNgoaiGiangDayCLC, new string[] { "MaGiangVien", "HoTen", "MaHoatDong", "MaLopHocPhan", "SoLuong", "SoTien", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
                AppGridView.SummaryField(gridViewHoatDongNgoaiGiangDayCLC, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
                AppGridView.SummaryField(gridViewHoatDongNgoaiGiangDayCLC, "SoTien", "{0}", DevExpress.Data.SummaryItemType.Sum);
                AppGridView.FormatDataField(gridViewHoatDongNgoaiGiangDayCLC, "SoTien", DevExpress.Utils.FormatType.Custom, "n0");
                AppGridView.RegisterControlField(gridViewHoatDongNgoaiGiangDayCLC, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
                AppGridView.RegisterControlField(gridViewHoatDongNgoaiGiangDayCLC, "MaHoatDong", repositoryItemGridLookUpEditHoatDong);
                AppGridView.RegisterControlField(gridViewHoatDongNgoaiGiangDayCLC, "MaLopHocPhan", repositoryItemGridLookUpEditLopHocPhan);
                #endregion

                #region NamHoc
                AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
                AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
                cboNamHoc.Properties.DisplayMember = "NamHoc";
                cboNamHoc.Properties.ValueMember = "NamHoc";
                cboNamHoc.Properties.NullText = string.Empty;
                cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
                #endregion

                #region Học kỳ
                AppGridLookupEdit.InitGridLookUp(cboHocKy, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
                AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
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
                repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
                repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
                repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
                #endregion

                #region HoatDongNgoaiGiangDay
                AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHoatDong, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
                AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHoatDong, new string[] { "TenHoatDong", "MucQuyDoi", "DonGia", "GhiChu" }, new string[] { "Tên hoạt động", "Mức quy đổi", "Đơn giá", "Ghi chú" }, new int[] { 300, 100, 100, 100 });
                AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditHoatDong, 600, 650);
                repositoryItemGridLookUpEditHoatDong.DisplayMember = "TenHoatDong";
                repositoryItemGridLookUpEditHoatDong.ValueMember = "MaQuanLy";
                repositoryItemGridLookUpEditHoatDong.NullText = string.Empty;
                #endregion

                #region LopHocPhan

                AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLopHocPhan, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
                AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLopHocPhan, new string[] { "MaLop", "TenLop" }, new string[] { "Mã lớp", "Tên môn" }, new int[] { 50, 100 });
                AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditLopHocPhan, 500, 450);
                repositoryItemGridLookUpEditLopHocPhan.DisplayMember = "MaLop";
                repositoryItemGridLookUpEditLopHocPhan.ValueMember = "MaLop";
                repositoryItemGridLookUpEditLopHocPhan.NullText = string.Empty;
                #endregion

                #region _LoaiHoatDongNgoaiGiangDay
                AppGridLookupEdit.InitGridLookUp(cbo_LoaiHoatDongCLC, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
                AppGridLookupEdit.ShowField(cbo_LoaiHoatDongCLC, new string[] { "TenHoatDong" }, new string[] { "Tên hoạt động" });
                cbo_LoaiHoatDongCLC.Properties.DisplayMember = "TenHoatDong";
                cbo_LoaiHoatDongCLC.Properties.ValueMember = "MaQuanLy";
                #endregion

                InitData();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }
        #endregion

        #region InitData
        void InitData()
        {
            #region _namHoc-_hocKy
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
            #endregion

            #region _khoaDonVi
            cboKhoaDonVi.DataBindings.Clear();

            VList<ViewKhoaBoMon> _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();

            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                if (_groupName == v.MaBoMon)
                {
                    _userRole = true;
                    break;
                }
                else
                {
                    _userRole = false;
                }
            }

            if (_userRole)
            {
                _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetByMaBoMon(_groupName);
            }
            else
            {
                _vListKhoaBoMon.Add(new ViewKhoaBoMon() { ThuTu = 0, MaBoMon = "-1", TenBoMon = "[Tất cả]" });
            }
            bindingSourceKhoaDonVi.DataSource = _vListKhoaBoMon;
            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaBoMon", true, DataSourceUpdateMode.Never);
            #endregion

            #region MaHoatDong
            cbo_LoaiHoatDongCLC.DataBindings.Clear();
            VList<ViewHoatDongNgoaiGiangDayNhomClc> _VListHoatDongNgoaiGiangDay = DataServices.ViewHoatDongNgoaiGiangDayNhomClc.GetAll();
            foreach (ViewHoatDongNgoaiGiangDayNhomClc item in _VListHoatDongNgoaiGiangDay)
            {
                foreach (var itemHD in iMaHoatDong.Split(';'))
                {
                    if (item.MaQuanLy == int.Parse(itemHD.ToString()))
                    {
                        bUserHoatDong = true;
                        break;
                    }
                }
            }
            if (bUserHoatDong)
            {
                _VListHoatDongNgoaiGiangDay = DataServices.ViewHoatDongNgoaiGiangDayNhomClc.GetMaQuanLyNhomCLC(iMaHoatDong);
            }
            else
                _VListHoatDongNgoaiGiangDay.Add(new ViewHoatDongNgoaiGiangDayNhomClc() { MaQuanLy = -1, TenHoatDong = "[Tất cả]" });
            bds_MaHoatDong.DataSource = _VListHoatDongNgoaiGiangDay;
            bds_MaHoatDong.Sort = "MaQuanLy";
            cbo_LoaiHoatDongCLC.DataBindings.Add("EditValue", bds_MaHoatDong, "MaQuanLy", true, DataSourceUpdateMode.Never);
            cbo_LoaiHoatDongCLC.Properties.DataSource = bds_MaHoatDong;
            #endregion

            #region GiangVien
            InitGiangVien();
            #endregion

            #region HoatDong
            _listHoatDong = DataServices.ViewHoatDongNgoaiGiangDayNhomClc.GetAll();
            bindingSourceHoatDong.DataSource = _listHoatDong;
            #endregion

            #region LopHocPhan
            InitLopHocPhan();
            #endregion

            LoadDataSource();
        }

        void InitGiangVien()
        {
            if (cboKhoaDonVi.EditValue != null)
            {
                _listGiangVien = DataServices.ViewGiangVien.GetByMaDonViTrucThuoc(cboKhoaDonVi.EditValue.ToString(), cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                bindingSourceGiangVien.DataSource = _listGiangVien;
            }
        }

        void InitLopHocPhan()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                //DataTable dtLop = Libraries.BLL.DBComunication.ExecProc("sp_psc_pms_getLop"
                //        , new object[] { cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString() });
                DataTable dtLop = new DataTable();
                IDataReader readerLop = DataServices.ViewLopHocPhan.GetByNamHocHocKyKhoaDonViBuh(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                dtLop.Load(readerLop);
                bindingSourceLopHocPhan.DataSource = dtLop;
            }
        }

        void LoadDataSource()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null && cbo_LoaiHoatDongCLC.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.HoatDongNgoaiGiangDayClc.GetByNamHocHocKyKhoaDonViMaHoatDong(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), cbo_LoaiHoatDongCLC.EditValue.ToString());
                tb.Load(reader);
                foreach (DataColumn col in tb.Columns)
                {
                    col.ReadOnly = false;
                }

                bindingSourceHoatDongNgoaiGiangDayCLC.DataSource = tb;
            }
        }
        #endregion

        #region Event CBO
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }

            InitLopHocPhan();

            LoadDataSource();
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitLopHocPhan();
            LoadDataSource();
            Cursor.Current = Cursors.Default;
        }

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitGiangVien();
            InitLopHocPhan();
            LoadDataSource();
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event Button


        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLayDuLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                int kq = 0;
                DataServices.HoatDongNgoaiGiangDayClc.KiemTraDuLieu(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), ref kq);

                if (kq == 0)
                {
                    if (XtraMessageBox.Show(string.Format("Bạn muốn thực hiện lấy dữ liệu năm học {0} - {1}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            DataServices.HoatDongNgoaiGiangDayClc.LayDuLieu(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                            XtraMessageBox.Show("Lấy dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        { }
                    }
                }
                else
                {
                    if (XtraMessageBox.Show(string.Format("Dữ liệu hoạt động ngoài giảng dạy của năm học {0} - {1} đã có, tiếp tục lấy dữ liệu sẽ ghi đè dữ liệu cũ.\n Bạn có muốn tiếp tục?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            DataServices.HoatDongNgoaiGiangDayClc.LayDuLieu(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                            XtraMessageBox.Show("Lấy dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        { }
                    }
                }

                barButtonItem1.PerformClick();
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] LstIndex = gridViewHoatDongNgoaiGiangDayCLC.GetSelectedRows();
            try
            {
                for (int i =0  ; i < LstIndex.Length; i++)
                {
                    HoatDongNgoaiGiangDayClc itemGiangVien = new HoatDongNgoaiGiangDayClc();
                    itemGiangVien.MaGiangVien = int.Parse(gridViewHoatDongNgoaiGiangDayCLC.GetRowCellValue(LstIndex[i], "MaGiangVien").ToString());
                    itemGiangVien.MaLopHocPhan = gridViewHoatDongNgoaiGiangDayCLC.GetRowCellValue(LstIndex[i], "MaLopHocPhan").ToString();
                    itemGiangVien.MaHoatDong = int.Parse(gridViewHoatDongNgoaiGiangDayCLC.GetRowCellValue(LstIndex[i], "MaHoatDong").ToString());
                    itemGiangVien.SoTien = int.Parse(gridViewHoatDongNgoaiGiangDayCLC.GetRowCellValue(LstIndex[i], "SoTien").ToString());
                    itemGiangVien.GhiChu = gridViewHoatDongNgoaiGiangDayCLC.GetRowCellValue(LstIndex[i], "GhiChu").ToString();
                    LstHDCLC.Add(itemGiangVien);
                }
                AppGridView.DeleteSelectedRows(gridViewHoatDongNgoaiGiangDayCLC);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }

        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewHoatDongNgoaiGiangDayCLC.FocusedRowHandle = -1;
            DataTable tb = bindingSourceHoatDongNgoaiGiangDayCLC.DataSource as DataTable;
            if (tb != null)
            {
                if (XtraMessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string xmlData = "";
                        int result = -1;
                        if (tb.Rows.Count > 0)
                        {
                            foreach (DataRow row in tb.Rows)
                            {
                                //bool bChon = (bool)PMS.Common.Globals.IsNull(row["LayDuLieu"], "bool") != false ? true : false;
                                if (row.RowState != DataRowState.Deleted)
                                {
                                    if (row["MaGiangVien"].ToString() != "" && row["MaHoatDong"].ToString() != "" && row["MaLopHocPhan"].ToString() != "")
                                    {
                                        xmlData += "<Input M=\"" + row["MaGiangVien"]
                                                + "\" L=\"" + row["MaLopHocPhan"]
                                                + "\" H=\"" + row["MaHoatDong"]
                                                + "\" T=\"" + row["SoTien"]
                                                + "\" G=\"" + row["GhiChu"]
                                                + "\" LayDuLieu=\"" + false
                                                + "\" />";
                                    }
                                    else
                                    {
                                        XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin họ tên, hoạt động và mã lớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                }
                            }
                        }
                        if (LstHDCLC.Count > 0)
                        {
                            foreach (HoatDongNgoaiGiangDayClc item in LstHDCLC)
                            {
                                xmlData += "<Input M=\"" + item.MaGiangVien
                                                + "\" L=\"" + item.MaLopHocPhan
                                                + "\" H=\"" + item.MaHoatDong
                                                + "\" T=\"" + item.SoTien
                                                + "\" G=\"" + item.GhiChu
                                                + "\" LayDuLieu=\"" + true
                                                + "\" />";
                            }
                        }
                        xmlData = "<Root>" + xmlData + "</Root>";
                        DataServices.HoatDongNgoaiGiangDayClc.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), ref result);
                        if (result == 0)
                        {
                            XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LstHDCLC.Clear();
                        }
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    { ex.Message.ToString(); }

                }
            }
        }


        #endregion

        #region Event Grid
        private void gridViewHoatDongNgoaiGiangDayCLC_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "MaGiangVien")
            {
                DataRowView r = gridViewHoatDongNgoaiGiangDayCLC.GetRow(e.RowHandle) as DataRowView;
                ViewGiangVien gv = _listGiangVien.Find(p => p.MaGiangVien == int.Parse(r["MaGiangVien"].ToString()));
                gridViewHoatDongNgoaiGiangDayCLC.SetRowCellValue(e.RowHandle, "HoTen", gv.HoTen);
            }
            else if (e.Column.FieldName == "MaHoatDong")
            {
                DataRowView r = gridViewHoatDongNgoaiGiangDayCLC.GetRow(e.RowHandle) as DataRowView;
                ViewHoatDongNgoaiGiangDayNhomClc hd = _listHoatDong.Find(p => p.MaQuanLy == int.Parse(r["MaHoatDong"].ToString()));
                gridViewHoatDongNgoaiGiangDayCLC.SetRowCellValue(e.RowHandle, "SoTien", hd.DonGia);
            }
            else if (e.Column.FieldName == "SoLuong")
            {
                iSoLuong = int.Parse(gridViewHoatDongNgoaiGiangDayCLC.GetRowCellValue(e.RowHandle, "SoLuong").ToString());
                DataRowView r = gridViewHoatDongNgoaiGiangDayCLC.GetRow(e.RowHandle) as DataRowView;
                ViewHoatDongNgoaiGiangDayNhomClc hd = _listHoatDong.Find(p => p.MaQuanLy == 18);
                gridViewHoatDongNgoaiGiangDayCLC.SetRowCellValue(e.RowHandle, "SoTien", iSoLuong * hd.DonGia);
            }

        }

        private void gridViewHoatDongNgoaiGiangDayCLC_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHoatDongNgoaiGiangDayCLC, e);
        }

        private void gridViewHoatDongNgoaiGiangDayCLC_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            //Mặc định khi thêm mới lấy hoạt động CLC
            //HoatDongNgoaiGiangDay hd = _listHoatDong.Find(p => p.MaQuanLy == 17);
            //gridViewHoatDongNgoaiGiangDayCLC.SetRowCellValue(e.RowHandle, "MaHoatDong", 17);
            //gridViewHoatDongNgoaiGiangDayCLC.SetRowCellValue(e.RowHandle, "SoTien", hd.DonGia);
        }
        #endregion

        private void gridViewHoatDongNgoaiGiangDayCLC_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            if (gridViewHoatDongNgoaiGiangDayCLC.FocusedColumn.FieldName == "SoLuong")
            {
                if (!PMS.Common.XuLySo.KiemTraChuoiToanSo(e.Value.ToString()))
                {
                    e.Valid = false;
                    e.ErrorText = PMS.Common.ThongBao.Str_ChiNhapSo;
                }
                else
                {
                    iSoLuong = int.Parse(e.Value.ToString());
                    if (iSoLuong > 2 || iSoLuong < 1)
                    {
                        e.Valid = false;
                        e.ErrorText = PMS.Common.ThongBao.Str_SoLuongCLC;
                    }
                }
            }
        }

        private void gridViewHoatDongNgoaiGiangDayCLC_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "SoLuong" && EditValueChamBai(view, view.FocusedRowHandle))
                e.Cancel = true;
        }

        private bool EditValueChamBai(GridView view, int row)
        {
            GridColumn col = view.Columns["MaHoatDong"];
            string val = Convert.ToString(view.GetRowCellValue(row, col));
            return (val == "20");
        }

        private void btn_XuatFileExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable dbTable = new DataTable();
            dbTable.Load(DataServices.GiangVienHoatDongNgoaiGiangDay.GetByNamHocHocKyKhoaExportExcel(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), cbo_LoaiHoatDongCLC.EditValue.ToString()));
            ExcelImport.exportDataToExcel(2, dbTable);
        }

        private void btn_NhapFileExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int iOutput = -1;
            using (FrmIm_Ex_port_GiangVienHoatDongNgoaiGiangDay frmImExport = new NghiepVu.FrmIm_Ex_port_GiangVienHoatDongNgoaiGiangDay(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), 1))
            {
                frmImExport.MaHoatDong = cbo_LoaiHoatDongCLC.EditValue.ToString();
                frmImExport.ShowDialog();
                iOutput = frmImExport.OutPut;
            }
            if (iOutput == 0)
            {
                LoadDataSource();
            }
        }

        private void cbo_LoaiHoatDongCLC_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitGiangVien();
            InitLopHocPhan();
            LoadDataSource();
            Cursor.Current = Cursors.Default;
        }


    }
}