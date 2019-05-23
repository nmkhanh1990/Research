using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Entities;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;

namespace PMS.UI.Modules.DanhMuc.HBU
{
    public partial class ucThoiGianNghiTamThoi_HBU : DevExpress.XtraEditors.XtraUserControl
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
        VList<ViewGiangVien> _listGiangVien;
        string _maTruong;

        DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit RepositoryItemGridLookUpEditLoaiNhap;
        #endregion

        #region Event Form
        public ucThoiGianNghiTamThoi_HBU()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucThoiGianNghiTamThoi_Load(object sender, EventArgs e)
        {
            #region InitGridView
            CreatRepository();
            InitRemaining();

            #endregion

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenDonVi" }, new string[] { "Mã giảng viên", "Họ tên", "Khoa - Bộ môn" }, new int[] { 90, 170, 240 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 500, 650);
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            #region LyDoNghi
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLyDo, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLyDo, new string[] { "MaQuanLy", "TenLyDoTamNghi" }, new string[] { "Mã quản lý", "Tên lý do tạm nghỉ" }, new int[] { 90, 210 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditLyDo, 300, 650);
            repositoryItemGridLookUpEditLyDo.DisplayMember = "TenLyDoTamNghi";
            repositoryItemGridLookUpEditLyDo.ValueMember = "Id";
            repositoryItemGridLookUpEditLyDo.NullText = string.Empty;
            #endregion

            #region NoiDungGiamTru
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNoiDungGiamTru, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNoiDungGiamTru, new string[] { "NoiDungGiamTru" }, new string[] { "Lý do" }, new int[] { 300 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditNoiDungGiamTru, 300, 650);
            repositoryItemGridLookUpEditNoiDungGiamTru.DisplayMember = "NoiDungGiamTru";
            repositoryItemGridLookUpEditNoiDungGiamTru.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEditNoiDungGiamTru.NullText = string.Empty;
            #endregion

            #region LoaiNhap
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(RepositoryItemGridLookUpEditLoaiNhap, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(RepositoryItemGridLookUpEditLoaiNhap, new string[] { "NameLoaiNhap" }, new string[] { "Chọn" }, new int[] { 200 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(RepositoryItemGridLookUpEditLoaiNhap, 200, 100);
            RepositoryItemGridLookUpEditLoaiNhap.DisplayMember = "NameLoaiNhap";
            RepositoryItemGridLookUpEditLoaiNhap.ValueMember = "IDLoaiNhap";
            RepositoryItemGridLookUpEditLoaiNhap.NullText = string.Empty;
            #endregion

            InitData();
        }
        #endregion

        #region InitGrid
        void InitGridDLU()
        {
            AppGridView.InitGridView(gridViewThoiGian, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewThoiGian, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewThoiGian, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "MaTamNghi", "TuNgay", "DenNgay", "GhiChu" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Đơn vị", "Lý do", "Từ ngày", "Đến ngày", "Ghi chú" }
                    , new int[] { 90, 150, 160, 200, 90, 90, 200 });
            AppGridView.AlignHeader(gridViewThoiGian, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "MaTamNghi", "TuNgay", "DenNgay", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewThoiGian, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewThoiGian, "MaTamNghi", repositoryItemGridLookUpEditNoiDungGiamTru);
            AppGridView.SummaryField(gridViewThoiGian, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewThoiGian, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewThoiGian, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewThoiGian, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "MaTamNghi", "LoaiNhap", "MucGiam", "DonVi", "TuNgay", "DenNgay", "GhiChu" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Đơn vị", "Lý do", "Loại nhập", "Mức giảm", "Đơn vị", "Từ ngày", "Đến ngày", "Ghi chú" }
                    , new int[] { 90, 150, 160, 200, 150, 110, 100, 90, 90, 200 });
            AppGridView.AlignHeader(gridViewThoiGian, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "MaTamNghi", "LoaiNhap", "MucGiam", "DonVi", "TuNgay", "DenNgay", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.FixedField(gridViewThoiGian, new string[] { "MaGiangVien", "HoTen" }, FixedStyle.Left);
            AppGridView.RegisterControlField(gridViewThoiGian, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewThoiGian, "MaTamNghi", repositoryItemGridLookUpEditLyDo);
            AppGridView.RegisterControlField(gridViewThoiGian, "MaTamNghi", repositoryItemGridLookUpEditNoiDungGiamTru);
            AppGridView.RegisterControlField(gridViewThoiGian, "LoaiNhap", RepositoryItemGridLookUpEditLoaiNhap);
            AppGridView.SummaryField(gridViewThoiGian, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.HideField(gridViewThoiGian, new string[] { "DonVi" });
        }
        #endregion

        #region InitData
        void InitData()
        {
            _listGiangVien = DataServices.ViewGiangVien.GetAll();
            bindingSourceGiangVien.DataSource = _listGiangVien;

            bindingSourceLyDo.DataSource = DataServices.LyDoTamNghi.GetAll();

            bindingSourceNoiDungGiamTru.DataSource = DataServices.GiamTruDinhMuc.GetAll();

            // bindingSourceLoaiNhap.DataSource = GetData(); 

            DataTable tb = new DataTable();
            IDataReader reader = DataServices.ThoiGianNghiTamThoiCuaGiangVien.GetAllGiangVienTamNghi();
            tb.Load(reader);
            foreach (DataColumn col in tb.Columns)
            {
                col.ReadOnly = false;
            }
            bindingSourceThoiGian.DataSource = tb;

        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewThoiGian);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewThoiGian.FocusedRowHandle = -1;
            DataTable list = bindingSourceThoiGian.DataSource as DataTable;
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string xmlData = "";
                    foreach (DataRow v in list.Rows)
                    {
                        if (v.RowState != DataRowState.Deleted)
                        {
                            if ((v["TuNgay"].ToString() != "" && v["DenNgay"].ToString() != "") || (v["MucGiam"].ToString() != "" && v["TenDonVi"].ToString() != ""))
                            {
                                xmlData += "<Input Id=\"" + v["Id"]
                                        + "\" M=\"" + v["MaGiangVien"]
                                        + "\" G=\"" + v["MaTamNghi"]
                                        + "\" LN=\"" + v["LoaiNhap"]
                                        + "\" MG=\"" + v["MucGiam"]
                                        + "\" DV=\"" + v["DonVi"]
                                        + "\" Tu=\"" + v["TuNgay"]
                                        + "\" Den=\"" + v["DenNgay"]
                                        + "\" GC=\"" + v["GhiChu"]
                                        + "\" />";
                            }
                            else
                            {
                                if (int.Parse(v["LoaiNhap"].ToString()) == 0)
                                {
                                    XtraMessageBox.Show("Thời gian từ ngày, đến ngày không được phép bỏ trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                else if (int.Parse(v["LoaiNhap"].ToString()) == 1)
                                {
                                    XtraMessageBox.Show("Mức giảm đơn vị không được phép bỏ trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                        }
                    }
                    xmlData = "<Root>" + xmlData + "</Root>";
                    bindingSourceThoiGian.EndEdit();
                    int kq = 0;
                    DataServices.ThoiGianNghiTamThoiCuaGiangVien.Luu(xmlData, ref kq);
                    if (kq == 0)
                        XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi."+ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                InitData();
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    sf.ShowDialog();
                    if (sf.FileName != "")
                    {
                        gridControlThoiGian.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void gridViewThoiGian_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaGiangVien")
            {
                DataRowView v = gridViewThoiGian.GetRow(e.RowHandle) as DataRowView;
                ViewGiangVien gv = _listGiangVien.Find(p => p.MaGiangVien == int.Parse(v["MaGiangVien"].ToString()));
                gridViewThoiGian.SetRowCellValue(e.RowHandle, "HoTen", gv.HoTen);
                gridViewThoiGian.SetRowCellValue(e.RowHandle, "TenDonVi", gv.TenDonVi);
            }
            if (col.FieldName == "LoaiNhap")
            {
                DataRowView v = gridViewThoiGian.GetRow(e.RowHandle) as DataRowView;
                int iDloaiNhap = int.Parse(v["LoaiNhap"].ToString());
                string schuoiNgay = "TuNgay" + "," + "DenNgay";
                string schuoiPhanTram = "MucGiam" + "," + "DonVi";
                ReadOnlyColumns(iDloaiNhap, schuoiNgay, schuoiPhanTram);
            }
        }

        private string getName(int id)
        {
            DataTable tbl = GetData();
            string strResult = string.Empty;
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                if (tbl.Rows[i]["IDLoaiNhap"].ToString() == id.ToString())
                {
                    strResult = tbl.Rows[i]["NameLoaiNhap"].ToString();
                }
            }
            return strResult;
        }

        private void ReadOnlyColumns(int iIDLoaiNhap, string strChuoi, string strChuoiPhanTram)
        {
            string[] Columns = strChuoi.Split(',');
            string[] ColumnsPhantram = strChuoiPhanTram.Split(',');
            for (int i = 0; i < Columns.Length; i++)
            {
                for (int j = 0; j < gridViewThoiGian.Columns.Count; j++)
                {
                    if (gridViewThoiGian.Columns[j].FieldName == Columns[i].ToString())
                    {
                        gridViewThoiGian.Columns[Columns[i].ToString()].OptionsColumn.AllowEdit = iIDLoaiNhap == 0 ? true : false;
                        gridViewThoiGian.Columns[ColumnsPhantram[i].ToString()].OptionsColumn.AllowEdit = iIDLoaiNhap == 1 ? true : false;
                    }
                }
            }
        }

        private void gridViewThoiGian_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewThoiGian, e);
        }

        private void CreatRepository()
        {
            RepositoryItemGridLookUpEditLoaiNhap = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            gridControlThoiGian.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            RepositoryItemGridLookUpEditLoaiNhap});
            RepositoryItemGridLookUpEditLoaiNhap.AutoHeight = false;
            RepositoryItemGridLookUpEditLoaiNhap.DataSource = GetData();
            RepositoryItemGridLookUpEditLoaiNhap.Name = "RepositoryItemGridLookUpEditLoaiNhap";
            RepositoryItemGridLookUpEditLoaiNhap.View = new DevExpress.XtraGrid.Views.Grid.GridView();

        }
        private DataTable GetData()
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("IDLoaiNhap", typeof(int)));
            table.Columns.Add(new DataColumn("NameLoaiNhap", typeof(string)));
            table.Rows.Add(new object[] { 0, "Nhập ngày" });
            table.Rows.Add(new object[] { 1, "Nhập phần trăm" });
            return table;
        }
    }
}
