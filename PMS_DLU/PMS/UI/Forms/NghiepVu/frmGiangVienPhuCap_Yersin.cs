using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using PMS.Entities;
using DevExpress.XtraGrid.Columns;
using PMS.Core;
using ExcelLibrary;
using PMS.BLL;
using DevExpress.XtraGrid.Views.Grid;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmGiangVienPhuCap_Yersin : DevExpress.XtraEditors.XtraForm
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
        TList<CauHinhChung> cauHinh = DataServices.CauHinhChung.GetAll();
        string _maTruong, _tenTruong;
        private string _groupName = UserInfo.GroupName;
        VList<ViewGiangVien> _listGiangVien;
        VList<ViewKhoa> _listKhoaDonVi;
        DataTable tblCoVanHocTap = new DataTable();
        bool _status;

        #endregion

        #region Event Form
        public frmGiangVienPhuCap_Yersin()
        {
            InitializeComponent();
            _maTruong = cauHinh.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _tenTruong = cauHinh.Find(p => p.TenCauHinh == "Tên trường").GiaTri;

        }

        private void frmCoVanHocTap2_Load(object sender, EventArgs e)
        {

            #region InitGridView
            InitRemaining();
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            #endregion

            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            #endregion

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen" },
                    new string[] { "Mã giảng viên", "Họ tên" });
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "HoTen";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            #region LopHocPhan
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEdit_LopHocPhan, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEdit_LopHocPhan, new string[] { "MaLopHocPhan", "MaMonHoc", "TenMonHoc" },
                    new string[] { "Mã lớp học phần", "Mã môn học", "Tên môn học" });
            repositoryItemGridLookUpEdit_LopHocPhan.DisplayMember = "TenMonHoc";
            repositoryItemGridLookUpEdit_LopHocPhan.ValueMember = "MaLopHocPhan";
            repositoryItemGridLookUpEdit_LopHocPhan.NullText = string.Empty;
            #endregion

            #region Nhóm
            AppGridLookupEdit.InitGridLookUp(comboBoxEdit_Khoa, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(comboBoxEdit_Khoa, new string[] { "MaKhoa", "TenKhoa" }, new string[] { "Mã khoa - Đơn vị", "Tên khoa - Đơn vị" }, new int[] { 110, 250 });
            comboBoxEdit_Khoa.Properties.ValueMember = "MaKhoa";
            comboBoxEdit_Khoa.Properties.DisplayMember = "TenKhoa";
            comboBoxEdit_Khoa.Properties.NullText = string.Empty;
            #endregion

            #region Init nam hoc - hoc ky hien tai
            cboNamHoc.EditValue = cauHinh.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            cboHocKy.EditValue = cauHinh.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region Init Data
            InitData();
            #endregion
        }
        #endregion


        #region Init Remaining
        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewCoVan, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewCoVan, new string[] { "MaGiangVien", "NamHoc", "HocKy", "SoDot", "SoNgay", "NgayCapNhat", "NguoiCapNhat", "MaPhuCap", "MaLopHocPhan", "GhiChu", "TinhTrang" },
                                    new string[] { "Họ tên giảng viên", "Năm học", "Học kỳ", "SL đợt", "SL ngày", "Ngày cập nhật", "Người cập nhật", "Tiền phụ cấp", "Tên môn học", "Ghi chú", "Xác nhận" },
                                    new int[] { 180, 80, 150, 80, 120, 100, 120, 260, 200, 150, 100 });
            AppGridView.ShowEditor(gridViewCoVan, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewCoVan, new string[] { "MaGiangVien", "NamHoc", "HocKy", "SoDot", "SoNgay", "NgayCapNhat", "NguoiCapNhat", "MaPhuCap", "MaLopHocPhan", "GhiChu", "TinhTrang" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewCoVan, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.HideField(gridViewCoVan, new string[] { "NamHoc", "HocKy", "NgayCapNhat", "NguoiCapNhat", "TinhTrang" });
            AppGridView.RegisterControlField(gridViewCoVan, "MaPhuCap", repositoryItemCheckedComboBoxEditDonGiaPhuCap);
            AppGridView.RegisterControlField(gridViewCoVan, "MaLopHocPhan", repositoryItemGridLookUpEdit_LopHocPhan);
            AppGridView.ReadOnlyColumn(gridViewCoVan, new string[] { "TinhTrang" });
        }
        #endregion


        #region InitData
        void InitData()
        {

            #region Năm học_Học kỳ
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            #endregion

            #region BindingData
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

            comboBoxEdit_Khoa.DataBindings.Clear();
            bindingSourceKhoa.DataSource = _listKhoaDonVi;
            comboBoxEdit_Khoa.DataBindings.Add("EditValue", bindingSourceKhoa, "MaKhoa", true, DataSourceUpdateMode.Never);



            _listGiangVien = DataServices.ViewGiangVien.GetByMaDonVi(comboBoxEdit_Khoa.EditValue.ToString());
            bindingSourceGiangVien.DataSource = _listGiangVien;
            InitDonGiaPhuCap();
            InitLopHocPhan();
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceGiangVienPhuCap.DataSource = DataServices.GiangVienPhucCap.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), string.Empty);

            #endregion
        }

        void InitDonGiaPhuCap()
        {
            #region Init GioGiang
            repositoryItemCheckedComboBoxEditDonGiaPhuCap.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditDonGiaPhuCap.TextEditStyle = TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditDonGiaPhuCap.Items.Clear();
            TList<DonGiaPhuCap> _TList = new TList<DonGiaPhuCap>();
            _TList = DataServices.DonGiaPhuCap.GetAll();
            List<CheckedListBoxItem> _listDM = new List<CheckedListBoxItem>();
            foreach (DonGiaPhuCap v in _TList)
            {
                _listDM.Add(new CheckedListBoxItem(v.MaQuanLy, v.TenPhuCap + " " + v.DonGia.ToString(), CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboBoxEditDonGiaPhuCap.Items.AddRange(_listDM.ToArray());
            repositoryItemCheckedComboBoxEditDonGiaPhuCap.SeparatorChar = ';';
            #endregion
        }

        void InitLopHocPhan()
        {
            bindingSource_LopHocPhan.DataSource = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }



        #endregion

        #region Event Button
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkThanhToan())
            {
                XtraMessageBox.Show("Giảng viên hiện tại đã thanh toán không thể xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
                AppGridView.DeleteSelectedRows(gridViewCoVan);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewCoVan.FocusedRowHandle = -1;
            TList<GiangVienPhucCap> list = bindingSourceGiangVienPhuCap.DataSource as TList<GiangVienPhucCap>;
            if (list != null)
            {

                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceGiangVienPhuCap.EndEdit();
                            DataServices.GiangVienPhucCap.Save(list);
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

        private TList<GiangVienPhucCap> SetValuesList(TList<GiangVienPhucCap> listValue)
        {
            TList<GiangVienPhucCap> ValueList = new TList<GiangVienPhucCap>();
            foreach (GiangVienPhucCap item in listValue)
            {
                GiangVienPhucCap items = new GiangVienPhucCap();
                items.MaQuanLy = item.MaQuanLy;
                items.MaGiangVien = item.MaGiangVien;
                items.SoDot = item.SoDot;
                items.SoNgay = item.SoNgay;
                items.NgayCapNhat = DateTime.Now;
                items.NguoiCapNhat = UserInfo.UserName;
                items.TinhTrang = item.TinhTrang;
                items.GhiChu = item.GhiChu;
                items.MaPhuCap = item.MaPhuCap;
                ValueList.Add(items);
            }
            return ValueList;
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepCoVanHocTap");
            frm.ShowDialog();
        }

        private void btn_Nhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmImportCoVanHocTap frm = new frmImportCoVanHocTap())
            {
                frm.ShowDialog();
            }
        }

        #region Ham Xuat Excel
        void Excel01()
        {
            using (SaveFileDialog file = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    if (file.FileName != "")
                    {
                        gridControlCoVan.ExportToXls(file.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Bạn chưa nhập tên file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        #endregion
        private void btn_Xuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Excel01();
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void comboBoxEdit_Khoa_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _listGiangVien = DataServices.ViewGiangVien.GetByMaDonVi(comboBoxEdit_Khoa.EditValue.ToString());
            bindingSourceGiangVien.DataSource = _listGiangVien;
            Cursor.Current = Cursors.Default;
        }
                       
        bool checkThanhToan(
            )
        {
            bool bResult = false;
            if (bindingSourceGiangVienPhuCap.DataSource != null)
            {
                GiangVienPhucCap dt = bindingSourceGiangVienPhuCap.Current as GiangVienPhucCap;
                if (dt.TinhTrang != null)
                    bResult = Convert.ToBoolean(dt.TinhTrang.ToString());
            }
            return bResult;
        }

        #endregion

            #region Event GridView      
        private void gridViewCoVan_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewCoVan, e);
        }
        #endregion

    }
}