using DevExpress.Common.Grid;
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
        }

        private void ucTietNghiaVuTheoNamHoc_Load(object sender, EventArgs e)
        {
            try
            {
                #region Init GirdView           
                AppGridView.InitGridView(gridViewTietNghiaVu, true, true, GridMultiSelectMode.RowSelect, false, true);
                AppGridView.ShowField(gridViewTietNghiaVu, new string[] { "MaGiangVien", "MaQuanLy", "HoTen"
                        , "TenDonVi", "TenChucVu", "NhomGiangVien"
                        , "DinhMucGiangDay", "DinhMucNckh", "DinhMucKhac", "TongDinhMuc"
                        , "DinhMucThucTeGiangDay", "DinhMucThucTeNckh", "DinhMucThucTeKhac", "TongDinhMucThucTe"
                        , "TietNghiaVuHk01", "TietNghiaVuHk02", "GhiChu", "ThayDoi" }
                    , new string[] { "MaGiangVien", "Mã", "Họ tên", "Đơn vị", "Chức vụ", "Nhóm giảng viên"
                        , "Định mức giảng dạy", "Định mức NCKH", "Định mức HTBD & khác", "Tổng định mức"
                        , "Định mức thực tế giảng dạy", "Định mức thực tế NCKH", "Định mức thực tế HTBD & khác", "Tổng định mức thực tế"
                        , "Định mức thực tế HK01", "Định mức thực tế HK02", "Ghi chú", "ThayDoi" }
                    , new int[] { 50, 70, 130, 150, 100, 150, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 300, 50 });
                AppGridView.AlignHeader(gridViewTietNghiaVu, new string[] { "MaGiangVien", "MaQuanLy", "HoTen", "TenDonVi", "TenChucVu", "NhomGiangVien"
                        , "DinhMucGiangDay", "DinhMucNckh", "DinhMucKhac", "TongDinhMuc"
                        , "DinhMucThucTeGiangDay", "DinhMucThucTeNckh", "DinhMucThucTeKhac", "TongDinhMucThucTe"
                        , "TietNghiaVuHk01", "TietNghiaVuHk02", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
                AppGridView.ReadOnlyColumn(gridViewTietNghiaVu, new string[] { "MaGiangVien", "MaQuanLy", "HoTen", "TenDonVi", "TenChucVu", "NhomGiangVien"
                        //, "DinhMucGiangDay", "DinhMucNckh", "DinhMucKhac", "TongDinhMuc"
                        //, "DinhMucThucTeGiangDay", "DinhMucThucTeNckh", "DinhMucThucTeKhac", "TongDinhMucThucTe"
                        //, "TietNghiaVuHk01", "TietNghiaVuHk02", "GhiChu"
                    });
                AppGridView.HideField(gridViewTietNghiaVu, new string[] { "MaGiangVien", "ThayDoi" });
                AppGridView.FixedField(gridViewTietNghiaVu, new string[] { "MaGiangVien", "MaQuanLy", "HoTen" }, FixedStyle.Left);
                AppGridView.FormatDataField(gridViewTietNghiaVu, new string[] { "DinhMucGiangDay", "DinhMucNckh", "DinhMucKhac", "TongDinhMuc"
                        , "DinhMucThucTeGiangDay", "DinhMucThucTeNckh", "DinhMucThucTeKhac", "TongDinhMucThucTe"
                        , "TietNghiaVuHk01", "TietNghiaVuHk02" }, DevExpress.Utils.FormatType.Custom, "n2");
                AppGridView.SummaryField(gridViewTietNghiaVu, "MaQuanLy", "{0} GV", DevExpress.Data.SummaryItemType.Count);
                AppGridView.SummaryField(gridViewTietNghiaVu, new string[] { "DinhMucGiangDay", "DinhMucNckh", "DinhMucKhac", "TongDinhMuc"
                        , "DinhMucThucTeGiangDay", "DinhMucThucTeNckh", "DinhMucThucTeKhac", "TongDinhMucThucTe"
                        , "TietNghiaVuHk01", "TietNghiaVuHk02" }, "{0:n2}", DevExpress.Data.SummaryItemType.Sum);
                AppGridView.BackColorFieldAppearance(gridViewTietNghiaVu, new string[] { "DinhMucGiangDay", "DinhMucThucTeGiangDay" }, Color.FromArgb(220, 230, 255));
                AppGridView.BackColorFieldAppearance(gridViewTietNghiaVu, new string[] { "DinhMucNckh", "DinhMucThucTeNckh" }, Color.FromArgb(230, 255, 245));
                AppGridView.BackColorFieldAppearance(gridViewTietNghiaVu, new string[] { "DinhMucKhac", "DinhMucThucTeKhac" }, Color.FromArgb(250, 250, 230));
                PMS.Common.Globals.WordWrapHeader(gridViewTietNghiaVu, 40);
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
                cboHocKy.EditValue = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Học kỳ hiện tại");
                #endregion               

                InitData();
            }
            catch (Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
            }
        }

        #region InitData
        void InitData()
        {
            if (cboNamHoc.EditValue == null)
            {
                bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            }
            if (cboHocKy.EditValue == null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                LoadDataSource(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

        void LoadDataSource(string strNamHoc, string strHocKy)
        {
            DataTable tb = new DataTable();
            IDataReader reader;
            reader = DataServices.TietNghiaVu.GetByNamHocHocKy(strNamHoc, strHocKy);
            tb.Load(reader);
            foreach (DataColumn col in tb.Columns)
                col.ReadOnly = false;
            bindingSourceTietNghiaVu.DataSource = tb;
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
                if (dSumTietnghiaVuGiangDay.ToString() != tbl.Rows[i]["TietnghiaVuGiangDay"].ToString()
                     || dSumTietNghiaVuNckh.ToString() != tbl.Rows[i]["TietNghiaVuNckh"].ToString()
                     )
                {

                    ToMauIndex.Add(tbl.Rows[i]["MaQuanLy"].ToString());
                }
                string strMaQuanLy = tbl.Rows[i]["MaQuanLy"].ToString();
                bool bchk = AppGridControl.chkKhoa(lstTTGV, strMaQuanLy);
                if (bchk)
                {
                    if (LstIdMaGV.Count == 0)
                        LstIdMaGV.Add(strMaQuanLy);
                    else
                    {
                        for (int j = 0; j < LstIdMaGV.Count; j++)
                        {
                            if (LstIdMaGV[j].ToString() != strMaQuanLy)
                                LstIdMaGV.Add(strMaQuanLy);
                        }
                    }
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
                            if ((bool)kl["ThayDoi"])
                            {
                                string[] MangKiTu = { "<=", ">=", "<", ">" };
                                string[] MangMoTa = { "nhỏ hơn bằng", "lớn hơn bằng", "nhỏ hơn_", "lớn hơn_" };
                                string strGhiChu = kl["GhiChu"].ToString();
                                for (int i = 0; i < MangKiTu.Length; i++)
                                {
                                    strGhiChu = strGhiChu.Replace(MangKiTu[i], MangMoTa[i]);
                                }
                                xmlData += String.Format (
                                    "<Input M=\"{0}\" DMGD=\"{1}\" DMNCKH=\"{2}\" DMK=\"{3}\" TDM=\"{4}\" DMTTGD=\"{5}\" DMTTNCKH=\"{6}\"  DMTTK=\"{7}\" TDMTT=\"{8}\" TNVHK1=\"{9}\" TNVHK2=\"{10}\" GC=\"{11}\" />"
                                    , kl["MaGiangVien"]
                                    , PMS.Common.Globals.IsNull(kl["DinhMucGiangDay"], "int").ToString()
                                    , PMS.Common.Globals.IsNull(kl["DinhMucNckh"], "decimal")
                                    , PMS.Common.Globals.IsNull(kl["DinhMucKhac"], "decimal")
                                    , PMS.Common.Globals.IsNull(kl["TongDinhMuc"], "decimal")
                                    , PMS.Common.Globals.IsNull(kl["DinhMucThucTeGiangDay"], "decimal")
                                    , PMS.Common.Globals.IsNull(kl["DinhMucThucTeNckh"], "decimal")
                                    , PMS.Common.Globals.IsNull(kl["DinhMucThucTeKhac"], "decimal")
                                    , PMS.Common.Globals.IsNull(kl["TongDinhMucThucTe"], "decimal")
                                    , PMS.Common.Globals.IsNull(kl["TietNghiaVuHk01"], "decimal")
                                    , PMS.Common.Globals.IsNull(kl["TietNghiaVuHk02"], "decimal")
                                    , strGhiChu
                                );
                            }
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
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi:" + ex.Message + "\n" + ex.StackTrace, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            InitData();
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
            InitData();
        }

        private void gridViewTietNghiaVu_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if(e.Column.FieldName != "ThayDoi")
            {
                gridViewTietNghiaVu.SetRowCellValue(e.RowHandle, "ThayDoi", true);
                AppGridView.GridRowAppearance(gridViewTietNghiaVu, "ThayDoi", DevExpress.XtraGrid.FormatConditionEnum.Equal, "True", Color.FromArgb(230, 220, 255));
            }
        }
    }
}
