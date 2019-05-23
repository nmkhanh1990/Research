using DevExpress.Common.Grid;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Entities.Validation;
using PMS.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucDonGiaTheoLopHocPhan : DevExpress.XtraEditors.XtraUserControl
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

        public ucDonGiaTheoLopHocPhan()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucDonGiaTheoLopHocPhan_Load(object sender, EventArgs e)
        {
            #region Init GridView
            string[] arrStr_showField = { "MaLopHocPhan", "DonGia" };
            string[] arrStr_showFieldName = { "Lớp học phần", "Đơn giá" };
            int[] arrStr_showFieldWidth = { 200, 100 };

            AppGridView.InitGridView(gridViewDonGiaLopHocPhan, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewDonGiaLopHocPhan, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewDonGiaLopHocPhan, arrStr_showField, arrStr_showFieldName, arrStr_showFieldWidth);
            AppGridView.AlignHeader(gridViewDonGiaLopHocPhan, arrStr_showField, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewDonGiaLopHocPhan, "MaLopHocPhan", repoItemGLE_LopHocPhan);
            AppGridView.FormatDataField(gridViewDonGiaLopHocPhan, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            #endregion

            #region NamHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Học kỳ
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region Lớp học phần
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp (repoItemGLE_LopHocPhan, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField (
                repoItemGLE_LopHocPhan, 
                new string[] { "MaLopHocPhan", "TenMonHoc" }, 
                new string[] { "Lớp học phần", "Môn học" }, 
                new int[] { 150, 300 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repoItemGLE_LopHocPhan, 500, 300); 
            repoItemGLE_LopHocPhan.ValueMember = "MaLopHocPhan";
            repoItemGLE_LopHocPhan.DisplayMember = "MaLopHocPhan";
            repoItemGLE_LopHocPhan.NullText = string.Empty;
            #endregion

            //#region Bậc đào tạo
            //AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repoItemGLE_LoaiHinhDaoTao, TextEditStyles.Standard);
            //AppRepositoryItemGridLookUpEdit.ShowField (
            //    repoItemGLE_LoaiHinhDaoTao, 
            //    new string[] { "TenLoaiHinh" }, 
            //    new string[] { "Tên loại hình" }, 
            //    new int[] { 200 });
            //AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repoItemGLE_LoaiHinhDaoTao, 300, 250);
            //repoItemGLE_LoaiHinhDaoTao.ValueMember = "MaLoaiHinh";
            //repoItemGLE_LoaiHinhDaoTao.DisplayMember = "TenLoaiHinh";
            //repoItemGLE_LoaiHinhDaoTao.NullText = string.Empty;
            //#endregion
            
            InitData();
        }

        void InitData()
        {
            //InitPhanLoaiGiangVien();
            bindingSourceLoaiHinhDaoTao.DataSource = DataServices.ViewLoaiHinhDaoTao.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if(cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceLopHocPhan.DataSource = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                bindingSourceDonGiaLopHocPhan.DataSource = DataServices.DonGiaTheoLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewDonGiaLopHocPhan);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewDonGiaLopHocPhan.FocusedRowHandle = -1;
            TList<DonGiaTheoLopHocPhan> list = bindingSourceDonGiaLopHocPhan.DataSource as TList<DonGiaTheoLopHocPhan>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceDonGiaLopHocPhan.EndEdit();
                            DataServices.DonGiaTheoLopHocPhan.Save(list);
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Đã xảy ra lỗi trong quá trình lưu các thay đổi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    if (sf.FileName != "")
                    {
                        gridControlDonGiaLopHocPhan.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void gridViewDonGiaClc_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gridViewDonGiaClc_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewDonGiaLopHocPhan, e);
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            DonGiaTheoLopHocPhan obj = target as DonGiaTheoLopHocPhan;
            if (obj != null)
            {
                if (((TList<DonGiaTheoLopHocPhan>)bindingSourceDonGiaLopHocPhan.DataSource)
                    .FindAll(p => p.MaLopHocPhan == obj.MaLopHocPhan).Count > 1)
                {
                    e.Description = "Lớp học phần hiện tại đã có.";
                    return false;
                }
            }
            return true;
        }

        private void gridViewDonGiaClc_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DonGiaTheoLopHocPhan obj = e.Row as DonGiaTheoLopHocPhan;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckDuplicate, "MaLopHocPhan");
                if (obj.IsValid)
                    e.Valid = true;
                else
                {
                    XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                }
            }
        }

        private void gridViewDonGiaLopHocPhan_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "MaLopHocPhan")
            {
                VList<ViewLopHocPhan> vlhp = bindingSourceLopHocPhan.DataSource as VList<ViewLopHocPhan>;
                string ten_mon_hoc = vlhp.Find(lhp => lhp.MaLopHocPhan == (string)e.Value).TenMonHoc;
                gridViewDonGiaLopHocPhan.SetRowCellValue(e.RowHandle, "TenMonHoc", ten_mon_hoc);
            }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceLopHocPhan.DataSource = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                bindingSourceDonGiaLopHocPhan.DataSource = DataServices.DonGiaTheoLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceLopHocPhan.DataSource = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                bindingSourceDonGiaLopHocPhan.DataSource = DataServices.DonGiaTheoLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }
    }
}
