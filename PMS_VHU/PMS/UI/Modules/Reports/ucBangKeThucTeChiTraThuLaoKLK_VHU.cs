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
using PMS.UI.Forms.NghiepVu.FormXuLy;
using DevExpress.XtraGrid.Columns;

namespace PMS.UI.Modules.Reports
{
    public partial class ucBangKeThucTeChiTraThuLaoKLK_VHU : XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int lanchot = 0;
        DateTime _ngayIn;
        VList<ViewKhoaBoMon> _listKhoaBoMon;
        string strMaTruong = string.Empty;
        string strTenTruong = string.Empty;
        #endregion

        public ucBangKeThucTeChiTraThuLaoKLK_VHU()
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
            AppGridView.ShowField(gridViewBangThanhToan, new string[] { "MaQuanLy", "HoTen", "MonHoc", "SoTiet", "ThuLao", "ThanhTien", "Thue", "ThucNhan", "MaSoThue", "SoTaiKhoan", "NganHangChiNhanh", "GhiChu" }
                                                       , new string[] { "Mã giảng viên", "Họ tên giảng viên", "Môn học","Số tiết","Thù lào","Thành tiền", "Thuế TNCN 10%", "Thực nhận", "Mã số thuế", "Số tài khoản", "Ngân hàng - chi nhánh", "Ghi chú" }
                                                       , new int[] { 70, 130, 100, 90, 100, 80, 90, 100, 120, 100, 140, 100});
            AppGridView.AlignHeader(gridViewBangThanhToan, new string[] { "MaQuanLy", "HoTen", "MonHoc", "SoTiet", "ThuLao", "ThanhTien", "Thue", "ThucNhan", "MaSoThue", "SoTaiKhoan", "NganHangChiNhanh", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewBangThanhToan, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewBangThanhToan, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewBangThanhToan, "Thue", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewBangThanhToan, "ThucNhan", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.ReadOnlyColumn(gridViewBangThanhToan, new string[] { "MaQuanLy", "HoTen", "MonHoc", "SoTiet", "ThuLao", "ThanhTien", "Thue", "ThucNhan", "MaSoThue", "SoTaiKhoan", "NganHangChiNhanh", "GhiChu" });
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;            
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
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaBoMon", "TenBoMon" }, new string[] { "Mã khoa đơn vị", "Tên khoa đơn vị" });
            cboKhoaDonVi.Properties.ValueMember = "MaBoMon";
            cboKhoaDonVi.Properties.DisplayMember = "TenBoMon";
            cboKhoaDonVi.Properties.NullText = string.Empty;
            #endregion

            chekenablebutton();

            InitData();
        }

        #region InitData()
        void InitData()
        {
            _listKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            _listKhoaBoMon.Insert(0, new ViewKhoaBoMon() { ThuTu = -1, MaKhoa = "-1", TenKhoa = "[Tất cả]", MaBoMon = "-1", TenBoMon = "[Tất cả]" });
            cboKhoaDonVi.DataBindings.Clear();
            bindingSourceKhoaDonVi.DataSource = _listKhoaBoMon;
            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaBoMon", true, DataSourceUpdateMode.Never);
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            cboNamHoc.EditValue = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Năm học hiện tại");
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

        #endregion


        private void chekenablebutton()
        {
            if (strMaTruong == "VHU")
            {
                btnIn.Enabled = false;
                layoutControlILoaiBaocao.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                btnIn.Enabled = true;
                layoutControlILoaiBaocao.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }
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
                DataTable vListBaoCao = PMS.Common.XuLyGiaoDien.LayDuLieuIn(gridViewBangThanhToan, bindingSourceBangThanhToan);
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
                        foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewBangThanhToan.SortedColumns)
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
                    INBaoCao(rdb_Baocao.EditValue.ToString(), vListBaoCao);
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
                    IDataReader reader = DataServices.KetQuaThanhToanThuLao.BangChiTraThuLaoGiangDayKLK_VHU(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), cboLanChot.EditValue.ToString(),string.Empty);
                    dt.Load(reader);                   
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
               
        
        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            if (cboKhoaDonVi.EditValue != null)
                cboKhoaDonVi.EditValue = cboKhoaDonVi.EditValue.ToString();
        }

        void INBaoCao(string strChon, DataTable lsttbl)
        {
            using (frmBaoCao frm = new frmBaoCao())
            {

                DataTable tbl;
                IDataReader idr;
                string StrMaGiangVien = PMS.Common.XuLyChuoi.GetAllColumns(lsttbl, "MaQuanLy");
                switch (rdb_Baocao.EditValue.ToString())
                {
                    
                    case "Bangkethuctegiogiangklk":
                        tbl = new DataTable();
                        idr = DataServices.KetQuaThanhToanThuLao.BangKeThuTeGioGiangKLK_VHU(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(),cboLanChot.EditValue.ToString(), StrMaGiangVien);
                        tbl.Load(idr);
                        frm.InBangKeThucTeGioGiangKLK_VHU(strTenTruong, PMS.BLL.UserInfo.FullName, _ngayIn, tbl);
                        break;                   
                    default:
                        frm.InBangChiTraThuLaoGiangDayKLK_VHU(strTenTruong, PMS.BLL.UserInfo.FullName, _ngayIn, lsttbl);
                        break;
                }
                frm.ShowDialog();

            }
        }

        private void rdb_Baocao_SelectedIndexChanged(object sender, EventArgs e)
        {
            PMS.Common.XuLyGiaoDien.SelectedIndexChanged(sender, e, btnIn);
        }
       
    }
}
