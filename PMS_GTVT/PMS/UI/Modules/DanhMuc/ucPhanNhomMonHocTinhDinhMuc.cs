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
    public partial class ucPhanNhomMonHocTinhDinhMuc : UserControl
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

        public ucPhanNhomMonHocTinhDinhMuc()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _thayDoiMaNhomMon = false;
        }

        private void ucPhanNhomMonHocTinhDinhMuc_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewPhanNhomMonHocTinhDinhMuc, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewPhanNhomMonHocTinhDinhMuc, new string[] { "ChonLuu", "MaMonHoc", "TenMonHoc", "SoTinChi", "TenDonVi", "MaNhomMon", "ThayDoi" }
                        , new string[] { "Chọn", "Mã môn học", "Tên môn học", "Tín chỉ", "Khoa - Bộ môn", "Nhóm môn học", "Thay đổi" }
                        , new int[] { 40, 80, 300, 50, 200, 200, 50 });
            AppGridView.AlignHeader(gridViewPhanNhomMonHocTinhDinhMuc, new string[] { "ChonLuu", "MaMonHoc", "TenMonHoc", "SoTinChi", "MaNhomMon", "TenDonVi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewPhanNhomMonHocTinhDinhMuc, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "TenDonVi" });
            AppGridView.HideField(gridViewPhanNhomMonHocTinhDinhMuc, new string[] { "ThayDoi" });
            AppGridView.RegisterControlField(gridViewPhanNhomMonHocTinhDinhMuc, "MaNhomMon", repositoryItemGridLookUpEditNhomMonHoc);
            AppGridView.SummaryField(gridViewPhanNhomMonHocTinhDinhMuc, "MaMonHoc", "{0} môn.", DevExpress.Data.SummaryItemType.Count);
            #endregion

            #region Nhóm môn học tính định mức
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNhomMonHoc
                , new string[] { "TenNhomMon" }, new string[] { "Tên nhóm môn học" }
                , new int[] { 250 }, "MaNhomMon", "TenNhomMon", 300, 300);
            
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Form chọn lựa
            _frmChon = new frmChonLua();
            _frmChon.ThietLapViewComboBox(new string[] { "TenNhomMon" }, new string[] { "Tên nhóm môn học" }
                , new int[] { 200 }, "MaNhomMon", "TenNhomMon", 220, 300);
            _frmChon.ChonNhieu = false;
            #endregion 

            InitData();
        }

        #region InitData
        private void InitData()
        {
            bindingSourceNhomMonHoc.DataSource = DataServices.NhomMonHocTinhDinhMuc.GetAll();
            _frmChon.DataSource = bindingSourceNhomMonHoc.DataSource;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            ReloadGridView();
        }
        private void ReloadGridView()
        {
            if (cboNamHoc.EditValue != null)
            {
                //DataServices.PhanNhomMonHocTinhDinhMuc.PhanNhomMacDinh(cboNamHoc.EditValue.ToString());
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.PhanNhomMonHocTinhDinhMuc.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), null);
                tb.Load(reader);
                tb.Columns["ChonLuu"].ReadOnly = false;
                tb.Columns["ThayDoi"].ReadOnly = false;
                bindingSourcePhanNhomMonHoc.DataSource = tb;
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
            AppGridView.DeleteSelectedRows(gridViewPhanNhomMonHocTinhDinhMuc);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewPhanNhomMonHocTinhDinhMuc.FocusedRowHandle = -1;

            string xmlData = "";
            bindingSourcePhanNhomMonHoc.EndEdit();

            try
            {
                DataTable dt = bindingSourcePhanNhomMonHoc.DataSource as DataTable;
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
                                , (string)row["MaMonHoc"], Common.Globals.IsNull(_maNhomDuocChon, "int"));
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
                                , (string)row["MaMonHoc"], (string)row["MaNhomMon"]);
                        }
                    }
                }

                if(xmlData != "")
                {
                    xmlData = String.Format("<Root>{0}</Root>", xmlData);
                    DataServices.PhanNhomMonHocTinhDinhMuc.LuuTheoNam(xmlData, cboNamHoc.EditValue.ToString());
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

        private void gridViewNhomMonHoc_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewPhanNhomMonHocTinhDinhMuc, e);
        }

        private void gridViewNhomMonHoc_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewPhanNhomMonHocTinhDinhMuc, e);
        }

        private void gridViewNhomMonHoc_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" } )
                {
                    sf.ShowDialog();
                    if (sf.FileName != "")
                    {
                        gridControlPhanNhomMonHocTinhDinhMuc.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void repositoryItemGridLookUpEditNhomMonHoc_EditValueChanging(object sender, ChangingEventArgs e)
        {
            _thayDoiMaNhomMon = e.OldValue.ToString() != e.NewValue.ToString();
        }

        private void gridViewPhanNhomMonHocTinhDinhMuc_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if(e.Column.FieldName == "MaNhomMon")
            {
                gridViewPhanNhomMonHocTinhDinhMuc.SetRowCellValue(e.RowHandle, "ThayDoi", _thayDoiMaNhomMon);
                AppGridView.GridRowAppearance(gridViewPhanNhomMonHocTinhDinhMuc, "ThayDoi"
                    , DevExpress.XtraGrid.FormatConditionEnum.Equal, "True", System.Drawing.Color.FromArgb(200,255,210));
            }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ReloadGridView();
            Cursor.Current = Cursors.Default;
        }
        
        
    }
}
