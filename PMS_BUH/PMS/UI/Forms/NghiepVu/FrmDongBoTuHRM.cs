using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using PMS.Entities;
using PMS.Services;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class FrmDongBoTuHRM : Form
    {
        int iiMoveNext = 0;
        int iCheckexists = -1;

        DataTable tblKetQua = new DataTable();
        DataTable tblHRM = new DataTable();
        DataTable tblPMS = new DataTable();

        public FrmDongBoTuHRM()
        {
            InitializeComponent();
        }

        private void LoadTuDien()
        {
            string[] strListTitle = { "DÂN TỘC", "TÔN GIÁO", "QUỐC TỊCH", "BỘ PHẬN", "HỌC HÀM", "HỌC VỊ", "LOẠI GIẢNG VIÊN", "TÌNH TRẠNG", "CHỨC VỤ", "GIẢNG VIÊN" };
            string[] strListID = { "DanToc", "TonGiao", "QuocTich", "BoPhan", "HocHam", "HocVi", "LoaiGiangVien", "TinhTrang", "ChucVu", "GiangVien" };
            List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();
            for (int i = 0; i < strListTitle.Length; i++)
            {
                list.Add(new CheckedListBoxItem(strListID[i].ToString(), strListTitle[i].ToString(), CheckState.Unchecked, true));
            }
            cbo_DongBo.Properties.Items.AddRange(list.ToArray());
            cbo_DongBo.Properties.SeparatorChar = ';';
        }

        private void FrmDongBoTuHRM_Load(object sender, EventArgs e)
        {
            #region Tiêu đề gridview
            LoadTitle();
            LoadTuDien();
            LoadTblKetQua();
            #endregion
        }

        private void LoadTblKetQua()
        {
            string[] strLstColumn = { "MaQuanLyDuocChon", "TenQuanLyDuocChon", "MaQuanLyDuocBo", "TenQuanLyDuocBo", "STT", "TuDien", "Oid", "LoaiDB", "GhiChu" };
            tblKetQua = PMS.Common.XuLyGiaoDien.CreateTable(strLstColumn);
        }

        private void LoadTitle()
        {
            #region InitGrid Thông Tin Giảng Viên Bên HRM
            AppGridView.InitGridView(gdv_HRM, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gdv_HRM, new string[] { "XacNhan", "MaQuanLy", "TenQuanLy", "STT", "TuDien", "ToMau" }
                , new string[] { "Chọn", "Mã HRM", "Tên HRM", "STT", "Tự Điển", "Tô Màu", "Trạng thái" }
                , new int[] { 100, 100, 180, 100, 180, 100 });
            AppGridView.AlignHeader(gdv_HRM, new string[] { "XacNhan", "MaQuanLy", "TenQuanLy", "STT", "TuDien", "ToMau" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gdv_HRM, "TuDien", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.HideField(gdv_HRM, new string[] { "STT", "ToMau" });
            AppGridView.ReadOnlyColumn(gdv_HRM, new string[] { "MaQuanLy", "TenQuanLy", "STT", "TuDien" });
            gdv_HRM.Columns["TuDien"].GroupIndex = 0;
            gdv_HRM.ExpandAllGroups();
            #endregion

            #region InitGrid Thông Tin Giảng Viên Bên PMS
            AppGridView.InitGridView(gdv_PMS, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gdv_PMS, new string[] { "XacNhan", "MaQuanLy", "MaQuanLyHRM", "TenQuanLy", "STT", "TuDien", "ToMau", "GhiChu" }
                , new string[] { "Chọn", "Mã PMS", "Mã Quản Lý HRM", "Tên PMS", "STT", "Từ Điển", "Tô Màu", "Chú thích" }
                , new int[] { 100, 100, 100, 180, 100, 180, 100, 150 });
            AppGridView.AlignHeader(gdv_PMS, new string[] { "XacNhan", "MaQuanLy", "TenQuanLy", "STT", "TuDien", "ToMau", "MaQuanLyHRM", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gdv_PMS, "TuDien", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.HideField(gdv_PMS, new string[] { "STT", "MaQuanLy", "ToMau" });
            AppGridView.ReadOnlyColumn(gdv_PMS);
            AppGridView.AllowEditColumn(gdv_PMS, new string[] { "XacNhan" });
            gdv_PMS.Columns["TuDien"].GroupIndex = 0;
            gdv_PMS.ExpandAllGroups();
            #endregion


            #region InitGrid Thông Tin KetQua
            AppGridView.InitGridView(gdv_KetQua, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gdv_KetQua, new string[] { "MaQuanLyDuocChon", "TenQuanLyDuocChon", "MaQuanLyDuocBo", "TenQuanLyDuocBo", "STT", "TuDien", "GhiChu", "Xoa" }
                , new string[] { "Mã được chọn", "Tên được chọn", "Mã được bỏ", "Tên được bỏ", "STT", "Từ Điển", "Ghi chú", "Xóa" }
                , new int[] { 100, 180, 100, 180, 100, 180, 100, 50 });
            AppGridView.AlignHeader(gdv_KetQua, new string[] { "MaQuanLyDuocChon", "TenQuanLyDuocChon", "MaQuanLyDuocBo", "TenQuanLyDuocBo", "STT", "TuDien", "GhiChu", "Xoa" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gdv_KetQua, "TuDien", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.HideField(gdv_KetQua, new string[] { "STT", "GhiChu" });
            AppGridView.ReadOnlyColumn(gdv_KetQua, new string[] { "MaQuanLyDuocChon", "TenQuanLyDuocChon", "MaQuanLyDuocBo", "TenQuanLyDuocBo", "STT", "TuDien", "GhiChu" });
            AppGridView.RegisterControlField(gdv_KetQua, "Xoa", repositoryItem_btn_Xoa);
            gdv_KetQua.Columns["TuDien"].GroupIndex = 0;
            #endregion

            #region Hiển Thị Dữ Liệu
            LoadDataBase(string.Empty);
            #endregion
        }

        private void LoadDataBase(string strIDData)
        {
            try
            {
                #region HRM
                DataTable dbDataHRM = new DataTable("DataHRM");
                dbDataHRM.Load(DataServices.GiangVien.LayDuLieuDongBoTuHRM());
                dbDataHRM.Columns["XacNhan"].ReadOnly = false;
                dbDataHRM.Columns.Add("ToMau", typeof(bool));
                foreach (DataRow item in dbDataHRM.Rows)
                {
                    item["ToMau"] = "False";

                }

                #endregion
                #region PMS
                DataTable dbDataPMS = new DataTable("DataPMS");
                dbDataPMS.Load(DataServices.GiangVien.LayDuLieuTuCOREUIS(strIDData));
                dbDataPMS.Columns["XacNhan"].ReadOnly = false;
                dbDataPMS.Columns.Add("ToMau", typeof(bool));
                foreach (DataRow item in dbDataPMS.Rows)
                {
                    item["ToMau"] = "False";
                }
                AddTable(dbDataHRM, dbDataPMS);
                #endregion
            }
            catch (Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
            }
        }

        private void FilterGridView()
        {
            gdv_HRM.ActiveFilterString = "[TrangThai]=False";
            gdv_PMS.ActiveFilterString = "[TrangThai]=False";
        }


        private void cbo_DongBo_EditValueChanged(object sender, EventArgs e)
        {
            if (cbo_DongBo.EditValue.ToString() != string.Empty)
                LoadDataBase(cbo_DongBo.EditValue.ToString());
        }

        private void gdv_HRM_Click(object sender, EventArgs e)
        {
            try
            {
                GridView gv = gdv_HRM as GridView;
                if (gv.FocusedColumn.FieldName != "ToMau")
                {
                    gdv_HRM.SetRowCellValue(gv.FocusedRowHandle, "ToMau", true);
                    string strOid = gv.GetRowCellValue(gv.FocusedRowHandle, "Oid").ToString();
                    string strTenQuanLy = gv.GetRowCellValue(gv.FocusedRowHandle, "TenQuanLy").ToString();
                    string strMaQuanLy = gv.GetRowCellValue(gv.FocusedRowHandle, "MaQuanLy").ToString();
                    int iiflag = 0;
                    SetColor(strOid, strTenQuanLy, strMaQuanLy, ref iiflag);
                    AppGridView.NextPrev(gdv_PMS, gv.FocusedRowHandle, iiflag, ref iiMoveNext);
                    iiMoveNext = gdv_PMS.FocusedRowHandle;
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        /// <summary>
        /// Nếu cùng tên thì tô mau lên để nhân biết
        /// </summary>
        /// <param name="strName"></param>
        private void SetColor(string strOid, string strName, string strMaQuanLy, ref int iiflag)
        {

            //string[] LenthColumn = strName.Split(' ');
            DataTable tblPMS = bindingSource_PMS.DataSource as DataTable;
            DataTable tblHRM = bindingSource_HRM.DataSource as DataTable;
            int ii = 0;
            int iflag = 0;
            foreach (DataRow item in tblPMS.Rows)
            {
                if (item["Oid"].ToString().ToUpper() == strOid.ToUpper()
                     && (strName.ToString().ToUpper() == item["TenQuanLy"].ToString().ToUpper()
                        || strMaQuanLy.ToUpper() == item["MaQuanLy"].ToString().ToUpper()))
                {
                    gdv_PMS.SetRowCellValue(ii, "ToMau", true);
                    iflag = iiflag = ii;
                    AppGridView.GridRowAppearance(gdv_HRM, "ToMau", DevExpress.XtraGrid.FormatConditionEnum.Equal, "True", Color.FromArgb(230, 220, 255));
                    AppGridView.GridRowAppearance(gdv_PMS, "ToMau", DevExpress.XtraGrid.FormatConditionEnum.Equal, "True", Color.FromArgb(230, 220, 255));
                }
                ii = ii + 1;
            }
            for (int i = 0; tblPMS.Rows.Count > tblHRM.Rows.Count ? i < tblPMS.Rows.Count : i < tblHRM.Rows.Count; i++)
            {
                if (i != iflag || iflag == 0)
                {
                    if (i < tblPMS.Rows.Count)
                        gdv_PMS.SetRowCellValue(i, "ToMau", false);
                    gdv_HRM.SetRowCellValue(i, "ToMau", false);
                }
            }

        }

        private void btn_LayTuHRM_Click(object sender, EventArgs e)
        {
            try
            {
                tblPMS.Rows.Clear();
                tblHRM.Rows.Clear();
                LayDBTableFromPMS();
                LayDBTableFromHRM();
                //DBREFESH();
                DataTableKetQua(btn_LayTuHRM.Name.ToString());
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }

        }

        private void DataTableKetQua(string strName)
        {
            #region Codeold
            /*
            DataTable dbTableHRM = bindingSource_HRM.DataSource as DataTable;
            DataTable dbTablePMS = bindingSource_PMS.DataSource as DataTable;
            GridView gdvHRM = gdv_HRM as GridView;
            for (int i = 0; i < gdvHRM.RowCount - 1; i++)
            {
                bool bXachNhan = Convert.ToBoolean(gdvHRM.GetRowCellValue(i, "XacNhan").ToString());
                if (bXachNhan)
                {
                    string strOid = gdvHRM.GetRowCellValue(i, "Oid").ToString();
                    DataRow[] drItemHRM = dbTableHRM.Select("Oid='" + strOid + "'");
                    DataRow[] drItemPMS = dbTablePMS.Select("Oid='" + strOid + "'");
                    foreach (DataRow itemHRM in strName == "btn_LayTuHRM" ? drItemHRM : drItemPMS)
                    {
                        DataRow dr = tblKetQua.NewRow();
                        dr["MaQuanLyDuocChon"] = itemHRM["MaQuanLy"].ToString();
                        dr["TenQuanLyDuocChon"] = itemHRM["TenQuanLy"].ToString();
                        if (strName == "btn_LayTuHRM")
                        {
                            if (drItemPMS.Length > 0)
                            {
                                dr["MaQuanLyDuocBo"] = drItemPMS[0]["MaQuanLyHRM"].ToString();
                                dr["TenQuanLyDuocBo"] = drItemPMS[0]["TenQuanLy"].ToString();
                                dr["LoaiDB"] = "1";
                            }
                            else //Trường hợp bên PMS chưa có 
                            {
                                dr["MaQuanLyDuocBo"] = drItemHRM[0]["MaQuanLy"].ToString();
                                dr["TenQuanLyDuocBo"] = drItemHRM[0]["TenQuanLy"].ToString();
                                dr["LoaiDB"] = "1";
                            }
                        }
                        else
                        {
                            if (drItemHRM.Length > 0)
                            {
                                dr["MaQuanLyDuocBo"] = drItemHRM[0]["MaQuanLy"].ToString();
                                dr["TenQuanLyDuocBo"] = drItemHRM[0]["TenQuanLy"].ToString();
                                dr["LoaiDB"] = "2";
                            }
                        }

                        dr["STT"] = itemHRM["STT"].ToString();
                        dr["TuDien"] = itemHRM["TuDien"].ToString();
                        dr["Oid"] = itemHRM["Oid"].ToString();
                        iCheckexists = PMS.Common.XuLyGiaoDien.ChekEixstsItemOnTable(tblKetQua, "Oid", strOid);
                        if (iCheckexists == -1)
                        {
                            tblKetQua.Rows.Add(dr);
                            //Delete(strOid, dbTableHRM, dbTablePMS);
                        }
                    }
                }
            }*/
            #endregion
            int i = 0;
            foreach (DataRow itemHRM in strName == "btn_LayTuHRM" ? tblHRM.Rows : tblPMS.Rows)
            {
                DataRow dr = tblKetQua.NewRow();
                dr["MaQuanLyDuocChon"] = itemHRM["MaQuanLy"].ToString();
                dr["TenQuanLyDuocChon"] = itemHRM["TenQuanLy"].ToString();
                dr["LoaiDB"] = strName == "btn_LayTuHRM" ? "1" : "2";
                dr["STT"] = itemHRM["STT"].ToString();
                dr["TuDien"] = itemHRM["TuDien"].ToString();
                dr["Oid"] = itemHRM["Oid"] == null ? tblHRM.Rows[i]["Oid"].ToString() : itemHRM["Oid"].ToString();
                dr["MaQuanLyDuocBo"] = strName == "btn_LayTuHRM" ? tblPMS.Rows.Count==0 ? tblHRM.Rows[i]["MaQuanLy"].ToString() : tblPMS.Rows[i]["MaQuanLy"].ToString() : tblHRM.Rows[i]["MaQuanLy"].ToString() ;
                dr["TenQuanLyDuocBo"] = strName == "btn_LayTuHRM" ? tblPMS.Rows.Count == 0 ? tblHRM.Rows[i]["TenQuanLy"].ToString() : tblPMS.Rows[i]["TenQuanLy"].ToString() : tblHRM.Rows[i]["TenQuanLy"].ToString() ;
                dr["GhiChu"] = strName == "btn_LayTuHRM" ? "HRM" : "PMS";
                i = i + 1;
                iCheckexists = PMS.Common.XuLyGiaoDien.ChekEixstsItemOnTable(tblKetQua, "Oid", itemHRM["Oid"].ToString());
                if (iCheckexists == -1)
                {
                    tblKetQua.Rows.Add(dr);
                    //Delete(strOid, dbTableHRM, dbTablePMS);
                }
            }
            LoadDB();
            

            if(tblKetQua.Rows.Count>0)
            {
                Readonlycheck(true);
            }
            else
            {
                Readonlycheck(false);
            }

        }

        void Readonlycheck(bool b)
        {
            chk_ChonTatHRM.ReadOnly = b;
            chk_ChonTatCaPMS.ReadOnly = b;
        }

        private void Delete(string strOid, DataTable dbDataHRM, DataTable dbDataPMS)
        {

            for (int i = 0; i < dbDataHRM.Rows.Count; i++)
            {
                if (dbDataHRM.Rows[i]["Oid"].ToString().ToUpper() == strOid.ToUpper())
                {
                    dbDataHRM.Rows[i].Delete();
                }
            }
            for (int i = 0; i < dbDataPMS.Rows.Count; i++)
            {
                if (dbDataPMS.Rows[i]["Oid"].ToString().ToUpper() == strOid.ToUpper())
                {
                    dbDataPMS.Rows[i].Delete();
                }
            }
            AddTable(dbDataHRM, dbDataPMS);
        }

        private void LoadDataHRM_PMS(DataTable dbHRM, DataTable dbPMS)
        {
            bindingSource_HRM.DataSource = dbHRM;
            bindingSource_PMS.DataSource = dbPMS;
        }

        private void LoadDB()
        {
            bindingSource_KetQua.DataSource = tblKetQua;
        }

        private void btn_DongBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int output = -1;
                Cursor.Current = Cursors.WaitCursor;
                string strXML = "<Root></Root>";
                string strColumn = GetAllColumn(tblKetQua);
                strXML = PMS.Common.Globals.GetXMLFromString(tblKetQua, strColumn);
                if (strXML == "<Root></Root>")
                {
                    PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_ThongBaoDuLieu, MessageBoxIcon.Warning, true);
                    return;
                }
                else
                {
                    DataServices.GiangVien.DongBoTuHRMByDesign(strXML, ref output);
                    if (output == 0)
                    {
                        PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_LuuDongBoThanhCong, MessageBoxIcon.None, true);
                        tblKetQua.Rows.Clear();
                        LoadDB();
                        if (cbo_DongBo.EditValue.ToString() != string.Empty)
                            LoadDataBase(cbo_DongBo.EditValue.ToString());
                        if(tblKetQua.Rows.Count==0)
                        {
                            chk_ChonTatHRM.ReadOnly = false;
                            chk_ChonTatCaPMS.ReadOnly = false;
                        }
                    }
                    else
                        PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_LuuDongBoThatBai, MessageBoxIcon.Warning, true);

                }

                Cursor.Current = Cursors.Default;
            }
            catch
            {
                PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_LuuLoiXayRa + ".......!", MessageBoxIcon.Error, true);
            }
        }

        private string GetAllColumn(DataTable tbl)
        {
            string strChuoi = string.Empty;
            foreach (DataColumn item in tbl.Columns)
            {
                strChuoi = strChuoi + item.ColumnName.ToString() + ";";
            }
            return strChuoi.Substring(0, strChuoi.Length - 1);
        }



        private void btn_LayTuPMS_Click(object sender, EventArgs e)
        {
            try
            {
                tblPMS.Rows.Clear();
                tblHRM.Rows.Clear();
                LayDBTableFromPMS();
                LayDBTableFromHRM();
                //DataTableKetQua(btn_LayTuPMS.Name.ToString());                

                // DBREFESH();

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        private void SetCheckForPMS(string strOid, string strMaQuanLy, string strTenQuanLy, bool bCheck)
        {
            DataTable dbTablePMS = bindingSource_PMS.DataSource as DataTable;
            int i = 0;
            foreach (DataRow item in dbTablePMS.Rows)
            {
                if (item["Oid"].ToString() == strOid && (item["MaQuanLyHRM"].ToString() != strMaQuanLy || item["TenQuanLy"].ToString() != strTenQuanLy))
                {
                    gdv_PMS.SetRowCellValue(i, "XacNhan", bCheck);
                    break;
                }
                i = i + 1;
            }

        }

        private void btn_LamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadTuDien();
            LoadTblKetQua();

        }

        private void gdv_HRM_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                GridView gv = sender as GridView;
                if (gv.FocusedColumn.FieldName == "XacNhan")
                {

                    bool bXachNhan = Convert.ToBoolean(gv.GetRowCellValue(gv.FocusedRowHandle, "XacNhan").ToString());
                    string strOID = gv.GetRowCellValue(gv.FocusedRowHandle, "Oid").ToString();
                    string strMaQuanLy = gv.GetRowCellValue(gv.FocusedRowHandle, "MaQuanLy").ToString();
                    string strTenQuanLy = gv.GetRowCellValue(gv.FocusedRowHandle, "TenQuanLy").ToString();
                    gdv_HRM.SetRowCellValue(e.RowHandle, "XacNhan", e.Value);
                    SetCheckForPMS(strOID, strMaQuanLy, strTenQuanLy, !bXachNhan);


                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        private void repositoryItem_btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                GridView gdv = gdv_KetQua as GridView;
                string strOid = gdv.GetRowCellValue(gdv.FocusedRowHandle, "Oid").ToString();
                AddRow(strOid);
                LoadDB();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }

        }

        private void AddRow(string strOID)
        {
            //DataTable dbDataHRM = bindingSource_HRM.DataSource as DataTable;
            //dbDataHRM.TableName = "DataHRM";

            //DataTable dbDataPMS = bindingSource_PMS.DataSource as DataTable;
            //dbDataPMS.TableName = "DataPMS";


            for (int i = 0; i < tblKetQua.Rows.Count; i++)
            {
                if (tblKetQua.Rows[i]["Oid"].ToString().ToUpper() == strOID.ToUpper())
                {
                    //DataRow drHRM = dbDataHRM.NewRow();
                    //DataRow drPMS = dbDataPMS.NewRow();
                    //drHRM["MaQuanLy"] = tblKetQua.Rows[i]["MaQuanLyDuocChon"].ToString();
                    //drPMS["MaQuanLyHRM"] = tblKetQua.Rows[i]["MaQuanLyDuocBo"].ToString();


                    //drHRM["TenQuanLy"] = tblKetQua.Rows[i]["TenQuanLyDuocChon"].ToString();
                    //drPMS["TenQuanLy"] = tblKetQua.Rows[i]["TenQuanLyDuocBo"].ToString();

                    //drHRM["STT"] = drPMS["STT"] = tblKetQua.Rows[i]["STT"].ToString();
                    //drHRM["TuDien"] = drPMS["TuDien"] = tblKetQua.Rows[i]["TuDien"].ToString();
                    //drHRM["Oid"] = drPMS["Oid"] = tblKetQua.Rows[i]["Oid"].ToString();
                    //drHRM["ToMau"] = drPMS["ToMau"] = "false";
                    //drHRM["XacNhan"] = drPMS["XacNhan"] = "false";               
                    //dbDataHRM.Rows.Add(drHRM);
                    //dbDataPMS.Rows.Add(drPMS);
                    tblKetQua.Rows[i].Delete();
                }
            }
            //AddTable(dbDataHRM, dbDataPMS);

        }

        private void AddTable(DataTable tblHRM, DataTable tblPMS)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(tblHRM);
            ds.Tables.Add(tblPMS);
            ds.AcceptChanges();
            LoadDataHRM_PMS(ds.Tables["DataHRM"], ds.Tables["DataPMS"]);
        }

        private void gdv_HRM_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView grvcolum = sender as GridView;
            int icheck = -1;
            if (grvcolum.FocusedColumn.FieldName == "XacNhan")
            {
                string strOid = grvcolum.GetRowCellValue(grvcolum.FocusedRowHandle, "Oid").ToString();
                icheck = PMS.Common.XuLyGiaoDien.ChekEixstsItemOnTable(tblKetQua, "Oid", strOid);
                if (icheck != -1)
                    e.Cancel = true;
                //if (checkecrowongridview(gdv_HRM) == 2)
                //    e.Cancel = true;
            }
        }

        int checkecrowongridview(GridView gdv)
        {
            int ii = 0;
            for (int i = 0; i < gdv.RowCount; i++)
            {
                bool bXacNhan = Convert.ToBoolean(gdv.GetRowCellValue(i, "XacNhan").ToString());
                if(bXacNhan==true)
                {
                    ii = i+1;
                    break;
                }
            }
            return ii;
        }

        private void chk_ChonTatCaPMS_CheckedChanged(object sender, EventArgs e)
        {
            PMS.Common.XuLyGiaoDien.CheckAll(gdv_PMS, "XacNhan", chk_ChonTatCaPMS.Checked);
        }

        private void chk_ChonTatHRM_CheckedChanged(object sender, EventArgs e)
        {
            PMS.Common.XuLyGiaoDien.CheckAll(gdv_HRM, "XacNhan", chk_ChonTatHRM.Checked);
        }

        private void LayDBTableFromPMS()
        {
            DataTable dbTablePMS = bindingSource_PMS.DataSource as DataTable;
            for (int i = 0; i < dbTablePMS.Rows.Count; i++)
            {
                string strMaQuanLyPMS = string.Empty;
                string strTuDien = string.Empty;
                bool bXachNhan = Convert.ToBoolean(gdv_PMS.GetRowCellValue(i, "XacNhan").ToString());
                if (bXachNhan == true)
                {
                    strMaQuanLyPMS = gdv_PMS.GetRowCellValue(i, "MaQuanLy").ToString();
                    strTuDien = gdv_PMS.GetRowCellValue(i, "TuDien").ToString();
                    DbPMSKetQua(strMaQuanLyPMS, strTuDien);
                }
            }

        }

        private void LayDBTableFromHRM()
        {
            DataTable dbTableHRM = bindingSource_HRM.DataSource as DataTable;
            for (int i = 0; i < dbTableHRM.Rows.Count; i++)
            {
                string strMaQuanLyPMS = string.Empty;
                string strTuDien = string.Empty;
                bool bXachNhan = Convert.ToBoolean(gdv_HRM.GetRowCellValue(i, "XacNhan").ToString());
                if (bXachNhan == true)
                {
                    strMaQuanLyPMS = gdv_HRM.GetRowCellValue(i, "MaQuanLy").ToString();
                    strTuDien = gdv_HRM.GetRowCellValue(i, "TuDien").ToString();
                    DbHRMKetQua(strMaQuanLyPMS, strTuDien);
                }
            }

        }

        private void DbHRMKetQua(string strMaQuanLy, string strTuDien)
        {
            DataTable dbTableHRM = bindingSource_HRM.DataSource as DataTable;
            if (tblHRM.Columns.Count == 0)
                tblHRM = PMS.Common.XuLyGiaoDien.CreateFromTable(dbTableHRM);
            DataRow[] dvRowHRM = dbTableHRM.Select(" MaQuanLy='" + strMaQuanLy + "' And TuDien='" + strTuDien + "'");
            tblHRM.Rows.Add(PMS.Common.XuLyGiaoDien.AddRow(tblHRM, dvRowHRM));
        }

        private void DbPMSKetQua(string strMaQuanLy, string strTuDien)
        {
            DataTable dbTablePMS = bindingSource_PMS.DataSource as DataTable;
            if (tblPMS.Columns.Count == 0)
                tblPMS = PMS.Common.XuLyGiaoDien.CreateFromTable(dbTablePMS);
            DataRow[] dvRowPMS = dbTablePMS.Select(" MaQuanLy='" + strMaQuanLy + "' And TuDien='" + strTuDien + "'");
            tblPMS.Rows.Add(PMS.Common.XuLyGiaoDien.AddRow(tblPMS, dvRowPMS));
        }

        private void DBREFESH()
        {
            DataTable tblRefeshPMS = new DataTable();
            DataTable dbTablePMS = bindingSource_PMS.DataSource as DataTable;

            DataTable tblRefeshHRM = new DataTable();
            DataTable dbTableHRM = bindingSource_HRM.DataSource as DataTable;

            if (tblRefeshPMS.Columns.Count == 0)
                tblRefeshPMS = PMS.Common.XuLyGiaoDien.CreateFromTable(dbTablePMS);
            if (tblRefeshHRM.Columns.Count == 0)
                tblRefeshHRM = PMS.Common.XuLyGiaoDien.CreateFromTable(dbTableHRM);

            //Dữ liệu PMS
            foreach (DataRow item in dbTablePMS.Rows)
            {
                int iflag = 0;
                foreach (DataRow itemketqua in tblPMS.Rows)
                {
                    if (item["MaQuanLy"].ToString() == itemketqua["MaQuanLy"].ToString() && item["TuDien"].ToString() == itemketqua["TuDien"].ToString())
                    {
                        iflag = 1;
                    }
                }
                if (iflag == 0)
                {
                    DataRow[] dvRow = dbTablePMS.Select(" MaQuanLy='" + item["MaQuanLy"].ToString() + "' And TuDien='" + item["TuDien"].ToString() + "'");
                    tblRefeshPMS.Rows.Add(PMS.Common.XuLyGiaoDien.AddRow(tblRefeshPMS, dvRow));
                }
            }

            //Dữ liệu HRM
            foreach (DataRow item in dbTableHRM.Rows)
            {
                int iflag = 0;
                foreach (DataRow itemketqua in tblHRM.Rows)
                {
                    if (item["MaQuanLy"].ToString() == itemketqua["MaQuanLy"].ToString() && item["TuDien"].ToString() == itemketqua["TuDien"].ToString())
                    {
                        iflag = 1;
                    }
                }
                if (iflag == 0)
                {
                    DataRow[] dvRowHRM = dbTableHRM.Select(" MaQuanLy='" + item["MaQuanLy"].ToString() + "' And TuDien='" + item["TuDien"].ToString() + "'");
                    tblRefeshHRM.Rows.Add(PMS.Common.XuLyGiaoDien.AddRow(tblRefeshHRM, dvRowHRM));
                }
            }
            bindingSource_PMS.DataSource = tblRefeshPMS;
            bindingSource_HRM.DataSource = tblRefeshHRM;
        }

        private void gdv_PMS_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView grvcolum = sender as GridView;
            int icheck = -1;
            if (grvcolum.FocusedColumn.FieldName == "XacNhan")
            {
                string strOid = grvcolum.GetRowCellValue(grvcolum.FocusedRowHandle, "Oid").ToString();
                string strTuDien = grvcolum.GetRowCellValue(grvcolum.FocusedRowHandle, "TuDien").ToString();
                if (strOid == string.Empty)
                {
                    foreach (DataRow item in tblHRM.Rows)
                    {
                        strOid = item["Oid"].ToString();
                    }
                }
                icheck = PMS.Common.XuLyGiaoDien.ChekEixstsItemOnTable(tblKetQua, "Oid", strOid);
                if (icheck != -1)
                    e.Cancel = true;
                //if (checkecrowongridview(gdv_PMS) == 2)
                //    e.Cancel = true;
            }
        }
    }
}
