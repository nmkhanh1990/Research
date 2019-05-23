﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.UI.Forms.BaoCao;
using PMS.BLL;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using DevExpress.XtraGrid.Columns;
using PMS.UI.Forms.NghiepVu.ChucNangCon;
using DevExpress.XtraGrid.Views.Grid;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThongKeChiTietGioGiangBUH : DevExpress.XtraEditors.XtraUserControl
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnKeToaXacNhanChiTra.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnKeToaXacNhanChiTra.ItemShortcut = DevExpress.XtraBars.BarShortcut.Empty;

                btnLuuChiTra.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuuChiTra.ItemShortcut = DevExpress.XtraBars.BarShortcut.Empty;
            }
            else
            {
                btnKeToaXacNhanChiTra.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnLuuChiTra.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();        
        TList<TrangThaiGiangVien> lstTTGV;
        int lanchot = 0;
        string _maTruong;
        DateTime _ngayIn;
        bool userRole = false;
        DataTable dtData;
        string _groupName = UserInfo.GroupName;
        string _dotChiTra, _ngayChiTra;
        
        #endregion

        #region Event Form
        public ucThongKeChiTietGioGiangBUH()
        {
            InitializeComponent();
            _maTruong = PMS.Common.Globals.GetMaTruong( _cauHinhChung, "Mã trường");          
          
        }

        private void ShowFile()
        {
            #region Init GirdView
            //List<string> strIDColumns = new List<string>(), strFileColumns =new List<string>();
            //List<int> iSizeColumns = new List<int>();
            //PMS.Common.XuLyGiaoDien.GetTitleTable(ref strIDColumns, ref strFileColumns, ref iSizeColumns, _maTruong, this.GetType().Name.ToString());
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            #region Title
            AppGridView.ShowField(gridViewThongKe, new string[] { "Id","DaChiTra", "XacNhanChiTra","ChonIn", "TenDotChiTra","NgayChonThanhToan","NgayXacNhanThanhToan","MaQuanLy", "Ho", "Ten", "ChucDanh", "TenDonVi", "MaMonHoc", "TenMonHoc", "MaBacDaoTao"
                , "MaLopHocPhan", "MaLop", "TietThucDay", "SiSo", "HeSoChucDanhChuyenMon", "HeSoCoSo", "HeSoLopDong", "HeSoLuong", "HeSoNgoaiGio"
                , "HeSoThinhGiangMonChuyenNganh", "HeSoMonMoi", "TongHeSo", "TietQuyDoi", "DonGia", "ThanhTien", "ThuLaoVuotGio", "TamTruThue", "ThucChuyen", "SoTaiKhoan", "TenNganHang", "MaSoThue", "Cmnd", "TenLoaiGiangVien", "DotChiTra" }
                    , new string[] {"Id", "Xác nhận thanh toán", "Xác nhận chi trả","Chọn in", "Đợt chi trả","Khoa xác nhận","Ngày thanh toán","Mã giảng viên", "Họ", "Tên", "Chức danh", "Tên khoa - Bộ môn", "Mã môn học", "Tên môn học", "Bậc đào tạo"
                        , "Mã lớp học phần", "Mã lớp", "Tiết thực dạy", "Sĩ số"
                        , "HS Chức danh", "HS Địa điểm", "HS Lớp đông", "Hệ số lương", "Hệ số ngoài giờ HC", "HS thỉnh giảng môn chuyên ngành", "Hệ số môn mới", "Tổng hệ số"
                        , "Tiết quy đổi", "Đơn giá", "Thành tiền", "Thù lao vượt giờ"
                        , "Tạm trừ thuế", "Thực chuyển", "Số tài khoản", "Ngân hàng", "Mã số thuế", "CMND", "Loại giảng viên", "DotChiTra" }
                    , new int[] { 20,50, 50,50, 100,120,85,100, 110, 45, 110, 120, 80, 150, 110, 80, 100, 80, 70, 80, 80, 80, 80, 80, 100, 100, 100, 80, 100
                        , 110, 90, 100, 100, 100, 150, 90, 80, 99, 99 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] {"Id","DaChiTra", "XacNhanChiTra", "TenDotChiTra","NgayChonThanhToan","NgayXacNhanThanhToan","ChonIn","MaQuanLy", "Ho", "Ten", "ChucDanh", "TenDonVi", "MaMonHoc", "TenMonHoc", "MaBacDaoTao"
                , "MaLopHocPhan", "MaLop", "TietThucDay", "SiSo", "HeSoChucDanhChuyenMon", "HeSoCoSo", "HeSoLopDong", "HeSoLuong", "HeSoNgoaiGio"
                , "HeSoThinhGiangMonChuyenNganh", "HeSoMonMoi", "TongHeSo", "TietQuyDoi", "DonGia", "ThanhTien", "ThuLaoVuotGio", "TamTruThue", "ThucChuyen", "SoTaiKhoan", "TenNganHang", "MaSoThue", "Cmnd", "TenLoaiGiangVien" }, DevExpress.Utils.HorzAlignment.Center);
            #endregion
            //AppGridView.ShowField(gridViewThongKe, strIDColumns, strFileColumns, iSizeColumns);
            //AppGridView.AlignHeader(gridViewThongKe, strIDColumns, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewThongKe, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThuLaoVuotGio", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TamTruThue", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThucChuyen", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.ReadOnlyColumn(gridViewThongKe);
            AppGridView.HideField(gridViewThongKe, new string[] { "Id", "DaChiTra", "XacNhanChiTra", "DotChiTra" });
            AppGridView.AllowEditColumn(gridViewThongKe, new string[] { "DaChiTra", "XacNhanChiTra", "ChonIn" });
            gridViewThongKe.Columns["TenLoaiGiangVien"].GroupIndex = 0;

            PMS.Common.Globals.WordWrapHeader(gridViewThongKe, 55);




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
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion
            #region _lanChot
            AppGridLookupEdit.InitGridLookUp(cboLanChot, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLanChot, new string[] { "LanChot" }, new string[] { "Lần chốt" });
            cboLanChot.Properties.ValueMember = "LanChot";
            cboLanChot.Properties.DisplayMember = "LanChot";
            cboLanChot.Properties.NullText = string.Empty;
            #endregion
            #region Init Khoa-DonVi
            cboDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboDonVi.Properties.Items.Clear();
            VList<ViewKhoaBoMon> _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                if (_groupName == v.MaBoMon)
                {
                    userRole = true;
                    break;
                }                

            }
            if (userRole)
            {
                _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetByMaBoMon(_groupName);
                Showbutton(0);
            }
            else
            {
                //_vListKhoa.Add(new ViewKhoaBoMon() { MaBoMon = "-1", TenBoMon = "[Tất cả]", MaKhoa = "-1", TenKhoa = "[Tất cả]", ThuTu = 0 });
                if (PMS.Common.XuLySo.KiemTraChuoiToanSo(_groupName) == false)//ma khong phai la so thi vao
                {
                    btnLuuChiTra.Enabled = false;
                    layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    AppGridView.ShowField(gridViewThongKe, new string[] { "XacNhanChiTra" });
                    gridViewThongKe.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
                    btnKeToaXacNhanChiTra.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }
                else
                {
                    Showbutton(0);
                }
            }
            VisableColumns(!userRole);

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaKhoa, v.TenKhoa, CheckState.Unchecked, true));
            }
            cboDonVi.Properties.Items.AddRange(_list.ToArray());
            cboDonVi.Properties.SeparatorChar = ';';
            cboDonVi.CheckAll();
            #endregion
            #region Init LoaiGiangVien
            cboLoaiGiangVien.Properties.SelectAllItemCaption = "Tất cả";
            cboLoaiGiangVien.Properties.TextEditStyle = TextEditStyles.Standard;
            cboLoaiGiangVien.Properties.Items.Clear();

            TList<LoaiGiangVien> _listLoaiGv = new TList<LoaiGiangVien>();
            _listLoaiGv = DataServices.LoaiGiangVien.GetAll();

            List<CheckedListBoxItem> _listLGV = new List<CheckedListBoxItem>();
            foreach (LoaiGiangVien v in _listLoaiGv)
            {
                _listLGV.Add(new CheckedListBoxItem(v.MaLoaiGiangVien.ToString(), v.TenLoaiGiangVien, CheckState.Unchecked, true));
            }
            cboLoaiGiangVien.Properties.Items.AddRange(_listLGV.ToArray());
            cboLoaiGiangVien.Properties.SeparatorChar = ';';
            cboLoaiGiangVien.CheckAll();
            #endregion
        }

        private void ucThongKeChiTietGioGiangBUH_Load(object sender, EventArgs e)
        {
            ShowFile();

            PMS.Common.Globals.GridRowColor(gridViewThongKe, new Font("Tahoma", 8), Color.Aqua, "XacNhanChiTra", "True");
            InitData();            
            gridViewThongKe.Columns["HeSoMonMoi"].Visible = true;
            
        }
        #endregion

        #region Thêm
        private void Showbutton(int iLoaiXacNhan)
        {
            btnLuuChiTra.Enabled = true;
            if (iLoaiXacNhan == 0)
                AppGridView.ShowField(gridViewThongKe, new string[] { "DaChiTra" });
            else
                AppGridView.ShowField(gridViewThongKe, new string[] { "XacNhanChiTra" });
            layoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            btnKeToaXacNhanChiTra.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }
        #endregion

        private void TrangThaiGiangVienBUH()
        {
            if (_maTruong == "BUH")
                GetAllTrangThaiGiangVien();
        }
        #region InitData()
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            TrangThaiGiangVienBUH();
            InitLanChot();
            LoadDataSource();

        }

        void LoadDataSource()
        {            
            if (cboNamHoc.EditValue != null && cboDonVi.EditValue != null && cboLanChot.EditValue != null)
            {
                dtData = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.ThongKeChiTietGioGiangBuh(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()
                    , cboDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()));
                dtData.Load(reader);
                dtData.Columns["DaChiTra"].ReadOnly = false;
                dtData.Columns["ChonIn"].ReadOnly = false;
                dtData.Columns["XacNhanChiTra"].ReadOnly = false;

                bindingSourceThongKe.DataSource = dtData;
                if (!userRole && PMS.Common.XuLySo.KiemTraChuoiToanSo(_groupName) == false)
                {
                    gridViewThongKe.ActiveFilterString = "[DaChiTra] = True";
                }
                //AppGridControl.chkKhoa(gridViewThongKe, dtData, "XacNhanChiTra", false);
                //HidenColumn();
            }
            
            gridViewThongKe.ExpandAllGroups();
        }

        private int checkxacnhanchitra(DataTable tbl)
        {
            int iResult = 0;
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                if (tbl.Rows[i]["DotChiTra"].ToString().Length == 0 && tbl.Rows[i]["NgayChonThanhToan"].ToString().Length > 0)
                {
                    iResult = 1;
                    break;
                }
            }
            return iResult;
        }


        void InitLanChot()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                cboLanChot.DataBindings.Clear();
                DataServices.KetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref lanchot);
                DataTable tblLanChot = new DataTable();
                tblLanChot.Columns.Add("LanChot");
                if (lanchot > 0)
                {
                    for (int i = lanchot; i >= 1; i--)
                    {
                        tblLanChot.Rows.Add(new string[] { i.ToString() });
                    }
                }
                bindingSourceLanChot.DataSource = tblLanChot;
                cboLanChot.DataBindings.Add("EditValue", bindingSourceLanChot, "LanChot", true, DataSourceUpdateMode.Never);
            }
        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            TrangThaiGiangVienBUH();
            Cursor.Current = Cursors.Default;
        }

        private void GetAllTrangThaiGiangVien()
        {
            lstTTGV = PMS.Common.KiemTraDuLieuDoiTuong.GetAllTTGV(string.Empty, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewThongKe.FocusedRowHandle = -1;
            bindingSourceThongKe.EndEdit();
            DataTable data = bindingSourceThongKe.DataSource as DataTable;
            if (data == null) return;
            DataTable vListBaoCao = new DataTable();
            try
            {
                int icheck = PMS.Common.XuLyGiaoDien.CheckedIn(gridViewThongKe, "ChonIn");
                if (icheck == 0)
                {
                    PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_ChonIn, MessageBoxIcon.Warning, true);
                    return;
                }
                vListBaoCao = data.Select("ChonIn = True").CopyToDataTable();
            }
            catch(Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_CanhBao, PMS.Common.ThongBao.Str_InLoiXayRa +" "+ex.Message.ToString(), MessageBoxIcon.Error, true);
                return;
            }

            using (frmChonNgay frmChon = new frmChonNgay())
            {
                frmChon.ShowDialog();
                _ngayIn = frmChon.NgayIn;
            }

            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewThongKe.SortedColumns)
                    {
                        switch (c.SortOrder)
                        {
                            case DevExpress.Data.ColumnSortOrder.Ascending:
                                sort += string.Format("{0} ASC, ", c.FieldName);
                                break;
                            case DevExpress.Data.ColumnSortOrder.Descending:
                                sort += string.Format("{0} DESC, ", c.FieldName);
                                break;
                        }
                    }
                }
                if (sort != "")
                    sort = sort.Substring(0, sort.Length - 2);
            }

            vListBaoCao.AcceptChanges();

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    string xmlData = "";
                    if (!string.IsNullOrEmpty(gridViewThongKe.ActiveFilterString))
                    {                        
                        DevExpress.Data.Filtering.CriteriaOperator op = gridViewThongKe.ActiveFilterCriteria; //filterControl1.FilterCriteria 
                        string filterString = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(op);

                        DataTable dtTmp = vListBaoCao.Copy();

                        dtTmp.DefaultView.RowFilter = filterString;
                        DataView dvFilter = dtTmp.DefaultView;
                        
                        foreach (DataRow r in dvFilter.ToTable().Rows)
                        {
                            xmlData += "<Professors MaGiangVien= \"" + r["MaGiangVien"]
                                    + "\" MaLop=\"" + r["MaLop"]
                                    + "\" MaLoaiGiangVien=\"" + r["MaLoaiGiangVien"]    
                                    + "\" TenDotChiTra    =\"" + r["TenDotChiTra"]                          
                                    + "\" />";
                        }
                        xmlData = "<Root>" + xmlData + "</Root>";
                      
                    }
                    else
                    {                        
                        foreach (DataRow r in vListBaoCao.Rows)
                        {
                            xmlData += "<Professors MaGiangVien= \"" + r["MaGiangVien"]
                                    + "\" MaLop=\"" + r["MaLop"]
                                    + "\" MaLoaiGiangVien=\"" + r["MaLoaiGiangVien"]
                                     + "\" TenDotChiTra    =\"" + r["TenDotChiTra"]
                                    + "\" />";
                        }
                        xmlData = "<Root>" + xmlData + "</Root>";
                       
                    }

                    DataTable tblNoiDungGiamTru = new DataTable("GiamDinhMuc");
                    IDataReader readerGiamTru = DataServices.KetQuaThanhToanThuLao.GetNoiDungGiamTruGioChuan(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()));
                    tblNoiDungGiamTru.Load(readerGiamTru);

                    DataTable tblKetQua = new DataTable("NoiDung");
                    IDataReader readerKQ = DataServices.KetQuaThanhToanThuLao.BangKeVuotGioGiangBuh(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()));
                    tblKetQua.Load(readerKQ);
                    DataSet dsData = new DataSet();
                    dsData.Tables.Add(tblNoiDungGiamTru);
                    dsData.Tables.Add(tblKetQua);

                    int iNoiDung = tblNoiDungGiamTru.Rows.Count;
                    int iKetQua = tblKetQua.Rows.Count;
                    if(iKetQua==0)
                    {
                        PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_LocDuLieu, MessageBoxIcon.Warning, true);
                        return;
                    }

                    frm.InThongKeChiTietGioGiangBUH(dsData, vListBaoCao, _ngayIn);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }


        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    if (sf.FileName != "")
                    {
                        gridControlThongKe.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue == null)
            {
                XtraMessageBox.Show("Lỗi chưa thiết lập năm học mặc định.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cboDonVi.EditValue == null)
            {
                XtraMessageBox.Show("Lỗi đơn vị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cboLanChot.EditValue == null)
            {
                XtraMessageBox.Show("Chưa chốt dữ liệu theo năm. " + cboNamHoc.EditValue.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                LoadDataSource();
            }
        }

        private void HidenColumn()
        {
            bool bvisible = false;
            if (dtData != null)
            {
                if (checkxacnhanchitra(dtData) == 1)
                {
                    bvisible = true;
                }
                
            }
            gridViewThongKe.Columns["NgayChonThanhToan"].Visible = bvisible;
        }

        private void VisableColumns(bool b)
        {
            gridViewThongKe.Columns["NgayXacNhanThanhToan"].Visible = b;
        }


        private void btnLuuChiTra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewThongKe.FocusedRowHandle = -1;
            DataTable tbl = bindingSourceThongKe.DataSource as DataTable;
            if (XtraMessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string xmlData = "";
                    //int _kiemTra = -1;
                    foreach (DataRow r in tbl.Rows)
                    {
                        if (r.RowState == DataRowState.Modified)
                        {
                            string strNgayXNTT = DateTime.Now.ToString("dd/MM/yyyy") + " " + DateTime.Now.ToString("hh:mm:ss");
                            strNgayXNTT = PMS.Common.XuLyGiaoDien.ConvertMMDDYYYY(strNgayXNTT);
                            xmlData += String.Format("<Input I=\"{0}\" N=\"{1}\" NgayXNTT=\"{2}\" />", r["Id"], r["DaChiTra"], strNgayXNTT);
                        }
                    }
                    xmlData = String.Format("<Root>{0}</Root>", xmlData);
                    int kq = 0;
                    DataServices.KetQuaThanhToanThuLao.LuuChiTra(xmlData, ref kq);
                    if (kq == 0)
                    {
                        PMS.Common.XuLyGiaoDien.ThongBao("Thông báo", PMS.Common.ThongBao.Str_LuuThayDoiThanhCong, MessageBoxIcon.Information, true);
                        UncheckCheck(false);
                    }

                    else PMS.Common.XuLyGiaoDien.ThongBao("Thông báo", PMS.Common.ThongBao.Str_LuuLoiXayRa, MessageBoxIcon.Error, true);

                }
                catch
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            InitData();
        }



        private void btnKeToaXacNhanChiTra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewThongKe.FocusedRowHandle = -1;
            DataTable tbl = bindingSourceThongKe.DataSource as DataTable;
            try
            {
                using (frmChonDotThanhToan frm = new frmChonDotThanhToan(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()))
                {
                    frm.ShowDialog();
                    if (!frm.XacNhan)
                        return;
                    _dotChiTra = frm.IdDot;
                    _ngayChiTra = DateTime.Now.ToShortDateString();
                }

                string xmlData = "";
                foreach (DataRow r in tbl.Rows)
                {
                    if (r.RowState == DataRowState.Modified)
                        xmlData += String.Format("<Input I=\"{0}\" N=\"{1}\" />", r["Id"], r["XacNhanChiTra"]);
                }
                xmlData = String.Format("<Root>{0}</Root>", xmlData);
                int kq = 0;
                DataServices.KetQuaThanhToanThuLao.KeToanXacNhanThanhToan(xmlData, _dotChiTra, _ngayChiTra, ref kq);
                if (kq == 0)
                {
                    int kq2 = -1;
                    DataServices.TietNoKyTruoc.LuuSauChiTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()), ref kq2);
                    if (kq2 == 0)
                        XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UncheckCheck(false);
                }
                else
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                LoadDataSource();
            }
            catch
            {
                XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitLanChot();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitLanChot();
            Cursor.Current = Cursors.Default;
        }
        #endregion


        #region Event CheckEdit
        //Khoa xác nhận
        private void checkEditDaThanhToanTatCa_CheckedChanged(object sender, EventArgs e)
        {
            PMS.Common.XuLyGiaoDien.CheckAll(gridViewThongKe, "DaChiTra", Convert.ToBoolean(checkEditDaThanhToanTatCa.EditValue.ToString()));
        }


        private void checkEditInTatCa_CheckedChanged_1(object sender, EventArgs e)
        {
            PMS.Common.XuLyGiaoDien.CheckAll(gridViewThongKe, "ChonIn", Convert.ToBoolean(checkEditInTatCa.EditValue.ToString()));
        }


        //Kế toán xác nhận
        private void checkEditKeToanXacnhan_CheckedChanged(object sender, EventArgs e)
        {
            PMS.Common.XuLyGiaoDien.CheckAll(gridViewThongKe, "XacNhanChiTra", Convert.ToBoolean(checkEditKeToanXacnhan.EditValue.ToString()));
        }
        #endregion

        private void gridViewThongKe_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView View = sender as GridView;
            if (View.FocusedColumn.FieldName == "XacNhanChiTra")
            {
                string cellValue = View.GetRowCellValue(View.FocusedRowHandle, "MaQuanLy").ToString();
                string strHoTen = View.GetRowCellValue(View.FocusedRowHandle, "HoTen").ToString();
                bool bchk = AppGridControl.chkKhoa(lstTTGV, cellValue);
                e.Cancel = bchk;
                if (bchk)
                {
                    XtraMessageBox.Show("Giảng viên " + strHoTen + " " + PMS.Common.ThongBao.LST_TrangThaiGiangVien.ToString(), "Thông báo", MessageBoxButtons.OK);
                }
            }
            else if (View.FocusedColumn.FieldName == "DaChiTra")
            {
                bool bDisableIn = PMS.Common.XuLyGiaoDien.DisableCellRows(View, "XacNhanChiTra", View.FocusedRowHandle, "True");
                if (View.FocusedColumn.FieldName == "DaChiTra" && bDisableIn)
                {
                    e.Cancel = true;
                    XtraMessageBox.Show("Không thể thay đổi dòng dữ liệu kế toán đã thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void gridViewThongKe_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //if (e.Column.FieldName == "DaChiTra")
            //{
            //    int _kiemTra = -1;
            //    DataRowView r = gridViewThongKe.GetRow(e.RowHandle) as DataRowView;
            //    DataServices.KetQuaThanhToanThuLao.KiemTraTinhTrangKeToanChiTra(int.Parse(r["Id"].ToString()), ref _kiemTra);
            //    if (_kiemTra != 0)
            //    {
            //        XtraMessageBox.Show("Không thể thay đổi dòng dữ liệu kế toán đã thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        LoadDataSource();
            //    }
            //}
        }

        void UncheckCheck(bool b)
        {
            checkEditDaThanhToanTatCa.Checked = b;
            checkEditKeToanXacnhan.Checked = b;
        }
    }
}
