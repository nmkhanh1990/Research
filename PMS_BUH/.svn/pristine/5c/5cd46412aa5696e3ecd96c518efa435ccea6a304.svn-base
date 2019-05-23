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
    public partial class ucBangTongHopGioGiangCacKhoaVien_HBU : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable 
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string strMaTruong;
        VList<ViewKhoa> _listKhoaDonVi;
        int lanchot = 0;
        #endregion

        #region Even Form
        public ucBangTongHopGioGiangCacKhoaVien_HBU()
        {
            InitializeComponent();
            strMaTruong = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Mã trường");
        }

        private void ucThanhToanThuLaoUTE_Load(object sender, EventArgs e)
        {
            #region InitGridView
            ShowDataColumns();
            InitData();          
            
        }
        #endregion

        void ShowDataColumns()
        {
            AppGridView.InitGridView(gridViewThanhToan, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewThanhToan, new string[] {  "TenDonVi","TenBacDaoTao","TongGioLT","TongGioTH","TongGioTHQuyDoi","TongGio","HeSoNgoaiGio","HeSoChucDanh","HeSoLopDong","HeSoNganh","TongGioQD" }
                                                   , new string[] { "Tên khoa", "Bậc đào tạo", "Tổng giờ LT", "Tổng giờ TH", "Tổng giờ TH quy đổi", "Tổng giờ", "HS ngoài giờ", "HS chức danh", "HS lớp đông", "HS Ngành", "Tổng giờ chuẩn QD"}
                                                   , new int[] { 150, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 });
            AppGridView.AlignHeader(gridViewThanhToan, new string[] { "TenDonVi", "TenBacDaoTao", "TongGioLT", "TongGioTH", "TongGioTHQuyDoi", "TongGio", "HeSoNgoaiGio", "HeSoChucDanh", "HeSoLopDong", "HeSoNganh", "TongGioQD" }, DevExpress.Utils.HorzAlignment.Center);
            //AppGridView.SummaryField(gridViewThanhToan, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);    
            AppGridView.ReadOnlyColumn(gridViewThanhToan);
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Năm học hiện tại");
            #endregion

            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            
            #endregion

            #region Khoa-DonVi
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaKhoa", "TenKhoa" }, new string[] { "Mã khoa", "Tên khoa" }, new int[] { 80, 130 });
            cboKhoaDonVi.Properties.ValueMember = "MaKhoa";
            cboKhoaDonVi.Properties.DisplayMember = "TenKhoa";
            cboKhoaDonVi.Properties.NullText = string.Empty;

            #endregion

            #region Lần chốt
            AppGridLookupEdit.InitGridLookUp(cboLanchot, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLanchot, new string[] { "LanChot" }, new string[] { "Lần chốt" });
            cboLanchot.Properties.ValueMember = "LanChot";
            cboLanchot.Properties.DisplayMember = "LanChot";
            cboLanchot.Properties.NullText = string.Empty;
            #endregion
        }

        void InitLanChot()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                cboLanchot.DataBindings.Clear();
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
                bindingSourceLanchot.DataSource = tblLanChot;
                cboLanchot.DataBindings.Add("EditValue", bindingSourceLanchot, "LanChot", true, DataSourceUpdateMode.Never);
            }
        }

        void InitKhoa()
        {
            _listKhoaDonVi = DataServices.ViewKhoa.GetAll();
            _listKhoaDonVi.Insert(0, new ViewKhoa() { ThuTu = -1, MaKhoa = "-1", TenKhoa = "[Tất cả]" });
            bindingSourceKhoaDonVi.DataSource = _listKhoaDonVi;
            cboKhoaDonVi.DataBindings.Clear();
            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaKhoa", true, DataSourceUpdateMode.Never);
        }

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                cboHocKy.EditValue = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Học kỳ hiện tại");
            }
            InitKhoa();
            InitLanChot();
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null && cboLanchot.EditValue != null)
                initData();
        }
        #endregion

        void LoadData(string strNamHoc, string strHocky, string strMaKhoa)
        {
            DataTable tbl = new DataTable();
            IDataReader idr = DataServices.KetQuaThanhToanThuLao.BangTongHopGioGiangCacKhoa_Vien_HBU(strNamHoc, strHocky, strMaKhoa,Convert.ToInt32( cboLanchot.EditValue.ToString()));
            tbl.Load(idr);
            bindingSourceThanhToan.DataSource = tbl;
            gridControlThanhToan.DataSource = bindingSourceThanhToan;
        }

        #region Event Button
        private void btnLoc_Click(object sender, EventArgs e)
        {
            initData();
        }

        private void initData()
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null && cboLanchot.EditValue != null)
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
                    INBaoCao(PMS.Common.Globals._cauhinh.TenTruong, vListBaoCao);
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
            }
           
        }
        #endregion
                
        private void rdb_Baocao_SelectedIndexChanged(object sender, EventArgs e)
        {
            PMS.Common.XuLyGiaoDien.SelectedIndexChanged(sender, e,btnIn);
        }

        void INBaoCao(string strChon, DataTable lsttbl)
        {
            using (frmBaoCao frm = new frmBaoCao())
            {               
                frm.InBangTongHopGioGiangCacKhoaVien_HBU(strChon, lsttbl);            
                frm.ShowDialog();

            }
        }
    }
}
