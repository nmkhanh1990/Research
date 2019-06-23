using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using DevExpress.XtraGrid.Views.Grid;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThongKeTietNoKyTruoc : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong, _cauHinhHeSoTheoNam;
        VList<ViewGiangVien> _listGiangVien;
        TList<TrangThaiGiangVien> lstTTGV;
        List<string> LstIdMaGV = new List<string>();
        List<int> LstIndexReadOnly;
        #endregion
        public ucThongKeTietNoKyTruoc()
        {
            InitializeComponent();
            _maTruong =PMS.Common.Globals.GetMaTruong(_cauHinhChung,"Mã trường");
            _cauHinhHeSoTheoNam = PMS.Common.Globals.GetMaTruong(_cauHinhChung,"Cấu hình các hệ số tính giờ giảng theo năm");
        }

        private void GetAllTrangThaiGiangVien()
        {
            lstTTGV = PMS.Common.KiemTraDuLieuDoiTuong.GetAllTTGV(string.Empty, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void ToMau(VList< ViewTietNoKyTruoc> tbl)
        {            
            LstIdMaGV.Clear();
            for (int i = 0; i < tbl.Count; i++)
            {
                string strMaQuanLy = _listGiangVien.Find(p => p.MaGiangVien.ToString() == tbl[i].MaGiangVien.ToString()).MaQuanLy;

                bool bchk = AppGridControl.chkKhoa(lstTTGV, strMaQuanLy);
                if (bchk)
                {
                    if (LstIdMaGV.Count == 0)
                        LstIdMaGV.Add(strMaQuanLy);
                    else
                    {
                        for (int j = 0; j < LstIdMaGV.Count; j++)
                        {
                            if (LstIdMaGV[j].ToString() != strMaQuanLy)
                                LstIdMaGV.Add(strMaQuanLy);
                        }
                    }
                }

            }
        }

        private void ucThongKeTietNoKyTruoc_Load(object sender, EventArgs e)
        {
            #region Init Gridview
            switch (_maTruong)
            {
                case "ACT":
                    InitGridACT();
                    break;
                default:
                    InitRemaining();
                    break;
            }
            #endregion
            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion
            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenDonVi" }, new string[] { "Mã giảng viên", "Họ tên", "Đơn vị" });
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion
            InitData();
        }

        #region InitGridView
        void InitGridACT()
        {
            AppGridView.InitGridView(gridViewNoKyTruoc, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewNoKyTruoc, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewNoKyTruoc, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "SoTietNoKyTruoc", "TietNoKhac", "NgayCapNhat", "NguoiCapNhat" },
                                                           new string[] { "Mã giảng viên", "Họ tên", "Đơn vị", "Số tiết nợ kỳ trước", "Số tiết nợ khác", "NgayCapNhat", "NguoiCapNhat" },
                                                           new int[] { 120, 150, 200, 130, 130, 99, 99 });
            AppGridView.AlignHeader(gridViewNoKyTruoc, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "SoTietNoKyTruoc", "TietNoKhac", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewNoKyTruoc, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.HideField(gridViewNoKyTruoc, new string[] { "NgayCapNhat", "NguoiCapNhat" });
        }

        void InitRemaining()//UEL, IUH, BUH
        {
            AppGridView.InitGridView(gridViewNoKyTruoc, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewNoKyTruoc, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "SoTietNoKyTruoc", "NgayCapNhat", "NguoiCapNhat" },
                                                           new string[] { "Mã giảng viên", "Họ tên", "Đơn vị", "Số tiết nợ kỳ trước", "NgayCapNhat", "NguoiCapNhat" },
                                                           new int[] { 120, 150, 200, 130, 99, 99 });
            AppGridView.AlignHeader(gridViewNoKyTruoc, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "SoTietNoKyTruoc", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewNoKyTruoc, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.HideField(gridViewNoKyTruoc, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.ReadOnlyColumn(gridViewNoKyTruoc);
            AppGridView.SummaryField(gridViewNoKyTruoc, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewNoKyTruoc, "SoTietNoKyTruoc", "{0}", DevExpress.Data.SummaryItemType.Sum);
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }
        #endregion

        #region InitData
        void InitData()
        {
            _listGiangVien = DataServices.ViewGiangVien.GetAll();
            bindingSourceGiangVien.DataSource = _listGiangVien;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlNoKyTruoc.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
        }

        private void gridViewNoKyTruoc_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (_maTruong == "BUH")
            {
                LstIndexReadOnly = new List<int>();
                GridView View = sender as GridView;
                string MaQuanLy = View.GetRowCellDisplayText(e.RowHandle, View.Columns["MaGiangVien"]);
                for (int i = 0; i < LstIdMaGV.Count; i++)
                {
                    if (LstIdMaGV[i].ToString() == MaQuanLy)
                    {
                        LstIndexReadOnly.Add(e.RowHandle);
                        e.Appearance.BackColor = Color.GreenYellow;

                    }
                }
            }
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceNoKyTruoc.DataSource = DataServices.ViewTietNoKyTruoc.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                if(_maTruong=="BUH")
                {
                    VList<ViewTietNoKyTruoc> tbl = bindingSourceNoKyTruoc.DataSource as VList<ViewTietNoKyTruoc>;
                    GetAllTrangThaiGiangVien();
                    ToMau(tbl);
                }
            }
        }
    }
}
