using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using PMS.UI.Forms.BaoCao;
using PMS.Entities.Validation;
using PMS.BLL;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmThongKeThanhTraGiangVien : DevExpress.XtraEditors.XtraForm
    {

        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;

        public frmThongKeThanhTraGiangVien()
        {
            InitializeComponent();                        
            _maTruong =PMS.Common.Globals.GetMaTruong( _cauHinhChung,"Mã trường");
            if (_maTruong == "IUH")
                btnLamTuoi.Caption = "Cập nhật mới";
        }

        private void frmThongKeThanhTraGiangVien_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "MaCanBoGiangDay", "HoTen", "Khoa", "MaHocPhan", "TenHocPhan", "SoTinChi", "LoaiHocPhan", "MaGocLopHocPhan", "MaLop", "SoTiet", "SoTietGhiNhan","NguoiCapNhat","NgayCapNhat" }
                , new string[] { "Mã CBGD", "Họ tên", "Đơn vị", "Mã học phần", "Tên học phần", "STC", "Loại học phần", "Mã lớp học phần", "Mã lớp", "Số tiết", "Số tiết thanh tra ghi nhận","Người cập nhật","Ngày cập nhật" }
                    , new int[] { 70, 140, 150, 80, 150, 50, 90, 110, 90, 50, 160,160,100 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "MaHocPhan", "TenHocPhan", "SoTinChi", "LoaiHocPhan", "MaGocLopHocPhan", "MaLop", "MaCanBoGiangDay", "HoTen", "Khoa", "SoTiet", "SoTietGhiNhan","NguoiCapNhat","NgayCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThongKe, "MaHocPhan", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewThongKe);
            #endregion
            InitData();
        }

        #region InitData
        void InitData()
        {
            dateEditTuNgay.DateTime = DateTime.Now;
            dateEditDenNgay.DateTime = DateTime.Now;
            if (dateEditTuNgay.EditValue != null && dateEditDenNgay.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.ViewThanhTraTheoThoiKhoaBieu.SoSanhTienDo(dateEditTuNgay.DateTime.ToString("dd/MM/yyyy"), dateEditDenNgay.DateTime.ToString("dd/MM/yyyy"));
                tbl.Load(reader);
                bindingSourceThongKe.DataSource = tbl;
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
            Cursor.Current = Cursors.WaitCursor;
            if (dateEditTuNgay.EditValue != null && dateEditDenNgay.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.ViewThanhTraTheoThoiKhoaBieu.ThongKeTheoGiangVien(dateEditTuNgay.DateTime.ToString("dd/MM/yyyy"), dateEditDenNgay.DateTime.ToString("dd/MM/yyyy"));
                tbl.Load(reader);
                bindingSourceThongKe.DataSource = tbl;
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InThongKeThanhTraTheoGiangVien(PMS.Common.Globals._cauhinh.TenTruong, dateEditTuNgay.DateTime.ToString("dd/MM/yyyy"), dateEditDenNgay.DateTime.ToString("dd/MM/yyyy"), UserInfo.FullName, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog file = new SaveFileDialog())
            {
                file.Filter = "(*.xls)|*.xls";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    if (file.FileName != "")
                    {
                        gridControlThongKe.ExportToXls(file.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Bạn chưa nhập tên file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void gridViewThongKe_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            
        }

        
    }
}