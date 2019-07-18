using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Services;
using PMS.Core;
using PMS.Entities.Validation;
using PMS.BLL;
using DevExpress.XtraGrid.Columns;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucDanhMucLopChatLuongCao : DevExpress.XtraEditors.XtraUserControl
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
        VList<ViewLopChatLuongCao> vListLCC = new VList<ViewLopChatLuongCao>();
        TList<LopChatLuongCao> TListCLC = new TList<LopChatLuongCao>();
        #endregion

        public ucDanhMucLopChatLuongCao()
        {
            InitializeComponent();
        }

        private void ucDanhMucLopChatLuongCao_Load(object sender, EventArgs e)
        {
            #region Init gridview
            AppGridView.InitGridView(gridViewDMChatLuongCao, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewDMChatLuongCao, NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewDMChatLuongCao, new string[] { "MaLop", "TenLop", "TenKhoaHoc", "TenKhoa", "NamHoc" },
                        new string[] { "Mã lớp", "Tên lớp", "Tên khóa học", "Tên khoa", "Năm học" },
                        new int[] { 100, 140, 120, 250, 100 });
            AppGridView.AlignHeader(gridViewDMChatLuongCao, new string[] { "MaLop", "TenLop", "TenKhoaHoc", "TenKhoa", "NamHoc" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewDMChatLuongCao, new string[] {  "TenLop", "TenKhoaHoc", "TenKhoa", "NamHoc" });
            AppGridView.SummaryField(gridViewDMChatLuongCao, "MaLop", "Tổng: {0} Lớp", DevExpress.Data.SummaryItemType.Count);
            AppGridView.RegisterControlField(gridViewDMChatLuongCao, "MaLop", repositoryItemGridLookUpEditLopChatLuongCao);
            //gridViewDMChatLuongCao.Columns["TenKhoa"].GroupIndex = 0;
            #endregion

            #region AppGridLookupEdit _namHoc
            AppGridLookupEdit.InitGridLookUp(gridLookUpEditNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(gridLookUpEditNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            gridLookUpEditNamHoc.Properties.ValueMember = "NamHoc";
            gridLookUpEditNamHoc.Properties.DisplayMember = "NamHoc";
            gridLookUpEditNamHoc.Properties.NullText = "[Chọn năm học]";
            #endregion
            gridLookUpEditNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;

            SetNamHoc();
            GetLopChatLuongCao();
            ShowDataIndata();
            gridViewDMChatLuongCao.ExpandAllGroups();
        }

        private void ShowDataIndata()
        {
            TListCLC = DataServices.LopChatLuongCao.GetAll();
            DataTable Tbl = CreatTable(TListCLC, vListLCC);
            bindingSourceDMLopChatLuongCao.DataSource = Tbl;//
        }

        #region Lớp chất lượng cao
        private void GetLopChatLuongCao()
        {
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLopChatLuongCao, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLopChatLuongCao, new string[] { "MaLop", "TenLop", "TenKhoaHoc", "TenKhoa", "NamHoc" }, new string[] { "Mã lớp", "Tên lớp", "Tên khóa học", "Tên khoa", "Năm học" }
                       , new int[] { 130, 160, 140, 250, 120 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditLopChatLuongCao, 600, 500);
            repositoryItemGridLookUpEditLopChatLuongCao.DisplayMember = "MaLop";
            repositoryItemGridLookUpEditLopChatLuongCao.ValueMember = "MaLop";
            repositoryItemGridLookUpEditLopChatLuongCao.NullText = string.Empty;
            vListLCC = DataServices.ViewLopChatLuongCao.GetByNamHoc(gridLookUpEditNamHoc.EditValue.ToString());
            repositoryItemGridLookUpEditLopChatLuongCao.DataSource = vListLCC;
        }

        #endregion

        #region SetNamHoc, SetHocKy
        private void SetNamHoc()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
        }
        #endregion

        private void bntLocDuLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            vListLCC = DataServices.ViewLopChatLuongCao.GetByNamHoc(gridLookUpEditNamHoc.EditValue.ToString());
            ShowDataIndata();
            gridViewDMChatLuongCao.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewDMChatLuongCao.RowCount > 0)
                if (gridViewDMChatLuongCao.GetSelectedRows().Length > 0)
                    if (XtraMessageBox.Show(String.Format("Bạn có muốn xóa {0} dòng đã chọn không ?", gridViewDMChatLuongCao.GetSelectedRows().Length), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        AppGridView.DeleteSelectedRows(gridViewDMChatLuongCao);
                    }
        }

        private void gridLookUpEditNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceDMLopChatLuongCao.DataSource = DataServices.ViewLopChatLuongCao.GetByNamHoc(gridLookUpEditNamHoc.EditValue.ToString());
            gridViewDMChatLuongCao.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }

        private void gridControlDMChatLuongCao_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void gridViewDMChatLuongCao_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                if (gridViewDMChatLuongCao.RowCount > 0)
                    if (gridViewDMChatLuongCao.GetSelectedRows().Length > 0)
                        if (XtraMessageBox.Show(String.Format("Bạn có muốn xóa {0} dòng đã chọn không ?", gridViewDMChatLuongCao.GetSelectedRows().Length), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            AppGridView.DeleteSelectedRows(gridViewDMChatLuongCao);
        }

        private void gridViewDMChatLuongCao_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewDMChatLuongCao.FocusedRowHandle = -1;
            string xmlData = "<Root>";
            int kq = 0;
            DataTable list = bindingSourceDMLopChatLuongCao.DataSource as DataTable;
            foreach (DataRow v in list.Rows)
            {
                if (v.RowState!=DataRowState.Modified)
                {
                    xmlData += "<Input L = \"" + v["MaLop"].ToString()
                                + "\" D = \"" + DateTime.Now.ToString()
                                + "\" U = \"" + UserInfo.UserName
                                + "\" />";
                }
            }
            xmlData += "</Root>";

            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    DataServices.LopChatLuongCao.Luu(xmlData, gridLookUpEditNamHoc.EditValue.ToString(), ref kq);
                    if (kq == 0)
                        XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Thao tác thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void gridViewDMChatLuongCao_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaLop")
            {
                string strMaLop = gridViewDMChatLuongCao.GetRowCellValue(e.RowHandle, "MaLop").ToString();
                for (int i = 0; i < vListLCC.Count; i++)
                {
                    if (vListLCC[i].MaLop == strMaLop)
                    {
                        gridViewDMChatLuongCao.SetRowCellValue(e.RowHandle, "TenLop", vListLCC[i].TenLop);
                        gridViewDMChatLuongCao.SetRowCellValue(e.RowHandle, "TenKhoaHoc", vListLCC[i].TenKhoaHoc);
                        gridViewDMChatLuongCao.SetRowCellValue(e.RowHandle, "TenKhoa", vListLCC[i].TenKhoa);
                        gridViewDMChatLuongCao.SetRowCellValue(e.RowHandle, "NamHoc", vListLCC[i].NamHoc);
                        break;
                    }
                }

            }
        }

        private DataTable CreatTable(TList<LopChatLuongCao> lstLCL, VList<ViewLopChatLuongCao> vLCL)
        {
            DataTable Tbl = new DataTable();            
            Tbl.Columns.Add("MaLop", typeof(string));
            Tbl.Columns.Add("TenLop", typeof(string));
            Tbl.Columns.Add("TenKhoaHoc", typeof(string));
            Tbl.Columns.Add("TenKhoa", typeof(string));
            Tbl.Columns.Add("NamHoc", typeof(string));            
            for (int i = 0; i < lstLCL.Count; i++)
            {
                for (int j = 0; j < vLCL.Count; j++)
                {
                    if (lstLCL[i].MaLop == vLCL[j].MaLop)
                    {
                        DataRow dr = Tbl.NewRow();
                        dr["MaLop"]=vLCL[j].MaLop.ToString();
                        dr["TenLop"]= vLCL[j].TenLop.ToString();
                        dr["TenKhoaHoc"]=vLCL[j].TenKhoaHoc.ToString();
                        dr["TenKhoa"]=vLCL[j].TenKhoa.ToString();
                        dr["NamHoc"]=vLCL[j].NamHoc.ToString();
                        Tbl.Rows.Add(dr);
                        break;
                    }
                }
            }
            return Tbl;
        }

        private void gridViewDMChatLuongCao_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            if (gridViewDMChatLuongCao.FocusedColumn.FieldName == "MaLop")
            {
                string strMaLop = e.Value.ToString();
                if (strMaLop != string.Empty)
                {
                    if (PMS.Common.XuLyGiaoDien.RuleCheckDuplicate(gridViewDMChatLuongCao, strMaLop))
                    {
                        e.Valid = false;
                        e.ErrorText = "Mã môn học " + strMaLop + " hiện tại đã có.";
                    }
                }
            }
        }
    }
}
