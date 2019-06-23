using DevExpress.Common.Grid;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using PMS.Core;
using PMS.Entities;
using PMS.Entities.Validation;
using PMS.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucNhomMonHocTinhDinhMuc : UserControl
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
        string _maTruong;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        #endregion

        public ucNhomMonHocTinhDinhMuc()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucNhomMonHocTinhDinhMuc_Load(object sender, EventArgs e)
        {
            #region InitGridView
            switch (_maTruong)
            {
                default:
                    InitRemaining();
                    break;
            }
            #endregion

            InitData();
        }

        #region InitGrid
        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewNhomMonHocTinhDinhMuc, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewNhomMonHocTinhDinhMuc, new string[] { "MaNhomMon", "TenNhomMon" },
                        new string[] { "Mã nhóm môn", "Tên nhóm môn" }, new int[] { 100, 500 });
            AppGridView.ShowEditor(gridViewNhomMonHocTinhDinhMuc, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewNhomMonHocTinhDinhMuc, new string[] { "MaNhomMon", "TenNhomMon" }, DevExpress.Utils.HorzAlignment.Center);
        }
        #endregion

        #region InitData
        private void InitData()
        {
            InitNhomThucHanh();
            bindingSourceNhomMonHoc.DataSource = DataServices.NhomMonHocTinhDinhMuc.GetAll();
        }

        void InitNhomThucHanh()
        {
            DataTable tb = new DataTable();
            DataColumn col1 = new DataColumn("MaNhomThucHanh", typeof(decimal));
            DataColumn col2 = new DataColumn("TenNhomThucHanh", typeof(string));

            tb.Columns.Add(col1);
            tb.Columns.Add(col2);

            DataRow r1 = tb.NewRow();
            r1["MaNhomThucHanh"] = 1;
            r1["TenNhomThucHanh"] = "Thực hành đại cương";
            DataRow r2 = tb.NewRow();
            r2["MaNhomThucHanh"] = 2;
            r2["TenNhomThucHanh"] = "Thực hành chuyên nghiệp";
            tb.Rows.Add(r1);
            tb.Rows.Add(r2);
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
            AppGridView.DeleteSelectedRows(gridViewNhomMonHocTinhDinhMuc);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewNhomMonHocTinhDinhMuc.FocusedRowHandle = -1;
            TList<NhomMonHocTinhDinhMuc> list = bindingSourceNhomMonHoc.DataSource as TList<NhomMonHocTinhDinhMuc>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceNhomMonHoc.EndEdit();
                            DataServices.NhomMonHocTinhDinhMuc.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewNhomMonHocTinhDinhMuc, barManager1, layoutControl1 });
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", list.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void gridViewNhomMonHoc_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewNhomMonHocTinhDinhMuc, e);
        }

        private void gridViewNhomMonHoc_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewNhomMonHocTinhDinhMuc, e);
        }

        private void gridViewNhomMonHoc_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            NhomMonHocTinhDinhMuc obj = e.Row as NhomMonHocTinhDinhMuc;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckDuplicate, "MaNhomMon");
                if (obj.IsValid)
                    e.Valid = true;
                else
                {
                    XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                }
            }
        }
        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            NhomMonHocTinhDinhMuc obj = target as NhomMonHocTinhDinhMuc;
            if (obj != null)
            {
                if (((TList<NhomMonHocTinhDinhMuc>)bindingSourceNhomMonHoc.DataSource).FindAll(p => p.MaNhomMon == obj.MaNhomMon).Count > 1)
                {
                    e.Description = string.Format("Mã quy đổi {0} hiện tại đã có.", obj.MaNhomMon);
                    return false;
                }
            }
            return true;
        }

        private void gridViewNhomMonHoc_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gridViewNhomMonHoc_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {

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
                        gridControlNhomMonHocTinhDinhMuc.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }
    }
}
