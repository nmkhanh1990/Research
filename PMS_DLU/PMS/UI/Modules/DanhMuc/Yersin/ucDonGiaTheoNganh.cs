using DevExpress.Common.Grid;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.Entities;
using PMS.Entities.Validation;
using PMS.Services;
using PMS.UI.Forms.NghiepVu;
using System;
using System.Windows.Forms;

namespace PMS.UI.Modules.DanhMuc.Yersin
{
    public partial class ucDonGiaTheoNganh : DevExpress.XtraEditors.XtraUserControl
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
        string _maTruong, _cauHinhHeSoTheoNam;
        #endregion

        public ucDonGiaTheoNganh()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
            if (_maTruong != "USSH")
            {
                layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private void InidGridview()
        {
            AppGridView.InitGridView(gridViewDonGia, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewDonGia, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewDonGia, new string[] { "MaLoaiGiangVien", "MaHocHam", "MaHocVi", "DonGiaCh","DonGiaTgkc","DonGiaTgc", "DonGiaHocPhan", "DonGiaLt", "DonGiaTh", "MaDonGiaNhomNganh" }
                        , new string[] { "Loại giảng viên", "Học hàm", "Học vị", "Đơn giá ch","Đơn giá tgkc","Đơn giá tgc", "Đơn giá HP", "Đơn giá LT", "Đơn giá TH", "Nhóm ngành"}
                        , new int[] { 150, 150, 150, 100, 100, 100, 100, 100, 100, 200 });
            AppGridView.AlignHeader(gridViewDonGia, new string[] { "MaLoaiGiangVien", "MaHocHam", "MaHocVi", "DonGiaCh", "DonGiaTgkc", "DonGiaTgc", "DonGiaHocPhan", "DonGiaLt", "DonGiaTh", "MaDonGiaNhomNganh" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewDonGia, "MaLoaiGiangVien", repositoryItemGridLookUpEditLoaiGiangVien);
            AppGridView.RegisterControlField(gridViewDonGia, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewDonGia, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.RegisterControlField(gridViewDonGia, "DonGiaCh", repositoryItemSpinEditDonGiaCH);
            AppGridView.RegisterControlField(gridViewDonGia, "DonGiaHocPhan", repositoryItemSpinEditDonGiaHocPhan);
            AppGridView.RegisterControlField(gridViewDonGia, "DonGiaLt", repositoryItemSpinEditDonGiaLT);
            AppGridView.RegisterControlField(gridViewDonGia, "DonGiaTh", repositoryItemSpinEditDonGiaTH);
            AppGridView.RegisterControlField(gridViewDonGia, "MaDonGiaNhomNganh", repositoryItemGridLookUpEdit_MaDonGiaTheoNganh);
            AppGridView.FormatDataField(gridViewDonGia, new string[] { "DonGiaCh", "DonGiaTgkc", "DonGiaTgc", "DonGiaHocPhan", "DonGiaLt", "DonGiaTh" }, DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.HideField(gridViewDonGia, new string[] { "MaLoaiGiangVien" });

        }

        private void ucDonGia_Load(object sender, EventArgs e)
        {
            #region Init GridView
            InidGridview();
            #endregion

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region LoaiGiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLoaiGiangVien, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLoaiGiangVien, new string[] { "MaQuanLy", "TenLoaiGiangVien" }, new string[] { "Mã loại giảng viên", "Tên loại giảng viên" }, new int[] { 150, 200 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditLoaiGiangVien, 350, 400);
            repositoryItemGridLookUpEditLoaiGiangVien.ValueMember = "MaLoaiGiangVien";
            repositoryItemGridLookUpEditLoaiGiangVien.DisplayMember = "TenLoaiGiangVien";
            repositoryItemGridLookUpEditLoaiGiangVien.NullText = string.Empty;
            #endregion

            #region HocHam
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHocHam, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHocHam, new string[] { "MaQuanLy", "TenHocHam" }, new string[] { "Mã học hàm", "Tên học hàm" }, new int[] { 100, 200 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditHocHam, 300, 400);
            repositoryItemGridLookUpEditHocHam.ValueMember = "MaHocHam";
            repositoryItemGridLookUpEditHocHam.DisplayMember = "TenHocHam";
            repositoryItemGridLookUpEditHocHam.NullText = string.Empty;
            #endregion

            #region HocVi
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHocVi, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHocVi, new string[] { "MaQuanLy", "TenHocVi" }, new string[] { "Mã học vị", "Tên học vị" }, new int[] { 100, 200 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditHocVi, 300, 400);
            repositoryItemGridLookUpEditHocVi.ValueMember = "MaHocVi";
            repositoryItemGridLookUpEditHocVi.DisplayMember = "TenHocVi";
            repositoryItemGridLookUpEditHocVi.NullText = string.Empty;
            #endregion

           
           
            #region NgonNguGiangDay
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEdit_MaDonGiaTheoNganh, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEdit_MaDonGiaTheoNganh, new string[] { "MaQuanLy", "GhiChu" }, new string[] { "Mã nhóm ngành", "Tên nhóm ngành" }, new int[] { 150, 200 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEdit_MaDonGiaTheoNganh, 350, 400);
            repositoryItemGridLookUpEdit_MaDonGiaTheoNganh.ValueMember = "MaDonGiaNhomNganh";
            repositoryItemGridLookUpEdit_MaDonGiaTheoNganh.DisplayMember = "GhiChu";
            repositoryItemGridLookUpEdit_MaDonGiaTheoNganh.NullText = string.Empty;
            #endregion
         
            InitData();
        }

        
        #region InitData
        void InitData()
        {
            try
            {
                bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
                if (cboNamHoc.EditValue != null)
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());               
                bindingSourceMaDonGiaTheoNganh.DataSource = DataServices.DonGiaNhomNganh.GetAll();            
                bindingSourceLoaiGiangVien.DataSource = DataServices.LoaiGiangVien.GetAll();
                bindingSourceHocHam.DataSource = DataServices.HocHam.GetAll();
                bindingSourceHocVi.DataSource = DataServices.HocVi.GetAll();
                bindingSourceDonGiaTheoNganh.DataSource = DataServices.DonGiaTheoNganh.GetAll();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewDonGia);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewDonGia.FocusedRowHandle = -1;
            TList<DonGiaTheoNganh> list = bindingSourceDonGiaTheoNganh.DataSource as TList<DonGiaTheoNganh>;
            if (list != null)
            {                
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceDonGiaTheoNganh.EndEdit();
                            DataServices.DonGiaTheoNganh.Save(list);
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
        #endregion

        private TList<DonGiaTheoNganh> LstDonGiaTheoNganh(TList<DonGiaTheoNganh> LstValues)
        {
            TList<DonGiaTheoNganh> Lst = new TList<DonGiaTheoNganh>();
            foreach (DonGiaTheoNganh item in LstValues)
            {
                DonGiaTheoNganh items = item;
                items.MaLoaiGiangVien = item.MaLoaiGiangVien;
                items.MaHocHam = item.MaHocHam;
                items.MaHocVi = item.MaHocVi;
                items.DonGiaCh = item.DonGiaCh;
                items.DonGiaTgkc = item.DonGiaTgkc;
                item.DonGiaTgc = item.DonGiaTgc;
                items.DonGiaHocPhan = item.DonGiaHocPhan;
                items.DonGiaLt = item.DonGiaLt;
                items.DonGiaTh = item.DonGiaTh;
                items.MaDonGiaNhomNganh = item.MaDonGiaNhomNganh;
                items.NgayCapNhat = DateTime.Now;
                items.NguoiCapNhat = UserInfo.UserName;
                Lst.Add(items);
            }
            return Lst;
        }

        #region Event Grid
        private void gridViewDonGia_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewDonGia, e);
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            DonGia obj = target as DonGia;
            if (obj != null)
            {
                if (((TList<DonGia>)bindingSourceDonGiaTheoNganh.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
                {
                    e.Description = string.Format("Mã đơn giá {0} hiện tại đã có.", obj.MaQuanLy);
                    return false;
                }               
            }
            return true;
        }

        private void gridViewDonGia_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DonGia obj = e.Row as DonGia;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckDuplicate, "MaQuanLy, MaLoaiGiangVien, MaHocHam, MaHocVi");
                if (obj.IsValid)
                    e.Valid = true;
                else
                {
                    XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                }
            }
        }

        private void gridViewDonGia_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }
        #endregion

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
                        gridControlDonGia.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void gridViewDonGia_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaQuanLy" || col.FieldName == "MaLoaiGiangVien" || col.FieldName == "MaHocHam" || col.FieldName == "MaHocVi" || col.FieldName == "DonGia" || col.FieldName == "HeSoQuyDoiChatLuong")
            {
                int pos = e.RowHandle;
                gridViewDonGia.SetRowCellValue(pos, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewDonGia.SetRowCellValue(pos, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceDonGiaTheoNganh.DataSource = DataServices.DonGia.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceDonGiaTheoNganh.DataSource = DataServices.DonGia.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepDonGia"))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepDonGia"))
                {
                    frm.ShowDialog();
                }
            }
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceDonGiaTheoNganh.DataSource = DataServices.DonGia.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }
    }
}
