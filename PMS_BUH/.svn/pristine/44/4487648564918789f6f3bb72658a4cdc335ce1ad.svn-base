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
using PMS.UI.Forms.BaoCao;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmThanhToanThuLaoThinhGiang_HBU : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ItemShortcut = DevExpress.XtraBars.BarShortcut.Empty;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong, _strTenTruong;
        bool userRole;
        string _groupName = UserInfo.GroupName;
        DataTable tb;
        #endregion

        #region Event Form
        public frmThanhToanThuLaoThinhGiang_HBU()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _strTenTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Tên trường").GiaTri;
        }

        private void frmThanhToanThuLaoThinhGiang_HBU_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewThuLaoThinhGiang, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewThuLaoThinhGiang, new string[] { "XacNhan", "MaQuanLy", "Ho", "Ten", "ChucDanh", "MaLopHocPhan", "TenMonHoc", "LoaiHocPhan", "MaLop", "SiSo", "TietThucDay", "HeSoQuyDoi", "HeSoQuyDoiThucHanhSangLyThuyet", "HeSoChucDanhChuyenMon", "HeSoNgoaiGio", "HeSoLopDong", "HeSoKhoiNganh", "HeSoBacDaoTao", "HeSoNgonNgu", "TietQuyDoi", "DonGia", "NoiDung", "ThanhTien", "Thue", "ConNhan", "GhiChu", "TenDonVi", "STT", "MaGiangVien", "NgayXacNhan" }
                , new string[] { "Xác nhận", "Mã giảng viên", "Họ", "Tên", "Chức danh", "Lớp học phần", "Tên môn", "Loại HP", "Mã lớp", "Sĩ số", "Tiết thực dạy", "Hệ số quy đổi", "HS QD TH && LT", "HS chức danh", "HS ngoài giờ", "HS lớp đông", "HS khối ngành", "HS bậc đào tạo", "HS ngôn ngữ", "Tiết quy đổi", "Đơn giá", "Nội dung", "Thành tiền", "Thuế TNCN", "Còn nhận", "Ghi chú", "Tên khoa - Đơn vị", "STT", "Mã Giảng Viên", "Ngày xác nhận" }
                , new int[] { 70, 90, 115, 55, 120, 100, 120, 100, 70, 60, 70, 80, 80, 80, 80, 80, 90, 99, 99, 99, 80, 120, 99, 99, 99, 99, 160, 60, 100, 100 });
            AppGridView.AlignHeader(gridViewThuLaoThinhGiang, new string[] { "XacNhan", "MaQuanLy", "Ho", "Ten", "ChucDanh", "TenMonHoc", "MaLopHocPhan", "LoaiHocPhan", "MaLop", "SiSo", "TietThucDay", "HeSoQuyDoi", "HeSoQuyDoiThucHanhSangLyThuyet", "HeSoChucDanhChuyenMon", "HeSoNgoaiGio", "HeSoLopDong", "HeSoKhoiNganh", "HeSoBacDaoTao", "HeSoNgonNgu", "TietQuyDoi", "DonGia", "NoiDung", "ThanhTien", "Thue", "ConNhan", "GhiChu", "TenDonVi", "STT", "MaLopHocPhan", "MaGiangVien", "NgayXacNhan" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.FixedField(gridViewThuLaoThinhGiang, new string[] { "XacNhan", "MaQuanLy", "Ho", "Ten" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            AppGridView.HideField(gridViewThuLaoThinhGiang, new string[] { "STT", "MaGiangVien", "NgayXacNhan" });
            AppGridView.FormatDataField(gridViewThuLaoThinhGiang, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThuLaoThinhGiang, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThuLaoThinhGiang, "Thue", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThuLaoThinhGiang, "ConNhan", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.ReadOnlyColumn(gridViewThuLaoThinhGiang, new string[] { "MaQuanLy", "Ho", "Ten", "ChucDanh", "TenMonHoc", "MaLopHocPhan", "LoaiHocPhan", "MaLop", "SiSo", "TietThucDay", "HeSoQuyDoi", "HeSoQuyDoiThucHanhSangLyThuyet", "HeSoChucDanhChuyenMon", "HeSoNgoaiGio", "HeSoLopDong", "HeSoKhoiNganh", "HeSoBacDaoTao", "HeSoNgonNgu", "TietQuyDoi", "DonGia", "NoiDung", "ThanhTien", "Thue", "ConNhan" });

            //PMS.Common.Globals.WordWrapHeader(gridViewThuLaoThinhGiang, 40);


            //gridViewThuLaoThinhGiang.Columns["TenDonVi"].GroupIndex = 0;
            PMS.Common.Globals.GridRowColor(gridViewThuLaoThinhGiang, new Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold), Color.Aquamarine, "STT", "0");
            AppGridView.SummaryField(gridViewThuLaoThinhGiang, "MaLop", "{0}", DevExpress.Data.SummaryItemType.Count);
            //PMS.Common.Globals.GridRowColor(gridViewThuLaoThinhGiang, Color.Aquamarine, "XacNhan", "True");

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            InitData();
        }
        #endregion

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            LoadNgayBatDauKetThucHocKy();

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
                else
                    userRole = false;
            }

            //if (userRole)
            //{
            //    _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetByMaBoMon(_groupName);

            //    AppGridView.HideField(gridViewThuLaoThinhGiang, new string[] { "XacNhan", "HeSoChucDanh", "HeSoNgoaiGio", "HeSoLopDong", "HeSoKhoiNganh", "HeSoBacDaoTao", "HeSoNgonNgu", "TietQuyDoi", "DonGia", "ThanhTien", "Thue", "ConNhan", "GhiChu", "MaGiangVien", "MaLopHocPhan", "Id", "NgayNhap", "MaBacDaoTao", "SiSoNhomThucHanh", "MaLoaiHocPhan", "HeSoQuyDoiThucHanhSangLyThuyet" });

            //    btnLuu.Caption = "Lưu số tiết thực tế";
            //}

            ////if (!userRole)
            //    AppGridView.ReadOnlyColumn(gridViewThuLaoThinhGiang, new string[] { "SoTiet" });//Nếu là user Khoa mới dc sửa số tiết, còn lại ko được sửa

            _vListKhoaBoMon.Sort("TenKhoa");
            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                if (v.MaKhoa == v.MaBoMon)
                    _list.Add(new CheckedListBoxItem(v.MaKhoa, v.MaKhoa + " - " + v.TenKhoa, CheckState.Unchecked, true));
            }

            cboDonVi.Properties.Items.AddRange(_list.ToArray());
            cboDonVi.Properties.SeparatorChar = ';';
            cboDonVi.CheckAll();
            #endregion

        }

        void LoadNgayBatDauKetThucHocKy()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DateTime _ngayBatDau = DateTime.Now, _ngayKetThuc = DateTime.Now;
                DataServices.ViewHocKy.GetNgayBatDauKetThuc(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref _ngayBatDau, ref _ngayKetThuc);
                dateEditTuNgay.DateTime = _ngayBatDau;
                dateEditDenNgay.DateTime = DateTime.Now;
            }
        }

        void LoadDataSource()
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDonVi.EditValue != null && dateEditTuNgay.EditValue != null && dateEditDenNgay.EditValue != null)
            {
                tb = new DataTable();
                IDataReader reader = DataServices.ThanhToanThinhGiang.GetByNamHocHocKyDonViTuNgayDenNgay(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), dateEditTuNgay.DateTime, dateEditDenNgay.DateTime, userRole);
                tb.Load(reader);
                //tb.Columns["SoTiet"].ReadOnly = false;
                tb.Columns["XacNhan"].ReadOnly = false;
                bindingSourceThuLaoThinhGiang.DataSource = tb;
                gridViewThuLaoThinhGiang.ExpandAllGroups();
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event Button
        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDataSource();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewThuLaoThinhGiang.FocusedRowHandle = -1;
                DataTable dt = bindingSourceThuLaoThinhGiang.DataSource as DataTable;
                if (dt != null)
                {
                    if (XtraMessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string xmlData = "";
                        foreach (DataRow r in dt.Rows)
                        {
                            if (r.RowState == DataRowState.Modified)
                            {
                               
                                xmlData += "<Input MGV=\"" + r["MaGiangVien"]
                                      + "\" MLHP=\""    + r["MaLopHocPhan"]
                                      + "\" CD=\""      + r["ChucDanh"]
                                      + "\" ML=\""      + r["MaLop"]
                                      + "\" SS=\""      + r["SiSo"]
                                      + "\" HSQD=\""    + PMS.Common.Globals.IsNull(r["HeSoQuyDoi"], "decimal")
                                      + "\" TT=\""      + r["STT"]
                                      + "\" ND=\""      + r["NoiDung"]
                                      + "\" ST=\""      + PMS.Common.Globals.IsNull(r["TietThucDay"], "decimal")
                                      + "\" HSLTTH=\""  + PMS.Common.Globals.IsNull(r["HeSoQuyDoiThucHanhSangLyThuyet"], "decimal")
                                      + "\" HSCD=\""    + PMS.Common.Globals.IsNull(r["HeSoChucDanhChuyenMon"], "decimal")
                                      + "\" HSNG=\""    + PMS.Common.Globals.IsNull(r["HeSoNgoaiGio"], "decimal")
                                      + "\" HSLD=\""    + PMS.Common.Globals.IsNull(r["HeSoLopDong"], "decimal")
                                      + "\" HSKN=\""    + PMS.Common.Globals.IsNull(r["HeSoKhoiNganh"], "decimal")
                                      + "\" HSBDT=\""   + PMS.Common.Globals.IsNull(r["HeSoBacDaoTao"], "decimal")
                                      + "\" HSNN=\""    + PMS.Common.Globals.IsNull(r["HeSoNgonNgu"], "decimal")
                                      + "\" DG=\""      + PMS.Common.Globals.IsNull(r["DonGia"], "decimal")
                                      + "\" T=\""       + PMS.Common.Globals.IsNull(r["ThanhTien"], "decimal")
                                      + "\" TH=\""      + PMS.Common.Globals.IsNull(r["Thue"], "decimal")
                                      + "\" CN=\""      + PMS.Common.Globals.IsNull(r["ConNhan"], "decimal")
                                      + "\" NN=\""      + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
                                      + "\" MBDT=\""    + r["HeSoBacDaoTao"]
                                      + "\" X=\""       + PMS.Common.Globals.IsNull(r["XacNhan"], "bool")
                                      + "\" GC=\""      + r["GhiChu"]
                                      + "\" ID=\""      + r["Id"]
                                      + "\" TQD=\""     + PMS.Common.Globals.IsNull(r["TietQuyDoi"], "decimal")
                                      + "\" />";
                            }

                        }

                        xmlData = "<Root>" + xmlData + "</Root>";

                        int result = 0;

                        DataServices.ThanhToanThinhGiang.LuuHbu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref result);

                        if (result == 0)
                            XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã có lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        LoadDataSource();
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }

        }
        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            LoadNgayBatDauKetThucHocKy();
        }
        #endregion

        #region Event Grid

        private void gridViewThuLaoThinhGiang_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //try
            //{
            //    if (e.Column.FieldName == "SoTiet")
            //    {
            //        DataRowView v = gridViewThuLaoThinhGiang.GetRow(e.RowHandle) as DataRowView;

            //        int kt = 0;
            //        DataServices.ThanhToanThinhGiang.KiemTraThanhToan(v["MaGiangVien"].ToString(), v["MaLopHocPhan"].ToString(), ref kt);

            //        if (kt == 1)
            //        {
            //            XtraMessageBox.Show("Dòng dữ liệu đã xác nhận thanh toán. Không được phép cập nhật số tiết.\n Liên hệ phòng kế toán để biết thêm chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            ColumnView view = (ColumnView)gridControlTLTG.KeyboardFocusView;
            //            if (view.IsEditing)
            //                view.HideEditor();
            //            view.CancelUpdateCurrentRow();
            //        }
            //        else
            //        {
            //            gridViewThuLaoThinhGiang.SetRowCellValue(e.RowHandle, "NgayNhap", DateTime.Now.ToString("dd/MM/yyyy"));
            //        }
            //    }
            //}
            //catch
            //{ }
            try
            {
                if (e.Column.FieldName == "XacNhan")
                {
                    DataRowView v = gridViewThuLaoThinhGiang.GetRow(e.RowHandle) as DataRowView;
                    DataTable dt = bindingSourceThuLaoThinhGiang.DataSource as DataTable;

                    foreach (DataRow r in dt.Rows)
                    {
                        if (r["MaLopHocPhan"].ToString() == v["MaLopHocPhan"].ToString())
                        {
                            if (v["XacNhan"].ToString().ToLower() == "true")
                            {
                                r["XacNhan"] = true;
                            }
                            else r["XacNhan"] = false;
                        }
                    }
                }
            }
            catch
            { }
        }
        #endregion

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            LoadNgayBatDauKetThucHocKy();
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlTLTG.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        private void btn_InThanhLy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InBaoCao(btn_InThanhLy.Name.ToString());
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        private void btn_InHopDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InBaoCao(btn_InHopDong.Name.ToString());
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        private void InBaoCao(string strBtnName)
        {
            Cursor.Current = Cursors.WaitCursor;
            TList<CauHinh> lstcauhinh = DataServices.CauHinh.GetAll();
            gridViewThuLaoThinhGiang.FocusedRowHandle = -1;
            bindingSourceThuLaoThinhGiang.EndEdit();
            DataTable data = bindingSourceThuLaoThinhGiang.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;
            vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThuLaoThinhGiang, bindingSourceThuLaoThinhGiang);
            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewThuLaoThinhGiang.SortedColumns)
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
                    foreach (DataRow r in vListBaoCao.Rows)
                    {
                        xmlData += "<Professors MaGiangVien= \"" + r["MaGiangVien"]
                                    + "\" />";
                    }
                    xmlData = "<Root>" + xmlData + "</Root>";
                    if (strBtnName == "btnIn")
                    {
                        frm.InDanhSachThanhToanThuLaoTheoKhoa_HBU(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()
                            , PMS.Common.Globals._cauhinh.PhongToChucCanBo, PMS.Common.Globals._cauhinh.PhongDaoTao, PMS.Common.Globals._cauhinh.NguoiLapbieu
                            , vListBaoCao);
                    }
                    else if (strBtnName == "btn_InThanhLy")
                    {
                        DataTable tblKetQua = new DataTable("KetQua");
                        IDataReader readerKQ = DataServices.KetQuaThanhToanThuLao.GetThanhToanHopDong_BHU(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                        tblKetQua.Load(readerKQ);

                        DataSet dsData = new DataSet();
                        dsData.Tables.Add(tblKetQua);

                        frm.InBienBanThanhLyHopDongThinhGiang_HBU(_strTenTruong, dsData, lstcauhinh);
                    }
                    else if (strBtnName == "btn_InHopDong")
                    {
                        DataTable tblKetQua = new DataTable("KetQua");
                        IDataReader readerKQ = DataServices.KetQuaThanhToanThuLao.GetThanhToanHopDong_BHU(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                        tblKetQua.Load(readerKQ);

                        DataSet dsData = new DataSet();
                        dsData.Tables.Add(tblKetQua);
                        frm.InHopDongThinhGiang_HBU(_strTenTruong, dsData, lstcauhinh);
                    }
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }
    }
}