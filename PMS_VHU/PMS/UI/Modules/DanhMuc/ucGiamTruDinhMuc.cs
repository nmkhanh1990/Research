using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Services;
using PMS.Entities;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.Entities.Validation;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucGiamTruDinhMuc : DevExpress.XtraEditors.XtraUserControl
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
        public ucGiamTruDinhMuc()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucGiamTruDinhMuc_Load(object sender, EventArgs e)
        {
            #region Init Gridview
            switch (_maTruong)
            {
                case "CDGTVT":
                    InitGridCDGTVT();
                    break;
                case "ACT":
                    InitGridCDGTVT();
                    break;
                case "IUH":
                    InitGridCDGTVT();
                    break;
                case "VHU":
                    InitGridDLU();
                    break;
                case "LAW":
                    InitGridCDGTVT();
                    break;
                case "HBU":
                    InitGridCDGTVT();
                    break;
                case "DLU":
                    InitGridDLU();
                    break;
                default:
                    InitRemaining();
                    break;
            }
            #endregion
            InitData();
        }
        #region InitData
        void InitData()
        {
            bindingSourceGiamTruDinhMuc.DataSource = DataServices.GiamTruDinhMuc.GetAll();
        }

        void InitGridCDGTVT()
        {
            AppGridView.InitGridView(gridViewGiamTruDinhMuc, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewGiamTruDinhMuc, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewGiamTruDinhMuc, new string[] { "NoiDungGiamTru", "MucGiam", "DonVi", "GhiChu", "NgayCapNhat", "NguoiCapNhat" },
                                    new string[] { "Nội dung giảm trừ", "Mức giảm", "Đơn vị", "Ghi chú", "D", "U" },
                                    new int[] { 400, 150, 100, 200, 99, 99 });
            AppGridView.AlignHeader(gridViewGiamTruDinhMuc, new string[] { "NoiDungGiamTru", "MucGiam", "DonVi", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewGiamTruDinhMuc, "DonVi", repositoryItemGridLookUpEditDonVi);
            AppGridView.HideField(gridViewGiamTruDinhMuc, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            if(_maTruong =="HBU")
            {
                AppGridView.HideField(gridViewGiamTruDinhMuc, new string[] { "NgayCapNhat", "NguoiCapNhat", "MucGiam", "DonVi" });
            }
            InitDonVi();
        }

        void InitGridDLU()
        {
            AppGridView.InitGridView(gridViewGiamTruDinhMuc, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewGiamTruDinhMuc, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewGiamTruDinhMuc, new string[] { "NoiDungGiamTru", "MucGiam", "MucGiamNckh", "DonVi", "GhiChu", "NgayCapNhat", "NguoiCapNhat" },
                                    new string[] { "Nội dung giảm trừ", "Mức giảm giảng dạy", "Mức giảm NCKH", "Đơn vị", "Ghi chú", "D", "U" },
                                    new int[] { 400, 150, 150, 100, 200, 99, 99 });
            AppGridView.AlignHeader(gridViewGiamTruDinhMuc, new string[] { "NoiDungGiamTru", "MucGiam", "MucGiamNckh", "DonVi", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewGiamTruDinhMuc, "DonVi", repositoryItemGridLookUpEditDonVi);
            AppGridView.HideField(gridViewGiamTruDinhMuc, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            InitDonVi();
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewGiamTruDinhMuc, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewGiamTruDinhMuc, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewGiamTruDinhMuc, new string[] { "NoiDungGiamTru", "PhanTramGiamTru", "PhanTramGiamTruNckh", "GhiChu", "NgayCapNhat", "NguoiCapNhat" },
                                    new string[] { "Nội dung giảm trừ", "Phần trăm giảm trừ (%)", "Phần trăm giảm trừ Nckh (%)", "Ghi chú", "NgayCapNhat", "NguoiCapNhat" },
                                    new int[] { 400, 150, 150,200, 99, 99 });
            AppGridView.AlignHeader(gridViewGiamTruDinhMuc, new string[] { "NoiDungGiamTru", "PhanTramGiamTru", "PhanTramGiamTruNckh", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewGiamTruDinhMuc, "PhanTramGiamTru", repositoryItemSpinEditPhanTramGiamTru); 
            AppGridView.RegisterControlField(gridViewGiamTruDinhMuc, "PhanTramGiamTruNckh", repositoryItemSpinEditPhanTramGiamTruNckh);
            AppGridView.HideField(gridViewGiamTruDinhMuc, new string[] { "NgayCapNhat", "NguoiCapNhat" });
        }

        void InitDonVi()
        {
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditDonVi, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditDonVi, new string[] { "MaDonVi", "TenDonVi" }, new string[] { "Mã đơn vị", "Đơn vị" });
            repositoryItemGridLookUpEditDonVi.ValueMember = "MaDonVi";
            repositoryItemGridLookUpEditDonVi.DisplayMember = "TenDonVi";
            repositoryItemGridLookUpEditDonVi.NullText = string.Empty;

            DataTable tb = new DataTable();
            tb.Columns.Add(new DataColumn("MaDonVi"));
            tb.Columns["MaDonVi"].Caption = "Mã đơn vị";
            tb.Columns.Add(new DataColumn("TenDonVi"));
            tb.Columns["TenDonVi"].Caption = "Đơn vị";

            DataRow r1 = tb.NewRow();
            r1["MaDonVi"] = "PhanTram";
            r1["TenDonVi"] = "Phần trăm (%)";
            DataRow r2 = tb.NewRow();
            r2["MaDonVi"] = "GioChuan";
            r2["TenDonVi"] = "Giờ chuẩn/tiết chuẩn";

            tb.Rows.Add(r1);
            tb.Rows.Add(r2);

            bindingSourceDonVi.DataSource = tb;
        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.WaitCursor;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewGiamTruDinhMuc);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewGiamTruDinhMuc.FocusedRowHandle = -1;
            TList<GiamTruDinhMuc> list = bindingSourceGiamTruDinhMuc.DataSource as TList<GiamTruDinhMuc>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (list.IsValid)
                    {
                        try
                        {
                            bindingSourceGiamTruDinhMuc.EndEdit();
                            DataServices.GiamTruDinhMuc.Save(list);
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            Cursor.Current = Cursors.WaitCursor;
        }
        #endregion

        private void gridViewGiamTruDinhMuc_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewGiamTruDinhMuc, e);
        }

        private void gridViewGiamTruDinhMuc_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "NoiDungGiamTru" || col.FieldName == "MucGiam" || col.FieldName == "DonVi" || col.FieldName == "GhiChu" || col.FieldName == "PhanTramGiamTru")
            {
                gridViewGiamTruDinhMuc.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewGiamTruDinhMuc.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            GiamTruDinhMuc obj = target as GiamTruDinhMuc;
            if (obj != null)
            {
                if (((TList<GiamTruDinhMuc>)bindingSourceGiamTruDinhMuc.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
                {
                    e.Description = string.Format("Mã quy đổi {0} hiện tại đã có.", obj.MaQuanLy);
                    return false;
                }


            }
            return true;
        }

        private void gridViewGiamTruDinhMuc_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {

            GiamTruDinhMuc obj = e.Row as GiamTruDinhMuc;
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

            try
            {
                if (obj.PhanTramGiamTru > 100)
                {
                    XtraMessageBox.Show("Phần trăm định mức không được lớn hơn 100.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                    return;
                }
                else if (obj.PhanTramGiamTruNckh > 100)
                {
                    XtraMessageBox.Show("Phần trăm định mức NCKH không được lớn hơn 100.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                    return;
                }

            }
            catch
            { }
        }
    }
}
