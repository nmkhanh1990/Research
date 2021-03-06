﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using DevExpress.Common.Grid;
using PMS.Services;
using DevExpress.XtraEditors.Controls;
using PMS.UI.Forms.NghiepVu.FormXuLy;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmThuLaoChamBai_VHU : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnDongBo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnDongBo.ItemShortcut = DevExpress.XtraBars.BarShortcut.Empty;
                btnChot.Enabled = false;
                btnHuyChot.Enabled = false;
            }
            else
            {
                btnDongBo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnChot.Enabled = true;
                btnHuyChot.Enabled = true;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        int kiemtra = 0;
        #endregion

        public frmThuLaoChamBai_VHU()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void frmThuLaoChamBai_VHU_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewThuLaoChamBai, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewThuLaoChamBai, new string[] { "MaGiangVienQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "TenDonVi", "LanThi", "KyThi", "TenHocPhan", "MaLopHocPhan", "SoTinChi", "BacDaoTao", "LopSinhVien", "SiSo", "ThoiGianThi", "DinhMucChamGiuaKy", "ThuLaoChamGiuaKy", "DinhMucChamCuoiKy", "ThuLaoChamCuoiKy", "ThanhTienLan1", "SoBaiLan2", "ThanhTienLan2", "TongCong", "HinhThucThi", "SoTietQuyDoi" }
                , new string[] { "Mã giảng viên", "Họ tên", "Học hàm", "Học vị", "Loại giảng viên", "Khoa - đơn vị", "Lần thi", "Kỳ thi", "Tên học phần", "Mã lớp học phần", "Số tín chỉ", "Bậc đào tạo", "Lớp sinh viên", "Sĩ số", "Thời gian thi", "Định mức chấm giữa kỳ", "Thù lai chấm giữa kỳ", "Định mức chấm cuối kỳ", "Thù lao chấm cuối kỳ", "Thành tiền lần 1", "Số bài lần 2", "Thành tiền lần 2", "Tổng cộng", "Hình thức thi", "Số tiết quy đổi" }
                    , new int[] { 90, 160, 100, 100, 100, 120, 70, 70, 110, 100, 80, 90, 100, 80, 80, 100, 100, 100, 100, 100, 80, 100, 110, 90, 90 });
            //AppGridView.HideField(gridViewThuLaoChamBai, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.AlignHeader(gridViewThuLaoChamBai, new string[] { "MaGiangVienQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "TenDonVi", "LanThi", "KyThi", "TenHocPhan", "MaLopHocPhan", "SoTinChi", "BacDaoTao", "LopSinhVien", "SiSo", "ThoiGianThi", "DinhMucChamGiuaKy", "ThuLaoChamGiuaKy", "DinhMucChamCuoiKy", "ThuLaoChamCuoiKy", "ThanhTienLan1", "SoBaiLan2", "ThanhTienLan2", "TongCong", "HinhThucThi", "SoTietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThuLaoChamBai, "MaGiangVienQuanLy", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewThuLaoChamBai);
            AppGridView.FormatDataField(gridViewThuLaoChamBai, "DinhMucChamGiuaKy", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThuLaoChamBai, "ThuLaoChamGiuaKy", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThuLaoChamBai, "DinhMucChamCuoiKy", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThuLaoChamBai, "ThuLaoChamCuoiKy", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThuLaoChamBai, "ThanhTienLan1", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThuLaoChamBai, "ThanhTienLan2", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThuLaoChamBai, "TongCong", DevExpress.Utils.FormatType.Custom, "n0");
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
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            InitData();
        }

        void InitData()
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.ThuLaoChamBaiVhu.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tbl.Load(reader);
                bindingSourceThuLaoChamBai.DataSource = tbl;

                DataServices.ThuLaoChamBaiVhu.KiemTraChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kiemtra);
                if (kiemtra == 1)
                {

                    btnChot.Enabled = false;
                    btnHuyChot.Enabled = true;
                    btnDongBo.Enabled = false;

                    lblGhiChu.Text = String.Format("Dữ liệu chấm bài năm học {0} - {1} của giảng viên đã bị chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());

                }
                else
                {
                    btnChot.Enabled = true;
                    btnHuyChot.Enabled = false;
                    btnDongBo.Enabled = true;

                    lblGhiChu.Text = "";
                }
                gridViewThuLaoChamBai.BestFitColumns();
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnChot_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null & cboHocKy.EditValue != null)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn chốt dữ liệu coi thi năm học {0} - {1} ?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    DataServices.ThuLaoChamBaiVhu.Chot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    XtraMessageBox.Show("Chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamTuoi.PerformClick();
                }
            }
        }

        private void btnHuyChot_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null & cboHocKy.EditValue != null)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn huỷ chốt dữ liệu coi thi năm học {0} - {1} ?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (frmXacNhanLaiMatKhau frm = new frmXacNhanLaiMatKhau(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "HuyThuLaoChamBai_VHU"))
                    {
                        frm.ShowDialog();
                    }
                    btnLamTuoi.PerformClick();
                }
            }
        }

        private void btnDongBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                //kiem tra chot
                if (XtraMessageBox.Show(string.Format("Bạn muốn đồng bộ khối lượng coi thi năm học {0} - {1}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int kq = 0;
                        Cursor.Current = Cursors.WaitCursor;
                        DataServices.ThuLaoChamBaiVhu.DongBo(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                        Cursor.Current = Cursors.Default;
                        if (kq == 0)
                            XtraMessageBox.Show("Đồng bộ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình đồng bộ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch 
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình đồng bộ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn năm học - học kỳ - đợt chi trả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamHoc.Focus();
            }
            btnLamTuoi.PerformClick();
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
                            gridControlThuLaoChamBai.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.ThuLaoChamBaiVhu.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tbl.Load(reader);
                bindingSourceThuLaoChamBai.DataSource = tbl;

                DataServices.ThuLaoChamBaiVhu.KiemTraChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kiemtra);
                if (kiemtra == 1)
                {

                    btnChot.Enabled = false;
                    btnHuyChot.Enabled = true;
                    btnDongBo.Enabled = false;

                    lblGhiChu.Text = String.Format("Dữ liệu chấm bài năm học {0} - {1} của giảng viên đã bị chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());

                }
                else
                {
                    btnChot.Enabled = true;
                    btnHuyChot.Enabled = false;
                    btnDongBo.Enabled = true;

                    lblGhiChu.Text = "";
                }
                gridViewThuLaoChamBai.BestFitColumns();
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.ThuLaoChamBaiVhu.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tbl.Load(reader);
                bindingSourceThuLaoChamBai.DataSource = tbl;

                DataServices.ThuLaoChamBaiVhu.KiemTraChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kiemtra);
                if (kiemtra == 1)
                {

                    btnChot.Enabled = false;
                    btnHuyChot.Enabled = true;
                    btnDongBo.Enabled = false;

                    lblGhiChu.Text = String.Format("Dữ liệu chấm bài năm học {0} - {1} của giảng viên đã bị chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());

                }
                else
                {
                    btnChot.Enabled = true;
                    btnHuyChot.Enabled = false;
                    btnDongBo.Enabled = true;

                    lblGhiChu.Text = "";
                }
                gridViewThuLaoChamBai.BestFitColumns();
            }
            Cursor.Current = Cursors.Default;
        }
    }
}