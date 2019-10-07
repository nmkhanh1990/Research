﻿using System;
using PMS.Entities;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using PMS.Entities.Validation;
using PMS.Core;

namespace PMS.UI.Modules.DanhMuc.KhongChinhQuy
{
    public partial class ucHeSoCoSo_Kcq : XtraUserControl
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
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        #endregion
        public ucHeSoCoSo_Kcq()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucHeSoCoSo_Load(object sender, EventArgs e)
        {
            #region Init GridView HeSoCoSo
            AppGridView.InitGridView(gridViewCoSo, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewCoSo, new string[] { "ThuTu", "MaQuanLy", "MaCoSo", "HeSo", "NgayBdApDung", "NgayKtApDung" },
                new string[] { "STT", "Mã cơ sở", "Tên cơ sở", "Hệ số", "Ngày BD áp dụng", "Ngày KT áp dụng" },
                new int[] { 70, 100, 350, 100, 150, 150 });
            AppGridView.ShowEditor(gridViewCoSo, NewItemRowPosition.Top);
            AppGridView.RegisterControlField(gridViewCoSo, "MaCoSo", repositoryItemGridLookUpEditCoSo);
            if (_maTruong != "LAW")
                AppGridView.HideField(gridViewCoSo, new string[] { "NgayBdApDung", "NgayKtApDung" });
            #endregion
            #region CoSo
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditCoSo, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditCoSo, new string[] { "MaCoSo", "TenCoSo" }, new string[] { "Mã cơ sở", "Tên cơ sở" });
            repositoryItemGridLookUpEditCoSo.DisplayMember = "TenCoSo";
            repositoryItemGridLookUpEditCoSo.ValueMember = "MaCoSo";
            repositoryItemGridLookUpEditCoSo.NullText = string.Empty;
            #endregion

            #region Init Datasource
            bindingSourceCoSo.DataSource = DataServices.ViewCoSo.GetAll();
            bindingSourceHeSoCoSo.DataSource = DataServices.KcqHeSoCoSo.GetAll();
            //PMS.Common.Globals.LoadLayout(Tag as AppModule, new object[] { gridViewCoSo, barManager1, layoutControl1 });
            #endregion
        }

        //private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    KcqHeSoCoSo obj = bindingSourceHeSoCoSo.Current as KcqHeSoCoSo;
        //    if (obj != null)
        //    {
        //        if (obj.IsNew)
        //            bindingSourceHeSoCoSo.Remove(obj);
        //        else
        //            obj.CancelChanges();
        //        gridViewCoSo.RefreshData();
        //    }
        //}

        private void gridViewHeSoCoSo_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewCoSo, e);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewCoSo.FocusedRowHandle = -1;
            TList<KcqHeSoCoSo> list = bindingSourceHeSoCoSo.DataSource as TList<KcqHeSoCoSo>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceHeSoCoSo.EndEdit();
                            DataServices.KcqHeSoCoSo.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewCoSo, barManager1, layoutControl1 });
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
            bindingSourceCoSo.DataSource = DataServices.ViewCoSo.GetAll();
            bindingSourceHeSoCoSo.DataSource = DataServices.KcqHeSoCoSo.GetAll();
            Cursor.Current = Cursors.Default;
        }

        private void gridViewHeSoCoSo_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewCoSo, e);
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            KcqHeSoCoSo obj = target as KcqHeSoCoSo;
            if (obj != null)
            {
                if (((TList<KcqHeSoCoSo>)bindingSourceHeSoCoSo.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
                {
                    e.Description = string.Format("Mã cơ sở {0} hiện đã có.", obj.MaQuanLy);
                    return false;
                }
            }
            return true;
        }

        private void gridViewHeSoCoSo_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            KcqHeSoCoSo obj = e.Row as KcqHeSoCoSo;
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

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewCoSo);
        }

        private void gridControlCoSo_Click(object sender, EventArgs e)
        {

        }

        private void gridViewCoSo_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlCoSo.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }
    }
}