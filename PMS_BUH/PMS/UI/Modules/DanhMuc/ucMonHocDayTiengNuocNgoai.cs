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
using DevExpress.XtraGrid.Columns;
using System.Data;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucMonHocDayTiengNuocNgoai : XtraUserControl
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
        VList<VMonHocTinChi> LstMonHoc;
        public ucMonHocDayTiengNuocNgoai()
        {
            InitializeComponent();
            _maTruong = PMS.Common.Globals.GetMaTruong(_listCauHinh, "Mã trường");
        }


        #region InitGridView

        //VHU - LAW giống nhau

        void InitGridHBU()
        {

            AppGridView.InitGridView(gridView, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridView, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridView, new string[] { "MaMonHoc", "TenMonHoc", "TrangThai" },
                new string[] { "Mã môn học", "Tên môn học", "Trạng thái" },
                new int[] { 100, 400, 150 });
            AppGridView.AlignHeader(gridView, new string[] { "MaMonHoc", "TenMonHoc", "TrangThai" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridView, "MaMonHoc", repositoryItemGridLookUpEditMonHoc);
        }

        void InitDataShow()
        {
            bindingSource.DataSource = DataServices.MonHocDayTiengNuocNgoai.GetAll();
        }

        void InitDataRepository()
        {
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditMonHoc, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditMonHoc, new string[] { "MaMonHoc", "TenMonHoc" }, new string[] { "Mã môn học", "Tên môn học" }
                        , new int[] { 100, 180 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditMonHoc, 400, 500);
            repositoryItemGridLookUpEditMonHoc.DisplayMember = "MaMonHoc";
            repositoryItemGridLookUpEditMonHoc.ValueMember = "MaMonHoc";
            repositoryItemGridLookUpEditMonHoc.NullText = string.Empty;
            LstMonHoc = DataServices.VMonHocTinChi.GetAll();
            repositoryItemGridLookUpEditMonHoc.DataSource = LstMonHoc;
        }

        #endregion

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MonHocDayTiengNuocNgoai obj = gridView.GetFocusedRow() as MonHocDayTiengNuocNgoai;
            if (obj != null)
            {
                if (obj.EntityState == EntityState.Changed)
                    obj.CancelChanges();
                else
                    RestoreDeletedItems();
            }
            else
                RestoreDeletedItems();
            gridView.RefreshData();
        }

        private void RestoreDeletedItems()
        {
            TList<MonHocDayTiengNuocNgoai> list = bindingSource.DataSource as TList<MonHocDayTiengNuocNgoai>;
            if (list != null)
            {
                if (list.DeletedItems.Count > 0)
                {
                    foreach (MonHocDayTiengNuocNgoai c in list.DeletedItems)
                    {
                        c.EntityState = EntityState.Changed;
                        list.Add(c);
                        list.DeletedItems.Remove(c);
                        break;
                    }
                }
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView.FocusedRowHandle = -1;
            TList<MonHocDayTiengNuocNgoai> list = bindingSource.DataSource as TList<MonHocDayTiengNuocNgoai>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSource.EndEdit();
                            DataServices.MonHocDayTiengNuocNgoai.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridView, barManager1, layoutControl1 });
                            PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_LuuThayDoiThanhCong, MessageBoxIcon.Information, true);
                        }
                        else
                            XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", list.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_LuuLoiXayRa, MessageBoxIcon.Error, true);
                    }
                }
            }
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSource.DataSource = DataServices.MonHocDayTiengNuocNgoai.GetAll();
            Cursor.Current = Cursors.Default;
        }


        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            MonHocDayTiengNuocNgoai obj = target as MonHocDayTiengNuocNgoai;
            if (obj != null)
            {
                if (((TList<MonHocDayTiengNuocNgoai>)bindingSource.DataSource).FindAll(p => p.MaMonHoc == obj.MaMonHoc).Count > 1)
                {
                    e.Description = string.Format("Mã môn học {0} hiện tại đã có.", obj.MaMonHoc);
                    return false;
                }
            }
            return true;
        }



        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridView);
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
                    gridControl.ExportToXls(sf.FileName);
                    PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_XuatFile, MessageBoxIcon.Information, true);
                }
            }
            catch
            { }
        }

        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaMonHoc")
            {
                string strMonHoc = gridView.GetRowCellValue(e.RowHandle, "MaMonHoc").ToString();
                //DataRowView v = gridView.GetRow(e.RowHandle) as DataRowView;
                string _TenMonHoc = LstMonHoc.Find(p => p.MaMonHoc == strMonHoc).TenMonHoc;
                gridView.SetRowCellValue(e.RowHandle, "TenMonHoc", _TenMonHoc);

            }
        }

        private void ucMonHocDayTiengNuocNgoai_Load(object sender, EventArgs e)
        {
            #region Init GridView
            InitGridHBU();
            #endregion

            #region Init DataSource
            InitDataShow();
            InitDataRepository();
            #endregion
        }

        private void gridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridView, e);
        }

        private void gridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            MonHocDayTiengNuocNgoai obj = e.Row as MonHocDayTiengNuocNgoai;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckDuplicate, "MaMonHoc");
                if (obj.IsValid)
                    e.Valid = true;
                else
                {
                    XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                }
            }
        }

        private void gridView_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridView, e);
        }
    }
}