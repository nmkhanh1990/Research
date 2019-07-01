﻿using System;
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
using PMS.UI.Forms.BaoCao;
using PMS.BLL;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using DevExpress.Common.CheckedCombo;

namespace PMS.UI.Modules.Reports
{
    public partial class ucTongHopGioGiangToanTruongTheoDot : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        DateTime _ngayIn;
        bool userRole;
        string _groupName = UserInfo.GroupName;
        TList<CauHinhChotGio> _listDotThanhToan;

        #endregion

        #region Event Grid
        public ucTongHopGioGiangToanTruongTheoDot()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;

            TList<CauHinh> cauHinh = DataServices.CauHinh.GetAll();
            if (cauHinh != null)
            {
                foreach (CauHinh ch in cauHinh)
                {
                    if (ch.TrangThai == true)
                        PMS.Common.Globals._cauhinh = ch;
                }
            }
        }

        private void ucTongHopGioGiangToanTruongTheoDot_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "Stt", "MaDonVi", "TenDonVi", "Lt", "Thdc", "Thcn", "Nn", "LyThuyetSuPham", "ThcnSuPham", "TongTietQuyDoi", "KhoiLuongCongThem", "TongGio" }
                    , new string[] { "Stt", "Mã Khoa", "Tên khoa", "LT tổng hợp", "TH ĐC tổng hợp", "TH CN tổng hợp", "NN", "LT Sư phạm", "TH CN Sư phạm", "Số giờ quy đổi", "Số giờ quy đổi KL", "Tổng giờ quy đổi" }
                    , new int[] { 50, 60, 170, 70, 70, 70, 70, 70, 70, 80, 80, 80 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "Stt", "MaDonVi", "TenDonVi", "Lt", "Thdc", "Thcn", "Nn", "LyThuyetSuPham", "ThcnSuPham", "TongTietQuyDoi", "KhoiLuongCongThem", "TongGio" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewThongKe, new string[] { "Nn" });
            AppGridView.SummaryField(gridViewThongKe, "TenDonVi", "{0} đơn vị", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewThongKe, new string[] { "Lt", "Thdc", "Thcn", "LyThuyetSuPham", "ThcnSuPham", "TongTietQuyDoi", "KhoiLuongCongThem", "TongGio" }, "{0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewThongKe, new string[] { "Lt", "Thdc", "Thcn", "Nn", "LyThuyetSuPham", "ThcnSuPham", "TongTietQuyDoi", "KhoiLuongCongThem", "TongGio" }, DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.BackColorFieldAppearance(gridViewThongKe, new string[] { "Stt", "MaDonVi", "TenDonVi" }, Color.Azure);
            PMS.Common.Globals.WordWrapHeader(gridViewThongKe, 35);
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion
            
            #region Init LoaiGiangVien
            cboLoaiGiangVien.Properties.SelectAllItemCaption = "Tất cả";
            cboLoaiGiangVien.Properties.TextEditStyle = TextEditStyles.Standard;
            cboLoaiGiangVien.Properties.Items.Clear();

            TList<LoaiGiangVien> _listLoaiGv = new TList<LoaiGiangVien>();
            _listLoaiGv = DataServices.LoaiGiangVien.GetAll();

            List<CheckedListBoxItem> _listLGV = new List<CheckedListBoxItem>();
            foreach (LoaiGiangVien v in _listLoaiGv)
            {
                if (v.MaQuanLy.Equals("TG")) continue;
                _listLGV.Add(new CheckedListBoxItem(v.MaLoaiGiangVien.ToString(), v.TenLoaiGiangVien, CheckState.Unchecked, true));
            }
            cboLoaiGiangVien.Properties.Items.AddRange(_listLGV.ToArray());
            cboLoaiGiangVien.Properties.SeparatorChar = ';';
            cboLoaiGiangVien.CheckAll();
            #endregion

            #region Bậc - Loại hình
            VList<ViewBacDaoTaoLoaiHinh> _vListBacDaoTaoLoaiHinh = DataServices.ViewBacDaoTaoLoaiHinh.GetAll();
            _vListBacDaoTaoLoaiHinh.Sort("MaBacLoaiHinh");
            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            //MessageBox.Show(UserInfo.GroupID + " - " + UserInfo.GroupName);
            foreach (ViewBacDaoTaoLoaiHinh v in _vListBacDaoTaoLoaiHinh)
            {
                if (UserInfo.GroupName.Equals("PDT"))
                {
                    if ("DH;CD".Contains(v.MaBacDaoTao) && "CQ;XT".Contains(v.MaLoaiHinh))
                    {
                        _list.Add(new CheckedListBoxItem(v.MaBacLoaiHinh, v.TenBacLoaiHinh, CheckState.Unchecked, true));
                    }
                }
                else if (UserInfo.GroupName.Equals("PDTTX"))
                {
                    if ("TC;B2".Contains(v.MaLoaiHinh))
                    {
                        _list.Add(new CheckedListBoxItem(v.MaBacLoaiHinh, v.TenBacLoaiHinh, CheckState.Unchecked, true));
                    }
                }
                else if (UserInfo.GroupName.Equals("SDH"))
                {
                    if ("CH;NC".Contains(v.MaBacDaoTao))
                    {
                        _list.Add(new CheckedListBoxItem(v.MaBacLoaiHinh, v.TenBacLoaiHinh, CheckState.Unchecked, true));
                    }
                }
                else if (UserInfo.GroupName.Equals("Administrator"))
                {
                    _list.Add(new CheckedListBoxItem(v.MaBacLoaiHinh, v.TenBacLoaiHinh, CheckState.Unchecked, true));
                }
            }
            AppCheckedComboboxEdit.InitCheckedComboBoxEdit(cboLoaiHinhDaoTao, _list);
            #endregion

            InitData();
        }
        #endregion

        #region InitData()
        void InitDotThanhToan()
        {
            //if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            //{
            //    #region _dotThanhToan
            //    cboDotThanhToan.Properties.SelectAllItemCaption = "Tất cả";
            //    cboDotThanhToan.Properties.TextEditStyle = TextEditStyles.Standard;
            //    cboDotThanhToan.Properties.Items.Clear();
            //    _listDotThanhToan = DataServices.CauHinhChotGio.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            //    List<CheckedListBoxItem> _listDot = new List<CheckedListBoxItem>();
            //    foreach (CauHinhChotGio v in _listDotThanhToan)
            //    {
            //        _listDot.Add(new CheckedListBoxItem(v.MaCauHinhChotGio, v.MaQuanLy + " - " + v.TenQuanLy, CheckState.Unchecked, true));
            //    }
            //    cboDotThanhToan.Properties.Items.AddRange(_listDot.ToArray());
            //    cboDotThanhToan.Properties.SeparatorChar = ';';
            //    cboDotThanhToan.CheckAll();
            //    #endregion
            //}

            #region _dotThanhToan
            AppGridLookupEdit.InitGridLookUp(cboDotThanhToan, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboDotThanhToan, new string[] { "MaQuanLy", "TenQuanLy" }, new string[] { "Mã đợt", "Tên đợt" });
            cboDotThanhToan.Properties.ValueMember = "MaCauHinhChotGio";
            cboDotThanhToan.Properties.DisplayMember = "TenQuanLy";
            cboDotThanhToan.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Đợt thanh toán hiện tại").GiaTri;
            cboDotThanhToan.Properties.NullText = string.Empty;
            #endregion

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                //cboDotThanhToan.DataBindings.Clear();
                bindingSourceDotThanhToan.DataSource = DataServices.CauHinhChotGio.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                //cboDotThanhToan.DataBindings.Add("EditValue", bindingSourceDotThanhToan, "MaCauHinhChotGio", true, DataSourceUpdateMode.Never);
            }
        }

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            InitDotThanhToan();

            //LoadDataSource();
        }

        void LoadDataSource()
        {
            if (cboNamHoc.EditValue != null && cboDotThanhToan.EditValue != null && cboLoaiGiangVien.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.ThongKeTongHopGioGiangTheoDot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotThanhToan.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(),cboLoaiHinhDaoTao.EditValue.ToString());
                dt.Load(reader);
                bindingSourceThongKe.DataSource = dt;
                gridViewThongKe.ExpandAllGroups();
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

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmChonNgay frmChon = new frmChonNgay())
            {
                frmChon.ShowDialog();
                _ngayIn = frmChon.NgayIn;
            }
            Cursor.Current = Cursors.WaitCursor;
            gridViewThongKe.FocusedRowHandle = -1;
            bindingSourceThongKe.EndEdit();
            DataTable data = bindingSourceThongKe.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;

            vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThongKe, bindingSourceThongKe);
            
            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.ThongKeTongHopGioGiangToanTruong(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.Text, cboDotThanhToan.Text
                        , PMS.Common.Globals._cauhinh.PhongDaoTao, UserInfo.FullName, _ngayIn, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    if (sf.FileName != "")
                    {
                        gridControlThongKe.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadDataSource();
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            InitDotThanhToan();
            Cursor.Current = Cursors.Default;

        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitDotThanhToan();
            Cursor.Current = Cursors.Default;

        }
        #endregion
    }
}
