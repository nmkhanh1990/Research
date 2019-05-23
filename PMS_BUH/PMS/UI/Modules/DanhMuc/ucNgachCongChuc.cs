﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.Entities.Validation;
using PMS.Entities;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucNgachCongChuc : DevExpress.XtraEditors.XtraUserControl
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

        public ucNgachCongChuc()
        {
            InitializeComponent();
        }

        private void ucNgachCongChuc_Load(object sender, EventArgs e)
        {
            #region Init GridView QuyDoiGioChuan
            AppGridView.InitGridView(gridViewKyThi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewKyThi, new string[] { "MaQuanLy", "TenNgach", "Ngach", "GhiChu", "NgayCapNhat", "NguoiCapNhat" },
                new string[] { "Mã ngạch công chức", "Tên ngạch công chức", "Ngạch", "Ghi chú", "Ngày cập nhật", "Người cập nhật" },
                new int[] { 120, 200, 120, 200, 99, 99 });
            AppGridView.ShowEditor(gridViewKyThi, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.HideField(gridViewKyThi, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            #endregion
            InitData();
        }

        void InitData()
        {
            bindingSourceKyThi.DataSource = DataServices.NgachCongChuc.GetAll();
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InitData();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewKyThi);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewKyThi.FocusedRowHandle = -1;
            TList<NgachCongChuc> list = bindingSourceKyThi.DataSource as TList<NgachCongChuc>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceKyThi.EndEdit();
                            DataServices.NgachCongChuc.Save(list);
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

        private void gridViewKyThi_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaQuanLy" || col.FieldName == "TenNgach" || col.FieldName == "Ngach" || col.FieldName == "GhiChu")
            {
                gridViewKyThi.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
                gridViewKyThi.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void gridViewKyThi_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewKyThi, e);
        }

        private void gridViewKyThi_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            NgachCongChuc obj = e.Row as NgachCongChuc;
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


        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            NgachCongChuc obj = target as NgachCongChuc;
            if (obj != null)
            {
                if (((TList<NgachCongChuc>)bindingSourceKyThi.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
                {
                    e.Description = string.Format("Mã {0} hiện tại đã có.", obj.MaQuanLy);
                    return false;
                }
            }
            return true;
        }
    }
}