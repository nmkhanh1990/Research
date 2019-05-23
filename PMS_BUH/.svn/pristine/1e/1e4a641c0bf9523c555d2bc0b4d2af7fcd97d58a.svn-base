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
    public partial class ucHocHam : XtraUserControl
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

        public ucHocHam()
        {
            InitializeComponent();
        }

        private void ucHocHam_Load(object sender, EventArgs e)
        {
            #region Init GridView HocHam
            AppGridView.InitGridView(gridViewHocHam, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHocHam, new string[] { "ThuTu", "MaQuanLy", "TenHocHam","TinhTrang" },
                new string[] { "STT", "Mã học hàm", "Tên học hàm","Không dùng" },
                new int[] { 70, 100, 300,100 });
            AppGridView.AlignHeader(gridViewHocHam, new string[] { "ThuTu", "MaQuanLy", "TenHocHam", "TinhTrang" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewHocHam, new string[] { "ThuTu" });
            AppGridView.ShowEditor(gridViewHocHam, NewItemRowPosition.Top);
            #endregion

            #region Init Datasource
            bindingSourceHocHam.DataSource = DataServices.HocHam.GetAll();
            //PMS.Common.Globals.LoadLayout(Tag as AppModule, new object[] { gridViewHocHam, barManager1, layoutControl1 });
            #endregion

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HocHam obj = bindingSourceHocHam.Current as HocHam;
            if (obj != null)
            {
                if (obj.IsNew)
                    bindingSourceHocHam.Remove(obj);
                else
                    obj.CancelChanges();
                gridViewHocHam.RefreshData();
            }
        }

        private void gridViewHocHam_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHocHam, e);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewHocHam.FocusedRowHandle = -1;
            TList<HocHam> list = bindingSourceHocHam.DataSource as TList<HocHam>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceHocHam.EndEdit();
                            DataServices.HocHam.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewHocHam, barManager1, layoutControl1 });
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
            bindingSourceHocHam.DataSource = DataServices.HocHam.GetAll();
            Cursor.Current = Cursors.Default;
        }

        private void gridViewHocHam_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewHocHam, e);
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            HocHam obj = target as HocHam;
            if (obj != null)
            {
                if (((TList<HocHam>)bindingSourceHocHam.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
                {
                    e.Description = string.Format("Mã học hàm {0} hiện tại đã có.", obj.MaQuanLy);
                    return false;
                }
            }
            return true;
        }

        private void gridViewHocHam_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            HocHam obj = e.Row as HocHam;
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

        private void gridViewHocHam_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHocHam);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlHocHam.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        private void gridViewHocHam_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.Name == "colTenHocHam")
            {
                if (CheckMaChucDanh(gridViewHocHam.GetRowCellDisplayText(e.RowHandle, "MaQuanLy")) == 0)
                    gridViewHocHam.SetRowCellValue(e.RowHandle, "ThuTu", gridViewHocHam.DataRowCount + 1);
            }
        }

        private int CheckMaChucDanh(string strMaCD)
        {
            int ichk = 0;
            TList<HocHam> list = bindingSourceHocHam.DataSource as TList<HocHam>;
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