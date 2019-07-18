using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Services;
using PMS.Entities;
using PMS.UI.Forms.BaoCao;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using DevExpress.XtraEditors.Controls;
using PMS.Entities.Validation;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmThanhTraTheoTKB : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ItemShortcut = DevExpress.XtraBars.BarShortcut.Empty;

                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnXoa.ItemShortcut = DevExpress.XtraBars.BarShortcut.Empty;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }

        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong, _tenTruong;
        string _groupUser = UserInfo.GroupName;
        string strGioVao = string.Empty, strGioRa = string.Empty, strKetQua = string.Empty, strSoTietGhiNhan = "0";

        DataTable tbl, TblTemp;
        #endregion

        #region Event Form
        public frmThanhTraTheoTKB()
        {
            InitializeComponent();
            _maTruong = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Mã trường");
            _tenTruong = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Tên trường");
        }

        private void frmThanhTraTheoTKB_Load(object sender, EventArgs e)
        {
            #region Init GridView            
            InitRemaining();
            #endregion

            #region InitRepository ViPham
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNoiDungViPham, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditNoiDungViPham, 400, 650);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNoiDungViPham, new string[] { "MaViPham", "NoiDungViPham" }, new string[] { "Mã vi phạm", "Nội dung vi phạm" }, new int[] { 70, 260 });
            repositoryItemGridLookUpEditNoiDungViPham.DisplayMember = "NoiDungViPham";
            repositoryItemGridLookUpEditNoiDungViPham.ValueMember = "MaViPham";
            repositoryItemGridLookUpEditNoiDungViPham.NullText = string.Empty;
            #endregion

            #region InitRepository HinhThucViPhamHRM
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHinhThucViPhamHRM, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditHinhThucViPhamHRM, 380, 650);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHinhThucViPhamHRM, new string[] { "MaQuanLy", "TenHinhThucViPham" }, new string[] { "Mã vi phạm", "Nội dung vi phạm" }, new int[] { 80, 300 });
            repositoryItemGridLookUpEditHinhThucViPhamHRM.DisplayMember = "TenHinhThucViPham";
            repositoryItemGridLookUpEditHinhThucViPhamHRM.ValueMember = "Oid";
            repositoryItemGridLookUpEditHinhThucViPhamHRM.NullText = string.Empty;
            #endregion

            InitData();
        }
        #endregion

        #region InitGrid


        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewThanhTra, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThanhTra, new string[] { "ThanhLy", "XacNhan", "Ngay", "Phong", "MaHocPhan", "TenHocPhan", "LoaiHocPhan", "MaGocLopHocPhan", "MaLop", "MaCanBoGiangDay", "HoTen", "Khoa", "Thu", "TietBatDau", "SoTiet", "TienDo", "SiSo", "GioVao", "GioRa", "SoTietGhiNhan", "MaViPham", "MaHinhThucViPhamHrm", "ThoiDiemGhiNhan", "LyDo", "GhiChu", "NgayCapNhat", "NguoiCapNhat", "TrangThai" }
                    , new string[] { "Tình trạng", "Xác nhận", "Ngày", "Phòng học", "Mã học phần", "Tên học phần", "Loại học phần", "Mã lớp học phần", "Mã lớp", "Mã CBGD", "Họ tên", "Đơn vị", "Thứ", "Tiết bắt đầu", "Số tiết", "Tiến độ", "Sĩ số", "Giờ vào", "Giờ ra", "Số tiết ghi nhận", "Nội dung vi phạm", "Hình thức vi phạm đánh giá ABC", "Thời điểm thanh lý", "Lý do", "Ghi chú", "NgayCapNhat", "NguoiCapNhat", "TrangThai" }
                    , new int[] { 60, 60, 70, 80, 80, 150, 90, 110, 90, 70, 140, 150, 50, 70, 60, 80, 60, 100, 100, 100, 170, 200, 110, 150, 150, 99, 99, 99, 99 });
            AppGridView.AlignHeader(gridViewThanhTra, new string[] { "ThanhLy", "XacNhan", "Ngay", "Phong", "MaHocPhan", "TenHocPhan", "LoaiHocPhan", "MaGocLopHocPhan", "MaLop", "MaCanBoGiangDay", "HoTen", "Khoa", "Thu", "TietBatDau", "SoTiet", "GioVao", "GioRa", "SoTietGhiNhan", "TienDo", "SiSo", "MaViPham", "MaHinhThucViPhamHrm", "ThoiDiemGhiNhan", "LyDo", "GhiChu", "NgayCapNhat", "NguoiCapNhat", "XacNhan" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThanhTra, "Ngay", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewThanhTra, "SiSo", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.RegisterControlField(gridViewThanhTra, "MaViPham", repositoryItemGridLookUpEditNoiDungViPham);
            AppGridView.RegisterControlField(gridViewThanhTra, "GioVao", repositoryItemTextEditGioVao);
            AppGridView.RegisterControlField(gridViewThanhTra, "GioRa", repositoryItemTextEditGioRa);
            AppGridView.RegisterControlField(gridViewThanhTra, "MaHinhThucViPhamHrm", repositoryItemGridLookUpEditHinhThucViPhamHRM);
            AppGridView.FixedField(gridViewThanhTra, new string[] { "ThanhLy", "XacNhan", "Ngay", "Phong", "MaHocPhan", "TenHocPhan" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            AppGridView.RegisterControlField(gridViewThanhTra, "Ngay", repositoryItemDateEditNgay);
            AppGridView.HideField(gridViewThanhTra, new string[] { "MaHinhThucViPhamHrm", "MaViPham", "GioVao", "GioRa", "SiSo", "NgayCapNhat", "NguoiCapNhat", "TrangThai" });
            AppGridView.ReadOnlyColumn(gridViewThanhTra, new string[] { "ThanhLy", "Ngay", "Phong", "MaHocPhan", "TenHocPhan", "LoaiHocPhan", "MaGocLopHocPhan", "MaLop", "MaCanBoGiangDay", "HoTen", "Khoa", "Thu", "TietBatDau", "SoTiet", "TienDo" });

        }
        #endregion 

        #region InitData
        void InitData()
        {
            dateEditTuNgay.DateTime = DateTime.Now;
            dateEditDenNgay.DateTime = DateTime.Now;

            InitCoSo();

            InitDayNha();

            bindingSourceNoiDungViPham.DataSource = DataServices.DanhMucViPham.GetAll();
            if (dateEditTuNgay.EditValue != null && dateEditDenNgay.EditValue != null && cboDayNha.EditValue != null)
            {
                InitShowData();
            }
        }

        DataTable GetTbl(DataTable tbl)
        {
            DataTable tblResult = new DataTable();
            tblResult.Columns.Add("MaLopHocPhan", typeof(string));
            tblResult.Columns.Add("SoTietGhiNhan", typeof(Int32));
            foreach (DataRow item in tbl.Rows)
            {
                DataRow rows = tblResult.NewRow();
                rows["MaLopHocPhan"] = item["MaLopHocPhan"].ToString();
                rows["SoTietGhiNhan"] = item["SoTietGhiNhan"].ToString();
                tblResult.Rows.Add(rows);
            }
            return tblResult;
        }

        void InitCoSo()
        {
            #region Init Co So
            cboCoSo.Properties.SelectAllItemCaption = "Tất cả";
            cboCoSo.Properties.TextEditStyle = TextEditStyles.Standard;
            cboCoSo.Properties.Items.Clear();

            VList<ViewCoSo> _vListKhoaBoMon = new VList<ViewCoSo>();
            _vListKhoaBoMon = DataServices.ViewCoSo.GetAll();

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewCoSo v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaCoSo, v.TenCoSo, CheckState.Unchecked, true));
            }
            cboCoSo.Properties.Items.AddRange(_list.ToArray());
            cboCoSo.Properties.SeparatorChar = ';';
            cboCoSo.CheckAll();
            #endregion
        }

        void InitShowData()
        {
            tbl = new DataTable();
            IDataReader id = DataServices.ViewThanhTraTheoThoiKhoaBieu.GetByNgayCoSoToaNha(dateEditTuNgay.DateTime.ToString("dd/MM/yyyy"), dateEditDenNgay.DateTime.ToString("dd/MM/yyyy"), cboDayNha.EditValue.ToString());
            tbl.Load(id);
            tbl.Columns["XacNhan"].ReadOnly = false;
            TblTemp = GetTbl(tbl);
            bindingSourceThanhTra.DataSource = tbl;
            gridControlThanhTra.DataSource = bindingSourceThanhTra;
            ToMau(bindingSourceThanhTra.DataSource as VList<ViewThanhTraTheoThoiKhoaBieu>);
        }

        void InitDayNha()
        {
            #region Init Day Nha
            if (cboCoSo.EditValue != null)
            {
                cboDayNha.Properties.SelectAllItemCaption = "Tất cả";
                cboDayNha.Properties.TextEditStyle = TextEditStyles.Standard;
                cboDayNha.Properties.Items.Clear();

                DataTable tb = new DataTable();
                IDataReader reader = DataServices.ViewCoSo.GetDayNhaByCoSo(cboCoSo.EditValue.ToString());
                tb.Load(reader);
                List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
                foreach (DataRow v in tb.Rows)
                {
                    _list.Add(new CheckedListBoxItem(v["MaDayNha"].ToString(), v["TenDayNha"].ToString(), CheckState.Unchecked, true));
                }
                cboDayNha.Properties.Items.AddRange(_list.ToArray());
                cboDayNha.Properties.SeparatorChar = ';';
                cboDayNha.CheckAll();
            }
            #endregion
        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gridViewThanhTra.RowCount > 0)
                    if (gridViewThanhTra.GetSelectedRows().Length > 0)
                    {
                        SetDataValueGridView(gridViewThanhTra);
                    }
            }
            catch
            { }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string s = PMS.Common.Globals.IsNull(0, "int").ToString();
            gridViewThanhTra.FocusedRowHandle = -1;
            DataTable tbl = bindingSourceThanhTra.DataSource as DataTable;
            string str_GioVao = string.Empty, str_GioRa = string.Empty;
            if (tbl.Rows.Count > 0)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        string xmlData = "";
                        foreach (DataRow v in tbl.Rows)
                        {
                            if (v.RowState == DataRowState.Modified)
                            {
                                str_GioVao = v["GioVao"].ToString();
                                str_GioRa = v["GioRa"].ToString();
                                if (PMS.Common.Globals.IsNull(v["GhiChu"].ToString(), "string").ToString().Contains("[Đã đổi lịch]"))
                                    v["GhiChu"] = v["GhiChu"].ToString().Replace("[Đã đổi lịch]", "");//Tránh trường hợp lưu nhiều lần ghi chú [Đã đổi lịch]

                                xmlData += String.Format(
                                    "<Input ML=\"" + v["MaLichHoc"]
                                            + "\" S=\"" + v["SiSo"]
                                            + "\" VP=\"" + v["MaViPham"]
                                            + "\" HR=\"" + v["MaHinhThucViPhamHrm"]
                                            + "\" T=\"" + v["ThoiDiemGhiNhan"]
                                            + "\" L=\"" + v["LyDo"]
                                            + "\" G=\"" + v["GhiChu"]
                                            + "\" N=\"" + v["NgayCapNhat"]
                                            + "\" U=\"" + v["NguoiCapNhat"]
                                            + "\" MH=\"" + v["MaHocPhan"]
                                            + "\" HP=\"" + v["MaGocLopHocPhan"]
                                            + "\" ST=\"" + v["SoTietGhiNhan"]//PMS.Common.Globals.IsNull(v["SoTietGhiNhan"], "int").ToString()
                                            + "\" CB=\"" + v["MaCanBoGiangDay"]
                                            + "\" ND=\"" + v["Ngay"]
                                            + "\" GV=\"" + str_GioVao
                                            + "\" GR=\"" + str_GioRa
                                            + "\" TBD=\"" + v["TietBatDau"]
                                            + "\" S2=\"" + v["SoTiet"]
                                            + "\" P=\"" + v["Phong"]
                                            + "\" XN=\"" + v["XacNhan"]
                                            + "\" TL=\"" + v["ThanhLy"]
                                            + "\" />");

                            }
                        }
                        xmlData = "<Root>" + xmlData + "</Root>";
                        int kq = 0;
                        DataServices.ThanhTraTheoThoiKhoaBieu.Luu(xmlData, ref kq);
                        if (kq == 0)
                            PMS.Common.XuLyGiaoDien.ThongBao("Thông báo", PMS.Common.ThongBao.Str_LuuThayDoiThanhCong, MessageBoxIcon.Information, true);

                        else
                            PMS.Common.XuLyGiaoDien.ThongBao("Thông báo", PMS.Common.ThongBao.Str_LuuLoiXayRa, MessageBoxIcon.Error, true);

                        //Lấy lại dữ liệu sau khi lưu
                        Cursor.Current = Cursors.WaitCursor;
                        if (dateEditTuNgay.EditValue != null && dateEditDenNgay.EditValue != null && cboDayNha.EditValue != null)
                        {
                            InitShowData();
                        }
                        Cursor.Current = Cursors.Default;
                    }
                    catch (Exception ex)
                    {
                        PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);

                    }
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog file = new SaveFileDialog())
            {
                file.Filter = "(*.xls)|*.xls";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    if (file.FileName != "")
                    {
                        gridControlThanhTra.ExportToXls(file.FileName);
                        PMS.Common.XuLyGiaoDien.ThongBao("Thông báo", PMS.Common.ThongBao.Str_XuatFile, MessageBoxIcon.Information, true);
                    }
                    else
                        PMS.Common.XuLyGiaoDien.ThongBao("Thông báo", PMS.Common.ThongBao.Str_ChuaNhapFile, MessageBoxIcon.Warning, true);
                }
            }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewThanhTra.FocusedRowHandle = -1;
            bindingSourceThanhTra.EndEdit();
            DataTable data = bindingSourceThanhTra.DataSource as DataTable;
            if (data == null)
                return;
            DataTable vListBaoCao = data;
            vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThanhTra, vListBaoCao);

            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewThanhTra.SortedColumns)
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
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InThanhTraTheoNgay(PMS.Common.Globals._cauhinh.TenTruong, dateEditTuNgay.DateTime.ToString("dd/MM/yyyy"), dateEditDenNgay.DateTime.ToString("dd/MM/yyyy"), UserInfo.FullName, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (dateEditTuNgay.EditValue != null && dateEditDenNgay.EditValue != null && cboDayNha.EditValue != null)
            {
                InitShowData();
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event GridView
        private void gridViewThanhTra_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            string strTietGhiNhan = "0", strSoTiet = "0";
            if (col.FieldName == "SiSo" || col.FieldName == "MaViPham" || col.FieldName == "ThoiDiemGhiNhan" || col.FieldName == "LyDo" || col.FieldName == "GhiChu" || col.FieldName == "MaHinhThucViPhamHrm" || col.FieldName == "SoTietGhiNhan" || col.FieldName == "XacNhan")
            {
                gridViewThanhTra.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
                gridViewThanhTra.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
                gridViewThanhTra.SetRowCellValue(e.RowHandle, "TrangThai", "True");
            }

            if (col.FieldName == "SoTietGhiNhan")
            {
                DataTable v = bindingSourceThanhTra.DataSource as DataTable;
                strTietGhiNhan = v.Rows[e.RowHandle]["SoTietGhiNhan"].ToString();
                strTietGhiNhan = strTietGhiNhan != string.Empty ? strTietGhiNhan : "0";
                strSoTiet = v.Rows[e.RowHandle]["SoTiet"].ToString();
                strSoTiet = strSoTiet != string.Empty ? strSoTiet : "0";
                if (_maTruong == "IUH")
                {
                    if (int.Parse(strTietGhiNhan) > int.Parse(strSoTiet))
                    {
                        PMS.Common.XuLyGiaoDien.ThongBao("Thông báo", PMS.Common.ThongBao.Str_SoTietQuaGioHan, MessageBoxIcon.Warning, true);
                        gridViewThanhTra.SetRowCellValue(e.RowHandle, "SoTietGhiNhan", v.Rows[e.RowHandle]["SoTiet"].ToString());
                    }
                }
                else
                {

                    if (int.Parse(strTietGhiNhan) > 15)
                    {
                        PMS.Common.XuLyGiaoDien.ThongBao("Thông báo", PMS.Common.ThongBao.Str_SoTietQuaGioHan, MessageBoxIcon.Warning, true);
                        gridViewThanhTra.SetRowCellValue(e.RowHandle, "SoTietGhiNhan", "");
                    }
                    //else
                    //{
                    //    try
                    //    {
                    //        gridViewThanhTra.SetRowCellValue(e.RowHandle, "SoTietGhiNhan", v.Rows[e.RowHandle]["SoTiet"].ToString());
                    //    }
                    //    catch 
                    //    {                           
                    //    }
                        
                    //}
                }
            }
            if (col.FieldName == "GioVao" || col.FieldName == "GioRa")
            {
                if (strGioVao != string.Empty && strGioRa != string.Empty)
                {
                    //strSoTietGhiNhan = GetSoTietGhiNhan(TblTemp, gridViewThanhTra.GetRowCellValue(e.RowHandle, "MaLopHocPhan").ToString()).ToString();
                    strSoTietGhiNhan = gridViewThanhTra.GetRowCellValue(e.RowHandle, "SoTiet").ToString();
                    int iSoTietHT = int.Parse(gridViewThanhTra.GetRowCellValue(e.RowHandle, "SoTietGhiNhan").ToString());
                    int iSTGN = int.Parse(strKetQua);
                    int iKQSTGN = int.Parse(strSoTietGhiNhan);
                    if (iSTGN < iKQSTGN)
                        iKQSTGN = iSTGN;
                    gridViewThanhTra.SetRowCellValue(e.RowHandle, "SoTietGhiNhan", iKQSTGN);
                }
            }
        }

        private void gridViewThanhTra_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                    if (gridViewThanhTra.RowCount > 0)
                        if (gridViewThanhTra.GetSelectedRows().Length > 0)
                        {
                            SetDataValueGridView(gridViewThanhTra);
                        }
            }
            catch
            { }
        }

        private void SetDataValueGridView(GridView gv)
        {
            foreach (int i in gv.GetSelectedRows())
            {

                gv.SetRowCellValue(i, "SiSo", null);
                gv.SetRowCellValue(i, "MaViPham", "");
                gv.SetRowCellValue(i, "MaHinhThucViPhamHrm", "");
                gv.SetRowCellValue(i, "ThoiDiemGhiNhan", "");
                gv.SetRowCellValue(i, "LyDo", "");
                gv.SetRowCellValue(i, "GhiChu", "");
                gv.SetRowCellValue(i, "SoTietGhiNhan", 0);
                gv.SetRowCellValue(i, "GioVao", "");
                gv.SetRowCellValue(i, "GioRa", "");
                gv.SetRowCellValue(i, "NgayCapNhat", "");
                gv.SetRowCellValue(i, "NguoiCapNhat", "");
            }
        }

        private void gridViewThanhTra_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            ViewThanhTraTheoThoiKhoaBieu obj = gridViewThanhTra.GetRow(e.RowHandle) as ViewThanhTraTheoThoiKhoaBieu;
            //Kiểm tra quá số ngày cho phép chấm thanh tra
            if (obj != null)
            {
                bool kq = false, trongGioChamGiang = false;
                DataServices.ThanhTraTheoThoiKhoaBieu.KiemTraThoiHanChamThanhTra(obj.Ngay, ref kq);
                if (!kq)
                {
                    PMS.Common.XuLyGiaoDien.ThongBao("Thông báo", PMS.Common.ThongBao.Str_NgoaiThoiGianChamGiang, MessageBoxIcon.Warning, true);
                    ColumnView view = (ColumnView)gridControlThanhTra.FocusedView;
                    if (view.IsEditing)
                        view.HideEditor();
                    view.CancelUpdateCurrentRow();
                    return;
                }

                //Kiểm tra trong giờ cho phép chấm thanh tra đối với nhân viên thanh tra
                if (_groupUser.ToLower() != "truongthanhtra")
                {
                    DataServices.ThanhTraTheoThoiKhoaBieu.KiemTraGioChamThanhTra(obj.Ngay, ref trongGioChamGiang);
                    if (!trongGioChamGiang)
                    {
                        PMS.Common.XuLyGiaoDien.ThongBao("Thông báo", PMS.Common.ThongBao.Str_NgoaiThoiGiangChamGiangTrongKhoang, MessageBoxIcon.Warning, true);
                        ColumnView view = (ColumnView)gridControlThanhTra.FocusedView;
                        if (view.IsEditing)
                            view.HideEditor();
                        view.CancelUpdateCurrentRow();
                    }
                }

            }
            if (col.FieldName == "GioVao" || col.FieldName == "GioRa")
            {
                strGioVao = gridViewThanhTra.GetRowCellValue(e.RowHandle, "GioVao").ToString();
                strGioRa = gridViewThanhTra.GetRowCellValue(e.RowHandle, "GioRa").ToString();
            }

        }

        private void gridViewThanhTra_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            if (gridViewThanhTra.FocusedColumn.FieldName == "GioVao")
            {
                strGioVao = e.Value.ToString();
                if (strGioVao != string.Empty)
                {
                    if (!PMS.Common.XuLySo.CheckTime(strGioVao))
                    {
                        e.Valid = false;
                        e.ErrorText = PMS.Common.ThongBao.Str_GioVao;
                    }
                    else if (strGioRa != string.Empty)
                    {
                        string[] LstGio = PMS.Common.XuLySo.GetLstSplit(PMS.Common.XuLySo.FormatTime(strGioVao, strGioRa), ':');
                        if (int.Parse(LstGio[0].ToString()) < 0)
                        {
                            e.Valid = false;
                            e.ErrorText = PMS.Common.ThongBao.Str_KetQuaGio;
                        }
                        strKetQua = GetSoTietGhiNhan(LstGio);
                    }
                }
            }
            else if (gridViewThanhTra.FocusedColumn.FieldName == "GioRa")
            {
                strGioRa = e.Value.ToString();
                if (strGioRa != string.Empty)
                {
                    if (!PMS.Common.XuLySo.CheckTime(strGioRa))
                    {
                        e.Valid = false;
                        e.ErrorText = PMS.Common.ThongBao.Str_GioRa;
                    }
                    else
                    {
                        string[] LstGio = PMS.Common.XuLySo.GetLstSplit(PMS.Common.XuLySo.FormatTime(strGioVao, strGioRa), ':');
                        if (int.Parse(LstGio[0].ToString()) < 0)
                        {
                            e.Valid = false;
                            e.ErrorText = PMS.Common.ThongBao.Str_KetQuaGio;
                        }
                        strKetQua = GetSoTietGhiNhan(LstGio);
                    }
                }
            }
            else if (gridViewThanhTra.FocusedColumn.FieldName == "SoTietGhiNhan")
            {
                string strSoTietHT = e.Value.ToString();
                if (strSoTietHT != string.Empty && strSoTietHT != "0")
                {
                    if (!PMS.Common.XuLySo.KiemTraChuoiToanSo(strSoTietHT))
                    {
                        e.Valid = false;
                        e.ErrorText = PMS.Common.ThongBao.Str_ChiNhapSo;
                    }
                    else
                    {
                        strSoTietGhiNhan = gridViewThanhTra.GetRowCellValue(gridViewThanhTra.FocusedRowHandle, "SoTiet").ToString();
                        if (int.Parse(strSoTietHT) > int.Parse(strSoTietGhiNhan))
                        {
                            e.Valid = false;
                            e.ErrorText = PMS.Common.ThongBao.Str_SoTietGhiNhan;
                        }
                    }
                }
                else
                {
                    e.Valid = false;
                    e.ErrorText = PMS.Common.ThongBao.Str_VuiLongKhongDeTrong;
                }
                
            }
        }
        #endregion

        #region Event Cbo
        private void cboCoSo_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitDayNha();
            Cursor.Current = Cursors.Default;
        }

        private void gridViewThanhTra_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            bool bDisable = PMS.Common.XuLyGiaoDien.DisableCellRows(view, "ThanhLy", view.FocusedRowHandle, "ĐTL");
            if ((view.FocusedColumn.FieldName == "XacNhan"
                || view.FocusedColumn.FieldName == "ThoiDiemGhiNhan"
                || view.FocusedColumn.FieldName == "LyDo"
                || view.FocusedColumn.FieldName == "GhiChu")
                && bDisable)
                e.Cancel = true;
        }

        private void gridViewThanhTra_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView currentView = sender as GridView;
            if (e.Column.FieldName == "ThanhLy")
            {
                if (e.RowHandle > 0)
                {
                    string strTrangThai = currentView.GetRowCellValue(e.RowHandle, "ThanhLy").ToString();
                    if (strTrangThai == "ĐTL")
                        e.Appearance.BackColor = Color.Purple;
                }
            }
        }
        #endregion

        #region ToMau
        void ToMau(VList<ViewThanhTraTheoThoiKhoaBieu> list)
        {
            try
            {
                if (list.Count > 0)
                {
                    foreach (ViewThanhTraTheoThoiKhoaBieu v in list)
                    {
                        if (v.TienDo == "LB")
                        {
                            AppGridView.ConditionsAdjustment(gridViewThanhTra, "TienDo", DevExpress.XtraGrid.FormatConditionEnum.Equal, true, Color.Yellow, v.TienDo);
                        }

                        if (v.TienDo == "LN")
                        {
                            AppGridView.ConditionsAdjustment(gridViewThanhTra, "TienDo", DevExpress.XtraGrid.FormatConditionEnum.Equal, true, Color.Aqua, v.TienDo);
                        }
                    }
                }
            }
            catch
            { }

        }
        #endregion

        private void dateEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (_maTruong == "UEL")
            {
                DateEdit dedit = sender as DateEdit;
                DateTime strGet_ngay = DateTime.Now;
                if (dedit.Name == "dateEditTuNgay")
                    strGet_ngay = Convert.ToDateTime(dateEditTuNgay.EditValue.ToString());
                else
                    strGet_ngay = Convert.ToDateTime(dateEditDenNgay.EditValue.ToString());
                string strGetQuyen = QuyenTruongThanhTra(UserInfo.GroupName, strGet_ngay);
                KhongDuocPhepCapNhat(strGetQuyen);
            }
        }

        string GetSoTietGhiNhan(string[] LstKetQua)
        {
            int iSoPhut = 0;
            double iSoTiet = 0;
            for (int i = 0; i < LstKetQua.Length; i++)
            {
                if (i == 0)
                    iSoPhut = int.Parse(LstKetQua[i].ToString()) * 60;
                else
                    iSoPhut = iSoPhut + int.Parse(LstKetQua[i].ToString());
            }
            iSoTiet = iSoPhut / 50;
            iSoTiet = Math.Round(iSoTiet, MidpointRounding.AwayFromZero);
            return iSoTiet.ToString();
        }

        string QuyenTruongThanhTra(string str_Quyen, DateTime str_TuNgay)
        {
            string strQuyen = "true";
            DateTime Dt = DateTime.Now;
            DateTime strTuNgay = str_TuNgay;
            if (strTuNgay.ToShortDateString().ToString() != Dt.ToShortDateString().ToString())
            {
                if (str_Quyen == "TruongThanhTra")
                {
                    strQuyen = "false";
                }

            }
            else
            {
                strQuyen = "false";
            }
            return strQuyen;
        }

        int GetSoTietGhiNhan(DataTable tbl, string strMaLopHocPhan)
        {
            int iResult = 0;
            DataRow[] ArrayRows = tbl.Select("MaLopHocPhan=" + "'" + strMaLopHocPhan + "'");
            foreach (DataRow item in ArrayRows)
            {
                iResult = int.Parse(item["SoTietGhiNhan"].ToString());
            }
            return iResult;
        }

    }
}