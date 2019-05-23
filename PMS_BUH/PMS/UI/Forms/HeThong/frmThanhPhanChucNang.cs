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
    public partial class frmThanhPhanChucNang : XtraForm
    {
        
        string[] strIDColumns = new string[] { "TenThanhPhan"};
        string[] strFieldColumns = new string[] { "Tên chức năng"};
        int[] iSizeColumns = new int[] {200};
        public frmThanhPhanChucNang()
        {
            InitializeComponent();
        }
              
        private void InitData()
        {
            bds_ThanhPhanChucNang.DataSource = DataServices.ThanhPhanChucNang.GetAll();
            gridControlTieuDe.DataSource = bds_ThanhPhanChucNang;          
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
            TList<ThanhPhanChucNang> list = bds_ThanhPhanChucNang.DataSource as TList<ThanhPhanChucNang>;
            if (list != null)
            {
                
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    try
                    {
                        if (list.IsValid)
                        {
                            bds_ThanhPhanChucNang.EndEdit();
                            DataServices.ThanhPhanChucNang.Save(list);
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
            ThanhPhanChucNang obj = target as ThanhPhanChucNang;
            if (obj != null)
            {
                if (((TList<ThanhPhanChucNang>)bds_ThanhPhanChucNang.DataSource).FindAll(p => p.TenThanhPhan == obj.TenThanhPhan).Count > 1)
                {
                    e.Description = string.Format("Mã thành phần {0} hiện tại đã có.", obj.TenThanhPhan);
                    return false;
                }
            }
            return true;
        }

        private void gridViewTieuDe_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            ThanhPhanChucNang obj = e.Row as ThanhPhanChucNang;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckDuplicate, "TenThanhPhan");
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