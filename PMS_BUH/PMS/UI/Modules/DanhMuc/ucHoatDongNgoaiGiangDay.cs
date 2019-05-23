﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Services;
using PMS.Entities;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
//using Libraries.DevEx;
//using Libraries.Entities;
//using Libraries.BLL;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucHoatDongNgoaiGiangDay : DevExpress.XtraEditors.XtraUserControl
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

        string _maTruong;
        TList<CauHinhChung> _listCauHinh = DataServices.CauHinhChung.GetAll();
        RepositoryItemGridLookUpEdit repositoriGridNhom = new RepositoryItemGridLookUpEdit();
        public ucHoatDongNgoaiGiangDay()
        {
            InitializeComponent();
            _maTruong = PMS.Common.Globals.GetMaTruong(_listCauHinh, "Mã trường");
        }

        void InitShowColumns()
        {
            AppGridView.InitGridView(gridViewHoatDongNgoaiGiangDay, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewHoatDongNgoaiGiangDay, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewHoatDongNgoaiGiangDay, new string[] { "TenHoatDong", "MaNhom", "MaDonViTinh", "SoLuong", "MucQuyDoi", "DonGia", "NhomHoatDongBt", "NhomHoatDongClc","ThanhToanBinhThuong", "GhiChu" }
                        , new string[] { "Tên hoạt động", "Tên nhóm", "Đơn vị tính", "Số lượng", "Mức quy đổi", "Đơn giá", "Mặc định", "Mặc định Clc","Mặc định TT", "Ghi chú" }
                        , new int[] { 300, 200, 100, 100, 100, 100, 70, 70,70, 220 });
            AppGridView.AlignHeader(gridViewHoatDongNgoaiGiangDay, new string[] { "TenHoatDong", "MaNhom", "MaDonViTinh", "SoLuong", "MucQuyDoi", "DonGia", "NhomHoatDongBt", "NhomHoatDongClc", "ThanhToanBinhThuong", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewHoatDongNgoaiGiangDay, "MaDonViTinh", repositoryItemGridLookUpEditDonViTinh);
            AppGridView.SummaryField(gridViewHoatDongNgoaiGiangDay, "TenHoatDong", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewHoatDongNgoaiGiangDay, "SoLuong", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewHoatDongNgoaiGiangDay, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");

            #region Nhom

            //dtNhom = Libraries.BLL.DBComunication.GetTable("NhomHoatDongNgoaiGiangDay", string.Empty, false, false);
            //repositoriGridNhom.InitRepositoryItemGridLookUp(
            //    new ColumnProperty[]{
            //        new ColumnProperty("MaNhom","Mã nhóm",200){isValueMember = true}
            //        , new ColumnProperty("TenNhom", "Tên nhóm", 500){isDisplayMember = true}
            //    }, true, TextEditStyles.Standard, new Size(), string.Empty, dtNhom);

            gridViewHoatDongNgoaiGiangDay.Columns["MaNhom"].ColumnEdit = repositoriGridNhom;

            repositoriGridNhom.DataSource = DataServices.NhomHoatDongNgoaiGiangDay.GetAll();
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoriGridNhom, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoriGridNhom, 700, 650);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoriGridNhom, new string[] { "MaNhom", "TenNhom" }, new string[] { "Mã nhóm", "Tên nhóm" }, new int[] { 200, 500 });
            repositoriGridNhom.ValueMember = "MaNhom";
            repositoriGridNhom.DisplayMember = "TenNhom";
            repositoriGridNhom.NullText = string.Empty;

            #endregion
        }

        private void ucHoatDongNgoaiGiangDay_Load(object sender, EventArgs e)
        {
            #region InitGridView
            InitShowColumns();
            #endregion

            #region DonViTinh
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditDonViTinh, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditDonViTinh, new string[] { "MaQuanLy", "TenDonVi" }, new string[] { "Mã đơn vị tính", "Tên đơn vị tính" });
            repositoryItemGridLookUpEditDonViTinh.DisplayMember = "TenDonVi";
            repositoryItemGridLookUpEditDonViTinh.ValueMember = "MaDonVi";
            repositoryItemGridLookUpEditDonViTinh.NullText = string.Empty;
            #endregion


            InitData();
        }

        #region InitData
        void InitData()
        {
            bindingSourceDonViTinh.DataSource = DataServices.DonViTinh.GetAll();
            gridControlHoatDongNgoaiGiangDay.DataSource = DataServices.HoatDongNgoaiGiangDay.GetAll();
            repositoriGridNhom.DataSource = DataServices.NhomHoatDongNgoaiGiangDay.GetAll();
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
            AppGridView.DeleteSelectedRows(gridViewHoatDongNgoaiGiangDay);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewHoatDongNgoaiGiangDay.FocusedRowHandle = -1;
            TList<HoatDongNgoaiGiangDay> _list = gridControlHoatDongNgoaiGiangDay.DataSource as TList<HoatDongNgoaiGiangDay>;
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_list.IsValid)
                {
                    try
                    {

                        DataServices.HoatDongNgoaiGiangDay.Save(_list);
                        XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event GridView
        private void gridViewHoatDongNgoaiGiangDay_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHoatDongNgoaiGiangDay, e);
        }

        private void gridViewHoatDongNgoaiGiangDay_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }
        #endregion
    }
}
