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
using System.Collections.Generic;

namespace PMS.UI.Modules.DanhMuc.Yersin
{
    public partial class ucDonGiaNhomNganh : XtraUserControl
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

        public ucDonGiaNhomNganh()
        {
            InitializeComponent();
        }

       
        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DonGiaNhomNganh obj = bindingSourceMaNhomNganh.Current as DonGiaNhomNganh;
            if (obj != null)
            {
                if (obj.IsNew)
                    bindingSourceMaNhomNganh.Remove(obj);
                else
                    obj.CancelChanges();
                gridViewChucDanh.RefreshData();
            }
        }
               

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewChucDanh.FocusedRowHandle = -1;
            TList<DonGiaNhomNganh> list = bindingSourceMaNhomNganh.DataSource as TList<DonGiaNhomNganh>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceMaNhomNganh.EndEdit();
                            DataServices.DonGiaNhomNganh.Save(list);
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
            DonGiaNhomNganh obj = target as DonGiaNhomNganh;
            if (obj != null)
            {
                if (((TList<DonGiaNhomNganh>)bindingSourceMaNhomNganh.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
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
            AppGridView.ShowField(gridViewChucDanh, new string[] { "MaQuanLy", "MaTenNhomNganh", "GiaTri", "GhiChu", "TinhTrang"},
                new string[] { "Mã nhóm ngành", "Tên nhóm ngành","giá trị","Ghi chú","Tình trạng" },
                new int[] { 100, 300,120,100,100 });
            AppGridView.ShowEditor(gridViewChucDanh, NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewChucDanh, new string[] { "MaQuanLy", "MaTenNhomNganh", "GiaTri", "GhiChu", "TinhTrang" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewChucDanh, "MaTenNhomNganh", repositoryItemCheckedComboBoxEdit_MaNhomNganh);

            #endregion

            #region Init Datasource
            Initdata();
            #endregion
        }

       
        private void gridViewChucDanh_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DonGiaNhomNganh obj = e.Row as DonGiaNhomNganh;
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
            InitDonGiaPhuCap();
            bindingSourceMaNhomNganh.DataSource = DataServices.DonGiaNhomNganh.GetAll();
            
        }

        void InitDonGiaPhuCap()
        {
            #region Init GioGiang
            repositoryItemCheckedComboBoxEdit_MaNhomNganh.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEdit_MaNhomNganh.TextEditStyle = TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEdit_MaNhomNganh.Items.Clear();
            VList<ViewKhoaBoMon> _TList = new VList<ViewKhoaBoMon>();
            _TList = DataServices.ViewKhoaBoMon.GetAll();
            List<CheckedListBoxItem> _listDM = new List<CheckedListBoxItem>();
            foreach (ViewKhoaBoMon v in _TList)
            {
                _listDM.Add(new CheckedListBoxItem(v.MaKhoa, v.TenKhoa, CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboBoxEdit_MaNhomNganh.Items.AddRange(_listDM.ToArray());
            repositoryItemCheckedComboBoxEdit_MaNhomNganh.SeparatorChar = ';';
            #endregion
        }


    }
}