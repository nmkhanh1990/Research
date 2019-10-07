﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Services;
using PMS.UI.Forms.NghiepVu.FormXuLy;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmTinhThuLaoChamBai_ACT : DevExpress.XtraEditors.XtraForm
    {

        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnDongBo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnDongBo.ItemShortcut = DevExpress.XtraBars.BarShortcut.Empty;
                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnQuyDoi.ItemShortcut = DevExpress.XtraBars.BarShortcut.Empty;
                btnChot.Enabled = false;
                btnHuyChot.Enabled = false;
            }
            else
            {
                btnDongBo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnChot.Enabled = true;
                btnHuyChot.Enabled = true;
            }
        }
        #endregion

        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int kiemtra = 0;
        public frmTinhThuLaoChamBai_ACT()
        {
            InitializeComponent();

            btnChot.Enabled = false;
            btnHuyChot.Enabled = false;
            btnDongBo.Enabled = false;
            btnQuyDoi.Enabled = false;
            lblGhiChu.Text = "";
        }

        private void frmTinhThuLaoChamBai_ACT_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewThuLaoChamBai, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThuLaoChamBai, new string[] { "MaGiangVienQuanLy", "HoTen", "TenDonVi", "MaLop", "TenMonHoc", "LoaiBaiThi", "SoBai", "HeSo", "TietQuyDoi" }
                , new string[] { "Mã giảng viên", "Họ tên", "Đơn vị", "Lớp", "Môn học", "Loại bài thi", "Số bài", "Hệ số", "Tiết quy đổi" }
                    , new int[] { 90, 150, 150, 80, 150, 300, 100, 100, 100 });
            AppGridView.AlignHeader(gridViewThuLaoChamBai, new string[] { "MaGiangVienQuanLy", "HoTen", "TenDonVi", "MaLop", "TenMonHoc", "LoaiBaiThi", "SoBai", "HeSo", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThuLaoChamBai, "MaGiangVienQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewThuLaoChamBai, "HeSo", DevExpress.Utils.FormatType.Custom, "n3");
            AppGridView.FormatDataField(gridViewThuLaoChamBai, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
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

            #region Init Khoa-DonVi
            cboKhoaDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboKhoaDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboKhoaDonVi.Properties.Items.Clear();

            VList<ViewKhoaBoMon> _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                if (v.MaBoMon == v.MaKhoa)
                    _list.Add(new CheckedListBoxItem(v.MaBoMon, v.MaBoMon + " - " + v.TenBoMon, CheckState.Unchecked, true));
            }

            cboKhoaDonVi.Properties.Items.AddRange(_list.ToArray());
            cboKhoaDonVi.Properties.SeparatorChar = ';';
            cboKhoaDonVi.CheckAll();
            #endregion
            
            InitData();
        }

        void InitData()
        {
            try
            {
                bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
                if (cboNamHoc.EditValue != null)
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    DataTable tb = new DataTable();
                    IDataReader reader = DataServices.ThuLaoChamBai.GetByNamHocHocKyKhoaDonVi_Act(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                    tb.Load(reader);
                    bindingSourceThulaoChamBai.DataSource = tb;

                    DataServices.ThuLaoChamBai.KiemTraChotTheoKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), "", ref kiemtra);
                    if (kiemtra == 1)
                    {
                        btnChot.Enabled = false;
                        btnHuyChot.Enabled = true;
                        btnDongBo.Enabled = false;
                        btnQuyDoi.Enabled = false;
                        lblGhiChu.Text = String.Format("Dữ liệu chấm bài năm học {0} - {1} của giảng viên đã bị chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    }
                    else
                    {
                        btnChot.Enabled = true;
                        btnHuyChot.Enabled = false;
                        btnDongBo.Enabled = true;
                        btnQuyDoi.Enabled = true;
                        lblGhiChu.Text = "";
                    }
                }
            }
            catch 
            {}
           
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnDongBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    //kiem tra chot
                    if (XtraMessageBox.Show(string.Format("Bạn muốn đồng bộ khối lượng chấm bài năm học {0} - {1}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int kq = 0;
                        Cursor.Current = Cursors.WaitCursor;
                        DataServices.ThuLaoChamBai.DongBo(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "", ref kq);
                        Cursor.Current = Cursors.Default;
                        if (kq == 0)
                            XtraMessageBox.Show("Đồng bộ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình đồng bộ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng chọn năm học - học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboNamHoc.Focus();
                }
                btnLamTuoi.PerformClick();
            }
            catch
            { }
           
        }

        private void btnQuyDoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                //kiem tra chot
                if (XtraMessageBox.Show(string.Format("Bạn muốn quy đổi khối lượng chấm bài năm học {0} - {1}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int kq = 0;
                    Cursor.Current = Cursors.WaitCursor;
                    DataServices.ThuLaoChamBai.QuyDoi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "", ref kq);
                    Cursor.Current = Cursors.Default;
                    if (kq == 0)
                        XtraMessageBox.Show("Quy đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình quy đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn năm học - học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamHoc.Focus();
            }

            btnLamTuoi.PerformClick();
        }

        private void btnChot_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null & cboHocKy.EditValue != null)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn chốt dữ liệu chấm bài năm học {0} - {1}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    DataServices.ThuLaoChamBai.ChotTheoKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), "");
                    XtraMessageBox.Show("Chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamTuoi.PerformClick();
                }
            }
        }

        private void btnHuyChot_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null & cboHocKy.EditValue != null)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn huỷ chốt dữ liệu chấm bài năm học {0} - {1}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (frmXacNhanLaiMatKhau frm = new frmXacNhanLaiMatKhau(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "", "HuyThuLaoChamBai"))
                    {
                        frm.ShowDialog();
                    }
                    btnLamTuoi.PerformClick();
                }
            }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (cboNamHoc.EditValue != null)
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
              
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    DataTable tb = new DataTable();
                    IDataReader reader = DataServices.ThuLaoChamBai.GetByNamHocHocKyKhoaDonVi_Act(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                    tb.Load(reader);
                    bindingSourceThulaoChamBai.DataSource = tb;

                    DataServices.ThuLaoChamBai.KiemTraChotTheoKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), "", ref kiemtra);
                    if (kiemtra == 1)
                    {

                        btnChot.Enabled = false;
                        btnHuyChot.Enabled = true;
                        btnDongBo.Enabled = false;
                        btnQuyDoi.Enabled = false;
                        lblGhiChu.Text = String.Format("Dữ liệu chấm bài năm học {0} - {1} của giảng viên đã bị chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());

                    }
                    else
                    {
                        btnChot.Enabled = true;
                        btnHuyChot.Enabled = false;
                        btnDongBo.Enabled = true;
                        btnQuyDoi.Enabled = true;
                        lblGhiChu.Text = "";
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch
            { }
           
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    DataTable tb = new DataTable();
                    IDataReader reader = DataServices.ThuLaoChamBai.GetByNamHocHocKyKhoaDonVi_Act(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                    tb.Load(reader);
                    bindingSourceThulaoChamBai.DataSource = tb;

                    DataServices.ThuLaoChamBai.KiemTraChotTheoKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), "", ref kiemtra);
                    if (kiemtra == 1)
                    {

                        btnChot.Enabled = false;
                        btnHuyChot.Enabled = true;
                        btnDongBo.Enabled = false;
                        btnQuyDoi.Enabled = false;
                        lblGhiChu.Text = String.Format("Dữ liệu chấm bài năm học {0} - {1} của giảng viên đã bị chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());

                    }
                    else
                    {
                        btnChot.Enabled = true;
                        btnHuyChot.Enabled = false;
                        btnDongBo.Enabled = true;
                        btnQuyDoi.Enabled = true;
                        lblGhiChu.Text = "";
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch
            { }
            
        }

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.ThuLaoChamBai.GetByNamHocHocKyKhoaDonVi_Act(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                tb.Load(reader);
                bindingSourceThulaoChamBai.DataSource = tb;

                DataServices.ThuLaoChamBai.KiemTraChotTheoKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), "", ref kiemtra);
                if (kiemtra == 1)
                {

                    btnChot.Enabled = false;
                    btnHuyChot.Enabled = true;
                    btnDongBo.Enabled = false;
                    btnQuyDoi.Enabled = false;
                    lblGhiChu.Text = String.Format("Dữ liệu chấm bài năm học {0} - {1} của giảng viên đã bị chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());

                }
                else
                {
                    btnChot.Enabled = true;
                    btnHuyChot.Enabled = false;
                    btnDongBo.Enabled = true;
                    btnQuyDoi.Enabled = true;
                    lblGhiChu.Text = "";
                }
            }
            Cursor.Current = Cursors.Default;
        }

    }
}