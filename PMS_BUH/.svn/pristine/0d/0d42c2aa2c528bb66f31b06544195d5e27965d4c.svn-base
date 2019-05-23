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
using PMS.UI.Forms.BaoCao;
using PMS.BLL;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using System.Data.SqlClient;
using DevExpress.Common.CheckedCombo;

namespace PMS.UI.Modules.Reports
{
    public partial class ucBangKeVuotGioGiangCaNamDLU : DevExpress.XtraEditors.XtraUserControl
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
        public ucBangKeVuotGioGiangCaNamDLU()
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

        private void ucBangKeVuotGioGiangCaNamDLU_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "Stt", "MaQuanLy", "Ho", "Ten", "MaDonVi", "TenDonVi", "ChucVu", "HocHam", "HocVi"
                        , "GioThucHienGiangDay", "GioThucHienNckh", "GioNghiaVuGiangDay", "GioNghiaVuNckh", "GioVuotGiangDay", "GioVuotNckh", "GhiChu" }
                    , new string[] { "STT", "Mã giảng viên", "Họ", "Tên", "Mã ĐV", "Đơn vị", "Chức vụ", "Học hàm", "Học vị"
                        , "Giờ thực hiện giảng dạy", "Giờ thực hiện NCKH", "Giờ nghĩa vụ giảng dạy", "Giờ nghĩa vụ NCKH", "Giờ vượt giảng dạy", "Giờ vượt NCKH", "Ghi chú" }
                    , new int[] { 50, 90, 125, 65, 60, 100, 90, 90, 80, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 80, 80, 70, 100 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "Stt", "MaQuanLy", "Ho", "Ten", "MaDonVi", "TenDonVi", "ChucVu", "HocHam", "HocVi"
                        , "GioThucHienGiangDay", "GioThucHienNckh", "GioNghiaVuGiangDay", "GioNghiaVuNckh", "GioVuotGiangDay", "GioVuotNckh", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);

            gridViewThongKe.Columns["TenDonVi"].GroupIndex = 0;
            AppGridView.FixedField(gridViewThongKe, new string[] { "Stt", "MaQuanLy", "Ho", "Ten" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
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

            #region Init Khoa-DonVi
            AppCheckedComboboxEdit.InitCheckedComboBoxEdit(cboDonVi, CheckState.Checked, LoaiDuLieu.KhoaDonVi, _maTruong);
            #endregion

            InitData();
        }
        #endregion

        #region InitData()
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
        }

        void LoadDataSource()
        {
            if (cboNamHoc.EditValue != null && cboDonVi.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.ThongKeGioNghiaVuCaNam(cboNamHoc.EditValue.ToString(), cboDonVi.EditValue.ToString());
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
                    frm.InThongKeVuotGioChuanDLU(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), "", ""
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

        private void btnXacNhanThanhToan_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboDonVi.EditValue != null)
            {
                if (XtraMessageBox.Show(string.Format("Xác nhận thanh toán giờ giảng năm học {0}?", cboNamHoc.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int kq = 0;
                        //Nếu thanh toán đợt 4 thì _hocKy = ""
                        DataServices.GiangVienTamUng.LuuTamUng(cboNamHoc.EditValue.ToString(), "", 0, ref kq);

                        if (kq == 0)
                            XtraMessageBox.Show(string.Format("Xác nhận thanh toán giờ giảng năm học {0} thành công.", cboNamHoc.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Xác nhận thanh toán giờ giảng thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (SqlException ex)
                    {
                        XtraMessageBox.Show(string.Format("Xác nhận thanh toán giờ giảng thất bại.\n {0}", ex.Message), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadDataSource();
                }
            }
        }

        private void btnHuyThanhToan_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboDonVi.EditValue != null)
            {
                if (XtraMessageBox.Show(string.Format("Huỷ xác nhận thanh toán giờ giảng năm học {0}?", cboNamHoc.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int kq = 0;
                        //Huỷ cả năm: _hocKy = ""
                        DataServices.GiangVienTamUng.HuyTamUng(cboNamHoc.EditValue.ToString(), "", 0, ref kq);

                        if (kq == 0)
                            XtraMessageBox.Show(string.Format("Huỷ xác nhận thanh toán giờ giảng năm học {0} thành công.", cboNamHoc.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Huỷ xác nhận thanh toán giờ giảng thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (SqlException ex)
                    {
                        XtraMessageBox.Show(string.Format("Huỷ xác nhận thanh toán giờ giảng thất bại.\n {0}", ex.Message), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadDataSource();
                }
            }
        }
        #endregion

        private void btnInGioNghiaVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                    frm.InBangThongKeGioChuanDLU(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), "", ""
                        , PMS.Common.Globals._cauhinh.PhongDaoTao, UserInfo.FullName, _ngayIn, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
