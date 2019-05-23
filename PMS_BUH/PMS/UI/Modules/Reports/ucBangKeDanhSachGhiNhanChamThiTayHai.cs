﻿using System;
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
using PMS.UI.Forms.BaoCao;
using PMS.BLL;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using DevExpress.XtraGrid.Columns;
using PMS.UI.Forms.NghiepVu.ChucNangCon;
using DevExpress.XtraGrid.Views.Grid;
using PMS.Common;

namespace PMS.UI.Modules.Reports
{
    public partial class ucBangKeDanhSachGhiNhanChamThiTayHai : DevExpress.XtraEditors.XtraUserControl
    {

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        DateTime _ngayIn;
        bool userRole = true;
        string _groupName = UserInfo.GroupName;
        string strThueTNCN = "0";
        #endregion

        #region Event Form
        public ucBangKeDanhSachGhiNhanChamThiTayHai()
        {
            InitializeComponent();
            _maTruong = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Mã trường");

        }


        private void ucBangKeVuotGioGiangCLC_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "XacNhanChiTra", "ChonIn", "STT", "MaQuanLy", "HoTen", "TenKhoa","MaLopHocPhan", "TenHoatDong","SoTietDaiTra","DonGiaDaiTra", "SoTietClc", "DonGiaClc", "ThanhTienDaiTra", "ThanhTienClc","TongTien", "ThueTNCN", "SoTienThanhToan", "KyNhan" }
                    , new string[] { "Xác nhận chi trả", "Chọn in", "STT", "Mã giảng viên", "Họ tên", "Đơn vị","Lớp học phần", "Tên hoạt động", "Số tiết đại trà", "Đơn giá đại trà","Số tiết clc","Đơn giá clc", "Thành tiền đại trà", "Thành tiền clc","Tổng tiền", "Thuế TNCN", "Số tiền thanh toán", "Ký nhận" }
                    , new int[] { 50, 50, 60, 100, 120, 130,120, 150, 70, 70, 70, 70, 90, 90,100, 100,100, 120 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "XacNhanChiTra", "ChonIn", "STT", "MaQuanLy", "HoTen", "TenKhoa", "MaLopHocPhan", "TenHoatDong", "SoTietDaiTra", "DonGiaDaiTra", "SoTietClc", "DonGiaClc", "ThanhTienDaiTra", "ThanhTienClc", "ThueTNCN", "TongTien", "KyNhan" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewThongKe, "DonGiaDaiTra", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThanhTienDaiTra", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "DonGiaClc", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThanhTienClc", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThueTNCN", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TongTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "SoTienThanhToan", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.HideField(gridViewThongKe, new string[] { "STT" });
            AppGridView.ReadOnlyColumn(gridViewThongKe);//, new string[] { "STT", "MaQuanLy", "HoTen", "TenKhoa", "MaLopHocPhan", "TenHoatDong", "SoTietDaiTra", "DonGiaDaiTra", "SoTietClc", "DonGiaClc", "ThanhTienDaiTra", "ThanhTienClc", "TongTien", "KyNhan" });
            AppGridView.AllowEditColumn(gridViewThongKe, new string[] { "ThueTNCN", "XacNhanChiTra", "ChonIn" });
            AppGridView.FixedField(gridViewThongKe, new string[] { "XacNhanChiTra", "ChonIn", "STT", "MaQuanLy", "HoTen", "TenKhoa" }, FixedStyle.Left);
            PMS.Common.Globals.WordWrapHeader(gridViewThongKe, 45);
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cbo_NamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cbo_NamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cbo_NamHoc.Properties.ValueMember = "NamHoc";
            cbo_NamHoc.Properties.DisplayMember = "NamHoc";
            cbo_NamHoc.Properties.NullText = string.Empty;
            cbo_NamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cbo_HocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cbo_HocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cbo_HocKy.Properties.ValueMember = "MaHocKy";
            cbo_HocKy.Properties.DisplayMember = "TenHocKy";
            cbo_HocKy.Properties.NullText = string.Empty;
            cbo_HocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region Khoa bộ môn
            AppGridLookupEdit.InitGridLookUp(cbo_DonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cbo_DonVi, new string[] { "MaBoMon", "TenBoMon" }, new string[] { "Mã bộ môn", "Tên bộ môn" });
            cbo_DonVi.Properties.DisplayMember = "TenBoMon";
            cbo_DonVi.Properties.ValueMember = "MaBoMon";
            cbo_DonVi.Properties.NullText = string.Empty;


            #region _LoaiHoatDongNgoaiGiangDay
            //AppGridLookupEdit.InitGridLookUp(cbo_HoatDong, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            //AppGridLookupEdit.ShowField(cbo_HoatDong, new string[] { "TenHoatDong" }, new string[] { "Tên hoạt động" });
            //cbo_HoatDong.Properties.DisplayMember = "TenHoatDong";
            //cbo_HoatDong.Properties.ValueMember = "MaHoatDong";
            #endregion
            #endregion


            InitData();
        }
        #endregion Them


