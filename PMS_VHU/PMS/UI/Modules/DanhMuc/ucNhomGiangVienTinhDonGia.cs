using DevExpress.Common.Grid;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using PMS.Core;
using PMS.Entities;
using PMS.Entities.Validation;
using PMS.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucNhomGiangVienTinhDonGia : UserControl
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
        #endregion

        public ucNhomGiangVienTinhDonGia()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucNhomGiangVienTinhDonGia_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewNhomGiangVienTinhDonGia, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewNhomGiangVienTinhDonGia, new string[] { "MaNhom", "TenNhom", "GhiChu" },
                        new string[] { "Mã nhóm", "Tên nhóm", "Ghi chú" },
                        new int[] { 100, 300, 300 });
            AppGridView.ShowEditor(gridViewNhomGiangVienTinhDonGia, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewNhomGiangVienTinhDonGia, new string[] { "MaNhom", "TenNhom", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            #endregion

            #region NhomThucHanh
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNhomThucHanh, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNhomThucHanh, new string[] { "TenNhomThucHanh" }, new string[] { "Nhóm thực hành" });
            repositoryItemGridLookUpEditNhomThucHanh.DisplayMember = "TenNhomThucHanh";
            repositoryItemGridLookUpEditNhomThucHanh.ValueMember = "MaNhomThucHanh";
            repositoryItemGridLookUpEditNhomThucHanh.NullText = string.Empty;
            repositoryItemGridLookUpEditNhomThucHanh.BestFitMode = BestFitMode.BestFit;
            #endregion

            InitData();
        }

        #region InitData
        private void InitData()
        {
            InitNhomThucHanh();
            bindingSourceNhomGiangVienTinhDonGia.DataSource = DataServices.NhomGiangVienTinhDonGia.GetAll();
        }

        void InitNhomThucHanh()
        {
            DataTable tb = new DataTable();
            DataColumn col1 = new DataColumn("MaNhomThucHanh", typeof(decimal));
            DataColumn col2 = new DataColumn("TenNhomThucHanh", typeof(string));

            tb.Columns.Add(col1);
            tb.Columns.Add(col2);

            DataRow r1 = tb.NewRow();
            r1["MaNhomThucHanh"] = 1;
            r1["TenNhomThucHanh"] = "Thực hành đại cương";
            DataRow r2 = tb.NewRow();
            r2["MaNhomThucHanh"] = 2;
            r2["TenNhomThucHanh"] = "Thực hành chuyên nghiệp";
            tb.Rows.Add(r1);
            tb.Rows.Add(r2);

            bindingSourceNhomThucHanh.DataSource = tb;
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
            AppGridView.DeleteSelectedRows(gridViewNhomGiangVienTinhDonGia);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewNhomGiangVienTinhDonGia.FocusedRowHandle = -1;
            TList<NhomGiangVienTinhDonGia> list = bindingSourceNhomGiangVienTinhDonGia.DataSource as TList<NhomGiangVienTinhDonGia>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceNhomGiangVienTinhDonGia.EndEdit();
                            DataServices.NhomGiangVienTinhDonGia.Save(list);
                            Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewNhomGiangVienTinhDonGia, barManager1, layoutControl1 });
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", list.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void gridViewNhomGiangVienTinhDonGia_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewNhomGiangVienTinhDonGia, e);
        }

        private void gridViewNhomGiangVienTinhDonGia_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewNhomGiangVienTinhDonGia, e);
        }

        private void gridViewNhomGiangVienTinhDonGia_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            NhomGiangVienTinhDonGia obj = e.Row as NhomGiangVienTinhDonGia;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckDuplicate, "MaNhom");
                if (obj.IsValid)
                    e.Valid = true;
                else
                {
                    XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                }
            }
        }
        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            NhomGiangVienTinhDonGia obj = target as NhomGiangVienTinhDonGia;
            if (obj != null)
            {
                if (((TList<NhomGiangVienTinhDonGia>)bindingSourceNhomGiangVienTinhDonGia.DataSource).FindAll(p => p.MaNhom == obj.MaNhom).Count > 1)
                {
                    e.Description = string.Format("Mã quy đổi {0} hiện tại đã có.", obj.MaNhom);
                    return false;
                }
            }
            return true;
        }

        private void gridViewNhomGiangVienTinhDonGia_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gridViewNhomGiangVienTinhDonGia_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {

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
                        gridControlNhomGiangVienTinhDonGia.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }
    }
}
