using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Services;
using PMS.BLL;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace PMS.UI.Forms.HeThong
{
    public partial class frmPhanQuyenTaiKhoanTheoKhoa : DevExpress.XtraEditors.XtraForm
    {
        int MaTaiKhoan;
        int MaNhomQuyen;
        public frmPhanQuyenTaiKhoanTheoKhoa()
        {
            InitializeComponent();
        }

        public frmPhanQuyenTaiKhoanTheoKhoa(int maTaiKhoan,int maNhomQuyen)
        {
            InitializeComponent();
            MaTaiKhoan = maTaiKhoan;
            MaNhomQuyen = maNhomQuyen;
        }


        void InitData()
        {
            //DataTable tbl = new DataTable();
            //IDataReader reader = DataServices.PhanQuyenTheoKhoa.GetByMaNhomKhoa(MaTaiKhoan);
            //tbl.Load(reader);
            bindingSourcePhanQuyenTheoKhoa.DataSource = DataServices.PhanQuyenTheoKhoa.GetAll();
            gridViewPhanQuyenTaiKhoanTheoKhoa.ActiveFilterString = "[MaTaiKhoan] = " + "'" + MaTaiKhoan + "'";
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewPhanQuyenTaiKhoanTheoKhoa.FocusedRowHandle = -1;           
            TList<PhanQuyenTheoKhoa> list = bindingSourcePhanQuyenTheoKhoa.DataSource as TList<PhanQuyenTheoKhoa>;
        
            if (list != null)
            {
                foreach (PhanQuyenTheoKhoa item in list)
                {        
                    if(item.MaTaiKhoan ==null)            
                    item.MaTaiKhoan = MaTaiKhoan;                    
                }
                if (XtraMessageBox.Show("Bạn muốn lưu các thay đồi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        bindingSourcePhanQuyenTheoKhoa.EndEdit();
                        DataServices.PhanQuyenTheoKhoa.Save(list);
                        XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();                      
                    }
                    catch(Exception ex)
                    { XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi."+ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void frmPhanQuyenTaiKhoanTheoKhoa_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewPhanQuyenTaiKhoanTheoKhoa, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewPhanQuyenTaiKhoanTheoKhoa, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewPhanQuyenTaiKhoanTheoKhoa, new string[] { "MaTaiKhoan","MaKhoa","IdChucNang", "DuocPhepChot" }
                    , new string[] {"Tài khoản", "Tên khoa","Tên chức năng", "Được phép chốt" }, new int[] {60, 250,150, 150 });
            AppGridView.AlignHeader(gridViewPhanQuyenTaiKhoanTheoKhoa, new string[] { "MaTaiKhoan","MaKhoa", "IdChucNang", "DuocPhepChot" }, DevExpress.Utils.HorzAlignment.Center);
            
            AppGridView.RegisterControlField(gridViewPhanQuyenTaiKhoanTheoKhoa, "MaKhoa", repositoryItemcbo_editKhoa);
            AppGridView.RegisterControlField(gridViewPhanQuyenTaiKhoanTheoKhoa, "IdChucNang", repositoryItemchkcbo_ChucNang);
            AppGridView.HideField(gridViewPhanQuyenTaiKhoanTheoKhoa, new string[] { "MaTaiKhoan" });
            CheckListBoxKhoa();
            ListIdChucNangChot();
            InitData();
        }

        private void CheckListBoxKhoa()
        {
            VList<ViewKhoaBoMon> ViewlstKhoa = DataServices.ViewKhoaBoMon.GetAll();
            bindingSourceDanhSachKhoa.DataSource = ViewlstKhoa;
            List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();
            foreach (ViewKhoaBoMon obj in ViewlstKhoa)
            {
                list.Add(new CheckedListBoxItem(obj.MaKhoa,
                                                obj.TenKhoa.ToString(),
                                                CheckState.Unchecked, true));
            }
            repositoryItemcbo_editKhoa.Items.AddRange(list.ToArray());
            repositoryItemcbo_editKhoa.SeparatorChar = ';';
        }

        private void ListIdChucNangChot()
        {
            Dictionary<string,string>  LstrID = new Dictionary<string, string>();
            TList<NhomChucNang> LstNhomChucNang = DataServices.NhomChucNang.GetByMaNhomQuyen(MaNhomQuyen);
            //bindingSourceIdChucNang.DataSource = LstNhomChucNang;
            foreach (NhomChucNang item in LstNhomChucNang)
            {
                ChucNang iTemChucNang = DataServices.ChucNang.GetById(int.Parse(item.MaChucNang.ToString())); 
                if(iTemChucNang!=null)                          
                if (Convert.ToBoolean(PMS.Common.Globals.IsNull(iTemChucNang.TrangThaiChot.ToString().ToLower(), "bool")))
                    LstrID.Add(iTemChucNang.Id.ToString(), iTemChucNang.TenChucNang.ToString());
            }
            List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();           
            foreach (var item in LstrID)
            {
                list.Add(new CheckedListBoxItem(item.Key,
                                              item.Value.ToString(),
                                              CheckState.Unchecked, true));
            }
            repositoryItemchkcbo_ChucNang.Items.AddRange(list.ToArray());
            repositoryItemchkcbo_ChucNang.SeparatorChar = ';';
        }

        private void gridViewPhanQuyenTaiKhoanTheoKhoa_ShowingEditor(object sender, CancelEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                string strValue = string.Empty;
                if (view.FocusedColumn.FieldName == "IdChucNang")
                {
                    strValue = view.GetRowCellValue(view.FocusedRowHandle, "IdChucNang").ToString();
                }
                else if (view.FocusedColumn.FieldName == "DuocPhepChot")
                {
                    bool bDisableIn = PMS.Common.XuLyGiaoDien.DisableCellRows(view, "IdChucNang", view.FocusedRowHandle, "");//dùng cho in thanh lý 
                    if (bDisableIn)
                        e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                
            }
            
        }
    }
}