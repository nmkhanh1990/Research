using DevExpress.Common.Grid;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMS.UI.Forms.FormCon
{
    public partial class frmCauHinhChiTiet : Form
    {
        public frmCauHinhChiTiet()
        {
            InitializeComponent();
        }

        public frmCauHinhChiTiet(object data_source)
        {
            InitializeComponent();
            //if(data_source is ChiTietGiamTruDinhMuc)
            //{
                bindingSourceCauHinh.DataSource = data_source;
            //}
        }

        #region Hàm xử lý
        void InitData()
        {
            bindingSourceGiamTru.DataSource = DataServices.GiamTruDinhMuc.GetAll();
            bindingSourceNhomGiangVien.DataSource = DataServices.NhomGiangVienTinhDinhMuc.GetAll();
        }
        #endregion

        private void frmCauHinhChiTiet_Load(object sender, EventArgs e)
        {
            #region Init gridview
            AppGridView.InitGridView(gridViewCauHinhChiTiet, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
                , false, false, "Nhấn vào đây để thêm dòng mới");
            //AppGridView.ShowEditor(gridViewCauHinhChiTiet, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewCauHinhChiTiet, new string[] { "MaGiamTruDinhMuc", "MaNhomGiangVien", "DinhMucGiangDay", "DinhMucNckh", "DinhMucHoatDongKhac" },
                                    new string[] { "Nội dung giảm trừ", "Nhóm giảng viên", "Định mức giảng dạy", "Định mức NCKH", "Định mức hoạt động khác" },
                                    new int[] { 300, 250, 60, 60, 60 });
            AppGridView.AlignHeader(gridViewCauHinhChiTiet, new string[] { "MaGiamTruDinhMuc", "MaNhomGiangVien", "DinhMucGiangDay", "DinhMucNckh", "DinhMucHoatDongKhac" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewCauHinhChiTiet, "MaGiamTruDinhMuc", repositoryItemGridLookUpEditGiamTru);
            AppGridView.RegisterControlField(gridViewCauHinhChiTiet, "MaNhomGiangVien", repositoryItemGridLookUpEditNhomGiangVien);
            AppGridView.ReadOnlyColumn(gridViewCauHinhChiTiet, new string[] { "MaGiamTruDinhMuc" });
            PMS.Common.Globals.WordWrapHeader(gridViewCauHinhChiTiet, 50);
            #endregion

            #region Loại giảm trừ
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiamTru
                , new string[] { "NoiDungGiamTru", "MucGiam", "DonVi" }, new string[] { "Nội dung", "Mức giảm", "Đơn vị" }
                , new int[] { 200, 60, 70 }, "MaQuanLy", "NoiDungGiamTru", 350, 400);
            #endregion

            #region Nhóm giảng viên
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNhomGiangVien
                , new string[] { "TenNhomGiangVien" }, new string[] { "Tên nhóm" }
                , new int[] { 250 }, "MaNhomGiangVien", "TenNhomGiangVien", 270, 200);
            #endregion

            InitData();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewCauHinhChiTiet.FocusedRowHandle = -1;
            TList<ChiTietGiamTruDinhMuc> list = bindingSourceCauHinh.DataSource as TList<ChiTietGiamTruDinhMuc>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (list.IsValid)
                    {
                        try
                        {
                            bindingSourceCauHinh.EndEdit();
                            DataServices.ChiTietGiamTruDinhMuc.Save(list);
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            Cursor.Current = Cursors.WaitCursor;
        }
    }
}
