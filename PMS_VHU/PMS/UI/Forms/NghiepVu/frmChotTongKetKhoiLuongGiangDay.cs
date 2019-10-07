using DevExpress.Common.Grid;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using PMS.BLL;
using PMS.Entities;
using PMS.Services;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmChotTongKetKhoiLuongGiangDay : XtraForm
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int lanchot = 0;
        string _maTruong;
        string strTenTruong = string.Empty, strIDChucNang = string.Empty;
        bool _thanhToanTheoDot, bDuocPhepChot;
        #endregion

        #region Event Form
        public frmChotTongKetKhoiLuongGiangDay()
        {
            InitializeComponent();
            _maTruong = PMS.Common.Globals.GetMaTruong(_cauHinhChung,"Mã trường");
            strTenTruong = PMS.Common.Globals.GetMaTruong(_cauHinhChung,"Tên trường");
            try
            {
                _thanhToanTheoDot = bool.Parse(PMS.Common.Globals.GetMaTruong(_cauHinhChung,"Thanh toán giờ giảng theo nhiều đợt trong học kỳ"));
            }
            catch
            {
                _thanhToanTheoDot = false;
            }
        }
                
        private void frmChotTongKetKhoiLuongGiangDay_Load(object sender, EventArgs e)
        {
            #region Phân quyền chức năng (chốt)
            DataServices.TaiKhoan.KiemTraPhanQuyenControl(UserInfo.UserID, this.GetType().Name, ref bDuocPhepChot);
            layoutCtrItemChot.Visibility = layoutCtrItemHuyChot.Visibility
                = bDuocPhepChot ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                                : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            #endregion

            InitGridVHU();

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = PMS.Common.Globals.GetMaTruong(_cauHinhChung,"Năm học hiện tại");
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
                       
            InitData();
        }
        #endregion
               
        #region InitGrid()
        
        void InitGridVHU()
        {
            AppGridView.InitGridView(gridViewTongKet, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewTongKet
                , new string[] { "MaQuanLy", "Ho", "Ten", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "TenLoaiGiangVien"
                                , "MaMonHoc", "TenMonHoc", "LoaiHocPhan", "Nhom", "MaLop", "SiSo", "SoTiet"
                                , "HeSoLopDong", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoNgoaiGio", "HeSoCoSo"
                                , "HeSoClcCntn", "HeSoQuyDoiThucHanhSangLyThuyet", "TietQuyDoi", "TenDonVi" }
                , new string[] { "Mã giảng viên", "Họ", "Tên", "Học hàm", "Học vị", "Mã loại GV", "Loại giảng viên"
                                , "Mã môn học", "Tên môn học", "Loại", "Nhóm", "Mã lớp", "Sĩ số", "Số tiết"
                                , "HS lớp đông", "HS bậc đào tạo", "HS ngôn ngữ", "HS ngoài giờ", "HS cơ sở"
                                , "HS lớp CLC", "HS thực hành, TN, BT", "Tiết quy đổi", "Đơn vị" }
                , new int[] { 90, 115, 55, 80, 80, 80, 100, 80, 150, 60, 70, 80, 70, 70, 80, 80, 80, 80, 80, 80, 80, 80, 120 });
            AppGridView.AlignHeader(gridViewTongKet
                , new string[] { "MaQuanLy", "Ho", "Ten", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "TenLoaiGiangVien"
                                , "MaMonHoc", "TenMonHoc", "LoaiHocPhan", "Nhom", "MaLop", "SiSo", "SoTiet"
                                , "HeSoLopDong", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoNgoaiGio", "HeSoCoSo"
                                , "HeSoClcCntn", "HeSoQuyDoiThucHanhSangLyThuyet", "TietQuyDoi", "TenDonVi" }
                , DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTongKet, "MaQuanLy", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewTongKet, "SoTiet", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewTongKet, "TietQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewTongKet, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");

            AppGridView.ReadOnlyColumn(gridViewTongKet);

            AppGridView.FormatDataField(gridViewTongKet, "SiSo", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewTongKet, "SoTiet", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "HeSoLopDong", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");           
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocVi", repositoryItemGridLookUpEditHocVi);         
            AppGridView.HideField(gridViewTongKet, new string[] { "HeSoCoSo", "HeSoClcCntn", "MaLoaiGiangVien" });
        }
        #endregion

        #region Hoc Ky    
        private void LoadHocKy(string strNamHoc)
        {
            cboHocKy.Properties.SelectAllItemCaption = "Tất cả";
            cboHocKy.Properties.TextEditStyle = TextEditStyles.Standard;
            cboHocKy.Properties.Items.Clear();
            VList<ViewHocKy> VlistHocKy = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            VlistHocKy.Sort("MaHocKy");
            List<CheckedListBoxItem> listHK = new List<CheckedListBoxItem>();
            for (int i = 0; i < VlistHocKy.Count; i++)
            {
                listHK.Add(new CheckedListBoxItem(VlistHocKy[i].MaHocKy
                    , String.Format("{0} - {1}", VlistHocKy[i].MaHocKy, VlistHocKy[i].TenHocKy)
                    , CheckState.Unchecked, true));
            }
            cboHocKy.Properties.Items.AddRange(listHK.ToArray());
            cboHocKy.Properties.SeparatorChar = ';';
            cboHocKy.CheckAll();
        }
        #endregion

        #region InitData
        void InitData()
        {
            bindingSourceHocHam.DataSource = DataServices.HocHam.GetAll();
            bindingSourceHocVi.DataSource = DataServices.HocVi.GetAll();          
         
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                LoadHocKy(cboNamHoc.EditValue.ToString());
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
                    reader = DataServices.ViewLietKeKhoiLuongGiangDayChiTietUssh.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), string.Empty, string.Empty);
                    tb.Load(reader);
                    bindingSourceTongKet.DataSource = tb; DataServices.KetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref lanchot);
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
            LoadDataSource();
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            EnableChot(cboHocKy.EditValue.ToString());
            LoadDataSource();
        }
        #endregion

        private void EnableChot(string strHocKy)
        {
            string[] LstHocKy = strHocKy.Split(';');
            if (LstHocKy.Length > 1)
                Enable(false);
            else
                Enable(true);
        }

        void Enable(bool b)
        {
            btnChotThanhToan.Enabled = b;
            btnHuyChot.Enabled = b;
        }

        #region Ham Chot
       
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
    }
}
