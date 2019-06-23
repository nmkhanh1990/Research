using DevExpress.Common.Grid;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Entities.Validation;
using PMS.Services;
using PMS.UI.Forms.FormCon;
using System;
using System.Data;
using System.Windows.Forms;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucPhanNhomGiangVienTinhDinhMuc : UserControl
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ItemShortcut = DevExpress.XtraBars.BarShortcut.Empty;

                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnXoa.ItemShortcut = DevExpress.XtraBars.BarShortcut.Empty;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        string _maTruong;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        frmChonLua _frmChon;
        string _maNhomDuocChon;
        bool _thayDoiMaNhomMon;
        #endregion

        public ucPhanNhomGiangVienTinhDinhMuc()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _thayDoiMaNhomMon = false;
        }

        private void ucPhanNhomGiangVienTinhDinhMuc_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewPhanNhomGiangVienTinhDinhMuc, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewPhanNhomGiangVienTinhDinhMuc, new string[] { "ChonLuu", "MaQuanLy", "HoTen", "TenDonVi", "MaNhomGiangVien", "ThayDoi" },
                        new string[] { "Chọn", "Mã giảng viên", "Họ và tên", "Khoa - Bộ môn", "Nhóm giảng viên", "Thay đổi" }, new int[] { 60, 100, 150, 200, 200, 50 });
            AppGridView.ShowEditor(gridViewPhanNhomGiangVienTinhDinhMuc, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewPhanNhomGiangVienTinhDinhMuc, new string[] { "ChonLuu", "MaQuanLy", "HoTen", "TenDonVi", "MaNhomGiangVien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewPhanNhomGiangVienTinhDinhMuc, new string[] { "ThayDoi" });
            //AppGridView.RegisterControlField(gridViewPhanNhomGiangVienTinhDinhMuc, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewPhanNhomGiangVienTinhDinhMuc, "MaNhomGiangVien", repositoryItemGridLookUpEditNhomGiangVien);
            AppGridView.SummaryField(gridViewPhanNhomGiangVienTinhDinhMuc, "MaQuanLy", "{0} giảng viên.", DevExpress.Data.SummaryItemType.Count);
            #endregion

            #region Nhóm giảng viên tính định mức
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNhomGiangVien
                , new string[] { "TenNhomGiangVien" }, new string[] { "Tên nhóm giảng viên" }
                , new int[] { 200 }, "MaNhomGiangVien", "TenNhomGiangVien", 220, 300);
            #endregion

            #region Năm học
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Học kỳ
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region Form chọn lựa
            _frmChon = new frmChonLua();
            _frmChon.ThietLapViewComboBox(new string[] { "TenNhomGiangVien" }, new string[] { "Tên nhóm giảng viên" }
                , new int[] { 250 }, "MaNhomGiangVien", "TenNhomGiangVien", 300, 300);
            _frmChon.ChonNhieu = false;
            #endregion 

            InitData();
        }

        #region InitData
        private void InitData()
        {
            bindingSourceNhomGiangVien.DataSource = DataServices.NhomGiangVienTinhDinhMuc.GetAll();
            _frmChon.DataSource = bindingSourceNhomGiangVien.DataSource;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            ReloadGridView();
        }
        private void ReloadGridView()
        {
            if (cboNamHoc.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.PhanNhomGiangVienTinhDinhMuc.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), null);
                tb.Load(reader);
                tb.Columns["ChonLuu"].ReadOnly = false;
                tb.Columns["ThayDoi"].ReadOnly = false;
                bindingSourcePhanNhomGiangVien.DataSource = tb;
            }
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewPhanNhomGiangVienTinhDinhMuc);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewPhanNhomGiangVienTinhDinhMuc.FocusedRowHandle = -1;

            string xmlData = "";
            bindingSourcePhanNhomGiangVien.EndEdit();

            try
            {
                DataTable dt = bindingSourcePhanNhomGiangVien.DataSource as DataTable;
                DataRow[] dr = dt.Select("ChonLuu = true");

                if (dr.Length > 0)
                {
                    DataTable dtChonLuu = dr.CopyToDataTable();
                    _frmChon.ShowDialog();
                    _maNhomDuocChon = _frmChon.GiaTriDuocChon;
                    if (_maNhomDuocChon == null) return;
                    if (XtraMessageBox.Show("Bạn có muốn lưu các môn đã chọn vào nhóm " + _maNhomDuocChon + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataRow row in dtChonLuu.Rows)
                        {
                            xmlData += String.Format("<Input M = \"{0}\" L = \"{1}\" />"
                                , (string)row["MaQuanLy"], Common.Globals.IsNull(_maNhomDuocChon, "int"));
                        }
                    }
                }

                dr = dt.Select("ThayDoi = true");

                if (dr.Length > 0)
                {
                    DataTable dtThayDoi = dr.CopyToDataTable();
                    if (XtraMessageBox.Show("Lưu các môn đã thay đổi phân nhóm riêng lẻ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataRow row in dtThayDoi.Rows)
                        {
                            xmlData += String.Format("<Input M = \"{0}\" L = \"{1}\" />"
                                , (string)row["MaQuanLy"], (string)row["MaNhomGiangVien"]);
                        }
                    }
                }

                if (xmlData != "")
                {
                    xmlData = String.Format("<Root>{0}</Root>", xmlData);
                    DataServices.PhanNhomGiangVienTinhDinhMuc.LuuTheoNam(xmlData, cboNamHoc.EditValue.ToString());
                    Cursor.Current = Cursors.Default;
                    XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadGridView();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.\n" + ex.Message + "\n" + ex.StackTrace, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewNhomGiangVien_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewPhanNhomGiangVienTinhDinhMuc, e);
        }

        private void gridViewNhomGiangVien_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewPhanNhomGiangVienTinhDinhMuc, e);
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
                        gridControlPhanNhomGiangVienTinhDinhMuc.ExportToXls(sf.FileName);
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
            ReloadGridView();
            Cursor.Current = Cursors.Default;
        }

        private void repositoryItemGridLookUpEditNhomGiangVien_EditValueChanging(object sender, ChangingEventArgs e)
        {
            _thayDoiMaNhomMon = e.OldValue.ToString() != e.NewValue.ToString();
        }

        private void gridViewPhanNhomGiangVienTinhDinhMuc_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "MaNhomGiangVien")
            {
                gridViewPhanNhomGiangVienTinhDinhMuc.SetRowCellValue(e.RowHandle, "ThayDoi", _thayDoiMaNhomMon);
                AppGridView.GridRowAppearance(gridViewPhanNhomGiangVienTinhDinhMuc, "ThayDoi"
                    , DevExpress.XtraGrid.FormatConditionEnum.Equal, "True", System.Drawing.Color.FromArgb(200, 255, 210));
            }
        }

        
    }
}
