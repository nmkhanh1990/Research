using DevExpress.Common.Grid;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using PMS.Common;
using PMS.Entities;
using PMS.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmQuyDoiGioChuan : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnDongbo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnDongbo.ItemShortcut = DevExpress.XtraBars.BarShortcut.Empty;

                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnQuyDoi.ItemShortcut = DevExpress.XtraBars.BarShortcut.Empty;
            }
            else
            {
                btnDongbo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong, _tenTruong;
        #endregion

        #region Event Form
        public frmQuyDoiGioChuan()
        {
            InitializeComponent();
            _maTruong = Common.Globals.GetMaTruong(_cauHinhChung, "Mã trường");
            _tenTruong = Common.Globals.GetMaTruong(_cauHinhChung, "Tên trường");
        }

        private void frmQuyDoiGioChuan_Load(object sender, EventArgs e)
        {
            #region Init GridView            
            //HeSoQuyDoiThucHanhSangLyThuyet: hệ số môn thực tập; HeSoTroCap: hệ số CVHT
            AppGridView.InitGridView(gridViewKhoiLuongQuyDoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongQuyDoi
                , new string[] { "MaGiangVien", "Ho", "Ten", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc"
                                , "HeSoBacDaoTao", "HeSoLopDong", "HeSoQuyDoiThucHanhSangLyThuyet", "HeSoTroCap", "HeSoDayNhieuLop", "TietThucDay", "TietDayNhieuLopHocPhan", "TietQuyDoi" }
                , new string[] { "Mã giảng viên", "Họ", "Tên", "Tên học phần", "Số tín chỉ", "Mã Lớp học phần", "Lớp sinh viên", "Học kỳ", "Số SV ĐK", "Loại học phần", "Bậc đào tạo", "Mã Khóa học"
                                , "Hệ số bậc đào tạo", "Hệ số lớp đông", "Hệ số môn thực tập", "Hệ số CVHT", "Hệ số dạy nhiều LHP", "Tiết dạy thực tế", "Tiết dạy song song", "Tiết quy đổi" }
                , new int[] { 70, 120, 60, 200, 60, 100, 100, 70, 100, 80, 110, 110, 100, 100, 80, 80, 120, 120, 80, 80 });
            AppGridView.HideField(gridViewKhoiLuongQuyDoi, new string[] { "HeSoBacDaoTao", "HeSoTroCap", "HeSoDayNhieuLop" });
            AppGridView.AlignHeader(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc"
                                                                       , "HeSoBacDaoTao", "HeSoLopDong", "HeSoQuyDoiThucHanhSangLyThuyet", "HeSoTroCap", "HeSoDayNhieuLop", "TietThucDay", "TietDayNhieuLopHocPhan", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewKhoiLuongQuyDoi, new string[] { "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "HeSoBacDaoTao", "HeSoLopDong", "HeSoQuyDoiThucHanhSangLyThuyet", "HeSoTroCap", "HeSoDayNhieuLop", "TietThucDay", "TietDayNhieuLopHocPhan", "TietQuyDoi" }
                            , DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "MaGiangVien", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietThucDay", "Tổng: {0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietDayNhieuLopHocPhan", "Tổng: {0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", "Tổng: {0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, new string[] { "HeSoBacDaoTao", "HeSoLopDong", "HeSoQuyDoiThucHanhSangLyThuyet", "HeSoTroCap", "HeSoDayNhieuLop", "TietThucDay", "TietDayNhieuLopHocPhan", "TietQuyDoi" }, DevExpress.Utils.FormatType.Custom, "n2");
            gridViewKhoiLuongQuyDoi.Columns["HocKy"].GroupIndex = 0;
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongQuyDoi);
            AppGridView.FixedField(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenMonHoc" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            WordWrapHeader(gridViewKhoiLuongQuyDoi, 40);
            #endregion

            VisibleCombobox(_maTruong);

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            cboNamHoc.Properties.NullText = string.Empty;
            #endregion

            LoadHocKy();
            
            KhoaDonVi();

            InitData();
        }
        #endregion

        #region KhoaDonVi
        private void KhoaDonVi()
        {
            cboDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboDonVi.Properties.Items.Clear();

            VList<ViewKhoaBoMon> vListKhoa = DataServices.ViewKhoaBoMon.GetAll();
            vListKhoa.Sort("MaKhoa");
            List<CheckedListBoxItem> listKhoa = new List<CheckedListBoxItem>();
            for (int i = 0; i < vListKhoa.Count; i++)
            {
                listKhoa.Add(new CheckedListBoxItem(vListKhoa[i].MaKhoa
                    , String.Format("{0} - {1}", vListKhoa[i].MaKhoa, vListKhoa[i].TenKhoa)
                    , CheckState.Unchecked, true));
            }
            cboDonVi.Properties.Items.AddRange(listKhoa.ToArray());
            cboDonVi.Properties.SeparatorChar = ';';
            cboDonVi.CheckAll();
        }
        #endregion

        #region Hoc Ky    
        private void LoadHocKy()
        {
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã hoc kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
        }
        #endregion

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
            if (cboNamHoc.EditValue != null && cboHocKy.Text != "")
            {
                bindingSourceDot.DataSource = DataServices.CauHinhChotGio.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

        void WordWrapHeader(GridView grid, int height)
        {
            for (int i = 0; i < grid.Columns.Count; i++)
                grid.Columns[i].AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            AutoHeightHelper a = new AutoHeightHelper(grid, height);
            a.EnableColumnPanelAutoHeight();
        }

        void LoadDataTheoNamHocHocKy(string strMaTruong)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (cboNamHoc.EditValue.ToString() == "" || cboHocKy.EditValue.ToString() == "")
                {
                    XuLyGiaoDien.ThongBao(ThongBao.Str_ThongBao, ThongBao.Str_ChekNamHocHocKy, MessageBoxIcon.Warning, true);
                    cboNamHoc.Focus();
                    return;
                }
                string strLst = string.Empty, strHocKy = string.Empty;
                ListCombox(_maTruong, ref strLst, ref strHocKy);
                DataTable dataTable = new DataTable();
                IDataReader reader = DataServices.KhoiLuongQuyDoi.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), strHocKy);
                dataTable.Load(reader);
                foreach (DataColumn col in dataTable.Columns)
                {
                    col.ReadOnly = false;
                }
                bindingSourceKhoiLuongQuyDoi.DataSource = dataTable;
                gridViewKhoiLuongQuyDoi.ExpandAllGroups();
            }
            catch (Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
            }
        }
        #endregion

        #region Ham Quy Doi
        void QuyDoiTheoNamHocHocKy()
        {
            using (frmXuLyQuyDoiGioiChuan frm = new frmXuLyQuyDoiGioiChuan(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), _maTruong))
            {
                frm.ShowDialog();
            }
            LoadDataTheoNamHocHocKy(_maTruong);
        }
        #endregion

        #region HamDongBo
        void DongBoCacTruongConLai()
        {
            if (cboNamHoc.EditValue.ToString() == "" || cboHocKy.EditValue.ToString() == "")
            {
                PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_ChekNamHocHocKy, MessageBoxIcon.Warning, true);
                cboNamHoc.Focus();
                return;
            }
            

            int kiemTraDongBo = 0;
            DataServices.KhoiLuongGiangDayChiTiet.KiemTraDongBo(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kiemTraDongBo);
            if (kiemTraDongBo == 0)
                XtraMessageBox.Show(string.Format("Dữ liệu của năm học {0} - {1} đã được đồng bộ.\nLưu ý: nếu đồng bộ lại toàn bộ dữ liệu cũ của năm học {0} - {1} sẽ bị thay thế.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (XtraMessageBox.Show("Bạn có muốn đồng bộ dữ liệu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    frmXuLyDongBoDuLieu frm;
                    bindingSourceKhoiLuongQuyDoi.EndEdit(); 
                    frm = new frmXuLyDongBoDuLieu(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), _maTruong);                    
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_LoiDongBo+" "+ex.Message.ToString(), MessageBoxIcon.Error, true);                    
                }
            }

            LoadDataTheoNamHocHocKy(_maTruong);

            if (_maTruong == "IUH")
            {
                DataTable tb = bindingSourceKhoiLuongQuyDoi.DataSource as DataTable;
                foreach (DataRow r in tb.Rows)
                {
                    r["Chon"] = true;
                }
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event Button
        private void btnDongbo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DongBoCacTruongConLai();
            Cursor.Current = Cursors.Default;
        }

        private void btnQuyDoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                gridViewKhoiLuongQuyDoi.FocusedRowHandle = -1;
                if (cboNamHoc.EditValue.ToString() == "" || cboHocKy.EditValue.ToString()=="")
                {
                    XuLyGiaoDien.ThongBao(ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_ChekNamHocHocKy, MessageBoxIcon.Warning, true);
                    cboNamHoc.Focus();
                    return;
                }
                QuyDoiTheoNamHocHocKy();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadDataTheoNamHocHocKy(_maTruong);
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InitData();
            LoadDataTheoNamHocHocKy(_maTruong);
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
                            gridControlKhoiLuongQuyDoi.ExportToXls(sf.FileName);
                            PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_XuatFile, MessageBoxIcon.Information, true);
                        }
                }
            }
            catch (Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_LoiXuatFile+" "+ex.Message.ToString(), MessageBoxIcon.Error, true);

            }
        }
        #endregion

        #region Event Grid
        private void gridViewKhoiLuongQuyDoi_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            try
            {
                if (_maTruong == "IUH")
                {
                    if (e.Column.FieldName == "HeSoQuyDoiThucHanhSangLyThuyet")
                    {
                        if (Convert.ToDouble(e.Value) == 0.67)
                            e.DisplayText = "2/3";
                    }
                }

                if (_maTruong == "LAW")
                {
                    if (e.Column.FieldName == "HeSoNienCheTinChi")
                    {
                        if (Convert.ToDouble(e.Value) == 1.111111)
                            e.DisplayText = "50/45";
                    }

                    if (e.Column.FieldName == "HeSoTroCap")
                    {
                        if (Convert.ToDouble(e.Value) == 1.333333)
                            e.DisplayText = "20/15";
                    }
                }
            }
            catch
            { }

        }
        #endregion

        #region Event CheckEdit
        private void checkEditChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            PMS.Common.XuLyGiaoDien.CheckAll(gridViewKhoiLuongQuyDoi, "Chon", checkEditChonTatCa.Checked);
        }
        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboNamHoc.EditValue != null)
                {
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                }
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    bindingSourceDot.DataSource = DataServices.CauHinhChotGio.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    bindingSourceDot.DataSource = DataServices.CauHinhChotGio.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        #endregion

        private void VisibleCombobox(string strMaTruong)
        {
            layoutControlcbohocky.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlKhoa.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        private void ListCombox(string strMaTruong,ref string strLst,ref string strHocKy)
        {
            strHocKy = cboHocKy.EditValue.ToString();
        }
    }
}
