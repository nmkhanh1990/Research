using DevExpress.Common.Grid;
using DevExpress.XtraEditors;
//using PMS.TruyCapDuLieu;
using PMS.BLL;
using PMS.Entities;
using PMS.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucDanhMucDonGiaLopHocPhan : DevExpress.XtraEditors.XtraUserControl
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
        string _maTruong;
        DataTable dtData = new DataTable();
        #endregion

        #region Inits
        public ucDanhMucDonGiaLopHocPhan()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucDanhMucDonGiaLopHocPhan_Load(object sender, EventArgs e)
        {
            InitData();
        }
        #endregion

        #region InitData
        void InitData()
        {
            dtData = PMS_BLL.LayThongTinDanhMucDonGiaTheoLopHocPhan(BLL.UserInfo.UserID.ToString());

            foreach (DataColumn dc in dtData.Columns)
            {
                dc.ReadOnly = false;
            }

            gridControlDanhMucDonGiaLopHocPhan.DataSource = dtData;

            AppGridView.InitGridView(gridViewDanhMucDonGiaLopHocPhan, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewDanhMucDonGiaLopHocPhan, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewDanhMucDonGiaLopHocPhan, new string[] { "Chon", "DonGia", "MacDinh", "GhiChu" }, new string[] { "Xóa", "Đơn giá", "Mặc định", "Ghi chú" }, new int[] { 100, 100, 80, 150 });
            AppGridView.AlignHeader(gridViewDanhMucDonGiaLopHocPhan, new string[] { "Chon", "DonGia", "MacDinh", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewDanhMucDonGiaLopHocPhan, new string[] { "Chon", "DonGia", "MacDinh" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewDanhMucDonGiaLopHocPhan, "DonGia", "{0}", DevExpress.Data.SummaryItemType.Count);
        }
        #endregion

        #region Events
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
                gridViewDanhMucDonGiaLopHocPhan.FocusedRowHandle = -1;
                if (XtraMessageBox.Show("Xóa cấu đơn giá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                string strXml = string.Empty;
                foreach (DataRow dr in dtData.Rows)
                {
                    if (dr["Chon"].ToString().ToLower() == "true")
                        strXml += string.Format("<Pms ID = \"{0}\"/>", dr["ID"]);
                }

                strXml = string.Format("<Root>{0}</Root>", strXml);

                string result = PMS_BLL.CapNhatThongTinDanhMucDonGiaTheoLopHocPhan(strXml, UserInfo.UserName, true);
                if (result == "True")
                {
                    XtraMessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitData();
                }
                else
                {
                    XtraMessageBox.Show("Lỗi: " + result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewDanhMucDonGiaLopHocPhan.FocusedRowHandle = -1;
                if (XtraMessageBox.Show("Lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                DataTable dtTemp = dtData.GetChanges();

                string strXml = string.Empty;

                if (dtTemp != null)
                {
                    foreach (DataRow dr in dtTemp.Rows)
                    {
                        strXml += string.Format("<Pms ID = \"{0}\" DG = \"{1}\" MD = \"{2}\" GC = \"{3}\"/>", dr["ID"], dr["DonGia"], dr["MacDinh"], dr["GhiChu"]);
                    }
                }

                strXml = string.Format("<Root>{0}</Root>", strXml);

                string result = PMS_BLL.CapNhatThongTinDanhMucDonGiaTheoLopHocPhan(strXml, UserInfo.UserName, false);
                if (result == "True")
                {
                    XtraMessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtData.AcceptChanges();
                }
                else
                {
                    XtraMessageBox.Show("Lỗi: " + result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        gridControlDanhMucDonGiaLopHocPhan.ExportToXls(file.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Bạn chưa nhập tên file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void gridViewViPham_KeyUp(object sender, KeyEventArgs e)
        {
        }
        #endregion
    }
}
