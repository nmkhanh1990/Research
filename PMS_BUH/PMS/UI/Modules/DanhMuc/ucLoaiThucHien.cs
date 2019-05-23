using System;
using PMS.Entities;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using PMS.Entities.Validation;
using PMS.Core;
using System.IO;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucLoaiThucHien : XtraUserControl
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

        TList<CauHinhChung> _listCauHinh = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        public ucLoaiThucHien()
        {
            InitializeComponent();
            _maTruong = _listCauHinh.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucChucVu_Load(object sender, EventArgs e)
        {
            #region Init GridView ChucVu
            InitRemaining();
            #endregion

            #region Init DataSource
            bindingSourceChucVu.DataSource = DataServices.LoaiThucHien.GetAll();
            #endregion
        }

        #region InitGridView
       

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewChucVu, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewChucVu, new string[] { "TenLoaiThucHien", "NgayThucHien", "NguoiThucHien", "TrangThaiDung","GhiChu" },
                new string[] { "Tên thực hiện", "Ngày thực hiên", "Người thực hiện", "Dùng", "Ghi chú" },
                new int[] { 150, 100, 100, 120, 170 });
            AppGridView.AlignHeader(gridViewChucVu, new string[] { "TenLoaiThucHien", "NgayThucHien", "NguoiThucHien", "TrangThaiDung", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ShowEditor(gridViewChucVu, NewItemRowPosition.Top);
            AppGridView.HideField(gridViewChucVu, new string[] { "NgayThucHien", "NguoiThucHien" });
        }
        #endregion

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoaiThucHien obj = gridViewChucVu.GetFocusedRow() as LoaiThucHien;
            if (obj != null)
            {
                if (obj.EntityState == EntityState.Changed)
                    obj.CancelChanges();
                else
                    RestoreDeletedItems();
            }
            else
                RestoreDeletedItems();            
            gridViewChucVu.RefreshData();
        }

        private void RestoreDeletedItems()
        {
            TList<LoaiThucHien> list = bindingSourceChucVu.DataSource as TList<LoaiThucHien>;
            if (list != null)
            {
                if (list.DeletedItems.Count > 0)
                {
                    foreach (LoaiThucHien c in list.DeletedItems)
                    {
                        c.EntityState = EntityState.Changed;
                        list.Add(c);
                        list.DeletedItems.Remove(c);
                        break;
                    }
                }
            }
        }

        private void gridViewChucVu_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewChucVu, e);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewChucVu.FocusedRowHandle = -1;
            TList<LoaiThucHien> list = bindingSourceChucVu.DataSource as TList<LoaiThucHien>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceChucVu.EndEdit();
                            DataServices.LoaiThucHien.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewChucVu, barManager1, layoutControl1 });
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

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceChucVu.DataSource = DataServices.LoaiThucHien.GetAll();
            Cursor.Current = Cursors.Default;
        }

        private void gridViewChucVu_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewChucVu, e);
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            LoaiThucHien obj = target as LoaiThucHien;
            if (obj != null)
            {
                if (((TList<LoaiThucHien>)bindingSourceChucVu.DataSource).FindAll(p => p.MaLoaiThucHien == obj.MaLoaiThucHien).Count > 1)
                {
                    e.Description = string.Format("Mã thực hiện {0} hiện tại đã có.", obj.MaLoaiThucHien);
                    return false;
                }
            }
            return true;
        }

        private void gridViewChucVu_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            LoaiThucHien obj = e.Row as LoaiThucHien;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckDuplicate, "MaLoaiThucHien");
                if (obj.IsValid)
                    e.Valid = true;
                else
                {
                    XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                }
            }
        }

        private void gridViewChucVu_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewChucVu);
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlChucVu.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }
    }
}