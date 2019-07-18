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
using DevExpress.XtraGrid.Columns;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucHocVi : XtraUserControl
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

        public ucHocVi()
        {
            InitializeComponent();
        }

        private void ucHocVi_Load(object sender, EventArgs e)
        {
            #region Init GridView HocVi
            AppGridView.InitGridView(gridViewHocVi, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHocVi, new string[] { "ThuTu", "MaQuanLy", "TenHocVi", "TinhTrang" },
                new string[] { "STT", "Mã học vị", "Tên học vị","Không dùng" },
                new int[] { 70, 100, 300,100 });
            AppGridView.AlignHeader(gridViewHocVi, new string[] { "ThuTu", "MaQuanLy", "TenHocVi", "TinhTrang" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewHocVi, new string[] { "ThuTu" });
            AppGridView.ShowEditor(gridViewHocVi, NewItemRowPosition.Top);
            #endregion

            #region Init Datasource
            bindingSourceHocVi.DataSource = DataServices.HocVi.GetAll();
            //PMS.Common.Globals.LoadLayout(Tag as AppModule, new object[] { gridViewHocVi, barManager1, layoutControl1 });
            #endregion
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HocVi obj = bindingSourceHocVi.Current as HocVi;
            if (obj != null)
            {
                if (obj.IsNew)
                    bindingSourceHocVi.Remove(obj);
                else
                    obj.CancelChanges();
                gridViewHocVi.RefreshData();
            }
        }

        private void gridViewHocVi_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHocVi, e);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewHocVi.FocusedRowHandle = -1;
            TList<HocVi> list = bindingSourceHocVi.DataSource as TList<HocVi>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceHocVi.EndEdit();
                            DataServices.HocVi.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewHocVi, barManager1, layoutControl1 });
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", list.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Dòng dữ liệu này đang được sử dụng, không được phép xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceHocVi.DataSource = DataServices.HocVi.GetAll();
            Cursor.Current = Cursors.Default;
        }

        private void gridViewHocVi_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewHocVi, e);
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            HocVi obj = target as HocVi;
            if (obj != null)
            {
                if (((TList<HocVi>)bindingSourceHocVi.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
                {
                    e.Description = string.Format("Mã học vị {0} hiện tại đã có.", obj.MaQuanLy);
                    return false;
                }
            }
            return true;
        }

        private void gridViewHocVi_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            HocVi obj = e.Row as HocVi;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckDuplicate, "MaQuanLy");
                if (obj.IsValid)
                    e.Valid = true;
                else
                {
                    XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                }
            }
        }

        private void gridViewHocVi_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHocVi);
        }

        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlHocVi.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }

        private void gridViewHocVi_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.Name == "colTenHocVi")
            {
                if (CheckMaChucDanh(gridViewHocVi.GetRowCellDisplayText(e.RowHandle, "MaQuanLy")) == 0)
                    gridViewHocVi.SetRowCellValue(e.RowHandle, "ThuTu", gridViewHocVi.DataRowCount + 1);
            }
        }

        private int CheckMaChucDanh(string strMaCD)
        {
            int ichk = 0;
            TList<HocVi> list = bindingSourceHocVi.DataSource as TList<HocVi>;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].MaQuanLy.ToString() == strMaCD)
                {
                    ichk = list[i].ThuTu != null ? int.Parse(list[i].ThuTu.ToString()) : 0;
                    break;
                }
            }
            return ichk;
        }
    }
}