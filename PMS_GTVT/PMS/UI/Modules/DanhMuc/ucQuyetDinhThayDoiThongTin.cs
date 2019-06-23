using DevExpress.Common.Grid;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using PMS.Entities;
using PMS.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucQuyetDinhThayDoiThongTin : XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong, _cauHinhHeSoTheoNam;
        #endregion

        public ucQuyetDinhThayDoiThongTin()
        {
            InitializeComponent();
            try
            {
                _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
                _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
            }
            catch
            {
                XtraMessageBox.Show("Lỗi khi khởi tạo các giá trị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucChiTietTienCanTrenTheoNam_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewQuyetDinh, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewQuyetDinh, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewQuyetDinh, new string[] { "TenDonVi", "MaGiangVien", "HoTen"
                    , "MaChucVuCu", "MaChucVu", "MaHocHamCu", "MaHocHam", "MaHocViCu", "MaHocVi", "MaLoaiGiangVienCu", "MaLoaiGiangVien"
                    , "NgayBatDau", "NgayKetThuc", "GhiChu", "ThayDoi" },
                        new string[] {  "Đơn vị", "Mã", "Họ tên"
                    , "Mã CV cũ", "Chức vụ", "Mã HH cũ", "Học hàm", "Mã HV cũ", "Học vị", "Mã LGV cũ", "Loại giảng viên"
                    , "Ngày bắt đầu", "Ngày kết thúc", "Ghi chú", "Thay đổi" },
                        new int[] { 200, 80, 150, 80, 100, 80, 100, 80, 100, 80, 100, 90, 90, 200, 50 });
            AppGridView.HideField(gridViewQuyetDinh, new string[] { "ThayDoi" });
            AppGridView.AlignHeader(gridViewQuyetDinh, new string[] { "TenDonVi", "MaGiangVien", "HoTen", "MaChucVu"
                    , "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "NgayBatDau", "NgayKetThuc", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.BackColorFieldAppearance(gridViewQuyetDinh, new string[] { "MaChucVuCu", "MaHocHamCu", "MaHocViCu", "MaLoaiGiangVienCu" }, System.Drawing.Color.FromArgb(230,230,230));
            AppGridView.BackColorFieldAppearance(gridViewQuyetDinh, new string[] { "MaChucVu", "MaHocHam", "MaHocVi", "MaLoaiGiangVien" }, System.Drawing.Color.FromArgb(233,200,255));
            AppGridView.SummaryField(gridViewQuyetDinh, "HoTen", "{0} dòng", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewQuyetDinh, new string[] { "HoTen", "TenDonVi" });
            AppGridView.RegisterControlField(gridViewQuyetDinh, "MaGiangVien", rcboGiangVien);
            AppGridView.RegisterControlField(gridViewQuyetDinh, "MaChucVuCu", rcboChucVuCu);
            AppGridView.RegisterControlField(gridViewQuyetDinh, "MaHocHamCu", rcboHocHamCu);
            AppGridView.RegisterControlField(gridViewQuyetDinh, "MaHocViCu", rcboHocViCu);
            AppGridView.RegisterControlField(gridViewQuyetDinh, "MaLoaiGiangVienCu", rcboLoaiGiangVienCu);
            AppGridView.RegisterControlField(gridViewQuyetDinh, "MaChucVu", rcboChucVu);
            AppGridView.RegisterControlField(gridViewQuyetDinh, "MaHocHam", rcboHocHam);
            AppGridView.RegisterControlField(gridViewQuyetDinh, "MaHocVi", rcboHocVi);
            AppGridView.RegisterControlField(gridViewQuyetDinh, "MaLoaiGiangVien", rcboLoaiGiangVien);
            #endregion

            #region Giảng viên
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(rcboGiangVien, new string[] { "MaQuanLy", "HoTen", "TenDonVi" }
                , new string[] { "Mã", "Họ tên", "Trực thuộc" }, new int[] { 80, 120, 200 }, "MaGiangVien", "MaQuanLy", 410, 400);
            #endregion

            #region Học hàm
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(rcboHocHamCu, new string[] { "TenHocHam" }
                , new string[] { "Tên học hàm" }, new int[] { 120 }, "MaHocHam", "TenHocHam", 130, 300);
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(rcboHocHam, new string[] { "TenHocHam" }
                , new string[] { "Tên học hàm" }, new int[] { 120 }, "MaHocHam", "TenHocHam", 130, 300);
            #endregion

            #region Học vị
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(rcboHocViCu, new string[] { "TenHocVi" }
                , new string[] { "Tên học vị" }, new int[] { 120 }, "MaHocVi", "TenHocVi", 130, 300);
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(rcboHocVi, new string[] { "TenHocVi" }
                , new string[] { "Tên học vị" }, new int[] { 120 }, "MaHocVi", "TenHocVi", 130, 300);
            #endregion

            #region Loại giảng viên
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(rcboLoaiGiangVien, new string[] { "TenLoaiGiangVien" }
                , new string[] { "Tên loại GV" }, new int[] { 120 }, "MaLoaiGiangVien", "TenLoaiGiangVien", 130, 300);
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(rcboLoaiGiangVienCu, new string[] { "TenLoaiGiangVien" }
                , new string[] { "Tên loại GV" }, new int[] { 120 }, "MaLoaiGiangVien", "TenLoaiGiangVien", 130, 300);
            #endregion

            #region Chức vụ
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(rcboChucVuCu, new string[] { "TenChucVu" }
                , new string[] { "Tên chức vụ" }, new int[] { 120 }, "MaChucVu", "TenChucVu", 130, 300);
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(rcboChucVu, new string[] { "TenChucVu" }
                , new string[] { "Tên chức vụ" }, new int[] { 120 }, "MaChucVu", "TenChucVu", 130, 300);
            #endregion

            InitData();
        }

        #region InitData
        private void InitData()
        {
            bindingSourceGiangVien.DataSource = DataServices.ViewGiangVien.GetAll();
            bindingSourceHocHam.DataSource = DataServices.HocHam.GetAll();
            bindingSourceHocVi.DataSource = DataServices.HocVi.GetAll();
            bindingSourceLoaiGiangVien.DataSource = DataServices.LoaiGiangVien.GetAll();
            bindingSourceChucVu.DataSource = DataServices.ChucVu.GetAll();
            ckbTatCa.Checked = true;
            dtpTuNgay.EditValue = dtpDenNgay.EditValue = DateTime.Now;
            ReloadGridView();
        }

        private void ReloadGridView()
        {
            IDataReader reader = null;
            if (ckbTatCa.Checked)
            {
                reader = DataServices.GiangVien.GetQuyetDinh(null, null);
            }
            else if (dtpTuNgay.EditValue != null && dtpDenNgay.EditValue != null)
            {
                reader = DataServices.GiangVien.GetQuyetDinh((DateTime)dtpTuNgay.EditValue, (DateTime)dtpDenNgay.EditValue);
            }
            DataTable dt = new DataTable();
            dt.Load(reader);
            dt.Columns["MaGiangVien"].ReadOnly
                = dt.Columns["HoTen"].ReadOnly
                = dt.Columns["TenDonVi"].ReadOnly
                = dt.Columns["MaChucVuCu"].ReadOnly
                = dt.Columns["MaChucVu"].ReadOnly
                = dt.Columns["MaHocHamCu"].ReadOnly
                = dt.Columns["MaHocHam"].ReadOnly
                = dt.Columns["MaHocViCu"].ReadOnly
                = dt.Columns["MaHocVi"].ReadOnly
                = dt.Columns["MaLoaiGiangVienCu"].ReadOnly
                = dt.Columns["MaLoaiGiangVien"].ReadOnly
                = dt.Columns["NgayBatDau"].ReadOnly
                = dt.Columns["NgayKetThuc"].ReadOnly
                = dt.Columns["ThayDoi"].ReadOnly
                = false;
            bindingSourceQuyetDinh.DataSource = dt;
        }
        #endregion

        private void btnLamtuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ReloadGridView();
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    sf.ShowDialog();
                    if (sf.FileName != "")
                    {
                        gridControlQuyetDinh.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewQuyetDinh.FocusedRowHandle = -1;
            DataTable list = bindingSourceQuyetDinh.DataSource as DataTable;
            if (list != null)
            {
                try
                {
                    string xmlData = "";
                    foreach (DataRow row in list.Rows)
                    {
                        if ((bool)row["ThayDoi"])
                        {
                            xmlData += String.Format(
                                "<Input MGV=\"{0}\" CVC=\"{1}\" CV=\"{2}\" HHC=\"{3}\" HH=\"{4}\" HVC=\"{5}\" HV=\"{6}\" "
                                 + "LGVC=\"{7}\" LGV=\"{8}\" BD=\"{9}\" KT=\"{10}\"/> "
                                    , row["MaGiangVien"]
                                    , row["MaChucVuCu"]
                                    , row["MaChucVu"]
                                    , row["MaHocHamCu"]
                                    , row["MaHocHam"]
                                    , row["MaHocViCu"]
                                    , row["MaHocVi"]
                                    , row["MaLoaiGiangVienCu"]
                                    , row["MaLoaiGiangVien"]
                                    , row["NgayBatDau"].ToString() == "" ? new DateTime(1990, 06, 21).ToString("yyyy-MM-dd") : ((DateTime)row["NgayBatDau"]).ToString("yyyy-MM-dd")
                                    , row["NgayKetThuc"].ToString() == "" ? new DateTime(1990, 06, 21).ToString("yyyy-MM-dd") : ((DateTime)row["NgayKetThuc"]).ToString("yyyy-MM-dd")
                            );
                        }
                    }
                    xmlData = string.Format("<Root>{0}</Root>", xmlData);
                    bindingSourceQuyetDinh.EndEdit();
                    int kq = 0;
                    DataServices.GiangVien.LuuQuyetDinh(xmlData);
                    if (kq == 0)
                    {
                        XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReloadGridView();
                    }
                    else XtraMessageBox.Show("Đã xảy ra lỗi khi lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.\n" + ex.Message + "\n" + ex.StackTrace, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ckbTatCa_CheckedChanged(object sender, EventArgs e)
        {
            dtpTuNgay.Enabled = dtpDenNgay.Enabled = ckbTatCa.Checked;
            ReloadGridView();
        }

        private void dtpTuNgay_EditValueChanged(object sender, EventArgs e)
        {
            ReloadGridView();
        }

        private void dtpDenNgay_EditValueChanged(object sender, EventArgs e)
        {
            ReloadGridView();
        }

        private void rcboChucVu_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if(e.NewValue.ToString() != e.OldValue.ToString())
            {
                string ma_cu = gridViewQuyetDinh.GetRowCellValue(gridViewQuyetDinh.FocusedRowHandle, "MaChucVuCu").ToString();
                if (ma_cu == e.NewValue.ToString()) return;
                int ma_hien_tai = e.OldValue.ToString() == "" ? 0 : (int)e.OldValue;
                gridViewQuyetDinh.SetRowCellValue(gridViewQuyetDinh.FocusedRowHandle, "ThayDoi", true);
                gridViewQuyetDinh.SetRowCellValue(gridViewQuyetDinh.FocusedRowHandle, "MaChucVuCu", ma_hien_tai);
                gridViewQuyetDinh.SetRowCellValue(gridViewQuyetDinh.FocusedRowHandle, "MaChucVu", e.NewValue);
                AppGridView.GridRowAppearance(gridViewQuyetDinh, "ThayDoi"
                    , DevExpress.XtraGrid.FormatConditionEnum.Equal, "True", System.Drawing.Color.FromArgb(220, 255, 240));
            }
        }

        private void rcboLoaiGiangVien_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue.ToString() != e.OldValue.ToString())
            {
                string ma_cu = gridViewQuyetDinh.GetRowCellValue(gridViewQuyetDinh.FocusedRowHandle, "MaLoaiGiangVienCu").ToString();
                if (ma_cu == e.NewValue.ToString()) return;
                int ma_hien_tai = e.OldValue.ToString() == "" ? 0 : (int)e.OldValue;
                gridViewQuyetDinh.SetRowCellValue(gridViewQuyetDinh.FocusedRowHandle, "ThayDoi", true);
                gridViewQuyetDinh.SetRowCellValue(gridViewQuyetDinh.FocusedRowHandle, "MaLoaiGiangVienCu", ma_hien_tai);
                gridViewQuyetDinh.SetRowCellValue(gridViewQuyetDinh.FocusedRowHandle, "MaLoaiGiangVien", e.NewValue);
                AppGridView.GridRowAppearance(gridViewQuyetDinh, "ThayDoi"
                    , DevExpress.XtraGrid.FormatConditionEnum.Equal, "True", System.Drawing.Color.FromArgb(220, 255, 240));
            }
        }

        private void rcboHocHam_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue.ToString() != e.OldValue.ToString())
            {
                string ma_cu = gridViewQuyetDinh.GetRowCellValue(gridViewQuyetDinh.FocusedRowHandle, "MaHocHamCu").ToString();
                if (ma_cu == e.NewValue.ToString()) return;
                int ma_hien_tai = e.OldValue.ToString() == "" ? 0 : (int)e.OldValue;
                gridViewQuyetDinh.SetRowCellValue(gridViewQuyetDinh.FocusedRowHandle, "ThayDoi", true);
                gridViewQuyetDinh.SetRowCellValue(gridViewQuyetDinh.FocusedRowHandle, "MaHocHamCu", ma_hien_tai);
                gridViewQuyetDinh.SetRowCellValue(gridViewQuyetDinh.FocusedRowHandle, "MaHocHam", e.NewValue);
                AppGridView.GridRowAppearance(gridViewQuyetDinh, "ThayDoi"
                    , DevExpress.XtraGrid.FormatConditionEnum.Equal, "True", System.Drawing.Color.FromArgb(220, 255, 240));
            }
        }

        private void rcboHocVi_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue.ToString() != e.OldValue.ToString())
            {
                string ma_cu = gridViewQuyetDinh.GetRowCellValue(gridViewQuyetDinh.FocusedRowHandle, "MaHocViCu").ToString();
                if (ma_cu == e.NewValue.ToString()) return;
                int ma_hien_tai = e.OldValue.ToString() == "" ? 0 : (int)e.OldValue;
                gridViewQuyetDinh.SetRowCellValue(gridViewQuyetDinh.FocusedRowHandle, "ThayDoi", true);
                gridViewQuyetDinh.SetRowCellValue(gridViewQuyetDinh.FocusedRowHandle, "MaHocViCu", ma_hien_tai);
                gridViewQuyetDinh.SetRowCellValue(gridViewQuyetDinh.FocusedRowHandle, "MaHocVi", e.NewValue);
                AppGridView.GridRowAppearance(gridViewQuyetDinh, "ThayDoi"
                    , DevExpress.XtraGrid.FormatConditionEnum.Equal, "True", System.Drawing.Color.FromArgb(220, 255, 240));
            }
        }

        private void gridViewChiTietTienCanTren_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //MessageBox.Show(e.Value.ToString());
            if(e.Column.FieldName == "MaGiangVien")
            {
                VList<ViewGiangVien> vlist = bindingSourceGiangVien.DataSource as VList<ViewGiangVien>;
                ViewGiangVien gv = vlist.Find(v => v.MaGiangVien == (int)e.Value);
                gridViewQuyetDinh.SetRowCellValue(e.RowHandle, "HoTen", gv.HoTen);
                gridViewQuyetDinh.SetRowCellValue(e.RowHandle, "TenDonVi", gv.TenDonVi);
                gridViewQuyetDinh.SetRowCellValue(e.RowHandle, "ThayDoi", true);
            }
        }
    }
}
