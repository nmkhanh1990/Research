using DevExpress.Common.Grid;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using PMS.BLL;
using PMS.Entities;
using PMS.Services;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmQuyDoiCacKhoiLuongKhac_VHU : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        //public void KhongDuocPhepCapNhat(string value)
        //{
        //    if (value.ToLower() == "true")
        //    {
        //        btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        //        btnQuyDoi.ItemShortcut = DevExpress.XtraBars.BarShortcut.Empty;
        //        btnChot.Enabled = false;
        //        btnHuyChot.Enabled = false;
        //    }
        //    else
        //    {
        //        btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
        //        btnChot.Enabled = true;
        //        btnHuyChot.Enabled = true;
        //    }
        //}
        #endregion

        #region Variable
        TList<CauHinhChung> _listCauHinhChung = DataServices.CauHinhChung.GetAll();
        int kiemtra = 0;
        string _maTruong, strIDChucNang = string.Empty;
        string _groupName = UserInfo.GroupName;
        bool _status, bDuocPhepChot; // = UserInfo.DuocPhepChot;
        VList<ViewKhoa> _listKhoaDonVi;
        #endregion

        public frmQuyDoiCacKhoiLuongKhac_VHU()
        {
            InitializeComponent();

            btnQuyDoi.Enabled = false;
            lblGhiChu.Text = "";

            _maTruong = _listCauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void frmQuyDoiCacKhoiLuongKhac_VHU_Load(object sender, EventArgs e)
        {
            #region Phân quyền chức năng (chốt)
            DataServices.TaiKhoan.KiemTraPhanQuyenControl(UserInfo.UserID, this.GetType().Name, ref bDuocPhepChot);
            layoutCtrItemChot.Visibility = layoutCtrItemHuyChot.Visibility
                = bDuocPhepChot ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                                : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            #endregion

            InitGridVHU();
            layoutControlItem_KhoaDonVi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlItem_LoaiKhoiLuong.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _listCauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _listCauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region _khoaDonVi
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaKhoa", "TenKhoa" }, new string[] { "Mã khoa", "Tên khoa" }, new int[] { 60, 200 });
            cboKhoaDonVi.Properties.ValueMember = "MaKhoa";
            cboKhoaDonVi.Properties.DisplayMember = "TenKhoa";
            cboKhoaDonVi.Properties.NullText = string.Empty;
            #endregion

            #region LoaiKhoiLuong
            AppGridLookupEdit.InitGridLookUp(cboLoaiKhoiLuong, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLoaiKhoiLuong, new string[] { "MaLoaiKhoiLuong", "TenLoaiKhoiLuong" }, new string[] { "Mã loại", "Tên loại" }, new int[] { 50, 250 });
            //AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 400, 650);
            cboLoaiKhoiLuong.Properties.ValueMember = "MaLoaiKhoiLuong";
            cboLoaiKhoiLuong.Properties.DisplayMember = "TenLoaiKhoiLuong";
            cboLoaiKhoiLuong.Properties.NullText = string.Empty;
            #endregion

            InitData();
        }

        #region InitGrid
        void InitGridVHU()
        {
            AppGridView.InitGridView(gridViewKhoiLuong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewKhoiLuong, new string[] { "MaGiangVienQuanLy", "Ho", "Ten", "TenCongViec", "HeSoNhan", "MaLop", "MaNhom", "SoLuong", "HeSoQuyDoi", "TietQuyDoi", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Tên công việc", "Số tín chỉ", "Mã lớp", "Nhóm", "Số lượng", "Hệ số quy đổi", "Tiết quy đổi", "Ghi chú", "Ngày cập nhật", "Người cập nhật" }
                    , new int[] { 90, 115, 55, 200, 90, 100, 100, 90, 90, 90, 250, 99, 99 });
            AppGridView.ShowEditor(gridViewKhoiLuong, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewKhoiLuong, new string[] { "MaGiangVienQuanLy", "Ho", "Ten", "TenCongViec", "HeSoNhan", "MaLop", "MaNhom", "SoLuong", "HeSoQuyDoi", "TietQuyDoi", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewKhoiLuong, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.SummaryField(gridViewKhoiLuong, "MaGiangVienQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuong, "TietQuyDoi", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.ReadOnlyColumn(gridViewKhoiLuong);
        }

        #endregion

        #region InitData()
        void InitData()
        {
            _listKhoaDonVi = DataServices.ViewKhoa.GetAll();
            if (_maTruong.Equals("VHU"))
            {
                foreach (ViewKhoa v in _listKhoaDonVi)
                {
                    if (v.MaKhoa == _groupName)
                    {
                        if (UserInfo.QLNhomQuyen.ToString() != UserInfo.GroupID.ToString())
                        {
                            _status = true;
                            break;
                        }

                    }
                }
            }

            if (_status)
                _listKhoaDonVi = _listKhoaDonVi.FindAll(p => p.MaKhoa == _groupName) as VList<ViewKhoa>;
            else
            {
                _listKhoaDonVi.Insert(0, new ViewKhoa() { ThuTu = -1, MaKhoa = "-1", TenKhoa = "[Tất cả]" });
            }
            cboKhoaDonVi.DataBindings.Clear();
            bindingSourceKhoaDonVi.DataSource = _listKhoaDonVi;
            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaKhoa", true, DataSourceUpdateMode.Never);

            cboLoaiKhoiLuong.DataBindings.Clear();
            bindingSourceLoaiKhoiLuong.DataSource = DataServices.LoaiKhoiLuong.GetAll();
            cboLoaiKhoiLuong.DataBindings.Add("EditValue", bindingSourceLoaiKhoiLuong, "MaLoaiKhoiLuong", true, DataSourceUpdateMode.Never);



            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            LoadDataSource();

        }

        void InitDotThanhToan()
        {
            try
            {
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    #region _dotThanhToan
                    repositoryItemCheckedComboBoxEditDotThanhToan.SelectAllItemCaption = "Tất cả";
                    repositoryItemCheckedComboBoxEditDotThanhToan.TextEditStyle = TextEditStyles.Standard;
                    repositoryItemCheckedComboBoxEditDotThanhToan.Items.Clear();
                    TList<CauHinhChotGio> _listDotThanhToan = DataServices.CauHinhChotGio.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    List<CheckedListBoxItem> _listDot = new List<CheckedListBoxItem>();
                    foreach (CauHinhChotGio v in _listDotThanhToan)
                    {
                        _listDot.Add(new CheckedListBoxItem(v.MaCauHinhChotGio, v.TenQuanLy, CheckState.Unchecked, true));
                    }
                    repositoryItemCheckedComboBoxEditDotThanhToan.Items.AddRange(_listDot.ToArray());
                    repositoryItemCheckedComboBoxEditDotThanhToan.SeparatorChar = ';';
                    #endregion
                }
            }
            catch
            { }
        }

        void LoadDataSource()
        {
            VList<ViewKhoiLuongCacCongViecKhac> LstKLCCVK = new VList<ViewKhoiLuongCacCongViecKhac>();
            InitDotThanhToan();
            if (_maTruong != "VHU")
            {
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    LstKLCCVK = DataServices.ViewKhoiLuongCacCongViecKhac.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    KiemTraChot();
                }
            }
            else
            {
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null && cboLoaiKhoiLuong.EditValue != null)
                {
                    LstKLCCVK = DataServices.ViewKhoiLuongCacCongViecKhac.GetByNamHocHocKyLoaiCongViecKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboLoaiKhoiLuong.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                    KiemTraChot();
                }
            }
            bindingSourceKhoiLuong.DataSource = LstKLCCVK;

        }

        void KiemTraChot()
        {
            DataServices.KhoiLuongCacCongViecKhac.KiemTraChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kiemtra);
            if (kiemtra == 1)
            {
                btnQuyDoi.Enabled = false;
                btnChot.Enabled = false;
                btnHuyChot.Enabled = true;
                lblGhiChu.Text = string.Format("Dữ liệu của năm học {0} - {1} đã bị chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            else
            {
                btnQuyDoi.Enabled = true;
                btnChot.Enabled = true;
                btnHuyChot.Enabled = false;
                lblGhiChu.Text = "";
            }
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnQuyDoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn quy đổi khối lượng năm học {0} - {1}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int kq = 0;
                    DataServices.KhoiLuongCacCongViecKhac.QuyDoi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                    if (kq == 0)
                        XtraMessageBox.Show("Quy đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình quy đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    LoadDataSource();
                }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn năm học, học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamHoc.Focus();
            }
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlKhoiLuong.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            LoadDataSource();
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadDataSource();
            Cursor.Current = Cursors.Default;
        }

        private void btnChot_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null & cboHocKy.EditValue != null)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn chốt khối lượng năm học {0} - {1}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    DataServices.KhoiLuongCacCongViecKhac.Chot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    XtraMessageBox.Show("Chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataSource();
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void btnHuyChot_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null & cboHocKy.EditValue != null)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn huỷ chốt khối lượng năm học {0} - {1}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    using (frmXacNhanLaiMatKhau frm = new frmXacNhanLaiMatKhau(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "HuyCacKhoiLuongKhac_VHU"))
                    {
                        frm.ShowDialog();
                    }
                    LoadDataSource();
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataByID(0);
        }

        private void cboLoaiKhoiLuong_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataByID(1);
        }

        private void LoadDataByID(int ii)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null && cboLoaiKhoiLuong.EditValue != null)
            {
                bindingSourceKhoiLuong.DataSource = DataServices.ViewKhoiLuongCacCongViecKhac.GetByNamHocHocKyLoaiCongViecKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboLoaiKhoiLuong.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                if (ii == 1)//khi chọn loại khối lượng
                {
                    if (_maTruong == "VHU")
                    {
                        if (cboLoaiKhoiLuong.EditValue.ToString() == "1")
                        {
                            AppGridView.UnHideField(gridViewKhoiLuong, new string[] { "HeSoNhan" });
                        }
                        else
                        {
                            AppGridView.HideField(gridViewKhoiLuong, new string[] { "HeSoNhan" });
                        }
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }
    }
}