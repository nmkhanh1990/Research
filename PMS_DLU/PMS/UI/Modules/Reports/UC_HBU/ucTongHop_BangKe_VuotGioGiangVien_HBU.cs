using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.DataForm;
using PMS.UI.Forms.BaoCao;


namespace PMS.UI.Modules.Reports
{
    public partial class ucTongHop_BangKe_VuotGioGiangVien_HBU : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable 
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        VList<ViewKhoa> _listKhoaDonVi;
        TList<LoaiGiangVien> _listLoaiGiangVien;
        #endregion

        #region Even Form
        public ucTongHop_BangKe_VuotGioGiangVien_HBU()
        {
            InitializeComponent();
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

        private void ucThanhToanThuLaoUTE_Load(object sender, EventArgs e)
        {
            #region InitGridView

            ShowDataColumns();
            InitData();
            EnableButtonEdit(false); 
            
        }
        #endregion

        void ShowDataColumns()
        {
            AppGridView.InitGridView(gridViewThanhToan, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewThanhToan, new string[] { "MaQuanLy", "HoTen", "TenKhoa", "MaMonHoc", "TenMonHoc", "STC", "SoTiet", "MalopHocPhan", "MaLop", "SiSo", "HeSoLopDongLT", "HeSoLopDongTH", "DonGia", "ThanhTien" }
                , new string[] { "Mã giảng viên", "Họ và tên", "Tên khoa", "Mã môn học", "tên môn học", "STC", "Số tiết", "Mã lớp học phần", "Mã lớp", "Sĩ số", "hệ số lớp động LT", "Hệ số lớp đông TH", "Đơn giá", "Thành tiền" }
                , new int[] { 80, 150, 200, 100, 180, 50, 70, 110, 90, 80, 120, 120, 100, 100 });
            AppGridView.AlignHeader(gridViewThanhToan, new string[] { "MaQuanLy", "HoTen", "TenKhoa", "MaMonHoc", "TenMonHoc", "STC", "SoTiet", "MalopHocPhan", "MaLop", "SiSo", "HeSoLopDongLT", "HeSoLopDongTH", "DonGia", "ThanhTien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThanhToan, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewThanhToan, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThanhToan, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.ReadOnlyColumn(gridViewThanhToan);
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

            #region Khoa-DonVi
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] {"TenKhoa" }, new string[] { "Tên khoa" }, new int[] { 80, 230 });
            cboKhoaDonVi.Properties.ValueMember = "MaKhoa";
            cboKhoaDonVi.Properties.DisplayMember = "TenKhoa";
            cboKhoaDonVi.Properties.NullText = string.Empty;

            #endregion

            #region LoaiGiangVien
            AppGridLookupEdit.InitGridLookUp(cboLoaiGiangVien, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLoaiGiangVien, new string[] {  "TenLoaiGiangVien" }, new string[] { "Tên loại giảng viên" });
            cboLoaiGiangVien.Properties.ValueMember = "MaLoaiGiangVien";
            cboLoaiGiangVien.Properties.DisplayMember = "TenLoaiGiangVien";
            cboLoaiGiangVien.Properties.NullText = string.Empty;
            #endregion
        }

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            InitKhoa();
            InitLoaiGiangVien();
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null )
                LoadData(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
        }


        void InitKhoa()
        {
            _listKhoaDonVi = DataServices.ViewKhoa.GetAll();
            _listKhoaDonVi.Insert(0, new ViewKhoa() { ThuTu = -1, MaKhoa = "-1", TenKhoa = "[Tất cả]" });
            bindingSourceKhoaDonVi.DataSource = _listKhoaDonVi;
            cboKhoaDonVi.DataBindings.Clear();
            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaKhoa", true, DataSourceUpdateMode.Never);
        }

