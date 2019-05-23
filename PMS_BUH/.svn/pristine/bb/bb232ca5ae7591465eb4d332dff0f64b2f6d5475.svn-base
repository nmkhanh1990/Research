using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.UI.Forms.NghiepVu;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucGiangVienDangKyHinhThucGiangDay : DevExpress.XtraEditors.XtraUserControl
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
        VList<ViewGiangVien> _listGiangVien = new VList<ViewGiangVien>();
        string _maTruong, _cauHinhHeSoTheoNam;
        #endregion

        public ucGiangVienDangKyHinhThucGiangDay()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
            if (_maTruong == "TCB")
            {
                layoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }

        private void ucGiangVienDangKyHinhThucGiangDay_Load(object sender, EventArgs e)
        {
            #region Init Gridview
            switch (_maTruong)
            {
                default:    //UTE
                    InitRemaining();
                    break;
            }
            #endregion 
           
            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen" }, new string[] { "Mã giảng viên", "Họ tên" }, "MaGiangVien", "HoTen", 500, 500);
            #endregion

            #region Hinh thuc dang ky giang day
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHinhThuc, new string[] { "TenHinhThucDaoTao" }, new string[] { "Tên hình thức" }, "MaHinhThucDaoTao", "TenHinhThucDaoTao", 300, 200);
            #endregion

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }

            InitData();
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewGiangVienDangKyHinhThuc, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewGiangVienDangKyHinhThuc, new string[] { "MaGiangVien", "MaHinhThucDaoTao", "GhiChu" }
                    , new string[] { "Mã giảng viên", "Mã Hình thức đăng ký", "Ghi chú" }
                    , new int[] { 170, 230, 100 });
            AppGridView.ShowEditor(gridViewGiangVienDangKyHinhThuc, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewGiangVienDangKyHinhThuc, new string[] { "MaGiangVien", "MaHinhThucDaoTao", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewGiangVienDangKyHinhThuc, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
            //gridViewLietKeKhoiLuong.Columns["PhanLoai"].GroupIndex = 0;
            AppGridView.RegisterControlField(gridViewGiangVienDangKyHinhThuc, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewGiangVienDangKyHinhThuc, "MaHinhThucDaoTao", repositoryItemGridLookUpEditHinhThuc);
        }

        #region InitData
        void InitData()
        {
            _listGiangVien = DataServices.ViewGiangVien.GetAll();
            bindingSourceGiangVien.DataSource = _listGiangVien;
            bindingSourceHinhThuc.DataSource = DataServices.HinhThucDaoTao.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceGiangVienDangKyHinhThuc.DataSource = DataServices.GiangVienDangKyHinhThucGiangDay.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
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
            gridViewGiangVienDangKyHinhThuc.DeleteSelectedRows();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewGiangVienDangKyHinhThuc.FocusedRowHandle = -1;
            TList<GiangVienDangKyHinhThucGiangDay> list = bindingSourceGiangVienDangKyHinhThuc.DataSource as TList<GiangVienDangKyHinhThucGiangDay>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            foreach (GiangVienDangKyHinhThucGiangDay gv in list)
                            {
                                gv.NamHoc = cboNamHoc.EditValue.ToString();
                                gv.HocKy = cboHocKy.EditValue.ToString();
                            }
                            bindingSourceGiangVienDangKyHinhThuc.EndEdit();
                            DataServices.GiangVienDangKyHinhThucGiangDay.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as Core.AppModule, new object[] { gridViewGiangVienDangKyHinhThuc, barManager1, layoutControl1 });
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
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceGiangVienDangKyHinhThuc.DataSource = DataServices.GiangVienDangKyHinhThucGiangDay.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceGiangVienDangKyHinhThuc.DataSource = DataServices.GiangVienDangKyHinhThucGiangDay.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }
        #endregion

        private void gridViewDonGiaNgoaiQuyChe_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //GridColumn col = e.Column;
            //int pos = e.RowHandle;
            //if (col.FieldName == "MaGiangVien")
            //{
            //    ViewDonGiaNgoaiQuyChe v = (ViewDonGiaNgoaiQuyChe)gridViewGiangVienDangKyHinhThuc.GetRow(pos);
            //    string _hoTen = _listGiangVien.Find(p => p.MaGiangVien == v.MaGiangVien).HoTen;
            //    gridViewGiangVienDangKyHinhThuc.SetRowCellValue(pos, "HoTen", _hoTen);
            //    gridViewGiangVienDangKyHinhThuc.SetRowCellValue(pos, "NgayCapNhat", DateTime.Now);
            //}
            //if (col.FieldName == "DonGiaDaiTra" || col.FieldName == "DonGiaClc" || col.FieldName == "GhiChu")
            //{
            //    ViewDonGiaNgoaiQuyChe v = (ViewDonGiaNgoaiQuyChe)gridViewGiangVienDangKyHinhThuc.GetRow(pos);
            //    gridViewGiangVienDangKyHinhThuc.SetRowCellValue(pos, "NgayCapNhat", DateTime.Now);
            //}
        }

        private void gridViewDonGiaNgoaiQuyChe_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewGiangVienDangKyHinhThuc, e);
        }

        private void gridViewDonGiaNgoaiQuyChe_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        string IsNull(object o)
        { 
            if(o == null)
                return "";
            else return o.ToString();
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepDonGiaNgoaiQuyChe"))
            //{
            //    frm.ShowDialog();
            //}
            //InitData();

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepDinhMucGioChuan"))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepDinhMucGioChuan"))
                {
                    frm.ShowDialog();
                }
            }
            InitData();
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
                    gridControlGiangVienDangKyHinhThuc.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }
    }
}
