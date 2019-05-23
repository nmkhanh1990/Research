using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Common;
using DevExpress.XtraGrid.Views.Grid;
using PMS.BLL;
using DevExpress.Common.CheckedCombo;

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
        bool _thanhToanTheoDot;
        string strLst = string.Empty, strHocKy = string.Empty;
        #endregion

        #region Event Form
        public frmQuyDoiGioChuan()
        {
            InitializeComponent();
            _maTruong = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Mã trường");
            _tenTruong = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Tên trường");
            try
            {
                _thanhToanTheoDot = Boolean.Parse(PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Thanh toán giờ giảng theo nhiều đợt trong học kỳ"));
            }
            catch
            {
                _thanhToanTheoDot = false;
            }
        }
        
        private void frmQuyDoiGioChuan_Load(object sender, EventArgs e)
        {
            #region Init GridView     
            InitGridBUH();
            #endregion

            WordWrapHeader(gridViewKhoiLuongQuyDoi, 50);

            
            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            cboNamHoc.Properties.NullText = string.Empty;
            #endregion

            LoadHocKy();
           
            LoadGiangVien();
           
            InitData();
        }
        #endregion

        #region InitGrid        
        
        void InitGridBUH()
        {
            AppGridView.InitGridView(gridViewKhoiLuongQuyDoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongQuyDoi, new string[] { "Chon", "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TietThucDay"
                                                                        , "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "HeSoNgoaiGio", "HeSoLuong", "HeSoMonMoi", "TietQuyDoi"  }
                                                         , new string[] { " ","Mã giảng viên", "Họ", "Tên", "Học hàm", "Học vị", "Tên môn học", "STC", "Mã Lớp học phần", "Lớp sinh viên", "Học kỳ", "Số SV ĐK", "Loại học phần", "Bậc đào tạo", "Mã Khóa học", "Tiết thực dạy"
                                                                        , "Hệ số chức danh", "Hệ số lớp đông", "Hệ số tỉnh (hs cơ sở)", "Hệ số ngoài giờ", "Hệ số lương", "Hệ số môn mới", "Tiết quy đổi"}
                                                         , new int[] { 30, 140, 120, 70, 90, 90, 150, 60, 110, 100, 70, 100, 90, 80, 90, 100, 100, 100, 100, 100, 90, 100, 100 });
            AppGridView.AlignHeader(gridViewKhoiLuongQuyDoi, new string[] {"MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TietThucDay"
                                                                        , "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "HeSoNgoaiGio", "HeSoLuong", "HeSoMonMoi", "TietQuyDoi"   }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewKhoiLuongQuyDoi, new string[] { "SoTinChi", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TietThucDay"
                                                                        , "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "HeSoNgoaiGio", "HeSoLuong", "HeSoMonMoi", "TietQuyDoi"  }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "MaGiangVien", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietThucDay", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            gridViewKhoiLuongQuyDoi.Columns["HocKy"].GroupIndex = 0;
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TietThucDay"
                                                                        , "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "HeSoNgoaiGio", "HeSoLuong", "HeSoMonMoi", "TietQuyDoi" });
            AppGridView.FixedField(gridViewKhoiLuongQuyDoi, new string[] { "Chon", "MaGiangVien", "Ho", "Ten" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);

            layoutControlItemChonTatCa.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }
        
        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewKhoiLuongQuyDoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc"
                                                                        , "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "TietThucDay", "SoTietThucTeQuyDoi", "TietQuyDoi"  }
                                                         , new string[] { "Mã giảng viên", "Họ", "Tên", "Tên môn học", "Số tín chỉ", "Mã Lớp học phần", "Lớp sinh viên", "Học kỳ", "Số SV ĐK", "Loại học phần", "Bậc đào tạo", "Mã Khóa học"
                                                                        , "Hệ số công việc", "Hệ số bậc đào tạo", "Hệ số ngôn ngữ", "Hệ số chức danh", "Hệ số lớp đông", "Hệ số cơ sở", "Tiết dạy thực tế", "Tiết thực tế quy đổi", "Tiết quy đổi"}
                                                         , new int[] { 140, 120, 80, 150, 80, 100, 100, 70, 100, 90, 80, 90, 100, 110, 110, 100, 90, 90, 120, 120, 90 });
            AppGridView.AlignHeader(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc"
                                                                        , "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "TietThucDay", "SoTietThucTeQuyDoi", "TietQuyDoi"  }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewKhoiLuongQuyDoi, new string[] { "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "MaGiangVien", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietThucDay", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "SoTietThucTeQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            gridViewKhoiLuongQuyDoi.Columns["HocKy"].GroupIndex = 0;
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongQuyDoi);
            AppGridView.FixedField(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
        }
        #endregion

       

        #region Giang Vien
        private void LoadGiangVien()
        {
            cboGiangVien.Properties.SelectAllItemCaption = "Tất cả";
            cboGiangVien.Properties.TextEditStyle = TextEditStyles.Standard;
            cboGiangVien.Properties.Items.Clear();

            VList<ViewGiangVien> vListGiangVien = DataServices.ViewGiangVien.GetAll();
            vListGiangVien.Sort("MaQuanLy");
            List<CheckedListBoxItem> listGV = new List<CheckedListBoxItem>();
            for (int i = 0; i < vListGiangVien.Count; i++)
            {
                listGV.Add(new CheckedListBoxItem(vListGiangVien[i].MaQuanLy
                    , String.Format("{0} - {1}", vListGiangVien[i].MaQuanLy, vListGiangVien[i].HoTen)
                    , CheckState.Unchecked, true));
            }
            cboGiangVien.Properties.Items.AddRange(listGV.ToArray());
            cboGiangVien.Properties.SeparatorChar = ';';
            cboGiangVien.CheckAll();
        }
        #endregion

        #region Hoc Ky    
        private void LoadHocKy()
        {
            if (_maTruong != "HBU")
            {
                AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
                AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã hoc kỳ", "Tên học kỳ" });
                cboHocKy.Properties.ValueMember = "MaHocKy";
                cboHocKy.Properties.DisplayMember = "TenHocKy";
                cboHocKy.Properties.NullText = string.Empty;
                cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            }
            
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
                if (cboGiangVien.EditValue.ToString() == "")
                {
                    PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_ChonGiangVien, MessageBoxIcon.Warning, true);
                    cboGiangVien.Focus();
                    return;
                }
                if (cboNamHoc.EditValue.ToString() == "" || cboHocKy.EditValue.ToString() == "")
                {
                    PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_ChekNamHocHocKy, MessageBoxIcon.Warning, true);
                    cboNamHoc.Focus();
                    return;
                }                
                ListCombox(ref strLst, ref strHocKy);
                DataTable dataTable = new DataTable();
                IDataReader reader = DataServices.KhoiLuongQuyDoi.GetByGiangVienNamHocHocKy(strLst, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
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
        void QuyDoiTheoGiangVienLopHocPhan_XML()
        {
            DataTable tb = bindingSourceKhoiLuongQuyDoi.DataSource as DataTable;
            string xmlData = "";
            foreach (DataRow r in tb.Rows)
            {
                if (r["Chon"].ToString().ToLower() == "true")
                {
                    xmlData += String.Format("<Input M=\"{0}\" L=\"{1}\" HH=\"{2}\" HV=\"{3}\" LGV=\"{4}\" CS=\"{5}\" />"
                            , r["MaGiangVien"].ToString(), r["MaLopHocPhan"].ToString()
                            , PMS.Common.Globals.IsNull(r["MaHocHam"], "int").ToString()
                            , PMS.Common.Globals.IsNull(r["MaHocVi"], "int").ToString()
                            , PMS.Common.Globals.IsNull(r["MaLoaiGiangVien"], "int").ToString()
                            , r["MaCoSo"].ToString());
                }
            }

            if (xmlData == "")
            {
                XtraMessageBox.Show("Vui lòng chọn những dòng muốn quy đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            xmlData = String.Format("<Root>{0}</Root>", xmlData);

            using (frmXuLyQuyDoiGioiChuan frm = new frmXuLyQuyDoiGioiChuan(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), _maTruong, xmlData, 1))
            {
                frm.ShowDialog();
            }

            LoadDataTheoNamHocHocKy(_maTruong);
        }
        void QuyDoiTheoGiangVienLopHocPhan()
        {
            try
            {
                frmXuLyQuyDoiGioiChuan frm;
                if (gridViewKhoiLuongQuyDoi.RowCount > 0)
                {
                    DataTable dt = (bindingSourceKhoiLuongQuyDoi.DataSource as DataTable).Select("Chon = 'True'").CopyToDataTable();
                    if (dt.Rows.Count > 0)
                    {
                        frm = new frmXuLyQuyDoiGioiChuan(dt, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), _maTruong);
                    }
                    else
                    {
                        frm = new frmXuLyQuyDoiGioiChuan(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), _maTruong);
                    }
                    frm.ShowDialog();
                    LoadDataTheoNamHocHocKy(_maTruong);
                }
                else
                {
                    XtraMessageBox.Show("Chưa lọc dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception ex)
            {
                XuLyGiaoDien.ThongBaoLoi(ex, true);
            }

        }
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
                    ListCombox( ref strLst, ref strHocKy);
                    frmXuLyDongBoDuLieu frm;
                    bindingSourceKhoiLuongQuyDoi.EndEdit();
                    frm = new frmXuLyDongBoDuLieu(strLst,cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_LoiDongBo + " " + ex.Message.ToString(), MessageBoxIcon.Error, true);
                }
            }

            LoadDataTheoNamHocHocKy(_maTruong);
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event Button
        private void btnDongbo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DongBoCacTruongConLai();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
            }
           
        }

        private void btnQuyDoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                gridViewKhoiLuongQuyDoi.FocusedRowHandle = -1;
                if (cboNamHoc.EditValue.ToString() == "" || cboHocKy.EditValue.ToString() == "")
                {
                    PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_ChekNamHocHocKy, MessageBoxIcon.Warning, true);
                    cboNamHoc.Focus();
                    return;
                }

                QuyDoiTheoGiangVienLopHocPhan();
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
                PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_LoiXuatFile + " " + ex.Message.ToString(), MessageBoxIcon.Error, true);

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
            catch (Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
            }

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
                PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
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
                PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
            }
        }
        #endregion

              

        private void ListCombox(ref string strLst, ref string strHocKy)
        {
            strLst = cboGiangVien.EditValue.ToString();
            strHocKy = cboHocKy.EditValue.ToString();

        }
    }
}
