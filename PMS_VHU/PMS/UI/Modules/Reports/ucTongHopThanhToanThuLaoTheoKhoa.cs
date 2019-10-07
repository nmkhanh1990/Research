using DevExpress.Common.Grid;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using PMS.BLL;
using PMS.Entities;
using PMS.Services;
using PMS.UI.Forms.BaoCao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PMS.UI.Modules.Reports
{
    public partial class ucTongHopThanhToanThuLaoTheoKhoa : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        string groupname = UserInfo.GroupName;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        int lanchot = 0;
        #endregion
        public ucTongHopThanhToanThuLaoTheoKhoa()
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

        private void ucTongHopThanhToanThuLaoTheoKhoa_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "ChonIn", "MaQuanLy", "HoTen", "TenQuocTich", "TenDonVi", "TenHocHam", "TenHocVi"
                , "TenLoaiGiangVien", "MaLopHocPhan", "MaMonHoc", "TenMonHoc", "Loai", "Nhom", "MaLop", "SiSo", "SoTiet", "HeSoLopDong", "HeSoNgoaiGio"
                , "HeSoClcThem", "HeSoClc", "TietQuyDoi", "HeSoChucDanhChuyenMon", "DonGia", "ThanhTien" }
                    , new string[] { "Chọn", "Mã giảng viên", "Họ và tên", "Quốc tịch", "Bộ môn", "Học hàm", "Học vị"
                , "Loại giảng viên", "Mã lớp học phần", "Mã môn học", "Tên môn học", "Loại", "Nhóm", "Mã lớp", "Sĩ số", "Số tiết", "Hệ số lớp đông", "Hệ số ngoài giờ"
                , "Hệ số CLC thêm", "Hệ số CLC", "Tiết quy đổi", "Hệ số chức danh", "Đơn giá", "Thành tiền" }
                    , new int[] { 80, 90, 140, 100, 120, 80, 80, 100, 80, 80, 150, 60, 70, 80, 70, 70, 90, 90, 90, 90, 90, 90, 90, 90 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "ChonIn", "MaQuanLy", "HoTen", "TenQuocTich", "TenDonVi", "TenHocHam", "TenHocVi"
                , "TenLoaiGiangVien", "MaLopHocPhan", "MaMonHoc", "TenMonHoc", "Loai", "Nhom", "MaLop", "SiSo", "SoTiet", "HeSoLopDong", "HeSoNgoaiGio"
                , "HeSoClcThem", "HeSoClc", "TietQuyDoi", "HeSoChucDanhChuyenMon", "DonGia", "ThanhTien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewThongKe, new string[] { "TietQuyDoi", "ThanhTien" }, "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.ReadOnlyColumn(gridViewThongKe, new string[] { "MaQuanLy", "HoTen", "TenQuocTich", "TenDonVi", "TenHocHam", "TenHocVi"
                , "TenLoaiGiangVien", "MaLopHocPhan", "MaMonHoc", "TenMonHoc", "Loai", "Nhom", "MaLop", "SiSo", "SoTiet", "HeSoLopDong", "HeSoNgoaiGio"
                , "HeSoClcThem", "HeSoClc", "TietQuyDoi", "HeSoChucDanhChuyenMon", "DonGia", "ThanhTien" });
            AppGridView.FormatDataField(gridViewThongKe
                , new string[] { "SiSo", "DonGia", "ThanhTien" }
                , DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe
                , new string[] { "SoTiet", "HeSoLopDong", "HeSoNgoaiGio", "HeSoClcThem", "HeSoClc", "TietQuyDoi" }
                , DevExpress.Utils.FormatType.Custom, "n2");
            //gridViewThongKe.Columns["TenDonVi"].GroupIndex = 0;
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

            #region _lanChot
            AppGridLookupEdit.InitGridLookUp(cboLanChot, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLanChot, new string[] { "LanChot" }, new string[] { "Lần chốt" });
            cboLanChot.Properties.ValueMember = "LanChot";
            cboLanChot.Properties.DisplayMember = "LanChot";
            cboLanChot.Properties.NullText = string.Empty;
            #endregion

            #region Khoa-DonVi
            InitKhoaDonVi();
            #endregion

            #region LoaiGiangVien
            InitLoaiGiangVien();
            #endregion

            InitData();
        }

        #region InitData()
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            InitLanChot();
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDonVi.EditValue != null && cboLoaiGiangVien.EditValue != null && cboLanChot.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.ViewKetQuaThanhToanThuLao.GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot2(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), cboLanChot.EditValue.ToString());
                dt.Load(reader);
                dt.Columns["ChonIn"].ReadOnly = false;
                bindingSourceThongKe.DataSource = dt;
            }
            gridViewThongKe.ExpandAllGroups();
        }

        void InitLanChot()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                cboLanChot.DataBindings.Clear();
                DataServices.KetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref lanchot);
                DataTable tblLanChot = new DataTable();
                tblLanChot.Columns.Add("LanChot");
                if (lanchot > 0)
                {
                    for (int i = lanchot; i >= 1; i--)
                    {
                        tblLanChot.Rows.Add(new string[] { i.ToString() });
                    }
                }
                bindingSourceLanChot.DataSource = tblLanChot;
                cboLanChot.DataBindings.Add("EditValue", bindingSourceLanChot, "LanChot", true, DataSourceUpdateMode.Never);
            }
        }

        void InitKhoaDonVi()
        {
            cboDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboDonVi.Properties.Items.Clear();
            VList<ViewKhoa> _listKhoa = DataServices.ViewKhoa.GetAll();
            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoa v in _listKhoa)
            {
                _list.Add(new CheckedListBoxItem(v.MaKhoa, string.Format("{0} - {1}", v.MaKhoa, v.TenKhoa), CheckState.Unchecked, true));
            }
            cboDonVi.Properties.Items.AddRange(_list.ToArray());
            cboDonVi.Properties.SeparatorChar = ';';
            cboDonVi.CheckAll();
        }

        void InitLoaiGiangVien()
        {
            cboLoaiGiangVien.Properties.SelectAllItemCaption = "Tất cả";
            cboLoaiGiangVien.Properties.TextEditStyle = TextEditStyles.Standard;
            cboLoaiGiangVien.Properties.Items.Clear();
            TList<LoaiGiangVien> _listLoaiGiangVien = DataServices.LoaiGiangVien.GetAll();
            List<CheckedListBoxItem> _listLoaiGV = new List<CheckedListBoxItem>();
            foreach (LoaiGiangVien l in _listLoaiGiangVien)
            {
                _listLoaiGV.Add(new CheckedListBoxItem(l.MaLoaiGiangVien, string.Format("{0}", l.TenLoaiGiangVien), CheckState.Unchecked, true));
            }
            cboLoaiGiangVien.Properties.Items.AddRange(_listLoaiGV.ToArray());
            cboLoaiGiangVien.Properties.SeparatorChar = ';';
            cboLoaiGiangVien.CheckAll();
        }
        #endregion

        #region Event Button
        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDonVi.EditValue != null && cboLoaiGiangVien.EditValue != null && cboLanChot.EditValue != null)
                {
                    DataTable dt = new DataTable();
                    IDataReader reader = DataServices.ViewKetQuaThanhToanThuLao.GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot2(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), cboLanChot.EditValue.ToString());
                    dt.Load(reader);
                    dt.Columns["ChonIn"].ReadOnly = false;
                    bindingSourceThongKe.DataSource = dt;
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng chọn đủ điều kiện :)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Cursor.Current = Cursors.WaitCursor;
            }
            catch (Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
            }
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            InitLanChot();
            InitLoaiGiangVien();
            InitKhoaDonVi();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewThongKe.FocusedRowHandle = -1;
            bindingSourceThongKe.EndEdit();
            DataTable data = bindingSourceThongKe.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThongKe, data.Select("ChonIn = true").CopyToDataTable());

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InTongHopThanhToanThuLaoTheoKhoa (PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()
                        , cboLoaiGiangVien.Text, cboLanChot.EditValue.ToString(), PMS.Common.Globals._cauhinh.NguoiLapbieu
                        , PMS.Common.Globals._cauhinh.PhongDaoTao, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnInMau2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewThongKe.FocusedRowHandle = -1;
            bindingSourceThongKe.EndEdit();
            DataTable data = bindingSourceThongKe.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThongKe, data.Select("ChonIn = true").CopyToDataTable());

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InTongHopThanhToanThuLaoTheoKhoaMau2(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()
                        , cboLoaiGiangVien.Text, cboLanChot.EditValue.ToString(), PMS.Common.Globals._cauhinh.NguoiLapbieu
                        , PMS.Common.Globals._cauhinh.PhongDaoTao, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitLanChot();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            Cursor.Current = Cursors.WaitCursor;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitLanChot();
            Cursor.Current = Cursors.WaitCursor;
        }
        #endregion

        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void chk_ChonInTatCa_CheckedChanged(object sender, EventArgs e)
        {
            Common.XuLyGiaoDien.CheckAll(gridViewThongKe, "ChonIn", chk_ChonInTatCa.Checked);
        }
    }
}
