using DevExpress.Common.Grid;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using PMS.BLL;
using PMS.Entities;
using PMS.Services;
using PMS.UI.Forms.BaoCao;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThongKeDuTruCaNamTruocThoiKhoaBieu : DevExpress.XtraEditors.XtraUserControl
    {

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        DateTime _ngayIn;
        string _maTruong;
        private string groupname = UserInfo.GroupName;
        private bool user = false;
        #endregion

        public ucThongKeDuTruCaNamTruocThoiKhoaBieu()
        {
            InitializeComponent();
        }

        private void ucThongKeDuTruCaNamTruocThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            #region Init GridView
            string[] arrShowFields = { "Stt", "MaQuanLy", "HoTen", "TenDonVi"
                    , "GioGiangHk01", "SoTietNghiaVuHk01", "GioVuotHk01"
                    , "GioGiangHk02", "SoTietNghiaVuHk02", "GioVuotHk02"
                    , "GioGiangHK03", "SoTietNghiaVuHk03", "GioVuotHk03"
                    , "GioGiangCaNam", "SoTietNghiaVuCaNam", "GioVuotCaNam", "TenChucVu" };
            string[] arrShowFieldNames = { "STT", "Mã giảng viên", "Họ tên", "Tên Bộ Môn"
                    , "Tổng giờ dạy HK01", "Định mức giờ chuẩn HK01", "Giờ vượt HK01"
                    , "Tổng giờ dạy HK02", "Định mức giờ chuẩn HK02", "Giờ vượt HK02"
                    , "Tổng giờ dạy HK03", "Định mức giờ chuẩn HK03", "Giờ vượt HK03"
                    , "Tổng giờ dạy cả năm", "Định mức giờ tiêu chuẩn cả năm", "Giờ vượt cả năm", "Ghi chú" };
            int[] arrShowFieldWidths = { 60, 90, 170, 150
                    , 80, 80, 80
                    , 80, 80, 80
                    , 80, 80, 80
                    , 80, 80, 80, 150 };
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
            AppGridView.ShowField(gridViewThongKe, arrShowFields, arrShowFieldNames, arrShowFieldWidths);
            AppGridView.ReadOnlyColumn(gridViewThongKe);
            AppGridView.AlignHeader(gridViewThongKe, arrShowFields, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewThongKe, arrShowFields, DevExpress.Utils.HorzAlignment.Center);
            gridViewThongKe.Columns["TenDonVi"].GroupIndex = 0;
            PMS.Common.Globals.WordWrapHeader(gridViewThongKe, 50);

            gridViewThongKe.Columns["GioVuotHk01"].AppearanceCell.Font = new Font(gridViewThongKe.Columns[4].AppearanceCell.Font.FontFamily, gridViewThongKe.Columns[4].AppearanceCell.Font.Size, FontStyle.Bold);
            gridViewThongKe.Columns["GioVuotHk02"].AppearanceCell.Font = new Font(gridViewThongKe.Columns[4].AppearanceCell.Font.FontFamily, gridViewThongKe.Columns[4].AppearanceCell.Font.Size, FontStyle.Bold);
            gridViewThongKe.Columns["GioVuotCaNam"].AppearanceCell.Font = new Font(gridViewThongKe.Columns[4].AppearanceCell.Font.FontFamily, gridViewThongKe.Columns[4].AppearanceCell.Font.Size, FontStyle.Bold);
            AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region LoaiGiangVien
            cboDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboDonVi.Properties.Items.Clear();

            VList<ViewKhoaBoMon> _vlistKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();

            List<CheckedListBoxItem> listKhoaBoMon = new List<CheckedListBoxItem>();

            foreach (ViewKhoaBoMon l in _vlistKhoaBoMon)
                listKhoaBoMon.Add(new CheckedListBoxItem(l.MaBoMon, string.Format("{0} - {1}", l.MaBoMon, l.TenBoMon), CheckState.Unchecked, true));
            cboDonVi.Properties.Items.AddRange(listKhoaBoMon.ToArray());
            cboDonVi.Properties.SeparatorChar = ';';
            cboDonVi.CheckAll();
            #endregion

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

            InitData();
        }

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboDonVi.EditValue != null && cboLoaiGiangVien.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.DuTruGioGiangTruocThoiKhoaBieu.ThongKeCaNamTheoGiangVien(cboNamHoc.EditValue.ToString(), cboDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString());
                tbl.Load(reader);
                bindingSourceThongKe.DataSource = tbl;
            }
            gridViewThongKe.ExpandAllGroups();
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
            
            vListBaoCao.AcceptChanges();

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {

                    frm.InThongKeDuTruCaNamCuaGiangVienTruocTKB(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString()
                          , PMS.Common.Globals._cauhinh.BanGiamHieu, PMS.Common.Globals._cauhinh.PhongDaoTao, _ngayIn, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
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
                            gridControlThongKe.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }
    }
}
