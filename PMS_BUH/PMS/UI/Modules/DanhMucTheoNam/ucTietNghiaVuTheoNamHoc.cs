﻿using DevExpress.Common.Grid;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using PMS.Entities;
using PMS.Services;
using PMS.UI.Forms.NghiepVu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PMS.UI.Modules.DanhMucTheoNam
{
    public partial class ucTietNghiaVuTheoNamHoc : DevExpress.XtraEditors.XtraUserControl
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ItemShortcut = DevExpress.XtraBars.BarShortcut.Empty;


                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnSaoChep.ItemShortcut = DevExpress.XtraBars.BarShortcut.Empty;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        TList<GiamTruDinhMuc> _listGiamTruKhac = new TList<GiamTruDinhMuc>();
        TList<TrangThaiGiangVien> lstTTGV;
        string _maTruong = string.Empty;
        string strTenTruong = string.Empty;
        string icboHocKyindex = string.Empty;
        List<string> ToMauIndex = new List<string>();
        List<string> LstIdMaGV = new List<string>();
        List<int> LstIndexReadOnly;
        #endregion

        public ucTietNghiaVuTheoNamHoc()
        {
            InitializeComponent();
            _maTruong = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Mã trường");
            strTenTruong = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Tên trường");
            lstTTGV = new TList<TrangThaiGiangVien>();
            LstIndexReadOnly = new List<int>();

        }

        private void GetAllTrangThaiGiangVien()
        {
            lstTTGV = PMS.Common.KiemTraDuLieuDoiTuong.GetAllTTGV(string.Empty, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }       
        private void ucTietNghiaVuTheoNamHoc_Load(object sender, EventArgs e)
        {
            try
            {
                #region Init GirdView           
                InitGrid();
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
               
                InitData();
            }
            catch (Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
            }
        }

        #region InitGridView { }
       
        void InitGrid()
        {
            AppGridView.InitGridView(gridViewTietNghiaVu, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewTietNghiaVu, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "TietNghiaVuGiangDayBanDau", "TietNghiaVuNckhBanDau", "DinhMucToiThieuCuaChucVu", "TietGiangDayGiamDoChucVu", "TietNo_BaoLuuGiangDay", "TietNo_BaoLuuNcKh", "TietGiangDayDuocGiam", "SumTietnghiaVuGiangDay", "TietNckhDuocGiam", "SumTietNghiaVuNckh","TongTietNghiaVu", "MaGiangVien", "LyDo","GhiChu" }
                , new string[] { "Khoa - Đơn vị", "Mã giảng viên", "Họ và tên", "Học hàm", "Học vị", "Chức vụ", "Định mức GC giảng dạy", "Định mức GC NCKH", "Định mức do chức vụ (%)", "Tiết giảng dạy được giảm", "Giờ chuẩn giảng dạy nợ/bảo lưu", "Giờ chuẩn NCKH nợ/bảo lưu", "Tổng giờ chuẩn giảng dạy", "Tổng giờ chuẩn giảng dạy đã lưu", "Tổng giờ chuẩn NCKH", "Tổng giờ chuẩn NCKH đã lưu","Tổng tiết nghĩa vụ", "MaGiangVien", "Lý do","Ghi chú" }
                , new int[] { 100, 110, 130, 90, 80, 100, 90, 90, 100, 90,  110, 100, 90, 90, 90, 90,100, 50, 300,300 });
            AppGridView.AlignHeader(gridViewTietNghiaVu, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenChucVu", "TietNghiaVuGiangDayBanDau", "TietNghiaVuNckhBanDau", "DinhMucToiThieuCuaChucVu", "TietGiangDayGiamDoChucVu", "TietNo_BaoLuuGiangDay", "TietNo_BaoLuuNcKh", "TietGiangDayDuocGiam", "SumTietnghiaVuGiangDay", "TietNckhDuocGiam", "SumTietNghiaVuNckh", "TongTietNghiaVu", "MaGiangVien","LyDo", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTietNghiaVu, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewTietNghiaVu, new string[] { "TenDonVi", "TenHocHam", "TenHocVi", "TenChucVu", "TietNghiaVuGiangDayBanDau", "TietNghiaVuNckhBanDau", "DinhMucToiThieuCuaChucVu",  "TietNo_BaoLuuGiangDay", "TietNo_BaoLuuNcKh", "MaGiangVien", "TietGiangDayDuocGiam", "TietNckhDuocGiam", "TongTietNghiaVu" });

            AppGridView.HideField(gridViewTietNghiaVu, new string[] { "MaGiangVien" });
            AppGridView.FixedField(gridViewTietNghiaVu, new string[] { "MaQuanLy", "HoTen" }, FixedStyle.Left);
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TietNghiaVuGiangDayBanDau", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TietNghiaVuNckhBanDau", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "SumTietnghiaVuGiangDay", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "SumTietNghiaVuNckh", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TietGiangDayDuocGiam", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TietNckhDuocGiam", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TongTietNghiaVu", DevExpress.Utils.FormatType.Custom, "n2");
            gridViewTietNghiaVu.Columns["TenDonVi"].GroupIndex = 0;
            PMS.Common.Globals.WordWrapHeader(gridViewTietNghiaVu, 35);
        }
        #endregion

        #region InitData
        void InitData()
        {
            _listGiamTruKhac = DataServices.GiamTruDinhMuc.GetAll();
            bindingSourceGiamTruKhac.DataSource = _listGiamTruKhac;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            cboNamHoc.EditValue = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Năm học hiện tại");
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
               
                cboHocKy.EditValue = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Học kỳ hiện tại");
            }
            LoadDataSource(cboNamHoc.EditValue.ToString(),cboHocKy.EditValue.ToString());
        }

        void LoadDataSource(string strNamHoc,string strHocKy)
        {
            DataTable tb = new DataTable();
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                IDataReader reader = DataServices.TietNghiaVu.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tb.Load(reader);
            }
            foreach (DataColumn col in tb.Columns)
                col.ReadOnly = false;
            bindingSourceTietNghiaVu.DataSource = tb;
            if (_maTruong == "BUH")
            {
                GetAllTrangThaiGiangVien();
                ToMau(tb);
            }
            gridViewTietNghiaVu.ExpandAllGroups();
        }
        #endregion

        #region Thêm
        private void ToMau(DataTable tbl)
        {
            ToMauIndex.Clear();
            LstIdMaGV.Clear();
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                decimal dSumTietnghiaVuGiangDay = decimal.Parse(tbl.Rows[i]["SumTietnghiaVuGiangDay"].ToString());
                decimal dSumTietNghiaVuNckh = decimal.Parse(tbl.Rows[i]["SumTietNghiaVuNckh"].ToString());
                if (dSumTietnghiaVuGiangDay.ToString() != tbl.Rows[i]["TietGiangDayDuocGiam"].ToString()
                     || dSumTietNghiaVuNckh.ToString() != tbl.Rows[i]["TietNckhDuocGiam"].ToString()
                   )
                {
                    ToMauIndex.Add(tbl.Rows[i]["MaQuanLy"].ToString());
                }
                string strMaQuanLy = tbl.Rows[i]["MaQuanLy"].ToString();
                bool bchk = AppGridControl.chkKhoa(lstTTGV, strMaQuanLy);
                if (bchk)
                {
                    if(!LstIdMaGV.Contains(strMaQuanLy)) LstIdMaGV.Add(strMaQuanLy);
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

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewTietNghiaVu.FocusedRowHandle = -1;
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataTable list = bindingSourceTietNghiaVu.DataSource as DataTable;
                if (list != null)
                {
                    try
                    {
                        string xmlData = "";
                        foreach (DataRow kl in list.Rows)
                        {
                            //if (kl.RowState == DataRowState.Modified)
                            //{
                            string[] MangKiTu = { "<=", ">=", "<", ">" };
                            string[] MangMoTa = { "nhỏ hơn bằng", "lớn hơn bằng", "nhỏ hơn_", "lớn hơn_" };
                            string strGhiChu = kl["LyDo"].ToString();
                            for (int i = 0; i < MangKiTu.Length; i++)
                            {
                                strGhiChu = strGhiChu.Replace(MangKiTu[i], MangMoTa[i]);
                            }
                            xmlData += String.Format("<Input M=\"{0}\" G=\"{1}\" TG=\"{2}\" GD=\"{3}\" NC=\"{4}\" QL=\"{5}\" C=\"{6}\"  GK=\"{7}\" NK=\"{8}\" GC=\"{9}\" TDG=\"{10}\" TNG=\"{11}\" GhiChu=\"{12}\" />"
                                    , kl["MaGiangVien"]
                                    , PMS.Common.Globals.IsNull(kl["DinhMucToiThieuCuaChucVu"], "int").ToString()
                                    , PMS.Common.Globals.IsNull(kl["TietGiangDayGiamDoChucVu"], "decimal")
                                    , PMS.Common.Globals.IsNull(kl["SumTietNghiaVuGiangDay"], "decimal")
                                    , PMS.Common.Globals.IsNull(kl["SumTietNghiaVuNckh"], "decimal")
                                    , PMS.Common.Globals.IsNull(kl["SumTietNghiaVuQuanly"], "decimal")
                                    , 0
                                    , 0
                                    , 0
                                    , strGhiChu
                                    , PMS.Common.Globals.IsNull(kl["TietGiangDayDuocGiam"], "decimal")
                                    , PMS.Common.Globals.IsNull(kl["TietNckhDuocGiam"], "decimal")
                                     , kl["Ghichu"]
                                    );
                            //}
                        }
                        //xmlData = string.Format("<Root>{0}</Root>", xmlData);
                        xmlData = "<Root>" + xmlData + "</Root>";
                        bindingSourceTietNghiaVu.EndEdit();
                        int kq = 0;
                        DataServices.TietNghiaVu.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepTietNghiaVu"))
            {
                frm.ShowDialog();
            }
            InitData();
        }
        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                LoadDataSource(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

        #endregion

      

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlTietNghiaVu.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                icboHocKyindex = cboHocKy.EditValue.ToString();
                LoadDataSource(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

        private void gridViewTietNghiaVu_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            LstIndexReadOnly.Clear();
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string MaQuanLy = View.GetRowCellDisplayText(e.RowHandle, View.Columns["MaQuanLy"]);
                for (int i = 0; i < ToMauIndex.Count; i++)
                {
                    if (ToMauIndex[i].ToString() == MaQuanLy)
                    {
                        e.Appearance.BackColor = Color.Orange;
                    }
                }

                for (int i = 0; i < LstIdMaGV.Count; i++)
                {
                    if (LstIdMaGV[i].ToString() == MaQuanLy)
                    {
                        LstIndexReadOnly.Add(e.RowHandle);
                        e.Appearance.BackColor = Color.GreenYellow;

                    }
                }

            }

        }
        
    }
}
