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
using PMS.Services;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThongKeTongHopThanhToanThuLao : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int lanchot = 0;
        #endregion

        public ucThongKeTongHopThanhToanThuLao()
        {
            InitializeComponent();
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

        private void ucThongKeTongHopThanhToanThuLao_Load(object sender, EventArgs e)
        {
            #region Init GirdView cu
            //AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            //AppGridView.ShowField(gridViewThongKe, new string[] { "_namHoc", "_hocKy", "MaQuanLy", "Ho", "Ten", "SoHieuCongChuc", "MaKhoa", "TenKhoa", "MaBoMon", "TenBoMon", "TenLoaiGiangVien", "MaHocHam", "TenHocHam", "MaHocVi", "TenHocVi", "LopClc", "SoTietNghiaVu", "TietGioiHan", "TongTietQuyDoi", "TongTietGiangDay", "TietDoAn", "TietDu", "TietThieu", "DonGia", "TongTien", "ThueThnh", "TienGiangDay", "TienDoAn", "TienDu", "TamUng", "ThucLanh", "TienThieu", "CoHopDongThinhGiangThinhGiang", "TienNghiaVu", "TienGioHan", "TietThucLanhClc", "TienThucLanhClc", "TietDuClc", "TienVuotClc", "TietThucLanhDaiTra", "TienThucLanhDaiTra", "TietDuDaiTra", "TienVuotDaiTra" }
            //        , new string[] { "Năm học", "Học kỳ", "Mã giảng viên", "Họ", "Tên", "Mã công chức", "Mã khoa", "Tên khoa", "Mã bộ môn", "Tên bộ môn", "Loại giảng viên", "Mã HH", "Tên học hàm", "Mã HV", "Tên học vị", "Lớp CLC", "Tiết nghĩa vụ", "Tiết giới hạn", "Tổng tiết quy đổi", "Tiết giảng dạy", "Tiết ĐA-LA", "Tiết vượt", "Tiết thiếu", "Đơn giá", "Tổng tiền", "Thuế THNH", "Tiền giảng dạy", "Tiền ĐA-LA", "Tiền vượt", "Tạm ứng", "Tổng thực lãnh", "Tiền thiếu", "Có hợp đồng", "Tiền nghĩa vụ", "tiền giới hạn", "Tiết thực lãnh CLC", "Tiền thực lãnh CLC", "Tiết vượt CLC", "Tiền vượt CLC", "Tiết thực lãnh đại trà", "Tiền thực lãnh đại trà", "Tiết vượt đại trà", "Tiền vượt đại trà" }
            //        , new int[] { 60, 60, 85, 110, 45, 80, 60, 120, 70, 120, 100, 50, 90, 50, 80, 65, 85, 75, 100, 100, 75, 55, 60, 65, 95, 80, 90, 80, 75, 65, 80, 80, 80, 100, 90, 110, 110, 90, 90, 110, 110, 100, 100 });
            //AppGridView.AlignHeader(gridViewThongKe, new string[] { "_namHoc", "_hocKy", "MaQuanLy", "Ho", "Ten", "SoHieuCongChuc", "MaKhoa", "TenKhoa", "MaBoMon", "TenBoMon", "TenLoaiGiangVien", "MaHocHam", "TenHocHam", "MaHocVi", "TenHocVi", "LopClc", "SoTietNghiaVu", "TietGioiHan", "TongTietQuyDoi", "TongTietGiangDay", "TietDoAn", "TietDu", "TietThieu", "DonGia", "TongTien", "ThueThnh", "TienGiangDay", "TienDoAn", "TienDu", "TamUng", "ThucLanh", "TienThieu", "CoHopDongThinhGiangThinhGiang", "TienNghiaVu", "TienGioHan", "TietThucLanhClc", "TienThucLanhClc", "TietDuClc", "TienVuotClc", "TietThucLanhDaiTra", "TienThucLanhDaiTra", "TietDuDaiTra", "TienVuotDaiTra" }, DevExpress.Utils.HorzAlignment.Center);
            //AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            //AppGridView.FormatDataField(gridViewThongKe, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            //AppGridView.FormatDataField(gridViewThongKe, "TongTien", DevExpress.Utils.FormatType.Custom, "n0");
            //AppGridView.FormatDataField(gridViewThongKe, "TienGiangDay", DevExpress.Utils.FormatType.Custom, "n0");
            //AppGridView.FormatDataField(gridViewThongKe, "TienDoAn", DevExpress.Utils.FormatType.Custom, "n0");
            //AppGridView.FormatDataField(gridViewThongKe, "TienDu", DevExpress.Utils.FormatType.Custom, "n0");
            //AppGridView.FormatDataField(gridViewThongKe, "ThucLanh", DevExpress.Utils.FormatType.Custom, "n0");
            //AppGridView.FormatDataField(gridViewThongKe, "TienThieu", DevExpress.Utils.FormatType.Custom, "n0");

            //AppGridView.FormatDataField(gridViewThongKe, "TienNghiaVu", DevExpress.Utils.FormatType.Custom, "n0");
            //AppGridView.FormatDataField(gridViewThongKe, "TienGioHan", DevExpress.Utils.FormatType.Custom, "n0");
            //AppGridView.FormatDataField(gridViewThongKe, "TienThucLanhClc", DevExpress.Utils.FormatType.Custom, "n0");
            //AppGridView.FormatDataField(gridViewThongKe, "TienVuotClc", DevExpress.Utils.FormatType.Custom, "n0");
            //AppGridView.FormatDataField(gridViewThongKe, "TienThucLanhDaiTra", DevExpress.Utils.FormatType.Custom, "n0");
            //AppGridView.FormatDataField(gridViewThongKe, "TienVuotDaiTra", DevExpress.Utils.FormatType.Custom, "n0");
            //AppGridView.ReadOnlyColumn(gridViewThongKe);
            #endregion

            #region Init GridView
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "MaQuanLy", "Ho", "Ten", "SoHieuCongChuc", "TenKhoa", "TenBoMon", "TenLoaiGiangVien", "TenLoaiNhanVien",
                    "TenHocHam", "TenHocVi", "TietGiangDayDaiTra", "TietGiangDayClc", "TietGiangDayClcNgoaiNgu", "TietDeAnLuanAnDaiTra", "TietDeAnLuanAnClc", "TietQuyDoiDaiTra", "TietQuyDoiClc", "TietQuyDoiClcNgoaiNgu",
                    "DonGiaDaiTra", "DonGiaClc", "DonGiaClcNgoaiNgu", "DonGiaDoAnClc", "ThanhTienDaiTra", "ThanhTienClc", "SoTietNghiaVu", "ThanhTienNghiaVu", "ThanhTienConThieu", "TietCanTren", "TietVuotCanTren", "ThucLanhChuaChan",
                    "ThanhTienVuot", "ThucLanhSauChan", "CoHopDongThinhGiang", "SoTaiKhoan", "TenNganHang", "MaSoThue" }
                , new string[] { "Mã giảng viên", "Họ", "Tên", "Mã công chức", "Khoa", "Bộ môn", "Loại giảng viên", "Loại nhân viên",
                    "Học hàm", "Học vị", "Tiết giảng dạy đại trà", "Tiết giảng dạy CLC tiếng Việt", "Tiết giảng dạy CLC tiếng Anh", "Tiết ĐA-LA đại trà", "Tiết ĐA-LA CLC", "Tổng tiết quy đổi đại trà", "Tổng tiết quy đổi CLC tiếng Việt", "Tổng tiết quy đổi CLC tiếng Anh",
                    "Đơn giá đại trà", "Đơn giá CLC tiếng Việt", "Đơn giá CLC tiếng Anh", "Đơn giá đồ án CLC", "Tổng thành tiền đại trà", "Tổng thành tiền CLC", "Tiết nghĩa vụ", "Thành tiền nghĩa vụ", "Thành tiền còn thiếu", "Tiết giới hạn", "Tiết vượt giới hạn", "Thực lãnh chưa chặn",
                    "Thành tiền vượt", "Thực lãnh sau chặn", "Có hợp đồng", "Số tài khoản", "Tên ngân hàng", "Mã số thuế" }
                , new int[] { 50, 100, 50, 80, 180, 180, 100, 100, 100, 100, 80, 80, 80, 80, 80, 80, 80, 80, 80,
                    80, 80, 100, 100, 100, 80, 100, 90, 80, 80, 100, 100, 100, 60, 70, 150, 70 });

            AppGridView.AlignHeader(gridViewThongKe, new string[] { "MaQuanLy", "Ho", "Ten", "SoHieuCongChuc", "TenKhoa", "TenBoMon", "TenLoaiGiangVien", "TenLoaiNhanVien",
                    "TenHocHam", "TenHocVi", "CoHopDongThinhGiang", "SoTaiKhoan", "TenNganHang", "MaSoThue" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.BackColorFieldAppearance(gridViewThongKe, new string[] { "TietGiangDayDaiTra", "TietDeAnLuanAnDaiTra", "TietQuyDoiDaiTra", "DonGiaDaiTra", "ThanhTienDaiTra" }, Color.FromArgb(0xF2, 0xFF, 0xDF));
            AppGridView.BackColorFieldAppearance(gridViewThongKe, new string[] { "TietGiangDayClc", "TietGiangDayClcNgoaiNgu", "TietDeAnLuanAnClc", "TietQuyDoiClc", "TietQuyDoiClcNgoaiNgu", "DonGiaClc", "DonGiaClcNgoaiNgu", "DonGiaDoAnClc", "ThanhTienClc" }, Color.FromArgb(0xF2, 0xE1, 0xFF));
            AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0} dòng", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewThongKe, new string[] { "TietGiangDayDaiTra", "TietGiangDayClc", "TietDeAnLuanAnDaiTra", "TietDeAnLuanAnClc", "TietQuyDoiDaiTra", "TietQuyDoiClc"
                , "SoTietNghiaVu", "TietCanTren", "TietVuotCanTren" }, DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewThongKe, new string[] { "DonGiaDaiTra", "DonGiaClc", "DonGiaDoAnClc", "ThanhTienDaiTra", "ThanhTienClc", "ThanhTienNghiaVu", "ThanhTienConThieu"
                , "ThucLanhChuaChan", "ThanhTienVuot", "ThucLanhSauChan" }, DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.ReadOnlyColumn(gridViewThongKe);

            PMS.Common.Globals.WordWrapHeader(gridViewThongKe, 45);
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

            #region _lanChot
            AppGridLookupEdit.InitGridLookUp(cboLanChot, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLanChot, new string[] { "LanChot" }, new string[] { "Lần chốt" });
            cboLanChot.Properties.ValueMember = "LanChot";
            cboLanChot.Properties.DisplayMember = "LanChot";
            cboLanChot.Properties.NullText = string.Empty;
            #endregion

            #region Init Khoa-DonVi
            cboDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboDonVi.Properties.Items.Clear();

            VList<ViewKhoa> _vListKhoaBoMon = new VList<ViewKhoa>();
            _vListKhoaBoMon = DataServices.ViewKhoa.GetAll();

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoa v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaKhoa, v.TenKhoa, CheckState.Unchecked, true));
            }
            cboDonVi.Properties.Items.AddRange(_list.ToArray());
            cboDonVi.Properties.SeparatorChar = ';';
            cboDonVi.CheckAll();
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
                _listLGV.Add(new CheckedListBoxItem(v.MaLoaiGiangVien.ToString(), v.TenLoaiGiangVien, CheckState.Unchecked, true));
            }
            cboLoaiGiangVien.Properties.Items.AddRange(_listLGV.ToArray());
            cboLoaiGiangVien.Properties.SeparatorChar = ';';
            cboLoaiGiangVien.CheckAll();
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
            if (cboNamHoc.EditValue != null && cboDonVi.EditValue != null)
            {
                if (cboLanChot.EditValue != null)
                {
                    DataTable dt = new DataTable();
                    IDataReader reader = DataServices.KetQuaThanhToanThuLao.TongHopKetQuaThanhToan(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()));
                    dt.Load(reader);
                    bindingSourceThongKe.DataSource = dt;
                }
                else
                {
                    XtraMessageBox.Show("Khối lượng chưa quy đổi hoặc chưa được chốt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
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

        #endregion

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboDonVi.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.TongHopKetQuaThanhToan(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()));
                dt.Load(reader);
                bindingSourceThongKe.DataSource = dt;
            }
            gridViewThongKe.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    sf.ShowDialog();
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

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitLanChot();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitLanChot();
            Cursor.Current = Cursors.Default;
        }

        private void btnInTheoBoMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewThongKe.FocusedRowHandle = -1;
            bindingSourceThongKe.EndEdit();
            DataTable data = bindingSourceThongKe.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;

            vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThongKe, bindingSourceThongKe);

            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewThongKe.SortedColumns)
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

            List<DataRow> rowDelete = new List<DataRow>();
            foreach (DataRow row in vListBaoCao.Rows)
            {
                if ((row["CoHopDongThinhGiangThinhGiang"].ToString() != "True" && row["MaLoaiGiangVien"].ToString() == "17" && decimal.Parse(PMS.Common.Globals.IsNull(row["TietDoAn"].ToString(), "decimal").ToString()) <= 0) || row["MaHocHam"].ToString() == "TSU")
                {
                    rowDelete.Add(row);
                }
            }
            foreach (DataRow row in rowDelete)
            {
                vListBaoCao.Rows.Remove(row);
            }
            vListBaoCao.AcceptChanges();
           

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InDanhSachThanhToanThuLaoTheoBoMon(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()
                        , PMS.Common.Globals._cauhinh.PhongToChucCanBo, PMS.Common.Globals._cauhinh.PhongDaoTao, PMS.Common.Globals._cauhinh.NguoiLapbieu
                        , vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewThongKe.FocusedRowHandle = -1;
            bindingSourceThongKe.EndEdit();
            DataTable data = bindingSourceThongKe.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;
            
            vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThongKe, bindingSourceThongKe);

            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewThongKe.SortedColumns)
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
                    frm.InDanhSachThanhToanThuLaoTheoKhoa(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()
                        , PMS.Common.Globals._cauhinh.PhongToChucCanBo, PMS.Common.Globals._cauhinh.PhongDaoTao, PMS.Common.Globals._cauhinh.NguoiLapbieu
                        , vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void gridControlThongKe_Click(object sender, EventArgs e)
        {

        }

        private void btnInKhongGomNhom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewThongKe.FocusedRowHandle = -1;
            bindingSourceThongKe.EndEdit();
            DataTable data = bindingSourceThongKe.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;

            vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThongKe, bindingSourceThongKe);

            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewThongKe.SortedColumns)
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

            List<DataRow> rowDelete = new List<DataRow>();
            foreach (DataRow row in vListBaoCao.Rows)
            {
                if ((row["CoHopDongThinhGiangThinhGiang"].ToString() != "True" && row["MaLoaiGiangVien"].ToString() == "17" && decimal.Parse(PMS.Common.Globals.IsNull(row["TietDoAn"].ToString(), "decimal").ToString()) <= 0) || row["MaHocHam"].ToString() == "TSU")
                {
                    rowDelete.Add(row);
                }
            }
            foreach (DataRow row in rowDelete)
            {
                vListBaoCao.Rows.Remove(row);
            }
            vListBaoCao.AcceptChanges();

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InDanhSachThanhToanThuLaoToanTruong(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()
                        , PMS.Common.Globals._cauhinh.PhongToChucCanBo, PMS.Common.Globals._cauhinh.PhongDaoTao, PMS.Common.Globals._cauhinh.NguoiLapbieu
                        , vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
