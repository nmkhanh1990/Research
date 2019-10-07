using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Windows.Forms;
using DevExpress.Utils;
using PMS.UI.Forms.NghiepVu;

namespace PMS.Common
{
    class XuLyTapTin
    {
        private static StreamWriter STREAM_WRITER;

        #region Text file
        /// <summary>
        /// Tạo stream đến tập tin txt.
        /// </summary>
        /// <param name="fileName">Tên tập tin (bao gồm đường dẫn và phần mở rộng).</param>
        /// <returns> StreamWriter để bắt đầu ghi dữ liệu. </returns>
        public static void OpenTextFileForWrite(string fileName)
        {
            STREAM_WRITER = new StreamWriter(fileName);
        }

        /// <summary>
        /// Ghi chuỗi vào tập tin đang mở.
        /// </summary>
        /// <param name="text">Dữ liệu cần ghi.</param>
        public static void WriteTextFile(string text)
        {
            STREAM_WRITER.Write(text);
        }

        /// <summary>
        /// Đóng stream của tập tin đang mở.
        /// </summary>
        public static void CloseCurrentTextFile()
        {
            STREAM_WRITER.Close();
        }
        #endregion

        #region Excel file
        public static DataTable LoadExcelFile()
        {
            DataTable dt = new DataTable();
            OpenFileDialog dialog = new OpenFileDialog { Filter = "Excel Workbook (*.xls)|*.xls", Multiselect = false, ValidateNames = true };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                DevExpress.Common.SQLHelper.Helper helper =
                    new DevExpress.Common.SQLHelper.Helper(String.Format("Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0};Extended Properties={1}Excel 8.0;Imex=2;HDR=yes{1}"
                        , dialog.FileName, Convert.ToChar(34)));
                DataTable schemaData = helper.GetOleDbSchemaTable();
                if (schemaData == null || schemaData.Rows.Count < 1)
                    return null;
                dt = helper.FillDataTable(String.Format("Select * From [{0}]", schemaData.Rows[0]["TABLE_NAME"]));
                //frmDinhDangCot frm = new frmDinhDangCot(dt, schemaData, helper);
                //frm.ShowDialog();
                //DataTable dtcol = frm.dt;
                //DataTable table = frm.dtChon;
                //if (table == null)
                //    return null;
                //using (WaitDialogForm wait = new WaitDialogForm("Loading data ..."))
                //{
                //    try
                //    {
                //        if (table != null)
                //        {
                //            dt.Rows.Clear();
                //            foreach (DataRow dr in table.Rows)
                //            {
                //                DataRow drdulieu = dt.NewRow();
                //                int i = 0;
                //                foreach (DataRow drcol in dtcol.Rows)
                //                {
                //                    if (drcol["Name"].ToString() == " ")
                //                        continue;
                //                    if (!string.IsNullOrEmpty(drcol["Name"].ToString()))
                //                    {
                //                        drdulieu[drcol["colDataBase"].ToString()] = dr[drcol["Name"].ToString()].ToString() == string.Empty ? null : dr[drcol["Name"].ToString()].ToString();
                //                        i = 1;
                //                    }
                //                }
                //                if (i == 1)
                //                {
                //                    dt.Rows.Add(drdulieu);
                //                }
                //            }
                //        }
                //    }
                //    catch (Exception ex)
                //    {
                //        XuLyGiaoDien.ThongBaoLoi(ex, true);
                //    }
                //    finally
                //    {
                //        wait.Close();
                //    }
                //}
            }
            //Loại bỏ dòng trống:
            
            return XuLyTapHop.LoaiBoDongTrong(dt);
        }
        #endregion
    }
}
