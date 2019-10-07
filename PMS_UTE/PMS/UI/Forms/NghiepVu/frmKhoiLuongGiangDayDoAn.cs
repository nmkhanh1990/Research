using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.Services;
using PMS.Common;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmKhoiLuongGiangDayDoAn : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLayDuLieuDoAn.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLayDuLieuDoAn.ItemShortcut = DevExpress.XtraBars.BarShortcut.Empty;

                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ItemShortcut = DevExpress.XtraBars.BarShortcut.Empty;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnLayDuLieuDoAn.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        VList<ViewGiangVien> _listGiangVien = new VList<ViewGiangVien>();
        TList<QuyDoiGioChuan> listQuyDoiGioChuan = DataServices.QuyDoiGioChuan.GetAll();
        int kiemtra = 0;
        #endregion

        #region Event Form
        public frmKhoiLuongGiangDayDoAn()
        {
            InitializeComponent();
        }

        private void frmKhoiLuongGiangDayDoAn_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewKhoiLuongDoAn, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongDoAn, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "Nhom", "SiSo", "MaGiangVienQuanLy", "NgayCapNhat", "SoTietQuyDoi", "HeSoHocKy", "DonGia", "ThanhTien" }
                    , new string[] { "Mã môn học", "Tên môn học", "Số tín chỉ", "Mã lớp học phần", "Mã lớp", "Nhóm", "Sĩ số", "Họ tên giảng viên", "Ngày cập nhật", "Tiết quy đổi", "Hệ số học kỳ", "Đơn giá", "Thành tiền" }
                    , new int[] { 100, 150, 90, 110, 100, 80, 80, 150, 120, 90, 90, 100, 100 });
            AppGridView.HideField(gridViewKhoiLuongDoAn, new string[] { "NgayCapNhat" });
            AppGridView.AlignHeader(gridViewKhoiLuongDoAn, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "Nhom", "SiSo", "MaGiangVienQuanLy", "HeSoHocKy", "SoTietQuyDoi", "DonGia", "ThanhTien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongDoAn, "MaMonHoc", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.RegisterControlField(gridViewKhoiLuongDoAn, "MaGiangVienQuanLy", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewKhoiLuongDoAn, "SiSo", repositoryItemSpinEditSiSo);
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongDoAn, new string[] { "SoTietQuyDoi", "DonGia", "ThanhTien" });
            AppGridView.FormatDataField(gridViewKhoiLuongDoAn, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoiLuongDoAn, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
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

            #region GiangVien 
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien" }, new string[] { "Mã giảng viên", "Họ tên", "Học hàm", "Học vị", "Loại giảng viên" }, new int[] { 90, 150, 120, 120, 120 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 600, 600);
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "HoTen";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            InitData();
        }
        #endregion

        #region InitData()
        void InitData()
        {
            _listGiangVien = DataServices.ViewGiangVien.GetAll();
            bindingSourceGiangVien.DataSource = _listGiangVien;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if(cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceKhoiLuongDoAn.DataSource = DataServices.KhoiLuongGiangDayDoAn.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }
        #endregion

        #region Event Button
        private void btLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLayDuLieuDoAn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataServices.ChotKhoiLuongGiangDay.KiemTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "DAMH", ref kiemtra);
                if (kiemtra == 1)
                {
                    XtraMessageBox.Show(string.Format("Khối lượng giảng dạy năm học {0} - {1} đã chốt, không được phép sửa đổi.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int kq = 0;
                DataServices.KhoiLuongGiangDayDoAn.KiemTraDongBo(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                if (kq == 0)
                {
                    using (frmDongBoDuLieuDoAnUIS frm = new frmDongBoDuLieuDoAnUIS(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "DAMH"))
                    {
                        frm.ShowDialog();
                    }
                    bindingSourceKhoiLuongDoAn.DataSource = DataServices.KhoiLuongGiangDayDoAn.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                }
                if (kq == 1)
                {
                    if (XtraMessageBox.Show(string.Format("Dữ liệu đồ án của năm học {0} - {1} đã có, tiếp tục lấy dữ liệu sẽ ghi đè dữ liệu cũ.\n Bạn có muốn tiếp tục?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (frmDongBoDuLieuDoAnUIS frm = new frmDongBoDuLieuDoAnUIS(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "DAMH"))
                        {
                            frm.ShowDialog();
                        }
                        bindingSourceKhoiLuongDoAn.DataSource = DataServices.KhoiLuongGiangDayDoAn.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    }
                    else return;
                }
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataServices.ChotKhoiLuongGiangDay.KiemTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "DAMH", ref kiemtra);
            if (kiemtra == 1)
            {
                XtraMessageBox.Show(string.Format("Khối lượng giảng dạy năm học {0} - {1} đã chốt, không được phép sửa đổi.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            gridViewKhoiLuongDoAn.FocusedRowHandle = -1;
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TList<KhoiLuongGiangDayDoAn> list = bindingSourceKhoiLuongDoAn.DataSource as TList<KhoiLuongGiangDayDoAn>;
                //if (list != null || list.Count > 0) 
                if (list != null)
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        QuyDoiGioChuan objQuyDoi = listQuyDoiGioChuan.Find(p => p.MaQuanLy == "DAMH");
                        TList<KhoanQuyDoi> listKhoanQuyDoi = new TList<KhoanQuyDoi>();
                        if (objQuyDoi != null)
                            listKhoanQuyDoi = DataServices.KhoanQuyDoi.GetByMaQuyDoi(objQuyDoi.MaQuyDoi);
                        //XuLyTapTin.OpenTextFileForWrite("QuyDoiKhoiLuongDoAn_log.txt");

                        TList<DonGia> listDonGia = DataServices.DonGia.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());

                        foreach (KhoiLuongGiangDayDoAn kl in list)
                        {
                            if (kl.MaGiangVienQuanLy != null)
                            {
                                
                                kl.SoTietQuyDoi = TinhTietQuyDoi(objQuyDoi, listKhoanQuyDoi, (int)kl.SiSo, (int)kl.SoTinChi) * kl.HeSoHocKy;
                                int _donGia = 0;

                                //XuLyTapTin.WriteTextFile("MaGiangVienQuanLy: " + kl.MaGiangVienQuanLy + "; NamHoc: " + kl.NamHoc + "; HocKy: " + kl.HocKy + Environment.NewLine);

                                DataServices.DonGiaNgoaiQuyChe.GetByMaQuanLyNamHocHocKyLopClc(kl.MaGiangVienQuanLy, kl.NamHoc, kl.HocKy, false, ref _donGia);
                                if (_donGia == 0)   //đồ án môn học tất cả lấy đơn giá theo đại trà
                                {
                                    //XuLyTapTin.WriteTextFile("=> MaLoaiGiangVien: " + kl.MaLoaiGiangVien.ToString() + "; MaHocHam: " + kl.MaHocHam.ToString() + "; MaHocVi: " + kl.MaHocVi.ToString() + Environment.NewLine);
                                    //DataServices.DonGia.GetByMaLoaiGiangVienMaHocHamMaHocViLopClc((int)kl.MaLoaiGiangVien, (int)kl.MaHocHam, (int)kl.MaHocVi, false, ref _donGia);
                                    kl.MaHocHam = kl.MaHocHam != null ? kl.MaHocHam : 0;
                                    kl.MaHocVi = kl.MaHocVi != null ? kl.MaHocVi : 0;
                                    kl.MaLoaiGiangVien = kl.MaLoaiGiangVien != null ? kl.MaLoaiGiangVien : 0;
                                    DonGia don_gia = listDonGia.Find(dg =>
                                                                    dg.MaHocHam == (int)kl.MaHocHam
                                                                    && dg.MaHocVi == (int)kl.MaHocVi
                                                                    && dg.MaLoaiGiangVien == (int)kl.MaLoaiGiangVien);

									if (don_gia != null)
									{
										if (kl.MaLopHocPhan.Contains("CLC"))
										{
											if (don_gia.DonGiaDoAnClc != null)
												_donGia = (int)don_gia.DonGiaDoAnClc;
										}
										else if (don_gia.DonGiaDoAnDaiTra != null)
										{
											_donGia = (int)don_gia.DonGiaDoAnDaiTra;
										}
										else
										{
											_donGia = 0;
										}
									}
									//_donGia = don_gia != null ?
         //                               kl.MaLopHocPhan.Contains("CLC") ?
         //                                   (int)don_gia.DonGiaDoAnClc
         //                                   : (int)don_gia.DonGiaDoAnDaiTra
         //                           : 0; // đại trà
                                }
                                kl.DonGia = _donGia;
                                kl.ThanhTien = kl.SoTietQuyDoi * kl.DonGia;
                            }
                        }
                        bindingSourceKhoiLuongDoAn.EndEdit();
                        //XuLyTapTin.WriteTextFile("=> Save...");
                        DataServices.KhoiLuongGiangDayDoAn.Save(list);
                        //XuLyTapTin.WriteTextFile("\n~.o0o.~");
                        XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        //XuLyTapTin.WriteTextFile(ex.Message + "\n" + ex.StackTrace + "\n");
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.\n" + ex.Message + "\n" + ex.StackTrace, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        //XuLyTapTin.CloseCurrentTextFile();
                        Cursor.Current = Cursors.Default;
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceKhoiLuongDoAn.DataSource = DataServices.KhoiLuongGiangDayDoAn.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceKhoiLuongDoAn.DataSource = DataServices.KhoiLuongGiangDayDoAn.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }
        #endregion

        #region Event Grid
        private void gridViewKhoiLuongDoAn_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //GridColumn col = e.Column;
            //if (col.FieldName == "MaLop")
            //{
            //    int pos = e.RowHandle;
            //    object r = gridViewCoVan.GetRow(pos);

            //    CoVanHocTap dt = (CoVanHocTap)r;
            //    VList<ViewLop> lop = DataServices.ViewLop.Get(String.Format("MaLop = '{0}'", dt.MaLop), "MaLop");

            //    gridViewCoVan.SetRowCellValue(pos, "MaKhoaHoc", lop[0].MaKhoaHoc);
            //}
            GridColumn col = e.Column;
            int pos = e.RowHandle;
            if (col.FieldName == "MaMonHoc" || col.FieldName == "TenMonHoc" || col.FieldName == "SoTinChi" || col.FieldName == "MaLopHocPhan" || col.FieldName == "MaLop" || col.FieldName == "SiSo" || col.FieldName == "MaGiangVienQuanLy" || col.FieldName == "SoTietQuyDoi")
                gridViewKhoiLuongDoAn.SetRowCellValue(pos, "NgayCapNhat", DateTime.Now.ToString());

        }
        #endregion

        #region TinhTietQuyDoi
        decimal? TinhTietQuyDoi(QuyDoiGioChuan objQuyDoi, TList<KhoanQuyDoi> listKhoanQuyDoi, int siSo, int soTinChi)
        {
            decimal? tietQuyDoi = 0;
            
            //Tinh he so quy doi
            
            //Lay danh sach khoan quy doi
                
            listKhoanQuyDoi.Sort("ThuTu ASC");

            //-----Loop-----
            if (listKhoanQuyDoi.Count > 0)
            {
                foreach (KhoanQuyDoi k in listKhoanQuyDoi)
                {
                    if (objQuyDoi.CongDon == true)
                    {
                        if (k.DenKhoan != null && k.TuKhoan <= siSo && siSo <= k.DenKhoan)
                        {
                            if (tietQuyDoi > 0)
                            {
                                //if (siSo == k.DenKhoan)
                                //    return tietQuyDoi += (k.DenKhoan - k.TuKhoan + 1) * (k.HeSo + 2 * (soTinChi-1) * (decimal)0.5);
                                //else
                                //    return 
								tietQuyDoi += (siSo - k.TuKhoan + 1) * (k.HeSo + 2 * (soTinChi - 1) * (decimal)0.5);
                            }
                            else
                                return tietQuyDoi = siSo * (k.HeSo + 2 * (soTinChi - 1) * (decimal)0.5);
                        }
                        else if (k.DenKhoan != null && siSo >= k.DenKhoan)
                            tietQuyDoi += (k.DenKhoan - k.TuKhoan + 1) * (k.HeSo + 2 * (soTinChi - 1) * (decimal)0.5);
                        else if (k.DenKhoan == null && siSo >= k.TuKhoan)
                            tietQuyDoi += (siSo - k.TuKhoan + 1) * (k.HeSo + 2 * (soTinChi - 1) * (decimal)0.5);
                    }
                    else
                    {
                        if (k.DenKhoan != null && siSo >= k.TuKhoan && siSo <= k.DenKhoan)
                            return siSo * (k.HeSo + 2 * (soTinChi - 1) * (decimal)0.5);
                        else if (k.DenKhoan == null && siSo >= k.TuKhoan)
                            return siSo * (k.HeSo + 2 * (soTinChi - 1) * (decimal)0.5);
                    }
                }
            }
            
            return tietQuyDoi;
        }
        #endregion

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlKhoiLuongDoAn.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }
    }
}