using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Services;
using PMS.Entities;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using System.Collections.Generic;
using Libraries.BLL.FormHeThong;
using System.Reflection;
using System.Linq;
using PMS.Entities.Validation;

namespace PMS.UI.Forms.HeThong
{
    public partial class frmTaiKhoanDuocPhep : XtraForm
    {

        string[] strIDColumns = new string[] { "IdTaiKhoan", "IdThanhPhan" };
        string[] strFieldColumns = new string[] { "Tên tài khoản", "Tên chức năng" };
        int[] iSizeColumns = new int[] { 200, 200 };
        public frmTaiKhoanDuocPhep()
        {
            InitializeComponent();
        }
              
        private void InitData()
        {
            bds_ThanhPhanChucNang.DataSource = DataServices.TaiKhoanDuocPhep.GetAll();
            gridControlTieuDe.DataSource = bds_ThanhPhanChucNang;

            bds_TaiKhoan.DataSource = DataServices.TaiKhoan.GetAll();
            TList<ThanhPhanChucNang> LstThanhPhan = DataServices.ThanhPhanChucNang.GetAll();
            List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();
            foreach (ThanhPhanChucNang Itemobj in LstThanhPhan)
            {
                list.Add(new CheckedListBoxItem(Itemobj.Id.ToString(), Itemobj.TenThanhPhan.ToString(), CheckState.Unchecked, true));
            }
            repositoryItemChecked_ThanhPhan.Items.AddRange(list.ToArray());
            repositoryItemChecked_ThanhPhan.SeparatorChar = ';';
        }

        private void frmXemNguoiDung_Load(object sender, EventArgs e)
        {
            ShowFile();
            InitData();
        }


        private void ShowFile()
        {
            AppGridView.InitGridView(gridViewTieuDe, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewTieuDe, strIDColumns, strFieldColumns, iSizeColumns);
            AppGridView.ShowEditor(gridViewTieuDe, NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewTieuDe, strIDColumns, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewTieuDe, "IdTaiKhoan", repositoryItemGrid_TaiKhoan);
            AppGridView.RegisterControlField(gridViewTieuDe, "IdThanhPhan", repositoryItemChecked_ThanhPhan);

            #region Nhóm quyền
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGrid_TaiKhoan, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGrid_TaiKhoan, new string[] { "MaTaiKhoan", "TenDangNhap","HoTen" }, new string[] { "Mã tài khoản", "Tên tài khoản","Họ và tên" }, new int[] { 100, 200,150 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGrid_TaiKhoan, 500, 450);
            repositoryItemGrid_TaiKhoan.DisplayMember = "TenDangNhap";
            repositoryItemGrid_TaiKhoan.ValueMember = "MaTaiKhoan";
            repositoryItemGrid_TaiKhoan.NullText = string.Empty;
            #endregion

                  
        }



        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewTieuDe.FocusedRowHandle = -1;
            TList<TaiKhoanDuocPhep> list = bds_ThanhPhanChucNang.DataSource as TList<TaiKhoanDuocPhep>;
            if (list != null)
            {
                
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    try
                    {
                        if (list.IsValid)
                        {
                            bds_ThanhPhanChucNang.EndEdit();
                            DataServices.TaiKhoanDuocPhep.Save(list);
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewTieuDe);
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            TaiKhoanDuocPhep obj = target as TaiKhoanDuocPhep;
            if (obj != null)
            {
                if (((TList<TaiKhoanDuocPhep>)bds_ThanhPhanChucNang.DataSource).FindAll(p => p.IdTaiKhoan == obj.IdTaiKhoan).Count > 1)
                {
                    e.Description = string.Format("Mã thành phần {0} hiện tại đã có.", obj.IdThanhPhan);
                    return false;
                }
            }
            return true;
        }

        private void gridViewTieuDe_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            TaiKhoanDuocPhep obj = e.Row as TaiKhoanDuocPhep;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckDuplicate, "IdTaiKhoan");                
                if (obj.IsValid)
                    e.Valid = true;
                else
                {
                    XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                }
            }
        }
    }
}