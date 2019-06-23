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
using DevExpress.XtraGrid.Columns;
using System.Data;
using System.Collections.Generic;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucLopHocPhanTinhSiSoRieng : XtraUserControl
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
        TList<CauHinhChung> _cauhinhchung = DataServices.CauHinhChung.GetAll();
        TList<LopHocPhanTinhSiSoRieng> LstLHP;
        VList<ViewLopHocPhan> ViewLHP;
        TList<LopHocPhanTinhSiSoRieng> Lstindex = new TList<LopHocPhanTinhSiSoRieng>();
        LopHocPhanTinhSiSoRieng iindexXoa ;
        string[] lstColumn = new string[] { "MaLopHocPhan", "TenMonHoc", "TenLop", "TenLoaiHocPhan", "TenKhoa", "SiSo", "GhiChu" };

        public ucLopHocPhanTinhSiSoRieng()
        {
            InitializeComponent();
        }

        private void ShowInitLopHocPhan(string strNamHoc, string strHocKy)
        {
            LstLHP = DataServices.LopHocPhanTinhSiSoRieng.GetAll();
            ViewLHP = DataServices.ViewLopHocPhan.GetByNamHocHocKy(strNamHoc, strHocKy);
            bindingSourceLopHocPhan.DataSource = ViewLHP;
            repositoryItemGridLookUpEditMaLHP.DataSource = bindingSourceLopHocPhan;
        }
        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewLopHocPhan obj = bindingSourceChucDanh.Current as ViewLopHocPhan;
            if (obj != null)
            {
                if (obj.IsNew)
                    bindingSourceChucDanh.Remove(obj);
                else
                    obj.CancelChanges();
                gridViewChucDanh.RefreshData();
            }
        }


        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewChucDanh.FocusedRowHandle = -1;
            DataTable list = bindingSourceChucDanh.DataSource as DataTable;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.Rows.Count > 0)
                        {
                            bindingSourceChucDanh.EndEdit();
                            Luu(LstLHP,Lstindex);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewChucDanh, Mng_Chucdanh, layoutControl1 });
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", list.Rows.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch(Exception ex)
                    {
                        PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
                        //XtraMessageBox.Show("Dòng dữ liệu này đang được sử dụng, không được phép xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            Initdata();
            Lstindex.Clear();
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Initdata();
            Cursor.Current = Cursors.Default;
        }

        private int checkMaLopHocPhan(string strMaLopHocPhan)
        {
            int i = 0;
            DataTable tbl = bindingSourceChucDanh.DataSource as DataTable;
            foreach (DataRow item in tbl.Rows)
            {
                if (item["MaLopHocPhan"].ToString() == strMaLopHocPhan)
                {
                    i = 1;
                    break;
                }
            }
            return i;
        }


        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewChucDanh);
            Lstindex.Add(iindexXoa);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlChucDanh.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        private void gridViewChucDanh_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewChucDanh, e);
        }

        private void gridViewChucDanh_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewChucDanh, e);
        }

        private void gridViewChucDanh_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void LoadNamHocHocKyKhoa()
        {
            #region Nam hoc

            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = PMS.Common.Globals.GetMaTruong(_cauhinhchung, "Năm học hiện tại");
            #endregion

            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            #endregion

            #region KhoaBoMon
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditMaLHP, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditMaLHP, new string[] { "MaLopHocPhan", "TenMonHoc", "TenLop", "TenLoaiHocPhan", "TenKhoa" }, new string[] { "Mã lớp học phần", "Tên môn", "Tên lớp", "Tên loại HP", "Tên khoa" });
            repositoryItemGridLookUpEditMaLHP.DisplayMember = "MaLopHocPhan";
            repositoryItemGridLookUpEditMaLHP.ValueMember = "MaLopHocPhan";
            repositoryItemGridLookUpEditMaLHP.NullText = string.Empty;
            #endregion


        }

        private void ShowInidtDataNamHocHocKyKhoa()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                cboHocKy.EditValue = PMS.Common.Globals.GetMaTruong(_cauhinhchung, "Học kỳ hiện tại");
            }


        }

        private void ucChucDanh_Load(object sender, EventArgs e)
        {
            #region Init GridView HocHam
            AppGridView.InitGridView(gridViewChucDanh, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewChucDanh, lstColumn,
                new string[] { "Mã Lớp HP", "Tên Môn Học", "Tên Lớp", "Tên Loại HP", "Tên Khoa", "Sĩ số", "Ghi chú" },
                new int[] { 150, 150, 150, 100, 150, 100, 150 });
            AppGridView.ShowEditor(gridViewChucDanh, NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewChucDanh, new string[] { "MaLopHocPhan", "TenMonHoc", "TenLop", "TenLoaiHocPhan", "TenKhoa", "SiSo", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewChucDanh, new string[] { "TenMonHoc", "TenLop", "TenLoaiHocPhan", "TenKhoa" });
            AppGridView.RegisterControlField(gridViewChucDanh, "MaLopHocPhan", repositoryItemGridLookUpEditMaLHP);
            #endregion

            #region Init Datasource
            LoadNamHocHocKyKhoa();
            ShowInidtDataNamHocHocKyKhoa();
            Initdata();
            #endregion
        }

        private void gridViewChucDanh_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.Name == "colMaLopHocPhan")
            {
                string strMaLopHP = gridViewChucDanh.GetRowCellDisplayText(e.RowHandle, "MaLopHocPhan");

                VList<ViewLopHocPhan> LstLopHP = GetViewLst(ViewLHP, strMaLopHP);
                foreach (ViewLopHocPhan item in LstLopHP)
                {
                    gridViewChucDanh.SetRowCellValue(e.RowHandle, "TenMonHoc", item.TenMonHoc);
                    gridViewChucDanh.SetRowCellValue(e.RowHandle, "TenLop", item.TenLop);
                    gridViewChucDanh.SetRowCellValue(e.RowHandle, "TenLoaiHocPhan", item.TenLoaiHocPhan);
                    gridViewChucDanh.SetRowCellValue(e.RowHandle, "TenKhoa", item.TenKhoa);
                }

            }            
        }

        private VList<ViewLopHocPhan> GetViewLst(VList<ViewLopHocPhan> GetTems, string strMaLopHocPhan)
        {
            VList<ViewLopHocPhan> Lst = new VList<ViewLopHocPhan>();
            foreach (ViewLopHocPhan item in GetTems)
            {
                if (item.MaLopHocPhan == strMaLopHocPhan)
                {
                    ViewLopHocPhan v = new ViewLopHocPhan();
                    v.MaLopHocPhan = item.MaLopHocPhan;
                    v.TenMonHoc = item.TenMonHoc;
                    v.TenLop = item.TenLop;
                    v.TenLoaiHocPhan = item.TenLoaiHocPhan;
                    v.TenKhoa = item.TenKhoa;
                    Lst.Add(v);
                    break;
                }
            }
            return Lst;
        }


        private void Initdata()
        {
            ShowInitLopHocPhan(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            bindingSourceChucDanh.DataSource = CreateTable(LstLHP, ViewLHP);
        }

        
        private DataTable CreateTable(TList<LopHocPhanTinhSiSoRieng> LstLHP, VList<ViewLopHocPhan> ViewLHP)
        {
            DataTable tbl = PMS.Common.XuLyGiaoDien.CreateTable(lstColumn);
            foreach (LopHocPhanTinhSiSoRieng item in LstLHP)
            {
                foreach (ViewLopHocPhan viewItems in ViewLHP)
                {
                    if (item.MaLopHocPhan == viewItems.MaLopHocPhan)
                    {
                        DataRow dr = tbl.NewRow();
                        dr["MaLopHocPhan"] = viewItems.MaLopHocPhan;
                        dr["TenMonHoc"] = viewItems.TenMonHoc;
                        dr["TenLop"] = viewItems.TenLop;
                        dr["TenLoaiHocPhan"] = viewItems.TenLoaiHocPhan;
                        dr["TenKhoa"] = viewItems.TenKhoa;
                        dr["SiSo"] = item.SiSo;
                        dr["GhiChu"] = item.GhiChu;
                        tbl.Rows.Add(dr);
                        break;
                    }
                }
            }
            return tbl;
        }




        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboHocKy.EditValue != null)
                Initdata();
        }

        private void gridViewChucDanh_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            if (gridViewChucDanh.FocusedColumn.FieldName == "MaLopHocPhan")
            {
                string strMaLopHocPhan = e.Value.ToString();
                if (checkMaLopHocPhan(strMaLopHocPhan) != 0)
                {
                    e.Valid = false;
                    e.ErrorText = "Mã lớp học phần đã tồn tại.";
                }
            }

            if (gridViewChucDanh.FocusedColumn.FieldName == "SiSo")
            {
                string strSiSo = e.Value.ToString();
                if (!PMS.Common.XuLySo.KiemTraChuoiToanSo(strSiSo))
                {
                    e.Valid = false;
                    e.ErrorText = "Xin vui lòng chỉ nhập số";
                }
                
            }
        }

        private void Luu(TList<LopHocPhanTinhSiSoRieng> LstLopHP, TList<LopHocPhanTinhSiSoRieng> LstTemps)
        {
            int ichek = 0;
            TList<LopHocPhanTinhSiSoRieng> LstLopHPLuu = new TList<LopHocPhanTinhSiSoRieng>();
            DataTable tbl = bindingSourceChucDanh.DataSource as DataTable;
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                LopHocPhanTinhSiSoRieng ItemsValues = new LopHocPhanTinhSiSoRieng();                
                ItemsValues.MaLopHocPhan = tbl.Rows[i]["MaLopHocPhan"].ToString();
                ItemsValues.SiSo = int.Parse(tbl.Rows[i]["SiSo"].ToString());
                ItemsValues.GhiChu = tbl.Rows[i]["GhiChu"].ToString();
                ichek = CheckLopHPTinhSSRieng(LstLopHP, tbl.Rows[i]["MaLopHocPhan"].ToString());
                if (ichek ==0)
                    LstLopHPLuu.Add(ItemsValues);
                else if(ichek == tbl.Rows.Count)
                    LstLopHPLuu.Add(ItemsValues);

            }
            if (LstTemps.Count == 0 && ichek == 0)
                DataServices.LopHocPhanTinhSiSoRieng.Save(LstLopHPLuu);
            else if (LstTemps.Count == 0 && ichek == tbl.Rows.Count)
            {
                DataServices.LopHocPhanTinhSiSoRieng.Delete(LstLopHPLuu);
                DataServices.LopHocPhanTinhSiSoRieng.Save(LstLopHPLuu);
            }
            else
                DataServices.LopHocPhanTinhSiSoRieng.Delete(LstTemps);
        }
        
        private int CheckLopHPTinhSSRieng(TList<LopHocPhanTinhSiSoRieng> LstLopHP,string strMaLopHocPhan)
        {
            int i = 0;
            foreach (LopHocPhanTinhSiSoRieng item in LstLopHP)
            {
                if(item.MaLopHocPhan==strMaLopHocPhan)
                {
                    i = i + 1;                    
                }
            }
            return i;
        }    

        private void gridViewChucDanh_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            iindexXoa = new LopHocPhanTinhSiSoRieng();
            iindexXoa.MaLopHocPhan = gridViewChucDanh.GetRowCellValue(e.RowHandle, "MaLopHocPhan").ToString();
            iindexXoa.SiSo = int.Parse(gridViewChucDanh.GetRowCellValue(e.RowHandle, "SiSo").ToString());
            iindexXoa.GhiChu = gridViewChucDanh.GetRowCellValue(e.RowHandle, "GhiChu").ToString();
        }
    }
}