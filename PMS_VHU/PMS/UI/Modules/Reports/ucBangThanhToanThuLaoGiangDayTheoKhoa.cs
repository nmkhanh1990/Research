using DevExpress.Common.Grid;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.Entities;
using PMS.Services;
using PMS.UI.Forms.BaoCao;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PMS.UI.Modules.Reports
{
    public partial class ucBangThanhToanThuLaoGiangDayTheoKhoa : XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int lanchot = 0;
        DateTime _ngayIn;
        VList<ViewKhoaBoMon> _listKhoaBoMon;
        string strMaTruong = string.Empty;
        string strTenTruong = string.Empty;
        string groupname = UserInfo.GroupName;
        string PQTheoKhoa = UserInfo.PQTheoKhoa;
        #endregion

        public ucBangThanhToanThuLaoGiangDayTheoKhoa()
        {
            InitializeComponent();
            strMaTruong = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Mã trường");
            strTenTruong = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Tên trường");
        }

        private void ucBangThanhToanThuLaoGiangDayTheoKhoa_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewBangThanhToan, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            //AppGridView.ShowEditor(gridViewBangThanhToan, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewBangThanhToan
                , new string[] { "MaQuanLy", "HoTen", "TenQuocTich", "TenLoaiGiangVien", "TenKhoaHoc", "TenBacDaoTao", "LoaiHinhDaoTao", "KhoaBacLoaiHinh", "TenMonHoc", "MaLop", "SoTinChi", "SoTiet", "SoLuongSv", "DonGia", "ThanhTien", "ThueTncn", "ThucNhan", "MaSoThue", "SoTaiKhoan", "TenNganHang", "DaChiTra", "Id", "NgayChiTra", "ChonIn" }
                , new string[] { "Mã giảng viên", "Họ tên giảng viên", "Quốc tịch", "Loại giảng viên", "Khóa học", "Bậc đào tạo", "Loại hình đào tạo", "-", "Tên môn học", "Mã lớp", "Số tín chỉ", "Số tiết", "Sĩ số", "Đơn giá", "Thành tiền", "Thuế TNCN 10%", "Thực nhận", "Mã số thuế", "Số tài khoản", "Ngân hàng - chi nhánh", "Đã chi trả", "Id", "Ngày chi trả", "Chọn in" }
                , new int[] { 70, 130, 100, 90, 100, 80, 90, 100, 120, 170, 80, 80, 80, 100, 100, 100, 100, 110, 120, 330, 90, 99, 99, 80 });
            AppGridView.AlignHeader(gridViewBangThanhToan, new string[] { "MaQuanLy", "HoTen", "TenQuocTich", "TenLoaiGiangVien", "TenKhoaHoc", "TenBacDaoTao", "LoaiHinhDaoTao", "KhoaBacLoaiHinh", "TenMonHoc", "MaLop", "SoTinChi", "SoTiet", "SoLuongSv", "DonGia", "ThanhTien", "ThueTncn", "ThucNhan", "MaSoThue", "SoTaiKhoan", "TenNganHang", "DaChiTra", "ChonIn" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewBangThanhToan, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewBangThanhToan, "SoTinChi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewBangThanhToan, "SoTiet", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewBangThanhToan, "SoLuongSv", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewBangThanhToan, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewBangThanhToan, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewBangThanhToan, "ThueTncn", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewBangThanhToan, "ThucNhan", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.ReadOnlyColumn(gridViewBangThanhToan, new string[] { "MaQuanLy", "HoTen", "TenLoaiGiangVien", "TenKhoaHoc", "TenBacDaoTao", "LoaiHinhDaoTao", "KhoaBacLoaiHinh", "TenMonHoc", "MaLop", "SoTinChi", "SoTiet", "SoLuongSv", "DonGia", "ThanhTien", "ThueTncn", "ThucNhan", "MaSoThue", "SoTaiKhoan", "TenNganHang" });
            AppGridView.HideField(gridViewBangThanhToan, new string[] { "Id", "NgayChiTra", "TenKhoaHoc", "TenBacDaoTao", "LoaiHinhDaoTao", "KhoaBacLoaiHinh", "TenMonHoc", "MaLop", "SoTinChi", "SoLuongSv" });
            //gridViewBangThanhToan.Columns["KhoaBacLoaiHinh"].GroupIndex = 0;
            gridViewBangThanhToan.GroupPanelText = PMS.Common.ThongBao.Str_GomNhom;
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Năm học hiện tại");
            #endregion

            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Học kỳ hiện tại");
            #endregion

            #region _lanChot
            AppGridLookupEdit.InitGridLookUp(cboLanChot, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLanChot, new string[] { "LanChot" }, new string[] { "Lần chốt" });
            cboLanChot.Properties.ValueMember = "LanChot";
            cboLanChot.Properties.DisplayMember = "LanChot";
            cboLanChot.Properties.NullText = string.Empty;
            #endregion

            #region Init Khoa-DonVi
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaKhoa", "TenKhoa" }, new string[] { "Mã khoa", "Tên khoa" });
            cboKhoaDonVi.Properties.ValueMember = "MaKhoa";
            cboKhoaDonVi.Properties.DisplayMember = "TenKhoa";
            cboKhoaDonVi.Properties.NullText = string.Empty;
            #endregion           

            InitData();
        }

        #region InitData()
        void InitData()
        {
            InitDonVi();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            InitLanChot();
            #region LoaiGiangVien
            cboLoaiGiangVien.Properties.SelectAllItemCaption = "Tất cả";
            cboLoaiGiangVien.Properties.TextEditStyle = TextEditStyles.Standard;
            cboLoaiGiangVien.Properties.Items.Clear();

            TList<LoaiGiangVien> _tListLoaiGiangVien = DataServices.LoaiGiangVien.GetAll();

            List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();

            foreach (LoaiGiangVien l in _tListLoaiGiangVien)
                list.Add(new CheckedListBoxItem(l.MaLoaiGiangVien, string.Format("{0} - {1}", l.MaQuanLy, l.TenLoaiGiangVien), CheckState.Unchecked, true));
            cboLoaiGiangVien.Properties.Items.AddRange(list.ToArray());
            cboLoaiGiangVien.Properties.SeparatorChar = ';';
            cboLoaiGiangVien.CheckAll();
            #endregion
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

        void InitDonVi()
        {
            //int icountKhoa = 0;
            VList<ViewKhoa> _listKhoa = DataServices.ViewKhoa.GetAll(); //DataServices.ViewKhoaBoMon.GetAll();
            //if (groupname != "Administrator")
            //{
            //    if (PQTheoKhoa == string.Empty)
            //        _listKhoaBoMon = _listKhoaBoMon.FindAll(p => p.MaKhoa == groupname) as VList<ViewKhoaBoMon>;
            //    else
            //    {
            //        _listKhoaBoMon = DataServices.ViewKhoaBoMon.GetByMaKhoa(PQTheoKhoa);
            //        icountKhoa = PQTheoKhoa.Split(';').Length;//check xem tài khoản này có được xem hết tất cả khoa hok
            //    }
            //}
            //if (icountKhoa == _listKhoaBoMon.Count || groupname == "Administrator")
            _listKhoa.Insert(0, new ViewKhoa() { ThuTu = -1, MaKhoa = "-1", TenKhoa = "[Tất cả]" });

            cboKhoaDonVi.DataBindings.Clear();
            bindingSourceKhoaDonVi.DataSource = _listKhoa;
        }

        #endregion


        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                gridViewBangThanhToan.FocusedRowHandle = -1;
                bindingSourceBangThanhToan.EndEdit();

                DataTable vListBaoCao = bindingSourceBangThanhToan.DataSource as DataTable;
                vListBaoCao = vListBaoCao.Select("ChonIn=True").CopyToDataTable();// PMS.Common.XuLyGiaoDien.LayDuLieuIn(gridViewBangThanhToan, bindingSourceBangThanhToan);
                if (gridViewBangThanhToan.RowCount == 0)
                {
                    PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_ThongBaoDuLieu, MessageBoxIcon.Warning, true);
                    return;
                }
                using (frmChonNgay frmChon = new frmChonNgay())
                {
                    frmChon.ShowDialog();
                    _ngayIn = frmChon.NgayIn;
                }
                string sort = "";
                if (vListBaoCao != null)
                {
                    if (vListBaoCao.Rows.Count != 0)
                    {
                        foreach (GridColumn c in gridViewBangThanhToan.SortedColumns)
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
                    INBaoCao(vListBaoCao);
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("row"))
                {
                    PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ChonIn, MessageBoxIcon.Warning, true);
                }
            }
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
                        gridControlBangThanhToan.ExportToXls(sf.FileName);
                        PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_XuatFile, MessageBoxIcon.Information, true);
                    }
                }
            }
            catch
            { }
        }

        private void gridLookUpEditNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            InitLanChot();
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboLanChot.EditValue == null)
                {
                    PMS.Common.XuLyGiaoDien.ThongBao("Thông báo", PMS.Common.ThongBao.Str_KiemTraChot + cboNamHoc.EditValue.ToString(), MessageBoxIcon.Warning, true);
                    return;
                }
                Cursor.Current = Cursors.WaitCursor;
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null && cboLoaiGiangVien.EditValue != null)
                {
                    DataTable dt = new DataTable();
                    IDataReader reader = DataServices.KetQuaThanhToanThuLao.ThanhToanThuLaoGiangDayTheoKhoa(cboKhoaDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()));
                    dt.Load(reader);
                    dt.Columns["DaChiTra"].ReadOnly = false;
                    dt.Columns["ChonIn"].ReadOnly = false;
                    bindingSourceBangThanhToan.DataSource = dt;
                }
                gridViewBangThanhToan.ExpandAllGroups();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
            }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitLanChot();
            Cursor.Current = Cursors.Default;
        }

        private void checkEditChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            PMS.Common.XuLyGiaoDien.CheckAll(gridViewBangThanhToan, "DaChiTra", Convert.ToBoolean(checkEditChonTatCa.EditValue.ToString()));
        }

        private void btnLuuChiTra_Click(object sender, EventArgs e)
        {
            
        }

        private void gridViewBangThanhToan_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "DaChiTra")
            {
                gridViewBangThanhToan.SetRowCellValue(e.RowHandle, "NgayChiTra", DateTime.Now.ToString("dd/MM/yyyy"));
            }
        }

        private void checkEditChonIn_CheckedChanged(object sender, EventArgs e)
        {
            PMS.Common.XuLyGiaoDien.CheckAll(gridViewBangThanhToan, "ChonIn", Convert.ToBoolean(checkEditChonIn.EditValue.ToString()));
        }

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            if (cboKhoaDonVi.EditValue != null)
                cboKhoaDonVi.EditValue = cboKhoaDonVi.EditValue.ToString();
        }

        void INBaoCao(DataTable lsttbl)
        {
            using (frmBaoCao frm = new frmBaoCao())
            {

                DataTable tbl;
                IDataReader idr;
                string StrMaGiangVien = PMS.Common.XuLyChuoi.GetAllColumns(lsttbl, "MaQuanLy");
                tbl = new DataTable();
                idr = DataServices.KetQuaThanhToanThuLao.ThanhToanThuLaoGiangDayTheoKhoa(cboKhoaDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()));
                tbl.Load(idr);
                frm.InBangThanhToanThuLaoGiangDayTheoKhoa(strTenTruong, cboKhoaDonVi.Text.ToUpper(), cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()
                   , PMS.Common.Globals._cauhinh.PhongDaoTao, PMS.Common.Globals._cauhinh.NguoiLapbieu, _ngayIn
                   , lsttbl);
                frm.ShowDialog();

            }
        }

        private void rdb_Baocao_SelectedIndexChanged(object sender, EventArgs e)
        {
            PMS.Common.XuLyGiaoDien.SelectedIndexChanged(sender, e, btnIn);
        }

        private void btn_LuuChiTra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewBangThanhToan.FocusedRowHandle = -1;
            DataTable tbl = bindingSourceBangThanhToan.DataSource as DataTable;
            if (tbl != null)
            {
                if (XtraMessageBox.Show(PMS.Common.ThongBao.Str_LuuChiTraGIANGVIEN, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string xmlData = "", kt = "";
                        foreach (DataRow r in tbl.Rows)
                        {
                            if (r.RowState == DataRowState.Modified)
                            {
                                DataServices.KetQuaThanhToanThuLao.KiemTraDaChiTra(int.Parse(r["Id"].ToString()), ref kt);
                                if (kt != "")
                                {
                                    XtraMessageBox.Show(kt, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    btnLocDuLieu.PerformClick();
                                    return;
                                }
                                xmlData += "<Input Id=\"" + r["Id"].ToString()
                                        + "\" C=\"" + r["DaChiTra"].ToString()
                                        + "\" D=\"" + r["NgayChiTra"].ToString()
                                        + "\" />";
                            }
                        }
                        xmlData = "<Root>" + xmlData + "</Root>";

                        int kq = -1;
                        DataServices.KetQuaThanhToanThuLao.LuuGiangVienDaChiTra(xmlData, ref kq);

                        if (kq == 0)
                            PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_LuuThayDoiThanhCong, MessageBoxIcon.Information, true);
                        else
                            PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_LuuLoiXayRa, MessageBoxIcon.Error, true);
                        btnLocDuLieu.PerformClick();
                    }
                    catch
                    { PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_LuuLoiXayRa, MessageBoxIcon.Error, true); }
                }
            }
        }
    }
}
