using DevExpress.Common.Grid;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.Entities;
using PMS.Services;
using PMS.UI.Forms.NghiepVu;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMS.UI.Modules.DanhMucTheoNam
{
    public partial class ucHeSoGiangDayNhieuLopCungHocPhan : DevExpress.XtraEditors.XtraUserControl
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

                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnSaoChep.ItemShortcut = DevExpress.XtraBars.BarShortcut.Empty;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong, _cauHinhHeSoTheoNam;
        VList<ViewHocKy> _listHocKy;
        #endregion

        public ucHeSoGiangDayNhieuLopCungHocPhan()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucHeSoGiangDayNhieuLopCungHocPhan_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewHeSoGiangDayNhieuLopCungHocPhan, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoGiangDayNhieuLopCungHocPhan, new string[] { "TuKhoan", "DenKhoan", "HeSo" },
                        new string[] { "Từ số lớp", "Đến số lớp", "Hệ số" },
                        new int[] { 100, 100, 100 });
            AppGridView.ShowEditor(gridViewHeSoGiangDayNhieuLopCungHocPhan, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewHeSoGiangDayNhieuLopCungHocPhan, new string[] { "TuKhoan", "DenKhoan", "HeSo" }, DevExpress.Utils.HorzAlignment.Center);

            //if (_cauHinhHeSoTheoNam.ToLower() == "true")
            //{
            //    layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            //    cboHocKy.EditValue = "";
            //}
            #endregion

            #region NamHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region HocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            InitData();
        }

        #region InitData
        private void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            
            if(cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                string hocKy = checkEditTheoHocKy.Checked ? cboHocKy.EditValue.ToString() : null;
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                bindingSourceHeSoGiangDayNhieuLopCungHocPhan.DataSource = DataServices.HeSoGiangDayNhieuLopCungHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), hocKy);
            }
        }

        private void LoadGridView()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                string hocKy = checkEditTheoHocKy.Checked ? cboHocKy.EditValue.ToString() : null;
                bindingSourceHeSoGiangDayNhieuLopCungHocPhan.DataSource = DataServices.HeSoGiangDayNhieuLopCungHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), hocKy);
            }
        }
        #endregion

        private void btnLamtuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoGiangDayNhieuLopCungHocPhan);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewHeSoGiangDayNhieuLopCungHocPhan.FocusedRowHandle = -1;
            TList<HeSoGiangDayNhieuLopCungHocPhan> list = bindingSourceHeSoGiangDayNhieuLopCungHocPhan.DataSource as TList<HeSoGiangDayNhieuLopCungHocPhan>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            foreach (HeSoGiangDayNhieuLopCungHocPhan hs in list)
                            {
                                hs.NamHoc = cboNamHoc.EditValue.ToString();
                                if (checkEditTheoHocKy.Checked)
                                    hs.HocKy = cboHocKy.EditValue.ToString();
                                else
                                    hs.HocKy = null;
                            }
                            bindingSourceHeSoGiangDayNhieuLopCungHocPhan.EndEdit();
                            DataServices.HeSoGiangDayNhieuLopCungHocPhan.Save(list);
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

        private void gridViewHeSoGiangDayNhieuLopCungHocPhan_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoGiangDayNhieuLopCungHocPhan, e);
        }

        private void gridViewHeSoGiangDayNhieuLopCungHocPhan_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewHeSoGiangDayNhieuLopCungHocPhan, e);
        }

        private void gridViewHeSoGiangDayNhieuLopCungHocPhan_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            //HeSoGiangDayNhieuLopCungHocPhan obj = e.Row as HeSoGiangDayNhieuLopCungHocPhan;
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

        //private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        //{
        //    HeSoGiangDayNhieuLopCungHocPhan obj = target as HeSoGiangDayNhieuLopCungHocPhan;
        //    if (obj != null)
        //    {
        //        if (((TList<HeSoGiangDayNhieuLopCungHocPhan>)bindingSourceHeSoGiangDayNhieuLopCungHocPhan.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
        //        {
        //            e.Description = string.Format("Mã quy đổi {0} hiện tại đã có.", obj.MaQuanLy);
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        private void gridViewHeSoGiangDayNhieuLopCungHocPhan_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    sf.ShowDialog();
                    if (sf.FileName != "")
                    {
                        gridControlHeSoGiangDayNhieuLopCungHocPhan.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
            Cursor.Current = Cursors.Default;
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void gridViewHeSoGiangDayNhieuLopCungHocPhan_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaQuanLy" || col.FieldName == "MaBacDaoTao" || col.FieldName == "MaNhomMonHoc" || col.FieldName == "TuKhoan" || col.FieldName == "DenKhoan" || col.FieldName == "HeSo" || col.FieldName == "NgayBdApDung" || col.FieldName == "NgayKtApDung")
            {
                gridViewHeSoGiangDayNhieuLopCungHocPhan.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
                gridViewHeSoGiangDayNhieuLopCungHocPhan.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void checkEditTheoHocKy_CheckedChanged(object sender, EventArgs e)
        {
            layoutControlItemHocKy.Enabled = checkEditTheoHocKy.Checked;
            //if (checkEditTheoHocKy.Checked)
            //{
            //    layoutControlItemHocKy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            //}
            //else
            //{
            //    layoutControlItemHocKy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            //}
            LoadGridView();
        }

        private void btnSapChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepHeSoGiangDayNhieuLopCungHocPhan"))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepHeSoGiangDayNhieuLopCungHocPhan"))
                {
                    frm.ShowDialog();
                }
            }
            InitData();
        }
    }
}