        #region InitData()
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cbo_NamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cbo_NamHoc.EditValue.ToString());

            #region Init Khoa-DonVi
            cbo_DonVi.DataBindings.Clear();
            VList<ViewKhoaBoMon> _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                if (_groupName == v.MaBoMon)
                {
                    _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetByMaBoMon(_groupName);
                    break;
                }
                else
                {
                    _vListKhoaBoMon.Add(new ViewKhoaBoMon() { ThuTu = 0, MaBoMon = "-1", TenBoMon = "[Tất cả]" });
                    break;
                }
            }
            bindingSourceKhoaDonVi.DataSource = _vListKhoaBoMon;
            bindingSourceKhoaDonVi.Sort = "ThuTu";
            cbo_DonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaBoMon", true, DataSourceUpdateMode.Never);
            #endregion

            #region Init LoaiGiangVien
            //cbo_HoatDong.DataBindings.Clear();
            //VList<ViewGiangVienHoatDongNgoaiGiangDay> _VListHoatDongNgoaiGiangDay = DataServices.ViewGiangVienHoatDongNgoaiGiangDay.GetAll();
            //_VListHoatDongNgoaiGiangDay.Add(new ViewGiangVienHoatDongNgoaiGiangDay() { MaHoatDong = -1, TenHoatDong = "[Tất cả]" });
            //bindingSourceMaHoatDong.DataSource = _VListHoatDongNgoaiGiangDay;
            //bindingSourceMaHoatDong.Sort = "MaHoatDong";
            //cbo_HoatDong.DataBindings.Add("EditValue", bindingSourceMaHoatDong, "MaHoatDong", true, DataSourceUpdateMode.Never);
            InitHoatDong();
            #endregion
        }
        #endregion

        void InitHoatDong()
        {
            cbo_HoatDong.Properties.SelectAllItemCaption = "Tất cả";
            cbo_HoatDong.Properties.TextEditStyle = TextEditStyles.Standard;
            cbo_HoatDong.Properties.Items.Clear();
            TList<HoatDongNgoaiGiangDay> _ListHDNGD= DataServices.HoatDongNgoaiGiangDay.GetAll();
            _ListHDNGD.Sort("MaQuanLy");
            List<CheckedListBoxItem> listHD = new List<CheckedListBoxItem>();
            for (int i = 0; i < _ListHDNGD.Count; i++)
            {
                listHD.Add(new CheckedListBoxItem(_ListHDNGD[i].MaQuanLy
                    , String.Format("{0} - {1}", _ListHDNGD[i].MaQuanLy, _ListHDNGD[i].TenHoatDong)
                    , CheckState.Unchecked, true));
            }
            cbo_HoatDong.Properties.Items.AddRange(listHD.ToArray());
            cbo_HoatDong.Properties.SeparatorChar = ';';
            cbo_HoatDong.CheckAll();
        }

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (frmChonNgay frmChon = new frmChonNgay())
            {
                frmChon.ShowDialog();
                DateTime dt = frmChon.NgayIn;
                if (dt.ToString("dd/MM/yyyy") == "01/01/0001")
                    return;
                _ngayIn = frmChon.NgayIn;
            }
            gridViewThongKe.FocusedRowHandle = -1;
            bindingSourceThongKe.EndEdit();
            DataTable data = bindingSourceThongKe.DataSource as DataTable;
            if (data == null)
                return;
            DataTable vListBaoCao;
            try
            {
                vListBaoCao = data.Select("ChonIn=True").CopyToDataTable();
            }
            catch
            {
                XtraMessageBox.Show("Hiện tại dữ liệu chưa có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewThongKe.SortedColumns)
                    {
                        switch (c.SortOrder)
                        {
                            case DevExpress.Data.ColumnSortOrder.Ascending:
                                sort += string.Format("{0} ASC, ", c.FieldName);
                                break;
                            case DevExpress.Data.ColumnSortOrder.Descending:
                                sort += string.Format("{0} DESC, ", c.FieldName);
                                break;
                        }
                    }
                }
                if (sort != "")
                    sort = sort.Substring(0, sort.Length - 2);
            }
            vListBaoCao.AcceptChanges();
            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    string xmlData = "";
                    foreach (DataRow r in vListBaoCao.Rows)
                    {
                        xmlData += "<Professors MaGiangVien= \"" + r["MaQuanLy"] + "\" />";
                    }
                    xmlData = "<Root>" + xmlData + "</Root>";
                    DataTable dbTable = new DataTable();
                    dbTable.Load(DataServices.GiangVienHoatDongNgoaiGiangDay.GetDanhSachThanhToanChamThiTayHai(xmlData, cbo_NamHoc.EditValue.ToString(), cbo_HocKy.EditValue.ToString(), cbo_DonVi.EditValue.ToString(), cbo_HoatDong.EditValue.ToString()));
                    frm.InBangKeThanhToanChamThiTayHai(dbTable, UserInfo.UserName, _ngayIn);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    if (sf.FileName != "")
                    {
                        gridControlThongKe.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void btnLocChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                InitShowData(cbo_NamHoc.EditValue.ToString(), cbo_HocKy.EditValue.ToString()
                    , cbo_DonVi.EditValue.ToString(), cbo_HoatDong.EditValue.ToString(), false);
                btnIn.Enabled = false;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                XuLyGiaoDien.ThongBaoLoi(ex, true);
            }
        }

        private void btnLocTongHop_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                InitShowData(cbo_NamHoc.EditValue.ToString(), cbo_HocKy.EditValue.ToString()
                    , cbo_DonVi.EditValue.ToString(), cbo_HoatDong.EditValue.ToString(), true);
                btnIn.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                XuLyGiaoDien.ThongBaoLoi(ex, true);
            }
        }

        #endregion

        void InitShowData(string strNamHoc, string strHocKy, string strKhoa, string strMaHoatDong, bool loc_tong_hop)
        {
            DataTable dtData = new DataTable();

            IDataReader idr;
            if (loc_tong_hop)
            {
                idr = DataServices.GiangVienHoatDongNgoaiGiangDay.GetThanhToanTongHopChamThiTayHai(strNamHoc, strHocKy, strKhoa, strMaHoatDong);
            }
            else
            {
                idr = DataServices.GiangVienHoatDongNgoaiGiangDay.GetThanhToatChamThiTayHai(strNamHoc, strHocKy, strKhoa, strMaHoatDong);
            }
            
            dtData.Load(idr);
            dtData.Columns["ChonIn"].ReadOnly = false;
            dtData.Columns["ThueTNCN"].ReadOnly = false;
            dtData.Columns["XacNhanChiTra"].ReadOnly = false;
            bindingSourceThongKe.DataSource = dtData;
        }

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cbo_NamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cbo_NamHoc.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }

        
        #endregion

        private void chk_ChonInTatCa_CheckedChanged(object sender, EventArgs e)
        {
            PMS.Common.XuLyGiaoDien.CheckAll(gridViewThongKe, "ChonIn", Convert.ToBoolean(chk_ChonInTatCa.EditValue.ToString()));

        }

        private void chk_ChonTatCaChiTra_CheckedChanged(object sender, EventArgs e)
        {
            PMS.Common.XuLyGiaoDien.CheckAll(gridViewThongKe, "XacNhanChiTra", Convert.ToBoolean(chk_ChonTatCaChiTra.EditValue.ToString()));

        }

        private void btn_Luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                gridViewThongKe.FocusedRowHandle = -1;
                DataTable tbl = bindingSourceThongKe.DataSource as DataTable;               
                string strColumnName = "MaGiangVien;MaLopHocPhan;MaHoatDong;SoTietDaiTra;DonGiaDaiTra;SoTietClc;DonGiaClc;ThueTNCN;XacNhanChiTra";
                string strXML = "<Root></Root>";
                int kq = 0;
                strXML = PMS.Common.Globals.GetXMLFromString(tbl, strColumnName, cbo_NamHoc.EditValue.ToString(), cbo_HocKy.EditValue.ToString(), UserInfo.UserName,DateTime.Now.ToString("yyyy-MM-dd"));
                DataServices.ThanhToanTienKhac.LuuXacNhanChiTra(strXML, ref kq);
                if (kq == 0)
                {
                    PMS.Common.XuLyGiaoDien.ThongBao("Thông báo", PMS.Common.ThongBao.Str_LuuThayDoiThanhCong, MessageBoxIcon.Information, true);
                    InitShowData(cbo_NamHoc.EditValue.ToString(), cbo_HocKy.EditValue.ToString(), cbo_DonVi.EditValue.ToString(), cbo_HoatDong.EditValue.ToString(), false);

                }
                else PMS.Common.XuLyGiaoDien.ThongBao("Thông báo", PMS.Common.ThongBao.Str_LuuLoiXayRa, MessageBoxIcon.Error, true);
            }
            catch
            {
                PMS.Common.XuLyGiaoDien.ThongBao("Thông báo", PMS.Common.ThongBao.Str_LoiDuoiCoSoDuLieu, MessageBoxIcon.Error, true);
            }
            InitShowData(cbo_NamHoc.EditValue.ToString(), cbo_HocKy.EditValue.ToString(), cbo_DonVi.EditValue.ToString(), cbo_HoatDong.EditValue.ToString(), false);
            Cursor.Current = Cursors.Default;
        }

        private void gridViewThongKe_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {

            if (gridViewThongKe.FocusedColumn.FieldName == "ThueTNCN")
            {
                strThueTNCN = e.Value.ToString();
                if (strThueTNCN != string.Empty)
                {
                    if (!PMS.Common.XuLySo.KiemTraChuoiToanSo(strThueTNCN))
                    {
                        e.Valid = false;
                        e.ErrorText = PMS.Common.ThongBao.Str_ChiNhapSo;
                    }
                }
            }
        }

        private void gridViewThongKe_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            string strThanhTienHT = "0";
            decimal dSoTienThanhToanKQ = 0;
            if (col.FieldName == "ThueTNCN")
            {
                strThanhTienHT = gridViewThongKe.GetRowCellValue(e.RowHandle, "TongTien").ToString();
                if (strThueTNCN == "0")
                    dSoTienThanhToanKQ = decimal.Parse(strThanhTienHT);
                else
                    dSoTienThanhToanKQ = decimal.Parse(strThanhTienHT) - decimal.Parse(strThueTNCN);
                gridViewThongKe.SetRowCellValue(e.RowHandle, "TongTien", dSoTienThanhToanKQ);
            }
        }

        private void gridViewThongKe_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            bool bThueTNCN = PMS.Common.XuLyGiaoDien.DisableCellRows(view, "XacNhanChiTra", view.FocusedRowHandle, "True");
            if (view.FocusedColumn.FieldName == "ThueTNCN" && bThueTNCN)
                e.Cancel = true;
        }

    }
}
