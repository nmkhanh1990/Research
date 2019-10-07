using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;

namespace PMS.UI.Modules.DanhMucTheoNam
{
    public partial class ucNhomGiangVienDayLopHocPhan : DevExpress.XtraEditors.XtraUserControl
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

        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        VList<ViewLopHocPhan> _listLHP;
        public ucNhomGiangVienDayLopHocPhan()
        {
            InitializeComponent();
        }

        private void ucNhomGiangVienDayLopHocPhan_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewLHPKhongTinhGioGiang, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
            AppGridView.ShowEditor(gridViewLHPKhongTinhGioGiang, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewLHPKhongTinhGioGiang, new string[] { "MaLopHocPhan", "MaHocPhan", "TenHocPhan", "SoTinChi", "MaLop", "MaNhomGvLayDonGia" }
                    , new string[] { "Mã lớp học phần", "Mã học phần", "Tên học phần", "STC", "Lớp sinh viên", "Nhóm giảng viên" }
                    , new int[] { 110, 80, 180, 60, 90, 80, 99, 99 });
            AppGridView.AlignHeader(gridViewLHPKhongTinhGioGiang, new string[] { "MaLopHocPhan", "MaHocPhan", "TenHocPhan", "SoTinChi", "MaLop", "MaNhomGvLayDonGia" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewLHPKhongTinhGioGiang, "MaLopHocPhan", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewLHPKhongTinhGioGiang, new string[] { "MaHocPhan", "TenHocPhan", "SoTinChi", "MaLop" });
            //AppGridView.HideField(gridViewLHPKhongTinhGioGiang, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.RegisterControlField(gridViewLHPKhongTinhGioGiang, "MaLopHocPhan", repositoryItemGridLookUpEditLopHocPhan);
            AppGridView.RegisterControlField(gridViewLHPKhongTinhGioGiang, "MaNhomGvLayDonGia", repositoryItemGridLookUpEditNhomGiangVien);

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

            #region LopHocPhan
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLopHocPhan, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLopHocPhan
                    , new string[] { "MaLopHocPhan", "MaMonHoc", "TenMonHoc", "MaLop", "SoTinChi" }
                    , new string[] { "Lớp học phần", "Mã môn học", "Tên môn học", "Lớp sinh viên", "STC" }
                    , new int[] { 100, 90, 150, 100, 50 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditLopHocPhan, 500, 500);
            repositoryItemGridLookUpEditLopHocPhan.DisplayMember = "MaLopHocPhan";
            repositoryItemGridLookUpEditLopHocPhan.ValueMember = "MaLopHocPhan";
            repositoryItemGridLookUpEditLopHocPhan.NullText = string.Empty;
            #endregion

            #region Nhóm giảng viên lấy đơn giá
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNhomGiangVien, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNhomGiangVien, new string[] { "MaNhom", "TenNhom" }
                , new string[] { "Mã nhóm", "Tên nhóm" }, new int[] { 80, 300 });
            repositoryItemGridLookUpEditNhomGiangVien.DisplayMember = "TenNhom";
            repositoryItemGridLookUpEditNhomGiangVien.ValueMember = "MaNhom";
            repositoryItemGridLookUpEditNhomGiangVien.NullText = string.Empty;
            #endregion

            InitData();
        }

        void LoadDataGrid ()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                _listLHP = DataServices.ViewLopHocPhan.GetLopClcByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                bindingSourceLopHocPhan.DataSource = _listLHP; 
                IDataReader reader = DataServices.LopHocPhanTheoNhomGiangVien.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                DataTable tbl = new DataTable();
                tbl.Load(reader);
                tbl.Columns["MaLopHocPhan"].ReadOnly = false;
                tbl.Columns["MaNhomGvLayDonGia"].ReadOnly = false;
                bindingSourceLHPKhongTinhGioGiang.DataSource = tbl;
                gridViewLHPKhongTinhGioGiang.BestFitColumns();
            }
        }

        void InitData() 
        {
            bindingSourceNhomGiangVien.DataSource = DataServices.NhomGiangVienTinhDonGia.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            LoadDataGrid();
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewLHPKhongTinhGioGiang);
        }

        private void gridViewLHPKhongTinhGioGiang_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewLHPKhongTinhGioGiang, e);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewLHPKhongTinhGioGiang.FocusedRowHandle = -1;
            DataTable list = bindingSourceLHPKhongTinhGioGiang.DataSource as DataTable;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string xmlData = "";
                        int kq = -1;
                        foreach (DataRow q in list.Rows)
                        {
                            if(q.RowState != DataRowState.Deleted)
                            {
                                xmlData += "<Input LHP=\"" + q["MaLopHocPhan"].ToString()
                                + "\" NGV=\"" + q["MaNhomGvLayDonGia"].ToString()
                                + "\"/>";
                            }
                        }
                        bindingSourceLHPKhongTinhGioGiang.EndEdit();

                        xmlData = "<Root>" + xmlData + "</Root>";
                        DataServices.LopHocPhanTheoNhomGiangVien.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        if (sf.FileName != "")
                        {
                            gridControlLHPKhongTinhGioGiang.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch
            { }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void gridViewLHPKhongTinhGioGiang_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaLopHocPhan")
            {
                DataRowView r = gridViewLHPKhongTinhGioGiang.GetRow(e.RowHandle) as DataRowView;
                ViewLopHocPhan _lhp = _listLHP.Find(p => p.MaLopHocPhan == (string)r["MaLopHocPhan"]);

                gridViewLHPKhongTinhGioGiang.SetRowCellValue(e.RowHandle, "MaHocPhan", _lhp.MaMonHoc);
                gridViewLHPKhongTinhGioGiang.SetRowCellValue(e.RowHandle, "TenHocPhan", _lhp.TenMonHoc);
                gridViewLHPKhongTinhGioGiang.SetRowCellValue(e.RowHandle, "SoTinChi", _lhp.SoTinChi);
                gridViewLHPKhongTinhGioGiang.SetRowCellValue(e.RowHandle, "MaLop", _lhp.MaLop);
                gridViewLHPKhongTinhGioGiang.SetRowCellValue(e.RowHandle, "Nhom", _lhp.Nhom);
                gridViewLHPKhongTinhGioGiang.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewLHPKhongTinhGioGiang.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }
    }
}
