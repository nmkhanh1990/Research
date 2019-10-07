using System;
using PMS.Entities;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using PMS.Entities.Validation;
using PMS.Core;
using System.Data;
using DevExpress.XtraGrid.Columns;
using System.Drawing;
namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucKhoabomon : XtraUserControl
    {

        TList<KhoaBoMon> LstKhoabomon;
        VList<ViewKhoaBoMon> VlstkhoaTemp;

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

        public ucKhoabomon()
        {
            InitializeComponent();
        }

        

        private void InitData()
        {
            LstKhoabomon = DataServices.KhoaBoMon.GetAll();
            VlstkhoaTemp = DataServices.ViewKhoaBoMon.GetAll();
            bindingSourceKhoa.DataSource = VlstkhoaTemp;

            DataTable tblKhoabomon = CreateTable();
            for (int i = 0; i < LstKhoabomon.Count; i++)
            {
                for (int j = 0; j < VlstkhoaTemp.Count; j++)
                {
                    string strMabomon = LstKhoabomon[i].MaBoMon.ToString();
                    if (LstKhoabomon[i].MaBoMon == int.Parse(VlstkhoaTemp[j].MaBoMon))
                    {
                        tblKhoabomon.Rows.Add(i + 1, strMabomon.Length > 1 ? strMabomon : "0" + strMabomon, VlstkhoaTemp[j].TenBoMon, LstKhoabomon[i].GhiChu);
                        break;
                    }
                }
            }
            bindingSourceKhoabomon.DataSource = tblKhoabomon;
        }

        private DataTable CreateTable()
        {
            DataTable tblTemp = new DataTable();
            tblTemp.Columns.Add("ThuTu", typeof(int));
            tblTemp.Columns.Add("MaKhoa", typeof(string));
            tblTemp.Columns.Add("TenKhoa", typeof(string));
            tblTemp.Columns.Add("GhiChu", typeof(string));
            return tblTemp;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KhoaBoMon obj = bindingSourceKhoabomon.Current as KhoaBoMon;
            if (obj != null)
            {
                if (obj.IsNew)
                    bindingSourceKhoabomon.Remove(obj);
                else
                    obj.CancelChanges();
                gridViewKhoabomon.RefreshData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewKhoabomon.FocusedRowHandle = -1;
            bindingSourceKhoabomon.DataSource = GetLstKhoabomon();
            TList<KhoaBoMon> LstKhoaBMTemp = LstKhoabomon;
            DataServices.KhoaBoMon.Delete(LstKhoaBMTemp);
           
            TList<KhoaBoMon> list = bindingSourceKhoabomon.DataSource as TList<KhoaBoMon>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceKhoabomon.EndEdit();
                            DataServices.KhoaBoMon.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewKhoabomon, barManagerKhoabomon, layoutControl1 });
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", list.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Dòng dữ liệu này đang được sử dụng, không được phép xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            InitData();
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            KhoaBoMon obj = target as KhoaBoMon;
            if (obj != null)
            {
                if (((TList<KhoaBoMon>)bindingSourceKhoabomon.DataSource).FindAll(p => p.MaBoMon == obj.MaBoMon).Count > 1)
                {
                    e.Description = string.Format("Mã loại lớp {0} hiện tại đã có.", obj.MaBoMon);
                    return false;
                }
            }
            return true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewKhoabomon);
        }

        private void barbtnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlKhoabomon.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        private void gridViewKhoabomon_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewKhoabomon, e);
        }

        private void gridViewKhoabomon_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewKhoabomon, e);
        }

        private void gridViewKhoabomon_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gridViewKhoabomon_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            KhoaBoMon obj = e.Row as KhoaBoMon;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckDuplicate, "MaBoMon");
                if (obj.IsValid)
                    e.Valid = true;
                else
                {
                    XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                }
            }
        }

        private void ucKhoabomon_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewKhoabomon, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewKhoabomon, new string[] { "ThuTu", "MaKhoa", "TenKhoa", "GhiChu" },
                new string[] { "STT", "Mã bộ môn", "Tên bộ môn", "Ghi chú" },
                new int[] { 70, 200, 250, 300 });
            AppGridView.ShowEditor(gridViewKhoabomon, NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewKhoabomon, new string[] { "ThuTu", "MaKhoa", "TenKhoa", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewKhoabomon, "MaKhoa", repositoryItemGridLookUpEditKhoabomon);
            #endregion


            #region Khoa
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditKhoabomon, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditKhoabomon, new string[] { "MaBoMon", "TenBoMon" }, new string[] { "Mã bộ môn", "Tên bộ môn" }, new int[] { 200, 250 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditKhoabomon, 500, 650);
            repositoryItemGridLookUpEditKhoabomon.DisplayMember = "MaBoMon";
            repositoryItemGridLookUpEditKhoabomon.ValueMember = "MaBoMon";
            repositoryItemGridLookUpEditKhoabomon.NullText = string.Empty;
            #endregion

            #region Init Datasource
            InitData();
            //bindingSourceKhoabomon.DataSource = DataServices.LoaiLop.GetAll();
            #endregion
        }

        private void gridViewKhoabomon_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaKhoa")
            {
                DataRowView v = gridViewKhoabomon.GetRow(e.RowHandle) as DataRowView;
                ViewKhoaBoMon gv = VlstkhoaTemp.Find(p => p.MaBoMon ==v["MaKhoa"].ToString());
                gridViewKhoabomon.SetRowCellValue(e.RowHandle, "ThuTu", gridViewKhoabomon.RowCount+1);
                gridViewKhoabomon.SetRowCellValue(e.RowHandle, "TenKhoa", gv.TenBoMon);              
            }
        }

        private TList<KhoaBoMon>GetLstKhoabomon()
        {
            TList<KhoaBoMon> ResultLst = new TList<KhoaBoMon>();
            for (int i = 0; i < gridViewKhoabomon.RowCount; i++)
            {
                KhoaBoMon KhoaBM = new KhoaBoMon();
                KhoaBM.MaBoMon = int.Parse(gridViewKhoabomon.GetRowCellValue(i, "MaKhoa").ToString());
                KhoaBM.GhiChu = gridViewKhoabomon.GetRowCellValue(i, "GhiChu").ToString();
                ResultLst.Add(KhoaBM);
            }
            return ResultLst;
        }
    }
}