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

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucPscCoSo : XtraUserControl
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
        public ucPscCoSo()
        {
            InitializeComponent();
            _maTruong = _listCauHinh.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucPscCoSo_Load(object sender, EventArgs e)
        {
            #region Init GridView PscCoSo
            switch (_maTruong)
            { 
                case "CDGTVT":
                    InitGridCDGTVT();
                    break;
                case "VHU":
                    InitGridVHU();
                    break;
                case "LAW":
                    InitGridVHU();
                    break;
                case "IUH":
                    InitGridIUH();
                    break;
                case "HBU":
                    InitGridVHU();
                    break;
                case "DLU":
                    InitGridVHU();
                    break;
                default:
                    InitRemaining();
                    break;
            }
            
            #endregion

            #region Init DataSource
            //bindingSourcePscCoSo.DataSource = DataServices.PscPscCoSo.GetAll();
            #endregion
        }

        #region InitGridView
        void InitGridCDGTVT()
        {
            AppGridView.InitGridView(gridViewPscCoSo, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewPscCoSo, new string[] { "ThuTu", "MaQuanLy", "TenPscCoSo", "CongDonKiemNhiem" },
                new string[] { "STT", "Mã chức vụ", "Tên chức vụ", "Kiêm nhiệm" },
                new int[] { 70, 100, 400, 90 });
            AppGridView.AlignHeader(gridViewPscCoSo, new string[] { "ThuTu", "MaQuanLy", "TenPscCoSo", "CongDonKiemNhiem" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ShowEditor(gridViewPscCoSo, NewItemRowPosition.Top);
        }

        //VHU - LAW giống nhau
        void InitGridVHU()
        {
            AppGridView.InitGridView(gridViewPscCoSo, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewPscCoSo, new string[] { "ThuTu", "MaQuanLy", "TenPscCoSo","TinhTrang" },
                new string[] { "STT", "Mã chức vụ", "Tên chức vụ","Không dùng" },
                new int[] { 70, 100, 400,100 });
            AppGridView.AlignHeader(gridViewPscCoSo, new string[] { "ThuTu", "MaQuanLy", "TenPscCoSo", "TinhTrang" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewPscCoSo, new string[] { "ThuTu" });
            AppGridView.ShowEditor(gridViewPscCoSo, NewItemRowPosition.Top);
        }

        void InitGridIUH()
        {
            AppGridView.InitGridView(gridViewPscCoSo, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewPscCoSo, new string[] { "ThuTu", "MaQuanLy", "TenPscCoSo", "CongDonKiemNhiem" },
                new string[] { "STT", "Mã chức vụ", "Tên chức vụ", "Có định mức coi thi" },
                new int[] { 70, 100, 400, 150 });
            AppGridView.ShowEditor(gridViewPscCoSo, NewItemRowPosition.Top);
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewPscCoSo, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewPscCoSo, new string[] { "ThuTu", "MaQuanLy", "TenPscCoSo", "SoTiet", "PhanTramGio", "NguongTiet" },
                new string[] { "STT", "Mã chức vụ", "Tên chức vụ", "Số tiết định mức", "% Giờ", "Ngưỡng tiết" },
                new int[] { 70, 100, 400, 120, 70, 90 });
            AppGridView.RegisterControlField(gridViewPscCoSo, "SoTiet", repositoryItemSpinEditSoGio);
            AppGridView.RegisterControlField(gridViewPscCoSo, "PhanTramGio", repositoryItemSpinEditPhanTramGio);
            AppGridView.RegisterControlField(gridViewPscCoSo, "NguongTiet", repositoryItemSpinEditNguongTiet);
            AppGridView.ShowEditor(gridViewPscCoSo, NewItemRowPosition.Top);
            if (_maTruong == "UEL" || _maTruong == "IUH" || _maTruong == "CDGTVT")
                AppGridView.HideField(gridViewPscCoSo, new string[] { "SoTiet", "PhanTramGio", "NguongTiet" });
            if (_maTruong == "CTIM")
                AppGridView.HideField(gridViewPscCoSo, new string[] { "SoTiet", "NguongTiet" });
        }
        #endregion

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PscCoSo obj = gridViewPscCoSo.GetFocusedRow() as PscCoSo;
            if (obj != null)
            {
                if (obj.EntityState == EntityState.Changed)
                    obj.CancelChanges();
                else
                    RestoreDeletedItems();
            }
            else
                RestoreDeletedItems();            
            gridViewPscCoSo.RefreshData();
        }

        private void RestoreDeletedItems()
        {
            TList<PscCoSo> list = bindingSourcePscCoSo.DataSource as TList<PscCoSo>;
            if (list != null)
            {
                if (list.DeletedItems.Count > 0)
                {
                    foreach (PscCoSo c in list.DeletedItems)
                    {
                        c.EntityState = EntityState.Changed;
                        list.Add(c);
                        list.DeletedItems.Remove(c);
                        break;
                    }
                }
            }
        }

        private void gridViewPscCoSo_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewPscCoSo, e);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewPscCoSo.FocusedRowHandle = -1;
            TList<PscCoSo> list = bindingSourcePscCoSo.DataSource as TList<PscCoSo>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourcePscCoSo.EndEdit();
                            DataServices.PscCoSo.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewPscCoSo, barManager1, layoutControl1 });
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
            bindingSourcePscCoSo.DataSource = DataServices.PscCoSo.GetAll();
            Cursor.Current = Cursors.Default;
        }

        private void gridViewPscCoSo_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewPscCoSo, e);
        }

     
        private void gridViewPscCoSo_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            //PscCoSo obj = e.Row as PscCoSo;
            //if (obj != null)
            //{
            //    obj.AddValidationRuleHandler(RuleCheckDuplicate, "MaQuanLy");
            //    if (obj.IsValid)
            //        e.Valid = true;
            //    else
            //    {
            //        XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        e.Valid = false;
            //    }
            //}
        }

        private void gridViewPscCoSo_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewPscCoSo);
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
                    gridControlPscCoSo.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }
    }
}