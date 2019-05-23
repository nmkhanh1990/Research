﻿using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using PMS.Entities;
using PMS.UI.Forms.BaoCao;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.Common
{
    public static class XuLyGiaoDien
    {
        /// <summary>
        /// In 
        /// </summary>
        public static DataTable LayDuLieuIn(GridView gridViewThongKe, BindingSource bindingsourceThongKe)
        {
            Cursor.Current = Cursors.WaitCursor;

            gridViewThongKe.FocusedRowHandle = -1;
            //bindingSourceThongKe.EndEdit();
            DataTable data = bindingsourceThongKe.DataSource as DataTable;

            if (data == null)
                return null;
            DataTable vListBaoCao = data;
            if (vListBaoCao == null)
                return null;

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

            string filter = gridViewThongKe.ActiveFilterString;
            if (filter.Contains(".0000m"))
                filter = filter.Replace(".0000m", "");
            if (filter.Contains(".000m"))
                filter = filter.Replace(".000m", "");
            if (filter.Contains(".00m"))
                filter = filter.Replace(".00m", "");
            if (filter.Contains(".0m"))
                filter = filter.Replace(".0m", "");
            if (filter.Contains(".m"))
                filter = filter.Replace(".m", "");

            if (gridViewThongKe.ActiveFilter == null || ! gridViewThongKe.ActiveFilterEnabled
                || gridViewThongKe.ActiveFilter.Expression == "")
                return data;

            DataView dv = new DataView(data);
            dv.RowFilter = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(gridViewThongKe.ActiveFilterCriteria);

            vListBaoCao = dv.ToTable();
            if (vListBaoCao == null)
                return null;

            vListBaoCao.AcceptChanges();
            Cursor.Current = Cursors.Default;

            return vListBaoCao;
        }

        public static DataTable LayDuLieuIn(GridView gridViewThongKe, DataTable data)
        {
            Cursor.Current = Cursors.WaitCursor;

            gridViewThongKe.FocusedRowHandle = -1;

            if (data == null)
                return null;
            DataTable vListBaoCao = data;
            if (vListBaoCao == null)
                return null;

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

            vListBaoCao = LayDuLieuFilter(gridViewThongKe, data);
            if (vListBaoCao == null)
                return null;

            vListBaoCao.AcceptChanges();           
            Cursor.Current = Cursors.Default;

            return vListBaoCao;
        }

        public static DataTable LayDuLieuFilter(GridView gridViewThongKe, DataTable data)
        {
            string filter = gridViewThongKe.ActiveFilterString;
            if (filter.Contains(".0000m"))
                filter = filter.Replace(".0000m", "");
            if (filter.Contains(".000m"))
                filter = filter.Replace(".000m", "");
            if (filter.Contains(".00m"))
                filter = filter.Replace(".00m", "");
            if (filter.Contains(".0m"))
                filter = filter.Replace(".0m", "");
            if (filter.Contains(".m"))
                filter = filter.Replace(".m", "");

            if (gridViewThongKe.ActiveFilter == null || !gridViewThongKe.ActiveFilterEnabled
                || gridViewThongKe.ActiveFilter.Expression == "")
                return data;

            DataView dv = new DataView(data);
            dv.RowFilter = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(gridViewThongKe.ActiveFilterCriteria);

            return dv.ToTable();
        }

        public static void ThongBao(string message, MessageBoxIcon icon, bool useDevExpress)
        {
            string title;
            switch (icon)
            {
                case MessageBoxIcon.Information:
                    title = "Thông báo";
                    break;
                case MessageBoxIcon.Warning:
                    title = "Cảnh báo";
                    break;
                case MessageBoxIcon.Error:
                    title = "Lỗi";
                    break;
                default:
                    title = "";
                    break;
            }
            if (useDevExpress)
            {
                XtraMessageBox.Show(message, title, MessageBoxButtons.OK, icon);
            }
            else
            {
                MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
            }
        }

        public static void ThongBao(string title, string message, MessageBoxIcon icon, bool useDevExpress)
        {
            if (useDevExpress)
            {
                XtraMessageBox.Show(message, title, MessageBoxButtons.OK, icon);
            }
            else
            {
                MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
            }
        }

        public static void ThongBaoLoi(Exception ex, bool useDevExpress)
        {
            string message;
            if (ex.Message.Contains("is being used by another process"))
            {
                message = "Tập tin hoặc ứng dụng đang mở. Hãy đóng lại trước khi thực hiện thao tác này.";
            }
            else if (ex.Message.Contains("number") && ex.Message.Contains("format"))
            {
                message = "Không thể chuyển đổi chữ sang số.";
            }
            else if (ex.Message.Contains("no DataRow"))
            {
                message = "Không có dòng dữ liệu nào.";
            }
            else
            {
                message = ex.Message + "\n" + ex.StackTrace;
            }
            if(useDevExpress)
            {
                XtraMessageBox.Show(message, "Lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(message, "Lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool cheked(GridView dv,string strColumns)
        {
            bool bchk = false;
            for (int i = 0; i < dv.DataRowCount; i++)
            {
                bool btemp = (bool)dv.GetRowCellValue(i, strColumns);
                if(btemp)
                {
                    bchk = true;
                    break;
                }
            }
            return bchk;
        }

        public static void CheckAll(GridView gv, string strColumns, bool bchk)
        {
            for (int i = 0; i < gv.DataRowCount; i++)
            {
                gv.SetRowCellValue(i, strColumns, bchk);
            }
        }

        public static int CountCheckedl(GridView gv, string strColumns, bool bchk)
        {
            int icountchecked = 0;
            for (int i = 0; i < gv.DataRowCount; i++)
            {
                if (Convert.ToBoolean(gv.GetRowCellValue(i, strColumns).ToString()) == bchk)
                    icountchecked = icountchecked + 1;
            }
            return icountchecked;
        }

        public static int CheckedIn(GridView gv, string strColumns)
        {
            int iCheck = 0;
            if (gv.DataRowCount == 0)
            {
                iCheck = 2;
            }
            else
            {
                for (int i = 0; i < gv.DataRowCount; i++)
                {
                    bool b = Convert.ToBoolean(gv.GetRowCellValue(i, strColumns));
                    if (b == true)
                    {
                        iCheck = 1;
                        break;
                    }
                }
            }
            return iCheck;

        }

        public static void SelectedIndexChanged(object sender, System.EventArgs e,DevExpress.XtraBars.BarButtonItem btnEdit)
        {
            RadioGroup edit = sender as RadioGroup;
            if (edit.SelectedIndex < 0) btnEdit.Enabled = false;
            else btnEdit.Enabled = true;
        }
        
        public static void AddControl(PanelControl pnlCtrl)
        {
            PMS.PMS_Control.ucNamHocHocKy ucctrl = new PMS_Control.ucNamHocHocKy();
            pnlCtrl.Width = ucctrl.Width;
            pnlCtrl.Height = ucctrl.Height;
            pnlCtrl.Controls.Add(ucctrl);

        }

        public static void  GetTitleTable( ref List<string> strIdColumns,ref List<string> strFileColumns,ref List<int> iSize, string strMaTruong,string strIdFrom)
        {
            TList<TieuDe> lstTieuDe = Services.DataServices.TieuDe.GetAll();            
            for (int i = 0; i < lstTieuDe.Count; i++)
            {
                if(CheckColumnTitle(lstTieuDe[i].MaTruong,strMaTruong)==1)
                {
                    if (CheckColumnTitle(lstTieuDe[i].IdFrom, strIdFrom) == 1)
                    {                        
                        strIdColumns.Add(lstTieuDe[i].IdFileName);
                        strFileColumns.Add(lstTieuDe[i].IdTitleVn);
                        iSize.Add((int)lstTieuDe[i].IdSize);
                        
                    }
                }
            }           
        }

        private static int CheckColumnTitle(string strIDColumns,string strID)
        {
            int iResult = 0;
            string[] LstColumns = PMS.Common.XuLySo.GetLstSplit(strIDColumns, ';');
            for (int i = 0; i < LstColumns.Length; i++)
            {
                if(LstColumns[i].ToString().Contains(strID))
                {
                    iResult = 1;
                    break;
                }
            }
            return iResult;
        }

        public static int GetTotalItems(string strMaTruong, string strIdFrom)
        {
            TList<TieuDe> lstTieuDe = Services.DataServices.TieuDe.GetAll();
            int iResult = 1;
            for (int i = 0; i < lstTieuDe.Count; i++)
            {
                if (CheckColumnTitle(lstTieuDe[i].MaTruong, strMaTruong) == 1)
                {
                    if (CheckColumnTitle(lstTieuDe[i].IdFrom, strIdFrom) == 1)
                    {
                        iResult += i;
                    }
                }
            }
            return iResult;
        }

        public static string GetHocKy(GridLookUpEdit cbo, CheckedComboBoxEdit chkcbo,string strMaTruong)
        {
            string strChuoi = string.Empty;
            object objTemp = new object();
            if (strMaTruong == "HBU")
                strChuoi= chkcbo.EditValue.ToString();
            else
                strChuoi= cbo.EditValue.ToString();
            return strChuoi;
        }

        public static bool RuleCheckDuplicate(GridView grd,string strMaLop)
        {
            bool bResult = false;
            for (int i = 0; i < grd.RowCount; i++)
            {
                if(grd.GetRowCellValue(i,"MaLop").ToString()==strMaLop)
                {
                    bResult = true;
                    break;
                }
            }
            return bResult;
        }

        public static DataTable CreateTable(string[]LstColumns)
        {
            DataTable tbl = new DataTable();
            for (int i = 0; i < LstColumns.Length; i++)
            {
                tbl.Columns.Add(LstColumns[i].ToString(), LstColumns[i].ToString() != "Chon" ? typeof(string) : typeof(bool));
            }
            return tbl;
        }

        public static DataTable CreateFromTable(DataTable LstColumns)
        {
            DataTable tbl = new DataTable();
            foreach (DataColumn item in LstColumns.Columns)
            {
                
                tbl.Columns.Add(item.ColumnName.ToString(), item.ColumnName.ToString() != "XacNhan" ? typeof(string) : typeof(bool));

            }
            return tbl;
        }

        public static DataTable AddRowFromTable( DataTable LstColumns)
        {
            DataTable tbl = PMS.Common.XuLyGiaoDien.CreateFromTable(LstColumns);
            foreach (DataRow drItems in LstColumns.Rows)
            {
                DataRow dr = tbl.NewRow();
                foreach (DataColumn item in tbl.Columns)
                {
                    dr[item.ColumnName.ToString()] = drItems[item.ColumnName.ToString()];
                }
                tbl.Rows.Add(dr);
            }
            
            return tbl;
        }

        public static DataRow AddRow(DataTable LstColumns,DataRow[] dv)
        {
            DataRow dr = LstColumns.NewRow();
            foreach (DataRow drItems in dv)
            {               
                foreach (DataColumn item in LstColumns.Columns)
                {
                    dr[item.ColumnName] = drItems[item.ColumnName];
                }               
            }

            return dr;
        }


        public static DataTable AddRowFromListColumn(string[] LstTileColumns,DataTable LstColumns)
        {
            DataTable tbl = PMS.Common.XuLyGiaoDien.CreateTable(LstTileColumns);
            foreach (DataRow drItems in LstColumns.Rows)
            {
                DataRow dr = tbl.NewRow();
                foreach (DataColumn item in tbl.Columns)
                {
                    dr[item.ColumnName.ToString()] = drItems[item.ColumnName.ToString()];
                }
                tbl.Rows.Add(dr);
            }

            return tbl;
        }


        public static int CheckMaTruong(string strMaTruong, string strTenTruong)
        {
            int icheck = 0;
            if (strMaTruong != "VHU" || strTenTruong == "Trường Đại Học Yersin")
                icheck = 1;
            else if (strMaTruong == "VHU" && strTenTruong != "Trường Đại Học Yersin")
                icheck = 0;
            return icheck;
        }

        public static string ConvertMMDDYYYY(string strDate)
        {
            string strResult = string.Empty;
            string[] LstDate = strDate.Split('/');
            strResult = LstDate[1] + "/" + LstDate[0] + "/" + LstDate[2];
            return strResult;
        }

        public static bool DisableCellRows(GridView view, string strColumnName, int row, string strValue)
        {
            GridColumn col = view.Columns[strColumnName];
            string val = Convert.ToString(view.GetRowCellValue(row, col));
            return (val == strValue);
        }

        public static DataTable GetAllDataGridView(GridView grv)
        {
            DataTable tbl = new DataTable();
            foreach (GridColumn item in grv.Columns)
            {
                tbl.Columns.Add(item.FieldName.ToString(), typeof(string));
            }
            for (int i = 0; i < grv.RowCount; i++)
            {
                DataRow drItem = tbl.NewRow();
                foreach (var item in tbl.Columns)
                {
                    if (grv.GetRowCellValue(i, item.ToString()).ToString() != string.Empty)
                        drItem[item.ToString()] = PMS.Common.XuLyChuoi.ReplaceCharacter(grv.GetRowCellValue(i, item.ToString()).ToString(), "'", "");
                }
                tbl.Rows.Add(drItem);
            }
            return tbl;
        }

        public static int ChekEixstsItemOnTable(DataTable dbTable, string strColumnsName, string strColumnValue)
        {
            int iResult = -1;
            string[] LstColumnName = strColumnsName.Split(';');
            string[] LstColumnValue = strColumnValue.Split(';');
            int ii = 0;
            foreach (DataRow itemrow in dbTable.Rows)
            {
                for (int i = 0; i < LstColumnName.Length; i++)
                {
                    if (itemrow[LstColumnName[i].ToString()].ToString().ToUpper() == LstColumnValue[i].ToUpper())
                    {
                        iResult = ii;
                    }
                }
                ii = ii + 1;
            }
            return iResult;
        }



    }
}
