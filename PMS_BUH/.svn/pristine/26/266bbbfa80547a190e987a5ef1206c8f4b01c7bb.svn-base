using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Entities;
using PMS.BLL;
using DevExpress.XtraEditors.Controls;
using DevExpress.Common.DataForm;
using PMS.UI.Forms.BaoCao;
using PMS.Services;
using DevExpress.Common.CheckedCombo;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThuMoiGiang_VHU : XtraUserControl
    {
        #region Variable
        string groupname = UserInfo.GroupName;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();      
        string _maTruong;
        private bool user = false;
        #endregion

        #region Event Form
        public ucThuMoiGiang_VHU()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            TList<CauHinh> cauHinh = DataServices.CauHinh.GetAll();
            if (cauHinh != null)
            {
                foreach (CauHinh ch in cauHinh)
                {
                    if (ch.TrangThai == true)
                        PMS.Common.Globals._cauhinh = ch;
                }
            }
        }

        private void ucThuMoiGiang_VHU_Load(object sender, EventArgs e)
        {
            #region InitGridView 
            AppGridView.InitGridView(gridViewThuMoiGiang, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThuMoiGiang, new string[] { "Chon", "MaQuanLy", "HoTenGiangVien", "TenHocHam", "TenHocVi", "MaLopHocPhan", "TenMonHoc", "SoTietLt", "SoTietTh", "SiSo", "SoTinChi", "Thu", "Tiet", "Phong" }
                    , new string[] { "Chọn", "Mã giảng viên", "Họ tên", "Học hàm", "Học vị", "Mã lớp học phần", "Tên môn học", "Lý thuyết", "Thực hành", "Sĩ số", "Tín chỉ", "Thứ", "Tiết", "Phòng học" }
                    , new int[] { 50, 80, 150, 100, 100, 100, 200, 70, 70, 60, 60, 50, 50, 80 });
            AppGridView.AlignHeader(gridViewThuMoiGiang, new string[] { "MaQuanLy", "HoTenGiangVien", "TenHocHam", "TenHocVi", "MaLopHocPhan", "TenMonHoc", "SoTietLt", "SoTietTh", "SiSo", "SoTinChi", "Thu", "Tiet", "Phong" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewThuMoiGiang, new string[] { "MaQuanLy", "HoTenGiangVien", "TenHocHam", "TenHocVi", "MaLopHocPhan", "TenMonHoc", "SoTietLt", "SoTietTh", "SiSo", "SoTinChi", "Thu", "Tiet", "Phong" });
            AppGridView.HideField(gridViewThuMoiGiang, new string[] { "Chon","TenHocVi", "TenHocHam", "TenHocVi", "SoTinChi" });
            AppGridView.SummaryField(gridViewThuMoiGiang, "MaLopHocPhan", "{0} dòng", DevExpress.Data.SummaryItemType.Count);
            //gridViewDanhSachGiangVien.Columns["Khoa"].GroupIndex = 0;
            AppGridView.FixedField(gridViewThuMoiGiang, new string[] { "Chon", "MaQuanLy", "HoTenGiangVien", "MaLopHocPhan", "TenMonHoc" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            #endregion
            
            #region Năm học
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Học kỳ
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region
            AppCheckedComboboxEdit.InitCheckedComboBoxEdit(cboDonVi, CheckState.Checked, LoaiDuLieu.KhoaDonVi, _maTruong);
            #endregion

            InitData();
        }
        #endregion

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if(cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
            if(cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.GiangVien.GetThuMoiGiang(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), UserInfo.UserName);
                tb.Load(reader);
                tb.Columns["Chon"].ReadOnly = false;
                bindingSourceThuMoiGiang.DataSource = tb;
            }
            gridViewThuMoiGiang.ExpandAllGroups();
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXuatExcel_ItemClick(object sender, DevExpress. XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlThuMoiGiang.ExportToXls(sf.FileName);
                    PMS.Common.XuLyGiaoDien.ThongBao("Thông báo", PMS.Common.ThongBao.Str_XuatFile, MessageBoxIcon.Information, true);                    
                }
            }
            catch
            { }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                gridViewThuMoiGiang.FocusedRowHandle = -1;
                bindingSourceThuMoiGiang.EndEdit();
                AppType objLoaiBaoCao = bindingSourceThuMoiGiang.Current as AppType;
                DataTable data = bindingSourceThuMoiGiang.DataSource as DataTable;
                if (data == null)
                    return;
                DataTable vListBaoCao = data;
                vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThuMoiGiang, bindingSourceThuMoiGiang);

                vListBaoCao = vListBaoCao.Select("Chon = 'False'").CopyToDataTable();
                string khoa = "";
                if (_maTruong == "UTE")
                {
                    khoa = groupname;
                }
                else
                {
                    VList<ViewKhoa> _vKhoa = DataServices.ViewKhoa.GetAll();
                    try
                    {
                        khoa = _vKhoa.Find(p => p.MaKhoa == groupname).TenKhoa;
                    }
                    catch
                    {
                        khoa = "";
                    }
                }
                if (groupname == "Administrator" || groupname == "User")
                    khoa = "";

                if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
                {
                    using (frmBaoCao frm = new frmBaoCao())
                    {
                        frm.InThuMoiGiang(vListBaoCao);
                        frm.ShowDialog();
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
            }
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue.ToString() != "" && cboHocKy.EditValue.ToString() != "")
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.GiangVien.GetThuMoiGiang(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), UserInfo.UserName);
                tb.Load(reader);
                tb.Columns["Chon"].ReadOnly = false;
                bindingSourceThuMoiGiang.DataSource = tb;
            }
            gridViewThuMoiGiang.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceThuMoiGiang.DataSource = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

        private void gridViewThuMoiGiang_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if(e.Column.Caption.Equals("Chon"))
            {
                AppGridView.CheckAll(gridViewThuMoiGiang, "Chon", new string[] { "MaQuanLy" }, e.RowHandle);
            }
        }
    }
}
