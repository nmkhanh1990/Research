using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Services;
using PMS.BLL;
using System.Drawing;
using PMS.UI.Forms.BaoCao;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmKetQuaGiangDayTheoNam_Yersin : XtraForm
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        DateTime _ngayIn;
        string _maTruong;
        int iichekc = 0;
        int lanchot = 0;
        VList<ViewKhoaBoMon> _listKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
        string _groupName = UserInfo.GroupName;
        bool _userRole;
        int _currentSecond = 0;         //in second
        int _currentMilli = 0;          //in millisecond
        int _currentRow = 0;
        string strTenTruong = string.Empty;
        #endregion

        public frmKetQuaGiangDayTheoNam_Yersin()
        {
            InitializeComponent();
            _maTruong = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Mã trường");
            strTenTruong = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Tên trường");
        }

       
        private void frmKetQuaGiangDayTheoNam_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewKetQua, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, true);
            AppGridView.ShowField(gridViewKetQua, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien"
                , "DinhMucGiangDay", "DinhMucNckh", "DinhMucQuanLy", "DinhMucGiangDayGiam", "DinhMucNckhGiam", "DinhMucQuanLyGiam"
                , "TietNoGiangDayKyTruoc", "TietNoNckhKyTruoc", "TietNoQlKyTruoc"
                , "SumTietNghiaVuGiangDay", "SumTietNghiaVuNckh", "SumTietNghiaVuQuanLy", "TietGiangDayLtTh", "TietGiangDayKhac", "TongTietGiang"
                , "TietThucHienNckh", "TietThamGiaQuanLy", "TietVuotGiangDay", "TietThieuGiangDay", "TietVuotNckh", "TietThieuNckh", "TietVuotQuanLy", "TietThieuQuanLy"
                , "TietVuotGiangDayBaoLuu","TietVuotNckhBaoLuu","TietVuotQuanLyBaoLuu"
                , "DonGia", "HeSoChucDanhChuyenMon", "TongTietVuot", "TienVuot" }
                                                , new string[] { "Khoa - Bộ môn", "Mã giảng viên", "Họ Tên", "Học hàm", "Học vị", "Loại giảng viên"
                , "Định mức giảng dạy", "Định mức NCKH","Định mức khác", "Định mức giảm giảng dạy", "Định mức giảm NCKH", "Định mức giảm khác"
                , "GC giảng dạy nợ kỳ trước", "GC NCKH bảo lưu kỳ trước", "GC TGQL nợ kỳ trước"
                , "Tổng hợp định mức giảng dạy", "Tổng hợp định mức NCKH","Tổng hợp định mức khác", "GC thực hiện giảng LT-TH", "GC thực hiện giảng khác", "Tổng GC thực hiện giảng dạy"
                , "GC thực hiện NCKH","GC tham gia khác", "GC giảng dạy vượt/thiếu", "GC giảng dạy thiếu", "GC NCKH vượt/thiếu", "GC NCKH thiếu", "GC khác vượt/thiếu", "GC khác thiếu"
                , "Tiết vượt GD sau khi bù","Tiết vượt NCKH sau khi bù","Tiết vượt QL sau khi bù"
                , "Đơn giá", "Hệ số chức danh", "GC thanh toán", "Tiền vượt giờ" }
                                                , new int[] { 99, 90, 140, 100, 100, 100, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 100, 100, 100, 80, 80, 80, 100 });
            AppGridView.AlignHeader(gridViewKetQua, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien"
                , "SumTietNghiaVuGiangDay", "SumTietNghiaVuNckh", "SumTietNghiaVuQuanLy", "TietGiangDayLtTh", "TietGiangDayKhac", "TongTietGiang"
                , "TietThucHienNckh", "TietThamGiaQuanLy", "TietVuotGiangDay", "TietThieuGiangDay", "TietVuotNckh", "TietThieuNckh", "TietVuotQuanLy", "TietThieuQuanLy"
                , "TietVuotGiangDayBaoLuu","TietVuotNckhBaoLuu","TietVuotQuanLyBaoLuu"
                , "DonGia", "HeSoChucDanhChuyenMon", "TongTietVuot", "TienVuot" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKetQua, "MaQuanLy", "{0} GV", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKetQua, "TietGiangDayLtTh", "{0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKetQua, "TietGiangDayKhac", "{0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKetQua, "TongTietGiang", "{0:n2", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKetQua, "TietThucHienNckh", "{0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKetQua, "TietThamGiaQuanLy", "{0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKetQua, "TongTietVuot", "{0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKetQua, "TienVuot", "{0:n0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewKetQua, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKetQua, "TienVuot", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.BackColorFieldAppearance(gridViewKetQua, new string[] { "DinhMucGiangDay", "DinhMucGiangDayGiam", "SumTietNghiaVuGiangDay", "TongTietGiang", "TietVuotGiangDay", "TietThieuGiangDay" }, Color.FromArgb(235, 220, 255));
            AppGridView.BackColorFieldAppearance(gridViewKetQua, new string[] { "DinhMucNckh", "DinhMucNckhGiam", "SumTietNghiaVuNckh", "TietThucHienNckh", "TietVuotNckh", "TietThieuNckh" }, Color.FromArgb(230, 255, 245));
            AppGridView.BackColorFieldAppearance(gridViewKetQua, new string[] { "DinhMucQuanLy", "DinhMucQuanLyGiam", "SumTietNghiaVuQuanLy", "TietThamGiaQuanLy", "TietVuotQuanLy", "TietThieuQuanLy" }, Color.FromArgb(255, 250, 240));
            AppGridView.FixedField(gridViewKetQua, new string[] { "MaQuanLy", "HoTen" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            AppGridView.HideField(gridViewKetQua, new string[] { "DinhMucGiangDayGiam", "HeSoChucDanhChuyenMon", "TietVuotGiangDayBaoLuu", "TietVuotNckhBaoLuu", "TietVuotQuanLyBaoLuu", "TietNoGiangDayKyTruoc", "TietNoNckhKyTruoc", "TietNoQlKyTruoc", "DinhMucNckhGiam", "DinhMucQuanLyGiam", "TietThieuGiangDay", "TietThieuNckh", "TietThieuQuanLy" });
            //gridViewKetQua.Columns["TenDonVi"].GroupIndex = 0;
            #endregion

            Common.Globals.WordWrapHeader(gridViewKetQua, 40);

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region _lanChot HK01
            AppGridLookupEdit.InitGridLookUp(cboLanChotHK01, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLanChotHK01, new string[] { "LanChot" }, new string[] { "Lần chốt" });
            cboLanChotHK01.Properties.ValueMember = "LanChot";
            cboLanChotHK01.Properties.DisplayMember = "LanChot";
            cboLanChotHK01.Properties.NullText = string.Empty;
            #endregion

            #region _lanChot HK02
            AppGridLookupEdit.InitGridLookUp(cboLanChotHK02, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLanChotHK02, new string[] { "LanChot" }, new string[] { "Lần chốt" });
            cboLanChotHK02.Properties.ValueMember = "LanChot";
            cboLanChotHK02.Properties.DisplayMember = "LanChot";
            cboLanChotHK02.Properties.NullText = string.Empty;
            #endregion

            #region _lanChot HK03
            AppGridLookupEdit.InitGridLookUp(cboLanChotHK03, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLanChotHK03, new string[] { "LanChot" }, new string[] { "Lần chốt" });
            cboLanChotHK03.Properties.ValueMember = "LanChot";
            cboLanChotHK03.Properties.DisplayMember = "LanChot";
            cboLanChotHK03.Properties.NullText = string.Empty;
            #endregion

            //VisibleLayout(_maTruong);

            InitData();

            iichekc = PMS.Common.XuLyGiaoDien.CheckMaTruong(_maTruong, strTenTruong);//kiểm tra là trường nào            
        }

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();

            InitLanChotHK01();
            InitLanChotHK02();
            InitLanChotHK03();

            #region Init Khoa-DonVi
            VList<ViewKhoaBoMon> _vListKhoaBoMon = new VList<ViewKhoaBoMon>();
            foreach (ViewKhoaBoMon v in _listKhoaBoMon)
            {
                if (_groupName == v.MaBoMon)
                {
                    _userRole = true;
                    break;
                }
                else
                    _userRole = false;
            }

            if (_userRole)
            {
                _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetByMaBoMon(_groupName);
            }
            else
            {
                _vListKhoaBoMon = _listKhoaBoMon;
            }
            cboKhoaDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboKhoaDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboKhoaDonVi.Properties.Items.Clear();

            _vListKhoaBoMon.Sort("MaKhoa");
            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaBoMon, v.TenBoMon, CheckState.Unchecked, true));
            }

            cboKhoaDonVi.Properties.Items.AddRange(_list.ToArray());
            cboKhoaDonVi.Properties.SeparatorChar = ';';
            cboKhoaDonVi.CheckAll();
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
        }

        void InitLanChotHK01()
        {
            if (cboNamHoc.EditValue != null)
            {
                cboLanChotHK01.DataBindings.Clear();
                DataServices.KetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), "HK01", ref lanchot);
                DataTable tblLanChot = new DataTable();
                tblLanChot.Columns.Add("LanChot");
                if (lanchot > 0)
                {
                    for (int i = lanchot; i >= 1; i--)
                    {
                        tblLanChot.Rows.Add(new string[] { i.ToString() });
                    }
                }
                bindingSourceLanChotHK01.DataSource = tblLanChot;
                cboLanChotHK01.DataBindings.Add("EditValue", bindingSourceLanChotHK01, "LanChot", true, DataSourceUpdateMode.Never);
            }
        }

        void InitLanChotHK02()
        {
            if (cboNamHoc.EditValue != null)
            {
                cboLanChotHK02.DataBindings.Clear();
                DataServices.KetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), "HK02", ref lanchot);
                DataTable tblLanChot = new DataTable();
                tblLanChot.Columns.Add("LanChot");
                if (lanchot > 0)
                {
                    for (int i = lanchot; i >= 1; i--)
                    {
                        tblLanChot.Rows.Add(new string[] { i.ToString() });
                    }
                }
                bindingSourceLanChotHK02.DataSource = tblLanChot;
                cboLanChotHK02.DataBindings.Add("EditValue", bindingSourceLanChotHK02, "LanChot", true, DataSourceUpdateMode.Never);
            }
        }

        void InitLanChotHK03()
        {
            if (cboNamHoc.EditValue != null)
            {
                cboLanChotHK03.DataBindings.Clear();
                DataServices.KetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), "HK03", ref lanchot);
                DataTable tblLanChot = new DataTable();
                tblLanChot.Columns.Add("LanChot");
                if (lanchot > 0)
                {
                    for (int i = lanchot; i >= 1; i--)
                    {
                        tblLanChot.Rows.Add(new string[] { i.ToString() });
                    }
                }
                bindingSourceLanChotHK03.DataSource = tblLanChot;
                cboLanChotHK03.DataBindings.Add("EditValue", bindingSourceLanChotHK03, "LanChot", true, DataSourceUpdateMode.Never);
            }
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //int iichekc = PMS.Common.XuLyGiaoDien.CheckMaTruong(_maTruong, strTenTruong);
                if (iichekc == 0)
                {
                    if (cboLanChotHK01.EditValue == null)
                    {
                        PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ChonLanChot, MessageBoxIcon.Warning, true);
                        return;
                    }
                    else if (cboLanChotHK02.EditValue == null)
                    {
                        PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ChonLanChot, MessageBoxIcon.Warning, true);
                        return;
                    }
                    else if (cboLanChotHK03.EditValue == null)
                    {
                        PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ChonLanChot, MessageBoxIcon.Warning, true);
                        return;
                    }
                    else
                    {
                        if (cboNamHoc.EditValue != null && cboLanChotHK01.EditValue != null && cboLanChotHK02.EditValue != null && cboLanChotHK03.EditValue != null
                     && cboKhoaDonVi.EditValue != null && cboLoaiGiangVien.EditValue != null)
                        {
                            DataTable tb = new DataTable();
                            IDataReader reader = DataServices.KetQuaThanhToanThuLao.KetQuaGiangDayTheoNam(cboNamHoc.EditValue.ToString(),
                                int.Parse(cboLanChotHK01.EditValue.ToString()), int.Parse(cboLanChotHK02.EditValue.ToString()), int.Parse(cboLanChotHK03.EditValue.ToString())
                                , cboKhoaDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString());
                            tb.Load(reader);
                            bindingSourceKetQua.DataSource = tb;
                            gridViewKetQua.ExpandAllGroups();
                        }
                    }
                }
                else
                {
                    if (cboNamHoc.EditValue != null && cboLanChotHK01.EditValue != null// && cboLanChotHK02.EditValue != null && cboLanChotHK03.EditValue != null
                    && cboKhoaDonVi.EditValue != null && cboLoaiGiangVien.EditValue != null)
                    {
                        DataTable tb = new DataTable();
                        IDataReader reader = DataServices.KetQuaThanhToanThuLao.KetQuaGiangDayTheoNam(cboNamHoc.EditValue.ToString(),
                            int.Parse(cboLanChotHK01.EditValue.ToString()), 1, 2 //int.Parse(cboLanChotHK02.EditValue.ToString()), int.Parse(cboLanChotHK03.EditValue.ToString())
                            , cboKhoaDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString());
                        tb.Load(reader);
                        bindingSourceKetQua.DataSource = tb;
                        gridViewKetQua.ExpandAllGroups();
                    }
                }

                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
            }
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
                            gridControlKetQua.ExportToXls(sf.FileName);
                            PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_XuatFile, MessageBoxIcon.Information, true);
                        }
                }
            }
            catch (Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
            }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            InitLanChotHK01();
            InitLanChotHK02();
            InitLanChotHK03();
        }

        private void gridViewKetQua_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                DataRow dr = gridViewKetQua.GetDataRow(_currentRow);
                int second = DateTime.Now.Second;
                int millisecond = DateTime.Now.Millisecond;
                if (e.RowHandle == _currentRow && second == _currentSecond && millisecond - _currentMilli < 500)
                {
                    switch (e.Column.Caption)
                    {
                        case "Số GC giảng LT-TH":
                            new frmKetQuaGiangDayChiTiet("Khối lượng lý thuyết - thực hành", (string)dr["MaQuanLy"], (string)gridViewKetQua.GetDataRow(_currentRow)["HoTen"], cboNamHoc.EditValue.ToString(), cboLanChotHK01.EditValue.ToString(), cboLanChotHK02.EditValue.ToString(), cboLanChotHK03.EditValue.ToString()).ShowDialog();
                            break;
                        case "GC giảng khác":
                            new frmKetQuaGiangDayChiTiet("Khối lượng khác", (string)dr["MaQuanLy"], (string)gridViewKetQua.GetDataRow(_currentRow)["HoTen"], cboNamHoc.EditValue.ToString(), cboLanChotHK01.EditValue.ToString(), cboLanChotHK02.EditValue.ToString(), cboLanChotHK03.EditValue.ToString()).ShowDialog();
                            break;
                        case "Số GC thực hiện NCKH":
                            new frmKetQuaGiangDayChiTiet("Khối lượng nghiên cứu khoa học", (string)dr["MaQuanLy"], (string)gridViewKetQua.GetDataRow(_currentRow)["HoTen"], cboNamHoc.EditValue.ToString(), cboLanChotHK01.EditValue.ToString(), cboLanChotHK02.EditValue.ToString(), cboLanChotHK03.EditValue.ToString()).ShowDialog();
                            break;
                        case "Số GC tham gia HĐ quản lý":
                            new frmKetQuaGiangDayChiTiet("Khối lượng hoạt động quản lý", (string)dr["MaQuanLy"], (string)gridViewKetQua.GetDataRow(_currentRow)["HoTen"], cboNamHoc.EditValue.ToString(), cboLanChotHK01.EditValue.ToString(), cboLanChotHK02.EditValue.ToString(), cboLanChotHK03.EditValue.ToString()).ShowDialog();
                            break;
                    }
                }
                _currentRow = e.RowHandle;
                _currentSecond = second;
                _currentMilli = millisecond;
            }
            catch (Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
            }

        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                gridViewKetQua.FocusedRowHandle = -1;
                bindingSourceKetQua.EndEdit();
                DataTable data = bindingSourceKetQua.DataSource as DataTable;

                if (data == null)
                    return;
                DataTable vListBaoCao = data;

                vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewKetQua, bindingSourceKetQua);

                string sort = "";
                if (vListBaoCao != null)
                {
                    if (vListBaoCao.Rows.Count != 0)
                    {
                        foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewKetQua.SortedColumns)
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
                int dem = vListBaoCao.Rows.Count;

                vListBaoCao.AcceptChanges();

                if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
                {
                    using (frmBaoCao frm = new frmBaoCao())
                    {
                        frm.InKetQuaGiangDayTheoNam_VHU(Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), _ngayIn, vListBaoCao);
                        frm.ShowDialog();
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
            }

        }

        private void VisibleLayout(string strMaTruong)
        {
            if (strMaTruong == "HBU")
                layoutControlI_LoaiGiangVien.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            else
                layoutControlI_LoaiGiangVien.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }

        private void bar_btnLuuTietNo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                LuuTietNoKyHienTai();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        void LuuTietNoKyHienTai()
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewKetQua.FocusedRowHandle = -1;
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataTable list = bindingSourceKetQua.DataSource as DataTable;
                if (list != null)
                {
                    string xmlData = "";
                    foreach (DataRow kl in list.Rows)
                    {
                        xmlData += String.Format("<Input M=\"{0}\" GCBL=\"{1}\" NCKHBL=\"{2}\" QLBL=\"{3}\" NH=\"{4}\" NN=\"{5}\" NCN=\"{6}\" />"
                                , kl["MaGiangVien"]
                                , PMS.Common.Globals.IsNull(kl["TietVuotGiangDayBaoLuu"], "decimal")
                                , PMS.Common.Globals.IsNull(kl["TietVuotNckhBaoLuu"], "decimal")
                                , PMS.Common.Globals.IsNull(kl["TietVuotQuanLyBaoLuu"], "decimal")
                                , cboNamHoc.EditValue.ToString()
                                , DateTime.Today.ToString()
                                , UserInfo.UserName.ToString());

                    }
                    xmlData = "<Root>" + xmlData + "</Root>";
                    bindingSourceKetQua.EndEdit();
                    int kq = 0;
                    DataServices.TietNoKyTruoc.LuuSauKhiBaoLuu(xmlData, cboNamHoc.EditValue.ToString(), "HK01", ref kq);
                    if (kq == 0)
                        XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            InitData();
            Cursor.Current = Cursors.Default;
        }
    }
}