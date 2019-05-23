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
using System.Data;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucChucDanh : XtraUserControl
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

        public ucChucDanh()
        {
            InitializeComponent();
        }

       
        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChucDanh obj = bindingSourceChucDanh.Current as ChucDanh;
            if (obj != null)
            {
                if (obj.IsNew)
                    bindingSourceChucDanh.Remove(obj);
                else
                    obj.CancelChanges();
                gridViewChucDanh.RefreshData();
            }
        }
               

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewChucDanh.FocusedRowHandle = -1;
            TList<ChucDanh> list = bindingSourceChucDanh.DataSource as TList<ChucDanh>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceChucDanh.EndEdit();
                            DataServices.ChucDanh.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewChucDanh, Mng_Chucdanh, layoutControl1 });
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
            Initdata();
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Initdata();
            Cursor.Current = Cursors.Default;
        }
               

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            ChucDanh obj = target as ChucDanh;
            if (obj != null)
            {
                if (((TList<ChucDanh>)bindingSourceChucDanh.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
                {
                    e.Description = string.Format("Mã học hàm {0} hiện tại đã có.", obj.MaQuanLy);
                    return false;
                }
            }
            return true;
        }

        
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewChucDanh);
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
                            gridControlChucDanh.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        private void gridViewChucDanh_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewChucDanh, e);
        }

        private void gridViewChucDanh_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewChucDanh, e);
        }

        private void gridViewChucDanh_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void ucChucDanh_Load(object sender, EventArgs e)
        {
            #region Init GridView HocHam
            AppGridView.InitGridView(gridViewChucDanh, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewChucDanh, new string[] { "ThuTu", "MaQuanLy", "TenChucDanh", "TinhTrang" },
                new string[] { "STT", "Mã chức danh", "Tên chức danh","Không dùng" },
                new int[] { 70, 100, 300,100 });
            AppGridView.ShowEditor(gridViewChucDanh, NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewChucDanh, new string[] { "ThuTu", "MaQuanLy", "TenChucDanh", "TinhTrang" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewChucDanh, new string[] { "ThuTu" });
            #endregion

            #region Init Datasource
            Initdata();
            #endregion
        }

        private void gridViewChucDanh_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if(col.Name== "colTenChucDanh")
            {
                if(CheckMaChucDanh(gridViewChucDanh.GetRowCellDisplayText(e.RowHandle,"MaQuanLy"))==0)
                gridViewChucDanh.SetRowCellValue(e.RowHandle, "ThuTu", gridViewChucDanh.DataRowCount + 1);
            }
        }

        private void gridViewChucDanh_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            ChucDanh obj = e.Row as ChucDanh;
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

        private void Initdata()
        {
            bindingSourceChucDanh.DataSource = DataServices.ChucDanh.GetAll();
        }

        private int CheckMaChucDanh(string strMaCD)
        {
            int ichk = 0;
            TList<ChucDanh> list = bindingSourceChucDanh.DataSource as TList<ChucDanh>;
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i].MaQuanLy.ToString()==strMaCD)
                {
                    ichk = list[i].ThuTu != null ? int.Parse(list[i].ThuTu.ToString()) : 0;
                    break;
                }
            }
            return ichk;
        }
    }
}