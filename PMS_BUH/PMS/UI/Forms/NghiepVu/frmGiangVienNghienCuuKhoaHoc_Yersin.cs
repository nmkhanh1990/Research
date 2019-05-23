﻿using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.UI.Forms.BaoCao;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmGiangVienNghienCuuKhoaHoc_Yersin : DevExpress.XtraEditors.XtraForm
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
        VList<ViewGiangVien> _listGiangVien;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        TList<DanhMucNghienCuuKhoaHoc> _danhMucNCKH;
        string _strMaTruong, _strTenTruong = string.Empty;
        TList<VaiTro> _listVaiTro;
        DateTime _ngayIn;
        TList<LoaiNghienCuuKhoaHoc> _listLoaiNCKH;
        #endregion

        public frmGiangVienNghienCuuKhoaHoc_Yersin()
        {
            InitializeComponent();
            _strMaTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _strTenTruong = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Tên trường");
          
        }

        private void frmGiangVienNghienCuuKhoaHoc_DLU_Load(object sender, EventArgs e)
        {
            //DLU nhập NCKH theo kỳ
            #region InitGridView
            AppGridView.InitGridView(gridViewGiangVienNCKH, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewGiangVienNCKH, new string[] { "MaGiangVien", "Ho", "Ten", "TenDonVi", "MaNckh", "TenNckh", "SoLuongThanhVien", "MaVaiTro", "DuKien", "SoTiet", "XacNhan", "NgayNhap", "NgayCapNhat", "NguoiCapNhat", "Id", "NgayXacNhan", "MaQuanLy" },
                                    new string[] { "Mã giảng viên", "Họ", "Tên", "Khoa - Đơn vị", "Loại NCKH", "Tên đề tài", "Số thành viên tham gia", "Vai trò", "Dự kiến", "Số lượng", "Xác nhận", "Ngày nhập", "Ngày cập nhật", "Người cập nhật", "Id", "NgayXacNhan", "MaQuanLy" },
                                    new int[] { 90, 115, 55, 200, 200, 200, 70, 80, 70, 70, 70, 80, 99, 99, 99, 99, 99 });
            AppGridView.ShowEditor(gridViewGiangVienNCKH, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.SummaryField(gridViewGiangVienNCKH, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.AlignHeader(gridViewGiangVienNCKH, new string[] { "MaGiangVien", "Ho", "Ten", "TenDonVi", "MaNckh", "TenNckh", "SoLuongThanhVien", "MaVaiTro", "DuKien", "SoTiet", "XacNhan", "NgayCapNhat", "NguoiCapNhat", "Id" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewGiangVienNCKH, new string[] { "NgayCapNhat", "NguoiCapNhat", "Id", "NgayXacNhan", "MaQuanLy" });
            AppGridView.RegisterControlField(gridViewGiangVienNCKH, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewGiangVienNCKH, "MaNckh", repositoryItemGridLookUpEditDanhMucNCKH);
            AppGridView.RegisterControlField(gridViewGiangVienNCKH, "MaVaiTro", repositoryItemGridLookUpEditVaiTro);
            AppGridView.FormatDataField(gridViewGiangVienNCKH, "SoTiet", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FixedField(gridViewGiangVienNCKH, new string[] { "MaGiangVien", "Ho", "Ten" }, FixedStyle.Left);
            PMS.Common.Globals.WordWrapHeader(gridViewGiangVienNCKH, 40);

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
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenDonVi" },
                    new string[] { "Mã giảng viên", "Họ tên", "Bộ môn" }, new int[] { 100, 150, 180 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 430, 650);
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            #region DanhMuc NCKH
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditDanhMucNCKH, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditDanhMucNCKH, new string[] { "MaQuanLy", "TenNghienCuuKhoaHoc", "SoTiet", "GhiChu" },
                    new string[] { "Mã NCKH", "Tên nghiên cứu khoa học", "Số tiết", "Chi chú" }, new int[] { 60, 440, 80, 120 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditDanhMucNCKH, 600, 650);
            repositoryItemGridLookUpEditDanhMucNCKH.DisplayMember = "TenNghienCuuKhoaHoc";
            repositoryItemGridLookUpEditDanhMucNCKH.ValueMember = "Id";
            repositoryItemGridLookUpEditDanhMucNCKH.NullText = string.Empty;
            #endregion

            #region Vai tro

            if (_strMaTruong == "DLU")
            {
                AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditVaiTro, true, TextEditStyles.Standard);
                AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditVaiTro, new string[] { "MaVaiTro", "TenVaiTro" },
                        new string[] { "Mã vai trò", "Tên vai trò" }, new int[] { 100, 200 });
                AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditVaiTro, 400, 200);
            }
            else
            {
                AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditVaiTro, true, TextEditStyles.Standard);
                AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditVaiTro, new string[] { "MaVaiTro", "TenVaiTro", "MucHuong" },
                        new string[] { "Mã vai trò", "Tên vai trò", "Mức hưởng (%)" }, new int[] { 100, 200, 100 });
                AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditVaiTro, 400, 200);
            }
            repositoryItemGridLookUpEditVaiTro.DisplayMember = "TenVaiTro";
            repositoryItemGridLookUpEditVaiTro.ValueMember = "Id";
            repositoryItemGridLookUpEditVaiTro.NullText = string.Empty;
            repositoryItemGridLookUpEditVaiTro.BestFitMode = BestFitMode.BestFit;
            #endregion

            int iichekc = PMS.Common.XuLyGiaoDien.CheckMaTruong(_strMaTruong, _strTenTruong);
            if (iichekc == 1)
            {
                AppGridView.HideField(gridViewGiangVienNCKH, new string[] { "SoLuongThanhVien", "MaVaiTro", "DuKien" });
            }

            InitData();

           
        }
        #region InitData
        void InitData()
        {
            _listLoaiNCKH = DataServices.LoaiNghienCuuKhoaHoc.GetAll();
            _listGiangVien = DataServices.ViewGiangVien.GetAll();
            bindingSourceGiangVien.DataSource = _listGiangVien;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            _danhMucNCKH = DataServices.DanhMucNghienCuuKhoaHoc.GetAll();
            bindingSourceDanhMucNCKH.DataSource = _danhMucNCKH;
            _listVaiTro = DataServices.VaiTro.GetAll();
            bindingSourceVaiTro.DataSource = _listVaiTro;

            LoadDataSource();
        }

        void LoadDataSource()
        {

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.GiangVienNghienCuuKh.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tb.Load(reader);
                foreach (DataColumn col in tb.Columns)
                    col.ReadOnly = false;
                bindingSourceGiangVienNghienCuuKhoaHoc.DataSource = tb;

                gridViewGiangVienNCKH.ExpandAllGroups();
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

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewGiangVienNCKH);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewGiangVienNCKH.FocusedRowHandle = -1;
            DataTable list = bindingSourceGiangVienNghienCuuKhoaHoc.DataSource as DataTable;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        bindingSourceGiangVienNghienCuuKhoaHoc.EndEdit();
                        string xmlData = "";
                        int kq = 0;

                        foreach (DataRow v in list.Rows)
                        {
                            if (v.RowState != DataRowState.Deleted)
                            {
                                if ((int)PMS.Common.Globals.IsNull(v["MaGiangVien"], "int") != 0 && (int)PMS.Common.Globals.IsNull(v["MaNckh"], "int") != 0)
                                {
                                    xmlData += String.Format("<Input M=\"{0}\" MN=\"{1}\" S=\"{2}\" D=\"{3}\" U=\"{4}\" T=\"{5}\" NN=\"{6}\" SL=\"{7}\" V=\"{8}\" DK=\"{9}\" X=\"{10}\" NX=\"{11}\" Id=\"{12}\" />"
                                        , v["MaGiangVien"], v["MaNckh"], v["SoTiet"], v["NgayCapNhat"], v["NguoiCapNhat"]
                                        , v["TenNckh"], v["NgayNhap"]
                                        , v["SoLuongThanhVien"], v["MaVaiTro"]
                                        , PMS.Common.Globals.IsNull(v["DuKien"], "bool")
                                        , PMS.Common.Globals.IsNull(v["XacNhan"], "bool")
                                        , v["NgayXacNhan"]
                                        , PMS.Common.Globals.IsNull(v["Id"], "int"));
                                }
                                else
                                {
                                    XtraMessageBox.Show("Vui lòng nhập đủ thông tin giảng viên, loại NCKH, vai trò, số thành viên tham gia.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                            }
                        }
                        xmlData = String.Format("<Root>{0}</Root>", xmlData);

                        DataServices.GiangVienNghienCuuKh.LuuTheoHocKy(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);

                        if (kq == 0)
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        InitData();
                        Cursor.Current = Cursors.Default;
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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
                            gridControlGiangVienNCKH.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }
        #endregion
        #region Event Grid
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            LoadDataSource();
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadDataSource();
            Cursor.Current = Cursors.Default;
        }

        private void gridViewGiangVienNCKH_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewGiangVienNCKH, e);
        }

        private void gridViewGiangVienNCKH_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                GridColumn col = e.Column;
                if (col.FieldName == "MaGiangVien")
                {
                    DataRowView nckh = gridViewGiangVienNCKH.GetRow(e.RowHandle) as DataRowView;
                    ViewGiangVien _gv = _listGiangVien.Find(p => p.MaGiangVien == int.Parse(nckh["MaGiangVien"].ToString()));
                    gridViewGiangVienNCKH.SetRowCellValue(e.RowHandle, "Ho", _gv.Ho);
                    gridViewGiangVienNCKH.SetRowCellValue(e.RowHandle, "Ten", _gv.Ten);
                    gridViewGiangVienNCKH.SetRowCellValue(e.RowHandle, "TenDonVi", _gv.TenDonVi);
                    gridViewGiangVienNCKH.SetRowCellValue(e.RowHandle, "MaQuanLy", _gv.MaQuanLy);

                }

                if (col.FieldName == "MaNckh" || col.FieldName == "SoLuongThanhVien" || col.FieldName == "MaVaiTro")
                {
                    DataRowView nckh = gridViewGiangVienNCKH.GetRow(e.RowHandle) as DataRowView;
                    DanhMucNghienCuuKhoaHoc _dmNCKH = _danhMucNCKH.Find(p => p.Id == int.Parse(nckh["MaNckh"].ToString()));
                    decimal? _sotiet = _dmNCKH.SoTiet;
                    VaiTro _vt = _listVaiTro.Find(p => p.Id == int.Parse(nckh["MaVaiTro"].ToString()));

                    int _soLuongThanhVien = int.Parse(nckh["SoLuongThanhVien"].ToString());

                    LoaiNghienCuuKhoaHoc _lNCKH = _listLoaiNCKH.Find(p => p.Id == _dmNCKH.MaLoaiNckh);

                    decimal? _soTietDuocHuong = 0;

                    if (_lNCKH.Id == 1)//Thực hiện các đề tài nghiên cứu khoa học
                    {
                        if (_vt.Id == 1)//Chủ trì đề tài, chủ biên
                        {
                            if (_soLuongThanhVien == 1)//Nếu đề tài có 1 người tham gia: hưởng hết
                                _soTietDuocHuong = _sotiet;
                            if (_soLuongThanhVien == 2)//Nếu đề tài có 2 người tham gia: hưởng 2/3
                                _soTietDuocHuong = _sotiet * 2 / 3;
                            if (_soLuongThanhVien > 2)//Nếu đề tài chó hơn 2 thành viên: hưởng theo % quy định
                                _soTietDuocHuong = _sotiet * _lNCKH.ChuTriDeTaiHuong / 100;
                        }
                        else//Thành viên
                        {
                            if (_soLuongThanhVien == 1)//Nếu đề tài có 1 người tham gia: hưởng hết
                                _soTietDuocHuong = _sotiet;
                            if (_soLuongThanhVien == 2)//Nếu đề tài có 2 người tham gia: hưởng 1/3
                                _soTietDuocHuong = _sotiet * 1 / 3;
                            if (_soLuongThanhVien > 2)//Nếu đề tài chó hơn 2 người tham gia: hưởng theo % quy định
                                _soTietDuocHuong = (_sotiet * _lNCKH.ThanhVienHuong / 100) / _soLuongThanhVien;
                        }
                    }

                    if (_lNCKH.Id == 2)//Bài viết, bài báo
                    {
                        _soTietDuocHuong = _sotiet / _soLuongThanhVien;//Số tiết được hưởng chia đều cho các thành viên
                    }
                    if (_lNCKH.Id == 3)//Công trình biên dịch, biên soạn sách chuyên khảo, tham khảo, giáo trình
                    {
                        if (_vt.Id == 1)//Chủ trì đề tài, chủ biên
                        {
                            if (_soLuongThanhVien == 1)//Nếu đề tài có 1 người tham gia: hưởng hết
                                _soTietDuocHuong = _sotiet;
                            if (_soLuongThanhVien == 2 || _soLuongThanhVien == 3)//Nếu có 2-3 người tham gia: hưởng 2/3
                                _soTietDuocHuong = _sotiet * 2 / 3;
                            if (_soLuongThanhVien > 3)//Nếu hơn 3 thành viên thì hưởng 1/3
                                _soTietDuocHuong = _sotiet * _lNCKH.ChuTriDeTaiHuong / 100;
                        }
                        else //Thành viên
                        {
                            if (_soLuongThanhVien == 1)//Nếu đề tài có 1 người tham gia: hưởng hết
                                _soTietDuocHuong = _sotiet;
                            if (_soLuongThanhVien == 2)//Nếu có 2 người tham gia: hưởng 1/3
                                _soTietDuocHuong = _sotiet * 1 / 3;
                            if (_soLuongThanhVien == 3)//Nếu có 3 người tham gia: 2 người thành viên mỗi người hưởng 1 nửa của 1/3 còn lại
                                _soTietDuocHuong = (_sotiet * 1 / 3) / 2;
                            if (_soLuongThanhVien > 3)//Nếu hơn 3 thành viên thì hưởng 1/3
                                _soTietDuocHuong = (_sotiet * _lNCKH.ThanhVienHuong / 100) / _soLuongThanhVien;
                        }
                    }

                    if (_lNCKH.Id > 3)
                    {
                        if (_vt.Id == 1)//Chủ trì đề tài, chủ biên
                        {
                            if (_soLuongThanhVien == 1)//Nếu đề tài có 1 người tham gia: hưởng hết
                                _soTietDuocHuong = _sotiet;
                            if (_soLuongThanhVien == 2)//Nếu đề tài có 2 người tham gia: hưởng 2/3
                                _soTietDuocHuong = _sotiet * 2 / 3;
                            if (_soLuongThanhVien > 2)//Nếu đề tài có hơn 2 thành viên: hưởng theo % quy định
                                _soTietDuocHuong = _sotiet * _lNCKH.ChuTriDeTaiHuong / 100;
                        }
                        else//Thành viên
                        {
                            if (_soLuongThanhVien == 1)//Nếu đề tài có 1 người tham gia: hưởng hết
                                _soTietDuocHuong = _sotiet;
                            if (_soLuongThanhVien == 2)//Nếu đề tài có 2 người tham gia: hưởng 1/3
                                _soTietDuocHuong = _sotiet * 1 / 3;
                            if (_soLuongThanhVien > 2)//Nếu đề tài chó hơn 2 người tham gia: hưởng theo % quy định
                                _soTietDuocHuong = (_sotiet * _lNCKH.ThanhVienHuong / 100) / _soLuongThanhVien;
                        }
                    }

                    gridViewGiangVienNCKH.SetRowCellValue(e.RowHandle, "SoTiet", _soTietDuocHuong);
                }

                if (col.FieldName == "XacNhan")
                {
                    DataRowView nckh = gridViewGiangVienNCKH.GetRow(e.RowHandle) as DataRowView;
                    if (nckh["XacNhan"].ToString().ToLower() == "true")
                    {
                        gridViewGiangVienNCKH.SetRowCellValue(e.RowHandle, "DuKien", false);
                        gridViewGiangVienNCKH.SetRowCellValue(e.RowHandle, "NgayXacNhan", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    }
                }

                if (col.FieldName == "MaGiangVien" || col.FieldName == "MaNckh" || col.FieldName == "TenNckh" || col.FieldName == "SoLuongThanhVien" 
                        || col.FieldName == "MaVaiTro" || col.FieldName == "DuKien" || col.FieldName == "SoTiet" || col.FieldName == "XacNhan")
                {
                    gridViewGiangVienNCKH.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    gridViewGiangVienNCKH.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
                }
            }
            catch
            {  }
           
        }
        #endregion

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DataTable tb = bindingSourceGiangVienNghienCuuKhoaHoc.DataSource as DataTable;
                gridViewGiangVienNCKH.FocusedRowHandle = -1;
                if (tb.Rows.Count == 0) return;
                DataTable vListBaoCao = tb.Select("XacNhan = 'True'").CopyToDataTable();

                if (vListBaoCao.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Chưa có đề tài nào được xác nhận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                using (frmChonNgay frmChon = new frmChonNgay())
                {
                    frmChon.ShowDialog();
                    DateTime dtNgay = frmChon.NgayIn;
                    if (dtNgay.ToString("dd/MM/yyyy") == "01/01/0001")
                        return;
                    _ngayIn = frmChon.NgayIn;

                }

                string sort = "";
                if (vListBaoCao != null)
                {
                    if (vListBaoCao.Rows.Count != 0)
                    {
                        foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewGiangVienNCKH.SortedColumns)
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
                        frm.ThongKeNghienCuuKhoaHoc(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), UserInfo.FullName, _ngayIn, vListBaoCao);
                        frm.ShowDialog();
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch
            {
            }
        }

        private void btnInTatCa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DataTable tb = bindingSourceGiangVienNghienCuuKhoaHoc.DataSource as DataTable;
                gridViewGiangVienNCKH.FocusedRowHandle = -1;
                if (tb.Rows.Count == 0) return;

                using (frmChonNgay frmChon = new frmChonNgay())
                {
                    frmChon.ShowDialog();
                    DateTime dtNgay = frmChon.NgayIn;
                    if (dtNgay.ToString("dd/MM/yyyy") == "01/01/0001")
                        return;
                    _ngayIn = frmChon.NgayIn;

                }
                string sort = "";
                if (tb != null)
                {
                    if (tb.Rows.Count != 0)
                    {
                        foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewGiangVienNCKH.SortedColumns)
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

                string filter = gridViewGiangVienNCKH.ActiveFilterString;             
                DataView dv = new DataView(tb, filter, sort, DataViewRowState.CurrentRows);
                tb = dv.ToTable();
                if (tb == null)
                    return;
                if (tb != null && tb.Rows.Count > 0)
                {
                    using (frmBaoCao frm = new frmBaoCao())
                    {
                        frm.ThongKeNghienCuuKhoaHoc(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), UserInfo.FullName, _ngayIn, tb);
                        frm.ShowDialog();
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch
            {
            }
        }
    }
}