﻿using System;
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

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmXemTKBThanhTra : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong, _tenTruong;
        string _groupUser = UserInfo.GroupName;
        #endregion

        #region Event Form
        public frmXemTKBThanhTra()
        {
            InitializeComponent();            
            _maTruong =PMS.Common.Globals.GetMaTruong( _cauHinhChung, "Mã trường");
            _tenTruong = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Tên trường");
        }

        private void frmXemTKBThanhTra_Load(object sender, EventArgs e)
        {
            #region Init GridView
                AppGridView.InitGridView(gridViewThanhTra, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
                AppGridView.ShowField(gridViewThanhTra, new string[] { "Ngay", "Phong", "MaHocPhan", "TenHocPhan", "LoaiHocPhan", "MaGocLopHocPhan", "MaLop", "MaCanBoGiangDay", "HoTen", "Khoa", "Thu", "TietBatDau", "SoTiet", "TienDo", "SiSo", "SoTietGhiNhan", "MaViPham", "MaHinhThucViPhamHrm", "ThoiDiemGhiNhan", "LyDo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }
                        , new string[] { "Ngày", "Phòng học", "Mã học phần", "Tên học phần", "Loại học phần", "Mã lớp học phần", "Mã lớp", "Mã CBGD", "Họ tên", "Đơn vị", "Thứ", "Tiết bắt đầu", "Số tiết", "Tiến độ", "Sĩ số", "Số tiết ghi nhận", "Nội dung vi phạm", "Hình thức vi phạm đánh giá ABC", "Thời điểm ghi nhận", "Lý do", "Ghi chú", "NgayCapNhat", "NguoiCapNhat" }
                        , new int[] { 70, 80, 80, 150, 90, 110, 90, 70, 140, 150, 50, 70, 60, 80, 60, 100, 170, 200, 110, 150, 150, 99, 99 });
                AppGridView.AlignHeader(gridViewThanhTra, new string[] { "Ngay", "Phong", "MaHocPhan", "TenHocPhan", "LoaiHocPhan", "MaGocLopHocPhan", "MaLop", "MaCanBoGiangDay", "HoTen", "Khoa", "Thu", "TietBatDau", "SoTiet", "SoTietGhiNhan", "TienDo", "SiSo", "MaViPham", "MaHinhThucViPhamHrm", "ThoiDiemGhiNhan", "LyDo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
                AppGridView.SummaryField(gridViewThanhTra, "Ngay", "{0}", DevExpress.Data.SummaryItemType.Count);
                AppGridView.HideField(gridViewThanhTra, new string[] { "NgayCapNhat", "NguoiCapNhat", "SiSo" });
                AppGridView.FormatDataField(gridViewThanhTra, "SiSo", DevExpress.Utils.FormatType.Custom, "n0");
                AppGridView.RegisterControlField(gridViewThanhTra, "MaViPham", repositoryItemGridLookUpEditNoiDungViPham);
                AppGridView.RegisterControlField(gridViewThanhTra, "MaHinhThucViPhamHrm", repositoryItemGridLookUpEditHinhThucViPhamHRM);
                AppGridView.ReadOnlyColumn(gridViewThanhTra);
                AppGridView.FixedField(gridViewThanhTra, new string[] { "Ngay", "Phong", "MaHocPhan", "TenHocPhan" }, FixedStyle.Left);
            if(_maTruong != "UEL")
                AppGridView.HideField(gridViewThanhTra, new string[] { "MaHinhThucViPhamHrm" });
            AppGridView.RegisterControlField(gridViewThanhTra, "Ngay", repositoryItemDateEditNgay);
            #endregion

            #region InitRepository ViPham
                AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNoiDungViPham, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
                AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditNoiDungViPham, 400, 650);
                AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNoiDungViPham, new string[] { "MaViPham", "NoiDungViPham", "CoXepLoai" }, new string[] { "Mã vi phạm", "Nội dung vi phạm", "Có xếp loại" }, new int[] { 70, 260, 70 });
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

        #region InitData
        void InitData()
        {
            dateEditTuNgay.DateTime = DateTime.Now;
            dateEditDenNgay.DateTime = DateTime.Now;

            InitCoSo();

            InitDayNha();

            bindingSourceNoiDungViPham.DataSource = DataServices.DanhMucViPham.GetAll();
            if (_tenTruong != "Trường Đại Học Yersin")
                bindingSourceHinhThucViPhamHRM.DataSource = DataServices.ViewHinhThucViPham.GetAll();
            //if (dateEditTuNgay.EditValue != null && dateEditDenNgay.EditValue != null && cboDayNha.EditValue != null)
            //{
            //    bindingSourceThanhTra.DataSource = DataServices.ViewThanhTraTheoThoiKhoaBieu.GetByNgayCoSoToaNha(dateEditTuNgay.DateTime.ToString("dd/MM/yyyy"), dateEditDenNgay.DateTime.ToString("dd/MM/yyyy"), cboDayNha.EditValue.ToString());
            //    ToMau(bindingSourceThanhTra.DataSource as VList<ViewThanhTraTheoThoiKhoaBieu>);
            //}
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
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Bạn chưa nhập tên file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewThanhTra.FocusedRowHandle = -1;
            bindingSourceThanhTra.EndEdit();
            VList<ViewThanhTraTheoThoiKhoaBieu> list = bindingSourceThanhTra.DataSource as VList<ViewThanhTraTheoThoiKhoaBieu>;
            DataTable data = list.ToDataSet(false).Tables[0];

            if (data == null)
                return;

            DataTable vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThanhTra, data);

            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (GridColumn c in gridViewThanhTra.SortedColumns)
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
                    frm.InThanhTraTheoNgay(Common.Globals._cauhinh.TenTruong, dateEditTuNgay.DateTime.ToString("dd/MM/yyyy"), dateEditDenNgay.DateTime.ToString("dd/MM/yyyy"), UserInfo.FullName, vListBaoCao);
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
                LoadData();
                ToMau(bindingSourceThanhTra.DataSource as VList<ViewThanhTraTheoThoiKhoaBieu>);
            }
            Cursor.Current = Cursors.Default;
        }


        private void LoadData()
        {
            DataTable tbl = new DataTable();
            IDataReader id = DataServices.ViewThanhTraTheoThoiKhoaBieu.GetByNgayCoSoToaNha(dateEditTuNgay.DateTime.ToString("dd/MM/yyyy"), dateEditDenNgay.DateTime.ToString("dd/MM/yyyy"), cboDayNha.EditValue.ToString());
            tbl.Load(id);
            bindingSourceThanhTra.DataSource = tbl;
        }

        #endregion


        #region Event GridView
        private void gridViewThanhTra_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "SiSo" || col.FieldName == "MaViPham" || col.FieldName == "ThoiDiemGhiNhan" || col.FieldName == "LyDo" || col.FieldName == "GhiChu" || col.FieldName == "MaHinhThucViPhamHrm" || col.FieldName == "SoTietGhiNhan")
            {
                gridViewThanhTra.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
                gridViewThanhTra.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }

            if (col.FieldName == "SoTietGhiNhan")
            {
                ViewThanhTraTheoThoiKhoaBieu v = gridViewThanhTra.GetRow(e.RowHandle) as ViewThanhTraTheoThoiKhoaBieu;
                if (v.SoTietGhiNhan > 15)
                {
                    XtraMessageBox.Show("Số tiết nhập quá giới hạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gridViewThanhTra.SetRowCellValue(e.RowHandle, "SoTietGhiNhan", "");
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
                            foreach (int i in gridViewThanhTra.GetSelectedRows())
                            {
                                gridViewThanhTra.SetRowCellValue(i, "SiSo", null);
                                gridViewThanhTra.SetRowCellValue(i, "MaViPham", "");
                                gridViewThanhTra.SetRowCellValue(i, "MaHinhThucViPhamHrm", "");
                                gridViewThanhTra.SetRowCellValue(i, "ThoiDiemGhiNhan", "");
                                gridViewThanhTra.SetRowCellValue(i, "LyDo", "");
                                gridViewThanhTra.SetRowCellValue(i, "GhiChu", "");
                                gridViewThanhTra.SetRowCellValue(i, "SoTietGhiNhan", "");
                            }
                        }
            }
            catch
            { }
        }
        #endregion

        #region Event Cbo
        private void cboCoSo_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitDayNha();
            Cursor.Current = Cursors.Default;
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

        private void gridViewThanhTra_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            ViewThanhTraTheoThoiKhoaBieu obj = gridViewThanhTra.GetRow(e.RowHandle) as ViewThanhTraTheoThoiKhoaBieu;
            //Kiểm tra quá số ngày cho phép chấm thanh tra
            if (obj != null)
            {
                bool kq = false, trongGioChamGiang = false;
                DataServices.ThanhTraTheoThoiKhoaBieu.KiemTraThoiHanChamThanhTra(obj.Ngay, ref kq);
                if (!kq)
                {
                    XtraMessageBox.Show("Ngoài thời gian chấm giảng. Vui lòng liên hệ với quản trị viên để biết thêm chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ColumnView view = (ColumnView)gridControlThanhTra.KeyboardFocusView;
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
                        XtraMessageBox.Show("Ngoài thời gian chấm giảng. Thời gian chấm giảng từ 06h00 đến 18h00 cùng ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ColumnView view = (ColumnView)gridControlThanhTra.KeyboardFocusView;
                        if (view.IsEditing)
                            view.HideEditor();
                        view.CancelUpdateCurrentRow();
                    }
                }
            }
        }
    }
}