using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.Services;
using DevExpress.Common.CheckedCombo;
using PMS.BLL;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmChotTongKetKhoiLuongGiangDay : XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnChotThanhToan.Enabled = false;
                btnHuyChot.Enabled = false;
            }
            else
            {
                btnChotThanhToan.Enabled = true;
                btnHuyChot.Enabled = true;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int lanchot = 0;
        string _maTruong, _dsMaTruong;
        string strTenTruong = string.Empty;
        bool _thanhToanTheoDot;

        #endregion

        #region Event Form
        public frmChotTongKetKhoiLuongGiangDay()
        {
            InitializeComponent();
            _maTruong =PMS.Common.Globals.GetMaTruong(_cauHinhChung,"Mã trường");
            strTenTruong = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Tên trường");
            try
            {
                _thanhToanTheoDot = bool.Parse(PMS.Common.Globals.GetMaTruong(_cauHinhChung,"Thanh toán giờ giảng theo nhiều đợt trong học kỳ"));
            }
            catch
            {
                _thanhToanTheoDot = false;
            }
        }

        #region Thêm
        private void EnableCommbo(int i)
        {
            if (i == 0)
            {
                layoutControlItemBacDaoTao.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItemHeDaoTao.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            else
            {
                layoutControlItemBacDaoTao.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItemHeDaoTao.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
        }
        #endregion

        private void frmChotTongKetKhoiLuongGiangDay_Load(object sender, EventArgs e)
        {
            EnableCommbo(0);
            if (_thanhToanTheoDot)
            {
                layoutControlItemDotThanhToan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                layoutControlItemDotThanhToan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }

            #region Init GridView
            AppGridView.InitGridView(gridViewTongKet, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewTongKet, new string[] { "MaQuanLy", "Ho", "Ten", "MaMonHoc", "TenMonHoc", "MaHocHam", "MaHocVi", "MaLoaiGiangVien"
                , "LoaiHocPhan", "Nhom", "MaLop", "SiSo", "SoTiet", "HeSoBacDaoTao", "HeSoLopDong", "HeSoQuyDoiThucHanhSangLyThuyet", "HeSoTroCap", "HeSoDayNhieuLop", "TietQuyDoi", "MaDonVi" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Mã học phần", "Tên học phần", "Học hàm", "Học vị", "Loại giảng viên"
                , "Loại", "Nhóm", "Mã lớp", "Sĩ số", "Số tiết", "Hệ số bậc đào tạo", "Hệ số lớp đông", "Hệ số môn thực tập", "Hệ số CVHT", "Hệ số dạy nhiều LHP", "Tiết quy đổi", "Đơn vị" }
                    , new int[] { 70, 110, 60, 80, 200, 80, 80, 80, 60, 70, 80, 70, 70, 90, 90, 90, 90, 90, 90, 90 });
            AppGridView.HideField(gridViewTongKet, new string[] { "MaMonHoc", "HeSoBacDaoTao", "HeSoTroCap" });
            AppGridView.AlignHeader(gridViewTongKet, new string[] { "MaQuanLy", "Ho", "Ten", "MaMonHoc", "TenMonHoc"
                , "LoaiHocPhan", "Nhom", "MaLop", "SiSo", "SoTiet", "HeSoBacDaoTao", "HeSoLopDong", "HeSoQuyDoiThucHanhSangLyThuyet", "HeSoTroCap", "HeSoDayNhieuLop", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTongKet, "MaQuanLy", "{0} GV", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewTongKet);
            AppGridView.FormatDataField(gridViewTongKet, "SiSo", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewTongKet, new string[] { "SoTiet", "HeSoLopDong", "HeSoQuyDoiThucHanhSangLyThuyet", "HeSoTroCap", "HeSoBacDaoTao", "HeSoDayNhieuLop", "TietQuyDoi" }, DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.RegisterControlField(gridViewTongKet, "MaDonVi", repositoryItemGridLookUpEditDonVi);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.RegisterControlField(gridViewTongKet, "MaLoaiGiangVien", repositoryItemGridLookUpEditLoaiGiangVien);
            AppGridView.FixedField(gridViewTongKet, new string[] { "MaQuanLy", "Ho", "Ten" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            PMS.Common.Globals.WordWrapHeader(gridViewTongKet, 45);
            gridViewTongKet.GroupPanelText = "Gom nhóm bằng cách kéo tên cột thả vào đây";
            //gridViewTongKet.Columns["MaDonVi"].GroupIndex = 0;
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = PMS.Common.Globals.GetMaTruong(_cauHinhChung,"Năm học hiện tại");
            #endregion

            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Học kỳ hiện tại");
            #endregion

            #region DonVi
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditDonVi, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditDonVi, new string[] { "TenBoMon" }, new string[] { "Đơn vị" });
            repositoryItemGridLookUpEditDonVi.ValueMember = "MaBoMon";
            repositoryItemGridLookUpEditDonVi.DisplayMember = "TenBoMon";
            repositoryItemGridLookUpEditDonVi.NullText = string.Empty;
            #endregion

            #region HocHam
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHocHam, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHocHam, new string[] { "MaQuanLy", "TenHocHam" }, new string[] { "Mã học hàm", "Tên học hàm" });
            repositoryItemGridLookUpEditHocHam.ValueMember = "MaHocHam";
            repositoryItemGridLookUpEditHocHam.DisplayMember = "TenHocHam";
            repositoryItemGridLookUpEditHocHam.NullText = string.Empty;
            #endregion

            #region HocVi
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHocVi, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHocVi, new string[] { "MaQuanLy", "TenHocVi" }, new string[] { "Mã học vị", "Tên học vị" });
            repositoryItemGridLookUpEditHocVi.ValueMember = "MaHocVi";
            repositoryItemGridLookUpEditHocVi.DisplayMember = "TenHocVi";
            repositoryItemGridLookUpEditHocVi.NullText = string.Empty;
            #endregion

            #region LoaiGiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLoaiGiangVien, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLoaiGiangVien, new string[] { "MaQuanLy", "TenLoaiGiangVien" }, new string[] { "Mã loại giảng viên", "Tên loại giảng viên" });
            repositoryItemGridLookUpEditLoaiGiangVien.ValueMember = "MaLoaiGiangVien";
            repositoryItemGridLookUpEditLoaiGiangVien.DisplayMember = "TenLoaiGiangVien";
            repositoryItemGridLookUpEditLoaiGiangVien.NullText = string.Empty;
            #endregion

            #region HinhThucDaoTao
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHinhThucDaoTao, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHinhThucDaoTao, new string[] { "MaHinhThucDaoTao", "TenHinhThucDaoTao" }, new string[] { "Mã hình thức đào tạo", "Tên hình thức đào tạo" });
            repositoryItemGridLookUpEditHinhThucDaoTao.ValueMember = "MaHinhThucDaoTao";
            repositoryItemGridLookUpEditHinhThucDaoTao.DisplayMember = "TenHinhThucDaoTao";
            repositoryItemGridLookUpEditHinhThucDaoTao.NullText = string.Empty;
            #endregion

            InitData();
        }
        #endregion

        #region Init Khoa-DonVi
        private void KhoaDonVi()
        {
            cboKhoa.Properties.SelectAllItemCaption = "Tất cả";
            cboKhoa.Properties.TextEditStyle = TextEditStyles.Standard;
            cboKhoa.Properties.Items.Clear();

            VList<ViewKhoaBoMon> _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();

            _vListKhoaBoMon.Sort("TenKhoa");
            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                if (v.MaKhoa == v.MaBoMon)
                    _list.Add(new CheckedListBoxItem(v.MaKhoa, v.MaKhoa + " - " + v.TenKhoa, CheckState.Unchecked, true));
            }
            cboKhoa.Properties.Items.AddRange(_list.ToArray());
            cboKhoa.Properties.SeparatorChar = ';';
            cboKhoa.CheckAll();            
        }
            #endregion

        #region InitData
        void InitData()
        {
            bindingSourceHocHam.DataSource = DataServices.HocHam.GetAll();
            bindingSourceHocVi.DataSource = DataServices.HocVi.GetAll();
            bindingSourceLoaiGiangVien.DataSource = DataServices.LoaiGiangVien.GetAll();
            bindingSourceDonVi.DataSource = DataServices.ViewKhoaBoMon.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            bindingSourceHinhThucDaoTao.DataSource = DataServices.HinhThucDaoTao.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceCauHinhChotGio.DataSource = DataServices.CauHinhChotGio.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            LoadDataSource();
        }

        void LoadDataSource()
        {
            try
            {
                DataTable tb;
                IDataReader reader;
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    tb = new DataTable();
                    reader = DataServices.ViewLietKeKhoiLuongGiangDayChiTietUssh.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(),_maTruong=="HBU" ? cboKhoa.EditValue.ToString() : string.Empty,string.Empty);
                    tb.Load(reader);
                    bindingSourceTongKet.DataSource = tb;
                    DataServices.KetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref lanchot);
                }
                txtSoLanChot.Text = lanchot.ToString();
                gridViewTongKet.ExpandAllGroups();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceCauHinhChotGio.DataSource = DataServices.CauHinhChotGio.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            LoadDataSource();
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceCauHinhChotGio.DataSource = DataServices.CauHinhChotGio.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            LoadDataSource();
        }
        #endregion

        #region Ham Chot
        void ChotTheoDot()
        {
            int ktra = 0;
            DataServices.GiangVienTamUng.KiemTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboCauHinhChotGio.EditValue.ToString()), ref ktra);
            if (ktra == 1)
            {
                XtraMessageBox.Show(string.Format("Khối lượng giảng dạy năm học {0} - {1} - {2} đã thanh toán. Không thể tiếp tục chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboCauHinhChotGio.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bindingSourceTongKet.Count > 0)
            {
                int kq = 0;
                DataServices.KetQuaThanhToanThuLao.GetSoLanChotTheoDot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboCauHinhChotGio.EditValue.ToString()), cboBacDaoTao.EditValue.ToString(), cboLoaiHinhDaoTao.EditValue.ToString(), ref lanchot);
                lanchot++;
                if (XtraMessageBox.Show(string.Format("Chốt khối lượng giảng dạy năm học {0} - {1} - {2} lần thứ {3}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboCauHinhChotGio.Text, lanchot), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        DataServices.KetQuaThanhToanThuLao.ChotThanhToanTheoDot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboCauHinhChotGio.EditValue.ToString()), cboBacDaoTao.EditValue.ToString(), cboLoaiHinhDaoTao.EditValue.ToString(), lanchot, ref kq);
                        DataServices.KetQuaThanhToanThuLao.GetSoLanChotTheoDot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboCauHinhChotGio.EditValue.ToString()), cboBacDaoTao.EditValue.ToString(), cboLoaiHinhDaoTao.EditValue.ToString(), ref lanchot);
                        txtSoLanChot.Text = lanchot.ToString();
                        if (kq == 0)
                            XtraMessageBox.Show("Chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình chốt dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình chốt dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Cursor.Current = Cursors.Default;
                }
            }
        }

        void ChotTheoNamHocHocKy()
        {
            if (bindingSourceTongKet.Count > 0)
            {
                int kq = 0;
                DataServices.KetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref lanchot);
                lanchot++;
                if (XtraMessageBox.Show(string.Format("Chốt khối lượng giảng dạy năm học {0} - {1} lần thứ {2}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), lanchot), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        DataServices.KetQuaThanhToanThuLao.ChotThanhToan(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), lanchot, ref kq);
                        DataServices.KetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref lanchot);
                        txtSoLanChot.Text = lanchot.ToString();
                        if (kq == 0)
                            XtraMessageBox.Show("Chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình chốt dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình chốt dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Cursor.Current = Cursors.Default;
                }
            }
        }

        void ChotTheoNamHocHocKyKhoaDonVi()
        {
            if (bindingSourceTongKet.Count > 0)
            {
                int kq = 0;
                DataServices.KetQuaThanhToanThuLao.GetSoLanChotTheoKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoa.EditValue.ToString(), ref lanchot);
                lanchot++;
                if (XtraMessageBox.Show(string.Format("Chốt khối lượng giảng dạy năm học {0} - {1} lần thứ {2} cho đơn vị:\n{3}\n?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), lanchot, cboKhoa.Text), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        DataServices.KetQuaThanhToanThuLao.ChotThanhToanKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoa.EditValue.ToString(), lanchot, ref kq);
                        DataServices.KetQuaThanhToanThuLao.GetSoLanChotTheoKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoa.EditValue.ToString(), ref lanchot);
                        txtSoLanChot.Text = lanchot.ToString();
                        if (kq == 0)
                            XtraMessageBox.Show("Chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình chốt dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình chốt dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Cursor.Current = Cursors.Default;
                }
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
        private void btnChotThanhToan_Click(object sender, EventArgs e)
        {
            ChotTheoNamHocHocKy();
        }

        private void btnHuyChot_Click(object sender, EventArgs e)
        {
            HuyChotTheoNamHocHocKy();
        }
        #endregion

        #region HamHuy Chot
        void HuyChotTheoNamHocHocKy()
        {
            if (lanchot > 0)
            {
                using (frmHuyChotThuLao frm = new frmHuyChotThuLao(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), lanchot))
                {
                    frm.ShowDialog();
                }
                InitData();
            }
            else
            {
                XtraMessageBox.Show("Không thể huỷ do chưa chốt lần nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void HuyChotTheoNamHocHocKyKhoaDonVi()
        {
            if (lanchot > 0)
            {
                using (frmHuyChotThuLao frm = new frmHuyChotThuLao(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoa.EditValue.ToString(), lanchot))
                {
                    frm.ShowDialog();
                }
                InitData();
            }
            else
            {
                XtraMessageBox.Show("Không thể huỷ do chưa chốt lần nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void HuyChotTheoDot()
        {
            int kq = 0;
            DataServices.GiangVienTamUng.KiemTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboCauHinhChotGio.EditValue.ToString()), ref kq);
            if (kq == 1)
            {
                XtraMessageBox.Show(string.Format("Khối lượng giảng dạy năm học {0} - {1} - {2} đã thanh toán. Không thể huỷ chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboCauHinhChotGio.Text), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lanchot > 0)
            {
                using (frmHuyChotThuLao frm = new frmHuyChotThuLao(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboCauHinhChotGio.EditValue.ToString()), cboCauHinhChotGio.Text, lanchot))
                {
                    frm.ShowDialog();
                }
                InitData();
            }
            else
            {
                XtraMessageBox.Show("Không thể huỷ do chưa chốt lần nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlTongKet.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        private void gridViewTongKet_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            try
            {
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

        private void cboCauHinhChotGio_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void cboBacDaoTao_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void cboLoaiHinhDaoTao_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void cboKhoa_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoa.EditValue != null)
            {
                if (!_thanhToanTheoDot || cboCauHinhChotGio.EditValue != null)
                    LoadDataSource();
            }
        }
    }
}