        void InitLoaiGiangVien()
        {
            _listLoaiGiangVien = DataServices.LoaiGiangVien.GetAll();
            _listLoaiGiangVien.Insert(0, new LoaiGiangVien() { ThuTu = -1, MaLoaiGiangVien = -1, TenLoaiGiangVien = "[Tất cả]" });
            bindingSourceLoaiGiangVien.DataSource = _listLoaiGiangVien;
            cboLoaiGiangVien.DataBindings.Clear();
            cboLoaiGiangVien.DataBindings.Add("EditValue", bindingSourceLoaiGiangVien, "MaLoaiGiangVien", true, DataSourceUpdateMode.Never);

        }



        #endregion

        void LoadData(string strNamHoc, string strHocky, string strMaKhoa)
        {
            DataTable tbl = new DataTable();
            IDataReader idr = DataServices.KetQuaThanhToanThuLao.GetThongTinGiangVien(strNamHoc, strHocky, strMaKhoa,string.Empty);
            tbl.Load(idr);
            bindingSourceThanhToan.DataSource = tbl;
            gridControlThanhToan.DataSource = bindingSourceThanhToan;
        }

        #region Event Button
        private void btnLoc_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null )
                LoadData(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadData(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                gridViewThanhToan.FocusedRowHandle = -1;
                bindingSourceThanhToan.EndEdit();
                DataTable data = bindingSourceThanhToan.DataSource as DataTable;
                if (data == null)
                    return;
                DataTable vListBaoCao = data;
                vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThanhToan, vListBaoCao);
                string sort = "";
                if (vListBaoCao != null)
                {
                    if (vListBaoCao.Rows.Count != 0)
                    {
                        foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewThanhToan.SortedColumns)
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

                if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
                {
                    INBaoCao(rdb_Baocao.EditValue.ToString(), vListBaoCao);
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
            }

           
        }
        #endregion

        void EnableButtonEdit(bool b)
        {
            btnIn.Enabled = b;
        }

        private void rdb_Baocao_SelectedIndexChanged(object sender, EventArgs e)
        {
            PMS.Common.XuLyGiaoDien.SelectedIndexChanged(sender, e,btnIn);
        }

       void INBaoCao(string strChon,DataTable lsttbl)
        {
            using (frmBaoCao frm = new frmBaoCao())
            {

                DataTable tbl;
                IDataReader idr;
                string StrMaGiangVien = PMS.Common.XuLyChuoi.GetAllColumns(lsttbl, "MaQuanLy");
                switch (rdb_Baocao.EditValue.ToString())
                {
                    case "Bangkekhaigiogiang":
                        tbl = new DataTable();
                        idr = DataServices.KetQuaThanhToanThuLao.BangKeKhaiGioGiangCuaGiangVien_HBU(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), StrMaGiangVien);
                        tbl.Load(idr);                        
                        frm.InBangKeKhaiGioGiangCuaGiangVien_HBU(PMS.Common.Globals._cauhinh.TenTruong, tbl);                       
                        break;
                    case "Tonghopgiochuancuakhoa":
                        tbl = new DataTable();
                        idr = DataServices.KetQuaThanhToanThuLao.rptTongHopGioChuanCuaKhoa_HBU(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), StrMaGiangVien);
                        tbl.Load(idr);
                        frm.InTongHopGioChuanChuanCuaKhoa_HBU(PMS.Common.Globals._cauhinh.TenTruong, tbl);                       
                        break;
                    case "Bangtonghopvuotgiogiangviencohuu":
                        tbl = new DataTable();
                        idr = DataServices.KetQuaThanhToanThuLao.rptBangTongHopVuotGioGiangVienCoHuu_HBU(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), StrMaGiangVien);
                        tbl.Load(idr);
                        frm.InBangTongHopVuotGioGiangVienCoHuu_HBU(PMS.Common.Globals._cauhinh.TenTruong, tbl);
                        break;
                    default:
                        break;
                }
                frm.ShowDialog();

            }
        }
    }
}
