using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Entities;
using PMS.Services;
using DevExpress.XtraEditors.Controls;
using PMS.BLL;
using DevExpress.XtraGrid.Views.Base;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmThanhToanThuLaoVuotGioGiang_HBU : DevExpress.XtraEditors.XtraForm
    {      

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        bool userRole;
        string _groupName = UserInfo.GroupName;
        DataTable tb;
        #endregion

      
        public frmThanhToanThuLaoVuotGioGiang_HBU()
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

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            gridView_ThanhToanThuLaoVuotGio.ExpandAllGroups();
        }

        private void frmThanhToanThuLaoVuotGioGiang_HBU_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridView_ThanhToanThuLaoVuotGio, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridView_ThanhToanThuLaoVuotGio, new string[] { "MaQuanLy", "HoTen", "TenBoMon", "TenLoaiGiangVien", "TenHocHam", "TenHocVi", "TongTietNghiaVu", "TongTietMienGiam", "TongTietQuyDoi", "TongTietGiangDay", "TongTietNckh", "TongTietKhac", "TietVuot", "DonGia", "DonGiaClc", "TienVuot", "ThueTncn", "ThucLanh" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Tên đơn vị", "Loại giảng viên", "Tên học hàm", "Tên học vị", "Tổng tiết nghĩa vụ", "Tổng tiết miễn giảm", "Tổng tiết quy đổi", "Tổng tiết giảng dạy", "Tổng tiết NCKH", "Tổng tiết HĐ khác", "Tiết vượt", "Đơn giá đại trà", "Đơn giá CLC", "Tiền vượt", "Thuế TNCN", "Thực lãnh" }
                    , new int[] { 70, 150, 120, 120, 90, 90, 100, 100, 100, 100, 100, 100, 70, 70, 70, 100, 110, 110 });
            AppGridView.AlignHeader(gridView_ThanhToanThuLaoVuotGio, new string[] { "MaQuanLy", "HoTen", "TenBoMon", "TenLoaiGiangVien", "TenHocHam", "TenHocVi", "TongTietNghiaVu", "TongTietMienGiam", "TongTietQuyDoi", "TongTietGiangDay", "TongTietNckh", "TongTietKhac", "TietVuot", "DonGia", "DonGiaClc", "ThueTncn", "TienVuot", "ThucLanh" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridView_ThanhToanThuLaoVuotGio, new string[] { "TongTietQuyDoi", "DonGia", "DonGiaClc" });
            AppGridView.SummaryField(gridView_ThanhToanThuLaoVuotGio, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridView_ThanhToanThuLaoVuotGio, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridView_ThanhToanThuLaoVuotGio, "DonGiaClc", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridView_ThanhToanThuLaoVuotGio, "ThueTncn", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridView_ThanhToanThuLaoVuotGio, "TienVuot", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridView_ThanhToanThuLaoVuotGio, "ThucLanh", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.ReadOnlyColumn(gridView_ThanhToanThuLaoVuotGio);
            PMS.Common.Globals.WordWrapHeader(gridView_ThanhToanThuLaoVuotGio, 45);
            AppGridView.FixedField(gridView_ThanhToanThuLaoVuotGio, new string[] { "MaQuanLy", "HoTen" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
           

            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            LoadHocKy();

            #region Init Khoa-DonVi
            cboDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboDonVi.Properties.Items.Clear();

            VList<ViewKhoa> _vListKhoaBoMon = new VList<ViewKhoa>();
            _vListKhoaBoMon = DataServices.ViewKhoa.GetAll();

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoa v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaKhoa, v.TenKhoa, CheckState.Unchecked, true));
            }
            cboDonVi.Properties.Items.AddRange(_list.ToArray());
            cboDonVi.Properties.SeparatorChar = ';';
            cboDonVi.CheckAll();
            #endregion

            InitData();
        }

        private void LoadHocKy()
        {
            cbo_HocKy.Properties.SelectAllItemCaption = "Tất cả";
            cbo_HocKy.Properties.TextEditStyle = TextEditStyles.Standard;
            cbo_HocKy.Properties.Items.Clear();
            VList<ViewHocKy> VlistHocKy = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            VlistHocKy.Sort("MaHocKy");
            List<CheckedListBoxItem> listHK = new List<CheckedListBoxItem>();
            for (int i = 0; i < VlistHocKy.Count; i++)
            {
                listHK.Add(new CheckedListBoxItem(VlistHocKy[i].MaHocKy
                    , String.Format("{0} - {1}", VlistHocKy[i].MaHocKy, VlistHocKy[i].TenHocKy)
                    , CheckState.Unchecked, true));
            }
            cbo_HocKy.Properties.Items.AddRange(listHK.ToArray());
            cbo_HocKy.Properties.SeparatorChar = ';';
            cbo_HocKy.CheckAll();
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboDonVi.EditValue != null)
            {
                try
                {
                    DataTable dt = new DataTable();
                    IDataReader reader = DataServices.KetQuaThanhToanThuLao.BangThanhToanGioGiangCoHuuCaNam(cboNamHoc.EditValue.ToString(), cboDonVi.EditValue.ToString(), cbo_HocKy.EditValue.ToString());
                    dt.Load(reader);
                    bindingSource_ThanhToanThuLaoVuotGio.DataSource = dt;
                }
                catch
                { }
            }
            gridView_ThanhToanThuLaoVuotGio.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }
    }
}