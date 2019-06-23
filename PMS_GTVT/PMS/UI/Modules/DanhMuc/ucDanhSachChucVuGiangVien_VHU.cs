using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.BLL;
using PMS.UI.Forms.NghiepVu.FormXuLy;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucDanhSachChucVuGiangVien_VHU : XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();       
        string _maTruong;
        private string groupname = UserInfo.GroupName;    
        VList<ViewKhoa> vListKhoaBoMon;
      
        #endregion

        public ucDanhSachChucVuGiangVien_VHU()
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
            AppGridView.InitGridView(gridViewDanhSachChucVu, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewDanhSachChucVu, new string[] { "InHopDong", "MaGiangVien", "HoTen", "TenChucVu", "TenKhoa", "DienThoai", "NgayHieuLuc", "NgayHetHieuLuc" }
                , new string[] { "Chọn", "Mã giảng viên", "Họ và tên", "Tên chức vụ", "Tên khoa", "Điện thoại", "Ngày hiệu lực", "Ngày hết hiệu lực" }
                , new int[] { 60, 100, 130, 140, 140, 100, 120, 120 });
            AppGridView.AlignHeader(gridViewDanhSachChucVu, new string[] { "InHopDong", "MaGiangVien", "HoTen", "TenChucVu", "TenKhoa", "DienThoai", "NgayHieuLuc", "NgayHetHieuLuc" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewDanhSachChucVu, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewDanhSachChucVu, new string[] { "MaGiangVien", "HoTen", "TenChucVu", "TenKhoa", "DienThoai", "NgayHieuLuc", "NgayHetHieuLuc" });
            #endregion

            #region Năm học
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion          

            #region Khoa - Đơn vị
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaKhoa", "TenKhoa" }, new string[] { "Mã đơn vị", "Tên đơn vị" });
            cboKhoaDonVi.Properties.ValueMember = "MaKhoa";
            cboKhoaDonVi.Properties.DisplayMember = "TenKhoa";
            cboKhoaDonVi.Properties.NullText = string.Empty;
            #endregion

            InitData();
        }

        void InitData()
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            vListKhoaBoMon = DataServices.ViewKhoa.GetAll();
            vListKhoaBoMon.Insert(0, new ViewKhoa() { ThuTu = -1, MaKhoa = "-1", TenKhoa = "[Tất cả]" });
            vListKhoaBoMon.Sort("TenKhoa");            
            cboKhoaDonVi.DataBindings.Clear();
            bindingSourceKhoaDonVi.DataSource = vListKhoaBoMon;
            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaKhoa", true, DataSourceUpdateMode.Never);
            ShowData("-1");
            gridViewDanhSachChucVu.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }

        private void ShowData(string strMaKhoa)
        {
            DataTable tbl = new DataTable();
            IDataReader id = DataServices.GiangVienChucVu.DanhSachChucVu(strMaKhoa);
            tbl.Load(id);
            bindingSourceDanhSachChucVu.DataSource = tbl;
        }

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            if (cboKhoaDonVi.EditValue != null)
            {
                ShowData(cboKhoaDonVi.EditValue.ToString());
            }
        }
               

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewDanhSachChucVu.FocusedRowHandle = -1;
                DataTable tbl = bindingSourceDanhSachChucVu.DataSource as DataTable;
                string xmlData = string.Empty;
                if (XtraMessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataRow item in tbl.Rows)
                    {
                        if (item.RowState == DataRowState.Modified)
                        {
                            xmlData += String.Format("<Input MGV=\"{0}\" MQL=\"{1}\" MCV=\"{2}\" MDV=\"{3}\" Chon=\"{4}\" />",
                                                            item["MaGiangVien"], item["MaQuanLy"], item["MaChucVu"], item["MaDonVi"], item["InHopDong"]);

                        }
                    }

                    xmlData = String.Format("<Root>{0}</Root>", xmlData);
                    int kq = 0;
                    DataServices.GiangVienChucVu.LuuDanhSachInHopDong(xmlData, cboKhoaDonVi.EditValue.ToString(), ref kq);
                    if (kq == 0)
                    {
                        PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_LuuThayDoiThanhCong, MessageBoxIcon.Information, true);
                    }
                    else
                        PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_LuuLoiXayRa, MessageBoxIcon.Warning, true);
                    ShowData(cboKhoaDonVi.EditValue.ToString());
                }
            }
            catch (Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_LuuLoiXayRa, MessageBoxIcon.Error, true);
            }
        }
    }
}
