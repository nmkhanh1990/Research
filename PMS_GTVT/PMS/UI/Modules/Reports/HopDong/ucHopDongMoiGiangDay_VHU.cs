using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.UI.Forms.BaoCao;
using PMS.BLL;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using DevExpress.XtraRichEdit;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using System.IO;
using System.Diagnostics;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraBars;
using PMS.UserReports;
using DevExpress.XtraReports.Parameters;

namespace PMS.UI.Modules.Reports
{
    public partial class ucHopDongMoiGiangDay_VHU : XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        DateTime _ngayIn;

        string _maTruong;
        private string groupname = UserInfo.GroupName;  
        DataTable vListBaoCao;
        #endregion

        public ucHopDongMoiGiangDay_VHU()
        {
            InitializeComponent();
            _maTruong = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Mã trường");
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void ucHopDongMoiGiangDay_VHU_Load(object sender, EventArgs e)
        {
            #region InitGridview
            AppGridView.InitGridView(gridViewHopDongMoiGiangVien, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewHopDongMoiGiangVien, new string[] { "Chon", "MaGiangVien", "HoTen", "TenLoaiGiangVien", "NamHoc", "HocKy", "MaLopHocPhan", "MaMonHoc", "TenMonHoc", "MaLopSinhVien", "MaKhoaHoc", "SiSo", "SoTinChi", "NgayBatDauGiangDay", "NgayKetThucGiangDay", "SoTiet", "MaLoaiHocPhan", "TenLoaiHocPhan", "KhoaDonVi" }
                , new string[] { "Chọn", "Mã giảng viên", "Tên giảng viên", "Loại giảng viên", "Năm học", "Học kỳ", "Mã lớp học phần", "Mã môn học", "Tên môn học", "Mã lớp sinh viên", "Mã khóa học", "Sĩ số", "Số tín chỉ", "Ngày bắt đầu giảng dạy", "Ngày kết thúc giảng dạy", "Số tiết", "Mã loại học phần", "Tên loại học phần", "Khoa - Đơn vị" }
                , new int[] { 60, 80, 130, 100, 100, 100, 110, 110, 150, 110, 100, 60, 60, 90, 90, 60, 50, 90, 120 });
            AppGridView.AlignHeader(gridViewHopDongMoiGiangVien, new string[] { "Chon", "MaGiangVien", "HoTen", "TenLoaiGiangVien", "NamHoc", "HocKy", "MaLopHocPhan", "MaMonHoc", "TenMonHoc", "MaLopSinhVien", "MaKhoaHoc", "SiSo", "SoTinChi", "NgayBatDauGiangDay", "NgayKetThucGiangDay", "SoTiet", "MaLoaiHocPhan", "TenLoaiHocPhan", "KhoaDonVi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewHopDongMoiGiangVien, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewHopDongMoiGiangVien, new string[] { "MaGiangVien", "HoTen", "TenLoaiGiangVien", "NamHoc", "HocKy", "MaLopHocPhan", "MaMonHoc", "TenMonHoc", "MaLopSinhVien", "MaKhoaHoc", "SiSo", "SoTinChi", "NgayBatDauGiangDay", "NgayKetThucGiangDay", "SoTiet", "MaLoaiHocPhan", "TenLoaiHocPhan", "KhoaDonVi" });
            #endregion

            #region Năm học
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Học kỳ
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region Khoa - Đơn vị
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaKhoa", "TenKhoa" }, new string[] { "Mã đơn vị", "Tên đơn vị" });
            cboKhoaDonVi.Properties.ValueMember = "MaKhoa";
            cboKhoaDonVi.Properties.DisplayMember = "TenKhoa";
            cboKhoaDonVi.Properties.NullText = string.Empty;
            #endregion

            #region Bac dao tao
            AppGridLookupEdit.InitGridLookUp(cboBacDaoTao, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboBacDaoTao, new string[] { "MaBacDaoTao", "TenBacDaoTao" }, new string[] { "Mã bậc đào tạo", "Tên bậc đào tạo" });
            cboBacDaoTao.Properties.ValueMember = "MaBacDaoTao";
            cboBacDaoTao.Properties.DisplayMember = "TenBacDaoTao";
            cboBacDaoTao.Properties.NullText = string.Empty;
            #endregion

            InitData();
        }

        void InitData()
        {
            Cursor.Current = Cursors.WaitCursor;

            cboBacDaoTao.DataBindings.Clear();
            bindingSourceBacDaoTao.DataSource = DataServices.ViewBacDaoTao.GetAll();
            cboBacDaoTao.DataBindings.Add("EditValue", bindingSourceBacDaoTao, "MaBacDaoTao", true, DataSourceUpdateMode.Never);

            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            VList<ViewKhoa> vListKhoaBoMon;
            //if (user == true)
            //{
            //    vListKhoaBoMon = DataServices.ViewKhoa.GetByMaBoMon(groupname);
            //}
            //else
            //{
            vListKhoaBoMon = DataServices.ViewKhoa.GetAll();
            //}
            vListKhoaBoMon.Sort("TenKhoa");
            bindingSourceKhoaDonVi.DataSource = vListKhoaBoMon;

            gridViewHopDongMoiGiangVien.ExpandAllGroups();

            Cursor.Current = Cursors.Default;
        }

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            cboMaGiangVien.Properties.SelectAllItemCaption = "Tất cả";
            cboMaGiangVien.Properties.TextEditStyle = TextEditStyles.Standard;
            cboMaGiangVien.Properties.Items.Clear();
            if (cboKhoaDonVi.EditValue != null)
            {
                VList<ViewGiangVien> _tLisGiangVien = DataServices.ViewGiangVien.GetByMaDonVi(cboKhoaDonVi.EditValue.ToString());

                List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();

                foreach (ViewGiangVien l in _tLisGiangVien)
                    list.Add(new CheckedListBoxItem(l.MaQuanLy, string.Format("{0} - {1}", l.MaQuanLy, l.HoTen), CheckState.Unchecked, true));
                cboMaGiangVien.Properties.Items.AddRange(list.ToArray());
                cboMaGiangVien.Properties.SeparatorChar = ';';
                cboMaGiangVien.CheckAll();
            }
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboKhoaDonVi.EditValue != null && cboMaGiangVien.EditValue != null && cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.GiangVien.HopDongMoiGiangDay("", cboKhoaDonVi.EditValue.ToString(), "", cboNamHoc.EditValue.ToString(), "");
                tbl.Load(reader);
                DataColumn chon = new DataColumn("Chon", typeof(Boolean));
                tbl.Columns.Add(chon);

                foreach (DataRow item in tbl.Rows)
                {
                    item["Chon"] = false;
                }

                bindingSourceHopDongGiangDay.DataSource = tbl;
            }
            Cursor.Current = Cursors.Default;
        }


        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                GetDataIn();
                if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
                {
                    using (frmBaoCao frm = new frmBaoCao())
                    {
                        frm.InHopDongMoiGiangDay_VHU(vListBaoCao);
                        frm.ShowDialog();
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
            }
        }

        private void checkEditChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                PMS.Common.XuLyGiaoDien.CheckAll(gridViewHopDongMoiGiangVien, "Chon", Convert.ToBoolean(checkEditChonTatCa.EditValue.ToString()));
            }
            catch (Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
            }
        }
        private void GetDataIn()
        {
            vListBaoCao = new DataTable();
            Cursor.Current = Cursors.WaitCursor;
            gridViewHopDongMoiGiangVien.FocusedRowHandle = -1;
            bindingSourceHopDongGiangDay.EndEdit();
            DataTable data = bindingSourceHopDongGiangDay.DataSource as DataTable;
            if (data == null)
                return;

            try
            {
                int ichk = PMS.Common.XuLyGiaoDien.CheckedIn(gridViewHopDongMoiGiangVien, "Chon");
                if (ichk == 2)
                {
                    PMS.Common.XuLyGiaoDien.ThongBao("Thông báo", PMS.Common.ThongBao.Str_ThongBaoDuLieu, MessageBoxIcon.Information, true);
                    return;
                }
                else if (ichk == 0)
                {
                    PMS.Common.XuLyGiaoDien.ThongBao("Thông báo", PMS.Common.ThongBao.Str_ChonIn, MessageBoxIcon.Information, true);
                    return;
                }
                vListBaoCao = data.Select("Chon = 1").CopyToDataTable();

            }
            catch
            {
                XtraMessageBox.Show("Vui lòng chọn môn muốn in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (frmChonNgay frmChon = new frmChonNgay())
            {
                frmChon.ShowDialog();
                _ngayIn = frmChon.NgayIn;
            }

            vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewHopDongMoiGiangVien, vListBaoCao);
            vListBaoCao.AcceptChanges();
        }

    }
}
